/*
 * eHelply SDK - 1.1.68
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.68
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
    /// User object, contains all required parameters
    /// </summary>
    [DataContract(Name = "User")]
    public partial class User : IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="cognitoId">cognitoId.</param>
        /// <param name="cognitoData">cognitoData.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="email">email.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="country">country.</param>
        /// <param name="picture">picture.</param>
        /// <param name="gpsLocation">gpsLocation.</param>
        /// <param name="verifiedLegalTerms">verifiedLegalTerms (default to false).</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="dateUpdated">dateUpdated.</param>
        /// <param name="dateDeleted">dateDeleted.</param>
        /// <param name="uuid">uuid (required).</param>
        /// <param name="lastLogin">lastLogin.</param>
        /// <param name="firstLogin">firstLogin (default to true).</param>
        public User(string cognitoId = default(string), Object cognitoData = default(Object), string firstName = default(string), string lastName = default(string), string email = default(string), string phoneNumber = default(string), string country = default(string), string picture = default(string), Object gpsLocation = default(Object), bool verifiedLegalTerms = false, DateTime dateCreated = default(DateTime), DateTime dateUpdated = default(DateTime), DateTime dateDeleted = default(DateTime), string uuid = default(string), DateTime lastLogin = default(DateTime), bool firstLogin = true)
        {
            // to ensure "uuid" is required (not null)
            if (uuid == null) {
                throw new ArgumentNullException("uuid is a required property for User and cannot be null");
            }
            this.Uuid = uuid;
            this.CognitoId = cognitoId;
            this.CognitoData = cognitoData;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Country = country;
            this.Picture = picture;
            this.GpsLocation = gpsLocation;
            this.VerifiedLegalTerms = verifiedLegalTerms;
            this.DateCreated = dateCreated;
            this.DateUpdated = dateUpdated;
            this.DateDeleted = dateDeleted;
            this.LastLogin = lastLogin;
            this.FirstLogin = firstLogin;
        }

        /// <summary>
        /// Gets or Sets CognitoId
        /// </summary>
        [DataMember(Name = "cognito_id", EmitDefaultValue = false)]
        public string CognitoId { get; set; }

        /// <summary>
        /// Gets or Sets CognitoData
        /// </summary>
        [DataMember(Name = "cognito_data", EmitDefaultValue = false)]
        public Object CognitoData { get; set; }

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
        public string Email { get; set; }

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
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name = "uuid", IsRequired = true, EmitDefaultValue = false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name = "last_login", EmitDefaultValue = false)]
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// Gets or Sets FirstLogin
        /// </summary>
        [DataMember(Name = "first_login", EmitDefaultValue = true)]
        public bool FirstLogin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  CognitoId: ").Append(CognitoId).Append("\n");
            sb.Append("  CognitoData: ").Append(CognitoData).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  GpsLocation: ").Append(GpsLocation).Append("\n");
            sb.Append("  VerifiedLegalTerms: ").Append(VerifiedLegalTerms).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateUpdated: ").Append(DateUpdated).Append("\n");
            sb.Append("  DateDeleted: ").Append(DateDeleted).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  FirstLogin: ").Append(FirstLogin).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CognitoId == input.CognitoId ||
                    (this.CognitoId != null &&
                    this.CognitoId.Equals(input.CognitoId))
                ) && 
                (
                    this.CognitoData == input.CognitoData ||
                    (this.CognitoData != null &&
                    this.CognitoData.Equals(input.CognitoData))
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
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.LastLogin == input.LastLogin ||
                    (this.LastLogin != null &&
                    this.LastLogin.Equals(input.LastLogin))
                ) && 
                (
                    this.FirstLogin == input.FirstLogin ||
                    this.FirstLogin.Equals(input.FirstLogin)
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
                if (this.CognitoId != null)
                    hashCode = hashCode * 59 + this.CognitoId.GetHashCode();
                if (this.CognitoData != null)
                    hashCode = hashCode * 59 + this.CognitoData.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.LastLogin != null)
                    hashCode = hashCode * 59 + this.LastLogin.GetHashCode();
                hashCode = hashCode * 59 + this.FirstLogin.GetHashCode();
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
