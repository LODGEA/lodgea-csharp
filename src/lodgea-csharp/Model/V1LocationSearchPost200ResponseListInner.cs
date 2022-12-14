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

namespace lodgea-csharp.Model
{
    /// <summary>
    /// V1LocationSearchPost200ResponseListInner
    /// </summary>
    [DataContract]
    public partial class V1LocationSearchPost200ResponseListInner :  IEquatable<V1LocationSearchPost200ResponseListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LocationSearchPost200ResponseListInner" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="lowestPrice">lowestPrice.</param>
        /// <param name="propertyId">propertyId.</param>
        /// <param name="propertyUriName">propertyUriName.</param>
        /// <param name="propertyUriPath">propertyUriPath.</param>
        public V1LocationSearchPost200ResponseListInner(string name = default(string), string type = default(string), string currencyCode = default(string), decimal lowestPrice = default(decimal), string propertyId = default(string), string propertyUriName = default(string), string propertyUriPath = default(string))
        {
            this.Name = name;
            this.Type = type;
            this.CurrencyCode = currencyCode;
            this.LowestPrice = lowestPrice;
            this.PropertyId = propertyId;
            this.PropertyUriName = propertyUriName;
            this.PropertyUriPath = propertyUriPath;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets LowestPrice
        /// </summary>
        [DataMember(Name="lowestPrice", EmitDefaultValue=false)]
        public decimal LowestPrice { get; set; }

        /// <summary>
        /// Gets or Sets PropertyId
        /// </summary>
        [DataMember(Name="propertyId", EmitDefaultValue=false)]
        public string PropertyId { get; set; }

        /// <summary>
        /// Gets or Sets PropertyUriName
        /// </summary>
        [DataMember(Name="propertyUriName", EmitDefaultValue=false)]
        public string PropertyUriName { get; set; }

        /// <summary>
        /// Gets or Sets PropertyUriPath
        /// </summary>
        [DataMember(Name="propertyUriPath", EmitDefaultValue=false)]
        public string PropertyUriPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1LocationSearchPost200ResponseListInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  LowestPrice: ").Append(LowestPrice).Append("\n");
            sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
            sb.Append("  PropertyUriName: ").Append(PropertyUriName).Append("\n");
            sb.Append("  PropertyUriPath: ").Append(PropertyUriPath).Append("\n");
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
            return this.Equals(input as V1LocationSearchPost200ResponseListInner);
        }

        /// <summary>
        /// Returns true if V1LocationSearchPost200ResponseListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1LocationSearchPost200ResponseListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1LocationSearchPost200ResponseListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.LowestPrice == input.LowestPrice ||
                    (this.LowestPrice != null &&
                    this.LowestPrice.Equals(input.LowestPrice))
                ) && 
                (
                    this.PropertyId == input.PropertyId ||
                    (this.PropertyId != null &&
                    this.PropertyId.Equals(input.PropertyId))
                ) && 
                (
                    this.PropertyUriName == input.PropertyUriName ||
                    (this.PropertyUriName != null &&
                    this.PropertyUriName.Equals(input.PropertyUriName))
                ) && 
                (
                    this.PropertyUriPath == input.PropertyUriPath ||
                    (this.PropertyUriPath != null &&
                    this.PropertyUriPath.Equals(input.PropertyUriPath))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.LowestPrice != null)
                    hashCode = hashCode * 59 + this.LowestPrice.GetHashCode();
                if (this.PropertyId != null)
                    hashCode = hashCode * 59 + this.PropertyId.GetHashCode();
                if (this.PropertyUriName != null)
                    hashCode = hashCode * 59 + this.PropertyUriName.GetHashCode();
                if (this.PropertyUriPath != null)
                    hashCode = hashCode * 59 + this.PropertyUriPath.GetHashCode();
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
