/*
 * eHelply SDK - 1.1.122
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.122
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
    /// CreateProjectInvoice
    /// </summary>
    [DataContract(Name = "CreateProjectInvoice")]
    public partial class CreateProjectInvoice : IEquatable<CreateProjectInvoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectInvoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateProjectInvoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectInvoice" /> class.
        /// </summary>
        /// <param name="year">year (required).</param>
        /// <param name="month">month (required).</param>
        public CreateProjectInvoice(int year = default(int), int month = default(int))
        {
            this.Year = year;
            this.Month = month;
        }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateProjectInvoice {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
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
            return this.Equals(input as CreateProjectInvoice);
        }

        /// <summary>
        /// Returns true if CreateProjectInvoice instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateProjectInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateProjectInvoice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Year == input.Year ||
                    this.Year.Equals(input.Year)
                ) && 
                (
                    this.Month == input.Month ||
                    this.Month.Equals(input.Month)
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
                hashCode = (hashCode * 59) + this.Year.GetHashCode();
                hashCode = (hashCode * 59) + this.Month.GetHashCode();
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
