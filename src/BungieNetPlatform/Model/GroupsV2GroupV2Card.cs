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
    /// A small infocard of group information, usually used for when a list of groups are returned
    /// </summary>
    [DataContract]
    public partial class GroupsV2GroupV2Card :  IEquatable<GroupsV2GroupV2Card>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupV2Card" /> class.
        /// </summary>
        /// <param name="GroupId">GroupId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="GroupType">GroupType.</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="About">About.</param>
        /// <param name="Motto">Motto.</param>
        /// <param name="MemberCount">MemberCount.</param>
        /// <param name="Locale">Locale.</param>
        /// <param name="MembershipOption">MembershipOption.</param>
        /// <param name="Capabilities">Capabilities.</param>
        /// <param name="ClanInfo">ClanInfo.</param>
        /// <param name="AvatarPath">AvatarPath.</param>
        /// <param name="Theme">Theme.</param>
        public GroupsV2GroupV2Card(long? GroupId = default(long?), string Name = default(string), GroupsV2GroupType GroupType = default(GroupsV2GroupType), DateTime? CreationDate = default(DateTime?), string About = default(string), string Motto = default(string), int? MemberCount = default(int?), string Locale = default(string), GroupsV2MembershipOption MembershipOption = default(GroupsV2MembershipOption), GroupsV2Capabilities Capabilities = default(GroupsV2Capabilities), GroupsV2GroupV2ClanInfo ClanInfo = default(GroupsV2GroupV2ClanInfo), string AvatarPath = default(string), string Theme = default(string))
        {
            this.GroupId = GroupId;
            this.Name = Name;
            this.GroupType = GroupType;
            this.CreationDate = CreationDate;
            this.About = About;
            this.Motto = Motto;
            this.MemberCount = MemberCount;
            this.Locale = Locale;
            this.MembershipOption = MembershipOption;
            this.Capabilities = Capabilities;
            this.ClanInfo = ClanInfo;
            this.AvatarPath = AvatarPath;
            this.Theme = Theme;
        }
        
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets GroupType
        /// </summary>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public GroupsV2GroupType GroupType { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

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
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name="memberCount", EmitDefaultValue=false)]
        public int? MemberCount { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets MembershipOption
        /// </summary>
        [DataMember(Name="membershipOption", EmitDefaultValue=false)]
        public GroupsV2MembershipOption MembershipOption { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public GroupsV2Capabilities Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets ClanInfo
        /// </summary>
        [DataMember(Name="clanInfo", EmitDefaultValue=false)]
        public GroupsV2GroupV2ClanInfo ClanInfo { get; set; }

        /// <summary>
        /// Gets or Sets AvatarPath
        /// </summary>
        [DataMember(Name="avatarPath", EmitDefaultValue=false)]
        public string AvatarPath { get; set; }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name="theme", EmitDefaultValue=false)]
        public string Theme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsV2GroupV2Card {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  Motto: ").Append(Motto).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  MembershipOption: ").Append(MembershipOption).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  ClanInfo: ").Append(ClanInfo).Append("\n");
            sb.Append("  AvatarPath: ").Append(AvatarPath).Append("\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
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
            return this.Equals(input as GroupsV2GroupV2Card);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupV2Card instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupV2Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupV2Card input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
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
                    this.MemberCount == input.MemberCount ||
                    (this.MemberCount != null &&
                    this.MemberCount.Equals(input.MemberCount))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.MembershipOption == input.MembershipOption ||
                    (this.MembershipOption != null &&
                    this.MembershipOption.Equals(input.MembershipOption))
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    (this.Capabilities != null &&
                    this.Capabilities.Equals(input.Capabilities))
                ) && 
                (
                    this.ClanInfo == input.ClanInfo ||
                    (this.ClanInfo != null &&
                    this.ClanInfo.Equals(input.ClanInfo))
                ) && 
                (
                    this.AvatarPath == input.AvatarPath ||
                    (this.AvatarPath != null &&
                    this.AvatarPath.Equals(input.AvatarPath))
                ) && 
                (
                    this.Theme == input.Theme ||
                    (this.Theme != null &&
                    this.Theme.Equals(input.Theme))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.About != null)
                    hashCode = hashCode * 59 + this.About.GetHashCode();
                if (this.Motto != null)
                    hashCode = hashCode * 59 + this.Motto.GetHashCode();
                if (this.MemberCount != null)
                    hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.MembershipOption != null)
                    hashCode = hashCode * 59 + this.MembershipOption.GetHashCode();
                if (this.Capabilities != null)
                    hashCode = hashCode * 59 + this.Capabilities.GetHashCode();
                if (this.ClanInfo != null)
                    hashCode = hashCode * 59 + this.ClanInfo.GetHashCode();
                if (this.AvatarPath != null)
                    hashCode = hashCode * 59 + this.AvatarPath.GetHashCode();
                if (this.Theme != null)
                    hashCode = hashCode * 59 + this.Theme.GetHashCode();
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
