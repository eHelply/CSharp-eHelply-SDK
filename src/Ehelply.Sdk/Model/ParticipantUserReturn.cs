/*
 * eHelply SDK - 1.1.93
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.93
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
    /// Contains all fields required when doing a Participant GET but also has user fields (name, location, ect). This is what is returned from all participant endpoints.
    /// </summary>
    [DataContract(Name = "ParticipantUserReturn")]
    public partial class ParticipantUserReturn : IEquatable<ParticipantUserReturn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantUserReturn" /> class.
        /// </summary>
        /// <param name="uuid">uuid.</param>
        /// <param name="userUuid">userUuid.</param>
        /// <param name="participantMeta">participantMeta.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="email">email.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="country">country.</param>
        /// <param name="gpsLocation">gpsLocation.</param>
        /// <param name="picture">picture.</param>
        /// <param name="lastLogin">lastLogin.</param>
        /// <param name="verifiedLegalTerms">verifiedLegalTerms.</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="dateUpdated">dateUpdated.</param>
        public ParticipantUserReturn(string uuid = default(string), string userUuid = default(string), Object participantMeta = default(Object), string firstName = default(string), string lastName = default(string), Email email = default(Email), string phoneNumber = default(string), string country = default(string), Object gpsLocation = default(Object), string picture = default(string), DateTime lastLogin = default(DateTime), bool verifiedLegalTerms = default(bool), DateTime dateCreated = default(DateTime), DateTime dateUpdated = default(DateTime))
        {
            this.Uuid = uuid;
            this.UserUuid = userUuid;
            this.ParticipantMeta = participantMeta;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Country = country;
            this.GpsLocation = gpsLocation;
            this.Picture = picture;
            this.LastLogin = lastLogin;
            this.VerifiedLegalTerms = verifiedLegalTerms;
            this.DateCreated = dateCreated;
            this.DateUpdated = dateUpdated;
        }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets UserUuid
        /// </summary>
        [DataMember(Name = "user_uuid", EmitDefaultValue = false)]
        public string UserUuid { get; set; }

        /// <summary>
        /// Gets or Sets ParticipantMeta
        /// </summary>
        [DataMember(Name = "participant_meta", EmitDefaultValue = false)]
        public Object ParticipantMeta { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "first_name", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "last_name", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public Email Email { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phone_number", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets GpsLocation
        /// </summary>
        [DataMember(Name = "gps_location", EmitDefaultValue = false)]
        public Object GpsLocation { get; set; }

        /// <summary>
        /// Gets or Sets Picture
        /// </summary>
        [DataMember(Name = "picture", EmitDefaultValue = false)]
        public string Picture { get; set; }

        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name = "last_login", EmitDefaultValue = false)]
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedLegalTerms
        /// </summary>
        [DataMember(Name = "verified_legal_terms", EmitDefaultValue = true)]
        public bool VerifiedLegalTerms { get; set; }

        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name = "date_created", EmitDefaultValue = false)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets DateUpdated
        /// </summary>
        [DataMember(Name = "date_updated", EmitDefaultValue = false)]
        public DateTime DateUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParticipantUserReturn {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  UserUuid: ").Append(UserUuid).Append("\n");
            sb.Append("  ParticipantMeta: ").Append(ParticipantMeta).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  GpsLocation: ").Append(GpsLocation).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  VerifiedLegalTerms: ").Append(VerifiedLegalTerms).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
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
            return this.Equals(input as ParticipantUserReturn);
        }

        /// <summary>
        /// Returns true if ParticipantUserReturn instances are equal
        /// </summary>
        /// <param name="input">Instance of ParticipantUserReturn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParticipantUserReturn input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.UserUuid == input.UserUuid ||
                    (this.UserUuid != null &&
                    this.UserUuid.Equals(input.UserUuid))
                ) && 
                (
                    this.ParticipantMeta == input.ParticipantMeta ||
                    (this.ParticipantMeta != null &&
                    this.ParticipantMeta.Equals(input.ParticipantMeta))
                ) && 
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.GpsLocation == input.GpsLocation ||
                    (this.GpsLocation != null &&
                    this.GpsLocation.Equals(input.GpsLocation))
                ) && 
                (
                    this.Picture == input.Picture ||
                    (this.Picture != null &&
                    this.Picture.Equals(input.Picture))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.VerifiedLegalTerms == input.VerifiedLegalTerms ||
                    this.VerifiedLegalTerms.Equals(input.VerifiedLegalTerms)
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.DateUpdated == input.DateUpdated ||
                    (this.DateUpdated != null &&
                    this.DateUpdated.Equals(input.DateUpdated))
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
                if (this.Uuid != null)
                {
                    hashCode = (hashCode * 59) + this.Uuid.GetHashCode();
                }
                if (this.UserUuid != null)
                {
                    hashCode = (hashCode * 59) + this.UserUuid.GetHashCode();
                }
                if (this.ParticipantMeta != null)
                {
                    hashCode = (hashCode * 59) + this.ParticipantMeta.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.GpsLocation != null)
                {
                    hashCode = (hashCode * 59) + this.GpsLocation.GetHashCode();
                }
                if (this.Picture != null)
                {
                    hashCode = (hashCode * 59) + this.Picture.GetHashCode();
                }
                if (this.LastLogin != null)
                {
                    hashCode = (hashCode * 59) + this.LastLogin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VerifiedLegalTerms.GetHashCode();
                if (this.DateCreated != null)
                {
                    hashCode = (hashCode * 59) + this.DateCreated.GetHashCode();
                }
                if (this.DateUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.DateUpdated.GetHashCode();
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
