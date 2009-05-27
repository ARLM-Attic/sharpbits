using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpBits.WinClient.Controls;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;


namespace SharpBits.WinClient
{
    public partial class BitsJobDetails : JobControl
    {
        // Fields
        private FileListControl fileListControl;
        private JobDetailsControl jobDetailsControl;
        private JobMessageControl jobMessageControl;
        private TabPage tabDetails;
        private TabPage tabFiles;
        private TabPage tabMessages;
        private TabPage tabSecurity;
        private TabControl tcJobDetails;
        private UserAuthenticationControl userAuthenticationControl;

        // Methods
        public BitsJobDetails()
        {
            this.InitializeComponent();
        }

        public void AddFilesOnJob()
        {
            this.tcJobDetails.SelectedTab = this.tabFiles;
            this.fileListControl.AddFilesOnJob();
        }

        public override void DeInitControl()
        {
            this.jobDetailsControl.DeInitControl();
            this.fileListControl.DeInitControl();
            this.userAuthenticationControl.DeInitControl();
            this.jobMessageControl.DeInitControl();
            base.DeInitControl();
        }

        public override void InitControl(JobWrapper wrapper)
        {
            this.jobDetailsControl.InitControl(wrapper);
            this.fileListControl.InitControl(wrapper);
            this.userAuthenticationControl.InitControl(wrapper);
            this.jobMessageControl.InitControl(wrapper);
            this.tcJobDetails.SelectedTab = this.tabDetails;
            base.InitControl(wrapper);
        }

        private void tcJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateControl();
        }

        public override void UpdateControl()
        {
            if (base.initialized)
            {
                if (this.tcJobDetails.SelectedTab == this.tabDetails)
                {
                    this.jobDetailsControl.UpdateControl();
                }
                else if (this.tcJobDetails.SelectedTab == this.tabFiles)
                {
                    this.fileListControl.UpdateControl();
                }
                else if (this.tcJobDetails.SelectedTab == this.tabSecurity)
                {
                    this.userAuthenticationControl.UpdateControl();
                }
                else if (this.tcJobDetails.SelectedTab == this.tabMessages)
                {
                    this.jobMessageControl.UpdateControl();
                }
            }
        }
    }

}
