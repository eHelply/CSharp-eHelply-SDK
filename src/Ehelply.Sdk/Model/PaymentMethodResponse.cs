/*
 * eHelply SDK - 1.1.105
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.105
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
    /// PaymentMethodResponse
    /// </summary>
    [DataContract(Name = "PaymentMethodResponse")]
    public partial class PaymentMethodResponse : IEquatable<PaymentMethodResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodResponse" /> class.
        /// </summary>
        /// <param name="paymentId">paymentId (required).</param>
        /// <param name="last4Digits">last4Digits (required).</param>
        /// <param name="cardBrand">cardBrand (required).</param>
        /// <param name="projectUuid">projectUuid (required).</param>
        public PaymentMethodResponse(string paymentId = default(string), string last4Digits = default(string), string cardBrand = default(string), string projectUuid = default(string))
        {
            // to ensure "paymentId" is required (not null)
            if (paymentId == null)
            {
                throw new ArgumentNullException("paymentId is a required property for PaymentMethodResponse and cannot be null");
            }
            this.PaymentId = paymentId;
            // to ensure "last4Digits" is required (not null)
            if (last4Digits == null)
            {
                throw new ArgumentNullException("last4Digits is a required property for PaymentMethodResponse and cannot be null");
            }
            this.Last4Digits = last4Digits;
            // to ensure "cardBrand" is required (not null)
            if (cardBrand == null)
            {
                throw new ArgumentNullException("cardBrand is a required property for PaymentMethodResponse and cannot be null");
            }
            this.CardBrand = cardBrand;
            // to ensure "projectUuid" is required (not null)
            if (projectUuid == null)
            {
                throw new ArgumentNullException("projectUuid is a required property for PaymentMethodResponse and cannot be null");
            }
            this.ProjectUuid = projectUuid;
        }

        /// <summary>
        /// Gets or Sets PaymentId
        /// </summary>
        [DataMember(Name = "payment_id", IsRequired = true, EmitDefaultValue = false)]
        public string PaymentId { get; set; }

        /// <summary>
        /// Gets or Sets Last4Digits
        /// </summary>
        [DataMember(Name = "last_4_digits", IsRequired = true, EmitDefaultValue = false)]
        public string Last4Digits { get; set; }

        /// <summary>
        /// Gets or Sets CardBrand
        /// </summary>
        [DataMember(Name = "card_brand", IsRequired = true, EmitDefaultValue = false)]
        public string CardBrand { get; set; }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodResponse {\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  Last4Digits: ").Append(Last4Digits).Append("\n");
            sb.Append("  CardBrand: ").Append(CardBrand).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
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
            return this.Equals(input as PaymentMethodResponse);
        }

        /// <summary>
        /// Returns true if PaymentMethodResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && 
                (
                    this.Last4Digits == input.Last4Digits ||
                    (this.Last4Digits != null &&
                    this.Last4Digits.Equals(input.Last4Digits))
                ) && 
                (
                    this.CardBrand == input.CardBrand ||
                    (this.CardBrand != null &&
                    this.CardBrand.Equals(input.CardBrand))
                ) && 
                (
                    this.ProjectUuid == input.ProjectUuid ||
                    (this.ProjectUuid != null &&
                    this.ProjectUuid.Equals(input.ProjectUuid))
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
                if (this.PaymentId != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentId.GetHashCode();
                }
                if (this.Last4Digits != null)
                {
                    hashCode = (hashCode * 59) + this.Last4Digits.GetHashCode();
                }
                if (this.CardBrand != null)
                {
                    hashCode = (hashCode * 59) + this.CardBrand.GetHashCode();
                }
                if (this.ProjectUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectUuid.GetHashCode();
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
