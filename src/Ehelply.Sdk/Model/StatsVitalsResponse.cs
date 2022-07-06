/*
 * eHelply SDK - 1.1.95
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.95
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
    /// StatsVitalsResponse
    /// </summary>
    [DataContract(Name = "StatsVitalsResponse")]
    public partial class StatsVitalsResponse : IEquatable<StatsVitalsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatsVitalsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StatsVitalsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatsVitalsResponse" /> class.
        /// </summary>
        /// <param name="uuid">uuid.</param>
        /// <param name="serviceUuid">serviceUuid (required).</param>
        /// <param name="heartbeatUuid">heartbeatUuid (required).</param>
        /// <param name="stats">stats.</param>
        /// <param name="vitals">vitals.</param>
        /// <param name="createdAt">createdAt.</param>
        public StatsVitalsResponse(string uuid = default(string), string serviceUuid = default(string), string heartbeatUuid = default(string), Object stats = default(Object), Object vitals = default(Object), string createdAt = default(string))
        {
            // to ensure "serviceUuid" is required (not null)
            if (serviceUuid == null)
            {
                throw new ArgumentNullException("serviceUuid is a required property for StatsVitalsResponse and cannot be null");
            }
            this.ServiceUuid = serviceUuid;
            // to ensure "heartbeatUuid" is required (not null)
            if (heartbeatUuid == null)
            {
                throw new ArgumentNullException("heartbeatUuid is a required property for StatsVitalsResponse and cannot be null");
            }
            this.HeartbeatUuid = heartbeatUuid;
            this.Uuid = uuid;
            this.Stats = stats;
            this.Vitals = vitals;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets ServiceUuid
        /// </summary>
        [DataMember(Name = "service_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string ServiceUuid { get; set; }

        /// <summary>
        /// Gets or Sets HeartbeatUuid
        /// </summary>
        [DataMember(Name = "heartbeat_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string HeartbeatUuid { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        public Object Stats { get; set; }

        /// <summary>
        /// Gets or Sets Vitals
        /// </summary>
        [DataMember(Name = "vitals", EmitDefaultValue = false)]
        public Object Vitals { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StatsVitalsResponse {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ServiceUuid: ").Append(ServiceUuid).Append("\n");
            sb.Append("  HeartbeatUuid: ").Append(HeartbeatUuid).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
            sb.Append("  Vitals: ").Append(Vitals).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as StatsVitalsResponse);
        }

        /// <summary>
        /// Returns true if StatsVitalsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StatsVitalsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatsVitalsResponse input)
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
                    this.HeartbeatUuid == input.HeartbeatUuid ||
                    (this.HeartbeatUuid != null &&
                    this.HeartbeatUuid.Equals(input.HeartbeatUuid))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
                ) && 
                (
                    this.Vitals == input.Vitals ||
                    (this.Vitals != null &&
                    this.Vitals.Equals(input.Vitals))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.HeartbeatUuid != null)
                {
                    hashCode = (hashCode * 59) + this.HeartbeatUuid.GetHashCode();
                }
                if (this.Stats != null)
                {
                    hashCode = (hashCode * 59) + this.Stats.GetHashCode();
                }
                if (this.Vitals != null)
                {
                    hashCode = (hashCode * 59) + this.Vitals.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
