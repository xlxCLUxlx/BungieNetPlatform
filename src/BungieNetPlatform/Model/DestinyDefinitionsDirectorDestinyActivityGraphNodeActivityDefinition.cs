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
    /// The actual activity to be redirected to when you click on the node. Note that a node can have many Activities attached to it: but only one will be active at any given time. The list of Node Activities will be traversed, and the first one found to be active will be displayed. This way, a node can layer multiple variants of an activity on top of each other. For instance, one node can control the weekly Crucible Playlist. There are multiple possible playlists, but only one is active for the week.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition :  IEquatable<DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition" /> class.
        /// </summary>
        /// <param name="NodeActivityId">An identifier for this node activity. It is only guaranteed to be unique within the Activity Graph..</param>
        /// <param name="ActivityHash">The activity that will be activated if the user clicks on this node. Controls all activity-related information displayed on the node if it is active (the text shown in the tooltip etc).</param>
        public DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition(uint? NodeActivityId = default(uint?), uint? ActivityHash = default(uint?))
        {
            this.NodeActivityId = NodeActivityId;
            this.ActivityHash = ActivityHash;
        }
        
        /// <summary>
        /// An identifier for this node activity. It is only guaranteed to be unique within the Activity Graph.
        /// </summary>
        /// <value>An identifier for this node activity. It is only guaranteed to be unique within the Activity Graph.</value>
        [DataMember(Name="nodeActivityId", EmitDefaultValue=false)]
        public uint? NodeActivityId { get; set; }

        /// <summary>
        /// The activity that will be activated if the user clicks on this node. Controls all activity-related information displayed on the node if it is active (the text shown in the tooltip etc)
        /// </summary>
        /// <value>The activity that will be activated if the user clicks on this node. Controls all activity-related information displayed on the node if it is active (the text shown in the tooltip etc)</value>
        [DataMember(Name="activityHash", EmitDefaultValue=false)]
        public uint? ActivityHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition {\n");
            sb.Append("  NodeActivityId: ").Append(NodeActivityId).Append("\n");
            sb.Append("  ActivityHash: ").Append(ActivityHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeActivityId == input.NodeActivityId ||
                    (this.NodeActivityId != null &&
                    this.NodeActivityId.Equals(input.NodeActivityId))
                ) && 
                (
                    this.ActivityHash == input.ActivityHash ||
                    (this.ActivityHash != null &&
                    this.ActivityHash.Equals(input.ActivityHash))
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
                if (this.NodeActivityId != null)
                    hashCode = hashCode * 59 + this.NodeActivityId.GetHashCode();
                if (this.ActivityHash != null)
                    hashCode = hashCode * 59 + this.ActivityHash.GetHashCode();
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
