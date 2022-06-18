/*
 * eHelply SDK - 1.1.91
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.91
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
    /// Meta
    /// </summary>
    [DataContract(Name = "MetaCreate")]
    public partial class MetaCreate : IEquatable<MetaCreate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetaCreate" /> class.
        /// </summary>
        /// <param name="basic">basic.</param>
        /// <param name="detailed">detailed.</param>
        /// <param name="custom">custom.</param>
        /// <param name="fields">fields.</param>
        /// <param name="children">children.</param>
        /// <param name="parentUuid">parentUuid.</param>
        public MetaCreate(BasicMetaCreate basic = default(BasicMetaCreate), DetailedMetaCreate detailed = default(DetailedMetaCreate), MetaCustom custom = default(MetaCustom), List<Field> fields = default(List<Field>), List<MetaChildren> children = default(List<MetaChildren>), string parentUuid = default(string))
        {
            this.Basic = basic;
            this.Detailed = detailed;
            this.Custom = custom;
            this.Fields = fields;
            this.Children = children;
            this.ParentUuid = parentUuid;
        }

        /// <summary>
        /// Gets or Sets Basic
        /// </summary>
        [DataMember(Name = "basic", EmitDefaultValue = false)]
        public BasicMetaCreate Basic { get; set; }

        /// <summary>
        /// Gets or Sets Detailed
        /// </summary>
        [DataMember(Name = "detailed", EmitDefaultValue = false)]
        public DetailedMetaCreate Detailed { get; set; }

        /// <summary>
        /// Gets or Sets Custom
        /// </summary>
        [DataMember(Name = "custom", EmitDefaultValue = false)]
        public MetaCustom Custom { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<Field> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = false)]
        public List<MetaChildren> Children { get; set; }

        /// <summary>
        /// Gets or Sets ParentUuid
        /// </summary>
        [DataMember(Name = "parent_uuid", EmitDefaultValue = false)]
        public string ParentUuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetaCreate {\n");
            sb.Append("  Basic: ").Append(Basic).Append("\n");
            sb.Append("  Detailed: ").Append(Detailed).Append("\n");
            sb.Append("  Custom: ").Append(Custom).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  ParentUuid: ").Append(ParentUuid).Append("\n");
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
            return this.Equals(input as MetaCreate);
        }

        /// <summary>
        /// Returns true if MetaCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of MetaCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetaCreate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Basic == input.Basic ||
                    (this.Basic != null &&
                    this.Basic.Equals(input.Basic))
                ) && 
                (
                    this.Detailed == input.Detailed ||
                    (this.Detailed != null &&
                    this.Detailed.Equals(input.Detailed))
                ) && 
                (
                    this.Custom == input.Custom ||
                    (this.Custom != null &&
                    this.Custom.Equals(input.Custom))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.ParentUuid == input.ParentUuid ||
                    (this.ParentUuid != null &&
                    this.ParentUuid.Equals(input.ParentUuid))
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
                if (this.Basic != null)
                {
                    hashCode = (hashCode * 59) + this.Basic.GetHashCode();
                }
                if (this.Detailed != null)
                {
                    hashCode = (hashCode * 59) + this.Detailed.GetHashCode();
                }
                if (this.Custom != null)
                {
                    hashCode = (hashCode * 59) + this.Custom.GetHashCode();
                }
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                if (this.Children != null)
                {
                    hashCode = (hashCode * 59) + this.Children.GetHashCode();
                }
                if (this.ParentUuid != null)
                {
                    hashCode = (hashCode * 59) + this.ParentUuid.GetHashCode();
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
