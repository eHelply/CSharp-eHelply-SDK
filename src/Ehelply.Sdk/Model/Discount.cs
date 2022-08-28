/*
 * eHelply SDK - 1.1.105
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.105
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
    /// Discount
    /// </summary>
    [DataContract(Name = "Discount")]
    public partial class Discount : IEquatable<Discount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Discount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Discount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Discount" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="rate">rate (required).</param>
        /// <param name="flat">flat (required).</param>
        public Discount(string name = default(string), string description = default(string), int rate = default(int), int flat = default(int))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Discount and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for Discount and cannot be null");
            }
            this.Description = description;
            this.Rate = rate;
            this.Flat = flat;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name = "rate", IsRequired = true, EmitDefaultValue = false)]
        public int Rate { get; set; }

        /// <summary>
        /// Gets or Sets Flat
        /// </summary>
        [DataMember(Name = "flat", IsRequired = true, EmitDefaultValue = false)]
        public int Flat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Discount {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  Flat: ").Append(Flat).Append("\n");
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
            return this.Equals(input as Discount);
        }

        /// <summary>
        /// Returns true if Discount instances are equal
        /// </summary>
        /// <param name="input">Instance of Discount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Discount input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Rate == input.Rate ||
                    this.Rate.Equals(input.Rate)
                ) && 
                (
                    this.Flat == input.Flat ||
                    this.Flat.Equals(input.Flat)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                hashCode = (hashCode * 59) + this.Flat.GetHashCode();
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
