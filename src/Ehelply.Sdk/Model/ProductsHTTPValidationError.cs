/*
 * eHelply SDK - 1.1.61
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.61
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
    /// ProductsHTTPValidationError
    /// </summary>
    [DataContract(Name = "ProductsHTTPValidationError")]
    public partial class ProductsHTTPValidationError : IEquatable<ProductsHTTPValidationError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsHTTPValidationError" /> class.
        /// </summary>
        /// <param name="detail">detail.</param>
        public ProductsHTTPValidationError(List<ProductsValidationError> detail = default(List<ProductsValidationError>))
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public List<ProductsValidationError> Detail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductsHTTPValidationError {\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
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
            return this.Equals(input as ProductsHTTPValidationError);
        }

        /// <summary>
        /// Returns true if ProductsHTTPValidationError instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductsHTTPValidationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductsHTTPValidationError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Detail == input.Detail ||
                    this.Detail != null &&
                    input.Detail != null &&
                    this.Detail.SequenceEqual(input.Detail)
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
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
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
