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
    /// V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner :  IEquatable<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner" /> class.
        /// </summary>
        /// <param name="isMainImage">isMainImage.</param>
        /// <param name="sortOrder">sortOrder.</param>
        /// <param name="url">url.</param>
        /// <param name="tagList">tagList.</param>
        /// <param name="moderationLabelList">moderationLabelList.</param>
        /// <param name="detectionLabelList">detectionLabelList.</param>
        /// <param name="propertyAmenityList">propertyAmenityList.</param>
        /// <param name="roomAmenityList">roomAmenityList.</param>
        public V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner(bool isMainImage = default(bool), decimal sortOrder = default(decimal), string url = default(string), List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInnerTagListInner> tagList = default(List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInnerTagListInner>), List<string> moderationLabelList = default(List<string>), List<string> detectionLabelList = default(List<string>), List<string> propertyAmenityList = default(List<string>), List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInnerRoomAmenityListInner> roomAmenityList = default(List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInnerRoomAmenityListInner>))
        {
            this.IsMainImage = isMainImage;
            this.SortOrder = sortOrder;
            this.Url = url;
            this.TagList = tagList;
            this.ModerationLabelList = moderationLabelList;
            this.DetectionLabelList = detectionLabelList;
            this.PropertyAmenityList = propertyAmenityList;
            this.RoomAmenityList = roomAmenityList;
        }

        /// <summary>
        /// Gets or Sets IsMainImage
        /// </summary>
        [DataMember(Name="isMainImage", EmitDefaultValue=false)]
        public bool IsMainImage { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public decimal SortOrder { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets TagList
        /// </summary>
        [DataMember(Name="tagList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInnerTagListInner> TagList { get; set; }

        /// <summary>
        /// Gets or Sets ModerationLabelList
        /// </summary>
        [DataMember(Name="moderationLabelList", EmitDefaultValue=false)]
        public List<string> ModerationLabelList { get; set; }

        /// <summary>
        /// Gets or Sets DetectionLabelList
        /// </summary>
        [DataMember(Name="detectionLabelList", EmitDefaultValue=false)]
        public List<string> DetectionLabelList { get; set; }

        /// <summary>
        /// Gets or Sets PropertyAmenityList
        /// </summary>
        [DataMember(Name="propertyAmenityList", EmitDefaultValue=false)]
        public List<string> PropertyAmenityList { get; set; }

        /// <summary>
        /// Gets or Sets RoomAmenityList
        /// </summary>
        [DataMember(Name="roomAmenityList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInnerRoomAmenityListInner> RoomAmenityList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner {\n");
            sb.Append("  IsMainImage: ").Append(IsMainImage).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  TagList: ").Append(TagList).Append("\n");
            sb.Append("  ModerationLabelList: ").Append(ModerationLabelList).Append("\n");
            sb.Append("  DetectionLabelList: ").Append(DetectionLabelList).Append("\n");
            sb.Append("  PropertyAmenityList: ").Append(PropertyAmenityList).Append("\n");
            sb.Append("  RoomAmenityList: ").Append(RoomAmenityList).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsMainImage == input.IsMainImage ||
                    (this.IsMainImage != null &&
                    this.IsMainImage.Equals(input.IsMainImage))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.TagList == input.TagList ||
                    this.TagList != null &&
                    input.TagList != null &&
                    this.TagList.SequenceEqual(input.TagList)
                ) && 
                (
                    this.ModerationLabelList == input.ModerationLabelList ||
                    this.ModerationLabelList != null &&
                    input.ModerationLabelList != null &&
                    this.ModerationLabelList.SequenceEqual(input.ModerationLabelList)
                ) && 
                (
                    this.DetectionLabelList == input.DetectionLabelList ||
                    this.DetectionLabelList != null &&
                    input.DetectionLabelList != null &&
                    this.DetectionLabelList.SequenceEqual(input.DetectionLabelList)
                ) && 
                (
                    this.PropertyAmenityList == input.PropertyAmenityList ||
                    this.PropertyAmenityList != null &&
                    input.PropertyAmenityList != null &&
                    this.PropertyAmenityList.SequenceEqual(input.PropertyAmenityList)
                ) && 
                (
                    this.RoomAmenityList == input.RoomAmenityList ||
                    this.RoomAmenityList != null &&
                    input.RoomAmenityList != null &&
                    this.RoomAmenityList.SequenceEqual(input.RoomAmenityList)
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
                if (this.IsMainImage != null)
                    hashCode = hashCode * 59 + this.IsMainImage.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.TagList != null)
                    hashCode = hashCode * 59 + this.TagList.GetHashCode();
                if (this.ModerationLabelList != null)
                    hashCode = hashCode * 59 + this.ModerationLabelList.GetHashCode();
                if (this.DetectionLabelList != null)
                    hashCode = hashCode * 59 + this.DetectionLabelList.GetHashCode();
                if (this.PropertyAmenityList != null)
                    hashCode = hashCode * 59 + this.PropertyAmenityList.GetHashCode();
                if (this.RoomAmenityList != null)
                    hashCode = hashCode * 59 + this.RoomAmenityList.GetHashCode();
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
