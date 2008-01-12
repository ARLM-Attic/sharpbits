using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBits.Base
{
    public class BitsFileInfo
    {
        private BG_FILE_INFO fileInfo;

        internal BitsFileInfo(BG_FILE_INFO fileInfo)
        {
            this.fileInfo = fileInfo;
        }

        public BitsFileInfo(string remoteName, string localName)
        {
            this.fileInfo = new BG_FILE_INFO();
            this.fileInfo.RemoteName = remoteName;
            this.fileInfo.LocalName = localName;
        }

        public string RemoteName
        {
            get { return this.fileInfo.RemoteName; }
        }

        public string LocalName
        {
            get { return this.fileInfo.LocalName; }
        }

        internal BG_FILE_INFO _BG_FILE_INFO
        {
            get { return this.fileInfo; }
        }
    }
}
