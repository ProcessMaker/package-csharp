/* 
 * ProcessMaker API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@processmaker.com
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
using OpenAPIDateConverter = ProcessMakerSDK.Client.OpenAPIDateConverter;

namespace ProcessMakerSDK.Model
{
    /// <summary>
    /// InlineObject6
    /// </summary>
    [DataContract]
    public partial class InlineObject6 :  IEquatable<InlineObject6>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject6" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject6() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject6" /> class.
        /// </summary>
        /// <param name="file">file to upload (required).</param>
        public InlineObject6(System.IO.Stream file = default(System.IO.Stream))
        {
            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new InvalidDataException("file is a required property for InlineObject6 and cannot be null");
            }
            else
            {
                this.File = file;
            }
            
        }
        
        /// <summary>
        /// file to upload
        /// </summary>
        /// <value>file to upload</value>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject6 {\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
            return this.Equals(input as InlineObject6);
        }

        /// <summary>
        /// Returns true if InlineObject6 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject6 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
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
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
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
