using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;

namespace SharpBits.WinClient
{
    internal static class Program
    {
        // Methods
        [STAThread]
        private static void Main(string[] args)
        {
            bool flag;
            string url = string.Empty;
            if (args.Length > 0)
            {
                url = args[0];
            }
            string name = @"Local\" + Assembly.GetExecutingAssembly().FullName;
            Mutex mutex = new Mutex(true, name, out flag);
            try
            {
                if (flag)
                {
                    GC.KeepAlive(mutex);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm(url));
                }
                else
                {
                    IntPtr zero = IntPtr.Zero;
                    lock (typeof(MainForm))
                    {
                        zero = MemoryMappedFile.ReadHandle(@"Local\SharpBITS");
                    }
                    if (Win32.IsIconic(zero))
                    {
                        Win32.ShowWindowAsync(zero, 9);
                    }
                    else
                    {
                        Win32.ShowWindowAsync(zero, 5);
                    }
                    Win32.SetForegroundWindow(zero);
                    COPYDATASTRUCT lParam = new COPYDATASTRUCT();
                    lParam.cbData = url.Length * Marshal.SystemDefaultCharSize;
                    lParam.dwData = IntPtr.Zero;
                    lParam.lpData = Marshal.StringToHGlobalAuto(url);
                    Win32.SendMessage(zero, 0x4a, 0, ref lParam);
                    Marshal.FreeHGlobal(lParam.lpData);
                }
            }
            finally
            {
                mutex.Close();
            }
        }
    }

}
