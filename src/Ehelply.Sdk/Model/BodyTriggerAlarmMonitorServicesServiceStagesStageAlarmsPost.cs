/*
 * eHelply SDK - 1.1.47
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.47
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
    /// BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost
    /// </summary>
    [DataContract(Name = "Body_trigger_alarm_monitor_services__service__stages__stage__alarms_post")]
    public partial class BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost : IEquatable<BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost" /> class.
        /// </summary>
        /// <param name="alarm">alarm (required).</param>
        public BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost(AlarmCreate alarm = default(AlarmCreate))
        {
            // to ensure "alarm" is required (not null)
            if (alarm == null) {
                throw new ArgumentNullException("alarm is a required property for BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost and cannot be null");
            }
            this.Alarm = alarm;
        }

        /// <summary>
        /// Gets or Sets Alarm
        /// </summary>
        [DataMember(Name = "alarm", IsRequired = true, EmitDefaultValue = false)]
        public AlarmCreate Alarm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost {\n");
            sb.Append("  Alarm: ").Append(Alarm).Append("\n");
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
            return this.Equals(input as BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost);
        }

        /// <summary>
        /// Returns true if BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Alarm == input.Alarm ||
                    (this.Alarm != null &&
                    this.Alarm.Equals(input.Alarm))
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
                if (this.Alarm != null)
                    hashCode = hashCode * 59 + this.Alarm.GetHashCode();
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
