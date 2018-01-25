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
    /// CommunityCommunityLiveStatus
    /// </summary>
    [DataContract]
    public partial class CommunityCommunityLiveStatus :  IEquatable<CommunityCommunityLiveStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityCommunityLiveStatus" /> class.
        /// </summary>
        /// <param name="DateStatusUpdated">DateStatusUpdated.</param>
        /// <param name="Url">Url.</param>
        /// <param name="PartnershipIdentifier">PartnershipIdentifier.</param>
        /// <param name="PartnershipType">PartnershipType.</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="ThumbnailSmall">ThumbnailSmall.</param>
        /// <param name="ThumbnailLarge">ThumbnailLarge.</param>
        /// <param name="DestinyCharacterId">DestinyCharacterId.</param>
        /// <param name="UserInfo">UserInfo.</param>
        /// <param name="CurrentActivityHash">CurrentActivityHash.</param>
        /// <param name="DateLastPlayed">DateLastPlayed.</param>
        /// <param name="DateStreamStarted">DateStreamStarted.</param>
        /// <param name="Locale">Locale.</param>
        /// <param name="CurrentViewers">CurrentViewers.</param>
        /// <param name="Followers">Followers.</param>
        /// <param name="OverallViewers">OverallViewers.</param>
        /// <param name="IsFeatured">IsFeatured.</param>
        /// <param name="Title">Title.</param>
        /// <param name="ActivityModeHash">ActivityModeHash.</param>
        /// <param name="DateFeatured">DateFeatured.</param>
        /// <param name="TrendingValue">TrendingValue.</param>
        /// <param name="IsSubscribable">IsSubscribable.</param>
        public CommunityCommunityLiveStatus(DateTime? DateStatusUpdated = default(DateTime?), string Url = default(string), string PartnershipIdentifier = default(string), PartnershipsPartnershipType PartnershipType = default(PartnershipsPartnershipType), string Thumbnail = default(string), string ThumbnailSmall = default(string), string ThumbnailLarge = default(string), long? DestinyCharacterId = default(long?), UserUserInfoCard UserInfo = default(UserUserInfoCard), uint? CurrentActivityHash = default(uint?), DateTime? DateLastPlayed = default(DateTime?), DateTime? DateStreamStarted = default(DateTime?), string Locale = default(string), int? CurrentViewers = default(int?), int? Followers = default(int?), int? OverallViewers = default(int?), bool? IsFeatured = default(bool?), string Title = default(string), uint? ActivityModeHash = default(uint?), DateTime? DateFeatured = default(DateTime?), float? TrendingValue = default(float?), bool? IsSubscribable = default(bool?))
        {
            this.DateStatusUpdated = DateStatusUpdated;
            this.Url = Url;
            this.PartnershipIdentifier = PartnershipIdentifier;
            this.PartnershipType = PartnershipType;
            this.Thumbnail = Thumbnail;
            this.ThumbnailSmall = ThumbnailSmall;
            this.ThumbnailLarge = ThumbnailLarge;
            this.DestinyCharacterId = DestinyCharacterId;
            this.UserInfo = UserInfo;
            this.CurrentActivityHash = CurrentActivityHash;
            this.DateLastPlayed = DateLastPlayed;
            this.DateStreamStarted = DateStreamStarted;
            this.Locale = Locale;
            this.CurrentViewers = CurrentViewers;
            this.Followers = Followers;
            this.OverallViewers = OverallViewers;
            this.IsFeatured = IsFeatured;
            this.Title = Title;
            this.ActivityModeHash = ActivityModeHash;
            this.DateFeatured = DateFeatured;
            this.TrendingValue = TrendingValue;
            this.IsSubscribable = IsSubscribable;
        }
        
        /// <summary>
        /// Gets or Sets DateStatusUpdated
        /// </summary>
        [DataMember(Name="dateStatusUpdated", EmitDefaultValue=false)]
        public DateTime? DateStatusUpdated { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets PartnershipIdentifier
        /// </summary>
        [DataMember(Name="partnershipIdentifier", EmitDefaultValue=false)]
        public string PartnershipIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets PartnershipType
        /// </summary>
        [DataMember(Name="partnershipType", EmitDefaultValue=false)]
        public PartnershipsPartnershipType PartnershipType { get; set; }

        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailSmall
        /// </summary>
        [DataMember(Name="thumbnailSmall", EmitDefaultValue=false)]
        public string ThumbnailSmall { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailLarge
        /// </summary>
        [DataMember(Name="thumbnailLarge", EmitDefaultValue=false)]
        public string ThumbnailLarge { get; set; }

        /// <summary>
        /// Gets or Sets DestinyCharacterId
        /// </summary>
        [DataMember(Name="destinyCharacterId", EmitDefaultValue=false)]
        public long? DestinyCharacterId { get; set; }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [DataMember(Name="userInfo", EmitDefaultValue=false)]
        public UserUserInfoCard UserInfo { get; set; }

        /// <summary>
        /// Gets or Sets CurrentActivityHash
        /// </summary>
        [DataMember(Name="currentActivityHash", EmitDefaultValue=false)]
        public uint? CurrentActivityHash { get; set; }

        /// <summary>
        /// Gets or Sets DateLastPlayed
        /// </summary>
        [DataMember(Name="dateLastPlayed", EmitDefaultValue=false)]
        public DateTime? DateLastPlayed { get; set; }

        /// <summary>
        /// Gets or Sets DateStreamStarted
        /// </summary>
        [DataMember(Name="dateStreamStarted", EmitDefaultValue=false)]
        public DateTime? DateStreamStarted { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets CurrentViewers
        /// </summary>
        [DataMember(Name="currentViewers", EmitDefaultValue=false)]
        public int? CurrentViewers { get; set; }

        /// <summary>
        /// Gets or Sets Followers
        /// </summary>
        [DataMember(Name="followers", EmitDefaultValue=false)]
        public int? Followers { get; set; }

        /// <summary>
        /// Gets or Sets OverallViewers
        /// </summary>
        [DataMember(Name="overallViewers", EmitDefaultValue=false)]
        public int? OverallViewers { get; set; }

        /// <summary>
        /// Gets or Sets IsFeatured
        /// </summary>
        [DataMember(Name="isFeatured", EmitDefaultValue=false)]
        public bool? IsFeatured { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets ActivityModeHash
        /// </summary>
        [DataMember(Name="activityModeHash", EmitDefaultValue=false)]
        public uint? ActivityModeHash { get; set; }

        /// <summary>
        /// Gets or Sets DateFeatured
        /// </summary>
        [DataMember(Name="dateFeatured", EmitDefaultValue=false)]
        public DateTime? DateFeatured { get; set; }

        /// <summary>
        /// Gets or Sets TrendingValue
        /// </summary>
        [DataMember(Name="trendingValue", EmitDefaultValue=false)]
        public float? TrendingValue { get; set; }

        /// <summary>
        /// Gets or Sets IsSubscribable
        /// </summary>
        [DataMember(Name="isSubscribable", EmitDefaultValue=false)]
        public bool? IsSubscribable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommunityCommunityLiveStatus {\n");
            sb.Append("  DateStatusUpdated: ").Append(DateStatusUpdated).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  PartnershipIdentifier: ").Append(PartnershipIdentifier).Append("\n");
            sb.Append("  PartnershipType: ").Append(PartnershipType).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  ThumbnailSmall: ").Append(ThumbnailSmall).Append("\n");
            sb.Append("  ThumbnailLarge: ").Append(ThumbnailLarge).Append("\n");
            sb.Append("  DestinyCharacterId: ").Append(DestinyCharacterId).Append("\n");
            sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
            sb.Append("  CurrentActivityHash: ").Append(CurrentActivityHash).Append("\n");
            sb.Append("  DateLastPlayed: ").Append(DateLastPlayed).Append("\n");
            sb.Append("  DateStreamStarted: ").Append(DateStreamStarted).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  CurrentViewers: ").Append(CurrentViewers).Append("\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
            sb.Append("  OverallViewers: ").Append(OverallViewers).Append("\n");
            sb.Append("  IsFeatured: ").Append(IsFeatured).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ActivityModeHash: ").Append(ActivityModeHash).Append("\n");
            sb.Append("  DateFeatured: ").Append(DateFeatured).Append("\n");
            sb.Append("  TrendingValue: ").Append(TrendingValue).Append("\n");
            sb.Append("  IsSubscribable: ").Append(IsSubscribable).Append("\n");
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
            return this.Equals(input as CommunityCommunityLiveStatus);
        }

        /// <summary>
        /// Returns true if CommunityCommunityLiveStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of CommunityCommunityLiveStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommunityCommunityLiveStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateStatusUpdated == input.DateStatusUpdated ||
                    (this.DateStatusUpdated != null &&
                    this.DateStatusUpdated.Equals(input.DateStatusUpdated))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.PartnershipIdentifier == input.PartnershipIdentifier ||
                    (this.PartnershipIdentifier != null &&
                    this.PartnershipIdentifier.Equals(input.PartnershipIdentifier))
                ) && 
                (
                    this.PartnershipType == input.PartnershipType ||
                    (this.PartnershipType != null &&
                    this.PartnershipType.Equals(input.PartnershipType))
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
                ) && 
                (
                    this.ThumbnailSmall == input.ThumbnailSmall ||
                    (this.ThumbnailSmall != null &&
                    this.ThumbnailSmall.Equals(input.ThumbnailSmall))
                ) && 
                (
                    this.ThumbnailLarge == input.ThumbnailLarge ||
                    (this.ThumbnailLarge != null &&
                    this.ThumbnailLarge.Equals(input.ThumbnailLarge))
                ) && 
                (
                    this.DestinyCharacterId == input.DestinyCharacterId ||
                    (this.DestinyCharacterId != null &&
                    this.DestinyCharacterId.Equals(input.DestinyCharacterId))
                ) && 
                (
                    this.UserInfo == input.UserInfo ||
                    (this.UserInfo != null &&
                    this.UserInfo.Equals(input.UserInfo))
                ) && 
                (
                    this.CurrentActivityHash == input.CurrentActivityHash ||
                    (this.CurrentActivityHash != null &&
                    this.CurrentActivityHash.Equals(input.CurrentActivityHash))
                ) && 
                (
                    this.DateLastPlayed == input.DateLastPlayed ||
                    (this.DateLastPlayed != null &&
                    this.DateLastPlayed.Equals(input.DateLastPlayed))
                ) && 
                (
                    this.DateStreamStarted == input.DateStreamStarted ||
                    (this.DateStreamStarted != null &&
                    this.DateStreamStarted.Equals(input.DateStreamStarted))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.CurrentViewers == input.CurrentViewers ||
                    (this.CurrentViewers != null &&
                    this.CurrentViewers.Equals(input.CurrentViewers))
                ) && 
                (
                    this.Followers == input.Followers ||
                    (this.Followers != null &&
                    this.Followers.Equals(input.Followers))
                ) && 
                (
                    this.OverallViewers == input.OverallViewers ||
                    (this.OverallViewers != null &&
                    this.OverallViewers.Equals(input.OverallViewers))
                ) && 
                (
                    this.IsFeatured == input.IsFeatured ||
                    (this.IsFeatured != null &&
                    this.IsFeatured.Equals(input.IsFeatured))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.ActivityModeHash == input.ActivityModeHash ||
                    (this.ActivityModeHash != null &&
                    this.ActivityModeHash.Equals(input.ActivityModeHash))
                ) && 
                (
                    this.DateFeatured == input.DateFeatured ||
                    (this.DateFeatured != null &&
                    this.DateFeatured.Equals(input.DateFeatured))
                ) && 
                (
                    this.TrendingValue == input.TrendingValue ||
                    (this.TrendingValue != null &&
                    this.TrendingValue.Equals(input.TrendingValue))
                ) && 
                (
                    this.IsSubscribable == input.IsSubscribable ||
                    (this.IsSubscribable != null &&
                    this.IsSubscribable.Equals(input.IsSubscribable))
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
                if (this.DateStatusUpdated != null)
                    hashCode = hashCode * 59 + this.DateStatusUpdated.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.PartnershipIdentifier != null)
                    hashCode = hashCode * 59 + this.PartnershipIdentifier.GetHashCode();
                if (this.PartnershipType != null)
                    hashCode = hashCode * 59 + this.PartnershipType.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.ThumbnailSmall != null)
                    hashCode = hashCode * 59 + this.ThumbnailSmall.GetHashCode();
                if (this.ThumbnailLarge != null)
                    hashCode = hashCode * 59 + this.ThumbnailLarge.GetHashCode();
                if (this.DestinyCharacterId != null)
                    hashCode = hashCode * 59 + this.DestinyCharacterId.GetHashCode();
                if (this.UserInfo != null)
                    hashCode = hashCode * 59 + this.UserInfo.GetHashCode();
                if (this.CurrentActivityHash != null)
                    hashCode = hashCode * 59 + this.CurrentActivityHash.GetHashCode();
                if (this.DateLastPlayed != null)
                    hashCode = hashCode * 59 + this.DateLastPlayed.GetHashCode();
                if (this.DateStreamStarted != null)
                    hashCode = hashCode * 59 + this.DateStreamStarted.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.CurrentViewers != null)
                    hashCode = hashCode * 59 + this.CurrentViewers.GetHashCode();
                if (this.Followers != null)
                    hashCode = hashCode * 59 + this.Followers.GetHashCode();
                if (this.OverallViewers != null)
                    hashCode = hashCode * 59 + this.OverallViewers.GetHashCode();
                if (this.IsFeatured != null)
                    hashCode = hashCode * 59 + this.IsFeatured.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.ActivityModeHash != null)
                    hashCode = hashCode * 59 + this.ActivityModeHash.GetHashCode();
                if (this.DateFeatured != null)
                    hashCode = hashCode * 59 + this.DateFeatured.GetHashCode();
                if (this.TrendingValue != null)
                    hashCode = hashCode * 59 + this.TrendingValue.GetHashCode();
                if (this.IsSubscribable != null)
                    hashCode = hashCode * 59 + this.IsSubscribable.GetHashCode();
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
