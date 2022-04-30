/*
 * eHelply SDK - 1.1.71
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.71
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
    /// BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost
    /// </summary>
    [DataContract(Name = "Body_attach_alarm_ticket_monitor_services__service__stages__stage__alarms__alarm_uuid__ticket_post")]
    public partial class BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost : IEquatable<BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost" /> class.
        /// </summary>
        /// <param name="ticket">ticket (required).</param>
        public BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost(AlarmTicket ticket = default(AlarmTicket))
        {
            // to ensure "ticket" is required (not null)
            if (ticket == null)
            {
                throw new ArgumentNullException("ticket is a required property for BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost and cannot be null");
            }
            this.Ticket = ticket;
        }

        /// <summary>
        /// Gets or Sets Ticket
        /// </summary>
        [DataMember(Name = "ticket", IsRequired = true, EmitDefaultValue = false)]
        public AlarmTicket Ticket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost {\n");
            sb.Append("  Ticket: ").Append(Ticket).Append("\n");
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
            return this.Equals(input as BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost);
        }

        /// <summary>
        /// Returns true if BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ticket == input.Ticket ||
                    (this.Ticket != null &&
                    this.Ticket.Equals(input.Ticket))
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
                if (this.Ticket != null)
                {
                    hashCode = (hashCode * 59) + this.Ticket.GetHashCode();
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
