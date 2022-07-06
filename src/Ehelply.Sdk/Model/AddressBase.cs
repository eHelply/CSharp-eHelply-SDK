/*
 * eHelply SDK - 1.1.95
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.95
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
    /// **:param** address_type                        **type:** string or None  **:param** address_line_1                      **type:** string or None  **:param** address_line_2                      **type:** string or None  **:param** postal_zip_code                     **type:** string or None  **:param** city                                **type:** string or None  **:param** province_state                      **type:** string or None  **:param** country                             **type:** string or None  **:param** lat                                 **type:** string or None  **:param** lng                                 **type:** string or None
    /// </summary>
    [DataContract(Name = "AddressBase")]
    public partial class AddressBase : IEquatable<AddressBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBase" /> class.
        /// </summary>
        /// <param name="addressType">addressType.</param>
        /// <param name="addressLine1">addressLine1.</param>
        /// <param name="addressLine2">addressLine2.</param>
        /// <param name="postalZipCode">postalZipCode.</param>
        /// <param name="city">city.</param>
        /// <param name="provinceState">provinceState.</param>
        /// <param name="country">country.</param>
        /// <param name="lat">lat.</param>
        /// <param name="lng">lng.</param>
        public AddressBase(string addressType = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string postalZipCode = default(string), string city = default(string), string provinceState = default(string), string country = default(string), string lat = default(string), string lng = default(string))
        {
            this.AddressType = addressType;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.PostalZipCode = postalZipCode;
            this.City = city;
            this.ProvinceState = provinceState;
            this.Country = country;
            this.Lat = lat;
            this.Lng = lng;
        }

        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name = "address_type", EmitDefaultValue = false)]
        public string AddressType { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        [DataMember(Name = "address_line_1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name = "address_line_2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets PostalZipCode
        /// </summary>
        [DataMember(Name = "postal_zip_code", EmitDefaultValue = false)]
        public string PostalZipCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets ProvinceState
        /// </summary>
        [DataMember(Name = "province_state", EmitDefaultValue = false)]
        public string ProvinceState { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Lat
        /// </summary>
        [DataMember(Name = "lat", EmitDefaultValue = false)]
        public string Lat { get; set; }

        /// <summary>
        /// Gets or Sets Lng
        /// </summary>
        [DataMember(Name = "lng", EmitDefaultValue = false)]
        public string Lng { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressBase {\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  PostalZipCode: ").Append(PostalZipCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  ProvinceState: ").Append(ProvinceState).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
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
            return this.Equals(input as AddressBase);
        }

        /// <summary>
        /// Returns true if AddressBase instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressBase input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.PostalZipCode == input.PostalZipCode ||
                    (this.PostalZipCode != null &&
                    this.PostalZipCode.Equals(input.PostalZipCode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.ProvinceState == input.ProvinceState ||
                    (this.ProvinceState != null &&
                    this.ProvinceState.Equals(input.ProvinceState))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
                ) && 
                (
                    this.Lng == input.Lng ||
                    (this.Lng != null &&
                    this.Lng.Equals(input.Lng))
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
                if (this.AddressType != null)
                {
                    hashCode = (hashCode * 59) + this.AddressType.GetHashCode();
                }
                if (this.AddressLine1 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLine1.GetHashCode();
                }
                if (this.AddressLine2 != null)
                {
                    hashCode = (hashCode * 59) + this.AddressLine2.GetHashCode();
                }
                if (this.PostalZipCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalZipCode.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.ProvinceState != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceState.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Lat != null)
                {
                    hashCode = (hashCode * 59) + this.Lat.GetHashCode();
                }
                if (this.Lng != null)
                {
                    hashCode = (hashCode * 59) + this.Lng.GetHashCode();
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
