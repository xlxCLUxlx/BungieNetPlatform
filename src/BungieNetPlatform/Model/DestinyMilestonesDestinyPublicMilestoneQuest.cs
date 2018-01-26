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
    /// DestinyMilestonesDestinyPublicMilestoneQuest
    /// </summary>
    [DataContract]
    public partial class DestinyMilestonesDestinyPublicMilestoneQuest :  IEquatable<DestinyMilestonesDestinyPublicMilestoneQuest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMilestonesDestinyPublicMilestoneQuest" /> class.
        /// </summary>
        /// <param name="QuestItemHash">Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data..</param>
        /// <param name="Activity">A milestone need not have an active activity, but if there is one it will be returned here, along with any variant and additional information..</param>
        /// <param name="Challenges">For the given quest there could be 0-to-Many challenges: mini quests that you can perform in the course of doing this quest, that may grant you rewards and benefits..</param>
        public DestinyMilestonesDestinyPublicMilestoneQuest(uint? QuestItemHash = default(uint?), DestinyMilestonesDestinyPublicMilestoneActivity Activity = default(DestinyMilestonesDestinyPublicMilestoneActivity), List<DestinyMilestonesDestinyPublicMilestoneChallenge> Challenges = default(List<DestinyMilestonesDestinyPublicMilestoneChallenge>))
        {
            this.QuestItemHash = QuestItemHash;
            this.Activity = Activity;
            this.Challenges = Challenges;
        }
        
        /// <summary>
        /// Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.
        /// </summary>
        /// <value>Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data.</value>
        [DataMember(Name="questItemHash", EmitDefaultValue=false)]
        public uint? QuestItemHash { get; set; }

        /// <summary>
        /// A milestone need not have an active activity, but if there is one it will be returned here, along with any variant and additional information.
        /// </summary>
        /// <value>A milestone need not have an active activity, but if there is one it will be returned here, along with any variant and additional information.</value>
        [DataMember(Name="activity", EmitDefaultValue=false)]
        public DestinyMilestonesDestinyPublicMilestoneActivity Activity { get; set; }

        /// <summary>
        /// For the given quest there could be 0-to-Many challenges: mini quests that you can perform in the course of doing this quest, that may grant you rewards and benefits.
        /// </summary>
        /// <value>For the given quest there could be 0-to-Many challenges: mini quests that you can perform in the course of doing this quest, that may grant you rewards and benefits.</value>
        [DataMember(Name="challenges", EmitDefaultValue=false)]
        public List<DestinyMilestonesDestinyPublicMilestoneChallenge> Challenges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyMilestonesDestinyPublicMilestoneQuest {\n");
            sb.Append("  QuestItemHash: ").Append(QuestItemHash).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("  Challenges: ").Append(Challenges).Append("\n");
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
            return this.Equals(input as DestinyMilestonesDestinyPublicMilestoneQuest);
        }

        /// <summary>
        /// Returns true if DestinyMilestonesDestinyPublicMilestoneQuest instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMilestonesDestinyPublicMilestoneQuest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMilestonesDestinyPublicMilestoneQuest input)
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
                    this.Activity == input.Activity ||
                    (this.Activity != null &&
                    this.Activity.Equals(input.Activity))
                ) && 
                (
                    this.Challenges == input.Challenges ||
                    this.Challenges != null &&
                    this.Challenges.SequenceEqual(input.Challenges)
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
                if (this.Activity != null)
                    hashCode = hashCode * 59 + this.Activity.GetHashCode();
                if (this.Challenges != null)
                    hashCode = hashCode * 59 + this.Challenges.GetHashCode();
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
