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
    /// Tax
    /// </summary>
    [DataContract(Name = "Tax")]
    public partial class Tax : IEquatable<Tax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tax" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tax() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tax" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="rate">rate (required).</param>
        public Tax(string name = default(string), int rate = default(int))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Tax and cannot be null");
            }
            this.Name = name;
            this.Rate = rate;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name = "rate", IsRequired = true, EmitDefaultValue = false)]
        public int Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Tax {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return this.Equals(input as Tax);
        }

        /// <summary>
        /// Returns true if Tax instances are equal
        /// </summary>
        /// <param name="input">Instance of Tax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tax input)
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
                    this.Rate == input.Rate ||
                    this.Rate.Equals(input.Rate)
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
                hashCode = (hashCode * 59) + this.Rate.GetHashCode();
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
