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
    /// V1AvailabilitySearchPost200ResponseListInner
    /// </summary>
    [DataContract]
    public partial class V1AvailabilitySearchPost200ResponseListInner :  IEquatable<V1AvailabilitySearchPost200ResponseListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1AvailabilitySearchPost200ResponseListInner" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="languageCode">languageCode.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="unitSystem">unitSystem.</param>
        /// <param name="name">name.</param>
        /// <param name="uri">uri.</param>
        /// <param name="serviceList">serviceList.</param>
        /// <param name="categoryList">categoryList.</param>
        /// <param name="uriPath">uriPath.</param>
        /// <param name="text">text.</param>
        /// <param name="geo">geo.</param>
        /// <param name="mediaList">mediaList.</param>
        /// <param name="attractionList">attractionList.</param>
        /// <param name="lowestPrice">lowestPrice.</param>
        public V1AvailabilitySearchPost200ResponseListInner(string code = default(string), string languageCode = default(string), string currencyCode = default(string), string unitSystem = default(string), string name = default(string), string uri = default(string), List<decimal> serviceList = default(List<decimal>), List<decimal> categoryList = default(List<decimal>), string uriPath = default(string), string text = default(string), V1AvailabilitySearchPost200ResponseListInnerGeo geo = default(V1AvailabilitySearchPost200ResponseListInnerGeo), List<V1AvailabilitySearchPost200ResponseListInnerMediaListInner> mediaList = default(List<V1AvailabilitySearchPost200ResponseListInnerMediaListInner>), List<V1AvailabilitySearchPost200ResponseListInnerAttractionListInner> attractionList = default(List<V1AvailabilitySearchPost200ResponseListInnerAttractionListInner>), V1AvailabilitySearchPost200ResponseListInnerLowestPrice lowestPrice = default(V1AvailabilitySearchPost200ResponseListInnerLowestPrice))
        {
            this.Code = code;
            this.LanguageCode = languageCode;
            this.CurrencyCode = currencyCode;
            this.UnitSystem = unitSystem;
            this.Name = name;
            this.Uri = uri;
            this.ServiceList = serviceList;
            this.CategoryList = categoryList;
            this.UriPath = uriPath;
            this.Text = text;
            this.Geo = geo;
            this.MediaList = mediaList;
            this.AttractionList = attractionList;
            this.LowestPrice = lowestPrice;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets LanguageCode
        /// </summary>
        [DataMember(Name="languageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets UnitSystem
        /// </summary>
        [DataMember(Name="unitSystem", EmitDefaultValue=false)]
        public string UnitSystem { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets ServiceList
        /// </summary>
        [DataMember(Name="serviceList", EmitDefaultValue=false)]
        public List<decimal> ServiceList { get; set; }

        /// <summary>
        /// Gets or Sets CategoryList
        /// </summary>
        [DataMember(Name="categoryList", EmitDefaultValue=false)]
        public List<decimal> CategoryList { get; set; }

        /// <summary>
        /// Gets or Sets UriPath
        /// </summary>
        [DataMember(Name="uriPath", EmitDefaultValue=false)]
        public string UriPath { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Geo
        /// </summary>
        [DataMember(Name="geo", EmitDefaultValue=false)]
        public V1AvailabilitySearchPost200ResponseListInnerGeo Geo { get; set; }

        /// <summary>
        /// Gets or Sets MediaList
        /// </summary>
        [DataMember(Name="mediaList", EmitDefaultValue=false)]
        public List<V1AvailabilitySearchPost200ResponseListInnerMediaListInner> MediaList { get; set; }

        /// <summary>
        /// Gets or Sets AttractionList
        /// </summary>
        [DataMember(Name="attractionList", EmitDefaultValue=false)]
        public List<V1AvailabilitySearchPost200ResponseListInnerAttractionListInner> AttractionList { get; set; }

        /// <summary>
        /// Gets or Sets LowestPrice
        /// </summary>
        [DataMember(Name="lowestPrice", EmitDefaultValue=false)]
        public V1AvailabilitySearchPost200ResponseListInnerLowestPrice LowestPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1AvailabilitySearchPost200ResponseListInner {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  UnitSystem: ").Append(UnitSystem).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ServiceList: ").Append(ServiceList).Append("\n");
            sb.Append("  CategoryList: ").Append(CategoryList).Append("\n");
            sb.Append("  UriPath: ").Append(UriPath).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Geo: ").Append(Geo).Append("\n");
            sb.Append("  MediaList: ").Append(MediaList).Append("\n");
            sb.Append("  AttractionList: ").Append(AttractionList).Append("\n");
            sb.Append("  LowestPrice: ").Append(LowestPrice).Append("\n");
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
            return this.Equals(input as V1AvailabilitySearchPost200ResponseListInner);
        }

        /// <summary>
        /// Returns true if V1AvailabilitySearchPost200ResponseListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1AvailabilitySearchPost200ResponseListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1AvailabilitySearchPost200ResponseListInner input)
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
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.UnitSystem == input.UnitSystem ||
                    (this.UnitSystem != null &&
                    this.UnitSystem.Equals(input.UnitSystem))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.ServiceList == input.ServiceList ||
                    this.ServiceList != null &&
                    input.ServiceList != null &&
                    this.ServiceList.SequenceEqual(input.ServiceList)
                ) && 
                (
                    this.CategoryList == input.CategoryList ||
                    this.CategoryList != null &&
                    input.CategoryList != null &&
                    this.CategoryList.SequenceEqual(input.CategoryList)
                ) && 
                (
                    this.UriPath == input.UriPath ||
                    (this.UriPath != null &&
                    this.UriPath.Equals(input.UriPath))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Geo == input.Geo ||
                    (this.Geo != null &&
                    this.Geo.Equals(input.Geo))
                ) && 
                (
                    this.MediaList == input.MediaList ||
                    this.MediaList != null &&
                    input.MediaList != null &&
                    this.MediaList.SequenceEqual(input.MediaList)
                ) && 
                (
                    this.AttractionList == input.AttractionList ||
                    this.AttractionList != null &&
                    input.AttractionList != null &&
                    this.AttractionList.SequenceEqual(input.AttractionList)
                ) && 
                (
                    this.LowestPrice == input.LowestPrice ||
                    (this.LowestPrice != null &&
                    this.LowestPrice.Equals(input.LowestPrice))
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
                if (this.LanguageCode != null)
                    hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.UnitSystem != null)
                    hashCode = hashCode * 59 + this.UnitSystem.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.ServiceList != null)
                    hashCode = hashCode * 59 + this.ServiceList.GetHashCode();
                if (this.CategoryList != null)
                    hashCode = hashCode * 59 + this.CategoryList.GetHashCode();
                if (this.UriPath != null)
                    hashCode = hashCode * 59 + this.UriPath.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Geo != null)
                    hashCode = hashCode * 59 + this.Geo.GetHashCode();
                if (this.MediaList != null)
                    hashCode = hashCode * 59 + this.MediaList.GetHashCode();
                if (this.AttractionList != null)
                    hashCode = hashCode * 59 + this.AttractionList.GetHashCode();
                if (this.LowestPrice != null)
                    hashCode = hashCode * 59 + this.LowestPrice.GetHashCode();
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
