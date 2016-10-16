using System;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormEmulatorList : Form
    {
        public FormEmulatorList()
        {
            InitializeComponent();

            loadStrings();
            loadData();
        }

        private void loadStrings()
        {
            base.Text = Properties.Resources.textEmulators;
            this.labelTitle.Text = Properties.Resources.textEmulators;
            this.columnHeaderTitle.Text = Properties.Resources.textTitle;
            this.columnHeaderPlatform.Text = Properties.Resources.textPlatform;
            this.columnHeaderDeveloper.Text = Properties.Resources.textDeveloper;
            this.columnHeaderLocation.Text = Properties.Resources.textLocation;
            this.buttonOk.Text = Properties.Resources.textOk;
        }

        private void loadData()
        {
            this.listViewEmulators.Items.Clear();

            foreach (Emulator emulator in ObjectManager.instance.emulators)
            {
                ListViewItem listViewItem = new ListViewItem(new[] { emulator.name, emulator.developer, emulator.platform, emulator.location });
                listViewItem.Tag = emulator;

                this.listViewEmulators.Items.Add(listViewItem);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditEmulator formAddEditEmulator = new FormAddEditEmulator();
            DialogResult dialogResult = formAddEditEmulator.ShowDialog(this);

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            ObjectManager.instance.emulators.Add(formAddEditEmulator.emulator);

            loadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.listViewEmulators.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem listViewItem = this.listViewEmulators.SelectedItems[0];

            FormAddEditEmulator formAddEditEmulator = new FormAddEditEmulator((Emulator)listViewItem.Tag);
            DialogResult dialogResult = formAddEditEmulator.ShowDialog(this);

            loadData();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.listViewEmulators.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem listViewItem = this.listViewEmulators.SelectedItems[0];

            ObjectManager.instance.emulators.Remove((Emulator)listViewItem.Tag);
            MessageBox.Show((Emulator)listViewItem.Tag + " Removed");
            loadData();
        }

        private void listViewEmulators_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selectedItem = (this.listViewEmulators.SelectedItems.Count != 0);

            this.buttonEdit.Enabled = selectedItem;
            this.buttonRemove.Enabled = selectedItem;
        }
    }
}
