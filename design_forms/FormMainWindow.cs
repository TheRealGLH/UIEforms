using System;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();

            //loadStrings();
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
            FormGameList formGameList = new FormGameList();
            formGameList.ShowDialog(this);
            /*
            FormAddEditGame formAddEditGame = new FormAddEditGame();
            DialogResult dialogResult = formAddEditGame.ShowDialog(this);

            if(dialogResult != DialogResult.OK)
            {
                return;
            }

            ObjectManager.instance.games.Add(formAddEditGame.game);
            */
        }

        private void buttonEmulator_Click(object sender, EventArgs e)
        {
            FormEmulatorList formEmulatorList = new FormEmulatorList();
            formEmulatorList.ShowDialog(this);
            /*
            FormAddEditEmulator formAddEditEmulator = new FormAddEditEmulator();
            DialogResult dialogResult = formAddEditEmulator.ShowDialog(this);

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            ObjectManager.instance.emulators.Add(formAddEditEmulator.emulator);
            */
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            DialogResult dialogResult = formSearch.ShowDialog(this);

            if (dialogResult != DialogResult.OK)
            {
                return;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            DialogResult dialogResult = formSettings.ShowDialog(this);

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            System.Threading.Thread.CurrentThread.CurrentCulture = formSettings.language;
            System.Threading.Thread.CurrentThread.CurrentUICulture = formSettings.language;

            loadStrings();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog(this);
        }

        private void buttonFavourites_Click(object sender, EventArgs e)
        {
            FormFavourites formFavourites = new FormFavourites();
            formFavourites.ShowDialog(this);
        }
    }
}
