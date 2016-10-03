using System;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();

            loadStrings();
        }

        private void loadStrings()
        {
            base.Text = Properties.Resources.textUnilator;
            this.labelTitle.Text = Properties.Resources.textUnilator;
            this.buttonGame.Text = Properties.Resources.textGame;
            this.buttonEmulator.Text = Properties.Resources.textEmulator;
            this.buttonSearch.Text = Properties.Resources.textSearch;
            this.buttonSettings.Text = Properties.Resources.textSettings;
            this.buttonHelp.Text = Properties.Resources.textHelp;
            this.buttonFavourites.Text = Properties.Resources.textFavourites;
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmulator_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private void buttonFavourites_Click(object sender, EventArgs e)
        {

        }
    }
}
