/*
 * lodgea-csharp
 *
 * LODGEA SDK for CSharp. Check out https://docs.lodgea.io for more information.
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
    /// V1PropertyGetPost200ResponsePropertyServiceListInner
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyServiceListInner :  IEquatable<V1PropertyGetPost200ResponsePropertyServiceListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyServiceListInner" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="price">price.</param>
        /// <param name="exists">exists.</param>
        /// <param name="included">included.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="featureList">featureList.</param>
        /// <param name="typeList">typeList.</param>
        /// <param name="itemList">itemList.</param>
        /// <param name="operationTimeList">operationTimeList.</param>
        /// <param name="name">name.</param>
        public V1PropertyGetPost200ResponsePropertyServiceListInner(decimal code = default(decimal), decimal price = default(decimal), bool exists = default(bool), bool included = default(bool), string currencyCode = default(string), List<string> featureList = default(List<string>), List<string> typeList = default(List<string>), List<string> itemList = default(List<string>), List<string> operationTimeList = default(List<string>), string name = default(string))
        {
            this.Code = code;
            this.Price = price;
            this.Exists = exists;
            this.Included = included;
            this.CurrencyCode = currencyCode;
            this.FeatureList = featureList;
            this.TypeList = typeList;
            this.ItemList = itemList;
            this.OperationTimeList = operationTimeList;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public decimal Code { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or Sets Exists
        /// </summary>
        [DataMember(Name="exists", EmitDefaultValue=false)]
        public bool Exists { get; set; }

        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name="included", EmitDefaultValue=false)]
        public bool Included { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets FeatureList
        /// </summary>
        [DataMember(Name="featureList", EmitDefaultValue=false)]
        public List<string> FeatureList { get; set; }

        /// <summary>
        /// Gets or Sets TypeList
        /// </summary>
        [DataMember(Name="typeList", EmitDefaultValue=false)]
        public List<string> TypeList { get; set; }

        /// <summary>
        /// Gets or Sets ItemList
        /// </summary>
        [DataMember(Name="itemList", EmitDefaultValue=false)]
        public List<string> ItemList { get; set; }

        /// <summary>
        /// Gets or Sets OperationTimeList
        /// </summary>
        [DataMember(Name="operationTimeList", EmitDefaultValue=false)]
        public List<string> OperationTimeList { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyServiceListInner {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Exists: ").Append(Exists).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  FeatureList: ").Append(FeatureList).Append("\n");
            sb.Append("  TypeList: ").Append(TypeList).Append("\n");
            sb.Append("  ItemList: ").Append(ItemList).Append("\n");
            sb.Append("  OperationTimeList: ").Append(OperationTimeList).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyServiceListInner);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyServiceListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyServiceListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyServiceListInner input)
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
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Exists == input.Exists ||
                    (this.Exists != null &&
                    this.Exists.Equals(input.Exists))
                ) && 
                (
                    this.Included == input.Included ||
                    (this.Included != null &&
                    this.Included.Equals(input.Included))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.FeatureList == input.FeatureList ||
                    this.FeatureList != null &&
                    input.FeatureList != null &&
                    this.FeatureList.SequenceEqual(input.FeatureList)
                ) && 
                (
                    this.TypeList == input.TypeList ||
                    this.TypeList != null &&
                    input.TypeList != null &&
                    this.TypeList.SequenceEqual(input.TypeList)
                ) && 
                (
                    this.ItemList == input.ItemList ||
                    this.ItemList != null &&
                    input.ItemList != null &&
                    this.ItemList.SequenceEqual(input.ItemList)
                ) && 
                (
                    this.OperationTimeList == input.OperationTimeList ||
                    this.OperationTimeList != null &&
                    input.OperationTimeList != null &&
                    this.OperationTimeList.SequenceEqual(input.OperationTimeList)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Exists != null)
                    hashCode = hashCode * 59 + this.Exists.GetHashCode();
                if (this.Included != null)
                    hashCode = hashCode * 59 + this.Included.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.FeatureList != null)
                    hashCode = hashCode * 59 + this.FeatureList.GetHashCode();
                if (this.TypeList != null)
                    hashCode = hashCode * 59 + this.TypeList.GetHashCode();
                if (this.ItemList != null)
                    hashCode = hashCode * 59 + this.ItemList.GetHashCode();
                if (this.OperationTimeList != null)
                    hashCode = hashCode * 59 + this.OperationTimeList.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
