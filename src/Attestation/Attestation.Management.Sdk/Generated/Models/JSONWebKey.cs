// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Attestation.Models
{
    using System.Linq;

    public partial class JSONWebKey
    {
        /// <summary>
        /// Initializes a new instance of the JSONWebKey class.
        /// </summary>
        public JSONWebKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JSONWebKey class.
        /// </summary>

        /// <param name="alg">The &#34;alg&#34; (algorithm) parameter identifies the algorithm intended for
        /// use with the key.  The values used should either be registered in the
        /// IANA &#34;JSON Web Signature and Encryption Algorithms&#34; registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.
        /// </param>

        /// <param name="crv">The &#34;crv&#34; (curve) parameter identifies the curve type
        /// </param>

        /// <param name="d">RSA private exponent or ECC private key
        /// </param>

        /// <param name="dp">RSA Private Key Parameter
        /// </param>

        /// <param name="dq">RSA Private Key Parameter
        /// </param>

        /// <param name="e">RSA public exponent, in Base64
        /// </param>

        /// <param name="k">Symmetric key
        /// </param>

        /// <param name="kid">The &#34;kid&#34; (key ID) parameter is used to match a specific key.  This
        /// is used, for instance, to choose among a set of keys within a JWK Set
        /// during key rollover.  The structure of the &#34;kid&#34; value is
        /// unspecified.  When &#34;kid&#34; values are used within a JWK Set, different
        /// keys within the JWK Set SHOULD use distinct &#34;kid&#34; values.  (One
        /// example in which different keys might use the same &#34;kid&#34; value is if
        /// they have different &#34;kty&#34; (key type) values but are considered to be
        /// equivalent alternatives by the application using them.)  The &#34;kid&#34;
        /// value is a case-sensitive string.
        /// </param>

        /// <param name="kty">The &#34;kty&#34; (key type) parameter identifies the cryptographic algorithm
        /// family used with the key, such as &#34;RSA&#34; or &#34;EC&#34;. &#34;kty&#34; values should
        /// either be registered in the IANA &#34;JSON Web Key Types&#34; registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.  The &#34;kty&#34; value is a case-sensitive string.
        /// </param>

        /// <param name="n">RSA modulus, in Base64
        /// </param>

        /// <param name="p">RSA secret prime
        /// </param>

        /// <param name="q">RSA secret prime, with p &lt; q
        /// </param>

        /// <param name="qi">RSA Private Key Parameter
        /// </param>

        /// <param name="use">Use (&#34;public key use&#34;) identifies the intended use of
        /// the public key. The &#34;use&#34; parameter is employed to indicate whether
        /// a public key is used for encrypting data or verifying the signature
        /// on data. Values are commonly &#34;sig&#34; (signature) or &#34;enc&#34; (encryption).
        /// </param>

        /// <param name="x">X coordinate for the Elliptic Curve point
        /// </param>

        /// <param name="x5C">The &#34;x5c&#34; (X.509 certificate chain) parameter contains a chain of one
        /// or more PKIX certificates [RFC5280].  The certificate chain is
        /// represented as a JSON array of certificate value strings.  Each
        /// string in the array is a base64-encoded (Section 4 of [RFC4648] --
        /// not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
        /// The PKIX certificate containing the key value MUST be the first
        /// certificate.
        /// </param>

        /// <param name="y">Y coordinate for the Elliptic Curve point
        /// </param>
        public JSONWebKey(string alg, string kid, string kty, string use, string crv = default(string), string d = default(string), string dp = default(string), string dq = default(string), string e = default(string), string k = default(string), string n = default(string), string p = default(string), string q = default(string), string qi = default(string), string x = default(string), System.Collections.Generic.IList<string> x5C = default(System.Collections.Generic.IList<string>), string y = default(string))

        {
            this.Alg = alg;
            this.Crv = crv;
            this.D = d;
            this.Dp = dp;
            this.Dq = dq;
            this.E = e;
            this.K = k;
            this.Kid = kid;
            this.Kty = kty;
            this.N = n;
            this.P = p;
            this.Q = q;
            this.Qi = qi;
            this.Use = use;
            this.X = x;
            this.X5c = x5C;
            this.Y = y;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the &#34;alg&#34; (algorithm) parameter identifies the algorithm
        /// intended for
        /// use with the key.  The values used should either be registered in the
        /// IANA &#34;JSON Web Signature and Encryption Algorithms&#34; registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "alg")]
        public string Alg {get; set; }

        /// <summary>
        /// Gets or sets the &#34;crv&#34; (curve) parameter identifies the curve type
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "crv")]
        public string Crv {get; set; }

        /// <summary>
        /// Gets or sets rSA private exponent or ECC private key
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "d")]
        public string D {get; set; }

        /// <summary>
        /// Gets or sets rSA Private Key Parameter
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dp")]
        public string Dp {get; set; }

        /// <summary>
        /// Gets or sets rSA Private Key Parameter
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dq")]
        public string Dq {get; set; }

        /// <summary>
        /// Gets or sets rSA public exponent, in Base64
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "e")]
        public string E {get; set; }

        /// <summary>
        /// Gets or sets symmetric key
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "k")]
        public string K {get; set; }

        /// <summary>
        /// Gets or sets the &#34;kid&#34; (key ID) parameter is used to match a specific key. 
        /// This
        /// is used, for instance, to choose among a set of keys within a JWK Set
        /// during key rollover.  The structure of the &#34;kid&#34; value is
        /// unspecified.  When &#34;kid&#34; values are used within a JWK Set, different
        /// keys within the JWK Set SHOULD use distinct &#34;kid&#34; values.  (One
        /// example in which different keys might use the same &#34;kid&#34; value is if
        /// they have different &#34;kty&#34; (key type) values but are considered to be
        /// equivalent alternatives by the application using them.)  The &#34;kid&#34;
        /// value is a case-sensitive string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kid")]
        public string Kid {get; set; }

        /// <summary>
        /// Gets or sets the &#34;kty&#34; (key type) parameter identifies the cryptographic
        /// algorithm
        /// family used with the key, such as &#34;RSA&#34; or &#34;EC&#34;. &#34;kty&#34; values should
        /// either be registered in the IANA &#34;JSON Web Key Types&#34; registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.  The &#34;kty&#34; value is a case-sensitive string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kty")]
        public string Kty {get; set; }

        /// <summary>
        /// Gets or sets rSA modulus, in Base64
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "n")]
        public string N {get; set; }

        /// <summary>
        /// Gets or sets rSA secret prime
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "p")]
        public string P {get; set; }

        /// <summary>
        /// Gets or sets rSA secret prime, with p &lt; q
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "q")]
        public string Q {get; set; }

        /// <summary>
        /// Gets or sets rSA Private Key Parameter
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "qi")]
        public string Qi {get; set; }

        /// <summary>
        /// Gets or sets use (&#34;public key use&#34;) identifies the intended use of
        /// the public key. The &#34;use&#34; parameter is employed to indicate whether
        /// a public key is used for encrypting data or verifying the signature
        /// on data. Values are commonly &#34;sig&#34; (signature) or &#34;enc&#34; (encryption).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "use")]
        public string Use {get; set; }

        /// <summary>
        /// Gets or sets x coordinate for the Elliptic Curve point
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "x")]
        public string X {get; set; }

        /// <summary>
        /// Gets or sets the &#34;x5c&#34; (X.509 certificate chain) parameter contains a chain
        /// of one
        /// or more PKIX certificates [RFC5280].  The certificate chain is
        /// represented as a JSON array of certificate value strings.  Each
        /// string in the array is a base64-encoded (Section 4 of [RFC4648] --
        /// not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
        /// The PKIX certificate containing the key value MUST be the first
        /// certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "x5c")]
        public System.Collections.Generic.IList<string> X5c {get; set; }

        /// <summary>
        /// Gets or sets y coordinate for the Elliptic Curve point
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "y")]
        public string Y {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Alg == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Alg");
            }
            if (this.Kid == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Kid");
            }
            if (this.Kty == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Kty");
            }
            if (this.Use == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Use");
            }

















        }
    }
}