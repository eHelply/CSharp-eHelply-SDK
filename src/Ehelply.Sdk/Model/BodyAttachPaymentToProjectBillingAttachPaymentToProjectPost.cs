/*
 * eHelply SDK - 1.1.87
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.87
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
    /// BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost
    /// </summary>
    [DataContract(Name = "Body_attach_payment_to_project_billing_attach_payment_to_project_post")]
    public partial class BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost : IEquatable<BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost" /> class.
        /// </summary>
        /// <param name="attachmentDetails">attachmentDetails (required).</param>
        public BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost(AttachPaymentToProject attachmentDetails = default(AttachPaymentToProject))
        {
            // to ensure "attachmentDetails" is required (not null)
            if (attachmentDetails == null)
            {
                throw new ArgumentNullException("attachmentDetails is a required property for BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost and cannot be null");
            }
            this.AttachmentDetails = attachmentDetails;
        }

        /// <summary>
        /// Gets or Sets AttachmentDetails
        /// </summary>
        [DataMember(Name = "attachment_details", IsRequired = true, EmitDefaultValue = false)]
        public AttachPaymentToProject AttachmentDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost {\n");
            sb.Append("  AttachmentDetails: ").Append(AttachmentDetails).Append("\n");
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
            return this.Equals(input as BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost);
        }

        /// <summary>
        /// Returns true if BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AttachmentDetails == input.AttachmentDetails ||
                    (this.AttachmentDetails != null &&
                    this.AttachmentDetails.Equals(input.AttachmentDetails))
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
                if (this.AttachmentDetails != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentDetails.GetHashCode();
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
