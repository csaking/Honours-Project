namespace HonoursApp
{
    partial class CreateEditMisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditMisc));
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cbiID = new System.Windows.Forms.ComboBox();
            this.cblID = new System.Windows.Forms.ComboBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtPubName = new System.Windows.Forms.TextBox();
            this.lblUID = new System.Windows.Forms.Label();
            this.lblPubName = new System.Windows.Forms.Label();
            this.lblIssueID = new System.Windows.Forms.Label();
            this.lblListID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.btnConfirm.Location = new System.Drawing.Point(272, 174);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(145, 40);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.btnBack.Location = new System.Drawing.Point(12, 174);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 40);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(204, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 31);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Create/Edit Misc";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(168, 156);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 13;
            this.picLogo.TabStop = false;
            // 
            // cbiID
            // 
            this.cbiID.FormattingEnabled = true;
            this.cbiID.Location = new System.Drawing.Point(296, 90);
            this.cbiID.Name = "cbiID";
            this.cbiID.Size = new System.Drawing.Size(121, 21);
            this.cbiID.TabIndex = 17;
            this.cbiID.SelectedIndexChanged += new System.EventHandler(this.cbiID_SelectedIndexChanged);
            // 
            // cblID
            // 
            this.cblID.FormattingEnabled = true;
            this.cblID.Location = new System.Drawing.Point(296, 117);
            this.cblID.Name = "cblID";
            this.cblID.Size = new System.Drawing.Size(121, 21);
            this.cblID.TabIndex = 18;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(310, 54);
            this.txtUID.Name = "txtUID";
            this.txtUID.ReadOnly = true;
            this.txtUID.Size = new System.Drawing.Size(39, 20);
            this.txtUID.TabIndex = 19;
            // 
            // txtPubName
            // 
            this.txtPubName.Location = new System.Drawing.Point(255, 112);
            this.txtPubName.Name = "txtPubName";
            this.txtPubName.Size = new System.Drawing.Size(113, 20);
            this.txtPubName.TabIndex = 20;
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUID.Location = new System.Drawing.Point(198, 54);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(106, 24);
            this.lblUID.TabIndex = 21;
            this.lblUID.Text = "Unique ID";
            // 
            // lblPubName
            // 
            this.lblPubName.AutoSize = true;
            this.lblPubName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPubName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPubName.Location = new System.Drawing.Point(228, 85);
            this.lblPubName.Name = "lblPubName";
            this.lblPubName.Size = new System.Drawing.Size(168, 24);
            this.lblPubName.TabIndex = 22;
            this.lblPubName.Text = "Publisher Name";
            this.lblPubName.Click += new System.EventHandler(this.lblPubName_Click);
            // 
            // lblIssueID
            // 
            this.lblIssueID.AutoSize = true;
            this.lblIssueID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblIssueID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIssueID.Location = new System.Drawing.Point(206, 90);
            this.lblIssueID.Name = "lblIssueID";
            this.lblIssueID.Size = new System.Drawing.Size(90, 24);
            this.lblIssueID.TabIndex = 23;
            this.lblIssueID.Text = "Issue ID";
            // 
            // lblListID
            // 
            this.lblListID.AutoSize = true;
            this.lblListID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblListID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListID.Location = new System.Drawing.Point(217, 114);
            this.lblListID.Name = "lblListID";
            this.lblListID.Size = new System.Drawing.Size(73, 24);
            this.lblListID.TabIndex = 24;
            this.lblListID.Text = "List ID";
            // 
            // CreateEditMisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(429, 224);
            this.Controls.Add(this.lblListID);
            this.Controls.Add(this.lblIssueID);
            this.Controls.Add(this.lblPubName);
            this.Controls.Add(this.lblUID);
            this.Controls.Add(this.txtPubName);
            this.Controls.Add(this.txtUID);
            this.Controls.Add(this.cblID);
            this.Controls.Add(this.cbiID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
            this.Name = "CreateEditMisc";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.frmCreateEditMisc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ComboBox cbiID;
        private System.Windows.Forms.ComboBox cblID;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.TextBox txtPubName;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Label lblPubName;
        private System.Windows.Forms.Label lblIssueID;
        private System.Windows.Forms.Label lblListID;
    }
}