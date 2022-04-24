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
    /// AppointmentResponse
    /// </summary>
    [DataContract(Name = "AppointmentResponse")]
    public partial class AppointmentResponse : IEquatable<AppointmentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AppointmentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentResponse" /> class.
        /// </summary>
        /// <param name="projectUuid">projectUuid (required).</param>
        /// <param name="placeUuid">placeUuid.</param>
        /// <param name="reviewGroupUuid">reviewGroupUuid.</param>
        /// <param name="expectedFinishAt">expectedFinishAt.</param>
        /// <param name="expectedStartAt">expectedStartAt.</param>
        /// <param name="actualStartAt">actualStartAt.</param>
        /// <param name="actualFinishAt">actualFinishAt.</param>
        /// <param name="products">products.</param>
        /// <param name="metaUuid">metaUuid.</param>
        /// <param name="status">status.</param>
        /// <param name="cancellationAt">cancellationAt.</param>
        /// <param name="cancellationReason">cancellationReason.</param>
        /// <param name="cancellationEntityUuid">cancellationEntityUuid.</param>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="deletedAt">deletedAt.</param>
        public AppointmentResponse(string projectUuid = default(string), string placeUuid = default(string), string reviewGroupUuid = default(string), string expectedFinishAt = default(string), string expectedStartAt = default(string), string actualStartAt = default(string), string actualFinishAt = default(string), Object products = default(Object), string metaUuid = default(string), string status = default(string), string cancellationAt = default(string), string cancellationReason = default(string), string cancellationEntityUuid = default(string), string uuid = default(string), string createdAt = default(string), string updatedAt = default(string), string deletedAt = default(string))
        {
            // to ensure "projectUuid" is required (not null)
            if (projectUuid == null) {
                throw new ArgumentNullException("projectUuid is a required property for AppointmentResponse and cannot be null");
            }
            this.ProjectUuid = projectUuid;
            // to ensure "uuid" is required (not null)
            if (uuid == null) {
                throw new ArgumentNullException("uuid is a required property for AppointmentResponse and cannot be null");
            }
            this.Uuid = uuid;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null) {
                throw new ArgumentNullException("createdAt is a required property for AppointmentResponse and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null) {
                throw new ArgumentNullException("updatedAt is a required property for AppointmentResponse and cannot be null");
            }
            this.UpdatedAt = updatedAt;
            this.PlaceUuid = placeUuid;
            this.ReviewGroupUuid = reviewGroupUuid;
            this.ExpectedFinishAt = expectedFinishAt;
            this.ExpectedStartAt = expectedStartAt;
            this.ActualStartAt = actualStartAt;
            this.ActualFinishAt = actualFinishAt;
            this.Products = products;
            this.MetaUuid = metaUuid;
            this.Status = status;
            this.CancellationAt = cancellationAt;
            this.CancellationReason = cancellationReason;
            this.CancellationEntityUuid = cancellationEntityUuid;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Gets or Sets PlaceUuid
        /// </summary>
        [DataMember(Name = "place_uuid", EmitDefaultValue = false)]
        public string PlaceUuid { get; set; }

        /// <summary>
        /// Gets or Sets ReviewGroupUuid
        /// </summary>
        [DataMember(Name = "review_group_uuid", EmitDefaultValue = false)]
        public string ReviewGroupUuid { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedFinishAt
        /// </summary>
        [DataMember(Name = "expected_finish_at", EmitDefaultValue = false)]
        public string ExpectedFinishAt { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedStartAt
        /// </summary>
        [DataMember(Name = "expected_start_at", EmitDefaultValue = false)]
        public string ExpectedStartAt { get; set; }

        /// <summary>
        /// Gets or Sets ActualStartAt
        /// </summary>
        [DataMember(Name = "actual_start_at", EmitDefaultValue = false)]
        public string ActualStartAt { get; set; }

        /// <summary>
        /// Gets or Sets ActualFinishAt
        /// </summary>
        [DataMember(Name = "actual_finish_at", EmitDefaultValue = false)]
        public string ActualFinishAt { get; set; }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name = "products", EmitDefaultValue = false)]
        public Object Products { get; set; }

        /// <summary>
        /// Gets or Sets MetaUuid
        /// </summary>
        [DataMember(Name = "meta_uuid", EmitDefaultValue = false)]
        public string MetaUuid { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CancellationAt
        /// </summary>
        [DataMember(Name = "cancellation_at", EmitDefaultValue = false)]
        public string CancellationAt { get; set; }

        /// <summary>
        /// Gets or Sets CancellationReason
        /// </summary>
        [DataMember(Name = "cancellation_reason", EmitDefaultValue = false)]
        public string CancellationReason { get; set; }

        /// <summary>
        /// Gets or Sets CancellationEntityUuid
        /// </summary>
        [DataMember(Name = "cancellation_entity_uuid", EmitDefaultValue = false)]
        public string CancellationEntityUuid { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = false)]
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
            sb.Append("class AppointmentResponse {\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  PlaceUuid: ").Append(PlaceUuid).Append("\n");
            sb.Append("  ReviewGroupUuid: ").Append(ReviewGroupUuid).Append("\n");
            sb.Append("  ExpectedFinishAt: ").Append(ExpectedFinishAt).Append("\n");
            sb.Append("  ExpectedStartAt: ").Append(ExpectedStartAt).Append("\n");
            sb.Append("  ActualStartAt: ").Append(ActualStartAt).Append("\n");
            sb.Append("  ActualFinishAt: ").Append(ActualFinishAt).Append("\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            sb.Append("  MetaUuid: ").Append(MetaUuid).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CancellationAt: ").Append(CancellationAt).Append("\n");
            sb.Append("  CancellationReason: ").Append(CancellationReason).Append("\n");
            sb.Append("  CancellationEntityUuid: ").Append(CancellationEntityUuid).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(input as AppointmentResponse);
        }

        /// <summary>
        /// Returns true if AppointmentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AppointmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppointmentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectUuid == input.ProjectUuid ||
                    (this.ProjectUuid != null &&
                    this.ProjectUuid.Equals(input.ProjectUuid))
                ) && 
                (
                    this.PlaceUuid == input.PlaceUuid ||
                    (this.PlaceUuid != null &&
                    this.PlaceUuid.Equals(input.PlaceUuid))
                ) && 
                (
                    this.ReviewGroupUuid == input.ReviewGroupUuid ||
                    (this.ReviewGroupUuid != null &&
                    this.ReviewGroupUuid.Equals(input.ReviewGroupUuid))
                ) && 
                (
                    this.ExpectedFinishAt == input.ExpectedFinishAt ||
                    (this.ExpectedFinishAt != null &&
                    this.ExpectedFinishAt.Equals(input.ExpectedFinishAt))
                ) && 
                (
                    this.ExpectedStartAt == input.ExpectedStartAt ||
                    (this.ExpectedStartAt != null &&
                    this.ExpectedStartAt.Equals(input.ExpectedStartAt))
                ) && 
                (
                    this.ActualStartAt == input.ActualStartAt ||
                    (this.ActualStartAt != null &&
                    this.ActualStartAt.Equals(input.ActualStartAt))
                ) && 
                (
                    this.ActualFinishAt == input.ActualFinishAt ||
                    (this.ActualFinishAt != null &&
                    this.ActualFinishAt.Equals(input.ActualFinishAt))
                ) && 
                (
                    this.Products == input.Products ||
                    (this.Products != null &&
                    this.Products.Equals(input.Products))
                ) && 
                (
                    this.MetaUuid == input.MetaUuid ||
                    (this.MetaUuid != null &&
                    this.MetaUuid.Equals(input.MetaUuid))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CancellationAt == input.CancellationAt ||
                    (this.CancellationAt != null &&
                    this.CancellationAt.Equals(input.CancellationAt))
                ) && 
                (
                    this.CancellationReason == input.CancellationReason ||
                    (this.CancellationReason != null &&
                    this.CancellationReason.Equals(input.CancellationReason))
                ) && 
                (
                    this.CancellationEntityUuid == input.CancellationEntityUuid ||
                    (this.CancellationEntityUuid != null &&
                    this.CancellationEntityUuid.Equals(input.CancellationEntityUuid))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.ProjectUuid != null)
                    hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.PlaceUuid != null)
                    hashCode = hashCode * 59 + this.PlaceUuid.GetHashCode();
                if (this.ReviewGroupUuid != null)
                    hashCode = hashCode * 59 + this.ReviewGroupUuid.GetHashCode();
                if (this.ExpectedFinishAt != null)
                    hashCode = hashCode * 59 + this.ExpectedFinishAt.GetHashCode();
                if (this.ExpectedStartAt != null)
                    hashCode = hashCode * 59 + this.ExpectedStartAt.GetHashCode();
                if (this.ActualStartAt != null)
                    hashCode = hashCode * 59 + this.ActualStartAt.GetHashCode();
                if (this.ActualFinishAt != null)
                    hashCode = hashCode * 59 + this.ActualFinishAt.GetHashCode();
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                if (this.MetaUuid != null)
                    hashCode = hashCode * 59 + this.MetaUuid.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CancellationAt != null)
                    hashCode = hashCode * 59 + this.CancellationAt.GetHashCode();
                if (this.CancellationReason != null)
                    hashCode = hashCode * 59 + this.CancellationReason.GetHashCode();
                if (this.CancellationEntityUuid != null)
                    hashCode = hashCode * 59 + this.CancellationEntityUuid.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
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