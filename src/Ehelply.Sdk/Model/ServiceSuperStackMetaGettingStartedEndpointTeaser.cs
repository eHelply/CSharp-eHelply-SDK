/*
 * eHelply SDK - 1.1.116
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.116
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
    /// ServiceSuperStackMetaGettingStartedEndpointTeaser
    /// </summary>
    [DataContract(Name = "ServiceSuperStackMetaGettingStartedEndpointTeaser")]
    public partial class ServiceSuperStackMetaGettingStartedEndpointTeaser : IEquatable<ServiceSuperStackMetaGettingStartedEndpointTeaser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceSuperStackMetaGettingStartedEndpointTeaser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceSuperStackMetaGettingStartedEndpointTeaser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceSuperStackMetaGettingStartedEndpointTeaser" /> class.
        /// </summary>
        /// <param name="path">path (required).</param>
        /// <param name="method">method (required).</param>
        /// <param name="description">description (required).</param>
        public ServiceSuperStackMetaGettingStartedEndpointTeaser(string path = default(string), string method = default(string), string description = default(string))
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for ServiceSuperStackMetaGettingStartedEndpointTeaser and cannot be null");
            }
            this.Path = path;
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new ArgumentNullException("method is a required property for ServiceSuperStackMetaGettingStartedEndpointTeaser and cannot be null");
            }
            this.Method = method;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for ServiceSuperStackMetaGettingStartedEndpointTeaser and cannot be null");
            }
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceSuperStackMetaGettingStartedEndpointTeaser {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as ServiceSuperStackMetaGettingStartedEndpointTeaser);
        }

        /// <summary>
        /// Returns true if ServiceSuperStackMetaGettingStartedEndpointTeaser instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceSuperStackMetaGettingStartedEndpointTeaser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceSuperStackMetaGettingStartedEndpointTeaser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Path != null)
                {
                    hashCode = (hashCode * 59) + this.Path.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
