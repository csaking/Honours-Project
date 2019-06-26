using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace HonoursApp
{
    public partial class frmIssues : Form
    {
        private MySqlDataAdapter IssuesDA;

        public frmIssues()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIssues_Load(object sender, EventArgs e)
        {
            issuesGridLoad();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            //Open fileDialog, and select an image
            var myFileDialog = new System.Windows.Forms.OpenFileDialog();
            DialogResult result = myFileDialog.ShowDialog();
            //if result is accepted
            if (result == DialogResult.OK)
            {
                //Get filename substring from the filepath string
                string fName = myFileDialog.FileName;
                int index = fName.LastIndexOf(@"\") + 1;
                //POST fResult to DB
                //define connection
                MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                connection.Open();
                //define procedure
                string storedProc = "AddImage";
                MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?iID", grdIssues.SelectedRows));
                cmd.Parameters.Add(new MySqlParameter("?imagepath", fName.Substring(index, fName.Length - index)));
                //execute procedure and close connection
                int i = cmd.ExecuteNonQuery();
                connection.Close();
            }
            issuesGridLoad();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateEditIssues CreateIssueForm = new CreateEditIssues(0);
            CreateIssueForm.ShowDialog();
            issuesGridLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CreateEditIssues EditIssueForm = new CreateEditIssues(1, grdIssues.Rows[grdIssues.CurrentCell.RowIndex].Cells[0].Value.ToString());
            EditIssueForm.ShowDialog();
            issuesGridLoad();
        }

        private void grdIssues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get confirmation of delete
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                //define connection
                MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                connection.Open();
                //define procedure
                string storedProc = "DeleteIssueByPKID";
                MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?iID", Convert.ToInt32(grdIssues.Rows[grdIssues.CurrentCell.RowIndex].Cells[0].Value.ToString())));
                //Confirmation
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmation.Equals(DialogResult.OK))
                {
                    //execute procedure upon positive confirmation
                    int i = cmd.ExecuteNonQuery();
                }
                //close connection
                connection.Close();
                issuesGridLoad();
            }
        }

        private void issuesGridLoad()
        {
            try
            {
                ConnectionClass.OpenConnection();
                DataSet IssuesDS = new DataSet();
                IssuesDA = new MySqlDataAdapter("SELECT * FROM tblissues", ConnectionClass.con);
                IssuesDA.Fill(IssuesDS);
                grdIssues.DataSource = IssuesDS.Tables[0];
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error contacting the database. Refresh your connection and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            switch (cbSort.Text)
            {
                case "IssuesID":
                    grdIssues.Sort(this.grdIssues.Columns["IssuesID"], ListSortDirection.Ascending);
                    break;
                case "SeriesID":
                    grdIssues.Sort(this.grdIssues.Columns["SeriesID"], ListSortDirection.Ascending);
                    break;
                case "IssueNumber":
                    grdIssues.Sort(this.grdIssues.Columns["IssueNumber"], ListSortDirection.Ascending);
                    break;
                case "Price":
                    grdIssues.Sort(this.grdIssues.Columns["Price"], ListSortDirection.Ascending);
                    break;
                case "ReleaseDate":
                    grdIssues.Sort(this.grdIssues.Columns["ReleaseDate"], ListSortDirection.Ascending);
                    break;
            }
        }
    }
}
