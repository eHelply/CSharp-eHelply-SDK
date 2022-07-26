/*
 * eHelply SDK - 1.1.102
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.102
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
    /// ProductReturn
    /// </summary>
    [DataContract(Name = "ProductReturn")]
    public partial class ProductReturn : IEquatable<ProductReturn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductReturn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductReturn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductReturn" /> class.
        /// </summary>
        /// <param name="metaData">metaData.</param>
        /// <param name="collectionUuid">collectionUuid.</param>
        /// <param name="reviewGroupUuid">reviewGroupUuid.</param>
        /// <param name="addons">addons.</param>
        /// <param name="name">name.</param>
        /// <param name="price">price (required).</param>
        /// <param name="quantityForPublic">quantityForPublic (required).</param>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="metaUuid">metaUuid.</param>
        /// <param name="projectUuid">projectUuid (required).</param>
        /// <param name="catalogUuid">catalogUuid.</param>
        /// <param name="addonList">addonList.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="deletedAt">deletedAt.</param>
        public ProductReturn(Object metaData = default(Object), string collectionUuid = default(string), string reviewGroupUuid = default(string), List<string> addons = default(List<string>), string name = default(string), int price = default(int), int quantityForPublic = default(int), string uuid = default(string), string metaUuid = default(string), string projectUuid = default(string), string catalogUuid = default(string), List<Object> addonList = default(List<Object>), string createdAt = default(string), string updatedAt = default(string), string deletedAt = default(string))
        {
            this.Price = price;
            this.QuantityForPublic = quantityForPublic;
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for ProductReturn and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "projectUuid" is required (not null)
            if (projectUuid == null)
            {
                throw new ArgumentNullException("projectUuid is a required property for ProductReturn and cannot be null");
            }
            this.ProjectUuid = projectUuid;
            this.MetaData = metaData;
            this.CollectionUuid = collectionUuid;
            this.ReviewGroupUuid = reviewGroupUuid;
            this.Addons = addons;
            this.Name = name;
            this.MetaUuid = metaUuid;
            this.CatalogUuid = catalogUuid;
            this.AddonList = addonList;
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
        /// Gets or Sets CollectionUuid
        /// </summary>
        [DataMember(Name = "collection_uuid", EmitDefaultValue = false)]
        public string CollectionUuid { get; set; }

        /// <summary>
        /// Gets or Sets ReviewGroupUuid
        /// </summary>
        [DataMember(Name = "review_group_uuid", EmitDefaultValue = false)]
        public string ReviewGroupUuid { get; set; }

        /// <summary>
        /// Gets or Sets Addons
        /// </summary>
        [DataMember(Name = "addons", EmitDefaultValue = false)]
        public List<string> Addons { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = false)]
        public int Price { get; set; }

        /// <summary>
        /// Gets or Sets QuantityForPublic
        /// </summary>
        [DataMember(Name = "quantity_for_public", IsRequired = true, EmitDefaultValue = false)]
        public int QuantityForPublic { get; set; }

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
        /// Gets or Sets CatalogUuid
        /// </summary>
        [DataMember(Name = "catalog_uuid", EmitDefaultValue = false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// Gets or Sets AddonList
        /// </summary>
        [DataMember(Name = "addon_list", EmitDefaultValue = false)]
        public List<Object> AddonList { get; set; }

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
            sb.Append("class ProductReturn {\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  CollectionUuid: ").Append(CollectionUuid).Append("\n");
            sb.Append("  ReviewGroupUuid: ").Append(ReviewGroupUuid).Append("\n");
            sb.Append("  Addons: ").Append(Addons).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  QuantityForPublic: ").Append(QuantityForPublic).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  MetaUuid: ").Append(MetaUuid).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  CatalogUuid: ").Append(CatalogUuid).Append("\n");
            sb.Append("  AddonList: ").Append(AddonList).Append("\n");
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
            return this.Equals(input as ProductReturn);
        }

        /// <summary>
        /// Returns true if ProductReturn instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductReturn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductReturn input)
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
                    this.CollectionUuid == input.CollectionUuid ||
                    (this.CollectionUuid != null &&
                    this.CollectionUuid.Equals(input.CollectionUuid))
                ) && 
                (
                    this.ReviewGroupUuid == input.ReviewGroupUuid ||
                    (this.ReviewGroupUuid != null &&
                    this.ReviewGroupUuid.Equals(input.ReviewGroupUuid))
                ) && 
                (
                    this.Addons == input.Addons ||
                    this.Addons != null &&
                    input.Addons != null &&
                    this.Addons.SequenceEqual(input.Addons)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.QuantityForPublic == input.QuantityForPublic ||
                    this.QuantityForPublic.Equals(input.QuantityForPublic)
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
                    this.CatalogUuid == input.CatalogUuid ||
                    (this.CatalogUuid != null &&
                    this.CatalogUuid.Equals(input.CatalogUuid))
                ) && 
                (
                    this.AddonList == input.AddonList ||
                    this.AddonList != null &&
                    input.AddonList != null &&
                    this.AddonList.SequenceEqual(input.AddonList)
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
                if (this.CollectionUuid != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionUuid.GetHashCode();
                }
                if (this.ReviewGroupUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ReviewGroupUuid.GetHashCode();
                }
                if (this.Addons != null)
                {
                    hashCode = (hashCode * 59) + this.Addons.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                hashCode = (hashCode * 59) + this.QuantityForPublic.GetHashCode();
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
                if (this.CatalogUuid != null)
                {
                    hashCode = (hashCode * 59) + this.CatalogUuid.GetHashCode();
                }
                if (this.AddonList != null)
                {
                    hashCode = (hashCode * 59) + this.AddonList.GetHashCode();
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
