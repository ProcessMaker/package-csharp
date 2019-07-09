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
    /// ProcessPermissionsEditable
    /// </summary>
    [DataContract]
    public partial class ProcessPermissionsEditable :  IEquatable<ProcessPermissionsEditable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessPermissionsEditable" /> class.
        /// </summary>
        /// <param name="id">Represents a Process permission..</param>
        /// <param name="processId">Represents a Process permission..</param>
        /// <param name="permissionId">Represents a Process permission..</param>
        /// <param name="assignableId">Represents a Process permission..</param>
        /// <param name="assignableType">Represents a Process permission..</param>
        public ProcessPermissionsEditable(int? id = default(int?), int? processId = default(int?), int? permissionId = default(int?), int? assignableId = default(int?), string assignableType = default(string))
        {
            this.Id = id;
            this.ProcessId = processId;
            this.PermissionId = permissionId;
            this.AssignableId = assignableId;
            this.AssignableType = assignableType;
        }
        
        /// <summary>
        /// Represents a Process permission.
        /// </summary>
        /// <value>Represents a Process permission.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Represents a Process permission.
        /// </summary>
        /// <value>Represents a Process permission.</value>
        [DataMember(Name="process_id", EmitDefaultValue=false)]
        public int? ProcessId { get; set; }

        /// <summary>
        /// Represents a Process permission.
        /// </summary>
        /// <value>Represents a Process permission.</value>
        [DataMember(Name="permission_id", EmitDefaultValue=false)]
        public int? PermissionId { get; set; }

        /// <summary>
        /// Represents a Process permission.
        /// </summary>
        /// <value>Represents a Process permission.</value>
        [DataMember(Name="assignable_id", EmitDefaultValue=false)]
        public int? AssignableId { get; set; }

        /// <summary>
        /// Represents a Process permission.
        /// </summary>
        /// <value>Represents a Process permission.</value>
        [DataMember(Name="assignable_type", EmitDefaultValue=false)]
        public string AssignableType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessPermissionsEditable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  PermissionId: ").Append(PermissionId).Append("\n");
            sb.Append("  AssignableId: ").Append(AssignableId).Append("\n");
            sb.Append("  AssignableType: ").Append(AssignableType).Append("\n");
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
            return this.Equals(input as ProcessPermissionsEditable);
        }

        /// <summary>
        /// Returns true if ProcessPermissionsEditable instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessPermissionsEditable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessPermissionsEditable input)
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
                    this.PermissionId == input.PermissionId ||
                    (this.PermissionId != null &&
                    this.PermissionId.Equals(input.PermissionId))
                ) && 
                (
                    this.AssignableId == input.AssignableId ||
                    (this.AssignableId != null &&
                    this.AssignableId.Equals(input.AssignableId))
                ) && 
                (
                    this.AssignableType == input.AssignableType ||
                    (this.AssignableType != null &&
                    this.AssignableType.Equals(input.AssignableType))
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
                if (this.PermissionId != null)
                    hashCode = hashCode * 59 + this.PermissionId.GetHashCode();
                if (this.AssignableId != null)
                    hashCode = hashCode * 59 + this.AssignableId.GetHashCode();
                if (this.AssignableType != null)
                    hashCode = hashCode * 59 + this.AssignableType.GetHashCode();
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