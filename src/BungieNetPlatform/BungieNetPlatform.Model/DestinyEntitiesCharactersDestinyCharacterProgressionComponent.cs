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
    /// This component returns anything that could be considered \&quot;Progression\&quot; on a user: data where the user is gaining levels, reputation, completions, rewards, etc...
    /// </summary>
    [DataContract]
    public partial class DestinyEntitiesCharactersDestinyCharacterProgressionComponent :  IEquatable<DestinyEntitiesCharactersDestinyCharacterProgressionComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesCharactersDestinyCharacterProgressionComponent" /> class.
        /// </summary>
        /// <param name="Progressions">A Dictionary of all known progressions for the Character, keyed by the Progression&#39;s hash.  Not all progressions have user-facing data, but those who do will have that data contained in the DestinyProgressionDefinition..</param>
        /// <param name="Factions">A dictionary of all known Factions, keyed by the Faction&#39;s hash. It contains data about this character&#39;s status with the faction..</param>
        /// <param name="Milestones">Milestones are related to the simple progressions shown in the game, but return additional and hopefully helpful information for users about the specifics of the Milestone&#39;s status..</param>
        /// <param name="Quests">If the user has any active quests, the quests&#39; statuses will be returned here.  Note that quests have been largely supplanted by Milestones, but that doesn&#39;t mean that they won&#39;t make a comeback independent of milestones at some point..</param>
        /// <param name="UninstancedItemObjectives">Sometimes, you have items in your inventory that don&#39;t have instances, but still have Objective information. This provides you that objective information for uninstanced items.   This dictionary is keyed by the item&#39;s hash: which you can use to look up the name and description for the overall task(s) implied by the objective. The value is the list of objectives for this item, and their statuses..</param>
        public DestinyEntitiesCharactersDestinyCharacterProgressionComponent(Dictionary<string, DestinyDestinyProgression> Progressions = default(Dictionary<string, DestinyDestinyProgression>), Dictionary<string, DestinyProgressionDestinyFactionProgression> Factions = default(Dictionary<string, DestinyProgressionDestinyFactionProgression>), Dictionary<string, DestinyMilestonesDestinyMilestone> Milestones = default(Dictionary<string, DestinyMilestonesDestinyMilestone>), List<DestinyQuestsDestinyQuestStatus> Quests = default(List<DestinyQuestsDestinyQuestStatus>), Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> UninstancedItemObjectives = default(Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>>))
        {
            this.Progressions = Progressions;
            this.Factions = Factions;
            this.Milestones = Milestones;
            this.Quests = Quests;
            this.UninstancedItemObjectives = UninstancedItemObjectives;
        }
        
        /// <summary>
        /// A Dictionary of all known progressions for the Character, keyed by the Progression&#39;s hash.  Not all progressions have user-facing data, but those who do will have that data contained in the DestinyProgressionDefinition.
        /// </summary>
        /// <value>A Dictionary of all known progressions for the Character, keyed by the Progression&#39;s hash.  Not all progressions have user-facing data, but those who do will have that data contained in the DestinyProgressionDefinition.</value>
        [DataMember(Name="progressions", EmitDefaultValue=false)]
        public Dictionary<string, DestinyDestinyProgression> Progressions { get; set; }

        /// <summary>
        /// A dictionary of all known Factions, keyed by the Faction&#39;s hash. It contains data about this character&#39;s status with the faction.
        /// </summary>
        /// <value>A dictionary of all known Factions, keyed by the Faction&#39;s hash. It contains data about this character&#39;s status with the faction.</value>
        [DataMember(Name="factions", EmitDefaultValue=false)]
        public Dictionary<string, DestinyProgressionDestinyFactionProgression> Factions { get; set; }

        /// <summary>
        /// Milestones are related to the simple progressions shown in the game, but return additional and hopefully helpful information for users about the specifics of the Milestone&#39;s status.
        /// </summary>
        /// <value>Milestones are related to the simple progressions shown in the game, but return additional and hopefully helpful information for users about the specifics of the Milestone&#39;s status.</value>
        [DataMember(Name="milestones", EmitDefaultValue=false)]
        public Dictionary<string, DestinyMilestonesDestinyMilestone> Milestones { get; set; }

        /// <summary>
        /// If the user has any active quests, the quests&#39; statuses will be returned here.  Note that quests have been largely supplanted by Milestones, but that doesn&#39;t mean that they won&#39;t make a comeback independent of milestones at some point.
        /// </summary>
        /// <value>If the user has any active quests, the quests&#39; statuses will be returned here.  Note that quests have been largely supplanted by Milestones, but that doesn&#39;t mean that they won&#39;t make a comeback independent of milestones at some point.</value>
        [DataMember(Name="quests", EmitDefaultValue=false)]
        public List<DestinyQuestsDestinyQuestStatus> Quests { get; set; }

        /// <summary>
        /// Sometimes, you have items in your inventory that don&#39;t have instances, but still have Objective information. This provides you that objective information for uninstanced items.   This dictionary is keyed by the item&#39;s hash: which you can use to look up the name and description for the overall task(s) implied by the objective. The value is the list of objectives for this item, and their statuses.
        /// </summary>
        /// <value>Sometimes, you have items in your inventory that don&#39;t have instances, but still have Objective information. This provides you that objective information for uninstanced items.   This dictionary is keyed by the item&#39;s hash: which you can use to look up the name and description for the overall task(s) implied by the objective. The value is the list of objectives for this item, and their statuses.</value>
        [DataMember(Name="uninstancedItemObjectives", EmitDefaultValue=false)]
        public Dictionary<string, List<DestinyQuestsDestinyObjectiveProgress>> UninstancedItemObjectives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyEntitiesCharactersDestinyCharacterProgressionComponent {\n");
            sb.Append("  Progressions: ").Append(Progressions).Append("\n");
            sb.Append("  Factions: ").Append(Factions).Append("\n");
            sb.Append("  Milestones: ").Append(Milestones).Append("\n");
            sb.Append("  Quests: ").Append(Quests).Append("\n");
            sb.Append("  UninstancedItemObjectives: ").Append(UninstancedItemObjectives).Append("\n");
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
            return this.Equals(input as DestinyEntitiesCharactersDestinyCharacterProgressionComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesCharactersDestinyCharacterProgressionComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesCharactersDestinyCharacterProgressionComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesCharactersDestinyCharacterProgressionComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Progressions == input.Progressions ||
                    this.Progressions != null &&
                    this.Progressions.SequenceEqual(input.Progressions)
                ) && 
                (
                    this.Factions == input.Factions ||
                    this.Factions != null &&
                    this.Factions.SequenceEqual(input.Factions)
                ) && 
                (
                    this.Milestones == input.Milestones ||
                    this.Milestones != null &&
                    this.Milestones.SequenceEqual(input.Milestones)
                ) && 
                (
                    this.Quests == input.Quests ||
                    this.Quests != null &&
                    this.Quests.SequenceEqual(input.Quests)
                ) && 
                (
                    this.UninstancedItemObjectives == input.UninstancedItemObjectives ||
                    this.UninstancedItemObjectives != null &&
                    this.UninstancedItemObjectives.SequenceEqual(input.UninstancedItemObjectives)
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
                if (this.Progressions != null)
                    hashCode = hashCode * 59 + this.Progressions.GetHashCode();
                if (this.Factions != null)
                    hashCode = hashCode * 59 + this.Factions.GetHashCode();
                if (this.Milestones != null)
                    hashCode = hashCode * 59 + this.Milestones.GetHashCode();
                if (this.Quests != null)
                    hashCode = hashCode * 59 + this.Quests.GetHashCode();
                if (this.UninstancedItemObjectives != null)
                    hashCode = hashCode * 59 + this.UninstancedItemObjectives.GetHashCode();
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
