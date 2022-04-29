/*
 * eHelply SDK - 1.1.68
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.68
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
    /// BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost
    /// </summary>
    [DataContract(Name = "Body_terminate_alarm_monitor_services__service__stages__stage__alarms__alarm_uuid__terminate_post")]
    public partial class BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost : IEquatable<BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost" /> class.
        /// </summary>
        /// <param name="terminate">terminate (required).</param>
        public BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost(AlarmTerminate terminate = default(AlarmTerminate))
        {
            // to ensure "terminate" is required (not null)
            if (terminate == null) {
                throw new ArgumentNullException("terminate is a required property for BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost and cannot be null");
            }
            this.Terminate = terminate;
        }

        /// <summary>
        /// Gets or Sets Terminate
        /// </summary>
        [DataMember(Name = "terminate", IsRequired = true, EmitDefaultValue = false)]
        public AlarmTerminate Terminate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost {\n");
            sb.Append("  Terminate: ").Append(Terminate).Append("\n");
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
            return this.Equals(input as BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost);
        }

        /// <summary>
        /// Returns true if BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Terminate == input.Terminate ||
                    (this.Terminate != null &&
                    this.Terminate.Equals(input.Terminate))
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
                if (this.Terminate != null)
                    hashCode = hashCode * 59 + this.Terminate.GetHashCode();
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
