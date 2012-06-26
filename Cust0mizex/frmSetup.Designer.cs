namespace Cust0mizex
{
    partial class frmSetup
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetup));
            this.tcSetup = new System.Windows.Forms.TabControl();
            this.tpGeneralSettings = new System.Windows.Forms.TabPage();
            this.btnRestoreTheme = new System.Windows.Forms.Button();
            this.btnPatchSystem = new System.Windows.Forms.Button();
            this.tpCloudSettings = new System.Windows.Forms.TabPage();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblSyncStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pbUpdate = new System.Windows.Forms.ProgressBar();
            this.lblVersionNumber = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCheckForUpdate = new System.Windows.Forms.Button();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pbDeviantArt = new System.Windows.Forms.PictureBox();
            this.lblPoweredBy = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.tpChangeLog = new System.Windows.Forms.TabPage();
            this.rtxtChangeLog = new System.Windows.Forms.RichTextBox();
            this.tcSetup.SuspendLayout();
            this.tpGeneralSettings.SuspendLayout();
            this.tpCloudSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpUpdate.SuspendLayout();
            this.tpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeviantArt)).BeginInit();
            this.tpChangeLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSetup
            // 
            this.tcSetup.Controls.Add(this.tpGeneralSettings);
            this.tcSetup.Controls.Add(this.tpCloudSettings);
            this.tcSetup.Controls.Add(this.tpUpdate);
            this.tcSetup.Controls.Add(this.tpInfo);
            this.tcSetup.Controls.Add(this.tpChangeLog);
            this.tcSetup.Location = new System.Drawing.Point(12, 12);
            this.tcSetup.Name = "tcSetup";
            this.tcSetup.SelectedIndex = 0;
            this.tcSetup.Size = new System.Drawing.Size(321, 264);
            this.tcSetup.TabIndex = 0;
            // 
            // tpGeneralSettings
            // 
            this.tpGeneralSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpGeneralSettings.BackgroundImage")));
            this.tpGeneralSettings.Controls.Add(this.btnRestoreTheme);
            this.tpGeneralSettings.Controls.Add(this.btnPatchSystem);
            this.tpGeneralSettings.Location = new System.Drawing.Point(4, 22);
            this.tpGeneralSettings.Name = "tpGeneralSettings";
            this.tpGeneralSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneralSettings.Size = new System.Drawing.Size(313, 238);
            this.tpGeneralSettings.TabIndex = 0;
            this.tpGeneralSettings.Text = "General";
            this.tpGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // btnRestoreTheme
            // 
            this.btnRestoreTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestoreTheme.BackgroundImage")));
            this.btnRestoreTheme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestoreTheme.Location = new System.Drawing.Point(42, 55);
            this.btnRestoreTheme.Name = "btnRestoreTheme";
            this.btnRestoreTheme.Size = new System.Drawing.Size(226, 23);
            this.btnRestoreTheme.TabIndex = 2;
            this.btnRestoreTheme.Text = "Reset Windows Theme";
            this.btnRestoreTheme.UseVisualStyleBackColor = true;
            // 
            // btnPatchSystem
            // 
            this.btnPatchSystem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatchSystem.BackgroundImage")));
            this.btnPatchSystem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPatchSystem.Location = new System.Drawing.Point(42, 26);
            this.btnPatchSystem.Name = "btnPatchSystem";
            this.btnPatchSystem.Size = new System.Drawing.Size(226, 23);
            this.btnPatchSystem.TabIndex = 0;
            this.btnPatchSystem.Text = "Patch System";
            this.btnPatchSystem.UseVisualStyleBackColor = true;
            this.btnPatchSystem.Click += new System.EventHandler(this.btnPatchSystem_Click);
            // 
            // tpCloudSettings
            // 
            this.tpCloudSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpCloudSettings.BackgroundImage")));
            this.tpCloudSettings.Controls.Add(this.txtPassword);
            this.tpCloudSettings.Controls.Add(this.txtUsername);
            this.tpCloudSettings.Controls.Add(this.btnSync);
            this.tpCloudSettings.Controls.Add(this.btnLogIn);
            this.tpCloudSettings.Controls.Add(this.lblSyncStatus);
            this.tpCloudSettings.Controls.Add(this.pictureBox1);
            this.tpCloudSettings.Location = new System.Drawing.Point(4, 22);
            this.tpCloudSettings.Name = "tpCloudSettings";
            this.tpCloudSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpCloudSettings.Size = new System.Drawing.Size(313, 238);
            this.tpCloudSettings.TabIndex = 1;
            this.tpCloudSettings.Text = "Cloud";
            this.tpCloudSettings.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(24, 197);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(24, 168);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(149, 20);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "Username";
            // 
            // btnSync
            // 
            this.btnSync.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSync.BackgroundImage")));
            this.btnSync.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSync.Location = new System.Drawing.Point(179, 194);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(108, 23);
            this.btnSync.TabIndex = 3;
            this.btnSync.Text = "sync";
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogIn.BackgroundImage")));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogIn.Location = new System.Drawing.Point(179, 165);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(108, 23);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // lblSyncStatus
            // 
            this.lblSyncStatus.AutoSize = true;
            this.lblSyncStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSyncStatus.Location = new System.Drawing.Point(237, 222);
            this.lblSyncStatus.Name = "lblSyncStatus";
            this.lblSyncStatus.Size = new System.Drawing.Size(73, 13);
            this.lblSyncStatus.TabIndex = 1;
            this.lblSyncStatus.Text = "log in required";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpUpdate.BackgroundImage")));
            this.tpUpdate.Controls.Add(this.label1);
            this.tpUpdate.Controls.Add(this.pbUpdate);
            this.tpUpdate.Controls.Add(this.lblVersionNumber);
            this.tpUpdate.Controls.Add(this.lblVersion);
            this.tpUpdate.Controls.Add(this.btnUpdate);
            this.tpUpdate.Controls.Add(this.btnCheckForUpdate);
            this.tpUpdate.Location = new System.Drawing.Point(4, 22);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(313, 238);
            this.tpUpdate.TabIndex = 2;
            this.tpUpdate.Text = "Update";
            this.tpUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(53, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "You can now download a new version !";
            this.label1.Visible = false;
            // 
            // pbUpdate
            // 
            this.pbUpdate.Location = new System.Drawing.Point(37, 199);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(223, 23);
            this.pbUpdate.TabIndex = 4;
            this.pbUpdate.Visible = false;
            // 
            // lblVersionNumber
            // 
            this.lblVersionNumber.AutoSize = true;
            this.lblVersionNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVersionNumber.Location = new System.Drawing.Point(114, 33);
            this.lblVersionNumber.Name = "lblVersionNumber";
            this.lblVersionNumber.Size = new System.Drawing.Size(31, 13);
            this.lblVersionNumber.TabIndex = 3;
            this.lblVersionNumber.Text = "0.4.0";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVersion.Location = new System.Drawing.Point(63, 33);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(37, 151);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(223, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCheckForUpdate
            // 
            this.btnCheckForUpdate.Location = new System.Drawing.Point(37, 78);
            this.btnCheckForUpdate.Name = "btnCheckForUpdate";
            this.btnCheckForUpdate.Size = new System.Drawing.Size(223, 23);
            this.btnCheckForUpdate.TabIndex = 0;
            this.btnCheckForUpdate.Text = "Check for Updates";
            this.btnCheckForUpdate.UseVisualStyleBackColor = true;
            // 
            // tpInfo
            // 
            this.tpInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpInfo.BackgroundImage")));
            this.tpInfo.Controls.Add(this.linkLabel1);
            this.tpInfo.Controls.Add(this.pbDeviantArt);
            this.tpInfo.Controls.Add(this.lblPoweredBy);
            this.tpInfo.Controls.Add(this.lblDeveloper);
            this.tpInfo.Controls.Add(this.lblYear);
            this.tpInfo.Controls.Add(this.lblProjectName);
            this.tpInfo.Location = new System.Drawing.Point(4, 22);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(313, 238);
            this.tpInfo.TabIndex = 3;
            this.tpInfo.Text = "Info";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Location = new System.Drawing.Point(171, 190);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DeviantArt";
            // 
            // pbDeviantArt
            // 
            this.pbDeviantArt.Image = ((System.Drawing.Image)(resources.GetObject("pbDeviantArt.Image")));
            this.pbDeviantArt.Location = new System.Drawing.Point(84, 168);
            this.pbDeviantArt.Name = "pbDeviantArt";
            this.pbDeviantArt.Size = new System.Drawing.Size(81, 64);
            this.pbDeviantArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeviantArt.TabIndex = 4;
            this.pbDeviantArt.TabStop = false;
            // 
            // lblPoweredBy
            // 
            this.lblPoweredBy.AutoSize = true;
            this.lblPoweredBy.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPoweredBy.Location = new System.Drawing.Point(20, 152);
            this.lblPoweredBy.Name = "lblPoweredBy";
            this.lblPoweredBy.Size = new System.Drawing.Size(103, 13);
            this.lblPoweredBy.TabIndex = 3;
            this.lblPoweredBy.Text = "Themes powered by";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeveloper.Location = new System.Drawing.Point(104, 113);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(100, 13);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "Yakup Suchorabski";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYear.Location = new System.Drawing.Point(121, 85);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(64, 13);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "2012 - 2013";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProjectName.Location = new System.Drawing.Point(121, 53);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(69, 13);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Cust0mizex©";
            // 
            // tpChangeLog
            // 
            this.tpChangeLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpChangeLog.BackgroundImage")));
            this.tpChangeLog.Controls.Add(this.rtxtChangeLog);
            this.tpChangeLog.Location = new System.Drawing.Point(4, 22);
            this.tpChangeLog.Name = "tpChangeLog";
            this.tpChangeLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpChangeLog.Size = new System.Drawing.Size(313, 238);
            this.tpChangeLog.TabIndex = 4;
            this.tpChangeLog.Text = "changelog";
            this.tpChangeLog.UseVisualStyleBackColor = true;
            // 
            // rtxtChangeLog
            // 
            this.rtxtChangeLog.Location = new System.Drawing.Point(6, 6);
            this.rtxtChangeLog.Name = "rtxtChangeLog";
            this.rtxtChangeLog.Size = new System.Drawing.Size(301, 226);
            this.rtxtChangeLog.TabIndex = 0;
            this.rtxtChangeLog.Text = "";
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 288);
            this.Controls.Add(this.tcSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSetup";
            this.Text = "Cust0mizex - Setup";
            this.tcSetup.ResumeLayout(false);
            this.tpGeneralSettings.ResumeLayout(false);
            this.tpCloudSettings.ResumeLayout(false);
            this.tpCloudSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeviantArt)).EndInit();
            this.tpChangeLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSetup;
        private System.Windows.Forms.TabPage tpGeneralSettings;
        private System.Windows.Forms.TabPage tpCloudSettings;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCheckForUpdate;
        private System.Windows.Forms.Label lblVersionNumber;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ProgressBar pbUpdate;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.PictureBox pbDeviantArt;
        private System.Windows.Forms.Label lblPoweredBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRestoreTheme;
        private System.Windows.Forms.Button btnPatchSystem;
        private System.Windows.Forms.TabPage tpChangeLog;
        private System.Windows.Forms.RichTextBox rtxtChangeLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSyncStatus;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}