/*
 * eHelply SDK - 1.1.78
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.78
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
    /// ProductBase
    /// </summary>
    [DataContract(Name = "ProductBase")]
    public partial class ProductBase : IEquatable<ProductBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBase" /> class.
        /// </summary>
        /// <param name="metaData">metaData.</param>
        /// <param name="collectionUuid">collectionUuid.</param>
        /// <param name="reviewGroupUuid">reviewGroupUuid.</param>
        /// <param name="addons">addons.</param>
        /// <param name="name">name.</param>
        /// <param name="price">price (required).</param>
        /// <param name="quantityForPublic">quantityForPublic (required).</param>
        public ProductBase(Object metaData = default(Object), string collectionUuid = default(string), string reviewGroupUuid = default(string), List<string> addons = default(List<string>), string name = default(string), int price = default(int), int quantityForPublic = default(int))
        {
            this.Price = price;
            this.QuantityForPublic = quantityForPublic;
            this.MetaData = metaData;
            this.CollectionUuid = collectionUuid;
            this.ReviewGroupUuid = reviewGroupUuid;
            this.Addons = addons;
            this.Name = name;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductBase {\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  CollectionUuid: ").Append(CollectionUuid).Append("\n");
            sb.Append("  ReviewGroupUuid: ").Append(ReviewGroupUuid).Append("\n");
            sb.Append("  Addons: ").Append(Addons).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  QuantityForPublic: ").Append(QuantityForPublic).Append("\n");
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
            return this.Equals(input as ProductBase);
        }

        /// <summary>
        /// Returns true if ProductBase instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductBase input)
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
