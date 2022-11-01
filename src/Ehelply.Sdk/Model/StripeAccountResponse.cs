/*
 * eHelply SDK - 1.1.121
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.121
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
    /// StripeAccountResponse
    /// </summary>
    [DataContract(Name = "StripeAccountResponse")]
    public partial class StripeAccountResponse : IEquatable<StripeAccountResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeAccountResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StripeAccountResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StripeAccountResponse" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="projectUuid">projectUuid (required).</param>
        /// <param name="stripeCustomerId">stripeCustomerId (required).</param>
        public StripeAccountResponse(string firstName = default(string), string lastName = default(string), string projectUuid = default(string), string stripeCustomerId = default(string))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for StripeAccountResponse and cannot be null");
            }
            this.FirstName = firstName;
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for StripeAccountResponse and cannot be null");
            }
            this.LastName = lastName;
            // to ensure "projectUuid" is required (not null)
            if (projectUuid == null)
            {
                throw new ArgumentNullException("projectUuid is a required property for StripeAccountResponse and cannot be null");
            }
            this.ProjectUuid = projectUuid;
            // to ensure "stripeCustomerId" is required (not null)
            if (stripeCustomerId == null)
            {
                throw new ArgumentNullException("stripeCustomerId is a required property for StripeAccountResponse and cannot be null");
            }
            this.StripeCustomerId = stripeCustomerId;
        }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "first_name", IsRequired = true, EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "last_name", IsRequired = true, EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets ProjectUuid
        /// </summary>
        [DataMember(Name = "project_uuid", IsRequired = true, EmitDefaultValue = false)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// Gets or Sets StripeCustomerId
        /// </summary>
        [DataMember(Name = "stripe_customer_id", IsRequired = true, EmitDefaultValue = false)]
        public string StripeCustomerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StripeAccountResponse {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ProjectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  StripeCustomerId: ").Append(StripeCustomerId).Append("\n");
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
            return this.Equals(input as StripeAccountResponse);
        }

        /// <summary>
        /// Returns true if StripeAccountResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StripeAccountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StripeAccountResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.ProjectUuid == input.ProjectUuid ||
                    (this.ProjectUuid != null &&
                    this.ProjectUuid.Equals(input.ProjectUuid))
                ) && 
                (
                    this.StripeCustomerId == input.StripeCustomerId ||
                    (this.StripeCustomerId != null &&
                    this.StripeCustomerId.Equals(input.StripeCustomerId))
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
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.ProjectUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectUuid.GetHashCode();
                }
                if (this.StripeCustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.StripeCustomerId.GetHashCode();
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
