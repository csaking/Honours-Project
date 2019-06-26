namespace HonoursApp
{
    partial class CreateEditAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditAccount));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbPrimaryID = new System.Windows.Forms.TextBox();
            this.lblPrimaryID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
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
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(186, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(259, 31);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Create/Edit Account";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.btnBack.Location = new System.Drawing.Point(12, 175);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.btnConfirm.Location = new System.Drawing.Point(342, 175);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(145, 40);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbPrimaryID
            // 
            this.tbPrimaryID.Location = new System.Drawing.Point(345, 73);
            this.tbPrimaryID.Name = "tbPrimaryID";
            this.tbPrimaryID.ReadOnly = true;
            this.tbPrimaryID.Size = new System.Drawing.Size(76, 20);
            this.tbPrimaryID.TabIndex = 13;
            // 
            // lblPrimaryID
            // 
            this.lblPrimaryID.AutoSize = true;
            this.lblPrimaryID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrimaryID.Location = new System.Drawing.Point(229, 71);
            this.lblPrimaryID.Name = "lblPrimaryID";
            this.lblPrimaryID.Size = new System.Drawing.Size(115, 24);
            this.lblPrimaryID.TabIndex = 14;
            this.lblPrimaryID.Text = "AccountID";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(345, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(345, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(142, 20);
            this.txtUsername.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(189, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(155, 24);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email Address";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(232, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(112, 24);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            // 
            // frmCreateEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(513, 228);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPrimaryID);
            this.Controls.Add(this.tbPrimaryID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "frmCreateEditAccount";
            this.Text = "Account Managment";
            this.Load += new System.EventHandler(this.frmCreateEditAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbPrimaryID;
        private System.Windows.Forms.Label lblPrimaryID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
    }
}