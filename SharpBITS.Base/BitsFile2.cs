using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Runtime.InteropServices;

namespace SharpBits.Base
{
    public partial class BitsFile : IDisposable
    {
        private IBackgroundCopyFile2 file2;

        #region public properties
        public Collection<FileRange> FileRanges
        {
            get
            {
                try
                {
                    if  (this.file2 != null)
                    {
                        uint count = 0;
                        Collection<FileRange> fileRanges = new Collection<FileRange>();
                        IntPtr rangePtr;
                        this.file2.GetFileRanges(out count, out rangePtr);
                        for (int i = 0; i < count; i++)
                        {
                            BG_FILE_RANGE range = (BG_FILE_RANGE)Marshal.PtrToStructure(rangePtr, typeof(BG_FILE_RANGE));
                            fileRanges.Add(new FileRange(range));
                            rangePtr = new IntPtr((int)rangePtr + System.Runtime.InteropServices.Marshal.SizeOf(range));
                        }
                        return fileRanges;
                    }
                    else
                    {
                        throw new NotSupportedException("IBackgroundCopyFile2");
                    }
                }
                catch (COMException exception)
                {
                    this.job.PublishException(exception);
                    return new Collection<FileRange>();
                }
            }
        }

        #endregion
    }
}