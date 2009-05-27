using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SharpBits.WinClient
{
    internal static class Utils
{
    // Methods
    public static string Bytes2Size(ulong bytes)
    {
        if (bytes < 0x400L)
        {
            return (bytes.ToString("N0") + " Bytes");
        }
        if (bytes < 0x100000L)
        {
            double num = ((double) bytes) / 1024.0;
            return (num.ToString("N2") + " KB");
        }
        if (bytes < 0x40000000L)
        {
            double num2 = ((double) bytes) / 1048576.0;
            return (num2.ToString("N2") + " MB");
        }
        if (bytes < 0x10000000000L)
        {
            double num3 = ((double) bytes) / 1073741824.0;
            return (num3.ToString("N2") + " GB");
        }
        double num4 = ((double) bytes) / 1099511627776;
        return (num4.ToString("N2") + " TB");
    }

    public static Rectangle CalculateProgress(Rectangle rectAngle, ulong total, ulong current)
    {
        Rectangle rectangle = new Rectangle(rectAngle.X, rectAngle.Y, rectAngle.Width, rectAngle.Height);
        rectangle.Width = (total == 0L) ? 0 : ((int) Math.Floor((double) (((uint)rectangle.Width * current) / ((double) total))));
        return rectangle;
    }

    [DllImport("user32.dll")]
    internal static extern bool IsIconic(IntPtr hWnd);
    public static string Percentage(ulong total, ulong current)
    {
        double num = (total == 0L) ? 0.0 : (((double) current) / ((double) total));
        return num.ToString("P2");
    }

    [DllImport("user32.dll")]
    internal static extern bool SetForegroundWindow(IntPtr hWnd);
    [DllImport("user32.dll")]
    internal static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

    // Nested Types
    public enum SizeConversion : ulong
    {
        Factor = 0x400L,
        GigaByte = 0x40000000L,
        Kilobyte = 0x400L,
        Megabyte = 0x100000L,
        TeraByte = 0x10000000000L
    }

    internal enum WindowMode
    {
        SW_HIDE = 0,
        SW_RESTORE = 9,
        SW_SHOWDEFAULT = 10,
        SW_SHOWMAXIMIZED = 3,
        SW_SHOWMINIMIZED = 2,
        SW_SHOWNOACTIVATE = 4,
        SW_SHOWNORMAL = 1
    }
}

}
