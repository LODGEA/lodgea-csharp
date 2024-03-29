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
    /// PropertiesPropertyIdAvailabilityGet200Response
    /// </summary>
    [DataContract]
    public partial class PropertiesPropertyIdAvailabilityGet200Response :  IEquatable<PropertiesPropertyIdAvailabilityGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdAvailabilityGet200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertiesPropertyIdAvailabilityGet200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdAvailabilityGet200Response" /> class.
        /// </summary>
        /// <param name="availabilityList">An array of objects describing the available booking options. (required).</param>
        public PropertiesPropertyIdAvailabilityGet200Response(List<PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner> availabilityList = default(List<PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner>))
        {
            // to ensure "availabilityList" is required (not null)
            if (availabilityList == null)
            {
                throw new InvalidDataException("availabilityList is a required property for PropertiesPropertyIdAvailabilityGet200Response and cannot be null");
            }
            else
            {
                this.AvailabilityList = availabilityList;
            }

        }

        /// <summary>
        /// An array of objects describing the available booking options.
        /// </summary>
        /// <value>An array of objects describing the available booking options.</value>
        [DataMember(Name="availabilityList", EmitDefaultValue=true)]
        public List<PropertiesPropertyIdAvailabilityGet200ResponseAvailabilityListInner> AvailabilityList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesPropertyIdAvailabilityGet200Response {\n");
            sb.Append("  AvailabilityList: ").Append(AvailabilityList).Append("\n");
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
            return this.Equals(input as PropertiesPropertyIdAvailabilityGet200Response);
        }

        /// <summary>
        /// Returns true if PropertiesPropertyIdAvailabilityGet200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesPropertyIdAvailabilityGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesPropertyIdAvailabilityGet200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabilityList == input.AvailabilityList ||
                    this.AvailabilityList != null &&
                    input.AvailabilityList != null &&
                    this.AvailabilityList.SequenceEqual(input.AvailabilityList)
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
                if (this.AvailabilityList != null)
                    hashCode = hashCode * 59 + this.AvailabilityList.GetHashCode();
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
