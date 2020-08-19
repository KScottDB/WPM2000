using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WPM2000
{
    public partial class Form1 : Form
    {
        private About aboutDialog = new About();

        public Form1()
        {
            InitializeComponent();
        }

        // File -> About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialog.Show();
        }

        // File -> Install package from disk...
        private void installPackageFromDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
            throw new NotImplementedException("This function has not been written yet.");
        }

        // File -> Install package from URL...
        private void installPackageFromURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
            throw new NotImplementedException("This function has not been written yet.");
        }
    }
}