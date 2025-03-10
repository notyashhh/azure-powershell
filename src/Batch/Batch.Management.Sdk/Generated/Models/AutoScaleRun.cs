// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// The results and errors from an execution of a pool autoscale formula.
    /// </summary>
    /// <remarks>
    /// The results and errors from an execution of a pool autoscale formula.
    /// </remarks>
    public partial class AutoScaleRun
    {
        /// <summary>
        /// Initializes a new instance of the AutoScaleRun class.
        /// </summary>
        public AutoScaleRun()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoScaleRun class.
        /// </summary>

        /// <param name="evaluationTime">The time at which the autoscale formula was last evaluated.
        /// </param>

        /// <param name="results">Each variable value is returned in the form $variable=value, and variables
        /// are separated by semicolons.
        /// </param>

        /// <param name="error">An error that occurred when autoscaling a pool.
        /// </param>
        public AutoScaleRun(System.DateTime evaluationTime, string results = default(string), AutoScaleRunError error = default(AutoScaleRunError))

        {
            this.EvaluationTime = evaluationTime;
            this.Results = results;
            this.Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the time at which the autoscale formula was last evaluated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "evaluationTime")]
        public System.DateTime EvaluationTime {get; set; }

        /// <summary>
        /// Gets or sets each variable value is returned in the form $variable=value,
        /// and variables are separated by semicolons.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "results")]
        public string Results {get; set; }

        /// <summary>
        /// Gets or sets an error that occurred when autoscaling a pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "error")]
        public AutoScaleRunError Error {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.Error != null)
            {
                this.Error.Validate();
            }
        }
    }
}