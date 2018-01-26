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
    /// GroupsV2GroupPotentialMember
    /// </summary>
    [DataContract]
    public partial class GroupsV2GroupPotentialMember :  IEquatable<GroupsV2GroupPotentialMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupPotentialMember" /> class.
        /// </summary>
        /// <param name="PotentialStatus">PotentialStatus.</param>
        /// <param name="GroupId">GroupId.</param>
        /// <param name="DestinyUserInfo">DestinyUserInfo.</param>
        /// <param name="BungieNetUserInfo">BungieNetUserInfo.</param>
        /// <param name="JoinDate">JoinDate.</param>
        public GroupsV2GroupPotentialMember(GroupsV2GroupPotentialMemberStatus PotentialStatus = default(GroupsV2GroupPotentialMemberStatus), long? GroupId = default(long?), UserUserInfoCard DestinyUserInfo = default(UserUserInfoCard), UserUserInfoCard BungieNetUserInfo = default(UserUserInfoCard), DateTime? JoinDate = default(DateTime?))
        {
            this.PotentialStatus = PotentialStatus;
            this.GroupId = GroupId;
            this.DestinyUserInfo = DestinyUserInfo;
            this.BungieNetUserInfo = BungieNetUserInfo;
            this.JoinDate = JoinDate;
        }
        
        /// <summary>
        /// Gets or Sets PotentialStatus
        /// </summary>
        [DataMember(Name="potentialStatus", EmitDefaultValue=false)]
        public GroupsV2GroupPotentialMemberStatus PotentialStatus { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// Gets or Sets DestinyUserInfo
        /// </summary>
        [DataMember(Name="destinyUserInfo", EmitDefaultValue=false)]
        public UserUserInfoCard DestinyUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets BungieNetUserInfo
        /// </summary>
        [DataMember(Name="bungieNetUserInfo", EmitDefaultValue=false)]
        public UserUserInfoCard BungieNetUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets JoinDate
        /// </summary>
        [DataMember(Name="joinDate", EmitDefaultValue=false)]
        public DateTime? JoinDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsV2GroupPotentialMember {\n");
            sb.Append("  PotentialStatus: ").Append(PotentialStatus).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  DestinyUserInfo: ").Append(DestinyUserInfo).Append("\n");
            sb.Append("  BungieNetUserInfo: ").Append(BungieNetUserInfo).Append("\n");
            sb.Append("  JoinDate: ").Append(JoinDate).Append("\n");
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
            return this.Equals(input as GroupsV2GroupPotentialMember);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupPotentialMember instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupPotentialMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupPotentialMember input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PotentialStatus == input.PotentialStatus ||
                    (this.PotentialStatus != null &&
                    this.PotentialStatus.Equals(input.PotentialStatus))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.DestinyUserInfo == input.DestinyUserInfo ||
                    (this.DestinyUserInfo != null &&
                    this.DestinyUserInfo.Equals(input.DestinyUserInfo))
                ) && 
                (
                    this.BungieNetUserInfo == input.BungieNetUserInfo ||
                    (this.BungieNetUserInfo != null &&
                    this.BungieNetUserInfo.Equals(input.BungieNetUserInfo))
                ) && 
                (
                    this.JoinDate == input.JoinDate ||
                    (this.JoinDate != null &&
                    this.JoinDate.Equals(input.JoinDate))
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
                if (this.PotentialStatus != null)
                    hashCode = hashCode * 59 + this.PotentialStatus.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.DestinyUserInfo != null)
                    hashCode = hashCode * 59 + this.DestinyUserInfo.GetHashCode();
                if (this.BungieNetUserInfo != null)
                    hashCode = hashCode * 59 + this.BungieNetUserInfo.GetHashCode();
                if (this.JoinDate != null)
                    hashCode = hashCode * 59 + this.JoinDate.GetHashCode();
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
