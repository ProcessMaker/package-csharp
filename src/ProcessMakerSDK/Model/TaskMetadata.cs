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
    /// TaskMetadata
    /// </summary>
    [DataContract]
    public partial class TaskMetadata :  IEquatable<TaskMetadata>, IValidatableObject
    {
        /// <summary>
        /// Defines SortOrder
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortOrderEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            [EnumMember(Value = "asc")]
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            [EnumMember(Value = "desc")]
            Desc = 2

        }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskMetadata" /> class.
        /// </summary>
        /// <param name="filter">filter.</param>
        /// <param name="sortBy">sortBy.</param>
        /// <param name="sortOrder">sortOrder.</param>
        /// <param name="count">count.</param>
        /// <param name="totalPages">totalPages.</param>
        /// <param name="currentPage">currentPage.</param>
        /// <param name="form">form.</param>
        /// <param name="lastPage">lastPage.</param>
        /// <param name="path">path.</param>
        /// <param name="perPage">perPage.</param>
        /// <param name="to">to.</param>
        /// <param name="total">total.</param>
        /// <param name="inOverdue">inOverdue.</param>
        public TaskMetadata(string filter = default(string), string sortBy = default(string), SortOrderEnum? sortOrder = default(SortOrderEnum?), int? count = default(int?), int? totalPages = default(int?), int? currentPage = default(int?), int? form = default(int?), int? lastPage = default(int?), string path = default(string), int? perPage = default(int?), int? to = default(int?), int? total = default(int?), int? inOverdue = default(int?))
        {
            this.Filter = filter;
            this.SortBy = sortBy;
            this.SortOrder = sortOrder;
            this.Count = count;
            this.TotalPages = totalPages;
            this.CurrentPage = currentPage;
            this.Form = form;
            this.LastPage = lastPage;
            this.Path = path;
            this.PerPage = perPage;
            this.To = to;
            this.Total = total;
            this.InOverdue = inOverdue;
        }
        
        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [DataMember(Name="sort_by", EmitDefaultValue=false)]
        public string SortBy { get; set; }


        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="total_pages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name="current_page", EmitDefaultValue=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Gets or Sets Form
        /// </summary>
        [DataMember(Name="form", EmitDefaultValue=false)]
        public int? Form { get; set; }

        /// <summary>
        /// Gets or Sets LastPage
        /// </summary>
        [DataMember(Name="last_page", EmitDefaultValue=false)]
        public int? LastPage { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets PerPage
        /// </summary>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        public int? PerPage { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public int? To { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Gets or Sets InOverdue
        /// </summary>
        [DataMember(Name="in_overdue", EmitDefaultValue=false)]
        public int? InOverdue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskMetadata {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  LastPage: ").Append(LastPage).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  InOverdue: ").Append(InOverdue).Append("\n");
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
            return this.Equals(input as TaskMetadata);
        }

        /// <summary>
        /// Returns true if TaskMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.SortBy == input.SortBy ||
                    (this.SortBy != null &&
                    this.SortBy.Equals(input.SortBy))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
                ) && 
                (
                    this.Form == input.Form ||
                    (this.Form != null &&
                    this.Form.Equals(input.Form))
                ) && 
                (
                    this.LastPage == input.LastPage ||
                    (this.LastPage != null &&
                    this.LastPage.Equals(input.LastPage))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.InOverdue == input.InOverdue ||
                    (this.InOverdue != null &&
                    this.InOverdue.Equals(input.InOverdue))
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
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.SortBy != null)
                    hashCode = hashCode * 59 + this.SortBy.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.CurrentPage != null)
                    hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.Form != null)
                    hashCode = hashCode * 59 + this.Form.GetHashCode();
                if (this.LastPage != null)
                    hashCode = hashCode * 59 + this.LastPage.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.InOverdue != null)
                    hashCode = hashCode * 59 + this.InOverdue.GetHashCode();
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
