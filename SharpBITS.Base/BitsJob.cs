using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace SharpBits.Base
{
    public partial class BitsJob: IDisposable
    {
        #region member fields
        private IBackgroundCopyJob job;
        private BitsManager manager;
        private bool disposed;

        private BitsFiles files;
        private JobTimes jobTimes;
        private ProxySettings proxySettings;
        private BitsError error;
        private JobProgress progress;
        private Guid guid;
        //notification
        internal IBackgroundCopyCallback notificationTarget;
        private EventHandler<JobNotificationEventArgs> onJobModified;
        private EventHandler<JobNotificationEventArgs> onJobTransfered;
        private EventHandler<JobErrorNotificationEventArgs> onJobErrored;
        #endregion

        #region .ctor
        internal BitsJob(BitsManager manager, IBackgroundCopyJob job)
        {
            this.manager = manager;
            this.job = job;
            this.job2 = this.job as IBackgroundCopyJob2;
            this.job3 = this.job as IBackgroundCopyJob3;
            this.job4 = this.job as IBackgroundCopyJob4;

            ///store existing notification handler and route message to this as well
            ///otherwise it may break system download jobs
            if (this.NotificationInterface != null)
            {
                this.notificationTarget = this.NotificationInterface;   //pointer to the existing one;
            }
            this.NotificationInterface = manager.NotificationHandler;   //notification interface will be disabled when NotifyCmd is set
        }
        #endregion

        #region public properties

        #region IBackgroundCopyJob
        /// <summary>
        /// Display Name, max 256 chars
        /// </summary>
        public string DisplayName
        {
            get
            {
                try
                {
                    string displayName;
                    this.job.GetDisplayName(out displayName);
                    return displayName;
                }
                catch (COMException exception)
                {                    
                    manager.PublishException(this, exception);
                    return string.Empty;
                }
            }
            set
            {
                try
                {
                    this.job.SetDisplayName(value);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
            }
        }

        /// <summary>
        /// Description, max 1024 chars
        /// </summary>
        public string Description
        {
            get
            {
                try
                {
                    string description;
                    this.job.GetDescription(out description);
                    return description;
                }
                catch (COMException exception)
                {                    
                    manager.PublishException(this, exception);
                    return string.Empty;
                }
            }
            set
            {
                try
                {
                    this.job.SetDescription(value);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
            }
        }

        /// <summary>
        /// SID of the job owner
        /// </summary>
        public string Owner
        {
            get
            {
                try
                {
                    string owner;
                    this.job.GetOwner(out owner);
                    return owner;
                }
                catch (COMException exception)
                {                    
                    manager.PublishException(this, exception);
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// resolved owner name from job owner SID
        /// </summary>
        public string OwnerName
        {
            get 
            {
                try
                {
                    return Utils.GetName(Owner);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Job priority
        /// can not be set for jobs already in state Canceled or Acknowledged
        /// </summary>
        public JobPriority Priority
        {
            get
            {
                BG_JOB_PRIORITY priority = BG_JOB_PRIORITY.BG_JOB_PRIORITY_NORMAL;
                try
                {
                    this.job.GetPriority(out priority);
                }
                catch (COMException exception)
                {                    
                    manager.PublishException(this, exception);
                }
                return (JobPriority)priority;
            }
            set
            {
                try
                {
                    this.job.SetPriority((BG_JOB_PRIORITY)value);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
            }

        }

        public JobProgress Progress
        {
            get
            {
                try
                {
                    BG_JOB_PROGRESS jobProgress;
                    this.job.GetProgress(out jobProgress);
                    this.progress = new JobProgress(jobProgress);
                }
                catch (COMException exception)
                {                    
                    manager.PublishException(this, exception);
                }
                return this.progress;
            }
        }

        public BitsFiles EnumFiles()
        {
            try
            {
                IEnumBackgroundCopyFiles fileList = null;
                this.job.EnumFiles(out fileList);
                this.files = new BitsFiles(this, fileList);
            }
            catch (COMException exception)
            {                
                manager.PublishException(this, exception);
            }
            return this.files;
        }

        public BitsFiles Files
        {
            get { return this.files; }
        }

        public ulong ErrorCount
        {
            get
            {
                ulong count = 0;
                try
                {
                    this.job.GetErrorCount(out count);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return count;
            }
        }

        public BitsError Error
        {
            get
            {
                try
                {
                    JobState state = this.State;
                    if (state == JobState.Error || state == JobState.TransientError)
                    {

                        if (null == this.error)
                        {
                            IBackgroundCopyError error;
                            this.job.GetError(out error);
                            if (null != error)
                            {
                                this.error = new BitsError(this, error);
                            }
                        }
                    }
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return this.error;
            }
        }

        public uint MinimumRetryDelay
        {
            get
            {
                uint seconds = 0;
                try
                {
                    this.job.GetMinimumRetryDelay(out seconds);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return seconds;
            }
            set
            {
                try
                {
                    this.job.SetMinimumRetryDelay(value);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
            }
        }

        public uint NoProgressTimeout
        {
            get
            {
                uint seconds = 0;
                try
                {
                    this.job.GetNoProgressTimeout(out seconds);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return seconds;
            }
            set
            {
                try
                {
                    this.job.SetNoProgressTimeout(value);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
            }

        }

        public Guid JobId
        {
            get
            {
                try
                {
                    if (this.guid == Guid.Empty)
                    {
                        this.job.GetId(out guid);
                    }
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return this.guid;
            }
        }

        public JobState State
        {
            get
            {
                BG_JOB_STATE state = BG_JOB_STATE.BG_JOB_STATE_UNKNOWN;
                try
                {
                    this.job.GetState(out state);
                }
                catch (COMException exception)
                {                    
                    manager.PublishException(this, exception);
                }
                return (JobState)state;
            }
        }

        public JobTimes JobTimes
        {
            get
            {
                try
                {
                    BG_JOB_TIMES times;
                    this.job.GetTimes(out times);
                    this.jobTimes = new JobTimes(times);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return this.jobTimes;
            }
        }

        public JobType JobType
        {
            get
            {
                BG_JOB_TYPE jobType = BG_JOB_TYPE.BG_JOB_TYPE_UNKNOWN;
                try
                {
                    this.job.GetType(out jobType);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return (JobType)jobType;
            }
        }

        public ProxySettings ProxySettings
        {
            get 
            {
                if (null == proxySettings)
                {
                    this.proxySettings = new ProxySettings(this.job);
                }
                return this.proxySettings;
            }
        }

        public void Suspend()
        {
            try
            {
                this.job.Suspend();
            }
            catch (COMException exception)
            {                
                manager.PublishException(this, exception);
            }
        }

        public void Resume()
        {
            try
            {
                this.job.Resume();
            }
            catch (COMException exception)
            {
                manager.PublishException(this, exception);
            }
        }

        public void Cancel()
        {
            try
            {
                this.job.Cancel();
            }
            catch (COMException exception)
            {
                manager.PublishException(this, exception);
            }
        }

        public void Complete()
        {
            try
            {
                this.job.Complete();
            }
            catch (COMException exception)
            {
                manager.PublishException(this, exception);
            }
        }

        public void TakeOwnership()
        {
            try
            {
                this.job.TakeOwnership();
            }
            catch (COMException exception) 
            {
                manager.PublishException(this, exception);
            }
        }

        public void AddFile(string remoteName, string localName)
        {
            try
            {
                this.job.AddFile(remoteName, localName);
            }
            catch (COMException exception)
            {
                manager.PublishException(this, exception);
            }
        }

        public void AddFile(BitsFileInfo fileInfo)
        {
            if (fileInfo == null)
                throw new ArgumentNullException("fileInfo");
            this.AddFile(fileInfo.RemoteName, fileInfo.LocalName);
        }

        internal void AddFiles(BG_FILE_INFO[] files)
        {
            try
            {
                uint count = Convert.ToUInt32(files.Length);
                this.job.AddFileSet(count, files);
            }
            catch (COMException exception)
            {
                manager.PublishException(this, exception);
            }
        }

        public void AddFiles(Collection<BitsFileInfo> files)
        {
            BG_FILE_INFO[] fileArray = new BG_FILE_INFO[files.Count];
            for (int i = 0; i < files.Count; i++)
            {
                fileArray[i] = files[i]._BG_FILE_INFO;
            }
            this.AddFiles(fileArray);
        }

        public NotificationFlags NotificationFlags
        {
            get
            {
                BG_JOB_NOTIFICATION_TYPE flags = 0;
                try
                {
                    job.GetNotifyFlags(out flags);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return (NotificationFlags)flags;
            }
            set
            {
                try
                {
                    job.SetNotifyFlags((BG_JOB_NOTIFICATION_TYPE)value);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
            }
        }

        internal IBackgroundCopyCallback NotificationInterface
        {
            get
            {
                object notificationInterface = null;
                try
                {
                    job.GetNotifyInterface(out notificationInterface);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return notificationInterface as IBackgroundCopyCallback;
            }
            set
            {
                try
                {
                    job.SetNotifyInterface(value);
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
            }
        }

        #endregion

        #endregion

        #region notification
        internal void JobTransferred(object sender, NotificationEventArgs e)
        {
            if (this.onJobTransfered != null)
                this.onJobTransfered(sender, new JobNotificationEventArgs());
        }

        internal void JobModified(object sender, NotificationEventArgs e)
        {
            if (this.onJobModified != null)
                this.onJobModified(sender, new JobNotificationEventArgs());
        }

        internal void JobError(object sender, ErrorNotificationEventArgs e)
        {
            if (null != this.onJobErrored)
                this.onJobErrored(sender, new JobErrorNotificationEventArgs(e.Error));
        }
        #endregion

        #region public events
        public event EventHandler<JobNotificationEventArgs> OnJobModified
        {
            add { this.onJobModified += value; }
            remove { this.onJobModified -= value; }
        }

        public event EventHandler<JobNotificationEventArgs> OnJobTransferred
        {
            add { this.onJobTransfered += value; }
            remove { this.onJobTransfered -= value; }
        }

        public event EventHandler<JobErrorNotificationEventArgs> OnJobError
        {
            add { this.onJobErrored += value; }
            remove { this.onJobErrored -= value; }
        }
        #endregion

        #region internal
        internal IBackgroundCopyJob Job
        {
            get { return this.job; }
        }

        internal void PublishException(COMException exception)
        {
            this.manager.PublishException(this, exception);
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
                    if (this.notificationTarget != null)
                        this.NotificationInterface = this.notificationTarget;
                    if (this.files != null)
                        this.files.Dispose();
                    this.job = null;
                }
            }
            disposed = true;
        }
        #endregion
    }
}
