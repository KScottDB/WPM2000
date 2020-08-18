using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WPM2000
{
    public partial class About : Form
    {
        private const string githubLink = "https://github.com/KScottDB/WPM2000";

        public About()
        {
            InitializeComponent();
            linkLabelGit.Text = githubLink;
        }

        private void openGithub(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(githubLink);
        }
    }
}