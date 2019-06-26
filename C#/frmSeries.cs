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
    public partial class frmSeries : Form
    {
        private MySqlDataAdapter SeriesDA, PublisherDA;

        public frmSeries()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSeries_Load(object sender, EventArgs e)
        {
            seriesGridLoad();
            publishersGridLoad();
        }

        private void grdSeries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateEditSeries CreateSeriesForm = new CreateEditSeries(0);
            CreateSeriesForm.ShowDialog();
            seriesGridLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CreateEditSeries EditSeriesForm = new CreateEditSeries(1, grdSeries.Rows[grdSeries.CurrentCell.RowIndex].Cells[0].Value.ToString());
            EditSeriesForm.ShowDialog();
            seriesGridLoad();
        }

        private void btnNewPub_Click(object sender, EventArgs e)
        {
            CreateEditMisc CreatePublisherForm = new CreateEditMisc(0);
            CreatePublisherForm.ShowDialog();
            publishersGridLoad();
        }

        private void btnDeleteSeries_Click(object sender, EventArgs e)
        {
            //get confirmation of delete
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                //define connection
                MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                connection.Open();
                //define procedure
                string storedProc = "RemoveSeriesAndLinkedData";
                MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?sID", Convert.ToInt32(grdSeries.Rows[grdSeries.CurrentCell.RowIndex].Cells[0].Value.ToString())));
                //Confirmation
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmation.Equals(DialogResult.OK))
                {
                    //execute procedure upon positive confirmation
                    int i = cmd.ExecuteNonQuery();
                }
                //close connection
                connection.Close();
                seriesGridLoad();
            }
        }

        private void btnDeletePub_Click(object sender, EventArgs e)
        {
            //get confirmation of delete
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                //define connection
                MySqlConnection connection = new MySqlConnection(ConnectionClass.ConnectionString);
                connection.Open();
                //define procedure
                string storedProc = "RemovePublisherAndLinkedData";
                MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?pID", Convert.ToInt32(grdPublisher.Rows[grdPublisher.CurrentCell.RowIndex].Cells[0].Value.ToString())));
                //Confirmation
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmation.Equals(DialogResult.OK))
                {
                    //execute procedure upon positive confirmation
                    int i = cmd.ExecuteNonQuery();
                }
                //close connection
                connection.Close();
                publishersGridLoad();
            }
        }

        private void grdPublisher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditPub_Click(object sender, EventArgs e)
        {
            CreateEditMisc EditPublisherForm = new CreateEditMisc(1, grdPublisher.Rows[grdPublisher.CurrentCell.RowIndex].Cells[0].Value.ToString());
            EditPublisherForm.ShowDialog();
            publishersGridLoad();
        }

        private void seriesGridLoad()
        {
            try
            {
                ConnectionClass.OpenConnection();
                DataSet SeriesDS = new DataSet();
                SeriesDA = new MySqlDataAdapter("SELECT * FROM tblseries", ConnectionClass.con);
                SeriesDA.Fill(SeriesDS);
                grdSeries.DataSource = SeriesDS.Tables[0];
                ConnectionClass.CloseConnection();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error contacting the database. Refresh your connection and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSortSeries_Click(object sender, EventArgs e)
        {
            switch (cbSortSeries.Text)
            {
                case "SeriesID":
                    grdSeries.Sort(this.grdSeries.Columns["SeriesID"], ListSortDirection.Ascending);
                    break;
                case "Name":
                    grdSeries.Sort(this.grdSeries.Columns["Name"], ListSortDirection.Ascending);
                    break;
                case "Author":
                    grdSeries.Sort(this.grdSeries.Columns["Author"], ListSortDirection.Ascending);
                    break;
                case "PublisherID":
                    grdSeries.Sort(this.grdSeries.Columns["PublisherID"], ListSortDirection.Ascending);
                    break;
            }
        }

        private void btnSortPub_Click(object sender, EventArgs e)
        {
            switch (cbSortPub.Text)
            {
                case "PublisherID":
                    grdPublisher.Sort(this.grdPublisher.Columns["PublisherID"], ListSortDirection.Ascending);
                    break;
                case "Name":
                    grdPublisher.Sort(this.grdPublisher.Columns["Name"], ListSortDirection.Ascending);
                    break;
            }
        }

        private void cbSortSeries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void publishersGridLoad()
        {
            try
            {
                ConnectionClass.OpenConnection();
                DataSet PublisherDS = new DataSet();
                PublisherDA = new MySqlDataAdapter("SELECT * FROM tblpublisher", ConnectionClass.con);
                PublisherDA.Fill(PublisherDS);
                grdPublisher.DataSource = PublisherDS.Tables[0];
                ConnectionClass.CloseConnection();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error contacting the database. Refresh your connection and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
