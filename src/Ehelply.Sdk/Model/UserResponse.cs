/*
 * eHelply SDK - 1.1.70
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.70
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
    /// When retrieving a user
    /// </summary>
    [DataContract(Name = "UserResponse")]
    public partial class UserResponse : IEquatable<UserResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponse" /> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="country">country.</param>
        /// <param name="picture">picture.</param>
        /// <param name="gpsLocation">gpsLocation.</param>
        /// <param name="verifiedLegalTerms">verifiedLegalTerms (default to false).</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="dateUpdated">dateUpdated.</param>
        /// <param name="dateDeleted">dateDeleted.</param>
        /// <param name="email">email.</param>
        /// <param name="missing">missing.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="participants">participants.</param>
        /// <param name="flags">flags.</param>
        /// <param name="lastLogin">lastLogin.</param>
        public UserResponse(string firstName = default(string), string lastName = default(string), string phoneNumber = default(string), string country = default(string), string picture = default(string), Object gpsLocation = default(Object), bool verifiedLegalTerms = false, DateTime dateCreated = default(DateTime), DateTime dateUpdated = default(DateTime), DateTime dateDeleted = default(DateTime), UserEmail email = default(UserEmail), List<string> missing = default(List<string>), string uuid = default(string), List<Object> participants = default(List<Object>), UserFlags flags = default(UserFlags), string lastLogin = default(string))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Country = country;
            this.Picture = picture;
            this.GpsLocation = gpsLocation;
            this.VerifiedLegalTerms = verifiedLegalTerms;
            this.DateCreated = dateCreated;
            this.DateUpdated = dateUpdated;
            this.DateDeleted = dateDeleted;
            this.Email = email;
            this.Missing = missing;
            this.Uuid = uuid;
            this.Participants = participants;
            this.Flags = flags;
            this.LastLogin = lastLogin;
        }

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
        /// Gets or Sets Picture
        /// </summary>
        [DataMember(Name = "picture", EmitDefaultValue = false)]
        public string Picture { get; set; }

        /// <summary>
        /// Gets or Sets GpsLocation
        /// </summary>
        [DataMember(Name = "gps_location", EmitDefaultValue = false)]
        public Object GpsLocation { get; set; }

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
        /// Gets or Sets DateDeleted
        /// </summary>
        [DataMember(Name = "date_deleted", EmitDefaultValue = false)]
        public DateTime DateDeleted { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public UserEmail Email { get; set; }

        /// <summary>
        /// Gets or Sets Missing
        /// </summary>
        [DataMember(Name = "missing", EmitDefaultValue = false)]
        public List<string> Missing { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name = "participants", EmitDefaultValue = false)]
        public List<Object> Participants { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = false)]
        public UserFlags Flags { get; set; }

        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name = "last_login", EmitDefaultValue = false)]
        public string LastLogin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResponse {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  GpsLocation: ").Append(GpsLocation).Append("\n");
            sb.Append("  VerifiedLegalTerms: ").Append(VerifiedLegalTerms).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
            sb.Append("  DateDeleted: ").Append(DateDeleted).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Missing: ").Append(Missing).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
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
            return this.Equals(input as UserResponse);
        }

        /// <summary>
        /// Returns true if UserResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResponse input)
        {
            if (input == null)
                return false;

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
                    this.Picture == input.Picture ||
                    (this.Picture != null &&
                    this.Picture.Equals(input.Picture))
                ) && 
                (
                    this.GpsLocation == input.GpsLocation ||
                    (this.GpsLocation != null &&
                    this.GpsLocation.Equals(input.GpsLocation))
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
                ) && 
                (
                    this.DateDeleted == input.DateDeleted ||
                    (this.DateDeleted != null &&
                    this.DateDeleted.Equals(input.DateDeleted))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Missing == input.Missing ||
                    this.Missing != null &&
                    input.Missing != null &&
                    this.Missing.SequenceEqual(input.Missing)
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Participants == input.Participants ||
                    this.Participants != null &&
                    input.Participants != null &&
                    this.Participants.SequenceEqual(input.Participants)
                ) && 
                (
                    this.Flags == input.Flags ||
                    (this.Flags != null &&
                    this.Flags.Equals(input.Flags))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
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
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Picture != null)
                    hashCode = hashCode * 59 + this.Picture.GetHashCode();
                if (this.GpsLocation != null)
                    hashCode = hashCode * 59 + this.GpsLocation.GetHashCode();
                hashCode = hashCode * 59 + this.VerifiedLegalTerms.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.DateUpdated != null)
                    hashCode = hashCode * 59 + this.DateUpdated.GetHashCode();
                if (this.DateDeleted != null)
                    hashCode = hashCode * 59 + this.DateDeleted.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Missing != null)
                    hashCode = hashCode * 59 + this.Missing.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Participants != null)
                    hashCode = hashCode * 59 + this.Participants.GetHashCode();
                if (this.Flags != null)
                    hashCode = hashCode * 59 + this.Flags.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
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
