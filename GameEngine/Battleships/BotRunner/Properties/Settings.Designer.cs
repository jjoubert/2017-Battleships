﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BotRunner.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\msbuild.exe")]
        public string PathToMSBuild {
            get {
                return ((string)(this["PathToMSBuild"]));
            }
            set {
                this["PathToMSBuild"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("mvn.bat")]
        public string PathToMaven {
            get {
                return ((string)(this["PathToMaven"]));
            }
            set {
                this["PathToMaven"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("java")]
        public string PathToJava {
            get {
                return ((string)(this["PathToJava"]));
            }
            set {
                this["PathToJava"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("go")]
        public string PathToGolang {
            get {
                return ((string)(this["PathToGolang"]));
            }
            set {
                this["PathToGolang"] = value;
            }
        }
	
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("node.exe")]
        public string PathToNode {
            get {
                return ((string)(this["PathToNode"]));
            }
            set {
                this["PathToNode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("python.exe")]
        public string PathToPython2 {
            get {
                return ((string)(this["PathToPython2"]));
            }
            set {
                this["PathToPython2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("python.exe")]
        public string PathToPython3 {
            get {
                return ((string)(this["PathToPython3"]));
            }
            set {
                this["PathToPython3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("pip")]
        public string PathToPythonPackageIndex {
            get {
                return ((string)(this["PathToPythonPackageIndex"]));
            }
            set {
                this["PathToPythonPackageIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("X:\\NodeJS\\npm.cmd")]
        public string PathToNpm {
            get {
                return ((string)(this["PathToNpm"]));
            }
            set {
                this["PathToNpm"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("state.json")]
        public string StateFileName {
            get {
                return ((string)(this["StateFileName"]));
            }
            set {
                this["StateFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("map.txt")]
        public string MapFileName {
            get {
                return ((string)(this["MapFileName"]));
            }
            set {
                this["MapFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("log.txt")]
        public string LogFileName {
            get {
                return ((string)(this["LogFileName"]));
            }
            set {
                this["LogFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("bot.json")]
        public string BotMetaFileName {
            get {
                return ((string)(this["BotMetaFileName"]));
            }
            set {
                this["BotMetaFileName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int MaxBotRuntimeSeconds {
            get {
                return ((int)(this["MaxBotRuntimeSeconds"]));
            }
            set {
                this["MaxBotRuntimeSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("place.txt")]
        public string ShipPlacementFile {
            get {
                return ((string)(this["ShipPlacementFile"]));
            }
            set {
                this["ShipPlacementFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("command.txt")]
        public string CommandFileTxt {
            get {
                return ((string)(this["CommandFileTxt"]));
            }
            set {
                this["CommandFileTxt"] = value;
            }
        }
    }
}
