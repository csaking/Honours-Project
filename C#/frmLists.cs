using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;

namespace HonoursApp
{
    public partial class frmLists : Form
    {
        private MySqlDataAdapter ListsDA;
        private MySqlDataAdapter ListContentDA;
        private int previousList;
        public frmLists()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLists_Load(object sender, EventArgs e)
        {
            listsGridLoad();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateEditLists CreateListForm = new CreateEditLists(0);
            CreateListForm.ShowDialog();
            listsGridLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CreateEditLists EditListForm = new CreateEditLists(1, grdLists.Rows[grdLists.CurrentCell.RowIndex].Cells[0].Value.ToString());
            EditListForm.ShowDialog();
            listsGridLoad();
        }

        private void btnNewContent_Click(object sender, EventArgs e)
        {
            try
            {
                //try load the form passing in the ListID from the currently selected list as a parameter
                CreateEditMisc CreateListContentForm = new CreateEditMisc(2, listID: grdLists.Rows[grdLists.CurrentCell.RowIndex].Cells[0].Value.ToString());
                CreateListContentForm.ShowDialog();
                listsGridLoad();
            }
            catch
            {
                //load the form without the ListID if there is no selected record
                CreateEditMisc CreateListContentForm = new CreateEditMisc(2);
                CreateListContentForm.ShowDialog();
                listsGridLoad();
            }
        }

        private void grdLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            //get confirmation of delete
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                //define connection
                MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                connection.Open();
                //define procedure
                string storedProc = "RemoveListAndLinkedData";
                MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?lID", Convert.ToInt32(grdLists.Rows[grdLists.CurrentCell.RowIndex].Cells[0].Value.ToString())));
                //Confirmation
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmation.Equals(DialogResult.OK))
                {
                    //execute procedure upon positive confirmation
                    int i = cmd.ExecuteNonQuery();
                }
                //close connection
                connection.Close();
                listsGridLoad();
            }
        }

        private void btnDeleteContent_Click(object sender, EventArgs e)
        {
            //get confirmation of delete
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                //define connection
                MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                connection.Open();
                //define procedure
                string storedProc = "DeleteListIssueByPKID";
                MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?liID", grdListIssues.Rows[grdLists.CurrentCell.RowIndex].Cells[5].Value.ToString()));
                cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.VarChar)).Direction = ParameterDirection.Output;
                //Confirmation
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmation.Equals(DialogResult.OK))
                {
                    //execute procedure upon positive confirmation
                    int i = cmd.ExecuteNonQuery();
                }
                //close connection
                connection.Close();
                listsGridLoad();
            }
        }

        private void btnEditContent_Click(object sender, EventArgs e)
        {
            try
            {
                //try load the form passing in the ListID from the currently selected list as a parameter
                CreateEditMisc EditListContentForm = new CreateEditMisc(3, listID: grdLists.Rows[grdLists.CurrentCell.RowIndex].Cells[0].Value.ToString());
                EditListContentForm.ShowDialog();
                listsGridLoad();
            }
            catch
            {
                //load the form without the ListID if there is no selected record
                CreateEditMisc EditListContentForm = new CreateEditMisc(3);
                EditListContentForm.ShowDialog();
                listsGridLoad();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //create sql command + open connection
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(ConnectionClass.ConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("GetListIssuesNamedByListID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?lID", Convert.ToInt32(grdLists.Rows[grdLists.CurrentCell.RowIndex].Cells[0].Value.ToString())));
            previousList = Convert.ToInt32(grdLists.Rows[grdLists.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //execute command
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //fill table with results
            da.Fill(dt);
            grdListIssues.DataSource = dt;
            grdListIssues.AutoGenerateColumns = true;
            //close connection
            con.Close();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to send out the List Emails?" +
                "  This operation could take a while.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (confirmation.Equals(DialogResult.OK))
            {
                string eAddress, content, price, username = "";
                DataTable dt = new DataTable();
                //get the lists from the databse
                dt = getLists();
                //get the number of records returned, and loop through each one
                int storeID;
                try
                {
                    //do for all listIDs in retrieved 
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //get the current listID from retrieved table of ListIDs
                        storeID = dt.Rows[i].Field<int>("ListID");
                        //Get email address for linked account from the current listID
                        eAddress = getEmailAddress(storeID);
                        //get list content for list ID
                        content = getListContent(storeID);
                        //get the username linked to this list
                        username = getUsername(storeID);
                        //get price for list ID and append content with it
                        price = "Price: £" + getListPrice(storeID);
                        content = content + price + "<br><br/>";
                        //Send the mail passing eAddress and content as parameters
                        beginMail(content, eAddress, username);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A problem has occured sending emails." +
                      "  Check the database connection and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private string getUsername(int listID)
        {
            //local variables
            string result = "";
            int i;
            string storedProc = "RetrieveUsernameByListID";
            // - define connection variables
            MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
            connection.Open();
            //define procedure
            MySqlCommand cmd = new MySqlCommand(storedProc, connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?lID", listID));
            cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.VarChar)).Direction = ParameterDirection.Output;
            try
           {
                //execute procedure and close connection
                i = cmd.ExecuteNonQuery();
                result = Convert.ToString(cmd.Parameters["?result"].Value);
            }
            catch
            {
                DialogResult errorResult = MessageBox.Show("Connection to the database has failed. Try again to get the username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            //return email address
            return result;
        }

        private DataTable getLists()
        {
            //create sql command + open connection
            DataTable dt = new DataTable();
            MySqlConnection con = new MySqlConnection(ConnectionClass.ConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("GetCompletedListIDs", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //execute command
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //fill table with results
            da.Fill(dt);
            //close connection
            con.Close();
            //return datatable
            return dt;
        }

        //send email from a pre-defined gmail account, takes the recipient email address, the email body content,
        //and the username of the list owner as parameters.
        private void beginMail(string body, string address, string uName)
        {
            //gmail account is ckinghonours@gmail.com, pw is Honours2019
            //set up construction strings for email
            string senderAddress = "ckinghonours@gmail.com";
            string password = "Honours2019";
            //Create and set relevant Email variables

            //setup email parameters
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(senderAddress);
                mail.To.Add(address);
                mail.Subject = "Hi " + uName + ", it's your List update!";
                mail.Body = body;
                mail.IsBodyHtml = true;
                //send email
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(senderAddress, password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }

        private string getEmailAddress(int listID)
        {
            //local variables
            string result = "";
            int i;
            string storedProc = "GetEmailFromListID";
            bool failCheck = false;
            // - define connection variables
            MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
            connection.Open();
            //define procedure
            MySqlCommand cmd = new MySqlCommand(storedProc, connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?lID", listID));
            cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.VarChar)).Direction = ParameterDirection.Output;
            try
            {
                //execute procedure and close connection
                i = cmd.ExecuteNonQuery();
                result = Convert.ToString(cmd.Parameters["?result"].Value);
            }
            catch
            {
                failCheck = true;
            }
            if (failCheck == true)
            {
                DialogResult errorResult = MessageBox.Show("Connection to the database has failed. Could not retrieve email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            //return email address
            return result;
        }

        private void listsGridLoad()
        {
            try
            {
                ConnectionClass.OpenConnection();
                DataSet ListsDS = new DataSet();
                ListsDA = new MySqlDataAdapter("SELECT * FROM tbllists", ConnectionClass.con);
                ListsDA.Fill(ListsDS);
                grdLists.DataSource = ListsDS.Tables[0];
                ConnectionClass.CloseConnection();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error contacting the database. Refresh your connection and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listContentLoad()
        {
            try
            {
                ConnectionClass.OpenConnection();
                DataSet ListContentsDS = new DataSet();
                ListContentDA = new MySqlDataAdapter("SELECT * FROM collatedlists", ConnectionClass.con);
                ListContentDA.Fill(ListContentsDS);
                grdListIssues.DataSource = ListContentsDS.Tables[0];
                ConnectionClass.CloseConnection();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error contacting the database. Refresh your connection and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string getListContent(int listID)
        {
            //local variables
            DataSet ds = new DataSet();
            StringBuilder contents = new StringBuilder();
            string storedProc = "GetListIssuesNamedByListID";
            bool failCheck = false;
            // - define connection variables
            MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
            connection.Open();
            //define procedure
            MySqlCommand cmd = new MySqlCommand(storedProc, connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?lID", listID));
            try
            {
                //execute procedure
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);
                contents.AppendFormat("<span style = \"\"font-family:Arial;font-size: 12pt;\"\"> Your List: &nbsp <br><br/> ");
                //go through table row by row
                foreach (DataRow rows in ds.Tables[0].Rows)
                {
                    foreach (DataColumn cols in ds.Tables[0].Columns)
                    {
                        contents.AppendFormat("{0} ", rows[cols]);
                    }
                    contents.AppendFormat("<br><br/>");
                    contents.AppendLine();
                }
            }
            catch
            //error handling
            {
                failCheck = true;
            }
            if (failCheck == true)
            {
                DialogResult errorResult = MessageBox.Show("Connection to the database has failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //close connection
            connection.Close();
            //return string
            return contents.ToString(); ;
        }

        private void lblLists_Click(object sender, EventArgs e)
        {

        }

        private void btnSortLists_Click(object sender, EventArgs e)
        {
            switch (cbSortLists.Text)
            {
                case "AccountID":
                    grdLists.Sort(this.grdLists.Columns["AccountID"], ListSortDirection.Ascending);
                    break;
                case "ListID":
                    grdLists.Sort(this.grdLists.Columns["ListID"], ListSortDirection.Ascending);
                    break;
            }
        }

        private string getListPrice(int listID)
        {
            //local variables
            string result = "";
            int i;
            string storedProc = "CostForList";
            bool failCheck = false;
            // - define connection variables
            MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
            connection.Open();
            //define procedure
            MySqlCommand cmd = new MySqlCommand(storedProc, connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("?lID", listID));
            cmd.Parameters.Add(new MySqlParameter("?result", MySqlDbType.VarChar)).Direction = ParameterDirection.Output;
            try
            {
                //execute procedure and close connection
                i = cmd.ExecuteNonQuery();
                result = Convert.ToString(cmd.Parameters["?result"].Value);
            }
            catch
            {
                failCheck = true;
            }
            if (failCheck == true)
            {
                DialogResult errorResult = MessageBox.Show("Connection to the database has failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            //return price
            return result;
        }

        private void btnSortContent_Click(object sender, EventArgs e)
        {
            switch (cbSortContent.Text)
            {
                case "Name":
                    grdListIssues.Sort(this.grdListIssues.Columns["Name"], ListSortDirection.Ascending);
                    break;
                case "Author":
                    grdListIssues.Sort(this.grdListIssues.Columns["Author"], ListSortDirection.Ascending);
                    break;
                case "IssueNumber":
                    grdListIssues.Sort(this.grdListIssues.Columns["IssueNumber"], ListSortDirection.Ascending);
                    break;
                case "Price":
                    grdListIssues.Sort(this.grdListIssues.Columns["Price"], ListSortDirection.Ascending);
                    break;
                case "ReleaseDate":
                    grdListIssues.Sort(this.grdListIssues.Columns["ReleaseDate"], ListSortDirection.Ascending);
                    break;
                case "ListIssueID":
                    grdListIssues.Sort(this.grdListIssues.Columns["ListIssueID"], ListSortDirection.Ascending);
                    break;
            }
        }
    }
}
