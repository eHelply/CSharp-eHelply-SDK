/*
 * eHelply SDK - 1.1.98
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.98
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
    /// GetServiceSpecResponse
    /// </summary>
    [DataContract(Name = "GetServiceSpecResponse")]
    public partial class GetServiceSpecResponse : IEquatable<GetServiceSpecResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceSpecResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetServiceSpecResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceSpecResponse" /> class.
        /// </summary>
        /// <param name="contents">contents (required).</param>
        public GetServiceSpecResponse(string contents = default(string))
        {
            // to ensure "contents" is required (not null)
            if (contents == null)
            {
                throw new ArgumentNullException("contents is a required property for GetServiceSpecResponse and cannot be null");
            }
            this.Contents = contents;
        }

        /// <summary>
        /// Gets or Sets Contents
        /// </summary>
        [DataMember(Name = "contents", IsRequired = true, EmitDefaultValue = false)]
        public string Contents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetServiceSpecResponse {\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
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
            return this.Equals(input as GetServiceSpecResponse);
        }

        /// <summary>
        /// Returns true if GetServiceSpecResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetServiceSpecResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetServiceSpecResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Contents == input.Contents ||
                    (this.Contents != null &&
                    this.Contents.Equals(input.Contents))
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
                if (this.Contents != null)
                {
                    hashCode = (hashCode * 59) + this.Contents.GetHashCode();
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
