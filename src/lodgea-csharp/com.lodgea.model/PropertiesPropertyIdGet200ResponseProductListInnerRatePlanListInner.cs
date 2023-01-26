/*
 * lodgea-csharp
 *
 * LODGEA SDK for CSharp. Check out https://docs.lodgea.io for more information.
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner
    /// </summary>
    [DataContract]
    public partial class PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner :  IEquatable<PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner" /> class.
        /// </summary>
        /// <param name="active">Whether the rate plan is active. (required).</param>
        /// <param name="name">The name of the rate plan. (required).</param>
        /// <param name="code">The code identifying the rate plan. (required).</param>
        /// <param name="pricingList">pricingList (required).</param>
        public PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner(bool active = default(bool), string name = default(string), string code = default(string), List<PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInnerPricingListInner> pricingList = default(List<PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInnerPricingListInner>))
        {
            // to ensure "active" is required (not null)
            if (active == null)
            {
                throw new InvalidDataException("active is a required property for PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner and cannot be null");
            }
            else
            {
                this.Active = active;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner and cannot be null");
            }
            else
            {
                this.Code = code;
            }

            // to ensure "pricingList" is required (not null)
            if (pricingList == null)
            {
                throw new InvalidDataException("pricingList is a required property for PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner and cannot be null");
            }
            else
            {
                this.PricingList = pricingList;
            }

        }

        /// <summary>
        /// Whether the rate plan is active.
        /// </summary>
        /// <value>Whether the rate plan is active.</value>
        [DataMember(Name="active", EmitDefaultValue=true)]
        public bool Active { get; set; }

        /// <summary>
        /// The name of the rate plan.
        /// </summary>
        /// <value>The name of the rate plan.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The code identifying the rate plan.
        /// </summary>
        /// <value>The code identifying the rate plan.</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets PricingList
        /// </summary>
        [DataMember(Name="pricingList", EmitDefaultValue=true)]
        public List<PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInnerPricingListInner> PricingList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner);
        }

        /// <summary>
        /// Returns true if PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesPropertyIdGet200ResponseProductListInnerRatePlanListInner input)
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