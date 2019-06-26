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
    public partial class CreateEditSeries : Form
    {
        private int exitCheck;
        public CreateEditSeries(int EdCh_Check, string seriesID = "")
        {
            exitCheck = EdCh_Check;
            InitializeComponent();
            tbPrimaryID.Text = seriesID;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //check if form is being loaded as Create = 0, or Edit = 1
            //Form initialises with different boxes hidden on Create or Edit mode
            if (EdCh_Check == 0)
            {
                lblTitle.Text = "Create Series";
                lblPrimaryID.Visible = false;
                tbPrimaryID.Visible = false;
            }
            else
            {
                lblTitle.Text = "Edit Series";
                lblPrimaryID.Visible = true;
                tbPrimaryID.Visible = true;
            }
        }

        private void CreateEditSeries_Load(object sender, EventArgs e)
        {
            //populate combobox cbPublisher
            //open connection
            using (var con = new MySqlConnection(ConnectionClass.ConnectionString))
            {
                try
                {
                    con.Open();
                    //select the name of the field from the table we want to use to populate the combo box
                    using (var cmd = new MySqlCommand("SELECT `Name` FROM tblpublisher", con))
                    {

                        //read results
                        using (var rdr = cmd.ExecuteReader())
                        {
                            //fill the combo box with the results
                            while (rdr.Read())
                            {
                                cbPublisher.Items.Add(rdr.GetString("Name"));
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
                string storedProc = "GetSeriesByID";
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
                    while(rd.Read())
                    {
                        //load data into form components from reader
                        tbName.Text = rd[0].ToString();
                        tbAuthor.Text = rd[1].ToString();
                        cbPublisher.SelectedText = rd[2].ToString();
                    }
                    //close reader
                    rd.Close();
                }
                //close connection
                connection.Close();

                //load Publisher Name from the Series ID
                using (connection)
                {
                    storedProc = "GetPubNameBySeriesID";
                    MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("?sID", Convert.ToInt32(tbPrimaryID.Text)));
                    connection.Open();
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cbPublisher.Text = rd[0].ToString();
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
            if (tbName.Text.Length > 0 && tbName.Text.Length <= 50 && tbAuthor.Text.Length > 0 && tbAuthor.Text.Length <= 50 && cbPublisher.Text.Length != 0)
            {
                return true;
            }
            else
            {
                if (tbName.Text.Length == 0)
                {
                    MessageBox.Show("You must give the series a name.", "Too Short!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (tbName.Text.Length > 50)
                {
                    MessageBox.Show("The series name is too long.  The character limit is 50.", "Too Long!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (tbAuthor.Text.Length == 0)
                {
                    MessageBox.Show("You must provide an Author for the series.", "Too Short!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (tbAuthor.Text.Length > 50)
                {
                    MessageBox.Show("The Author's name is too long.  The character limit is 50.", "Too Long!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (cbPublisher.Text.Length == 0)
                {
                    MessageBox.Show("You must select a publisher for the series.", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateEntries() == true)
            {
                //error handling
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
                        storedProc = "CreateNewSeriesUsingPubName";
                        MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?pName", cbPublisher.SelectedText));
                        cmd.Parameters.Add(new MySqlParameter("?sName", tbName.Text));
                        cmd.Parameters.Add(new MySqlParameter("?Author", tbAuthor.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "New Series creation has failed! Check the database connection and try again.";
                        }
                        connection.Close();
                        break;
                    case 1:
                        //define procedure
                        storedProc = "UpdateSeriesUsingPubName";
                        cmd = new MySqlCommand(storedProc, connection);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add(new MySqlParameter("?sID", tbPrimaryID.Text));
                        cmd.Parameters.Add(new MySqlParameter("?pName", cbPublisher.SelectedText));
                        cmd.Parameters.Add(new MySqlParameter("?sName", tbName.Text));
                        cmd.Parameters.Add(new MySqlParameter("?Author", tbAuthor.Text));
                        try
                        {
                            //execute procedure and close connection
                            i = cmd.ExecuteNonQuery();
                        }
                        catch
                        {
                            failCheck = true;
                            message = "Edit Series has failed! Check the database connection and try again.";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateEditMisc CreatePublisherForm = new CreateEditMisc(0);
            CreatePublisherForm.ShowDialog();
        }
    }
}
