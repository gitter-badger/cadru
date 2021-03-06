﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cadru.UnitTest.Framework.Properties {
    using System;
    
    
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Cadru.UnitTest.Framework.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0} cannot contain a null (Nothing in Visual Basic) element..
        /// </summary>
        internal static string Argument_NullElement {
            get {
                return ResourceManager.GetString("Argument_NullElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be an empty string..
        /// </summary>
        internal static string ArgumentException_EmptyString {
            get {
                return ResourceManager.GetString("ArgumentException_EmptyString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a collection containing &lt;0&gt; items but actual was &lt;{0}&gt; items..
        /// </summary>
        internal static string Assertion_CollectionFailure {
            get {
                return ResourceManager.GetString("Assertion_CollectionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected exception of type {0} but no exception was thrown..
        /// </summary>
        internal static string Assertion_ExceptionNotThrown {
            get {
                return ResourceManager.GetString("Assertion_ExceptionNotThrown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected {0} to be assignable from {1}.
        /// </summary>
        internal static string Assertion_ExpectedToBeAssignableFrom {
            get {
                return ResourceManager.GetString("Assertion_ExpectedToBeAssignableFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected &lt;{0}&gt; but actual was &lt;{1}&gt;..
        /// </summary>
        internal static string Assertion_GenericFailure {
            get {
                return ResourceManager.GetString("Assertion_GenericFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is {1} than {2}..
        /// </summary>
        internal static string Assertion_IsComparison {
            get {
                return ResourceManager.GetString("Assertion_IsComparison", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is {1} than or equal to {2}..
        /// </summary>
        internal static string Assertion_IsComparisonOrEqualTo {
            get {
                return ResourceManager.GetString("Assertion_IsComparisonOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected exception with a message of &apos;{0}&apos; but exception with message of &apos;{1}&apos; was thrown instead..
        /// </summary>
        internal static string Assertion_UnexceptedExceptionMessage {
            get {
                return ResourceManager.GetString("Assertion_UnexceptedExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected exception was not thrown..
        /// </summary>
        internal static string Assertion_UnexpectedExceptionThrown {
            get {
                return ResourceManager.GetString("Assertion_UnexpectedExceptionThrown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected type {0} but actual was  {1}..
        /// </summary>
        internal static string Assertion_WrongType {
            get {
                return ResourceManager.GetString("Assertion_WrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assumption failed..
        /// </summary>
        internal static string AssumptionException_EmptyMessage {
            get {
                return ResourceManager.GetString("AssumptionException_EmptyMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assumption failed. {0}.
        /// </summary>
        internal static string AssumptionException_Message {
            get {
                return ResourceManager.GetString("AssumptionException_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} member must be overridden by a derived class..
        /// </summary>
        internal static string NotImplemented_NotOverriddenByDerived {
            get {
                return ResourceManager.GetString("NotImplemented_NotOverriddenByDerived", resourceCulture);
            }
        }
    }
}
