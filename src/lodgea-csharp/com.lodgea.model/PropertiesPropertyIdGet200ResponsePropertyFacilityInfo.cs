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
    /// Further information regarding the facility.
    /// </summary>
    [DataContract]
    public partial class PropertiesPropertyIdGet200ResponsePropertyFacilityInfo :  IEquatable<PropertiesPropertyIdGet200ResponsePropertyFacilityInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdGet200ResponsePropertyFacilityInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertiesPropertyIdGet200ResponsePropertyFacilityInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdGet200ResponsePropertyFacilityInfo" /> class.
        /// </summary>
        /// <param name="guestRoomList">An array of objects representing a room in the property. (required).</param>
        public PropertiesPropertyIdGet200ResponsePropertyFacilityInfo(List<PropertiesPropertyIdGet200ResponsePropertyFacilityInfoGuestRoomListInner> guestRoomList = default(List<PropertiesPropertyIdGet200ResponsePropertyFacilityInfoGuestRoomListInner>))
        {
            // to ensure "guestRoomList" is required (not null)
            if (guestRoomList == null)
            {
                throw new InvalidDataException("guestRoomList is a required property for PropertiesPropertyIdGet200ResponsePropertyFacilityInfo and cannot be null");
            }
            else
            {
                this.GuestRoomList = guestRoomList;
            }

        }

        /// <summary>
        /// An array of objects representing a room in the property.
        /// </summary>
        /// <value>An array of objects representing a room in the property.</value>
        [DataMember(Name="guestRoomList", EmitDefaultValue=true)]
        public List<PropertiesPropertyIdGet200ResponsePropertyFacilityInfoGuestRoomListInner> GuestRoomList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesPropertyIdGet200ResponsePropertyFacilityInfo {\n");
            sb.Append("  GuestRoomList: ").Append(GuestRoomList).Append("\n");
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
            return this.Equals(input as PropertiesPropertyIdGet200ResponsePropertyFacilityInfo);
        }

        /// <summary>
        /// Returns true if PropertiesPropertyIdGet200ResponsePropertyFacilityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesPropertyIdGet200ResponsePropertyFacilityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesPropertyIdGet200ResponsePropertyFacilityInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GuestRoomList == input.GuestRoomList ||
                    this.GuestRoomList != null &&
                    input.GuestRoomList != null &&
                    this.GuestRoomList.SequenceEqual(input.GuestRoomList)
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
                if (this.GuestRoomList != null)
                    hashCode = hashCode * 59 + this.GuestRoomList.GetHashCode();
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