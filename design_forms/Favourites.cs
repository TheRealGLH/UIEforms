using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_forms
{
    public partial class Favourites : Form
    {
        public Favourites()
        {
            InitializeComponent();
            SetText();
        }

        private void chbGame_MouseClick(object sender, MouseEventArgs e)
        {
            this.chbEmulator.Checked = false;
            this.chbGame.Checked = true;
        }

        private void chbEmulator_MouseClick(object sender, MouseEventArgs e)
        {
            this.chbGame.Checked = false;
            this.chbEmulator.Checked = true;
        }

        private void SetText()
        {
            this.lblName.Text = Properties.Resources.FavouritesName;
            this.chbGame.Text = Properties.Resources.GenGame;
            this.chbEmulator.Text = Properties.Resources.GenEmulator;
            this.lvcItems.Columns[0].Text = Properties.Resources.FavoutritesListViewName;
            this.lvcItems.Columns[1].Text = Properties.Resources.FavouritesListViewPlatform;
            this.btnPlayRun.Text = Properties.Resources.SearchPlayRun;
            this.btnMenu.Text = Properties.Resources.GenBackToMenu;
            this.Text = Properties.Resources.FavouritesName;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMainWindow formMain = new FormMainWindow();
            formMain.Show();
            this.Hide();
        }
    }
}
