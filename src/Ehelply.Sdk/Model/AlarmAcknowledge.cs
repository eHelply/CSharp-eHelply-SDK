/*
 * eHelply SDK - 1.1.118
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.118
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
    /// AlarmAcknowledge
    /// </summary>
    [DataContract(Name = "AlarmAcknowledge")]
    public partial class AlarmAcknowledge : IEquatable<AlarmAcknowledge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmAcknowledge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlarmAcknowledge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmAcknowledge" /> class.
        /// </summary>
        /// <param name="acknowledgerUuid">acknowledgerUuid (required).</param>
        public AlarmAcknowledge(string acknowledgerUuid = default(string))
        {
            // to ensure "acknowledgerUuid" is required (not null)
            if (acknowledgerUuid == null)
            {
                throw new ArgumentNullException("acknowledgerUuid is a required property for AlarmAcknowledge and cannot be null");
            }
            this.AcknowledgerUuid = acknowledgerUuid;
        }

        /// <summary>
        /// Gets or Sets AcknowledgerUuid
        /// </summary>
        [DataMember(Name = "acknowledger_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string AcknowledgerUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlarmAcknowledge {\n");
            sb.Append("  AcknowledgerUuid: ").Append(AcknowledgerUuid).Append("\n");
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
            return this.Equals(input as AlarmAcknowledge);
        }

        /// <summary>
        /// Returns true if AlarmAcknowledge instances are equal
        /// </summary>
        /// <param name="input">Instance of AlarmAcknowledge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlarmAcknowledge input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcknowledgerUuid == input.AcknowledgerUuid ||
                    (this.AcknowledgerUuid != null &&
                    this.AcknowledgerUuid.Equals(input.AcknowledgerUuid))
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
                if (this.AcknowledgerUuid != null)
                {
                    hashCode = (hashCode * 59) + this.AcknowledgerUuid.GetHashCode();
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
