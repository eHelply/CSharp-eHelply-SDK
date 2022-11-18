/*
 * eHelply SDK - 1.1.122
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.122
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
    /// GetProjectInvoiceResponse
    /// </summary>
    [DataContract(Name = "GetProjectInvoiceResponse")]
    public partial class GetProjectInvoiceResponse : IEquatable<GetProjectInvoiceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectInvoiceResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetProjectInvoiceResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectInvoiceResponse" /> class.
        /// </summary>
        /// <param name="projectUuid">projectUuid (required).</param>
        /// <param name="invoiceUuid">invoiceUuid (required).</param>
        /// <param name="year">year (required).</param>
        /// <param name="month">month (required).</param>
        /// <param name="createdBy">createdBy (required).</param>
        /// <param name="invoice">invoice.</param>
        public GetProjectInvoiceResponse(string projectUuid = default(string), string invoiceUuid = default(string), int year = default(int), int month = default(int), string createdBy = default(string), GetInvoiceResponse invoice = default(GetInvoiceResponse))
        {
            // to ensure "projectUuid" is required (not null)
            if (projectUuid == null)
            {
                throw new ArgumentNullException("projectUuid is a required property for GetProjectInvoiceResponse and cannot be null");
            }
            this.ProjectUuid = projectUuid;
            // to ensure "invoiceUuid" is required (not null)
            if (invoiceUuid == null)
            {
                throw new ArgumentNullException("invoiceUuid is a required property for GetProjectInvoiceResponse and cannot be null");
            }
            this.InvoiceUuid = invoiceUuid;
            this.Year = year;
            this.Month = month;
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new ArgumentNullException("createdBy is a required property for GetProjectInvoiceResponse and cannot be null");
            }
            this.CreatedBy = createdBy;
            this.Invoice = invoice;
        }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceUuid
        /// </summary>
        [DataMember(Name = "invoice_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string InvoiceUuid { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name = "year", IsRequired = true, EmitDefaultValue = false)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name = "month", IsRequired = true, EmitDefaultValue = false)]
        public int Month { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "created_by", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name = "invoice", EmitDefaultValue = false)]
        public GetInvoiceResponse Invoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetProjectInvoiceResponse {\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  InvoiceUuid: ").Append(InvoiceUuid).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
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
            return this.Equals(input as GetProjectInvoiceResponse);
        }

        /// <summary>
        /// Returns true if GetProjectInvoiceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProjectInvoiceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProjectInvoiceResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProjectUuid == input.ProjectUuid ||
                    (this.ProjectUuid != null &&
                    this.ProjectUuid.Equals(input.ProjectUuid))
                ) && 
                (
                    this.InvoiceUuid == input.InvoiceUuid ||
                    (this.InvoiceUuid != null &&
                    this.InvoiceUuid.Equals(input.InvoiceUuid))
                ) && 
                (
                    this.Year == input.Year ||
                    this.Year.Equals(input.Year)
                ) && 
                (
                    this.Month == input.Month ||
                    this.Month.Equals(input.Month)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
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
                if (this.ProjectUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectUuid.GetHashCode();
                }
                if (this.InvoiceUuid != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceUuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Year.GetHashCode();
                hashCode = (hashCode * 59) + this.Month.GetHashCode();
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.Invoice != null)
                {
                    hashCode = (hashCode * 59) + this.Invoice.GetHashCode();
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
