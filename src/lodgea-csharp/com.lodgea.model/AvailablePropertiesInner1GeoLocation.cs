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
    /// AvailablePropertiesInner1GeoLocation
    /// </summary>
    [DataContract]
    public partial class AvailablePropertiesInner1GeoLocation :  IEquatable<AvailablePropertiesInner1GeoLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePropertiesInner1GeoLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvailablePropertiesInner1GeoLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePropertiesInner1GeoLocation" /> class.
        /// </summary>
        /// <param name="lng">The longitude coordinate of the location. (required).</param>
        /// <param name="lat">The location of the property as coordinates (required).</param>
        public AvailablePropertiesInner1GeoLocation(decimal lng = default(decimal), decimal lat = default(decimal))
        {
            // to ensure "lng" is required (not null)
            if (lng == null)
            {
                throw new InvalidDataException("lng is a required property for AvailablePropertiesInner1GeoLocation and cannot be null");
            }
            else
            {
                this.Lng = lng;
            }

            // to ensure "lat" is required (not null)
            if (lat == null)
            {
                throw new InvalidDataException("lat is a required property for AvailablePropertiesInner1GeoLocation and cannot be null");
            }
            else
            {
                this.Lat = lat;
            }

        }

        /// <summary>
        /// The longitude coordinate of the location.
        /// </summary>
        /// <value>The longitude coordinate of the location.</value>
        [DataMember(Name="lng", EmitDefaultValue=true)]
        public decimal Lng { get; set; }

        /// <summary>
        /// The location of the property as coordinates
        /// </summary>
        /// <value>The location of the property as coordinates</value>
        [DataMember(Name="lat", EmitDefaultValue=true)]
        public decimal Lat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailablePropertiesInner1GeoLocation {\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
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
            return this.Equals(input as AvailablePropertiesInner1GeoLocation);
        }

        /// <summary>
        /// Returns true if AvailablePropertiesInner1GeoLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailablePropertiesInner1GeoLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailablePropertiesInner1GeoLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Lng == input.Lng ||
                    (this.Lng != null &&
                    this.Lng.Equals(input.Lng))
                ) && 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
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
                if (this.Lng != null)
                    hashCode = hashCode * 59 + this.Lng.GetHashCode();
                if (this.Lat != null)
                    hashCode = hashCode * 59 + this.Lat.GetHashCode();
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
