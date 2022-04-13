/*
 * eHelply SDK - 1.1.53
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.53
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
    /// ProjectsUsageTypeUnitPrice
    /// </summary>
    [DataContract(Name = "ProjectsUsageTypeUnitPrice")]
    public partial class ProjectsUsageTypeUnitPrice : IEquatable<ProjectsUsageTypeUnitPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUsageTypeUnitPrice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectsUsageTypeUnitPrice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUsageTypeUnitPrice" /> class.
        /// </summary>
        /// <param name="minQuantity">minQuantity (required).</param>
        /// <param name="maxQuantity">maxQuantity (required).</param>
        /// <param name="unitPrice">unitPrice (required).</param>
        public ProjectsUsageTypeUnitPrice(int minQuantity = default(int), int maxQuantity = default(int), int unitPrice = default(int))
        {
            this.MinQuantity = minQuantity;
            this.MaxQuantity = maxQuantity;
            this.UnitPrice = unitPrice;
        }

        /// <summary>
        /// Gets or Sets MinQuantity
        /// </summary>
        [DataMember(Name = "min_quantity", IsRequired = true, EmitDefaultValue = false)]
        public int MinQuantity { get; set; }

        /// <summary>
        /// Gets or Sets MaxQuantity
        /// </summary>
        [DataMember(Name = "max_quantity", IsRequired = true, EmitDefaultValue = false)]
        public int MaxQuantity { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrice
        /// </summary>
        [DataMember(Name = "unit_price", IsRequired = true, EmitDefaultValue = false)]
        public int UnitPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsUsageTypeUnitPrice {\n");
            sb.Append("  MinQuantity: ").Append(MinQuantity).Append("\n");
            sb.Append("  MaxQuantity: ").Append(MaxQuantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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
            return this.Equals(input as ProjectsUsageTypeUnitPrice);
        }

        /// <summary>
        /// Returns true if ProjectsUsageTypeUnitPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectsUsageTypeUnitPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectsUsageTypeUnitPrice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MinQuantity == input.MinQuantity ||
                    this.MinQuantity.Equals(input.MinQuantity)
                ) && 
                (
                    this.MaxQuantity == input.MaxQuantity ||
                    this.MaxQuantity.Equals(input.MaxQuantity)
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    this.UnitPrice.Equals(input.UnitPrice)
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
                hashCode = hashCode * 59 + this.MinQuantity.GetHashCode();
                hashCode = hashCode * 59 + this.MaxQuantity.GetHashCode();
                hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
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
