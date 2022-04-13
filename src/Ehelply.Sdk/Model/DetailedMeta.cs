/*
 * eHelply SDK - 1.1.47
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.47
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
    [DataContract(Name = "DetailedMeta")]
    public partial class DetailedMeta : IEquatable<DetailedMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedMeta" /> class.
        /// </summary>
        /// <param name="summaryUuid">summaryUuid.</param>
        /// <param name="descriptionUuid">descriptionUuid.</param>
        public DetailedMeta(string summaryUuid = default(string), string descriptionUuid = default(string))
        {
            this.SummaryUuid = summaryUuid;
            this.DescriptionUuid = descriptionUuid;
        }

        /// <summary>
        /// Gets or Sets SummaryUuid
        /// </summary>
        [DataMember(Name = "summary_uuid", EmitDefaultValue = false)]
        public string SummaryUuid { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionUuid
        /// </summary>
        [DataMember(Name = "description_uuid", EmitDefaultValue = false)]
        public string DescriptionUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedMeta {\n");
            sb.Append("  SummaryUuid: ").Append(SummaryUuid).Append("\n");
            sb.Append("  DescriptionUuid: ").Append(DescriptionUuid).Append("\n");
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
            return this.Equals(input as DetailedMeta);
        }

        /// <summary>
        /// Returns true if DetailedMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedMeta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SummaryUuid == input.SummaryUuid ||
                    (this.SummaryUuid != null &&
                    this.SummaryUuid.Equals(input.SummaryUuid))
                ) && 
                (
                    this.DescriptionUuid == input.DescriptionUuid ||
                    (this.DescriptionUuid != null &&
                    this.DescriptionUuid.Equals(input.DescriptionUuid))
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
                if (this.SummaryUuid != null)
                    hashCode = hashCode * 59 + this.SummaryUuid.GetHashCode();
                if (this.DescriptionUuid != null)
                    hashCode = hashCode * 59 + this.DescriptionUuid.GetHashCode();
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
