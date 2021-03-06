/* 
 * API v1
 *
 * FormAPI is a service that helps you fill out and sign PDF templates.
 *
 * OpenAPI spec version: v1
 * 
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
using OpenAPIDateConverter = FormApi.Client.Client.OpenAPIDateConverter;

namespace FormApi.Client.Model
{
    /// <summary>
    /// SubmissionDataRequest
    /// </summary>
    [DataContract]
    public partial class SubmissionDataRequest :  IEquatable<SubmissionDataRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Completed for value: completed
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed = 2

        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Defines AuthType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthTypeEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Password for value: password
            /// </summary>
            [EnumMember(Value = "password")]
            Password = 2,

            /// <summary>
            /// Enum Oauth for value: oauth
            /// </summary>
            [EnumMember(Value = "oauth")]
            Oauth = 3,

            /// <summary>
            /// Enum Emaillink for value: email_link
            /// </summary>
            [EnumMember(Value = "email_link")]
            Emaillink = 4,

            /// <summary>
            /// Enum Phonenumber for value: phone_number
            /// </summary>
            [EnumMember(Value = "phone_number")]
            Phonenumber = 5,

            /// <summary>
            /// Enum Ldap for value: ldap
            /// </summary>
            [EnumMember(Value = "ldap")]
            Ldap = 6,

            /// <summary>
            /// Enum Saml for value: saml
            /// </summary>
            [EnumMember(Value = "saml")]
            Saml = 7

        }

        /// <summary>
        /// Gets or Sets AuthType
        /// </summary>
        [DataMember(Name="auth_type", EmitDefaultValue=false)]
        public AuthTypeEnum? AuthType { get; set; }
        /// <summary>
        /// Defines AuthSecondFactorType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthSecondFactorTypeEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Phonenumber for value: phone_number
            /// </summary>
            [EnumMember(Value = "phone_number")]
            Phonenumber = 2,

            /// <summary>
            /// Enum Totp for value: totp
            /// </summary>
            [EnumMember(Value = "totp")]
            Totp = 3,

            /// <summary>
            /// Enum Mobilepush for value: mobile_push
            /// </summary>
            [EnumMember(Value = "mobile_push")]
            Mobilepush = 4,

            /// <summary>
            /// Enum Securitykey for value: security_key
            /// </summary>
            [EnumMember(Value = "security_key")]
            Securitykey = 5,

            /// <summary>
            /// Enum Fingerprint for value: fingerprint
            /// </summary>
            [EnumMember(Value = "fingerprint")]
            Fingerprint = 6

        }

        /// <summary>
        /// Gets or Sets AuthSecondFactorType
        /// </summary>
        [DataMember(Name="auth_second_factor_type", EmitDefaultValue=false)]
        public AuthSecondFactorTypeEnum? AuthSecondFactorType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmissionDataRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubmissionDataRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmissionDataRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="order">order (required).</param>
        /// <param name="fields">fields (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="state">state (required).</param>
        /// <param name="viewedAt">viewedAt.</param>
        /// <param name="completedAt">completedAt.</param>
        /// <param name="authType">authType.</param>
        /// <param name="authSecondFactorType">authSecondFactorType.</param>
        /// <param name="authProvider">authProvider.</param>
        /// <param name="authSessionStartedAt">authSessionStartedAt.</param>
        /// <param name="authSessionIdHash">authSessionIdHash.</param>
        /// <param name="authUserIdHash">authUserIdHash.</param>
        /// <param name="authUsernameHash">authUsernameHash.</param>
        /// <param name="authPhoneNumberHash">authPhoneNumberHash.</param>
        public SubmissionDataRequest(string id = default(string), string name = default(string), string email = default(string), int? order = default(int?), List<string> fields = default(List<string>), Object metadata = default(Object), StateEnum state = default(StateEnum), string viewedAt = default(string), string completedAt = default(string), AuthTypeEnum? authType = default(AuthTypeEnum?), AuthSecondFactorTypeEnum? authSecondFactorType = default(AuthSecondFactorTypeEnum?), string authProvider = default(string), string authSessionStartedAt = default(string), string authSessionIdHash = default(string), string authUserIdHash = default(string), string authUsernameHash = default(string), string authPhoneNumberHash = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SubmissionDataRequest and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for SubmissionDataRequest and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for SubmissionDataRequest and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new InvalidDataException("order is a required property for SubmissionDataRequest and cannot be null");
            }
            else
            {
                this.Order = order;
            }
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new InvalidDataException("fields is a required property for SubmissionDataRequest and cannot be null");
            }
            else
            {
                this.Fields = fields;
            }
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for SubmissionDataRequest and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new InvalidDataException("state is a required property for SubmissionDataRequest and cannot be null");
            }
            else
            {
                this.State = state;
            }
            this.ViewedAt = viewedAt;
            this.CompletedAt = completedAt;
            this.AuthType = authType;
            this.AuthSecondFactorType = authSecondFactorType;
            this.AuthProvider = authProvider;
            this.AuthSessionStartedAt = authSessionStartedAt;
            this.AuthSessionIdHash = authSessionIdHash;
            this.AuthUserIdHash = authUserIdHash;
            this.AuthUsernameHash = authUsernameHash;
            this.AuthPhoneNumberHash = authPhoneNumberHash;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }


        /// <summary>
        /// Gets or Sets ViewedAt
        /// </summary>
        [DataMember(Name="viewed_at", EmitDefaultValue=false)]
        public string ViewedAt { get; set; }

        /// <summary>
        /// Gets or Sets CompletedAt
        /// </summary>
        [DataMember(Name="completed_at", EmitDefaultValue=false)]
        public string CompletedAt { get; set; }



        /// <summary>
        /// Gets or Sets AuthProvider
        /// </summary>
        [DataMember(Name="auth_provider", EmitDefaultValue=false)]
        public string AuthProvider { get; set; }

        /// <summary>
        /// Gets or Sets AuthSessionStartedAt
        /// </summary>
        [DataMember(Name="auth_session_started_at", EmitDefaultValue=false)]
        public string AuthSessionStartedAt { get; set; }

        /// <summary>
        /// Gets or Sets AuthSessionIdHash
        /// </summary>
        [DataMember(Name="auth_session_id_hash", EmitDefaultValue=false)]
        public string AuthSessionIdHash { get; set; }

        /// <summary>
        /// Gets or Sets AuthUserIdHash
        /// </summary>
        [DataMember(Name="auth_user_id_hash", EmitDefaultValue=false)]
        public string AuthUserIdHash { get; set; }

        /// <summary>
        /// Gets or Sets AuthUsernameHash
        /// </summary>
        [DataMember(Name="auth_username_hash", EmitDefaultValue=false)]
        public string AuthUsernameHash { get; set; }

        /// <summary>
        /// Gets or Sets AuthPhoneNumberHash
        /// </summary>
        [DataMember(Name="auth_phone_number_hash", EmitDefaultValue=false)]
        public string AuthPhoneNumberHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmissionDataRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ViewedAt: ").Append(ViewedAt).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  AuthType: ").Append(AuthType).Append("\n");
            sb.Append("  AuthSecondFactorType: ").Append(AuthSecondFactorType).Append("\n");
            sb.Append("  AuthProvider: ").Append(AuthProvider).Append("\n");
            sb.Append("  AuthSessionStartedAt: ").Append(AuthSessionStartedAt).Append("\n");
            sb.Append("  AuthSessionIdHash: ").Append(AuthSessionIdHash).Append("\n");
            sb.Append("  AuthUserIdHash: ").Append(AuthUserIdHash).Append("\n");
            sb.Append("  AuthUsernameHash: ").Append(AuthUsernameHash).Append("\n");
            sb.Append("  AuthPhoneNumberHash: ").Append(AuthPhoneNumberHash).Append("\n");
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
            return this.Equals(input as SubmissionDataRequest);
        }

        /// <summary>
        /// Returns true if SubmissionDataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubmissionDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmissionDataRequest input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ViewedAt == input.ViewedAt ||
                    (this.ViewedAt != null &&
                    this.ViewedAt.Equals(input.ViewedAt))
                ) && 
                (
                    this.CompletedAt == input.CompletedAt ||
                    (this.CompletedAt != null &&
                    this.CompletedAt.Equals(input.CompletedAt))
                ) && 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
                ) && 
                (
                    this.AuthSecondFactorType == input.AuthSecondFactorType ||
                    (this.AuthSecondFactorType != null &&
                    this.AuthSecondFactorType.Equals(input.AuthSecondFactorType))
                ) && 
                (
                    this.AuthProvider == input.AuthProvider ||
                    (this.AuthProvider != null &&
                    this.AuthProvider.Equals(input.AuthProvider))
                ) && 
                (
                    this.AuthSessionStartedAt == input.AuthSessionStartedAt ||
                    (this.AuthSessionStartedAt != null &&
                    this.AuthSessionStartedAt.Equals(input.AuthSessionStartedAt))
                ) && 
                (
                    this.AuthSessionIdHash == input.AuthSessionIdHash ||
                    (this.AuthSessionIdHash != null &&
                    this.AuthSessionIdHash.Equals(input.AuthSessionIdHash))
                ) && 
                (
                    this.AuthUserIdHash == input.AuthUserIdHash ||
                    (this.AuthUserIdHash != null &&
                    this.AuthUserIdHash.Equals(input.AuthUserIdHash))
                ) && 
                (
                    this.AuthUsernameHash == input.AuthUsernameHash ||
                    (this.AuthUsernameHash != null &&
                    this.AuthUsernameHash.Equals(input.AuthUsernameHash))
                ) && 
                (
                    this.AuthPhoneNumberHash == input.AuthPhoneNumberHash ||
                    (this.AuthPhoneNumberHash != null &&
                    this.AuthPhoneNumberHash.Equals(input.AuthPhoneNumberHash))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ViewedAt != null)
                    hashCode = hashCode * 59 + this.ViewedAt.GetHashCode();
                if (this.CompletedAt != null)
                    hashCode = hashCode * 59 + this.CompletedAt.GetHashCode();
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.AuthSecondFactorType != null)
                    hashCode = hashCode * 59 + this.AuthSecondFactorType.GetHashCode();
                if (this.AuthProvider != null)
                    hashCode = hashCode * 59 + this.AuthProvider.GetHashCode();
                if (this.AuthSessionStartedAt != null)
                    hashCode = hashCode * 59 + this.AuthSessionStartedAt.GetHashCode();
                if (this.AuthSessionIdHash != null)
                    hashCode = hashCode * 59 + this.AuthSessionIdHash.GetHashCode();
                if (this.AuthUserIdHash != null)
                    hashCode = hashCode * 59 + this.AuthUserIdHash.GetHashCode();
                if (this.AuthUsernameHash != null)
                    hashCode = hashCode * 59 + this.AuthUsernameHash.GetHashCode();
                if (this.AuthPhoneNumberHash != null)
                    hashCode = hashCode * 59 + this.AuthPhoneNumberHash.GetHashCode();
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
