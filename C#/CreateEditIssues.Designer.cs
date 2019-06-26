namespace HonoursApp
{
    partial class CreateEditIssues
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditIssues));
            this.lblPrimaryID = new System.Windows.Forms.Label();
            this.tbPrimaryID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.cbSeries = new System.Windows.Forms.ComboBox();
            this.txtIssueNum = new System.Windows.Forms.TextBox();
            this.tbRDate = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblIssueNum = new System.Windows.Forms.Label();
            this.lblRDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimaryID
            // 
            this.lblPrimaryID.AutoSize = true;
            this.lblPrimaryID.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrimaryID.Location = new System.Drawing.Point(257, 56);
            this.lblPrimaryID.Name = "lblPrimaryID";
            this.lblPrimaryID.Size = new System.Drawing.Size(79, 22);
            this.lblPrimaryID.TabIndex = 20;
            this.lblPrimaryID.Text = "IssueID";
            // 
            // tbPrimaryID
            // 
            this.tbPrimaryID.Location = new System.Drawing.Point(342, 56);
            this.tbPrimaryID.Name = "tbPrimaryID";
            this.tbPrimaryID.ReadOnly = true;
            this.tbPrimaryID.Size = new System.Drawing.Size(45, 20);
            this.tbPrimaryID.TabIndex = 19;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(316, 237);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(145, 40);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(17, 237);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 40);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(180, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 31);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Create/Edit Issues";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(6, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(168, 156);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 15;
            this.picLogo.TabStop = false;
            // 
            // cbSeries
            // 
            this.cbSeries.FormattingEnabled = true;
            this.cbSeries.Location = new System.Drawing.Point(342, 91);
            this.cbSeries.Name = "cbSeries";
            this.cbSeries.Size = new System.Drawing.Size(119, 21);
            this.cbSeries.TabIndex = 22;
            // 
            // txtIssueNum
            // 
            this.txtIssueNum.Location = new System.Drawing.Point(342, 131);
            this.txtIssueNum.Name = "txtIssueNum";
            this.txtIssueNum.Size = new System.Drawing.Size(119, 20);
            this.txtIssueNum.TabIndex = 24;
            // 
            // tbRDate
            // 
            this.tbRDate.Location = new System.Drawing.Point(342, 202);
            this.tbRDate.MaxLength = 10;
            this.tbRDate.Name = "tbRDate";
            this.tbRDate.Size = new System.Drawing.Size(119, 20);
            this.tbRDate.TabIndex = 25;
            this.tbRDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(342, 165);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 20);
            this.txtPrice.TabIndex = 26;
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSeries.Location = new System.Drawing.Point(211, 90);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(126, 22);
            this.lblSeries.TabIndex = 28;
            this.lblSeries.Text = "Series Name";
            // 
            // lblIssueNum
            // 
            this.lblIssueNum.AutoSize = true;
            this.lblIssueNum.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblIssueNum.Location = new System.Drawing.Point(199, 131);
            this.lblIssueNum.Name = "lblIssueNum";
            this.lblIssueNum.Size = new System.Drawing.Size(138, 22);
            this.lblIssueNum.TabIndex = 29;
            this.lblIssueNum.Text = "Issue Number";
            // 
            // lblRDate
            // 
            this.lblRDate.AutoSize = true;
            this.lblRDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRDate.Location = new System.Drawing.Point(65, 200);
            this.lblRDate.Name = "lblRDate";
            this.lblRDate.Size = new System.Drawing.Size(272, 22);
            this.lblRDate.TabIndex = 30;
            this.lblRDate.Text = "Release Date (YYYY-MM-DD)";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(279, 165);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 22);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = "Price";
            // 
            // CreateEditIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(69)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(491, 291);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRDate);
            this.Controls.Add(this.lblIssueNum);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.tbRDate);
            this.Controls.Add(this.txtIssueNum);
            this.Controls.Add(this.cbSeries);
            this.Controls.Add(this.lblPrimaryID);
            this.Controls.Add(this.tbPrimaryID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
            this.Name = "CreateEditIssues";
            this.Text = "Issues Management";
            this.Load += new System.EventHandler(this.CreateEditIssues_Load);
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
        private System.Windows.Forms.ComboBox cbSeries;
        private System.Windows.Forms.TextBox txtIssueNum;
        private System.Windows.Forms.TextBox tbRDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblIssueNum;
        private System.Windows.Forms.Label lblRDate;
        private System.Windows.Forms.Label lblPrice;
    }
}