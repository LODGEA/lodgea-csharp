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
    /// V1PropertyGetPost200ResponsePropertyGeoDa
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyGeoDa :  IEquatable<V1PropertyGetPost200ResponsePropertyGeoDa>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyGeoDa" /> class.
        /// </summary>
        /// <param name="location">location.</param>
        /// <param name="formattedAddress">formattedAddress.</param>
        /// <param name="placeId">placeId.</param>
        /// <param name="locality">locality.</param>
        /// <param name="administrativeAreaLevel3">administrativeAreaLevel3.</param>
        /// <param name="administrativeAreaLevel1">administrativeAreaLevel1.</param>
        /// <param name="stateCode">stateCode.</param>
        /// <param name="country">country.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="language">language.</param>
        /// <param name="naturalFeature">naturalFeature.</param>
        /// <param name="establishment">establishment.</param>
        /// <param name="sublocality">sublocality.</param>
        /// <param name="sublocalityLevel1">sublocalityLevel1.</param>
        /// <param name="streetNumber">streetNumber.</param>
        /// <param name="route">route.</param>
        public V1PropertyGetPost200ResponsePropertyGeoDa(V1PropertyGetPost200ResponsePropertyGeoDeLocation location = default(V1PropertyGetPost200ResponsePropertyGeoDeLocation), string formattedAddress = default(string), string placeId = default(string), string locality = default(string), string administrativeAreaLevel3 = default(string), string administrativeAreaLevel1 = default(string), string stateCode = default(string), string country = default(string), string countryCode = default(string), string postalCode = default(string), string language = default(string), string naturalFeature = default(string), string establishment = default(string), string sublocality = default(string), string sublocalityLevel1 = default(string), string streetNumber = default(string), string route = default(string))
        {
            this.Location = location;
            this.FormattedAddress = formattedAddress;
            this.PlaceId = placeId;
            this.Locality = locality;
            this.AdministrativeAreaLevel3 = administrativeAreaLevel3;
            this.AdministrativeAreaLevel1 = administrativeAreaLevel1;
            this.StateCode = stateCode;
            this.Country = country;
            this.CountryCode = countryCode;
            this.PostalCode = postalCode;
            this.Language = language;
            this.NaturalFeature = naturalFeature;
            this.Establishment = establishment;
            this.Sublocality = sublocality;
            this.SublocalityLevel1 = sublocalityLevel1;
            this.StreetNumber = streetNumber;
            this.Route = route;
        }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyGeoDeLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets FormattedAddress
        /// </summary>
        [DataMember(Name="formatted_address", EmitDefaultValue=false)]
        public string FormattedAddress { get; set; }

        /// <summary>
        /// Gets or Sets PlaceId
        /// </summary>
        [DataMember(Name="place_id", EmitDefaultValue=false)]
        public string PlaceId { get; set; }

        /// <summary>
        /// Gets or Sets Locality
        /// </summary>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or Sets AdministrativeAreaLevel3
        /// </summary>
        [DataMember(Name="administrative_area_level_3", EmitDefaultValue=false)]
        public string AdministrativeAreaLevel3 { get; set; }

        /// <summary>
        /// Gets or Sets AdministrativeAreaLevel1
        /// </summary>
        [DataMember(Name="administrative_area_level_1", EmitDefaultValue=false)]
        public string AdministrativeAreaLevel1 { get; set; }

        /// <summary>
        /// Gets or Sets StateCode
        /// </summary>
        [DataMember(Name="state_code", EmitDefaultValue=false)]
        public string StateCode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets NaturalFeature
        /// </summary>
        [DataMember(Name="natural_feature", EmitDefaultValue=false)]
        public string NaturalFeature { get; set; }

        /// <summary>
        /// Gets or Sets Establishment
        /// </summary>
        [DataMember(Name="establishment", EmitDefaultValue=false)]
        public string Establishment { get; set; }

        /// <summary>
        /// Gets or Sets Sublocality
        /// </summary>
        [DataMember(Name="sublocality", EmitDefaultValue=false)]
        public string Sublocality { get; set; }

        /// <summary>
        /// Gets or Sets SublocalityLevel1
        /// </summary>
        [DataMember(Name="sublocality_level_1", EmitDefaultValue=false)]
        public string SublocalityLevel1 { get; set; }

        /// <summary>
        /// Gets or Sets StreetNumber
        /// </summary>
        [DataMember(Name="street_number", EmitDefaultValue=false)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Gets or Sets Route
        /// </summary>
        [DataMember(Name="route", EmitDefaultValue=false)]
        public string Route { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyGeoDa {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  FormattedAddress: ").Append(FormattedAddress).Append("\n");
            sb.Append("  PlaceId: ").Append(PlaceId).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  AdministrativeAreaLevel3: ").Append(AdministrativeAreaLevel3).Append("\n");
            sb.Append("  AdministrativeAreaLevel1: ").Append(AdministrativeAreaLevel1).Append("\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  NaturalFeature: ").Append(NaturalFeature).Append("\n");
            sb.Append("  Establishment: ").Append(Establishment).Append("\n");
            sb.Append("  Sublocality: ").Append(Sublocality).Append("\n");
            sb.Append("  SublocalityLevel1: ").Append(SublocalityLevel1).Append("\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyGeoDa);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyGeoDa instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyGeoDa to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyGeoDa input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.FormattedAddress == input.FormattedAddress ||
                    (this.FormattedAddress != null &&
                    this.FormattedAddress.Equals(input.FormattedAddress))
                ) && 
                (
                    this.PlaceId == input.PlaceId ||
                    (this.PlaceId != null &&
                    this.PlaceId.Equals(input.PlaceId))
                ) && 
                (
                    this.Locality == input.Locality ||
                    (this.Locality != null &&
                    this.Locality.Equals(input.Locality))
                ) && 
                (
                    this.AdministrativeAreaLevel3 == input.AdministrativeAreaLevel3 ||
                    (this.AdministrativeAreaLevel3 != null &&
                    this.AdministrativeAreaLevel3.Equals(input.AdministrativeAreaLevel3))
                ) && 
                (
                    this.AdministrativeAreaLevel1 == input.AdministrativeAreaLevel1 ||
                    (this.AdministrativeAreaLevel1 != null &&
                    this.AdministrativeAreaLevel1.Equals(input.AdministrativeAreaLevel1))
                ) && 
                (
                    this.StateCode == input.StateCode ||
                    (this.StateCode != null &&
                    this.StateCode.Equals(input.StateCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.NaturalFeature == input.NaturalFeature ||
                    (this.NaturalFeature != null &&
                    this.NaturalFeature.Equals(input.NaturalFeature))
                ) && 
                (
                    this.Establishment == input.Establishment ||
                    (this.Establishment != null &&
                    this.Establishment.Equals(input.Establishment))
                ) && 
                (
                    this.Sublocality == input.Sublocality ||
                    (this.Sublocality != null &&
                    this.Sublocality.Equals(input.Sublocality))
                ) && 
                (
                    this.SublocalityLevel1 == input.SublocalityLevel1 ||
                    (this.SublocalityLevel1 != null &&
                    this.SublocalityLevel1.Equals(input.SublocalityLevel1))
                ) && 
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                    this.StreetNumber.Equals(input.StreetNumber))
                ) && 
                (
                    this.Route == input.Route ||
                    (this.Route != null &&
                    this.Route.Equals(input.Route))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.FormattedAddress != null)
                    hashCode = hashCode * 59 + this.FormattedAddress.GetHashCode();
                if (this.PlaceId != null)
                    hashCode = hashCode * 59 + this.PlaceId.GetHashCode();
                if (this.Locality != null)
                    hashCode = hashCode * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeAreaLevel3 != null)
                    hashCode = hashCode * 59 + this.AdministrativeAreaLevel3.GetHashCode();
                if (this.AdministrativeAreaLevel1 != null)
                    hashCode = hashCode * 59 + this.AdministrativeAreaLevel1.GetHashCode();
                if (this.StateCode != null)
                    hashCode = hashCode * 59 + this.StateCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.NaturalFeature != null)
                    hashCode = hashCode * 59 + this.NaturalFeature.GetHashCode();
                if (this.Establishment != null)
                    hashCode = hashCode * 59 + this.Establishment.GetHashCode();
                if (this.Sublocality != null)
                    hashCode = hashCode * 59 + this.Sublocality.GetHashCode();
                if (this.SublocalityLevel1 != null)
                    hashCode = hashCode * 59 + this.SublocalityLevel1.GetHashCode();
                if (this.StreetNumber != null)
                    hashCode = hashCode * 59 + this.StreetNumber.GetHashCode();
                if (this.Route != null)
                    hashCode = hashCode * 59 + this.Route.GetHashCode();
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
