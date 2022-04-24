/*
 * eHelply SDK - 1.1.67
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.67
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
    /// BodyProcessPaymentBillingProcessPaymentPost
    /// </summary>
    [DataContract(Name = "Body_process_payment_billing_process_payment_post")]
    public partial class BodyProcessPaymentBillingProcessPaymentPost : IEquatable<BodyProcessPaymentBillingProcessPaymentPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyProcessPaymentBillingProcessPaymentPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyProcessPaymentBillingProcessPaymentPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyProcessPaymentBillingProcessPaymentPost" /> class.
        /// </summary>
        /// <param name="paymentSchema">paymentSchema (required).</param>
        public BodyProcessPaymentBillingProcessPaymentPost(Payment paymentSchema = default(Payment))
        {
            // to ensure "paymentSchema" is required (not null)
            if (paymentSchema == null) {
                throw new ArgumentNullException("paymentSchema is a required property for BodyProcessPaymentBillingProcessPaymentPost and cannot be null");
            }
            this.PaymentSchema = paymentSchema;
        }

        /// <summary>
        /// Gets or Sets PaymentSchema
        /// </summary>
        [DataMember(Name = "payment_schema", IsRequired = true, EmitDefaultValue = false)]
        public Payment PaymentSchema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BodyProcessPaymentBillingProcessPaymentPost {\n");
            sb.Append("  PaymentSchema: ").Append(PaymentSchema).Append("\n");
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
            return this.Equals(input as BodyProcessPaymentBillingProcessPaymentPost);
        }

        /// <summary>
        /// Returns true if BodyProcessPaymentBillingProcessPaymentPost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyProcessPaymentBillingProcessPaymentPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyProcessPaymentBillingProcessPaymentPost input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentSchema == input.PaymentSchema ||
                    (this.PaymentSchema != null &&
                    this.PaymentSchema.Equals(input.PaymentSchema))
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
                if (this.PaymentSchema != null)
                    hashCode = hashCode * 59 + this.PaymentSchema.GetHashCode();
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
