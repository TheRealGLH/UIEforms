using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace design_forms
{
    public partial class EmulatorList : Form
    {
        public EmulatorList()
        {
            InitializeComponent();
            SetText();
        }

        private void SetText()
        {
            this.lblName.Text = Properties.Resources.EmulatorListName;
            this.btnAdd.Text = Properties.Resources.ListAdd;
            this.btnEdit.Text = Properties.Resources.ListEdit;
            this.btnRemove.Text = Properties.Resources.ListRemove;
            this.btnFavorites.Text = Properties.Resources.ListAddFavourite;
            this.btnPlay.Text = Properties.Resources.EmulatorListRun;
            this.btnMenu.Text = Properties.Resources.GenBackToMenu;
            this.lvcItems.Columns[0].Text = Properties.Resources.EmulatorListLvcName;
            this.lvcItems.Columns[1].Text = Properties.Resources.EmulatorListLvcDeveloper;
            this.lvcItems.Columns[2].Text = Properties.Resources.EmulatorListLvcPlatform;
            this.lvcItems.Columns[3].Text = Properties.Resources.EmulatorListLvcVersion;
        }
    }
}
