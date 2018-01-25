/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * OpenAPI spec version: 2.0.1
 * Contact: support@bungie.com
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
using SwaggerDateConverter = BungieNetPlatform.Client.SwaggerDateConverter;

namespace BungieNetPlatform.BungieNetPlatform.Model
{
    /// <summary>
    /// Used in a number of Destiny contracts to return data about an item stack and its quantity. Can optionally return an itemInstanceId if the item is instanced - in which case, the quantity returned will be 1. If it&#39;s not... uh, let me know okay? Thanks.
    /// </summary>
    [DataContract]
    public partial class DestinyDestinyItemQuantity :  IEquatable<DestinyDestinyItemQuantity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDestinyItemQuantity" /> class.
        /// </summary>
        /// <param name="ItemHash">The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition..</param>
        /// <param name="ItemInstanceId">If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null..</param>
        /// <param name="Quantity">The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used..</param>
        public DestinyDestinyItemQuantity(uint? ItemHash = default(uint?), long? ItemInstanceId = default(long?), int? Quantity = default(int?))
        {
            this.ItemHash = ItemHash;
            this.ItemInstanceId = ItemInstanceId;
            this.Quantity = Quantity;
        }
        
        /// <summary>
        /// The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.
        /// </summary>
        /// <value>The hash identifier for the item in question. Use it to look up the item&#39;s DestinyInventoryItemDefinition.</value>
        [DataMember(Name="itemHash", EmitDefaultValue=false)]
        public uint? ItemHash { get; set; }

        /// <summary>
        /// If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.
        /// </summary>
        /// <value>If this quantity is referring to a specific instance of an item, this will have the item&#39;s instance ID. Normally, this will be null.</value>
        [DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
        public long? ItemInstanceId { get; set; }

        /// <summary>
        /// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
        /// </summary>
        /// <value>The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDestinyItemQuantity {\n");
            sb.Append("  ItemHash: ").Append(ItemHash).Append("\n");
            sb.Append("  ItemInstanceId: ").Append(ItemInstanceId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as DestinyDestinyItemQuantity);
        }

        /// <summary>
        /// Returns true if DestinyDestinyItemQuantity instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDestinyItemQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDestinyItemQuantity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemHash == input.ItemHash ||
                    (this.ItemHash != null &&
                    this.ItemHash.Equals(input.ItemHash))
                ) && 
                (
                    this.ItemInstanceId == input.ItemInstanceId ||
                    (this.ItemInstanceId != null &&
                    this.ItemInstanceId.Equals(input.ItemInstanceId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.ItemHash != null)
                    hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
                if (this.ItemInstanceId != null)
                    hashCode = hashCode * 59 + this.ItemInstanceId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
