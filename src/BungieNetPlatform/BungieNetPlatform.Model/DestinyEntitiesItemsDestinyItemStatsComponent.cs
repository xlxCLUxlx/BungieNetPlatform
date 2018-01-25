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
    /// If you want the stats on an item&#39;s instanced data, get this component.  These are stats like Attack, Defense etc... and *not* historical stats.  Note that some stats have additional computation in-game at runtime - for instance, Magazine Size - and thus these stats might not be 100% accurate compared to what you see in-game for some stats. I know, it sucks. I hate it too.
    /// </summary>
    [DataContract]
    public partial class DestinyEntitiesItemsDestinyItemStatsComponent :  IEquatable<DestinyEntitiesItemsDestinyItemStatsComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesItemsDestinyItemStatsComponent" /> class.
        /// </summary>
        /// <param name="Stats">If the item has stats that it provides (damage, defense, etc...), it will be given here..</param>
        public DestinyEntitiesItemsDestinyItemStatsComponent(Dictionary<string, DestinyDestinyStat> Stats = default(Dictionary<string, DestinyDestinyStat>))
        {
            this.Stats = Stats;
        }
        
        /// <summary>
        /// If the item has stats that it provides (damage, defense, etc...), it will be given here.
        /// </summary>
        /// <value>If the item has stats that it provides (damage, defense, etc...), it will be given here.</value>
        [DataMember(Name="stats", EmitDefaultValue=false)]
        public Dictionary<string, DestinyDestinyStat> Stats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyEntitiesItemsDestinyItemStatsComponent {\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
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
            return this.Equals(input as DestinyEntitiesItemsDestinyItemStatsComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesItemsDestinyItemStatsComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesItemsDestinyItemStatsComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesItemsDestinyItemStatsComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stats == input.Stats ||
                    this.Stats != null &&
                    this.Stats.SequenceEqual(input.Stats)
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
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
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