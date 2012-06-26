namespace Cust0mizex
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbExtendRight = new System.Windows.Forms.PictureBox();
            this.pbExtendLeft = new System.Windows.Forms.PictureBox();
            this.lbThemes = new System.Windows.Forms.ListBox();
            this.pbThemePreview = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnApplyTheme = new System.Windows.Forms.Button();
            this.btnInstallTheme = new System.Windows.Forms.Button();
            this.tcThemes = new System.Windows.Forms.TabControl();
            this.tpInstalledThemes = new System.Windows.Forms.TabPage();
            this.tpDownloadedThemes = new System.Windows.Forms.TabPage();
            this.lbDownloadedThemes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtendRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtendLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThemePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.tcThemes.SuspendLayout();
            this.tpInstalledThemes.SuspendLayout();
            this.tpDownloadedThemes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbExtendRight
            // 
            this.pbExtendRight.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbExtendRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbExtendRight.BackgroundImage")));
            this.pbExtendRight.Image = ((System.Drawing.Image)(resources.GetObject("pbExtendRight.Image")));
            this.pbExtendRight.Location = new System.Drawing.Point(445, 131);
            this.pbExtendRight.Name = "pbExtendRight";
            this.pbExtendRight.Size = new System.Drawing.Size(25, 31);
            this.pbExtendRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExtendRight.TabIndex = 0;
            this.pbExtendRight.TabStop = false;
            this.pbExtendRight.Click += new System.EventHandler(this.pbExtendRight_Click);
            this.pbExtendRight.DoubleClick += new System.EventHandler(this.pbExtendRight_DoubleClick);
            // 
            // pbExtendLeft
            // 
            this.pbExtendLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbExtendLeft.BackgroundImage")));
            this.pbExtendLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbExtendLeft.Image")));
            this.pbExtendLeft.Location = new System.Drawing.Point(12, 131);
            this.pbExtendLeft.Name = "pbExtendLeft";
            this.pbExtendLeft.Size = new System.Drawing.Size(25, 31);
            this.pbExtendLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExtendLeft.TabIndex = 1;
            this.pbExtendLeft.TabStop = false;
            this.pbExtendLeft.Click += new System.EventHandler(this.pbExtendLeft_Click);
            this.pbExtendLeft.DoubleClick += new System.EventHandler(this.pbExtendLeft_DoubleClick);
            // 
            // lbThemes
            // 
            this.lbThemes.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbThemes.ForeColor = System.Drawing.SystemColors.Control;
            this.lbThemes.FormattingEnabled = true;
            this.lbThemes.Location = new System.Drawing.Point(0, 0);
            this.lbThemes.Name = "lbThemes";
            this.lbThemes.Size = new System.Drawing.Size(178, 108);
            this.lbThemes.TabIndex = 2;
            this.lbThemes.SelectedIndexChanged += new System.EventHandler(this.lbThemes_SelectedIndexChanged);
            // 
            // pbThemePreview
            // 
            this.pbThemePreview.Image = ((System.Drawing.Image)(resources.GetObject("pbThemePreview.Image")));
            this.pbThemePreview.Location = new System.Drawing.Point(235, 123);
            this.pbThemePreview.Name = "pbThemePreview";
            this.pbThemePreview.Size = new System.Drawing.Size(204, 134);
            this.pbThemePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThemePreview.TabIndex = 10;
            this.pbThemePreview.TabStop = false;
            this.pbThemePreview.Click += new System.EventHandler(this.pbThemePreview_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClose.BackgroundImage")));
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(445, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(27, 28);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 11;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // btnApplyTheme
            // 
            this.btnApplyTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApplyTheme.BackgroundImage")));
            this.btnApplyTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyTheme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnApplyTheme.Location = new System.Drawing.Point(345, 63);
            this.btnApplyTheme.Name = "btnApplyTheme";
            this.btnApplyTheme.Size = new System.Drawing.Size(94, 27);
            this.btnApplyTheme.TabIndex = 12;
            this.btnApplyTheme.Text = "Apply Theme";
            this.btnApplyTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnApplyTheme.UseVisualStyleBackColor = true;
            this.btnApplyTheme.Click += new System.EventHandler(this.btnApplyTheme_Click);
            // 
            // btnInstallTheme
            // 
            this.btnInstallTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInstallTheme.BackgroundImage")));
            this.btnInstallTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallTheme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInstallTheme.Location = new System.Drawing.Point(235, 63);
            this.btnInstallTheme.Name = "btnInstallTheme";
            this.btnInstallTheme.Size = new System.Drawing.Size(90, 27);
            this.btnInstallTheme.TabIndex = 13;
            this.btnInstallTheme.Text = "Install Theme";
            this.btnInstallTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInstallTheme.UseVisualStyleBackColor = true;
            this.btnInstallTheme.Click += new System.EventHandler(this.btnInstallTheme_Click);
            // 
            // tcThemes
            // 
            this.tcThemes.Controls.Add(this.tpInstalledThemes);
            this.tcThemes.Controls.Add(this.tpDownloadedThemes);
            this.tcThemes.Location = new System.Drawing.Point(43, 41);
            this.tcThemes.Name = "tcThemes";
            this.tcThemes.SelectedIndex = 0;
            this.tcThemes.Size = new System.Drawing.Size(186, 133);
            this.tcThemes.TabIndex = 14;
            // 
            // tpInstalledThemes
            // 
            this.tpInstalledThemes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpInstalledThemes.BackgroundImage")));
            this.tpInstalledThemes.Controls.Add(this.lbThemes);
            this.tpInstalledThemes.Location = new System.Drawing.Point(4, 22);
            this.tpInstalledThemes.Name = "tpInstalledThemes";
            this.tpInstalledThemes.Padding = new System.Windows.Forms.Padding(3);
            this.tpInstalledThemes.Size = new System.Drawing.Size(178, 107);
            this.tpInstalledThemes.TabIndex = 0;
            this.tpInstalledThemes.Text = "Installed";
            this.tpInstalledThemes.UseVisualStyleBackColor = true;
            // 
            // tpDownloadedThemes
            // 
            this.tpDownloadedThemes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpDownloadedThemes.BackgroundImage")));
            this.tpDownloadedThemes.Controls.Add(this.lbDownloadedThemes);
            this.tpDownloadedThemes.Location = new System.Drawing.Point(4, 22);
            this.tpDownloadedThemes.Name = "tpDownloadedThemes";
            this.tpDownloadedThemes.Padding = new System.Windows.Forms.Padding(3);
            this.tpDownloadedThemes.Size = new System.Drawing.Size(178, 107);
            this.tpDownloadedThemes.TabIndex = 1;
            this.tpDownloadedThemes.Text = "Downloaded";
            this.tpDownloadedThemes.UseVisualStyleBackColor = true;
            // 
            // lbDownloadedThemes
            // 
            this.lbDownloadedThemes.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbDownloadedThemes.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDownloadedThemes.FormattingEnabled = true;
            this.lbDownloadedThemes.Location = new System.Drawing.Point(0, -1);
            this.lbDownloadedThemes.Name = "lbDownloadedThemes";
            this.lbDownloadedThemes.Size = new System.Drawing.Size(178, 108);
            this.lbDownloadedThemes.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 288);
            this.Controls.Add(this.tcThemes);
            this.Controls.Add(this.btnInstallTheme);
            this.Controls.Add(this.btnApplyTheme);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbThemePreview);
            this.Controls.Add(this.pbExtendLeft);
            this.Controls.Add(this.pbExtendRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Cust0mizex";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbExtendRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtendLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThemePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.tcThemes.ResumeLayout(false);
            this.tpInstalledThemes.ResumeLayout(false);
            this.tpDownloadedThemes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbExtendRight;
        private System.Windows.Forms.PictureBox pbExtendLeft;
        private System.Windows.Forms.ListBox lbThemes;
        private System.Windows.Forms.PictureBox pbThemePreview;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnApplyTheme;
        private System.Windows.Forms.Button btnInstallTheme;
        private System.Windows.Forms.TabControl tcThemes;
        private System.Windows.Forms.TabPage tpInstalledThemes;
        private System.Windows.Forms.TabPage tpDownloadedThemes;
        private System.Windows.Forms.ListBox lbDownloadedThemes;
    }
}