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
    /// Guided Game information for this activity.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyActivityGuidedBlockDefinition :  IEquatable<DestinyDefinitionsDestinyActivityGuidedBlockDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyActivityGuidedBlockDefinition" /> class.
        /// </summary>
        /// <param name="GuidedMaxLobbySize">The maximum amount of people that can be in the waiting lobby..</param>
        /// <param name="GuidedMinLobbySize">The minimum amount of people that can be in the waiting lobby..</param>
        /// <param name="GuidedDisbandCount">If -1, the guided group cannot be disbanded. Otherwise, take the total # of players in the activity and subtract this number: that is the total # of votes needed for the guided group to disband..</param>
        public DestinyDefinitionsDestinyActivityGuidedBlockDefinition(int? GuidedMaxLobbySize = default(int?), int? GuidedMinLobbySize = default(int?), int? GuidedDisbandCount = default(int?))
        {
            this.GuidedMaxLobbySize = GuidedMaxLobbySize;
            this.GuidedMinLobbySize = GuidedMinLobbySize;
            this.GuidedDisbandCount = GuidedDisbandCount;
        }
        
        /// <summary>
        /// The maximum amount of people that can be in the waiting lobby.
        /// </summary>
        /// <value>The maximum amount of people that can be in the waiting lobby.</value>
        [DataMember(Name="guidedMaxLobbySize", EmitDefaultValue=false)]
        public int? GuidedMaxLobbySize { get; set; }

        /// <summary>
        /// The minimum amount of people that can be in the waiting lobby.
        /// </summary>
        /// <value>The minimum amount of people that can be in the waiting lobby.</value>
        [DataMember(Name="guidedMinLobbySize", EmitDefaultValue=false)]
        public int? GuidedMinLobbySize { get; set; }

        /// <summary>
        /// If -1, the guided group cannot be disbanded. Otherwise, take the total # of players in the activity and subtract this number: that is the total # of votes needed for the guided group to disband.
        /// </summary>
        /// <value>If -1, the guided group cannot be disbanded. Otherwise, take the total # of players in the activity and subtract this number: that is the total # of votes needed for the guided group to disband.</value>
        [DataMember(Name="guidedDisbandCount", EmitDefaultValue=false)]
        public int? GuidedDisbandCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyActivityGuidedBlockDefinition {\n");
            sb.Append("  GuidedMaxLobbySize: ").Append(GuidedMaxLobbySize).Append("\n");
            sb.Append("  GuidedMinLobbySize: ").Append(GuidedMinLobbySize).Append("\n");
            sb.Append("  GuidedDisbandCount: ").Append(GuidedDisbandCount).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyActivityGuidedBlockDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyActivityGuidedBlockDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyActivityGuidedBlockDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyActivityGuidedBlockDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GuidedMaxLobbySize == input.GuidedMaxLobbySize ||
                    (this.GuidedMaxLobbySize != null &&
                    this.GuidedMaxLobbySize.Equals(input.GuidedMaxLobbySize))
                ) && 
                (
                    this.GuidedMinLobbySize == input.GuidedMinLobbySize ||
                    (this.GuidedMinLobbySize != null &&
                    this.GuidedMinLobbySize.Equals(input.GuidedMinLobbySize))
                ) && 
                (
                    this.GuidedDisbandCount == input.GuidedDisbandCount ||
                    (this.GuidedDisbandCount != null &&
                    this.GuidedDisbandCount.Equals(input.GuidedDisbandCount))
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
                if (this.GuidedMaxLobbySize != null)
                    hashCode = hashCode * 59 + this.GuidedMaxLobbySize.GetHashCode();
                if (this.GuidedMinLobbySize != null)
                    hashCode = hashCode * 59 + this.GuidedMinLobbySize.GetHashCode();
                if (this.GuidedDisbandCount != null)
                    hashCode = hashCode * 59 + this.GuidedDisbandCount.GetHashCode();
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
