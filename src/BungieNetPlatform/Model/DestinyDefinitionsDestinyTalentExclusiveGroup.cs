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
    /// As of Destiny 2, nodes can exist as part of \&quot;Exclusive Groups\&quot;. These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause \&quot;opposing\&quot; nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyTalentExclusiveGroup :  IEquatable<DestinyDefinitionsDestinyTalentExclusiveGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyTalentExclusiveGroup" /> class.
        /// </summary>
        /// <param name="GroupHash">The identifier for this exclusive group. Only guaranteed unique within the talent grid, not globally..</param>
        /// <param name="LoreHash">If this group has an associated piece of lore to show next to it, this will be the identifier for that DestinyLoreDefinition..</param>
        /// <param name="NodeHashes">A quick reference of the talent nodes that are part of this group, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash).</param>
        /// <param name="OpposingGroupHashes">A quick reference of Groups whose nodes will be deactivated if any node in this group is activated..</param>
        /// <param name="OpposingNodeHashes">A quick reference of Nodes that will be deactivated if any node in this group is activated, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash).</param>
        public DestinyDefinitionsDestinyTalentExclusiveGroup(uint? GroupHash = default(uint?), uint? LoreHash = default(uint?), List<uint?> NodeHashes = default(List<uint?>), List<uint?> OpposingGroupHashes = default(List<uint?>), List<uint?> OpposingNodeHashes = default(List<uint?>))
        {
            this.GroupHash = GroupHash;
            this.LoreHash = LoreHash;
            this.NodeHashes = NodeHashes;
            this.OpposingGroupHashes = OpposingGroupHashes;
            this.OpposingNodeHashes = OpposingNodeHashes;
        }
        
        /// <summary>
        /// The identifier for this exclusive group. Only guaranteed unique within the talent grid, not globally.
        /// </summary>
        /// <value>The identifier for this exclusive group. Only guaranteed unique within the talent grid, not globally.</value>
        [DataMember(Name="groupHash", EmitDefaultValue=false)]
        public uint? GroupHash { get; set; }

        /// <summary>
        /// If this group has an associated piece of lore to show next to it, this will be the identifier for that DestinyLoreDefinition.
        /// </summary>
        /// <value>If this group has an associated piece of lore to show next to it, this will be the identifier for that DestinyLoreDefinition.</value>
        [DataMember(Name="loreHash", EmitDefaultValue=false)]
        public uint? LoreHash { get; set; }

        /// <summary>
        /// A quick reference of the talent nodes that are part of this group, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)
        /// </summary>
        /// <value>A quick reference of the talent nodes that are part of this group, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)</value>
        [DataMember(Name="nodeHashes", EmitDefaultValue=false)]
        public List<uint?> NodeHashes { get; set; }

        /// <summary>
        /// A quick reference of Groups whose nodes will be deactivated if any node in this group is activated.
        /// </summary>
        /// <value>A quick reference of Groups whose nodes will be deactivated if any node in this group is activated.</value>
        [DataMember(Name="opposingGroupHashes", EmitDefaultValue=false)]
        public List<uint?> OpposingGroupHashes { get; set; }

        /// <summary>
        /// A quick reference of Nodes that will be deactivated if any node in this group is activated, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)
        /// </summary>
        /// <value>A quick reference of Nodes that will be deactivated if any node in this group is activated, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)</value>
        [DataMember(Name="opposingNodeHashes", EmitDefaultValue=false)]
        public List<uint?> OpposingNodeHashes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyTalentExclusiveGroup {\n");
            sb.Append("  GroupHash: ").Append(GroupHash).Append("\n");
            sb.Append("  LoreHash: ").Append(LoreHash).Append("\n");
            sb.Append("  NodeHashes: ").Append(NodeHashes).Append("\n");
            sb.Append("  OpposingGroupHashes: ").Append(OpposingGroupHashes).Append("\n");
            sb.Append("  OpposingNodeHashes: ").Append(OpposingNodeHashes).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyTalentExclusiveGroup);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyTalentExclusiveGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyTalentExclusiveGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyTalentExclusiveGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupHash == input.GroupHash ||
                    (this.GroupHash != null &&
                    this.GroupHash.Equals(input.GroupHash))
                ) && 
                (
                    this.LoreHash == input.LoreHash ||
                    (this.LoreHash != null &&
                    this.LoreHash.Equals(input.LoreHash))
                ) && 
                (
                    this.NodeHashes == input.NodeHashes ||
                    this.NodeHashes != null &&
                    this.NodeHashes.SequenceEqual(input.NodeHashes)
                ) && 
                (
                    this.OpposingGroupHashes == input.OpposingGroupHashes ||
                    this.OpposingGroupHashes != null &&
                    this.OpposingGroupHashes.SequenceEqual(input.OpposingGroupHashes)
                ) && 
                (
                    this.OpposingNodeHashes == input.OpposingNodeHashes ||
                    this.OpposingNodeHashes != null &&
                    this.OpposingNodeHashes.SequenceEqual(input.OpposingNodeHashes)
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
                if (this.GroupHash != null)
                    hashCode = hashCode * 59 + this.GroupHash.GetHashCode();
                if (this.LoreHash != null)
                    hashCode = hashCode * 59 + this.LoreHash.GetHashCode();
                if (this.NodeHashes != null)
                    hashCode = hashCode * 59 + this.NodeHashes.GetHashCode();
                if (this.OpposingGroupHashes != null)
                    hashCode = hashCode * 59 + this.OpposingGroupHashes.GetHashCode();
                if (this.OpposingNodeHashes != null)
                    hashCode = hashCode * 59 + this.OpposingNodeHashes.GetHashCode();
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
