// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System.Linq;

    /// <summary>
    /// The integration account certificate properties.
    /// </summary>
    public partial class IntegrationAccountCertificateProperties
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountCertificateProperties class.
        /// </summary>
        public IntegrationAccountCertificateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountCertificateProperties class.
        /// </summary>

        /// <param name="createdTime">The created time.
        /// </param>

        /// <param name="changedTime">The changed time.
        /// </param>

        /// <param name="metadata">The metadata.
        /// </param>

        /// <param name="key">The key details in the key vault.
        /// </param>

        /// <param name="publicCertificate">The public certificate.
        /// </param>
        public IntegrationAccountCertificateProperties(System.DateTime? createdTime = default(System.DateTime?), System.DateTime? changedTime = default(System.DateTime?), object metadata = default(object), KeyVaultKeyReference key = default(KeyVaultKeyReference), string publicCertificate = default(string))

        {
            this.CreatedTime = createdTime;
            this.ChangedTime = changedTime;
            this.Metadata = metadata;
            this.Key = key;
            this.PublicCertificate = publicCertificate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the created time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime {get; private set; }

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "changedTime")]
        public System.DateTime? ChangedTime {get; private set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public object Metadata {get; set; }

        /// <summary>
        /// Gets or sets the key details in the key vault.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "key")]
        public KeyVaultKeyReference Key {get; set; }

        /// <summary>
        /// Gets or sets the public certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicCertificate")]
        public string PublicCertificate {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.Key != null)
            {
                this.Key.Validate();
            }

        }
    }
}