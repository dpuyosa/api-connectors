/* 
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Get funding record response
    /// </summary>
    [DataContract]
    public partial class FundingRecords :  IEquatable<FundingRecords>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FundingRecords" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="coin">coin.</param>
        /// <param name="walletId">walletId.</param>
        /// <param name="type">type.</param>
        /// <param name="amount">amount.</param>
        /// <param name="txId">txId.</param>
        /// <param name="address">address.</param>
        /// <param name="walletBalance">walletBalance.</param>
        /// <param name="execTime">execTime.</param>
        /// <param name="crossSeq">crossSeq.</param>
        public FundingRecords(decimal? id = default(decimal?), decimal? userId = default(decimal?), string coin = default(string), decimal? walletId = default(decimal?), string type = default(string), string amount = default(string), string txId = default(string), string address = default(string), string walletBalance = default(string), string execTime = default(string), decimal? crossSeq = default(decimal?))
        {
            this.Id = id;
            this.UserId = userId;
            this.Coin = coin;
            this.WalletId = walletId;
            this.Type = type;
            this.Amount = amount;
            this.TxId = txId;
            this.Address = address;
            this.WalletBalance = walletBalance;
            this.ExecTime = execTime;
            this.CrossSeq = crossSeq;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public decimal? Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public decimal? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Coin
        /// </summary>
        [DataMember(Name="coin", EmitDefaultValue=false)]
        public string Coin { get; set; }

        /// <summary>
        /// Gets or Sets WalletId
        /// </summary>
        [DataMember(Name="wallet_id", EmitDefaultValue=false)]
        public decimal? WalletId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets TxId
        /// </summary>
        [DataMember(Name="tx_id", EmitDefaultValue=false)]
        public string TxId { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets WalletBalance
        /// </summary>
        [DataMember(Name="wallet_balance", EmitDefaultValue=false)]
        public string WalletBalance { get; set; }

        /// <summary>
        /// Gets or Sets ExecTime
        /// </summary>
        [DataMember(Name="exec_time", EmitDefaultValue=false)]
        public string ExecTime { get; set; }

        /// <summary>
        /// Gets or Sets CrossSeq
        /// </summary>
        [DataMember(Name="cross_seq", EmitDefaultValue=false)]
        public decimal? CrossSeq { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FundingRecords {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Coin: ").Append(Coin).Append("\n");
            sb.Append("  WalletId: ").Append(WalletId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TxId: ").Append(TxId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  WalletBalance: ").Append(WalletBalance).Append("\n");
            sb.Append("  ExecTime: ").Append(ExecTime).Append("\n");
            sb.Append("  CrossSeq: ").Append(CrossSeq).Append("\n");
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
            return this.Equals(input as FundingRecords);
        }

        /// <summary>
        /// Returns true if FundingRecords instances are equal
        /// </summary>
        /// <param name="input">Instance of FundingRecords to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FundingRecords input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Coin == input.Coin ||
                    (this.Coin != null &&
                    this.Coin.Equals(input.Coin))
                ) && 
                (
                    this.WalletId == input.WalletId ||
                    (this.WalletId != null &&
                    this.WalletId.Equals(input.WalletId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.TxId == input.TxId ||
                    (this.TxId != null &&
                    this.TxId.Equals(input.TxId))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.WalletBalance == input.WalletBalance ||
                    (this.WalletBalance != null &&
                    this.WalletBalance.Equals(input.WalletBalance))
                ) && 
                (
                    this.ExecTime == input.ExecTime ||
                    (this.ExecTime != null &&
                    this.ExecTime.Equals(input.ExecTime))
                ) && 
                (
                    this.CrossSeq == input.CrossSeq ||
                    (this.CrossSeq != null &&
                    this.CrossSeq.Equals(input.CrossSeq))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Coin != null)
                    hashCode = hashCode * 59 + this.Coin.GetHashCode();
                if (this.WalletId != null)
                    hashCode = hashCode * 59 + this.WalletId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.TxId != null)
                    hashCode = hashCode * 59 + this.TxId.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.WalletBalance != null)
                    hashCode = hashCode * 59 + this.WalletBalance.GetHashCode();
                if (this.ExecTime != null)
                    hashCode = hashCode * 59 + this.ExecTime.GetHashCode();
                if (this.CrossSeq != null)
                    hashCode = hashCode * 59 + this.CrossSeq.GetHashCode();
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
