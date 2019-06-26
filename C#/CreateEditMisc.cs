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

namespace HonoursApp
{
    public partial class CreateEditMisc : Form
    {
        private int exitCheck;
        private string IDstore;
        //form which handles the small entries and edits of Publishers and List-Issues
        public CreateEditMisc(int Check, string primaryID = "", string listID = "")
        {
            InitializeComponent();
            txtUID.Text = primaryID;
            //assign type and disable control box for dialog
            exitCheck = Check;
            this.ControlBox = false;
            //check the type of form needed
            switch(Check)
            {
                case 0:
                    lblTitle.Text = "Create New Publisher";
                    lblPubName.Visible = true;
                    lblListID.Visible = false;
                    lblIssueID.Visible = false;
                    txtPubName.Visible = true;
                    cbiID.Visible = false;
                    cblID.Visible = false;
                    txtUID.Visible = false;
                    lblUID.Visible = false;
                    break;

                case 1:
                    lblTitle.Text = "Edit Publisher";
                    lblPubName.Visible = true;
                    lblListID.Visible = false;
                    lblIssueID.Visible = false;
                    txtPubName.Visible = true;
                    cbiID.Visible = false;
                    cblID.Visible = false;
                    txtUID.Visible = true;
                    lblUID.Visible = true;
                    break;

                case 2:
                    lblTitle.Text = "Add Issue to List";
                    lblPubName.Visible = false;
                    lblListID.Visible = true;
                    lblIssueID.Visible = true;
                    txtPubName.Visible = false;
                    cbiID.Visible = true;
                    cblID.Visible = true;
                    IDstore = listID;
                    txtUID.Visible = false;
                    lblUID.Visible = false;
                    break;

                case 3:
                    lblTitle.Text = "Edit Issue on List";
                    lblPubName.Visible = false;
                    lblListID.Visible = true;
                    lblIssueID.Visible = true;
                    txtPubName.Visible = false;
                    cbiID.Visible = true;
                    cblID.Visible = true;
                    IDstore = listID;
                    txtUID.Visible = true;
                    lblUID.Visible = true;
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean ValidatePubName()
        {
            if (txtPubName.Text.Length > 0 && txtPubName.Text.Length <= 50)
            {
                return true;
            }
            else
            {
                if (txtPubName.Text.Length == 0)
                {
                    MessageBox.Show("The publisher must have a name.", "Too Short!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtPubName.Text.Length > 50)
                {
                    MessageBox.Show("The publisher's name cannot be longer than 50 characters.", "Too Long", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return false;
            }
        }

        private Boolean ValidateListContent()
        {
            if (cbiID.Text.Length > 0 && cblID.Text.Length > 0)
            {
                return true;
            }
            else
            {

                if (cbiID.Text.Length == 0)
                {
                    MessageBox.Show("You must select an Issue to add to the List.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (cblID.Text.Length == 0)
                {
                    MessageBox.Show("You must select a List to add the Issue to.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool failCheck = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            string message = "";
            string title = "Error!";
            //define connection
            MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
            connection.Open();
            //local variable declaration
            int i;
            string storedProc;
            MySqlCommand cmd;
            switch (exitCheck)
            {
                case 0:
                    if (ValidatePubName() == true)
                    {
                        //define procedure
                        storedProc = "CreatePublisher";
                        cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?pName", txtPubName.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "New Publisher creation has failed! Check the database connection and try again.";
                        }
                        connection.Close();
                    }
                    break;
                case 1:
                    if (ValidatePubName() == true)
                    {
                        //define procedure
                        storedProc = "UpdatePublisherByID";
                        cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?pID", txtUID.Text));
                        cmd.Parameters.Add(new MySqlParameter("?pName", txtPubName.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "Edit Publisher has failed! Check the database connection and try again.";
                        }
                        connection.Close();
                    }
                    break;
                case 2:
                    if (ValidateListContent() == true)
                    {
                        //define procedure
                        storedProc = "CreateListIssue";
                        cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?lID", cblID.Text));
                        cmd.Parameters.Add(new MySqlParameter("?iID", cbiID.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "New List Item creation has failed! Check the database connection and try again.";
                        }
                        connection.Close();
                    }
                    break;
                case 3:
                    if (ValidateListContent() == true)
                    {
                        //define procedure
                        storedProc = "UpdateListIssueByID";
                        cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?liID", txtUID.Text));
                        cmd.Parameters.Add(new MySqlParameter("?lID", cblID.Text));
                        cmd.Parameters.Add(new MySqlParameter("?iID", cbiID.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "Edit List Items has failed! Check the database connection and try again.";
                        }
                        connection.Close();
                    }
                    break;
            }
            if (failCheck == true)
            {
                DialogResult errorResult = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }

        private void frmCreateEditMisc_Load(object sender, EventArgs e)
        {
            //populate combobox cblID (ListID)
            //open connection
            using (var con = new MySqlConnection(ConnectionClass.ConnectionString))
            {
                try
                {
                    con.Open();
                    //select the name of the field from the table we want to use to populate the combo box
                    using (var cmd = new MySqlCommand("SELECT `ListID` FROM tbllists", con))
                    {

                        //read results
                        using (var rdr = cmd.ExecuteReader())
                        {
                            //fill the combo box with the results
                            while (rdr.Read())
                            {
                                cblID.Items.Add(rdr.GetString("ListID"));
                            }
                        }
                    }
                }
                //error handling if something fails
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error has occurred contacting the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            //populate combobox cbiID (IssueID)
            //open connection
            using (var con = new MySqlConnection(ConnectionClass.ConnectionString))
            {
                try
                {
                    con.Open();
                    //select the name of the field from the table we want to use to populate the combo box
                    using (var cmd = new MySqlCommand("SELECT `IssueID` FROM tblissues", con))
                    {

                        //read results
                        using (var rdr = cmd.ExecuteReader())
                        {
                            //fill the combo box with the results
                            while (rdr.Read())
                            {
                                cbiID.Items.Add(rdr.GetString("IssueID"));
                            }
                        }
                    }
                }
                //error handling if something fails
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error has occurred contacting the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            if (exitCheck == 1)
            {
                    //if editing, do
                    //define connection
                    MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                    MySqlDataReader rd;
                    //Define stored procedure name
                    string storedProc = "GetPublisherByID";
                    using (connection)
                    {
                        //define procedure type and parameters
                        MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?pID", Convert.ToInt32(txtUID.Text)));
                        //open connection, execute procedure and load results into data reader
                        connection.Open();
                        rd = cmd.ExecuteReader();
                        //while reading data, do
                        while (rd.Read())
                        {
                            //load data into form components from reader
                            txtPubName.Text = rd[0].ToString();

                        }
                        //close reader
                        rd.Close();
            }
                    //close connection
                    connection.Close();
               
        }
            if (exitCheck == 2)
            {
                cblID.Text = IDstore;
            }

            if (exitCheck == 3)
            {
                    //if editing, do
                    //define connection
                    MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                    MySqlDataReader rd;
                    //Define stored procedure name
                    string storedProc = "GetListIssueByID";
                    using (connection)
                    {
                        //define procedure type and parameters
                        MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?liID", Convert.ToInt32(txtUID.Text)));
                        //open connection, execute procedure and load results into data reader
                        connection.Open();
                        rd = cmd.ExecuteReader();
                        //while reading data, do
                        while (rd.Read())
                        {
                            //load data into form components from reader
                            cblID.Text = rd[0].ToString();
                            cbiID.Text = rd[1].ToString();
                    }
                        //close reader
                        rd.Close();
                    }
                    //close connection
                    connection.Close();
                cblID.Text = IDstore;
            }
        }

        private void lblPubName_Click(object sender, EventArgs e)
        {

        }

        private void cbiID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
