/*
 * eHelply SDK - 1.1.117
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.117
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
    /// GetServiceServiceWithSpecsResponse
    /// </summary>
    [DataContract(Name = "GetServiceServiceWithSpecsResponse")]
    public partial class GetServiceServiceWithSpecsResponse : IEquatable<GetServiceServiceWithSpecsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceServiceWithSpecsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetServiceServiceWithSpecsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetServiceServiceWithSpecsResponse" /> class.
        /// </summary>
        /// <param name="services">services (required).</param>
        public GetServiceServiceWithSpecsResponse(List<string> services = default(List<string>))
        {
            // to ensure "services" is required (not null)
            if (services == null)
            {
                throw new ArgumentNullException("services is a required property for GetServiceServiceWithSpecsResponse and cannot be null");
            }
            this.Services = services;
        }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name = "services", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetServiceServiceWithSpecsResponse {\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
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
            return this.Equals(input as GetServiceServiceWithSpecsResponse);
        }

        /// <summary>
        /// Returns true if GetServiceServiceWithSpecsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetServiceServiceWithSpecsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetServiceServiceWithSpecsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
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
                if (this.Services != null)
                {
                    hashCode = (hashCode * 59) + this.Services.GetHashCode();
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
