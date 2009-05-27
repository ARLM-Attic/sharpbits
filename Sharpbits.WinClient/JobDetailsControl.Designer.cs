using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Crad.Windows.Forms.Actions;
using System.Drawing;
using SharpBits.WinClient.Properties;

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
            components = new System.ComponentModel.Container();
            this.gbJobDetails = new GroupBox();
            this.tbJobFilesCompleted = new TextBox();
            this.label10 = new Label();
            this.tbJobBytesTransferred = new TextBox();
            this.label9 = new Label();
            this.tbJobBytesTotal = new TextBox();
            this.label6 = new Label();
            this.tbJobDirection = new TextBox();
            this.label3 = new Label();
            this.tbJobState = new TextBox();
            this.label8 = new Label();
            this.label7 = new Label();
            this.cbPriority = new ComboBox();
            this.tbJobStartTime = new TextBox();
            this.lblJobTimeStamps = new Label();
            this.tbJobOwner = new TextBox();
            this.label5 = new Label();
            this.btnTakeOwnership = new Button();
            this.tbJobFileCount = new TextBox();
            this.label4 = new Label();
            this.tbJobDescription = new TextBox();
            this.label2 = new Label();
            this.tbJobName = new TextBox();
            this.label1 = new Label();
            this.btnComplete = new Button();
            this.btnCancel = new Button();
            this.btnSuspend = new Button();
            this.btnResume = new Button();
            this.actlJobDetails = new ActionList();
            this.actComplete = new Crad.Windows.Forms.Actions.Action();
            this.actCancel = new Crad.Windows.Forms.Actions.Action();
            this.actSuspend = new Crad.Windows.Forms.Actions.Action();
            this.actResume = new Crad.Windows.Forms.Actions.Action();
            this.chkAutoComplete = new CheckBox();
            this.gbJobDetails.SuspendLayout();
            this.actlJobDetails.BeginInit();
            base.SuspendLayout();
            this.gbJobDetails.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Top;
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
            this.gbJobDetails.Location = new Point(3, 3);
            this.gbJobDetails.Name = "gbJobDetails";
            this.gbJobDetails.Size = new Size(0x220, 0xf8);
            this.gbJobDetails.TabIndex = 2;
            this.gbJobDetails.TabStop = false;
            this.gbJobDetails.Text = "Job Details";
            this.tbJobFilesCompleted.Location = new Point(0x18c, 0xbd);
            this.tbJobFilesCompleted.Name = "tbJobFilesCompleted";
            this.tbJobFilesCompleted.ReadOnly = true;
            this.tbJobFilesCompleted.Size = new Size(0x72, 20);
            this.tbJobFilesCompleted.TabIndex = 0x17;
            this.tbJobFilesCompleted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new Point(0x135, 0xc0);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x51, 13);
            this.label10.TabIndex = 0x16;
            this.label10.Text = "Files Completed";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tbJobBytesTransferred.Location = new Point(0x18c, 0xd7);
            this.tbJobBytesTransferred.Name = "tbJobBytesTransferred";
            this.tbJobBytesTransferred.ReadOnly = true;
            this.tbJobBytesTransferred.Size = new Size(0x72, 20);
            this.tbJobBytesTransferred.TabIndex = 0x15;
            this.tbJobBytesTransferred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new Point(300, 0xda);
            this.label9.Name = "label9";
            this.label9.Size = new Size(90, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Bytes Transferred";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tbJobBytesTotal.Location = new Point(0x4d, 0xd7);
            this.tbJobBytesTotal.Name = "tbJobBytesTotal";
            this.tbJobBytesTotal.ReadOnly = true;
            this.tbJobBytesTotal.Size = new Size(0x72, 20);
            this.tbJobBytesTotal.TabIndex = 0x13;
            this.tbJobBytesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(11, 0xda);
            this.label6.Name = "label6";
            this.label6.Size = new Size(60, 13);
            this.label6.TabIndex = 0x12;
            this.label6.Text = "Bytes Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tbJobDirection.Location = new Point(0x18c, 0xa3);
            this.tbJobDirection.Name = "tbJobDirection";
            this.tbJobDirection.ReadOnly = true;
            this.tbJobDirection.Size = new Size(0x72, 20);
            this.tbJobDirection.TabIndex = 0x11;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(0x155, 0xa6);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x31, 13);
            this.label3.TabIndex = 0x10;
            this.label3.Text = "Direction";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tbJobState.Location = new Point(0x4d, 0xa2);
            this.tbJobState.Name = "tbJobState";
            this.tbJobState.ReadOnly = true;
            this.tbJobState.Size = new Size(0x72, 20);
            this.tbJobState.TabIndex = 15;
            this.label8.AutoSize = true;
            this.label8.Location = new Point(0x27, 0xa5);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x20, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "State";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.AutoSize = true;
            this.label7.Location = new Point(0x160, 0x8b);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x26, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Priority";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new Point(0x18c, 0x88);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new Size(0x72, 0x15);
            this.cbPriority.TabIndex = 11;
            this.cbPriority.SelectedIndexChanged += new EventHandler(this.cbPriority_SelectedIndexChanged);
            this.tbJobStartTime.Location = new Point(0x4d, 0x88);
            this.tbJobStartTime.Name = "tbJobStartTime";
            this.tbJobStartTime.ReadOnly = true;
            this.tbJobStartTime.Size = new Size(0xc6, 20);
            this.tbJobStartTime.TabIndex = 10;
            this.tbJobStartTime.MouseClick += new MouseEventHandler(this.lblJobTimeStamps_MouseClick);
            this.lblJobTimeStamps.AutoSize = true;
            this.lblJobTimeStamps.Location = new Point(0x10, 0x8b);
            this.lblJobTimeStamps.Name = "lblJobTimeStamps";
            this.lblJobTimeStamps.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblJobTimeStamps.Size = new Size(0x37, 13);
            this.lblJobTimeStamps.TabIndex = 9;
            this.lblJobTimeStamps.Text = "Start Time";
            this.lblJobTimeStamps.MouseClick += new MouseEventHandler(this.lblJobTimeStamps_MouseClick);
            this.tbJobOwner.Location = new Point(0x4d, 110);
            this.tbJobOwner.Name = "tbJobOwner";
            this.tbJobOwner.ReadOnly = true;
            this.tbJobOwner.Size = new Size(0xc6, 20);
            this.tbJobOwner.TabIndex = 8;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(0x21, 0x71);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new Size(0x26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Owner";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnTakeOwnership.Location = new Point(0x119, 0x6c);
            this.btnTakeOwnership.Name = "btnTakeOwnership";
            this.btnTakeOwnership.Size = new Size(0x72, 0x17);
            this.btnTakeOwnership.TabIndex = 6;
            this.btnTakeOwnership.Text = "Take Ownership";
            this.btnTakeOwnership.UseVisualStyleBackColor = true;
            this.btnTakeOwnership.Click += new EventHandler(this.btnTakeOwnership_Click);
            this.tbJobFileCount.Location = new Point(0x4d, 0xbc);
            this.tbJobFileCount.Name = "tbJobFileCount";
            this.tbJobFileCount.ReadOnly = true;
            this.tbJobFileCount.Size = new Size(0x72, 20);
            this.tbJobFileCount.TabIndex = 5;
            this.tbJobFileCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(0x2b, 0xbf);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x1c, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Files";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tbJobDescription.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Top;
            this.tbJobDescription.Location = new Point(0x4d, 0x27);
            this.tbJobDescription.Multiline = true;
            this.tbJobDescription.Name = "tbJobDescription";
            this.tbJobDescription.ReadOnly = true;
            this.tbJobDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJobDescription.Size = new Size(0x1c9, 0x41);
            this.tbJobDescription.TabIndex = 3;
            this.tbJobDescription.Click += new EventHandler(this.tbJobDescription_Click);
            this.tbJobDescription.Leave += new EventHandler(this.tbJobDescription_Leave);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(11, 0x2a);
            this.label2.Name = "label2";
            this.label2.Size = new Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.tbJobName.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Top;
            this.tbJobName.Location = new Point(0x4d, 13);
            this.tbJobName.Name = "tbJobName";
            this.tbJobName.ReadOnly = true;
            this.tbJobName.Size = new Size(0x1c9, 20);
            this.tbJobName.TabIndex = 1;
            this.tbJobName.Click += new EventHandler(this.tbJobName_Click);
            this.tbJobName.Leave += new EventHandler(this.tbJobName_Leave);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(0x10, 0x10);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.actlJobDetails.SetAction(this.btnComplete, this.actComplete);
            this.btnComplete.Image = Resources.Complete;
            this.btnComplete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplete.Location = new Point(0x179, 0x107);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new Size(0x4b, 0x17);
            this.btnComplete.TabIndex = 11;
            this.btnComplete.Text = "Complete";
            this.btnComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComplete.UseVisualStyleBackColor = true;
            this.actlJobDetails.SetAction(this.btnCancel, this.actCancel);
            this.btnCancel.Image = Resources.Delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new Point(0x128, 0x107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(0x4b, 0x17);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.actlJobDetails.SetAction(this.btnSuspend, this.actSuspend);
            this.btnSuspend.Image = Resources.Pause;
            this.btnSuspend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuspend.Location = new Point(0xd7, 0x107);
            this.btnSuspend.Name = "btnSuspend";
            this.btnSuspend.Size = new Size(0x4b, 0x17);
            this.btnSuspend.TabIndex = 9;
            this.btnSuspend.Text = "Suspend";
            this.btnSuspend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuspend.UseVisualStyleBackColor = true;
            this.actlJobDetails.SetAction(this.btnResume, this.actResume);
            this.btnResume.Image = Resources.Play;
            this.btnResume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResume.Location = new Point(0x86, 0x107);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new Size(0x4b, 0x17);
            this.btnResume.TabIndex = 8;
            this.btnResume.Text = "Resume";
            this.btnResume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResume.UseVisualStyleBackColor = true;
            this.actlJobDetails.Actions.Add(this.actResume);
            this.actlJobDetails.Actions.Add(this.actSuspend);
            this.actlJobDetails.Actions.Add(this.actCancel);
            this.actlJobDetails.Actions.Add(this.actComplete);
            this.actlJobDetails.ContainerControl = this;
            this.actComplete.Image = Resources.Complete;
            this.actComplete.Text = "Complete";
            this.actComplete.Execute += new EventHandler(this.actComplete_Execute);
            this.actCancel.Image = Resources.Delete;
            this.actCancel.Text = "Cancel";
            this.actCancel.Execute += new EventHandler(this.actCancel_Execute);
            this.actSuspend.Image = Resources.Pause;
            this.actSuspend.Text = "Suspend";
            this.actSuspend.Execute += new EventHandler(this.actSuspend_Execute);
            this.actResume.Image = Resources.Play;
            this.actResume.Text = "Resume";
            this.actResume.Execute += new EventHandler(this.actResume_Execute);
            this.chkAutoComplete.AutoSize = true;
            this.chkAutoComplete.Checked = true;
            this.chkAutoComplete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoComplete.Location = new Point(0x21, 0x10b);
            this.chkAutoComplete.Name = "chkAutoComplete";
            this.chkAutoComplete.Size = new Size(0x5f, 0x11);
            this.chkAutoComplete.TabIndex = 12;
            this.chkAutoComplete.Text = "Auto Complete";
            this.chkAutoComplete.UseVisualStyleBackColor = true;
            this.chkAutoComplete.CheckedChanged += new EventHandler(this.chkAutoComplete_CheckedChanged);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.Controls.Add(this.chkAutoComplete);
            base.Controls.Add(this.btnComplete);
            base.Controls.Add(this.btnCancel);
            base.Controls.Add(this.btnSuspend);
            base.Controls.Add(this.btnResume);
            base.Controls.Add(this.gbJobDetails);
            base.Name = "JobDetailsControl";
            base.Size = new Size(550, 300);
            this.gbJobDetails.ResumeLayout(false);
            this.gbJobDetails.PerformLayout();
            this.actlJobDetails.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

    }
}
