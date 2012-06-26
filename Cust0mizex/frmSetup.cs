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
    public partial class frmSetup : Form
    {
        #region Variables
        CopyData copyfile = new CopyData();
        FolderBrowserDialog ofd = new FolderBrowserDialog();
        Windows win = new Windows();
        Point ReadySize;
        Patcher takeownership = new Patcher();
        #endregion

        #region Methods
        public frmSetup()
        {
            InitializeComponent();
            rtxtChangeLog.LoadFile(@"bin\log\changelog.rtf");
        }
        
        public frmSetup(Point ScreenPosition)
        {
            InitializeComponent();
            Point Plus = new Point(ScreenPosition.X - 347, ScreenPosition.Y);
            ReadySize = Plus;
        }

        public void ScreenPosition(Point ScreenPosition)
        {
            Point Plus = new Point(ScreenPosition.X - 347, ScreenPosition.Y);
            this.Location = Plus;
        }
        #endregion

        private void btnPatchSystem_Click(object sender, EventArgs e)
        {
            takeownership.PatchSystemX64();
            MessageBox.Show("You need to restart your PC to apply the changes", "Restart needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
