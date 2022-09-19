/*
 * eHelply SDK - 1.1.114
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.114
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
    /// GetInvoiceResponse
    /// </summary>
    [DataContract(Name = "GetInvoiceResponse")]
    public partial class GetInvoiceResponse : IEquatable<GetInvoiceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetInvoiceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInvoiceResponse" /> class.
        /// </summary>
        /// <param name="invoiceUuid">invoiceUuid (required).</param>
        /// <param name="lineItems">lineItems (required).</param>
        /// <param name="subtotal">subtotal (required).</param>
        /// <param name="discounts">discounts (required).</param>
        /// <param name="taxes">taxes (required).</param>
        /// <param name="total">total (required).</param>
        /// <param name="notes">notes (required).</param>
        /// <param name="paid">paid (default to false).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updateAt">updateAt (required).</param>
        /// <param name="deletedAt">deletedAt.</param>
        public GetInvoiceResponse(string invoiceUuid = default(string), List<LineItem> lineItems = default(List<LineItem>), int subtotal = default(int), List<Discount> discounts = default(List<Discount>), List<Tax> taxes = default(List<Tax>), int total = default(int), List<Note> notes = default(List<Note>), bool paid = false, string createdAt = default(string), string updateAt = default(string), string deletedAt = default(string))
        {
            // to ensure "invoiceUuid" is required (not null)
            if (invoiceUuid == null)
            {
                throw new ArgumentNullException("invoiceUuid is a required property for GetInvoiceResponse and cannot be null");
            }
            this.InvoiceUuid = invoiceUuid;
            // to ensure "lineItems" is required (not null)
            if (lineItems == null)
            {
                throw new ArgumentNullException("lineItems is a required property for GetInvoiceResponse and cannot be null");
            }
            this.LineItems = lineItems;
            this.Subtotal = subtotal;
            // to ensure "discounts" is required (not null)
            if (discounts == null)
            {
                throw new ArgumentNullException("discounts is a required property for GetInvoiceResponse and cannot be null");
            }
            this.Discounts = discounts;
            // to ensure "taxes" is required (not null)
            if (taxes == null)
            {
                throw new ArgumentNullException("taxes is a required property for GetInvoiceResponse and cannot be null");
            }
            this.Taxes = taxes;
            this.Total = total;
            // to ensure "notes" is required (not null)
            if (notes == null)
            {
                throw new ArgumentNullException("notes is a required property for GetInvoiceResponse and cannot be null");
            }
            this.Notes = notes;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for GetInvoiceResponse and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "updateAt" is required (not null)
            if (updateAt == null)
            {
                throw new ArgumentNullException("updateAt is a required property for GetInvoiceResponse and cannot be null");
            }
            this.UpdateAt = updateAt;
            this.Paid = paid;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Gets or Sets InvoiceUuid
        /// </summary>
        [DataMember(Name = "invoice_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string InvoiceUuid { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "line_items", IsRequired = true, EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name = "subtotal", IsRequired = true, EmitDefaultValue = false)]
        public int Subtotal { get; set; }

        /// <summary>
        /// Gets or Sets Discounts
        /// </summary>
        [DataMember(Name = "discounts", IsRequired = true, EmitDefaultValue = false)]
        public List<Discount> Discounts { get; set; }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name = "taxes", IsRequired = true, EmitDefaultValue = false)]
        public List<Tax> Taxes { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", IsRequired = true, EmitDefaultValue = false)]
        public List<Note> Notes { get; set; }

        /// <summary>
        /// Gets or Sets Paid
        /// </summary>
        [DataMember(Name = "paid", EmitDefaultValue = true)]
        public bool Paid { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdateAt
        /// </summary>
        [DataMember(Name = "update_at", IsRequired = true, EmitDefaultValue = false)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name = "deleted_at", EmitDefaultValue = false)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetInvoiceResponse {\n");
            sb.Append("  InvoiceUuid: ").Append(InvoiceUuid).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  Discounts: ").Append(Discounts).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
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
            return this.Equals(input as GetInvoiceResponse);
        }

        /// <summary>
        /// Returns true if GetInvoiceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetInvoiceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInvoiceResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InvoiceUuid == input.InvoiceUuid ||
                    (this.InvoiceUuid != null &&
                    this.InvoiceUuid.Equals(input.InvoiceUuid))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Subtotal == input.Subtotal ||
                    this.Subtotal.Equals(input.Subtotal)
                ) && 
                (
                    this.Discounts == input.Discounts ||
                    this.Discounts != null &&
                    input.Discounts != null &&
                    this.Discounts.SequenceEqual(input.Discounts)
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    input.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
                ) && 
                (
                    this.Paid == input.Paid ||
                    this.Paid.Equals(input.Paid)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdateAt == input.UpdateAt ||
                    (this.UpdateAt != null &&
                    this.UpdateAt.Equals(input.UpdateAt))
                ) && 
                (
                    this.DeletedAt == input.DeletedAt ||
                    (this.DeletedAt != null &&
                    this.DeletedAt.Equals(input.DeletedAt))
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
                if (this.InvoiceUuid != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceUuid.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Subtotal.GetHashCode();
                if (this.Discounts != null)
                {
                    hashCode = (hashCode * 59) + this.Discounts.GetHashCode();
                }
                if (this.Taxes != null)
                {
                    hashCode = (hashCode * 59) + this.Taxes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Paid.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdateAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateAt.GetHashCode();
                }
                if (this.DeletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeletedAt.GetHashCode();
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
