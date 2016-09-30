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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
            SetText();
        }


        void SetText()
        {
            lblSearchName.Text = Properties.Resources.SearchName;
            btnSearchEmu.Text = Properties.Resources.GenEmulator;
            btnSearchGame.Text = Properties.Resources.GenGame;
            btnplay.Text = Properties.Resources.SearchPlayRun;
            btnEdit.Text = Properties.Resources.SearchEdit;
        }
    }
}
