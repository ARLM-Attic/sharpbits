using System;
using System.Collections.Generic;

namespace SharpBits.Base
{
    public class FileProgress
    {
        private BG_FILE_PROGRESS fileProgress;

        internal FileProgress(BG_FILE_PROGRESS fileProgress)
        {
            this.fileProgress = fileProgress;
        }

        public ulong BytesTotal
        {
            get
            {
                if (this.fileProgress.BytesTotal == ulong.MaxValue)
                    return 0;
                return this.fileProgress.BytesTotal; 
            }
        }

        public ulong BytesTransferred
        {
            get { return this.fileProgress.BytesTransferred; }
        }

        public bool Completed
        {
            get { return Convert.ToBoolean(this.fileProgress.Completed); }
        }
    }
}
