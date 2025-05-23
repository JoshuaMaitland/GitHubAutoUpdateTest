﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubAutoUpdateTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblCurrentVersion.Text += Application.ProductVersion;
            if (Application.ProductVersion != VersionChecker.GetNewVersionNumberFromGithubAPI())
            {
                var updateForm = new frmUpdateAvailable();
                updateForm.ShowDialog();
            }
        }
    }
}
