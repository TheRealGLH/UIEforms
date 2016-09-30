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
    public partial class MainMenu: Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        void SetText()
        {
            this.btnEmulator.Text = Properties.Resources.MainEmulator;
            this.btnGame.Text = Properties.Resources.MainGame;
            this.btnHelp.Text = Properties.Resources.MainHelp;
            this.btnSettings.Text = Properties.Resources.MainSettings;
            this.btnSearch.Text = Properties.Resources.MainSearch;
        }
    }
}
