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
    /// Represents a runtime instance of a user&#39;s milestone status. Live Milestone data should be combined with DestinyMilestoneDefinition data to show the user a picture of what is available for them to do in the game, and their status in regards to said \&quot;things to do.\&quot; Consider it a big, wonky to-do list, or Advisors 3.0 for those who remember the Destiny 1 API.
    /// </summary>
    [DataContract]
    public partial class DestinyMilestonesDestinyMilestone :  IEquatable<DestinyMilestonesDestinyMilestone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyMilestone" /> class.
        /// </summary>
        /// <param name="MilestoneHash">The unique identifier for the Milestone. Use it to look up the DestinyMilestoneDefinition, so you can combine the other data in this contract with static definition data..</param>
        /// <param name="AvailableQuests">Indicates what quests are available for this Milestone. Usually this will be only a single Quest, but some quests have multiple available that you can choose from at any given time. All possible quests for a milestone can be found in the DestinyMilestoneDefinition, but they must be combined with this Live data to determine which one(s) are actually active right now. It is possible for Milestones to not have any quests..</param>
        /// <param name="Values">Milestones may have arbitrary key/value pairs associated with them, for data that users will want to know about but that doesn&#39;t fit neatly into any of the common components such as Quests. A good example of this would be - if this existed in Destiny 1 - the number of wins you currently have on your Trials of Osiris ticket. Looking in the DestinyMilestoneDefinition, you can use the string identifier of this dictionary to look up more info about the value, including localized string content for displaying the value. The value in the dictionary is the floating point number. The definition will tell you how to format this number..</param>
        /// <param name="VendorHashes">A milestone may have one or more active vendors that are \&quot;related\&quot; to it (that provide rewards, or that are the initiators of the Milestone). I already regret this, even as I&#39;m typing it. [I told you I&#39;d regret this] You see, sometimes a milestone may be directly correlated with a set of vendors that provide varying tiers of rewards. The player may not be able to interact with one or more of those vendors. This will return the hashes of the Vendors that the player *can* interact with, allowing you to show their current inventory as rewards or related items to the Milestone or its activities.  Before we even use it, it&#39;s already deprecated! How much of a bummer is that? We need more data..</param>
        /// <param name="Vendors">Replaces vendorHashes, which I knew was going to be trouble the day it walked in the door. This will return not only what Vendors are active and relevant to the activity (in an implied order that you can choose to ignore), but also other data - for example, if the Vendor is featuring a specific item relevant to this event that you should show with them..</param>
        /// <param name="Rewards">If the entity to which this component is attached has known active Rewards for the player, this will detail information about those rewards, keyed by the RewardEntry Hash. (See DestinyMilestoneDefinition for more information about Reward Entries) Note that these rewards are not for the Quests related to the Milestone. Think of these as \&quot;overview/checklist\&quot; rewards that may be provided for Milestones that may provide rewards for performing a variety of tasks that aren&#39;t under a specific Quest..</param>
        /// <param name="StartDate">If known, this is the date when the event last began or refreshed. It will only be populated for events with fixed and repeating start and end dates..</param>
        /// <param name="EndDate">If known, this is the date when the event will next end or repeat. It will only be populated for events with fixed and repeating start and end dates..</param>
        public DestinyMilestonesDestinyMilestone(uint? MilestoneHash = default(uint?), List<DestinyMilestonesDestinyMilestoneQuest> AvailableQuests = default(List<DestinyMilestonesDestinyMilestoneQuest>), Dictionary<string, float?> Values = default(Dictionary<string, float?>), List<uint?> VendorHashes = default(List<uint?>), List<DestinyMilestonesDestinyMilestoneVendor> Vendors = default(List<DestinyMilestonesDestinyMilestoneVendor>), List<DestinyMilestonesDestinyMilestoneRewardCategory> Rewards = default(List<DestinyMilestonesDestinyMilestoneRewardCategory>), DateTime? StartDate = default(DateTime?), DateTime? EndDate = default(DateTime?))
        {
            this.MilestoneHash = MilestoneHash;
            this.AvailableQuests = AvailableQuests;
            this.Values = Values;
            this.VendorHashes = VendorHashes;
            this.Vendors = Vendors;
            this.Rewards = Rewards;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
        
        /// <summary>
        /// The unique identifier for the Milestone. Use it to look up the DestinyMilestoneDefinition, so you can combine the other data in this contract with static definition data.
        /// </summary>
        /// <value>The unique identifier for the Milestone. Use it to look up the DestinyMilestoneDefinition, so you can combine the other data in this contract with static definition data.</value>
        [DataMember(Name="milestoneHash", EmitDefaultValue=false)]
        public uint? MilestoneHash { get; set; }

        /// <summary>
        /// Indicates what quests are available for this Milestone. Usually this will be only a single Quest, but some quests have multiple available that you can choose from at any given time. All possible quests for a milestone can be found in the DestinyMilestoneDefinition, but they must be combined with this Live data to determine which one(s) are actually active right now. It is possible for Milestones to not have any quests.
        /// </summary>
        /// <value>Indicates what quests are available for this Milestone. Usually this will be only a single Quest, but some quests have multiple available that you can choose from at any given time. All possible quests for a milestone can be found in the DestinyMilestoneDefinition, but they must be combined with this Live data to determine which one(s) are actually active right now. It is possible for Milestones to not have any quests.</value>
        [DataMember(Name="availableQuests", EmitDefaultValue=false)]
        public List<DestinyMilestonesDestinyMilestoneQuest> AvailableQuests { get; set; }

        /// <summary>
        /// Milestones may have arbitrary key/value pairs associated with them, for data that users will want to know about but that doesn&#39;t fit neatly into any of the common components such as Quests. A good example of this would be - if this existed in Destiny 1 - the number of wins you currently have on your Trials of Osiris ticket. Looking in the DestinyMilestoneDefinition, you can use the string identifier of this dictionary to look up more info about the value, including localized string content for displaying the value. The value in the dictionary is the floating point number. The definition will tell you how to format this number.
        /// </summary>
        /// <value>Milestones may have arbitrary key/value pairs associated with them, for data that users will want to know about but that doesn&#39;t fit neatly into any of the common components such as Quests. A good example of this would be - if this existed in Destiny 1 - the number of wins you currently have on your Trials of Osiris ticket. Looking in the DestinyMilestoneDefinition, you can use the string identifier of this dictionary to look up more info about the value, including localized string content for displaying the value. The value in the dictionary is the floating point number. The definition will tell you how to format this number.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public Dictionary<string, float?> Values { get; set; }

        /// <summary>
        /// A milestone may have one or more active vendors that are \&quot;related\&quot; to it (that provide rewards, or that are the initiators of the Milestone). I already regret this, even as I&#39;m typing it. [I told you I&#39;d regret this] You see, sometimes a milestone may be directly correlated with a set of vendors that provide varying tiers of rewards. The player may not be able to interact with one or more of those vendors. This will return the hashes of the Vendors that the player *can* interact with, allowing you to show their current inventory as rewards or related items to the Milestone or its activities.  Before we even use it, it&#39;s already deprecated! How much of a bummer is that? We need more data.
        /// </summary>
        /// <value>A milestone may have one or more active vendors that are \&quot;related\&quot; to it (that provide rewards, or that are the initiators of the Milestone). I already regret this, even as I&#39;m typing it. [I told you I&#39;d regret this] You see, sometimes a milestone may be directly correlated with a set of vendors that provide varying tiers of rewards. The player may not be able to interact with one or more of those vendors. This will return the hashes of the Vendors that the player *can* interact with, allowing you to show their current inventory as rewards or related items to the Milestone or its activities.  Before we even use it, it&#39;s already deprecated! How much of a bummer is that? We need more data.</value>
        [DataMember(Name="vendorHashes", EmitDefaultValue=false)]
        public List<uint?> VendorHashes { get; set; }

        /// <summary>
        /// Replaces vendorHashes, which I knew was going to be trouble the day it walked in the door. This will return not only what Vendors are active and relevant to the activity (in an implied order that you can choose to ignore), but also other data - for example, if the Vendor is featuring a specific item relevant to this event that you should show with them.
        /// </summary>
        /// <value>Replaces vendorHashes, which I knew was going to be trouble the day it walked in the door. This will return not only what Vendors are active and relevant to the activity (in an implied order that you can choose to ignore), but also other data - for example, if the Vendor is featuring a specific item relevant to this event that you should show with them.</value>
        [DataMember(Name="vendors", EmitDefaultValue=false)]
        public List<DestinyMilestonesDestinyMilestoneVendor> Vendors { get; set; }

        /// <summary>
        /// If the entity to which this component is attached has known active Rewards for the player, this will detail information about those rewards, keyed by the RewardEntry Hash. (See DestinyMilestoneDefinition for more information about Reward Entries) Note that these rewards are not for the Quests related to the Milestone. Think of these as \&quot;overview/checklist\&quot; rewards that may be provided for Milestones that may provide rewards for performing a variety of tasks that aren&#39;t under a specific Quest.
        /// </summary>
        /// <value>If the entity to which this component is attached has known active Rewards for the player, this will detail information about those rewards, keyed by the RewardEntry Hash. (See DestinyMilestoneDefinition for more information about Reward Entries) Note that these rewards are not for the Quests related to the Milestone. Think of these as \&quot;overview/checklist\&quot; rewards that may be provided for Milestones that may provide rewards for performing a variety of tasks that aren&#39;t under a specific Quest.</value>
        [DataMember(Name="rewards", EmitDefaultValue=false)]
        public List<DestinyMilestonesDestinyMilestoneRewardCategory> Rewards { get; set; }

        /// <summary>
        /// If known, this is the date when the event last began or refreshed. It will only be populated for events with fixed and repeating start and end dates.
        /// </summary>
        /// <value>If known, this is the date when the event last began or refreshed. It will only be populated for events with fixed and repeating start and end dates.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// If known, this is the date when the event will next end or repeat. It will only be populated for events with fixed and repeating start and end dates.
        /// </summary>
        /// <value>If known, this is the date when the event will next end or repeat. It will only be populated for events with fixed and repeating start and end dates.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyMilestone {\n");
            sb.Append("  MilestoneHash: ").Append(MilestoneHash).Append("\n");
            sb.Append("  AvailableQuests: ").Append(AvailableQuests).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  VendorHashes: ").Append(VendorHashes).Append("\n");
            sb.Append("  Vendors: ").Append(Vendors).Append("\n");
            sb.Append("  Rewards: ").Append(Rewards).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyMilestone);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyMilestone instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyMilestone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyMilestone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MilestoneHash == input.MilestoneHash ||
                    (this.MilestoneHash != null &&
                    this.MilestoneHash.Equals(input.MilestoneHash))
                ) && 
                (
                    this.AvailableQuests == input.AvailableQuests ||
                    this.AvailableQuests != null &&
                    this.AvailableQuests.SequenceEqual(input.AvailableQuests)
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.VendorHashes == input.VendorHashes ||
                    this.VendorHashes != null &&
                    this.VendorHashes.SequenceEqual(input.VendorHashes)
                ) && 
                (
                    this.Vendors == input.Vendors ||
                    this.Vendors != null &&
                    this.Vendors.SequenceEqual(input.Vendors)
                ) && 
                (
                    this.Rewards == input.Rewards ||
                    this.Rewards != null &&
                    this.Rewards.SequenceEqual(input.Rewards)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.MilestoneHash != null)
                    hashCode = hashCode * 59 + this.MilestoneHash.GetHashCode();
                if (this.AvailableQuests != null)
                    hashCode = hashCode * 59 + this.AvailableQuests.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.VendorHashes != null)
                    hashCode = hashCode * 59 + this.VendorHashes.GetHashCode();
                if (this.Vendors != null)
                    hashCode = hashCode * 59 + this.Vendors.GetHashCode();
                if (this.Rewards != null)
                    hashCode = hashCode * 59 + this.Rewards.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
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