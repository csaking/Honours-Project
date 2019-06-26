namespace HonoursApp
{
    partial class CreateEditStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditStock));
            this.lblPrimaryID = new System.Windows.Forms.Label();
            this.tbPrimaryID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.cbIssues = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimaryID
            // 
            this.lblPrimaryID.AutoSize = true;
            this.lblPrimaryID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPrimaryID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrimaryID.Location = new System.Drawing.Point(252, 69);
            this.lblPrimaryID.Name = "lblPrimaryID";
            this.lblPrimaryID.Size = new System.Drawing.Size(88, 24);
            this.lblPrimaryID.TabIndex = 20;
            this.lblPrimaryID.Text = "StockID";
            // 
            // tbPrimaryID
            // 
            this.tbPrimaryID.Location = new System.Drawing.Point(346, 69);
            this.tbPrimaryID.Name = "tbPrimaryID";
            this.tbPrimaryID.ReadOnly = true;
            this.tbPrimaryID.Size = new System.Drawing.Size(76, 20);
            this.tbPrimaryID.TabIndex = 19;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.btnConfirm.Location = new System.Drawing.Point(325, 173);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(145, 40);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.btnBack.Location = new System.Drawing.Point(15, 174);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 40);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(215, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 31);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Create/Edit Stock";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(15, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(168, 156);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 15;
            this.picLogo.TabStop = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumber.Location = new System.Drawing.Point(189, 93);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(153, 24);
            this.lblNumber.TabIndex = 22;
            this.lblNumber.Text = "Stock Number";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(346, 95);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(76, 20);
            this.tbNumber.TabIndex = 21;
            this.tbNumber.TextChanged += new System.EventHandler(this.tbNumber_TextChanged);
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblIssue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIssue.Location = new System.Drawing.Point(256, 118);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(84, 24);
            this.lblIssue.TabIndex = 23;
            this.lblIssue.Text = "IssueID";
            // 
            // cbIssues
            // 
            this.cbIssues.FormattingEnabled = true;
            this.cbIssues.Location = new System.Drawing.Point(346, 121);
            this.cbIssues.Name = "cbIssues";
            this.cbIssues.Size = new System.Drawing.Size(121, 21);
            this.cbIssues.TabIndex = 24;
            // 
            // CreateEditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(485, 225);
            this.Controls.Add(this.cbIssues);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lblPrimaryID);
            this.Controls.Add(this.tbPrimaryID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "CreateEditStock";
            this.Text = "Stock Management";
            this.Load += new System.EventHandler(this.CreateEditStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimaryID;
        private System.Windows.Forms.TextBox tbPrimaryID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.ComboBox cbIssues;
    }
}