/*
 * eHelply SDK - 1.1.73
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.73
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
    /// AttachPaymentToProject
    /// </summary>
    [DataContract(Name = "AttachPaymentToProject")]
    public partial class AttachPaymentToProject : IEquatable<AttachPaymentToProject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachPaymentToProject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttachPaymentToProject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachPaymentToProject" /> class.
        /// </summary>
        /// <param name="paymentType">paymentType (required).</param>
        /// <param name="number">number (required).</param>
        /// <param name="expMonth">expMonth (required).</param>
        /// <param name="expYear">expYear (required).</param>
        /// <param name="cvc">cvc (required).</param>
        public AttachPaymentToProject(string paymentType = default(string), string number = default(string), int expMonth = default(int), int expYear = default(int), string cvc = default(string))
        {
            // to ensure "paymentType" is required (not null)
            if (paymentType == null)
            {
                throw new ArgumentNullException("paymentType is a required property for AttachPaymentToProject and cannot be null");
            }
            this.PaymentType = paymentType;
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new ArgumentNullException("number is a required property for AttachPaymentToProject and cannot be null");
            }
            this.Number = number;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            // to ensure "cvc" is required (not null)
            if (cvc == null)
            {
                throw new ArgumentNullException("cvc is a required property for AttachPaymentToProject and cannot be null");
            }
            this.Cvc = cvc;
        }

        /// <summary>
        /// Gets or Sets PaymentType
        /// </summary>
        [DataMember(Name = "payment_type", IsRequired = true, EmitDefaultValue = false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets ExpMonth
        /// </summary>
        [DataMember(Name = "exp_month", IsRequired = true, EmitDefaultValue = false)]
        public int ExpMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpYear
        /// </summary>
        [DataMember(Name = "exp_year", IsRequired = true, EmitDefaultValue = false)]
        public int ExpYear { get; set; }

        /// <summary>
        /// Gets or Sets Cvc
        /// </summary>
        [DataMember(Name = "cvc", IsRequired = true, EmitDefaultValue = false)]
        public string Cvc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachPaymentToProject {\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  Cvc: ").Append(Cvc).Append("\n");
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
            return this.Equals(input as AttachPaymentToProject);
        }

        /// <summary>
        /// Returns true if AttachPaymentToProject instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachPaymentToProject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachPaymentToProject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.ExpMonth == input.ExpMonth ||
                    this.ExpMonth.Equals(input.ExpMonth)
                ) && 
                (
                    this.ExpYear == input.ExpYear ||
                    this.ExpYear.Equals(input.ExpYear)
                ) && 
                (
                    this.Cvc == input.Cvc ||
                    (this.Cvc != null &&
                    this.Cvc.Equals(input.Cvc))
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
                if (this.PaymentType != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentType.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpMonth.GetHashCode();
                hashCode = (hashCode * 59) + this.ExpYear.GetHashCode();
                if (this.Cvc != null)
                {
                    hashCode = (hashCode * 59) + this.Cvc.GetHashCode();
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
