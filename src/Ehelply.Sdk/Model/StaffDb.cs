/*
 * eHelply SDK - 1.1.67
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.67
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
    /// **:param** uuid                                **type:** string **:param** project_uuid                        **type:** string or None  **:param** entity_uuid                         **type:** string or None  **:param** schedule_uuid                       **type:** string or None  **:param** catalog_uuid                        **type:** string or None  **:param** review_group_uuid                   **type:** string or None  **:param** created_at                          **type:** string or None  **:param** updated_at                          **type:** string or None  **:param** deleted_at                          **type:** string or None
    /// </summary>
    [DataContract(Name = "StaffDb")]
    public partial class StaffDb : IEquatable<StaffDb>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffDb" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaffDb() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffDb" /> class.
        /// </summary>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="projectUuid">projectUuid.</param>
        /// <param name="entityUuid">entityUuid.</param>
        /// <param name="scheduleUuid">scheduleUuid.</param>
        /// <param name="catalogUuid">catalogUuid.</param>
        /// <param name="reviewGroupUuid">reviewGroupUuid.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="deletedAt">deletedAt.</param>
        public StaffDb(string uuid = default(string), string projectUuid = default(string), string entityUuid = default(string), string scheduleUuid = default(string), string catalogUuid = default(string), string reviewGroupUuid = default(string), string createdAt = default(string), string updatedAt = default(string), string deletedAt = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null) {
                throw new ArgumentNullException("uuid is a required property for StaffDb and cannot be null");
            }
            this.Uuid = uuid;
            this.ProjectUuid = projectUuid;
            this.EntityUuid = entityUuid;
            this.ScheduleUuid = scheduleUuid;
            this.CatalogUuid = catalogUuid;
            this.ReviewGroupUuid = reviewGroupUuid;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Gets or Sets EntityUuid
        /// </summary>
        [DataMember(Name = "entity_uuid", EmitDefaultValue = false)]
        public string EntityUuid { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleUuid
        /// </summary>
        [DataMember(Name = "schedule_uuid", EmitDefaultValue = false)]
        public string ScheduleUuid { get; set; }

        /// <summary>
        /// Gets or Sets CatalogUuid
        /// </summary>
        [DataMember(Name = "catalog_uuid", EmitDefaultValue = false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// Gets or Sets ReviewGroupUuid
        /// </summary>
        [DataMember(Name = "review_group_uuid", EmitDefaultValue = false)]
        public string ReviewGroupUuid { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name = "deleted_at", EmitDefaultValue = false)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaffDb {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  EntityUuid: ").Append(EntityUuid).Append("\n");
            sb.Append("  ScheduleUuid: ").Append(ScheduleUuid).Append("\n");
            sb.Append("  CatalogUuid: ").Append(CatalogUuid).Append("\n");
            sb.Append("  ReviewGroupUuid: ").Append(ReviewGroupUuid).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
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
            return this.Equals(input as StaffDb);
        }

        /// <summary>
        /// Returns true if StaffDb instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffDb to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffDb input)
        {
            if (input == null)
                return false;

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
                    this.EntityUuid == input.EntityUuid ||
                    (this.EntityUuid != null &&
                    this.EntityUuid.Equals(input.EntityUuid))
                ) && 
                (
                    this.ScheduleUuid == input.ScheduleUuid ||
                    (this.ScheduleUuid != null &&
                    this.ScheduleUuid.Equals(input.ScheduleUuid))
                ) && 
                (
                    this.CatalogUuid == input.CatalogUuid ||
                    (this.CatalogUuid != null &&
                    this.CatalogUuid.Equals(input.CatalogUuid))
                ) && 
                (
                    this.ReviewGroupUuid == input.ReviewGroupUuid ||
                    (this.ReviewGroupUuid != null &&
                    this.ReviewGroupUuid.Equals(input.ReviewGroupUuid))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
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
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.ProjectUuid != null)
                    hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.EntityUuid != null)
                    hashCode = hashCode * 59 + this.EntityUuid.GetHashCode();
                if (this.ScheduleUuid != null)
                    hashCode = hashCode * 59 + this.ScheduleUuid.GetHashCode();
                if (this.CatalogUuid != null)
                    hashCode = hashCode * 59 + this.CatalogUuid.GetHashCode();
                if (this.ReviewGroupUuid != null)
                    hashCode = hashCode * 59 + this.ReviewGroupUuid.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.DeletedAt != null)
                    hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
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