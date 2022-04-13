/*
 * eHelply SDK - 1.1.45
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.45
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
    /// ProjectsProjectUsageDB
    /// </summary>
    [DataContract(Name = "ProjectsProjectUsageDB")]
    public partial class ProjectsProjectUsageDB : IEquatable<ProjectsProjectUsageDB>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsProjectUsageDB" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectsProjectUsageDB() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsProjectUsageDB" /> class.
        /// </summary>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="projectUuid">projectUuid (required).</param>
        /// <param name="usageKey">usageKey (required).</param>
        /// <param name="year">year (required).</param>
        /// <param name="month">month (required).</param>
        /// <param name="quantity">quantity (required).</param>
        /// <param name="estimatedCost">estimatedCost (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public ProjectsProjectUsageDB(string uuid = default(string), string projectUuid = default(string), string usageKey = default(string), int year = default(int), int month = default(int), int quantity = default(int), int estimatedCost = default(int), string updatedAt = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null) {
                throw new ArgumentNullException("uuid is a required property for ProjectsProjectUsageDB and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "projectUuid" is required (not null)
            if (projectUuid == null) {
                throw new ArgumentNullException("projectUuid is a required property for ProjectsProjectUsageDB and cannot be null");
            }
            this.ProjectUuid = projectUuid;
            // to ensure "usageKey" is required (not null)
            if (usageKey == null) {
                throw new ArgumentNullException("usageKey is a required property for ProjectsProjectUsageDB and cannot be null");
            }
            this.UsageKey = usageKey;
            this.Year = year;
            this.Month = month;
            this.Quantity = quantity;
            this.EstimatedCost = estimatedCost;
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null) {
                throw new ArgumentNullException("updatedAt is a required property for ProjectsProjectUsageDB and cannot be null");
            }
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Gets or Sets UsageKey
        /// </summary>
        [DataMember(Name = "usage_key", IsRequired = true, EmitDefaultValue = false)]
        public string UsageKey { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", IsRequired = true, EmitDefaultValue = false)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", IsRequired = true, EmitDefaultValue = false)]
        public int Month { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedCost
        /// </summary>
        [DataMember(Name = "estimated_cost", IsRequired = true, EmitDefaultValue = false)]
        public int EstimatedCost { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectsProjectUsageDB {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  UsageKey: ").Append(UsageKey).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  EstimatedCost: ").Append(EstimatedCost).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as ProjectsProjectUsageDB);
        }

        /// <summary>
        /// Returns true if ProjectsProjectUsageDB instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectsProjectUsageDB to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectsProjectUsageDB input)
        {
            if (input == null)
                return false;

            return 
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
                    this.UsageKey == input.UsageKey ||
                    (this.UsageKey != null &&
                    this.UsageKey.Equals(input.UsageKey))
                ) && 
                (
                    this.Year == input.Year ||
                    this.Year.Equals(input.Year)
                ) && 
                (
                    this.Month == input.Month ||
                    this.Month.Equals(input.Month)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.EstimatedCost == input.EstimatedCost ||
                    this.EstimatedCost.Equals(input.EstimatedCost)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.ProjectUuid != null)
                    hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.UsageKey != null)
                    hashCode = hashCode * 59 + this.UsageKey.GetHashCode();
                hashCode = hashCode * 59 + this.Year.GetHashCode();
                hashCode = hashCode * 59 + this.Month.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                hashCode = hashCode * 59 + this.EstimatedCost.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
