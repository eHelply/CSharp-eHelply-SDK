/*
 * eHelply SDK - 1.1.52
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.52
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
    /// BodyUpdateMetaFromUuidMetaMetaMetaUuidPut
    /// </summary>
    [DataContract(Name = "Body_update_meta_from_uuid_meta_meta__meta_uuid__put")]
    public partial class BodyUpdateMetaFromUuidMetaMetaMetaUuidPut : IEquatable<BodyUpdateMetaFromUuidMetaMetaMetaUuidPut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateMetaFromUuidMetaMetaMetaUuidPut" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BodyUpdateMetaFromUuidMetaMetaMetaUuidPut() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateMetaFromUuidMetaMetaMetaUuidPut" /> class.
        /// </summary>
        /// <param name="meta">meta (required).</param>
        public BodyUpdateMetaFromUuidMetaMetaMetaUuidPut(MetaCreate meta = default(MetaCreate))
        {
            // to ensure "meta" is required (not null)
            if (meta == null) {
                throw new ArgumentNullException("meta is a required property for BodyUpdateMetaFromUuidMetaMetaMetaUuidPut and cannot be null");
            }
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", IsRequired = true, EmitDefaultValue = false)]
        public MetaCreate Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BodyUpdateMetaFromUuidMetaMetaMetaUuidPut {\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as BodyUpdateMetaFromUuidMetaMetaMetaUuidPut);
        }

        /// <summary>
        /// Returns true if BodyUpdateMetaFromUuidMetaMetaMetaUuidPut instances are equal
        /// </summary>
        /// <param name="input">Instance of BodyUpdateMetaFromUuidMetaMetaMetaUuidPut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BodyUpdateMetaFromUuidMetaMetaMetaUuidPut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
