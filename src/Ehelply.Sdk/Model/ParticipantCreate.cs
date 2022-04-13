/*
 * eHelply SDK - 1.1.46
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.46
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
    /// Contains field for when we create a participant only
    /// </summary>
    [DataContract(Name = "ParticipantCreate")]
    public partial class ParticipantCreate : IEquatable<ParticipantCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantCreate" /> class.
        /// </summary>
        /// <param name="meta">Dictionary containing any data you would like.</param>
        /// <param name="userUuid">userUuid.</param>
        public ParticipantCreate(Object meta = default(Object), string userUuid = default(string))
        {
            this.Meta = meta;
            this.UserUuid = userUuid;
        }

        /// <summary>
        /// Dictionary containing any data you would like
        /// </summary>
        /// <value>Dictionary containing any data you would like</value>
        [DataMember(Name = "meta", EmitDefaultValue = false)]
        public Object Meta { get; set; }

        /// <summary>
        /// Gets or Sets UserUuid
        /// </summary>
        [DataMember(Name = "user_uuid", EmitDefaultValue = false)]
        public string UserUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParticipantCreate {\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  UserUuid: ").Append(UserUuid).Append("\n");
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
            return this.Equals(input as ParticipantCreate);
        }

        /// <summary>
        /// Returns true if ParticipantCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ParticipantCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParticipantCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.UserUuid == input.UserUuid ||
                    (this.UserUuid != null &&
                    this.UserUuid.Equals(input.UserUuid))
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
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.UserUuid != null)
                    hashCode = hashCode * 59 + this.UserUuid.GetHashCode();
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
