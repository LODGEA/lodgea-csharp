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
    /// V1PropertyGetPost200ResponseProperty
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponseProperty :  IEquatable<V1PropertyGetPost200ResponseProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponseProperty" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="name">name.</param>
        /// <param name="recordCreated">recordCreated.</param>
        /// <param name="recordModified">recordModified.</param>
        /// <param name="propertyInfo">propertyInfo.</param>
        /// <param name="guestInfo">guestInfo.</param>
        /// <param name="awardList">awardList.</param>
        /// <param name="contactList">contactList.</param>
        /// <param name="facilityInfo">facilityInfo.</param>
        /// <param name="mediaList">mediaList.</param>
        /// <param name="geo">geo.</param>
        /// <param name="refinementDate">refinementDate.</param>
        /// <param name="published">published.</param>
        /// <param name="policyList">policyList.</param>
        /// <param name="uri">uri.</param>
        /// <param name="transaction">transaction.</param>
        /// <param name="cancellationGracePeriod">cancellationGracePeriod.</param>
        /// <param name="serviceList">serviceList.</param>
        public V1PropertyGetPost200ResponseProperty(string code = default(string), string name = default(string), V1PropertyGetPost200ResponsePropertyRecordCreated recordCreated = default(V1PropertyGetPost200ResponsePropertyRecordCreated), V1PropertyGetPost200ResponsePropertyRecordModified recordModified = default(V1PropertyGetPost200ResponsePropertyRecordModified), V1PropertyGetPost200ResponsePropertyPropertyInfo propertyInfo = default(V1PropertyGetPost200ResponsePropertyPropertyInfo), V1PropertyGetPost200ResponsePropertyGuestInfo guestInfo = default(V1PropertyGetPost200ResponsePropertyGuestInfo), List<V1PropertyGetPost200ResponsePropertyAwardListInner> awardList = default(List<V1PropertyGetPost200ResponsePropertyAwardListInner>), List<V1PropertyGetPost200ResponsePropertyContactListInner> contactList = default(List<V1PropertyGetPost200ResponsePropertyContactListInner>), V1PropertyGetPost200ResponsePropertyFacilityInfo facilityInfo = default(V1PropertyGetPost200ResponsePropertyFacilityInfo), List<V1PropertyGetPost200ResponsePropertyMediaListInner> mediaList = default(List<V1PropertyGetPost200ResponsePropertyMediaListInner>), V1PropertyGetPost200ResponsePropertyGeo geo = default(V1PropertyGetPost200ResponsePropertyGeo), decimal refinementDate = default(decimal), bool published = default(bool), List<V1PropertyGetPost200ResponsePropertyPolicyListInner> policyList = default(List<V1PropertyGetPost200ResponsePropertyPolicyListInner>), string uri = default(string), V1PropertyGetPost200ResponsePropertyTransaction transaction = default(V1PropertyGetPost200ResponsePropertyTransaction), V1PropertyGetPost200ResponsePropertyCancellationGracePeriod cancellationGracePeriod = default(V1PropertyGetPost200ResponsePropertyCancellationGracePeriod), List<V1PropertyGetPost200ResponsePropertyServiceListInner> serviceList = default(List<V1PropertyGetPost200ResponsePropertyServiceListInner>))
        {
            this.Code = code;
            this.Name = name;
            this.RecordCreated = recordCreated;
            this.RecordModified = recordModified;
            this.PropertyInfo = propertyInfo;
            this.GuestInfo = guestInfo;
            this.AwardList = awardList;
            this.ContactList = contactList;
            this.FacilityInfo = facilityInfo;
            this.MediaList = mediaList;
            this.Geo = geo;
            this.RefinementDate = refinementDate;
            this.Published = published;
            this.PolicyList = policyList;
            this.Uri = uri;
            this.Transaction = transaction;
            this.CancellationGracePeriod = cancellationGracePeriod;
            this.ServiceList = serviceList;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RecordCreated
        /// </summary>
        [DataMember(Name="recordCreated", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyRecordCreated RecordCreated { get; set; }

        /// <summary>
        /// Gets or Sets RecordModified
        /// </summary>
        [DataMember(Name="recordModified", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyRecordModified RecordModified { get; set; }

        /// <summary>
        /// Gets or Sets PropertyInfo
        /// </summary>
        [DataMember(Name="propertyInfo", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyPropertyInfo PropertyInfo { get; set; }

        /// <summary>
        /// Gets or Sets GuestInfo
        /// </summary>
        [DataMember(Name="guestInfo", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyGuestInfo GuestInfo { get; set; }

        /// <summary>
        /// Gets or Sets AwardList
        /// </summary>
        [DataMember(Name="awardList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyAwardListInner> AwardList { get; set; }

        /// <summary>
        /// Gets or Sets ContactList
        /// </summary>
        [DataMember(Name="contactList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyContactListInner> ContactList { get; set; }

        /// <summary>
        /// Gets or Sets FacilityInfo
        /// </summary>
        [DataMember(Name="facilityInfo", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyFacilityInfo FacilityInfo { get; set; }

        /// <summary>
        /// Gets or Sets MediaList
        /// </summary>
        [DataMember(Name="mediaList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyMediaListInner> MediaList { get; set; }

        /// <summary>
        /// Gets or Sets Geo
        /// </summary>
        [DataMember(Name="geo", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyGeo Geo { get; set; }

        /// <summary>
        /// Gets or Sets RefinementDate
        /// </summary>
        [DataMember(Name="refinementDate", EmitDefaultValue=false)]
        public decimal RefinementDate { get; set; }

        /// <summary>
        /// Gets or Sets Published
        /// </summary>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool Published { get; set; }

        /// <summary>
        /// Gets or Sets PolicyList
        /// </summary>
        [DataMember(Name="policyList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyPolicyListInner> PolicyList { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyTransaction Transaction { get; set; }

        /// <summary>
        /// Gets or Sets CancellationGracePeriod
        /// </summary>
        [DataMember(Name="cancellationGracePeriod", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyCancellationGracePeriod CancellationGracePeriod { get; set; }

        /// <summary>
        /// Gets or Sets ServiceList
        /// </summary>
        [DataMember(Name="serviceList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyServiceListInner> ServiceList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponseProperty {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecordCreated: ").Append(RecordCreated).Append("\n");
            sb.Append("  RecordModified: ").Append(RecordModified).Append("\n");
            sb.Append("  PropertyInfo: ").Append(PropertyInfo).Append("\n");
            sb.Append("  GuestInfo: ").Append(GuestInfo).Append("\n");
            sb.Append("  AwardList: ").Append(AwardList).Append("\n");
            sb.Append("  ContactList: ").Append(ContactList).Append("\n");
            sb.Append("  FacilityInfo: ").Append(FacilityInfo).Append("\n");
            sb.Append("  MediaList: ").Append(MediaList).Append("\n");
            sb.Append("  Geo: ").Append(Geo).Append("\n");
            sb.Append("  RefinementDate: ").Append(RefinementDate).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  PolicyList: ").Append(PolicyList).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  CancellationGracePeriod: ").Append(CancellationGracePeriod).Append("\n");
            sb.Append("  ServiceList: ").Append(ServiceList).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponseProperty);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponseProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponseProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponseProperty input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RecordCreated == input.RecordCreated ||
                    (this.RecordCreated != null &&
                    this.RecordCreated.Equals(input.RecordCreated))
                ) && 
                (
                    this.RecordModified == input.RecordModified ||
                    (this.RecordModified != null &&
                    this.RecordModified.Equals(input.RecordModified))
                ) && 
                (
                    this.PropertyInfo == input.PropertyInfo ||
                    (this.PropertyInfo != null &&
                    this.PropertyInfo.Equals(input.PropertyInfo))
                ) && 
                (
                    this.GuestInfo == input.GuestInfo ||
                    (this.GuestInfo != null &&
                    this.GuestInfo.Equals(input.GuestInfo))
                ) && 
                (
                    this.AwardList == input.AwardList ||
                    this.AwardList != null &&
                    input.AwardList != null &&
                    this.AwardList.SequenceEqual(input.AwardList)
                ) && 
                (
                    this.ContactList == input.ContactList ||
                    this.ContactList != null &&
                    input.ContactList != null &&
                    this.ContactList.SequenceEqual(input.ContactList)
                ) && 
                (
                    this.FacilityInfo == input.FacilityInfo ||
                    (this.FacilityInfo != null &&
                    this.FacilityInfo.Equals(input.FacilityInfo))
                ) && 
                (
                    this.MediaList == input.MediaList ||
                    this.MediaList != null &&
                    input.MediaList != null &&
                    this.MediaList.SequenceEqual(input.MediaList)
                ) && 
                (
                    this.Geo == input.Geo ||
                    (this.Geo != null &&
                    this.Geo.Equals(input.Geo))
                ) && 
                (
                    this.RefinementDate == input.RefinementDate ||
                    (this.RefinementDate != null &&
                    this.RefinementDate.Equals(input.RefinementDate))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.PolicyList == input.PolicyList ||
                    this.PolicyList != null &&
                    input.PolicyList != null &&
                    this.PolicyList.SequenceEqual(input.PolicyList)
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.CancellationGracePeriod == input.CancellationGracePeriod ||
                    (this.CancellationGracePeriod != null &&
                    this.CancellationGracePeriod.Equals(input.CancellationGracePeriod))
                ) && 
                (
                    this.ServiceList == input.ServiceList ||
                    this.ServiceList != null &&
                    input.ServiceList != null &&
                    this.ServiceList.SequenceEqual(input.ServiceList)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RecordCreated != null)
                    hashCode = hashCode * 59 + this.RecordCreated.GetHashCode();
                if (this.RecordModified != null)
                    hashCode = hashCode * 59 + this.RecordModified.GetHashCode();
                if (this.PropertyInfo != null)
                    hashCode = hashCode * 59 + this.PropertyInfo.GetHashCode();
                if (this.GuestInfo != null)
                    hashCode = hashCode * 59 + this.GuestInfo.GetHashCode();
                if (this.AwardList != null)
                    hashCode = hashCode * 59 + this.AwardList.GetHashCode();
                if (this.ContactList != null)
                    hashCode = hashCode * 59 + this.ContactList.GetHashCode();
                if (this.FacilityInfo != null)
                    hashCode = hashCode * 59 + this.FacilityInfo.GetHashCode();
                if (this.MediaList != null)
                    hashCode = hashCode * 59 + this.MediaList.GetHashCode();
                if (this.Geo != null)
                    hashCode = hashCode * 59 + this.Geo.GetHashCode();
                if (this.RefinementDate != null)
                    hashCode = hashCode * 59 + this.RefinementDate.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.PolicyList != null)
                    hashCode = hashCode * 59 + this.PolicyList.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.CancellationGracePeriod != null)
                    hashCode = hashCode * 59 + this.CancellationGracePeriod.GetHashCode();
                if (this.ServiceList != null)
                    hashCode = hashCode * 59 + this.ServiceList.GetHashCode();
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
