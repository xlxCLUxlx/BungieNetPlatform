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
    /// ForumPostResponse
    /// </summary>
    [DataContract]
    public partial class ForumPostResponse :  IEquatable<ForumPostResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumPostResponse" /> class.
        /// </summary>
        /// <param name="LastReplyTimestamp">LastReplyTimestamp.</param>
        /// <param name="IsPinned">IsPinned.</param>
        /// <param name="UrlMediaType">UrlMediaType.</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="Popularity">Popularity.</param>
        /// <param name="IsActive">IsActive.</param>
        /// <param name="IsAnnouncement">IsAnnouncement.</param>
        /// <param name="UserRating">UserRating.</param>
        /// <param name="UserHasRated">UserHasRated.</param>
        /// <param name="UserHasMutedPost">UserHasMutedPost.</param>
        /// <param name="LatestReplyPostId">LatestReplyPostId.</param>
        /// <param name="LatestReplyAuthorId">LatestReplyAuthorId.</param>
        /// <param name="IgnoreStatus">IgnoreStatus.</param>
        /// <param name="Locale">Locale.</param>
        public ForumPostResponse(DateTime? LastReplyTimestamp = default(DateTime?), bool? IsPinned = default(bool?), ForumForumMediaType UrlMediaType = default(ForumForumMediaType), string Thumbnail = default(string), ForumForumPostPopularity Popularity = default(ForumForumPostPopularity), bool? IsActive = default(bool?), bool? IsAnnouncement = default(bool?), int? UserRating = default(int?), bool? UserHasRated = default(bool?), bool? UserHasMutedPost = default(bool?), long? LatestReplyPostId = default(long?), long? LatestReplyAuthorId = default(long?), IgnoresIgnoreResponse IgnoreStatus = default(IgnoresIgnoreResponse), string Locale = default(string))
        {
            this.LastReplyTimestamp = LastReplyTimestamp;
            this.IsPinned = IsPinned;
            this.UrlMediaType = UrlMediaType;
            this.Thumbnail = Thumbnail;
            this.Popularity = Popularity;
            this.IsActive = IsActive;
            this.IsAnnouncement = IsAnnouncement;
            this.UserRating = UserRating;
            this.UserHasRated = UserHasRated;
            this.UserHasMutedPost = UserHasMutedPost;
            this.LatestReplyPostId = LatestReplyPostId;
            this.LatestReplyAuthorId = LatestReplyAuthorId;
            this.IgnoreStatus = IgnoreStatus;
            this.Locale = Locale;
        }
        
        /// <summary>
        /// Gets or Sets LastReplyTimestamp
        /// </summary>
        [DataMember(Name="lastReplyTimestamp", EmitDefaultValue=false)]
        public DateTime? LastReplyTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets IsPinned
        /// </summary>
        [DataMember(Name="IsPinned", EmitDefaultValue=false)]
        public bool? IsPinned { get; set; }

        /// <summary>
        /// Gets or Sets UrlMediaType
        /// </summary>
        [DataMember(Name="urlMediaType", EmitDefaultValue=false)]
        public ForumForumMediaType UrlMediaType { get; set; }

        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or Sets Popularity
        /// </summary>
        [DataMember(Name="popularity", EmitDefaultValue=false)]
        public ForumForumPostPopularity Popularity { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsAnnouncement
        /// </summary>
        [DataMember(Name="isAnnouncement", EmitDefaultValue=false)]
        public bool? IsAnnouncement { get; set; }

        /// <summary>
        /// Gets or Sets UserRating
        /// </summary>
        [DataMember(Name="userRating", EmitDefaultValue=false)]
        public int? UserRating { get; set; }

        /// <summary>
        /// Gets or Sets UserHasRated
        /// </summary>
        [DataMember(Name="userHasRated", EmitDefaultValue=false)]
        public bool? UserHasRated { get; set; }

        /// <summary>
        /// Gets or Sets UserHasMutedPost
        /// </summary>
        [DataMember(Name="userHasMutedPost", EmitDefaultValue=false)]
        public bool? UserHasMutedPost { get; set; }

        /// <summary>
        /// Gets or Sets LatestReplyPostId
        /// </summary>
        [DataMember(Name="latestReplyPostId", EmitDefaultValue=false)]
        public long? LatestReplyPostId { get; set; }

        /// <summary>
        /// Gets or Sets LatestReplyAuthorId
        /// </summary>
        [DataMember(Name="latestReplyAuthorId", EmitDefaultValue=false)]
        public long? LatestReplyAuthorId { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreStatus
        /// </summary>
        [DataMember(Name="ignoreStatus", EmitDefaultValue=false)]
        public IgnoresIgnoreResponse IgnoreStatus { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForumPostResponse {\n");
            sb.Append("  LastReplyTimestamp: ").Append(LastReplyTimestamp).Append("\n");
            sb.Append("  IsPinned: ").Append(IsPinned).Append("\n");
            sb.Append("  UrlMediaType: ").Append(UrlMediaType).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Popularity: ").Append(Popularity).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsAnnouncement: ").Append(IsAnnouncement).Append("\n");
            sb.Append("  UserRating: ").Append(UserRating).Append("\n");
            sb.Append("  UserHasRated: ").Append(UserHasRated).Append("\n");
            sb.Append("  UserHasMutedPost: ").Append(UserHasMutedPost).Append("\n");
            sb.Append("  LatestReplyPostId: ").Append(LatestReplyPostId).Append("\n");
            sb.Append("  LatestReplyAuthorId: ").Append(LatestReplyAuthorId).Append("\n");
            sb.Append("  IgnoreStatus: ").Append(IgnoreStatus).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as ForumPostResponse);
        }

        /// <summary>
        /// Returns true if ForumPostResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ForumPostResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumPostResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastReplyTimestamp == input.LastReplyTimestamp ||
                    (this.LastReplyTimestamp != null &&
                    this.LastReplyTimestamp.Equals(input.LastReplyTimestamp))
                ) && 
                (
                    this.IsPinned == input.IsPinned ||
                    (this.IsPinned != null &&
                    this.IsPinned.Equals(input.IsPinned))
                ) && 
                (
                    this.UrlMediaType == input.UrlMediaType ||
                    (this.UrlMediaType != null &&
                    this.UrlMediaType.Equals(input.UrlMediaType))
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
                ) && 
                (
                    this.Popularity == input.Popularity ||
                    (this.Popularity != null &&
                    this.Popularity.Equals(input.Popularity))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
                ) && 
                (
                    this.IsAnnouncement == input.IsAnnouncement ||
                    (this.IsAnnouncement != null &&
                    this.IsAnnouncement.Equals(input.IsAnnouncement))
                ) && 
                (
                    this.UserRating == input.UserRating ||
                    (this.UserRating != null &&
                    this.UserRating.Equals(input.UserRating))
                ) && 
                (
                    this.UserHasRated == input.UserHasRated ||
                    (this.UserHasRated != null &&
                    this.UserHasRated.Equals(input.UserHasRated))
                ) && 
                (
                    this.UserHasMutedPost == input.UserHasMutedPost ||
                    (this.UserHasMutedPost != null &&
                    this.UserHasMutedPost.Equals(input.UserHasMutedPost))
                ) && 
                (
                    this.LatestReplyPostId == input.LatestReplyPostId ||
                    (this.LatestReplyPostId != null &&
                    this.LatestReplyPostId.Equals(input.LatestReplyPostId))
                ) && 
                (
                    this.LatestReplyAuthorId == input.LatestReplyAuthorId ||
                    (this.LatestReplyAuthorId != null &&
                    this.LatestReplyAuthorId.Equals(input.LatestReplyAuthorId))
                ) && 
                (
                    this.IgnoreStatus == input.IgnoreStatus ||
                    (this.IgnoreStatus != null &&
                    this.IgnoreStatus.Equals(input.IgnoreStatus))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.LastReplyTimestamp != null)
                    hashCode = hashCode * 59 + this.LastReplyTimestamp.GetHashCode();
                if (this.IsPinned != null)
                    hashCode = hashCode * 59 + this.IsPinned.GetHashCode();
                if (this.UrlMediaType != null)
                    hashCode = hashCode * 59 + this.UrlMediaType.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.Popularity != null)
                    hashCode = hashCode * 59 + this.Popularity.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.IsAnnouncement != null)
                    hashCode = hashCode * 59 + this.IsAnnouncement.GetHashCode();
                if (this.UserRating != null)
                    hashCode = hashCode * 59 + this.UserRating.GetHashCode();
                if (this.UserHasRated != null)
                    hashCode = hashCode * 59 + this.UserHasRated.GetHashCode();
                if (this.UserHasMutedPost != null)
                    hashCode = hashCode * 59 + this.UserHasMutedPost.GetHashCode();
                if (this.LatestReplyPostId != null)
                    hashCode = hashCode * 59 + this.LatestReplyPostId.GetHashCode();
                if (this.LatestReplyAuthorId != null)
                    hashCode = hashCode * 59 + this.LatestReplyAuthorId.GetHashCode();
                if (this.IgnoreStatus != null)
                    hashCode = hashCode * 59 + this.IgnoreStatus.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
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
