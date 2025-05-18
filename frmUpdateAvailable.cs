using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubAutoUpdateTest
{
    public partial class frmUpdateAvailable : Form
    {
        public frmUpdateAvailable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCurrentVersion.Text += Application.ProductVersion;
            lblNewVersion.Text += UpdateChecker.GetNewVersionFromGithubAPI();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (Application.ProductVersion != UpdateChecker.GetNewVersionFromGithubAPI())
            {
                lblCurrentVersion.Visible = false;
                lblNewVersion.Visible = false;
                btnDownload.Visible = false;
                btnSkip.Visible = false;
                progressBar1.Visible = true;
                Text = "Downloading...";
                label1.Text = "Downloading new version...";
                try
                {
                    var c = new WebClient();

                    c.DownloadProgressChanged += (senderObj, progressArgs) =>
                    {
                        progressBar1.Value = progressArgs.ProgressPercentage;
                    };

                    var filePath = Environment.CurrentDirectory + "\\GitHubAutoUpdateTest_NEW.exe";
                    await c.DownloadFileTaskAsync("https://github.com/JoshuaMaitland/GitHubAutoUpdateTest/releases/download/" + UpdateChecker.GetNewVersionFromGithubAPI() + "/GitHubAutoUpdateTest.exe", filePath);

                    c.DownloadFileCompleted += (senderObj, completedArgs) =>
                    {
                        if (completedArgs.Error != null)
                        {
                            MessageBox.Show("Error: " + completedArgs.Error.Message);
                            lblCurrentVersion.Visible = true;
                            lblNewVersion.Visible = true;
                            btnDownload.Visible = true;
                            btnSkip.Visible = true;
                            progressBar1.Visible = false;
                            Text = "Update Available";
                        }
                        else
                        {
                            MessageBox.Show("Download complete!");
                        }
                    };

                    Process.Start(filePath);

                    Process.GetCurrentProcess().Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    lblCurrentVersion.Visible = true;
                    lblNewVersion.Visible = true;
                    btnDownload.Visible = true;
                    btnSkip.Visible = true;
                    progressBar1.Visible = false;
                    Text = "Update Available";
                }
            }
        }
    }
}
