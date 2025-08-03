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

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            lblCurrentVersion.Visible = false;
            lblNewVersion.Visible = false;
            btnDownload.Visible = false;
            btnSkip.Visible = false;
            progressBar1.Visible = true;
            lblProgress.Visible = true;
            Text = "Downloading...";
            label1.Text = "Downloading new version...";
            try
            {
                //var downloadFileUrl = "https://github.com/JoshuaMaitland/GitHubAutoUpdateTest/releases/download/v" + VersionChecker.GetNewVersionNumberFromGithubAPI() + "/GitHubAutoUpdateTest.exe";
                var downloadFileUrl = "http://localhost/GamingPHP/images/lock.png";
                var destinationFilePath = Path.GetFullPath("lock.png");

                using (var client = new HttpClientDownloadWithProgress(downloadFileUrl, destinationFilePath))
                {
                    client.ProgressChanged += (totalFileSize, totalBytesDownloaded, progressPercentage) => {
                        Console.WriteLine($"{progressPercentage}% ({totalBytesDownloaded}/{totalFileSize})");
                        progressBar1.Value = (int)(progressPercentage ?? 0);
                        lblProgress.Text = $"{progressPercentage}%";
                        if (progressPercentage >= 100)
                        {
                            MessageBox.Show("Download complete!");

                            Process.Start(destinationFilePath);
                            // Close the current application
                            Process.GetCurrentProcess().Kill();
                        }
                    };

                    await client.StartDownload();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                lblCurrentVersion.Visible = true;
                lblNewVersion.Visible = true;
                btnDownload.Visible = true;
                btnSkip.Visible = true;
                progressBar1.Visible = false;
                lblProgress.Visible = false;
                Text = "Update Available";
                label1.Text = "A new version is available";
            }
        }
    }
}
