using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cust0mizex
{
    public partial class frmFullScreenView : Form
    {

        public frmFullScreenView(string Previewpath)
        {
            InitializeComponent();
            pbPreview.Load(Previewpath);
        }

        
    }
}
