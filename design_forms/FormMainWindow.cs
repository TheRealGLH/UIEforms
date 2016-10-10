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
            gameList gameForm = new gameList();
            gameForm.Show();
            this.Hide();
        }

        private void buttonEmulator_Click(object sender, EventArgs e)
        {
            EmulatorList emulatorForm = new EmulatorList();
            emulatorForm.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.Show();
            this.Hide();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
            this.Hide();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
            this.Hide();
        }

        private void buttonFavourites_Click(object sender, EventArgs e)
        {
            Favourites formFavourites = new Favourites();
            formFavourites.Show();
            this.Hide();
        }
    }
}
