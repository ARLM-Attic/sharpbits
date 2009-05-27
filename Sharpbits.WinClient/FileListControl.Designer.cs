using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Crad.Windows.Forms.Actions;
using SharpBits.WinClient.Controls;

namespace SharpBits.WinClient
{
    partial class FileListControl
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
            ListViewGroup group = new ListViewGroup("Job", HorizontalAlignment.Left);
            ListViewGroup group2 = new ListViewGroup("Downloads", HorizontalAlignment.Left);
            ListViewGroup group3 = new ListViewGroup("Uploads", HorizontalAlignment.Left);
            this.lvJobFiles = new BitsListView();
            this.clhRemote = new ColumnHeader();
            this.clhLocal = new ColumnHeader();
            this.clhBytesTotal = new ColumnHeader();
            this.clhTransfered = new ColumnHeader();
            this.clhProgress = new ColumnHeader();
            this.actlFileList = new ActionList();
            this.actAddFile = new Crad.Windows.Forms.Actions.Action();
            this.actRemoveFile = new Crad.Windows.Forms.Actions.Action();
            this.actlFileList.BeginInit();
            base.SuspendLayout();
            this.lvJobFiles.AllowColumnReorder = true;
            this.lvJobFiles.AllowDrop = true;
            this.lvJobFiles.Columns.AddRange(new ColumnHeader[] { this.clhRemote, this.clhLocal, this.clhBytesTotal, this.clhTransfered, this.clhProgress });
            this.lvJobFiles.Dock = DockStyle.Fill;
            this.lvJobFiles.FullRowSelect = true;
            group.Header = "Job";
            group.Name = "lvGroupJob";
            group2.Header = "Downloads";
            group2.Name = "lvGroupDownloads";
            group3.Header = "Uploads";
            group3.Name = "lvGroupUpload";
            this.lvJobFiles.Groups.AddRange(new ListViewGroup[] { group, group2, group3 });
            this.lvJobFiles.Location = new Point(0, 0);
            this.lvJobFiles.Name = "lvJobFiles";
            this.lvJobFiles.OwnerDraw = true;
            this.lvJobFiles.ShowItemToolTips = true;
            this.lvJobFiles.Size = new Size(550, 300);
            this.lvJobFiles.TabIndex = 1;
            this.lvJobFiles.UseCompatibleStateImageBehavior = false;
            this.lvJobFiles.View = View.Details;
            this.lvJobFiles.DragEnter += new DragEventHandler(this.lvJobFiles_DragEnter);
            this.lvJobFiles.DragDrop += new DragEventHandler(this.lvJobFiles_DragDrop);
            this.lvJobFiles.DrawItem += new DrawListViewItemEventHandler(this.lvJobFiles_DrawItem);
            this.lvJobFiles.DoubleClick += new EventHandler(this.actAddFile_Execute);
            this.lvJobFiles.DrawSubItem += new DrawListViewSubItemEventHandler(this.lvJobFiles_DrawSubItem);
            this.lvJobFiles.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(this.lvJobFiles_DrawColumnHeader);
            this.clhRemote.Text = "Remote Path";
            this.clhRemote.Width = 120;
            this.clhLocal.Text = "Local Path";
            this.clhLocal.Width = 120;
            this.clhBytesTotal.Text = "Size";
            this.clhBytesTotal.Width = 80;
            this.clhTransfered.Text = "Transfered";
            this.clhTransfered.Width = 80;
            this.clhProgress.Text = "Progress";
            this.clhProgress.Width = 80;
            this.actlFileList.Actions.Add(this.actAddFile);
            this.actlFileList.Actions.Add(this.actRemoveFile);
            this.actlFileList.ContainerControl = this;
            this.actAddFile.Text = "Add File";
            this.actAddFile.Execute += new EventHandler(this.actAddFile_Execute);
            this.actRemoveFile.Text = "Remove File";
            this.actRemoveFile.Execute += new EventHandler(this.actRemoveFile_Execute);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.Controls.Add(this.lvJobFiles);
            this.DoubleBuffered = true;
            base.Name = "FileListControl";
            base.Size = new Size(550, 300);
            this.actlFileList.EndInit();
            base.ResumeLayout(false);
        }

        #endregion
    }
}
