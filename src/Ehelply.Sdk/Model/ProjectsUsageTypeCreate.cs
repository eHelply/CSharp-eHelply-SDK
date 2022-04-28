/*
 * eHelply SDK - 1.1.73
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.73
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
    /// Used for create endpoint
    /// </summary>
    [DataContract(Name = "ProjectsUsageTypeCreate")]
    public partial class ProjectsUsageTypeCreate : IEquatable<ProjectsUsageTypeCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUsageTypeCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectsUsageTypeCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUsageTypeCreate" /> class.
        /// </summary>
        /// <param name="key">key (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="summary">summary (required).</param>
        /// <param name="category">category (required).</param>
        /// <param name="service">service (required).</param>
        /// <param name="unitPrices">unitPrices (required).</param>
        public ProjectsUsageTypeCreate(string key = default(string), string name = default(string), string summary = default(string), string category = default(string), string service = default(string), List<ProjectsUsageTypeUnitPrice> unitPrices = default(List<ProjectsUsageTypeUnitPrice>))
        {
            // to ensure "key" is required (not null)
            if (key == null) {
                throw new ArgumentNullException("key is a required property for ProjectsUsageTypeCreate and cannot be null");
            }
            this.Key = key;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for ProjectsUsageTypeCreate and cannot be null");
            }
            this.Name = name;
            // to ensure "summary" is required (not null)
            if (summary == null) {
                throw new ArgumentNullException("summary is a required property for ProjectsUsageTypeCreate and cannot be null");
            }
            this.Summary = summary;
            // to ensure "category" is required (not null)
            if (category == null) {
                throw new ArgumentNullException("category is a required property for ProjectsUsageTypeCreate and cannot be null");
            }
            this.Category = category;
            // to ensure "service" is required (not null)
            if (service == null) {
                throw new ArgumentNullException("service is a required property for ProjectsUsageTypeCreate and cannot be null");
            }
            this.Service = service;
            // to ensure "unitPrices" is required (not null)
            if (unitPrices == null) {
                throw new ArgumentNullException("unitPrices is a required property for ProjectsUsageTypeCreate and cannot be null");
            }
            this.UnitPrices = unitPrices;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", IsRequired = true, EmitDefaultValue = false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", IsRequired = true, EmitDefaultValue = false)]
        public string Service { get; set; }

        /// <summary>
        /// Gets or Sets UnitPrices
        /// </summary>
        [DataMember(Name = "unit_prices", IsRequired = true, EmitDefaultValue = false)]
        public List<ProjectsUsageTypeUnitPrice> UnitPrices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsUsageTypeCreate {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as ProjectsUsageTypeCreate);
        }

        /// <summary>
        /// Returns true if ProjectsUsageTypeCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectsUsageTypeCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectsUsageTypeCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.UnitPrices != null)
                    hashCode = hashCode * 59 + this.UnitPrices.GetHashCode();
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
