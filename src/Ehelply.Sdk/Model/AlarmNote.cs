/*
 * eHelply SDK - 1.1.47
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.47
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
    /// AlarmNote
    /// </summary>
    [DataContract(Name = "AlarmNote")]
    public partial class AlarmNote : IEquatable<AlarmNote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmNote" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlarmNote() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmNote" /> class.
        /// </summary>
        /// <param name="authorUuid">authorUuid (required).</param>
        /// <param name="message">message (required).</param>
        public AlarmNote(string authorUuid = default(string), string message = default(string))
        {
            // to ensure "authorUuid" is required (not null)
            if (authorUuid == null) {
                throw new ArgumentNullException("authorUuid is a required property for AlarmNote and cannot be null");
            }
            this.AuthorUuid = authorUuid;
            // to ensure "message" is required (not null)
            if (message == null) {
                throw new ArgumentNullException("message is a required property for AlarmNote and cannot be null");
            }
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets AuthorUuid
        /// </summary>
        [DataMember(Name = "author_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string AuthorUuid { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmNote {\n");
            sb.Append("  AuthorUuid: ").Append(AuthorUuid).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AlarmNote);
        }

        /// <summary>
        /// Returns true if AlarmNote instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmNote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthorUuid == input.AuthorUuid ||
                    (this.AuthorUuid != null &&
                    this.AuthorUuid.Equals(input.AuthorUuid))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.AuthorUuid != null)
                    hashCode = hashCode * 59 + this.AuthorUuid.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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