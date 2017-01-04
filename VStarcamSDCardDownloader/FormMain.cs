using System;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VStarcamSDCardDownloader
{
    public partial class frmMain : Form
    {
        private int DownloadIndex;

        private string DownloadFileFrom = "";

        private string SaveFileTo = "";

        private bool DownloadCompleted;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                //create the request string
                string ip = txtIPAddress.Text.Trim();
                string port = txtPort.Text.Trim();
                string user = txtUser.Text.Trim();
                string password = txtPassword.Text;
                string pageSize = "100000"; //let's hope there's not more than 100,000 records on the SD card :)
                string request = string.Format("http://{0}:{1}/get_record_file.cgi?loginuse={2}&loginpas={3}&PageIndex=0&PageSize={4}", ip, port, user, password, pageSize);

                //get the response string
                WebClient webClient = new WebClient();
                string response = webClient.DownloadString(request);

                //parse the response
                GetRecordFileResponse files = new GetRecordFileResponse(response);

                //now add all the records to the list
                try
                {
                    lbxFiles.BeginUpdate();
                    lbxFiles.Items.Clear();
                    foreach (Record record in files.Records)
                    {
                        lbxFiles.Items.Add(record);
                    }
                }
                finally
                {
                    lbxFiles.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectDownloadFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = txtDownloadFolder.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtDownloadFolder.Text = dialog.SelectedPath;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtIPAddress.Text.Trim();
                string port = txtPort.Text.Trim();
                string downloadFolder = txtDownloadFolder.Text.Trim();

                //first ensure the download folder exist
                if (!System.IO.Directory.Exists(downloadFolder))
                {
                    throw new Exception("Folder does not exist!");
                }

                //now confirm the download
                long total = 0;
                foreach (Record record in lbxFiles.SelectedItems)
                {
                    total += record.Size;
                }
                if (MessageBox.Show(
                    string.Format("Total download size is {0}.  Would you like to continue?", total.ToPrettySize(2)),
                    "Confirm download",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }


                //now download all the files
                this.DownloadIndex = 0;
                foreach (Record record in lbxFiles.SelectedItems)
                {
                    //set the download status
                    UpdateDownloadStatus(-1);

                    //set the source and destination
                    this.DownloadFileFrom = string.Format("http://{0}:{1}/record/{2}", ip, port, record.Name);
                    this.SaveFileTo = string.Format("{0}\\{1}", downloadFolder, record.Name);

                    //only download if overwrite is enabled or the file doesn't exist yet
                    if (chkOverwrite.Checked == true || System.IO.File.Exists(this.SaveFileTo) == false)
                    {
                        //start the download and wait for it to complete
                        this.DownloadCompleted = false;
                        startDownload();
                        while (this.DownloadCompleted == false)
                        {
                            Application.DoEvents();
                        }
                    }

                    this.DownloadIndex++;
                }

                //let the user know we are done
                MessageBox.Show("Download completed", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDownload.Text = "Download";
                btnDownload.Enabled = true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Folder does not exist!")
                {
                    btnSelectDownloadFolder_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateDownloadStatus(int percentage)
        {
            btnDownload.Text = string.Format("Downloading file {0} of {1}...", (this.DownloadIndex + 1), lbxFiles.SelectedItems.Count);
            if (percentage >= 0)
            {
                btnDownload.Text += string.Format(" {0}%", percentage);
            }
            Application.DoEvents();
        }

        private void startDownload()
        {
            Thread thread = new Thread(() =>
            {
                string user = txtUser.Text.Trim();
                string password = txtPassword.Text;
                WebClient client = new WebClient();
                string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(user + ":" + password));
                client.Headers[HttpRequestHeader.Authorization] = string.Format("Basic {0}", credentials);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri(this.DownloadFileFrom), this.SaveFileTo);
            });
            thread.Start();
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.UpdateDownloadStatus(e.ProgressPercentage);
            });
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                var x = ((WebClient)sender);
                this.DownloadCompleted = true;
            });
        }
    }
}