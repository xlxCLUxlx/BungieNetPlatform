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
    /// If an item is a Plug, its DestinyInventoryItemDefinition.plug property will be populated with an instance of one of these bad boys.  This gives information about when it can be inserted, what the plug&#39;s category is (and thus whether it is compatible with a socket... see DestinySocketTypeDefinition for information about Plug Categories and socket compatibility), whether it is enabled and other Plug info.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsItemsDestinyItemPlugDefinition :  IEquatable<DestinyDefinitionsItemsDestinyItemPlugDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsItemsDestinyItemPlugDefinition" /> class.
        /// </summary>
        /// <param name="InsertionRules">The rules around when this plug can be inserted into a socket, aside from the socket&#39;s individual restrictions.  The live data DestinyItemPlugComponent.insertFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user..</param>
        /// <param name="PlugCategoryIdentifier">The string identifier for the plug&#39;s category. Use the socket&#39;s DestinySocketTypeDefinition.plugWhitelist to determine whether this plug can be inserted into the socket..</param>
        /// <param name="PlugCategoryHash">The hash for the plugCategoryIdentifier. You can use this instead if you wish: I put both in the definition for debugging purposes..</param>
        /// <param name="OnActionRecreateSelf">If you successfully socket the item, this will determine whether or not you get \&quot;refunded\&quot; on the plug..</param>
        /// <param name="InsertionMaterialRequirementHash">If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements..</param>
        /// <param name="PreviewItemOverrideHash">In the game, if you&#39;re inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item..</param>
        /// <param name="EnabledMaterialRequirementHash">It&#39;s not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one..</param>
        /// <param name="EnabledRules">The rules around whether the plug, once inserted, is enabled and providing its benefits.  The live data DestinyItemPlugComponent.enableFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user..</param>
        public DestinyDefinitionsItemsDestinyItemPlugDefinition(List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> InsertionRules = default(List<DestinyDefinitionsItemsDestinyPlugRuleDefinition>), string PlugCategoryIdentifier = default(string), uint? PlugCategoryHash = default(uint?), bool? OnActionRecreateSelf = default(bool?), uint? InsertionMaterialRequirementHash = default(uint?), uint? PreviewItemOverrideHash = default(uint?), uint? EnabledMaterialRequirementHash = default(uint?), List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> EnabledRules = default(List<DestinyDefinitionsItemsDestinyPlugRuleDefinition>))
        {
            this.InsertionRules = InsertionRules;
            this.PlugCategoryIdentifier = PlugCategoryIdentifier;
            this.PlugCategoryHash = PlugCategoryHash;
            this.OnActionRecreateSelf = OnActionRecreateSelf;
            this.InsertionMaterialRequirementHash = InsertionMaterialRequirementHash;
            this.PreviewItemOverrideHash = PreviewItemOverrideHash;
            this.EnabledMaterialRequirementHash = EnabledMaterialRequirementHash;
            this.EnabledRules = EnabledRules;
        }
        
        /// <summary>
        /// The rules around when this plug can be inserted into a socket, aside from the socket&#39;s individual restrictions.  The live data DestinyItemPlugComponent.insertFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.
        /// </summary>
        /// <value>The rules around when this plug can be inserted into a socket, aside from the socket&#39;s individual restrictions.  The live data DestinyItemPlugComponent.insertFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.</value>
        [DataMember(Name="insertionRules", EmitDefaultValue=false)]
        public List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> InsertionRules { get; set; }

        /// <summary>
        /// The string identifier for the plug&#39;s category. Use the socket&#39;s DestinySocketTypeDefinition.plugWhitelist to determine whether this plug can be inserted into the socket.
        /// </summary>
        /// <value>The string identifier for the plug&#39;s category. Use the socket&#39;s DestinySocketTypeDefinition.plugWhitelist to determine whether this plug can be inserted into the socket.</value>
        [DataMember(Name="plugCategoryIdentifier", EmitDefaultValue=false)]
        public string PlugCategoryIdentifier { get; set; }

        /// <summary>
        /// The hash for the plugCategoryIdentifier. You can use this instead if you wish: I put both in the definition for debugging purposes.
        /// </summary>
        /// <value>The hash for the plugCategoryIdentifier. You can use this instead if you wish: I put both in the definition for debugging purposes.</value>
        [DataMember(Name="plugCategoryHash", EmitDefaultValue=false)]
        public uint? PlugCategoryHash { get; set; }

        /// <summary>
        /// If you successfully socket the item, this will determine whether or not you get \&quot;refunded\&quot; on the plug.
        /// </summary>
        /// <value>If you successfully socket the item, this will determine whether or not you get \&quot;refunded\&quot; on the plug.</value>
        [DataMember(Name="onActionRecreateSelf", EmitDefaultValue=false)]
        public bool? OnActionRecreateSelf { get; set; }

        /// <summary>
        /// If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements.
        /// </summary>
        /// <value>If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements.</value>
        [DataMember(Name="insertionMaterialRequirementHash", EmitDefaultValue=false)]
        public uint? InsertionMaterialRequirementHash { get; set; }

        /// <summary>
        /// In the game, if you&#39;re inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item.
        /// </summary>
        /// <value>In the game, if you&#39;re inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item.</value>
        [DataMember(Name="previewItemOverrideHash", EmitDefaultValue=false)]
        public uint? PreviewItemOverrideHash { get; set; }

        /// <summary>
        /// It&#39;s not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one.
        /// </summary>
        /// <value>It&#39;s not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one.</value>
        [DataMember(Name="enabledMaterialRequirementHash", EmitDefaultValue=false)]
        public uint? EnabledMaterialRequirementHash { get; set; }

        /// <summary>
        /// The rules around whether the plug, once inserted, is enabled and providing its benefits.  The live data DestinyItemPlugComponent.enableFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.
        /// </summary>
        /// <value>The rules around whether the plug, once inserted, is enabled and providing its benefits.  The live data DestinyItemPlugComponent.enableFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user.</value>
        [DataMember(Name="enabledRules", EmitDefaultValue=false)]
        public List<DestinyDefinitionsItemsDestinyPlugRuleDefinition> EnabledRules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsItemsDestinyItemPlugDefinition {\n");
            sb.Append("  InsertionRules: ").Append(InsertionRules).Append("\n");
            sb.Append("  PlugCategoryIdentifier: ").Append(PlugCategoryIdentifier).Append("\n");
            sb.Append("  PlugCategoryHash: ").Append(PlugCategoryHash).Append("\n");
            sb.Append("  OnActionRecreateSelf: ").Append(OnActionRecreateSelf).Append("\n");
            sb.Append("  InsertionMaterialRequirementHash: ").Append(InsertionMaterialRequirementHash).Append("\n");
            sb.Append("  PreviewItemOverrideHash: ").Append(PreviewItemOverrideHash).Append("\n");
            sb.Append("  EnabledMaterialRequirementHash: ").Append(EnabledMaterialRequirementHash).Append("\n");
            sb.Append("  EnabledRules: ").Append(EnabledRules).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsItemsDestinyItemPlugDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsItemsDestinyItemPlugDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsItemsDestinyItemPlugDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsItemsDestinyItemPlugDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InsertionRules == input.InsertionRules ||
                    this.InsertionRules != null &&
                    this.InsertionRules.SequenceEqual(input.InsertionRules)
                ) && 
                (
                    this.PlugCategoryIdentifier == input.PlugCategoryIdentifier ||
                    (this.PlugCategoryIdentifier != null &&
                    this.PlugCategoryIdentifier.Equals(input.PlugCategoryIdentifier))
                ) && 
                (
                    this.PlugCategoryHash == input.PlugCategoryHash ||
                    (this.PlugCategoryHash != null &&
                    this.PlugCategoryHash.Equals(input.PlugCategoryHash))
                ) && 
                (
                    this.OnActionRecreateSelf == input.OnActionRecreateSelf ||
                    (this.OnActionRecreateSelf != null &&
                    this.OnActionRecreateSelf.Equals(input.OnActionRecreateSelf))
                ) && 
                (
                    this.InsertionMaterialRequirementHash == input.InsertionMaterialRequirementHash ||
                    (this.InsertionMaterialRequirementHash != null &&
                    this.InsertionMaterialRequirementHash.Equals(input.InsertionMaterialRequirementHash))
                ) && 
                (
                    this.PreviewItemOverrideHash == input.PreviewItemOverrideHash ||
                    (this.PreviewItemOverrideHash != null &&
                    this.PreviewItemOverrideHash.Equals(input.PreviewItemOverrideHash))
                ) && 
                (
                    this.EnabledMaterialRequirementHash == input.EnabledMaterialRequirementHash ||
                    (this.EnabledMaterialRequirementHash != null &&
                    this.EnabledMaterialRequirementHash.Equals(input.EnabledMaterialRequirementHash))
                ) && 
                (
                    this.EnabledRules == input.EnabledRules ||
                    this.EnabledRules != null &&
                    this.EnabledRules.SequenceEqual(input.EnabledRules)
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
                if (this.InsertionRules != null)
                    hashCode = hashCode * 59 + this.InsertionRules.GetHashCode();
                if (this.PlugCategoryIdentifier != null)
                    hashCode = hashCode * 59 + this.PlugCategoryIdentifier.GetHashCode();
                if (this.PlugCategoryHash != null)
                    hashCode = hashCode * 59 + this.PlugCategoryHash.GetHashCode();
                if (this.OnActionRecreateSelf != null)
                    hashCode = hashCode * 59 + this.OnActionRecreateSelf.GetHashCode();
                if (this.InsertionMaterialRequirementHash != null)
                    hashCode = hashCode * 59 + this.InsertionMaterialRequirementHash.GetHashCode();
                if (this.PreviewItemOverrideHash != null)
                    hashCode = hashCode * 59 + this.PreviewItemOverrideHash.GetHashCode();
                if (this.EnabledMaterialRequirementHash != null)
                    hashCode = hashCode * 59 + this.EnabledMaterialRequirementHash.GetHashCode();
                if (this.EnabledRules != null)
                    hashCode = hashCode * 59 + this.EnabledRules.GetHashCode();
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
