/*
 * eHelply SDK - 1.1.99
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.99
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
    /// ProjectsProjectMemberDB
    /// </summary>
    [DataContract(Name = "ProjectsProjectMemberDB")]
    public partial class ProjectsProjectMemberDB : IEquatable<ProjectsProjectMemberDB>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsProjectMemberDB" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectsProjectMemberDB() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsProjectMemberDB" /> class.
        /// </summary>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="projectUuid">projectUuid (required).</param>
        /// <param name="entityUuid">entityUuid (required).</param>
        /// <param name="role">role (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        public ProjectsProjectMemberDB(string uuid = default(string), string projectUuid = default(string), string entityUuid = default(string), string role = default(string), string createdAt = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for ProjectsProjectMemberDB and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "projectUuid" is required (not null)
            if (projectUuid == null)
            {
                throw new ArgumentNullException("projectUuid is a required property for ProjectsProjectMemberDB and cannot be null");
            }
            this.ProjectUuid = projectUuid;
            // to ensure "entityUuid" is required (not null)
            if (entityUuid == null)
            {
                throw new ArgumentNullException("entityUuid is a required property for ProjectsProjectMemberDB and cannot be null");
            }
            this.EntityUuid = entityUuid;
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new ArgumentNullException("role is a required property for ProjectsProjectMemberDB and cannot be null");
            }
            this.Role = role;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for ProjectsProjectMemberDB and cannot be null");
            }
            this.CreatedAt = createdAt;
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
        /// Gets or Sets EntityUuid
        /// </summary>
        [DataMember(Name = "entity_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string EntityUuid { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectsProjectMemberDB {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  EntityUuid: ").Append(EntityUuid).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as ProjectsProjectMemberDB);
        }

        /// <summary>
        /// Returns true if ProjectsProjectMemberDB instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectsProjectMemberDB to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectsProjectMemberDB input)
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
                    this.EntityUuid == input.EntityUuid ||
                    (this.EntityUuid != null &&
                    this.EntityUuid.Equals(input.EntityUuid))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.ProjectUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectUuid.GetHashCode();
                }
                if (this.EntityUuid != null)
                {
                    hashCode = (hashCode * 59) + this.EntityUuid.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
