
namespace SharpBits.WinClient
{
    partial class JobDetailsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbJobDetails = new System.Windows.Forms.GroupBox();
            this.tbJobFilesCompleted = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbJobBytesTransferred = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbJobBytesTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbJobDirection = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbJobState = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.tbJobStartTime = new System.Windows.Forms.TextBox();
            this.lblJobTimeStamps = new System.Windows.Forms.Label();
            this.tbJobOwner = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTakeOwnership = new System.Windows.Forms.Button();
            this.tbJobFileCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbJobDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJobName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSuspend = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.chkAutoComplete = new System.Windows.Forms.CheckBox();
            this.gbJobDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbJobDetails
            // 
            this.gbJobDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbJobDetails.Controls.Add(this.tbJobFilesCompleted);
            this.gbJobDetails.Controls.Add(this.label10);
            this.gbJobDetails.Controls.Add(this.tbJobBytesTransferred);
            this.gbJobDetails.Controls.Add(this.label9);
            this.gbJobDetails.Controls.Add(this.tbJobBytesTotal);
            this.gbJobDetails.Controls.Add(this.label6);
            this.gbJobDetails.Controls.Add(this.tbJobDirection);
            this.gbJobDetails.Controls.Add(this.label3);
            this.gbJobDetails.Controls.Add(this.tbJobState);
            this.gbJobDetails.Controls.Add(this.label8);
            this.gbJobDetails.Controls.Add(this.label7);
            this.gbJobDetails.Controls.Add(this.cbPriority);
            this.gbJobDetails.Controls.Add(this.tbJobStartTime);
            this.gbJobDetails.Controls.Add(this.lblJobTimeStamps);
            this.gbJobDetails.Controls.Add(this.tbJobOwner);
            this.gbJobDetails.Controls.Add(this.label5);
            this.gbJobDetails.Controls.Add(this.btnTakeOwnership);
            this.gbJobDetails.Controls.Add(this.tbJobFileCount);
            this.gbJobDetails.Controls.Add(this.label4);
            this.gbJobDetails.Controls.Add(this.tbJobDescription);
            this.gbJobDetails.Controls.Add(this.label2);
            this.gbJobDetails.Controls.Add(this.tbJobName);
            this.gbJobDetails.Controls.Add(this.label1);
            this.gbJobDetails.Location = new System.Drawing.Point(3, 3);
            this.gbJobDetails.Name = "gbJobDetails";
            this.gbJobDetails.Size = new System.Drawing.Size(544, 248);
            this.gbJobDetails.TabIndex = 2;
            this.gbJobDetails.TabStop = false;
            this.gbJobDetails.Text = "Job Details";
            // 
            // tbJobFilesCompleted
            // 
            this.tbJobFilesCompleted.Location = new System.Drawing.Point(396, 189);
            this.tbJobFilesCompleted.Name = "tbJobFilesCompleted";
            this.tbJobFilesCompleted.ReadOnly = true;
            this.tbJobFilesCompleted.Size = new System.Drawing.Size(114, 20);
            this.tbJobFilesCompleted.TabIndex = 23;
            this.tbJobFilesCompleted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Files Completed";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbJobBytesTransferred
            // 
            this.tbJobBytesTransferred.Location = new System.Drawing.Point(396, 215);
            this.tbJobBytesTransferred.Name = "tbJobBytesTransferred";
            this.tbJobBytesTransferred.ReadOnly = true;
            this.tbJobBytesTransferred.Size = new System.Drawing.Size(114, 20);
            this.tbJobBytesTransferred.TabIndex = 21;
            this.tbJobBytesTransferred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Bytes Transferred";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbJobBytesTotal
            // 
            this.tbJobBytesTotal.Location = new System.Drawing.Point(77, 215);
            this.tbJobBytesTotal.Name = "tbJobBytesTotal";
            this.tbJobBytesTotal.ReadOnly = true;
            this.tbJobBytesTotal.Size = new System.Drawing.Size(114, 20);
            this.tbJobBytesTotal.TabIndex = 19;
            this.tbJobBytesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bytes Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbJobDirection
            // 
            this.tbJobDirection.Location = new System.Drawing.Point(396, 163);
            this.tbJobDirection.Name = "tbJobDirection";
            this.tbJobDirection.ReadOnly = true;
            this.tbJobDirection.Size = new System.Drawing.Size(114, 20);
            this.tbJobDirection.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Direction";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbJobState
            // 
            this.tbJobState.Location = new System.Drawing.Point(77, 162);
            this.tbJobState.Name = "tbJobState";
            this.tbJobState.ReadOnly = true;
            this.tbJobState.Size = new System.Drawing.Size(114, 20);
            this.tbJobState.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "State";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Priority";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbPriority
            // 
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(396, 136);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(114, 21);
            this.cbPriority.TabIndex = 11;
            this.cbPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // tbJobStartTime
            // 
            this.tbJobStartTime.Location = new System.Drawing.Point(77, 136);
            this.tbJobStartTime.Name = "tbJobStartTime";
            this.tbJobStartTime.ReadOnly = true;
            this.tbJobStartTime.Size = new System.Drawing.Size(198, 20);
            this.tbJobStartTime.TabIndex = 10;
            this.tbJobStartTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblJobTimeStamps_MouseClick);
            // 
            // lblJobTimeStamps
            // 
            this.lblJobTimeStamps.AutoSize = true;
            this.lblJobTimeStamps.Location = new System.Drawing.Point(16, 139);
            this.lblJobTimeStamps.Name = "lblJobTimeStamps";
            this.lblJobTimeStamps.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblJobTimeStamps.Size = new System.Drawing.Size(55, 13);
            this.lblJobTimeStamps.TabIndex = 9;
            this.lblJobTimeStamps.Text = "Start Time";
            this.lblJobTimeStamps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblJobTimeStamps_MouseClick);
            // 
            // tbJobOwner
            // 
            this.tbJobOwner.Location = new System.Drawing.Point(77, 110);
            this.tbJobOwner.Name = "tbJobOwner";
            this.tbJobOwner.ReadOnly = true;
            this.tbJobOwner.Size = new System.Drawing.Size(198, 20);
            this.tbJobOwner.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 113);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Owner";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnTakeOwnership
            // 
            this.btnTakeOwnership.Location = new System.Drawing.Point(281, 108);
            this.btnTakeOwnership.Name = "btnTakeOwnership";
            this.btnTakeOwnership.Size = new System.Drawing.Size(114, 23);
            this.btnTakeOwnership.TabIndex = 6;
            this.btnTakeOwnership.Text = "Take Ownership";
            this.btnTakeOwnership.UseVisualStyleBackColor = true;
            this.btnTakeOwnership.Click += new System.EventHandler(this.btnTakeOwnership_Click);
            // 
            // tbJobFileCount
            // 
            this.tbJobFileCount.Location = new System.Drawing.Point(77, 188);
            this.tbJobFileCount.Name = "tbJobFileCount";
            this.tbJobFileCount.ReadOnly = true;
            this.tbJobFileCount.Size = new System.Drawing.Size(114, 20);
            this.tbJobFileCount.TabIndex = 5;
            this.tbJobFileCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Files";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbJobDescription
            // 
            this.tbJobDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJobDescription.Location = new System.Drawing.Point(77, 39);
            this.tbJobDescription.Multiline = true;
            this.tbJobDescription.Name = "tbJobDescription";
            this.tbJobDescription.ReadOnly = true;
            this.tbJobDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJobDescription.Size = new System.Drawing.Size(457, 65);
            this.tbJobDescription.TabIndex = 3;
            this.tbJobDescription.Click += new System.EventHandler(this.tbJobDescription_Click);
            this.tbJobDescription.Leave += new System.EventHandler(this.tbJobDescription_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbJobName
            // 
            this.tbJobName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbJobName.Location = new System.Drawing.Point(77, 13);
            this.tbJobName.Name = "tbJobName";
            this.tbJobName.ReadOnly = true;
            this.tbJobName.Size = new System.Drawing.Size(457, 20);
            this.tbJobName.TabIndex = 1;
            this.tbJobName.Click += new System.EventHandler(this.tbJobName_Click);
            this.tbJobName.Leave += new System.EventHandler(this.tbJobName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnComplete
            // 
            this.btnComplete.Image = global::SharpBits.WinClient.Properties.Resources.Complete;
            this.btnComplete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplete.Location = new System.Drawing.Point(377, 263);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 23);
            this.btnComplete.TabIndex = 11;
            this.btnComplete.Text = "Complete";
            this.btnComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::SharpBits.WinClient.Properties.Resources.Delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(296, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSuspend
            // 
            this.btnSuspend.Image = global::SharpBits.WinClient.Properties.Resources.Pause;
            this.btnSuspend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuspend.Location = new System.Drawing.Point(215, 263);
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new System.Drawing.Size(75, 23);
            this.btnSuspend.TabIndex = 9;
            this.btnSuspend.Text = "Suspend";
            this.btnSuspend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuspend.UseVisualStyleBackColor = true;
            this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
            // 
            // btnResume
            // 
            this.btnResume.Image = global::SharpBits.WinClient.Properties.Resources.Play;
            this.btnResume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResume.Location = new System.Drawing.Point(134, 263);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 8;
            this.btnResume.Text = "Resume";
            this.btnResume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // chkAutoComplete
            // 
            this.chkAutoComplete.AutoSize = true;
            this.chkAutoComplete.Checked = true;
            this.chkAutoComplete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoComplete.Location = new System.Drawing.Point(33, 267);
            this.chkAutoComplete.Name = "chkAutoComplete";
            this.chkAutoComplete.Size = new System.Drawing.Size(95, 17);
            this.chkAutoComplete.TabIndex = 12;
            this.chkAutoComplete.Text = "Auto Complete";
            this.chkAutoComplete.UseVisualStyleBackColor = true;
            this.chkAutoComplete.CheckedChanged += new System.EventHandler(this.chkAutoComplete_CheckedChanged);
            // 
            // JobDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAutoComplete);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSuspend);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.gbJobDetails);
            this.Name = "JobDetailsControl";
            this.Size = new System.Drawing.Size(550, 300);
            this.gbJobDetails.ResumeLayout(false);
            this.gbJobDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}
