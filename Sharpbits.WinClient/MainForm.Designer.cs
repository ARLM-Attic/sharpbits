using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using SharpBits.WinClient.Properties;
using Crad.Windows.Forms.Actions;
using System.ComponentModel;

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
            components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.systray = new NotifyIcon(this.components);
            this.ctxMenuSystray = new ContextMenuStrip(this.components);
            this.ctxSystrayShow = new ToolStripMenuItem();
            this.toolStripMenuItem2 = new ToolStripSeparator();
            this.toolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.ctxSystrayExit = new ToolStripMenuItem();
            this.toolStripBtnMenu = new ToolStripSplitButton();
            this.ctxStatusBar = new ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new ToolStripMenuItem();
            this.toolStripSeparator2 = new ToolStripSeparator();
            this.toolStripMenuItem3 = new ToolStripMenuItem();
            this.actlMain = new ActionList();
            this.actShowForm = new Crad.Windows.Forms.Actions.Action();
            this.actSetBrowserIntegration = new Crad.Windows.Forms.Actions.Action();
            this.actExit = new Crad.Windows.Forms.Actions.Action();
            this.actHideForm = new Crad.Windows.Forms.Actions.Action();
            this.actClearMessages = new Crad.Windows.Forms.Actions.Action();
            this.ctxmiMainExit = new ToolStripMenuItem();
            this.statMainForm = new StatusStrip();
            this.toolStripStatusLabel1 = new ToolStripStatusLabel();
            this.toolStripStatusJobUser = new ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new ToolStripStatusLabel();
            this.statLabelMessage = new ToolStripStatusLabel();
            this.txtMessages = new TextBox();
            this.ctxMainForm = new ContextMenuStrip(this.components);
            this.splitContainer = new SplitContainer();
            this.panel1 = new Panel();
            this.lblUrl = new Label();
            this.btnAddUrl = new Button();
            this.txtUrl = new TextBox();
            this.toolTipControl = new ToolTip(this.components);
            this.jobListControl = new JobListControl();
            this.ctxMenuSystray.SuspendLayout();
            this.ctxStatusBar.SuspendLayout();
            this.actlMain.BeginInit();
            this.statMainForm.SuspendLayout();
            this.ctxMainForm.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.systray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.systray.ContextMenuStrip = this.ctxMenuSystray;
            this.systray.Icon = (Icon)manager.GetObject("systray.Icon");
            this.systray.Text = "SharpBITS";
            this.systray.Visible = true;
            this.systray.DoubleClick += new EventHandler(this.systray_DoubleClick);
            this.ctxMenuSystray.Items.AddRange(new ToolStripItem[] { this.ctxSystrayShow, this.toolStripMenuItem2, this.toolStripMenuItem1, this.toolStripSeparator1, this.ctxSystrayExit });
            this.ctxMenuSystray.Name = "contextMenuStrip1";
            this.ctxMenuSystray.Size = new Size(0xbc, 0x52);
            this.actlMain.SetAction(this.ctxSystrayShow, this.actShowForm);
            this.ctxSystrayShow.Name = "ctxSystrayShow";
            this.ctxSystrayShow.Size = new Size(0xbb, 0x16);
            this.ctxSystrayShow.Text = "Show";
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new Size(0xb8, 6);
            this.actlMain.SetAction(this.toolStripMenuItem1, this.actSetBrowserIntegration);
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(0xbb, 0x16);
            this.toolStripMenuItem1.Text = "Enable IE Integration";
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(0xb8, 6);
            this.actlMain.SetAction(this.ctxSystrayExit, this.actExit);
            this.ctxSystrayExit.Name = "ctxSystrayExit";
            this.ctxSystrayExit.Size = new Size(0xbb, 0x16);
            this.ctxSystrayExit.Text = "Exit";
            this.toolStripBtnMenu.AutoToolTip = false;
            this.toolStripBtnMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnMenu.DropDown = this.ctxStatusBar;
            this.toolStripBtnMenu.Image = Resources.xidar;
            this.toolStripBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMenu.Name = "toolStripBtnMenu";
            this.toolStripBtnMenu.Size = new Size(0x20, 20);
            this.toolStripBtnMenu.Text = "toolStripSplitMenu";
            this.toolStripBtnMenu.ButtonClick += new EventHandler(this.toolStripBtnMenu_ButtonClick);
            this.ctxStatusBar.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItem4, this.toolStripSeparator2, this.toolStripMenuItem3 });
            this.ctxStatusBar.Name = "ctxStatusBar";
            this.ctxStatusBar.OwnerItem = this.toolStripBtnMenu;
            this.ctxStatusBar.Size = new Size(0xbc, 0x36);
            this.actlMain.SetAction(this.toolStripMenuItem4, this.actSetBrowserIntegration);
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new Size(0xbb, 0x16);
            this.toolStripMenuItem4.Text = "Enable IE Integration";
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(0xb8, 6);
            this.actlMain.SetAction(this.toolStripMenuItem3, this.actExit);
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new Size(0xbb, 0x16);
            this.toolStripMenuItem3.Text = "Exit";
            this.actlMain.Actions.Add(this.actShowForm);
            this.actlMain.Actions.Add(this.actHideForm);
            this.actlMain.Actions.Add(this.actExit);
            this.actlMain.Actions.Add(this.actClearMessages);
            this.actlMain.Actions.Add(this.actSetBrowserIntegration);
            this.actlMain.ContainerControl = this;
            this.actShowForm.Text = "Show";
            this.actShowForm.ToolTipText = "Open the main form";
            this.actShowForm.Execute += new EventHandler(this.actShowForm_Execute);
            this.actSetBrowserIntegration.CheckOnClick = true;
            this.actSetBrowserIntegration.Text = "Enable IE Integration";
            this.actSetBrowserIntegration.ToolTipText = "If enabled, SharpBITS integrates in IE Browser to start downloads from the context menu";
            this.actSetBrowserIntegration.Execute += new EventHandler(this.actSetBrowserIntegration_Execute);
            this.actExit.Text = "Exit";
            this.actExit.ToolTipText = "Exit";
            this.actExit.Execute += new EventHandler(this.actExit_Execute);
            this.actHideForm.Text = "Hide";
            this.actHideForm.ToolTipText = "Minimize the main form to system tray";
            this.actHideForm.Execute += new EventHandler(this.actHideForm_Execute);
            this.actClearMessages.Text = "Reset";
            this.actlMain.SetAction(this.ctxmiMainExit, this.actExit);
            this.ctxmiMainExit.Name = "ctxmiMainExit";
            this.ctxmiMainExit.ShortcutKeyDisplayString = "";
            this.ctxmiMainExit.Size = new Size(0x67, 0x16);
            this.ctxmiMainExit.Text = "Exit";
            this.statMainForm.Items.AddRange(new ToolStripItem[] { this.toolStripStatusLabel1, this.toolStripStatusJobUser, this.toolStripStatusLabel2, this.toolStripBtnMenu });
            this.statMainForm.Location = new Point(0, 0x179);
            this.statMainForm.Name = "statMainForm";
            this.statMainForm.ShowItemToolTips = true;
            this.statMainForm.Size = new Size(0x2b4, 0x16);
            this.statMainForm.TabIndex = 1;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new Size(0x270, 0x11);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusJobUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusJobUser.Image = Resources.AllUsers;
            this.toolStripStatusJobUser.Name = "toolStripStatusJobUser";
            this.toolStripStatusJobUser.Size = new Size(0x10, 0x11);
            this.toolStripStatusJobUser.Text = "toolStripStatusJobUser";
            this.toolStripStatusJobUser.Click += new EventHandler(this.toolStripStatusJobUser_Click);
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new Size(5, 0x11);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.statLabelMessage.AutoSize = false;
            this.statLabelMessage.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.All;
            this.statLabelMessage.Name = "statLabelMessage";
            this.statLabelMessage.Size = new Size(200, 0x11);
            this.statLabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMessages.ContextMenuStrip = this.ctxMainForm;
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Location = new Point(0, 0);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessages.Size = new Size(0x2b4, 90);
            this.txtMessages.TabIndex = 2;
            this.txtMessages.DoubleClick += new EventHandler(this.txtMessages_DoubleClick);
            this.txtMessages.KeyDown += new KeyEventHandler(this.txtMessages_KeyDown);
            this.ctxMainForm.Items.AddRange(new ToolStripItem[] { this.ctxmiMainExit });
            this.ctxMainForm.Name = "ctxMainForm";
            this.ctxMainForm.Size = new Size(0x68, 0x1a);
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer.Panel1.Controls.Add(this.panel1);
            this.splitContainer.Panel1.Controls.Add(this.jobListControl);
            this.splitContainer.Panel2.Controls.Add(this.txtMessages);
            this.splitContainer.Size = new Size(0x2b4, 0x179);
            this.splitContainer.SplitterDistance = 0x11b;
            this.splitContainer.TabIndex = 4;
            this.panel1.Controls.Add(this.lblUrl);
            this.panel1.Controls.Add(this.btnAddUrl);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new Point(0, 0x102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x2b4, 0x19);
            this.panel1.TabIndex = 1;
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new Point(9, 7);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new Size(0x29, 13);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "Url/File";
            this.btnAddUrl.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Top;
            this.btnAddUrl.Enabled = false;
            this.btnAddUrl.Location = new Point(0x25d, 2);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new Size(0x4b, 0x17);
            this.btnAddUrl.TabIndex = 1;
            this.btnAddUrl.Text = "Add";
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new EventHandler(this.btnAddUrl_Click);
            this.txtUrl.Anchor = System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Top;
            this.txtUrl.Location = new Point(0x38, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new Size(0x21f, 20);
            this.txtUrl.TabIndex = 0;
            this.toolTipControl.SetToolTip(this.txtUrl, "Enter a local file url to create an upload job, \r\nor a remote http(s) url to create a new download job.");
            this.txtUrl.TextChanged += new EventHandler(this.txtUrl_TextChanged);
            this.jobListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobListControl.Location = new Point(0, 0);
            this.jobListControl.Name = "jobListControl";
            this.jobListControl.Size = new Size(0x2b4, 0x11b);
            this.jobListControl.TabIndex = 0;
            base.AcceptButton = this.btnAddUrl;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x2b4, 0x18f);
            this.ContextMenuStrip = this.ctxMainForm;
            base.Controls.Add(this.splitContainer);
            base.Controls.Add(this.statMainForm);
            base.Icon = (Icon)manager.GetObject("$this.Icon");
            base.Name = "MainForm";
            this.Text = "SharpBITS";
            base.Resize += new EventHandler(this.MainForm_Resize);
            base.FormClosing += new FormClosingEventHandler(this.MainForm_FormClosing);
            base.KeyUp += new KeyEventHandler(this.MainForm_KeyUp);
            base.Load += new EventHandler(this.Form_Load);
            this.ctxMenuSystray.ResumeLayout(false);
            this.ctxStatusBar.ResumeLayout(false);
            this.actlMain.EndInit();
            this.statMainForm.ResumeLayout(false);
            this.statMainForm.PerformLayout();
            this.ctxMainForm.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion

    }
}
