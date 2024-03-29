/*
 * lodgea-csharp
 *
 * LODGEA SDK for csharp. Check out https://docs.lodgea.io for more information.
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner
    /// </summary>
    [DataContract]
    public partial class PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner :  IEquatable<PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner>, IValidatableObject
    {
        /// <summary>
        /// Defines MealPlanList
        /// </summary>
        public enum MealPlanListEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            _0 = 1,

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 2,

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 3,

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 4,

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 5,

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 6,

            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 7,

            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 8,

            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 9,

            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9 = 10,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 11,

            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 12,

            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12 = 13,

            /// <summary>
            /// Enum _14 for value: 14
            /// </summary>
            [EnumMember(Value = "14")]
            _14 = 14,

            /// <summary>
            /// Enum _15 for value: 15
            /// </summary>
            [EnumMember(Value = "15")]
            _15 = 15,

            /// <summary>
            /// Enum _16 for value: 16
            /// </summary>
            [EnumMember(Value = "16")]
            _16 = 16,

            /// <summary>
            /// Enum _17 for value: 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17 = 17,

            /// <summary>
            /// Enum _18 for value: 18
            /// </summary>
            [EnumMember(Value = "18")]
            _18 = 18,

            /// <summary>
            /// Enum _19 for value: 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19 = 19,

            /// <summary>
            /// Enum _20 for value: 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20 = 20,

            /// <summary>
            /// Enum _21 for value: 21
            /// </summary>
            [EnumMember(Value = "21")]
            _21 = 21,

            /// <summary>
            /// Enum _22 for value: 22
            /// </summary>
            [EnumMember(Value = "22")]
            _22 = 22,

            /// <summary>
            /// Enum _23 for value: 23
            /// </summary>
            [EnumMember(Value = "23")]
            _23 = 23,

            /// <summary>
            /// Enum _24 for value: 24
            /// </summary>
            [EnumMember(Value = "24")]
            _24 = 24,

            /// <summary>
            /// Enum _90001 for value: 90001
            /// </summary>
            [EnumMember(Value = "90001")]
            _90001 = 25

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner" /> class.
        /// </summary>
        /// <param name="ratePlanList">A list of available rate plans. (required).</param>
        /// <param name="name">The name of the rate plan group. (required).</param>
        /// <param name="mealPlanList">The available meal plans.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#mealplan-type-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; (required).</param>
        /// <param name="roomTypeList">The rooms this availability is for. (required).</param>
        public PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner(List<PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner> ratePlanList = default(List<PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner>), string name = default(string), List<MealPlanListEnum> mealPlanList = default(List<MealPlanListEnum>), List<string> roomTypeList = default(List<string>))
        {
            // to ensure "ratePlanList" is required (not null)
            if (ratePlanList == null)
            {
                throw new InvalidDataException("ratePlanList is a required property for PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner and cannot be null");
            }
            else
            {
                this.RatePlanList = ratePlanList;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "mealPlanList" is required (not null)
            if (mealPlanList == null)
            {
                throw new InvalidDataException("mealPlanList is a required property for PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner and cannot be null");
            }
            else
            {
                this.MealPlanList = mealPlanList;
            }

            // to ensure "roomTypeList" is required (not null)
            if (roomTypeList == null)
            {
                throw new InvalidDataException("roomTypeList is a required property for PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner and cannot be null");
            }
            else
            {
                this.RoomTypeList = roomTypeList;
            }

        }

        /// <summary>
        /// A list of available rate plans.
        /// </summary>
        /// <value>A list of available rate plans.</value>
        [DataMember(Name="ratePlanList", EmitDefaultValue=true)]
        public List<PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner> RatePlanList { get; set; }

        /// <summary>
        /// The name of the rate plan group.
        /// </summary>
        /// <value>The name of the rate plan group.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The available meal plans.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#mealplan-type-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The available meal plans.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#mealplan-type-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="mealPlanList", EmitDefaultValue=true)]
        public List<PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner.MealPlanListEnum> MealPlanList { get; set; }

        /// <summary>
        /// The rooms this availability is for.
        /// </summary>
        /// <value>The rooms this availability is for.</value>
        [DataMember(Name="roomTypeList", EmitDefaultValue=true)]
        public List<string> RoomTypeList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner {\n");
            sb.Append("  RatePlanList: ").Append(RatePlanList).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MealPlanList: ").Append(MealPlanList).Append("\n");
            sb.Append("  RoomTypeList: ").Append(RoomTypeList).Append("\n");
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
            return this.Equals(input as PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner);
        }

        /// <summary>
        /// Returns true if PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RatePlanList == input.RatePlanList ||
                    this.RatePlanList != null &&
                    input.RatePlanList != null &&
                    this.RatePlanList.SequenceEqual(input.RatePlanList)
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
                if (this.RatePlanList != null)
                    hashCode = hashCode * 59 + this.RatePlanList.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MealPlanList != null)
                    hashCode = hashCode * 59 + this.MealPlanList.GetHashCode();
                if (this.RoomTypeList != null)
                    hashCode = hashCode * 59 + this.RoomTypeList.GetHashCode();
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
