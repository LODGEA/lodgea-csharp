/*
 * lodgea-csharp
 *
 * LODGEA SDK for CSharp. Check out https://docs.lodgea.io for more information.
 *
 * The version of the OpenAPI document: 1.0.1
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
    /// V1PropertyGetPost200ResponsePropertyPropertyInfo
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyPropertyInfo :  IEquatable<V1PropertyGetPost200ResponsePropertyPropertyInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyPropertyInfo" /> class.
        /// </summary>
        /// <param name="unitCount">unitCount.</param>
        /// <param name="messageList">messageList.</param>
        /// <param name="categoryList">categoryList.</param>
        /// <param name="languageList">languageList.</param>
        /// <param name="location">location.</param>
        /// <param name="acceptedPaymentList">acceptedPaymentList.</param>
        public V1PropertyGetPost200ResponsePropertyPropertyInfo(decimal unitCount = default(decimal), List<V1PropertyGetPost200ResponsePropertyPropertyInfoMessageListInner> messageList = default(List<V1PropertyGetPost200ResponsePropertyPropertyInfoMessageListInner>), List<V1PropertyGetPost200ResponsePropertyPropertyInfoCategoryListInner> categoryList = default(List<V1PropertyGetPost200ResponsePropertyPropertyInfoCategoryListInner>), List<string> languageList = default(List<string>), V1PropertyGetPost200ResponsePropertyPropertyInfoLocation location = default(V1PropertyGetPost200ResponsePropertyPropertyInfoLocation), List<V1PropertyGetPost200ResponsePropertyPropertyInfoAcceptedPaymentListInner> acceptedPaymentList = default(List<V1PropertyGetPost200ResponsePropertyPropertyInfoAcceptedPaymentListInner>))
        {
            this.UnitCount = unitCount;
            this.MessageList = messageList;
            this.CategoryList = categoryList;
            this.LanguageList = languageList;
            this.Location = location;
            this.AcceptedPaymentList = acceptedPaymentList;
        }

        /// <summary>
        /// Gets or Sets UnitCount
        /// </summary>
        [DataMember(Name="unitCount", EmitDefaultValue=false)]
        public decimal UnitCount { get; set; }

        /// <summary>
        /// Gets or Sets MessageList
        /// </summary>
        [DataMember(Name="messageList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyPropertyInfoMessageListInner> MessageList { get; set; }

        /// <summary>
        /// Gets or Sets CategoryList
        /// </summary>
        [DataMember(Name="categoryList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyPropertyInfoCategoryListInner> CategoryList { get; set; }

        /// <summary>
        /// Gets or Sets LanguageList
        /// </summary>
        [DataMember(Name="languageList", EmitDefaultValue=false)]
        public List<string> LanguageList { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyPropertyInfoLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets AcceptedPaymentList
        /// </summary>
        [DataMember(Name="acceptedPaymentList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyPropertyInfoAcceptedPaymentListInner> AcceptedPaymentList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyPropertyInfo {\n");
            sb.Append("  UnitCount: ").Append(UnitCount).Append("\n");
            sb.Append("  MessageList: ").Append(MessageList).Append("\n");
            sb.Append("  CategoryList: ").Append(CategoryList).Append("\n");
            sb.Append("  LanguageList: ").Append(LanguageList).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  AcceptedPaymentList: ").Append(AcceptedPaymentList).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyPropertyInfo);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyPropertyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyPropertyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyPropertyInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnitCount == input.UnitCount ||
                    (this.UnitCount != null &&
                    this.UnitCount.Equals(input.UnitCount))
                ) && 
                (
                    this.MessageList == input.MessageList ||
                    this.MessageList != null &&
                    input.MessageList != null &&
                    this.MessageList.SequenceEqual(input.MessageList)
                ) && 
                (
                    this.CategoryList == input.CategoryList ||
                    this.CategoryList != null &&
                    input.CategoryList != null &&
                    this.CategoryList.SequenceEqual(input.CategoryList)
                ) && 
                (
                    this.LanguageList == input.LanguageList ||
                    this.LanguageList != null &&
                    input.LanguageList != null &&
                    this.LanguageList.SequenceEqual(input.LanguageList)
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.AcceptedPaymentList == input.AcceptedPaymentList ||
                    this.AcceptedPaymentList != null &&
                    input.AcceptedPaymentList != null &&
                    this.AcceptedPaymentList.SequenceEqual(input.AcceptedPaymentList)
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
                if (this.UnitCount != null)
                    hashCode = hashCode * 59 + this.UnitCount.GetHashCode();
                if (this.MessageList != null)
                    hashCode = hashCode * 59 + this.MessageList.GetHashCode();
                if (this.CategoryList != null)
                    hashCode = hashCode * 59 + this.CategoryList.GetHashCode();
                if (this.LanguageList != null)
                    hashCode = hashCode * 59 + this.LanguageList.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.AcceptedPaymentList != null)
                    hashCode = hashCode * 59 + this.AcceptedPaymentList.GetHashCode();
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
