/*
 * eHelply SDK - 1.1.97
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.97
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
    /// Used for DB row entry
    /// </summary>
    [DataContract(Name = "ProjectDB")]
    public partial class ProjectDB : IEquatable<ProjectDB>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDB" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProjectDB() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectDB" /> class.
        /// </summary>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="currentSpend">currentSpend (required).</param>
        /// <param name="maxSpend">maxSpend (required).</param>
        /// <param name="projectStatus">projectStatus (required).</param>
        /// <param name="archivedAt">archivedAt.</param>
        public ProjectDB(string uuid = default(string), string name = default(string), string createdAt = default(string), int currentSpend = default(int), int maxSpend = default(int), string projectStatus = default(string), string archivedAt = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for ProjectDB and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ProjectDB and cannot be null");
            }
            this.Name = name;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for ProjectDB and cannot be null");
            }
            this.CreatedAt = createdAt;
            this.CurrentSpend = currentSpend;
            this.MaxSpend = maxSpend;
            // to ensure "projectStatus" is required (not null)
            if (projectStatus == null)
            {
                throw new ArgumentNullException("projectStatus is a required property for ProjectDB and cannot be null");
            }
            this.ProjectStatus = projectStatus;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CurrentSpend
        /// </summary>
        [DataMember(Name = "current_spend", IsRequired = true, EmitDefaultValue = false)]
        public int CurrentSpend { get; set; }

        /// <summary>
        /// Gets or Sets MaxSpend
        /// </summary>
        [DataMember(Name = "max_spend", IsRequired = true, EmitDefaultValue = false)]
        public int MaxSpend { get; set; }

        /// <summary>
        /// Gets or Sets ProjectStatus
        /// </summary>
        [DataMember(Name = "project_status", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectStatus { get; set; }

        /// <summary>
        /// Gets or Sets ArchivedAt
        /// </summary>
        [DataMember(Name = "archived_at", EmitDefaultValue = false)]
        public string ArchivedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectDB {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CurrentSpend: ").Append(CurrentSpend).Append("\n");
            sb.Append("  MaxSpend: ").Append(MaxSpend).Append("\n");
            sb.Append("  ProjectStatus: ").Append(ProjectStatus).Append("\n");
            sb.Append("  ArchivedAt: ").Append(ArchivedAt).Append("\n");
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
            return this.Equals(input as ProjectDB);
        }

        /// <summary>
        /// Returns true if ProjectDB instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectDB to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectDB input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CurrentSpend == input.CurrentSpend ||
                    this.CurrentSpend.Equals(input.CurrentSpend)
                ) && 
                (
                    this.MaxSpend == input.MaxSpend ||
                    this.MaxSpend.Equals(input.MaxSpend)
                ) && 
                (
                    this.ProjectStatus == input.ProjectStatus ||
                    (this.ProjectStatus != null &&
                    this.ProjectStatus.Equals(input.ProjectStatus))
                ) && 
                (
                    this.ArchivedAt == input.ArchivedAt ||
                    (this.ArchivedAt != null &&
                    this.ArchivedAt.Equals(input.ArchivedAt))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CurrentSpend.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxSpend.GetHashCode();
                if (this.ProjectStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectStatus.GetHashCode();
                }
                if (this.ArchivedAt != null)
                {
                    hashCode = (hashCode * 59) + this.ArchivedAt.GetHashCode();
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
