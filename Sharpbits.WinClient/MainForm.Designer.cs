
namespace SharpBits.WinClient
{
    partial class MainForm
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
                this.manager.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.systray = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMenuSystray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxSystrayShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxmiBrowserIntegration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxSystrayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBtnMenu = new System.Windows.Forms.ToolStripSplitButton();
            this.ctxStatusBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBrowserIntegration = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiMainExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusJobUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.ctxMainForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.jobListControl = new SharpBits.WinClient.JobListControl();
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.ctxMenuSystray.SuspendLayout();
            this.ctxStatusBar.SuspendLayout();
            this.statMainForm.SuspendLayout();
            this.ctxMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // systray
            // 
            this.systray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.systray.ContextMenuStrip = this.ctxMenuSystray;
            this.systray.Text = "SharpBITS";
            this.systray.Visible = true;
            this.systray.DoubleClick += new System.EventHandler(this.systray_DoubleClick);
            // 
            // ctxMenuSystray
            // 
            this.ctxMenuSystray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSystrayShow,
            this.toolStripMenuItem2,
            this.ctxmiBrowserIntegration,
            this.toolStripSeparator1,
            this.ctxSystrayExit});
            this.ctxMenuSystray.Name = "contextMenuStrip1";
            this.ctxMenuSystray.Size = new System.Drawing.Size(177, 82);
            // 
            // ctxSystrayShow
            // 
            this.ctxSystrayShow.Name = "ctxSystrayShow";
            this.ctxSystrayShow.Size = new System.Drawing.Size(176, 22);
            this.ctxSystrayShow.Text = "Show";
            this.ctxSystrayShow.ToolTipText = "Open the main form";
            this.ctxSystrayShow.Click += new System.EventHandler(this.ctxSystrayShow_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // ctxmiBrowserIntegration
            // 
            this.ctxmiBrowserIntegration.CheckOnClick = true;
            this.ctxmiBrowserIntegration.Name = "ctxmiBrowserIntegration";
            this.ctxmiBrowserIntegration.Size = new System.Drawing.Size(176, 22);
            this.ctxmiBrowserIntegration.Text = "Enable IE Integration";
            this.ctxmiBrowserIntegration.ToolTipText = "If enabled, SharpBITS integrates in IE Browser to start downloads from the contex" +
    "t menu";
            this.ctxmiBrowserIntegration.Click += new System.EventHandler(this.tsmiBrowserIntegration_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
            // 
            // ctxSystrayExit
            // 
            this.ctxSystrayExit.Name = "ctxSystrayExit";
            this.ctxSystrayExit.Size = new System.Drawing.Size(176, 22);
            this.ctxSystrayExit.Text = "Exit";
            // 
            // toolStripBtnMenu
            // 
            this.toolStripBtnMenu.AutoToolTip = false;
            this.toolStripBtnMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnMenu.DropDown = this.ctxStatusBar;
            this.toolStripBtnMenu.Image = global::SharpBits.WinClient.Properties.Resources.xidar;
            this.toolStripBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMenu.Name = "toolStripBtnMenu";
            this.toolStripBtnMenu.Size = new System.Drawing.Size(32, 20);
            this.toolStripBtnMenu.Text = "toolStripSplitMenu";
            this.toolStripBtnMenu.ButtonClick += new System.EventHandler(this.toolStripBtnMenu_ButtonClick);
            // 
            // ctxStatusBar
            // 
            this.ctxStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBrowserIntegration,
            this.toolStripSeparator2,
            this.toolStripMenuItem3});
            this.ctxStatusBar.Name = "ctxStatusBar";
            this.ctxStatusBar.OwnerItem = this.toolStripBtnMenu;
            this.ctxStatusBar.Size = new System.Drawing.Size(177, 54);
            // 
            // tsmiBrowserIntegration
            // 
            this.tsmiBrowserIntegration.CheckOnClick = true;
            this.tsmiBrowserIntegration.Name = "tsmiBrowserIntegration";
            this.tsmiBrowserIntegration.Size = new System.Drawing.Size(176, 22);
            this.tsmiBrowserIntegration.Text = "Enable IE Integration";
            this.tsmiBrowserIntegration.ToolTipText = "If enabled, SharpBITS integrates in IE Browser to start downloads from the contex" +
    "t menu";
            this.tsmiBrowserIntegration.Click += new System.EventHandler(this.tsmiBrowserIntegration_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem3.Text = "Exit";
            this.toolStripMenuItem3.ToolTipText = "Exit";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ctxmiMainExit_Click);
            // 
            // ctxmiMainExit
            // 
            this.ctxmiMainExit.Name = "ctxmiMainExit";
            this.ctxmiMainExit.ShortcutKeyDisplayString = "";
            this.ctxmiMainExit.Size = new System.Drawing.Size(92, 22);
            this.ctxmiMainExit.Text = "Exit";
            this.ctxmiMainExit.ToolTipText = "Exit";
            this.ctxmiMainExit.Click += new System.EventHandler(this.ctxmiMainExit_Click);
            // 
            // statMainForm
            // 
            this.statMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusJobUser,
            this.toolStripStatusLabel2,
            this.toolStripBtnMenu});
            this.statMainForm.Location = new System.Drawing.Point(0, 377);
            this.statMainForm.Name = "statMainForm";
            this.statMainForm.ShowItemToolTips = true;
            this.statMainForm.Size = new System.Drawing.Size(692, 22);
            this.statMainForm.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(624, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusJobUser
            // 
            this.toolStripStatusJobUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusJobUser.Image = global::SharpBits.WinClient.Properties.Resources.AllUsers;
            this.toolStripStatusJobUser.Name = "toolStripStatusJobUser";
            this.toolStripStatusJobUser.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusJobUser.Text = "toolStripStatusJobUser";
            this.toolStripStatusJobUser.Click += new System.EventHandler(this.toolStripStatusJobUser_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(5, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // statLabelMessage
            // 
            this.statLabelMessage.AutoSize = false;
            this.statLabelMessage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statLabelMessage.Name = "statLabelMessage";
            this.statLabelMessage.Size = new System.Drawing.Size(200, 17);
            this.statLabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMessages
            // 
            this.txtMessages.ContextMenuStrip = this.ctxMainForm;
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Location = new System.Drawing.Point(0, 0);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessages.Size = new System.Drawing.Size(692, 90);
            this.txtMessages.TabIndex = 2;
            this.txtMessages.DoubleClick += new System.EventHandler(this.txtMessages_DoubleClick);
            this.txtMessages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessages_KeyDown);
            // 
            // ctxMainForm
            // 
            this.ctxMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmiMainExit});
            this.ctxMainForm.Name = "ctxMainForm";
            this.ctxMainForm.Size = new System.Drawing.Size(93, 26);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panel1);
            this.splitContainer.Panel1.Controls.Add(this.jobListControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txtMessages);
            this.splitContainer.Size = new System.Drawing.Size(692, 377);
            this.splitContainer.SplitterDistance = 283;
            this.splitContainer.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUrl);
            this.panel1.Controls.Add(this.btnAddUrl);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 25);
            this.panel1.TabIndex = 1;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(9, 7);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(41, 13);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "Url/File";
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUrl.Enabled = false;
            this.btnAddUrl.Location = new System.Drawing.Point(605, 2);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(75, 23);
            this.btnAddUrl.TabIndex = 1;
            this.btnAddUrl.Text = "Add";
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(56, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(543, 20);
            this.txtUrl.TabIndex = 0;
            this.toolTipControl.SetToolTip(this.txtUrl, "Enter a local file url to create an upload job, \r\nor a remote http(s) url to crea" +
        "te a new download job.");
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // jobListControl
            // 
            this.jobListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobListControl.Location = new System.Drawing.Point(0, 0);
            this.jobListControl.Name = "jobListControl";
            this.jobListControl.Size = new System.Drawing.Size(692, 283);
            this.jobListControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAddUrl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 399);
            this.ContextMenuStrip = this.ctxMainForm;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SharpBITS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ctxMenuSystray.ResumeLayout(false);
            this.ctxStatusBar.ResumeLayout(false);
            this.statMainForm.ResumeLayout(false);
            this.statMainForm.PerformLayout();
            this.ctxMainForm.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}
