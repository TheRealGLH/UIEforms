namespace design_forms
{
    partial class MainMenu
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEmulator = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(444, 301);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(184, 56);
            this.btnHelp.TabIndex = 26;
            this.btnHelp.Text = "%Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(151, 301);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(184, 56);
            this.btnSettings.TabIndex = 25;
            this.btnSettings.Text = "%Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(536, 172);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(184, 56);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "%Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEmulator
            // 
            this.btnEmulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmulator.Location = new System.Drawing.Point(293, 172);
            this.btnEmulator.Name = "btnEmulator";
            this.btnEmulator.Size = new System.Drawing.Size(184, 56);
            this.btnEmulator.TabIndex = 23;
            this.btnEmulator.Text = "%Emulator";
            this.btnEmulator.UseVisualStyleBackColor = true;
            // 
            // btnGame
            // 
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.Location = new System.Drawing.Point(44, 172);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(184, 56);
            this.btnGame.TabIndex = 22;
            this.btnGame.Text = "%Game";
            this.btnGame.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.Image = global::design_forms.Properties.Resources.imageedit_1_4773648694;
            this.logo.Location = new System.Drawing.Point(264, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(250, 88);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 20;
            this.logo.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEmulator);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.logo);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEmulator;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.PictureBox logo;
    }
}