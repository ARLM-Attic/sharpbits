using System;
using SharpBits.Base;

namespace SharpBits.WinClient
{
    public static class FileHandler
    {
        // Methods
        public static JobType GetJobType(string file)
        {
            Uri result = null;
            if (!Uri.TryCreate(file, UriKind.Absolute, out result))
            {
                return JobType.Unknown;
            }
            file = result.AbsoluteUri;
            if (!result.IsFile && !result.IsUnc)
            {
                return JobType.Download;
            }
            return JobType.Upload;
        }
    }

 
}
