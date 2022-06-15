/*
 * eHelply SDK - 1.1.79
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.79
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
    /// **:param** name                                **type:** string **:param** meta                                **type:** dict or None  **:param** project_uuid                        **type:** string or None
    /// </summary>
    [DataContract(Name = "CategoryBase")]
    public partial class CategoryBase : IEquatable<CategoryBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoryBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryBase" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="metaUuid">metaUuid.</param>
        /// <param name="meta">meta.</param>
        /// <param name="projectUuid">projectUuid.</param>
        public CategoryBase(string name = default(string), string metaUuid = default(string), Object meta = default(Object), string projectUuid = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CategoryBase and cannot be null");
            }
            this.Name = name;
            this.MetaUuid = metaUuid;
            this.Meta = meta;
            this.ProjectUuid = projectUuid;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets MetaUuid
        /// </summary>
        [DataMember(Name = "meta_uuid", EmitDefaultValue = false)]
        public string MetaUuid { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public Object Meta { get; set; }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CategoryBase {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MetaUuid: ").Append(MetaUuid).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
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
            return this.Equals(input as CategoryBase);
        }

        /// <summary>
        /// Returns true if CategoryBase instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryBase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MetaUuid == input.MetaUuid ||
                    (this.MetaUuid != null &&
                    this.MetaUuid.Equals(input.MetaUuid))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.ProjectUuid == input.ProjectUuid ||
                    (this.ProjectUuid != null &&
                    this.ProjectUuid.Equals(input.ProjectUuid))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.MetaUuid != null)
                {
                    hashCode = (hashCode * 59) + this.MetaUuid.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
                }
                if (this.ProjectUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectUuid.GetHashCode();
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
