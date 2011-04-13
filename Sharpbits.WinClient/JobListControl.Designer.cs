
using System.Windows.Forms;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobListControl));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Download", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Upload", System.Windows.Forms.HorizontalAlignment.Left);
            this.ctxJobControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmiAddDownloads = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiAddUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiaddDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiJobOwnerSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxsepJob1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxmiPriorityMap = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxdlPriority = new System.Windows.Forms.ToolStripComboBox();
            this.ctxsepJob2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxmiResume = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiSuspend = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxsepJob3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxmiJobProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.imglDirection = new System.Windows.Forms.ImageList(this.components);
            this.lvJobList = new SharpBits.WinClient.Controls.BitsListView();
            this.clhJobName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhJobState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhBytes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxJobControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxJobControl
            // 
            this.ctxJobControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmiAddDownloads,
            this.ctxmiRefresh,
            this.ctxmiJobOwnerSettings,
            this.ctxsepJob1,
            this.ctxmiPriorityMap,
            this.ctxdlPriority,
            this.ctxsepJob2,
            this.ctxmiResume,
            this.ctxmiCancel,
            this.ctxmiSuspend,
            this.ctxmiComplete,
            this.ctxsepJob3,
            this.ctxmiJobProperties});
            this.ctxJobControl.Name = "ctxJobControl";
            this.ctxJobControl.Size = new System.Drawing.Size(182, 267);
            // 
            // ctxmiAddDownloads
            // 
            this.ctxmiAddDownloads.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmiAddUpload,
            this.ctxmiaddDownload});
            this.ctxmiAddDownloads.Image = global::SharpBits.WinClient.Properties.Resources.NewItem;
            this.ctxmiAddDownloads.Name = "ctxmiAddDownloads";
            this.ctxmiAddDownloads.Size = new System.Drawing.Size(181, 22);
            this.ctxmiAddDownloads.Text = "Add new job";
            // 
            // ctxmiAddUpload
            // 
            this.ctxmiAddUpload.Image = global::SharpBits.WinClient.Properties.Resources.Upload;
            this.ctxmiAddUpload.Name = "ctxmiAddUpload";
            this.ctxmiAddUpload.Size = new System.Drawing.Size(121, 22);
            this.ctxmiAddUpload.Text = "Upload";
            this.ctxmiAddUpload.Click += new System.EventHandler(this.ctxmiAddUpload_Click);
            // 
            // ctxmiaddDownload
            // 
            this.ctxmiaddDownload.Image = global::SharpBits.WinClient.Properties.Resources.Download;
            this.ctxmiaddDownload.Name = "ctxmiaddDownload";
            this.ctxmiaddDownload.Size = new System.Drawing.Size(121, 22);
            this.ctxmiaddDownload.Text = "Download";
            this.ctxmiaddDownload.Click += new System.EventHandler(this.ctxmiaddDownload_Click);
            // 
            // ctxmiRefresh
            // 
            this.ctxmiRefresh.Image = global::SharpBits.WinClient.Properties.Resources.Refresh;
            this.ctxmiRefresh.Name = "ctxmiRefresh";
            this.ctxmiRefresh.Size = new System.Drawing.Size(181, 22);
            this.ctxmiRefresh.Text = "Refresh";
            this.ctxmiRefresh.Click += new System.EventHandler(this.ctxmiRefresh_Click);
            // 
            // ctxmiJobOwnerSettings
            // 
            this.ctxmiJobOwnerSettings.Image = global::SharpBits.WinClient.Properties.Resources.CurrentUser;
            this.ctxmiJobOwnerSettings.Name = "ctxmiJobOwnerSettings";
            this.ctxmiJobOwnerSettings.Size = new System.Drawing.Size(181, 22);
            this.ctxmiJobOwnerSettings.Text = "Show All Jobs";
            this.ctxmiJobOwnerSettings.Click += new System.EventHandler(this.ctxmiJobOwnerSettings_Click);
            // 
            // ctxsepJob1
            // 
            this.ctxsepJob1.Name = "ctxsepJob1";
            this.ctxsepJob1.Size = new System.Drawing.Size(178, 6);
            // 
            // ctxmiPriorityMap
            // 
            this.ctxmiPriorityMap.Image = global::SharpBits.WinClient.Properties.Resources.ColorMap;
            this.ctxmiPriorityMap.Name = "ctxmiPriorityMap";
            this.ctxmiPriorityMap.Size = new System.Drawing.Size(181, 22);
            this.ctxmiPriorityMap.Text = "Adjust Priority:";
            // 
            // ctxdlPriority
            // 
            this.ctxdlPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxdlPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctxdlPriority.Name = "ctxdlPriority";
            this.ctxdlPriority.Size = new System.Drawing.Size(121, 21);
            this.ctxdlPriority.ToolTipText = "Select job priority";
            this.ctxdlPriority.SelectedIndexChanged += new System.EventHandler(this.ctxdlPriority_SelectedIndexChanged);
            // 
            // ctxsepJob2
            // 
            this.ctxsepJob2.Name = "ctxsepJob2";
            this.ctxsepJob2.Size = new System.Drawing.Size(178, 6);
            // 
            // ctxmiResume
            // 
            this.ctxmiResume.Image = global::SharpBits.WinClient.Properties.Resources.Play;
            this.ctxmiResume.Name = "ctxmiResume";
            this.ctxmiResume.Size = new System.Drawing.Size(181, 22);
            this.ctxmiResume.Text = "Resume";
            this.ctxmiResume.ToolTipText = "Resume the current job";
            this.ctxmiResume.Click += new System.EventHandler(this.ctxmiResume_Click);
            // 
            // ctxmiCancel
            // 
            this.ctxmiCancel.Image = global::SharpBits.WinClient.Properties.Resources.Delete;
            this.ctxmiCancel.Name = "ctxmiCancel";
            this.ctxmiCancel.Size = new System.Drawing.Size(181, 22);
            this.ctxmiCancel.Text = "Cancel";
            this.ctxmiCancel.ToolTipText = "Cancel the current job";
            this.ctxmiCancel.Click += new System.EventHandler(this.ctxmiCancel_Click);
            // 
            // ctxmiSuspend
            // 
            this.ctxmiSuspend.Image = global::SharpBits.WinClient.Properties.Resources.Pause;
            this.ctxmiSuspend.Name = "ctxmiSuspend";
            this.ctxmiSuspend.Size = new System.Drawing.Size(181, 22);
            this.ctxmiSuspend.Text = "Suspend";
            this.ctxmiSuspend.ToolTipText = "Supend the current job";
            this.ctxmiSuspend.Click += new System.EventHandler(this.ctxmiSuspend_Click);
            // 
            // ctxmiComplete
            // 
            this.ctxmiComplete.Image = global::SharpBits.WinClient.Properties.Resources.Complete;
            this.ctxmiComplete.Name = "ctxmiComplete";
            this.ctxmiComplete.Size = new System.Drawing.Size(181, 22);
            this.ctxmiComplete.Text = "Complete";
            this.ctxmiComplete.ToolTipText = "Set job state to Complete for the current job";
            this.ctxmiComplete.Click += new System.EventHandler(this.ctxmiComplete_Click);
            // 
            // ctxsepJob3
            // 
            this.ctxsepJob3.Name = "ctxsepJob3";
            this.ctxsepJob3.Size = new System.Drawing.Size(178, 6);
            // 
            // ctxmiJobProperties
            // 
            this.ctxmiJobProperties.Image = global::SharpBits.WinClient.Properties.Resources.Properties;
            this.ctxmiJobProperties.Name = "ctxmiJobProperties";
            this.ctxmiJobProperties.Size = new System.Drawing.Size(181, 22);
            this.ctxmiJobProperties.Text = "Properties";
            this.ctxmiJobProperties.Click += new System.EventHandler(this.ctxmiJobProperties_Click);
            // 
            // imglDirection
            // 
            this.imglDirection.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglDirection.ImageStream")));
            this.imglDirection.TransparentColor = System.Drawing.Color.Transparent;
            this.imglDirection.Images.SetKeyName(0, "Download.png");
            this.imglDirection.Images.SetKeyName(1, "Upload.png");
            // 
            // lvJobList
            // 
            this.lvJobList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvJobList.AllowDrop = true;
            this.lvJobList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhJobName,
            this.clhJobState,
            this.clhFiles,
            this.clhBytes,
            this.clhProgress});
            this.lvJobList.ContextMenuStrip = this.ctxJobControl;
            this.lvJobList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvJobList.FullRowSelect = true;
            this.lvJobList.GridLines = true;
            listViewGroup1.Header = "Download";
            listViewGroup1.Name = "lvGroupDownload";
            listViewGroup2.Header = "Upload";
            listViewGroup2.Name = "lvGroupUpload";
            this.lvJobList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvJobList.HideSelection = false;
            this.lvJobList.LabelEdit = true;
            this.lvJobList.Location = new System.Drawing.Point(0, 0);
            this.lvJobList.MultiSelect = false;
            this.lvJobList.Name = "lvJobList";
            this.lvJobList.OwnerDraw = true;
            this.lvJobList.ShowItemToolTips = true;
            this.lvJobList.Size = new System.Drawing.Size(619, 323);
            this.lvJobList.SmallImageList = this.imglDirection;
            this.lvJobList.TabIndex = 0;
            this.lvJobList.UseCompatibleStateImageBehavior = false;
            this.lvJobList.View = System.Windows.Forms.View.Details;
            this.lvJobList.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvJobList_AfterLabelEdit);
            this.lvJobList.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvJobList_DrawColumnHeader);
            this.lvJobList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvJobList_DrawItem);
            this.lvJobList.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvJobList_DrawSubItem);
            this.lvJobList.SelectedIndexChanged += new System.EventHandler(this.lvJobList_SelectedIndexChanged);
            this.lvJobList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvJobList_DragDrop);
            this.lvJobList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvJobList_DragEnter);
            this.lvJobList.DoubleClick += new System.EventHandler(this.lvJobList_DoubleClick);
            this.lvJobList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvJobList_KeyUp);
            // 
            // clhJobName
            // 
            this.clhJobName.Text = "Name";
            this.clhJobName.Width = 120;
            // 
            // clhJobState
            // 
            this.clhJobState.Text = "State";
            this.clhJobState.Width = 80;
            // 
            // clhFiles
            // 
            this.clhFiles.Text = "Files";
            this.clhFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clhFiles.Width = 80;
            // 
            // clhBytes
            // 
            this.clhBytes.Text = "Bytes";
            this.clhBytes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clhBytes.Width = 120;
            // 
            // clhProgress
            // 
            this.clhProgress.Text = "Progress";
            this.clhProgress.Width = 120;
            // 
            // JobListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.ctxJobControl;
            this.Controls.Add(this.lvJobList);
            this.Name = "JobListControl";
            this.Size = new System.Drawing.Size(619, 323);
            this.ctxJobControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
