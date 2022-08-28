/*
 * eHelply SDK - 1.1.111
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.111
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
    /// ProjectCreditResponse
    /// </summary>
    [DataContract(Name = "ProjectCreditResponse")]
    public partial class ProjectCreditResponse : IEquatable<ProjectCreditResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreditResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectCreditResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreditResponse" /> class.
        /// </summary>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="projectUuid">projectUuid (required).</param>
        /// <param name="creditsGranted">creditsGranted (required).</param>
        /// <param name="creditsConsumed">creditsConsumed.</param>
        /// <param name="grantedBy">grantedBy (required).</param>
        /// <param name="grantedReason">grantedReason (required).</param>
        /// <param name="grantedAt">grantedAt (required).</param>
        /// <param name="fullyConsumedAt">fullyConsumedAt.</param>
        /// <param name="revokedReason">revokedReason.</param>
        /// <param name="revokedAt">revokedAt.</param>
        public ProjectCreditResponse(string uuid = default(string), string projectUuid = default(string), int creditsGranted = default(int), int creditsConsumed = default(int), string grantedBy = default(string), string grantedReason = default(string), string grantedAt = default(string), string fullyConsumedAt = default(string), string revokedReason = default(string), string revokedAt = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for ProjectCreditResponse and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "projectUuid" is required (not null)
            if (projectUuid == null)
            {
                throw new ArgumentNullException("projectUuid is a required property for ProjectCreditResponse and cannot be null");
            }
            this.ProjectUuid = projectUuid;
            this.CreditsGranted = creditsGranted;
            // to ensure "grantedBy" is required (not null)
            if (grantedBy == null)
            {
                throw new ArgumentNullException("grantedBy is a required property for ProjectCreditResponse and cannot be null");
            }
            this.GrantedBy = grantedBy;
            // to ensure "grantedReason" is required (not null)
            if (grantedReason == null)
            {
                throw new ArgumentNullException("grantedReason is a required property for ProjectCreditResponse and cannot be null");
            }
            this.GrantedReason = grantedReason;
            // to ensure "grantedAt" is required (not null)
            if (grantedAt == null)
            {
                throw new ArgumentNullException("grantedAt is a required property for ProjectCreditResponse and cannot be null");
            }
            this.GrantedAt = grantedAt;
            this.CreditsConsumed = creditsConsumed;
            this.FullyConsumedAt = fullyConsumedAt;
            this.RevokedReason = revokedReason;
            this.RevokedAt = revokedAt;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Gets or Sets CreditsGranted
        /// </summary>
        [DataMember(Name = "credits_granted", IsRequired = true, EmitDefaultValue = false)]
        public int CreditsGranted { get; set; }

        /// <summary>
        /// Gets or Sets CreditsConsumed
        /// </summary>
        [DataMember(Name = "credits_consumed", EmitDefaultValue = false)]
        public int CreditsConsumed { get; set; }

        /// <summary>
        /// Gets or Sets GrantedBy
        /// </summary>
        [DataMember(Name = "granted_by", IsRequired = true, EmitDefaultValue = false)]
        public string GrantedBy { get; set; }

        /// <summary>
        /// Gets or Sets GrantedReason
        /// </summary>
        [DataMember(Name = "granted_reason", IsRequired = true, EmitDefaultValue = false)]
        public string GrantedReason { get; set; }

        /// <summary>
        /// Gets or Sets GrantedAt
        /// </summary>
        [DataMember(Name = "granted_at", IsRequired = true, EmitDefaultValue = false)]
        public string GrantedAt { get; set; }

        /// <summary>
        /// Gets or Sets FullyConsumedAt
        /// </summary>
        [DataMember(Name = "fully_consumed_at", EmitDefaultValue = false)]
        public string FullyConsumedAt { get; set; }

        /// <summary>
        /// Gets or Sets RevokedReason
        /// </summary>
        [DataMember(Name = "revoked_reason", EmitDefaultValue = false)]
        public string RevokedReason { get; set; }

        /// <summary>
        /// Gets or Sets RevokedAt
        /// </summary>
        [DataMember(Name = "revoked_at", EmitDefaultValue = false)]
        public string RevokedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectCreditResponse {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  CreditsGranted: ").Append(CreditsGranted).Append("\n");
            sb.Append("  CreditsConsumed: ").Append(CreditsConsumed).Append("\n");
            sb.Append("  GrantedBy: ").Append(GrantedBy).Append("\n");
            sb.Append("  GrantedReason: ").Append(GrantedReason).Append("\n");
            sb.Append("  GrantedAt: ").Append(GrantedAt).Append("\n");
            sb.Append("  FullyConsumedAt: ").Append(FullyConsumedAt).Append("\n");
            sb.Append("  RevokedReason: ").Append(RevokedReason).Append("\n");
            sb.Append("  RevokedAt: ").Append(RevokedAt).Append("\n");
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
            return this.Equals(input as ProjectCreditResponse);
        }

        /// <summary>
        /// Returns true if ProjectCreditResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectCreditResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectCreditResponse input)
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
                    this.ProjectUuid == input.ProjectUuid ||
                    (this.ProjectUuid != null &&
                    this.ProjectUuid.Equals(input.ProjectUuid))
                ) && 
                (
                    this.CreditsGranted == input.CreditsGranted ||
                    this.CreditsGranted.Equals(input.CreditsGranted)
                ) && 
                (
                    this.CreditsConsumed == input.CreditsConsumed ||
                    this.CreditsConsumed.Equals(input.CreditsConsumed)
                ) && 
                (
                    this.GrantedBy == input.GrantedBy ||
                    (this.GrantedBy != null &&
                    this.GrantedBy.Equals(input.GrantedBy))
                ) && 
                (
                    this.GrantedReason == input.GrantedReason ||
                    (this.GrantedReason != null &&
                    this.GrantedReason.Equals(input.GrantedReason))
                ) && 
                (
                    this.GrantedAt == input.GrantedAt ||
                    (this.GrantedAt != null &&
                    this.GrantedAt.Equals(input.GrantedAt))
                ) && 
                (
                    this.FullyConsumedAt == input.FullyConsumedAt ||
                    (this.FullyConsumedAt != null &&
                    this.FullyConsumedAt.Equals(input.FullyConsumedAt))
                ) && 
                (
                    this.RevokedReason == input.RevokedReason ||
                    (this.RevokedReason != null &&
                    this.RevokedReason.Equals(input.RevokedReason))
                ) && 
                (
                    this.RevokedAt == input.RevokedAt ||
                    (this.RevokedAt != null &&
                    this.RevokedAt.Equals(input.RevokedAt))
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
                if (this.ProjectUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectUuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreditsGranted.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditsConsumed.GetHashCode();
                if (this.GrantedBy != null)
                {
                    hashCode = (hashCode * 59) + this.GrantedBy.GetHashCode();
                }
                if (this.GrantedReason != null)
                {
                    hashCode = (hashCode * 59) + this.GrantedReason.GetHashCode();
                }
                if (this.GrantedAt != null)
                {
                    hashCode = (hashCode * 59) + this.GrantedAt.GetHashCode();
                }
                if (this.FullyConsumedAt != null)
                {
                    hashCode = (hashCode * 59) + this.FullyConsumedAt.GetHashCode();
                }
                if (this.RevokedReason != null)
                {
                    hashCode = (hashCode * 59) + this.RevokedReason.GetHashCode();
                }
                if (this.RevokedAt != null)
                {
                    hashCode = (hashCode * 59) + this.RevokedAt.GetHashCode();
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
