namespace design_forms
{
    partial class Favourites
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
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lvcItems = new System.Windows.Forms.ListView();
            this.lvcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chbGame = new System.Windows.Forms.CheckBox();
            this.chbEmulator = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPlayRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(335, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(100, 67);
            this.pbIcon.TabIndex = 8;
            this.pbIcon.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMenu.Location = new System.Drawing.Point(335, 526);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 23);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Back To Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lvcItems
            // 
            this.lvcItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcName,
            this.lvcPlatform});
            this.lvcItems.Location = new System.Drawing.Point(131, 198);
            this.lvcItems.Name = "lvcItems";
            this.lvcItems.Size = new System.Drawing.Size(556, 260);
            this.lvcItems.TabIndex = 10;
            this.lvcItems.UseCompatibleStateImageBehavior = false;
            this.lvcItems.View = System.Windows.Forms.View.Details;
            // 
            // lvcName
            // 
            this.lvcName.Text = "Name";
            this.lvcName.Width = 250;
            // 
            // lvcPlatform
            // 
            this.lvcPlatform.Text = "Platform";
            this.lvcPlatform.Width = 362;
            // 
            // chbGame
            // 
            this.chbGame.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbGame.Location = new System.Drawing.Point(260, 147);
            this.chbGame.Name = "chbGame";
            this.chbGame.Size = new System.Drawing.Size(124, 45);
            this.chbGame.TabIndex = 11;
            this.chbGame.Text = "Game";
            this.chbGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbGame.UseVisualStyleBackColor = true;
            this.chbGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbGame_MouseClick);
            // 
            // chbEmulator
            // 
            this.chbEmulator.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbEmulator.Location = new System.Drawing.Point(390, 147);
            this.chbEmulator.Name = "chbEmulator";
            this.chbEmulator.Size = new System.Drawing.Size(124, 45);
            this.chbEmulator.TabIndex = 12;
            this.chbEmulator.Text = "Emulator";
            this.chbEmulator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbEmulator.UseVisualStyleBackColor = true;
            this.chbEmulator.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbEmulator_MouseClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(317, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 31);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "%Unilator";
            // 
            // btnPlayRun
            // 
            this.btnPlayRun.Location = new System.Drawing.Point(300, 465);
            this.btnPlayRun.Name = "btnPlayRun";
            this.btnPlayRun.Size = new System.Drawing.Size(165, 55);
            this.btnPlayRun.TabIndex = 23;
            this.btnPlayRun.Text = "Play/Run";
            this.btnPlayRun.UseVisualStyleBackColor = true;
            // 
            // Favourites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnPlayRun);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.chbEmulator);
            this.Controls.Add(this.chbGame);
            this.Controls.Add(this.lvcItems);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pbIcon);
            this.Name = "Favourites";
            this.Text = "Favourites";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ListView lvcItems;
        private System.Windows.Forms.ColumnHeader lvcName;
        private System.Windows.Forms.ColumnHeader lvcPlatform;
        private System.Windows.Forms.CheckBox chbGame;
        private System.Windows.Forms.CheckBox chbEmulator;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPlayRun;
    }
}