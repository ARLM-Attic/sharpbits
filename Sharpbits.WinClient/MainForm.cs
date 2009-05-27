using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Crad.Windows.Forms.Actions;
using System.ComponentModel;
using SharpBits.Base;
using SharpBits.WinClient.Properties;
using Microsoft.Win32;
using System.Reflection;
using System.IO;
using System.ServiceProcess;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Globalization;

namespace SharpBits.WinClient
{
   public partial class MainForm : Form
{
    // Fields
    private Crad.Windows.Forms.Actions.Action actClearMessages;
    private Crad.Windows.Forms.Actions.Action actExit;
    private Crad.Windows.Forms.Actions.Action actHideForm;
    private ActionList actlMain;
    private Crad.Windows.Forms.Actions.Action actSetBrowserIntegration;
    private Crad.Windows.Forms.Actions.Action actShowForm;
    private Button btnAddUrl;
    private ContextMenuStrip ctxMainForm;
    private ContextMenuStrip ctxMenuSystray;
    private ToolStripMenuItem ctxmiMainExit;
    private ContextMenuStrip ctxStatusBar;
    private ToolStripMenuItem ctxSystrayExit;
    private ToolStripMenuItem ctxSystrayShow;
    private JobListControl jobListControl;
    private Label lblUrl;
    private BitsManager manager;
    private Panel panel1;
    private SplitContainer splitContainer;
    private ToolStripStatusLabel statLabelMessage;
    private StatusStrip statMainForm;
    private NotifyIcon systray;
    private ToolStripSplitButton toolStripBtnMenu;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripSeparator toolStripMenuItem2;
    private ToolStripMenuItem toolStripMenuItem3;
    private ToolStripMenuItem toolStripMenuItem4;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripStatusLabel toolStripStatusJobUser;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripStatusLabel toolStripStatusLabel2;
    private ToolTip toolTipControl;
    private TextBox txtMessages;
    private TextBox txtUrl;

    // Methods
    public MainForm()
    {
        this.InitializeComponent();
        Application.EnableVisualStyles();
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(this.CurrentDomain_UnhandledException);
        AppDomain.CurrentDomain.ProcessExit += new EventHandler(this.CurrentDomain_ProcessExit);
        this.actSetBrowserIntegration.CheckState = Settings.Default.EnableIEExtension ? CheckState.Checked : CheckState.Unchecked;
        this.CheckIEMenuExtension();
        this.actShowForm.DoExecute();
        if (this.manager != null)
        {
            this.OutputMessage("SharpBITS started");
        }
        else
        {
            this.OutputMessage("SharpBITS could not be initialized. Check the messages below");
            return;
        }
        MemoryMappedFile file = MemoryMappedFile.CreateMMF(@"Local\SharpBITS", FileAccess.ReadWrite, 8);
        IntPtr handle = base.Handle;
        lock (this)
        {
            file.WriteHandle(handle);
        }
    }

    public MainForm(string url) : this()
    {
        if (((this.manager != null) && (url != null)) && (url.Length > 0))
        {
            this.AddFile(url);
        }
    }

    private void actExit_Execute(object sender, EventArgs e)
    {
        Settings.Default.Save();
        Application.Exit();
    }

    private void actHideForm_Execute(object sender, EventArgs e)
    {
        base.Hide();
        this.actShowForm.Enabled = true;
        if (Settings.Default.MinimizeWarning)
        {
            this.systray.BalloonTipClicked += new EventHandler(this.systray_BalloonTipClickedMinimizeWarning);
            this.systray.ShowBalloonTip(0x1388, "Application minimized", "The application was minimized and can be restored by clicking the icon. To leave the application, select Exit from context menu. To avoid showing this message again, click here.", ToolTipIcon.Info);
        }
    }

    private void actSetBrowserIntegration_Execute(object sender, EventArgs e)
    {
        Settings.Default.EnableIEExtension = this.actSetBrowserIntegration.Checked;
        this.CheckIEMenuExtension();
        Settings.Default.Save();
    }

    private void actShowForm_Execute(object sender, EventArgs e)
    {
        if (!base.Visible)
        {
            base.Show();
            base.WindowState = FormWindowState.Normal;
        }
        else
        {
            base.Activate();
        }
    }

    private void AddFile(string url)
    {
        this.jobListControl.AddFile(url);
    }

    private void btnAddUrl_Click(object sender, EventArgs e)
    {
        this.AddFile(this.txtUrl.Text);
    }

    private void CheckIEMenuExtension()
    {
        try
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Internet Explorer\MenuExt", true);
            if (key != null)
            {
                string location = Assembly.GetExecutingAssembly().Location;
                string directoryName = Path.GetDirectoryName(location);
                string str3 = "iecontext.htm";
                if (Settings.Default.EnableIEExtension)
                {
                    RegistryKey key2 = key.CreateSubKey("&Download using SharpBITS");
                    key2.SetValue("", Path.Combine(directoryName, str3));
                    key2.SetValue("Contexts", 0x22, RegistryValueKind.DWord);
                    string str4 = "<html>\r\n<script type=\"text/javascript\">\r\ntry\r\n{\r\n\t// this isn't being called from a menu\r\n\tif (external.menuArguments != null)\r\n\t{\r\n\t\t// Get the DOM for the current page\r\n\t\tvar doc = external.menuArguments.document;\r\n\t\t\r\n\t\t// Get the browser for the right click\r\n\t\tvar parentwindow = external.menuArguments;\r\n\t\tvar parentevent = null;\r\n\r\n\t\t// Find the event (either from the parent window, or if we're in\r\n\t\t// frames, from the frame)\r\n\t\tif(parentwindow)\r\n\t\t\tparentevent = parentwindow.event;\r\n\t\t\r\n\t\t// If we're in a subframe, iterate through the frame stack until we find the\r\n\t\t// frame with the events- grab its events.\r\n\t\tif(!parentevent && parentwindow)\r\n\t\t{\r\n\t\t\tif(parentwindow.frames)\r\n\t\t\t{\r\n\t\t\t\tfor(i = 0; i< parentwindow.frames.length; i++)\r\n\t\t\t\t{\r\n\t\t\t\t\tif(parentwindow.frames(i).event)\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\tparentevent = parentwindow.frames(i).event;\r\n\t\t\t\t\t\tbreak;\r\n\t\t\t\t\t}\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t}\r\n\t\t\r\n\t\t// If we found the event, add the entry\t\t\r\n\t\tif(parentevent)\r\n\t\t{\r\n\t\t\tvar url = escape(parentwindow.location.href);\r\n\t\t\tvar selectedElement = doc.elementFromPoint(parentevent.clientX, parentevent.clientY );\r\n\t\t\tvar tag = selectedElement.tagName;\r\n\t\t\tif(tag == \"A\" || tag == \"a\")\r\n\t\t\t\turl = selectedElement;\r\n\t\t\tif(tag == \"IMG\" || tag == \"img\") {\r\n\t\t\t\tselectedElement = getContainingA(selectedElement);\r\n\t\t\t\turl = selectedElement;\r\n\t\t\t}\r\n\t\t\turl = \"\" + url;\r\n\t\t\t\t\r\n\t\t\tvar commandtoRun = \"" + location.Replace(@"\", @"\\") + "\";\r\n\t\t\tvar commandParms = url;\r\n\t\t\tvar oShell = new ActiveXObject(\"Shell.Application\");\r\n\t\t\toShell.ShellExecute(commandtoRun, commandParms, \"\", \"open\", \"1\");\r\n\r\n\t\t}\t\t\r\n\t}\r\n}\r\ncatch (exception)\r\n{\r\n\talert(\"" + str3 + "::exception:\"+exception.message);\r\n}\r\n\r\nfunction getContainingA(Element)\r\n{\r\n\tvar AnyElement;\r\n\r\n\tAnyElement = Element;\r\n\tif (AnyElement.parentElement && AnyElement.tagName)\t{\r\n\t\twhile ((AnyElement) && (AnyElement.tagName != \"A\"))\r\n\t\t{\r\n\t\t\tAnyElement = AnyElement.parentElement;\r\n\t\t}\r\n\t} else {\r\n\t\twhile ((AnyElement) && (AnyElement.nodeName != \"A\"))\r\n\t\t{\r\n\t\t\tAnyElement = AnyElement.parentNode;\r\n\t\t}\r\n\t}\t\r\n\treturn AnyElement;\r\n}\r\n</script></html>";
                    using (StreamWriter writer = new StreamWriter(Path.Combine(directoryName, str3)))
                    {
                        writer.Write(str4);
                    }
                    this.actSetBrowserIntegration.Text = "Browser Integration enabled";
                }
                else
                {
                    key.DeleteSubKey("&Download using SharpBITS", false);
                    File.Delete(Path.Combine(directoryName, str3));
                    this.actSetBrowserIntegration.Text = "Browser Integration disabled";
                }
            }
            else
            {
                this.OutputMessage("Unable to open RegistryKey. Could not check browser integration.");
            }
        }
        catch (Exception exception)
        {
            this.OutputMessage(exception.Message, MessageLevel.Debug);
        }
    }

    private void CurrentDomain_ProcessExit(object sender, EventArgs e)
    {
        if (this.manager != null)
        {
            this.manager.Dispose();
        }
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        Exception exceptionObject = e.ExceptionObject as Exception;
        if (e.IsTerminating)
        {
            MessageBox.Show((("Application Error. Application can not continue and will be shut down. Restart application." + Environment.NewLine + exceptionObject) != null) ? exceptionObject.Message : e.ExceptionObject.ToString(), "Unhandled Excpetion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        else
        {
            this.OutputMessage((("Application Error." + Environment.NewLine + exceptionObject) != null) ? exceptionObject.Message : e.ExceptionObject.ToString());
        }
    }

    private void Form_Load(object sender, EventArgs e)
    {
        try
        {
            ServiceController controller = new ServiceController("BITS");
            if (controller.Status != ServiceControllerStatus.Running)
            {
                this.OutputMessage(string.Format("{0} was {1}. Service will be started now.", controller.DisplayName, 
                    controller.Status.ToString().ToLower(CultureInfo.CurrentCulture)), MessageLevel.Information);
                controller.Start();
            }
            else
            {
                this.OutputMessage(string.Format("{0} is {1}", controller.DisplayName, controller.Status.ToString().ToLower(CultureInfo.CurrentCulture)), 
                    MessageLevel.Information);
            }
        }
        catch (Exception exception)
        {
            this.OutputMessage(exception.Message, MessageLevel.Error);
            this.jobListControl.InitializeControl(null);
            return;
        }
        this.manager = new BitsManager();
        this.manager.OnInterfaceError += new EventHandler<BitsInterfaceNotificationEventArgs>(this.manager_OnInterfaceError);
        this.manager.OnJobAdded += new EventHandler<NotificationEventArgs>(this.manager_OnJobAdded);
        this.manager.OnJobRemoved += new EventHandler<NotificationEventArgs>(this.manager_OnJobRemoved);
        this.manager.OnJobError += new EventHandler<ErrorNotificationEventArgs>(this.manager_OnJobError);
        this.manager.OnJobTransferred += new EventHandler<NotificationEventArgs>(this.manager_OnJobTransferred);
        this.jobListControl.OnJobListOwnerChanged += new EventHandler(this.jobListControl_OnJobListOwnerChanged);
        this.jobListControl.InitializeControl(this.manager);
        while (this.ctxMainForm.Items.Count > 0)
        {
            ToolStripItem item = this.ctxMainForm.Items[0];
            this.ctxMainForm.Items.RemoveAt(0);
            this.jobListControl.ContextMenuStrip.Items.Add(item);
        }
        this.txtMessages.ContextMenuStrip = this.jobListControl.ContextMenuStrip;
        this.ContextMenuStrip = this.jobListControl.ContextMenuStrip;
        this.SetApplicationHints();
    }

    private void jobListControl_OnJobListOwnerChanged(object sender, EventArgs e)
    {
        this.toolStripStatusJobUser.Image = this.jobListControl.JobListOwnerImage;
        this.toolStripStatusJobUser.ToolTipText = "The list contains jobs for \r\n" + (Settings.Default.ShowAllJobs ? "all users on this machine" : "the current user only");
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Settings.Default.Save();
    }

    private void MainForm_KeyUp(object sender, KeyEventArgs e)
    {
        e.Handled = true;
        switch (e.KeyCode)
        {
            case Keys.V:
                if (!e.Control)
                {
                    break;
                }
                this.jobListControl.PasteUrl();
                return;

            case Keys.F5:
                this.jobListControl.UpdateControl();
                return;

            default:
                e.Handled = false;
                break;
        }
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        if (base.WindowState == FormWindowState.Minimized)
        {
            this.actHideForm.DoExecute();
        }
    }

    private void manager_OnInterfaceError(object sender, BitsInterfaceNotificationEventArgs e)
    {
        this.OutputMessage(string.Format("Job '{0}': {1}", e.Job.DisplayName, e.Description));
    }

    private void manager_OnJobAdded(object sender, NotificationEventArgs e)
    {
        this.OutputMessage(string.Format("New job '{0}' created", e.Job.DisplayName));
        this.SetApplicationHints();
    }

    private void manager_OnJobError(object sender, ErrorNotificationEventArgs e)
    {
        this.OutputMessage(string.Format("Job '{0}' failed on transfer: {1}", e.Job.DisplayName, e.Error.Description));
    }

    private void manager_OnJobRemoved(object sender, NotificationEventArgs e)
    {
        this.OutputMessage(string.Format("Job '{0}' was removed or is not visible for this user", e.Job.DisplayName));
        this.SetApplicationHints();
    }

    private void manager_OnJobTransferred(object sender, NotificationEventArgs e)
    {
        this.OutputMessage(string.Format("Job '{0}' transferred successfully", e.Job.DisplayName));
    }

    private void OutputMessage(string message)
    {
        if (base.InvokeRequired)
        {
            JobMessageCallback method = new JobMessageCallback(this.OutputMessage);
            base.Invoke(method, new object[] { message });
        }
        else
        {
            this.OutputMessage(message, MessageLevel.Information);
        }
    }

    private void OutputMessage(string message, MessageLevel level)
    {
        if (base.InvokeRequired)
        {
            JobMessageLevelCallback method = new JobMessageLevelCallback(this.OutputMessage);
            base.Invoke(method, new object[] { message, level });
        }
        else
        {
            if (!message.EndsWith(Environment.NewLine, StringComparison.OrdinalIgnoreCase))
            {
                message = message + Environment.NewLine;
            }
            switch (level)
            {
                case MessageLevel.Information:
                case MessageLevel.Warning:
                case MessageLevel.Error:
                    this.txtMessages.Text = string.Format("{0} : [{1}] {2}{3}", new object[] { DateTime.Now, level.ToString(), message, this.txtMessages.Text });
                    return;
            }
        }
    }

    private void SetApplicationHints()
    {
        int num = 0;
        int num2 = 0;
        foreach (BitsJob job in this.manager.Jobs.Values)
        {
            if (job.JobType == JobType.Download)
            {
                num2++;
            }
            else if (job.JobType == JobType.Upload)
            {
                num++;
            }
        }
        this.systray.Text = string.Format("{0} {1} Download: {2} Jobs{1} Upload: {3} Jobs", new object[] { "SharpBITS", Environment.NewLine, num2, num });
    }

    private void systray_BalloonTipClickedMinimizeWarning(object sender, EventArgs e)
    {
        if (Settings.Default.MinimizeWarning)
        {
            Settings.Default.MinimizeWarning = false;
            Settings.Default.Save();
        }
        this.systray.BalloonTipClicked -= new EventHandler(this.systray_BalloonTipClickedMinimizeWarning);
    }

    private void systray_DoubleClick(object sender, EventArgs e)
    {
        this.actShowForm.DoExecute();
    }

    private void toolStripBtnMenu_ButtonClick(object sender, EventArgs e)
    {
        this.toolStripBtnMenu.DropDown.Show();
    }

    private void toolStripStatusJobUser_Click(object sender, EventArgs e)
    {
        this.jobListControl.actShowAllJobs.DoExecute();
    }

    private void txtMessages_DoubleClick(object sender, EventArgs e)
    {
        this.txtMessages.Clear();
    }

    private void txtMessages_KeyDown(object sender, KeyEventArgs e)
    {
        e.SuppressKeyPress = true;
    }

    private void txtUrl_TextChanged(object sender, EventArgs e)
    {
        this.btnAddUrl.Enabled = this.txtUrl.Text.Length > 0;
    }

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == 0x4a)
        {
            COPYDATASTRUCT copydatastruct = new COPYDATASTRUCT();
            copydatastruct = (COPYDATASTRUCT) Marshal.PtrToStructure(m.LParam, typeof(COPYDATASTRUCT));
            if (copydatastruct.cbData > 0)
            {
                string str = Marshal.PtrToStringAuto(copydatastruct.lpData, copydatastruct.cbData / Marshal.SystemDefaultCharSize);
                AddUrlInvoker method = new AddUrlInvoker(this.AddFile);
                base.BeginInvoke(method, new object[] { str });
            }
        }
        base.WndProc(ref m);
    }

    // Nested Types
    private delegate void AddUrlInvoker(string url);
}


}
