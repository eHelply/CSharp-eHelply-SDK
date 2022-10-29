/*
 * eHelply SDK - 1.1.119
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.119
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
    /// KpiResponse
    /// </summary>
    [DataContract(Name = "KpiResponse")]
    public partial class KpiResponse : IEquatable<KpiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KpiResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KpiResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KpiResponse" /> class.
        /// </summary>
        /// <param name="uuid">uuid.</param>
        /// <param name="serviceUuid">serviceUuid (required).</param>
        /// <param name="kpis">kpis (required).</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="fetchedAt">fetchedAt.</param>
        public KpiResponse(string uuid = default(string), string serviceUuid = default(string), List<Object> kpis = default(List<Object>), string createdAt = default(string), string fetchedAt = default(string))
        {
            // to ensure "serviceUuid" is required (not null)
            if (serviceUuid == null)
            {
                throw new ArgumentNullException("serviceUuid is a required property for KpiResponse and cannot be null");
            }
            this.ServiceUuid = serviceUuid;
            // to ensure "kpis" is required (not null)
            if (kpis == null)
            {
                throw new ArgumentNullException("kpis is a required property for KpiResponse and cannot be null");
            }
            this.Kpis = kpis;
            this.Uuid = uuid;
            this.CreatedAt = createdAt;
            this.FetchedAt = fetchedAt;
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
        /// Gets or Sets Kpis
        /// </summary>
        [DataMember(Name = "kpis", IsRequired = true, EmitDefaultValue = false)]
        public List<Object> Kpis { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets FetchedAt
        /// </summary>
        [DataMember(Name = "fetched_at", EmitDefaultValue = false)]
        public string FetchedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KpiResponse {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ServiceUuid: ").Append(ServiceUuid).Append("\n");
            sb.Append("  Kpis: ").Append(Kpis).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  FetchedAt: ").Append(FetchedAt).Append("\n");
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
            return this.Equals(input as KpiResponse);
        }

        /// <summary>
        /// Returns true if KpiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KpiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KpiResponse input)
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
                    this.Kpis == input.Kpis ||
                    this.Kpis != null &&
                    input.Kpis != null &&
                    this.Kpis.SequenceEqual(input.Kpis)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.FetchedAt == input.FetchedAt ||
                    (this.FetchedAt != null &&
                    this.FetchedAt.Equals(input.FetchedAt))
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
                if (this.Kpis != null)
                {
                    hashCode = (hashCode * 59) + this.Kpis.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.FetchedAt != null)
                {
                    hashCode = (hashCode * 59) + this.FetchedAt.GetHashCode();
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
