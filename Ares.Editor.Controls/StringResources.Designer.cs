﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ares.Editor.Controls {
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
    internal class StringResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ares.Editor.Controls.StringResources", typeof(StringResources).Assembly);
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
        ///   Looks up a localized string similar to Add music tag {0}.
        /// </summary>
        internal static string AddTagCommand {
            get {
                return ResourceManager.GetString("AddTagCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starts the next element as soon as fading starts. Fade in for the next element must be set manually..
        /// </summary>
        internal static string CrossfadingTooltip {
            get {
                return ResourceManager.GetString("CrossfadingTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not running.
        /// </summary>
        internal static string ElementNotRunningCondition {
            get {
                return ResourceManager.GetString("ElementNotRunningCondition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is running.
        /// </summary>
        internal static string ElementRunningCondition {
            get {
                return ResourceManager.GetString("ElementRunningCondition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set value for all files in container.
        /// </summary>
        internal static string ForAllFileElements {
            get {
                return ResourceManager.GetString("ForAllFileElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;not found&gt;.
        /// </summary>
        internal static string InvalidModeElement {
            get {
                return ResourceManager.GetString("InvalidModeElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}/{1}&apos;.
        /// </summary>
        internal static string ModeElementDisplay {
            get {
                return ResourceManager.GetString("ModeElementDisplay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --.
        /// </summary>
        internal static string NoCondition {
            get {
                return ResourceManager.GetString("NoCondition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove all music tags.
        /// </summary>
        internal static string RemoveAllTagsCommand {
            get {
                return ResourceManager.GetString("RemoveAllTagsCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove music tag {0}.
        /// </summary>
        internal static string RemoveTagCommand {
            get {
                return ResourceManager.GetString("RemoveTagCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets the overall music volume as with the slider in the player or the controller.
        ///Volumes of individual files are relative to the global volume..
        /// </summary>
        internal static string SetGlobalMusicVolume {
            get {
                return ResourceManager.GetString("SetGlobalMusicVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets the overall sound volume (for all sounds), as with the slider in the player or the controller.
        ///Volumes of individual sounds are set relative to the global volume..
        /// </summary>
        internal static string SetGlobalSoundVolume {
            get {
                return ResourceManager.GetString("SetGlobalSoundVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start {0}.
        /// </summary>
        internal static string StartCommand {
            get {
                return ResourceManager.GetString("StartCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stop {0}.
        /// </summary>
        internal static string StopCommand {
            get {
                return ResourceManager.GetString("StopCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wait until {0} is not running.
        /// </summary>
        internal static string WaitElementNotRunningCommand {
            get {
                return ResourceManager.GetString("WaitElementNotRunningCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wait until {0} is running.
        /// </summary>
        internal static string WaitElementRunningCommand {
            get {
                return ResourceManager.GetString("WaitElementRunningCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wait {0} ms.
        /// </summary>
        internal static string WaitTimeCommand {
            get {
                return ResourceManager.GetString("WaitTimeCommand", resourceCulture);
            }
        }
    }
}
