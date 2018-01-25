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
    /// TrendingTrendingEntryCommunityStream
    /// </summary>
    [DataContract]
    public partial class TrendingTrendingEntryCommunityStream :  IEquatable<TrendingTrendingEntryCommunityStream>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingTrendingEntryCommunityStream" /> class.
        /// </summary>
        /// <param name="Image">Image.</param>
        /// <param name="Title">Title.</param>
        /// <param name="PartnershipIdentifier">PartnershipIdentifier.</param>
        /// <param name="PartnershipType">PartnershipType.</param>
        public TrendingTrendingEntryCommunityStream(string Image = default(string), string Title = default(string), string PartnershipIdentifier = default(string), PartnershipsPartnershipType PartnershipType = default(PartnershipsPartnershipType))
        {
            this.Image = Image;
            this.Title = Title;
            this.PartnershipIdentifier = PartnershipIdentifier;
            this.PartnershipType = PartnershipType;
        }
        
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrendingTrendingEntryCommunityStream {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  PartnershipIdentifier: ").Append(PartnershipIdentifier).Append("\n");
            sb.Append("  PartnershipType: ").Append(PartnershipType).Append("\n");
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
            return this.Equals(input as TrendingTrendingEntryCommunityStream);
        }

        /// <summary>
        /// Returns true if TrendingTrendingEntryCommunityStream instances are equal
        /// </summary>
        /// <param name="input">Instance of TrendingTrendingEntryCommunityStream to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrendingTrendingEntryCommunityStream input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.PartnershipIdentifier != null)
                    hashCode = hashCode * 59 + this.PartnershipIdentifier.GetHashCode();
                if (this.PartnershipType != null)
                    hashCode = hashCode * 59 + this.PartnershipType.GetHashCode();
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
