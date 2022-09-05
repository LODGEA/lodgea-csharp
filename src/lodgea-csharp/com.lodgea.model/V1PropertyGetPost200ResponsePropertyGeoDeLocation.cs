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
    /// V1PropertyGetPost200ResponsePropertyGeoDeLocation
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyGeoDeLocation :  IEquatable<V1PropertyGetPost200ResponsePropertyGeoDeLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyGeoDeLocation" /> class.
        /// </summary>
        /// <param name="lat">lat.</param>
        /// <param name="lng">lng.</param>
        public V1PropertyGetPost200ResponsePropertyGeoDeLocation(decimal lat = default(decimal), decimal lng = default(decimal))
        {
            this.Lat = lat;
            this.Lng = lng;
        }

        /// <summary>
        /// Gets or Sets Lat
        /// </summary>
        [DataMember(Name="lat", EmitDefaultValue=false)]
        public decimal Lat { get; set; }

        /// <summary>
        /// Gets or Sets Lng
        /// </summary>
        [DataMember(Name="lng", EmitDefaultValue=false)]
        public decimal Lng { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyGeoDeLocation {\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyGeoDeLocation);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyGeoDeLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyGeoDeLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyGeoDeLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
                ) && 
                (
                    this.Lng == input.Lng ||
                    (this.Lng != null &&
                    this.Lng.Equals(input.Lng))
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
                if (this.Lat != null)
                    hashCode = hashCode * 59 + this.Lat.GetHashCode();
                if (this.Lng != null)
                    hashCode = hashCode * 59 + this.Lng.GetHashCode();
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
