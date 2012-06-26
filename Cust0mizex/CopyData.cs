using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Cust0mizex
{
    class CopyData
    {
        #region Methods

        #region CopyFile
        public void CopyFile(string SourcePath, string DestinationPath)
        {
            if (File.Exists(SourcePath))
            {
                File.Copy(SourcePath, DestinationPath, true);
            }
            else
            {
                MessageBox.Show("Dateipfad fehlerhaft !");
            }
        }
        #endregion

        #region CopyDirectory
        public void CopyDirectory(string SourceDirectory, string DestinationDirectory)
        {
            if (Directory.Exists(SourceDirectory))
            {
                Directory.CreateDirectory(DestinationDirectory);

                string[] files = Directory.GetFiles(SourceDirectory);

                foreach (string file in files)
                {

                    string target = Path.Combine(DestinationDirectory, Path.GetFileName(file));

                    File.Copy(file, target, true);

                }
                string[] subSourceFolders = Directory.GetDirectories(SourceDirectory);

                foreach (string subSourceFolder in subSourceFolders)
                {

                    string subTargetFolder = subSourceFolder.Replace(SourceDirectory, DestinationDirectory);

                    CopyDirectory(subSourceFolder, subTargetFolder);

                }
            }
            else
            {
                MessageBox.Show("Ordnerpfad fehlerhaft !");
            }
        }
        #endregion

        #endregion
    }
}
