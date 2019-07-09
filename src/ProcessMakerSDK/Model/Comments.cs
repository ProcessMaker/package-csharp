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
    /// Comments
    /// </summary>
    [DataContract]
    public partial class Comments :  IEquatable<Comments>, IValidatableObject
    {
        /// <summary>
        /// Represents a business process definition.
        /// </summary>
        /// <value>Represents a business process definition.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum LOG for value: LOG
            /// </summary>
            [EnumMember(Value = "LOG")]
            LOG = 1,

            /// <summary>
            /// Enum MESSAGE for value: MESSAGE
            /// </summary>
            [EnumMember(Value = "MESSAGE")]
            MESSAGE = 2

        }

        /// <summary>
        /// Represents a business process definition.
        /// </summary>
        /// <value>Represents a business process definition.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Comments" /> class.
        /// </summary>
        /// <param name="id">Represents a business process definition..</param>
        /// <param name="userId">Represents a business process definition..</param>
        /// <param name="commentableId">Represents a business process definition..</param>
        /// <param name="commentableType">Represents a business process definition..</param>
        /// <param name="subject">Represents a business process definition..</param>
        /// <param name="body">Represents a business process definition..</param>
        /// <param name="hidden">Represents a business process definition..</param>
        /// <param name="type">Represents a business process definition..</param>
        public Comments(string id = default(string), string userId = default(string), string commentableId = default(string), string commentableType = default(string), string subject = default(string), string body = default(string), bool? hidden = default(bool?), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.UserId = userId;
            this.CommentableId = commentableId;
            this.CommentableType = commentableType;
            this.Subject = subject;
            this.Body = body;
            this.Hidden = hidden;
            this.Type = type;
        }
        
        /// <summary>
        /// Represents a business process definition.
        /// </summary>
        /// <value>Represents a business process definition.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Represents a business process definition.
        /// </summary>
        /// <value>Represents a business process definition.</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Represents a business process definition.
        /// </summary>
        /// <value>Represents a business process definition.</value>
        [DataMember(Name="commentable_id", EmitDefaultValue=false)]
        public string CommentableId { get; set; }

        /// <summary>
        /// Represents a business process definition.
        /// </summary>
        /// <value>Represents a business process definition.</value>
        [DataMember(Name="commentable_type", EmitDefaultValue=false)]
        public string CommentableType { get; set; }

        /// <summary>
        /// Represents a business process definition.
        /// </summary>
        /// <value>Represents a business process definition.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Represents a business process definition.
        /// </summary>
        /// <value>Represents a business process definition.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Represents a business process definition.
        /// </summary>
        /// <value>Represents a business process definition.</value>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool? Hidden { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Comments {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CommentableId: ").Append(CommentableId).Append("\n");
            sb.Append("  CommentableType: ").Append(CommentableType).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Comments);
        }

        /// <summary>
        /// Returns true if Comments instances are equal
        /// </summary>
        /// <param name="input">Instance of Comments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Comments input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.CommentableId == input.CommentableId ||
                    (this.CommentableId != null &&
                    this.CommentableId.Equals(input.CommentableId))
                ) && 
                (
                    this.CommentableType == input.CommentableType ||
                    (this.CommentableType != null &&
                    this.CommentableType.Equals(input.CommentableType))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.CommentableId != null)
                    hashCode = hashCode * 59 + this.CommentableId.GetHashCode();
                if (this.CommentableType != null)
                    hashCode = hashCode * 59 + this.CommentableType.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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