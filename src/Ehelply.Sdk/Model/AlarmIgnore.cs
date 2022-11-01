/*
 * eHelply SDK - 1.1.121
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.121
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
    /// AlarmIgnore
    /// </summary>
    [DataContract(Name = "AlarmIgnore")]
    public partial class AlarmIgnore : IEquatable<AlarmIgnore>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmIgnore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlarmIgnore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmIgnore" /> class.
        /// </summary>
        /// <param name="ignorerUuid">ignorerUuid (required).</param>
        public AlarmIgnore(string ignorerUuid = default(string))
        {
            // to ensure "ignorerUuid" is required (not null)
            if (ignorerUuid == null)
            {
                throw new ArgumentNullException("ignorerUuid is a required property for AlarmIgnore and cannot be null");
            }
            this.IgnorerUuid = ignorerUuid;
        }

        /// <summary>
        /// Gets or Sets IgnorerUuid
        /// </summary>
        [DataMember(Name = "ignorer_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string IgnorerUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlarmIgnore {\n");
            sb.Append("  IgnorerUuid: ").Append(IgnorerUuid).Append("\n");
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
            return this.Equals(input as AlarmIgnore);
        }

        /// <summary>
        /// Returns true if AlarmIgnore instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmIgnore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmIgnore input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IgnorerUuid == input.IgnorerUuid ||
                    (this.IgnorerUuid != null &&
                    this.IgnorerUuid.Equals(input.IgnorerUuid))
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
                if (this.IgnorerUuid != null)
                {
                    hashCode = (hashCode * 59) + this.IgnorerUuid.GetHashCode();
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
