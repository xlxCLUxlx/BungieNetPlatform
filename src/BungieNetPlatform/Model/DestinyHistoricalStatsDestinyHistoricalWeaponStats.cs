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
    /// DestinyHistoricalStatsDestinyHistoricalWeaponStats
    /// </summary>
    [DataContract]
    public partial class DestinyHistoricalStatsDestinyHistoricalWeaponStats :  IEquatable<DestinyHistoricalStatsDestinyHistoricalWeaponStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyHistoricalStatsDestinyHistoricalWeaponStats" /> class.
        /// </summary>
        /// <param name="ReferenceId">The hash ID of the item definition that describes the weapon..</param>
        /// <param name="Values">Collection of stats for the period..</param>
        public DestinyHistoricalStatsDestinyHistoricalWeaponStats(uint? ReferenceId = default(uint?), Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values = default(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue>))
        {
            this.ReferenceId = ReferenceId;
            this.Values = Values;
        }
        
        /// <summary>
        /// The hash ID of the item definition that describes the weapon.
        /// </summary>
        /// <value>The hash ID of the item definition that describes the weapon.</value>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public uint? ReferenceId { get; set; }

        /// <summary>
        /// Collection of stats for the period.
        /// </summary>
        /// <value>Collection of stats for the period.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyHistoricalStatsDestinyHistoricalWeaponStats {\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as DestinyHistoricalStatsDestinyHistoricalWeaponStats);
        }

        /// <summary>
        /// Returns true if DestinyHistoricalStatsDestinyHistoricalWeaponStats instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyHistoricalStatsDestinyHistoricalWeaponStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyHistoricalStatsDestinyHistoricalWeaponStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
