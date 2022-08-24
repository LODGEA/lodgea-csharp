/*
 * lodgea-csharp
 *
 * LODGEA SDK for CSharp. Check out https://lodgea.redoc.ly for more information.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@lodgea.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = lodgea-csharp.Client.OpenAPIDateConverter;

namespace lodgea-csharp.com.lodgea.model
{
    /// <summary>
    /// V1PropertyGetPost200ResponseProductListInnerPolicyInfoCancellationPolicyListInner
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponseProductListInnerPolicyInfoCancellationPolicyListInner :  IEquatable<V1PropertyGetPost200ResponseProductListInnerPolicyInfoCancellationPolicyListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponseProductListInnerPolicyInfoCancellationPolicyListInner" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="percentAfterReservation">percentAfterReservation.</param>
        /// <param name="nightsAfterReservation">nightsAfterReservation.</param>
        /// <param name="deadlineDays">deadlineDays.</param>
        /// <param name="deadlineHours">deadlineHours.</param>
        /// <param name="percentAfterDeadline">percentAfterDeadline.</param>
        /// <param name="nightsAfterDeadline">nightsAfterDeadline.</param>
        /// <param name="noShowPolicy">noShowPolicy.</param>
        public V1PropertyGetPost200ResponseProductListInnerPolicyInfoCancellationPolicyListInner(decimal code = default(decimal), decimal percentAfterReservation = default(decimal), decimal nightsAfterReservation = default(decimal), decimal deadlineDays = default(decimal), decimal deadlineHours = default(decimal), decimal percentAfterDeadline = default(decimal), decimal nightsAfterDeadline = default(decimal), string noShowPolicy = default(string))
        {
            this.Code = code;
            this.PercentAfterReservation = percentAfterReservation;
            this.NightsAfterReservation = nightsAfterReservation;
            this.DeadlineDays = deadlineDays;
            this.DeadlineHours = deadlineHours;
            this.PercentAfterDeadline = percentAfterDeadline;
            this.NightsAfterDeadline = nightsAfterDeadline;
            this.NoShowPolicy = noShowPolicy;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public decimal Code { get; set; }

        /// <summary>
        /// Gets or Sets PercentAfterReservation
        /// </summary>
        [DataMember(Name="percentAfterReservation", EmitDefaultValue=false)]
        public decimal PercentAfterReservation { get; set; }

        /// <summary>
        /// Gets or Sets NightsAfterReservation
        /// </summary>
        [DataMember(Name="nightsAfterReservation", EmitDefaultValue=false)]
        public decimal NightsAfterReservation { get; set; }

        /// <summary>
        /// Gets or Sets DeadlineDays
        /// </summary>
        [DataMember(Name="deadlineDays", EmitDefaultValue=false)]
        public decimal DeadlineDays { get; set; }

        /// <summary>
        /// Gets or Sets DeadlineHours
        /// </summary>
        [DataMember(Name="deadlineHours", EmitDefaultValue=false)]
        public decimal DeadlineHours { get; set; }

        /// <summary>
        /// Gets or Sets PercentAfterDeadline
        /// </summary>
        [DataMember(Name="percentAfterDeadline", EmitDefaultValue=false)]
        public decimal PercentAfterDeadline { get; set; }

        /// <summary>
        /// Gets or Sets NightsAfterDeadline
        /// </summary>
        [DataMember(Name="nightsAfterDeadline", EmitDefaultValue=false)]
        public decimal NightsAfterDeadline { get; set; }

        /// <summary>
        /// Gets or Sets NoShowPolicy
        /// </summary>
        [DataMember(Name="noShowPolicy", EmitDefaultValue=false)]
        public string NoShowPolicy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponseProductListInnerPolicyInfoCancellationPolicyListInner {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  PercentAfterReservation: ").Append(PercentAfterReservation).Append("\n");
            sb.Append("  NightsAfterReservation: ").Append(NightsAfterReservation).Append("\n");
            sb.Append("  DeadlineDays: ").Append(DeadlineDays).Append("\n");
            sb.Append("  DeadlineHours: ").Append(DeadlineHours).Append("\n");
            sb.Append("  PercentAfterDeadline: ").Append(PercentAfterDeadline).Append("\n");
            sb.Append("  NightsAfterDeadline: ").Append(NightsAfterDeadline).Append("\n");
            sb.Append("  NoShowPolicy: ").Append(NoShowPolicy).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponseProductListInnerPolicyInfoCancellationPolicyListInner);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponseProductListInnerPolicyInfoCancellationPolicyListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponseProductListInnerPolicyInfoCancellationPolicyListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponseProductListInnerPolicyInfoCancellationPolicyListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.PercentAfterReservation == input.PercentAfterReservation ||
                    (this.PercentAfterReservation != null &&
                    this.PercentAfterReservation.Equals(input.PercentAfterReservation))
                ) && 
                (
                    this.NightsAfterReservation == input.NightsAfterReservation ||
                    (this.NightsAfterReservation != null &&
                    this.NightsAfterReservation.Equals(input.NightsAfterReservation))
                ) && 
                (
                    this.DeadlineDays == input.DeadlineDays ||
                    (this.DeadlineDays != null &&
                    this.DeadlineDays.Equals(input.DeadlineDays))
                ) && 
                (
                    this.DeadlineHours == input.DeadlineHours ||
                    (this.DeadlineHours != null &&
                    this.DeadlineHours.Equals(input.DeadlineHours))
                ) && 
                (
                    this.PercentAfterDeadline == input.PercentAfterDeadline ||
                    (this.PercentAfterDeadline != null &&
                    this.PercentAfterDeadline.Equals(input.PercentAfterDeadline))
                ) && 
                (
                    this.NightsAfterDeadline == input.NightsAfterDeadline ||
                    (this.NightsAfterDeadline != null &&
                    this.NightsAfterDeadline.Equals(input.NightsAfterDeadline))
                ) && 
                (
                    this.NoShowPolicy == input.NoShowPolicy ||
                    (this.NoShowPolicy != null &&
                    this.NoShowPolicy.Equals(input.NoShowPolicy))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.PercentAfterReservation != null)
                    hashCode = hashCode * 59 + this.PercentAfterReservation.GetHashCode();
                if (this.NightsAfterReservation != null)
                    hashCode = hashCode * 59 + this.NightsAfterReservation.GetHashCode();
                if (this.DeadlineDays != null)
                    hashCode = hashCode * 59 + this.DeadlineDays.GetHashCode();
                if (this.DeadlineHours != null)
                    hashCode = hashCode * 59 + this.DeadlineHours.GetHashCode();
                if (this.PercentAfterDeadline != null)
                    hashCode = hashCode * 59 + this.PercentAfterDeadline.GetHashCode();
                if (this.NightsAfterDeadline != null)
                    hashCode = hashCode * 59 + this.NightsAfterDeadline.GetHashCode();
                if (this.NoShowPolicy != null)
                    hashCode = hashCode * 59 + this.NoShowPolicy.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
