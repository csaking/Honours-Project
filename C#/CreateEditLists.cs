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
    public partial class CreateEditLists : Form
    {
        private int exitCheck;
        public CreateEditLists(int EdCh_Check, string listID = "")
        {
            exitCheck = EdCh_Check;
            InitializeComponent();
            tbPrimaryID.Text = listID;
            this.ControlBox = false;
            //check if form is being loaded as Create = 0, or Edit = 1
            //Form initialises with different boxes hidden on Create or Edit mode
            if (EdCh_Check == 0)
            {
                lblTitle.Text = "Create List";
                lblPrimaryID.Visible = false;
                tbPrimaryID.Visible = false;
            }
            else
            {
                lblTitle.Text = "Edit List";
                lblPrimaryID.Visible = true;
                tbPrimaryID.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean ValidateEntries()
        {
            if (cbAccounts.Text.Length > 0)
            {
                return true;
            }
            else
            {

                MessageBox.Show("You must select a user that this list belongs to.","Invalid!",MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateEntries() == true)
            {
                //error handling
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

                switch (exitCheck)
                {
                    case 0:
                        //define procedure
                        storedProc = "CreateNewListUsingUsername";
                        MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?uName", cbAccounts.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "New List creation has failed! Check the database connection and try again.";
                        }
                        connection.Close();
                        break;
                    case 1:
                        //define procedure
                        storedProc = "UpdateListUsingUsername";
                        cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?lID", tbPrimaryID.Text));
                        cmd.Parameters.Add(new MySqlParameter("?uName", cbAccounts.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "Edit List has failed! Check the database connection and try again.";
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

        private void CreateEditLists_Load(object sender, EventArgs e)
        {
            //populate combobox cbAccounts
            //open connection
            using (var con = new MySqlConnection(ConnectionClass.ConnectionString))
            {
                try
                {
                    con.Open();
                    //select the name of the field from the table we want to use to populate the combo box
                    using (var cmd = new MySqlCommand("SELECT `Username` FROM tblaccounts", con))
                    {

                        //read results
                        using (var rdr = cmd.ExecuteReader())
                        {
                            //fill the combo box with the results
                            while (rdr.Read())
                            {
                                cbAccounts.Items.Add(rdr.GetString("Username"));
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
                //if editing, do
                //define connection
                MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                MySqlDataReader rd;
                //Define stored procedure name
                string storedProc = "GetListByID";
                using (connection)
                {
                    //define procedure type and parameters
                    MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("?lID", Convert.ToInt32(tbPrimaryID.Text)));
                    //open connection, execute procedure and load results into data reader
                    connection.Open();
                    rd = cmd.ExecuteReader();
                    //while reading data, do
                    while (rd.Read())
                    {
                        //load data into form components from reader
                        cbAccounts.SelectedText = rd[0].ToString();
                    }
                    //close reader
                    rd.Close();
                }
                //close connection
                connection.Close();

                //load Username from the List ID
                using (connection)
                {
                    storedProc = "GetUsernameByListID";
                    MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("?lID", Convert.ToInt32(tbPrimaryID.Text)));
                    connection.Open();
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cbAccounts.Text = rd[0].ToString();
                    }
                    //close reader
                    rd.Close();
                }
                //close connection
                connection.Close();
            }
        }

        private void cbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
