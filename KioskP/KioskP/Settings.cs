using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KioskP
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void backColorChanger_Click(object sender, EventArgs e)
        {
            ColorDialog j = new ColorDialog();
            if (j.ShowDialog() == DialogResult.OK)
            {
                backColorChanger.BackColor = j.Color;
                this.BackColor = j.Color;
            }
        }

        private void retractHere_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorBack = backColorChanger.BackColor;
            Properties.Settings.Default.isMaximized = takeItToTheMax.Checked;

            Properties.Settings.Default.Save();

            this.Close();

            
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.colorBack;
            backColorChanger.BackColor = this.BackColor;
        }

    }
}
