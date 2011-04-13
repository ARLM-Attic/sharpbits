using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SharpBits.WinClient
{
    partial class BitsJobDetails
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
            this.tabSecurity = new System.Windows.Forms.TabPage();
            this.userAuthenticationControl = new SharpBits.WinClient.UserAuthenticationControl();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.fileListControl = new SharpBits.WinClient.FileListControl();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.jobDetailsControl = new SharpBits.WinClient.JobDetailsControl();
            this.tcJobDetails = new System.Windows.Forms.TabControl();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.jobMessageControl = new SharpBits.WinClient.JobMessageControl();
            this.tabSecurity.SuspendLayout();
            this.tabFiles.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.tcJobDetails.SuspendLayout();
            this.tabMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.userAuthenticationControl);
            this.tabSecurity.Location = new System.Drawing.Point(4, 22);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecurity.Size = new System.Drawing.Size(547, 390);
            this.tabSecurity.TabIndex = 2;
            this.tabSecurity.Text = "Authentication";
            this.tabSecurity.UseVisualStyleBackColor = true;
            // 
            // userAuthenticationControl
            // 
            this.userAuthenticationControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAuthenticationControl.Location = new System.Drawing.Point(3, 3);
            this.userAuthenticationControl.MinimumSize = new System.Drawing.Size(578, 419);
            this.userAuthenticationControl.Name = "userAuthenticationControl";
            this.userAuthenticationControl.Size = new System.Drawing.Size(578, 419);
            this.userAuthenticationControl.TabIndex = 0;
            // 
            // tabFiles
            // 
            this.tabFiles.Controls.Add(this.fileListControl);
            this.tabFiles.Location = new System.Drawing.Point(4, 22);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiles.Size = new System.Drawing.Size(547, 390);
            this.tabFiles.TabIndex = 1;
            this.tabFiles.Text = "Files";
            this.tabFiles.UseVisualStyleBackColor = true;
            // 
            // fileListControl
            // 
            this.fileListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListControl.Location = new System.Drawing.Point(3, 3);
            this.fileListControl.Name = "fileListControl";
            this.fileListControl.Size = new System.Drawing.Size(541, 384);
            this.fileListControl.TabIndex = 0;
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.jobDetailsControl);
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(547, 390);
            this.tabDetails.TabIndex = 0;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            // 
            // jobDetailsControl
            // 
            this.jobDetailsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobDetailsControl.Location = new System.Drawing.Point(3, 3);
            this.jobDetailsControl.Name = "jobDetailsControl";
            this.jobDetailsControl.Size = new System.Drawing.Size(541, 384);
            this.jobDetailsControl.TabIndex = 0;
            // 
            // tcJobDetails
            // 
            this.tcJobDetails.Controls.Add(this.tabDetails);
            this.tcJobDetails.Controls.Add(this.tabFiles);
            this.tcJobDetails.Controls.Add(this.tabSecurity);
            this.tcJobDetails.Controls.Add(this.tabMessages);
            this.tcJobDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcJobDetails.Location = new System.Drawing.Point(0, 0);
            this.tcJobDetails.Name = "tcJobDetails";
            this.tcJobDetails.SelectedIndex = 0;
            this.tcJobDetails.Size = new System.Drawing.Size(555, 416);
            this.tcJobDetails.TabIndex = 3;
            this.tcJobDetails.SelectedIndexChanged += new System.EventHandler(this.tcJob_SelectedIndexChanged);
            // 
            // tabMessages
            // 
            this.tabMessages.Controls.Add(this.jobMessageControl);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(547, 390);
            this.tabMessages.TabIndex = 3;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // jobMessageControl
            // 
            this.jobMessageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobMessageControl.Location = new System.Drawing.Point(3, 3);
            this.jobMessageControl.Name = "jobMessageControl";
            this.jobMessageControl.Size = new System.Drawing.Size(541, 384);
            this.jobMessageControl.TabIndex = 0;
            // 
            // BitsJobDetails
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tcJobDetails);
            this.Name = "BitsJobDetails";
            this.Size = new System.Drawing.Size(555, 416);
            this.tabSecurity.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            this.tabDetails.ResumeLayout(false);
            this.tcJobDetails.ResumeLayout(false);
            this.tabMessages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
