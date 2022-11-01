/*
 * eHelply SDK - 1.1.117
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.117
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
    /// Information for resetting the new password with a confirmation code
    /// </summary>
    [DataContract(Name = "UserPasswordResetConfirmation")]
    public partial class UserPasswordResetConfirmation : IEquatable<UserPasswordResetConfirmation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPasswordResetConfirmation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserPasswordResetConfirmation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPasswordResetConfirmation" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="confirmationCode">confirmationCode (required).</param>
        /// <param name="password">password (required).</param>
        public UserPasswordResetConfirmation(string email = default(string), string confirmationCode = default(string), string password = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for UserPasswordResetConfirmation and cannot be null");
            }
            this.Email = email;
            // to ensure "confirmationCode" is required (not null)
            if (confirmationCode == null)
            {
                throw new ArgumentNullException("confirmationCode is a required property for UserPasswordResetConfirmation and cannot be null");
            }
            this.ConfirmationCode = confirmationCode;
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new ArgumentNullException("password is a required property for UserPasswordResetConfirmation and cannot be null");
            }
            this.Password = password;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmationCode
        /// </summary>
        [DataMember(Name = "confirmation_code", IsRequired = true, EmitDefaultValue = false)]
        public string ConfirmationCode { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserPasswordResetConfirmation {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ConfirmationCode: ").Append(ConfirmationCode).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as UserPasswordResetConfirmation);
        }

        /// <summary>
        /// Returns true if UserPasswordResetConfirmation instances are equal
        /// </summary>
        /// <param name="input">Instance of UserPasswordResetConfirmation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserPasswordResetConfirmation input)
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
                    this.ConfirmationCode == input.ConfirmationCode ||
                    (this.ConfirmationCode != null &&
                    this.ConfirmationCode.Equals(input.ConfirmationCode))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.ConfirmationCode != null)
                {
                    hashCode = (hashCode * 59) + this.ConfirmationCode.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
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
