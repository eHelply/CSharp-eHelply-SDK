/*
 * eHelply SDK - 1.1.71
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.71
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
    /// Tokens, naming scheme based off of cognito return fields
    /// </summary>
    [DataContract(Name = "UserTokenReturn")]
    public partial class UserTokenReturn : IEquatable<UserTokenReturn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTokenReturn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserTokenReturn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTokenReturn" /> class.
        /// </summary>
        /// <param name="accessToken">accessToken (required).</param>
        /// <param name="expiresIn">expiresIn (required).</param>
        /// <param name="tokenType">tokenType (required).</param>
        /// <param name="idToken">idToken (required).</param>
        public UserTokenReturn(string accessToken = default(string), int expiresIn = default(int), string tokenType = default(string), string idToken = default(string))
        {
            // to ensure "accessToken" is required (not null)
            if (accessToken == null)
            {
                throw new ArgumentNullException("accessToken is a required property for UserTokenReturn and cannot be null");
            }
            this.AccessToken = accessToken;
            this.ExpiresIn = expiresIn;
            // to ensure "tokenType" is required (not null)
            if (tokenType == null)
            {
                throw new ArgumentNullException("tokenType is a required property for UserTokenReturn and cannot be null");
            }
            this.TokenType = tokenType;
            // to ensure "idToken" is required (not null)
            if (idToken == null)
            {
                throw new ArgumentNullException("idToken is a required property for UserTokenReturn and cannot be null");
            }
            this.IdToken = idToken;
        }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name = "AccessToken", IsRequired = true, EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name = "ExpiresIn", IsRequired = true, EmitDefaultValue = false)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or Sets TokenType
        /// </summary>
        [DataMember(Name = "TokenType", IsRequired = true, EmitDefaultValue = false)]
        public string TokenType { get; set; }

        /// <summary>
        /// Gets or Sets IdToken
        /// </summary>
        [DataMember(Name = "IdToken", IsRequired = true, EmitDefaultValue = false)]
        public string IdToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserTokenReturn {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
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
            return this.Equals(input as UserTokenReturn);
        }

        /// <summary>
        /// Returns true if UserTokenReturn instances are equal
        /// </summary>
        /// <param name="input">Instance of UserTokenReturn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserTokenReturn input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    this.ExpiresIn.Equals(input.ExpiresIn)
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.IdToken == input.IdToken ||
                    (this.IdToken != null &&
                    this.IdToken.Equals(input.IdToken))
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
                if (this.AccessToken != null)
                {
                    hashCode = (hashCode * 59) + this.AccessToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresIn.GetHashCode();
                if (this.TokenType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenType.GetHashCode();
                }
                if (this.IdToken != null)
                {
                    hashCode = (hashCode * 59) + this.IdToken.GetHashCode();
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
