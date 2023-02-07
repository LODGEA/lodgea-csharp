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
    /// PropertiesGet200ResponseListInner
    /// </summary>
    [DataContract]
    public partial class PropertiesGet200ResponseListInner :  IEquatable<PropertiesGet200ResponseListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesGet200ResponseListInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertiesGet200ResponseListInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesGet200ResponseListInner" /> class.
        /// </summary>
        /// <param name="published">Whether the property is in published state. (required).</param>
        /// <param name="name">The name of the property. (required).</param>
        /// <param name="propertyId">The unique identifier for the property. (required).</param>
        /// <param name="image">The file name of the image for the property. (required).</param>
        /// <param name="address">The address of the property. (required).</param>
        /// <param name="lastUpdated">The timestamp of the last update to the property (Unix in ms). (required).</param>
        public PropertiesGet200ResponseListInner(bool published = default(bool), string name = default(string), string propertyId = default(string), string image = default(string), string address = default(string), decimal lastUpdated = default(decimal))
        {
            // to ensure "published" is required (not null)
            if (published == null)
            {
                throw new InvalidDataException("published is a required property for PropertiesGet200ResponseListInner and cannot be null");
            }
            else
            {
                this.Published = published;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PropertiesGet200ResponseListInner and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "propertyId" is required (not null)
            if (propertyId == null)
            {
                throw new InvalidDataException("propertyId is a required property for PropertiesGet200ResponseListInner and cannot be null");
            }
            else
            {
                this.PropertyId = propertyId;
            }

            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new InvalidDataException("image is a required property for PropertiesGet200ResponseListInner and cannot be null");
            }
            else
            {
                this.Image = image;
            }

            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for PropertiesGet200ResponseListInner and cannot be null");
            }
            else
            {
                this.Address = address;
            }

            // to ensure "lastUpdated" is required (not null)
            if (lastUpdated == null)
            {
                throw new InvalidDataException("lastUpdated is a required property for PropertiesGet200ResponseListInner and cannot be null");
            }
            else
            {
                this.LastUpdated = lastUpdated;
            }

        }

        /// <summary>
        /// Whether the property is in published state.
        /// </summary>
        /// <value>Whether the property is in published state.</value>
        [DataMember(Name="published", EmitDefaultValue=true)]
        public bool Published { get; set; }

        /// <summary>
        /// The name of the property.
        /// </summary>
        /// <value>The name of the property.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier for the property.
        /// </summary>
        /// <value>The unique identifier for the property.</value>
        [DataMember(Name="propertyId", EmitDefaultValue=true)]
        public string PropertyId { get; set; }

        /// <summary>
        /// The file name of the image for the property.
        /// </summary>
        /// <value>The file name of the image for the property.</value>
        [DataMember(Name="image", EmitDefaultValue=true)]
        public string Image { get; set; }

        /// <summary>
        /// The address of the property.
        /// </summary>
        /// <value>The address of the property.</value>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }

        /// <summary>
        /// The timestamp of the last update to the property (Unix in ms).
        /// </summary>
        /// <value>The timestamp of the last update to the property (Unix in ms).</value>
        [DataMember(Name="lastUpdated", EmitDefaultValue=true)]
        public decimal LastUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesGet200ResponseListInner {\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
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
            return this.Equals(input as PropertiesGet200ResponseListInner);
        }

        /// <summary>
        /// Returns true if PropertiesGet200ResponseListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesGet200ResponseListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesGet200ResponseListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PropertyId == input.PropertyId ||
                    (this.PropertyId != null &&
                    this.PropertyId.Equals(input.PropertyId))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
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
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PropertyId != null)
                    hashCode = hashCode * 59 + this.PropertyId.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
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
