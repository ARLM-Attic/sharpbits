using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SharpBits.Base;
using SharpBits.WinClient.Controls;
using SharpBits.WinClient.Properties;
using System.ComponentModel;
using System.Drawing;

namespace SharpBits.WinClient
{
    public partial class AddSimpleFile : AddFilesDialog
    {
        // Fields
        private Button btnCancel;
        private Button btnLocalFile;
        private Button btnOk;
        private CheckBox chkDeleteLocalFile;
        private string fileName;
        private JobType jobType;
        private Label label1;
        private Label label2;
        private ErrorProvider requiredFieldsValidation;
        private TextBox tbLocalName;
        private bool tbLocalUpdated;
        private TextBox tbRemoteName;
        private bool tbRemoteUpdated;

        // Methods
        public AddSimpleFile()
        {
            this.InitializeComponent();
            this.tbLocalName.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
            this.tbLocalName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.tbRemoteName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.tbRemoteName.AutoCompleteCustomSource = base.remotePaths;
            this.tbRemoteName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void AddSimpleFile_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            switch (e.KeyCode)
            {
                case Keys.Return:
                    e.SuppressKeyPress = true;
                    this.btnOk_Click(sender, e);
                    return;

                case Keys.Escape:
                    e.SuppressKeyPress = true;
                    this.btnCancel_Click(sender, e);
                    return;
            }
            e.Handled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void btnLocalFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog;
            switch (this.jobType)
            {
                case JobType.Download:
                    {
                        FolderBrowserDialog dialog2 = new FolderBrowserDialog();
                        dialog2.Description = "Select Folder";
                        dialog2.ShowNewFolderButton = true;
                        if (dialog2.ShowDialog().Equals(DialogResult.OK))
                        {
                            if (this.fileName == null)
                            {
                                this.tbLocalName.Text = dialog2.SelectedPath + Path.DirectorySeparatorChar;
                                return;
                            }
                            this.tbLocalName.Text = Path.Combine(dialog2.SelectedPath, this.fileName);
                        }
                        return;
                    }
                case JobType.Upload:
                    dialog = new OpenFileDialog();
                    dialog.CheckFileExists = true;
                    dialog.Filter = "All files (*.*)|*.*";
                    if (this.tbLocalName.Text.Length <= 0)
                    {
                        dialog.InitialDirectory = Settings.Default.DownloadDir0;
                        break;
                    }
                    dialog.InitialDirectory = Path.GetFullPath(this.tbLocalName.Text);
                    break;

                default:
                    return;
            }
            dialog.Multiselect = false;
            dialog.RestoreDirectory = true;
            dialog.SupportMultiDottedExtensions = true;
            dialog.Title = "Select File";
            if (dialog.ShowDialog().Equals(DialogResult.OK))
            {
                this.tbLocalName.Text = dialog.FileName;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Visible))
            {
                Uri uri;
                if (Uri.TryCreate(this.tbLocalName.Text, UriKind.Absolute, out uri))
                {
                    Settings.Default.DownloadDir0 = PathFromUri(uri).ToString();
                }
                if (Uri.TryCreate(this.tbRemoteName.Text, UriKind.Absolute, out uri))
                {
                    Settings.Default.UploadDir0 = PathFromUri(uri).ToString();
                }
                Settings.Default.Save();
                base.DialogResult = DialogResult.OK;
                base.Close();
            }
        }

        public override void InitControl(JobWrapper wrapper)
        {
            base.InitControl(wrapper);
            this.jobType = wrapper.BitsJob.JobType;
            this.chkDeleteLocalFile.Visible = this.jobType == JobType.Upload;
            if ((wrapper.FileList != null) && (wrapper.FileList.Length == 1))
            {
                Uri uri;
                string path = wrapper.FileList[0];
                if (Uri.TryCreate(Settings.Default.DownloadDir0, UriKind.Absolute, out uri))
                {
                    this.tbLocalName.Text = uri.LocalPath;
                }
                if (Uri.TryCreate(Settings.Default.UploadDir0, UriKind.Absolute, out uri))
                {
                    this.tbRemoteName.Text = uri.ToString();
                }
                switch (this.jobType)
                {
                    case JobType.Download:
                        this.tbRemoteName.Text = path;
                        if (Uri.TryCreate(Settings.Default.DownloadDir0, UriKind.Absolute, out uri))
                        {
                            uri = PathFromUri(uri, Path.GetFileName(path));
                            this.tbLocalName.Text = uri.LocalPath;
                        }
                        return;

                    case JobType.Upload:
                        this.tbLocalName.Text = path;
                        if (Uri.TryCreate(Settings.Default.UploadDir0, UriKind.Absolute, out uri))
                        {
                            this.tbRemoteName.Text = PathFromUri(uri, Path.GetFileName(path)).ToString();
                        }
                        return;

                    default:
                        return;
                }
            }
        }

        private static Uri PathFromUri(Uri uri)
        {
            return PathFromUri(uri, null);
        }

        private static Uri PathFromUri(Uri uri, string fileName)
        {
            StringBuilder builder2 = new StringBuilder();
            UriBuilder builder = new UriBuilder(uri);
            foreach (string str in uri.Segments)
            {
                if (!str.EndsWith("/", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                builder2.Append(str);
            }
            if (!string.IsNullOrEmpty(fileName))
            {
                builder2.Append(fileName);
            }
            builder.Path = builder2.ToString();
            return builder.Uri;
        }

        private void tbLocalName_TextChanged(object sender, EventArgs e)
        {
            Uri uri;
            this.tbLocalUpdated = false;
            if (!this.tbRemoteUpdated && Uri.TryCreate(this.tbRemoteName.Text, UriKind.Absolute, out uri))
            {
                this.fileName = Path.GetFileName(uri.ToString());
                this.tbRemoteUpdated = true;
            }
            string text = this.tbLocalName.Text;
            if (!string.IsNullOrEmpty(this.fileName) && (text.EndsWith("/", StringComparison.OrdinalIgnoreCase) || 
                text.EndsWith(@"\", StringComparison.OrdinalIgnoreCase)))
            {
                this.tbLocalName.Text = this.tbLocalName.Text + this.fileName;
                this.tbLocalName.SelectionStart = text.Length;
                this.tbLocalName.SelectionLength = this.fileName.Length;
            }
        }

        private void tbLocalName_Validating(object sender, CancelEventArgs e)
        {
            Uri uri;
            bool flag = Uri.TryCreate(this.tbLocalName.Text, UriKind.Absolute, out uri);
            if ((this.tbLocalName.Text.Length == 0) || !flag)
            {
                this.requiredFieldsValidation.SetError(this.tbLocalName, "A valid url must be provided prior to continue!");
                e.Cancel = true;
            }
            else if ((!(uri.Scheme == "file") && !(uri.Scheme == "http")) && !(uri.Scheme == "https"))
            {
                this.requiredFieldsValidation.SetError(this.tbLocalName, "A valid url must be provided! Url must start with file://, http:// or https://");
                e.Cancel = true;
            }
        }

        private void tbRemoteName_TextChanged(object sender, EventArgs e)
        {
            Uri uri;
            this.tbRemoteUpdated = false;
            if (!this.tbLocalUpdated && Uri.TryCreate(this.tbLocalName.Text, UriKind.Absolute, out uri))
            {
                this.fileName = Uri.EscapeUriString(Path.GetFileName(uri.ToString()));
                this.tbLocalUpdated = true;
            }
            string text = this.tbRemoteName.Text;
            if (!string.IsNullOrEmpty(this.fileName) && (text.EndsWith("/", StringComparison.OrdinalIgnoreCase) || 
                text.EndsWith(@"\", StringComparison.OrdinalIgnoreCase)))
            {
                this.tbRemoteName.Text = this.tbRemoteName.Text + this.fileName;
                this.tbRemoteName.SelectionStart = text.Length;
                this.tbRemoteName.SelectionLength = this.fileName.Length;
            }
        }

        private void tbRemoteName_Validating(object sender, CancelEventArgs e)
        {
            Uri uri;
            bool flag = Uri.TryCreate(this.tbRemoteName.Text, UriKind.Absolute, out uri);
            if ((this.tbRemoteName.Text.Length == 0) || !flag)
            {
                this.requiredFieldsValidation.SetError(this.tbRemoteName, "A valid url must be provided prior to continue!");
                e.Cancel = true;
            }
            else if ((!(uri.Scheme == "file") && !(uri.Scheme == "http")) && !(uri.Scheme == "https"))
            {
                this.requiredFieldsValidation.SetError(this.tbRemoteName, "A valid url must be provided! Url must start with file://, http:// or https://");
                e.Cancel = true;
            }
        }

        // Properties
        public bool CleanupOnUpload
        {
            get
            {
                return this.chkDeleteLocalFile.Checked;
            }
        }

        public bool DeleteLocalFile
        {
            get
            {
                return this.chkDeleteLocalFile.Checked;
            }
        }

        public string LocalName
        {
            get
            {
                return this.tbLocalName.Text;
            }
        }

        public string RemoteName
        {
            get
            {
                return this.tbRemoteName.Text;
            }
        }
    }


}
