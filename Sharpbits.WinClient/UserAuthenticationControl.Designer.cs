using System.Windows.Forms;

namespace SharpBits.WinClient
{
    partial class UserAuthenticationControl
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
            this.gbAuthScheme = new System.Windows.Forms.GroupBox();
            this.rbAuthSchemePassport = new System.Windows.Forms.RadioButton();
            this.rbAuthSchemeNegotiate = new System.Windows.Forms.RadioButton();
            this.rbAuthSchemeNtlm = new System.Windows.Forms.RadioButton();
            this.rbAuthSchemeDigest = new System.Windows.Forms.RadioButton();
            this.rbAuthSchemeBasic = new System.Windows.Forms.RadioButton();
            this.gbAuthTarget = new System.Windows.Forms.GroupBox();
            this.rbAuthTargetServer = new System.Windows.Forms.RadioButton();
            this.rbAuthTargetProxy = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lvCredentials = new System.Windows.Forms.ListView();
            this.clhAuthTarget = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAuthScheme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAuthUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCredentials = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbAuthScheme.SuspendLayout();
            this.gbAuthTarget.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAuthScheme
            // 
            this.gbAuthScheme.Controls.Add(this.rbAuthSchemePassport);
            this.gbAuthScheme.Controls.Add(this.rbAuthSchemeNegotiate);
            this.gbAuthScheme.Controls.Add(this.rbAuthSchemeNtlm);
            this.gbAuthScheme.Controls.Add(this.rbAuthSchemeDigest);
            this.gbAuthScheme.Controls.Add(this.rbAuthSchemeBasic);
            this.gbAuthScheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAuthScheme.Location = new System.Drawing.Point(254, 3);
            this.gbAuthScheme.Name = "gbAuthScheme";
            this.gbAuthScheme.Size = new System.Drawing.Size(249, 136);
            this.gbAuthScheme.TabIndex = 17;
            this.gbAuthScheme.TabStop = false;
            this.gbAuthScheme.Text = "Authentication Scheme";
            // 
            // rbAuthSchemePassport
            // 
            this.rbAuthSchemePassport.AutoSize = true;
            this.rbAuthSchemePassport.Location = new System.Drawing.Point(20, 111);
            this.rbAuthSchemePassport.Name = "rbAuthSchemePassport";
            this.rbAuthSchemePassport.Size = new System.Drawing.Size(66, 17);
            this.rbAuthSchemePassport.TabIndex = 4;
            this.rbAuthSchemePassport.Text = "Passport";
            this.rbAuthSchemePassport.UseVisualStyleBackColor = true;
            this.rbAuthSchemePassport.Click += new System.EventHandler(this.CheckAddAllowed);
            // 
            // rbAuthSchemeNegotiate
            // 
            this.rbAuthSchemeNegotiate.AutoSize = true;
            this.rbAuthSchemeNegotiate.Location = new System.Drawing.Point(20, 88);
            this.rbAuthSchemeNegotiate.Name = "rbAuthSchemeNegotiate";
            this.rbAuthSchemeNegotiate.Size = new System.Drawing.Size(71, 17);
            this.rbAuthSchemeNegotiate.TabIndex = 3;
            this.rbAuthSchemeNegotiate.Text = "Negotiate";
            this.rbAuthSchemeNegotiate.UseVisualStyleBackColor = true;
            this.rbAuthSchemeNegotiate.Click += new System.EventHandler(this.CheckAddAllowed);
            // 
            // rbAuthSchemeNtlm
            // 
            this.rbAuthSchemeNtlm.AutoSize = true;
            this.rbAuthSchemeNtlm.Checked = true;
            this.rbAuthSchemeNtlm.Location = new System.Drawing.Point(20, 65);
            this.rbAuthSchemeNtlm.Name = "rbAuthSchemeNtlm";
            this.rbAuthSchemeNtlm.Size = new System.Drawing.Size(55, 17);
            this.rbAuthSchemeNtlm.TabIndex = 2;
            this.rbAuthSchemeNtlm.TabStop = true;
            this.rbAuthSchemeNtlm.Text = "NTLM";
            this.rbAuthSchemeNtlm.UseVisualStyleBackColor = true;
            this.rbAuthSchemeNtlm.Click += new System.EventHandler(this.CheckAddAllowed);
            // 
            // rbAuthSchemeDigest
            // 
            this.rbAuthSchemeDigest.AutoSize = true;
            this.rbAuthSchemeDigest.Location = new System.Drawing.Point(20, 42);
            this.rbAuthSchemeDigest.Name = "rbAuthSchemeDigest";
            this.rbAuthSchemeDigest.Size = new System.Drawing.Size(55, 17);
            this.rbAuthSchemeDigest.TabIndex = 1;
            this.rbAuthSchemeDigest.Text = "Digest";
            this.rbAuthSchemeDigest.UseVisualStyleBackColor = true;
            this.rbAuthSchemeDigest.Click += new System.EventHandler(this.CheckAddAllowed);
            // 
            // rbAuthSchemeBasic
            // 
            this.rbAuthSchemeBasic.AutoSize = true;
            this.rbAuthSchemeBasic.Location = new System.Drawing.Point(20, 19);
            this.rbAuthSchemeBasic.Name = "rbAuthSchemeBasic";
            this.rbAuthSchemeBasic.Size = new System.Drawing.Size(51, 17);
            this.rbAuthSchemeBasic.TabIndex = 0;
            this.rbAuthSchemeBasic.Text = "Basic";
            this.rbAuthSchemeBasic.UseVisualStyleBackColor = true;
            this.rbAuthSchemeBasic.Click += new System.EventHandler(this.CheckAddAllowed);
            // 
            // gbAuthTarget
            // 
            this.gbAuthTarget.Controls.Add(this.rbAuthTargetServer);
            this.gbAuthTarget.Controls.Add(this.rbAuthTargetProxy);
            this.gbAuthTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAuthTarget.Location = new System.Drawing.Point(3, 3);
            this.gbAuthTarget.Name = "gbAuthTarget";
            this.gbAuthTarget.Size = new System.Drawing.Size(245, 136);
            this.gbAuthTarget.TabIndex = 16;
            this.gbAuthTarget.TabStop = false;
            this.gbAuthTarget.Text = "Authentication Target";
            // 
            // rbAuthTargetServer
            // 
            this.rbAuthTargetServer.AutoSize = true;
            this.rbAuthTargetServer.Checked = true;
            this.rbAuthTargetServer.Location = new System.Drawing.Point(20, 19);
            this.rbAuthTargetServer.Name = "rbAuthTargetServer";
            this.rbAuthTargetServer.Size = new System.Drawing.Size(56, 17);
            this.rbAuthTargetServer.TabIndex = 6;
            this.rbAuthTargetServer.TabStop = true;
            this.rbAuthTargetServer.Text = "Server";
            this.rbAuthTargetServer.UseVisualStyleBackColor = true;
            this.rbAuthTargetServer.Click += new System.EventHandler(this.CheckAddAllowed);
            // 
            // rbAuthTargetProxy
            // 
            this.rbAuthTargetProxy.AutoSize = true;
            this.rbAuthTargetProxy.Location = new System.Drawing.Point(20, 42);
            this.rbAuthTargetProxy.Name = "rbAuthTargetProxy";
            this.rbAuthTargetProxy.Size = new System.Drawing.Size(51, 17);
            this.rbAuthTargetProxy.TabIndex = 7;
            this.rbAuthTargetProxy.Text = "Proxy";
            this.rbAuthTargetProxy.UseVisualStyleBackColor = true;
            this.rbAuthTargetProxy.Click += new System.EventHandler(this.CheckAddAllowed);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "User Name";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Location = new System.Drawing.Point(216, 16);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(207, 20);
            this.tbPassword.TabIndex = 13;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.CheckAddAllowed);
            this.tbPassword.Leave += new System.EventHandler(this.CheckAddAllowed);
            // 
            // tbUserName
            // 
            this.tbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserName.Location = new System.Drawing.Point(3, 16);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(207, 20);
            this.tbUserName.TabIndex = 12;
            this.tbUserName.TextChanged += new System.EventHandler(this.CheckAddAllowed);
            this.tbUserName.Leave += new System.EventHandler(this.CheckAddAllowed);
            // 
            // lvCredentials
            // 
            this.lvCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCredentials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhAuthTarget,
            this.clhAuthScheme,
            this.clhAuthUser});
            this.lvCredentials.FullRowSelect = true;
            this.lvCredentials.Location = new System.Drawing.Point(15, 197);
            this.lvCredentials.Name = "lvCredentials";
            this.lvCredentials.Size = new System.Drawing.Size(506, 85);
            this.lvCredentials.TabIndex = 10;
            this.lvCredentials.UseCompatibleStateImageBehavior = false;
            this.lvCredentials.View = System.Windows.Forms.View.Details;
            this.lvCredentials.DoubleClick += new System.EventHandler(this.lvCredentials_DoubleClick);
            // 
            // clhAuthTarget
            // 
            this.clhAuthTarget.Text = "Target";
            this.clhAuthTarget.Width = 100;
            // 
            // clhAuthScheme
            // 
            this.clhAuthScheme.Text = "Schema";
            this.clhAuthScheme.Width = 100;
            // 
            // clhAuthUser
            // 
            this.clhAuthUser.Text = "User";
            this.clhAuthUser.Width = 200;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.69072F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.30928F));
            this.tableLayoutPanel1.Controls.Add(this.gbAuthTarget, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbAuthScheme, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(506, 142);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // btnAddCredentials
            // 
            this.btnAddCredentials.Location = new System.Drawing.Point(429, 16);
            this.btnAddCredentials.Name = "btnAddCredentials";
            this.btnAddCredentials.Size = new System.Drawing.Size(74, 23);
            this.btnAddCredentials.TabIndex = 20;
            this.btnAddCredentials.Text = "Add";
            this.toolTip.SetToolTip(this.btnAddCredentials, "Adds the current credentials to the list");
            this.btnAddCredentials.UseVisualStyleBackColor = true;
            this.btnAddCredentials.Click += new System.EventHandler(this.btnAddCredentials_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddCredentials, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbUserName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbPassword, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(506, 46);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // UserAuthenticationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lvCredentials);
            this.Name = "UserAuthenticationControl";
            this.Size = new System.Drawing.Size(550, 300);
            this.gbAuthScheme.ResumeLayout(false);
            this.gbAuthScheme.PerformLayout();
            this.gbAuthTarget.ResumeLayout(false);
            this.gbAuthTarget.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolTip toolTip;

    }
}
