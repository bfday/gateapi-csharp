/*
 * Gate API v4
 *
 * Welcome to Gate.io API  APIv4 provides spot, margin and futures trading operations. There are public APIs to retrieve the real-time market statistics, and private APIs which needs authentication to trade on user's behalf.
 *
 * Contact: support@mail.gate.io
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
using OpenAPIDateConverter = Io.Gate.GateApi.Client.OpenAPIDateConverter;

namespace Io.Gate.GateApi.Model
{
    /// <summary>
    /// CrossMarginLoan
    /// </summary>
    [DataContract]
    public partial class CrossMarginLoan :  IEquatable<CrossMarginLoan>, IValidatableObject
    {
        /// <summary>
        /// Borrow loan status, which includes:  - 1: failed to borrow - 2: borrowed but not repaid - 3: repayment complete
        /// </summary>
        /// <value>Borrow loan status, which includes:  - 1: failed to borrow - 2: borrowed but not repaid - 3: repayment complete</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3

        }

        /// <summary>
        /// Borrow loan status, which includes:  - 1: failed to borrow - 2: borrowed but not repaid - 3: repayment complete
        /// </summary>
        /// <value>Borrow loan status, which includes:  - 1: failed to borrow - 2: borrowed but not repaid - 3: repayment complete</value>
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossMarginLoan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CrossMarginLoan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossMarginLoan" /> class.
        /// </summary>
        /// <param name="currency">Currency name (required).</param>
        /// <param name="amount">Borrowed amount (required).</param>
        /// <param name="text">User defined custom ID.</param>
        public CrossMarginLoan(string currency = default(string), string amount = default(string), string text = default(string))
        {
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency", "currency is a required property for CrossMarginLoan and cannot be null");
            // to ensure "amount" is required (not null)
            this.Amount = amount ?? throw new ArgumentNullException("amount", "amount is a required property for CrossMarginLoan and cannot be null");
            this.Text = text;
        }

        /// <summary>
        /// Borrow loan ID
        /// </summary>
        /// <value>Borrow loan ID</value>
        [DataMember(Name="id")]
        public string Id { get; private set; }

        /// <summary>
        /// Creation timestamp, in milliseconds
        /// </summary>
        /// <value>Creation timestamp, in milliseconds</value>
        [DataMember(Name="create_time")]
        public long CreateTime { get; private set; }

        /// <summary>
        /// Update timestamp, in milliseconds
        /// </summary>
        /// <value>Update timestamp, in milliseconds</value>
        [DataMember(Name="update_time")]
        public long UpdateTime { get; private set; }

        /// <summary>
        /// Currency name
        /// </summary>
        /// <value>Currency name</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Borrowed amount
        /// </summary>
        /// <value>Borrowed amount</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// User defined custom ID
        /// </summary>
        /// <value>User defined custom ID</value>
        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// Repaid amount
        /// </summary>
        /// <value>Repaid amount</value>
        [DataMember(Name="repaid")]
        public string Repaid { get; private set; }

        /// <summary>
        /// Repaid interest
        /// </summary>
        /// <value>Repaid interest</value>
        [DataMember(Name="repaid_interest")]
        public string RepaidInterest { get; private set; }

        /// <summary>
        /// Outstanding interest yet to be paid
        /// </summary>
        /// <value>Outstanding interest yet to be paid</value>
        [DataMember(Name="unpaid_interest")]
        public string UnpaidInterest { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrossMarginLoan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Repaid: ").Append(Repaid).Append("\n");
            sb.Append("  RepaidInterest: ").Append(RepaidInterest).Append("\n");
            sb.Append("  UnpaidInterest: ").Append(UnpaidInterest).Append("\n");
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
            return this.Equals(input as CrossMarginLoan);
        }

        /// <summary>
        /// Returns true if CrossMarginLoan instances are equal
        /// </summary>
        /// <param name="input">Instance of CrossMarginLoan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrossMarginLoan input)
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
                    this.CreateTime == input.CreateTime ||
                    this.CreateTime.Equals(input.CreateTime)
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    this.UpdateTime.Equals(input.UpdateTime)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Repaid == input.Repaid ||
                    (this.Repaid != null &&
                    this.Repaid.Equals(input.Repaid))
                ) && 
                (
                    this.RepaidInterest == input.RepaidInterest ||
                    (this.RepaidInterest != null &&
                    this.RepaidInterest.Equals(input.RepaidInterest))
                ) && 
                (
                    this.UnpaidInterest == input.UnpaidInterest ||
                    (this.UnpaidInterest != null &&
                    this.UnpaidInterest.Equals(input.UnpaidInterest))
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
                hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Repaid != null)
                    hashCode = hashCode * 59 + this.Repaid.GetHashCode();
                if (this.RepaidInterest != null)
                    hashCode = hashCode * 59 + this.RepaidInterest.GetHashCode();
                if (this.UnpaidInterest != null)
                    hashCode = hashCode * 59 + this.UnpaidInterest.GetHashCode();
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
