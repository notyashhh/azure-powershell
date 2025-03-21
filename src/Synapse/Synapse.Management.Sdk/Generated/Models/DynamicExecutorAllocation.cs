// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Dynamic Executor Allocation Properties
    /// </summary>
    public partial class DynamicExecutorAllocation
    {
        /// <summary>
        /// Initializes a new instance of the DynamicExecutorAllocation class.
        /// </summary>
        public DynamicExecutorAllocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicExecutorAllocation class.
        /// </summary>

        /// <param name="enabled">Indicates whether Dynamic Executor Allocation is enabled or not.
        /// </param>

        /// <param name="minExecutors">The minimum number of executors alloted
        /// </param>

        /// <param name="maxExecutors">The maximum number of executors alloted
        /// </param>
        public DynamicExecutorAllocation(bool? enabled = default(bool?), int? minExecutors = default(int?), int? maxExecutors = default(int?))

        {
            this.Enabled = enabled;
            this.MinExecutors = minExecutors;
            this.MaxExecutors = maxExecutors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets indicates whether Dynamic Executor Allocation is enabled or
        /// not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enabled")]
        public bool? Enabled {get; set; }

        /// <summary>
        /// Gets or sets the minimum number of executors alloted
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minExecutors")]
        public int? MinExecutors {get; set; }

        /// <summary>
        /// Gets or sets the maximum number of executors alloted
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxExecutors")]
        public int? MaxExecutors {get; set; }
    }
}