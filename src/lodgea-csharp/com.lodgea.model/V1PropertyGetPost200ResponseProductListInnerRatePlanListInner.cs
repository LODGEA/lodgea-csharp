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
    /// V1PropertyGetPost200ResponseProductListInnerRatePlanListInner
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponseProductListInnerRatePlanListInner :  IEquatable<V1PropertyGetPost200ResponseProductListInnerRatePlanListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponseProductListInnerRatePlanListInner" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="propertyId">propertyId.</param>
        /// <param name="pricingList">pricingList.</param>
        public V1PropertyGetPost200ResponseProductListInnerRatePlanListInner(bool active = default(bool), string name = default(string), string code = default(string), string propertyId = default(string), List<V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner> pricingList = default(List<V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner>))
        {
            this.Active = active;
            this.Name = name;
            this.Code = code;
            this.PropertyId = propertyId;
            this.PricingList = pricingList;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets PropertyId
        /// </summary>
        [DataMember(Name="propertyId", EmitDefaultValue=false)]
        public string PropertyId { get; set; }

        /// <summary>
        /// Gets or Sets PricingList
        /// </summary>
        [DataMember(Name="pricingList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponseProductListInnerRatePlanListInnerPricingListInner> PricingList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponseProductListInnerRatePlanListInner {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
            sb.Append("  PricingList: ").Append(PricingList).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponseProductListInnerRatePlanListInner);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponseProductListInnerRatePlanListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponseProductListInnerRatePlanListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponseProductListInnerRatePlanListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.PropertyId == input.PropertyId ||
                    (this.PropertyId != null &&
                    this.PropertyId.Equals(input.PropertyId))
                ) && 
                (
                    this.PricingList == input.PricingList ||
                    this.PricingList != null &&
                    input.PricingList != null &&
                    this.PricingList.SequenceEqual(input.PricingList)
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.PropertyId != null)
                    hashCode = hashCode * 59 + this.PropertyId.GetHashCode();
                if (this.PricingList != null)
                    hashCode = hashCode * 59 + this.PricingList.GetHashCode();
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
