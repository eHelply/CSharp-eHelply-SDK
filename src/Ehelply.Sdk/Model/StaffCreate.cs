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
    /// **:param** project_uuid                        **type:** string or None  **:param** entity_uuid                         **type:** string or None  **:param** schedule_uuid                       **type:** string or None  **:param** catalog_uuid                        **type:** string or None  **:param** review_group_uuid                   **type:** string or None
    /// </summary>
    [DataContract(Name = "StaffCreate")]
    public partial class StaffCreate : IEquatable<StaffCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaffCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffCreate" /> class.
        /// </summary>
        /// <param name="entityUuid">entityUuid (required).</param>
        /// <param name="projectUuid">projectUuid.</param>
        /// <param name="scheduleUuid">scheduleUuid.</param>
        /// <param name="catalogUuid">catalogUuid.</param>
        /// <param name="reviewGroupUuid">reviewGroupUuid.</param>
        public StaffCreate(string entityUuid = default(string), string projectUuid = default(string), string scheduleUuid = default(string), string catalogUuid = default(string), string reviewGroupUuid = default(string))
        {
            // to ensure "entityUuid" is required (not null)
            if (entityUuid == null)
            {
                throw new ArgumentNullException("entityUuid is a required property for StaffCreate and cannot be null");
            }
            this.EntityUuid = entityUuid;
            this.ProjectUuid = projectUuid;
            this.ScheduleUuid = scheduleUuid;
            this.CatalogUuid = catalogUuid;
            this.ReviewGroupUuid = reviewGroupUuid;
        }

        /// <summary>
        /// Gets or Sets EntityUuid
        /// </summary>
        [DataMember(Name = "entity_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string EntityUuid { get; set; }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StaffCreate {\n");
            sb.Append("  EntityUuid: ").Append(EntityUuid).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  ScheduleUuid: ").Append(ScheduleUuid).Append("\n");
            sb.Append("  CatalogUuid: ").Append(CatalogUuid).Append("\n");
            sb.Append("  ReviewGroupUuid: ").Append(ReviewGroupUuid).Append("\n");
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
            return this.Equals(input as StaffCreate);
        }

        /// <summary>
        /// Returns true if StaffCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffCreate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EntityUuid == input.EntityUuid ||
                    (this.EntityUuid != null &&
                    this.EntityUuid.Equals(input.EntityUuid))
                ) && 
                (
                    this.ProjectUuid == input.ProjectUuid ||
                    (this.ProjectUuid != null &&
                    this.ProjectUuid.Equals(input.ProjectUuid))
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
                if (this.EntityUuid != null)
                {
                    hashCode = (hashCode * 59) + this.EntityUuid.GetHashCode();
                }
                if (this.ProjectUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectUuid.GetHashCode();
                }
                if (this.ScheduleUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduleUuid.GetHashCode();
                }
                if (this.CatalogUuid != null)
                {
                    hashCode = (hashCode * 59) + this.CatalogUuid.GetHashCode();
                }
                if (this.ReviewGroupUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ReviewGroupUuid.GetHashCode();
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
