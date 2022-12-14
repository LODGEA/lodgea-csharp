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
    /// V1PropertyGetPost200ResponsePropertyTransaction
    /// </summary>
    [DataContract]
    public partial class V1PropertyGetPost200ResponsePropertyTransaction :  IEquatable<V1PropertyGetPost200ResponsePropertyTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PropertyGetPost200ResponsePropertyTransaction" /> class.
        /// </summary>
        /// <param name="method">method.</param>
        /// <param name="contactTypeList">contactTypeList.</param>
        /// <param name="externalList">externalList.</param>
        public V1PropertyGetPost200ResponsePropertyTransaction(string method = default(string), List<string> contactTypeList = default(List<string>), List<V1PropertyGetPost200ResponsePropertyTransactionExternalListInner> externalList = default(List<V1PropertyGetPost200ResponsePropertyTransactionExternalListInner>))
        {
            this.Method = method;
            this.ContactTypeList = contactTypeList;
            this.ExternalList = externalList;
        }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets ContactTypeList
        /// </summary>
        [DataMember(Name="contactTypeList", EmitDefaultValue=false)]
        public List<string> ContactTypeList { get; set; }

        /// <summary>
        /// Gets or Sets ExternalList
        /// </summary>
        [DataMember(Name="externalList", EmitDefaultValue=false)]
        public List<V1PropertyGetPost200ResponsePropertyTransactionExternalListInner> ExternalList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PropertyGetPost200ResponsePropertyTransaction {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  ContactTypeList: ").Append(ContactTypeList).Append("\n");
            sb.Append("  ExternalList: ").Append(ExternalList).Append("\n");
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
            return this.Equals(input as V1PropertyGetPost200ResponsePropertyTransaction);
        }

        /// <summary>
        /// Returns true if V1PropertyGetPost200ResponsePropertyTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of V1PropertyGetPost200ResponsePropertyTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PropertyGetPost200ResponsePropertyTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.ContactTypeList == input.ContactTypeList ||
                    this.ContactTypeList != null &&
                    input.ContactTypeList != null &&
                    this.ContactTypeList.SequenceEqual(input.ContactTypeList)
                ) && 
                (
                    this.ExternalList == input.ExternalList ||
                    this.ExternalList != null &&
                    input.ExternalList != null &&
                    this.ExternalList.SequenceEqual(input.ExternalList)
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
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.ContactTypeList != null)
                    hashCode = hashCode * 59 + this.ContactTypeList.GetHashCode();
                if (this.ExternalList != null)
                    hashCode = hashCode * 59 + this.ExternalList.GetHashCode();
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
