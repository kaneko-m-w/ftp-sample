using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace FTPSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowserDialog = new OpenFileDialog();
            if (folderBrowserDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            else
            {
                TextFileName.Text = folderBrowserDialog.FileName;
            }
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowserDialog = new OpenFileDialog();
            if (folderBrowserDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            // Get the object used to communicate with the server.
            FtpWebRequest ftpReq = (FtpWebRequest)WebRequest.Create("ftp://" + TextHost.Text + "/" + Path.GetFileName(folderBrowserDialog.FileName));
            ftpReq.Method = WebRequestMethods.Ftp.UploadFile;

            // FTP user logon.
            ftpReq.Credentials = new NetworkCredential(TextUserName.Text, TextPassword.Text);

            // Close the connection when the upload is complete
            ftpReq.KeepAlive = false;
            // ASCII mode enabled
            ftpReq.UseBinary = false;
            // PASSIVE mode enabled
            // ファイアウォールの内側から外側にあるFTPサーバに接続する場合はTrueにする
            ftpReq.UsePassive = true;

            using (FileStream fs = new FileStream(folderBrowserDialog.FileName, FileMode.Open, FileAccess.Read))
            using (Stream responseStream = ftpReq.GetRequestStream())
            {
                byte[] buffer = new byte[1024];
                while (true)
                {
                    int readSize = fs.Read(buffer, 0, buffer.Length);
                    if (readSize == 0)
                    {
                        break;
                    }
                    responseStream.Write(buffer, 0, readSize);
                }
            }

            MessageBox.Show("Upload success.");
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + TextHost.Text + "/" + ListBoxDirectory.SelectedItem.ToString());
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // FTP user logon.
            request.Credentials = new NetworkCredential(TextUserName.Text, TextPassword.Text);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            using (FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\" + ListBoxDirectory.SelectedItem.ToString(), FileMode.CreateNew, FileAccess.Write))
            using (Stream responseStream = response.GetResponseStream())
            {
                byte[] buffer = new byte[1024];
                while (true)
                {
                    int readSize = responseStream.Read(buffer, 0, buffer.Length);
                    if (readSize == 0)
                    {
                        break;
                    }
                    fs.Write(buffer, 0, readSize);
                }
            }

            MessageBox.Show("Download success.");
        }

        private void ButtonReflesh_Click(object sender, EventArgs e)
        {
            ListBoxDirectory.Items.Clear();

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + TextHost.Text);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            // FTP user logon.
            request.Credentials = new NetworkCredential(TextUserName.Text, TextPassword.Text);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string line;
                string[] info;
                while ((line = reader.ReadLine()) != null)
                {
                    info = line.Split(' ');
                    ListBoxDirectory.Items.Add(info[info.Length - 1]);
                }
            }

            if (ListBoxDirectory.Items.Count == 0)
            {
                MessageBox.Show("FTP folder is empty.");
            }
            else
            {
                ListBoxDirectory.SelectedIndex = 0;
                ButtonDownload.Enabled = true;
            }
        }
    }
}
