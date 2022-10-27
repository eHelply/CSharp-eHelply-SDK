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
    /// GetProjectInvoiceHistory
    /// </summary>
    [DataContract(Name = "GetProjectInvoiceHistory")]
    public partial class GetProjectInvoiceHistory : IEquatable<GetProjectInvoiceHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectInvoiceHistory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetProjectInvoiceHistory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectInvoiceHistory" /> class.
        /// </summary>
        /// <param name="projectUuid">projectUuid (required).</param>
        /// <param name="invoiceHistory">invoiceHistory.</param>
        public GetProjectInvoiceHistory(string projectUuid = default(string), List<History> invoiceHistory = default(List<History>))
        {
            // to ensure "projectUuid" is required (not null)
            if (projectUuid == null)
            {
                throw new ArgumentNullException("projectUuid is a required property for GetProjectInvoiceHistory and cannot be null");
            }
            this.ProjectUuid = projectUuid;
            this.InvoiceHistory = invoiceHistory;
        }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceHistory
        /// </summary>
        [DataMember(Name = "invoice_history", EmitDefaultValue = false)]
        public List<History> InvoiceHistory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetProjectInvoiceHistory {\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  InvoiceHistory: ").Append(InvoiceHistory).Append("\n");
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
            return this.Equals(input as GetProjectInvoiceHistory);
        }

        /// <summary>
        /// Returns true if GetProjectInvoiceHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of GetProjectInvoiceHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetProjectInvoiceHistory input)
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
                    this.InvoiceHistory == input.InvoiceHistory ||
                    this.InvoiceHistory != null &&
                    input.InvoiceHistory != null &&
                    this.InvoiceHistory.SequenceEqual(input.InvoiceHistory)
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
                if (this.InvoiceHistory != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceHistory.GetHashCode();
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
