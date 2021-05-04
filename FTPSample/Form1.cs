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
            Uri uri = new Uri("ftp://" + TextHost.Text + "/" + Path.GetFileName(TextFileName.Text));

            FtpWebRequest ftpReq = (FtpWebRequest)WebRequest.Create(uri);
            ftpReq.Credentials = new NetworkCredential(TextUserName.Text, TextPassword.Text);
            ftpReq.Method = WebRequestMethods.Ftp.UploadFile;

            // 要求の完了後(アップロード終了時)に接続を閉じる
            // Connection closing at finished upload.
            ftpReq.KeepAlive = false;
            // ASCIIモードで転送する
            // ASCII transfer enabled.
            ftpReq.UseBinary = false;
            // PASSIVEモードを有効にする(ファイアウォールの内側から外側にあるFTPサーバに接続する場合はTrueにする)
            // PASSIVE enabled. PASSIVE enabled case is able to connecting server in the outside firewall.
            ftpReq.UsePassive = true;

            using (FileStream fs = new FileStream(TextFileName.Text, FileMode.Open, FileAccess.Read))
            using (Stream reqStrm = ftpReq.GetRequestStream())
            {
                byte[] buffer = new byte[1024];
                while (true)
                {
                    int readSize = fs.Read(buffer, 0, buffer.Length);
                    if (readSize == 0)
                    {
                        break;
                    }
                    reqStrm.Write(buffer, 0, readSize);
                }
            }

            MessageBox.Show("Upload success.");
        }
    }
}
