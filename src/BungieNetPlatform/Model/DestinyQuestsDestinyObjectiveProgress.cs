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
    /// Returns data about a character&#39;s status with a given Objective. Combine with DestinyObjectiveDefinition static data for display purposes.
    /// </summary>
    [DataContract]
    public partial class DestinyQuestsDestinyObjectiveProgress :  IEquatable<DestinyQuestsDestinyObjectiveProgress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyQuestsDestinyObjectiveProgress" /> class.
        /// </summary>
        /// <param name="ObjectiveHash">The unique identifier of the Objective being referred to. Use to look up the DestinyObjectiveDefinition in static data..</param>
        /// <param name="DestinationHash">If the Objective has a Destination associated with it, this is the unique identifier of the Destination being referred to. Use to look up the DestinyDestinationDefinition in static data. This will give localized data about *where* in the universe the objective should be achieved..</param>
        /// <param name="ActivityHash">If the Objective has an Activity associated with it, this is the unique identifier of the Activity being referred to. Use to look up the DestinyActivityDefinition in static data. This will give localized data about *what* you should be playing for the objective to be achieved..</param>
        /// <param name="Progress">If progress has been made, and the progress can be measured numerically, this will be the value of that progress. You can compare it to the DestinyObjectiveDefinition.completionValue property for current vs. upper bounds, and use DestinyObjectiveDefinition.valueStyle to determine how this should be rendered. Note that progress, in Destiny 2, need not be a literal numeric progression. It could be one of a number of possible values, even a Timestamp. Always examine DestinyObjectiveDefinition.valueStyle before rendering progress..</param>
        /// <param name="Complete">Whether or not the Objective is completed..</param>
        public DestinyQuestsDestinyObjectiveProgress(uint? ObjectiveHash = default(uint?), uint? DestinationHash = default(uint?), uint? ActivityHash = default(uint?), int? Progress = default(int?), bool? Complete = default(bool?))
        {
            this.ObjectiveHash = ObjectiveHash;
            this.DestinationHash = DestinationHash;
            this.ActivityHash = ActivityHash;
            this.Progress = Progress;
            this.Complete = Complete;
        }
        
        /// <summary>
        /// The unique identifier of the Objective being referred to. Use to look up the DestinyObjectiveDefinition in static data.
        /// </summary>
        /// <value>The unique identifier of the Objective being referred to. Use to look up the DestinyObjectiveDefinition in static data.</value>
        [DataMember(Name="objectiveHash", EmitDefaultValue=false)]
        public uint? ObjectiveHash { get; set; }

        /// <summary>
        /// If the Objective has a Destination associated with it, this is the unique identifier of the Destination being referred to. Use to look up the DestinyDestinationDefinition in static data. This will give localized data about *where* in the universe the objective should be achieved.
        /// </summary>
        /// <value>If the Objective has a Destination associated with it, this is the unique identifier of the Destination being referred to. Use to look up the DestinyDestinationDefinition in static data. This will give localized data about *where* in the universe the objective should be achieved.</value>
        [DataMember(Name="destinationHash", EmitDefaultValue=false)]
        public uint? DestinationHash { get; set; }

        /// <summary>
        /// If the Objective has an Activity associated with it, this is the unique identifier of the Activity being referred to. Use to look up the DestinyActivityDefinition in static data. This will give localized data about *what* you should be playing for the objective to be achieved.
        /// </summary>
        /// <value>If the Objective has an Activity associated with it, this is the unique identifier of the Activity being referred to. Use to look up the DestinyActivityDefinition in static data. This will give localized data about *what* you should be playing for the objective to be achieved.</value>
        [DataMember(Name="activityHash", EmitDefaultValue=false)]
        public uint? ActivityHash { get; set; }

        /// <summary>
        /// If progress has been made, and the progress can be measured numerically, this will be the value of that progress. You can compare it to the DestinyObjectiveDefinition.completionValue property for current vs. upper bounds, and use DestinyObjectiveDefinition.valueStyle to determine how this should be rendered. Note that progress, in Destiny 2, need not be a literal numeric progression. It could be one of a number of possible values, even a Timestamp. Always examine DestinyObjectiveDefinition.valueStyle before rendering progress.
        /// </summary>
        /// <value>If progress has been made, and the progress can be measured numerically, this will be the value of that progress. You can compare it to the DestinyObjectiveDefinition.completionValue property for current vs. upper bounds, and use DestinyObjectiveDefinition.valueStyle to determine how this should be rendered. Note that progress, in Destiny 2, need not be a literal numeric progression. It could be one of a number of possible values, even a Timestamp. Always examine DestinyObjectiveDefinition.valueStyle before rendering progress.</value>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// Whether or not the Objective is completed.
        /// </summary>
        /// <value>Whether or not the Objective is completed.</value>
        [DataMember(Name="complete", EmitDefaultValue=false)]
        public bool? Complete { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyQuestsDestinyObjectiveProgress {\n");
            sb.Append("  ObjectiveHash: ").Append(ObjectiveHash).Append("\n");
            sb.Append("  DestinationHash: ").Append(DestinationHash).Append("\n");
            sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
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
            return this.Equals(input as DestinyQuestsDestinyObjectiveProgress);
        }

        /// <summary>
        /// Returns true if DestinyQuestsDestinyObjectiveProgress instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyQuestsDestinyObjectiveProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyQuestsDestinyObjectiveProgress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectiveHash == input.ObjectiveHash ||
                    (this.ObjectiveHash != null &&
                    this.ObjectiveHash.Equals(input.ObjectiveHash))
                ) && 
                (
                    this.DestinationHash == input.DestinationHash ||
                    (this.DestinationHash != null &&
                    this.DestinationHash.Equals(input.DestinationHash))
                ) && 
                (
                    this.ActivityHash == input.ActivityHash ||
                    (this.ActivityHash != null &&
                    this.ActivityHash.Equals(input.ActivityHash))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.Complete == input.Complete ||
                    (this.Complete != null &&
                    this.Complete.Equals(input.Complete))
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
                if (this.ObjectiveHash != null)
                    hashCode = hashCode * 59 + this.ObjectiveHash.GetHashCode();
                if (this.DestinationHash != null)
                    hashCode = hashCode * 59 + this.DestinationHash.GetHashCode();
                if (this.ActivityHash != null)
                    hashCode = hashCode * 59 + this.ActivityHash.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.Complete != null)
                    hashCode = hashCode * 59 + this.Complete.GetHashCode();
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
