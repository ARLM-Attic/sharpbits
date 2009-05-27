using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpBits.WinClient.Controls;
using SharpBits.Base;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace SharpBits.WinClient
{
    public partial class JobMessageControl : JobControl
    {
        // Fields
        private GroupBox gbJobMessages;
        private TextBox txtJobError;

        // Methods
        public JobMessageControl()
        {
            this.InitializeComponent();
        }

        private void BitsJob_OnJobErrorEvent(object sender, JobErrorNotificationEventArgs e)
        {
            if (base.InvokeRequired)
            {
                EventHandler<JobErrorNotificationEventArgs> method = new EventHandler<JobErrorNotificationEventArgs>(this.BitsJob_OnJobErrorEvent);
                base.Invoke(method, new object[] { sender, e });
            }
            else
            {
                string str = string.Concat(new object[] { "Error: ", e.Error.Description, Environment.NewLine, "Context: ", e.Error.ContextDescription, Environment.NewLine, "ErrorCode: ", e.Error.ErrorCode, Environment.NewLine, "File: ", e.Error.File, Environment.NewLine, "Protocol:", e.Error.Protocol, Environment.NewLine });
                this.txtJobError.Text = string.Format("{0} : {1} {2}", DateTime.Now, str, this.txtJobError.Text);
            }
        }

        private void BitsJob_OnJobTransferredEvent(object sender, JobNotificationEventArgs e)
        {
            if (base.InvokeRequired)
            {
                EventHandler<JobNotificationEventArgs> method = new EventHandler<JobNotificationEventArgs>(this.BitsJob_OnJobTransferredEvent);
                base.Invoke(method, new object[] { sender, e });
            }
            else
            {
                string str = "Job transferred successfully" + Environment.NewLine;
                this.txtJobError.Text = string.Format("{0} : {1} {2}", DateTime.Now, str, this.txtJobError.Text);
            }
        }

        public override void DeInitControl()
        {
            base.wrapper.BitsJob.OnJobError += new EventHandler<JobErrorNotificationEventArgs>(this.BitsJob_OnJobErrorEvent);
            base.wrapper.BitsJob.OnJobTransferred += new EventHandler<JobNotificationEventArgs>(this.BitsJob_OnJobTransferredEvent);
            base.wrapper.Manager.OnInterfaceError += new EventHandler<BitsInterfaceNotificationEventArgs>(this.Manager_OnInterfaceError);
            base.DeInitControl();
        }

        public override void InitControl(JobWrapper wrapper)
        {
            base.InitControl(wrapper);
            wrapper.BitsJob.OnJobError += new EventHandler<JobErrorNotificationEventArgs>(this.BitsJob_OnJobErrorEvent);
            wrapper.BitsJob.OnJobTransferred += new EventHandler<JobNotificationEventArgs>(this.BitsJob_OnJobTransferredEvent);
            wrapper.Manager.OnInterfaceError += new EventHandler<BitsInterfaceNotificationEventArgs>(this.Manager_OnInterfaceError);
        }

        private void Manager_OnInterfaceError(object sender, BitsInterfaceNotificationEventArgs e)
        {
            if (e.Job.JobId == base.wrapper.BitsJob.JobId)
            {
                if (base.InvokeRequired)
                {
                    EventHandler<BitsInterfaceNotificationEventArgs> method = new EventHandler<BitsInterfaceNotificationEventArgs>(this.Manager_OnInterfaceError);
                    base.Invoke(method, new object[] { sender, e });
                }
                else
                {
                    string str = e.Message + Environment.NewLine + e.Description + Environment.NewLine;
                    this.txtJobError.Text = string.Format("{0} : {1} {2}", DateTime.Now, str, this.txtJobError.Text);
                }
            }
        }

        private void tbJobError_DoubleClick(object sender, EventArgs e)
        {
            this.txtJobError.Clear();
        }

        private void tbJobError_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
