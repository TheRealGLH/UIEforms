namespace design_forms
{
    partial class settings
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblSettingsName = new System.Windows.Forms.Label();
            this.gBoxUI = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.lblScale = new System.Windows.Forms.Label();
            this.btnLoadPreset = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.cboxLang = new System.Windows.Forms.ComboBox();
            this.cboxColor = new System.Windows.Forms.ComboBox();
            this.cboxFont = new System.Windows.Forms.ComboBox();
            this.cboxScale = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.gBoxUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(324, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 88);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // lblSettingsName
            // 
            this.lblSettingsName.AutoSize = true;
            this.lblSettingsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsName.Location = new System.Drawing.Point(309, 103);
            this.lblSettingsName.Name = "lblSettingsName";
            this.lblSettingsName.Size = new System.Drawing.Size(133, 31);
            this.lblSettingsName.TabIndex = 1;
            this.lblSettingsName.Text = "%settings";
            this.lblSettingsName.Click += new System.EventHandler(this.label1_Click);
            // 
            // gBoxUI
            // 
            this.gBoxUI.Controls.Add(this.cboxScale);
            this.gBoxUI.Controls.Add(this.cboxFont);
            this.gBoxUI.Controls.Add(this.cboxColor);
            this.gBoxUI.Controls.Add(this.lblColor);
            this.gBoxUI.Controls.Add(this.lblScale);
            this.gBoxUI.Controls.Add(this.lblFont);
            this.gBoxUI.Location = new System.Drawing.Point(130, 230);
            this.gBoxUI.Name = "gBoxUI";
            this.gBoxUI.Size = new System.Drawing.Size(493, 214);
            this.gBoxUI.TabIndex = 2;
            this.gBoxUI.TabStop = false;
            this.gBoxUI.Text = "ui";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(26, 31);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(63, 20);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "%color";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.Location = new System.Drawing.Point(247, 168);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(98, 20);
            this.lblLang.TabIndex = 5;
            this.lblLang.Text = "%language";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(26, 64);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(56, 20);
            this.lblFont.TabIndex = 6;
            this.lblFont.Text = "%font";
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScale.Location = new System.Drawing.Point(26, 93);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(66, 20);
            this.lblScale.TabIndex = 7;
            this.lblScale.Text = "%scale";
            // 
            // btnLoadPreset
            // 
            this.btnLoadPreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPreset.Location = new System.Drawing.Point(285, 450);
            this.btnLoadPreset.Name = "btnLoadPreset";
            this.btnLoadPreset.Size = new System.Drawing.Size(175, 42);
            this.btnLoadPreset.TabIndex = 6;
            this.btnLoadPreset.Text = "%presetload";
            this.btnLoadPreset.UseVisualStyleBackColor = true;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(310, 513);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(142, 26);
            this.lblBack.TabIndex = 7;
            this.lblBack.Text = "%menuback";
            this.lblBack.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboxLang
            // 
            this.cboxLang.FormattingEnabled = true;
            this.cboxLang.Items.AddRange(new object[] {
            "English",
            "Nederlands",
            "Español"});
            this.cboxLang.Location = new System.Drawing.Point(372, 170);
            this.cboxLang.Name = "cboxLang";
            this.cboxLang.Size = new System.Drawing.Size(121, 21);
            this.cboxLang.TabIndex = 8;
            // 
            // cboxColor
            // 
            this.cboxColor.FormattingEnabled = true;
            this.cboxColor.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green",
            "White",
            "Black"});
            this.cboxColor.Location = new System.Drawing.Point(357, 30);
            this.cboxColor.Name = "cboxColor";
            this.cboxColor.Size = new System.Drawing.Size(121, 21);
            this.cboxColor.TabIndex = 8;
            // 
            // cboxFont
            // 
            this.cboxFont.FormattingEnabled = true;
            this.cboxFont.Items.AddRange(new object[] {
            "Arial",
            "Comic Sans",
            "Times New Roman",
            "Helvetica Standard"});
            this.cboxFont.Location = new System.Drawing.Point(357, 63);
            this.cboxFont.Name = "cboxFont";
            this.cboxFont.Size = new System.Drawing.Size(121, 21);
            this.cboxFont.TabIndex = 8;
            // 
            // cboxScale
            // 
            this.cboxScale.FormattingEnabled = true;
            this.cboxScale.Location = new System.Drawing.Point(357, 92);
            this.cboxScale.Name = "cboxScale";
            this.cboxScale.Size = new System.Drawing.Size(121, 21);
            this.cboxScale.TabIndex = 8;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cboxLang);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnLoadPreset);
            this.Controls.Add(this.gBoxUI);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.lblSettingsName);
            this.Controls.Add(this.logo);
            this.Name = "settings";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.gBoxUI.ResumeLayout(false);
            this.gBoxUI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblSettingsName;
        private System.Windows.Forms.GroupBox gBoxUI;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Button btnLoadPreset;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.ComboBox cboxLang;
        private System.Windows.Forms.ComboBox cboxScale;
        private System.Windows.Forms.ComboBox cboxFont;
        private System.Windows.Forms.ComboBox cboxColor;
    }
}

