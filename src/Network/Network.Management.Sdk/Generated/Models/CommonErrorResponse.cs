// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Common error response for all Azure Resource Manager APIs to return error
    /// details for failed operations. (This also follows the OData error response
    /// format.).
    /// </summary>
    /// <remarks>
    /// Common error response for all Azure Resource Manager APIs to return error
    /// details for failed operations. (This also follows the OData error response
    /// format.).
    /// </remarks>
    public partial class CommonErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the CommonErrorResponse class.
        /// </summary>
        public CommonErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CommonErrorResponse class.
        /// </summary>

        /// <param name="error">The error object.
        /// </param>
        public CommonErrorResponse(CommonErrorDetail error = default(CommonErrorDetail))

        {
            this.Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the error object.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error")]
        public CommonErrorDetail Error {get; set; }
    }
}