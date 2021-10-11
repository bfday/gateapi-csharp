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
    /// LoanPatch
    /// </summary>
    [DataContract]
    public partial class LoanPatch :  IEquatable<LoanPatch>, IValidatableObject
    {
        /// <summary>
        /// Loan side. Possible values are &#x60;lend&#x60; and &#x60;borrow&#x60;. For &#x60;LoanRecord&#x60; patching, only &#x60;lend&#x60; is supported
        /// </summary>
        /// <value>Loan side. Possible values are &#x60;lend&#x60; and &#x60;borrow&#x60;. For &#x60;LoanRecord&#x60; patching, only &#x60;lend&#x60; is supported</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SideEnum
        {
            /// <summary>
            /// Enum Lend for value: lend
            /// </summary>
            [EnumMember(Value = "lend")]
            Lend = 1,

            /// <summary>
            /// Enum Borrow for value: borrow
            /// </summary>
            [EnumMember(Value = "borrow")]
            Borrow = 2

        }

        /// <summary>
        /// Loan side. Possible values are &#x60;lend&#x60; and &#x60;borrow&#x60;. For &#x60;LoanRecord&#x60; patching, only &#x60;lend&#x60; is supported
        /// </summary>
        /// <value>Loan side. Possible values are &#x60;lend&#x60; and &#x60;borrow&#x60;. For &#x60;LoanRecord&#x60; patching, only &#x60;lend&#x60; is supported</value>
        [DataMember(Name="side")]
        public SideEnum Side { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanPatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoanPatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanPatch" /> class.
        /// </summary>
        /// <param name="currency">Loan currency (required).</param>
        /// <param name="side">Loan side. Possible values are &#x60;lend&#x60; and &#x60;borrow&#x60;. For &#x60;LoanRecord&#x60; patching, only &#x60;lend&#x60; is supported (required).</param>
        /// <param name="autoRenew">Auto renew (required).</param>
        /// <param name="currencyPair">Currency pair. Required if borrowing.</param>
        /// <param name="loanId">Loan ID. Required for &#x60;LoanRecord&#x60; patching.</param>
        public LoanPatch(string currency = default(string), SideEnum side = default(SideEnum), bool autoRenew = default(bool), string currencyPair = default(string), string loanId = default(string))
        {
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency", "currency is a required property for LoanPatch and cannot be null");
            this.Side = side;
            this.AutoRenew = autoRenew;
            this.CurrencyPair = currencyPair;
            this.LoanId = loanId;
        }

        /// <summary>
        /// Loan currency
        /// </summary>
        /// <value>Loan currency</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Auto renew
        /// </summary>
        /// <value>Auto renew</value>
        [DataMember(Name="auto_renew")]
        public bool AutoRenew { get; set; }

        /// <summary>
        /// Currency pair. Required if borrowing
        /// </summary>
        /// <value>Currency pair. Required if borrowing</value>
        [DataMember(Name="currency_pair")]
        public string CurrencyPair { get; set; }

        /// <summary>
        /// Loan ID. Required for &#x60;LoanRecord&#x60; patching
        /// </summary>
        /// <value>Loan ID. Required for &#x60;LoanRecord&#x60; patching</value>
        [DataMember(Name="loan_id")]
        public string LoanId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanPatch {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
            sb.Append("  CurrencyPair: ").Append(CurrencyPair).Append("\n");
            sb.Append("  LoanId: ").Append(LoanId).Append("\n");
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
            return this.Equals(input as LoanPatch);
        }

        /// <summary>
        /// Returns true if LoanPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanPatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Side == input.Side ||
                    this.Side.Equals(input.Side)
                ) && 
                (
                    this.AutoRenew == input.AutoRenew ||
                    this.AutoRenew.Equals(input.AutoRenew)
                ) && 
                (
                    this.CurrencyPair == input.CurrencyPair ||
                    (this.CurrencyPair != null &&
                    this.CurrencyPair.Equals(input.CurrencyPair))
                ) && 
                (
                    this.LoanId == input.LoanId ||
                    (this.LoanId != null &&
                    this.LoanId.Equals(input.LoanId))
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
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                hashCode = hashCode * 59 + this.Side.GetHashCode();
                hashCode = hashCode * 59 + this.AutoRenew.GetHashCode();
                if (this.CurrencyPair != null)
                    hashCode = hashCode * 59 + this.CurrencyPair.GetHashCode();
                if (this.LoanId != null)
                    hashCode = hashCode * 59 + this.LoanId.GetHashCode();
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
