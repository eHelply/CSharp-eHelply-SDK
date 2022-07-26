/*
 * eHelply SDK - 1.1.96
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.96
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
    /// GetServiceSpecsResponse
    /// </summary>
    [DataContract(Name = "GetServiceSpecsResponse")]
    public partial class GetServiceSpecsResponse : IEquatable<GetServiceSpecsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceSpecsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetServiceSpecsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceSpecsResponse" /> class.
        /// </summary>
        /// <param name="specs">specs (required).</param>
        public GetServiceSpecsResponse(List<string> specs = default(List<string>))
        {
            // to ensure "specs" is required (not null)
            if (specs == null)
            {
                throw new ArgumentNullException("specs is a required property for GetServiceSpecsResponse and cannot be null");
            }
            this.Specs = specs;
        }

        /// <summary>
        /// Gets or Sets Specs
        /// </summary>
        [DataMember(Name = "specs", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Specs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetServiceSpecsResponse {\n");
            sb.Append("  Specs: ").Append(Specs).Append("\n");
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
            return this.Equals(input as GetServiceSpecsResponse);
        }

        /// <summary>
        /// Returns true if GetServiceSpecsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetServiceSpecsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetServiceSpecsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Specs == input.Specs ||
                    this.Specs != null &&
                    input.Specs != null &&
                    this.Specs.SequenceEqual(input.Specs)
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
                if (this.Specs != null)
                {
                    hashCode = (hashCode * 59) + this.Specs.GetHashCode();
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
