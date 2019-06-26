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
    public partial class CreateEditAccount : Form
    {
        private int exitCheck;
        public CreateEditAccount(int EdCh_Check, string aID = "")
        {
            InitializeComponent();
            tbPrimaryID.Text = aID;
            exitCheck = EdCh_Check;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //check if form is being loaded as Create = 0, or Edit = 1
            //Form initialises with different boxes hidden on Create or Edit mode
            if (EdCh_Check == 0)
            {
                lblTitle.Text = "Create Account";
                lblPrimaryID.Visible = false;
                tbPrimaryID.Visible = false;
            }
            else
            {
                lblTitle.Text = "Edit Account";
                lblPrimaryID.Visible = true;
                tbPrimaryID.Visible = true;
            }
        }

        private void frmCreateEditAccount_Load(object sender, EventArgs e)
        {
            //load current values from database when editing record
            if (exitCheck == 1) //check if editing
            {
                //if editing, do
                //define connection
                MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                MySqlDataReader rd;
                //Define stored procedure name
                string storedProc = "GetAccountByID";
                using (connection)
                {
                    //define procedure type and parameters
                    MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("?aID", Convert.ToInt32(tbPrimaryID.Text)));
                    //open connection, execute procedure and load results into data reader
                    connection.Open();
                    rd = cmd.ExecuteReader();
                    //while reading data, do
                    while (rd.Read())
                    {
                        //load data into form components from reader
                        txtEmail.Text = rd[0].ToString();
                        txtUsername.Text = rd[1].ToString();
                    }
                    //close reader
                    rd.Close();
                }
                //close connection
                connection.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private Boolean ValidateEntries()
        {
            if(txtUsername.Text.Length > 0 && txtEmail.Text.Length > 0 && txtUsername.Text.Length <= 50 && txtEmail.Text.Length <=50)
            {
                return true;
            }
            else
            {

                  if(txtUsername.Text.Length == 0)
                  {
                        MessageBox.Show("Account must have a username.","Too Short!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                  }
                else if (txtEmail.Text.Length == 0)
                {
                    MessageBox.Show("Account must have an email.", "Too Short!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtUsername.Text.Length > 50)
                {
                    MessageBox.Show("Username is too long.  Cannot be longer than 50 characters.", "Too Long!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (txtEmail.Text.Length > 50)
                {
                    MessageBox.Show("Email is too long.  Cannot be longer than 50 characters.", "Too Long!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Validate the user entered data
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
                        storedProc = "CreateAccount";
                        MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?emailadd", txtEmail.Text));
                        cmd.Parameters.Add(new MySqlParameter("?uName", txtUsername.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "New Account creation has failed! Check the database connection and try again.";
                        }
                        connection.Close();
                        break;
                    case 1:
                        //define procedure
                        storedProc = "UpdateAccountByID";
                        cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?aID", tbPrimaryID.Text));
                        cmd.Parameters.Add(new MySqlParameter("?emailadd", txtEmail.Text));
                        cmd.Parameters.Add(new MySqlParameter("?uName", txtUsername.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "Edit Account has failed! Check the database connection and try again.";
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
    }
}
