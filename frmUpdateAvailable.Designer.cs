namespace GitHubAutoUpdateTest
{
    partial class frmUpdateAvailable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.lblNewVersion = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "A new version is available";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentVersion.Location = new System.Drawing.Point(12, 40);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(152, 24);
            this.lblCurrentVersion.TabIndex = 1;
            this.lblCurrentVersion.Text = "Current Version: ";
            // 
            // lblNewVersion
            // 
            this.lblNewVersion.AutoSize = true;
            this.lblNewVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewVersion.Location = new System.Drawing.Point(12, 70);
            this.lblNewVersion.Name = "lblNewVersion";
            this.lblNewVersion.Size = new System.Drawing.Size(129, 24);
            this.lblNewVersion.TabIndex = 2;
            this.lblNewVersion.Text = "New Version: ";
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Location = new System.Drawing.Point(91, 126);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkip.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSkip.Location = new System.Drawing.Point(172, 126);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 4;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(235, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // frmUpdateAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSkip;
            this.ClientSize = new System.Drawing.Size(259, 161);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblNewVersion);
            this.Controls.Add(this.lblCurrentVersion);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 200);
            this.Name = "frmUpdateAvailable";
            this.ShowInTaskbar = false;
            this.Text = "A new version is available";
            this.Load += new System.EventHandler(this.frmUpdateAvailable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label lblNewVersion;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

