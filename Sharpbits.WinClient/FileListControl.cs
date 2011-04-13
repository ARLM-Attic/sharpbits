using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SharpBits.Base;
using SharpBits.WinClient.Controls;
using SharpBits.WinClient.Properties;

namespace SharpBits.WinClient
{
    public partial class FileListControl : JobControl
    {
        // Fields
        private ColumnHeader clhBytesTotal;
        private ColumnHeader clhLocal;
        private ColumnHeader clhProgress;
        private ColumnHeader clhRemote;
        private ColumnHeader clhTransfered;
        private BitsListView lvJobFiles;

        // Methods
        public FileListControl()
        {
            this.InitializeComponent();
        }

        private void actAddFile_Execute(object sender, EventArgs e)
        {
        }

        private void AddFiles(JobType jobType)
        {
            base.wrapper.FileList = new string[0];
            this.ShowAddFileDialog();
        }

        private void AddFiles(JobType jobType, string[] files)
        {
            base.wrapper.FileList = files;
            this.ShowAddFileDialog();
        }

        public void AddFilesOnJob()
        {
            if (base.wrapper.FileList != null)
            {
                MethodInvoker method = new MethodInvoker(this.ShowAddFileDialog);
                base.BeginInvoke(method);
            }
        }

        private void BitsJob_OnJobError(object sender, JobErrorNotificationEventArgs e)
        {
            if (base.InvokeRequired)
            {
                EventHandler<JobErrorNotificationEventArgs> method = new EventHandler<JobErrorNotificationEventArgs>(this.BitsJob_OnJobError);
                base.Invoke(method, new object[] { sender, e });
            }
            else
            {
                this.UpdateControl();
            }
        }

        private void BitsJob_OnJobModified(object sender, JobNotificationEventArgs e)
        {
            if (base.InvokeRequired)
            {
                EventHandler<JobNotificationEventArgs> method = new EventHandler<JobNotificationEventArgs>(this.BitsJob_OnJobModified);
                base.Invoke(method, new object[] { sender, e });
            }
            else
            {
                this.UpdateControl();
            }
        }

        private static Rectangle CalcProgress(Rectangle rectAngle, ulong total, ulong current)
        {
            Rectangle rectangle = new Rectangle(rectAngle.X, rectAngle.Y, rectAngle.Width, rectAngle.Height);
            rectangle.Width = (int)Math.Floor((double)(((ulong)rectangle.Width * current) / ((double)total)));
            return rectangle;
        }

        public override void DeInitControl()
        {
            base.wrapper.BitsJob.OnJobModified -= new EventHandler<JobNotificationEventArgs>(this.BitsJob_OnJobModified);
            base.wrapper.BitsJob.OnJobError -= new EventHandler<JobErrorNotificationEventArgs>(this.BitsJob_OnJobError);
            base.DeInitControl();
        }

        public override void InitControl(JobWrapper wrapper)
        {
            base.InitControl(wrapper);
            wrapper.BitsJob.OnJobError += new EventHandler<JobErrorNotificationEventArgs>(this.BitsJob_OnJobError);
            wrapper.BitsJob.OnJobModified += new EventHandler<JobNotificationEventArgs>(this.BitsJob_OnJobModified);
        }

        private void lvJobFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] strArray = DragDropHandler.DragDrop(e);
            DragDropCallback method = new DragDropCallback(this.AddFiles);
            base.BeginInvoke(method, new object[] { base.wrapper.BitsJob.JobType, strArray });
        }

        private void lvJobFiles_DragEnter(object sender, DragEventArgs e)
        {
            DragDropHandler.DragEnter(e, base.wrapper.BitsJob.JobType);
        }

        private void lvJobFiles_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvJobFiles_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if (e.Item.Focused)
            {
                Pen pen = new Pen(SystemColors.ControlDark, 1f);
                pen.DashStyle = DashStyle.Dot;
                Rectangle rect = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
                pen.Dispose();
            }
        }

        private void lvJobFiles_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Rectangle rectangle;
            Brush gradientActiveCaption;
            BitsFile tag = (BitsFile)e.Item.Tag;
            BitsJob bitsJob = base.wrapper.BitsJob;
            Color windowText = SystemColors.WindowText;
            Font prototype = this.lvJobFiles.Font;
            TextFormatFlags flags = TextFormatFlags.LeftAndRightPadding | TextFormatFlags.EndEllipsis | TextFormatFlags.VerticalCenter;
            if (tag == null)
            {
                if ((bitsJob.State == JobState.Suspended) || (bitsJob.State == JobState.Queued))
                {
                    if (e.Item.Selected)
                    {
                        windowText = SystemColors.ActiveCaptionText;
                    }
                    else
                    {
                        windowText = SystemColors.InactiveCaptionText;
                    }
                    prototype = new Font(prototype, FontStyle.Italic);
                }
                else if ((bitsJob.State == JobState.Error) || (bitsJob.State == JobState.TransientError))
                {
                    windowText = Color.Red;
                }
                else if ((bitsJob.State == JobState.Transferred) || (bitsJob.State == JobState.Acknowledged))
                {
                    windowText = Settings.Default.ProgressCompletedColor;
                    prototype = new Font(prototype, FontStyle.Strikeout);
                }
                else if (bitsJob.State == JobState.Canceled)
                {
                    if (e.Item.Selected)
                    {
                        windowText = SystemColors.ActiveCaptionText;
                    }
                    else
                    {
                        windowText = SystemColors.InactiveCaptionText;
                    }
                    prototype = new Font(prototype, FontStyle.Strikeout);
                }
                else if (bitsJob.State == JobState.Connecting)
                {
                    windowText = Color.YellowGreen;
                }
                else if (bitsJob.State == JobState.Transferring)
                {
                    windowText = Settings.Default.ProgressDoneColor;
                }
            }
            if (e.Item.Selected)
            {
                int num = (e.ColumnIndex == 0) ? 1 : 0;
                rectangle = new Rectangle(e.Bounds.X + num, e.Bounds.Y + 1, e.Bounds.Width - num, e.Bounds.Height - 2);
                if (this.lvJobFiles.Focused)
                {
                    gradientActiveCaption = SystemBrushes.GradientActiveCaption;
                }
                else
                {
                    gradientActiveCaption = SystemBrushes.GradientInactiveCaption;
                }
                e.Graphics.FillRectangle(gradientActiveCaption, rectangle);
            }
            if (e.SubItem.Name.Equals("BytesTotal"))
            {
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, prototype, e.Bounds, windowText, flags | TextFormatFlags.Right);
            }
            else if (e.SubItem.Name.Equals("BytesTransfered"))
            {
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, prototype, e.Bounds, windowText, flags | TextFormatFlags.Right);
            }
            else if (e.SubItem.Name == "Progress")
            {
                Rectangle rectangle2;
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                gradientActiveCaption = new SolidBrush(Settings.Default.ProgressLeftColor);
                rectangle = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
                e.Graphics.FillRectangle(gradientActiveCaption, rectangle);
                JobProgress progress = null;
                if (tag != null)
                {
                    FileProgress progress2 = null;
                    progress2 = tag.Progress;
                    rectangle2 = CalcProgress(e.Bounds, progress2.BytesTotal, progress2.BytesTransferred);
                    if (progress2.BytesTransferred > 0L)
                    {
                        if (progress2.Completed || (progress2.BytesTotal == progress2.BytesTransferred))
                        {
                            gradientActiveCaption = new SolidBrush(Settings.Default.ProgressCompletedColor);
                        }
                        else
                        {
                            gradientActiveCaption = new LinearGradientBrush(rectangle, Settings.Default.ProgressDoneColor, Settings.Default.ProgressCompletedColor, LinearGradientMode.Horizontal);
                        }
                    }
                    rectangle2 = Utils.CalculateProgress(rectangle, progress2.BytesTotal, progress2.BytesTransferred);
                }
                else
                {
                    progress = bitsJob.Progress;
                    rectangle2 = CalcProgress(e.Bounds, progress.BytesTotal, progress.BytesTransferred);
                    if (progress.BytesTransferred > 0L)
                    {
                        if ((bitsJob.State == JobState.Transferred) || (bitsJob.State == JobState.Acknowledged))
                        {
                            gradientActiveCaption = new SolidBrush(Settings.Default.ProgressCompletedColor);
                        }
                        else
                        {
                            gradientActiveCaption = new LinearGradientBrush(rectangle, Settings.Default.ProgressDoneColor, Settings.Default.ProgressCompletedColor, LinearGradientMode.Horizontal);
                        }
                    }
                    rectangle2 = Utils.CalculateProgress(rectangle, progress.BytesTotal, progress.BytesTransferred);
                }
                e.Graphics.FillRectangle(gradientActiveCaption, rectangle2);
                ControlPaint.DrawBorder(e.Graphics, rectangle, SystemColors.ActiveBorder, ButtonBorderStyle.Solid);
                windowText = SystemColors.InactiveCaptionText;
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, prototype, rectangle, windowText, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }
            else
            {
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, prototype, e.Bounds, windowText, flags);
            }
        }

        private void ShowAddFileDialog()
        {
            base.FindForm().Activate();
            if (base.wrapper.FileList != null)
            {
                switch (base.wrapper.FileList.Length)
                {
                    case 0:
                    case 1:
                        {
                            AddSimpleFile addFile = new AddSimpleFile();
                            addFile.InitControl(base.wrapper);
                            this.ShowFileDialog(addFile);
                            return;
                        }
                }
                MessageBox.Show(this, "Operation with multiple files are not supported currently. Please add only one file at a time for now!\r\nAlso note, due to restrictions in BITS, upload jobs will always only support one file per job.");
            }
        }

        private void ShowFileDialog(AddSimpleFile addFile)
        {
            if (addFile.ShowDialog(this).Equals(DialogResult.OK))
            {
                base.wrapper.BitsJob.AddFile(addFile.RemoteName, addFile.LocalName);
                base.wrapper.FileList = null;
                base.wrapper.DeleteLocalFile = addFile.DeleteLocalFile;
                this.UpdateControl();
            }
            else if (base.wrapper.BitsJob.Files.Count == 0)
            {
                base.FindForm().DialogResult = DialogResult.Abort;
            }
        }

        public override void UpdateControl()
        {
            if (base.wrapper.BitsJob != null)
            {
                this.lvJobFiles.BeginUpdate();
                this.lvJobFiles.Items.Clear();
                base.wrapper.BitsJob.EnumFiles();
                ListViewItem owner = new ListViewItem();
                owner.Text = base.wrapper.BitsJob.DisplayName;
                ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(owner, base.wrapper.BitsJob.State.ToString());
                item.Name = "LocalName";
                owner.SubItems.Add(item);
                item = new ListViewItem.ListViewSubItem(owner, Utils.Bytes2Size(base.wrapper.BitsJob.Progress.BytesTotal));
                item.Name = "BytesTotal";
                owner.SubItems.Add(item);
                item = new ListViewItem.ListViewSubItem(owner, Utils.Bytes2Size(base.wrapper.BitsJob.Progress.BytesTransferred));
                item.Name = "BytesTransfered";
                owner.SubItems.Add(item);
                item = new ListViewItem.ListViewSubItem(owner, string.Empty);
                item.Name = "Progress";
                owner.SubItems.Add(item);
                owner.Tag = null;
                owner.Group = this.lvJobFiles.Groups[0];
                owner.ToolTipText = "Doubleclick this entry to open the Add-File dialog";
                this.lvJobFiles.Items.Add(owner);
                foreach (BitsFile file in base.wrapper.BitsJob.Files)
                {
                    owner = new ListViewItem();
                    owner.Text = file.RemoteName;
                    item = new ListViewItem.ListViewSubItem(owner, file.LocalName);
                    item.Name = "LocalName";
                    owner.SubItems.Add(item);
                    item = new ListViewItem.ListViewSubItem(owner, Utils.Bytes2Size(file.Progress.BytesTotal));
                    item.Name = "BytesTotal";
                    owner.SubItems.Add(item);
                    item = new ListViewItem.ListViewSubItem(owner, Utils.Bytes2Size(file.Progress.BytesTransferred));
                    item.Name = "BytesTransfered";
                    owner.SubItems.Add(item);
                    item = new ListViewItem.ListViewSubItem(owner, string.Empty);
                    item.Name = "Progress";
                    owner.SubItems.Add(item);
                    owner.Tag = file;
                    if (base.wrapper.BitsJob.JobType == JobType.Download)
                    {
                        owner.Group = this.lvJobFiles.Groups[1];
                    }
                    else if (base.wrapper.BitsJob.JobType == JobType.Upload)
                    {
                        owner.Group = this.lvJobFiles.Groups[2];
                    }
                    this.lvJobFiles.Items.Add(owner);
                }
                this.lvJobFiles.EndUpdate();
            }
        }

        private void lvJobFiles_DoubleClick(object sender, EventArgs e)
        {
            this.AddFiles(base.wrapper.BitsJob.JobType);
        }
    }

}
