/*
 * lodgea-csharp
 *
 * LODGEA SDK for csharp. Check out https://docs.lodgea.io for more information.
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
    /// LocationSearchPost200Response
    /// </summary>
    [DataContract]
    public partial class LocationSearchPost200Response :  IEquatable<LocationSearchPost200Response>, IValidatableObject
    {
        /// <summary>
        /// The language code of the language in which the descriptive texts for each found location are returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The language code of the language in which the descriptive texts for each found location are returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LanguageCodeEnum
        {
            /// <summary>
            /// Enum Af for value: af
            /// </summary>
            [EnumMember(Value = "af")]
            Af = 1,

            /// <summary>
            /// Enum Ar for value: ar
            /// </summary>
            [EnumMember(Value = "ar")]
            Ar = 2,

            /// <summary>
            /// Enum Bg for value: bg
            /// </summary>
            [EnumMember(Value = "bg")]
            Bg = 3,

            /// <summary>
            /// Enum Ca for value: ca
            /// </summary>
            [EnumMember(Value = "ca")]
            Ca = 4,

            /// <summary>
            /// Enum Cs for value: cs
            /// </summary>
            [EnumMember(Value = "cs")]
            Cs = 5,

            /// <summary>
            /// Enum Da for value: da
            /// </summary>
            [EnumMember(Value = "da")]
            Da = 6,

            /// <summary>
            /// Enum De for value: de
            /// </summary>
            [EnumMember(Value = "de")]
            De = 7,

            /// <summary>
            /// Enum El for value: el
            /// </summary>
            [EnumMember(Value = "el")]
            El = 8,

            /// <summary>
            /// Enum En for value: en
            /// </summary>
            [EnumMember(Value = "en")]
            En = 9,

            /// <summary>
            /// Enum Es for value: es
            /// </summary>
            [EnumMember(Value = "es")]
            Es = 10,

            /// <summary>
            /// Enum Et for value: et
            /// </summary>
            [EnumMember(Value = "et")]
            Et = 11,

            /// <summary>
            /// Enum Fi for value: fi
            /// </summary>
            [EnumMember(Value = "fi")]
            Fi = 12,

            /// <summary>
            /// Enum Fr for value: fr
            /// </summary>
            [EnumMember(Value = "fr")]
            Fr = 13,

            /// <summary>
            /// Enum He for value: he
            /// </summary>
            [EnumMember(Value = "he")]
            He = 14,

            /// <summary>
            /// Enum Hi for value: hi
            /// </summary>
            [EnumMember(Value = "hi")]
            Hi = 15,

            /// <summary>
            /// Enum Hr for value: hr
            /// </summary>
            [EnumMember(Value = "hr")]
            Hr = 16,

            /// <summary>
            /// Enum Hu for value: hu
            /// </summary>
            [EnumMember(Value = "hu")]
            Hu = 17,

            /// <summary>
            /// Enum Id for value: id
            /// </summary>
            [EnumMember(Value = "id")]
            Id = 18,

            /// <summary>
            /// Enum Is for value: is
            /// </summary>
            [EnumMember(Value = "is")]
            Is = 19,

            /// <summary>
            /// Enum It for value: it
            /// </summary>
            [EnumMember(Value = "it")]
            It = 20,

            /// <summary>
            /// Enum Ja for value: ja
            /// </summary>
            [EnumMember(Value = "ja")]
            Ja = 21,

            /// <summary>
            /// Enum Ko for value: ko
            /// </summary>
            [EnumMember(Value = "ko")]
            Ko = 22,

            /// <summary>
            /// Enum Lt for value: lt
            /// </summary>
            [EnumMember(Value = "lt")]
            Lt = 23,

            /// <summary>
            /// Enum Lv for value: lv
            /// </summary>
            [EnumMember(Value = "lv")]
            Lv = 24,

            /// <summary>
            /// Enum Nl for value: nl
            /// </summary>
            [EnumMember(Value = "nl")]
            Nl = 25,

            /// <summary>
            /// Enum No for value: no
            /// </summary>
            [EnumMember(Value = "no")]
            No = 26,

            /// <summary>
            /// Enum Pl for value: pl
            /// </summary>
            [EnumMember(Value = "pl")]
            Pl = 27,

            /// <summary>
            /// Enum Pt for value: pt
            /// </summary>
            [EnumMember(Value = "pt")]
            Pt = 28,

            /// <summary>
            /// Enum Ro for value: ro
            /// </summary>
            [EnumMember(Value = "ro")]
            Ro = 29,

            /// <summary>
            /// Enum Ru for value: ru
            /// </summary>
            [EnumMember(Value = "ru")]
            Ru = 30,

            /// <summary>
            /// Enum Sk for value: sk
            /// </summary>
            [EnumMember(Value = "sk")]
            Sk = 31,

            /// <summary>
            /// Enum Sl for value: sl
            /// </summary>
            [EnumMember(Value = "sl")]
            Sl = 32,

            /// <summary>
            /// Enum Sr for value: sr
            /// </summary>
            [EnumMember(Value = "sr")]
            Sr = 33,

            /// <summary>
            /// Enum Sv for value: sv
            /// </summary>
            [EnumMember(Value = "sv")]
            Sv = 34,

            /// <summary>
            /// Enum Th for value: th
            /// </summary>
            [EnumMember(Value = "th")]
            Th = 35,

            /// <summary>
            /// Enum Tr for value: tr
            /// </summary>
            [EnumMember(Value = "tr")]
            Tr = 36,

            /// <summary>
            /// Enum Vi for value: vi
            /// </summary>
            [EnumMember(Value = "vi")]
            Vi = 37,

            /// <summary>
            /// Enum Zh for value: zh
            /// </summary>
            [EnumMember(Value = "zh")]
            Zh = 38

        }

        /// <summary>
        /// The language code of the language in which the descriptive texts for each found location are returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The language code of the language in which the descriptive texts for each found location are returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="languageCode", EmitDefaultValue=true)]
        public LanguageCodeEnum LanguageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationSearchPost200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocationSearchPost200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationSearchPost200Response" /> class.
        /// </summary>
        /// <param name="languageCode">The language code of the language in which the descriptive texts for each found location are returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; (required).</param>
        /// <param name="list">A list of available properties matching the given criteria. (required).</param>
        public LocationSearchPost200Response(LanguageCodeEnum languageCode = default(LanguageCodeEnum), List<AvailablePropertiesInner> list = default(List<AvailablePropertiesInner>))
        {
            // to ensure "languageCode" is required (not null)
            if (languageCode == null)
            {
                throw new InvalidDataException("languageCode is a required property for LocationSearchPost200Response and cannot be null");
            }
            else
            {
                this.LanguageCode = languageCode;
            }

            // to ensure "list" is required (not null)
            if (list == null)
            {
                throw new InvalidDataException("list is a required property for LocationSearchPost200Response and cannot be null");
            }
            else
            {
                this.List = list;
            }

        }


        /// <summary>
        /// A list of available properties matching the given criteria.
        /// </summary>
        /// <value>A list of available properties matching the given criteria.</value>
        [DataMember(Name="list", EmitDefaultValue=true)]
        public List<AvailablePropertiesInner> List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationSearchPost200Response {\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
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
            return this.Equals(input as LocationSearchPost200Response);
        }

        /// <summary>
        /// Returns true if LocationSearchPost200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationSearchPost200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationSearchPost200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
                ) && 
                (
                    this.List == input.List ||
                    this.List != null &&
                    input.List != null &&
                    this.List.SequenceEqual(input.List)
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
                if (this.LanguageCode != null)
                    hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
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
