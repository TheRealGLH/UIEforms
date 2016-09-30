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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lblSearchName = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnSearchGame = new System.Windows.Forms.Button();
            this.btnSearchEmu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Platform = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnplay = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchName.Location = new System.Drawing.Point(329, 108);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(120, 31);
            this.lblSearchName.TabIndex = 13;
            this.lblSearchName.Text = "%search";
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
            // btnSearchGame
            // 
            this.btnSearchGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGame.Location = new System.Drawing.Point(248, 159);
            this.btnSearchGame.Name = "btnSearchGame";
            this.btnSearchGame.Size = new System.Drawing.Size(128, 34);
            this.btnSearchGame.TabIndex = 14;
            this.btnSearchGame.Text = "%game";
            this.btnSearchGame.UseVisualStyleBackColor = true;
            // 
            // btnSearchEmu
            // 
            this.btnSearchEmu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmu.Location = new System.Drawing.Point(392, 159);
            this.btnSearchEmu.Name = "btnSearchEmu";
            this.btnSearchEmu.Size = new System.Drawing.Size(128, 34);
            this.btnSearchEmu.TabIndex = 14;
            this.btnSearchEmu.Text = "%emulator";
            this.btnSearchEmu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(280, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Dolphin";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clName,
            this.Platform});
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(239, 248);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(307, 104);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clName
            // 
            this.clName.Text = "Name";
            this.clName.Width = 140;
            // 
            // btnplay
            // 
            this.btnplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.Location = new System.Drawing.Point(229, 358);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(183, 34);
            this.btnplay.TabIndex = 14;
            this.btnplay.Text = "%play";
            this.btnplay.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(418, 358);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 34);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "%edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearchEmu);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btnSearchGame);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lblBack);
            this.Name = "search";
            this.Text = "search";
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnSearchGame;
        private System.Windows.Forms.Button btnSearchEmu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader Platform;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnEdit;
    }
}