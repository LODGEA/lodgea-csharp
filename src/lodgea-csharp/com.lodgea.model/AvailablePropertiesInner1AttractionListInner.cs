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
    /// AvailablePropertiesInner1AttractionListInner
    /// </summary>
    [DataContract]
    public partial class AvailablePropertiesInner1AttractionListInner :  IEquatable<AvailablePropertiesInner1AttractionListInner>, IValidatableObject
    {
        /// <summary>
        /// The code for this attraction type.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#attractioncategory-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The code for this attraction type.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#attractioncategory-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeCodeEnum
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
            /// Enum _3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            _3 = 3,

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            _4 = 4,

            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            [EnumMember(Value = "5")]
            _5 = 5,

            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            [EnumMember(Value = "6")]
            _6 = 6,

            /// <summary>
            /// Enum _7 for value: 7
            /// </summary>
            [EnumMember(Value = "7")]
            _7 = 7,

            /// <summary>
            /// Enum _8 for value: 8
            /// </summary>
            [EnumMember(Value = "8")]
            _8 = 8,

            /// <summary>
            /// Enum _9 for value: 9
            /// </summary>
            [EnumMember(Value = "9")]
            _9 = 9,

            /// <summary>
            /// Enum _10 for value: 10
            /// </summary>
            [EnumMember(Value = "10")]
            _10 = 10,

            /// <summary>
            /// Enum _11 for value: 11
            /// </summary>
            [EnumMember(Value = "11")]
            _11 = 11,

            /// <summary>
            /// Enum _12 for value: 12
            /// </summary>
            [EnumMember(Value = "12")]
            _12 = 12,

            /// <summary>
            /// Enum _13 for value: 13
            /// </summary>
            [EnumMember(Value = "13")]
            _13 = 13,

            /// <summary>
            /// Enum _14 for value: 14
            /// </summary>
            [EnumMember(Value = "14")]
            _14 = 14,

            /// <summary>
            /// Enum _15 for value: 15
            /// </summary>
            [EnumMember(Value = "15")]
            _15 = 15,

            /// <summary>
            /// Enum _16 for value: 16
            /// </summary>
            [EnumMember(Value = "16")]
            _16 = 16,

            /// <summary>
            /// Enum _17 for value: 17
            /// </summary>
            [EnumMember(Value = "17")]
            _17 = 17,

            /// <summary>
            /// Enum _18 for value: 18
            /// </summary>
            [EnumMember(Value = "18")]
            _18 = 18,

            /// <summary>
            /// Enum _19 for value: 19
            /// </summary>
            [EnumMember(Value = "19")]
            _19 = 19,

            /// <summary>
            /// Enum _20 for value: 20
            /// </summary>
            [EnumMember(Value = "20")]
            _20 = 20,

            /// <summary>
            /// Enum _21 for value: 21
            /// </summary>
            [EnumMember(Value = "21")]
            _21 = 21,

            /// <summary>
            /// Enum _22 for value: 22
            /// </summary>
            [EnumMember(Value = "22")]
            _22 = 22,

            /// <summary>
            /// Enum _23 for value: 23
            /// </summary>
            [EnumMember(Value = "23")]
            _23 = 23,

            /// <summary>
            /// Enum _24 for value: 24
            /// </summary>
            [EnumMember(Value = "24")]
            _24 = 24,

            /// <summary>
            /// Enum _25 for value: 25
            /// </summary>
            [EnumMember(Value = "25")]
            _25 = 25,

            /// <summary>
            /// Enum _26 for value: 26
            /// </summary>
            [EnumMember(Value = "26")]
            _26 = 26,

            /// <summary>
            /// Enum _27 for value: 27
            /// </summary>
            [EnumMember(Value = "27")]
            _27 = 27,

            /// <summary>
            /// Enum _28 for value: 28
            /// </summary>
            [EnumMember(Value = "28")]
            _28 = 28,

            /// <summary>
            /// Enum _29 for value: 29
            /// </summary>
            [EnumMember(Value = "29")]
            _29 = 29,

            /// <summary>
            /// Enum _30 for value: 30
            /// </summary>
            [EnumMember(Value = "30")]
            _30 = 30,

            /// <summary>
            /// Enum _31 for value: 31
            /// </summary>
            [EnumMember(Value = "31")]
            _31 = 31,

            /// <summary>
            /// Enum _32 for value: 32
            /// </summary>
            [EnumMember(Value = "32")]
            _32 = 32,

            /// <summary>
            /// Enum _33 for value: 33
            /// </summary>
            [EnumMember(Value = "33")]
            _33 = 33,

            /// <summary>
            /// Enum _34 for value: 34
            /// </summary>
            [EnumMember(Value = "34")]
            _34 = 34,

            /// <summary>
            /// Enum _35 for value: 35
            /// </summary>
            [EnumMember(Value = "35")]
            _35 = 35,

            /// <summary>
            /// Enum _36 for value: 36
            /// </summary>
            [EnumMember(Value = "36")]
            _36 = 36,

            /// <summary>
            /// Enum _37 for value: 37
            /// </summary>
            [EnumMember(Value = "37")]
            _37 = 37,

            /// <summary>
            /// Enum _38 for value: 38
            /// </summary>
            [EnumMember(Value = "38")]
            _38 = 38,

            /// <summary>
            /// Enum _39 for value: 39
            /// </summary>
            [EnumMember(Value = "39")]
            _39 = 39,

            /// <summary>
            /// Enum _40 for value: 40
            /// </summary>
            [EnumMember(Value = "40")]
            _40 = 40,

            /// <summary>
            /// Enum _41 for value: 41
            /// </summary>
            [EnumMember(Value = "41")]
            _41 = 41,

            /// <summary>
            /// Enum _42 for value: 42
            /// </summary>
            [EnumMember(Value = "42")]
            _42 = 42,

            /// <summary>
            /// Enum _43 for value: 43
            /// </summary>
            [EnumMember(Value = "43")]
            _43 = 43,

            /// <summary>
            /// Enum _44 for value: 44
            /// </summary>
            [EnumMember(Value = "44")]
            _44 = 44,

            /// <summary>
            /// Enum _45 for value: 45
            /// </summary>
            [EnumMember(Value = "45")]
            _45 = 45,

            /// <summary>
            /// Enum _46 for value: 46
            /// </summary>
            [EnumMember(Value = "46")]
            _46 = 46,

            /// <summary>
            /// Enum _47 for value: 47
            /// </summary>
            [EnumMember(Value = "47")]
            _47 = 47,

            /// <summary>
            /// Enum _48 for value: 48
            /// </summary>
            [EnumMember(Value = "48")]
            _48 = 48,

            /// <summary>
            /// Enum _49 for value: 49
            /// </summary>
            [EnumMember(Value = "49")]
            _49 = 49,

            /// <summary>
            /// Enum _50 for value: 50
            /// </summary>
            [EnumMember(Value = "50")]
            _50 = 50,

            /// <summary>
            /// Enum _51 for value: 51
            /// </summary>
            [EnumMember(Value = "51")]
            _51 = 51,

            /// <summary>
            /// Enum _52 for value: 52
            /// </summary>
            [EnumMember(Value = "52")]
            _52 = 52,

            /// <summary>
            /// Enum _53 for value: 53
            /// </summary>
            [EnumMember(Value = "53")]
            _53 = 53,

            /// <summary>
            /// Enum _54 for value: 54
            /// </summary>
            [EnumMember(Value = "54")]
            _54 = 54,

            /// <summary>
            /// Enum _55 for value: 55
            /// </summary>
            [EnumMember(Value = "55")]
            _55 = 55,

            /// <summary>
            /// Enum _56 for value: 56
            /// </summary>
            [EnumMember(Value = "56")]
            _56 = 56,

            /// <summary>
            /// Enum _57 for value: 57
            /// </summary>
            [EnumMember(Value = "57")]
            _57 = 57,

            /// <summary>
            /// Enum _58 for value: 58
            /// </summary>
            [EnumMember(Value = "58")]
            _58 = 58,

            /// <summary>
            /// Enum _59 for value: 59
            /// </summary>
            [EnumMember(Value = "59")]
            _59 = 59,

            /// <summary>
            /// Enum _60 for value: 60
            /// </summary>
            [EnumMember(Value = "60")]
            _60 = 60,

            /// <summary>
            /// Enum _61 for value: 61
            /// </summary>
            [EnumMember(Value = "61")]
            _61 = 61,

            /// <summary>
            /// Enum _62 for value: 62
            /// </summary>
            [EnumMember(Value = "62")]
            _62 = 62,

            /// <summary>
            /// Enum _63 for value: 63
            /// </summary>
            [EnumMember(Value = "63")]
            _63 = 63,

            /// <summary>
            /// Enum _64 for value: 64
            /// </summary>
            [EnumMember(Value = "64")]
            _64 = 64,

            /// <summary>
            /// Enum _65 for value: 65
            /// </summary>
            [EnumMember(Value = "65")]
            _65 = 65,

            /// <summary>
            /// Enum _66 for value: 66
            /// </summary>
            [EnumMember(Value = "66")]
            _66 = 66,

            /// <summary>
            /// Enum _67 for value: 67
            /// </summary>
            [EnumMember(Value = "67")]
            _67 = 67,

            /// <summary>
            /// Enum _68 for value: 68
            /// </summary>
            [EnumMember(Value = "68")]
            _68 = 68,

            /// <summary>
            /// Enum _69 for value: 69
            /// </summary>
            [EnumMember(Value = "69")]
            _69 = 69,

            /// <summary>
            /// Enum _70 for value: 70
            /// </summary>
            [EnumMember(Value = "70")]
            _70 = 70,

            /// <summary>
            /// Enum _71 for value: 71
            /// </summary>
            [EnumMember(Value = "71")]
            _71 = 71,

            /// <summary>
            /// Enum _72 for value: 72
            /// </summary>
            [EnumMember(Value = "72")]
            _72 = 72,

            /// <summary>
            /// Enum _73 for value: 73
            /// </summary>
            [EnumMember(Value = "73")]
            _73 = 73,

            /// <summary>
            /// Enum _74 for value: 74
            /// </summary>
            [EnumMember(Value = "74")]
            _74 = 74,

            /// <summary>
            /// Enum _75 for value: 75
            /// </summary>
            [EnumMember(Value = "75")]
            _75 = 75,

            /// <summary>
            /// Enum _76 for value: 76
            /// </summary>
            [EnumMember(Value = "76")]
            _76 = 76,

            /// <summary>
            /// Enum _77 for value: 77
            /// </summary>
            [EnumMember(Value = "77")]
            _77 = 77,

            /// <summary>
            /// Enum _78 for value: 78
            /// </summary>
            [EnumMember(Value = "78")]
            _78 = 78,

            /// <summary>
            /// Enum _79 for value: 79
            /// </summary>
            [EnumMember(Value = "79")]
            _79 = 79,

            /// <summary>
            /// Enum _80 for value: 80
            /// </summary>
            [EnumMember(Value = "80")]
            _80 = 80,

            /// <summary>
            /// Enum _81 for value: 81
            /// </summary>
            [EnumMember(Value = "81")]
            _81 = 81,

            /// <summary>
            /// Enum _82 for value: 82
            /// </summary>
            [EnumMember(Value = "82")]
            _82 = 82,

            /// <summary>
            /// Enum _83 for value: 83
            /// </summary>
            [EnumMember(Value = "83")]
            _83 = 83,

            /// <summary>
            /// Enum _84 for value: 84
            /// </summary>
            [EnumMember(Value = "84")]
            _84 = 84,

            /// <summary>
            /// Enum _85 for value: 85
            /// </summary>
            [EnumMember(Value = "85")]
            _85 = 85,

            /// <summary>
            /// Enum _86 for value: 86
            /// </summary>
            [EnumMember(Value = "86")]
            _86 = 86,

            /// <summary>
            /// Enum _87 for value: 87
            /// </summary>
            [EnumMember(Value = "87")]
            _87 = 87,

            /// <summary>
            /// Enum _88 for value: 88
            /// </summary>
            [EnumMember(Value = "88")]
            _88 = 88,

            /// <summary>
            /// Enum _89 for value: 89
            /// </summary>
            [EnumMember(Value = "89")]
            _89 = 89,

            /// <summary>
            /// Enum _90 for value: 90
            /// </summary>
            [EnumMember(Value = "90")]
            _90 = 90,

            /// <summary>
            /// Enum _91 for value: 91
            /// </summary>
            [EnumMember(Value = "91")]
            _91 = 91,

            /// <summary>
            /// Enum _92 for value: 92
            /// </summary>
            [EnumMember(Value = "92")]
            _92 = 92,

            /// <summary>
            /// Enum _93 for value: 93
            /// </summary>
            [EnumMember(Value = "93")]
            _93 = 93,

            /// <summary>
            /// Enum _94 for value: 94
            /// </summary>
            [EnumMember(Value = "94")]
            _94 = 94,

            /// <summary>
            /// Enum _95 for value: 95
            /// </summary>
            [EnumMember(Value = "95")]
            _95 = 95,

            /// <summary>
            /// Enum _96 for value: 96
            /// </summary>
            [EnumMember(Value = "96")]
            _96 = 96,

            /// <summary>
            /// Enum _97 for value: 97
            /// </summary>
            [EnumMember(Value = "97")]
            _97 = 97,

            /// <summary>
            /// Enum _98 for value: 98
            /// </summary>
            [EnumMember(Value = "98")]
            _98 = 98,

            /// <summary>
            /// Enum _99 for value: 99
            /// </summary>
            [EnumMember(Value = "99")]
            _99 = 99,

            /// <summary>
            /// Enum _100 for value: 100
            /// </summary>
            [EnumMember(Value = "100")]
            _100 = 100,

            /// <summary>
            /// Enum _101 for value: 101
            /// </summary>
            [EnumMember(Value = "101")]
            _101 = 101,

            /// <summary>
            /// Enum _102 for value: 102
            /// </summary>
            [EnumMember(Value = "102")]
            _102 = 102,

            /// <summary>
            /// Enum _103 for value: 103
            /// </summary>
            [EnumMember(Value = "103")]
            _103 = 103,

            /// <summary>
            /// Enum _104 for value: 104
            /// </summary>
            [EnumMember(Value = "104")]
            _104 = 104,

            /// <summary>
            /// Enum _105 for value: 105
            /// </summary>
            [EnumMember(Value = "105")]
            _105 = 105,

            /// <summary>
            /// Enum _106 for value: 106
            /// </summary>
            [EnumMember(Value = "106")]
            _106 = 106,

            /// <summary>
            /// Enum _107 for value: 107
            /// </summary>
            [EnumMember(Value = "107")]
            _107 = 107,

            /// <summary>
            /// Enum _108 for value: 108
            /// </summary>
            [EnumMember(Value = "108")]
            _108 = 108,

            /// <summary>
            /// Enum _109 for value: 109
            /// </summary>
            [EnumMember(Value = "109")]
            _109 = 109,

            /// <summary>
            /// Enum _110 for value: 110
            /// </summary>
            [EnumMember(Value = "110")]
            _110 = 110,

            /// <summary>
            /// Enum _90001 for value: 90001
            /// </summary>
            [EnumMember(Value = "90001")]
            _90001 = 111,

            /// <summary>
            /// Enum _90002 for value: 90002
            /// </summary>
            [EnumMember(Value = "90002")]
            _90002 = 112,

            /// <summary>
            /// Enum _90003 for value: 90003
            /// </summary>
            [EnumMember(Value = "90003")]
            _90003 = 113,

            /// <summary>
            /// Enum _90004 for value: 90004
            /// </summary>
            [EnumMember(Value = "90004")]
            _90004 = 114,

            /// <summary>
            /// Enum _90005 for value: 90005
            /// </summary>
            [EnumMember(Value = "90005")]
            _90005 = 115,

            /// <summary>
            /// Enum _90006 for value: 90006
            /// </summary>
            [EnumMember(Value = "90006")]
            _90006 = 116,

            /// <summary>
            /// Enum _90007 for value: 90007
            /// </summary>
            [EnumMember(Value = "90007")]
            _90007 = 117,

            /// <summary>
            /// Enum _90008 for value: 90008
            /// </summary>
            [EnumMember(Value = "90008")]
            _90008 = 118,

            /// <summary>
            /// Enum _90009 for value: 90009
            /// </summary>
            [EnumMember(Value = "90009")]
            _90009 = 119,

            /// <summary>
            /// Enum _90010 for value: 90010
            /// </summary>
            [EnumMember(Value = "90010")]
            _90010 = 120

        }

        /// <summary>
        /// The code for this attraction type.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#attractioncategory-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>The code for this attraction type.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#attractioncategory-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="typeCode", EmitDefaultValue=true)]
        public TypeCodeEnum TypeCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePropertiesInner1AttractionListInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AvailablePropertiesInner1AttractionListInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePropertiesInner1AttractionListInner" /> class.
        /// </summary>
        /// <param name="typeCode">The code for this attraction type.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#attractioncategory-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; (required).</param>
        /// <param name="name">The name of the attraction. Names are proper nouns and therefore not affected by the given language code. (required).</param>
        /// <param name="distance">distance (required).</param>
        public AvailablePropertiesInner1AttractionListInner(TypeCodeEnum typeCode = default(TypeCodeEnum), string name = default(string), AvailablePropertiesInner1AttractionListInnerDistance distance = default(AvailablePropertiesInner1AttractionListInnerDistance))
        {
            // to ensure "typeCode" is required (not null)
            if (typeCode == null)
            {
                throw new InvalidDataException("typeCode is a required property for AvailablePropertiesInner1AttractionListInner and cannot be null");
            }
            else
            {
                this.TypeCode = typeCode;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for AvailablePropertiesInner1AttractionListInner and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "distance" is required (not null)
            if (distance == null)
            {
                throw new InvalidDataException("distance is a required property for AvailablePropertiesInner1AttractionListInner and cannot be null");
            }
            else
            {
                this.Distance = distance;
            }

        }


        /// <summary>
        /// The name of the attraction. Names are proper nouns and therefore not affected by the given language code.
        /// </summary>
        /// <value>The name of the attraction. Names are proper nouns and therefore not affected by the given language code.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=true)]
        public AvailablePropertiesInner1AttractionListInnerDistance Distance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailablePropertiesInner1AttractionListInner {\n");
            sb.Append("  TypeCode: ").Append(TypeCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
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
            return this.Equals(input as AvailablePropertiesInner1AttractionListInner);
        }

        /// <summary>
        /// Returns true if AvailablePropertiesInner1AttractionListInner instances are equal
        /// </summary>
        /// <param name="input">Instance of AvailablePropertiesInner1AttractionListInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailablePropertiesInner1AttractionListInner input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
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
