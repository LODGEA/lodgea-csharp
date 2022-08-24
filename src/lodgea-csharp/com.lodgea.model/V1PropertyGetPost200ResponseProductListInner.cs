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
    /// V1PropertyGetPost200ResponseProductListInner
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponseProductListInner :  IEquatable<V1PropertyGetPost200ResponseProductListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponseProductListInner" /> class.
        /// </summary>
        /// <param name="propertyId">propertyId.</param>
        /// <param name="name">name.</param>
        /// <param name="mealPlanList">mealPlanList.</param>
        /// <param name="roomTypeList">roomTypeList.</param>
        /// <param name="isLOSPricing">isLOSPricing.</param>
        /// <param name="isOBPPricing">isOBPPricing.</param>
        /// <param name="ratePlanList">ratePlanList.</param>
        /// <param name="policyInfo">policyInfo.</param>
        public V1PropertyGetPost200ResponseProductListInner(string propertyId = default(string), string name = default(string), List<V1PropertyGetPost200ResponseProductListInnerMealPlanListInner> mealPlanList = default(List<V1PropertyGetPost200ResponseProductListInnerMealPlanListInner>), List<V1PropertyGetPost200ResponseProductListInnerRoomTypeListInner> roomTypeList = default(List<V1PropertyGetPost200ResponseProductListInnerRoomTypeListInner>), bool isLOSPricing = default(bool), bool isOBPPricing = default(bool), List<V1PropertyGetPost200ResponseProductListInnerRatePlanListInner> ratePlanList = default(List<V1PropertyGetPost200ResponseProductListInnerRatePlanListInner>), V1PropertyGetPost200ResponseProductListInnerPolicyInfo policyInfo = default(V1PropertyGetPost200ResponseProductListInnerPolicyInfo))
        {
            this.PropertyId = propertyId;
            this.Name = name;
            this.MealPlanList = mealPlanList;
            this.RoomTypeList = roomTypeList;
            this.IsLOSPricing = isLOSPricing;
            this.IsOBPPricing = isOBPPricing;
            this.RatePlanList = ratePlanList;
            this.PolicyInfo = policyInfo;
        }

        /// <summary>
        /// Gets or Sets PropertyId
        /// </summary>
        [DataMember(Name="propertyId", EmitDefaultValue=false)]
        public string PropertyId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets MealPlanList
        /// </summary>
        [DataMember(Name="mealPlanList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponseProductListInnerMealPlanListInner> MealPlanList { get; set; }

        /// <summary>
        /// Gets or Sets RoomTypeList
        /// </summary>
        [DataMember(Name="roomTypeList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponseProductListInnerRoomTypeListInner> RoomTypeList { get; set; }

        /// <summary>
        /// Gets or Sets IsLOSPricing
        /// </summary>
        [DataMember(Name="isLOSPricing", EmitDefaultValue=false)]
        public bool IsLOSPricing { get; set; }

        /// <summary>
        /// Gets or Sets IsOBPPricing
        /// </summary>
        [DataMember(Name="isOBPPricing", EmitDefaultValue=false)]
        public bool IsOBPPricing { get; set; }

        /// <summary>
        /// Gets or Sets RatePlanList
        /// </summary>
        [DataMember(Name="ratePlanList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponseProductListInnerRatePlanListInner> RatePlanList { get; set; }

        /// <summary>
        /// Gets or Sets PolicyInfo
        /// </summary>
        [DataMember(Name="policyInfo", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponseProductListInnerPolicyInfo PolicyInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponseProductListInner {\n");
            sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MealPlanList: ").Append(MealPlanList).Append("\n");
            sb.Append("  RoomTypeList: ").Append(RoomTypeList).Append("\n");
            sb.Append("  IsLOSPricing: ").Append(IsLOSPricing).Append("\n");
            sb.Append("  IsOBPPricing: ").Append(IsOBPPricing).Append("\n");
            sb.Append("  RatePlanList: ").Append(RatePlanList).Append("\n");
            sb.Append("  PolicyInfo: ").Append(PolicyInfo).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponseProductListInner);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponseProductListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponseProductListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponseProductListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PropertyId == input.PropertyId ||
                    (this.PropertyId != null &&
                    this.PropertyId.Equals(input.PropertyId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MealPlanList == input.MealPlanList ||
                    this.MealPlanList != null &&
                    input.MealPlanList != null &&
                    this.MealPlanList.SequenceEqual(input.MealPlanList)
                ) && 
                (
                    this.RoomTypeList == input.RoomTypeList ||
                    this.RoomTypeList != null &&
                    input.RoomTypeList != null &&
                    this.RoomTypeList.SequenceEqual(input.RoomTypeList)
                ) && 
                (
                    this.IsLOSPricing == input.IsLOSPricing ||
                    (this.IsLOSPricing != null &&
                    this.IsLOSPricing.Equals(input.IsLOSPricing))
                ) && 
                (
                    this.IsOBPPricing == input.IsOBPPricing ||
                    (this.IsOBPPricing != null &&
                    this.IsOBPPricing.Equals(input.IsOBPPricing))
                ) && 
                (
                    this.RatePlanList == input.RatePlanList ||
                    this.RatePlanList != null &&
                    input.RatePlanList != null &&
                    this.RatePlanList.SequenceEqual(input.RatePlanList)
                ) && 
                (
                    this.PolicyInfo == input.PolicyInfo ||
                    (this.PolicyInfo != null &&
                    this.PolicyInfo.Equals(input.PolicyInfo))
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
                if (this.PropertyId != null)
                    hashCode = hashCode * 59 + this.PropertyId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MealPlanList != null)
                    hashCode = hashCode * 59 + this.MealPlanList.GetHashCode();
                if (this.RoomTypeList != null)
                    hashCode = hashCode * 59 + this.RoomTypeList.GetHashCode();
                if (this.IsLOSPricing != null)
                    hashCode = hashCode * 59 + this.IsLOSPricing.GetHashCode();
                if (this.IsOBPPricing != null)
                    hashCode = hashCode * 59 + this.IsOBPPricing.GetHashCode();
                if (this.RatePlanList != null)
                    hashCode = hashCode * 59 + this.RatePlanList.GetHashCode();
                if (this.PolicyInfo != null)
                    hashCode = hashCode * 59 + this.PolicyInfo.GetHashCode();
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