using System;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormAddEditEmulator : Form
    {
        public FormAddEditEmulator(bool editing)
        {
            InitializeComponent();

            loadStrings(editing);
        }

        private void loadStrings(bool editing)
        {
            if (editing)
            {
                base.Text = Properties.Resources.textEditEmulator;

                this.labelMainTitle.Text = Properties.Resources.textEditEmulator;
            }
            else
            {
                base.Text = Properties.Resources.textAddEmulator;

                this.labelMainTitle.Text = Properties.Resources.textAddEmulator;
            }

            this.labelName.Text = Properties.Resources.textName;
            this.labelPlatform.Text = Properties.Resources.textPlatform;
            this.labelDeveloper.Text = Properties.Resources.textDeveloper;
            this.labelLocation.Text = Properties.Resources.textLocation;
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

        public string name
        {
            get
            {
                return this.textBoxName.Text;
            }
        }

        public string platform
        {
            get
            {
                return this.textBoxPlatform.Text;
            }
        }

        public string developer
        {
            get
            {
                return this.textBoxDeveloper.Text;
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
            EmulatorList formEmulator = new EmulatorList();
            formEmulator.Show();
            this.Hide();
        }
    }
}
