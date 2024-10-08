// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using System.Linq;

    /// <summary>
    /// Managed identity generic object.
    /// </summary>
    public partial class ManagedServiceIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ManagedServiceIdentity class.
        /// </summary>
        public ManagedServiceIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedServiceIdentity class.
        /// </summary>

        /// <param name="type">Type of the managed identity.
        /// Possible values include: &#39;None&#39;, &#39;SystemAssigned&#39;, &#39;UserAssigned&#39;</param>

        /// <param name="principalId">Azure Active Directory principal ID associated with this Identity.
        /// </param>

        /// <param name="tenantId">ID of the Azure Active Directory.
        /// </param>

        /// <param name="userAssignedIdentities">The list of user-assigned managed identities associated with the resource.
        /// Key is the Azure resource Id of the managed identity.
        /// </param>
        public ManagedServiceIdentity(string type, string principalId = default(string), string tenantId = default(string), System.Collections.Generic.IDictionary<string, UserAssignedIdentity> userAssignedIdentities = default(System.Collections.Generic.IDictionary<string, UserAssignedIdentity>))

        {
            this.Type = type;
            this.PrincipalId = principalId;
            this.TenantId = tenantId;
            this.UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets type of the managed identity. Possible values include: &#39;None&#39;, &#39;SystemAssigned&#39;, &#39;UserAssigned&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; set; }

        /// <summary>
        /// Gets or sets azure Active Directory principal ID associated with this
        /// Identity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "principalId")]
        public string PrincipalId {get; set; }

        /// <summary>
        /// Gets or sets iD of the Azure Active Directory.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tenantId")]
        public string TenantId {get; set; }

        /// <summary>
        /// Gets or sets the list of user-assigned managed identities associated with
        /// the resource. Key is the Azure resource Id of the managed identity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "userAssignedIdentities")]
        public System.Collections.Generic.IDictionary<string, UserAssignedIdentity> UserAssignedIdentities {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Type == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Type");
            }




        }
    }
}