using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace SharpBits.Base
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1008:EnumsShouldHaveZeroValue"), Flags()]
    public enum RpcAuthnLevel
    {
        Default = 0,
        None = 1,
        Connect = 2,
        Call = 3,
        Pkt = 4,
        PktIntegrity = 5,
        PktPrivacy = 6
    }

    public enum RpcImpLevel
    {
        Default = 0,
        Anonymous = 1,
        Identify = 2,
        Impersonate = 3,
        Delegate = 4
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1027:MarkEnumsWithFlags")]
    public enum EoAuthnCap
    {
        None = 0x00,
        MutualAuth = 0x01,
        StaticCloaking = 0x20,
        DynamicCloaking = 0x40,
        AnyAuthority = 0x80,
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
        MakeFullSIC = 0x100,
        Default = 0x800,
        SecureRefs = 0x02,
        AccessControl = 0x04,
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", MessageId = "Member")]
        AppID = 0x08,
        Dynamic = 0x10,
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
        RequireFullSIC = 0x200,
        AutoImpersonate = 0x400,
        NoCustomMarshal = 0x2000,
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased", MessageId = "Member")]
        DisableAAA = 0x1000
    }

    public enum BitsVersion
    {
        Bits0_0,     //undefinied
        Bits1_0,
        Bits1_2,
        Bits1_5,
        Bits2_0,
        Bits2_5,
        Bits3_0,
        Bits4_0,
    }

    static class NativeMethods
    {
        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        internal static extern bool ConvertStringSidToSidW(string stringSID, ref IntPtr SID);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        internal static extern bool LookupAccountSidW(string systemName, IntPtr SID,
            StringBuilder name, ref long cbName, StringBuilder domainName, ref long cbDomainName, ref int psUse);

        [DllImport("ole32.dll", CharSet = CharSet.Auto)]
        public static extern int CoInitializeSecurity(IntPtr pVoid, int cAuthSvc, IntPtr asAuthSvc, IntPtr pReserved1, RpcAuthnLevel level,
            RpcImpLevel impers, IntPtr pAuthList, EoAuthnCap dwCapabilities, IntPtr pReserved3);
    }

    internal static class Utils
    {
        static BitsVersion version = GetBitsVersion();

        internal static string GetName(string SID)
        {
            const int size = 255;
            long cbUserName = size;
            long cbDomainName = size;
            IntPtr ptrSID = new IntPtr(0);
            int psUse = 0;
            StringBuilder userName = new StringBuilder(size);
            StringBuilder domainName = new StringBuilder(size);
            if (NativeMethods.ConvertStringSidToSidW(SID, ref ptrSID))
            {
                if (NativeMethods.LookupAccountSidW(string.Empty, ptrSID, userName, ref cbUserName, domainName, ref cbDomainName, ref psUse))
                {
                    return string.Concat(domainName.ToString(), "\\", userName.ToString());
                }
            }
            return string.Empty;
        }

        internal static FILETIME DateTime2FileTime(DateTime dateTime)
        {
            long fileTime = 0;
            if (dateTime != DateTime.MinValue)      //Checking for MinValue
                fileTime = dateTime.ToFileTime();    
            FILETIME resultingFileTime = new FILETIME();
            resultingFileTime.dwLowDateTime = (uint)(fileTime & 0xFFFFFFFF);
            resultingFileTime.dwHighDateTime = (uint)(fileTime >> 32);
            return resultingFileTime; 
        }

        internal static DateTime FileTime2DateTime(FILETIME fileTime)
        {
            if (fileTime.dwHighDateTime == 0 && fileTime.dwLowDateTime == 0)    //Checking for MinValue
                return DateTime.MinValue;

            long dateTime = (((long)fileTime.dwHighDateTime) << 32) + fileTime.dwLowDateTime;
            return DateTime.FromFileTime(dateTime);
        }

        /// <summary>
        /// maps version information from file version
        /// version number returned by qmgr.dll
        /// 6.0.xxxx = BITS 1.0
        /// 6.2.xxxx = BITS 1.2
        /// 6.5.xxxx = BITS 1.5
        /// 6.6.xxxx = BITS 2.0
        /// 6.7.xxxx = BITS 2.5
        /// 7.0.xxxx = BITS 3.0
        /// 7.5.xxxx = BITS 4.0
        /// </summary>
        /// <returns></returns>
        private static BitsVersion GetBitsVersion()
        {
            int major = 0;
            int minor = 0;
            try
            {
                string fileName = Path.Combine(System.Environment.SystemDirectory, "qmgr.dll");
                FileVersionInfo fileVersion = FileVersionInfo.GetVersionInfo(fileName);

                major = fileVersion.FileMajorPart;
                minor = fileVersion.FileMinorPart;
            }
            catch (FileNotFoundException)
            {
                return BitsVersion.Bits0_0;
            }

            switch (major)
            {
                case 6:
                    switch (minor)
                    {
                        case 0:
                            return BitsVersion.Bits1_0;
                        case 2:
                            return BitsVersion.Bits1_2;
                        case 5:
                            return BitsVersion.Bits1_5;
                        case 6:
                            return BitsVersion.Bits2_0;
                        case 7:
                            return BitsVersion.Bits2_5;
                        default:
                            return BitsVersion.Bits0_0;
                    }
                case 7:
                    switch (minor)
                    {
                        case 0:
                            return BitsVersion.Bits3_0;
                        case 5:
                            return BitsVersion.Bits4_0;
                        default:
                            return BitsVersion.Bits0_0;
                    }
                default:
                    return BitsVersion.Bits0_0;
            }
        }

        internal static BitsVersion BITSVersion
        {
            get { return version; }
        }
    }
}
