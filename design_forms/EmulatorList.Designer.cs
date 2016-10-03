namespace design_forms
{
    partial class EmulatorList
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.lvcItems = new System.Windows.Forms.ListView();
            this.lvcTitel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcDeveloper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcPlatform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMenu.Location = new System.Drawing.Point(347, 603);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 23);
            this.btnMenu.TabIndex = 8;
            this.btnMenu.Text = "Back To Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // lvcItems
            // 
            this.lvcItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcTitel,
            this.lvcDeveloper,
            this.lvcPlatform,
            this.lvcVersion});
            this.lvcItems.Location = new System.Drawing.Point(37, 212);
            this.lvcItems.Name = "lvcItems";
            this.lvcItems.Size = new System.Drawing.Size(717, 385);
            this.lvcItems.TabIndex = 7;
            this.lvcItems.UseCompatibleStateImageBehavior = false;
            this.lvcItems.View = System.Windows.Forms.View.Details;
            // 
            // lvcTitel
            // 
            this.lvcTitel.Text = "Titel";
            this.lvcTitel.Width = 283;
            // 
            // lvcDeveloper
            // 
            this.lvcDeveloper.Text = "Developer";
            this.lvcDeveloper.Width = 174;
            // 
            // lvcPlatform
            // 
            this.lvcPlatform.Text = "Platform";
            this.lvcPlatform.Width = 149;
            // 
            // lvcVersion
            // 
            this.lvcVersion.Text = "Version";
            this.lvcVersion.Width = 103;
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(347, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(100, 67);
            this.pbIcon.TabIndex = 14;
            this.pbIcon.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(679, 165);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 13;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnFavorites
            // 
            this.btnFavorites.Location = new System.Drawing.Point(294, 165);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(122, 23);
            this.btnFavorites.TabIndex = 12;
            this.btnFavorites.Text = "Add To Favorites";
            this.btnFavorites.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(213, 165);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(132, 165);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(332, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(189, 31);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "%EmulatorList";
            // 
            // EmulatorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 632);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lvcItems);
            this.Name = "EmulatorList";
            this.Text = "EmulatorList";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ListView lvcItems;
        private System.Windows.Forms.ColumnHeader lvcTitel;
        private System.Windows.Forms.ColumnHeader lvcDeveloper;
        private System.Windows.Forms.ColumnHeader lvcPlatform;
        private System.Windows.Forms.ColumnHeader lvcVersion;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
    }
}