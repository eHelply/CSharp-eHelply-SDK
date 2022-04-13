/*
 * eHelply SDK - 1.1.53
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.53
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
    /// BodyVerifyKeySecurityKeysVerifyPost
    /// </summary>
    [DataContract(Name = "Body_verify_key_security_keys_verify_post")]
    public partial class BodyVerifyKeySecurityKeysVerifyPost : IEquatable<BodyVerifyKeySecurityKeysVerifyPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyVerifyKeySecurityKeysVerifyPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyVerifyKeySecurityKeysVerifyPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyVerifyKeySecurityKeysVerifyPost" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        public BodyVerifyKeySecurityKeysVerifyPost(SecurityKeyVerify key = default(SecurityKeyVerify))
        {
            // to ensure "key" is required (not null)
            if (key == null) {
                throw new ArgumentNullException("key is a required property for BodyVerifyKeySecurityKeysVerifyPost and cannot be null");
            }
            this.Key = key;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public SecurityKeyVerify Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BodyVerifyKeySecurityKeysVerifyPost {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as BodyVerifyKeySecurityKeysVerifyPost);
        }

        /// <summary>
        /// Returns true if BodyVerifyKeySecurityKeysVerifyPost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyVerifyKeySecurityKeysVerifyPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyVerifyKeySecurityKeysVerifyPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
