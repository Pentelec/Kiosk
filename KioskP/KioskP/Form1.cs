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
    public partial class Form1 : Form
    {
        int thisisthewidthofyourscreennotcapitalizedhere;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = KioskP.Properties.Settings.Default.colorBack;
            if (Properties.Settings.Default.isMaximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            thisisthewidthofyourscreennotcapitalizedhere = 0;
            thisisthewidthofyourscreennotcapitalizedhere = Screen.PrimaryScreen.WorkingArea.Width;
            this.Width = thisisthewidthofyourscreennotcapitalizedhere;
            this.Left = 0;
            this.Top = 0;
        }

        private void somethingWasHoveredOver(object sender, EventArgs e)
        {
            //this.Opacity = 1;
        }

        private void somethingWasMouseLeft(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void app10_Click(object sender, EventArgs e)
        {
            Settings sett = new Settings();
            sett.Show();
            sett.BringToFront();
        }
    }
}
