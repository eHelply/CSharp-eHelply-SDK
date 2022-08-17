/*
 * eHelply SDK - 1.1.108
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.108
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
    /// GetTransactionResponse
    /// </summary>
    [DataContract(Name = "GetTransactionResponse")]
    public partial class GetTransactionResponse : IEquatable<GetTransactionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetTransactionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponse" /> class.
        /// </summary>
        /// <param name="invoice">invoice.</param>
        /// <param name="transactionUuid">transactionUuid (required).</param>
        /// <param name="stripeId">stripeId (required).</param>
        /// <param name="credit">credit (required).</param>
        /// <param name="debit">debit (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        public GetTransactionResponse(GetInvoiceResponse invoice = default(GetInvoiceResponse), string transactionUuid = default(string), string stripeId = default(string), int credit = default(int), int debit = default(int), string createdAt = default(string))
        {
            // to ensure "transactionUuid" is required (not null)
            if (transactionUuid == null)
            {
                throw new ArgumentNullException("transactionUuid is a required property for GetTransactionResponse and cannot be null");
            }
            this.TransactionUuid = transactionUuid;
            // to ensure "stripeId" is required (not null)
            if (stripeId == null)
            {
                throw new ArgumentNullException("stripeId is a required property for GetTransactionResponse and cannot be null");
            }
            this.StripeId = stripeId;
            this.Credit = credit;
            this.Debit = debit;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for GetTransactionResponse and cannot be null");
            }
            this.CreatedAt = createdAt;
            this.Invoice = invoice;
        }

        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name = "invoice", EmitDefaultValue = false)]
        public GetInvoiceResponse Invoice { get; set; }

        /// <summary>
        /// Gets or Sets TransactionUuid
        /// </summary>
        [DataMember(Name = "transaction_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionUuid { get; set; }

        /// <summary>
        /// Gets or Sets StripeId
        /// </summary>
        [DataMember(Name = "stripe_id", IsRequired = true, EmitDefaultValue = false)]
        public string StripeId { get; set; }

        /// <summary>
        /// Gets or Sets Credit
        /// </summary>
        [DataMember(Name = "credit", IsRequired = true, EmitDefaultValue = false)]
        public int Credit { get; set; }

        /// <summary>
        /// Gets or Sets Debit
        /// </summary>
        [DataMember(Name = "debit", IsRequired = true, EmitDefaultValue = false)]
        public int Debit { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionResponse {\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  TransactionUuid: ").Append(TransactionUuid).Append("\n");
            sb.Append("  StripeId: ").Append(StripeId).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Debit: ").Append(Debit).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as GetTransactionResponse);
        }

        /// <summary>
        /// Returns true if GetTransactionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTransactionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTransactionResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
                ) && 
                (
                    this.TransactionUuid == input.TransactionUuid ||
                    (this.TransactionUuid != null &&
                    this.TransactionUuid.Equals(input.TransactionUuid))
                ) && 
                (
                    this.StripeId == input.StripeId ||
                    (this.StripeId != null &&
                    this.StripeId.Equals(input.StripeId))
                ) && 
                (
                    this.Credit == input.Credit ||
                    this.Credit.Equals(input.Credit)
                ) && 
                (
                    this.Debit == input.Debit ||
                    this.Debit.Equals(input.Debit)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Invoice != null)
                {
                    hashCode = (hashCode * 59) + this.Invoice.GetHashCode();
                }
                if (this.TransactionUuid != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionUuid.GetHashCode();
                }
                if (this.StripeId != null)
                {
                    hashCode = (hashCode * 59) + this.StripeId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Credit.GetHashCode();
                hashCode = (hashCode * 59) + this.Debit.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
