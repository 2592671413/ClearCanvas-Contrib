﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIM.Annotation.Configuration {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    public sealed partial class AimSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static AimSettings defaultInstance = ((AimSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AimSettings())));
        
        public static AimSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SaveXmlToDesktop {
            get {
                return ((bool)(this["SaveXmlToDesktop"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SendNewXmlAnnotationsToGrid {
            get {
                return ((bool)(this["SendNewXmlAnnotationsToGrid"]));
            }
            set {
                this["SendNewXmlAnnotationsToGrid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool StoreXmlAnnotationsLocally {
            get {
                return ((bool)(this["StoreXmlAnnotationsLocally"]));
            }
            set {
                this["StoreXmlAnnotationsLocally"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool StoreXmlInMyDocuments {
            get {
                return ((bool)(this["StoreXmlInMyDocuments"]));
            }
            set {
                this["StoreXmlInMyDocuments"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LocalAnnotationsFolder {
            get {
                return ((string)(this["LocalAnnotationsFolder"]));
            }
            set {
                this["LocalAnnotationsFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserName {
            get {
                return ((string)(this["UserName"]));
            }
            set {
                this["UserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserRoleInTrial {
            get {
                return ((string)(this["UserRoleInTrial"]));
            }
            set {
                this["UserRoleInTrial"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UserLoginName {
            get {
                return ((string)(this["UserLoginName"]));
            }
            set {
                this["UserLoginName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int UserNumberWitinRoleOfClinicalTrial {
            get {
                return ((int)(this["UserNumberWitinRoleOfClinicalTrial"]));
            }
            set {
                this["UserNumberWitinRoleOfClinicalTrial"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RequireUserInfo {
            get {
                return ((bool)(this["RequireUserInfo"]));
            }
            set {
                this["RequireUserInfo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RequireMarkupInAnnotation {
            get {
                return ((bool)(this["RequireMarkupInAnnotation"]));
            }
            set {
                this["RequireMarkupInAnnotation"] = value;
            }
        }
    }
}
