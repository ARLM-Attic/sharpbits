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
            components = new System.ComponentModel.Container();
            this.tabSecurity = new TabPage();
            this.userAuthenticationControl = new UserAuthenticationControl();
            this.tabFiles = new TabPage();
            this.fileListControl = new FileListControl();
            this.tabDetails = new TabPage();
            this.jobDetailsControl = new JobDetailsControl();
            this.tcJobDetails = new TabControl();
            this.tabMessages = new TabPage();
            this.jobMessageControl = new JobMessageControl();
            this.tabSecurity.SuspendLayout();
            this.tabFiles.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.tcJobDetails.SuspendLayout();
            this.tabMessages.SuspendLayout();
            base.SuspendLayout();
            this.tabSecurity.Controls.Add(this.userAuthenticationControl);
            this.tabSecurity.Location = new Point(4, 0x16);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Padding = new Padding(3);
            this.tabSecurity.Size = new Size(0x223, 390);
            this.tabSecurity.TabIndex = 2;
            this.tabSecurity.Text = "Authentication";
            this.tabSecurity.UseVisualStyleBackColor = true;
            this.userAuthenticationControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAuthenticationControl.Location = new Point(3, 3);
            this.userAuthenticationControl.MinimumSize = new Size(0x242, 0x1a3);
            this.userAuthenticationControl.Name = "userAuthenticationControl";
            this.userAuthenticationControl.Size = new Size(0x242, 0x1a3);
            this.userAuthenticationControl.TabIndex = 0;
            this.tabFiles.Controls.Add(this.fileListControl);
            this.tabFiles.Location = new Point(4, 0x16);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Padding = new Padding(3);
            this.tabFiles.Size = new Size(0x223, 390);
            this.tabFiles.TabIndex = 1;
            this.tabFiles.Text = "Files";
            this.tabFiles.UseVisualStyleBackColor = true;
            this.fileListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListControl.Location = new Point(3, 3);
            this.fileListControl.Name = "fileListControl";
            this.fileListControl.Size = new Size(0x21d, 0x180);
            this.fileListControl.TabIndex = 0;
            this.tabDetails.Controls.Add(this.jobDetailsControl);
            this.tabDetails.Location = new Point(4, 0x16);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new Padding(3);
            this.tabDetails.Size = new Size(0x223, 390);
            this.tabDetails.TabIndex = 0;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            this.jobDetailsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobDetailsControl.Location = new Point(3, 3);
            this.jobDetailsControl.Name = "jobDetailsControl";
            this.jobDetailsControl.Size = new Size(0x21d, 0x180);
            this.jobDetailsControl.TabIndex = 0;
            this.tcJobDetails.Controls.Add(this.tabDetails);
            this.tcJobDetails.Controls.Add(this.tabFiles);
            this.tcJobDetails.Controls.Add(this.tabSecurity);
            this.tcJobDetails.Controls.Add(this.tabMessages);
            this.tcJobDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcJobDetails.Location = new Point(0, 0);
            this.tcJobDetails.Name = "tcJobDetails";
            this.tcJobDetails.SelectedIndex = 0;
            this.tcJobDetails.Size = new Size(0x22b, 0x1a0);
            this.tcJobDetails.TabIndex = 3;
            this.tcJobDetails.SelectedIndexChanged += new EventHandler(this.tcJob_SelectedIndexChanged);
            this.tabMessages.Controls.Add(this.jobMessageControl);
            this.tabMessages.Location = new Point(4, 0x16);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new Padding(3);
            this.tabMessages.Size = new Size(0x223, 390);
            this.tabMessages.TabIndex = 3;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            this.jobMessageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobMessageControl.Location = new Point(3, 3);
            this.jobMessageControl.Name = "jobMessageControl";
            this.jobMessageControl.Size = new Size(0x21d, 0x180);
            this.jobMessageControl.TabIndex = 0;
            this.AllowDrop = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            base.Controls.Add(this.tcJobDetails);
            base.Name = "BitsJobDetails";
            base.Size = new Size(0x22b, 0x1a0);
            this.tabSecurity.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            this.tabDetails.ResumeLayout(false);
            this.tcJobDetails.ResumeLayout(false);
            this.tabMessages.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        #endregion

    }
}
