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
    /// LocationSearchPostRequest
    /// </summary>
    [DataContract]
    public partial class LocationSearchPostRequest :  IEquatable<LocationSearchPostRequest>, IValidatableObject
    {
        /// <summary>
        /// The currency code of the currency in which the lowest price for each found location should be returned.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The currency code of the currency in which the lowest price for each found location should be returned.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyCodeEnum
        {
            /// <summary>
            /// Enum AED for value: AED
            /// </summary>
            [EnumMember(Value = "AED")]
            AED = 1,

            /// <summary>
            /// Enum ARS for value: ARS
            /// </summary>
            [EnumMember(Value = "ARS")]
            ARS = 2,

            /// <summary>
            /// Enum AUD for value: AUD
            /// </summary>
            [EnumMember(Value = "AUD")]
            AUD = 3,

            /// <summary>
            /// Enum AZN for value: AZN
            /// </summary>
            [EnumMember(Value = "AZN")]
            AZN = 4,

            /// <summary>
            /// Enum BGN for value: BGN
            /// </summary>
            [EnumMember(Value = "BGN")]
            BGN = 5,

            /// <summary>
            /// Enum BHD for value: BHD
            /// </summary>
            [EnumMember(Value = "BHD")]
            BHD = 6,

            /// <summary>
            /// Enum BRL for value: BRL
            /// </summary>
            [EnumMember(Value = "BRL")]
            BRL = 7,

            /// <summary>
            /// Enum CAD for value: CAD
            /// </summary>
            [EnumMember(Value = "CAD")]
            CAD = 8,

            /// <summary>
            /// Enum CHF for value: CHF
            /// </summary>
            [EnumMember(Value = "CHF")]
            CHF = 9,

            /// <summary>
            /// Enum CLP for value: CLP
            /// </summary>
            [EnumMember(Value = "CLP")]
            CLP = 10,

            /// <summary>
            /// Enum CNY for value: CNY
            /// </summary>
            [EnumMember(Value = "CNY")]
            CNY = 11,

            /// <summary>
            /// Enum COP for value: COP
            /// </summary>
            [EnumMember(Value = "COP")]
            COP = 12,

            /// <summary>
            /// Enum CZK for value: CZK
            /// </summary>
            [EnumMember(Value = "CZK")]
            CZK = 13,

            /// <summary>
            /// Enum DKK for value: DKK
            /// </summary>
            [EnumMember(Value = "DKK")]
            DKK = 14,

            /// <summary>
            /// Enum EGP for value: EGP
            /// </summary>
            [EnumMember(Value = "EGP")]
            EGP = 15,

            /// <summary>
            /// Enum EUR for value: EUR
            /// </summary>
            [EnumMember(Value = "EUR")]
            EUR = 16,

            /// <summary>
            /// Enum FJD for value: FJD
            /// </summary>
            [EnumMember(Value = "FJD")]
            FJD = 17,

            /// <summary>
            /// Enum GBP for value: GBP
            /// </summary>
            [EnumMember(Value = "GBP")]
            GBP = 18,

            /// <summary>
            /// Enum GEL for value: GEL
            /// </summary>
            [EnumMember(Value = "GEL")]
            GEL = 19,

            /// <summary>
            /// Enum HKD for value: HKD
            /// </summary>
            [EnumMember(Value = "HKD")]
            HKD = 20,

            /// <summary>
            /// Enum HUF for value: HUF
            /// </summary>
            [EnumMember(Value = "HUF")]
            HUF = 21,

            /// <summary>
            /// Enum IDR for value: IDR
            /// </summary>
            [EnumMember(Value = "IDR")]
            IDR = 22,

            /// <summary>
            /// Enum ILS for value: ILS
            /// </summary>
            [EnumMember(Value = "ILS")]
            ILS = 23,

            /// <summary>
            /// Enum INR for value: INR
            /// </summary>
            [EnumMember(Value = "INR")]
            INR = 24,

            /// <summary>
            /// Enum JOD for value: JOD
            /// </summary>
            [EnumMember(Value = "JOD")]
            JOD = 25,

            /// <summary>
            /// Enum JPY for value: JPY
            /// </summary>
            [EnumMember(Value = "JPY")]
            JPY = 26,

            /// <summary>
            /// Enum KRW for value: KRW
            /// </summary>
            [EnumMember(Value = "KRW")]
            KRW = 27,

            /// <summary>
            /// Enum KWD for value: KWD
            /// </summary>
            [EnumMember(Value = "KWD")]
            KWD = 28,

            /// <summary>
            /// Enum KZT for value: KZT
            /// </summary>
            [EnumMember(Value = "KZT")]
            KZT = 29,

            /// <summary>
            /// Enum MDL for value: MDL
            /// </summary>
            [EnumMember(Value = "MDL")]
            MDL = 30,

            /// <summary>
            /// Enum MXN for value: MXN
            /// </summary>
            [EnumMember(Value = "MXN")]
            MXN = 31,

            /// <summary>
            /// Enum MYR for value: MYR
            /// </summary>
            [EnumMember(Value = "MYR")]
            MYR = 32,

            /// <summary>
            /// Enum NAD for value: NAD
            /// </summary>
            [EnumMember(Value = "NAD")]
            NAD = 33,

            /// <summary>
            /// Enum NOK for value: NOK
            /// </summary>
            [EnumMember(Value = "NOK")]
            NOK = 34,

            /// <summary>
            /// Enum NZD for value: NZD
            /// </summary>
            [EnumMember(Value = "NZD")]
            NZD = 35,

            /// <summary>
            /// Enum OMR for value: OMR
            /// </summary>
            [EnumMember(Value = "OMR")]
            OMR = 36,

            /// <summary>
            /// Enum PLN for value: PLN
            /// </summary>
            [EnumMember(Value = "PLN")]
            PLN = 37,

            /// <summary>
            /// Enum QAR for value: QAR
            /// </summary>
            [EnumMember(Value = "QAR")]
            QAR = 38,

            /// <summary>
            /// Enum RON for value: RON
            /// </summary>
            [EnumMember(Value = "RON")]
            RON = 39,

            /// <summary>
            /// Enum RUB for value: RUB
            /// </summary>
            [EnumMember(Value = "RUB")]
            RUB = 40,

            /// <summary>
            /// Enum SAR for value: SAR
            /// </summary>
            [EnumMember(Value = "SAR")]
            SAR = 41,

            /// <summary>
            /// Enum SEK for value: SEK
            /// </summary>
            [EnumMember(Value = "SEK")]
            SEK = 42,

            /// <summary>
            /// Enum SGD for value: SGD
            /// </summary>
            [EnumMember(Value = "SGD")]
            SGD = 43,

            /// <summary>
            /// Enum THB for value: THB
            /// </summary>
            [EnumMember(Value = "THB")]
            THB = 44,

            /// <summary>
            /// Enum TRY for value: TRY
            /// </summary>
            [EnumMember(Value = "TRY")]
            TRY = 45,

            /// <summary>
            /// Enum TWD for value: TWD
            /// </summary>
            [EnumMember(Value = "TWD")]
            TWD = 46,

            /// <summary>
            /// Enum UAH for value: UAH
            /// </summary>
            [EnumMember(Value = "UAH")]
            UAH = 47,

            /// <summary>
            /// Enum USD for value: USD
            /// </summary>
            [EnumMember(Value = "USD")]
            USD = 48,

            /// <summary>
            /// Enum XOF for value: XOF
            /// </summary>
            [EnumMember(Value = "XOF")]
            XOF = 49,

            /// <summary>
            /// Enum ZAR for value: ZAR
            /// </summary>
            [EnumMember(Value = "ZAR")]
            ZAR = 50

        }

        /// <summary>
        /// The currency code of the currency in which the lowest price for each found location should be returned.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The currency code of the currency in which the lowest price for each found location should be returned.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=true)]
        public CurrencyCodeEnum CurrencyCode { get; set; }
        /// <summary>
        /// The language code of the language in which the descriptive texts for each found location should be returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The language code of the language in which the descriptive texts for each found location should be returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
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
        /// The language code of the language in which the descriptive texts for each found location should be returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The language code of the language in which the descriptive texts for each found location should be returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="languageCode", EmitDefaultValue=true)]
        public LanguageCodeEnum LanguageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationSearchPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocationSearchPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationSearchPostRequest" /> class.
        /// </summary>
        /// <param name="searchText">A search text in free form to search locations by. (required).</param>
        /// <param name="currencyCode">The currency code of the currency in which the lowest price for each found location should be returned.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; (required).</param>
        /// <param name="languageCode">The language code of the language in which the descriptive texts for each found location should be returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; (required).</param>
        public LocationSearchPostRequest(string searchText = default(string), CurrencyCodeEnum currencyCode = default(CurrencyCodeEnum), LanguageCodeEnum languageCode = default(LanguageCodeEnum))
        {
            // to ensure "searchText" is required (not null)
            if (searchText == null)
            {
                throw new InvalidDataException("searchText is a required property for LocationSearchPostRequest and cannot be null");
            }
            else
            {
                this.SearchText = searchText;
            }

            // to ensure "currencyCode" is required (not null)
            if (currencyCode == null)
            {
                throw new InvalidDataException("currencyCode is a required property for LocationSearchPostRequest and cannot be null");
            }
            else
            {
                this.CurrencyCode = currencyCode;
            }

            // to ensure "languageCode" is required (not null)
            if (languageCode == null)
            {
                throw new InvalidDataException("languageCode is a required property for LocationSearchPostRequest and cannot be null");
            }
            else
            {
                this.LanguageCode = languageCode;
            }

        }

        /// <summary>
        /// A search text in free form to search locations by.
        /// </summary>
        /// <value>A search text in free form to search locations by.</value>
        [DataMember(Name="searchText", EmitDefaultValue=true)]
        public string SearchText { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationSearchPostRequest {\n");
            sb.Append("  SearchText: ").Append(SearchText).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
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
            return this.Equals(input as LocationSearchPostRequest);
        }

        /// <summary>
        /// Returns true if LocationSearchPostRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationSearchPostRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationSearchPostRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchText == input.SearchText ||
                    (this.SearchText != null &&
                    this.SearchText.Equals(input.SearchText))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
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
                if (this.SearchText != null)
                    hashCode = hashCode * 59 + this.SearchText.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.LanguageCode != null)
                    hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
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
