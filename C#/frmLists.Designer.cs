namespace HonoursApp
{
    partial class frmLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLists));
            this.btnBack = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnEditList = new System.Windows.Forms.Button();
            this.btnNewList = new System.Windows.Forms.Button();
            this.grdLists = new System.Windows.Forms.DataGridView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.grdListIssues = new System.Windows.Forms.DataGridView();
            this.lblLists = new System.Windows.Forms.Label();
            this.lblContents = new System.Windows.Forms.Label();
            this.btnDeleteContent = new System.Windows.Forms.Button();
            this.btnEditContent = new System.Windows.Forms.Button();
            this.btnNewContent = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSortLists = new System.Windows.Forms.Button();
            this.cbSortLists = new System.Windows.Forms.ComboBox();
            this.btnSortContent = new System.Windows.Forms.Button();
            this.cbSortContent = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListIssues)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnBack.Location = new System.Drawing.Point(26, 358);
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
            // btnDeleteList
            // 
            this.btnDeleteList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnDeleteList.Location = new System.Drawing.Point(26, 266);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(145, 40);
            this.btnDeleteList.TabIndex = 9;
            this.btnDeleteList.Text = "Delete";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnEditList
            // 
            this.btnEditList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnEditList.Location = new System.Drawing.Point(26, 220);
            this.btnEditList.Name = "btnEditList";
            this.btnEditList.Size = new System.Drawing.Size(145, 40);
            this.btnEditList.TabIndex = 8;
            this.btnEditList.Text = "Edit";
            this.btnEditList.UseVisualStyleBackColor = true;
            this.btnEditList.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNewList
            // 
            this.btnNewList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnNewList.Location = new System.Drawing.Point(26, 174);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(145, 40);
            this.btnNewList.TabIndex = 7;
            this.btnNewList.Text = "New";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grdLists
            // 
            this.grdLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLists.Location = new System.Drawing.Point(186, 96);
            this.grdLists.Name = "grdLists";
            this.grdLists.Size = new System.Drawing.Size(271, 302);
            this.grdLists.TabIndex = 6;
            this.grdLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLists_CellContentClick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl1.Location = new System.Drawing.Point(419, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(199, 45);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "User Lists";
            // 
            // grdListIssues
            // 
            this.grdListIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListIssues.Location = new System.Drawing.Point(463, 96);
            this.grdListIssues.Name = "grdListIssues";
            this.grdListIssues.Size = new System.Drawing.Size(485, 302);
            this.grdListIssues.TabIndex = 11;
            // 
            // lblLists
            // 
            this.lblLists.AutoSize = true;
            this.lblLists.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLists.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLists.Location = new System.Drawing.Point(273, 48);
            this.lblLists.Name = "lblLists";
            this.lblLists.Size = new System.Drawing.Size(106, 45);
            this.lblLists.TabIndex = 12;
            this.lblLists.Text = "Lists";
            this.lblLists.Click += new System.EventHandler(this.lblLists_Click);
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContents.Location = new System.Drawing.Point(597, 48);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(254, 45);
            this.lblContents.TabIndex = 13;
            this.lblContents.Text = "List Contents";
            // 
            // btnDeleteContent
            // 
            this.btnDeleteContent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnDeleteContent.Location = new System.Drawing.Point(955, 266);
            this.btnDeleteContent.Name = "btnDeleteContent";
            this.btnDeleteContent.Size = new System.Drawing.Size(145, 40);
            this.btnDeleteContent.TabIndex = 16;
            this.btnDeleteContent.Text = "Delete";
            this.btnDeleteContent.UseVisualStyleBackColor = true;
            this.btnDeleteContent.Click += new System.EventHandler(this.btnDeleteContent_Click);
            // 
            // btnEditContent
            // 
            this.btnEditContent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnEditContent.Location = new System.Drawing.Point(955, 220);
            this.btnEditContent.Name = "btnEditContent";
            this.btnEditContent.Size = new System.Drawing.Size(145, 40);
            this.btnEditContent.TabIndex = 15;
            this.btnEditContent.Text = "Edit";
            this.btnEditContent.UseVisualStyleBackColor = true;
            this.btnEditContent.Click += new System.EventHandler(this.btnEditContent_Click);
            // 
            // btnNewContent
            // 
            this.btnNewContent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnNewContent.Location = new System.Drawing.Point(955, 174);
            this.btnNewContent.Name = "btnNewContent";
            this.btnNewContent.Size = new System.Drawing.Size(145, 40);
            this.btnNewContent.TabIndex = 14;
            this.btnNewContent.Text = "New";
            this.btnNewContent.UseVisualStyleBackColor = true;
            this.btnNewContent.Click += new System.EventHandler(this.btnNewContent_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnEmail.Location = new System.Drawing.Point(26, 312);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(145, 40);
            this.btnEmail.TabIndex = 17;
            this.btnEmail.Text = "Send Emails";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnLoad.Location = new System.Drawing.Point(955, 128);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(145, 40);
            this.btnLoad.TabIndex = 18;
            this.btnLoad.Text = "Load List";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSortLists
            // 
            this.btnSortLists.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortLists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnSortLists.Location = new System.Drawing.Point(312, 404);
            this.btnSortLists.Name = "btnSortLists";
            this.btnSortLists.Size = new System.Drawing.Size(145, 40);
            this.btnSortLists.TabIndex = 20;
            this.btnSortLists.Text = "Sort";
            this.btnSortLists.UseVisualStyleBackColor = true;
            this.btnSortLists.Click += new System.EventHandler(this.btnSortLists_Click);
            // 
            // cbSortLists
            // 
            this.cbSortLists.FormattingEnabled = true;
            this.cbSortLists.Items.AddRange(new object[] {
            "ListID",
            "AccountID"});
            this.cbSortLists.Location = new System.Drawing.Point(185, 417);
            this.cbSortLists.Name = "cbSortLists";
            this.cbSortLists.Size = new System.Drawing.Size(121, 21);
            this.cbSortLists.TabIndex = 19;
            // 
            // btnSortContent
            // 
            this.btnSortContent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.btnSortContent.Location = new System.Drawing.Point(803, 404);
            this.btnSortContent.Name = "btnSortContent";
            this.btnSortContent.Size = new System.Drawing.Size(145, 40);
            this.btnSortContent.TabIndex = 22;
            this.btnSortContent.Text = "Sort";
            this.btnSortContent.UseVisualStyleBackColor = true;
            this.btnSortContent.Click += new System.EventHandler(this.btnSortContent_Click);
            // 
            // cbSortContent
            // 
            this.cbSortContent.FormattingEnabled = true;
            this.cbSortContent.Items.AddRange(new object[] {
            "Name",
            "Author",
            "IssueNumber",
            "Price",
            "ReleaseDate",
            "ListIssueID"});
            this.cbSortContent.Location = new System.Drawing.Point(676, 417);
            this.cbSortContent.Name = "cbSortContent";
            this.cbSortContent.Size = new System.Drawing.Size(121, 21);
            this.cbSortContent.TabIndex = 21;
            // 
            // frmLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1112, 457);
            this.Controls.Add(this.btnSortContent);
            this.Controls.Add(this.cbSortContent);
            this.Controls.Add(this.btnSortLists);
            this.Controls.Add(this.cbSortLists);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnDeleteContent);
            this.Controls.Add(this.btnEditContent);
            this.Controls.Add(this.btnNewContent);
            this.Controls.Add(this.lblContents);
            this.Controls.Add(this.lblLists);
            this.Controls.Add(this.grdListIssues);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.btnEditList);
            this.Controls.Add(this.btnNewList);
            this.Controls.Add(this.grdLists);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnBack);
            this.Name = "frmLists";
            this.Text = "Lists Menu";
            this.Load += new System.EventHandler(this.frmLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListIssues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnEditList;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.DataGridView grdLists;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView grdListIssues;
        private System.Windows.Forms.Label lblLists;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.Button btnDeleteContent;
        private System.Windows.Forms.Button btnEditContent;
        private System.Windows.Forms.Button btnNewContent;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSortLists;
        private System.Windows.Forms.ComboBox cbSortLists;
        private System.Windows.Forms.Button btnSortContent;
        private System.Windows.Forms.ComboBox cbSortContent;
    }
}