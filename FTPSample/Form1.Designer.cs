
namespace FTPSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextUserName = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextFileName = new System.Windows.Forms.TextBox();
            this.ButtonUpload = new System.Windows.Forms.Button();
            this.TextHost = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.ButtonDownload = new System.Windows.Forms.Button();
            this.ButtonReflesh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ListBoxDirectory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Location = new System.Drawing.Point(318, 96);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(62, 20);
            this.ButtonSelect.TabIndex = 0;
            this.ButtonSelect.Text = "Select";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // TextUserName
            // 
            this.TextUserName.Location = new System.Drawing.Point(76, 44);
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(123, 20);
            this.TextUserName.TabIndex = 3;
            this.TextUserName.Text = "xuser";
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(76, 70);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(123, 20);
            this.TextPassword.TabIndex = 4;
            this.TextPassword.Text = "xpass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "File Name";
            // 
            // TextFileName
            // 
            this.TextFileName.Location = new System.Drawing.Point(76, 97);
            this.TextFileName.Name = "TextFileName";
            this.TextFileName.Size = new System.Drawing.Size(236, 20);
            this.TextFileName.TabIndex = 6;
            // 
            // ButtonUpload
            // 
            this.ButtonUpload.Location = new System.Drawing.Point(132, 129);
            this.ButtonUpload.Name = "ButtonUpload";
            this.ButtonUpload.Size = new System.Drawing.Size(120, 20);
            this.ButtonUpload.TabIndex = 7;
            this.ButtonUpload.Text = "Upload";
            this.ButtonUpload.UseVisualStyleBackColor = true;
            this.ButtonUpload.Click += new System.EventHandler(this.ButtonUpload_Click);
            // 
            // TextHost
            // 
            this.TextHost.Location = new System.Drawing.Point(76, 18);
            this.TextHost.Name = "TextHost";
            this.TextHost.Size = new System.Drawing.Size(123, 20);
            this.TextHost.TabIndex = 9;
            this.TextHost.Text = "localhost";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 13);
            this.label.TabIndex = 8;
            this.label.Text = "FTP Server";
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Enabled = false;
            this.ButtonDownload.Location = new System.Drawing.Point(132, 240);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(120, 20);
            this.ButtonDownload.TabIndex = 10;
            this.ButtonDownload.Text = "Download";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // ButtonReflesh
            // 
            this.ButtonReflesh.Location = new System.Drawing.Point(14, 240);
            this.ButtonReflesh.Name = "ButtonReflesh";
            this.ButtonReflesh.Size = new System.Drawing.Size(51, 20);
            this.ButtonReflesh.TabIndex = 12;
            this.ButtonReflesh.Text = "Reflesh";
            this.ButtonReflesh.UseVisualStyleBackColor = true;
            this.ButtonReflesh.Click += new System.EventHandler(this.ButtonReflesh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "FTP server directory";
            // 
            // ListBoxDirectory
            // 
            this.ListBoxDirectory.FormattingEnabled = true;
            this.ListBoxDirectory.Location = new System.Drawing.Point(14, 178);
            this.ListBoxDirectory.Name = "ListBoxDirectory";
            this.ListBoxDirectory.Size = new System.Drawing.Size(366, 56);
            this.ListBoxDirectory.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.ListBoxDirectory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonReflesh);
            this.Controls.Add(this.ButtonDownload);
            this.Controls.Add(this.TextHost);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ButtonUpload);
            this.Controls.Add(this.TextFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSelect);
            this.Name = "Form1";
            this.Text = "ftp";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextUserName;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextFileName;
        private System.Windows.Forms.Button ButtonUpload;
        private System.Windows.Forms.TextBox TextHost;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button ButtonDownload;
        private System.Windows.Forms.Button ButtonReflesh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ListBoxDirectory;
    }
}

