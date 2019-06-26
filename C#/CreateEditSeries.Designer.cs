namespace HonoursApp
{
    partial class CreateEditSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditSeries));
            this.lblPrimaryID = new System.Windows.Forms.Label();
            this.tbPrimaryID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimaryID
            // 
            this.lblPrimaryID.AutoSize = true;
            this.lblPrimaryID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimaryID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrimaryID.Location = new System.Drawing.Point(213, 67);
            this.lblPrimaryID.Name = "lblPrimaryID";
            this.lblPrimaryID.Size = new System.Drawing.Size(115, 24);
            this.lblPrimaryID.TabIndex = 20;
            this.lblPrimaryID.Text = "AccountID";
            // 
            // tbPrimaryID
            // 
            this.tbPrimaryID.Location = new System.Drawing.Point(334, 69);
            this.tbPrimaryID.Name = "tbPrimaryID";
            this.tbPrimaryID.ReadOnly = true;
            this.tbPrimaryID.Size = new System.Drawing.Size(76, 20);
            this.tbPrimaryID.TabIndex = 19;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.btnConfirm.Location = new System.Drawing.Point(359, 195);
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
            this.btnBack.Location = new System.Drawing.Point(12, 195);
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
            this.lblTitle.Location = new System.Drawing.Point(211, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 31);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Create/Edit Series";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(192, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Series Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(334, 95);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(76, 20);
            this.tbName.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(181, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Series Author";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(334, 120);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.Size = new System.Drawing.Size(76, 20);
            this.tbAuthor.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(223, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Publisher";
            // 
            // cbPublisher
            // 
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(334, 147);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(121, 21);
            this.cbPublisher.TabIndex = 27;
            // 
            // CreateEditSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(510, 247);
            this.Controls.Add(this.cbPublisher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPrimaryID);
            this.Controls.Add(this.tbPrimaryID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
            this.Name = "CreateEditSeries";
            this.Text = "Series Management";
            this.Load += new System.EventHandler(this.CreateEditSeries_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPublisher;
    }
}