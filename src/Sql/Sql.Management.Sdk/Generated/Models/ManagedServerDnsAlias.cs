// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using System.Linq;

    /// <summary>
    /// A managed server DNS alias.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ManagedServerDnsAlias : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedServerDnsAlias class.
        /// </summary>
        public ManagedServerDnsAlias()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedServerDnsAlias class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">Resource name.
        /// </param>

        /// <param name="type">Resource type.
        /// </param>

        /// <param name="azureDnsRecord">The fully qualified DNS record for managed server alias
        /// </param>

        /// <param name="publicAzureDnsRecord">The fully qualified public DNS record for managed server alias
        /// </param>
        public ManagedServerDnsAlias(string id = default(string), string name = default(string), string type = default(string), string azureDnsRecord = default(string), string publicAzureDnsRecord = default(string))

        : base(id, name, type)
        {
            this.AzureDnsRecord = azureDnsRecord;
            this.PublicAzureDnsRecord = publicAzureDnsRecord;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the fully qualified DNS record for managed server alias
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.azureDnsRecord")]
        public string AzureDnsRecord {get; private set; }

        /// <summary>
        /// Gets the fully qualified public DNS record for managed server alias
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publicAzureDnsRecord")]
        public string PublicAzureDnsRecord {get; private set; }
    }
}