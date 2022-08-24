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
    /// V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner :  IEquatable<V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner" /> class.
        /// </summary>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="occupancy">occupancy.</param>
        /// <param name="priceList">priceList.</param>
        /// <param name="currencyCode">currencyCode.</param>
        public V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner(decimal dateTime = default(decimal), decimal occupancy = default(decimal), V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInnerPriceList priceList = default(V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInnerPriceList), string currencyCode = default(string))
        {
            this.DateTime = dateTime;
            this.Occupancy = occupancy;
            this.PriceList = priceList;
            this.CurrencyCode = currencyCode;
        }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public decimal DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Occupancy
        /// </summary>
        [DataMember(Name="occupancy", EmitDefaultValue=false)]
        public decimal Occupancy { get; set; }

        /// <summary>
        /// Gets or Sets PriceList
        /// </summary>
        [DataMember(Name="priceList", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInnerPriceList PriceList { get; set; }

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
            sb.Append("class V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Occupancy: ").Append(Occupancy).Append("\n");
            sb.Append("  PriceList: ").Append(PriceList).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.Occupancy == input.Occupancy ||
                    (this.Occupancy != null &&
                    this.Occupancy.Equals(input.Occupancy))
                ) && 
                (
                    this.PriceList == input.PriceList ||
                    (this.PriceList != null &&
                    this.PriceList.Equals(input.PriceList))
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
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                if (this.Occupancy != null)
                    hashCode = hashCode * 59 + this.Occupancy.GetHashCode();
                if (this.PriceList != null)
                    hashCode = hashCode * 59 + this.PriceList.GetHashCode();
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
