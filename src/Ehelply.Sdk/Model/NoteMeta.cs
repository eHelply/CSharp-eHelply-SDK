/*
 * eHelply SDK - 1.1.90
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.90
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
    /// Metadata associated to a note
    /// </summary>
    [DataContract(Name = "NoteMeta")]
    public partial class NoteMeta : IEquatable<NoteMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteMeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NoteMeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteMeta" /> class.
        /// </summary>
        /// <param name="originalAuthor">originalAuthor.</param>
        /// <param name="author">author (required).</param>
        /// <param name="previousVersion">previousVersion.</param>
        /// <param name="nextVersion">nextVersion.</param>
        public NoteMeta(string originalAuthor = default(string), string author = default(string), string previousVersion = default(string), string nextVersion = default(string))
        {
            // to ensure "author" is required (not null)
            if (author == null)
            {
                throw new ArgumentNullException("author is a required property for NoteMeta and cannot be null");
            }
            this.Author = author;
            this.OriginalAuthor = originalAuthor;
            this.PreviousVersion = previousVersion;
            this.NextVersion = nextVersion;
        }

        /// <summary>
        /// Gets or Sets OriginalAuthor
        /// </summary>
        [DataMember(Name = "original_author", EmitDefaultValue = false)]
        public string OriginalAuthor { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", IsRequired = true, EmitDefaultValue = false)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets PreviousVersion
        /// </summary>
        [DataMember(Name = "previous_version", EmitDefaultValue = false)]
        public string PreviousVersion { get; set; }

        /// <summary>
        /// Gets or Sets NextVersion
        /// </summary>
        [DataMember(Name = "next_version", EmitDefaultValue = false)]
        public string NextVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NoteMeta {\n");
            sb.Append("  OriginalAuthor: ").Append(OriginalAuthor).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  PreviousVersion: ").Append(PreviousVersion).Append("\n");
            sb.Append("  NextVersion: ").Append(NextVersion).Append("\n");
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
            return this.Equals(input as NoteMeta);
        }

        /// <summary>
        /// Returns true if NoteMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of NoteMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NoteMeta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OriginalAuthor == input.OriginalAuthor ||
                    (this.OriginalAuthor != null &&
                    this.OriginalAuthor.Equals(input.OriginalAuthor))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.PreviousVersion == input.PreviousVersion ||
                    (this.PreviousVersion != null &&
                    this.PreviousVersion.Equals(input.PreviousVersion))
                ) && 
                (
                    this.NextVersion == input.NextVersion ||
                    (this.NextVersion != null &&
                    this.NextVersion.Equals(input.NextVersion))
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
                if (this.OriginalAuthor != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalAuthor.GetHashCode();
                }
                if (this.Author != null)
                {
                    hashCode = (hashCode * 59) + this.Author.GetHashCode();
                }
                if (this.PreviousVersion != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousVersion.GetHashCode();
                }
                if (this.NextVersion != null)
                {
                    hashCode = (hashCode * 59) + this.NextVersion.GetHashCode();
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
