using System.Text;
using System.Windows.Forms;

using SharpBits.WinClient.Properties;

namespace SharpBits.WinClient.Controls
{
    public partial class AddFilesDialog : Form
    {
        // Fields
        protected bool initialized;
        protected AutoCompleteStringCollection localPaths;
        protected AutoCompleteStringCollection remotePaths;
        protected JobWrapper wrapper;

        // Methods
        public AddFilesDialog()
        {
            this.InitializeComponent();
            this.localPaths = new AutoCompleteStringCollection();
            if (Settings.Default.LocalPaths != null)
            {
                this.localPaths.AddRange(Settings.Default.LocalPaths.Trim(new char[] { '|' }).Split(new char[] { '|' }));
            }
            this.remotePaths = new AutoCompleteStringCollection();
            if (Settings.Default.RemotePaths != null)
            {
                this.remotePaths.AddRange(Settings.Default.RemotePaths.Trim(new char[] { '|' }).Split(new char[] { '|' }));
            }
            base.FormClosing += new FormClosingEventHandler(this.AddFilesDialog_FormClosing);
        }

        private void AddFilesDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string str in this.localPaths)
            {
                if (str.Trim().Length > 0)
                {
                    builder.Append(str.Trim() + "|");
                }
            }
            Settings.Default.LocalPaths = builder.ToString();
            builder = new StringBuilder();
            foreach (string str2 in this.remotePaths)
            {
                if (str2.Trim().Length > 0)
                {
                    builder.Append(str2.Trim() + "|");
                }
            }
            Settings.Default.RemotePaths = builder.ToString();
            Settings.Default.Save();
        }

        public virtual void InitControl(JobWrapper wrapper)
        {
            this.wrapper = wrapper;
            this.initialized = true;
        }
    }
}
