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
    /// GroupsV2GroupEditAction
    /// </summary>
    [DataContract]
    public partial class GroupsV2GroupEditAction :  IEquatable<GroupsV2GroupEditAction>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets MembershipOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MembershipOptionEnum
        {
            
            /// <summary>
            /// Enum Reviewed for 0
            /// </summary>
            [EnumMember(Value = "0")]
            Reviewed = 0,
            
            /// <summary>
            /// Enum Open for 1
            /// </summary>
            [EnumMember(Value = "1")]
            Open = 1,
            
            /// <summary>
            /// Enum Closed for 2
            /// </summary>
            [EnumMember(Value = "2")]
            Closed = 2
        }

        /// <summary>
        /// Gets or Sets ChatSecurity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChatSecurityEnum
        {
            
            /// <summary>
            /// Enum Group for 0
            /// </summary>
            [EnumMember(Value = "0")]
            Group = 0,
            
            /// <summary>
            /// Enum Admins for 1
            /// </summary>
            [EnumMember(Value = "1")]
            Admins = 1
        }

        /// <summary>
        /// Gets or Sets Homepage
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HomepageEnum
        {
            
            /// <summary>
            /// Enum Wall for 0
            /// </summary>
            [EnumMember(Value = "0")]
            Wall = 0,
            
            /// <summary>
            /// Enum Forum for 1
            /// </summary>
            [EnumMember(Value = "1")]
            Forum = 1,
            
            /// <summary>
            /// Enum AllianceForum for 2
            /// </summary>
            [EnumMember(Value = "2")]
            AllianceForum = 2
        }

        /// <summary>
        /// Gets or Sets DefaultPublicity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DefaultPublicityEnum
        {
            
            /// <summary>
            /// Enum Public for 0
            /// </summary>
            [EnumMember(Value = "0")]
            Public = 0,
            
            /// <summary>
            /// Enum Alliance for 1
            /// </summary>
            [EnumMember(Value = "1")]
            Alliance = 1,
            
            /// <summary>
            /// Enum Private for 2
            /// </summary>
            [EnumMember(Value = "2")]
            Private = 2
        }

        /// <summary>
        /// Gets or Sets MembershipOption
        /// </summary>
        [DataMember(Name="membershipOption", EmitDefaultValue=false)]
        public MembershipOptionEnum? MembershipOption { get; set; }
        /// <summary>
        /// Gets or Sets ChatSecurity
        /// </summary>
        [DataMember(Name="chatSecurity", EmitDefaultValue=false)]
        public ChatSecurityEnum? ChatSecurity { get; set; }
        /// <summary>
        /// Gets or Sets Homepage
        /// </summary>
        [DataMember(Name="homepage", EmitDefaultValue=false)]
        public HomepageEnum? Homepage { get; set; }
        /// <summary>
        /// Gets or Sets DefaultPublicity
        /// </summary>
        [DataMember(Name="defaultPublicity", EmitDefaultValue=false)]
        public DefaultPublicityEnum? DefaultPublicity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupEditAction" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="About">About.</param>
        /// <param name="Motto">Motto.</param>
        /// <param name="Theme">Theme.</param>
        /// <param name="AvatarImageIndex">AvatarImageIndex.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="IsPublic">IsPublic.</param>
        /// <param name="MembershipOption">MembershipOption.</param>
        /// <param name="IsPublicTopicAdminOnly">IsPublicTopicAdminOnly.</param>
        /// <param name="AllowChat">AllowChat.</param>
        /// <param name="ChatSecurity">ChatSecurity.</param>
        /// <param name="Callsign">Callsign.</param>
        /// <param name="Locale">Locale.</param>
        /// <param name="Homepage">Homepage.</param>
        /// <param name="EnableInvitationMessagingForAdmins">EnableInvitationMessagingForAdmins.</param>
        /// <param name="DefaultPublicity">DefaultPublicity.</param>
        public GroupsV2GroupEditAction(string Name = default(string), string About = default(string), string Motto = default(string), string Theme = default(string), int? AvatarImageIndex = default(int?), string Tags = default(string), bool? IsPublic = default(bool?), MembershipOptionEnum? MembershipOption = default(MembershipOptionEnum?), bool? IsPublicTopicAdminOnly = default(bool?), bool? AllowChat = default(bool?), ChatSecurityEnum? ChatSecurity = default(ChatSecurityEnum?), string Callsign = default(string), string Locale = default(string), HomepageEnum? Homepage = default(HomepageEnum?), bool? EnableInvitationMessagingForAdmins = default(bool?), DefaultPublicityEnum? DefaultPublicity = default(DefaultPublicityEnum?))
        {
            this.Name = Name;
            this.About = About;
            this.Motto = Motto;
            this.Theme = Theme;
            this.AvatarImageIndex = AvatarImageIndex;
            this.Tags = Tags;
            this.IsPublic = IsPublic;
            this.MembershipOption = MembershipOption;
            this.IsPublicTopicAdminOnly = IsPublicTopicAdminOnly;
            this.AllowChat = AllowChat;
            this.ChatSecurity = ChatSecurity;
            this.Callsign = Callsign;
            this.Locale = Locale;
            this.Homepage = Homepage;
            this.EnableInvitationMessagingForAdmins = EnableInvitationMessagingForAdmins;
            this.DefaultPublicity = DefaultPublicity;
        }
        
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
        /// Gets or Sets IsPublicTopicAdminOnly
        /// </summary>
        [DataMember(Name="isPublicTopicAdminOnly", EmitDefaultValue=false)]
        public bool? IsPublicTopicAdminOnly { get; set; }

        /// <summary>
        /// Gets or Sets AllowChat
        /// </summary>
        [DataMember(Name="allowChat", EmitDefaultValue=false)]
        public bool? AllowChat { get; set; }


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
        /// Gets or Sets EnableInvitationMessagingForAdmins
        /// </summary>
        [DataMember(Name="enableInvitationMessagingForAdmins", EmitDefaultValue=false)]
        public bool? EnableInvitationMessagingForAdmins { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsV2GroupEditAction {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  Motto: ").Append(Motto).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  AvatarImageIndex: ").Append(AvatarImageIndex).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
            sb.Append("  MembershipOption: ").Append(MembershipOption).Append("\n");
            sb.Append("  IsPublicTopicAdminOnly: ").Append(IsPublicTopicAdminOnly).Append("\n");
            sb.Append("  AllowChat: ").Append(AllowChat).Append("\n");
            sb.Append("  ChatSecurity: ").Append(ChatSecurity).Append("\n");
            sb.Append("  Callsign: ").Append(Callsign).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Homepage: ").Append(Homepage).Append("\n");
            sb.Append("  EnableInvitationMessagingForAdmins: ").Append(EnableInvitationMessagingForAdmins).Append("\n");
            sb.Append("  DefaultPublicity: ").Append(DefaultPublicity).Append("\n");
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
            return this.Equals(input as GroupsV2GroupEditAction);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupEditAction instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupEditAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupEditAction input)
        {
            if (input == null)
                return false;

            return 
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
                    this.AllowChat == input.AllowChat ||
                    (this.AllowChat != null &&
                    this.AllowChat.Equals(input.AllowChat))
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
                    this.EnableInvitationMessagingForAdmins == input.EnableInvitationMessagingForAdmins ||
                    (this.EnableInvitationMessagingForAdmins != null &&
                    this.EnableInvitationMessagingForAdmins.Equals(input.EnableInvitationMessagingForAdmins))
                ) && 
                (
                    this.DefaultPublicity == input.DefaultPublicity ||
                    (this.DefaultPublicity != null &&
                    this.DefaultPublicity.Equals(input.DefaultPublicity))
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
                if (this.AllowChat != null)
                    hashCode = hashCode * 59 + this.AllowChat.GetHashCode();
                if (this.ChatSecurity != null)
                    hashCode = hashCode * 59 + this.ChatSecurity.GetHashCode();
                if (this.Callsign != null)
                    hashCode = hashCode * 59 + this.Callsign.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Homepage != null)
                    hashCode = hashCode * 59 + this.Homepage.GetHashCode();
                if (this.EnableInvitationMessagingForAdmins != null)
                    hashCode = hashCode * 59 + this.EnableInvitationMessagingForAdmins.GetHashCode();
                if (this.DefaultPublicity != null)
                    hashCode = hashCode * 59 + this.DefaultPublicity.GetHashCode();
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
