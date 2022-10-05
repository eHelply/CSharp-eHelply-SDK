/*
 * eHelply SDK - 1.1.110
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.110
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
    /// MetaChildren
    /// </summary>
    [DataContract(Name = "MetaChildren")]
    public partial class MetaChildren : IEquatable<MetaChildren>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaChildren" /> class.
        /// </summary>
        /// <param name="childName">childName.</param>
        /// <param name="childDescription">childDescription.</param>
        /// <param name="childUuid">childUuid.</param>
        public MetaChildren(string childName = default(string), string childDescription = default(string), string childUuid = default(string))
        {
            this.ChildName = childName;
            this.ChildDescription = childDescription;
            this.ChildUuid = childUuid;
        }

        /// <summary>
        /// Gets or Sets ChildName
        /// </summary>
        [DataMember(Name = "child_name", EmitDefaultValue = false)]
        public string ChildName { get; set; }

        /// <summary>
        /// Gets or Sets ChildDescription
        /// </summary>
        [DataMember(Name = "child_description", EmitDefaultValue = false)]
        public string ChildDescription { get; set; }

        /// <summary>
        /// Gets or Sets ChildUuid
        /// </summary>
        [DataMember(Name = "child_uuid", EmitDefaultValue = false)]
        public string ChildUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetaChildren {\n");
            sb.Append("  ChildName: ").Append(ChildName).Append("\n");
            sb.Append("  ChildDescription: ").Append(ChildDescription).Append("\n");
            sb.Append("  ChildUuid: ").Append(ChildUuid).Append("\n");
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
            return this.Equals(input as MetaChildren);
        }

        /// <summary>
        /// Returns true if MetaChildren instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaChildren to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaChildren input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChildName == input.ChildName ||
                    (this.ChildName != null &&
                    this.ChildName.Equals(input.ChildName))
                ) && 
                (
                    this.ChildDescription == input.ChildDescription ||
                    (this.ChildDescription != null &&
                    this.ChildDescription.Equals(input.ChildDescription))
                ) && 
                (
                    this.ChildUuid == input.ChildUuid ||
                    (this.ChildUuid != null &&
                    this.ChildUuid.Equals(input.ChildUuid))
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
                if (this.ChildName != null)
                {
                    hashCode = (hashCode * 59) + this.ChildName.GetHashCode();
                }
                if (this.ChildDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ChildDescription.GetHashCode();
                }
                if (this.ChildUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ChildUuid.GetHashCode();
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
