﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orleans.Reminders.CosmosDB.Properties {
    using System;
    
    
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Orleans.Reminders.CosmosDB.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to function DeleteRow(serviceId, grainId, name, eTag) {
        ///  var context = getContext();
        ///  var collection = context.getCollection();
        ///  var response = context.getResponse();
        ///
        ///  if (!serviceId) throw new Error(&apos;serviceId is required&apos;);
        ///  if (!grainId) throw new Error(&apos;grainId is required&apos;);
        ///  if (!name) throw new Error(&apos;name is required&apos;);
        ///  if (!eTag) throw new Error(&apos;eTag is required&apos;);
        ///
        ///  var query = &apos;SELECT * FROM c WHERE c.ServiceId = &quot;&apos; + serviceId +
        ///    &apos;&quot; AND c.GrainId &quot;&apos; + grainId + &apos;&quot; AND c.Name = &quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DeleteRow {
            get {
                return ResourceManager.GetString("DeleteRow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function ReadRows(serviceId) {
        ///  var context = getContext();
        ///  var collection = context.getCollection();
        ///  var response = context.getResponse();
        ///
        ///  if (!serviceId) throw new Error(&apos;serviceId is required&apos;);
        ///  if (!grainId) throw new Error(&apos;grainId is required&apos;);
        ///
        ///  var query = &apos;SELECT * FROM c WHERE c.ServiceId = &quot;&apos; + serviceId + &apos;&quot;&apos;;
        ///
        ///  var accept = collection.queryDocuments(collection.getSelfLink(), query, {},
        ///    function (err, docs, responseOptions) {
        ///      if (err) throw new Error(&quot;Error: &quot; + err.me [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DeleteRows {
            get {
                return ResourceManager.GetString("DeleteRows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function ReadRangeRows(serviceId, beginHash, endHash) {
        ///  var context = getContext();
        ///  var collection = context.getCollection();
        ///  var response = context.getResponse();
        ///
        ///  if (!serviceId) throw new Error(&apos;serviceId is required&apos;);
        ///  if (!beginHash) throw new Error(&apos;beginHash is required&apos;);
        ///  if (!endHash) throw new Error(&apos;endHash is required&apos;);
        ///
        ///  var query = &apos;SELECT * FROM c WHERE c.ServiceId = &quot;&apos; + serviceId + &apos;&quot;&apos;;
        ///
        ///  if (beginHash &lt; endHash) {
        ///    query = query + &apos; AND c.GrainHash &gt; &apos; + beginHash  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ReadRangeRows {
            get {
                return ResourceManager.GetString("ReadRangeRows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function ReadRow(serviceId, grainId, name) {
        ///  var context = getContext();
        ///  var collection = context.getCollection();
        ///  var response = context.getResponse();
        ///
        ///  if (!serviceId) throw new Error(&apos;serviceId is required&apos;);
        ///  if (!grainId) throw new Error(&apos;grainId is required&apos;);
        ///  if (!name) throw new Error(&apos;name is required&apos;);
        ///
        ///  var query = &apos;SELECT * FROM c WHERE c.ServiceId = &quot;&apos; + serviceId +
        ///    &apos;&quot; AND c.GrainId &quot;&apos; + grainId + &apos;&quot; AND c.Name = &quot;&apos; + name + &apos;&quot;&apos;;
        ///
        ///  var accept = collection.queryDocuments( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ReadRow {
            get {
                return ResourceManager.GetString("ReadRow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function ReadRows(serviceId, grainId) {
        ///  var context = getContext();
        ///  var collection = context.getCollection();
        ///  var response = context.getResponse();
        ///
        ///  if (!serviceId) throw new Error(&apos;serviceId is required&apos;);
        ///  if (!grainId) throw new Error(&apos;grainId is required&apos;);
        ///
        ///  var query = &apos;SELECT * FROM c WHERE is_defined(c.ServiceId) AND c.ServiceId = &quot;&apos; + serviceId +
        ///    &apos;&quot; AND is_defined(c.GrainId) AND c.GrainId &quot;&apos; + grainId + &apos;&quot;&apos;;
        ///
        ///  var accept = collection.queryDocuments(collection.getSelfLink(), quer [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ReadRows {
            get {
                return ResourceManager.GetString("ReadRows", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to function WriteState(entity) {
        ///  var context = getContext();
        ///  var collection = context.getCollection();
        ///  var response = context.getResponse();
        ///
        ///  if (!entity) throw new Error(&apos;entity is required&apos;);
        ///
        ///  var query = &apos;SELECT c.id, c._self FROM c WHERE c.GrainType = &quot;&apos; + entity.GrainType + &apos;&quot; AND c.id = &quot;&apos; + entity.id + &apos;&quot;&apos;;
        ///  var accept = collection.upsertDocument(collection.getSelfLink(), entity,
        ///    { accessCondition: { type: &apos;IfMatch&apos;, condition: entity._etag } },
        ///    function (err, doc) {
        ///      if (err [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpsertRow {
            get {
                return ResourceManager.GetString("UpsertRow", resourceCulture);
            }
        }
    }
}
