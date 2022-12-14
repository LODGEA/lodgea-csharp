/*
 * lodgea-csharp
 *
 * LODGEA SDK for CSharp. Check out https://docs.lodgea.io for more information.
 *
 * The version of the OpenAPI document: 1.0.2
 * Contact: support@lodgea.com
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
    /// AvailabilityGet
    /// </summary>
    [DataContract]
    public partial class AvailabilityGet :  IEquatable<AvailabilityGet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityGet" /> class.
        /// </summary>
        /// <param name="propertyCode">propertyCode.</param>
        /// <param name="currencyCode">currencyCode.</param>
        public AvailabilityGet(string propertyCode = default(string), string currencyCode = default(string))
        {
            this.PropertyCode = propertyCode;
            this.CurrencyCode = currencyCode;
        }

        /// <summary>
        /// Gets or Sets PropertyCode
        /// </summary>
        [DataMember(Name="propertyCode", EmitDefaultValue=false)]
        public string PropertyCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityGet {\n");
            sb.Append("  PropertyCode: ").Append(PropertyCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
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
            return this.Equals(input as AvailabilityGet);
        }

        /// <summary>
        /// Returns true if AvailabilityGet instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailabilityGet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityGet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PropertyCode == input.PropertyCode ||
                    (this.PropertyCode != null &&
                    this.PropertyCode.Equals(input.PropertyCode))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
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
                if (this.PropertyCode != null)
                    hashCode = hashCode * 59 + this.PropertyCode.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
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
