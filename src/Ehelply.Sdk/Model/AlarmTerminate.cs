/*
 * eHelply SDK - 1.1.74
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.74
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
    /// AlarmTerminate
    /// </summary>
    [DataContract(Name = "AlarmTerminate")]
    public partial class AlarmTerminate : IEquatable<AlarmTerminate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmTerminate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlarmTerminate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmTerminate" /> class.
        /// </summary>
        /// <param name="terminaterUuid">terminaterUuid (required).</param>
        public AlarmTerminate(string terminaterUuid = default(string))
        {
            // to ensure "terminaterUuid" is required (not null)
            if (terminaterUuid == null) {
                throw new ArgumentNullException("terminaterUuid is a required property for AlarmTerminate and cannot be null");
            }
            this.TerminaterUuid = terminaterUuid;
        }

        /// <summary>
        /// Gets or Sets TerminaterUuid
        /// </summary>
        [DataMember(Name = "terminater_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string TerminaterUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmTerminate {\n");
            sb.Append("  TerminaterUuid: ").Append(TerminaterUuid).Append("\n");
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
            return this.Equals(input as AlarmTerminate);
        }

        /// <summary>
        /// Returns true if AlarmTerminate instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmTerminate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmTerminate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TerminaterUuid == input.TerminaterUuid ||
                    (this.TerminaterUuid != null &&
                    this.TerminaterUuid.Equals(input.TerminaterUuid))
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
                if (this.TerminaterUuid != null)
                    hashCode = hashCode * 59 + this.TerminaterUuid.GetHashCode();
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
