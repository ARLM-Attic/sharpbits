using System;
using System.Globalization;
using System.Windows.Forms;
using SharpBits.Base;
using SharpBits.WinClient.Controls;
using SharpBits.WinClient.Properties;

namespace SharpBits.WinClient
{
    public partial class JobDetailsControl : JobControl
    {
        // Fields
        private Button btnCancel;
        private Button btnComplete;
        private Button btnResume;
        private Button btnSuspend;
        private Button btnTakeOwnership;
        private ComboBox cbPriority;
        private CheckBox chkAutoComplete;
        private GroupBox gbJobDetails;
        private Label label1;
        private Label label10;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private JobState lastState;
        private Label lblJobTimeStamps;
        private TextBox tbJobBytesTotal;
        private TextBox tbJobBytesTransferred;
        private TextBox tbJobDescription;
        private TextBox tbJobDirection;
        private TextBox tbJobFileCount;
        private TextBox tbJobFilesCompleted;
        private TextBox tbJobName;
        private TextBox tbJobOwner;
        private TextBox tbJobStartTime;
        private TextBox tbJobState;
        private TimeStampMode timestampMode;

        // Methods
        public JobDetailsControl()
        {
            this.InitializeComponent();
            this.timestampMode = TimeStampMode.Creation;
            this.cbPriority.BeginUpdate();
            this.cbPriority.Items.Add("Foreground");
            this.cbPriority.Items.Add("High");
            this.cbPriority.Items.Add("Normal");
            this.cbPriority.Items.Add("Low");
            this.cbPriority.EndUpdate();
        }

        private void btnTakeOwnership_Click(object sender, EventArgs e)
        {
            try
            {
                base.wrapper.BitsJob.TakeOwnership();
                this.tbJobOwner.Text = base.wrapper.BitsJob.OwnerName;
            }
            catch
            {
                MessageBox.Show("There was an error taking ownership of this job.\r\nEnsure you have sufficient rights to take ownership on this job.");
            }
        }

        private void cbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.wrapper.BitsJob.Priority = (JobPriority)this.cbPriority.SelectedIndex;
        }

        private void chkAutoComplete_CheckedChanged(object sender, EventArgs e)
        {
            base.wrapper.AutoComplete = this.chkAutoComplete.Checked;
            foreach (JobWrapper wrapper in Settings.Default.JobCache)
            {
                if (base.wrapper.JobId == wrapper.JobId)
                {
                    wrapper.AutoComplete = base.wrapper.AutoComplete;
                    Settings.Default.Save();
                    break;
                }
            }
        }

        private void ControlsFromJobState()
        {
            switch (base.wrapper.BitsJob.State)
            {
                case JobState.Queued:
                    this.btnResume.Enabled = true;
                    this.btnSuspend.Enabled = true;
                    this.btnCancel.Enabled = true;
                    this.btnComplete.Enabled = true;
                    return;

                case JobState.Connecting:
                    this.btnResume.Enabled = false;
                    this.btnSuspend.Enabled = true;
                    this.btnCancel.Enabled = true;
                    this.btnComplete.Enabled = true;
                    return;

                case JobState.Transferring:
                    this.btnResume.Enabled = false;
                    this.btnSuspend.Enabled = true;
                    this.btnCancel.Enabled = true;
                    this.btnComplete.Enabled = true;
                    return;

                case JobState.Suspended:
                    this.btnResume.Enabled = true;
                    this.btnSuspend.Enabled = false;
                    this.btnCancel.Enabled = true;
                    this.btnComplete.Enabled = true;
                    return;

                case JobState.Error:
                    this.btnResume.Enabled = true;
                    this.btnSuspend.Enabled = true;
                    this.btnCancel.Enabled = true;
                    this.btnComplete.Enabled = true;
                    return;

                case JobState.TransientError:
                    this.btnResume.Enabled = true;
                    this.btnSuspend.Enabled = false;
                    this.btnCancel.Enabled = true;
                    this.btnComplete.Enabled = true;
                    return;

                case JobState.Transferred:
                    this.btnResume.Enabled = false;
                    this.btnSuspend.Enabled = false;
                    this.btnCancel.Enabled = true;
                    this.btnComplete.Enabled = true;
                    return;

                case JobState.Acknowledged:
                    this.btnCancel.Enabled = false;
                    this.btnComplete.Enabled = false;
                    this.btnSuspend.Enabled = false;
                    this.btnResume.Enabled = false;
                    return;

                case JobState.Canceled:
                    this.btnCancel.Enabled = false;
                    this.btnComplete.Enabled = false;
                    this.btnSuspend.Enabled = false;
                    this.btnResume.Enabled = false;
                    return;
            }
        }

        public override void DeInitControl()
        {
            base.wrapper.BitsJob.OnJobError -= new EventHandler<JobErrorNotificationEventArgs>(this.OnJobErrorEvent);
            base.wrapper.BitsJob.OnJobModified -= new EventHandler<JobNotificationEventArgs>(this.OnJobModifiedEvent);
            base.wrapper.BitsJob.OnJobTransferred -= new EventHandler<JobNotificationEventArgs>(this.OnJobTransferredEvent);
            base.DeInitControl();
        }

        private void DisplayTimestamp()
        {
            this.DisplayTimestamp(this.tbJobStartTime, this.lblJobTimeStamps, this.timestampMode);
        }

        private void DisplayTimestamp(Control control, Control label, TimeStampMode timestamp)
        {
            switch (timestamp)
            {
                case TimeStampMode.Creation:
                    control.Text = Timestamp2String(base.wrapper.BitsJob.JobTimes.CreationTime);
                    label.Text = "Created";
                    return;

                case TimeStampMode.Modification:
                    control.Text = Timestamp2String(base.wrapper.BitsJob.JobTimes.ModificationTime);
                    label.Text = "Last Modified";
                    return;

                case TimeStampMode.Completion:
                    control.Text = Timestamp2String(base.wrapper.BitsJob.JobTimes.TransferCompletionTime);
                    label.Text = "Completed";
                    return;
            }
        }

        public override void InitControl(JobWrapper wrapper)
        {
            base.InitControl(wrapper);
            wrapper.BitsJob.OnJobError += new EventHandler<JobErrorNotificationEventArgs>(this.OnJobErrorEvent);
            wrapper.BitsJob.OnJobModified += new EventHandler<JobNotificationEventArgs>(this.OnJobModifiedEvent);
            wrapper.BitsJob.OnJobTransferred += new EventHandler<JobNotificationEventArgs>(this.OnJobTransferredEvent);
        }

        private void lblJobTimeStamps_MouseClick(object sender, MouseEventArgs e)
        {
            this.UpdateTimestamp();
        }

        private void OnJobErrorEvent(object sender, JobErrorNotificationEventArgs e)
        {
            if (base.InvokeRequired)
            {
                EventHandler<JobErrorNotificationEventArgs> method = new EventHandler<JobErrorNotificationEventArgs>(this.OnJobErrorEvent);
                base.Invoke(method, new object[] { sender, e });
            }
            else
            {
                this.UpdateControl();
            }
        }

        private void OnJobModifiedEvent(object sender, JobNotificationEventArgs e)
        {
            if (base.InvokeRequired)
            {
                EventHandler<JobNotificationEventArgs> method = new EventHandler<JobNotificationEventArgs>(this.OnJobModifiedEvent);
                base.Invoke(method, new object[] { sender, e });
            }
            else
            {
                this.UpdateControl();
            }
        }

        private void OnJobTransferredEvent(object sender, JobNotificationEventArgs e)
        {
            if (base.InvokeRequired)
            {
                EventHandler<JobNotificationEventArgs> method = new EventHandler<JobNotificationEventArgs>(this.OnJobTransferredEvent);
                base.Invoke(method, new object[] { sender, e });
            }
            else
            {
                this.UpdateControl();
            }
        }

        private void tbJobDescription_Click(object sender, EventArgs e)
        {
            if (this.tbJobDescription.ReadOnly)
            {
                this.tbJobDescription.ReadOnly = false;
            }
        }

        private void tbJobDescription_Leave(object sender, EventArgs e)
        {
            this.tbJobDescription.ReadOnly = true;
            base.wrapper.BitsJob.Description = this.tbJobDescription.Text;
        }

        private void tbJobName_Click(object sender, EventArgs e)
        {
            if (this.tbJobName.ReadOnly)
            {
                this.tbJobName.ReadOnly = false;
            }
        }

        private void tbJobName_Leave(object sender, EventArgs e)
        {
            this.tbJobName.ReadOnly = true;
            base.wrapper.BitsJob.DisplayName = this.tbJobName.Text;
        }

        private static string Timestamp2String(DateTime timeStamp)
        {
            if (timeStamp == DateTime.MinValue)
            {
                return "-''-";
            }
            return timeStamp.ToString();
        }

        public override void UpdateControl()
        {
            BitsJob bitsJob = base.wrapper.BitsJob;
            this.chkAutoComplete.CheckedChanged -= new EventHandler(this.chkAutoComplete_CheckedChanged);
            this.chkAutoComplete.Checked = base.wrapper.AutoComplete;
            this.chkAutoComplete.CheckedChanged += new EventHandler(this.chkAutoComplete_CheckedChanged);
            this.tbJobName.Text = bitsJob.DisplayName;
            this.tbJobDescription.Text = bitsJob.Description;
            this.tbJobOwner.Text = bitsJob.OwnerName;
            this.tbJobState.Text = bitsJob.State.ToString();
            this.cbPriority.SelectedIndexChanged -= new EventHandler(this.cbPriority_SelectedIndexChanged);
            this.cbPriority.SelectedIndex = (int)bitsJob.Priority;
            this.cbPriority.SelectedIndexChanged += new EventHandler(this.cbPriority_SelectedIndexChanged);
            this.tbJobDirection.Text = bitsJob.JobType.ToString();
            this.DisplayTimestamp();
            this.tbJobFileCount.Text = bitsJob.Progress.FilesTotal.ToString(CultureInfo.CurrentCulture);
            this.tbJobFilesCompleted.Text = bitsJob.Progress.FilesTransferred.ToString();
            this.tbJobBytesTotal.Text = Utils.Bytes2Size(bitsJob.Progress.BytesTotal);
            this.tbJobBytesTransferred.Text = Utils.Bytes2Size(bitsJob.Progress.BytesTransferred);
            if (this.lastState != bitsJob.State)
            {
                this.ControlsFromJobState();
                this.lastState = bitsJob.State;
            }
        }

        private void UpdateTimestamp()
        {
            this.timestampMode = (TimeStampMode)(((int)(this.timestampMode + 1)) % (int)(TimeStampMode.Completion | TimeStampMode.Modification));
            this.DisplayTimestamp(this.tbJobStartTime, this.lblJobTimeStamps, this.timestampMode);
        }

        // Nested Types
        private enum TimeStampMode
        {
            Creation,
            Modification,
            Completion
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if ((base.wrapper.BitsJob.State != JobState.Acknowledged) && (base.wrapper.BitsJob.State != JobState.Canceled))
            {
                base.wrapper.BitsJob.Resume();
            }
            this.ControlsFromJobState();
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            if ((base.wrapper.BitsJob.State != JobState.Acknowledged) && (base.wrapper.BitsJob.State != JobState.Canceled))
            {
                base.wrapper.BitsJob.Suspend();
            }
            this.ControlsFromJobState();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if ((base.wrapper.BitsJob.State != JobState.Acknowledged) && (base.wrapper.BitsJob.State != JobState.Canceled))
            {
                base.wrapper.BitsJob.Cancel();
            }
            this.ControlsFromJobState();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if ((((base.wrapper.BitsJob.JobType == JobType.Download) && (base.wrapper.BitsJob.State != JobState.Acknowledged)) && (base.wrapper.BitsJob.State != JobState.Canceled)) || ((base.wrapper.BitsJob.JobType == JobType.Upload) && (base.wrapper.BitsJob.State == JobState.Transferred)))
            {
                base.wrapper.BitsJob.Complete();
            }
            this.ControlsFromJobState();
        }
    }

}
