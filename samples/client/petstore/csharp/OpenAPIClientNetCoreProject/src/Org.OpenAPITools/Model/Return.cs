/* 
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Model for testing reserved words
    /// </summary>
    [DataContract]
    public partial class Return :  IEquatable<Return>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Return" /> class.
        /// </summary>
        /// <param name="_return">_return.</param>
        public Return(int _return = default(int))
        {
            this._Return = _return;
        }
        
        /// <summary>
        /// Gets or Sets _Return
        /// </summary>
        [DataMember(Name="return", EmitDefaultValue=false)]
        public int _Return { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Return {\n");
            sb.Append("  _Return: ").Append(_Return).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Return);
        }

        /// <summary>
        /// Returns true if Return instances are equal
        /// </summary>
        /// <param name="input">Instance of Return to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Return input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Return == input._Return ||
                    (this._Return != null &&
                    this._Return.Equals(input._Return))
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
                if (this._Return != null)
                    hashCode = hashCode * 59 + this._Return.GetHashCode();
                return hashCode;
            }
        }
    }

}
