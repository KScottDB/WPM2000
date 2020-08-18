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

        // Toolstrip: About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialog.Show();
        }
    }
}