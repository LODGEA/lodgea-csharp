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
    /// V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInner
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInner :  IEquatable<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInner" /> class.
        /// </summary>
        /// <param name="isActive">isActive.</param>
        /// <param name="roomId">roomId.</param>
        /// <param name="name">name.</param>
        /// <param name="typeName">typeName.</param>
        /// <param name="descriptionText">descriptionText.</param>
        /// <param name="imageList">imageList.</param>
        /// <param name="roomTypeCode">roomTypeCode.</param>
        /// <param name="isNonSmoking">isNonSmoking.</param>
        /// <param name="roomTypeName">roomTypeName.</param>
        /// <param name="amenityList">amenityList.</param>
        /// <param name="maxOccupancy">maxOccupancy.</param>
        /// <param name="messageList">messageList.</param>
        /// <param name="mediaList">mediaList.</param>
        /// <param name="maxAdultOccupancy">maxAdultOccupancy.</param>
        /// <param name="maxChildOccupancy">maxChildOccupancy.</param>
        public V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInner(bool isActive = default(bool), string roomId = default(string), string name = default(string), string typeName = default(string), string descriptionText = default(string), List<string> imageList = default(List<string>), string roomTypeCode = default(string), bool isNonSmoking = default(bool), string roomTypeName = default(string), List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner> amenityList = default(List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner>), string maxOccupancy = default(string), List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMessageListInner> messageList = default(List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMessageListInner>), List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner> mediaList = default(List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner>), string maxAdultOccupancy = default(string), string maxChildOccupancy = default(string))
        {
            this.IsActive = isActive;
            this.RoomId = roomId;
            this.Name = name;
            this.TypeName = typeName;
            this.DescriptionText = descriptionText;
            this.ImageList = imageList;
            this.RoomTypeCode = roomTypeCode;
            this.IsNonSmoking = isNonSmoking;
            this.RoomTypeName = roomTypeName;
            this.AmenityList = amenityList;
            this.MaxOccupancy = maxOccupancy;
            this.MessageList = messageList;
            this.MediaList = mediaList;
            this.MaxAdultOccupancy = maxAdultOccupancy;
            this.MaxChildOccupancy = maxChildOccupancy;
        }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets RoomId
        /// </summary>
        [DataMember(Name="roomId", EmitDefaultValue=false)]
        public string RoomId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TypeName
        /// </summary>
        [DataMember(Name="typeName", EmitDefaultValue=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or Sets DescriptionText
        /// </summary>
        [DataMember(Name="descriptionText", EmitDefaultValue=false)]
        public string DescriptionText { get; set; }

        /// <summary>
        /// Gets or Sets ImageList
        /// </summary>
        [DataMember(Name="imageList", EmitDefaultValue=false)]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// Gets or Sets RoomTypeCode
        /// </summary>
        [DataMember(Name="roomTypeCode", EmitDefaultValue=false)]
        public string RoomTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets IsNonSmoking
        /// </summary>
        [DataMember(Name="isNonSmoking", EmitDefaultValue=false)]
        public bool IsNonSmoking { get; set; }

        /// <summary>
        /// Gets or Sets RoomTypeName
        /// </summary>
        [DataMember(Name="roomTypeName", EmitDefaultValue=false)]
        public string RoomTypeName { get; set; }

        /// <summary>
        /// Gets or Sets AmenityList
        /// </summary>
        [DataMember(Name="amenityList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerAmenityListInner> AmenityList { get; set; }

        /// <summary>
        /// Gets or Sets MaxOccupancy
        /// </summary>
        [DataMember(Name="maxOccupancy", EmitDefaultValue=false)]
        public string MaxOccupancy { get; set; }

        /// <summary>
        /// Gets or Sets MessageList
        /// </summary>
        [DataMember(Name="messageList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMessageListInner> MessageList { get; set; }

        /// <summary>
        /// Gets or Sets MediaList
        /// </summary>
        [DataMember(Name="mediaList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInnerMediaListInner> MediaList { get; set; }

        /// <summary>
        /// Gets or Sets MaxAdultOccupancy
        /// </summary>
        [DataMember(Name="maxAdultOccupancy", EmitDefaultValue=false)]
        public string MaxAdultOccupancy { get; set; }

        /// <summary>
        /// Gets or Sets MaxChildOccupancy
        /// </summary>
        [DataMember(Name="maxChildOccupancy", EmitDefaultValue=false)]
        public string MaxChildOccupancy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInner {\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  DescriptionText: ").Append(DescriptionText).Append("\n");
            sb.Append("  ImageList: ").Append(ImageList).Append("\n");
            sb.Append("  RoomTypeCode: ").Append(RoomTypeCode).Append("\n");
            sb.Append("  IsNonSmoking: ").Append(IsNonSmoking).Append("\n");
            sb.Append("  RoomTypeName: ").Append(RoomTypeName).Append("\n");
            sb.Append("  AmenityList: ").Append(AmenityList).Append("\n");
            sb.Append("  MaxOccupancy: ").Append(MaxOccupancy).Append("\n");
            sb.Append("  MessageList: ").Append(MessageList).Append("\n");
            sb.Append("  MediaList: ").Append(MediaList).Append("\n");
            sb.Append("  MaxAdultOccupancy: ").Append(MaxAdultOccupancy).Append("\n");
            sb.Append("  MaxChildOccupancy: ").Append(MaxChildOccupancy).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInner);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyFacilityInfoGuestRoomListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.RoomId == input.RoomId ||
                    (this.RoomId != null &&
                    this.RoomId.Equals(input.RoomId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TypeName == input.TypeName ||
                    (this.TypeName != null &&
                    this.TypeName.Equals(input.TypeName))
                ) && 
                (
                    this.DescriptionText == input.DescriptionText ||
                    (this.DescriptionText != null &&
                    this.DescriptionText.Equals(input.DescriptionText))
                ) && 
                (
                    this.ImageList == input.ImageList ||
                    this.ImageList != null &&
                    input.ImageList != null &&
                    this.ImageList.SequenceEqual(input.ImageList)
                ) && 
                (
                    this.RoomTypeCode == input.RoomTypeCode ||
                    (this.RoomTypeCode != null &&
                    this.RoomTypeCode.Equals(input.RoomTypeCode))
                ) && 
                (
                    this.IsNonSmoking == input.IsNonSmoking ||
                    (this.IsNonSmoking != null &&
                    this.IsNonSmoking.Equals(input.IsNonSmoking))
                ) && 
                (
                    this.RoomTypeName == input.RoomTypeName ||
                    (this.RoomTypeName != null &&
                    this.RoomTypeName.Equals(input.RoomTypeName))
                ) && 
                (
                    this.AmenityList == input.AmenityList ||
                    this.AmenityList != null &&
                    input.AmenityList != null &&
                    this.AmenityList.SequenceEqual(input.AmenityList)
                ) && 
                (
                    this.MaxOccupancy == input.MaxOccupancy ||
                    (this.MaxOccupancy != null &&
                    this.MaxOccupancy.Equals(input.MaxOccupancy))
                ) && 
                (
                    this.MessageList == input.MessageList ||
                    this.MessageList != null &&
                    input.MessageList != null &&
                    this.MessageList.SequenceEqual(input.MessageList)
                ) && 
                (
                    this.MediaList == input.MediaList ||
                    this.MediaList != null &&
                    input.MediaList != null &&
                    this.MediaList.SequenceEqual(input.MediaList)
                ) && 
                (
                    this.MaxAdultOccupancy == input.MaxAdultOccupancy ||
                    (this.MaxAdultOccupancy != null &&
                    this.MaxAdultOccupancy.Equals(input.MaxAdultOccupancy))
                ) && 
                (
                    this.MaxChildOccupancy == input.MaxChildOccupancy ||
                    (this.MaxChildOccupancy != null &&
                    this.MaxChildOccupancy.Equals(input.MaxChildOccupancy))
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
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.RoomId != null)
                    hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TypeName != null)
                    hashCode = hashCode * 59 + this.TypeName.GetHashCode();
                if (this.DescriptionText != null)
                    hashCode = hashCode * 59 + this.DescriptionText.GetHashCode();
                if (this.ImageList != null)
                    hashCode = hashCode * 59 + this.ImageList.GetHashCode();
                if (this.RoomTypeCode != null)
                    hashCode = hashCode * 59 + this.RoomTypeCode.GetHashCode();
                if (this.IsNonSmoking != null)
                    hashCode = hashCode * 59 + this.IsNonSmoking.GetHashCode();
                if (this.RoomTypeName != null)
                    hashCode = hashCode * 59 + this.RoomTypeName.GetHashCode();
                if (this.AmenityList != null)
                    hashCode = hashCode * 59 + this.AmenityList.GetHashCode();
                if (this.MaxOccupancy != null)
                    hashCode = hashCode * 59 + this.MaxOccupancy.GetHashCode();
                if (this.MessageList != null)
                    hashCode = hashCode * 59 + this.MessageList.GetHashCode();
                if (this.MediaList != null)
                    hashCode = hashCode * 59 + this.MediaList.GetHashCode();
                if (this.MaxAdultOccupancy != null)
                    hashCode = hashCode * 59 + this.MaxAdultOccupancy.GetHashCode();
                if (this.MaxChildOccupancy != null)
                    hashCode = hashCode * 59 + this.MaxChildOccupancy.GetHashCode();
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
