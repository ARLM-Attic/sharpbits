
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Job", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Downloads", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Uploads", System.Windows.Forms.HorizontalAlignment.Left);
            this.lvJobFiles = new SharpBits.WinClient.Controls.BitsListView();
            this.clhRemote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhBytesTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTransfered = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvJobFiles
            // 
            this.lvJobFiles.AllowColumnReorder = true;
            this.lvJobFiles.AllowDrop = true;
            this.lvJobFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhRemote,
            this.clhLocal,
            this.clhBytesTotal,
            this.clhTransfered,
            this.clhProgress});
            this.lvJobFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvJobFiles.FullRowSelect = true;
            listViewGroup1.Header = "Job";
            listViewGroup1.Name = "lvGroupJob";
            listViewGroup2.Header = "Downloads";
            listViewGroup2.Name = "lvGroupDownloads";
            listViewGroup3.Header = "Uploads";
            listViewGroup3.Name = "lvGroupUpload";
            this.lvJobFiles.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.lvJobFiles.Location = new System.Drawing.Point(0, 0);
            this.lvJobFiles.Name = "lvJobFiles";
            this.lvJobFiles.OwnerDraw = true;
            this.lvJobFiles.ShowItemToolTips = true;
            this.lvJobFiles.Size = new System.Drawing.Size(550, 300);
            this.lvJobFiles.TabIndex = 1;
            this.lvJobFiles.UseCompatibleStateImageBehavior = false;
            this.lvJobFiles.View = System.Windows.Forms.View.Details;
            this.lvJobFiles.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvJobFiles_DrawColumnHeader);
            this.lvJobFiles.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvJobFiles_DrawItem);
            this.lvJobFiles.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvJobFiles_DrawSubItem);
            this.lvJobFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvJobFiles_DragDrop);
            this.lvJobFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvJobFiles_DragEnter);
            this.lvJobFiles.DoubleClick += new System.EventHandler(this.lvJobFiles_DoubleClick);
            // 
            // clhRemote
            // 
            this.clhRemote.Text = "Remote Path";
            this.clhRemote.Width = 120;
            // 
            // clhLocal
            // 
            this.clhLocal.Text = "Local Path";
            this.clhLocal.Width = 120;
            // 
            // clhBytesTotal
            // 
            this.clhBytesTotal.Text = "Size";
            this.clhBytesTotal.Width = 80;
            // 
            // clhTransfered
            // 
            this.clhTransfered.Text = "Transfered";
            this.clhTransfered.Width = 80;
            // 
            // clhProgress
            // 
            this.clhProgress.Text = "Progress";
            this.clhProgress.Width = 80;
            // 
            // FileListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvJobFiles);
            this.DoubleBuffered = true;
            this.Name = "FileListControl";
            this.Size = new System.Drawing.Size(550, 300);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
