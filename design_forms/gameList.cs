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
    public partial class gameList : Form
    {
        public gameList()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMainWindow formMain = new FormMainWindow();
            formMain.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddEditGame formAddEditGame = new FormAddEditGame(false);
            formAddEditGame.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormAddEditGame formAddEditGame = new FormAddEditGame(true);
            formAddEditGame.Show();
            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
