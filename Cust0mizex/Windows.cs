using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Management;
using System.Security.Permissions;
using System.Security.Principal;
using System.ComponentModel;
using System.Diagnostics;

namespace Cust0mizex
{
    class Windows
    {
        #region Methods
        public string GetBItVersion()
        {
            string _strOS = "";

            string value = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE", EnvironmentVariableTarget.Machine);
            _strOS += value.StartsWith("x86") ? "(32bit)" : "(64bit)";

            return value;
        }

        public string GetUsername()
        {
            string Userinfo = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] DomainAndUser = Userinfo.Split('\\');
            return DomainAndUser[1];
        }
       
        #endregion
    }
}
