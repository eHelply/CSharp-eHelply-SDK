/*
 * eHelply SDK - 1.1.93
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.93
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
    /// **:param** phones                              **type:** List[ContactKeys] or None  **:param** email                               **type:** string or None  **:param** website                             **type:** string or None  **:param** socials                             **type:** List[ContactKeys] or None
    /// </summary>
    [DataContract(Name = "ContactBase")]
    public partial class ContactBase : IEquatable<ContactBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactBase" /> class.
        /// </summary>
        /// <param name="phones">phones.</param>
        /// <param name="email">email.</param>
        /// <param name="website">website.</param>
        /// <param name="socials">socials.</param>
        public ContactBase(List<ContactMethod> phones = default(List<ContactMethod>), string email = default(string), string website = default(string), List<ContactMethod> socials = default(List<ContactMethod>))
        {
            this.Phones = phones;
            this.Email = email;
            this.Website = website;
            this.Socials = socials;
        }

        /// <summary>
        /// Gets or Sets Phones
        /// </summary>
        [DataMember(Name = "phones", EmitDefaultValue = false)]
        public List<ContactMethod> Phones { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public string Website { get; set; }

        /// <summary>
        /// Gets or Sets Socials
        /// </summary>
        [DataMember(Name = "socials", EmitDefaultValue = false)]
        public List<ContactMethod> Socials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContactBase {\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Socials: ").Append(Socials).Append("\n");
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
            return this.Equals(input as ContactBase);
        }

        /// <summary>
        /// Returns true if ContactBase instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactBase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Phones == input.Phones ||
                    this.Phones != null &&
                    input.Phones != null &&
                    this.Phones.SequenceEqual(input.Phones)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.Socials == input.Socials ||
                    this.Socials != null &&
                    input.Socials != null &&
                    this.Socials.SequenceEqual(input.Socials)
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
                if (this.Phones != null)
                {
                    hashCode = (hashCode * 59) + this.Phones.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Website != null)
                {
                    hashCode = (hashCode * 59) + this.Website.GetHashCode();
                }
                if (this.Socials != null)
                {
                    hashCode = (hashCode * 59) + this.Socials.GetHashCode();
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
