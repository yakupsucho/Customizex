using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Windows;
using System.Security.Principal;
using System.Runtime;
using System.Diagnostics;

namespace Cust0mizex
{
    class Patcher
    {
        #region Methods
        
        public void PatchSystemX64()
        {
            Windows win = new Windows();
            CopyData copyfile = new CopyData();
            string username = win.GetUsername();

            AddFileSecurity(@"C:\Windows\System32\uxtheme.dll", username, FileSystemRights.Modify, AccessControlType.Allow);
            AddFileSecurity(@"C:\Windows\System32\themeservice.dll", username, FileSystemRights.Modify, AccessControlType.Allow);
            AddFileSecurity(@"C:\Windows\System32\themeui.dll", username, FileSystemRights.Modify, AccessControlType.Allow);

            Process FirstProcess = new Process();

            FirstProcess.StartInfo.FileName = @"TakeOwnerShip.bat";
            FirstProcess.Start();


            Process SecondProcess = new Process();
            SecondProcess.StartInfo.FileName = @"copyw7x64.bat";
            SecondProcess.Start();
           
        }

        public static void AddFileSecurity(string filename, string account, FileSystemRights rights, AccessControlType controlType)
        {
            if (File.Exists(filename))
            {
                FileSecurity fSecurity = File.GetAccessControl(filename, AccessControlSections.All);
                fSecurity.AddAccessRule(new FileSystemAccessRule(account, rights, controlType));
                File.SetAccessControl(filename, fSecurity);
            }
        }

        public void UseTheme(string ThemeName)
        {
            Process Pr = new Process();

            Pr.StartInfo.FileName = @"C:\Windows\Resources\Themes\" + ThemeName;
            Pr.Start();
        }

        #endregion
    }
}
