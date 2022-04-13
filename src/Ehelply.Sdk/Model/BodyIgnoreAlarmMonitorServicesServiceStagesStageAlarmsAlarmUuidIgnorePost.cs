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
    /// BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost
    /// </summary>
    [DataContract(Name = "Body_ignore_alarm_monitor_services__service__stages__stage__alarms__alarm_uuid__ignore_post")]
    public partial class BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost : IEquatable<BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost" /> class.
        /// </summary>
        /// <param name="ignore">ignore (required).</param>
        public BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost(AlarmIgnore ignore = default(AlarmIgnore))
        {
            // to ensure "ignore" is required (not null)
            if (ignore == null) {
                throw new ArgumentNullException("ignore is a required property for BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost and cannot be null");
            }
            this.Ignore = ignore;
        }

        /// <summary>
        /// Gets or Sets Ignore
        /// </summary>
        [DataMember(Name = "ignore", IsRequired = true, EmitDefaultValue = false)]
        public AlarmIgnore Ignore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost {\n");
            sb.Append("  Ignore: ").Append(Ignore).Append("\n");
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
            return this.Equals(input as BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost);
        }

        /// <summary>
        /// Returns true if BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ignore == input.Ignore ||
                    (this.Ignore != null &&
                    this.Ignore.Equals(input.Ignore))
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
                if (this.Ignore != null)
                    hashCode = hashCode * 59 + this.Ignore.GetHashCode();
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
