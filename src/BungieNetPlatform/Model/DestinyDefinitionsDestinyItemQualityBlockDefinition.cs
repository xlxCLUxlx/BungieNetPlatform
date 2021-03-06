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
    /// An item&#39;s \&quot;Quality\&quot; determines its calculated stats. The Level at which the item spawns is combined with its \&quot;qualityLevel\&quot; along with some additional calculations to determine the value of those stats.  In Destiny 2, most items don&#39;t have default item levels and quality, making this property less useful: these apparently are almost always determined by the complex mechanisms of the Reward system rather than statically. They are still provided here in case they are still useful for people. This also contains some information about Infusion.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyItemQualityBlockDefinition :  IEquatable<DestinyDefinitionsDestinyItemQualityBlockDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemQualityBlockDefinition" /> class.
        /// </summary>
        /// <param name="ItemLevels">The \&quot;base\&quot; defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.  In practice, not only was that never done in Destiny 1, but now this isn&#39;t even populated at all. When it&#39;s not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result..</param>
        /// <param name="QualityLevel">qualityLevel is used in combination with the item&#39;s level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does..</param>
        /// <param name="InfusionCategoryName">The string identifier for this item&#39;s \&quot;infusability\&quot;, if any.   Items that match the same infusionCategoryName are allowed to infuse with each other..</param>
        /// <param name="InfusionCategoryHash">The hash identifier for the infusion. It does not map to a Definition entity..</param>
        /// <param name="ProgressionLevelRequirementHash">An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition..</param>
        public DestinyDefinitionsDestinyItemQualityBlockDefinition(List<int?> ItemLevels = default(List<int?>), int? QualityLevel = default(int?), string InfusionCategoryName = default(string), uint? InfusionCategoryHash = default(uint?), uint? ProgressionLevelRequirementHash = default(uint?))
        {
            this.ItemLevels = ItemLevels;
            this.QualityLevel = QualityLevel;
            this.InfusionCategoryName = InfusionCategoryName;
            this.InfusionCategoryHash = InfusionCategoryHash;
            this.ProgressionLevelRequirementHash = ProgressionLevelRequirementHash;
        }
        
        /// <summary>
        /// The \&quot;base\&quot; defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.  In practice, not only was that never done in Destiny 1, but now this isn&#39;t even populated at all. When it&#39;s not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result.
        /// </summary>
        /// <value>The \&quot;base\&quot; defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.  In practice, not only was that never done in Destiny 1, but now this isn&#39;t even populated at all. When it&#39;s not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result.</value>
        [DataMember(Name="itemLevels", EmitDefaultValue=false)]
        public List<int?> ItemLevels { get; set; }

        /// <summary>
        /// qualityLevel is used in combination with the item&#39;s level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does.
        /// </summary>
        /// <value>qualityLevel is used in combination with the item&#39;s level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does.</value>
        [DataMember(Name="qualityLevel", EmitDefaultValue=false)]
        public int? QualityLevel { get; set; }

        /// <summary>
        /// The string identifier for this item&#39;s \&quot;infusability\&quot;, if any.   Items that match the same infusionCategoryName are allowed to infuse with each other.
        /// </summary>
        /// <value>The string identifier for this item&#39;s \&quot;infusability\&quot;, if any.   Items that match the same infusionCategoryName are allowed to infuse with each other.</value>
        [DataMember(Name="infusionCategoryName", EmitDefaultValue=false)]
        public string InfusionCategoryName { get; set; }

        /// <summary>
        /// The hash identifier for the infusion. It does not map to a Definition entity.
        /// </summary>
        /// <value>The hash identifier for the infusion. It does not map to a Definition entity.</value>
        [DataMember(Name="infusionCategoryHash", EmitDefaultValue=false)]
        public uint? InfusionCategoryHash { get; set; }

        /// <summary>
        /// An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.
        /// </summary>
        /// <value>An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.</value>
        [DataMember(Name="progressionLevelRequirementHash", EmitDefaultValue=false)]
        public uint? ProgressionLevelRequirementHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemQualityBlockDefinition {\n");
            sb.Append("  ItemLevels: ").Append(ItemLevels).Append("\n");
            sb.Append("  QualityLevel: ").Append(QualityLevel).Append("\n");
            sb.Append("  InfusionCategoryName: ").Append(InfusionCategoryName).Append("\n");
            sb.Append("  InfusionCategoryHash: ").Append(InfusionCategoryHash).Append("\n");
            sb.Append("  ProgressionLevelRequirementHash: ").Append(ProgressionLevelRequirementHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemQualityBlockDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemQualityBlockDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemQualityBlockDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemQualityBlockDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemLevels == input.ItemLevels ||
                    this.ItemLevels != null &&
                    this.ItemLevels.SequenceEqual(input.ItemLevels)
                ) && 
                (
                    this.QualityLevel == input.QualityLevel ||
                    (this.QualityLevel != null &&
                    this.QualityLevel.Equals(input.QualityLevel))
                ) && 
                (
                    this.InfusionCategoryName == input.InfusionCategoryName ||
                    (this.InfusionCategoryName != null &&
                    this.InfusionCategoryName.Equals(input.InfusionCategoryName))
                ) && 
                (
                    this.InfusionCategoryHash == input.InfusionCategoryHash ||
                    (this.InfusionCategoryHash != null &&
                    this.InfusionCategoryHash.Equals(input.InfusionCategoryHash))
                ) && 
                (
                    this.ProgressionLevelRequirementHash == input.ProgressionLevelRequirementHash ||
                    (this.ProgressionLevelRequirementHash != null &&
                    this.ProgressionLevelRequirementHash.Equals(input.ProgressionLevelRequirementHash))
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
                if (this.ItemLevels != null)
                    hashCode = hashCode * 59 + this.ItemLevels.GetHashCode();
                if (this.QualityLevel != null)
                    hashCode = hashCode * 59 + this.QualityLevel.GetHashCode();
                if (this.InfusionCategoryName != null)
                    hashCode = hashCode * 59 + this.InfusionCategoryName.GetHashCode();
                if (this.InfusionCategoryHash != null)
                    hashCode = hashCode * 59 + this.InfusionCategoryHash.GetHashCode();
                if (this.ProgressionLevelRequirementHash != null)
                    hashCode = hashCode * 59 + this.ProgressionLevelRequirementHash.GetHashCode();
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
