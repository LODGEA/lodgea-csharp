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
    /// V1PropertyGetPost200ResponsePropertyContactListInner
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyContactListInner :  IEquatable<V1PropertyGetPost200ResponsePropertyContactListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyContactListInner" /> class.
        /// </summary>
        /// <param name="profileType">profileType.</param>
        /// <param name="addressList">addressList.</param>
        public V1PropertyGetPost200ResponsePropertyContactListInner(string profileType = default(string), List<V1PropertyGetPost200ResponsePropertyContactListInnerAddressListInner> addressList = default(List<V1PropertyGetPost200ResponsePropertyContactListInnerAddressListInner>))
        {
            this.ProfileType = profileType;
            this.AddressList = addressList;
        }

        /// <summary>
        /// Gets or Sets ProfileType
        /// </summary>
        [DataMember(Name="profileType", EmitDefaultValue=false)]
        public string ProfileType { get; set; }

        /// <summary>
        /// Gets or Sets AddressList
        /// </summary>
        [DataMember(Name="addressList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyContactListInnerAddressListInner> AddressList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyContactListInner {\n");
            sb.Append("  ProfileType: ").Append(ProfileType).Append("\n");
            sb.Append("  AddressList: ").Append(AddressList).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyContactListInner);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyContactListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyContactListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyContactListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProfileType == input.ProfileType ||
                    (this.ProfileType != null &&
                    this.ProfileType.Equals(input.ProfileType))
                ) && 
                (
                    this.AddressList == input.AddressList ||
                    this.AddressList != null &&
                    input.AddressList != null &&
                    this.AddressList.SequenceEqual(input.AddressList)
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
                if (this.ProfileType != null)
                    hashCode = hashCode * 59 + this.ProfileType.GetHashCode();
                if (this.AddressList != null)
                    hashCode = hashCode * 59 + this.AddressList.GetHashCode();
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
