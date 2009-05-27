using System;
using System.Runtime.InteropServices;

namespace SharpBits.WinClient
{
    internal static class Win32
    {
        // Fields
        public const int SW_RESTORE = 9;
        public const int SW_SHOW = 5;
        public const int WM_COPYDATA = 0x4a;

        // Methods
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool EnumWindows(EnumThreadWindowsCallback callback, IntPtr extraData);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetWindow(HandleRef hWnd, int uCmd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(HandleRef handle, out int processId);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool IsIconic(IntPtr hWnd);
        [DllImport("user32", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, ref COPYDATASTRUCT lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        // Nested Types
        public delegate bool EnumThreadWindowsCallback(IntPtr hWnd, IntPtr lParam);
    }


}
