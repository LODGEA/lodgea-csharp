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
    /// PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner
    /// </summary>
    [DataContract]
    public partial class PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner :  IEquatable<PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner>, IValidatableObject
    {
        /// <summary>
        /// The code that represents the type of tax.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#taxtype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The code that represents the type of tax.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#taxtype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeCodeEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 1,

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 2,

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 3,

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 4,

            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 5,

            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 6,

            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 7,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 8,

            /// <summary>
            /// Enum _13 for value: 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13 = 9,

            /// <summary>
            /// Enum _15 for value: 15
            /// </summary>
            [EnumMember(Value = "15")]
            _15 = 10,

            /// <summary>
            /// Enum _17 for value: 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17 = 11,

            /// <summary>
            /// Enum _18 for value: 18
            /// </summary>
            [EnumMember(Value = "18")]
            _18 = 12,

            /// <summary>
            /// Enum _19 for value: 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19 = 13,

            /// <summary>
            /// Enum _28 for value: 28
            /// </summary>
            [EnumMember(Value = "28")]
            _28 = 14,

            /// <summary>
            /// Enum _30 for value: 30
            /// </summary>
            [EnumMember(Value = "30")]
            _30 = 15,

            /// <summary>
            /// Enum _35 for value: 35
            /// </summary>
            [EnumMember(Value = "35")]
            _35 = 16,

            /// <summary>
            /// Enum _36 for value: 36
            /// </summary>
            [EnumMember(Value = "36")]
            _36 = 17,

            /// <summary>
            /// Enum _39 for value: 39
            /// </summary>
            [EnumMember(Value = "39")]
            _39 = 18,

            /// <summary>
            /// Enum _43 for value: 43
            /// </summary>
            [EnumMember(Value = "43")]
            _43 = 19,

            /// <summary>
            /// Enum _46 for value: 46
            /// </summary>
            [EnumMember(Value = "46")]
            _46 = 20,

            /// <summary>
            /// Enum _5001 for value: 5001
            /// </summary>
            [EnumMember(Value = "5001")]
            _5001 = 21,

            /// <summary>
            /// Enum _5002 for value: 5002
            /// </summary>
            [EnumMember(Value = "5002")]
            _5002 = 22,

            /// <summary>
            /// Enum _5004 for value: 5004
            /// </summary>
            [EnumMember(Value = "5004")]
            _5004 = 23,

            /// <summary>
            /// Enum _5007 for value: 5007
            /// </summary>
            [EnumMember(Value = "5007")]
            _5007 = 24,

            /// <summary>
            /// Enum _5008 for value: 5008
            /// </summary>
            [EnumMember(Value = "5008")]
            _5008 = 25

        }

        /// <summary>
        /// The code that represents the type of tax.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#taxtype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The code that represents the type of tax.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#taxtype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="typeCode", EmitDefaultValue=true)]
        public TypeCodeEnum TypeCode { get; set; }
        /// <summary>
        /// The type of charge.
        /// </summary>
        /// <value>The type of charge.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChargeTypeEnum
        {
            /// <summary>
            /// Enum Included for value: included
            /// </summary>
            [EnumMember(Value = "included")]
            Included = 1,

            /// <summary>
            /// Enum Excluded for value: excluded
            /// </summary>
            [EnumMember(Value = "excluded")]
            Excluded = 2,

            /// <summary>
            /// Enum Conditional for value: conditional
            /// </summary>
            [EnumMember(Value = "conditional")]
            Conditional = 3

        }

        /// <summary>
        /// The type of charge.
        /// </summary>
        /// <value>The type of charge.</value>
        [DataMember(Name="chargeType", EmitDefaultValue=true)]
        public ChargeTypeEnum ChargeType { get; set; }
        /// <summary>
        /// The code that represents the frequency of charge.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#chargetype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The code that represents the frequency of charge.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#chargetype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChargeFrequencyCodeEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            _1 = 1,

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            _2 = 2,

            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 3,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 4,

            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12 = 5,

            /// <summary>
            /// Enum _17 for value: 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17 = 6,

            /// <summary>
            /// Enum _19 for value: 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19 = 7,

            /// <summary>
            /// Enum _20 for value: 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20 = 8,

            /// <summary>
            /// Enum _21 for value: 21
            /// </summary>
            [EnumMember(Value = "21")]
            _21 = 9,

            /// <summary>
            /// Enum _25 for value: 25
            /// </summary>
            [EnumMember(Value = "25")]
            _25 = 10,

            /// <summary>
            /// Enum _31 for value: 31
            /// </summary>
            [EnumMember(Value = "31")]
            _31 = 11,

            /// <summary>
            /// Enum _5000 for value: 5000
            /// </summary>
            [EnumMember(Value = "5000")]
            _5000 = 12,

            /// <summary>
            /// Enum _5001 for value: 5001
            /// </summary>
            [EnumMember(Value = "5001")]
            _5001 = 13,

            /// <summary>
            /// Enum _5002 for value: 5002
            /// </summary>
            [EnumMember(Value = "5002")]
            _5002 = 14,

            /// <summary>
            /// Enum _5010 for value: 5010
            /// </summary>
            [EnumMember(Value = "5010")]
            _5010 = 15,

            /// <summary>
            /// Enum _5011 for value: 5011
            /// </summary>
            [EnumMember(Value = "5011")]
            _5011 = 16,

            /// <summary>
            /// Enum _5012 for value: 5012
            /// </summary>
            [EnumMember(Value = "5012")]
            _5012 = 17,

            /// <summary>
            /// Enum _5013 for value: 5013
            /// </summary>
            [EnumMember(Value = "5013")]
            _5013 = 18,

            /// <summary>
            /// Enum _5014 for value: 5014
            /// </summary>
            [EnumMember(Value = "5014")]
            _5014 = 19,

            /// <summary>
            /// Enum _5015 for value: 5015
            /// </summary>
            [EnumMember(Value = "5015")]
            _5015 = 20,

            /// <summary>
            /// Enum _5016 for value: 5016
            /// </summary>
            [EnumMember(Value = "5016")]
            _5016 = 21,

            /// <summary>
            /// Enum _5017 for value: 5017
            /// </summary>
            [EnumMember(Value = "5017")]
            _5017 = 22,

            /// <summary>
            /// Enum _90010 for value: 90010
            /// </summary>
            [EnumMember(Value = "90010")]
            _90010 = 23,

            /// <summary>
            /// Enum _90011 for value: 90011
            /// </summary>
            [EnumMember(Value = "90011")]
            _90011 = 24,

            /// <summary>
            /// Enum _90012 for value: 90012
            /// </summary>
            [EnumMember(Value = "90012")]
            _90012 = 25,

            /// <summary>
            /// Enum _90013 for value: 90013
            /// </summary>
            [EnumMember(Value = "90013")]
            _90013 = 26

        }

        /// <summary>
        /// The code that represents the frequency of charge.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#chargetype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The code that represents the frequency of charge.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#chargetype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="chargeFrequencyCode", EmitDefaultValue=true)]
        public ChargeFrequencyCodeEnum ChargeFrequencyCode { get; set; }
        /// <summary>
        /// The currency code of the currency in that the charge is applied.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The currency code of the currency in that the charge is applied.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
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
        /// The currency code of the currency in that the charge is applied.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The currency code of the currency in that the charge is applied.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=true)]
        public CurrencyCodeEnum CurrencyCode { get; set; }
        /// <summary>
        /// Defines ConditionList
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConditionListEnum
        {
            /// <summary>
            /// Enum Bringspet for value: guest_brings_pet
            /// </summary>
            [EnumMember(Value = "guest_brings_pet")]
            Bringspet = 1,

            /// <summary>
            /// Enum Doesntcleanbeforecheckout for value: guest_doesnt_clean_before_checkout
            /// </summary>
            [EnumMember(Value = "guest_doesnt_clean_before_checkout")]
            Doesntcleanbeforecheckout = 2,

            /// <summary>
            /// Enum Smokes for value: guest_smokes
            /// </summary>
            [EnumMember(Value = "guest_smokes")]
            Smokes = 3

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner" /> class.
        /// </summary>
        /// <param name="typeCode">The code that represents the type of tax.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#taxtype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; (required).</param>
        /// <param name="percent">The charged percentage if applicable..</param>
        /// <param name="chargeType">The type of charge. (required).</param>
        /// <param name="chargeFrequencyCode">The code that represents the frequency of charge.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#chargetype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; (required).</param>
        /// <param name="currencyCode">The currency code of the currency in that the charge is applied.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; (required).</param>
        /// <param name="conditionList">A list of conditions for the tax. Is empty if &lt;code&gt;chargeType&lt;/code&gt; is not &lt;code&gt;conditional&lt;/code&gt;. (required).</param>
        public PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner(TypeCodeEnum typeCode = default(TypeCodeEnum), decimal percent = default(decimal), ChargeTypeEnum chargeType = default(ChargeTypeEnum), ChargeFrequencyCodeEnum chargeFrequencyCode = default(ChargeFrequencyCodeEnum), CurrencyCodeEnum currencyCode = default(CurrencyCodeEnum), List<ConditionListEnum> conditionList = default(List<ConditionListEnum>))
        {
            // to ensure "typeCode" is required (not null)
            if (typeCode == null)
            {
                throw new InvalidDataException("typeCode is a required property for PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner and cannot be null");
            }
            else
            {
                this.TypeCode = typeCode;
            }

            // to ensure "chargeType" is required (not null)
            if (chargeType == null)
            {
                throw new InvalidDataException("chargeType is a required property for PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner and cannot be null");
            }
            else
            {
                this.ChargeType = chargeType;
            }

            // to ensure "chargeFrequencyCode" is required (not null)
            if (chargeFrequencyCode == null)
            {
                throw new InvalidDataException("chargeFrequencyCode is a required property for PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner and cannot be null");
            }
            else
            {
                this.ChargeFrequencyCode = chargeFrequencyCode;
            }

            // to ensure "currencyCode" is required (not null)
            if (currencyCode == null)
            {
                throw new InvalidDataException("currencyCode is a required property for PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner and cannot be null");
            }
            else
            {
                this.CurrencyCode = currencyCode;
            }

            // to ensure "conditionList" is required (not null)
            if (conditionList == null)
            {
                throw new InvalidDataException("conditionList is a required property for PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner and cannot be null");
            }
            else
            {
                this.ConditionList = conditionList;
            }

            this.Percent = percent;
        }


        /// <summary>
        /// The charged percentage if applicable.
        /// </summary>
        /// <value>The charged percentage if applicable.</value>
        [DataMember(Name="percent", EmitDefaultValue=false)]
        public decimal Percent { get; set; }




        /// <summary>
        /// A list of conditions for the tax. Is empty if &lt;code&gt;chargeType&lt;/code&gt; is not &lt;code&gt;conditional&lt;/code&gt;.
        /// </summary>
        /// <value>A list of conditions for the tax. Is empty if &lt;code&gt;chargeType&lt;/code&gt; is not &lt;code&gt;conditional&lt;/code&gt;.</value>
        [DataMember(Name="conditionList", EmitDefaultValue=true)]
        public List<PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner.ConditionListEnum> ConditionList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner {\n");
            sb.Append("  TypeCode: ").Append(TypeCode).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  ChargeFrequencyCode: ").Append(ChargeFrequencyCode).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  ConditionList: ").Append(ConditionList).Append("\n");
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
            return this.Equals(input as PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner);
        }

        /// <summary>
        /// Returns true if PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TypeCode == input.TypeCode ||
                    (this.TypeCode != null &&
                    this.TypeCode.Equals(input.TypeCode))
                ) && 
                (
                    this.Percent == input.Percent ||
                    (this.Percent != null &&
                    this.Percent.Equals(input.Percent))
                ) && 
                (
                    this.ChargeType == input.ChargeType ||
                    (this.ChargeType != null &&
                    this.ChargeType.Equals(input.ChargeType))
                ) && 
                (
                    this.ChargeFrequencyCode == input.ChargeFrequencyCode ||
                    (this.ChargeFrequencyCode != null &&
                    this.ChargeFrequencyCode.Equals(input.ChargeFrequencyCode))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.ConditionList == input.ConditionList ||
                    this.ConditionList != null &&
                    input.ConditionList != null &&
                    this.ConditionList.SequenceEqual(input.ConditionList)
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
                if (this.TypeCode != null)
                    hashCode = hashCode * 59 + this.TypeCode.GetHashCode();
                if (this.Percent != null)
                    hashCode = hashCode * 59 + this.Percent.GetHashCode();
                if (this.ChargeType != null)
                    hashCode = hashCode * 59 + this.ChargeType.GetHashCode();
                if (this.ChargeFrequencyCode != null)
                    hashCode = hashCode * 59 + this.ChargeFrequencyCode.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.ConditionList != null)
                    hashCode = hashCode * 59 + this.ConditionList.GetHashCode();
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
