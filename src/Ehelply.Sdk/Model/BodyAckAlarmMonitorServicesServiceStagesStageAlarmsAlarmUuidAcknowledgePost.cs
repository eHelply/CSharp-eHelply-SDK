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
    /// BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost
    /// </summary>
    [DataContract(Name = "Body_ack_alarm_monitor_services__service__stages__stage__alarms__alarm_uuid__acknowledge_post")]
    public partial class BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost : IEquatable<BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost" /> class.
        /// </summary>
        /// <param name="acknowledge">acknowledge (required).</param>
        public BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost(AlarmAcknowledge acknowledge = default(AlarmAcknowledge))
        {
            // to ensure "acknowledge" is required (not null)
            if (acknowledge == null)
            {
                throw new ArgumentNullException("acknowledge is a required property for BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost and cannot be null");
            }
            this.Acknowledge = acknowledge;
        }

        /// <summary>
        /// Gets or Sets Acknowledge
        /// </summary>
        [DataMember(Name = "acknowledge", IsRequired = true, EmitDefaultValue = false)]
        public AlarmAcknowledge Acknowledge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost {\n");
            sb.Append("  Acknowledge: ").Append(Acknowledge).Append("\n");
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
            return this.Equals(input as BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost);
        }

        /// <summary>
        /// Returns true if BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Acknowledge == input.Acknowledge ||
                    (this.Acknowledge != null &&
                    this.Acknowledge.Equals(input.Acknowledge))
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
                if (this.Acknowledge != null)
                {
                    hashCode = (hashCode * 59) + this.Acknowledge.GetHashCode();
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
