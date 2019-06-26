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
    public partial class CreateEditStock : Form
    {
        private int exitCheck;
        public CreateEditStock(int EdCh_Check, string stockID = "")
        {
            InitializeComponent();
            tbPrimaryID.Text = stockID;
            exitCheck = EdCh_Check;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //check if form is being loaded as Create = 0, or Edit = 1
            //Form initialises with different boxes hidden on Create or Edit mode
            if (EdCh_Check == 0)
            {
                lblTitle.Text = "Create Stock";
                lblPrimaryID.Visible = false;
                tbPrimaryID.Visible = false;
            }
            else
            {
                lblTitle.Text = "Edit Stock";
                lblPrimaryID.Visible = true;
                tbPrimaryID.Visible = true;
            }
        }

        private void CreateEditStock_Load(object sender, EventArgs e)
        {
            //populate combobox cbIssues
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
                                cbIssues.Items.Add(rdr.GetString("IssueID"));
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
                string storedProc = "GetStockByID";
                using (connection)
                {
                    //define procedure type and parameters
                    MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("?sID", Convert.ToInt32(tbPrimaryID.Text)));
                    //open connection, execute procedure and load results into data reader
                    connection.Open();
                    rd = cmd.ExecuteReader();
                    //while reading data, do
                    while (rd.Read())
                    {
                        //load data into form components from reader
                        tbNumber.Text = rd[0].ToString();
                        //cbIssues.SelectedText = rd[1].ToString();
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

        private Boolean ValidateEntries()
        {
            if (Convert.ToInt32(tbNumber.Text) >= 0 && cbIssues.Text.Length > 0)
            {
                return true;
            }
            else
            {

                if (Convert.ToInt32(tbNumber.Text) < 0)
                {
                    MessageBox.Show("You cannot have less than 0 items in stock.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (cbIssues.Text.Length == 0)
                {
                    MessageBox.Show("You must select an Issue ID for this stock record.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                        storedProc = "CreateStock";
                        MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?Num", tbNumber.Text));
                        cmd.Parameters.Add(new MySqlParameter("?iID", cbIssues.SelectedText));
                        //execute procedure and close connection
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "New Stock creation has failed! Check the database connection and try again.";
                        }
                        connection.Close();
                        break;
                    case 1:
                        //define procedure
                        storedProc = "UpdateStockByID";
                        cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?sID", tbPrimaryID.Text));
                        cmd.Parameters.Add(new MySqlParameter("?Num", tbNumber.Text));
                        cmd.Parameters.Add(new MySqlParameter("?iID", cbIssues.SelectedText));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "Edit Stock has failed! Check the database connection and try again.";
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

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
