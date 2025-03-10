// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.PolicyInsights.Models
{
    using System.Linq;

    /// <summary>
    /// A field that should be evaluated against Azure Policy to determine
    /// restrictions.
    /// </summary>
    public partial class PendingField
    {
        /// <summary>
        /// Initializes a new instance of the PendingField class.
        /// </summary>
        public PendingField()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PendingField class.
        /// </summary>

        /// <param name="field">The name of the field. This can be a top-level property like &#39;name&#39; or
        /// &#39;type&#39; or an Azure Policy field alias.
        /// </param>

        /// <param name="values">The list of potential values for the field that should be evaluated against
        /// Azure Policy.
        /// </param>
        public PendingField(string field, System.Collections.Generic.IList<string> values = default(System.Collections.Generic.IList<string>))

        {
            this.Field = field;
            this.Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the name of the field. This can be a top-level property like
        /// &#39;name&#39; or &#39;type&#39; or an Azure Policy field alias.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "field")]
        public string Field {get; set; }

        /// <summary>
        /// Gets or sets the list of potential values for the field that should be
        /// evaluated against Azure Policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.IList<string> Values {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Field == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Field");
            }


        }
    }
}