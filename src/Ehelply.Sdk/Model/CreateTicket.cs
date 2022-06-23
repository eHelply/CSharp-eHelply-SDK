/*
 * eHelply SDK - 1.1.92
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.92
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
    /// CreateTicket
    /// </summary>
    [DataContract(Name = "CreateTicket")]
    public partial class CreateTicket : IEquatable<CreateTicket>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTicket" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTicket() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTicket" /> class.
        /// </summary>
        /// <param name="priority">priority (required).</param>
        /// <param name="subject">subject (required).</param>
        public CreateTicket(string priority = default(string), string subject = default(string))
        {
            // to ensure "priority" is required (not null)
            if (priority == null)
            {
                throw new ArgumentNullException("priority is a required property for CreateTicket and cannot be null");
            }
            this.Priority = priority;
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new ArgumentNullException("subject is a required property for CreateTicket and cannot be null");
            }
            this.Subject = subject;
        }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = false)]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTicket {\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as CreateTicket);
        }

        /// <summary>
        /// Returns true if CreateTicket instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTicket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTicket input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.Priority != null)
                {
                    hashCode = (hashCode * 59) + this.Priority.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
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
