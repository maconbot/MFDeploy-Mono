﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.NetMicroFramework.Tools.MFDeployTool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("COM1")]
        public string DefaultSerialPort {
            get {
                return ((string)(this["DefaultSerialPort"]));
            }
            set {
                this["DefaultSerialPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>10.52.32.196</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection TcpIpAddresses {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["TcpIpAddresses"]));
            }
            set {
                this["TcpIpAddresses"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" />")]
        public global::System.Collections.Specialized.StringCollection MRUFiles {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["MRUFiles"]));
            }
            set {
                this["MRUFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("234.102.98.44")]
        public string DiscoveryMulticastAddress {
            get {
                return ((string)(this["DiscoveryMulticastAddress"]));
            }
            set {
                this["DiscoveryMulticastAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("234.102.98.45")]
        public string DiscoveryMulticastAddressRecv {
            get {
                return ((string)(this["DiscoveryMulticastAddressRecv"]));
            }
            set {
                this["DiscoveryMulticastAddressRecv"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3000")]
        public int DiscoveryMulticastTimeout {
            get {
                return ((int)(this["DiscoveryMulticastTimeout"]));
            }
            set {
                this["DiscoveryMulticastTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("26001")]
        public int DiscoveryMulticastPort {
            get {
                return ((int)(this["DiscoveryMulticastPort"]));
            }
            set {
                this["DiscoveryMulticastPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DOTNETMF")]
        public string DiscoveryMulticastToken {
            get {
                return ((string)(this["DiscoveryMulticastToken"]));
            }
            set {
                this["DiscoveryMulticastToken"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int DiscoveryTTL {
            get {
                return ((int)(this["DiscoveryTTL"]));
            }
            set {
                this["DiscoveryTTL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PlugIn")]
        public string PlugIns {
            get {
                return ((string)(this["PlugIns"]));
            }
            set {
                this["PlugIns"] = value;
            }
        }
    }
}
