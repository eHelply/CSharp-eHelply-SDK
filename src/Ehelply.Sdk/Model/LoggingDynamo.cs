/*
 * eHelply SDK - 1.1.113
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.113
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
    /// LoggingDynamo
    /// </summary>
    [DataContract(Name = "LoggingDynamo")]
    public partial class LoggingDynamo : IEquatable<LoggingDynamo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingDynamo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoggingDynamo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingDynamo" /> class.
        /// </summary>
        /// <param name="service">service (required).</param>
        /// <param name="time">time (required).</param>
        /// <param name="log">log (required).</param>
        /// <param name="severity">severity (required).</param>
        /// <param name="subject">subject (required).</param>
        /// <param name="serviceName">serviceName (required).</param>
        public LoggingDynamo(string service = default(string), string time = default(string), Object log = default(Object), string severity = default(string), string subject = default(string), string serviceName = default(string))
        {
            // to ensure "service" is required (not null)
            if (service == null)
            {
                throw new ArgumentNullException("service is a required property for LoggingDynamo and cannot be null");
            }
            this.Service = service;
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new ArgumentNullException("time is a required property for LoggingDynamo and cannot be null");
            }
            this.Time = time;
            // to ensure "log" is required (not null)
            if (log == null)
            {
                throw new ArgumentNullException("log is a required property for LoggingDynamo and cannot be null");
            }
            this.Log = log;
            // to ensure "severity" is required (not null)
            if (severity == null)
            {
                throw new ArgumentNullException("severity is a required property for LoggingDynamo and cannot be null");
            }
            this.Severity = severity;
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new ArgumentNullException("subject is a required property for LoggingDynamo and cannot be null");
            }
            this.Subject = subject;
            // to ensure "serviceName" is required (not null)
            if (serviceName == null)
            {
                throw new ArgumentNullException("serviceName is a required property for LoggingDynamo and cannot be null");
            }
            this.ServiceName = serviceName;
        }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name = "service", IsRequired = true, EmitDefaultValue = false)]
        public string Service { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name = "time", IsRequired = true, EmitDefaultValue = false)]
        public string Time { get; set; }

        /// <summary>
        /// Gets or Sets Log
        /// </summary>
        [DataMember(Name = "log", IsRequired = true, EmitDefaultValue = false)]
        public Object Log { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name = "severity", IsRequired = true, EmitDefaultValue = false)]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", IsRequired = true, EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name = "service_name", IsRequired = true, EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoggingDynamo {\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Log: ").Append(Log).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
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
            return this.Equals(input as LoggingDynamo);
        }

        /// <summary>
        /// Returns true if LoggingDynamo instances are equal
        /// </summary>
        /// <param name="input">Instance of LoggingDynamo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoggingDynamo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Log == input.Log ||
                    (this.Log != null &&
                    this.Log.Equals(input.Log))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
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
                if (this.Service != null)
                {
                    hashCode = (hashCode * 59) + this.Service.GetHashCode();
                }
                if (this.Time != null)
                {
                    hashCode = (hashCode * 59) + this.Time.GetHashCode();
                }
                if (this.Log != null)
                {
                    hashCode = (hashCode * 59) + this.Log.GetHashCode();
                }
                if (this.Severity != null)
                {
                    hashCode = (hashCode * 59) + this.Severity.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
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
