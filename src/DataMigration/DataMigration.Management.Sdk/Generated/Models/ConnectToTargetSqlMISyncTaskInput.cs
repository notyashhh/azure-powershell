// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Input for the task that validates connection to Azure SQL Database Managed
    /// Instance online scenario.
    /// </summary>
    public partial class ConnectToTargetSqlMISyncTaskInput
    {
        /// <summary>
        /// Initializes a new instance of the ConnectToTargetSqlMISyncTaskInput class.
        /// </summary>
        public ConnectToTargetSqlMISyncTaskInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectToTargetSqlMISyncTaskInput class.
        /// </summary>

        /// <param name="targetConnectionInfo">Connection information for Azure SQL Database Managed Instance
        /// </param>

        /// <param name="azureApp">Azure Active Directory Application the DMS instance will use to connect to
        /// the target instance of Azure SQL Database Managed Instance and the Azure
        /// Storage Account
        /// </param>
        public ConnectToTargetSqlMISyncTaskInput(MiSqlConnectionInfo targetConnectionInfo, AzureActiveDirectoryApp azureApp)

        {
            this.TargetConnectionInfo = targetConnectionInfo;
            this.AzureApp = azureApp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets connection information for Azure SQL Database Managed Instance
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetConnectionInfo")]
        public MiSqlConnectionInfo TargetConnectionInfo {get; set; }

        /// <summary>
        /// Gets or sets azure Active Directory Application the DMS instance will use
        /// to connect to the target instance of Azure SQL Database Managed Instance
        /// and the Azure Storage Account
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "azureApp")]
        public AzureActiveDirectoryApp AzureApp {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.TargetConnectionInfo == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TargetConnectionInfo");
            }
            if (this.AzureApp == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AzureApp");
            }
            if (this.TargetConnectionInfo != null)
            {
                this.TargetConnectionInfo.Validate();
            }
            if (this.AzureApp != null)
            {
                this.AzureApp.Validate();
            }
        }
    }
}