// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.PowerShell;

    /// <summary>Properties specific to the NewRelic Monitor resource</summary>
    [System.ComponentModel.TypeConverter(typeof(MonitorPropertiesTypeConverter))]
    public partial class MonitorProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.MonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MonitorProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.MonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MonitorProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MonitorProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MonitorProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.MonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MonitorProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NewRelicAccountProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountProperty = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.INewRelicAccountProperties) content.GetValueForProperty("NewRelicAccountProperty",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountProperty, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.NewRelicAccountPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfo = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IUserInfo) content.GetValueForProperty("UserInfo",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfo, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.UserInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlanData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanData = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IPlanData) content.GetValueForProperty("PlanData",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanData, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.PlanDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MonitoringStatus = (string) content.GetValueForProperty("MonitoringStatus",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MonitoringStatus, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("LiftrResourceCategory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).LiftrResourceCategory = (string) content.GetValueForProperty("LiftrResourceCategory",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).LiftrResourceCategory, global::System.Convert.ToString);
            }
            if (content.Contains("LiftrResourcePreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).LiftrResourcePreference = (int?) content.GetValueForProperty("LiftrResourcePreference",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).LiftrResourcePreference, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OrgCreationSource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).OrgCreationSource = (string) content.GetValueForProperty("OrgCreationSource",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).OrgCreationSource, global::System.Convert.ToString);
            }
            if (content.Contains("AccountCreationSource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountCreationSource = (string) content.GetValueForProperty("AccountCreationSource",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountCreationSource, global::System.Convert.ToString);
            }
            if (content.Contains("SubscriptionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SubscriptionState = (string) content.GetValueForProperty("SubscriptionState",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SubscriptionState, global::System.Convert.ToString);
            }
            if (content.Contains("SaaSAzureSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SaaSAzureSubscriptionStatus = (string) content.GetValueForProperty("SaaSAzureSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SaaSAzureSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("NewRelicAccountPropertyAccountInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyAccountInfo = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IAccountInfo) content.GetValueForProperty("NewRelicAccountPropertyAccountInfo",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyAccountInfo, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.AccountInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("NewRelicAccountPropertyOrganizationInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyOrganizationInfo = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IOrganizationInfo) content.GetValueForProperty("NewRelicAccountPropertyOrganizationInfo",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyOrganizationInfo, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.OrganizationInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("NewRelicAccountPropertyUserId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyUserId = (string) content.GetValueForProperty("NewRelicAccountPropertyUserId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyUserId, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoFirstName = (string) content.GetValueForProperty("UserInfoFirstName",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoLastName = (string) content.GetValueForProperty("UserInfoLastName",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoEmailAddress = (string) content.GetValueForProperty("UserInfoEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoPhoneNumber = (string) content.GetValueForProperty("UserInfoPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoCountry = (string) content.GetValueForProperty("UserInfoCountry",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoCountry, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataUsageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataUsageType = (string) content.GetValueForProperty("PlanDataUsageType",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataUsageType, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataBillingCycle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataBillingCycle = (string) content.GetValueForProperty("PlanDataBillingCycle",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataBillingCycle, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataPlanDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataPlanDetail = (string) content.GetValueForProperty("PlanDataPlanDetail",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataPlanDetail, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataEffectiveDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataEffectiveDate = (global::System.DateTime?) content.GetValueForProperty("PlanDataEffectiveDate",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataEffectiveDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("NewRelicAccountPropertySingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertySingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.INewRelicSingleSignOnProperties) content.GetValueForProperty("NewRelicAccountPropertySingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertySingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.NewRelicSingleSignOnPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AccountInfoAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoAccountId = (string) content.GetValueForProperty("AccountInfoAccountId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("AccountInfoRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoRegion = (string) content.GetValueForProperty("AccountInfoRegion",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoRegion, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationInfoOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).OrganizationInfoOrganizationId = (string) content.GetValueForProperty("OrganizationInfoOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).OrganizationInfoOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertyProvisioningState = (string) content.GetValueForProperty("SingleSignOnPropertyProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertyProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("AccountInfoIngestionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoIngestionKey = (System.Security.SecureString) content.GetValueForProperty("AccountInfoIngestionKey",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoIngestionKey, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertySingleSignOnState = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnState",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertySingleSignOnState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.MonitorProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MonitorProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NewRelicAccountProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountProperty = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.INewRelicAccountProperties) content.GetValueForProperty("NewRelicAccountProperty",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountProperty, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.NewRelicAccountPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfo = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IUserInfo) content.GetValueForProperty("UserInfo",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfo, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.UserInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("PlanData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanData = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IPlanData) content.GetValueForProperty("PlanData",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanData, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.PlanDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MonitoringStatus = (string) content.GetValueForProperty("MonitoringStatus",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MonitoringStatus, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("LiftrResourceCategory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).LiftrResourceCategory = (string) content.GetValueForProperty("LiftrResourceCategory",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).LiftrResourceCategory, global::System.Convert.ToString);
            }
            if (content.Contains("LiftrResourcePreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).LiftrResourcePreference = (int?) content.GetValueForProperty("LiftrResourcePreference",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).LiftrResourcePreference, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OrgCreationSource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).OrgCreationSource = (string) content.GetValueForProperty("OrgCreationSource",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).OrgCreationSource, global::System.Convert.ToString);
            }
            if (content.Contains("AccountCreationSource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountCreationSource = (string) content.GetValueForProperty("AccountCreationSource",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountCreationSource, global::System.Convert.ToString);
            }
            if (content.Contains("SubscriptionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SubscriptionState = (string) content.GetValueForProperty("SubscriptionState",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SubscriptionState, global::System.Convert.ToString);
            }
            if (content.Contains("SaaSAzureSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SaaSAzureSubscriptionStatus = (string) content.GetValueForProperty("SaaSAzureSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SaaSAzureSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("NewRelicAccountPropertyAccountInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyAccountInfo = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IAccountInfo) content.GetValueForProperty("NewRelicAccountPropertyAccountInfo",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyAccountInfo, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.AccountInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("NewRelicAccountPropertyOrganizationInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyOrganizationInfo = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IOrganizationInfo) content.GetValueForProperty("NewRelicAccountPropertyOrganizationInfo",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyOrganizationInfo, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.OrganizationInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("NewRelicAccountPropertyUserId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyUserId = (string) content.GetValueForProperty("NewRelicAccountPropertyUserId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertyUserId, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoFirstName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoFirstName = (string) content.GetValueForProperty("UserInfoFirstName",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoFirstName, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoLastName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoLastName = (string) content.GetValueForProperty("UserInfoLastName",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoLastName, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoEmailAddress = (string) content.GetValueForProperty("UserInfoEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoPhoneNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoPhoneNumber = (string) content.GetValueForProperty("UserInfoPhoneNumber",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoPhoneNumber, global::System.Convert.ToString);
            }
            if (content.Contains("UserInfoCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoCountry = (string) content.GetValueForProperty("UserInfoCountry",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).UserInfoCountry, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataUsageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataUsageType = (string) content.GetValueForProperty("PlanDataUsageType",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataUsageType, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataBillingCycle"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataBillingCycle = (string) content.GetValueForProperty("PlanDataBillingCycle",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataBillingCycle, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataPlanDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataPlanDetail = (string) content.GetValueForProperty("PlanDataPlanDetail",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataPlanDetail, global::System.Convert.ToString);
            }
            if (content.Contains("PlanDataEffectiveDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataEffectiveDate = (global::System.DateTime?) content.GetValueForProperty("PlanDataEffectiveDate",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).PlanDataEffectiveDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("NewRelicAccountPropertySingleSignOnProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertySingleSignOnProperty = (Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.INewRelicSingleSignOnProperties) content.GetValueForProperty("NewRelicAccountPropertySingleSignOnProperty",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).NewRelicAccountPropertySingleSignOnProperty, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.NewRelicSingleSignOnPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AccountInfoAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoAccountId = (string) content.GetValueForProperty("AccountInfoAccountId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("AccountInfoRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoRegion = (string) content.GetValueForProperty("AccountInfoRegion",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoRegion, global::System.Convert.ToString);
            }
            if (content.Contains("OrganizationInfoOrganizationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).OrganizationInfoOrganizationId = (string) content.GetValueForProperty("OrganizationInfoOrganizationId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).OrganizationInfoOrganizationId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertyProvisioningState = (string) content.GetValueForProperty("SingleSignOnPropertyProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertyProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("AccountInfoIngestionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoIngestionKey = (System.Security.SecureString) content.GetValueForProperty("AccountInfoIngestionKey",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).AccountInfoIngestionKey, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertySingleSignOnState = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnState",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertySingleSignOnState, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertyEnterpriseAppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId = (string) content.GetValueForProperty("SingleSignOnPropertyEnterpriseAppId",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertyEnterpriseAppId, global::System.Convert.ToString);
            }
            if (content.Contains("SingleSignOnPropertySingleSignOnUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl = (string) content.GetValueForProperty("SingleSignOnPropertySingleSignOnUrl",((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IMonitorPropertiesInternal)this).SingleSignOnPropertySingleSignOnUrl, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties specific to the NewRelic Monitor resource
    [System.ComponentModel.TypeConverter(typeof(MonitorPropertiesTypeConverter))]
    public partial interface IMonitorProperties

    {

    }
}