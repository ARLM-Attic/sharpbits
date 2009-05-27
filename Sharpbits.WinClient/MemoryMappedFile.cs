using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace SharpBits.WinClient
{
   public sealed class MemoryMappedFile : IDisposable
{
    // Fields
    private const int FILE_MAP_READ = 4;
    private const int FILE_MAP_WRITE = 2;
    private IntPtr memoryFileHandle;

    // Methods
    private MemoryMappedFile(IntPtr memoryFileHandle)
    {
        this.memoryFileHandle = memoryFileHandle;
    }

    [DllImport("kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
    private static extern bool CloseHandle(uint hHandle);
    [DllImport("Kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
    private static extern IntPtr CreateFileMapping(uint hFile, IntPtr lpAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, string lpName);
    public static MemoryMappedFile CreateMMF(string fileName, FileAccess access, int size)
    {
        if (size < 0)
        {
            throw new ArgumentException("The size parameter should be a number greater than Zero.");
        }
        IntPtr memoryFileHandle = CreateFileMapping(uint.MaxValue, IntPtr.Zero, (uint) access, 0, (uint) size, fileName);
        if (memoryFileHandle == IntPtr.Zero)
        {
            throw new SharedMemoryException("Creating Shared Memory failed.");
        }
        return new MemoryMappedFile(memoryFileHandle);
    }

    public void Dispose()
    {
        if ((this.memoryFileHandle != IntPtr.Zero) && CloseHandle((uint) ((int) this.memoryFileHandle)))
        {
            this.memoryFileHandle = IntPtr.Zero;
        }
    }

    [DllImport("kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
    private static extern uint GetLastError();
    [DllImport("Kernel32.dll")]
    private static extern IntPtr MapViewOfFile(IntPtr hFileMappingObject, uint dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, uint dwNumberOfBytesToMap);
    [DllImport("kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
    private static extern IntPtr OpenFileMapping(int dwDesiredAccess, bool bInheritHandle, string lpName);
    public static IntPtr ReadHandle(string fileName)
    {
        IntPtr hFileMappingObject = OpenFileMapping(4, false, fileName);
        if (hFileMappingObject == IntPtr.Zero)
        {
            throw new SharedMemoryException("Opening the Shared Memory for Read failed.");
        }
        IntPtr ptr = MapViewOfFile(hFileMappingObject, 4, 0, 0, 8);
        if (ptr == IntPtr.Zero)
        {
            throw new SharedMemoryException("Creating a view of Shared Memory failed.");
        }
        IntPtr ptr3 = Marshal.ReadIntPtr(ptr);
        if (ptr3 == IntPtr.Zero)
        {
            throw new ArgumentException("Reading from the specified address in  Shared Memory failed.");
        }
        UnmapViewOfFile(ptr);
        CloseHandle((uint) ((int) hFileMappingObject));
        return ptr3;
    }

    [DllImport("Kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
    private static extern bool UnmapViewOfFile(IntPtr lpBaseAddress);
    public void WriteHandle(IntPtr windowHandle)
    {
        IntPtr ptr = MapViewOfFile(this.memoryFileHandle, 2, 0, 0, 8);
        if (ptr == IntPtr.Zero)
        {
            throw new SharedMemoryException("Creating a view of Shared Memory failed.");
        }
        Marshal.WriteIntPtr(ptr, windowHandle);
        UnmapViewOfFile(ptr);
    }

}

}
