/*
 * eHelply SDK - 1.1.113
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.113
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
    /// Flags that may be attached to a user
    /// </summary>
    [DataContract(Name = "UserFlags")]
    public partial class UserFlags : IEquatable<UserFlags>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFlags" /> class.
        /// </summary>
        /// <param name="requiresTour">requiresTour (default to false).</param>
        /// <param name="missingData">missingData (default to false).</param>
        /// <param name="legalUpdates">legalUpdates (default to false).</param>
        /// <param name="newsletters">newsletters (default to false).</param>
        public UserFlags(bool requiresTour = false, bool missingData = false, bool legalUpdates = false, bool newsletters = false)
        {
            this.RequiresTour = requiresTour;
            this.MissingData = missingData;
            this.LegalUpdates = legalUpdates;
            this.Newsletters = newsletters;
        }

        /// <summary>
        /// Gets or Sets RequiresTour
        /// </summary>
        [DataMember(Name = "requires_tour", EmitDefaultValue = true)]
        public bool RequiresTour { get; set; }

        /// <summary>
        /// Gets or Sets MissingData
        /// </summary>
        [DataMember(Name = "missing_data", EmitDefaultValue = true)]
        public bool MissingData { get; set; }

        /// <summary>
        /// Gets or Sets LegalUpdates
        /// </summary>
        [DataMember(Name = "legal_updates", EmitDefaultValue = true)]
        public bool LegalUpdates { get; set; }

        /// <summary>
        /// Gets or Sets Newsletters
        /// </summary>
        [DataMember(Name = "newsletters", EmitDefaultValue = true)]
        public bool Newsletters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserFlags {\n");
            sb.Append("  RequiresTour: ").Append(RequiresTour).Append("\n");
            sb.Append("  MissingData: ").Append(MissingData).Append("\n");
            sb.Append("  LegalUpdates: ").Append(LegalUpdates).Append("\n");
            sb.Append("  Newsletters: ").Append(Newsletters).Append("\n");
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
            return this.Equals(input as UserFlags);
        }

        /// <summary>
        /// Returns true if UserFlags instances are equal
        /// </summary>
        /// <param name="input">Instance of UserFlags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserFlags input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RequiresTour == input.RequiresTour ||
                    this.RequiresTour.Equals(input.RequiresTour)
                ) && 
                (
                    this.MissingData == input.MissingData ||
                    this.MissingData.Equals(input.MissingData)
                ) && 
                (
                    this.LegalUpdates == input.LegalUpdates ||
                    this.LegalUpdates.Equals(input.LegalUpdates)
                ) && 
                (
                    this.Newsletters == input.Newsletters ||
                    this.Newsletters.Equals(input.Newsletters)
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
                hashCode = (hashCode * 59) + this.RequiresTour.GetHashCode();
                hashCode = (hashCode * 59) + this.MissingData.GetHashCode();
                hashCode = (hashCode * 59) + this.LegalUpdates.GetHashCode();
                hashCode = (hashCode * 59) + this.Newsletters.GetHashCode();
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
