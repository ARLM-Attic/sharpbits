using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SharpBits.WinClient
{
    partial class JobMessageControl
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
            this.gbJobMessages = new GroupBox();
            this.txtJobError = new TextBox();
            this.gbJobMessages.SuspendLayout();
            base.SuspendLayout();
            this.gbJobMessages.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Top;
            this.gbJobMessages.Controls.Add(this.txtJobError);
            this.gbJobMessages.Location = new Point(3, 3);
            this.gbJobMessages.Name = "gbJobMessages";
            this.gbJobMessages.Size = new Size(0x252, 0x18a);
            this.gbJobMessages.TabIndex = 0;
            this.gbJobMessages.TabStop = false;
            this.gbJobMessages.Text = "Messages related to this job";
            this.txtJobError.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Top;
            this.txtJobError.Location = new Point(6, 0x13);
            this.txtJobError.Multiline = true;
            this.txtJobError.Name = "txtJobError";
            this.txtJobError.ScrollBars = ScrollBars.Both;
            this.txtJobError.Size = new Size(0x246, 0x171);
            this.txtJobError.TabIndex = 8;
            this.txtJobError.DoubleClick += new EventHandler(this.tbJobError_DoubleClick);
            this.txtJobError.KeyDown += new KeyEventHandler(this.tbJobError_KeyDown);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.Controls.Add(this.gbJobMessages);
            base.Name = "JobMessageControl";
            this.gbJobMessages.ResumeLayout(false);
            this.gbJobMessages.PerformLayout();
            base.ResumeLayout(false);
        }

        #endregion
    }

}
