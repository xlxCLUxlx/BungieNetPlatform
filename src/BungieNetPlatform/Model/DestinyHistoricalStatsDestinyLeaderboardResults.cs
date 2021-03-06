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
    /// DestinyHistoricalStatsDestinyLeaderboardResults
    /// </summary>
    [DataContract]
    public partial class DestinyHistoricalStatsDestinyLeaderboardResults : Dictionary<String, DestinyHistoricalStatsDestinyLeaderboard>,  IEquatable<DestinyHistoricalStatsDestinyLeaderboardResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyHistoricalStatsDestinyLeaderboardResults" /> class.
        /// </summary>
        /// <param name="FocusMembershipId">Indicate the membership ID of the account that is the focal point of the provided leaderboards..</param>
        /// <param name="FocusCharacterId">Indicate the character ID of the character that is the focal point of the provided leaderboards. May be null, in which case any character from the focus membership can appear in the provided leaderboards..</param>
        public DestinyHistoricalStatsDestinyLeaderboardResults(long? FocusMembershipId = default(long?), long? FocusCharacterId = default(long?)) : base()
        {
            this.FocusMembershipId = FocusMembershipId;
            this.FocusCharacterId = FocusCharacterId;
        }
        
        /// <summary>
        /// Indicate the membership ID of the account that is the focal point of the provided leaderboards.
        /// </summary>
        /// <value>Indicate the membership ID of the account that is the focal point of the provided leaderboards.</value>
        [DataMember(Name="focusMembershipId", EmitDefaultValue=false)]
        public long? FocusMembershipId { get; set; }

        /// <summary>
        /// Indicate the character ID of the character that is the focal point of the provided leaderboards. May be null, in which case any character from the focus membership can appear in the provided leaderboards.
        /// </summary>
        /// <value>Indicate the character ID of the character that is the focal point of the provided leaderboards. May be null, in which case any character from the focus membership can appear in the provided leaderboards.</value>
        [DataMember(Name="focusCharacterId", EmitDefaultValue=false)]
        public long? FocusCharacterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyHistoricalStatsDestinyLeaderboardResults {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  FocusMembershipId: ").Append(FocusMembershipId).Append("\n");
            sb.Append("  FocusCharacterId: ").Append(FocusCharacterId).Append("\n");
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
            return this.Equals(input as DestinyHistoricalStatsDestinyLeaderboardResults);
        }

        /// <summary>
        /// Returns true if DestinyHistoricalStatsDestinyLeaderboardResults instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyHistoricalStatsDestinyLeaderboardResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyHistoricalStatsDestinyLeaderboardResults input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.FocusMembershipId == input.FocusMembershipId ||
                    (this.FocusMembershipId != null &&
                    this.FocusMembershipId.Equals(input.FocusMembershipId))
                ) && base.Equals(input) && 
                (
                    this.FocusCharacterId == input.FocusCharacterId ||
                    (this.FocusCharacterId != null &&
                    this.FocusCharacterId.Equals(input.FocusCharacterId))
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
                int hashCode = base.GetHashCode();
                if (this.FocusMembershipId != null)
                    hashCode = hashCode * 59 + this.FocusMembershipId.GetHashCode();
                if (this.FocusCharacterId != null)
                    hashCode = hashCode * 59 + this.FocusCharacterId.GetHashCode();
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
