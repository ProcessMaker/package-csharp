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
    /// Users
    /// </summary>
    [DataContract]
    public partial class Users :  IEquatable<Users>, IValidatableObject
    {
        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum INACTIVE for value: INACTIVE
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            INACTIVE = 2

        }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Users" /> class.
        /// </summary>
        /// <param name="email">The attributes that are mass assignable..</param>
        /// <param name="password">The attributes that are mass assignable..</param>
        /// <param name="firstname">The attributes that are mass assignable..</param>
        /// <param name="lastname">The attributes that are mass assignable..</param>
        /// <param name="username">The attributes that are mass assignable..</param>
        /// <param name="address">The attributes that are mass assignable..</param>
        /// <param name="city">The attributes that are mass assignable..</param>
        /// <param name="state">The attributes that are mass assignable..</param>
        /// <param name="postal">The attributes that are mass assignable..</param>
        /// <param name="country">The attributes that are mass assignable..</param>
        /// <param name="phone">The attributes that are mass assignable..</param>
        /// <param name="fax">The attributes that are mass assignable..</param>
        /// <param name="cell">The attributes that are mass assignable..</param>
        /// <param name="title">The attributes that are mass assignable..</param>
        /// <param name="timezone">The attributes that are mass assignable..</param>
        /// <param name="datetimeFormat">The attributes that are mass assignable..</param>
        /// <param name="language">The attributes that are mass assignable..</param>
        /// <param name="isAdministrator">The attributes that are mass assignable..</param>
        /// <param name="loggedinAt">The attributes that are mass assignable..</param>
        /// <param name="status">The attributes that are mass assignable..</param>
        /// <param name="id">The attributes that are mass assignable..</param>
        /// <param name="createdAt">The attributes that are mass assignable..</param>
        /// <param name="updatedAt">The attributes that are mass assignable..</param>
        public Users(string email = default(string), string password = default(string), string firstname = default(string), string lastname = default(string), string username = default(string), string address = default(string), string city = default(string), string state = default(string), string postal = default(string), string country = default(string), string phone = default(string), string fax = default(string), string cell = default(string), string title = default(string), string timezone = default(string), string datetimeFormat = default(string), string language = default(string), bool? isAdministrator = default(bool?), string loggedinAt = default(string), StatusEnum? status = default(StatusEnum?), string id = default(string), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?))
        {
            this.Email = email;
            this.Password = password;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Username = username;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Postal = postal;
            this.Country = country;
            this.Phone = phone;
            this.Fax = fax;
            this.Cell = cell;
            this.Title = title;
            this.Timezone = timezone;
            this.DatetimeFormat = datetimeFormat;
            this.Language = language;
            this.IsAdministrator = isAdministrator;
            this.LoggedinAt = loggedinAt;
            this.Status = status;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="postal", EmitDefaultValue=false)]
        public string Postal { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="cell", EmitDefaultValue=false)]
        public string Cell { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="datetime_format", EmitDefaultValue=false)]
        public string DatetimeFormat { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="is_administrator", EmitDefaultValue=false)]
        public bool? IsAdministrator { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="loggedin_at", EmitDefaultValue=false)]
        public string LoggedinAt { get; set; }


        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The attributes that are mass assignable.
        /// </summary>
        /// <value>The attributes that are mass assignable.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Users {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Postal: ").Append(Postal).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Cell: ").Append(Cell).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  DatetimeFormat: ").Append(DatetimeFormat).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  IsAdministrator: ").Append(IsAdministrator).Append("\n");
            sb.Append("  LoggedinAt: ").Append(LoggedinAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as Users);
        }

        /// <summary>
        /// Returns true if Users instances are equal
        /// </summary>
        /// <param name="input">Instance of Users to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Users input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Firstname == input.Firstname ||
                    (this.Firstname != null &&
                    this.Firstname.Equals(input.Firstname))
                ) && 
                (
                    this.Lastname == input.Lastname ||
                    (this.Lastname != null &&
                    this.Lastname.Equals(input.Lastname))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Postal == input.Postal ||
                    (this.Postal != null &&
                    this.Postal.Equals(input.Postal))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Cell == input.Cell ||
                    (this.Cell != null &&
                    this.Cell.Equals(input.Cell))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.DatetimeFormat == input.DatetimeFormat ||
                    (this.DatetimeFormat != null &&
                    this.DatetimeFormat.Equals(input.DatetimeFormat))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.IsAdministrator == input.IsAdministrator ||
                    (this.IsAdministrator != null &&
                    this.IsAdministrator.Equals(input.IsAdministrator))
                ) && 
                (
                    this.LoggedinAt == input.LoggedinAt ||
                    (this.LoggedinAt != null &&
                    this.LoggedinAt.Equals(input.LoggedinAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Firstname != null)
                    hashCode = hashCode * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hashCode = hashCode * 59 + this.Lastname.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Postal != null)
                    hashCode = hashCode * 59 + this.Postal.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Cell != null)
                    hashCode = hashCode * 59 + this.Cell.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.DatetimeFormat != null)
                    hashCode = hashCode * 59 + this.DatetimeFormat.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.IsAdministrator != null)
                    hashCode = hashCode * 59 + this.IsAdministrator.GetHashCode();
                if (this.LoggedinAt != null)
                    hashCode = hashCode * 59 + this.LoggedinAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
