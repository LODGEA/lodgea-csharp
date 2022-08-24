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
    /// V1PropertyGetPost200ResponsePropertyCancellationGracePeriod
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyCancellationGracePeriod :  IEquatable<V1PropertyGetPost200ResponsePropertyCancellationGracePeriod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyCancellationGracePeriod" /> class.
        /// </summary>
        /// <param name="hoursAfterBooking">hoursAfterBooking.</param>
        /// <param name="weeksBeforeCheckIn">weeksBeforeCheckIn.</param>
        public V1PropertyGetPost200ResponsePropertyCancellationGracePeriod(decimal hoursAfterBooking = default(decimal), decimal weeksBeforeCheckIn = default(decimal))
        {
            this.HoursAfterBooking = hoursAfterBooking;
            this.WeeksBeforeCheckIn = weeksBeforeCheckIn;
        }

        /// <summary>
        /// Gets or Sets HoursAfterBooking
        /// </summary>
        [DataMember(Name="hoursAfterBooking", EmitDefaultValue=false)]
        public decimal HoursAfterBooking { get; set; }

        /// <summary>
        /// Gets or Sets WeeksBeforeCheckIn
        /// </summary>
        [DataMember(Name="weeksBeforeCheckIn", EmitDefaultValue=false)]
        public decimal WeeksBeforeCheckIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyCancellationGracePeriod {\n");
            sb.Append("  HoursAfterBooking: ").Append(HoursAfterBooking).Append("\n");
            sb.Append("  WeeksBeforeCheckIn: ").Append(WeeksBeforeCheckIn).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyCancellationGracePeriod);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyCancellationGracePeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyCancellationGracePeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyCancellationGracePeriod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HoursAfterBooking == input.HoursAfterBooking ||
                    (this.HoursAfterBooking != null &&
                    this.HoursAfterBooking.Equals(input.HoursAfterBooking))
                ) && 
                (
                    this.WeeksBeforeCheckIn == input.WeeksBeforeCheckIn ||
                    (this.WeeksBeforeCheckIn != null &&
                    this.WeeksBeforeCheckIn.Equals(input.WeeksBeforeCheckIn))
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
                if (this.HoursAfterBooking != null)
                    hashCode = hashCode * 59 + this.HoursAfterBooking.GetHashCode();
                if (this.WeeksBeforeCheckIn != null)
                    hashCode = hashCode * 59 + this.WeeksBeforeCheckIn.GetHashCode();
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
