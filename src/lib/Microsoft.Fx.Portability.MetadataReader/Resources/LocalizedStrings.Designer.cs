﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Fx.Portability.Analyzer.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LocalizedStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LocalizedStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Fx.Portability.Analyzer.Resources.LocalizedStrings", typeof(LocalizedStrings).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Detecting assembly references.
        /// </summary>
        internal static string DetectingAssemblyReferences {
            get {
                return ResourceManager.GetString("DetectingAssemblyReferences", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Two types are defined which serve as each others&apos; scope. This may be the result of assembly obfuscation..
        /// </summary>
        internal static string InfiniteTypeParentingRecursion {
            get {
                return ResourceManager.GetString("InfiniteTypeParentingRecursion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a valid assembly.
        /// </summary>
        internal static string InvalidAssembly {
            get {
                return ResourceManager.GetString("InvalidAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid custom attribute prolog..
        /// </summary>
        internal static string InvalidAttributeProlog {
            get {
                return ResourceManager.GetString("InvalidAttributeProlog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unexpected error was encountered while parsing the metadata for the PE file located at {0}..
        /// </summary>
        internal static string MetadataParsingExceptionMessage {
            get {
                return ResourceManager.GetString("MetadataParsingExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot locate assembly information for System.Object. Microsoft assemblies found are:
        ///{0}.
        /// </summary>
        internal static string MissingSystemObjectAssembly {
            get {
                return ResourceManager.GetString("MissingSystemObjectAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More parameters were required than are available.
        /// </summary>
        internal static string MoreParametersWereRequired {
            get {
                return ResourceManager.GetString("MoreParametersWereRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All non-primitive types should be defined in an assembly.
        /// </summary>
        internal static string NonPrimitiveTypeNotDefinedInAssembly {
            get {
                return ResourceManager.GetString("NonPrimitiveTypeNotDefinedInAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This kind is not supported!.
        /// </summary>
        internal static string UnsupportedKind {
            get {
                return ResourceManager.GetString("UnsupportedKind", resourceCulture);
            }
        }
    }
}
