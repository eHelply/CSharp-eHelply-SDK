/*
 * eHelply SDK - 1.1.57
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.57
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
    /// Used for get endpoint
    /// </summary>
    [DataContract(Name = "SecurityKeyGet")]
    public partial class SecurityKeyGet : IEquatable<SecurityKeyGet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityKeyGet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecurityKeyGet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityKeyGet" /> class.
        /// </summary>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="access">access (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="summary">summary (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="lastUsedAt">lastUsedAt (required).</param>
        public SecurityKeyGet(string uuid = default(string), string access = default(string), string name = default(string), string summary = default(string), string createdAt = default(string), string lastUsedAt = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null) {
                throw new ArgumentNullException("uuid is a required property for SecurityKeyGet and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "access" is required (not null)
            if (access == null) {
                throw new ArgumentNullException("access is a required property for SecurityKeyGet and cannot be null");
            }
            this.Access = access;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for SecurityKeyGet and cannot be null");
            }
            this.Name = name;
            // to ensure "summary" is required (not null)
            if (summary == null) {
                throw new ArgumentNullException("summary is a required property for SecurityKeyGet and cannot be null");
            }
            this.Summary = summary;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null) {
                throw new ArgumentNullException("createdAt is a required property for SecurityKeyGet and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "lastUsedAt" is required (not null)
            if (lastUsedAt == null) {
                throw new ArgumentNullException("lastUsedAt is a required property for SecurityKeyGet and cannot be null");
            }
            this.LastUsedAt = lastUsedAt;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", IsRequired = true, EmitDefaultValue = false)]
        public string Access { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", IsRequired = true, EmitDefaultValue = false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastUsedAt
        /// </summary>
        [DataMember(Name = "last_used_at", IsRequired = true, EmitDefaultValue = false)]
        public string LastUsedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityKeyGet {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  LastUsedAt: ").Append(LastUsedAt).Append("\n");
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
            return this.Equals(input as SecurityKeyGet);
        }

        /// <summary>
        /// Returns true if SecurityKeyGet instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityKeyGet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityKeyGet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.LastUsedAt == input.LastUsedAt ||
                    (this.LastUsedAt != null &&
                    this.LastUsedAt.Equals(input.LastUsedAt))
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
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Access != null)
                    hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.LastUsedAt != null)
                    hashCode = hashCode * 59 + this.LastUsedAt.GetHashCode();
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
