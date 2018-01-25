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
    /// DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData
    /// </summary>
    [DataContract]
    public partial class DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData :  IEquatable<DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData" /> class.
        /// </summary>
        /// <param name="Weapons">List of weapons and their perspective values..</param>
        /// <param name="Values">Collection of stats for the player in this activity..</param>
        public DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData(List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> Weapons = default(List<DestinyHistoricalStatsDestinyHistoricalWeaponStats>), Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values = default(Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue>))
        {
            this.Weapons = Weapons;
            this.Values = Values;
        }
        
        /// <summary>
        /// List of weapons and their perspective values.
        /// </summary>
        /// <value>List of weapons and their perspective values.</value>
        [DataMember(Name="weapons", EmitDefaultValue=false)]
        public List<DestinyHistoricalStatsDestinyHistoricalWeaponStats> Weapons { get; set; }

        /// <summary>
        /// Collection of stats for the player in this activity.
        /// </summary>
        /// <value>Collection of stats for the player in this activity.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public Dictionary<string, DestinyHistoricalStatsDestinyHistoricalStatsValue> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData {\n");
            sb.Append("  Weapons: ").Append(Weapons).Append("\n");
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
            return this.Equals(input as DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData);
        }

        /// <summary>
        /// Returns true if DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Weapons == input.Weapons ||
                    this.Weapons != null &&
                    this.Weapons.SequenceEqual(input.Weapons)
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
                if (this.Weapons != null)
                    hashCode = hashCode * 59 + this.Weapons.GetHashCode();
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
