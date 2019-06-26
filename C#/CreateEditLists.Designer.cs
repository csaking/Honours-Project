namespace HonoursApp
{
    partial class CreateEditLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditLists));
            this.lblPrimaryID = new System.Windows.Forms.Label();
            this.tbPrimaryID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.cbAccounts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimaryID
            // 
            this.lblPrimaryID.AutoSize = true;
            this.lblPrimaryID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrimaryID.Location = new System.Drawing.Point(220, 66);
            this.lblPrimaryID.Name = "lblPrimaryID";
            this.lblPrimaryID.Size = new System.Drawing.Size(73, 24);
            this.lblPrimaryID.TabIndex = 20;
            this.lblPrimaryID.Text = "List ID";
            // 
            // tbPrimaryID
            // 
            this.tbPrimaryID.Location = new System.Drawing.Point(299, 66);
            this.tbPrimaryID.Name = "tbPrimaryID";
            this.tbPrimaryID.ReadOnly = true;
            this.tbPrimaryID.Size = new System.Drawing.Size(76, 20);
            this.tbPrimaryID.TabIndex = 19;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.btnConfirm.Location = new System.Drawing.Point(269, 184);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(145, 40);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.btnBack.Location = new System.Drawing.Point(12, 184);
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
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(202, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 31);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Create/Edit Lists";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(168, 156);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 15;
            this.picLogo.TabStop = false;
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccounts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccounts.Location = new System.Drawing.Point(181, 92);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(112, 24);
            this.lblAccounts.TabIndex = 22;
            this.lblAccounts.Text = "Username";
            // 
            // cbAccounts
            // 
            this.cbAccounts.FormattingEnabled = true;
            this.cbAccounts.Location = new System.Drawing.Point(299, 93);
            this.cbAccounts.Name = "cbAccounts";
            this.cbAccounts.Size = new System.Drawing.Size(115, 21);
            this.cbAccounts.TabIndex = 23;
            this.cbAccounts.SelectedIndexChanged += new System.EventHandler(this.cbAccounts_SelectedIndexChanged);
            // 
            // CreateEditLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(444, 239);
            this.Controls.Add(this.cbAccounts);
            this.Controls.Add(this.lblAccounts);
            this.Controls.Add(this.lblPrimaryID);
            this.Controls.Add(this.tbPrimaryID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
            this.Name = "CreateEditLists";
            this.Text = "Lists Management";
            this.Load += new System.EventHandler(this.CreateEditLists_Load);
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
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.ComboBox cbAccounts;
    }
}