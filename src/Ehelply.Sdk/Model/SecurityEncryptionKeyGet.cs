/*
 * eHelply SDK - 1.1.70
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.70
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
    /// SecurityEncryptionKeyGet
    /// </summary>
    [DataContract(Name = "SecurityEncryptionKeyGet")]
    public partial class SecurityEncryptionKeyGet : IEquatable<SecurityEncryptionKeyGet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityEncryptionKeyGet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecurityEncryptionKeyGet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityEncryptionKeyGet" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        /// <param name="category">category (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="retrievedAt">retrievedAt (required).</param>
        public SecurityEncryptionKeyGet(string key = default(string), string category = default(string), string createdAt = default(string), string retrievedAt = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null) {
                throw new ArgumentNullException("key is a required property for SecurityEncryptionKeyGet and cannot be null");
            }
            this.Key = key;
            // to ensure "category" is required (not null)
            if (category == null) {
                throw new ArgumentNullException("category is a required property for SecurityEncryptionKeyGet and cannot be null");
            }
            this.Category = category;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null) {
                throw new ArgumentNullException("createdAt is a required property for SecurityEncryptionKeyGet and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "retrievedAt" is required (not null)
            if (retrievedAt == null) {
                throw new ArgumentNullException("retrievedAt is a required property for SecurityEncryptionKeyGet and cannot be null");
            }
            this.RetrievedAt = retrievedAt;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets RetrievedAt
        /// </summary>
        [DataMember(Name = "retrieved_at", IsRequired = true, EmitDefaultValue = false)]
        public string RetrievedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityEncryptionKeyGet {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  RetrievedAt: ").Append(RetrievedAt).Append("\n");
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
            return this.Equals(input as SecurityEncryptionKeyGet);
        }

        /// <summary>
        /// Returns true if SecurityEncryptionKeyGet instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityEncryptionKeyGet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityEncryptionKeyGet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.RetrievedAt == input.RetrievedAt ||
                    (this.RetrievedAt != null &&
                    this.RetrievedAt.Equals(input.RetrievedAt))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.RetrievedAt != null)
                    hashCode = hashCode * 59 + this.RetrievedAt.GetHashCode();
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
