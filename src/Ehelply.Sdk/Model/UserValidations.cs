/*
 * eHelply SDK - 1.1.90
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.90
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
    /// Fields used to validate a user&#39;s field
    /// </summary>
    [DataContract(Name = "UserValidations")]
    public partial class UserValidations : IEquatable<UserValidations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserValidations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserValidations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserValidations" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="validationType">validationType (required).</param>
        public UserValidations(string value = default(string), string validationType = default(string))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for UserValidations and cannot be null");
            }
            this.Value = value;
            // to ensure "validationType" is required (not null)
            if (validationType == null)
            {
                throw new ArgumentNullException("validationType is a required property for UserValidations and cannot be null");
            }
            this.ValidationType = validationType;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets ValidationType
        /// </summary>
        [DataMember(Name = "validation_type", IsRequired = true, EmitDefaultValue = false)]
        public string ValidationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserValidations {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
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
            return this.Equals(input as UserValidations);
        }

        /// <summary>
        /// Returns true if UserValidations instances are equal
        /// </summary>
        /// <param name="input">Instance of UserValidations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserValidations input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ValidationType == input.ValidationType ||
                    (this.ValidationType != null &&
                    this.ValidationType.Equals(input.ValidationType))
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.ValidationType != null)
                {
                    hashCode = (hashCode * 59) + this.ValidationType.GetHashCode();
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
