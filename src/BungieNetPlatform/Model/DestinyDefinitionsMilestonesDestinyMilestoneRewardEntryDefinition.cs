/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * OpenAPI spec version: 2.1.1
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

namespace BungieNetPlatform.Model
{
    /// <summary>
    /// The definition of a specific reward, which may be contained in a category of rewards and that has optional information about how it is obtained.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition :  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition" /> class.
        /// </summary>
        /// <param name="RewardEntryHash">The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone..</param>
        /// <param name="RewardEntryIdentifier">The string identifier, if you care about it. Only guaranteed unique within the specific Milestone..</param>
        /// <param name="Items">The items you will get as rewards, and how much of it you&#39;ll get..</param>
        /// <param name="VendorHash">If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition..</param>
        /// <param name="DisplayProperties">For us to bother returning this info, we should be able to return some kind of information about why these rewards are grouped together. This is ideally that information. Look at how confident I am that this will always remain true..</param>
        /// <param name="Order">If you want to follow BNet&#39;s ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too..</param>
        public DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition(uint? RewardEntryHash = default(uint?), string RewardEntryIdentifier = default(string), List<DestinyDestinyItemQuantity> Items = default(List<DestinyDestinyItemQuantity>), uint? VendorHash = default(uint?), DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), int? Order = default(int?))
        {
            this.RewardEntryHash = RewardEntryHash;
            this.RewardEntryIdentifier = RewardEntryIdentifier;
            this.Items = Items;
            this.VendorHash = VendorHash;
            this.DisplayProperties = DisplayProperties;
            this.Order = Order;
        }
        
        /// <summary>
        /// The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone.
        /// </summary>
        /// <value>The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone.</value>
        [DataMember(Name="rewardEntryHash", EmitDefaultValue=false)]
        public uint? RewardEntryHash { get; set; }

        /// <summary>
        /// The string identifier, if you care about it. Only guaranteed unique within the specific Milestone.
        /// </summary>
        /// <value>The string identifier, if you care about it. Only guaranteed unique within the specific Milestone.</value>
        [DataMember(Name="rewardEntryIdentifier", EmitDefaultValue=false)]
        public string RewardEntryIdentifier { get; set; }

        /// <summary>
        /// The items you will get as rewards, and how much of it you&#39;ll get.
        /// </summary>
        /// <value>The items you will get as rewards, and how much of it you&#39;ll get.</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<DestinyDestinyItemQuantity> Items { get; set; }

        /// <summary>
        /// If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition.
        /// </summary>
        /// <value>If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition.</value>
        [DataMember(Name="vendorHash", EmitDefaultValue=false)]
        public uint? VendorHash { get; set; }

        /// <summary>
        /// For us to bother returning this info, we should be able to return some kind of information about why these rewards are grouped together. This is ideally that information. Look at how confident I am that this will always remain true.
        /// </summary>
        /// <value>For us to bother returning this info, we should be able to return some kind of information about why these rewards are grouped together. This is ideally that information. Look at how confident I am that this will always remain true.</value>
        [DataMember(Name="displayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// If you want to follow BNet&#39;s ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too.
        /// </summary>
        /// <value>If you want to follow BNet&#39;s ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition {\n");
            sb.Append("  RewardEntryHash: ").Append(RewardEntryHash).Append("\n");
            sb.Append("  RewardEntryIdentifier: ").Append(RewardEntryIdentifier).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RewardEntryHash == input.RewardEntryHash ||
                    (this.RewardEntryHash != null &&
                    this.RewardEntryHash.Equals(input.RewardEntryHash))
                ) && 
                (
                    this.RewardEntryIdentifier == input.RewardEntryIdentifier ||
                    (this.RewardEntryIdentifier != null &&
                    this.RewardEntryIdentifier.Equals(input.RewardEntryIdentifier))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.VendorHash == input.VendorHash ||
                    (this.VendorHash != null &&
                    this.VendorHash.Equals(input.VendorHash))
                ) && 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
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
                if (this.RewardEntryHash != null)
                    hashCode = hashCode * 59 + this.RewardEntryHash.GetHashCode();
                if (this.RewardEntryIdentifier != null)
                    hashCode = hashCode * 59 + this.RewardEntryIdentifier.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.VendorHash != null)
                    hashCode = hashCode * 59 + this.VendorHash.GetHashCode();
                if (this.DisplayProperties != null)
                    hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
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
