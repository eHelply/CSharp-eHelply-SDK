/*
 * eHelply SDK - 1.1.116
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.116
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
    /// ServiceSuperStackMeta
    /// </summary>
    [DataContract(Name = "ServiceSuperStackMeta")]
    public partial class ServiceSuperStackMeta : IEquatable<ServiceSuperStackMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceSuperStackMeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceSuperStackMeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceSuperStackMeta" /> class.
        /// </summary>
        /// <param name="humanName">humanName (required).</param>
        /// <param name="routeName">routeName (required).</param>
        /// <param name="serviceName">serviceName (required).</param>
        /// <param name="advertise">advertise (required).</param>
        /// <param name="featured">featured (required).</param>
        /// <param name="picture">picture (required).</param>
        /// <param name="backgroundPicture">backgroundPicture (required).</param>
        /// <param name="tagLine">tagLine (required).</param>
        /// <param name="summary">summary (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="features">features (required).</param>
        /// <param name="useCases">useCases (required).</param>
        /// <param name="gettingStarted">gettingStarted (required).</param>
        /// <param name="faqs">faqs (required).</param>
        public ServiceSuperStackMeta(string humanName = default(string), string routeName = default(string), string serviceName = default(string), bool advertise = default(bool), bool featured = default(bool), string picture = default(string), string backgroundPicture = default(string), string tagLine = default(string), string summary = default(string), string description = default(string), List<ServiceSuperStackMetaFeature> features = default(List<ServiceSuperStackMetaFeature>), List<ServiceSuperStackMetaUseCase> useCases = default(List<ServiceSuperStackMetaUseCase>), ServiceSuperStackMetaGettingStarted gettingStarted = default(ServiceSuperStackMetaGettingStarted), List<ServiceSuperStackMetaFaq> faqs = default(List<ServiceSuperStackMetaFaq>))
        {
            // to ensure "humanName" is required (not null)
            if (humanName == null)
            {
                throw new ArgumentNullException("humanName is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.HumanName = humanName;
            // to ensure "routeName" is required (not null)
            if (routeName == null)
            {
                throw new ArgumentNullException("routeName is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.RouteName = routeName;
            // to ensure "serviceName" is required (not null)
            if (serviceName == null)
            {
                throw new ArgumentNullException("serviceName is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.ServiceName = serviceName;
            this.Advertise = advertise;
            this.Featured = featured;
            // to ensure "picture" is required (not null)
            if (picture == null)
            {
                throw new ArgumentNullException("picture is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.Picture = picture;
            // to ensure "backgroundPicture" is required (not null)
            if (backgroundPicture == null)
            {
                throw new ArgumentNullException("backgroundPicture is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.BackgroundPicture = backgroundPicture;
            // to ensure "tagLine" is required (not null)
            if (tagLine == null)
            {
                throw new ArgumentNullException("tagLine is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.TagLine = tagLine;
            // to ensure "summary" is required (not null)
            if (summary == null)
            {
                throw new ArgumentNullException("summary is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.Summary = summary;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.Description = description;
            // to ensure "features" is required (not null)
            if (features == null)
            {
                throw new ArgumentNullException("features is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.Features = features;
            // to ensure "useCases" is required (not null)
            if (useCases == null)
            {
                throw new ArgumentNullException("useCases is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.UseCases = useCases;
            // to ensure "gettingStarted" is required (not null)
            if (gettingStarted == null)
            {
                throw new ArgumentNullException("gettingStarted is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.GettingStarted = gettingStarted;
            // to ensure "faqs" is required (not null)
            if (faqs == null)
            {
                throw new ArgumentNullException("faqs is a required property for ServiceSuperStackMeta and cannot be null");
            }
            this.Faqs = faqs;
        }

        /// <summary>
        /// Gets or Sets HumanName
        /// </summary>
        [DataMember(Name = "human_name", IsRequired = true, EmitDefaultValue = false)]
        public string HumanName { get; set; }

        /// <summary>
        /// Gets or Sets RouteName
        /// </summary>
        [DataMember(Name = "route_name", IsRequired = true, EmitDefaultValue = false)]
        public string RouteName { get; set; }

        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name = "service_name", IsRequired = true, EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or Sets Advertise
        /// </summary>
        [DataMember(Name = "advertise", IsRequired = true, EmitDefaultValue = true)]
        public bool Advertise { get; set; }

        /// <summary>
        /// Gets or Sets Featured
        /// </summary>
        [DataMember(Name = "featured", IsRequired = true, EmitDefaultValue = true)]
        public bool Featured { get; set; }

        /// <summary>
        /// Gets or Sets Picture
        /// </summary>
        [DataMember(Name = "picture", IsRequired = true, EmitDefaultValue = false)]
        public string Picture { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundPicture
        /// </summary>
        [DataMember(Name = "background_picture", IsRequired = true, EmitDefaultValue = false)]
        public string BackgroundPicture { get; set; }

        /// <summary>
        /// Gets or Sets TagLine
        /// </summary>
        [DataMember(Name = "tag_line", IsRequired = true, EmitDefaultValue = false)]
        public string TagLine { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", IsRequired = true, EmitDefaultValue = false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name = "features", IsRequired = true, EmitDefaultValue = false)]
        public List<ServiceSuperStackMetaFeature> Features { get; set; }

        /// <summary>
        /// Gets or Sets UseCases
        /// </summary>
        [DataMember(Name = "use_cases", IsRequired = true, EmitDefaultValue = false)]
        public List<ServiceSuperStackMetaUseCase> UseCases { get; set; }

        /// <summary>
        /// Gets or Sets GettingStarted
        /// </summary>
        [DataMember(Name = "getting_started", IsRequired = true, EmitDefaultValue = false)]
        public ServiceSuperStackMetaGettingStarted GettingStarted { get; set; }

        /// <summary>
        /// Gets or Sets Faqs
        /// </summary>
        [DataMember(Name = "faqs", IsRequired = true, EmitDefaultValue = false)]
        public List<ServiceSuperStackMetaFaq> Faqs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceSuperStackMeta {\n");
            sb.Append("  HumanName: ").Append(HumanName).Append("\n");
            sb.Append("  RouteName: ").Append(RouteName).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Advertise: ").Append(Advertise).Append("\n");
            sb.Append("  Featured: ").Append(Featured).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  BackgroundPicture: ").Append(BackgroundPicture).Append("\n");
            sb.Append("  TagLine: ").Append(TagLine).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  UseCases: ").Append(UseCases).Append("\n");
            sb.Append("  GettingStarted: ").Append(GettingStarted).Append("\n");
            sb.Append("  Faqs: ").Append(Faqs).Append("\n");
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
            return this.Equals(input as ServiceSuperStackMeta);
        }

        /// <summary>
        /// Returns true if ServiceSuperStackMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceSuperStackMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceSuperStackMeta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HumanName == input.HumanName ||
                    (this.HumanName != null &&
                    this.HumanName.Equals(input.HumanName))
                ) && 
                (
                    this.RouteName == input.RouteName ||
                    (this.RouteName != null &&
                    this.RouteName.Equals(input.RouteName))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.Advertise == input.Advertise ||
                    this.Advertise.Equals(input.Advertise)
                ) && 
                (
                    this.Featured == input.Featured ||
                    this.Featured.Equals(input.Featured)
                ) && 
                (
                    this.Picture == input.Picture ||
                    (this.Picture != null &&
                    this.Picture.Equals(input.Picture))
                ) && 
                (
                    this.BackgroundPicture == input.BackgroundPicture ||
                    (this.BackgroundPicture != null &&
                    this.BackgroundPicture.Equals(input.BackgroundPicture))
                ) && 
                (
                    this.TagLine == input.TagLine ||
                    (this.TagLine != null &&
                    this.TagLine.Equals(input.TagLine))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.UseCases == input.UseCases ||
                    this.UseCases != null &&
                    input.UseCases != null &&
                    this.UseCases.SequenceEqual(input.UseCases)
                ) && 
                (
                    this.GettingStarted == input.GettingStarted ||
                    (this.GettingStarted != null &&
                    this.GettingStarted.Equals(input.GettingStarted))
                ) && 
                (
                    this.Faqs == input.Faqs ||
                    this.Faqs != null &&
                    input.Faqs != null &&
                    this.Faqs.SequenceEqual(input.Faqs)
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
                if (this.HumanName != null)
                {
                    hashCode = (hashCode * 59) + this.HumanName.GetHashCode();
                }
                if (this.RouteName != null)
                {
                    hashCode = (hashCode * 59) + this.RouteName.GetHashCode();
                }
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Advertise.GetHashCode();
                hashCode = (hashCode * 59) + this.Featured.GetHashCode();
                if (this.Picture != null)
                {
                    hashCode = (hashCode * 59) + this.Picture.GetHashCode();
                }
                if (this.BackgroundPicture != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundPicture.GetHashCode();
                }
                if (this.TagLine != null)
                {
                    hashCode = (hashCode * 59) + this.TagLine.GetHashCode();
                }
                if (this.Summary != null)
                {
                    hashCode = (hashCode * 59) + this.Summary.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Features != null)
                {
                    hashCode = (hashCode * 59) + this.Features.GetHashCode();
                }
                if (this.UseCases != null)
                {
                    hashCode = (hashCode * 59) + this.UseCases.GetHashCode();
                }
                if (this.GettingStarted != null)
                {
                    hashCode = (hashCode * 59) + this.GettingStarted.GetHashCode();
                }
                if (this.Faqs != null)
                {
                    hashCode = (hashCode * 59) + this.Faqs.GetHashCode();
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
