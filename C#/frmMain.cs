using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HonoursApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            showStart();
        }

        private void showStart()
        {
            btnAccounts.Visible = true;
            btnLists.Visible = true;
            btnIssues.Visible = true;
            btnSeries.Visible = true;
            btnStock.Visible = true;
            btnExit.Visible = true;
        }

        private void hideStart()
        {
            btnAccounts.Visible = false;
            btnLists.Visible = false;
            btnIssues.Visible = false;
            btnSeries.Visible = false;
            btnStock.Visible = false;
            btnExit.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to want to exit the whole program?", "Confirmation!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            frmAccounts AccountForm = new frmAccounts();
            AccountForm.ShowDialog();
        }

        private void btnIssues_Click(object sender, EventArgs e)
        {
            frmIssues IssuesForm = new frmIssues();
            IssuesForm.ShowDialog();
        }

        private void btnLists_Click(object sender, EventArgs e)
        {
            frmLists ListsForm = new frmLists();
            ListsForm.ShowDialog();
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            frmSeries SeriesForm = new frmSeries();
            SeriesForm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock StockForm = new frmStock();
            StockForm.ShowDialog();
        }

    }
}
