/*
 * eHelply SDK - 1.1.76
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.76
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
    /// AlarmAssign
    /// </summary>
    [DataContract(Name = "AlarmAssign")]
    public partial class AlarmAssign : IEquatable<AlarmAssign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmAssign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlarmAssign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmAssign" /> class.
        /// </summary>
        /// <param name="assigneeUuid">assigneeUuid (required).</param>
        public AlarmAssign(string assigneeUuid = default(string))
        {
            // to ensure "assigneeUuid" is required (not null)
            if (assigneeUuid == null) {
                throw new ArgumentNullException("assigneeUuid is a required property for AlarmAssign and cannot be null");
            }
            this.AssigneeUuid = assigneeUuid;
        }

        /// <summary>
        /// Gets or Sets AssigneeUuid
        /// </summary>
        [DataMember(Name = "assignee_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string AssigneeUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmAssign {\n");
            sb.Append("  AssigneeUuid: ").Append(AssigneeUuid).Append("\n");
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
            return this.Equals(input as AlarmAssign);
        }

        /// <summary>
        /// Returns true if AlarmAssign instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmAssign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmAssign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssigneeUuid == input.AssigneeUuid ||
                    (this.AssigneeUuid != null &&
                    this.AssigneeUuid.Equals(input.AssigneeUuid))
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
                if (this.AssigneeUuid != null)
                    hashCode = hashCode * 59 + this.AssigneeUuid.GetHashCode();
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
