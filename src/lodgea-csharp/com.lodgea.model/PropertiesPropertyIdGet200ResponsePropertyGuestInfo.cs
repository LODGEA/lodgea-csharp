/*
 * lodgea-csharp
 *
 * LODGEA SDK for csharp. Check out https://docs.lodgea.io for more information.
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// Information regarding requirements towards guests.
    /// </summary>
    [DataContract]
    public partial class PropertiesPropertyIdGet200ResponsePropertyGuestInfo :  IEquatable<PropertiesPropertyIdGet200ResponsePropertyGuestInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdGet200ResponsePropertyGuestInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertiesPropertyIdGet200ResponsePropertyGuestInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdGet200ResponsePropertyGuestInfo" /> class.
        /// </summary>
        /// <param name="guestAddressRequired">Whether the address of the guest is required to book this property. (required).</param>
        /// <param name="guestContactNumberRequired">Whether the phone number of the guest is required to book this property. (required).</param>
        /// <param name="guestNameListRequired">Whether a list of the guests names is required to book this property. (required).</param>
        public PropertiesPropertyIdGet200ResponsePropertyGuestInfo(bool guestAddressRequired = default(bool), bool guestContactNumberRequired = default(bool), bool guestNameListRequired = default(bool))
        {
            // to ensure "guestAddressRequired" is required (not null)
            if (guestAddressRequired == null)
            {
                throw new InvalidDataException("guestAddressRequired is a required property for PropertiesPropertyIdGet200ResponsePropertyGuestInfo and cannot be null");
            }
            else
            {
                this.GuestAddressRequired = guestAddressRequired;
            }

            // to ensure "guestContactNumberRequired" is required (not null)
            if (guestContactNumberRequired == null)
            {
                throw new InvalidDataException("guestContactNumberRequired is a required property for PropertiesPropertyIdGet200ResponsePropertyGuestInfo and cannot be null");
            }
            else
            {
                this.GuestContactNumberRequired = guestContactNumberRequired;
            }

            // to ensure "guestNameListRequired" is required (not null)
            if (guestNameListRequired == null)
            {
                throw new InvalidDataException("guestNameListRequired is a required property for PropertiesPropertyIdGet200ResponsePropertyGuestInfo and cannot be null");
            }
            else
            {
                this.GuestNameListRequired = guestNameListRequired;
            }

        }

        /// <summary>
        /// Whether the address of the guest is required to book this property.
        /// </summary>
        /// <value>Whether the address of the guest is required to book this property.</value>
        [DataMember(Name="guestAddressRequired", EmitDefaultValue=true)]
        public bool GuestAddressRequired { get; set; }

        /// <summary>
        /// Whether the phone number of the guest is required to book this property.
        /// </summary>
        /// <value>Whether the phone number of the guest is required to book this property.</value>
        [DataMember(Name="guestContactNumberRequired", EmitDefaultValue=true)]
        public bool GuestContactNumberRequired { get; set; }

        /// <summary>
        /// Whether a list of the guests names is required to book this property.
        /// </summary>
        /// <value>Whether a list of the guests names is required to book this property.</value>
        [DataMember(Name="guestNameListRequired", EmitDefaultValue=true)]
        public bool GuestNameListRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesPropertyIdGet200ResponsePropertyGuestInfo {\n");
            sb.Append("  GuestAddressRequired: ").Append(GuestAddressRequired).Append("\n");
            sb.Append("  GuestContactNumberRequired: ").Append(GuestContactNumberRequired).Append("\n");
            sb.Append("  GuestNameListRequired: ").Append(GuestNameListRequired).Append("\n");
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
            return this.Equals(input as PropertiesPropertyIdGet200ResponsePropertyGuestInfo);
        }

        /// <summary>
        /// Returns true if PropertiesPropertyIdGet200ResponsePropertyGuestInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesPropertyIdGet200ResponsePropertyGuestInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesPropertyIdGet200ResponsePropertyGuestInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GuestAddressRequired == input.GuestAddressRequired ||
                    (this.GuestAddressRequired != null &&
                    this.GuestAddressRequired.Equals(input.GuestAddressRequired))
                ) && 
                (
                    this.GuestContactNumberRequired == input.GuestContactNumberRequired ||
                    (this.GuestContactNumberRequired != null &&
                    this.GuestContactNumberRequired.Equals(input.GuestContactNumberRequired))
                ) && 
                (
                    this.GuestNameListRequired == input.GuestNameListRequired ||
                    (this.GuestNameListRequired != null &&
                    this.GuestNameListRequired.Equals(input.GuestNameListRequired))
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
                if (this.GuestAddressRequired != null)
                    hashCode = hashCode * 59 + this.GuestAddressRequired.GetHashCode();
                if (this.GuestContactNumberRequired != null)
                    hashCode = hashCode * 59 + this.GuestContactNumberRequired.GetHashCode();
                if (this.GuestNameListRequired != null)
                    hashCode = hashCode * 59 + this.GuestNameListRequired.GetHashCode();
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
