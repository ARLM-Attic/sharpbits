using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpBits.WinClient.Controls;
using System.Windows.Forms;
using System.ComponentModel;
using SharpBits.WinClient.Properties;
using SharpBits.Base;
using System.Drawing;

namespace SharpBits.WinClient
{
    public partial class UserAuthenticationControl : JobControl
    {
        // Fields
        private Button btnAddCredentials;
        private ColumnHeader clhAuthScheme;
        private ColumnHeader clhAuthTarget;
        private ColumnHeader clhAuthUser;
        private GroupBox gbAuthScheme;
        private GroupBox gbAuthTarget;
        private Label label11;
        private Label label12;
        private ListView lvCredentials;
        private CredentialsUpdated onCredentialsAdded;
        private CredentialsUpdated onCredentialsRemoved;
        private RadioButton rbAuthSchemeBasic;
        private RadioButton rbAuthSchemeDigest;
        private RadioButton rbAuthSchemeNegotiate;
        private RadioButton rbAuthSchemeNtlm;
        private RadioButton rbAuthSchemePassport;
        private RadioButton rbAuthTargetProxy;
        private RadioButton rbAuthTargetServer;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbPassword;
        private TextBox tbUserName;

        // Events
        public event CredentialsUpdated OnCredentialsAdded
        {
            add
            {
                this.onCredentialsAdded = (CredentialsUpdated)Delegate.Combine(this.onCredentialsAdded, value);
            }
            remove
            {
                this.onCredentialsAdded = (CredentialsUpdated)Delegate.Remove(this.onCredentialsAdded, value);
            }
        }

        public event CredentialsUpdated OnCredentialsRemoved
        {
            add
            {
                this.onCredentialsRemoved = (CredentialsUpdated)Delegate.Combine(this.onCredentialsRemoved, value);
            }
            remove
            {
                this.onCredentialsRemoved = (CredentialsUpdated)Delegate.Remove(this.onCredentialsRemoved, value);
            }
        }

        // Methods
        public UserAuthenticationControl()
        {
            this.InitializeComponent();
            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();
            if (Settings.Default.UserNames != null)
            {
                strings.AddRange(Settings.Default.UserNames.Trim(new char[] { ';' }).Split(new char[] { ';' }));
            }
            this.tbUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.tbUserName.AutoCompleteCustomSource = strings;
            this.tbUserName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.btnAddCredentials.Enabled = false;
            if (Settings.Default.CredentialsCache == null)
            {
                Settings.Default.CredentialsCache = new CredentialsCache();
            }
        }

        private void CheckAddAllowed(object sender, EventArgs e)
        {
            this.btnAddCredentials.Enabled = false;
            if ((this.tbPassword.Text.Length != 0) && (this.tbUserName.Text.Length != 0))
            {
                CredentialsCacheItem item = this.CredentialsCacheItemFromUIValues();
                foreach (CredentialsCacheItem item2 in Settings.Default.CredentialsCache)
                {
                    if (item.Equals(item2))
                    {
                        return;
                    }
                }
                this.btnAddCredentials.Enabled = true;
            }
        }

        private CredentialsCacheItem CredentialsCacheItemFromUIValues()
        {
            AuthenticationScheme basic;
            AuthenticationTarget proxy;
            if (this.rbAuthTargetProxy.Checked)
            {
                proxy = AuthenticationTarget.Proxy;
            }
            else
            {
                if (!this.rbAuthTargetServer.Checked)
                {
                    throw new ApplicationException("No authentication target selected");
                }
                proxy = AuthenticationTarget.Server;
            }
            if (this.rbAuthSchemeBasic.Checked)
            {
                basic = AuthenticationScheme.Basic;
            }
            else if (this.rbAuthSchemeDigest.Checked)
            {
                basic = AuthenticationScheme.Digest;
            }
            else if (this.rbAuthSchemeNegotiate.Checked)
            {
                basic = AuthenticationScheme.Negotiate;
            }
            else if (this.rbAuthSchemeNtlm.Checked)
            {
                basic = AuthenticationScheme.Ntlm;
            }
            else
            {
                if (!this.rbAuthSchemePassport.Checked)
                {
                    throw new ApplicationException("No authentication scheme selected");
                }
                basic = AuthenticationScheme.Passport;
            }
            return new CredentialsCacheItem(basic, proxy, this.tbUserName.Text, base.wrapper.BitsJob.JobId);
        }

        public override void InitControl(JobWrapper wrapper)
        {
            base.InitControl(wrapper);
            base.FindForm().AcceptButton = this.btnAddCredentials;
        }

        private void lvCredentials_DoubleClick(object sender, EventArgs e)
        {
            while (this.lvCredentials.SelectedItems.Count > 0)
            {
                ListViewItem item = this.lvCredentials.SelectedItems[0];
                CredentialsCacheItem tag = item.Tag as CredentialsCacheItem;
                if (tag != null)
                {
                    base.wrapper.BitsJob.RemoveCredentials(tag.BitsCredentials);
                    if (this.onCredentialsRemoved != null)
                    {
                        this.onCredentialsRemoved(this, tag.BitsCredentials);
                    }
                    for (int i = 0; i < Settings.Default.CredentialsCache.Count; i++)
                    {
                        CredentialsCacheItem item3 = Settings.Default.CredentialsCache[i];
                        if (item3.Equals(tag))
                        {
                            Settings.Default.CredentialsCache.RemoveAt(i);
                        }
                    }
                }
                this.lvCredentials.Items.Remove(item);
            }
            Settings.Default.Save();
            this.UpdateCredentialsListview();
        }

        public override void UpdateControl()
        {
            this.UpdateCredentialsListview();
        }

        private void UpdateCredentialsListview()
        {
            this.lvCredentials.BeginUpdate();
            this.lvCredentials.Items.Clear();
            foreach (CredentialsCacheItem item in Settings.Default.CredentialsCache)
            {
                if (item.JobId == base.wrapper.BitsJob.JobId)
                {
                    ListViewItem item2 = this.lvCredentials.Items.Add(item.AuthenticationTarget.ToString());
                    item2.SubItems.Add(item.AuthenticationScheme.ToString());
                    item2.SubItems.Add(item.UserName);
                    item2.Tag = item;
                }
            }
            this.lvCredentials.EndUpdate();
        }

        private void btnAddCredentials_Click(object sender, EventArgs e)
        {
            BitsCredentials credentials = new BitsCredentials();
            CredentialsCacheItem item = this.CredentialsCacheItemFromUIValues();
            credentials.UserName = this.tbUserName.Text;
            credentials.Password = this.tbPassword.Text;
            credentials.AuthenticationTarget = item.AuthenticationTarget;
            credentials.AuthenticationScheme = item.AuthenticationScheme;
            base.wrapper.BitsJob.AddCredentials(credentials);
            if (this.onCredentialsAdded != null)
            {
                this.onCredentialsAdded(this, credentials);
            }
            Settings.Default.CredentialsCache.Add(item);
            StringBuilder builder = new StringBuilder();
            builder.Append(this.tbUserName.Text + ";");
            foreach (string str in this.tbUserName.AutoCompleteCustomSource)
            {
                builder.Append(str + ";");
            }
            Settings.Default.UserNames = builder.ToString();
            Settings.Default.Save();
            this.UpdateCredentialsListview();
            this.btnAddCredentials.Enabled = false;
            this.tbPassword.Clear();
        }
    }

}
