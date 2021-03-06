/*
 * eHelply SDK - 1.1.90
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.90
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
    /// Used for update endpoint
    /// </summary>
    [DataContract(Name = "ProjectsProjectUpdate")]
    public partial class ProjectsProjectUpdate : IEquatable<ProjectsProjectUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsProjectUpdate" /> class.
        /// </summary>
        /// <param name="maxSpend">maxSpend.</param>
        /// <param name="status">status.</param>
        public ProjectsProjectUpdate(int maxSpend = default(int), string status = default(string))
        {
            this.MaxSpend = maxSpend;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets MaxSpend
        /// </summary>
        [DataMember(Name = "max_spend", EmitDefaultValue = false)]
        public int MaxSpend { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProjectsProjectUpdate {\n");
            sb.Append("  MaxSpend: ").Append(MaxSpend).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as ProjectsProjectUpdate);
        }

        /// <summary>
        /// Returns true if ProjectsProjectUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectsProjectUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectsProjectUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxSpend == input.MaxSpend ||
                    this.MaxSpend.Equals(input.MaxSpend)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                hashCode = (hashCode * 59) + this.MaxSpend.GetHashCode();
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
