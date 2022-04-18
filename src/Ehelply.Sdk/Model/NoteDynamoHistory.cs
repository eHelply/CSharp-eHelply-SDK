/*
 * eHelply SDK - 1.1.54
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.54
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
    /// A note from Dynamo DB including n amount of version history of that note
    /// </summary>
    [DataContract(Name = "NoteDynamoHistory")]
    public partial class NoteDynamoHistory : IEquatable<NoteDynamoHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteDynamoHistory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NoteDynamoHistory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteDynamoHistory" /> class.
        /// </summary>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="content">content.</param>
        /// <param name="time">time (required).</param>
        /// <param name="meta">meta (required).</param>
        /// <param name="history">history.</param>
        public NoteDynamoHistory(string uuid = default(string), System.IO.Stream content = default(System.IO.Stream), string time = default(string), NoteMeta meta = default(NoteMeta), List<NoteDynamo> history = default(List<NoteDynamo>))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null) {
                throw new ArgumentNullException("uuid is a required property for NoteDynamoHistory and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "time" is required (not null)
            if (time == null) {
                throw new ArgumentNullException("time is a required property for NoteDynamoHistory and cannot be null");
            }
            this.Time = time;
            // to ensure "meta" is required (not null)
            if (meta == null) {
                throw new ArgumentNullException("meta is a required property for NoteDynamoHistory and cannot be null");
            }
            this.Meta = meta;
            this.Content = content;
            this.History = history;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public System.IO.Stream Content { get; set; }

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
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name = "history", EmitDefaultValue = false)]
        public List<NoteDynamo> History { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NoteDynamoHistory {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
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
            return this.Equals(input as NoteDynamoHistory);
        }

        /// <summary>
        /// Returns true if NoteDynamoHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of NoteDynamoHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoteDynamoHistory input)
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
                ) && 
                (
                    this.History == input.History ||
                    this.History != null &&
                    input.History != null &&
                    this.History.SequenceEqual(input.History)
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.History != null)
                    hashCode = hashCode * 59 + this.History.GetHashCode();
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
