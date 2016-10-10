using System;
using System.Windows.Forms;

namespace design_forms
{
    public partial class FormFavourites : Form
    {
        public FormFavourites()
        {
            InitializeComponent();

            loadStrings();
            loadData();
        }

        private void loadStrings()
        {
            base.Text = Properties.Resources.textFavourites;
            this.labelTitle.Text = Properties.Resources.textFavourites;
            this.buttonPlay.Text = Properties.Resources.textPlay;
        }

        private void loadData()
        {
            foreach(Game game in ObjectManager.instance.games)
            {
                ListViewItem listViewItem = new ListViewItem(new[] { game.name });
                listViewItem.Tag = game;

                this.listViewFavourites.Items.Add(listViewItem);
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if(this.listViewFavourites.SelectedItems.Count <= 0)
            {
                return;
            }

            Game game = (Game)this.listViewFavourites.SelectedItems[0].Tag;

            MessageBox.Show(string.Format(Properties.Resources.textDummyPlay, game.name), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewFavourites_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buttonPlay.Enabled = (this.listViewFavourites.SelectedItems.Count > 0);
        }
    }
}
