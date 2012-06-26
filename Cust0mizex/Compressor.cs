using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Cust0mizex
{
    /*
        GZip oZip = new GZip(@"C:\Test.txt", @"C:\Test1.txt", Action.Zip);
        oZip = new GZip(@"C:\Test1.txt", @"C:\Test2.txt", Action.UnZip);
    */
    class Compressor
    {
        public enum Action { Zip, UnZip };
        private string _SourceFileName = "";
        private string _DestinationFileName = "";
        private byte[] oBuffer;
        private GZipStream oZipper;

        public Compressor() { }
        public Compressor(string SourceFileName, string DestinationFileName, Action action)
        {
            oZipper = null;
            this.SourceFileName = SourceFileName;
            this.DestinationFileName = DestinationFileName;
            if (action == Action.Zip)
                this.CompressFile();
            if (action == Action.UnZip)
                this.DecompressFile();
        }

        public string SourceFileName
        {
            get { return _SourceFileName; }
            set { _SourceFileName = value; }
        }
        public string DestinationFileName
        {
            get { return _DestinationFileName; }
            set { _DestinationFileName = value; }
        }
        protected void CompressFile()
        {

            if (File.Exists(SourceFileName))
            {
                using (FileStream inputFile = File.Open(SourceFileName, FileMode.Open), outputFile = File.Create(DestinationFileName))
                {
                    using (oZipper = new GZipStream(outputFile, CompressionMode.Compress))
                    {
                        oBuffer = new byte[inputFile.Length];
                        int counter = 0;
                        while ((counter = inputFile.Read(oBuffer, 0, oBuffer.Length)) != 0)
                        {
                            oZipper.Write(oBuffer, 0, counter);
                        }
                    }
                    oBuffer = null;
                }
            }
        }

        protected void DecompressFile()
        {

            if (File.Exists(SourceFileName))
            {
                using (FileStream inputFile = File.Open(SourceFileName, FileMode.Open), outputFile = File.Create(DestinationFileName))
                {
                    using (oZipper = new GZipStream(inputFile, CompressionMode.Decompress))
                    {
                        oBuffer = new byte[inputFile.Length];
                        int counter;
                        while ((counter = oZipper.Read(oBuffer, 0, oBuffer.Length)) != 0)
                        {
                            outputFile.Write(oBuffer, 0, counter);
                        }
                    }
                    oBuffer = null;
                }
            }
        }
    }
}

