/*
 * eHelply SDK - 1.1.78
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.78
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
    /// CreateReview
    /// </summary>
    [DataContract(Name = "CreateReview")]
    public partial class CreateReview : IEquatable<CreateReview>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateReview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateReview" /> class.
        /// </summary>
        /// <param name="rating">rating (required).</param>
        /// <param name="maxRating">maxRating (required).</param>
        /// <param name="reviewText">reviewText (required).</param>
        public CreateReview(int rating = default(int), int maxRating = default(int), string reviewText = default(string))
        {
            this.Rating = rating;
            this.MaxRating = maxRating;
            // to ensure "reviewText" is required (not null)
            if (reviewText == null)
            {
                throw new ArgumentNullException("reviewText is a required property for CreateReview and cannot be null");
            }
            this.ReviewText = reviewText;
        }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name = "rating", IsRequired = true, EmitDefaultValue = false)]
        public int Rating { get; set; }

        /// <summary>
        /// Gets or Sets MaxRating
        /// </summary>
        [DataMember(Name = "max_rating", IsRequired = true, EmitDefaultValue = false)]
        public int MaxRating { get; set; }

        /// <summary>
        /// Gets or Sets ReviewText
        /// </summary>
        [DataMember(Name = "review_text", IsRequired = true, EmitDefaultValue = false)]
        public string ReviewText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateReview {\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  MaxRating: ").Append(MaxRating).Append("\n");
            sb.Append("  ReviewText: ").Append(ReviewText).Append("\n");
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
            return this.Equals(input as CreateReview);
        }

        /// <summary>
        /// Returns true if CreateReview instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateReview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateReview input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rating == input.Rating ||
                    this.Rating.Equals(input.Rating)
                ) && 
                (
                    this.MaxRating == input.MaxRating ||
                    this.MaxRating.Equals(input.MaxRating)
                ) && 
                (
                    this.ReviewText == input.ReviewText ||
                    (this.ReviewText != null &&
                    this.ReviewText.Equals(input.ReviewText))
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
                hashCode = (hashCode * 59) + this.Rating.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxRating.GetHashCode();
                if (this.ReviewText != null)
                {
                    hashCode = (hashCode * 59) + this.ReviewText.GetHashCode();
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
