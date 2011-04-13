using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace SharpBits.Base
{
    public partial class BitsFile : IDisposable
    {
        private IBackgroundCopyFile file;
        private FileProgress progress;
        private bool disposed;
        private BitsJob job;

        internal BitsFile(BitsJob job, IBackgroundCopyFile file)
        {
            if (null == file)
                throw new ArgumentNullException("file", "Parameter IBackgroundCopyFile cannot be a null reference");
            this.file = file;
            this.file2 = file as IBackgroundCopyFile2;
            this.job = job;
        }

        #region public properties
        public string LocalName
        {
            get
            {
                string name = string.Empty;
                try
                {
                    this.file.GetLocalName(out name);
                }
                catch (COMException exception)
                {
                    this.job.PublishException(exception);
                }
                return name;
            }
        }

        public string RemoteName
        {
            get
            {
                string name = string.Empty;
                try
                {
                    this.file.GetRemoteName(out name);
                }
                catch (COMException exception)
                {
                    this.job.PublishException(exception);
                }
                return name;
            }
            set //supported in IBackgroundCopyFile2
            {
                try
                {
                    if (this.file2 != null)
                    {
                        this.file2.SetRemoteName(value);
                    }
                    else
                    {
                        throw new NotSupportedException("IBackgroundCopyFile2");
                    }
                }
                catch (COMException exception)
                {
                    this.job.PublishException(exception);
                }
            }
        }

        public FileProgress Progress
        {
            get
            {
                if (null == this.progress)
                {
                    BG_FILE_PROGRESS fileProgress;
                    try
                    {
                        this.file.GetProgress(out fileProgress);
                        this.progress = new FileProgress(fileProgress);
                    }
                    catch (COMException exception)
                    {
                        this.job.PublishException(exception);
                    }
                }
                return this.progress;
            }
        }
        #endregion

        #region IDisposable Members


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //TODO: release COM resource
                    this.file = null;
                }
            }
            disposed = true;
        }

        #endregion
    }
}
