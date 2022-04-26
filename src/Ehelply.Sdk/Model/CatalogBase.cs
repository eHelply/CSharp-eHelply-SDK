/*
 * eHelply SDK - 1.1.56
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.56
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
    /// CatalogBase
    /// </summary>
    [DataContract(Name = "CatalogBase")]
    public partial class CatalogBase : IEquatable<CatalogBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogBase" /> class.
        /// </summary>
        /// <param name="metaData">metaData.</param>
        /// <param name="name">name.</param>
        /// <param name="featured">featured.</param>
        /// <param name="subCatalogs">subCatalogs.</param>
        public CatalogBase(Object metaData = default(Object), string name = default(string), Object featured = default(Object), Object subCatalogs = default(Object))
        {
            this.MetaData = metaData;
            this.Name = name;
            this.Featured = featured;
            this.SubCatalogs = subCatalogs;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogBase {\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Featured: ").Append(Featured).Append("\n");
            sb.Append("  SubCatalogs: ").Append(SubCatalogs).Append("\n");
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
            return this.Equals(input as CatalogBase);
        }

        /// <summary>
        /// Returns true if CatalogBase instances are equal
        /// </summary>
        /// <param name="input">Instance of CatalogBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogBase input)
        {
            if (input == null)
                return false;

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
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Featured != null)
                    hashCode = hashCode * 59 + this.Featured.GetHashCode();
                if (this.SubCatalogs != null)
                    hashCode = hashCode * 59 + this.SubCatalogs.GetHashCode();
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
