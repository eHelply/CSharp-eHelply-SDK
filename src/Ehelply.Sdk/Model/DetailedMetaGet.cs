/*
 * eHelply SDK - 1.1.98
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.98
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
    /// Detailed meta based on Notes
    /// </summary>
    [DataContract(Name = "DetailedMetaGet")]
    public partial class DetailedMetaGet : IEquatable<DetailedMetaGet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedMetaGet" /> class.
        /// </summary>
        /// <param name="summary">summary.</param>
        /// <param name="description">description.</param>
        /// <param name="summaryHistory">summaryHistory.</param>
        /// <param name="descriptionHistory">descriptionHistory.</param>
        public DetailedMetaGet(string summary = default(string), string description = default(string), List<string> summaryHistory = default(List<string>), List<string> descriptionHistory = default(List<string>))
        {
            this.Summary = summary;
            this.Description = description;
            this.SummaryHistory = summaryHistory;
            this.DescriptionHistory = descriptionHistory;
        }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets SummaryHistory
        /// </summary>
        [DataMember(Name = "summary_history", EmitDefaultValue = false)]
        public List<string> SummaryHistory { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionHistory
        /// </summary>
        [DataMember(Name = "description_history", EmitDefaultValue = false)]
        public List<string> DescriptionHistory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DetailedMetaGet {\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SummaryHistory: ").Append(SummaryHistory).Append("\n");
            sb.Append("  DescriptionHistory: ").Append(DescriptionHistory).Append("\n");
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
            return this.Equals(input as DetailedMetaGet);
        }

        /// <summary>
        /// Returns true if DetailedMetaGet instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedMetaGet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedMetaGet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SummaryHistory == input.SummaryHistory ||
                    this.SummaryHistory != null &&
                    input.SummaryHistory != null &&
                    this.SummaryHistory.SequenceEqual(input.SummaryHistory)
                ) && 
                (
                    this.DescriptionHistory == input.DescriptionHistory ||
                    this.DescriptionHistory != null &&
                    input.DescriptionHistory != null &&
                    this.DescriptionHistory.SequenceEqual(input.DescriptionHistory)
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
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.SummaryHistory != null)
                {
                    hashCode = (hashCode * 59) + this.SummaryHistory.GetHashCode();
                }
                if (this.DescriptionHistory != null)
                {
                    hashCode = (hashCode * 59) + this.DescriptionHistory.GetHashCode();
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
