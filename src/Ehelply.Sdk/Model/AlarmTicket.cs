/*
 * eHelply SDK - 1.1.77
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.77
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
    /// AlarmTicket
    /// </summary>
    [DataContract(Name = "AlarmTicket")]
    public partial class AlarmTicket : IEquatable<AlarmTicket>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmTicket" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlarmTicket() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmTicket" /> class.
        /// </summary>
        /// <param name="ticketUuid">ticketUuid (required).</param>
        public AlarmTicket(string ticketUuid = default(string))
        {
            // to ensure "ticketUuid" is required (not null)
            if (ticketUuid == null)
            {
                throw new ArgumentNullException("ticketUuid is a required property for AlarmTicket and cannot be null");
            }
            this.TicketUuid = ticketUuid;
        }

        /// <summary>
        /// Gets or Sets TicketUuid
        /// </summary>
        [DataMember(Name = "ticket_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string TicketUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlarmTicket {\n");
            sb.Append("  TicketUuid: ").Append(TicketUuid).Append("\n");
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
            return this.Equals(input as AlarmTicket);
        }

        /// <summary>
        /// Returns true if AlarmTicket instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmTicket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmTicket input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TicketUuid == input.TicketUuid ||
                    (this.TicketUuid != null &&
                    this.TicketUuid.Equals(input.TicketUuid))
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
                if (this.TicketUuid != null)
                {
                    hashCode = (hashCode * 59) + this.TicketUuid.GetHashCode();
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
