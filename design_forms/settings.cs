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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void settings_Load(object sender, EventArgs e)
        {
            SetText();
        }



        void SetText()
        {
            lblSettingsName.Text = Properties.Resources.SettingsName;
            lblScale.Text = Properties.Resources.SettingsOptionsScale + ":";
            lblFont.Text = Properties.Resources.SettingsOptionsFont + ":";
            lblColor.Text = Properties.Resources.SettingsOptionBGColor + ":";
            lblLang.Text = Properties.Resources.SettingsOptionLanguage + ":";
            lblBack.Text = "< "+Properties.Resources.GenBackToMenu;
            btnLoadPreset.Text = Properties.Resources.SettingsLoadPreset;


            cboxScale.Items.Add(Properties.Resources.SettingsScaleSmall);
            cboxScale.Items.Add(Properties.Resources.SettingsScaleMedium);
            cboxScale.Items.Add(Properties.Resources.SettingsScaleBig);
            cboxScale.Items.Add(Properties.Resources.SettingsScaleExtraBig);

            cboxColor.SelectedIndex = 0;
            cboxFont.SelectedIndex = 0;
            cboxLang.SelectedIndex = 0;
            cboxScale.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doesn't do anything :(");
        }
    }
}
