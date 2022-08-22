/*
 * eHelply SDK - 1.1.103
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.103
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
    /// ValidationError
    /// </summary>
    [DataContract(Name = "ValidationError")]
    public partial class ValidationError : IEquatable<ValidationError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidationError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationError" /> class.
        /// </summary>
        /// <param name="loc">loc (required).</param>
        /// <param name="msg">msg (required).</param>
        /// <param name="type">type (required).</param>
        public ValidationError(List<string> loc = default(List<string>), string msg = default(string), string type = default(string))
        {
            // to ensure "loc" is required (not null)
            if (loc == null)
            {
                throw new ArgumentNullException("loc is a required property for ValidationError and cannot be null");
            }
            this.Loc = loc;
            // to ensure "msg" is required (not null)
            if (msg == null)
            {
                throw new ArgumentNullException("msg is a required property for ValidationError and cannot be null");
            }
            this.Msg = msg;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ValidationError and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Loc
        /// </summary>
        [DataMember(Name = "loc", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Loc { get; set; }

        /// <summary>
        /// Gets or Sets Msg
        /// </summary>
        [DataMember(Name = "msg", IsRequired = true, EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidationError {\n");
            sb.Append("  Loc: ").Append(Loc).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ValidationError);
        }

        /// <summary>
        /// Returns true if ValidationError instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Loc == input.Loc ||
                    this.Loc != null &&
                    input.Loc != null &&
                    this.Loc.SequenceEqual(input.Loc)
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Loc != null)
                {
                    hashCode = (hashCode * 59) + this.Loc.GetHashCode();
                }
                if (this.Msg != null)
                {
                    hashCode = (hashCode * 59) + this.Msg.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
