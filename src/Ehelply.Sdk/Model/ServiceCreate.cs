/*
 * eHelply SDK - 1.1.74
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.74
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
    /// ServiceCreate
    /// </summary>
    [DataContract(Name = "ServiceCreate")]
    public partial class ServiceCreate : IEquatable<ServiceCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceCreate" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="key">key (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="summary">summary (required).</param>
        /// <param name="authors">authors (required).</param>
        /// <param name="authorEmails">authorEmails (required).</param>
        public ServiceCreate(string name = default(string), string key = default(string), string version = default(string), string summary = default(string), List<string> authors = default(List<string>), List<string> authorEmails = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ServiceCreate and cannot be null");
            }
            this.Name = name;
            // to ensure "key" is required (not null)
            if (key == null) {
                throw new ArgumentNullException("key is a required property for ServiceCreate and cannot be null");
            }
            this.Key = key;
            // to ensure "version" is required (not null)
            if (version == null) {
                throw new ArgumentNullException("version is a required property for ServiceCreate and cannot be null");
            }
            this._Version = version;
            // to ensure "summary" is required (not null)
            if (summary == null) {
                throw new ArgumentNullException("summary is a required property for ServiceCreate and cannot be null");
            }
            this.Summary = summary;
            // to ensure "authors" is required (not null)
            if (authors == null) {
                throw new ArgumentNullException("authors is a required property for ServiceCreate and cannot be null");
            }
            this.Authors = authors;
            // to ensure "authorEmails" is required (not null)
            if (authorEmails == null) {
                throw new ArgumentNullException("authorEmails is a required property for ServiceCreate and cannot be null");
            }
            this.AuthorEmails = authorEmails;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", IsRequired = true, EmitDefaultValue = false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Authors
        /// </summary>
        [DataMember(Name = "authors", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Authors { get; set; }

        /// <summary>
        /// Gets or Sets AuthorEmails
        /// </summary>
        [DataMember(Name = "author_emails", IsRequired = true, EmitDefaultValue = false)]
        public List<string> AuthorEmails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceCreate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  AuthorEmails: ").Append(AuthorEmails).Append("\n");
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
            return this.Equals(input as ServiceCreate);
        }

        /// <summary>
        /// Returns true if ServiceCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Authors == input.Authors ||
                    this.Authors != null &&
                    input.Authors != null &&
                    this.Authors.SequenceEqual(input.Authors)
                ) && 
                (
                    this.AuthorEmails == input.AuthorEmails ||
                    this.AuthorEmails != null &&
                    input.AuthorEmails != null &&
                    this.AuthorEmails.SequenceEqual(input.AuthorEmails)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Authors != null)
                    hashCode = hashCode * 59 + this.Authors.GetHashCode();
                if (this.AuthorEmails != null)
                    hashCode = hashCode * 59 + this.AuthorEmails.GetHashCode();
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
