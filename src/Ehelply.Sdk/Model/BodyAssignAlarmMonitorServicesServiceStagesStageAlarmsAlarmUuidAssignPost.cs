/*
 * eHelply SDK - 1.1.64
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.64
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
    /// BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost
    /// </summary>
    [DataContract(Name = "Body_assign_alarm_monitor_services__service__stages__stage__alarms__alarm_uuid__assign_post")]
    public partial class BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost : IEquatable<BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost" /> class.
        /// </summary>
        /// <param name="assignee">assignee (required).</param>
        public BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost(AlarmAssign assignee = default(AlarmAssign))
        {
            // to ensure "assignee" is required (not null)
            if (assignee == null) {
                throw new ArgumentNullException("assignee is a required property for BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost and cannot be null");
            }
            this.Assignee = assignee;
        }

        /// <summary>
        /// Gets or Sets Assignee
        /// </summary>
        [DataMember(Name = "assignee", IsRequired = true, EmitDefaultValue = false)]
        public AlarmAssign Assignee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost {\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
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
            return this.Equals(input as BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost);
        }

        /// <summary>
        /// Returns true if BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Assignee == input.Assignee ||
                    (this.Assignee != null &&
                    this.Assignee.Equals(input.Assignee))
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
                if (this.Assignee != null)
                    hashCode = hashCode * 59 + this.Assignee.GetHashCode();
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
