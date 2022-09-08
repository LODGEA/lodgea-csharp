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
    /// V1PropertyGetPost200Response
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200Response :  IEquatable<V1PropertyGetPost200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200Response" /> class.
        /// </summary>
        /// <param name="versionId">versionId.</param>
        /// <param name="property">property.</param>
        /// <param name="productList">productList.</param>
        public V1PropertyGetPost200Response(string versionId = default(string), V1PropertyGetPost200ResponseProperty property = default(V1PropertyGetPost200ResponseProperty), List<V1PropertyGetPost200ResponseProductListInner> productList = default(List<V1PropertyGetPost200ResponseProductListInner>))
        {
            this.VersionId = versionId;
            this.Property = property;
            this.ProductList = productList;
        }

        /// <summary>
        /// Gets or Sets VersionId
        /// </summary>
        [DataMember(Name="versionId", EmitDefaultValue=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name="property", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponseProperty Property { get; set; }

        /// <summary>
        /// Gets or Sets ProductList
        /// </summary>
        [DataMember(Name="productList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponseProductListInner> ProductList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200Response {\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  ProductList: ").Append(ProductList).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200Response);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.ProductList == input.ProductList ||
                    this.ProductList != null &&
                    input.ProductList != null &&
                    this.ProductList.SequenceEqual(input.ProductList)
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
                if (this.VersionId != null)
                    hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.ProductList != null)
                    hashCode = hashCode * 59 + this.ProductList.GetHashCode();
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
