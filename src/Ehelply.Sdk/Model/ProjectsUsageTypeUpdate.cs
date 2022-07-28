/*
 * eHelply SDK - 1.1.99
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.99
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
    /// Used for update endpoint
    /// </summary>
    [DataContract(Name = "ProjectsUsageTypeUpdate")]
    public partial class ProjectsUsageTypeUpdate : IEquatable<ProjectsUsageTypeUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUsageTypeUpdate" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="summary">summary.</param>
        /// <param name="category">category.</param>
        /// <param name="service">service.</param>
        /// <param name="unitPrices">unitPrices.</param>
        public ProjectsUsageTypeUpdate(string name = default(string), string summary = default(string), string category = default(string), string service = default(string), List<ProjectsUsageTypeUnitPrice> unitPrices = default(List<ProjectsUsageTypeUnitPrice>))
        {
            this.Name = name;
            this.Summary = summary;
            this.Category = category;
            this.Service = service;
            this.UnitPrices = unitPrices;
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
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", EmitDefaultValue = false)]
        public string Service { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrices
        /// </summary>
        [DataMember(Name = "unit_prices", EmitDefaultValue = false)]
        public List<ProjectsUsageTypeUnitPrice> UnitPrices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectsUsageTypeUpdate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  UnitPrices: ").Append(UnitPrices).Append("\n");
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
            return this.Equals(input as ProjectsUsageTypeUpdate);
        }

        /// <summary>
        /// Returns true if ProjectsUsageTypeUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectsUsageTypeUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectsUsageTypeUpdate input)
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
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.UnitPrices == input.UnitPrices ||
                    this.UnitPrices != null &&
                    input.UnitPrices != null &&
                    this.UnitPrices.SequenceEqual(input.UnitPrices)
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
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
                }
                if (this.UnitPrices != null)
                {
                    hashCode = (hashCode * 59) + this.UnitPrices.GetHashCode();
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
