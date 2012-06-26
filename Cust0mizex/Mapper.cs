using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Cust0mizex
{
    class Mapper
    {
        #region Methods

        public string Load(string path)
        {
            StreamReader sr = new StreamReader(path);
            string content = "";
            

            while (!sr.EndOfStream)
            {
                content += sr.ReadLine() + ";";
            }

            return content;
        }

        public string LoadLine(string path, string searchstring)
        {
            StreamReader sr = new StreamReader(path);
            string content = "";

            while (!sr.EndOfStream)
            {
                content = sr.ReadLine();

                if (content.StartsWith(searchstring))
                {
                    break;
                }
                else
                {
                    content = "no match";
                }
            }

            return content;
        }

        public void Save(string path, string[] Content)
        {
            StreamWriter sw = new StreamWriter(path);

            for (int i = 0; i < Content.Length; i++)
            {
                sw.WriteLine(i);
            }
        }
        #endregion
    }
}
