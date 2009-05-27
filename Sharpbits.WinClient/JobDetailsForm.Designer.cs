using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SharpBits.WinClient
{
    partial class JobDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobDetailsForm));
            this.bitsJobDetails = new SharpBits.WinClient.BitsJobDetails();
            this.SuspendLayout();
            // 
            // bitsJobDetails
            // 
            this.bitsJobDetails.AllowDrop = true;
            this.bitsJobDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bitsJobDetails.AutoScroll = true;
            this.bitsJobDetails.Location = new System.Drawing.Point(0, 0);
            this.bitsJobDetails.Name = "bitsJobDetails";
            this.bitsJobDetails.Size = new System.Drawing.Size(567, 322);
            this.bitsJobDetails.TabIndex = 0;
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(567, 328);
            this.Controls.Add(this.bitsJobDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(575, 355);
            this.Name = "JobDetailsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JobDetailsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JobDetailsForm_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.JobDetailsForm_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
