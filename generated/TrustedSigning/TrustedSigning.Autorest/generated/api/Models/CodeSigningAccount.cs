// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Runtime.Extensions;

    /// <summary>Trusted signing account resource.</summary>
    public partial class CodeSigningAccount :
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccount,
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountInternal,
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.TrackedResource();

        /// <summary>The URI of the trusted signing account which is used during signing files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inlined)]
        public string AccountUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountPropertiesInternal)Property).AccountUri; }

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for AccountUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountInternal.AccountUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountPropertiesInternal)Property).AccountUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountPropertiesInternal)Property).AccountUri = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountProperties Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.CodeSigningAccountProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IAccountSku Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountInternal.Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountPropertiesInternal)Property).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountPropertiesInternal)Property).Sku = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.CodeSigningAccountProperties()); set => this._property = value; }

        /// <summary>Status of the current operation on trusted signing account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountPropertiesInternal)Property).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountPropertiesInternal)Property).SkuName = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="CodeSigningAccount" /> instance.</summary>
        public CodeSigningAccount()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Trusted signing account resource.
    public partial interface ICodeSigningAccount :
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ITrackedResource
    {
        /// <summary>The URI of the trusted signing account which is used during signing files.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The URI of the trusted signing account which is used during signing files.",
        SerializedName = @"accountUri",
        PossibleTypes = new [] { typeof(string) })]
        string AccountUri { get;  }
        /// <summary>Status of the current operation on trusted signing account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of the current operation on trusted signing account.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Name of the SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PSArgumentCompleterAttribute("Basic", "Premium")]
        string SkuName { get; set; }

    }
    /// Trusted signing account resource.
    internal partial interface ICodeSigningAccountInternal :
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ITrackedResourceInternal
    {
        /// <summary>The URI of the trusted signing account which is used during signing files.</summary>
        string AccountUri { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.ICodeSigningAccountProperties Property { get; set; }
        /// <summary>Status of the current operation on trusted signing account.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>SKU of the trusted signing account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.Models.IAccountSku Sku { get; set; }
        /// <summary>Name of the SKU.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.TrustedSigning.PSArgumentCompleterAttribute("Basic", "Premium")]
        string SkuName { get; set; }

    }
}