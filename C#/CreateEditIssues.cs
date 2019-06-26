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
    public partial class CreateEditIssues : Form
    {
        private int exitCheck;
        public CreateEditIssues(int EdCh_Check, string issueID = "")
        {
            InitializeComponent();
            exitCheck = EdCh_Check;
            tbPrimaryID.Text = issueID;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //check if form is being loaded as Create = 0, or Edit = 1
            //Form initialises with different boxes hidden on Create or Edit mode
            if (EdCh_Check == 0)
            {
                lblTitle.Text = "Create Issue";
                lblPrimaryID.Visible = false;
                tbPrimaryID.Visible = false;
            }
            else
            {
                lblTitle.Text = "Edit Issue";
                lblPrimaryID.Visible = true;
                tbPrimaryID.Visible = true;
            }
        }

        private Boolean ValidateEntries()
        {
            if (Convert.ToInt32(txtIssueNum.Text) > 0 && Convert.ToDecimal(txtPrice.Text) > 0 && tbRDate.Text.Length == 10 && cbSeries.Text.Length > 0)
            {
                return true;
            }
            else
            {

                if (Convert.ToInt32(txtIssueNum.Text) <= 0)
                {
                    MessageBox.Show("Issue Number must be greater than 0.", "Too Little!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (Convert.ToInt32(txtPrice.Text) <= 0)
                {
                    MessageBox.Show("Price must be greater than 0.", "Too Little!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (tbRDate.Text.Length != 10)
                {
                    MessageBox.Show("Date is too short. Needs to be in the format YYYY-MM-DD.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (cbSeries.Text.Length == 0)
                {
                    MessageBox.Show("You must select a series that the issue belongs to.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateEntries() == true)
            {
                bool failCheck = false;
                string message = "";
                string title = "Error!";
                //define connection
                MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                connection.Open();
                //local variable declaration
                int i;
                string storedProc;

                switch (exitCheck)
                {
                    case 0:
                        //define procedure
                        storedProc = "CreateNewIssueUsingSeriesName";
                        MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?sName", cbSeries.Text));
                        cmd.Parameters.Add(new MySqlParameter("?iNum", txtIssueNum.Text));
                        cmd.Parameters.Add(new MySqlParameter("?cost", txtPrice.Text));
                        cmd.Parameters.Add(new MySqlParameter("?rDate", tbRDate.Text));
                        //try
                        // {
                        //execute procedure and close connection
                        i = cmd.ExecuteNonQuery();
                        //}
                        //catch
                        //{
                        //failCheck = true;
                        //message = "New Issue creation has failed! Check the database connection and try again.";
                        //}
                        connection.Close();
                        break;
                    case 1:
                        //define procedure
                        storedProc = "UpdateIssueUsingSeriesName";
                        cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?iID", tbPrimaryID.Text));
                        cmd.Parameters.Add(new MySqlParameter("?sName", cbSeries.Text));
                        cmd.Parameters.Add(new MySqlParameter("?iNum", txtIssueNum.Text));
                        cmd.Parameters.Add(new MySqlParameter("?cost", txtPrice.Text));
                        cmd.Parameters.Add(new MySqlParameter("?rDate", tbRDate.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "Edit Issue has failed! Check the database connection and try again.";
                        }
                        connection.Close();
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
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateEditIssues_Load(object sender, EventArgs e)
        {
            //populate combobox cbSeries
            //open connection
            using (var con = new MySqlConnection(ConnectionClass.ConnectionString))
            {
                try
                {
                    con.Open();
                    //select the name of the field from the table we want to use to populate the combo box
                    using (var cmd = new MySqlCommand("SELECT `Name` FROM tblseries", con))
                    {
                    
                        //read results
                        using (var rdr = cmd.ExecuteReader())
                        {
                            //fill the combo box with the results
                            while(rdr.Read())
                            {
                                cbSeries.Items.Add(rdr.GetString("Name"));
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
            //load current values from database when editing record
            if (exitCheck == 1) //check if editing
            {
                string dateString = "";
                //if editing, do
                //define connection
                MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                MySqlDataReader rd;
                //Define stored procedure name
                string storedProc = "GetIssueByID";
                using (connection)
                {
                    //define procedure type and parameters
                    MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("?iID", Convert.ToInt32(tbPrimaryID.Text)));
                    //open connection, execute procedure and load results into data reader
                    connection.Open();
                    rd = cmd.ExecuteReader();
                    //while reading data, do
                    while (rd.Read())
                    {
                        //load data into form components from reader
                        cbSeries.Text = rd[0].ToString();
                        txtIssueNum.Text = rd[1].ToString();
                        txtPrice.Text = rd[2].ToString();
                        dateString = rd[3].ToString();
                    }
                    //close reader
                    rd.Close();
                    tbRDate.Text = formatDate(dateString.Substring(0, 10));
                }
                //close connection
                connection.Close();

                //load Series Name from the issue ID
                using (connection)
                {
                    storedProc = "GetSeriesNameByIssueID";
                    MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("?iID", Convert.ToInt32(tbPrimaryID.Text)));
                    connection.Open();
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cbSeries.Text = rd[0].ToString();
                    }
                    //close reader
                    rd.Close();
                }
                //close connection
                connection.Close();
            }
        }
        private string formatDate(string inString)
        {
            string outString, lString1, lString2, lString3;
            if (inString.Length > 10)
            {
                MessageBox.Show("The entered date could not be recognised. The date has been set to 1999/12/12. You can try edit this again.", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                outString = "1999/12/12";
            }
            else
            {
                lString3 = inString.Substring(0, 2);
                lString2 = inString.Substring(3, 2);
                lString1 = inString.Substring(6, 4);
                outString = lString1 + "-" + lString2 + "-" + lString3;
            }
            return outString;
        }
    }
}
