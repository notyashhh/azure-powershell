// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Custom hostname configuration.
    /// </summary>
    public partial class HostnameConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the HostnameConfiguration class.
        /// </summary>
        public HostnameConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HostnameConfiguration class.
        /// </summary>

        /// <param name="type">Hostname type.
        /// Possible values include: &#39;Proxy&#39;, &#39;Portal&#39;, &#39;Management&#39;, &#39;Scm&#39;,
        /// &#39;DeveloperPortal&#39;</param>

        /// <param name="hostName">Hostname to configure on the Api Management service.
        /// </param>

        /// <param name="keyVaultId">Url to the KeyVault Secret containing the Ssl Certificate. If absolute Url
        /// containing version is provided, auto-update of ssl certificate will not
        /// work. This requires Api Management service to be configured with
        /// aka.ms/apimmsi. The secret should be of type *application/x-pkcs12*
        /// </param>

        /// <param name="identityClientId">System or User Assigned Managed identity clientId as generated by Azure AD,
        /// which has GET access to the keyVault containing the SSL certificate.
        /// </param>

        /// <param name="encodedCertificate">Base64 Encoded certificate.
        /// </param>

        /// <param name="certificatePassword">Certificate Password.
        /// </param>

        /// <param name="defaultSslBinding">Specify true to setup the certificate associated with this Hostname as the
        /// Default SSL Certificate. If a client does not send the SNI header, then
        /// this will be the certificate that will be challenged. The property is
        /// useful if a service has multiple custom hostname enabled and it needs to
        /// decide on the default ssl certificate. The setting only applied to Proxy
        /// Hostname Type.
        /// </param>

        /// <param name="negotiateClientCertificate">Specify true to always negotiate client certificate on the hostname.
        /// Default Value is false.
        /// </param>

        /// <param name="certificate">Certificate information.
        /// </param>

        /// <param name="certificateSource">Certificate Source.
        /// Possible values include: &#39;Managed&#39;, &#39;KeyVault&#39;, &#39;Custom&#39;, &#39;BuiltIn&#39;</param>

        /// <param name="certificateStatus">Certificate Status.
        /// Possible values include: &#39;Completed&#39;, &#39;Failed&#39;, &#39;InProgress&#39;</param>
        public HostnameConfiguration(string type, string hostName, string keyVaultId = default(string), string identityClientId = default(string), string encodedCertificate = default(string), string certificatePassword = default(string), bool? defaultSslBinding = default(bool?), bool? negotiateClientCertificate = default(bool?), CertificateInformation certificate = default(CertificateInformation), string certificateSource = default(string), string certificateStatus = default(string))

        {
            this.Type = type;
            this.HostName = hostName;
            this.KeyVaultId = keyVaultId;
            this.IdentityClientId = identityClientId;
            this.EncodedCertificate = encodedCertificate;
            this.CertificatePassword = certificatePassword;
            this.DefaultSslBinding = defaultSslBinding;
            this.NegotiateClientCertificate = negotiateClientCertificate;
            this.Certificate = certificate;
            this.CertificateSource = certificateSource;
            this.CertificateStatus = certificateStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets hostname type. Possible values include: &#39;Proxy&#39;, &#39;Portal&#39;, &#39;Management&#39;, &#39;Scm&#39;, &#39;DeveloperPortal&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; set; }

        /// <summary>
        /// Gets or sets hostname to configure on the Api Management service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "hostName")]
        public string HostName {get; set; }

        /// <summary>
        /// Gets or sets url to the KeyVault Secret containing the Ssl Certificate. If
        /// absolute Url containing version is provided, auto-update of ssl certificate
        /// will not work. This requires Api Management service to be configured with
        /// aka.ms/apimmsi. The secret should be of type *application/x-pkcs12*
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keyVaultId")]
        public string KeyVaultId {get; set; }

        /// <summary>
        /// Gets or sets system or User Assigned Managed identity clientId as generated
        /// by Azure AD, which has GET access to the keyVault containing the SSL
        /// certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identityClientId")]
        public string IdentityClientId {get; set; }

        /// <summary>
        /// Gets or sets base64 Encoded certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encodedCertificate")]
        public string EncodedCertificate {get; set; }

        /// <summary>
        /// Gets or sets certificate Password.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificatePassword")]
        public string CertificatePassword {get; set; }

        /// <summary>
        /// Gets or sets specify true to setup the certificate associated with this
        /// Hostname as the Default SSL Certificate. If a client does not send the SNI
        /// header, then this will be the certificate that will be challenged. The
        /// property is useful if a service has multiple custom hostname enabled and it
        /// needs to decide on the default ssl certificate. The setting only applied to
        /// Proxy Hostname Type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defaultSslBinding")]
        public bool? DefaultSslBinding {get; set; }

        /// <summary>
        /// Gets or sets specify true to always negotiate client certificate on the
        /// hostname. Default Value is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "negotiateClientCertificate")]
        public bool? NegotiateClientCertificate {get; set; }

        /// <summary>
        /// Gets or sets certificate information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificate")]
        public CertificateInformation Certificate {get; set; }

        /// <summary>
        /// Gets or sets certificate Source. Possible values include: &#39;Managed&#39;, &#39;KeyVault&#39;, &#39;Custom&#39;, &#39;BuiltIn&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateSource")]
        public string CertificateSource {get; set; }

        /// <summary>
        /// Gets or sets certificate Status. Possible values include: &#39;Completed&#39;, &#39;Failed&#39;, &#39;InProgress&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certificateStatus")]
        public string CertificateStatus {get; set; }
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
            if (this.HostName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "HostName");
            }






            if (this.Certificate != null)
            {
                this.Certificate.Validate();
            }


        }
    }
}