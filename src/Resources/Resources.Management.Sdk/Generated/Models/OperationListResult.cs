// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System.Linq;

    /// <summary>
    /// Result of the request to list Microsoft.Resources operations. It contains a
    /// list of operations and a URL link to get the next set of results.
    /// </summary>
    public partial class OperationListResult
    {
        /// <summary>
        /// Initializes a new instance of the OperationListResult class.
        /// </summary>
        public OperationListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationListResult class.
        /// </summary>

        /// <param name="value">List of Microsoft.Resources operations.
        /// </param>

        /// <param name="nextLink">URL to get the next set of operation list results if there are any.
        /// </param>
        public OperationListResult(System.Collections.Generic.IList<Operation> value = default(System.Collections.Generic.IList<Operation>), string nextLink = default(string))

        {
            this.Value = value;
            this.NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets list of Microsoft.Resources operations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<Operation> Value {get; set; }

        /// <summary>
        /// Gets or sets uRL to get the next set of operation list results if there are
        /// any.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink {get; set; }
    }
}