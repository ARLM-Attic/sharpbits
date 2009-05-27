using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Crad.Windows.Forms.Actions;
using SharpBits.WinClient.Controls;
using System.Drawing;
using SharpBits.WinClient.Properties;

namespace SharpBits.WinClient
{
    partial class JobListControl
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
            System.ComponentModel.ComponentResourceManager manager = new System.ComponentModel.ComponentResourceManager(typeof(JobListControl));
            ListViewGroup group = new ListViewGroup("Download", System.Windows.Forms.HorizontalAlignment.Left);
            ListViewGroup group2 = new ListViewGroup("Upload", System.Windows.Forms.HorizontalAlignment.Left);
            this.ctxJobControl = new ContextMenuStrip(this.components);
            this.ctxmiAddDownloads = new ToolStripMenuItem();
            this.ctxmiAddUpload = new ToolStripMenuItem();
            this.ctxmiaddDownload = new ToolStripMenuItem();
            this.ctxmiRefresh = new ToolStripMenuItem();
            this.ctxJobOwnerSettings = new ToolStripMenuItem();
            this.ctxsepJob1 = new ToolStripSeparator();
            this.ctxmiPriorityMap = new ToolStripMenuItem();
            this.ctxdlPriority = new ToolStripComboBox();
            this.ctxsepJob2 = new ToolStripSeparator();
            this.ctxmiResume = new ToolStripMenuItem();
            this.ctxmiCancel = new ToolStripMenuItem();
            this.ctxmiSuspend = new ToolStripMenuItem();
            this.ctxmiComplete = new ToolStripMenuItem();
            this.ctxsepJob3 = new ToolStripSeparator();
            this.ctxmiJobProperties = new ToolStripMenuItem();
            this.imglDirection = new ImageList(this.components);
            this.actlJobList = new ActionList();
            this.actAddUploadJob = new Crad.Windows.Forms.Actions.Action();
            this.actAddDownloadJob = new Crad.Windows.Forms.Actions.Action();
            this.actRefresh = new Crad.Windows.Forms.Actions.Action();
            this.actShowAllJobs = new Crad.Windows.Forms.Actions.Action();
            this.actResume = new Crad.Windows.Forms.Actions.Action();
            this.actCancel = new Crad.Windows.Forms.Actions.Action();
            this.actSuspend = new Crad.Windows.Forms.Actions.Action();
            this.actComplete = new Crad.Windows.Forms.Actions.Action();
            this.actJobProperties = new Crad.Windows.Forms.Actions.Action();
            this.actPasteUrl = new PasteAction();
            this.lvJobList = new BitsListView();
            this.clhJobName = new ColumnHeader();
            this.clhJobState = new ColumnHeader();
            this.clhFiles = new ColumnHeader();
            this.clhBytes = new ColumnHeader();
            this.clhProgress = new ColumnHeader();
            this.ctxJobControl.SuspendLayout();
            this.actlJobList.BeginInit();
            base.SuspendLayout();
            this.ctxJobControl.Items.AddRange(new ToolStripItem[] { this.ctxmiAddDownloads, this.ctxmiRefresh, this.ctxJobOwnerSettings, this.ctxsepJob1, this.ctxmiPriorityMap, this.ctxdlPriority, this.ctxsepJob2, this.ctxmiResume, this.ctxmiCancel, this.ctxmiSuspend, this.ctxmiComplete, this.ctxsepJob3, this.ctxmiJobProperties });
            this.ctxJobControl.Name = "ctxJobControl";
            this.ctxJobControl.Size = new Size(0xb6, 0xf5);
            this.ctxmiAddDownloads.DropDownItems.AddRange(new ToolStripItem[] { this.ctxmiAddUpload, this.ctxmiaddDownload });
            this.ctxmiAddDownloads.Image = Resources.NewItem;
            this.ctxmiAddDownloads.Name = "ctxmiAddDownloads";
            this.ctxmiAddDownloads.Size = new Size(0xb5, 0x16);
            this.ctxmiAddDownloads.Text = "Add new job";
            this.actlJobList.SetAction(this.ctxmiAddUpload, this.actAddUploadJob);
            this.ctxmiAddUpload.Image = Resources.Upload;
            this.ctxmiAddUpload.Name = "ctxmiAddUpload";
            this.ctxmiAddUpload.Size = new Size(0x84, 0x16);
            this.ctxmiAddUpload.Text = "Upload";
            this.actlJobList.SetAction(this.ctxmiaddDownload, this.actAddDownloadJob);
            this.ctxmiaddDownload.Image = Resources.Download;
            this.ctxmiaddDownload.Name = "ctxmiaddDownload";
            this.ctxmiaddDownload.Size = new Size(0x84, 0x16);
            this.ctxmiaddDownload.Text = "Download";
            this.actlJobList.SetAction(this.ctxmiRefresh, this.actRefresh);
            this.ctxmiRefresh.Image = Resources.Refresh;
            this.ctxmiRefresh.Name = "ctxmiRefresh";
            this.ctxmiRefresh.Size = new Size(0xb5, 0x16);
            this.ctxmiRefresh.Text = "Refresh";
            this.actlJobList.SetAction(this.ctxJobOwnerSettings, this.actShowAllJobs);
            this.ctxJobOwnerSettings.Image = Resources.CurrentUser;
            this.ctxJobOwnerSettings.Name = "ctxJobOwnerSettings";
            this.ctxJobOwnerSettings.Size = new Size(0xb5, 0x16);
            this.ctxJobOwnerSettings.Text = "Show All Jobs";
            this.ctxsepJob1.Name = "ctxsepJob1";
            this.ctxsepJob1.Size = new Size(0xb2, 6);
            this.ctxmiPriorityMap.Image = Resources.ColorMap;
            this.ctxmiPriorityMap.Name = "ctxmiPriorityMap";
            this.ctxmiPriorityMap.Size = new Size(0xb5, 0x16);
            this.ctxmiPriorityMap.Text = "Adjust Priority:";
            this.ctxdlPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxdlPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctxdlPriority.Name = "ctxdlPriority";
            this.ctxdlPriority.Size = new Size(0x79, 0x15);
            this.ctxdlPriority.ToolTipText = "Select job priority";
            this.ctxdlPriority.SelectedIndexChanged += new EventHandler(this.ctxdlPriority_SelectedIndexChanged);
            this.ctxsepJob2.Name = "ctxsepJob2";
            this.ctxsepJob2.Size = new Size(0xb2, 6);
            this.actlJobList.SetAction(this.ctxmiResume, this.actResume);
            this.ctxmiResume.Image = Resources.Play;
            this.ctxmiResume.Name = "ctxmiResume";
            this.ctxmiResume.Size = new Size(0xb5, 0x16);
            this.ctxmiResume.Text = "Resume";
            this.actlJobList.SetAction(this.ctxmiCancel, this.actCancel);
            this.ctxmiCancel.Image = Resources.Delete;
            this.ctxmiCancel.Name = "ctxmiCancel";
            this.ctxmiCancel.Size = new Size(0xb5, 0x16);
            this.ctxmiCancel.Text = "Cancel";
            this.actlJobList.SetAction(this.ctxmiSuspend, this.actSuspend);
            this.ctxmiSuspend.Image = Resources.Pause;
            this.ctxmiSuspend.Name = "ctxmiSuspend";
            this.ctxmiSuspend.Size = new Size(0xb5, 0x16);
            this.ctxmiSuspend.Text = "Suspend";
            this.actlJobList.SetAction(this.ctxmiComplete, this.actComplete);
            this.ctxmiComplete.Image = Resources.Complete;
            this.ctxmiComplete.Name = "ctxmiComplete";
            this.ctxmiComplete.Size = new Size(0xb5, 0x16);
            this.ctxmiComplete.Text = "Complete";
            this.ctxsepJob3.Name = "ctxsepJob3";
            this.ctxsepJob3.Size = new Size(0xb2, 6);
            this.actlJobList.SetAction(this.ctxmiJobProperties, this.actJobProperties);
            this.ctxmiJobProperties.Image = Resources.Properties;
            this.ctxmiJobProperties.Name = "ctxmiJobProperties";
            this.ctxmiJobProperties.Size = new Size(0xb5, 0x16);
            this.ctxmiJobProperties.Text = "Properties";
            this.imglDirection.ImageStream = (ImageListStreamer)manager.GetObject("imglDirection.ImageStream");
            this.imglDirection.TransparentColor = System.Drawing.Color.Transparent;
            this.imglDirection.Images.SetKeyName(0, "");
            this.imglDirection.Images.SetKeyName(1, "");
            this.actlJobList.Actions.Add(this.actSuspend);
            this.actlJobList.Actions.Add(this.actResume);
            this.actlJobList.Actions.Add(this.actCancel);
            this.actlJobList.Actions.Add(this.actComplete);
            this.actlJobList.Actions.Add(this.actAddDownloadJob);
            this.actlJobList.Actions.Add(this.actAddUploadJob);
            this.actlJobList.Actions.Add(this.actRefresh);
            this.actlJobList.Actions.Add(this.actJobProperties);
            this.actlJobList.Actions.Add(this.actShowAllJobs);
            this.actlJobList.ContainerControl = this;
            this.actAddUploadJob.Image = Resources.Upload;
            this.actAddUploadJob.Text = "Upload";
            this.actAddUploadJob.Execute += new EventHandler(this.actAddUploadJob_Execute);
            this.actAddDownloadJob.Image = Resources.Download;
            this.actAddDownloadJob.Text = "Download";
            this.actAddDownloadJob.Execute += new EventHandler(this.actAddDownloadJob_Execute);
            this.actRefresh.Image = Resources.Refresh;
            this.actRefresh.Text = "Refresh";
            this.actRefresh.Execute += new EventHandler(this.actRefresh_Execute);
            this.actShowAllJobs.Image = Resources.CurrentUser;
            this.actShowAllJobs.Text = "Show All Jobs";
            this.actShowAllJobs.Execute += new EventHandler(this.actShowAllJobs_Execute);
            this.actResume.Image = Resources.Play;
            this.actResume.Text = "Resume";
            this.actResume.ToolTipText = "Resume the current job";
            this.actResume.Execute += new EventHandler(this.actResume_Execute);
            this.actCancel.Image = Resources.Delete;
            this.actCancel.Text = "Cancel";
            this.actCancel.ToolTipText = "Cancel the current job";
            this.actCancel.Execute += new EventHandler(this.actCancel_Execute);
            this.actSuspend.Image = Resources.Pause;
            this.actSuspend.Text = "Suspend";
            this.actSuspend.ToolTipText = "Supend the current job";
            this.actSuspend.Execute += new EventHandler(this.actSuspend_Execute);
            this.actComplete.Image = Resources.Complete;
            this.actComplete.Text = "Complete";
            this.actComplete.ToolTipText = "Set job state to Complete for the current job";
            this.actComplete.Execute += new EventHandler(this.actComplete_Execute);
            this.actJobProperties.Image = Resources.Properties;
            this.actJobProperties.Text = "Properties";
            this.actJobProperties.Execute += new EventHandler(this.actJobProperties_Execute);
            this.actPasteUrl.Image = (Image)manager.GetObject("actPasteUrl.Image");
            this.actPasteUrl.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            this.actPasteUrl.Text = "&Paste";
            this.actPasteUrl.ToolTipText = "Paste";
            this.actPasteUrl.Execute += new EventHandler(this.actPasteUrl_Execute);
            this.lvJobList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvJobList.AllowDrop = true;
            this.lvJobList.Columns.AddRange(new ColumnHeader[] { this.clhJobName, this.clhJobState, this.clhFiles, this.clhBytes, this.clhProgress });
            this.lvJobList.ContextMenuStrip = this.ctxJobControl;
            this.lvJobList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvJobList.FullRowSelect = true;
            this.lvJobList.GridLines = true;
            group.Header = "Download";
            group.Name = "lvGroupDownload";
            group2.Header = "Upload";
            group2.Name = "lvGroupUpload";
            this.lvJobList.Groups.AddRange(new ListViewGroup[] { group, group2 });
            this.lvJobList.HideSelection = false;
            this.lvJobList.LabelEdit = true;
            this.lvJobList.Location = new Point(0, 0);
            this.lvJobList.MultiSelect = false;
            this.lvJobList.Name = "lvJobList";
            this.lvJobList.OwnerDraw = true;
            this.lvJobList.ShowItemToolTips = true;
            this.lvJobList.Size = new Size(0x26b, 0x143);
            this.lvJobList.SmallImageList = this.imglDirection;
            this.lvJobList.TabIndex = 0;
            this.lvJobList.UseCompatibleStateImageBehavior = false;
            this.lvJobList.View = System.Windows.Forms.View.Details;
            this.lvJobList.DragEnter += new DragEventHandler(this.lvJobList_DragEnter);
            this.lvJobList.DragDrop += new DragEventHandler(this.lvJobList_DragDrop);
            this.lvJobList.DrawItem += new DrawListViewItemEventHandler(this.lvJobList_DrawItem);
            this.lvJobList.DoubleClick += new EventHandler(this.lvJobList_DoubleClick);
            this.lvJobList.SelectedIndexChanged += new EventHandler(this.lvJobList_SelectedIndexChanged);
            this.lvJobList.DrawSubItem += new DrawListViewSubItemEventHandler(this.lvJobList_DrawSubItem);
            this.lvJobList.AfterLabelEdit += new LabelEditEventHandler(this.lvJobList_AfterLabelEdit);
            this.lvJobList.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(this.lvJobList_DrawColumnHeader);
            this.lvJobList.KeyUp += new KeyEventHandler(this.lvJobList_KeyUp);
            this.clhJobName.Text = "Name";
            this.clhJobName.Width = 120;
            this.clhJobState.Text = "State";
            this.clhJobState.Width = 80;
            this.clhFiles.Text = "Files";
            this.clhFiles.TextAlign = HorizontalAlignment.Right;
            this.clhFiles.Width = 80;
            this.clhBytes.Text = "Bytes";
            this.clhBytes.TextAlign = HorizontalAlignment.Right;
            this.clhBytes.Width = 120;
            this.clhProgress.Text = "Progress";
            this.clhProgress.Width = 120;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.ctxJobControl;
            base.Controls.Add(this.lvJobList);
            base.Name = "JobListControl";
            base.Size = new Size(0x26b, 0x143);
            this.ctxJobControl.ResumeLayout(false);
            this.actlJobList.EndInit();
            base.ResumeLayout(false);
        }

        #endregion

    }
}
