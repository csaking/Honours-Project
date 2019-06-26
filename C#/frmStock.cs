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
    public partial class frmStock : Form
    {
        private MySqlDataAdapter StockDA;

        public frmStock()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            stocksGridLoad();
        }

        private void grdStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateEditStock CreateStockForm = new CreateEditStock(0);
            CreateStockForm.ShowDialog();
            stocksGridLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CreateEditStock EditStockForm = new CreateEditStock(1, grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value.ToString());
            EditStockForm.ShowDialog();
            stocksGridLoad();
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
                string storedProc = "DeleteStockByPKID";
                MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?sID", Convert.ToInt32(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value.ToString())));
                //Confirmation
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmation.Equals(DialogResult.OK))
                {
                    //execute procedure upon positive confirmation
                    int i = cmd.ExecuteNonQuery();
                }
                //close connection
                connection.Close();
                stocksGridLoad();
            }
        }

        private void stocksGridLoad()
        {
            try
            {
                ConnectionClass.OpenConnection();
                DataSet StockDS = new DataSet();
                StockDA = new MySqlDataAdapter("SELECT * FROM tblstock", ConnectionClass.con);
                StockDA.Fill(StockDS);
                grdStock.DataSource = StockDS.Tables[0];
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
                case "StockID":
                    grdStock.Sort(this.grdStock.Columns["StockID"], ListSortDirection.Ascending);
                    break;
                case "StockNumber":
                    grdStock.Sort(this.grdStock.Columns["StockNumber"], ListSortDirection.Ascending);
                    break;
                case "IssueID":
                    grdStock.Sort(this.grdStock.Columns["IssueID"], ListSortDirection.Ascending);
                    break;
            }
        }
    }
}
