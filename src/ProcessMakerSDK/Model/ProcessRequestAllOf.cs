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
    /// ProcessRequestAllOf
    /// </summary>
    [DataContract]
    public partial class ProcessRequestAllOf :  IEquatable<ProcessRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessRequestAllOf" /> class.
        /// </summary>
        /// <param name="id">Represents an Eloquent model of a Request which is an instance of a Process..</param>
        /// <param name="processId">Represents an Eloquent model of a Request which is an instance of a Process..</param>
        /// <param name="processCollaborationId">Represents an Eloquent model of a Request which is an instance of a Process..</param>
        /// <param name="participantId">Represents an Eloquent model of a Request which is an instance of a Process..</param>
        /// <param name="processCategoryId">Represents an Eloquent model of a Request which is an instance of a Process..</param>
        /// <param name="createdAt">Represents an Eloquent model of a Request which is an instance of a Process..</param>
        /// <param name="updatedAt">Represents an Eloquent model of a Request which is an instance of a Process..</param>
        public ProcessRequestAllOf(string id = default(string), string processId = default(string), string processCollaborationId = default(string), string participantId = default(string), string processCategoryId = default(string), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?))
        {
            this.Id = id;
            this.ProcessId = processId;
            this.ProcessCollaborationId = processCollaborationId;
            this.ParticipantId = participantId;
            this.ProcessCategoryId = processCategoryId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// Represents an Eloquent model of a Request which is an instance of a Process.
        /// </summary>
        /// <value>Represents an Eloquent model of a Request which is an instance of a Process.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Request which is an instance of a Process.
        /// </summary>
        /// <value>Represents an Eloquent model of a Request which is an instance of a Process.</value>
        [DataMember(Name="process_id", EmitDefaultValue=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Request which is an instance of a Process.
        /// </summary>
        /// <value>Represents an Eloquent model of a Request which is an instance of a Process.</value>
        [DataMember(Name="process_collaboration_id", EmitDefaultValue=false)]
        public string ProcessCollaborationId { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Request which is an instance of a Process.
        /// </summary>
        /// <value>Represents an Eloquent model of a Request which is an instance of a Process.</value>
        [DataMember(Name="participant_id", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Request which is an instance of a Process.
        /// </summary>
        /// <value>Represents an Eloquent model of a Request which is an instance of a Process.</value>
        [DataMember(Name="process_category_id", EmitDefaultValue=false)]
        public string ProcessCategoryId { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Request which is an instance of a Process.
        /// </summary>
        /// <value>Represents an Eloquent model of a Request which is an instance of a Process.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Represents an Eloquent model of a Request which is an instance of a Process.
        /// </summary>
        /// <value>Represents an Eloquent model of a Request which is an instance of a Process.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessRequestAllOf {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  ProcessCollaborationId: ").Append(ProcessCollaborationId).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  ProcessCategoryId: ").Append(ProcessCategoryId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as ProcessRequestAllOf);
        }

        /// <summary>
        /// Returns true if ProcessRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessRequestAllOf input)
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
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
                ) && 
                (
                    this.ProcessCollaborationId == input.ProcessCollaborationId ||
                    (this.ProcessCollaborationId != null &&
                    this.ProcessCollaborationId.Equals(input.ProcessCollaborationId))
                ) && 
                (
                    this.ParticipantId == input.ParticipantId ||
                    (this.ParticipantId != null &&
                    this.ParticipantId.Equals(input.ParticipantId))
                ) && 
                (
                    this.ProcessCategoryId == input.ProcessCategoryId ||
                    (this.ProcessCategoryId != null &&
                    this.ProcessCategoryId.Equals(input.ProcessCategoryId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                if (this.ProcessCollaborationId != null)
                    hashCode = hashCode * 59 + this.ProcessCollaborationId.GetHashCode();
                if (this.ParticipantId != null)
                    hashCode = hashCode * 59 + this.ParticipantId.GetHashCode();
                if (this.ProcessCategoryId != null)
                    hashCode = hashCode * 59 + this.ProcessCategoryId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
