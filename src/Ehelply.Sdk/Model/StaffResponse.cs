/*
 * eHelply SDK - 1.1.101
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.101
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
    /// **:param** uuid                                **type:** string **:param** project_uuid                        **type:** string or None  **:param** entity                              **type:** string or None  **:param** place                               **type:** string or None  **:param** company                             **type:** string or None  **:param** schedule                            **type:** string or None  **:param** catalog                             **type:** string or None  **:param** reviews                             **type:** string or None  **:param** created_at                          **type:** string or None  **:param** updated_at                          **type:** string or None  **:param** deleted_at                          **type:** string or None
    /// </summary>
    [DataContract(Name = "StaffResponse")]
    public partial class StaffResponse : IEquatable<StaffResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StaffResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffResponse" /> class.
        /// </summary>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="projectUuid">projectUuid.</param>
        /// <param name="entity">entity.</param>
        /// <param name="place">place.</param>
        /// <param name="placeRoles">placeRoles.</param>
        /// <param name="company">company.</param>
        /// <param name="companyRoles">companyRoles.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="catalog">catalog.</param>
        /// <param name="reviews">reviews.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="deletedAt">deletedAt.</param>
        public StaffResponse(string uuid = default(string), string projectUuid = default(string), Object entity = default(Object), Object place = default(Object), List<string> placeRoles = default(List<string>), Object company = default(Object), List<string> companyRoles = default(List<string>), Object schedule = default(Object), Object catalog = default(Object), Object reviews = default(Object), string createdAt = default(string), string updatedAt = default(string), string deletedAt = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null)
            {
                throw new ArgumentNullException("uuid is a required property for StaffResponse and cannot be null");
            }
            this.Uuid = uuid;
            this.ProjectUuid = projectUuid;
            this.Entity = entity;
            this.Place = place;
            this.PlaceRoles = placeRoles;
            this.Company = company;
            this.CompanyRoles = companyRoles;
            this.Schedule = schedule;
            this.Catalog = catalog;
            this.Reviews = reviews;
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
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public Object Entity { get; set; }

        /// <summary>
        /// Gets or Sets Place
        /// </summary>
        [DataMember(Name = "place", EmitDefaultValue = false)]
        public Object Place { get; set; }

        /// <summary>
        /// Gets or Sets PlaceRoles
        /// </summary>
        [DataMember(Name = "place_roles", EmitDefaultValue = false)]
        public List<string> PlaceRoles { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public Object Company { get; set; }

        /// <summary>
        /// Gets or Sets CompanyRoles
        /// </summary>
        [DataMember(Name = "company_roles", EmitDefaultValue = false)]
        public List<string> CompanyRoles { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public Object Schedule { get; set; }

        /// <summary>
        /// Gets or Sets Catalog
        /// </summary>
        [DataMember(Name = "catalog", EmitDefaultValue = false)]
        public Object Catalog { get; set; }

        /// <summary>
        /// Gets or Sets Reviews
        /// </summary>
        [DataMember(Name = "reviews", EmitDefaultValue = false)]
        public Object Reviews { get; set; }

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
            StringBuilder sb = new StringBuilder();
            sb.Append("class StaffResponse {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Place: ").Append(Place).Append("\n");
            sb.Append("  PlaceRoles: ").Append(PlaceRoles).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CompanyRoles: ").Append(CompanyRoles).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Catalog: ").Append(Catalog).Append("\n");
            sb.Append("  Reviews: ").Append(Reviews).Append("\n");
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
            return this.Equals(input as StaffResponse);
        }

        /// <summary>
        /// Returns true if StaffResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StaffResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaffResponse input)
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
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
                ) && 
                (
                    this.Place == input.Place ||
                    (this.Place != null &&
                    this.Place.Equals(input.Place))
                ) && 
                (
                    this.PlaceRoles == input.PlaceRoles ||
                    this.PlaceRoles != null &&
                    input.PlaceRoles != null &&
                    this.PlaceRoles.SequenceEqual(input.PlaceRoles)
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.CompanyRoles == input.CompanyRoles ||
                    this.CompanyRoles != null &&
                    input.CompanyRoles != null &&
                    this.CompanyRoles.SequenceEqual(input.CompanyRoles)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.Catalog == input.Catalog ||
                    (this.Catalog != null &&
                    this.Catalog.Equals(input.Catalog))
                ) && 
                (
                    this.Reviews == input.Reviews ||
                    (this.Reviews != null &&
                    this.Reviews.Equals(input.Reviews))
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
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.ProjectUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectUuid.GetHashCode();
                }
                if (this.Entity != null)
                {
                    hashCode = (hashCode * 59) + this.Entity.GetHashCode();
                }
                if (this.Place != null)
                {
                    hashCode = (hashCode * 59) + this.Place.GetHashCode();
                }
                if (this.PlaceRoles != null)
                {
                    hashCode = (hashCode * 59) + this.PlaceRoles.GetHashCode();
                }
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.CompanyRoles != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyRoles.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                if (this.Catalog != null)
                {
                    hashCode = (hashCode * 59) + this.Catalog.GetHashCode();
                }
                if (this.Reviews != null)
                {
                    hashCode = (hashCode * 59) + this.Reviews.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.DeletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeletedAt.GetHashCode();
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
