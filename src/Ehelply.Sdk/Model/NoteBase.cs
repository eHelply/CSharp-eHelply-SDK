/*
 * eHelply SDK - 1.1.73
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.73
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
    /// Note This is used as the payload to endpoints
    /// </summary>
    [DataContract(Name = "NoteBase")]
    public partial class NoteBase : IEquatable<NoteBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NoteBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteBase" /> class.
        /// </summary>
        /// <param name="content">content (required).</param>
        /// <param name="time">time (required).</param>
        /// <param name="meta">meta (required).</param>
        public NoteBase(string content = default(string), string time = default(string), NoteMeta meta = default(NoteMeta))
        {
            // to ensure "content" is required (not null)
            if (content == null) {
                throw new ArgumentNullException("content is a required property for NoteBase and cannot be null");
            }
            this.Content = content;
            // to ensure "time" is required (not null)
            if (time == null) {
                throw new ArgumentNullException("time is a required property for NoteBase and cannot be null");
            }
            this.Time = time;
            // to ensure "meta" is required (not null)
            if (meta == null) {
                throw new ArgumentNullException("meta is a required property for NoteBase and cannot be null");
            }
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", IsRequired = true, EmitDefaultValue = false)]
        public string Time { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", IsRequired = true, EmitDefaultValue = false)]
        public NoteMeta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NoteBase {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as NoteBase);
        }

        /// <summary>
        /// Returns true if NoteBase instances are equal
        /// </summary>
        /// <param name="input">Instance of NoteBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoteBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
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
