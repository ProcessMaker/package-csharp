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
    /// ScriptsEditable
    /// </summary>
    [DataContract]
    public partial class ScriptsEditable :  IEquatable<ScriptsEditable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptsEditable" /> class.
        /// </summary>
        /// <param name="id">Represents an Eloquent model of a Script.</param>
        /// <param name="title">Represents an Eloquent model of a Script.</param>
        /// <param name="description">Represents an Eloquent model of a Script.</param>
        /// <param name="language">Represents an Eloquent model of a Script.</param>
        /// <param name="code">Represents an Eloquent model of a Script.</param>
        /// <param name="teimout">Represents an Eloquent model of a Script.</param>
        public ScriptsEditable(string id = default(string), string title = default(string), string description = default(string), string language = default(string), string code = default(string), int? teimout = default(int?))
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Language = language;
            this.Code = code;
            this.Teimout = teimout;
        }
        
        /// <summary>
        /// Represents an Eloquent model of a Script
        /// </summary>
        /// <value>Represents an Eloquent model of a Script</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Script
        /// </summary>
        /// <value>Represents an Eloquent model of a Script</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Script
        /// </summary>
        /// <value>Represents an Eloquent model of a Script</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Script
        /// </summary>
        /// <value>Represents an Eloquent model of a Script</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Script
        /// </summary>
        /// <value>Represents an Eloquent model of a Script</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Script
        /// </summary>
        /// <value>Represents an Eloquent model of a Script</value>
        [DataMember(Name="teimout", EmitDefaultValue=false)]
        public int? Teimout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScriptsEditable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Teimout: ").Append(Teimout).Append("\n");
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
            return this.Equals(input as ScriptsEditable);
        }

        /// <summary>
        /// Returns true if ScriptsEditable instances are equal
        /// </summary>
        /// <param name="input">Instance of ScriptsEditable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScriptsEditable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Teimout == input.Teimout ||
                    (this.Teimout != null &&
                    this.Teimout.Equals(input.Teimout))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Teimout != null)
                    hashCode = hashCode * 59 + this.Teimout.GetHashCode();
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