/*
 * lodgea-csharp
 *
 * LODGEA SDK for CSharp. Check out https://docs.lodgea.io for more information.
 *
 * The version of the OpenAPI document: 1.0.0
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
    /// V1AvailabilitySearchPost200ResponseListInnerMediaListInner
    /// </summary>
    [DataContract]
    public partial class V1AvailabilitySearchPost200ResponseListInnerMediaListInner :  IEquatable<V1AvailabilitySearchPost200ResponseListInnerMediaListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1AvailabilitySearchPost200ResponseListInnerMediaListInner" /> class.
        /// </summary>
        /// <param name="tagCodeList">tagCodeList.</param>
        /// <param name="isMainImage">isMainImage.</param>
        /// <param name="url">url.</param>
        /// <param name="sortOrder">sortOrder.</param>
        public V1AvailabilitySearchPost200ResponseListInnerMediaListInner(List<decimal> tagCodeList = default(List<decimal>), bool isMainImage = default(bool), string url = default(string), decimal sortOrder = default(decimal))
        {
            this.TagCodeList = tagCodeList;
            this.IsMainImage = isMainImage;
            this.Url = url;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Gets or Sets TagCodeList
        /// </summary>
        [DataMember(Name="tagCodeList", EmitDefaultValue=false)]
        public List<decimal> TagCodeList { get; set; }

        /// <summary>
        /// Gets or Sets IsMainImage
        /// </summary>
        [DataMember(Name="isMainImage", EmitDefaultValue=false)]
        public bool IsMainImage { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public decimal SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1AvailabilitySearchPost200ResponseListInnerMediaListInner {\n");
            sb.Append("  TagCodeList: ").Append(TagCodeList).Append("\n");
            sb.Append("  IsMainImage: ").Append(IsMainImage).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as V1AvailabilitySearchPost200ResponseListInnerMediaListInner);
        }

        /// <summary>
        /// Returns true if V1AvailabilitySearchPost200ResponseListInnerMediaListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1AvailabilitySearchPost200ResponseListInnerMediaListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1AvailabilitySearchPost200ResponseListInnerMediaListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagCodeList == input.TagCodeList ||
                    this.TagCodeList != null &&
                    input.TagCodeList != null &&
                    this.TagCodeList.SequenceEqual(input.TagCodeList)
                ) && 
                (
                    this.IsMainImage == input.IsMainImage ||
                    (this.IsMainImage != null &&
                    this.IsMainImage.Equals(input.IsMainImage))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
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
                if (this.TagCodeList != null)
                    hashCode = hashCode * 59 + this.TagCodeList.GetHashCode();
                if (this.IsMainImage != null)
                    hashCode = hashCode * 59 + this.IsMainImage.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
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
