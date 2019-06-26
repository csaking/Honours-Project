namespace HonoursApp
{
    partial class frmIssues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssues));
            this.btnBack = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grdIssues = new System.Windows.Forms.DataGridView();
            this.btnImage = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnBack.Location = new System.Drawing.Point(23, 358);
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
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnDelete.Location = new System.Drawing.Point(23, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnEdit.Location = new System.Drawing.Point(23, 220);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 40);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnNew.Location = new System.Drawing.Point(23, 174);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(145, 40);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grdIssues
            // 
            this.grdIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIssues.Location = new System.Drawing.Point(198, 69);
            this.grdIssues.Name = "grdIssues";
            this.grdIssues.Size = new System.Drawing.Size(776, 329);
            this.grdIssues.TabIndex = 6;
            this.grdIssues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdIssues_CellContentClick);
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnImage.Location = new System.Drawing.Point(23, 312);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(145, 40);
            this.btnImage.TabIndex = 10;
            this.btnImage.Text = "Add Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.lbl1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(527, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(134, 45);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Issues";
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnSort.Location = new System.Drawing.Point(829, 404);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(145, 40);
            this.btnSort.TabIndex = 14;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "IssueID",
            "SeriesID",
            "IssueNumber",
            "Price",
            "ReleaseDate"});
            this.cbSort.Location = new System.Drawing.Point(702, 417);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 21);
            this.cbSort.TabIndex = 13;
            // 
            // frmIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1002, 465);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grdIssues);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnBack);
            this.Name = "frmIssues";
            this.Text = "Issues Menu";
            this.Load += new System.EventHandler(this.frmIssues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIssues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView grdIssues;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox cbSort;
    }
}