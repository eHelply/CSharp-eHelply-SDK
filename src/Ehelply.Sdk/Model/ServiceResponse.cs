/*
 * eHelply SDK - 1.1.120
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.120
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
    /// ServiceResponse
    /// </summary>
    [DataContract(Name = "ServiceResponse")]
    public partial class ServiceResponse : IEquatable<ServiceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResponse" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="key">key (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="summary">summary (required).</param>
        /// <param name="authors">authors (required).</param>
        /// <param name="authorEmails">authorEmails (required).</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="heartbeats">heartbeats.</param>
        /// <param name="alarms">alarms.</param>
        /// <param name="hiddenStages">hiddenStages.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="superstackMeta">superstackMeta.</param>
        public ServiceResponse(string name = default(string), string key = default(string), string version = default(string), string summary = default(string), List<string> authors = default(List<string>), List<string> authorEmails = default(List<string>), string uuid = default(string), List<Object> heartbeats = default(List<Object>), List<AlarmResponse> alarms = default(List<AlarmResponse>), List<string> hiddenStages = default(List<string>), string createdAt = default(string), string updatedAt = default(string), ServiceSuperStackMeta superstackMeta = default(ServiceSuperStackMeta))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ServiceResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for ServiceResponse and cannot be null");
            }
            this.Key = key;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new ArgumentNullException("version is a required property for ServiceResponse and cannot be null");
            }
            this._Version = version;
            // to ensure "summary" is required (not null)
            if (summary == null)
            {
                throw new ArgumentNullException("summary is a required property for ServiceResponse and cannot be null");
            }
            this.Summary = summary;
            // to ensure "authors" is required (not null)
            if (authors == null)
            {
                throw new ArgumentNullException("authors is a required property for ServiceResponse and cannot be null");
            }
            this.Authors = authors;
            // to ensure "authorEmails" is required (not null)
            if (authorEmails == null)
            {
                throw new ArgumentNullException("authorEmails is a required property for ServiceResponse and cannot be null");
            }
            this.AuthorEmails = authorEmails;
            this.Uuid = uuid;
            this.Heartbeats = heartbeats;
            this.Alarms = alarms;
            this.HiddenStages = hiddenStages;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.SuperstackMeta = superstackMeta;
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
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Heartbeats
        /// </summary>
        [DataMember(Name = "heartbeats", EmitDefaultValue = false)]
        public List<Object> Heartbeats { get; set; }

        /// <summary>
        /// Gets or Sets Alarms
        /// </summary>
        [DataMember(Name = "alarms", EmitDefaultValue = false)]
        public List<AlarmResponse> Alarms { get; set; }

        /// <summary>
        /// Gets or Sets HiddenStages
        /// </summary>
        [DataMember(Name = "hidden_stages", EmitDefaultValue = false)]
        public List<string> HiddenStages { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets SuperstackMeta
        /// </summary>
        [DataMember(Name = "superstack_meta", EmitDefaultValue = false)]
        public ServiceSuperStackMeta SuperstackMeta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  AuthorEmails: ").Append(AuthorEmails).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Heartbeats: ").Append(Heartbeats).Append("\n");
            sb.Append("  Alarms: ").Append(Alarms).Append("\n");
            sb.Append("  HiddenStages: ").Append(HiddenStages).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  SuperstackMeta: ").Append(SuperstackMeta).Append("\n");
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
            return this.Equals(input as ServiceResponse);
        }

        /// <summary>
        /// Returns true if ServiceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceResponse input)
        {
            if (input == null)
            {
                return false;
            }
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
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Heartbeats == input.Heartbeats ||
                    this.Heartbeats != null &&
                    input.Heartbeats != null &&
                    this.Heartbeats.SequenceEqual(input.Heartbeats)
                ) && 
                (
                    this.Alarms == input.Alarms ||
                    this.Alarms != null &&
                    input.Alarms != null &&
                    this.Alarms.SequenceEqual(input.Alarms)
                ) && 
                (
                    this.HiddenStages == input.HiddenStages ||
                    this.HiddenStages != null &&
                    input.HiddenStages != null &&
                    this.HiddenStages.SequenceEqual(input.HiddenStages)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.SuperstackMeta == input.SuperstackMeta ||
                    (this.SuperstackMeta != null &&
                    this.SuperstackMeta.Equals(input.SuperstackMeta))
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
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
                }
                if (this.Authors != null)
                {
                    hashCode = (hashCode * 59) + this.Authors.GetHashCode();
                }
                if (this.AuthorEmails != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorEmails.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.Heartbeats != null)
                {
                    hashCode = (hashCode * 59) + this.Heartbeats.GetHashCode();
                }
                if (this.Alarms != null)
                {
                    hashCode = (hashCode * 59) + this.Alarms.GetHashCode();
                }
                if (this.HiddenStages != null)
                {
                    hashCode = (hashCode * 59) + this.HiddenStages.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.SuperstackMeta != null)
                {
                    hashCode = (hashCode * 59) + this.SuperstackMeta.GetHashCode();
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
