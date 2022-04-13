/*
 * eHelply SDK - 1.1.61
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.61
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
    /// Fields for updating participants including the participant uuid
    /// </summary>
    [DataContract(Name = "ParticipantUpdate")]
    public partial class ParticipantUpdate : IEquatable<ParticipantUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParticipantUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantUpdate" /> class.
        /// </summary>
        /// <param name="meta">Dictionary containing any data you would like.</param>
        /// <param name="userUuid">userUuid.</param>
        /// <param name="uuid">uuid (required).</param>
        public ParticipantUpdate(Object meta = default(Object), string userUuid = default(string), string uuid = default(string))
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null) {
                throw new ArgumentNullException("uuid is a required property for ParticipantUpdate and cannot be null");
            }
            this.Uuid = uuid;
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
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParticipantUpdate {\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  UserUuid: ").Append(UserUuid).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(input as ParticipantUpdate);
        }

        /// <summary>
        /// Returns true if ParticipantUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ParticipantUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParticipantUpdate input)
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
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
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
