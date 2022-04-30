/*
 * eHelply SDK - 1.1.71
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.71
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
    /// BodyCreateKeySecurityKeysPost
    /// </summary>
    [DataContract(Name = "Body_create_key_security_keys_post")]
    public partial class BodyCreateKeySecurityKeysPost : IEquatable<BodyCreateKeySecurityKeysPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateKeySecurityKeysPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyCreateKeySecurityKeysPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateKeySecurityKeysPost" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        public BodyCreateKeySecurityKeysPost(SecurityKeyCreate key = default(SecurityKeyCreate))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for BodyCreateKeySecurityKeysPost and cannot be null");
            }
            this.Key = key;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public SecurityKeyCreate Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BodyCreateKeySecurityKeysPost {\n");
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
            return this.Equals(input as BodyCreateKeySecurityKeysPost);
        }

        /// <summary>
        /// Returns true if BodyCreateKeySecurityKeysPost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyCreateKeySecurityKeysPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyCreateKeySecurityKeysPost input)
        {
            if (input == null)
            {
                return false;
            }
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
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
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
