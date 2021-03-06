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
    /// Any data we need to figure out whether this Quest Item is the currently active one for the conceptual Milestone. Even just typing this description, I already regret it.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition :  IEquatable<DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition" /> class.
        /// </summary>
        /// <param name="QuestItemHash">The item representing this Milestone quest. Use this hash to look up the DestinyInventoryItemDefinition for the quest to find its steps and human readable data..</param>
        /// <param name="DisplayProperties">The individual quests may have different definitions from the overall milestone: if there&#39;s a specific active quest, use these displayProperties instead of that of the overall DestinyMilestoneDefinition..</param>
        /// <param name="OverrideImage">If populated, this image can be shown instead of the generic milestone&#39;s image when this quest is live, or it can be used to show a background image for the quest itself that differs from that of the Activity or the Milestone..</param>
        /// <param name="QuestRewards">The rewards you will get for completing this quest, as best as we could extract them from our data. Sometimes, it&#39;ll be a decent amount of data. Sometimes, it&#39;s going to be sucky. Sorry..</param>
        /// <param name="Activities">The full set of all possible \&quot;conceptual activities\&quot; that are related to this Milestone. Tiers or alternative modes of play within these conceptual activities will be defined as sub-entities. Keyed by the Conceptual Activity Hash. Use the key to look up DestinyActivityDefinition..</param>
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition(uint? QuestItemHash = default(uint?), DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), string OverrideImage = default(string), DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition QuestRewards = default(DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition), Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition> Activities = default(Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition>))
        {
            this.QuestItemHash = QuestItemHash;
            this.DisplayProperties = DisplayProperties;
            this.OverrideImage = OverrideImage;
            this.QuestRewards = QuestRewards;
            this.Activities = Activities;
        }
        
        /// <summary>
        /// The item representing this Milestone quest. Use this hash to look up the DestinyInventoryItemDefinition for the quest to find its steps and human readable data.
        /// </summary>
        /// <value>The item representing this Milestone quest. Use this hash to look up the DestinyInventoryItemDefinition for the quest to find its steps and human readable data.</value>
        [DataMember(Name="questItemHash", EmitDefaultValue=false)]
        public uint? QuestItemHash { get; set; }

        /// <summary>
        /// The individual quests may have different definitions from the overall milestone: if there&#39;s a specific active quest, use these displayProperties instead of that of the overall DestinyMilestoneDefinition.
        /// </summary>
        /// <value>The individual quests may have different definitions from the overall milestone: if there&#39;s a specific active quest, use these displayProperties instead of that of the overall DestinyMilestoneDefinition.</value>
        [DataMember(Name="displayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// If populated, this image can be shown instead of the generic milestone&#39;s image when this quest is live, or it can be used to show a background image for the quest itself that differs from that of the Activity or the Milestone.
        /// </summary>
        /// <value>If populated, this image can be shown instead of the generic milestone&#39;s image when this quest is live, or it can be used to show a background image for the quest itself that differs from that of the Activity or the Milestone.</value>
        [DataMember(Name="overrideImage", EmitDefaultValue=false)]
        public string OverrideImage { get; set; }

        /// <summary>
        /// The rewards you will get for completing this quest, as best as we could extract them from our data. Sometimes, it&#39;ll be a decent amount of data. Sometimes, it&#39;s going to be sucky. Sorry.
        /// </summary>
        /// <value>The rewards you will get for completing this quest, as best as we could extract them from our data. Sometimes, it&#39;ll be a decent amount of data. Sometimes, it&#39;s going to be sucky. Sorry.</value>
        [DataMember(Name="questRewards", EmitDefaultValue=false)]
        public DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition QuestRewards { get; set; }

        /// <summary>
        /// The full set of all possible \&quot;conceptual activities\&quot; that are related to this Milestone. Tiers or alternative modes of play within these conceptual activities will be defined as sub-entities. Keyed by the Conceptual Activity Hash. Use the key to look up DestinyActivityDefinition.
        /// </summary>
        /// <value>The full set of all possible \&quot;conceptual activities\&quot; that are related to this Milestone. Tiers or alternative modes of play within these conceptual activities will be defined as sub-entities. Keyed by the Conceptual Activity Hash. Use the key to look up DestinyActivityDefinition.</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public Dictionary<string, DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition> Activities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition {\n");
            sb.Append("  QuestItemHash: ").Append(QuestItemHash).Append("\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  OverrideImage: ").Append(OverrideImage).Append("\n");
            sb.Append("  QuestRewards: ").Append(QuestRewards).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuestItemHash == input.QuestItemHash ||
                    (this.QuestItemHash != null &&
                    this.QuestItemHash.Equals(input.QuestItemHash))
                ) && 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.OverrideImage == input.OverrideImage ||
                    (this.OverrideImage != null &&
                    this.OverrideImage.Equals(input.OverrideImage))
                ) && 
                (
                    this.QuestRewards == input.QuestRewards ||
                    (this.QuestRewards != null &&
                    this.QuestRewards.Equals(input.QuestRewards))
                ) && 
                (
                    this.Activities == input.Activities ||
                    this.Activities != null &&
                    this.Activities.SequenceEqual(input.Activities)
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
                if (this.QuestItemHash != null)
                    hashCode = hashCode * 59 + this.QuestItemHash.GetHashCode();
                if (this.DisplayProperties != null)
                    hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
                if (this.OverrideImage != null)
                    hashCode = hashCode * 59 + this.OverrideImage.GetHashCode();
                if (this.QuestRewards != null)
                    hashCode = hashCode * 59 + this.QuestRewards.GetHashCode();
                if (this.Activities != null)
                    hashCode = hashCode * 59 + this.Activities.GetHashCode();
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
