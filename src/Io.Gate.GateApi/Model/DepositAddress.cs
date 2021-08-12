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
    /// DepositAddress
    /// </summary>
    [DataContract]
    public partial class DepositAddress :  IEquatable<DepositAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepositAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositAddress" /> class.
        /// </summary>
        /// <param name="currency">Currency detail (required).</param>
        /// <param name="address">Deposit address (required).</param>
        /// <param name="multichainAddresses">multichainAddresses.</param>
        public DepositAddress(string currency = default(string), string address = default(string), List<MultiChainAddressItem> multichainAddresses = default(List<MultiChainAddressItem>))
        {
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency", "currency is a required property for DepositAddress and cannot be null");
            // to ensure "address" is required (not null)
            this.Address = address ?? throw new ArgumentNullException("address", "address is a required property for DepositAddress and cannot be null");
            this.MultichainAddresses = multichainAddresses;
        }

        /// <summary>
        /// Currency detail
        /// </summary>
        /// <value>Currency detail</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Deposit address
        /// </summary>
        /// <value>Deposit address</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets MultichainAddresses
        /// </summary>
        [DataMember(Name="multichain_addresses", EmitDefaultValue=false)]
        public List<MultiChainAddressItem> MultichainAddresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepositAddress {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  MultichainAddresses: ").Append(MultichainAddresses).Append("\n");
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
            return this.Equals(input as DepositAddress);
        }

        /// <summary>
        /// Returns true if DepositAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositAddress input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.MultichainAddresses == input.MultichainAddresses ||
                    this.MultichainAddresses != null &&
                    input.MultichainAddresses != null &&
                    this.MultichainAddresses.SequenceEqual(input.MultichainAddresses)
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.MultichainAddresses != null)
                    hashCode = hashCode * 59 + this.MultichainAddresses.GetHashCode();
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
