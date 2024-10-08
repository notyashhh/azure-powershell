// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Describes the properties of the load balancer configuration.</summary>
    public partial class LoadBalancerConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="FrontendIPConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfiguration[] _frontendIPConfiguration;

        /// <summary>
        /// Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer
        /// configuration must have exactly one frontend IP configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfiguration[] FrontendIPConfiguration { get => this._frontendIPConfiguration; set => this._frontendIPConfiguration = value; }

        /// <summary>Creates an new <see cref="LoadBalancerConfigurationProperties" /> instance.</summary>
        public LoadBalancerConfigurationProperties()
        {

        }
    }
    /// Describes the properties of the load balancer configuration.
    public partial interface ILoadBalancerConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer
        /// configuration must have exactly one frontend IP configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer configuration must have exactly one frontend IP configuration.",
        SerializedName = @"frontendIpConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfiguration[] FrontendIPConfiguration { get; set; }

    }
    /// Describes the properties of the load balancer configuration.
    internal partial interface ILoadBalancerConfigurationPropertiesInternal

    {
        /// <summary>
        /// Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer
        /// configuration must have exactly one frontend IP configuration.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220904.ILoadBalancerFrontendIPConfiguration[] FrontendIPConfiguration { get; set; }

    }
}