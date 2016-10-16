using System;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormSearch : Form
    {
        private enum SearchMode
        {
            MODE_GAME,
            MODE_EMULATOR
        }

        private SearchMode searchMode;

        public FormSearch()
        {
            this.searchMode = SearchMode.MODE_GAME;

            InitializeComponent();

            loadStrings();
            showResults();
        }

        private void loadStrings()
        {
            base.Text = Properties.Resources.textSearch;
            this.labelTitle.Text = Properties.Resources.textSearch;
            this.buttonGame.Text = Properties.Resources.textGame;
            this.buttonEmulator.Text = Properties.Resources.textEmulator;
            this.buttonPlay.Text = Properties.Resources.textPlay;
            this.buttonEdit.Text = Properties.Resources.textEdit;
        }

        private void showResults()
        {
            this.listBoxResults.Items.Clear();

            switch (this.searchMode)
            {
                case SearchMode.MODE_GAME:
                    showGameResults();

                    break;
                case SearchMode.MODE_EMULATOR:
                    showEmulatorResults();

                    break;
            }
        }

        private void showGameResults()
        {
            bool searchTextEmpty = string.IsNullOrWhiteSpace(this.textBoxSearch.Text);
            string loweredSearchText = this.textBoxSearch.Text.ToLower();

            foreach(Game game in ObjectManager.instance.games)
            {
                if(searchTextEmpty || game.name.ToLower().Contains(loweredSearchText))
                {
                    this.listBoxResults.Items.Add(game);
                }
            }
        }

        private void showEmulatorResults()
        {
            bool searchTextEmpty = string.IsNullOrWhiteSpace(this.textBoxSearch.Text);
            string loweredSearchText = this.textBoxSearch.Text.ToLower();

            foreach (Emulator emulator in ObjectManager.instance.emulators)
            {
                if (searchTextEmpty || emulator.name.ToLower().Contains(loweredSearchText))
                {
                    this.listBoxResults.Items.Add(emulator);
                }
            }
        }

        private void editGame(Game game)
        {
            FormAddEditGame formAddEditGame = new FormAddEditGame(game);
            formAddEditGame.ShowDialog(this);
        }

        private void editEmulator(Emulator emulator)
        {
            FormAddEditEmulator formAddEditEmulator = new FormAddEditEmulator(emulator);
            formAddEditEmulator.ShowDialog(this);
        }

        private void buttonGame_Click(object sender, EventArgs e)
        {
            if(this.searchMode == SearchMode.MODE_GAME)
            {
                return;
            }

            this.searchMode = SearchMode.MODE_GAME;
            this.buttonEmulator.Enabled = true;
            this.buttonGame.Enabled = false;
            this.buttonPlay.Enabled = false;
            this.buttonEdit.Enabled = false;

            showResults();
        }

        private void buttonEmulator_Click(object sender, EventArgs e)
        {
            if (this.searchMode == SearchMode.MODE_EMULATOR)
            {
                return;
            }

            this.searchMode = SearchMode.MODE_EMULATOR;
            this.buttonEmulator.Enabled = false;
            this.buttonGame.Enabled = true;
            this.buttonPlay.Enabled = false;
            this.buttonEdit.Enabled = false;

            showResults();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            showResults();
        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selectedItem = (this.listBoxResults.SelectedItem != null);

            this.buttonPlay.Enabled = (this.searchMode == SearchMode.MODE_GAME && selectedItem);
            this.buttonEdit.Enabled = selectedItem;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Game game = this.listBoxResults.SelectedItem as Game;

            MessageBox.Show(string.Format(Properties.Resources.textDummyPlay, game.name), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            switch(this.searchMode)
            {
                case SearchMode.MODE_GAME:
                    editGame(this.listBoxResults.SelectedItem as Game);

                    break;
                case SearchMode.MODE_EMULATOR:
                    editEmulator(this.listBoxResults.SelectedItem as Emulator);

                    break;
            }
        }
    }
}
