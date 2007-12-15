using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBits.Base
{
    public class JobReplyProgress
    {
        private BG_JOB_REPLY_PROGRESS jobReplyProgress;

        internal JobReplyProgress(BG_JOB_REPLY_PROGRESS jobReplyProgress)
        {
            this.jobReplyProgress = jobReplyProgress;
        }

        public ulong BytesTotal
        {
            get 
            {
                if (this.jobReplyProgress.BytesTotal == ulong.MaxValue)
                    return 0;
                return this.jobReplyProgress.BytesTotal; 
            }
        }

        public ulong BytesTransferred
        {
            get { return this.jobReplyProgress.BytesTransferred;  }
        }

    }
}
