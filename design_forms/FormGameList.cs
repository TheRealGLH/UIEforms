using System;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormGameList : Form
    {
        public FormGameList()
        {
            InitializeComponent();

            loadStrings();
            loadData();
        }

        private void loadStrings()
        {
            base.Text = Properties.Resources.textGames;
            this.labelTitle.Text = Properties.Resources.textGames;
            this.buttonAdd.Text = Properties.Resources.textAdd;
            this.buttonEdit.Text = Properties.Resources.textEdit;
            this.buttonRemove.Text = Properties.Resources.textRemove;
            this.buttonAddToFavourites.Text = Properties.Resources.textAddToFavourites;
            this.buttonPlay.Text = Properties.Resources.textPlay;
            this.columnHeaderTitle.Text = Properties.Resources.textTitle;
            this.columnHeaderEmulator.Text = Properties.Resources.textEmulator;
            this.columnHeaderLocation.Text = Properties.Resources.textLocation;
            this.buttonOk.Text = Properties.Resources.textOk;
        }

        private void loadData()
        {
            this.listViewEmulators.Items.Clear();

            foreach (Game game in ObjectManager.instance.games)
            {
                ListViewItem listViewItem = new ListViewItem(new[] { game.name, game.emulator.name, game.location });
                listViewItem.Tag = game;

                this.listViewEmulators.Items.Add(listViewItem);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditGame formAddEditGame = new FormAddEditGame();
            DialogResult dialogResult = formAddEditGame.ShowDialog(this);

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            ObjectManager.instance.games.Add(formAddEditGame.game);

            loadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.listViewEmulators.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem listViewItem = this.listViewEmulators.SelectedItems[0];

            FormAddEditGame formAddEditGame = new FormAddEditGame((Game)listViewItem.Tag);
            DialogResult dialogResult = formAddEditGame.ShowDialog(this);

            loadData();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.listViewEmulators.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem listViewItem = this.listViewEmulators.SelectedItems[0];

            ObjectManager.instance.games.Remove((Game)listViewItem.Tag);

            MessageBox.Show((Game)listViewItem.Tag + " Removed");

            loadData();
        }

        private void listViewEmulators_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool selectedItem = (this.listViewEmulators.SelectedItems.Count != 0);

            this.buttonEdit.Enabled = selectedItem;
            this.buttonRemove.Enabled = selectedItem;
            this.buttonAddToFavourites.Enabled = (selectedItem && !ObjectManager.instance.favourites.Contains((Game)this.listViewEmulators.SelectedItems[0].Tag));
            this.buttonPlay.Enabled = selectedItem;
        }

        private void buttonAddToFavourites_Click(object sender, EventArgs e)
        {
            if (this.listViewEmulators.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem listViewItem = this.listViewEmulators.SelectedItems[0];

            ObjectManager.instance.favourites.Add((Game)listViewItem.Tag);

            MessageBox.Show(Properties.Resources.textAddedToFavourites, Properties.Resources.textConfirmation, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (this.listViewEmulators.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem listViewItem = this.listViewEmulators.SelectedItems[0];

            Game game = (Game)listViewItem.Tag;

            MessageBox.Show(string.Format(Properties.Resources.textDummyPlay, game.name), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
