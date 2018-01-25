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
    /// Well, we&#39;re here in Destiny 2, and Talent Grids are unfortunately still around.  The good news is that they&#39;re pretty much only being used for certain base information on items and for Builds/Subclasses. The bad news is that they still suck. If you really want this information, grab this component.  An important note is that talent grids are defined as such:  A Grid has 1:M Nodes, which has 1:M Steps.  Any given node can only have a single step active at one time, which represents the actual visual contents and effects of the Node (for instance, if you see a \&quot;Super Cool Bonus\&quot; node, the actual icon and text for the node is coming from the current Step of that node).  Nodes can be grouped into exclusivity sets *and* as of D2, exclusivity groups (which are collections of exclusivity sets that affect each other).  See DestinyTalentGridDefinition for more information. Brace yourself, the water&#39;s cold out there in the deep end.
    /// </summary>
    [DataContract]
    public partial class DestinyEntitiesItemsDestinyItemTalentGridComponent :  IEquatable<DestinyEntitiesItemsDestinyItemTalentGridComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesItemsDestinyItemTalentGridComponent" /> class.
        /// </summary>
        /// <param name="TalentGridHash">Most items don&#39;t have useful talent grids anymore, but Builds in particular still do.  You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item..</param>
        /// <param name="Nodes">Detailed information about the individual nodes in the talent grid.  A node represents a single visual \&quot;pip\&quot; in the talent grid or Build detail view, though each node may have multiple \&quot;steps\&quot; which indicate the actual bonuses and visual representation of that node..</param>
        /// <param name="IsGridComplete">Indicates whether the talent grid on this item is completed, and thus whether it should have a gold border around it.  Only will be true if the item actually *has* a talent grid, and only then if it is completed (i.e. every exclusive set has an activated node, and every non-exclusive set node has been activated).</param>
        /// <param name="GridProgression">If the item has a progression, it will be detailed here. A progression means that the item can gain experience. Thresholds of experience are what determines whether and when a talent node can be activated..</param>
        public DestinyEntitiesItemsDestinyItemTalentGridComponent(uint? TalentGridHash = default(uint?), List<DestinyDestinyTalentNode> Nodes = default(List<DestinyDestinyTalentNode>), bool? IsGridComplete = default(bool?), DestinyDestinyProgression GridProgression = default(DestinyDestinyProgression))
        {
            this.TalentGridHash = TalentGridHash;
            this.Nodes = Nodes;
            this.IsGridComplete = IsGridComplete;
            this.GridProgression = GridProgression;
        }
        
        /// <summary>
        /// Most items don&#39;t have useful talent grids anymore, but Builds in particular still do.  You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item.
        /// </summary>
        /// <value>Most items don&#39;t have useful talent grids anymore, but Builds in particular still do.  You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item.</value>
        [DataMember(Name="talentGridHash", EmitDefaultValue=false)]
        public uint? TalentGridHash { get; set; }

        /// <summary>
        /// Detailed information about the individual nodes in the talent grid.  A node represents a single visual \&quot;pip\&quot; in the talent grid or Build detail view, though each node may have multiple \&quot;steps\&quot; which indicate the actual bonuses and visual representation of that node.
        /// </summary>
        /// <value>Detailed information about the individual nodes in the talent grid.  A node represents a single visual \&quot;pip\&quot; in the talent grid or Build detail view, though each node may have multiple \&quot;steps\&quot; which indicate the actual bonuses and visual representation of that node.</value>
        [DataMember(Name="nodes", EmitDefaultValue=false)]
        public List<DestinyDestinyTalentNode> Nodes { get; set; }

        /// <summary>
        /// Indicates whether the talent grid on this item is completed, and thus whether it should have a gold border around it.  Only will be true if the item actually *has* a talent grid, and only then if it is completed (i.e. every exclusive set has an activated node, and every non-exclusive set node has been activated)
        /// </summary>
        /// <value>Indicates whether the talent grid on this item is completed, and thus whether it should have a gold border around it.  Only will be true if the item actually *has* a talent grid, and only then if it is completed (i.e. every exclusive set has an activated node, and every non-exclusive set node has been activated)</value>
        [DataMember(Name="isGridComplete", EmitDefaultValue=false)]
        public bool? IsGridComplete { get; set; }

        /// <summary>
        /// If the item has a progression, it will be detailed here. A progression means that the item can gain experience. Thresholds of experience are what determines whether and when a talent node can be activated.
        /// </summary>
        /// <value>If the item has a progression, it will be detailed here. A progression means that the item can gain experience. Thresholds of experience are what determines whether and when a talent node can be activated.</value>
        [DataMember(Name="gridProgression", EmitDefaultValue=false)]
        public DestinyDestinyProgression GridProgression { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyEntitiesItemsDestinyItemTalentGridComponent {\n");
            sb.Append("  TalentGridHash: ").Append(TalentGridHash).Append("\n");
            sb.Append("  Nodes: ").Append(Nodes).Append("\n");
            sb.Append("  IsGridComplete: ").Append(IsGridComplete).Append("\n");
            sb.Append("  GridProgression: ").Append(GridProgression).Append("\n");
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
            return this.Equals(input as DestinyEntitiesItemsDestinyItemTalentGridComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesItemsDestinyItemTalentGridComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesItemsDestinyItemTalentGridComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesItemsDestinyItemTalentGridComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TalentGridHash == input.TalentGridHash ||
                    (this.TalentGridHash != null &&
                    this.TalentGridHash.Equals(input.TalentGridHash))
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.IsGridComplete == input.IsGridComplete ||
                    (this.IsGridComplete != null &&
                    this.IsGridComplete.Equals(input.IsGridComplete))
                ) && 
                (
                    this.GridProgression == input.GridProgression ||
                    (this.GridProgression != null &&
                    this.GridProgression.Equals(input.GridProgression))
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
                if (this.TalentGridHash != null)
                    hashCode = hashCode * 59 + this.TalentGridHash.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.IsGridComplete != null)
                    hashCode = hashCode * 59 + this.IsGridComplete.GetHashCode();
                if (this.GridProgression != null)
                    hashCode = hashCode * 59 + this.GridProgression.GetHashCode();
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