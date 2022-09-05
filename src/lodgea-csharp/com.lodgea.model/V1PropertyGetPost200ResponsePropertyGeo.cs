/*
 * lodgea-csharp
 *
 * LODGEA SDK for CSharp. Check out https://docs.lodgea.io for more information.
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

namespace lodgea-csharp.com.lodgea.model
{
    /// <summary>
    /// V1PropertyGetPost200ResponsePropertyGeo
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyGeo :  IEquatable<V1PropertyGetPost200ResponsePropertyGeo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyGeo" /> class.
        /// </summary>
        /// <param name="de">de.</param>
        /// <param name="en">en.</param>
        /// <param name="da">da.</param>
        /// <param name="nl">nl.</param>
        public V1PropertyGetPost200ResponsePropertyGeo(V1PropertyGetPost200ResponsePropertyGeoDe de = default(V1PropertyGetPost200ResponsePropertyGeoDe), V1PropertyGetPost200ResponsePropertyGeoEn en = default(V1PropertyGetPost200ResponsePropertyGeoEn), V1PropertyGetPost200ResponsePropertyGeoDa da = default(V1PropertyGetPost200ResponsePropertyGeoDa), V1PropertyGetPost200ResponsePropertyGeoNl nl = default(V1PropertyGetPost200ResponsePropertyGeoNl))
        {
            this.De = de;
            this.En = en;
            this.Da = da;
            this.Nl = nl;
        }

        /// <summary>
        /// Gets or Sets De
        /// </summary>
        [DataMember(Name="de", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyGeoDe De { get; set; }

        /// <summary>
        /// Gets or Sets En
        /// </summary>
        [DataMember(Name="en", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyGeoEn En { get; set; }

        /// <summary>
        /// Gets or Sets Da
        /// </summary>
        [DataMember(Name="da", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyGeoDa Da { get; set; }

        /// <summary>
        /// Gets or Sets Nl
        /// </summary>
        [DataMember(Name="nl", EmitDefaultValue=false)]
        public V1PropertyGetPost200ResponsePropertyGeoNl Nl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyGeo {\n");
            sb.Append("  De: ").Append(De).Append("\n");
            sb.Append("  En: ").Append(En).Append("\n");
            sb.Append("  Da: ").Append(Da).Append("\n");
            sb.Append("  Nl: ").Append(Nl).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyGeo);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyGeo instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyGeo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyGeo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.De == input.De ||
                    (this.De != null &&
                    this.De.Equals(input.De))
                ) && 
                (
                    this.En == input.En ||
                    (this.En != null &&
                    this.En.Equals(input.En))
                ) && 
                (
                    this.Da == input.Da ||
                    (this.Da != null &&
                    this.Da.Equals(input.Da))
                ) && 
                (
                    this.Nl == input.Nl ||
                    (this.Nl != null &&
                    this.Nl.Equals(input.Nl))
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
                if (this.De != null)
                    hashCode = hashCode * 59 + this.De.GetHashCode();
                if (this.En != null)
                    hashCode = hashCode * 59 + this.En.GetHashCode();
                if (this.Da != null)
                    hashCode = hashCode * 59 + this.Da.GetHashCode();
                if (this.Nl != null)
                    hashCode = hashCode * 59 + this.Nl.GetHashCode();
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
