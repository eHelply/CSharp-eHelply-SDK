/*
 * eHelply SDK - 1.1.80
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.80
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
    /// Information to confirm user
    /// </summary>
    [DataContract(Name = "UserConfirmation")]
    public partial class UserConfirmation : IEquatable<UserConfirmation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConfirmation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserConfirmation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserConfirmation" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="verificationCode">verificationCode (required).</param>
        public UserConfirmation(string email = default(string), string verificationCode = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for UserConfirmation and cannot be null");
            }
            this.Email = email;
            // to ensure "verificationCode" is required (not null)
            if (verificationCode == null)
            {
                throw new ArgumentNullException("verificationCode is a required property for UserConfirmation and cannot be null");
            }
            this.VerificationCode = verificationCode;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets VerificationCode
        /// </summary>
        [DataMember(Name = "verification_code", IsRequired = true, EmitDefaultValue = false)]
        public string VerificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserConfirmation {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  VerificationCode: ").Append(VerificationCode).Append("\n");
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
            return this.Equals(input as UserConfirmation);
        }

        /// <summary>
        /// Returns true if UserConfirmation instances are equal
        /// </summary>
        /// <param name="input">Instance of UserConfirmation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserConfirmation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.VerificationCode == input.VerificationCode ||
                    (this.VerificationCode != null &&
                    this.VerificationCode.Equals(input.VerificationCode))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.VerificationCode != null)
                {
                    hashCode = (hashCode * 59) + this.VerificationCode.GetHashCode();
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
