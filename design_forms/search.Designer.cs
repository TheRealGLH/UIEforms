namespace design_forms
{
    partial class search
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
            this.lblSearchName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(346, 108);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(89, 31);
            this.lblSearchName.TabIndex = 13;
            this.lblSearchName.Text = "%help";
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(335, 17);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 88);
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(321, 518);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(142, 26);
            this.lblBack.TabIndex = 11;
            this.lblBack.Text = "%menuback";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lblBack);
            this.Name = "search";
            this.Text = "search";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblBack;
    }
}