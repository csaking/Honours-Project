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
    public partial class frmAccounts : Form
    {
        private MySqlDataAdapter AccountsDA;

        public frmAccounts()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            accountsGridLoad();
        }

        private void grdAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateEditAccount CreateAccountForm = new CreateEditAccount(0);
            CreateAccountForm.ShowDialog();
            this.Update();
            this.Refresh();
            accountsGridLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CreateEditAccount EditAccountForm = new CreateEditAccount(1, grdAccounts.Rows[grdAccounts.CurrentCell.RowIndex].Cells[0].Value.ToString());
            EditAccountForm.ShowDialog();
            this.Update();
            this.Refresh();
            accountsGridLoad();
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
                string storedProc = "RemoveAccountAndLinkedData";
                MySqlCommand cmd = new MySqlCommand(storedProc, connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("?aID", Convert.ToInt32(grdAccounts.Rows[grdAccounts.CurrentCell.RowIndex].Cells[0].Value.ToString())));
                //Confirmation
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this item? This will delete all Lists associated with this account.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (confirmation.Equals(DialogResult.OK))
                {
                    //execute procedure upon positive confirmation
                    int i = cmd.ExecuteNonQuery();
                }
                //close connection
                connection.Close();
                accountsGridLoad();
            }
        }

        private void accountsGridLoad()
        {
            try
            {
                ConnectionClass.OpenConnection();
                DataSet AccountsDS = new DataSet();
                AccountsDA = new MySqlDataAdapter("SELECT * FROM tblaccounts", ConnectionClass.con);
                AccountsDA.Fill(AccountsDS);
                grdAccounts.DataSource = AccountsDS.Tables[0];
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error contacting the database. Refresh your connection and try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbSort.Text)
            {
                case "AccountID":
                    grdAccounts.Sort(this.grdAccounts.Columns["AccountID"], ListSortDirection.Ascending);
                    break;
                case "Email":
                    grdAccounts.Sort(this.grdAccounts.Columns["Email"], ListSortDirection.Ascending);
                    break;
                case "Username":
                    grdAccounts.Sort(this.grdAccounts.Columns["Username"], ListSortDirection.Ascending);
                    break;
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
