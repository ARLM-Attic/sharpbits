﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Configuration;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
namespace SharpBits.WinClient.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : ApplicationSettingsBase
    {
        // Fields
        private static Settings defaultInstance = ((Settings)SettingsBase.Synchronized(new Settings()));

        // Methods
        private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
        {
        }

        private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
        {
        }

        // Properties
        [DebuggerNonUserCode, UserScopedSetting]
        public CredentialsCache CredentialsCache
        {
            get
            {
                return (CredentialsCache)this["CredentialsCache"];
            }
            set
            {
                this["CredentialsCache"] = value;
            }
        }

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("")]
        public string DownloadDir0
        {
            get
            {
                return (string)this["DownloadDir0"];
            }
            set
            {
                this["DownloadDir0"] = value;
            }
        }

        [UserScopedSetting, DefaultSettingValue("True"), DebuggerNonUserCode]
        public bool EnableIEExtension
        {
            get
            {
                return (bool)this["EnableIEExtension"];
            }
            set
            {
                this["EnableIEExtension"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting]
        public JobWrapperCache JobCache
        {
            get
            {
                return (JobWrapperCache)this["JobCache"];
            }
            set
            {
                this["JobCache"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("")]
        public string LocalPaths
        {
            get
            {
                return (string)this["LocalPaths"];
            }
            set
            {
                this["LocalPaths"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("True")]
        public bool MinimizeWarning
        {
            get
            {
                return (bool)this["MinimizeWarning"];
            }
            set
            {
                this["MinimizeWarning"] = value;
            }
        }

        [DebuggerNonUserCode, UserScopedSetting, DefaultSettingValue("LimeGreen")]
        public Color ProgressCompletedColor
        {
            get
            {
                return (Color)this["ProgressCompletedColor"];
            }
            set
            {
                this["ProgressCompletedColor"] = value;
            }
        }

        [DefaultSettingValue("Blue"), UserScopedSetting, DebuggerNonUserCode]
        public Color ProgressDoneColor
        {
            get
            {
                return (Color)this["ProgressDoneColor"];
            }
            set
            {
                this["ProgressDoneColor"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("Transparent"), UserScopedSetting]
        public Color ProgressLeftColor
        {
            get
            {
                return (Color)this["ProgressLeftColor"];
            }
            set
            {
                this["ProgressLeftColor"] = value;
            }
        }

        [DefaultSettingValue(""), DebuggerNonUserCode, UserScopedSetting]
        public string RemotePaths
        {
            get
            {
                return (string)this["RemotePaths"];
            }
            set
            {
                this["RemotePaths"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("GradientActiveCaption"), UserScopedSetting]
        public Color SelectedActiveColor
        {
            get
            {
                return (Color)this["SelectedActiveColor"];
            }
            set
            {
                this["SelectedActiveColor"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("GradientInactiveCaption"), UserScopedSetting]
        public Color SelectedInactiveColot
        {
            get
            {
                return (Color)this["SelectedInactiveColot"];
            }
            set
            {
                this["SelectedInactiveColot"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("False")]
        public bool ShowAllJobs
        {
            get
            {
                return (bool)this["ShowAllJobs"];
            }
            set
            {
                this["ShowAllJobs"] = value;
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue(""), UserScopedSetting]
        public string UploadDir0
        {
            get
            {
                return (string)this["UploadDir0"];
            }
            set
            {
                this["UploadDir0"] = value;
            }
        }

        [UserScopedSetting, DebuggerNonUserCode, DefaultSettingValue("")]
        public string UserNames
        {
            get
            {
                return (string)this["UserNames"];
            }
            set
            {
                this["UserNames"] = value;
            }
        }
    }
}
