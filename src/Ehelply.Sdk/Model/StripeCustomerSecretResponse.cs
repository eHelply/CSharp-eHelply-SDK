/*
 * eHelply SDK - 1.1.119
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.119
 * Contact: support@ehelply.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ehelply.Sdk.Client.OpenAPIDateConverter;

namespace Ehelply.Sdk.Model
{
    /// <summary>
    /// StripeCustomerSecretResponse
    /// </summary>
    [DataContract(Name = "StripeCustomerSecretResponse")]
    public partial class StripeCustomerSecretResponse : IEquatable<StripeCustomerSecretResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCustomerSecretResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StripeCustomerSecretResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCustomerSecretResponse" /> class.
        /// </summary>
        /// <param name="secret">secret (required).</param>
        public StripeCustomerSecretResponse(string secret = default(string))
        {
            // to ensure "secret" is required (not null)
            if (secret == null)
            {
                throw new ArgumentNullException("secret is a required property for StripeCustomerSecretResponse and cannot be null");
            }
            this.Secret = secret;
        }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name = "secret", IsRequired = true, EmitDefaultValue = false)]
        public string Secret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StripeCustomerSecretResponse {\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StripeCustomerSecretResponse);
        }

        /// <summary>
        /// Returns true if StripeCustomerSecretResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StripeCustomerSecretResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripeCustomerSecretResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Secret != null)
                {
                    hashCode = (hashCode * 59) + this.Secret.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
