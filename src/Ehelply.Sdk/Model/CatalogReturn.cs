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
    /// CatalogReturn
    /// </summary>
    [DataContract(Name = "CatalogReturn")]
    public partial class CatalogReturn : IEquatable<CatalogReturn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogReturn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CatalogReturn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogReturn" /> class.
        /// </summary>
        /// <param name="metaData">metaData.</param>
        /// <param name="name">name.</param>
        /// <param name="featured">featured.</param>
        /// <param name="subCatalogs">subCatalogs.</param>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="metaUuid">metaUuid.</param>
        /// <param name="projectUuid">projectUuid (required).</param>
        /// <param name="productUuids">productUuids.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="deletedAt">deletedAt.</param>
        public CatalogReturn(Object metaData = default(Object), string name = default(string), Object featured = default(Object), Object subCatalogs = default(Object), string uuid = default(string), string metaUuid = default(string), string projectUuid = default(string), List<string> productUuids = default(List<string>), string createdAt = default(string), string updatedAt = default(string), string deletedAt = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for CatalogReturn and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "projectUuid" is required (not null)
            if (projectUuid == null)
            {
                throw new ArgumentNullException("projectUuid is a required property for CatalogReturn and cannot be null");
            }
            this.ProjectUuid = projectUuid;
            this.MetaData = metaData;
            this.Name = name;
            this.Featured = featured;
            this.SubCatalogs = subCatalogs;
            this.MetaUuid = metaUuid;
            this.ProductUuids = productUuids;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name = "meta_data", EmitDefaultValue = false)]
        public Object MetaData { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Featured
        /// </summary>
        [DataMember(Name = "featured", EmitDefaultValue = false)]
        public Object Featured { get; set; }

        /// <summary>
        /// Gets or Sets SubCatalogs
        /// </summary>
        [DataMember(Name = "sub_catalogs", EmitDefaultValue = false)]
        public Object SubCatalogs { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets MetaUuid
        /// </summary>
        [DataMember(Name = "meta_uuid", EmitDefaultValue = false)]
        public string MetaUuid { get; set; }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Gets or Sets ProductUuids
        /// </summary>
        [DataMember(Name = "product_uuids", EmitDefaultValue = false)]
        public List<string> ProductUuids { get; set; }

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
            sb.Append("class CatalogReturn {\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Featured: ").Append(Featured).Append("\n");
            sb.Append("  SubCatalogs: ").Append(SubCatalogs).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  MetaUuid: ").Append(MetaUuid).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  ProductUuids: ").Append(ProductUuids).Append("\n");
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
            return this.Equals(input as CatalogReturn);
        }

        /// <summary>
        /// Returns true if CatalogReturn instances are equal
        /// </summary>
        /// <param name="input">Instance of CatalogReturn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogReturn input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Featured == input.Featured ||
                    (this.Featured != null &&
                    this.Featured.Equals(input.Featured))
                ) && 
                (
                    this.SubCatalogs == input.SubCatalogs ||
                    (this.SubCatalogs != null &&
                    this.SubCatalogs.Equals(input.SubCatalogs))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.MetaUuid == input.MetaUuid ||
                    (this.MetaUuid != null &&
                    this.MetaUuid.Equals(input.MetaUuid))
                ) && 
                (
                    this.ProjectUuid == input.ProjectUuid ||
                    (this.ProjectUuid != null &&
                    this.ProjectUuid.Equals(input.ProjectUuid))
                ) && 
                (
                    this.ProductUuids == input.ProductUuids ||
                    this.ProductUuids != null &&
                    input.ProductUuids != null &&
                    this.ProductUuids.SequenceEqual(input.ProductUuids)
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
                if (this.MetaData != null)
                {
                    hashCode = (hashCode * 59) + this.MetaData.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Featured != null)
                {
                    hashCode = (hashCode * 59) + this.Featured.GetHashCode();
                }
                if (this.SubCatalogs != null)
                {
                    hashCode = (hashCode * 59) + this.SubCatalogs.GetHashCode();
                }
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.MetaUuid != null)
                {
                    hashCode = (hashCode * 59) + this.MetaUuid.GetHashCode();
                }
                if (this.ProjectUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectUuid.GetHashCode();
                }
                if (this.ProductUuids != null)
                {
                    hashCode = (hashCode * 59) + this.ProductUuids.GetHashCode();
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
