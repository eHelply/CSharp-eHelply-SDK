/*
 * eHelply SDK - 1.1.118
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.118
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
    /// AlarmResponse
    /// </summary>
    [DataContract(Name = "AlarmResponse")]
    public partial class AlarmResponse : IEquatable<AlarmResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmResponse" /> class.
        /// </summary>
        /// <param name="uuid">uuid.</param>
        /// <param name="serviceUuid">serviceUuid.</param>
        /// <param name="count">count.</param>
        /// <param name="stage">stage.</param>
        /// <param name="process">process.</param>
        /// <param name="severity">severity.</param>
        /// <param name="ticketUuid">ticketUuid.</param>
        /// <param name="name">name.</param>
        /// <param name="summary">summary.</param>
        /// <param name="description">description.</param>
        /// <param name="note">note.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="latestAt">latestAt.</param>
        /// <param name="acknowledgedAt">acknowledgedAt.</param>
        /// <param name="ignoredAt">ignoredAt.</param>
        /// <param name="clearedAt">clearedAt.</param>
        /// <param name="terminatedAt">terminatedAt.</param>
        /// <param name="assigneeUuid">assigneeUuid.</param>
        /// <param name="acknowledgerUuid">acknowledgerUuid.</param>
        /// <param name="ignorerUuid">ignorerUuid.</param>
        /// <param name="terminaterUuid">terminaterUuid.</param>
        public AlarmResponse(string uuid = default(string), string serviceUuid = default(string), int count = default(int), string stage = default(string), string process = default(string), string severity = default(string), string ticketUuid = default(string), string name = default(string), string summary = default(string), string description = default(string), List<Object> note = default(List<Object>), string createdAt = default(string), string latestAt = default(string), string acknowledgedAt = default(string), string ignoredAt = default(string), string clearedAt = default(string), string terminatedAt = default(string), string assigneeUuid = default(string), string acknowledgerUuid = default(string), string ignorerUuid = default(string), string terminaterUuid = default(string))
        {
            this.Uuid = uuid;
            this.ServiceUuid = serviceUuid;
            this.Count = count;
            this.Stage = stage;
            this.Process = process;
            this.Severity = severity;
            this.TicketUuid = ticketUuid;
            this.Name = name;
            this.Summary = summary;
            this.Description = description;
            this.Note = note;
            this.CreatedAt = createdAt;
            this.LatestAt = latestAt;
            this.AcknowledgedAt = acknowledgedAt;
            this.IgnoredAt = ignoredAt;
            this.ClearedAt = clearedAt;
            this.TerminatedAt = terminatedAt;
            this.AssigneeUuid = assigneeUuid;
            this.AcknowledgerUuid = acknowledgerUuid;
            this.IgnorerUuid = ignorerUuid;
            this.TerminaterUuid = terminaterUuid;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets ServiceUuid
        /// </summary>
        [DataMember(Name = "service_uuid", EmitDefaultValue = false)]
        public string ServiceUuid { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Gets or Sets Stage
        /// </summary>
        [DataMember(Name = "stage", EmitDefaultValue = false)]
        public string Stage { get; set; }

        /// <summary>
        /// Gets or Sets Process
        /// </summary>
        [DataMember(Name = "process", EmitDefaultValue = false)]
        public string Process { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name = "severity", EmitDefaultValue = false)]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or Sets TicketUuid
        /// </summary>
        [DataMember(Name = "ticket_uuid", EmitDefaultValue = false)]
        public string TicketUuid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = false)]
        public List<Object> Note { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets LatestAt
        /// </summary>
        [DataMember(Name = "latest_at", EmitDefaultValue = false)]
        public string LatestAt { get; set; }

        /// <summary>
        /// Gets or Sets AcknowledgedAt
        /// </summary>
        [DataMember(Name = "acknowledged_at", EmitDefaultValue = false)]
        public string AcknowledgedAt { get; set; }

        /// <summary>
        /// Gets or Sets IgnoredAt
        /// </summary>
        [DataMember(Name = "ignored_at", EmitDefaultValue = false)]
        public string IgnoredAt { get; set; }

        /// <summary>
        /// Gets or Sets ClearedAt
        /// </summary>
        [DataMember(Name = "cleared_at", EmitDefaultValue = false)]
        public string ClearedAt { get; set; }

        /// <summary>
        /// Gets or Sets TerminatedAt
        /// </summary>
        [DataMember(Name = "terminated_at", EmitDefaultValue = false)]
        public string TerminatedAt { get; set; }

        /// <summary>
        /// Gets or Sets AssigneeUuid
        /// </summary>
        [DataMember(Name = "assignee_uuid", EmitDefaultValue = false)]
        public string AssigneeUuid { get; set; }

        /// <summary>
        /// Gets or Sets AcknowledgerUuid
        /// </summary>
        [DataMember(Name = "acknowledger_uuid", EmitDefaultValue = false)]
        public string AcknowledgerUuid { get; set; }

        /// <summary>
        /// Gets or Sets IgnorerUuid
        /// </summary>
        [DataMember(Name = "ignorer_uuid", EmitDefaultValue = false)]
        public string IgnorerUuid { get; set; }

        /// <summary>
        /// Gets or Sets TerminaterUuid
        /// </summary>
        [DataMember(Name = "terminater_uuid", EmitDefaultValue = false)]
        public string TerminaterUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlarmResponse {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ServiceUuid: ").Append(ServiceUuid).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  Process: ").Append(Process).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  TicketUuid: ").Append(TicketUuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  LatestAt: ").Append(LatestAt).Append("\n");
            sb.Append("  AcknowledgedAt: ").Append(AcknowledgedAt).Append("\n");
            sb.Append("  IgnoredAt: ").Append(IgnoredAt).Append("\n");
            sb.Append("  ClearedAt: ").Append(ClearedAt).Append("\n");
            sb.Append("  TerminatedAt: ").Append(TerminatedAt).Append("\n");
            sb.Append("  AssigneeUuid: ").Append(AssigneeUuid).Append("\n");
            sb.Append("  AcknowledgerUuid: ").Append(AcknowledgerUuid).Append("\n");
            sb.Append("  IgnorerUuid: ").Append(IgnorerUuid).Append("\n");
            sb.Append("  TerminaterUuid: ").Append(TerminaterUuid).Append("\n");
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
            return this.Equals(input as AlarmResponse);
        }

        /// <summary>
        /// Returns true if AlarmResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.ServiceUuid == input.ServiceUuid ||
                    (this.ServiceUuid != null &&
                    this.ServiceUuid.Equals(input.ServiceUuid))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Stage == input.Stage ||
                    (this.Stage != null &&
                    this.Stage.Equals(input.Stage))
                ) && 
                (
                    this.Process == input.Process ||
                    (this.Process != null &&
                    this.Process.Equals(input.Process))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.TicketUuid == input.TicketUuid ||
                    (this.TicketUuid != null &&
                    this.TicketUuid.Equals(input.TicketUuid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Note == input.Note ||
                    this.Note != null &&
                    input.Note != null &&
                    this.Note.SequenceEqual(input.Note)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.LatestAt == input.LatestAt ||
                    (this.LatestAt != null &&
                    this.LatestAt.Equals(input.LatestAt))
                ) && 
                (
                    this.AcknowledgedAt == input.AcknowledgedAt ||
                    (this.AcknowledgedAt != null &&
                    this.AcknowledgedAt.Equals(input.AcknowledgedAt))
                ) && 
                (
                    this.IgnoredAt == input.IgnoredAt ||
                    (this.IgnoredAt != null &&
                    this.IgnoredAt.Equals(input.IgnoredAt))
                ) && 
                (
                    this.ClearedAt == input.ClearedAt ||
                    (this.ClearedAt != null &&
                    this.ClearedAt.Equals(input.ClearedAt))
                ) && 
                (
                    this.TerminatedAt == input.TerminatedAt ||
                    (this.TerminatedAt != null &&
                    this.TerminatedAt.Equals(input.TerminatedAt))
                ) && 
                (
                    this.AssigneeUuid == input.AssigneeUuid ||
                    (this.AssigneeUuid != null &&
                    this.AssigneeUuid.Equals(input.AssigneeUuid))
                ) && 
                (
                    this.AcknowledgerUuid == input.AcknowledgerUuid ||
                    (this.AcknowledgerUuid != null &&
                    this.AcknowledgerUuid.Equals(input.AcknowledgerUuid))
                ) && 
                (
                    this.IgnorerUuid == input.IgnorerUuid ||
                    (this.IgnorerUuid != null &&
                    this.IgnorerUuid.Equals(input.IgnorerUuid))
                ) && 
                (
                    this.TerminaterUuid == input.TerminaterUuid ||
                    (this.TerminaterUuid != null &&
                    this.TerminaterUuid.Equals(input.TerminaterUuid))
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
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.ServiceUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceUuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Stage != null)
                {
                    hashCode = (hashCode * 59) + this.Stage.GetHashCode();
                }
                if (this.Process != null)
                {
                    hashCode = (hashCode * 59) + this.Process.GetHashCode();
                }
                if (this.Severity != null)
                {
                    hashCode = (hashCode * 59) + this.Severity.GetHashCode();
                }
                if (this.TicketUuid != null)
                {
                    hashCode = (hashCode * 59) + this.TicketUuid.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Note != null)
                {
                    hashCode = (hashCode * 59) + this.Note.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.LatestAt != null)
                {
                    hashCode = (hashCode * 59) + this.LatestAt.GetHashCode();
                }
                if (this.AcknowledgedAt != null)
                {
                    hashCode = (hashCode * 59) + this.AcknowledgedAt.GetHashCode();
                }
                if (this.IgnoredAt != null)
                {
                    hashCode = (hashCode * 59) + this.IgnoredAt.GetHashCode();
                }
                if (this.ClearedAt != null)
                {
                    hashCode = (hashCode * 59) + this.ClearedAt.GetHashCode();
                }
                if (this.TerminatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.TerminatedAt.GetHashCode();
                }
                if (this.AssigneeUuid != null)
                {
                    hashCode = (hashCode * 59) + this.AssigneeUuid.GetHashCode();
                }
                if (this.AcknowledgerUuid != null)
                {
                    hashCode = (hashCode * 59) + this.AcknowledgerUuid.GetHashCode();
                }
                if (this.IgnorerUuid != null)
                {
                    hashCode = (hashCode * 59) + this.IgnorerUuid.GetHashCode();
                }
                if (this.TerminaterUuid != null)
                {
                    hashCode = (hashCode * 59) + this.TerminaterUuid.GetHashCode();
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
