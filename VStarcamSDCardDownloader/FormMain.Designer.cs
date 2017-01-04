namespace VStarcamSDCardDownloader
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpbxCamera = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.grpbxRetrieve = new System.Windows.Forms.GroupBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.grpbxDownload = new System.Windows.Forms.GroupBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSelectDownloadFolder = new System.Windows.Forms.Button();
            this.txtDownloadFolder = new System.Windows.Forms.TextBox();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.grpbxCamera.SuspendLayout();
            this.grpbxRetrieve.SuspendLayout();
            this.grpbxDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxCamera
            // 
            this.grpbxCamera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxCamera.Controls.Add(this.txtPassword);
            this.grpbxCamera.Controls.Add(this.txtUser);
            this.grpbxCamera.Controls.Add(this.txtPort);
            this.grpbxCamera.Controls.Add(this.txtIPAddress);
            this.grpbxCamera.Controls.Add(this.lblPassword);
            this.grpbxCamera.Controls.Add(this.lblUser);
            this.grpbxCamera.Controls.Add(this.lblPort);
            this.grpbxCamera.Controls.Add(this.lblIP);
            this.grpbxCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxCamera.Location = new System.Drawing.Point(12, 12);
            this.grpbxCamera.Name = "grpbxCamera";
            this.grpbxCamera.Size = new System.Drawing.Size(760, 52);
            this.grpbxCamera.TabIndex = 0;
            this.grpbxCamera.TabStop = false;
            this.grpbxCamera.Text = "Step 1: Choose your camera";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(470, 19);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "888888";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(302, 19);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "admin";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(213, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(45, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "81";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPAddress.Location = new System.Drawing.Point(72, 19);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAddress.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(408, 22);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(264, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(178, 22);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(6, 22);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(60, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP address:";
            // 
            // grpbxRetrieve
            // 
            this.grpbxRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxRetrieve.Controls.Add(this.btnRetrieve);
            this.grpbxRetrieve.Controls.Add(this.lbxFiles);
            this.grpbxRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxRetrieve.Location = new System.Drawing.Point(12, 70);
            this.grpbxRetrieve.Name = "grpbxRetrieve";
            this.grpbxRetrieve.Size = new System.Drawing.Size(760, 376);
            this.grpbxRetrieve.TabIndex = 1;
            this.grpbxRetrieve.TabStop = false;
            this.grpbxRetrieve.Text = "Step 2: Retrieve a list of files on the SD card and select the ones to download";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.Location = new System.Drawing.Point(6, 19);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(748, 23);
            this.btnRetrieve.TabIndex = 0;
            this.btnRetrieve.Text = "Retrieve list of files";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // lbxFiles
            // 
            this.lbxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.Location = new System.Drawing.Point(6, 45);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxFiles.Size = new System.Drawing.Size(748, 316);
            this.lbxFiles.TabIndex = 1;
            // 
            // grpbxDownload
            // 
            this.grpbxDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxDownload.Controls.Add(this.btnDownload);
            this.grpbxDownload.Controls.Add(this.btnSelectDownloadFolder);
            this.grpbxDownload.Controls.Add(this.txtDownloadFolder);
            this.grpbxDownload.Controls.Add(this.chkOverwrite);
            this.grpbxDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxDownload.Location = new System.Drawing.Point(12, 452);
            this.grpbxDownload.Name = "grpbxDownload";
            this.grpbxDownload.Size = new System.Drawing.Size(760, 97);
            this.grpbxDownload.TabIndex = 2;
            this.grpbxDownload.TabStop = false;
            this.grpbxDownload.Text = "Step 3: Choose your download location and download the files";
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(6, 68);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(748, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSelectDownloadFolder
            // 
            this.btnSelectDownloadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDownloadFolder.Location = new System.Drawing.Point(724, 17);
            this.btnSelectDownloadFolder.Name = "btnSelectDownloadFolder";
            this.btnSelectDownloadFolder.Size = new System.Drawing.Size(30, 23);
            this.btnSelectDownloadFolder.TabIndex = 1;
            this.btnSelectDownloadFolder.Text = "...";
            this.btnSelectDownloadFolder.UseVisualStyleBackColor = true;
            this.btnSelectDownloadFolder.Click += new System.EventHandler(this.btnSelectDownloadFolder_Click);
            // 
            // txtDownloadFolder
            // 
            this.txtDownloadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloadFolder.Location = new System.Drawing.Point(6, 19);
            this.txtDownloadFolder.Name = "txtDownloadFolder";
            this.txtDownloadFolder.Size = new System.Drawing.Size(712, 20);
            this.txtDownloadFolder.TabIndex = 0;
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOverwrite.Location = new System.Drawing.Point(6, 45);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(130, 17);
            this.chkOverwrite.TabIndex = 2;
            this.chkOverwrite.Text = "Overwrite existing files";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpbxDownload);
            this.Controls.Add(this.grpbxRetrieve);
            this.Controls.Add(this.grpbxCamera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VStarcam SD Card Downloader";
            this.grpbxCamera.ResumeLayout(false);
            this.grpbxCamera.PerformLayout();
            this.grpbxRetrieve.ResumeLayout(false);
            this.grpbxDownload.ResumeLayout(false);
            this.grpbxDownload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxCamera;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.GroupBox grpbxRetrieve;
        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.GroupBox grpbxDownload;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.TextBox txtDownloadFolder;
        private System.Windows.Forms.Button btnSelectDownloadFolder;
        private System.Windows.Forms.Button btnDownload;
    }
}

