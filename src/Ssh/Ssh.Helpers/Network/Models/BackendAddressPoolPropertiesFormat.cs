// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of the backend address pool.
    /// </summary>
    public partial class BackendAddressPoolPropertiesFormat
    {
        /// <summary>
        /// Initializes a new instance of the BackendAddressPoolPropertiesFormat class.
        /// </summary>
        public BackendAddressPoolPropertiesFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendAddressPoolPropertiesFormat class.
        /// </summary>

        /// <param name="location">The location of the backend address pool.
        /// </param>

        /// <param name="tunnelInterfaces">An array of gateway load balancer tunnel interfaces.
        /// </param>

        /// <param name="loadBalancerBackendAddresses">An array of backend addresses.
        /// </param>

        /// <param name="backendIPConfigurations">An array of references to IP addresses defined in network interfaces.
        /// </param>

        /// <param name="loadBalancingRules">An array of references to load balancing rules that use this backend
        /// address pool.
        /// </param>

        /// <param name="outboundRule">A reference to an outbound rule that uses this backend address pool.
        /// </param>

        /// <param name="outboundRules">An array of references to outbound rules that use this backend address
        /// pool.
        /// </param>

        /// <param name="inboundNatRules">An array of references to inbound NAT rules that use this backend address
        /// pool.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the backend address pool resource.
        /// Possible values include: &#39;Succeeded&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Failed&#39;</param>

        /// <param name="drainPeriodInSeconds">Amount of seconds Load Balancer waits for before sending RESET to client
        /// and backend address.
        /// </param>

        /// <param name="virtualNetwork">A reference to a virtual network.
        /// </param>
        public BackendAddressPoolPropertiesFormat(string location = default(string), System.Collections.Generic.IList<GatewayLoadBalancerTunnelInterface> tunnelInterfaces = default(System.Collections.Generic.IList<GatewayLoadBalancerTunnelInterface>), System.Collections.Generic.IList<LoadBalancerBackendAddress> loadBalancerBackendAddresses = default(System.Collections.Generic.IList<LoadBalancerBackendAddress>), System.Collections.Generic.IList<NetworkInterfaceIPConfiguration> backendIPConfigurations = default(System.Collections.Generic.IList<NetworkInterfaceIPConfiguration>), System.Collections.Generic.IList<SubResource> loadBalancingRules = default(System.Collections.Generic.IList<SubResource>), SubResource outboundRule = default(SubResource), System.Collections.Generic.IList<SubResource> outboundRules = default(System.Collections.Generic.IList<SubResource>), System.Collections.Generic.IList<SubResource> inboundNatRules = default(System.Collections.Generic.IList<SubResource>), string provisioningState = default(string), int? drainPeriodInSeconds = default(int?), SubResource virtualNetwork = default(SubResource))

        {
            this.Location = location;
            this.TunnelInterfaces = tunnelInterfaces;
            this.LoadBalancerBackendAddresses = loadBalancerBackendAddresses;
            this.BackendIPConfigurations = backendIPConfigurations;
            this.LoadBalancingRules = loadBalancingRules;
            this.OutboundRule = outboundRule;
            this.OutboundRules = outboundRules;
            this.InboundNatRules = inboundNatRules;
            this.ProvisioningState = provisioningState;
            this.DrainPeriodInSeconds = drainPeriodInSeconds;
            this.VirtualNetwork = virtualNetwork;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the location of the backend address pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; set; }

        /// <summary>
        /// Gets or sets an array of gateway load balancer tunnel interfaces.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tunnelInterfaces")]
        public System.Collections.Generic.IList<GatewayLoadBalancerTunnelInterface> TunnelInterfaces {get; set; }

        /// <summary>
        /// Gets or sets an array of backend addresses.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "loadBalancerBackendAddresses")]
        public System.Collections.Generic.IList<LoadBalancerBackendAddress> LoadBalancerBackendAddresses {get; set; }

        /// <summary>
        /// Gets an array of references to IP addresses defined in network interfaces.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "backendIPConfigurations")]
        public System.Collections.Generic.IList<NetworkInterfaceIPConfiguration> BackendIPConfigurations {get; private set; }

        /// <summary>
        /// Gets an array of references to load balancing rules that use this backend
        /// address pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "loadBalancingRules")]
        public System.Collections.Generic.IList<SubResource> LoadBalancingRules {get; private set; }

        /// <summary>
        /// Gets a reference to an outbound rule that uses this backend address pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "outboundRule")]
        public SubResource OutboundRule {get; private set; }

        /// <summary>
        /// Gets an array of references to outbound rules that use this backend address
        /// pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "outboundRules")]
        public System.Collections.Generic.IList<SubResource> OutboundRules {get; private set; }

        /// <summary>
        /// Gets an array of references to inbound NAT rules that use this backend
        /// address pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "inboundNatRules")]
        public System.Collections.Generic.IList<SubResource> InboundNatRules {get; private set; }

        /// <summary>
        /// Gets the provisioning state of the backend address pool resource. Possible values include: &#39;Succeeded&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Failed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets amount of seconds Load Balancer waits for before sending RESET
        /// to client and backend address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "drainPeriodInSeconds")]
        public int? DrainPeriodInSeconds {get; set; }

        /// <summary>
        /// Gets or sets a reference to a virtual network.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "virtualNetwork")]
        public SubResource VirtualNetwork {get; set; }
    }
}