/*
 * eHelply SDK - 1.1.109
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.109
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
    /// CreateProjectCredential
    /// </summary>
    [DataContract(Name = "CreateProjectCredential")]
    public partial class CreateProjectCredential : IEquatable<CreateProjectCredential>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectCredential" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateProjectCredential() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectCredential" /> class.
        /// </summary>
        /// <param name="serviceName">serviceName (required).</param>
        /// <param name="secrets">secrets (required).</param>
        public CreateProjectCredential(string serviceName = default(string), List<Credential> secrets = default(List<Credential>))
        {
            // to ensure "serviceName" is required (not null)
            if (serviceName == null)
            {
                throw new ArgumentNullException("serviceName is a required property for CreateProjectCredential and cannot be null");
            }
            this.ServiceName = serviceName;
            // to ensure "secrets" is required (not null)
            if (secrets == null)
            {
                throw new ArgumentNullException("secrets is a required property for CreateProjectCredential and cannot be null");
            }
            this.Secrets = secrets;
        }

        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name = "service_name", IsRequired = true, EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or Sets Secrets
        /// </summary>
        [DataMember(Name = "secrets", IsRequired = true, EmitDefaultValue = false)]
        public List<Credential> Secrets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateProjectCredential {\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Secrets: ").Append(Secrets).Append("\n");
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
            return this.Equals(input as CreateProjectCredential);
        }

        /// <summary>
        /// Returns true if CreateProjectCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateProjectCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateProjectCredential input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.Secrets == input.Secrets ||
                    this.Secrets != null &&
                    input.Secrets != null &&
                    this.Secrets.SequenceEqual(input.Secrets)
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
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
                }
                if (this.Secrets != null)
                {
                    hashCode = (hashCode * 59) + this.Secrets.GetHashCode();
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
