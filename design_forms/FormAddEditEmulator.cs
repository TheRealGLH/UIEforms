using System;
using System.IO;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormAddEditEmulator : Form
    {
        private bool canClose;

        public FormAddEditEmulator(Emulator emulator = null)
        {
            this.canClose = true;

            this.emulator = emulator;

            InitializeComponent();

            loadStrings(emulator != null);
            loadData();            
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

        private void loadData()
        {
            if(this.emulator == null)
            {
                return;
            }

            this.textBoxName.Text = this.emulator.name;
            this.textBoxPlatform.Text = this.emulator.platform;
            this.textBoxDeveloper.Text = this.emulator.developer;
            this.textBoxLocation.Text = this.emulator.location;
        }

        private void FormAddEditEmulator_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxName.Text))
            {
                this.canClose = false;

                MessageBox.Show(Properties.Resources.textInvalidEmulatorName, Properties.Resources.textInvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(this.textBoxPlatform.Text))
            {
                this.canClose = false;

                MessageBox.Show(Properties.Resources.textInvalidEmulatorPlatform, Properties.Resources.textInvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(this.textBoxDeveloper.Text))
            {
                this.canClose = false;

                MessageBox.Show(Properties.Resources.textInvalidEmulatorDeveloper, Properties.Resources.textInvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!File.Exists(this.textBoxLocation.Text))
            {
                this.canClose = false;

                MessageBox.Show(Properties.Resources.textInvalidEmulatorLocation, Properties.Resources.textInvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (this.emulator == null)
            {
                Emulator emulator = new Emulator(this.textBoxName.Text, this.textBoxPlatform.Text, this.textBoxDeveloper.Text, this.textBoxLocation.Text);

                if (ObjectManager.instance.emulators.Contains(emulator))
                {
                    this.canClose = false;

                    MessageBox.Show(Properties.Resources.textEmulatorAlreadyAdded, Properties.Resources.textInvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                this.emulator = emulator;
            }
            else
            {
                this.emulator.developer = this.textBoxDeveloper.Text;
                this.emulator.platform = this.textBoxPlatform.Text;
                this.emulator.location = this.textBoxLocation.Text;
            }
        }

        public Emulator emulator
        {
            get;
            private set;
        }
    }
}
