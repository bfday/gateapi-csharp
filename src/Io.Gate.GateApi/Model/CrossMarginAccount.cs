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
    /// CrossMarginAccount
    /// </summary>
    [DataContract]
    public partial class CrossMarginAccount :  IEquatable<CrossMarginAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossMarginAccount" /> class.
        /// </summary>
        /// <param name="userId">User ID.</param>
        /// <param name="locked">Whether account is locked.</param>
        /// <param name="balances">balances.</param>
        /// <param name="total">Total account value in USDT, i.e., the sum of all currencies&#39; &#x60;(available+freeze)*price*discount&#x60;.</param>
        /// <param name="borrowed">Total borrowed value in USDT, i.e., the sum of all currencies&#39; &#x60;borrowed*price*discount&#x60;.</param>
        /// <param name="interest">Total unpaid interests in USDT, i.e., the sum of all currencies&#39; &#x60;interest*price*discount&#x60;.</param>
        /// <param name="risk">Risk rate. When it belows 110%, liquidation will be triggered. Calculation formula: &#x60;total / (borrowed+interest)&#x60;.</param>
        public CrossMarginAccount(long userId = default(long), bool locked = default(bool), Dictionary<string, CrossMarginBalance> balances = default(Dictionary<string, CrossMarginBalance>), string total = default(string), string borrowed = default(string), string interest = default(string), string risk = default(string))
        {
            this.UserId = userId;
            this.Locked = locked;
            this.Balances = balances;
            this.Total = total;
            this.Borrowed = borrowed;
            this.Interest = interest;
            this.Risk = risk;
        }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name="user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// Whether account is locked
        /// </summary>
        /// <value>Whether account is locked</value>
        [DataMember(Name="locked")]
        public bool Locked { get; set; }

        /// <summary>
        /// Gets or Sets Balances
        /// </summary>
        [DataMember(Name="balances")]
        public Dictionary<string, CrossMarginBalance> Balances { get; set; }

        /// <summary>
        /// Total account value in USDT, i.e., the sum of all currencies&#39; &#x60;(available+freeze)*price*discount&#x60;
        /// </summary>
        /// <value>Total account value in USDT, i.e., the sum of all currencies&#39; &#x60;(available+freeze)*price*discount&#x60;</value>
        [DataMember(Name="total")]
        public string Total { get; set; }

        /// <summary>
        /// Total borrowed value in USDT, i.e., the sum of all currencies&#39; &#x60;borrowed*price*discount&#x60;
        /// </summary>
        /// <value>Total borrowed value in USDT, i.e., the sum of all currencies&#39; &#x60;borrowed*price*discount&#x60;</value>
        [DataMember(Name="borrowed")]
        public string Borrowed { get; set; }

        /// <summary>
        /// Total unpaid interests in USDT, i.e., the sum of all currencies&#39; &#x60;interest*price*discount&#x60;
        /// </summary>
        /// <value>Total unpaid interests in USDT, i.e., the sum of all currencies&#39; &#x60;interest*price*discount&#x60;</value>
        [DataMember(Name="interest")]
        public string Interest { get; set; }

        /// <summary>
        /// Risk rate. When it belows 110%, liquidation will be triggered. Calculation formula: &#x60;total / (borrowed+interest)&#x60;
        /// </summary>
        /// <value>Risk rate. When it belows 110%, liquidation will be triggered. Calculation formula: &#x60;total / (borrowed+interest)&#x60;</value>
        [DataMember(Name="risk")]
        public string Risk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrossMarginAccount {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Borrowed: ").Append(Borrowed).Append("\n");
            sb.Append("  Interest: ").Append(Interest).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
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
            return this.Equals(input as CrossMarginAccount);
        }

        /// <summary>
        /// Returns true if CrossMarginAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of CrossMarginAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrossMarginAccount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this.Locked == input.Locked ||
                    this.Locked.Equals(input.Locked)
                ) && 
                (
                    this.Balances == input.Balances ||
                    this.Balances != null &&
                    input.Balances != null &&
                    this.Balances.SequenceEqual(input.Balances)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Borrowed == input.Borrowed ||
                    (this.Borrowed != null &&
                    this.Borrowed.Equals(input.Borrowed))
                ) && 
                (
                    this.Interest == input.Interest ||
                    (this.Interest != null &&
                    this.Interest.Equals(input.Interest))
                ) && 
                (
                    this.Risk == input.Risk ||
                    (this.Risk != null &&
                    this.Risk.Equals(input.Risk))
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
                hashCode = hashCode * 59 + this.UserId.GetHashCode();
                hashCode = hashCode * 59 + this.Locked.GetHashCode();
                if (this.Balances != null)
                    hashCode = hashCode * 59 + this.Balances.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Borrowed != null)
                    hashCode = hashCode * 59 + this.Borrowed.GetHashCode();
                if (this.Interest != null)
                    hashCode = hashCode * 59 + this.Interest.GetHashCode();
                if (this.Risk != null)
                    hashCode = hashCode * 59 + this.Risk.GetHashCode();
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
