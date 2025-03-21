// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Extensions;

    /// <summary>Response of get metrics status operation</summary>
    public partial class MetricsStatusResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IMetricsStatusResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20230427.IMetricsStatusResponseInternal
    {

        /// <summary>Backing field for <see cref="AzureResourceId" /> property.</summary>
        private string[] _azureResourceId;

        /// <summary>Azure resource IDs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Origin(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.PropertyOrigin.Owned)]
        public string[] AzureResourceId { get => this._azureResourceId; set => this._azureResourceId = value; }

        /// <summary>Creates an new <see cref="MetricsStatusResponse" /> instance.</summary>
        public MetricsStatusResponse()
        {

        }
    }
    /// Response of get metrics status operation
    public partial interface IMetricsStatusResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.IJsonSerializable
    {
        /// <summary>Azure resource IDs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure resource IDs",
        SerializedName = @"azureResourceIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] AzureResourceId { get; set; }

    }
    /// Response of get metrics status operation
    internal partial interface IMetricsStatusResponseInternal

    {
        /// <summary>Azure resource IDs</summary>
        string[] AzureResourceId { get; set; }

    }
}