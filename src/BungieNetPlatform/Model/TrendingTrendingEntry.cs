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
    /// The list entry view for trending items. Returns just enough to show the item on the trending page.
    /// </summary>
    [DataContract]
    public partial class TrendingTrendingEntry :  IEquatable<TrendingTrendingEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingTrendingEntry" /> class.
        /// </summary>
        /// <param name="Weight">The weighted score of this trending item..</param>
        /// <param name="IsFeatured">IsFeatured.</param>
        /// <param name="Identifier">We don&#39;t know whether the identifier will be a string, a uint, or a long... so we&#39;re going to cast it all to a string. But either way, we need any trending item created to have a single unique identifier for its type..</param>
        /// <param name="EntityType">An enum - unfortunately - dictating all of the possible kinds of trending items that you might get in your result set, in case you want to do custom rendering or call to get the details of the item..</param>
        /// <param name="DisplayName">The localized \&quot;display name/article title/&#39;primary localized identifier&#39;\&quot; of the entity..</param>
        /// <param name="Tagline">If the entity has a localized tagline/subtitle/motto/whatever, that is found here..</param>
        /// <param name="Image">Image.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Link">Link.</param>
        /// <param name="WebmVideo">If this is populated, the entry has a related WebM video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo.</param>
        /// <param name="Mp4Video">If this is populated, the entry has a related MP4 video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo.</param>
        /// <param name="FeatureImage">If isFeatured, this image will be populated with whatever the featured image is. Note that this will likely be a very large image, so don&#39;t use it all the time..</param>
        public TrendingTrendingEntry(double? Weight = default(double?), bool? IsFeatured = default(bool?), string Identifier = default(string), TrendingTrendingEntryType EntityType = default(TrendingTrendingEntryType), string DisplayName = default(string), string Tagline = default(string), string Image = default(string), DateTime? StartDate = default(DateTime?), DateTime? EndDate = default(DateTime?), string Link = default(string), string WebmVideo = default(string), string Mp4Video = default(string), string FeatureImage = default(string))
        {
            this.Weight = Weight;
            this.IsFeatured = IsFeatured;
            this.Identifier = Identifier;
            this.EntityType = EntityType;
            this.DisplayName = DisplayName;
            this.Tagline = Tagline;
            this.Image = Image;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Link = Link;
            this.WebmVideo = WebmVideo;
            this.Mp4Video = Mp4Video;
            this.FeatureImage = FeatureImage;
        }
        
        /// <summary>
        /// The weighted score of this trending item.
        /// </summary>
        /// <value>The weighted score of this trending item.</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public double? Weight { get; set; }

        /// <summary>
        /// Gets or Sets IsFeatured
        /// </summary>
        [DataMember(Name="isFeatured", EmitDefaultValue=false)]
        public bool? IsFeatured { get; set; }

        /// <summary>
        /// We don&#39;t know whether the identifier will be a string, a uint, or a long... so we&#39;re going to cast it all to a string. But either way, we need any trending item created to have a single unique identifier for its type.
        /// </summary>
        /// <value>We don&#39;t know whether the identifier will be a string, a uint, or a long... so we&#39;re going to cast it all to a string. But either way, we need any trending item created to have a single unique identifier for its type.</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// An enum - unfortunately - dictating all of the possible kinds of trending items that you might get in your result set, in case you want to do custom rendering or call to get the details of the item.
        /// </summary>
        /// <value>An enum - unfortunately - dictating all of the possible kinds of trending items that you might get in your result set, in case you want to do custom rendering or call to get the details of the item.</value>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public TrendingTrendingEntryType EntityType { get; set; }

        /// <summary>
        /// The localized \&quot;display name/article title/&#39;primary localized identifier&#39;\&quot; of the entity.
        /// </summary>
        /// <value>The localized \&quot;display name/article title/&#39;primary localized identifier&#39;\&quot; of the entity.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// If the entity has a localized tagline/subtitle/motto/whatever, that is found here.
        /// </summary>
        /// <value>If the entity has a localized tagline/subtitle/motto/whatever, that is found here.</value>
        [DataMember(Name="tagline", EmitDefaultValue=false)]
        public string Tagline { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// If this is populated, the entry has a related WebM video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo
        /// </summary>
        /// <value>If this is populated, the entry has a related WebM video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo</value>
        [DataMember(Name="webmVideo", EmitDefaultValue=false)]
        public string WebmVideo { get; set; }

        /// <summary>
        /// If this is populated, the entry has a related MP4 video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo
        /// </summary>
        /// <value>If this is populated, the entry has a related MP4 video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo</value>
        [DataMember(Name="mp4Video", EmitDefaultValue=false)]
        public string Mp4Video { get; set; }

        /// <summary>
        /// If isFeatured, this image will be populated with whatever the featured image is. Note that this will likely be a very large image, so don&#39;t use it all the time.
        /// </summary>
        /// <value>If isFeatured, this image will be populated with whatever the featured image is. Note that this will likely be a very large image, so don&#39;t use it all the time.</value>
        [DataMember(Name="featureImage", EmitDefaultValue=false)]
        public string FeatureImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrendingTrendingEntry {\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  IsFeatured: ").Append(IsFeatured).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Tagline: ").Append(Tagline).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  WebmVideo: ").Append(WebmVideo).Append("\n");
            sb.Append("  Mp4Video: ").Append(Mp4Video).Append("\n");
            sb.Append("  FeatureImage: ").Append(FeatureImage).Append("\n");
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
            return this.Equals(input as TrendingTrendingEntry);
        }

        /// <summary>
        /// Returns true if TrendingTrendingEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of TrendingTrendingEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrendingTrendingEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.IsFeatured == input.IsFeatured ||
                    (this.IsFeatured != null &&
                    this.IsFeatured.Equals(input.IsFeatured))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Tagline == input.Tagline ||
                    (this.Tagline != null &&
                    this.Tagline.Equals(input.Tagline))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.WebmVideo == input.WebmVideo ||
                    (this.WebmVideo != null &&
                    this.WebmVideo.Equals(input.WebmVideo))
                ) && 
                (
                    this.Mp4Video == input.Mp4Video ||
                    (this.Mp4Video != null &&
                    this.Mp4Video.Equals(input.Mp4Video))
                ) && 
                (
                    this.FeatureImage == input.FeatureImage ||
                    (this.FeatureImage != null &&
                    this.FeatureImage.Equals(input.FeatureImage))
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
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.IsFeatured != null)
                    hashCode = hashCode * 59 + this.IsFeatured.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Tagline != null)
                    hashCode = hashCode * 59 + this.Tagline.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.WebmVideo != null)
                    hashCode = hashCode * 59 + this.WebmVideo.GetHashCode();
                if (this.Mp4Video != null)
                    hashCode = hashCode * 59 + this.Mp4Video.GetHashCode();
                if (this.FeatureImage != null)
                    hashCode = hashCode * 59 + this.FeatureImage.GetHashCode();
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
