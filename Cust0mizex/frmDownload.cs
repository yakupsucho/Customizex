using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Reflection;

namespace Cust0mizex
{
    public partial class frmDownload : Form
    {
        #region Variables
        string _url;
        Point ReadySize;
        Point Plus;
        #endregion

        #region Get and Set
        public string url
        {
            get { return _url; }
            set { _url = value; }
        }
        #endregion

        #region Methods

        #region ScreenPosition
        public void ScreenPosition(Point ScreenPosition)
        {
            Plus = new Point(ScreenPosition.X + 475, ScreenPosition.Y);
            this.Location = Plus;
        }
        #endregion

        #region DownloadFile
        public frmDownload()
        {
            InitializeComponent();
        }

        public frmDownload(Point ScreenPosition)
        {
            InitializeComponent();
            
            Point Plus = new Point(ScreenPosition.X + 475, ScreenPosition.Y); 
            ReadySize = Plus;  
        }
        #endregion

        #region DownloadCompleted
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbDownloadProgress.Value = e.ProgressPercentage;
            lblDownloadStatus.Text = "Downloading.. " + pbDownloadProgress.Value + " %";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            lblDownloadStatus.Text = "Download finished";
            Compressor gzip = new Compressor(lbThemes.SelectedItem.ToString() + ".tar.gz", @"Themes/Windows 7", Compressor.Action.UnZip);
        }
        #endregion

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Mapper map = new Mapper();
            
            
            string selected = lbThemes.SelectedItem.ToString();
            
            string loaded = map.LoadLine(@"bin\file\w7links.txt", selected);
            string[] LoadedContent = loaded.Split(';');
            string link = LoadedContent[1];
                        
             url = link;
             WebClient webClient = new WebClient();

             webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
             webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
             webClient.DownloadFileAsync(new Uri(url),selected + ".tar.gz");


            
        }

        #endregion

        private void frmDownload_Load(object sender, EventArgs e)
        {

            string[] ThemeList = LoadThemeList();

            for (int i = 0; i < ThemeList.Length; i++)
            {
                if (i % 2 == 0)
                {
                    lbThemes.Items.Add(ThemeList[i]);
                }
            }
        }

        private string[] LoadThemeList()
        {
            Mapper load = new Mapper();

            string content = load.Load(@"bin\file\w7links.txt");

            string[] ThemeList = content.Split(';');

            return ThemeList;
        }

        
    }
}
