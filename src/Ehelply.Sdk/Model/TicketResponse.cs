/*
 * eHelply SDK - 1.1.51
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.51
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
    /// TicketResponse
    /// </summary>
    [DataContract(Name = "TicketResponse")]
    public partial class TicketResponse : IEquatable<TicketResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TicketResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketResponse" /> class.
        /// </summary>
        /// <param name="ticketId">ticketId (required).</param>
        /// <param name="contactId">contactId (required).</param>
        /// <param name="subject">subject (required).</param>
        /// <param name="priority">priority (required).</param>
        public TicketResponse(string ticketId = default(string), string contactId = default(string), string subject = default(string), string priority = default(string))
        {
            // to ensure "ticketId" is required (not null)
            if (ticketId == null) {
                throw new ArgumentNullException("ticketId is a required property for TicketResponse and cannot be null");
            }
            this.TicketId = ticketId;
            // to ensure "contactId" is required (not null)
            if (contactId == null) {
                throw new ArgumentNullException("contactId is a required property for TicketResponse and cannot be null");
            }
            this.ContactId = contactId;
            // to ensure "subject" is required (not null)
            if (subject == null) {
                throw new ArgumentNullException("subject is a required property for TicketResponse and cannot be null");
            }
            this.Subject = subject;
            // to ensure "priority" is required (not null)
            if (priority == null) {
                throw new ArgumentNullException("priority is a required property for TicketResponse and cannot be null");
            }
            this.Priority = priority;
        }

        /// <summary>
        /// Gets or Sets TicketId
        /// </summary>
        [DataMember(Name = "ticket_id", IsRequired = true, EmitDefaultValue = false)]
        public string TicketId { get; set; }

        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [DataMember(Name = "contact_id", IsRequired = true, EmitDefaultValue = false)]
        public string ContactId { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name = "priority", IsRequired = true, EmitDefaultValue = false)]
        public string Priority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TicketResponse {\n");
            sb.Append("  TicketId: ").Append(TicketId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
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
            return this.Equals(input as TicketResponse);
        }

        /// <summary>
        /// Returns true if TicketResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TicketResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TicketId == input.TicketId ||
                    (this.TicketId != null &&
                    this.TicketId.Equals(input.TicketId))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
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
                if (this.TicketId != null)
                    hashCode = hashCode * 59 + this.TicketId.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
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
