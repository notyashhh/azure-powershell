// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Extensions;

    /// <summary>The license profile of the provisioned cluster.</summary>
    public partial class ProvisionedClusterLicenseProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IProvisionedClusterLicenseProfile,
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IProvisionedClusterLicenseProfileInternal
    {

        /// <summary>Backing field for <see cref="AzureHybridBenefit" /> property.</summary>
        private string _azureHybridBenefit;

        /// <summary>Indicates whether Azure Hybrid Benefit is opted in. Default value is false</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string AzureHybridBenefit { get => this._azureHybridBenefit; set => this._azureHybridBenefit = value; }

        /// <summary>Creates an new <see cref="ProvisionedClusterLicenseProfile" /> instance.</summary>
        public ProvisionedClusterLicenseProfile()
        {

        }
    }
    /// The license profile of the provisioned cluster.
    public partial interface IProvisionedClusterLicenseProfile :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.IJsonSerializable
    {
        /// <summary>Indicates whether Azure Hybrid Benefit is opted in. Default value is false</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether Azure Hybrid Benefit is opted in. Default value is false",
        SerializedName = @"azureHybridBenefit",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AksArc.PSArgumentCompleterAttribute("True", "False", "NotApplicable")]
        string AzureHybridBenefit { get; set; }

    }
    /// The license profile of the provisioned cluster.
    internal partial interface IProvisionedClusterLicenseProfileInternal

    {
        /// <summary>Indicates whether Azure Hybrid Benefit is opted in. Default value is false</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AksArc.PSArgumentCompleterAttribute("True", "False", "NotApplicable")]
        string AzureHybridBenefit { get; set; }

    }
}