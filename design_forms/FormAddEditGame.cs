using System;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormAddEditGame : Form
    {
        public FormAddEditGame(bool editing)
        {
            InitializeComponent();

            loadStrings(editing);
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

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = this.openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            this.textBoxLocation.Text = this.openFileDialog.FileName;
        }

        public string title
        {
            get
            {
                return this.textBoxTitle.Text;
            }
        }

        public string emulator
        {
            get
            {
                return this.textBoxEmulator.Text;
            }
        }

        public string location
        {
            get
            {
                return this.textBoxLocation.Text;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            gameList formGame = new gameList();
            formGame.Show();
            this.Hide();
        }
    }
}
