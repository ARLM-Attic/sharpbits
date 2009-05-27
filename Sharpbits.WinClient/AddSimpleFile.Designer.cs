using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace SharpBits.WinClient
{
    partial class AddSimpleFile
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new Label();
            this.tbRemoteName = new TextBox();
            this.label2 = new Label();
            this.tbLocalName = new TextBox();
            this.btnOk = new Button();
            this.btnCancel = new Button();
            this.btnLocalFile = new Button();
            this.chkDeleteLocalFile = new CheckBox();
            this.requiredFieldsValidation = new ErrorProvider(this.components);
            ((ISupportInitialize)this.requiredFieldsValidation).BeginInit();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x2c, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remote";
            this.label1.TextAlign = ContentAlignment.TopRight;
            this.tbRemoteName.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.tbRemoteName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.tbRemoteName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.tbRemoteName.Location = new Point(0x35, 6);
            this.tbRemoteName.Name = "tbRemoteName";
            this.tbRemoteName.Size = new Size(0x169, 20);
            this.tbRemoteName.TabIndex = 1;
            this.tbRemoteName.Validating += new CancelEventHandler(this.tbRemoteName_Validating);
            this.tbRemoteName.TextChanged += new EventHandler(this.tbRemoteName_TextChanged);
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0x12, 0x27);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local";
            this.label2.TextAlign = ContentAlignment.TopRight;
            this.tbLocalName.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            this.tbLocalName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.tbLocalName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.tbLocalName.Location = new Point(0x35, 0x24);
            this.tbLocalName.Name = "tbLocalName";
            this.tbLocalName.Size = new Size(0x169, 20);
            this.tbLocalName.TabIndex = 3;
            this.tbLocalName.Validating += new CancelEventHandler(this.tbLocalName_Validating);
            this.tbLocalName.TextChanged += new EventHandler(this.tbLocalName_TextChanged);
            this.btnOk.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnOk.Location = new Point(340, 0x3e);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new Size(0x4b, 0x17);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Add";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new EventHandler(this.btnOk_Click);
            this.btnCancel.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnCancel.Location = new Point(0x103, 0x3e);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(0x4b, 0x17);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            this.btnLocalFile.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            this.btnLocalFile.Location = new Point(0x1ad, 0x22);
            this.btnLocalFile.Name = "btnLocalFile";
            this.btnLocalFile.Size = new Size(0x18, 0x17);
            this.btnLocalFile.TabIndex = 6;
            this.btnLocalFile.Text = "...";
            this.btnLocalFile.UseVisualStyleBackColor = true;
            this.btnLocalFile.Click += new EventHandler(this.btnLocalFile_Click);
            this.chkDeleteLocalFile.AutoSize = true;
            this.chkDeleteLocalFile.Location = new Point(0x35, 0x42);
            this.chkDeleteLocalFile.Name = "chkDeleteLocalFile";
            this.chkDeleteLocalFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDeleteLocalFile.Size = new Size(0xbb, 0x11);
            this.chkDeleteLocalFile.TabIndex = 7;
            this.chkDeleteLocalFile.Text = "Delete local file on upload finished";
            this.chkDeleteLocalFile.UseVisualStyleBackColor = true;
            this.requiredFieldsValidation.ContainerControl = this;
            base.AcceptButton = this.btnOk;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            base.ClientSize = new Size(0x1d1, 0x5f);
            base.Controls.Add(this.chkDeleteLocalFile);
            base.Controls.Add(this.btnLocalFile);
            base.Controls.Add(this.btnCancel);
            base.Controls.Add(this.btnOk);
            base.Controls.Add(this.tbLocalName);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.tbRemoteName);
            base.Controls.Add(this.label1);
            base.KeyPreview = true;
            base.Name = "AddSimpleFile";
            base.StartPosition = FormStartPosition.CenterParent;
            base.KeyUp += new KeyEventHandler(this.AddSimpleFile_KeyUp);
            ((ISupportInitialize)this.requiredFieldsValidation).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
    }
}
