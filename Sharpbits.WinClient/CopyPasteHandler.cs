using System;
using System.Collections.Specialized;
using System.Windows.Forms;
using SharpBits.Base;

namespace SharpBits.WinClient
{
    public static class CopyPasteHandler
    {
        // Methods
        public static JobType GetJobType(out string[] files)
        {
            Uri result = null;
            if (Clipboard.ContainsText())
            {
                if (Uri.TryCreate(Clipboard.GetText(), UriKind.Absolute, out result))
                {
                    files = new string[] { result.AbsoluteUri };
                    if (!result.IsFile && !result.IsUnc)
                    {
                        return JobType.Download;
                    }
                    return JobType.Upload;
                }
            }
            else if (Clipboard.ContainsFileDropList())
            {
                StringCollection fileDropList = Clipboard.GetFileDropList();
                files = new string[fileDropList.Count];
                fileDropList.CopyTo(files, 0);
                return JobType.Upload;
            }
            files = new string[0];
            return JobType.Unknown;
        }
    }


}
