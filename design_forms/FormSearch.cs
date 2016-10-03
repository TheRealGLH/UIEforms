using System;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();

            loadStrings();
        }

        private void loadStrings()
        {
            base.Text = Properties.Resources.textSearch;
            this.labelTitle.Text = Properties.Resources.textSearch;
            this.buttonGame.Text = Properties.Resources.textGame;
            this.buttonEmulator.Text = Properties.Resources.textEmulator;
            this.columnHeaderName.Text = Properties.Resources.textName;
            this.buttonPlay.Text = Properties.Resources.textPlay;
            this.buttonEdit.Text = Properties.Resources.textEdit;
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmulator_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
