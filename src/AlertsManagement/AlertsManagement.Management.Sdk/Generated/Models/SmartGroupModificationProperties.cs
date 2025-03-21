// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of the smartGroup modification item.
    /// </summary>
    public partial class SmartGroupModificationProperties
    {
        /// <summary>
        /// Initializes a new instance of the SmartGroupModificationProperties class.
        /// </summary>
        public SmartGroupModificationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SmartGroupModificationProperties class.
        /// </summary>

        /// <param name="smartGroupId">Unique Id of the smartGroup for which the history is being retrieved
        /// </param>

        /// <param name="modifications">Modification details
        /// </param>

        /// <param name="nextLink">URL to fetch the next set of results.
        /// </param>
        public SmartGroupModificationProperties(string smartGroupId = default(string), System.Collections.Generic.IList<SmartGroupModificationItem> modifications = default(System.Collections.Generic.IList<SmartGroupModificationItem>), string nextLink = default(string))

        {
            this.SmartGroupId = smartGroupId;
            this.Modifications = modifications;
            this.NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets unique Id of the smartGroup for which the history is being retrieved
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "smartGroupId")]
        public string SmartGroupId {get; private set; }

        /// <summary>
        /// Gets or sets modification details
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "modifications")]
        public System.Collections.Generic.IList<SmartGroupModificationItem> Modifications {get; set; }

        /// <summary>
        /// Gets or sets uRL to fetch the next set of results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink {get; set; }
    }
}