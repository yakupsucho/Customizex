using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Cust0mizex
{
    class NetStat
    {
        public static bool IsUrlValid(string url)
        {
            bool response = false;
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(url);
                response = true;
            }
            catch
            {
                response = false;
            }
            return response;
        }
    }
}
