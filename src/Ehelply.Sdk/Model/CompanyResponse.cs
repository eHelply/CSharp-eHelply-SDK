/*
 * eHelply SDK - 1.1.117
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.117
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
    /// **:param** name                                **type:** string **:param** summary                             **type:** string or None  **:param** public                              **type:** bool or None  **:param** meta                                **type:** dict or None  **:param** contact                             **type:** ContactBase or None
    /// </summary>
    [DataContract(Name = "CompanyResponse")]
    public partial class CompanyResponse : IEquatable<CompanyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyResponse" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="summary">summary.</param>
        /// <param name="_public">_public (default to true).</param>
        /// <param name="meta">meta.</param>
        /// <param name="contact">contact.</param>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="projectUuid">projectUuid.</param>
        /// <param name="metaUuid">metaUuid.</param>
        /// <param name="tags">tags.</param>
        /// <param name="categories">categories.</param>
        /// <param name="places">places.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="deletedAt">deletedAt.</param>
        public CompanyResponse(string name = default(string), string summary = default(string), bool _public = true, Object meta = default(Object), ContactBase contact = default(ContactBase), string uuid = default(string), string projectUuid = default(string), string metaUuid = default(string), List<TagBase> tags = default(List<TagBase>), List<CategoryBase> categories = default(List<CategoryBase>), List<PlaceBase> places = default(List<PlaceBase>), string createdAt = default(string), string updatedAt = default(string), string deletedAt = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for CompanyResponse and cannot be null");
            }
            this.Uuid = uuid;
            this.Name = name;
            this.Summary = summary;
            this.Public = _public;
            this.Meta = meta;
            this.Contact = contact;
            this.ProjectUuid = projectUuid;
            this.MetaUuid = metaUuid;
            this.Tags = tags;
            this.Categories = categories;
            this.Places = places;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Public
        /// </summary>
        [DataMember(Name = "public", EmitDefaultValue = true)]
        public bool Public { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public Object Meta { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public ContactBase Contact { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Gets or Sets MetaUuid
        /// </summary>
        [DataMember(Name = "meta_uuid", EmitDefaultValue = false)]
        public string MetaUuid { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<TagBase> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<CategoryBase> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Places
        /// </summary>
        [DataMember(Name = "places", EmitDefaultValue = false)]
        public List<PlaceBase> Places { get; set; }

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
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name = "deleted_at", EmitDefaultValue = false)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  MetaUuid: ").Append(MetaUuid).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Places: ").Append(Places).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
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
            return this.Equals(input as CompanyResponse);
        }

        /// <summary>
        /// Returns true if CompanyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyResponse input)
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
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Public == input.Public ||
                    this.Public.Equals(input.Public)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.ProjectUuid == input.ProjectUuid ||
                    (this.ProjectUuid != null &&
                    this.ProjectUuid.Equals(input.ProjectUuid))
                ) && 
                (
                    this.MetaUuid == input.MetaUuid ||
                    (this.MetaUuid != null &&
                    this.MetaUuid.Equals(input.MetaUuid))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Places == input.Places ||
                    this.Places != null &&
                    input.Places != null &&
                    this.Places.SequenceEqual(input.Places)
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
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
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
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Public.GetHashCode();
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
                }
                if (this.Contact != null)
                {
                    hashCode = (hashCode * 59) + this.Contact.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.ProjectUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectUuid.GetHashCode();
                }
                if (this.MetaUuid != null)
                {
                    hashCode = (hashCode * 59) + this.MetaUuid.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.Places != null)
                {
                    hashCode = (hashCode * 59) + this.Places.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.DeletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeletedAt.GetHashCode();
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
