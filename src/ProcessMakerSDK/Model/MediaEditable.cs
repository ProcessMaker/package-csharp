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
    /// MediaEditable
    /// </summary>
    [DataContract]
    public partial class MediaEditable :  IEquatable<MediaEditable>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaEditable" /> class.
        /// </summary>
        /// <param name="id">Represents media files stored in the database.</param>
        /// <param name="modelId">Represents media files stored in the database.</param>
        /// <param name="modelType">Represents media files stored in the database.</param>
        /// <param name="collectionName">Represents media files stored in the database.</param>
        /// <param name="name">Represents media files stored in the database.</param>
        /// <param name="fileName">Represents media files stored in the database.</param>
        /// <param name="mimeType">Represents media files stored in the database.</param>
        /// <param name="disk">Represents media files stored in the database.</param>
        /// <param name="size">Represents media files stored in the database.</param>
        /// <param name="manipulations">Represents media files stored in the database.</param>
        /// <param name="customProperties">Represents media files stored in the database.</param>
        /// <param name="responsiveImages">Represents media files stored in the database.</param>
        /// <param name="orderColumn">Represents media files stored in the database.</param>
        public MediaEditable(int? id = default(int?), int? modelId = default(int?), string modelType = default(string), string collectionName = default(string), string name = default(string), string fileName = default(string), string mimeType = default(string), string disk = default(string), int? size = default(int?), string manipulations = default(string), string customProperties = default(string), Object responsiveImages = default(Object), int? orderColumn = default(int?))
        {
            this.Id = id;
            this.ModelId = modelId;
            this.ModelType = modelType;
            this.CollectionName = collectionName;
            this.Name = name;
            this.FileName = fileName;
            this.MimeType = mimeType;
            this.Disk = disk;
            this.Size = size;
            this.Manipulations = manipulations;
            this.CustomProperties = customProperties;
            this.ResponsiveImages = responsiveImages;
            this.OrderColumn = orderColumn;
        }
        
        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="model_id", EmitDefaultValue=false)]
        public int? ModelId { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="model_type", EmitDefaultValue=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="collection_name", EmitDefaultValue=false)]
        public string CollectionName { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="file_name", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="mime_type", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="disk", EmitDefaultValue=false)]
        public string Disk { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="manipulations", EmitDefaultValue=false)]
        public string Manipulations { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="custom_properties", EmitDefaultValue=false)]
        public string CustomProperties { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="responsive_images", EmitDefaultValue=false)]
        public Object ResponsiveImages { get; set; }

        /// <summary>
        /// Represents media files stored in the database
        /// </summary>
        /// <value>Represents media files stored in the database</value>
        [DataMember(Name="order_column", EmitDefaultValue=false)]
        public int? OrderColumn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaEditable {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  ModelType: ").Append(ModelType).Append("\n");
            sb.Append("  CollectionName: ").Append(CollectionName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Disk: ").Append(Disk).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Manipulations: ").Append(Manipulations).Append("\n");
            sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
            sb.Append("  ResponsiveImages: ").Append(ResponsiveImages).Append("\n");
            sb.Append("  OrderColumn: ").Append(OrderColumn).Append("\n");
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
            return this.Equals(input as MediaEditable);
        }

        /// <summary>
        /// Returns true if MediaEditable instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaEditable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaEditable input)
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
                    this.ModelId == input.ModelId ||
                    (this.ModelId != null &&
                    this.ModelId.Equals(input.ModelId))
                ) && 
                (
                    this.ModelType == input.ModelType ||
                    (this.ModelType != null &&
                    this.ModelType.Equals(input.ModelType))
                ) && 
                (
                    this.CollectionName == input.CollectionName ||
                    (this.CollectionName != null &&
                    this.CollectionName.Equals(input.CollectionName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Disk == input.Disk ||
                    (this.Disk != null &&
                    this.Disk.Equals(input.Disk))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Manipulations == input.Manipulations ||
                    (this.Manipulations != null &&
                    this.Manipulations.Equals(input.Manipulations))
                ) && 
                (
                    this.CustomProperties == input.CustomProperties ||
                    (this.CustomProperties != null &&
                    this.CustomProperties.Equals(input.CustomProperties))
                ) && 
                (
                    this.ResponsiveImages == input.ResponsiveImages ||
                    (this.ResponsiveImages != null &&
                    this.ResponsiveImages.Equals(input.ResponsiveImages))
                ) && 
                (
                    this.OrderColumn == input.OrderColumn ||
                    (this.OrderColumn != null &&
                    this.OrderColumn.Equals(input.OrderColumn))
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
                if (this.ModelId != null)
                    hashCode = hashCode * 59 + this.ModelId.GetHashCode();
                if (this.ModelType != null)
                    hashCode = hashCode * 59 + this.ModelType.GetHashCode();
                if (this.CollectionName != null)
                    hashCode = hashCode * 59 + this.CollectionName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.Disk != null)
                    hashCode = hashCode * 59 + this.Disk.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Manipulations != null)
                    hashCode = hashCode * 59 + this.Manipulations.GetHashCode();
                if (this.CustomProperties != null)
                    hashCode = hashCode * 59 + this.CustomProperties.GetHashCode();
                if (this.ResponsiveImages != null)
                    hashCode = hashCode * 59 + this.ResponsiveImages.GetHashCode();
                if (this.OrderColumn != null)
                    hashCode = hashCode * 59 + this.OrderColumn.GetHashCode();
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