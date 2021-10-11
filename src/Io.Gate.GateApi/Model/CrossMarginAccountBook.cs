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
    /// CrossMarginAccountBook
    /// </summary>
    [DataContract]
    public partial class CrossMarginAccountBook :  IEquatable<CrossMarginAccountBook>, IValidatableObject
    {
        /// <summary>
        /// Account change type, including:  - in: transferals into cross margin account - out: transferals out from cross margin account - repay: loan repayment - borrow: borrowed loan - new_order: new order locked - order_fill: order fills - referral_fee: fee refund from referrals - order_fee: order fee generated from fills - unknown: unknown type
        /// </summary>
        /// <value>Account change type, including:  - in: transferals into cross margin account - out: transferals out from cross margin account - repay: loan repayment - borrow: borrowed loan - new_order: new order locked - order_fill: order fills - referral_fee: fee refund from referrals - order_fee: order fee generated from fills - unknown: unknown type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum In for value: in
            /// </summary>
            [EnumMember(Value = "in")]
            In = 1,

            /// <summary>
            /// Enum Out for value: out
            /// </summary>
            [EnumMember(Value = "out")]
            Out = 2,

            /// <summary>
            /// Enum Repay for value: repay
            /// </summary>
            [EnumMember(Value = "repay")]
            Repay = 3,

            /// <summary>
            /// Enum Borrow for value: borrow
            /// </summary>
            [EnumMember(Value = "borrow")]
            Borrow = 4,

            /// <summary>
            /// Enum Neworder for value: new_order
            /// </summary>
            [EnumMember(Value = "new_order")]
            Neworder = 5,

            /// <summary>
            /// Enum Orderfill for value: order_fill
            /// </summary>
            [EnumMember(Value = "order_fill")]
            Orderfill = 6,

            /// <summary>
            /// Enum Referralfee for value: referral_fee
            /// </summary>
            [EnumMember(Value = "referral_fee")]
            Referralfee = 7,

            /// <summary>
            /// Enum Orderfee for value: order_fee
            /// </summary>
            [EnumMember(Value = "order_fee")]
            Orderfee = 8,

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 9

        }

        /// <summary>
        /// Account change type, including:  - in: transferals into cross margin account - out: transferals out from cross margin account - repay: loan repayment - borrow: borrowed loan - new_order: new order locked - order_fill: order fills - referral_fee: fee refund from referrals - order_fee: order fee generated from fills - unknown: unknown type
        /// </summary>
        /// <value>Account change type, including:  - in: transferals into cross margin account - out: transferals out from cross margin account - repay: loan repayment - borrow: borrowed loan - new_order: new order locked - order_fill: order fills - referral_fee: fee refund from referrals - order_fee: order fee generated from fills - unknown: unknown type</value>
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossMarginAccountBook" /> class.
        /// </summary>
        /// <param name="id">Balance change record ID.</param>
        /// <param name="time">The timestamp of the change (in milliseconds).</param>
        /// <param name="currency">Currency changed.</param>
        /// <param name="change">Amount changed. Positive value means transferring in, while negative out.</param>
        /// <param name="balance">Balance after change.</param>
        /// <param name="type">Account change type, including:  - in: transferals into cross margin account - out: transferals out from cross margin account - repay: loan repayment - borrow: borrowed loan - new_order: new order locked - order_fill: order fills - referral_fee: fee refund from referrals - order_fee: order fee generated from fills - unknown: unknown type.</param>
        public CrossMarginAccountBook(string id = default(string), long time = default(long), string currency = default(string), string change = default(string), string balance = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Time = time;
            this.Currency = currency;
            this.Change = change;
            this.Balance = balance;
            this.Type = type;
        }

        /// <summary>
        /// Balance change record ID
        /// </summary>
        /// <value>Balance change record ID</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// The timestamp of the change (in milliseconds)
        /// </summary>
        /// <value>The timestamp of the change (in milliseconds)</value>
        [DataMember(Name="time")]
        public long Time { get; set; }

        /// <summary>
        /// Currency changed
        /// </summary>
        /// <value>Currency changed</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Amount changed. Positive value means transferring in, while negative out
        /// </summary>
        /// <value>Amount changed. Positive value means transferring in, while negative out</value>
        [DataMember(Name="change")]
        public string Change { get; set; }

        /// <summary>
        /// Balance after change
        /// </summary>
        /// <value>Balance after change</value>
        [DataMember(Name="balance")]
        public string Balance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrossMarginAccountBook {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Change: ").Append(Change).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
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
            return this.Equals(input as CrossMarginAccountBook);
        }

        /// <summary>
        /// Returns true if CrossMarginAccountBook instances are equal
        /// </summary>
        /// <param name="input">Instance of CrossMarginAccountBook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrossMarginAccountBook input)
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
                    this.Time == input.Time ||
                    this.Time.Equals(input.Time)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Change == input.Change ||
                    (this.Change != null &&
                    this.Change.Equals(input.Change))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Change != null)
                    hashCode = hashCode * 59 + this.Change.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
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
