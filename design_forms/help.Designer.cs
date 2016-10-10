namespace design_forms
{
    partial class help
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
            this.lblBack = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblHelpName = new System.Windows.Forms.Label();
            this.btnForum = new System.Windows.Forms.Button();
            this.btnBugReport = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(310, 513);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(142, 26);
            this.lblBack.TabIndex = 8;
            this.lblBack.Text = "%menuback";
            // 
            // logo
            // 
            this.logo.Image = global::design_forms.Properties.Resources.imageedit_1_4773648694;
            this.logo.Location = new System.Drawing.Point(268, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            // 
            // lblHelpName
            // 
            this.lblHelpName.AutoSize = true;
            this.lblHelpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpName.Location = new System.Drawing.Point(327, 115);
            this.lblHelpName.Name = "lblHelpName";
            this.lblHelpName.Size = new System.Drawing.Size(89, 31);
            this.lblHelpName.TabIndex = 10;
            this.lblHelpName.Text = "%help";
            // 
            // btnForum
            // 
            this.btnForum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForum.Location = new System.Drawing.Point(242, 189);
            this.btnForum.Name = "btnForum";
            this.btnForum.Size = new System.Drawing.Size(252, 56);
            this.btnForum.TabIndex = 11;
            this.btnForum.Text = "%forum";
            this.btnForum.UseVisualStyleBackColor = true;
            // 
            // btnBugReport
            // 
            this.btnBugReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBugReport.Location = new System.Drawing.Point(242, 266);
            this.btnBugReport.Name = "btnBugReport";
            this.btnBugReport.Size = new System.Drawing.Size(252, 56);
            this.btnBugReport.TabIndex = 11;
            this.btnBugReport.Text = "%bugreport";
            this.btnBugReport.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(242, 337);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(252, 56);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "%about";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnBugReport);
            this.Controls.Add(this.btnForum);
            this.Controls.Add(this.lblHelpName);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lblBack);
            this.Name = "help";
            this.Text = "help";
            this.Load += new System.EventHandler(this.help_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblHelpName;
        private System.Windows.Forms.Button btnForum;
        private System.Windows.Forms.Button btnBugReport;
        private System.Windows.Forms.Button btnAbout;
    }
}