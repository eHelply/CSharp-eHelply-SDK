/*
 * eHelply SDK - 1.1.59
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.59
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
    /// BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost
    /// </summary>
    [DataContract(Name = "Body_attach_alarm_note_monitor_services__service__stages__stage__alarms__alarm_uuid__note_post")]
    public partial class BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost : IEquatable<BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost" /> class.
        /// </summary>
        /// <param name="note">note (required).</param>
        public BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost(AlarmNote note = default(AlarmNote))
        {
            // to ensure "note" is required (not null)
            if (note == null) {
                throw new ArgumentNullException("note is a required property for BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost and cannot be null");
            }
            this.Note = note;
        }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", IsRequired = true, EmitDefaultValue = false)]
        public AlarmNote Note { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost {\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
            return this.Equals(input as BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost);
        }

        /// <summary>
        /// Returns true if BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
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
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
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
