using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace GitHubAutoUpdateTest
{
    public partial class frmUpdateAvailable : Form
    {
        public frmUpdateAvailable()
        {
            InitializeComponent();
        }

        private void frmUpdateAvailable_Load(object sender, EventArgs e)
        {
            lblCurrentVersion.Text += Application.ProductVersion;
            lblNewVersion.Text += VersionChecker.GetNewVersionNumberFromGithubAPI();
        }

        private void btnDownload_Click(object sender, EventArgs e)
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

                c.DownloadProgressChanged += (s, progressArgs) =>
                {
                    progressBar1.Value = progressArgs.ProgressPercentage;
                };

                var filePath = Path.Combine(Path.GetTempPath(), "GitHubAutoUpdateTest.exe");
                c.DownloadFileTaskAsync("https://github.com/JoshuaMaitland/GitHubAutoUpdateTest/releases/download/v" + VersionChecker.GetNewVersionNumberFromGithubAPI() + "/GitHubAutoUpdateTest.exe", filePath);

                c.DownloadFileCompleted += (s, completedArgs) =>
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
                        label1.Text = "A new version is available";
                    }
                    else
                    {
                        MessageBox.Show("Download complete!");

                        Process.Start(filePath);
                        // Close the current application
                        Process.GetCurrentProcess().Kill();
                    }

                };
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
                label1.Text = "A new version is available";
            }
        }
    }
}
