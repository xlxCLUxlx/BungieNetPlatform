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
    /// This defines a single Step in a progression (which roughly equates to a level. See DestinyProgressionDefinition for caveats).
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyProgressionStepDefinition :  IEquatable<DestinyDefinitionsDestinyProgressionStepDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyProgressionStepDefinition" /> class.
        /// </summary>
        /// <param name="StepName">Very rarely, Progressions will have localized text describing the Level of the progression. This will be that localized text, if it exists. Otherwise, the standard appears to be to simply show the level numerically..</param>
        /// <param name="DisplayEffectType">This appears to be, when you \&quot;level up\&quot;, whether a visual effect will display and on what entity. See DestinyProgressionStepDisplayEffect for slightly more info..</param>
        /// <param name="ProgressTotal">The total amount of progression points/\&quot;experience\&quot; you will need to initially reach this step. If this is the last step and the progression is repeating indefinitely (DestinyProgressionDefinition.repeatLastStep), this will also be the progress needed to level it up further by repeating this step again..</param>
        /// <param name="RewardItems">A listing of items rewarded as a result of reaching this level..</param>
        public DestinyDefinitionsDestinyProgressionStepDefinition(string StepName = default(string), DestinyDestinyProgressionStepDisplayEffect DisplayEffectType = default(DestinyDestinyProgressionStepDisplayEffect), int? ProgressTotal = default(int?), List<DestinyDestinyItemQuantity> RewardItems = default(List<DestinyDestinyItemQuantity>))
        {
            this.StepName = StepName;
            this.DisplayEffectType = DisplayEffectType;
            this.ProgressTotal = ProgressTotal;
            this.RewardItems = RewardItems;
        }
        
        /// <summary>
        /// Very rarely, Progressions will have localized text describing the Level of the progression. This will be that localized text, if it exists. Otherwise, the standard appears to be to simply show the level numerically.
        /// </summary>
        /// <value>Very rarely, Progressions will have localized text describing the Level of the progression. This will be that localized text, if it exists. Otherwise, the standard appears to be to simply show the level numerically.</value>
        [DataMember(Name="stepName", EmitDefaultValue=false)]
        public string StepName { get; set; }

        /// <summary>
        /// This appears to be, when you \&quot;level up\&quot;, whether a visual effect will display and on what entity. See DestinyProgressionStepDisplayEffect for slightly more info.
        /// </summary>
        /// <value>This appears to be, when you \&quot;level up\&quot;, whether a visual effect will display and on what entity. See DestinyProgressionStepDisplayEffect for slightly more info.</value>
        [DataMember(Name="displayEffectType", EmitDefaultValue=false)]
        public DestinyDestinyProgressionStepDisplayEffect DisplayEffectType { get; set; }

        /// <summary>
        /// The total amount of progression points/\&quot;experience\&quot; you will need to initially reach this step. If this is the last step and the progression is repeating indefinitely (DestinyProgressionDefinition.repeatLastStep), this will also be the progress needed to level it up further by repeating this step again.
        /// </summary>
        /// <value>The total amount of progression points/\&quot;experience\&quot; you will need to initially reach this step. If this is the last step and the progression is repeating indefinitely (DestinyProgressionDefinition.repeatLastStep), this will also be the progress needed to level it up further by repeating this step again.</value>
        [DataMember(Name="progressTotal", EmitDefaultValue=false)]
        public int? ProgressTotal { get; set; }

        /// <summary>
        /// A listing of items rewarded as a result of reaching this level.
        /// </summary>
        /// <value>A listing of items rewarded as a result of reaching this level.</value>
        [DataMember(Name="rewardItems", EmitDefaultValue=false)]
        public List<DestinyDestinyItemQuantity> RewardItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyProgressionStepDefinition {\n");
            sb.Append("  StepName: ").Append(StepName).Append("\n");
            sb.Append("  DisplayEffectType: ").Append(DisplayEffectType).Append("\n");
            sb.Append("  ProgressTotal: ").Append(ProgressTotal).Append("\n");
            sb.Append("  RewardItems: ").Append(RewardItems).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyProgressionStepDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyProgressionStepDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyProgressionStepDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyProgressionStepDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StepName == input.StepName ||
                    (this.StepName != null &&
                    this.StepName.Equals(input.StepName))
                ) && 
                (
                    this.DisplayEffectType == input.DisplayEffectType ||
                    (this.DisplayEffectType != null &&
                    this.DisplayEffectType.Equals(input.DisplayEffectType))
                ) && 
                (
                    this.ProgressTotal == input.ProgressTotal ||
                    (this.ProgressTotal != null &&
                    this.ProgressTotal.Equals(input.ProgressTotal))
                ) && 
                (
                    this.RewardItems == input.RewardItems ||
                    this.RewardItems != null &&
                    this.RewardItems.SequenceEqual(input.RewardItems)
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
                if (this.StepName != null)
                    hashCode = hashCode * 59 + this.StepName.GetHashCode();
                if (this.DisplayEffectType != null)
                    hashCode = hashCode * 59 + this.DisplayEffectType.GetHashCode();
                if (this.ProgressTotal != null)
                    hashCode = hashCode * 59 + this.ProgressTotal.GetHashCode();
                if (this.RewardItems != null)
                    hashCode = hashCode * 59 + this.RewardItems.GetHashCode();
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
