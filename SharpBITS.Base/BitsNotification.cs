using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpBits.Base
{
    #region delegates
    //replaced with Generic eventhandlers
    #endregion

    #region Notification Event Arguments
    public class JobNotificationEventArgs : System.EventArgs
    {
    }

    public class JobErrorNotificationEventArgs : JobNotificationEventArgs
    {

        private BitsError error;

        internal JobErrorNotificationEventArgs(BitsError error)
            : base()
        {
            this.error = error;
        }

        public BitsError Error
        {
            get { return this.error; }
        }
    }

    public class NotificationEventArgs : JobNotificationEventArgs
    {
        private BitsJob job;

        internal NotificationEventArgs(BitsJob job)
        {
            this.job = job;
        }

        public BitsJob Job
        {
            get { return job; }
        }
    }

    public class ErrorNotificationEventArgs : NotificationEventArgs
    {

        private BitsError error;

        internal ErrorNotificationEventArgs(BitsJob job, BitsError error)
            : base(job)
        {
            this.error = error;
        }

        public BitsError Error
        {
            get { return this.error; }
        }
    }

    public class BitsInterfaceNotificationEventArgs : NotificationEventArgs
    {
        private COMException exception;
        private string description;

        internal BitsInterfaceNotificationEventArgs(BitsJob job, COMException exception, string description)
            : base(job)
        {
            this.description = description;
            this.exception = exception;
        }

        public string Message
        {
            get { return this.exception.Message; }
        }

        public string Description
        {
            get { return this.description; }
        }

        public int HResult
        {
            get { return this.exception.ErrorCode; }
        }
    }

    #endregion

    internal class BitsNotification : IBackgroundCopyCallback
    {
        #region IBackgroundCopyCallback Members
        private EventHandler<NotificationEventArgs> onJobModified;
        private EventHandler<NotificationEventArgs> onJobTransfered;
        private EventHandler<ErrorNotificationEventArgs> onJobErrored;
        private BitsManager manager;

        internal BitsNotification(BitsManager manager)
        {
            this.manager = manager;
        }

        public void JobTransferred(IBackgroundCopyJob pJob)
        {
            BitsJob job;
            if (null != this.onJobTransfered)
            {
                Guid guid;
                pJob.GetId(out guid);
                if (manager.Jobs.ContainsKey(guid))
                {
                    job = manager.Jobs[guid];
                }
                else
                {
                    // Update Joblist to check whether the job still exists. If not, just return
                    manager.EnumJobs(manager.currentOwner);
                    if (manager.Jobs.ContainsKey(guid))
                    {
                        job = manager.Jobs[guid];
                    }
                    else
                        return;
                }
                this.onJobTransfered(this, new NotificationEventArgs(job));
                //forward event
                if (job.notificationTarget != null)
                    job.notificationTarget.JobTransferred(pJob);
            }
        }

        public void JobError(IBackgroundCopyJob pJob, IBackgroundCopyError pError)
        {
            BitsJob job;
            if (null != this.onJobErrored)
            {
                Guid guid;
                pJob.GetId(out guid);
                if (manager.Jobs.ContainsKey(guid))
                {
                    job = manager.Jobs[guid];
                }
                else
                {
                    // Update Joblist to check whether the job still exists. If not, just return
                    manager.EnumJobs(manager.currentOwner);
                    if (manager.Jobs.ContainsKey(guid))
                    {
                        job = manager.Jobs[guid];
                    }
                    else
                        return;
                }
                this.onJobErrored(this, new ErrorNotificationEventArgs(job, new BitsError(job, pError)));
                //forward event
                if (job.notificationTarget != null)
                    job.notificationTarget.JobError(pJob, pError);
            }
        }

        public void JobModification(IBackgroundCopyJob pJob, uint dwReserved)
        {
            BitsJob job;
            if (null != this.onJobModified)
            {
                Guid guid;
                pJob.GetId(out guid);
                if (manager.Jobs.ContainsKey(guid))
                {
                    job = manager.Jobs[guid];
                }
                else
                {
                    // Update Joblist to check whether the job still exists. If not, just return
                    manager.EnumJobs(manager.currentOwner);
                    if (manager.Jobs.ContainsKey(guid))
                    {
                        job = manager.Jobs[guid];
                    }
                    else
                        return;
                }
                this.onJobModified(this, new NotificationEventArgs(job));
                //forward event
                if (job.notificationTarget != null)
                    job.notificationTarget.JobModification(pJob, dwReserved);
            }
        }

        public event EventHandler<NotificationEventArgs> OnJobModifiedEvent
        {
            add { this.onJobModified += value; }
            remove { this.onJobModified -= value; }
        }

        public event EventHandler<NotificationEventArgs> OnJobTransferredEvent
        {
            add { this.onJobTransfered += value; }
            remove { this.onJobTransfered -= value; }
        }

        public event EventHandler<ErrorNotificationEventArgs> OnJobErrorEvent
        {
            add { this.onJobErrored += value; }
            remove { this.onJobErrored -= value; }
        }
        #endregion
    }
}