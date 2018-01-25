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
    /// Defines the conditions under which an intrinsic perk is applied while participating in an Objective.  These perks will generally not be benefit-granting perks, but rather a perk that modifies gameplay in some interesting way.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyObjectivePerkEntryDefinition :  IEquatable<DestinyDefinitionsDestinyObjectivePerkEntryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyObjectivePerkEntryDefinition" /> class.
        /// </summary>
        /// <param name="PerkHash">The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character..</param>
        /// <param name="Style">An enumeration indicating whether it will be applied as long as the Objective is active, when it&#39;s completed, or until it&#39;s completed..</param>
        public DestinyDefinitionsDestinyObjectivePerkEntryDefinition(uint? PerkHash = default(uint?), DestinyDestinyObjectiveGrantStyle Style = default(DestinyDestinyObjectiveGrantStyle))
        {
            this.PerkHash = PerkHash;
            this.Style = Style;
        }
        
        /// <summary>
        /// The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character.
        /// </summary>
        /// <value>The hash identifier of the DestinySandboxPerkDefinition that will be applied to the character.</value>
        [DataMember(Name="perkHash", EmitDefaultValue=false)]
        public uint? PerkHash { get; set; }

        /// <summary>
        /// An enumeration indicating whether it will be applied as long as the Objective is active, when it&#39;s completed, or until it&#39;s completed.
        /// </summary>
        /// <value>An enumeration indicating whether it will be applied as long as the Objective is active, when it&#39;s completed, or until it&#39;s completed.</value>
        [DataMember(Name="style", EmitDefaultValue=false)]
        public DestinyDestinyObjectiveGrantStyle Style { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyObjectivePerkEntryDefinition {\n");
            sb.Append("  PerkHash: ").Append(PerkHash).Append("\n");
            sb.Append("  Style: ").Append(Style).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyObjectivePerkEntryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyObjectivePerkEntryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyObjectivePerkEntryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyObjectivePerkEntryDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PerkHash == input.PerkHash ||
                    (this.PerkHash != null &&
                    this.PerkHash.Equals(input.PerkHash))
                ) && 
                (
                    this.Style == input.Style ||
                    (this.Style != null &&
                    this.Style.Equals(input.Style))
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
                if (this.PerkHash != null)
                    hashCode = hashCode * 59 + this.PerkHash.GetHashCode();
                if (this.Style != null)
                    hashCode = hashCode * 59 + this.Style.GetHashCode();
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