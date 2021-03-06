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
    /// GroupsV2GroupAction
    /// </summary>
    [DataContract]
    public partial class GroupsV2GroupAction :  IEquatable<GroupsV2GroupAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupAction" /> class.
        /// </summary>
        /// <param name="GroupType">Type of group, either Bungie.net hosted group, or a game services hosted clan..</param>
        /// <param name="Name">Name.</param>
        /// <param name="About">About.</param>
        /// <param name="Motto">Motto.</param>
        /// <param name="Theme">Theme.</param>
        /// <param name="AvatarImageIndex">AvatarImageIndex.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="IsPublic">IsPublic.</param>
        /// <param name="MembershipOption">MembershipOption.</param>
        /// <param name="IsPublicTopicAdminOnly">IsPublicTopicAdminOnly.</param>
        /// <param name="IsDefaultPostPublic">IsDefaultPostPublic.</param>
        /// <param name="AllowChat">AllowChat.</param>
        /// <param name="IsDefaultPostAlliance">IsDefaultPostAlliance.</param>
        /// <param name="ChatSecurity">ChatSecurity.</param>
        /// <param name="Callsign">Callsign.</param>
        /// <param name="Locale">Locale.</param>
        /// <param name="Homepage">Homepage.</param>
        /// <param name="PlatformMembershipType">When operation needs a platform specific account ID for the present user, use this property. In particular, groupType of Clan requires this value to be set..</param>
        public GroupsV2GroupAction(GroupsV2GroupType GroupType = default(GroupsV2GroupType), string Name = default(string), string About = default(string), string Motto = default(string), string Theme = default(string), int? AvatarImageIndex = default(int?), string Tags = default(string), bool? IsPublic = default(bool?), GroupsV2MembershipOption MembershipOption = default(GroupsV2MembershipOption), bool? IsPublicTopicAdminOnly = default(bool?), bool? IsDefaultPostPublic = default(bool?), bool? AllowChat = default(bool?), bool? IsDefaultPostAlliance = default(bool?), GroupsV2ChatSecuritySetting ChatSecurity = default(GroupsV2ChatSecuritySetting), string Callsign = default(string), string Locale = default(string), GroupsV2GroupHomepage Homepage = default(GroupsV2GroupHomepage), BungieMembershipType PlatformMembershipType = default(BungieMembershipType))
        {
            this.GroupType = GroupType;
            this.Name = Name;
            this.About = About;
            this.Motto = Motto;
            this.Theme = Theme;
            this.AvatarImageIndex = AvatarImageIndex;
            this.Tags = Tags;
            this.IsPublic = IsPublic;
            this.MembershipOption = MembershipOption;
            this.IsPublicTopicAdminOnly = IsPublicTopicAdminOnly;
            this.IsDefaultPostPublic = IsDefaultPostPublic;
            this.AllowChat = AllowChat;
            this.IsDefaultPostAlliance = IsDefaultPostAlliance;
            this.ChatSecurity = ChatSecurity;
            this.Callsign = Callsign;
            this.Locale = Locale;
            this.Homepage = Homepage;
            this.PlatformMembershipType = PlatformMembershipType;
        }
        
        /// <summary>
        /// Type of group, either Bungie.net hosted group, or a game services hosted clan.
        /// </summary>
        /// <value>Type of group, either Bungie.net hosted group, or a game services hosted clan.</value>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public GroupsV2GroupType GroupType { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets About
        /// </summary>
        [DataMember(Name="about", EmitDefaultValue=false)]
        public string About { get; set; }

        /// <summary>
        /// Gets or Sets Motto
        /// </summary>
        [DataMember(Name="motto", EmitDefaultValue=false)]
        public string Motto { get; set; }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name="theme", EmitDefaultValue=false)]
        public string Theme { get; set; }

        /// <summary>
        /// Gets or Sets AvatarImageIndex
        /// </summary>
        [DataMember(Name="avatarImageIndex", EmitDefaultValue=false)]
        public int? AvatarImageIndex { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or Sets IsPublic
        /// </summary>
        [DataMember(Name="isPublic", EmitDefaultValue=false)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Gets or Sets MembershipOption
        /// </summary>
        [DataMember(Name="membershipOption", EmitDefaultValue=false)]
        public GroupsV2MembershipOption MembershipOption { get; set; }

        /// <summary>
        /// Gets or Sets IsPublicTopicAdminOnly
        /// </summary>
        [DataMember(Name="isPublicTopicAdminOnly", EmitDefaultValue=false)]
        public bool? IsPublicTopicAdminOnly { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultPostPublic
        /// </summary>
        [DataMember(Name="isDefaultPostPublic", EmitDefaultValue=false)]
        public bool? IsDefaultPostPublic { get; set; }

        /// <summary>
        /// Gets or Sets AllowChat
        /// </summary>
        [DataMember(Name="allowChat", EmitDefaultValue=false)]
        public bool? AllowChat { get; set; }

        /// <summary>
        /// Gets or Sets IsDefaultPostAlliance
        /// </summary>
        [DataMember(Name="isDefaultPostAlliance", EmitDefaultValue=false)]
        public bool? IsDefaultPostAlliance { get; set; }

        /// <summary>
        /// Gets or Sets ChatSecurity
        /// </summary>
        [DataMember(Name="chatSecurity", EmitDefaultValue=false)]
        public GroupsV2ChatSecuritySetting ChatSecurity { get; set; }

        /// <summary>
        /// Gets or Sets Callsign
        /// </summary>
        [DataMember(Name="callsign", EmitDefaultValue=false)]
        public string Callsign { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets Homepage
        /// </summary>
        [DataMember(Name="homepage", EmitDefaultValue=false)]
        public GroupsV2GroupHomepage Homepage { get; set; }

        /// <summary>
        /// When operation needs a platform specific account ID for the present user, use this property. In particular, groupType of Clan requires this value to be set.
        /// </summary>
        /// <value>When operation needs a platform specific account ID for the present user, use this property. In particular, groupType of Clan requires this value to be set.</value>
        [DataMember(Name="platformMembershipType", EmitDefaultValue=false)]
        public BungieMembershipType PlatformMembershipType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsV2GroupAction {\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  Motto: ").Append(Motto).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  AvatarImageIndex: ").Append(AvatarImageIndex).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  MembershipOption: ").Append(MembershipOption).Append("\n");
            sb.Append("  IsPublicTopicAdminOnly: ").Append(IsPublicTopicAdminOnly).Append("\n");
            sb.Append("  IsDefaultPostPublic: ").Append(IsDefaultPostPublic).Append("\n");
            sb.Append("  AllowChat: ").Append(AllowChat).Append("\n");
            sb.Append("  IsDefaultPostAlliance: ").Append(IsDefaultPostAlliance).Append("\n");
            sb.Append("  ChatSecurity: ").Append(ChatSecurity).Append("\n");
            sb.Append("  Callsign: ").Append(Callsign).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Homepage: ").Append(Homepage).Append("\n");
            sb.Append("  PlatformMembershipType: ").Append(PlatformMembershipType).Append("\n");
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
            return this.Equals(input as GroupsV2GroupAction);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupAction instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupAction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.About == input.About ||
                    (this.About != null &&
                    this.About.Equals(input.About))
                ) && 
                (
                    this.Motto == input.Motto ||
                    (this.Motto != null &&
                    this.Motto.Equals(input.Motto))
                ) && 
                (
                    this.Theme == input.Theme ||
                    (this.Theme != null &&
                    this.Theme.Equals(input.Theme))
                ) && 
                (
                    this.AvatarImageIndex == input.AvatarImageIndex ||
                    (this.AvatarImageIndex != null &&
                    this.AvatarImageIndex.Equals(input.AvatarImageIndex))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.IsPublic == input.IsPublic ||
                    (this.IsPublic != null &&
                    this.IsPublic.Equals(input.IsPublic))
                ) && 
                (
                    this.MembershipOption == input.MembershipOption ||
                    (this.MembershipOption != null &&
                    this.MembershipOption.Equals(input.MembershipOption))
                ) && 
                (
                    this.IsPublicTopicAdminOnly == input.IsPublicTopicAdminOnly ||
                    (this.IsPublicTopicAdminOnly != null &&
                    this.IsPublicTopicAdminOnly.Equals(input.IsPublicTopicAdminOnly))
                ) && 
                (
                    this.IsDefaultPostPublic == input.IsDefaultPostPublic ||
                    (this.IsDefaultPostPublic != null &&
                    this.IsDefaultPostPublic.Equals(input.IsDefaultPostPublic))
                ) && 
                (
                    this.AllowChat == input.AllowChat ||
                    (this.AllowChat != null &&
                    this.AllowChat.Equals(input.AllowChat))
                ) && 
                (
                    this.IsDefaultPostAlliance == input.IsDefaultPostAlliance ||
                    (this.IsDefaultPostAlliance != null &&
                    this.IsDefaultPostAlliance.Equals(input.IsDefaultPostAlliance))
                ) && 
                (
                    this.ChatSecurity == input.ChatSecurity ||
                    (this.ChatSecurity != null &&
                    this.ChatSecurity.Equals(input.ChatSecurity))
                ) && 
                (
                    this.Callsign == input.Callsign ||
                    (this.Callsign != null &&
                    this.Callsign.Equals(input.Callsign))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.Homepage == input.Homepage ||
                    (this.Homepage != null &&
                    this.Homepage.Equals(input.Homepage))
                ) && 
                (
                    this.PlatformMembershipType == input.PlatformMembershipType ||
                    (this.PlatformMembershipType != null &&
                    this.PlatformMembershipType.Equals(input.PlatformMembershipType))
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
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.About != null)
                    hashCode = hashCode * 59 + this.About.GetHashCode();
                if (this.Motto != null)
                    hashCode = hashCode * 59 + this.Motto.GetHashCode();
                if (this.Theme != null)
                    hashCode = hashCode * 59 + this.Theme.GetHashCode();
                if (this.AvatarImageIndex != null)
                    hashCode = hashCode * 59 + this.AvatarImageIndex.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.IsPublic != null)
                    hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
                if (this.MembershipOption != null)
                    hashCode = hashCode * 59 + this.MembershipOption.GetHashCode();
                if (this.IsPublicTopicAdminOnly != null)
                    hashCode = hashCode * 59 + this.IsPublicTopicAdminOnly.GetHashCode();
                if (this.IsDefaultPostPublic != null)
                    hashCode = hashCode * 59 + this.IsDefaultPostPublic.GetHashCode();
                if (this.AllowChat != null)
                    hashCode = hashCode * 59 + this.AllowChat.GetHashCode();
                if (this.IsDefaultPostAlliance != null)
                    hashCode = hashCode * 59 + this.IsDefaultPostAlliance.GetHashCode();
                if (this.ChatSecurity != null)
                    hashCode = hashCode * 59 + this.ChatSecurity.GetHashCode();
                if (this.Callsign != null)
                    hashCode = hashCode * 59 + this.Callsign.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Homepage != null)
                    hashCode = hashCode * 59 + this.Homepage.GetHashCode();
                if (this.PlatformMembershipType != null)
                    hashCode = hashCode * 59 + this.PlatformMembershipType.GetHashCode();
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
