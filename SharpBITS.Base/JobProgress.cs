using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBits.Base
{
    public class JobProgress
    {
        private BG_JOB_PROGRESS jobProgress;

        internal JobProgress(BG_JOB_PROGRESS jobProgress)
        {
            this.jobProgress = jobProgress;
        }

        public ulong BytesTotal
        {
            get 
            {
                if (this.jobProgress.BytesTotal == ulong.MaxValue)
                    return 0;
                return this.jobProgress.BytesTotal; 
            }
        }

        public ulong BytesTransferred
        {
            get { return this.jobProgress.BytesTransferred;  }
        }

        public uint FilesTotal
        {
            get { return this.jobProgress.FilesTotal;  }
        }

        public uint FilesTransferred
        {
            get { return this.jobProgress.FilesTransferred; }
        }
    }
}
