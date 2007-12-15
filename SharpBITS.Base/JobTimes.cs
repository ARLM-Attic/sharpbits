using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBits.Base
{
    public class JobTimes
    {
        private BG_JOB_TIMES jobTimes;

        internal JobTimes(BG_JOB_TIMES jobTimes)
        {
            this.jobTimes = jobTimes;
        }

        public DateTime CreationTime
        {
            get { return Utils.FileTime2DateTime(jobTimes.CreationTime); }
        }

        public DateTime ModificationTime
        {
            get { return Utils.FileTime2DateTime(jobTimes.ModificationTime); }
        }

        public DateTime TransferCompletionTime
        {
            get { return Utils.FileTime2DateTime(jobTimes.TransferCompletionTime); }
        }
    }
}
