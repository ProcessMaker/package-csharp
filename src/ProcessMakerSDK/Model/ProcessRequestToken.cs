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
    /// ProcessRequestToken
    /// </summary>
    [DataContract]
    public partial class ProcessRequestToken :  IEquatable<ProcessRequestToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessRequestToken" /> class.
        /// </summary>
        /// <param name="userId">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="status">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="dueAt">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="initiatedAt">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="riskchangesAt">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="id">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="processId">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="processRequestId">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="elementId">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="elementType">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="createdAt">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        /// <param name="updatedAt">ProcessRequestToken is used to store the state of a token of the Nayra engine.</param>
        public ProcessRequestToken(string userId = default(string), string status = default(string), DateTime dueAt = default(DateTime), DateTime? initiatedAt = default(DateTime?), DateTime? riskchangesAt = default(DateTime?), string id = default(string), string processId = default(string), string processRequestId = default(string), string elementId = default(string), string elementType = default(string), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?))
        {
            this.UserId = userId;
            this.Status = status;
            this.DueAt = dueAt;
            this.InitiatedAt = initiatedAt;
            this.RiskchangesAt = riskchangesAt;
            this.Id = id;
            this.ProcessId = processId;
            this.ProcessRequestId = processRequestId;
            this.ElementId = elementId;
            this.ElementType = elementType;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="due_at", EmitDefaultValue=false)]
        public DateTime DueAt { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="initiated_at", EmitDefaultValue=false)]
        public DateTime? InitiatedAt { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="riskchanges_at", EmitDefaultValue=false)]
        public DateTime? RiskchangesAt { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="process_id", EmitDefaultValue=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="process_request_id", EmitDefaultValue=false)]
        public string ProcessRequestId { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="element_id", EmitDefaultValue=false)]
        public string ElementId { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="element_type", EmitDefaultValue=false)]
        public string ElementType { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// ProcessRequestToken is used to store the state of a token of the Nayra engine
        /// </summary>
        /// <value>ProcessRequestToken is used to store the state of a token of the Nayra engine</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessRequestToken {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DueAt: ").Append(DueAt).Append("\n");
            sb.Append("  InitiatedAt: ").Append(InitiatedAt).Append("\n");
            sb.Append("  RiskchangesAt: ").Append(RiskchangesAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  ProcessRequestId: ").Append(ProcessRequestId).Append("\n");
            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  ElementType: ").Append(ElementType).Append("\n");
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
            return this.Equals(input as ProcessRequestToken);
        }

        /// <summary>
        /// Returns true if ProcessRequestToken instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessRequestToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessRequestToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DueAt == input.DueAt ||
                    (this.DueAt != null &&
                    this.DueAt.Equals(input.DueAt))
                ) && 
                (
                    this.InitiatedAt == input.InitiatedAt ||
                    (this.InitiatedAt != null &&
                    this.InitiatedAt.Equals(input.InitiatedAt))
                ) && 
                (
                    this.RiskchangesAt == input.RiskchangesAt ||
                    (this.RiskchangesAt != null &&
                    this.RiskchangesAt.Equals(input.RiskchangesAt))
                ) && 
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
                    this.ProcessRequestId == input.ProcessRequestId ||
                    (this.ProcessRequestId != null &&
                    this.ProcessRequestId.Equals(input.ProcessRequestId))
                ) && 
                (
                    this.ElementId == input.ElementId ||
                    (this.ElementId != null &&
                    this.ElementId.Equals(input.ElementId))
                ) && 
                (
                    this.ElementType == input.ElementType ||
                    (this.ElementType != null &&
                    this.ElementType.Equals(input.ElementType))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DueAt != null)
                    hashCode = hashCode * 59 + this.DueAt.GetHashCode();
                if (this.InitiatedAt != null)
                    hashCode = hashCode * 59 + this.InitiatedAt.GetHashCode();
                if (this.RiskchangesAt != null)
                    hashCode = hashCode * 59 + this.RiskchangesAt.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                if (this.ProcessRequestId != null)
                    hashCode = hashCode * 59 + this.ProcessRequestId.GetHashCode();
                if (this.ElementId != null)
                    hashCode = hashCode * 59 + this.ElementId.GetHashCode();
                if (this.ElementType != null)
                    hashCode = hashCode * 59 + this.ElementType.GetHashCode();
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
