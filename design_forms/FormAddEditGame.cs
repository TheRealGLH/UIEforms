using System;
using System.IO;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormAddEditGame : Form
    {
        private bool canClose;

        public FormAddEditGame(Game game = null)
        {
            this.canClose = true;

            this.game = game;

            InitializeComponent();

            loadStrings(game == null);

            loadData();
        }

        private void loadStrings(bool editing)
        {
            if (editing)
            {
                base.Text = Properties.Resources.textEditGame;

                this.labelMainTitle.Text = Properties.Resources.textEditGame;
            }
            else
            {
                base.Text = Properties.Resources.textAddGame;

                this.labelMainTitle.Text = Properties.Resources.textAddGame;
            }

            this.labelTitle.Text = Properties.Resources.textTitle;
            this.labelEmulator.Text = Properties.Resources.textEmulator;
            this.labelLocation.Text = Properties.Resources.textLocation;
            this.buttonAutofill.Text = Properties.Resources.textAutofillMetadata;
            this.buttonOk.Text = Properties.Resources.textOk;
            this.buttonCancel.Text = Properties.Resources.textCancel;
        }

        private void loadData()
        {
            foreach(Emulator emulator in ObjectManager.instance.emulators)
            {
                this.comboBoxEmulator.Items.Add(emulator);
            }

            if(this.game == null)
            {
                return;
            }

            int x = 0;
            foreach(Emulator emulator in ObjectManager.instance.emulators)
            {
                if (this.game.emulator.Equals(emulator))
                {
                    break;
                }

                x++;
            }

            if(x < ObjectManager.instance.emulators.Count)
            {
                this.comboBoxEmulator.SelectedIndex = x;
            }

            this.textBoxTitle.Text = this.game.name;
            this.textBoxLocation.Text = this.game.location;
        }

        private void FormAddEditGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!this.canClose)
            {
                this.canClose = true;

                e.Cancel = true;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = this.openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            this.textBoxLocation.Text = this.openFileDialog.FileName;
        }

        private void buttonAutofill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Metadata not found");
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxTitle.Text))
            {
                this.canClose = false;

                MessageBox.Show(Properties.Resources.textInvalidGameName, Properties.Resources.textInvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Emulator emulator = this.comboBoxEmulator.SelectedItem as Emulator;
            if (emulator == null)
            {
                this.canClose = false;

                MessageBox.Show(Properties.Resources.textInvalidGameEmulator, Properties.Resources.textInvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!File.Exists(this.textBoxLocation.Text))
            {
                this.canClose = false;

                MessageBox.Show(Properties.Resources.textInvalidGameLocation, Properties.Resources.textInvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (this.game == null)
            {
                Game game = new Game(this.textBoxTitle.Text, emulator, this.textBoxLocation.Text);
                if (ObjectManager.instance.games.Contains(game))
                {
                    this.canClose = false;

                    MessageBox.Show(Properties.Resources.textGameAlreadyAdded, Properties.Resources.textInvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                this.game = game;
            }
            else
            {
                this.game.emulator = emulator;
                this.game.location = this.textBoxLocation.Text;
            }
        }

        public Game game
        {
            get;
            private set;
        }
    }
}
