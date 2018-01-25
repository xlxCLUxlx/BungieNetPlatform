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
    /// The most essential summary information about a Profile (in Destiny 1, we called these \&quot;Accounts\&quot;).
    /// </summary>
    [DataContract]
    public partial class DestinyEntitiesProfilesDestinyProfileComponent :  IEquatable<DestinyEntitiesProfilesDestinyProfileComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesProfilesDestinyProfileComponent" /> class.
        /// </summary>
        /// <param name="UserInfo">If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information..</param>
        /// <param name="DateLastPlayed">The last time the user played with any character on this Profile..</param>
        /// <param name="VersionsOwned">If you want to know what expansions they own, this will contain that data..</param>
        /// <param name="CharacterIds">A list of the character IDs, for further querying on your part..</param>
        public DestinyEntitiesProfilesDestinyProfileComponent(UserUserInfoCard UserInfo = default(UserUserInfoCard), DateTime? DateLastPlayed = default(DateTime?), DestinyDestinyGameVersions VersionsOwned = default(DestinyDestinyGameVersions), List<long?> CharacterIds = default(List<long?>))
        {
            this.UserInfo = UserInfo;
            this.DateLastPlayed = DateLastPlayed;
            this.VersionsOwned = VersionsOwned;
            this.CharacterIds = CharacterIds;
        }
        
        /// <summary>
        /// If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.
        /// </summary>
        /// <value>If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information.</value>
        [DataMember(Name="userInfo", EmitDefaultValue=false)]
        public UserUserInfoCard UserInfo { get; set; }

        /// <summary>
        /// The last time the user played with any character on this Profile.
        /// </summary>
        /// <value>The last time the user played with any character on this Profile.</value>
        [DataMember(Name="dateLastPlayed", EmitDefaultValue=false)]
        public DateTime? DateLastPlayed { get; set; }

        /// <summary>
        /// If you want to know what expansions they own, this will contain that data.
        /// </summary>
        /// <value>If you want to know what expansions they own, this will contain that data.</value>
        [DataMember(Name="versionsOwned", EmitDefaultValue=false)]
        public DestinyDestinyGameVersions VersionsOwned { get; set; }

        /// <summary>
        /// A list of the character IDs, for further querying on your part.
        /// </summary>
        /// <value>A list of the character IDs, for further querying on your part.</value>
        [DataMember(Name="characterIds", EmitDefaultValue=false)]
        public List<long?> CharacterIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyEntitiesProfilesDestinyProfileComponent {\n");
            sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
            sb.Append("  DateLastPlayed: ").Append(DateLastPlayed).Append("\n");
            sb.Append("  VersionsOwned: ").Append(VersionsOwned).Append("\n");
            sb.Append("  CharacterIds: ").Append(CharacterIds).Append("\n");
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
            return this.Equals(input as DestinyEntitiesProfilesDestinyProfileComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesProfilesDestinyProfileComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesProfilesDestinyProfileComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesProfilesDestinyProfileComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserInfo == input.UserInfo ||
                    (this.UserInfo != null &&
                    this.UserInfo.Equals(input.UserInfo))
                ) && 
                (
                    this.DateLastPlayed == input.DateLastPlayed ||
                    (this.DateLastPlayed != null &&
                    this.DateLastPlayed.Equals(input.DateLastPlayed))
                ) && 
                (
                    this.VersionsOwned == input.VersionsOwned ||
                    (this.VersionsOwned != null &&
                    this.VersionsOwned.Equals(input.VersionsOwned))
                ) && 
                (
                    this.CharacterIds == input.CharacterIds ||
                    this.CharacterIds != null &&
                    this.CharacterIds.SequenceEqual(input.CharacterIds)
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
                if (this.UserInfo != null)
                    hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                if (this.DateLastPlayed != null)
                    hashCode = hashCode * 59 + this.DateLastPlayed.GetHashCode();
                if (this.VersionsOwned != null)
                    hashCode = hashCode * 59 + this.VersionsOwned.GetHashCode();
                if (this.CharacterIds != null)
                    hashCode = hashCode * 59 + this.CharacterIds.GetHashCode();
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