// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.PowerShell;

    /// <summary>External Network Patch properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ExternalNetworkPatchPropertiesTypeConverter))]
    public partial class ExternalNetworkPatchProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ExternalNetworkPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ExternalNetworkPatchProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ExternalNetworkPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ExternalNetworkPatchProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ExternalNetworkPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ExternalNetworkPatchProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OptionAProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAProperty = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesOptionAProperties) content.GetValueForProperty("OptionAProperty",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAProperty, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ExternalNetworkPatchPropertiesOptionAPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PeeringOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).PeeringOption = (string) content.GetValueForProperty("PeeringOption",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).PeeringOption, global::System.Convert.ToString);
            }
            if (content.Contains("OptionBProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionBProperty = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3OptionBProperties) content.GetValueForProperty("OptionBProperty",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionBProperty, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.L3OptionBPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Annotation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)this).Annotation = (string) content.GetValueForProperty("Annotation",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)this).Annotation, global::System.Convert.ToString);
            }
            if (content.Contains("ImportRoutePolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ImportRoutePolicyId = (string) content.GetValueForProperty("ImportRoutePolicyId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ImportRoutePolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("ExportRoutePolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ExportRoutePolicyId = (string) content.GetValueForProperty("ExportRoutePolicyId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ExportRoutePolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("ImportRoutePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ImportRoutePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IImportRoutePolicy) content.GetValueForProperty("ImportRoutePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ImportRoutePolicy, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ImportRoutePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExportRoutePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ExportRoutePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExportRoutePolicy) content.GetValueForProperty("ExportRoutePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ExportRoutePolicy, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ExportRoutePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("OptionAPropertyBfdConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyBfdConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IBfdConfiguration) content.GetValueForProperty("OptionAPropertyBfdConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyBfdConfiguration, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.BfdConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("OptionAPropertyPrimaryIpv4Prefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPrimaryIpv4Prefix = (string) content.GetValueForProperty("OptionAPropertyPrimaryIpv4Prefix",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPrimaryIpv4Prefix, global::System.Convert.ToString);
            }
            if (content.Contains("OptionAPropertyPrimaryIpv6Prefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPrimaryIpv6Prefix = (string) content.GetValueForProperty("OptionAPropertyPrimaryIpv6Prefix",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPrimaryIpv6Prefix, global::System.Convert.ToString);
            }
            if (content.Contains("OptionAPropertySecondaryIpv4Prefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertySecondaryIpv4Prefix = (string) content.GetValueForProperty("OptionAPropertySecondaryIpv4Prefix",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertySecondaryIpv4Prefix, global::System.Convert.ToString);
            }
            if (content.Contains("OptionAPropertySecondaryIpv6Prefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertySecondaryIpv6Prefix = (string) content.GetValueForProperty("OptionAPropertySecondaryIpv6Prefix",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertySecondaryIpv6Prefix, global::System.Convert.ToString);
            }
            if (content.Contains("OptionAPropertyMtu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyMtu = (int?) content.GetValueForProperty("OptionAPropertyMtu",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyMtu, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OptionAPropertyVlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyVlanId = (int?) content.GetValueForProperty("OptionAPropertyVlanId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyVlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OptionAPropertyFabricAsn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyFabricAsn = (long?) content.GetValueForProperty("OptionAPropertyFabricAsn",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyFabricAsn, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("OptionAPropertyPeerAsn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPeerAsn = (long?) content.GetValueForProperty("OptionAPropertyPeerAsn",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPeerAsn, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("OptionAPropertyIngressAclId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyIngressAclId = (string) content.GetValueForProperty("OptionAPropertyIngressAclId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyIngressAclId, global::System.Convert.ToString);
            }
            if (content.Contains("OptionAPropertyEgressAclId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyEgressAclId = (string) content.GetValueForProperty("OptionAPropertyEgressAclId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyEgressAclId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ExternalNetworkPatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ExternalNetworkPatchProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OptionAProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAProperty = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesOptionAProperties) content.GetValueForProperty("OptionAProperty",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAProperty, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ExternalNetworkPatchPropertiesOptionAPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PeeringOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).PeeringOption = (string) content.GetValueForProperty("PeeringOption",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).PeeringOption, global::System.Convert.ToString);
            }
            if (content.Contains("OptionBProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionBProperty = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IL3OptionBProperties) content.GetValueForProperty("OptionBProperty",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionBProperty, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.L3OptionBPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Annotation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)this).Annotation = (string) content.GetValueForProperty("Annotation",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)this).Annotation, global::System.Convert.ToString);
            }
            if (content.Contains("ImportRoutePolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ImportRoutePolicyId = (string) content.GetValueForProperty("ImportRoutePolicyId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ImportRoutePolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("ExportRoutePolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ExportRoutePolicyId = (string) content.GetValueForProperty("ExportRoutePolicyId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ExportRoutePolicyId, global::System.Convert.ToString);
            }
            if (content.Contains("ImportRoutePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ImportRoutePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IImportRoutePolicy) content.GetValueForProperty("ImportRoutePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ImportRoutePolicy, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ImportRoutePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExportRoutePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ExportRoutePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExportRoutePolicy) content.GetValueForProperty("ExportRoutePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchablePropertiesInternal)this).ExportRoutePolicy, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ExportRoutePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("OptionAPropertyBfdConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyBfdConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IBfdConfiguration) content.GetValueForProperty("OptionAPropertyBfdConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyBfdConfiguration, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.BfdConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("OptionAPropertyPrimaryIpv4Prefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPrimaryIpv4Prefix = (string) content.GetValueForProperty("OptionAPropertyPrimaryIpv4Prefix",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPrimaryIpv4Prefix, global::System.Convert.ToString);
            }
            if (content.Contains("OptionAPropertyPrimaryIpv6Prefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPrimaryIpv6Prefix = (string) content.GetValueForProperty("OptionAPropertyPrimaryIpv6Prefix",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPrimaryIpv6Prefix, global::System.Convert.ToString);
            }
            if (content.Contains("OptionAPropertySecondaryIpv4Prefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertySecondaryIpv4Prefix = (string) content.GetValueForProperty("OptionAPropertySecondaryIpv4Prefix",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertySecondaryIpv4Prefix, global::System.Convert.ToString);
            }
            if (content.Contains("OptionAPropertySecondaryIpv6Prefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertySecondaryIpv6Prefix = (string) content.GetValueForProperty("OptionAPropertySecondaryIpv6Prefix",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertySecondaryIpv6Prefix, global::System.Convert.ToString);
            }
            if (content.Contains("OptionAPropertyMtu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyMtu = (int?) content.GetValueForProperty("OptionAPropertyMtu",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyMtu, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OptionAPropertyVlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyVlanId = (int?) content.GetValueForProperty("OptionAPropertyVlanId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyVlanId, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OptionAPropertyFabricAsn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyFabricAsn = (long?) content.GetValueForProperty("OptionAPropertyFabricAsn",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyFabricAsn, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("OptionAPropertyPeerAsn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPeerAsn = (long?) content.GetValueForProperty("OptionAPropertyPeerAsn",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyPeerAsn, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("OptionAPropertyIngressAclId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyIngressAclId = (string) content.GetValueForProperty("OptionAPropertyIngressAclId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyIngressAclId, global::System.Convert.ToString);
            }
            if (content.Contains("OptionAPropertyEgressAclId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyEgressAclId = (string) content.GetValueForProperty("OptionAPropertyEgressAclId",((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchPropertiesInternal)this).OptionAPropertyEgressAclId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ExternalNetworkPatchProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ExternalNetworkPatchProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IExternalNetworkPatchProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// External Network Patch properties.
    [System.ComponentModel.TypeConverter(typeof(ExternalNetworkPatchPropertiesTypeConverter))]
    public partial interface IExternalNetworkPatchProperties

    {

    }
}