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
    /// V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner :  IEquatable<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="quantity">quantity.</param>
        public V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner(string code = default(string), decimal quantity = default(decimal))
        {
            this.Code = code;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner input)
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
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
