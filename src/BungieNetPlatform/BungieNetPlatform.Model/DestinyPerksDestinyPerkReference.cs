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
    /// The list of perks to display in an item tooltip - and whether or not they have been activated.  Perks apply a variety of effects to a character, and are generally either intrinsic to the item or provided in activated talent nodes or sockets.
    /// </summary>
    [DataContract]
    public partial class DestinyPerksDestinyPerkReference :  IEquatable<DestinyPerksDestinyPerkReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyPerksDestinyPerkReference" /> class.
        /// </summary>
        /// <param name="PerkHash">The hash identifier for the perk, which can be used to look up DestinySandboxPerkDefinition if it exists. Be warned, perks frequently do not have user-viewable information. You should examine whether you actually found a name/description in the perk&#39;s definition before you show it to the user..</param>
        /// <param name="IconPath">The icon for the perk..</param>
        /// <param name="IsActive">Whether this perk is currently active. (We may return perks that you have not actually activated yet: these represent perks that you should show in the item&#39;s tooltip, but that the user has not yet activated.).</param>
        /// <param name="Visible">Some perks provide benefits, but aren&#39;t visible in the UI. This value will let you know if this is perk should be shown in your UI..</param>
        public DestinyPerksDestinyPerkReference(uint? PerkHash = default(uint?), string IconPath = default(string), bool? IsActive = default(bool?), bool? Visible = default(bool?))
        {
            this.PerkHash = PerkHash;
            this.IconPath = IconPath;
            this.IsActive = IsActive;
            this.Visible = Visible;
        }
        
        /// <summary>
        /// The hash identifier for the perk, which can be used to look up DestinySandboxPerkDefinition if it exists. Be warned, perks frequently do not have user-viewable information. You should examine whether you actually found a name/description in the perk&#39;s definition before you show it to the user.
        /// </summary>
        /// <value>The hash identifier for the perk, which can be used to look up DestinySandboxPerkDefinition if it exists. Be warned, perks frequently do not have user-viewable information. You should examine whether you actually found a name/description in the perk&#39;s definition before you show it to the user.</value>
        [DataMember(Name="perkHash", EmitDefaultValue=false)]
        public uint? PerkHash { get; set; }

        /// <summary>
        /// The icon for the perk.
        /// </summary>
        /// <value>The icon for the perk.</value>
        [DataMember(Name="iconPath", EmitDefaultValue=false)]
        public string IconPath { get; set; }

        /// <summary>
        /// Whether this perk is currently active. (We may return perks that you have not actually activated yet: these represent perks that you should show in the item&#39;s tooltip, but that the user has not yet activated.)
        /// </summary>
        /// <value>Whether this perk is currently active. (We may return perks that you have not actually activated yet: these represent perks that you should show in the item&#39;s tooltip, but that the user has not yet activated.)</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Some perks provide benefits, but aren&#39;t visible in the UI. This value will let you know if this is perk should be shown in your UI.
        /// </summary>
        /// <value>Some perks provide benefits, but aren&#39;t visible in the UI. This value will let you know if this is perk should be shown in your UI.</value>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyPerksDestinyPerkReference {\n");
            sb.Append("  PerkHash: ").Append(PerkHash).Append("\n");
            sb.Append("  IconPath: ").Append(IconPath).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
            return this.Equals(input as DestinyPerksDestinyPerkReference);
        }

        /// <summary>
        /// Returns true if DestinyPerksDestinyPerkReference instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyPerksDestinyPerkReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyPerksDestinyPerkReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PerkHash == input.PerkHash ||
                    (this.PerkHash != null &&
                    this.PerkHash.Equals(input.PerkHash))
                ) && 
                (
                    this.IconPath == input.IconPath ||
                    (this.IconPath != null &&
                    this.IconPath.Equals(input.IconPath))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
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
                if (this.PerkHash != null)
                    hashCode = hashCode * 59 + this.PerkHash.GetHashCode();
                if (this.IconPath != null)
                    hashCode = hashCode * 59 + this.IconPath.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
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