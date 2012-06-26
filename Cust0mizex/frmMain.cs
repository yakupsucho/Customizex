using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Cust0mizex
{
    public partial class frmMain : Form
    {
        #region Variables
        CopyData copy = new CopyData();
        private Point _mouseposition;
        public Point ScreenPosition;
        frmDownload Download = new frmDownload();
        frmSetup Setup = new frmSetup();
        Patcher patch = new Patcher();
        #endregion

        #region Methods
        public frmMain()
        {
            InitializeComponent();
        }

        #region MoveForm
        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseposition = new Point(-e.X, -e.Y);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(_mouseposition.X, _mouseposition.Y);
                System.Threading.Thread.Sleep(1);
                Location = mousePos;
                ScreenPosition = this.Location;
                Setup.ScreenPosition(ScreenPosition);
                Download.ScreenPosition(ScreenPosition);
            }
        }
        #endregion

        #region ExtendForm
        private void pbExtendRight_Click(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap(@"");
            //pbExtendRight.Image = bmp;
            Download.Show();
            Download.Location = new Point(this.Location.X + 475, this.Location.Y);
        }

        private void pbExtendLeft_Click(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap(@"");
            //pbExtendLeft.Image = bmp;
            Setup.Show();
            Setup.Location = new Point(this.Location.X - 347, this.Location.Y);
        }
        

        private void pbExtendLeft_DoubleClick(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap(@"");
            //pbExtendedRight.Image = bmp;
            Setup.Hide();
        }

        private void pbExtendRight_DoubleClick(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap(@"");
            //pbExtendedRight.Image = bmp;
            Download.Hide();
        }
        #endregion

        #region LoadForm
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Patcher"))
            {
            }
            else
            {
                copy.CopyDirectory(@"DLL-FILES", @"C:\DLL-FILES");
            }


            System.IO.DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(@"C:\Windows\Resources\Themes");

            try
            {
                foreach (System.IO.FileInfo f in ParentDirectory.GetFiles())
                {
                    lbThemes.Items.Add(f.Name);
                }

                foreach (System.IO.DirectoryInfo d in ParentDirectory.GetDirectories())
                {
                    lbThemes.Items.Add(d.Name);
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            System.IO.DirectoryInfo DownloadedThemesDirectory = new System.IO.DirectoryInfo(@"Themes/Windows 7");

            try
            {
                foreach (System.IO.FileInfo f in DownloadedThemesDirectory.GetFiles())
                {
                    lbDownloadedThemes.Items.Add(f.Name);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            
        }
        #endregion

        private void pbDeleteTheme_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void pbClose_Click(object sender, EventArgs e)
        {
            frmMain.ActiveForm.Close();
        }

        private void pbThemePreview_Click(object sender, EventArgs e)
        {
            frmFullScreenView.ActiveForm.Show();
        }

        private void btnInstallTheme_Click(object sender, EventArgs e)
        {
            string name = lbDownloadedThemes.SelectedItem.ToString();
            string[] NameAndSuffix = name.Split('.');

            copy.CopyDirectory(@"Themes\Windows 7\" + NameAndSuffix[0], @"C:\Windows\Resources\Themes\" + NameAndSuffix[0]);
            copy.CopyFile(@"Themes\Windows 7\" + name, @"C:\Windows\Resources\Themes\" + name);
        }

        private void lbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApplyTheme_Click(object sender, EventArgs e)
        {
            patch.UseTheme(lbThemes.SelectedItem.ToString());
        }
    }
}
