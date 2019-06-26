namespace HonoursApp
{
    partial class frmSeries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeries));
            this.btnBack = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnDeleteSeries = new System.Windows.Forms.Button();
            this.btnEditSeries = new System.Windows.Forms.Button();
            this.btnNewSeries = new System.Windows.Forms.Button();
            this.grdSeries = new System.Windows.Forms.DataGridView();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.grdPublisher = new System.Windows.Forms.DataGridView();
            this.btnDeletePub = new System.Windows.Forms.Button();
            this.btnEditPub = new System.Windows.Forms.Button();
            this.btnNewPub = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.btnSortSeries = new System.Windows.Forms.Button();
            this.cbSortSeries = new System.Windows.Forms.ComboBox();
            this.btnSortPub = new System.Windows.Forms.Button();
            this.cbSortPub = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnBack.Location = new System.Drawing.Point(21, 312);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(168, 156);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // btnDeleteSeries
            // 
            this.btnDeleteSeries.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnDeleteSeries.Location = new System.Drawing.Point(21, 266);
            this.btnDeleteSeries.Name = "btnDeleteSeries";
            this.btnDeleteSeries.Size = new System.Drawing.Size(145, 40);
            this.btnDeleteSeries.TabIndex = 9;
            this.btnDeleteSeries.Text = "Delete";
            this.btnDeleteSeries.UseVisualStyleBackColor = true;
            this.btnDeleteSeries.Click += new System.EventHandler(this.btnDeleteSeries_Click);
            // 
            // btnEditSeries
            // 
            this.btnEditSeries.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnEditSeries.Location = new System.Drawing.Point(21, 220);
            this.btnEditSeries.Name = "btnEditSeries";
            this.btnEditSeries.Size = new System.Drawing.Size(145, 40);
            this.btnEditSeries.TabIndex = 8;
            this.btnEditSeries.Text = "Edit";
            this.btnEditSeries.UseVisualStyleBackColor = true;
            this.btnEditSeries.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNewSeries
            // 
            this.btnNewSeries.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnNewSeries.Location = new System.Drawing.Point(21, 174);
            this.btnNewSeries.Name = "btnNewSeries";
            this.btnNewSeries.Size = new System.Drawing.Size(145, 40);
            this.btnNewSeries.TabIndex = 7;
            this.btnNewSeries.Text = "New";
            this.btnNewSeries.UseVisualStyleBackColor = true;
            this.btnNewSeries.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grdSeries
            // 
            this.grdSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSeries.Location = new System.Drawing.Point(186, 60);
            this.grdSeries.Name = "grdSeries";
            this.grdSeries.Size = new System.Drawing.Size(530, 292);
            this.grdSeries.TabIndex = 6;
            this.grdSeries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSeries_CellContentClick);
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle1.Location = new System.Drawing.Point(376, 9);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(130, 45);
            this.lblTitle1.TabIndex = 10;
            this.lblTitle1.Text = "Series";
            // 
            // grdPublisher
            // 
            this.grdPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPublisher.Location = new System.Drawing.Point(722, 60);
            this.grdPublisher.Name = "grdPublisher";
            this.grdPublisher.Size = new System.Drawing.Size(334, 292);
            this.grdPublisher.TabIndex = 11;
            this.grdPublisher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPublisher_CellContentClick);
            // 
            // btnDeletePub
            // 
            this.btnDeletePub.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnDeletePub.Location = new System.Drawing.Point(1062, 266);
            this.btnDeletePub.Name = "btnDeletePub";
            this.btnDeletePub.Size = new System.Drawing.Size(145, 40);
            this.btnDeletePub.TabIndex = 14;
            this.btnDeletePub.Text = "Delete";
            this.btnDeletePub.UseVisualStyleBackColor = true;
            this.btnDeletePub.Click += new System.EventHandler(this.btnDeletePub_Click);
            // 
            // btnEditPub
            // 
            this.btnEditPub.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnEditPub.Location = new System.Drawing.Point(1062, 220);
            this.btnEditPub.Name = "btnEditPub";
            this.btnEditPub.Size = new System.Drawing.Size(145, 40);
            this.btnEditPub.TabIndex = 13;
            this.btnEditPub.Text = "Edit";
            this.btnEditPub.UseVisualStyleBackColor = true;
            this.btnEditPub.Click += new System.EventHandler(this.btnEditPub_Click);
            // 
            // btnNewPub
            // 
            this.btnNewPub.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnNewPub.Location = new System.Drawing.Point(1062, 174);
            this.btnNewPub.Name = "btnNewPub";
            this.btnNewPub.Size = new System.Drawing.Size(145, 40);
            this.btnNewPub.TabIndex = 12;
            this.btnNewPub.Text = "New";
            this.btnNewPub.UseVisualStyleBackColor = true;
            this.btnNewPub.Click += new System.EventHandler(this.btnNewPub_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle2.Location = new System.Drawing.Point(773, 9);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(204, 45);
            this.lblTitle2.TabIndex = 15;
            this.lblTitle2.Text = "Publishers";
            // 
            // btnSortSeries
            // 
            this.btnSortSeries.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnSortSeries.Location = new System.Drawing.Point(571, 358);
            this.btnSortSeries.Name = "btnSortSeries";
            this.btnSortSeries.Size = new System.Drawing.Size(145, 40);
            this.btnSortSeries.TabIndex = 17;
            this.btnSortSeries.Text = "Sort";
            this.btnSortSeries.UseVisualStyleBackColor = true;
            this.btnSortSeries.Click += new System.EventHandler(this.btnSortSeries_Click);
            // 
            // cbSortSeries
            // 
            this.cbSortSeries.FormattingEnabled = true;
            this.cbSortSeries.Items.AddRange(new object[] {
            "SeriesID",
            "Name",
            "Author",
            "PublisherID"});
            this.cbSortSeries.Location = new System.Drawing.Point(444, 371);
            this.cbSortSeries.Name = "cbSortSeries";
            this.cbSortSeries.Size = new System.Drawing.Size(121, 21);
            this.cbSortSeries.TabIndex = 16;
            this.cbSortSeries.SelectedIndexChanged += new System.EventHandler(this.cbSortSeries_SelectedIndexChanged);
            // 
            // btnSortPub
            // 
            this.btnSortPub.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortPub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnSortPub.Location = new System.Drawing.Point(911, 358);
            this.btnSortPub.Name = "btnSortPub";
            this.btnSortPub.Size = new System.Drawing.Size(145, 40);
            this.btnSortPub.TabIndex = 19;
            this.btnSortPub.Text = "Sort";
            this.btnSortPub.UseVisualStyleBackColor = true;
            this.btnSortPub.Click += new System.EventHandler(this.btnSortPub_Click);
            // 
            // cbSortPub
            // 
            this.cbSortPub.FormattingEnabled = true;
            this.cbSortPub.Items.AddRange(new object[] {
            "PublisherID",
            "Name"});
            this.cbSortPub.Location = new System.Drawing.Point(784, 371);
            this.cbSortPub.Name = "cbSortPub";
            this.cbSortPub.Size = new System.Drawing.Size(121, 21);
            this.cbSortPub.TabIndex = 18;
            // 
            // frmSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1217, 423);
            this.Controls.Add(this.btnSortPub);
            this.Controls.Add(this.cbSortPub);
            this.Controls.Add(this.btnSortSeries);
            this.Controls.Add(this.cbSortSeries);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.btnDeletePub);
            this.Controls.Add(this.btnEditPub);
            this.Controls.Add(this.btnNewPub);
            this.Controls.Add(this.grdPublisher);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.btnDeleteSeries);
            this.Controls.Add(this.btnEditSeries);
            this.Controls.Add(this.btnNewSeries);
            this.Controls.Add(this.grdSeries);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnBack);
            this.Name = "frmSeries";
            this.Text = "Series Menu";
            this.Load += new System.EventHandler(this.frmSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPublisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnDeleteSeries;
        private System.Windows.Forms.Button btnEditSeries;
        private System.Windows.Forms.Button btnNewSeries;
        private System.Windows.Forms.DataGridView grdSeries;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.DataGridView grdPublisher;
        private System.Windows.Forms.Button btnDeletePub;
        private System.Windows.Forms.Button btnEditPub;
        private System.Windows.Forms.Button btnNewPub;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Button btnSortSeries;
        private System.Windows.Forms.ComboBox cbSortSeries;
        private System.Windows.Forms.Button btnSortPub;
        private System.Windows.Forms.ComboBox cbSortPub;
    }
}