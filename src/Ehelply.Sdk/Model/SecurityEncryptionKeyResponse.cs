/*
 * eHelply SDK - 1.1.118
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.118
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
    /// SecurityEncryptionKeyResponse
    /// </summary>
    [DataContract(Name = "SecurityEncryptionKeyResponse")]
    public partial class SecurityEncryptionKeyResponse : IEquatable<SecurityEncryptionKeyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityEncryptionKeyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecurityEncryptionKeyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityEncryptionKeyResponse" /> class.
        /// </summary>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="key">key (required).</param>
        /// <param name="category">category (required).</param>
        /// <param name="deletedAt">deletedAt (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="retrievedAt">retrievedAt (required).</param>
        public SecurityEncryptionKeyResponse(string uuid = default(string), System.IO.Stream key = default(System.IO.Stream), string category = default(string), string deletedAt = default(string), string createdAt = default(string), string retrievedAt = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for SecurityEncryptionKeyResponse and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for SecurityEncryptionKeyResponse and cannot be null");
            }
            this.Key = key;
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new ArgumentNullException("category is a required property for SecurityEncryptionKeyResponse and cannot be null");
            }
            this.Category = category;
            // to ensure "deletedAt" is required (not null)
            if (deletedAt == null)
            {
                throw new ArgumentNullException("deletedAt is a required property for SecurityEncryptionKeyResponse and cannot be null");
            }
            this.DeletedAt = deletedAt;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for SecurityEncryptionKeyResponse and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "retrievedAt" is required (not null)
            if (retrievedAt == null)
            {
                throw new ArgumentNullException("retrievedAt is a required property for SecurityEncryptionKeyResponse and cannot be null");
            }
            this.RetrievedAt = retrievedAt;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public System.IO.Stream Key { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name = "deleted_at", IsRequired = true, EmitDefaultValue = false)]
        public string DeletedAt { get; set; }

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
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityEncryptionKeyResponse {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
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
            return this.Equals(input as SecurityEncryptionKeyResponse);
        }

        /// <summary>
        /// Returns true if SecurityEncryptionKeyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityEncryptionKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityEncryptionKeyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
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
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
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
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.DeletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeletedAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.RetrievedAt != null)
                {
                    hashCode = (hashCode * 59) + this.RetrievedAt.GetHashCode();
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
