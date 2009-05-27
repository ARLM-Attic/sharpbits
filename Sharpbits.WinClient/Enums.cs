using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpBits.WinClient
{
    public enum FileAccess
    {
        None = 0,
        ReadOnly = 2,
        ReadWrite = 4
    }

    [Flags]
    public enum KeyState
    {
        Alt = 0x20,
        Ctrl = 8,
        LeftMouse = 1,
        MiddleMouse = 0x10,
        RightMouse = 2,
        Shift = 4
    }

    internal enum MessageLevel
    {
        Debug,
        Information,
        Warning,
        Error
    }

}
