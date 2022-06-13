/*
 * eHelply SDK - 1.1.78
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.78
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
    /// HeartbeatResponse
    /// </summary>
    [DataContract(Name = "HeartbeatResponse")]
    public partial class HeartbeatResponse : IEquatable<HeartbeatResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeartbeatResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HeartbeatResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HeartbeatResponse" /> class.
        /// </summary>
        /// <param name="uuid">uuid.</param>
        /// <param name="serviceUuid">serviceUuid (required).</param>
        /// <param name="stage">stage (required).</param>
        /// <param name="process">process (required).</param>
        /// <param name="health">health (required).</param>
        /// <param name="platform">platform (required).</param>
        /// <param name="createdAt">createdAt.</param>
        public HeartbeatResponse(string uuid = default(string), string serviceUuid = default(string), string stage = default(string), string process = default(string), string health = default(string), Object platform = default(Object), string createdAt = default(string))
        {
            // to ensure "serviceUuid" is required (not null)
            if (serviceUuid == null)
            {
                throw new ArgumentNullException("serviceUuid is a required property for HeartbeatResponse and cannot be null");
            }
            this.ServiceUuid = serviceUuid;
            // to ensure "stage" is required (not null)
            if (stage == null)
            {
                throw new ArgumentNullException("stage is a required property for HeartbeatResponse and cannot be null");
            }
            this.Stage = stage;
            // to ensure "process" is required (not null)
            if (process == null)
            {
                throw new ArgumentNullException("process is a required property for HeartbeatResponse and cannot be null");
            }
            this.Process = process;
            // to ensure "health" is required (not null)
            if (health == null)
            {
                throw new ArgumentNullException("health is a required property for HeartbeatResponse and cannot be null");
            }
            this.Health = health;
            // to ensure "platform" is required (not null)
            if (platform == null)
            {
                throw new ArgumentNullException("platform is a required property for HeartbeatResponse and cannot be null");
            }
            this.Platform = platform;
            this.Uuid = uuid;
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
        /// Gets or Sets Stage
        /// </summary>
        [DataMember(Name = "stage", IsRequired = true, EmitDefaultValue = false)]
        public string Stage { get; set; }

        /// <summary>
        /// Gets or Sets Process
        /// </summary>
        [DataMember(Name = "process", IsRequired = true, EmitDefaultValue = false)]
        public string Process { get; set; }

        /// <summary>
        /// Gets or Sets Health
        /// </summary>
        [DataMember(Name = "health", IsRequired = true, EmitDefaultValue = false)]
        public string Health { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = false)]
        public Object Platform { get; set; }

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
            sb.Append("class HeartbeatResponse {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ServiceUuid: ").Append(ServiceUuid).Append("\n");
            sb.Append("  Stage: ").Append(Stage).Append("\n");
            sb.Append("  Process: ").Append(Process).Append("\n");
            sb.Append("  Health: ").Append(Health).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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
            return this.Equals(input as HeartbeatResponse);
        }

        /// <summary>
        /// Returns true if HeartbeatResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HeartbeatResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HeartbeatResponse input)
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
                    this.Health == input.Health ||
                    (this.Health != null &&
                    this.Health.Equals(input.Health))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
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
                if (this.Stage != null)
                {
                    hashCode = (hashCode * 59) + this.Stage.GetHashCode();
                }
                if (this.Process != null)
                {
                    hashCode = (hashCode * 59) + this.Process.GetHashCode();
                }
                if (this.Health != null)
                {
                    hashCode = (hashCode * 59) + this.Health.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
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
