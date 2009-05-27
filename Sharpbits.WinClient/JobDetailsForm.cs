using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using SharpBits.Base;
using System.Drawing;

namespace SharpBits.WinClient
{
    public partial class JobDetailsForm : Form
    {
        // Fields
        private BitsJobDetails bitsJobDetails;
        private BitsJob job;
        private BitsManager manager;
        private JobWrapper wrapper;

        // Methods
        public JobDetailsForm(JobWrapper wrapper)
        {
            this.wrapper = wrapper;
            this.manager = wrapper.Manager;
            this.job = wrapper.BitsJob;
            this.InitializeComponent();
            this.bitsJobDetails.InitControl(wrapper);
            this.Text = this.job.DisplayName;
        }

        private void AddFiles()
        {
            string[] strArray;
            if (CopyPasteHandler.GetJobType(out strArray) == this.wrapper.BitsJob.JobType)
            {
                this.wrapper.FileList = strArray;
                this.bitsJobDetails.AddFilesOnJob();
            }
        }

        private void JobDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.bitsJobDetails.DeInitControl();
        }

        private void JobDetailsForm_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            Keys keyCode = e.KeyCode;
            if (keyCode != Keys.Escape)
            {
                if (keyCode != Keys.V)
                {
                    if (keyCode == Keys.F5)
                    {
                        this.bitsJobDetails.UpdateControl();
                        return;
                    }
                    e.Handled = false;
                    return;
                }
            }
            else
            {
                e.SuppressKeyPress = true;
                base.Close();
                return;
            }
            if (e.Control)
            {
                this.AddFiles();
            }
        }

        public DialogResult ShowDialog(bool addFiles)
        {
            if (addFiles)
            {
                this.bitsJobDetails.AddFilesOnJob();
            }
            return base.ShowDialog();
        }

        public DialogResult ShowDialog(IWin32Window owner, bool addFiles)
        {
            if (addFiles)
            {
                this.bitsJobDetails.AddFilesOnJob();
            }
            return base.ShowDialog(owner);
        }
    }

}    

