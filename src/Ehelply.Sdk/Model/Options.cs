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
    /// Options
    /// </summary>
    [DataContract(Name = "Options")]
    public partial class Options : IEquatable<Options>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Options" /> class.
        /// </summary>
        /// <param name="required">required.</param>
        /// <param name="label">label.</param>
        /// <param name="insetLabel">insetLabel.</param>
        /// <param name="placeholder">placeholder.</param>
        /// <param name="hint">hint.</param>
        /// <param name="icon">icon.</param>
        /// <param name="maxLength">maxLength.</param>
        /// <param name="counter">counter.</param>
        /// <param name="caption">caption.</param>
        /// <param name="color">color.</param>
        /// <param name="size">size.</param>
        /// <param name="type">type.</param>
        /// <param name="iconPosition">iconPosition.</param>
        /// <param name="selections">selections.</param>
        public Options(bool required = default(bool), string label = default(string), string insetLabel = default(string), string placeholder = default(string), string hint = default(string), string icon = default(string), decimal maxLength = default(decimal), bool counter = default(bool), string caption = default(string), string color = default(string), string size = default(string), string type = default(string), string iconPosition = default(string), List<OptionGroup> selections = default(List<OptionGroup>))
        {
            this.Required = required;
            this.Label = label;
            this.InsetLabel = insetLabel;
            this.Placeholder = placeholder;
            this.Hint = hint;
            this.Icon = icon;
            this.MaxLength = maxLength;
            this.Counter = counter;
            this.Caption = caption;
            this.Color = color;
            this.Size = size;
            this.Type = type;
            this.IconPosition = iconPosition;
            this.Selections = selections;
        }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets InsetLabel
        /// </summary>
        [DataMember(Name = "insetLabel", EmitDefaultValue = false)]
        public string InsetLabel { get; set; }

        /// <summary>
        /// Gets or Sets Placeholder
        /// </summary>
        [DataMember(Name = "placeholder", EmitDefaultValue = false)]
        public string Placeholder { get; set; }

        /// <summary>
        /// Gets or Sets Hint
        /// </summary>
        [DataMember(Name = "hint", EmitDefaultValue = false)]
        public string Hint { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name = "maxLength", EmitDefaultValue = false)]
        public decimal MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets Counter
        /// </summary>
        [DataMember(Name = "counter", EmitDefaultValue = true)]
        public bool Counter { get; set; }

        /// <summary>
        /// Gets or Sets Caption
        /// </summary>
        [DataMember(Name = "caption", EmitDefaultValue = false)]
        public string Caption { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public string Size { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets IconPosition
        /// </summary>
        [DataMember(Name = "iconPosition", EmitDefaultValue = false)]
        public string IconPosition { get; set; }

        /// <summary>
        /// Gets or Sets Selections
        /// </summary>
        [DataMember(Name = "selections", EmitDefaultValue = false)]
        public List<OptionGroup> Selections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Options {\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  InsetLabel: ").Append(InsetLabel).Append("\n");
            sb.Append("  Placeholder: ").Append(Placeholder).Append("\n");
            sb.Append("  Hint: ").Append(Hint).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  Counter: ").Append(Counter).Append("\n");
            sb.Append("  Caption: ").Append(Caption).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IconPosition: ").Append(IconPosition).Append("\n");
            sb.Append("  Selections: ").Append(Selections).Append("\n");
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
            return this.Equals(input as Options);
        }

        /// <summary>
        /// Returns true if Options instances are equal
        /// </summary>
        /// <param name="input">Instance of Options to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Options input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.InsetLabel == input.InsetLabel ||
                    (this.InsetLabel != null &&
                    this.InsetLabel.Equals(input.InsetLabel))
                ) && 
                (
                    this.Placeholder == input.Placeholder ||
                    (this.Placeholder != null &&
                    this.Placeholder.Equals(input.Placeholder))
                ) && 
                (
                    this.Hint == input.Hint ||
                    (this.Hint != null &&
                    this.Hint.Equals(input.Hint))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    this.MaxLength.Equals(input.MaxLength)
                ) && 
                (
                    this.Counter == input.Counter ||
                    this.Counter.Equals(input.Counter)
                ) && 
                (
                    this.Caption == input.Caption ||
                    (this.Caption != null &&
                    this.Caption.Equals(input.Caption))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IconPosition == input.IconPosition ||
                    (this.IconPosition != null &&
                    this.IconPosition.Equals(input.IconPosition))
                ) && 
                (
                    this.Selections == input.Selections ||
                    this.Selections != null &&
                    input.Selections != null &&
                    this.Selections.SequenceEqual(input.Selections)
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
                hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.InsetLabel != null)
                    hashCode = hashCode * 59 + this.InsetLabel.GetHashCode();
                if (this.Placeholder != null)
                    hashCode = hashCode * 59 + this.Placeholder.GetHashCode();
                if (this.Hint != null)
                    hashCode = hashCode * 59 + this.Hint.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                hashCode = hashCode * 59 + this.Counter.GetHashCode();
                if (this.Caption != null)
                    hashCode = hashCode * 59 + this.Caption.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IconPosition != null)
                    hashCode = hashCode * 59 + this.IconPosition.GetHashCode();
                if (this.Selections != null)
                    hashCode = hashCode * 59 + this.Selections.GetHashCode();
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
