using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cust0mizex
{
    class RessourceInstaller
    {
        #region Variables
        CopyData copy = new CopyData();
        #endregion

        #region Methods
        public void FontInstaller(string fontpath)
        {
            copy.CopyFile(fontpath, @"C:\Windows\Fonts");
        }
        public void CursorInstaller()
        {

        }
        #endregion
    }
}
