﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FakeItEasy.Analyzer {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FakeItEasy.Analyzer.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non overridable members can not be intercepted..
        /// </summary>
        internal static string NonVirtualSetupSpecificationDescription {
            get {
                return ResourceManager.GetString("NonVirtualSetupSpecificationDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non overridable member {0} cannot be intercepted..
        /// </summary>
        internal static string NonVirtualSetupSpecificationMessageFormat {
            get {
                return ResourceManager.GetString("NonVirtualSetupSpecificationMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non overridable setup specification.
        /// </summary>
        internal static string NonVirtualSetupSpecificationTitle {
            get {
                return ResourceManager.GetString("NonVirtualSetupSpecificationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call specifications should be configured or asserted..
        /// </summary>
        internal static string UnusedCallSpecificationDescription {
            get {
                return ResourceManager.GetString("UnusedCallSpecificationDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unused call specification &apos;{0}&apos;; did you forget to configure or assert the call?.
        /// </summary>
        internal static string UnusedCallSpecificationMessageFormat {
            get {
                return ResourceManager.GetString("UnusedCallSpecificationMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unused call specification.
        /// </summary>
        internal static string UnusedCallSpecificationTitle {
            get {
                return ResourceManager.GetString("UnusedCallSpecificationTitle", resourceCulture);
            }
        }
    }
}
