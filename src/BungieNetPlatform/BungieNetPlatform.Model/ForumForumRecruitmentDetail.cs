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
    /// ForumForumRecruitmentDetail
    /// </summary>
    [DataContract]
    public partial class ForumForumRecruitmentDetail :  IEquatable<ForumForumRecruitmentDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumForumRecruitmentDetail" /> class.
        /// </summary>
        /// <param name="TopicId">TopicId.</param>
        /// <param name="MicrophoneRequired">MicrophoneRequired.</param>
        /// <param name="Intensity">Intensity.</param>
        /// <param name="Tone">Tone.</param>
        /// <param name="Approved">Approved.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="PlayerSlotsTotal">PlayerSlotsTotal.</param>
        /// <param name="PlayerSlotsRemaining">PlayerSlotsRemaining.</param>
        /// <param name="Fireteam">Fireteam.</param>
        /// <param name="KickedPlayerIds">KickedPlayerIds.</param>
        public ForumForumRecruitmentDetail(long? TopicId = default(long?), bool? MicrophoneRequired = default(bool?), ForumForumRecruitmentIntensityLabel Intensity = default(ForumForumRecruitmentIntensityLabel), ForumForumRecruitmentToneLabel Tone = default(ForumForumRecruitmentToneLabel), bool? Approved = default(bool?), long? ConversationId = default(long?), int? PlayerSlotsTotal = default(int?), int? PlayerSlotsRemaining = default(int?), List<UserGeneralUser> Fireteam = default(List<UserGeneralUser>), List<long?> KickedPlayerIds = default(List<long?>))
        {
            this.TopicId = TopicId;
            this.MicrophoneRequired = MicrophoneRequired;
            this.Intensity = Intensity;
            this.Tone = Tone;
            this.Approved = Approved;
            this.ConversationId = ConversationId;
            this.PlayerSlotsTotal = PlayerSlotsTotal;
            this.PlayerSlotsRemaining = PlayerSlotsRemaining;
            this.Fireteam = Fireteam;
            this.KickedPlayerIds = KickedPlayerIds;
        }
        
        /// <summary>
        /// Gets or Sets TopicId
        /// </summary>
        [DataMember(Name="topicId", EmitDefaultValue=false)]
        public long? TopicId { get; set; }

        /// <summary>
        /// Gets or Sets MicrophoneRequired
        /// </summary>
        [DataMember(Name="microphoneRequired", EmitDefaultValue=false)]
        public bool? MicrophoneRequired { get; set; }

        /// <summary>
        /// Gets or Sets Intensity
        /// </summary>
        [DataMember(Name="intensity", EmitDefaultValue=false)]
        public ForumForumRecruitmentIntensityLabel Intensity { get; set; }

        /// <summary>
        /// Gets or Sets Tone
        /// </summary>
        [DataMember(Name="tone", EmitDefaultValue=false)]
        public ForumForumRecruitmentToneLabel Tone { get; set; }

        /// <summary>
        /// Gets or Sets Approved
        /// </summary>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public bool? Approved { get; set; }

        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public long? ConversationId { get; set; }

        /// <summary>
        /// Gets or Sets PlayerSlotsTotal
        /// </summary>
        [DataMember(Name="playerSlotsTotal", EmitDefaultValue=false)]
        public int? PlayerSlotsTotal { get; set; }

        /// <summary>
        /// Gets or Sets PlayerSlotsRemaining
        /// </summary>
        [DataMember(Name="playerSlotsRemaining", EmitDefaultValue=false)]
        public int? PlayerSlotsRemaining { get; set; }

        /// <summary>
        /// Gets or Sets Fireteam
        /// </summary>
        [DataMember(Name="Fireteam", EmitDefaultValue=false)]
        public List<UserGeneralUser> Fireteam { get; set; }

        /// <summary>
        /// Gets or Sets KickedPlayerIds
        /// </summary>
        [DataMember(Name="kickedPlayerIds", EmitDefaultValue=false)]
        public List<long?> KickedPlayerIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForumForumRecruitmentDetail {\n");
            sb.Append("  TopicId: ").Append(TopicId).Append("\n");
            sb.Append("  MicrophoneRequired: ").Append(MicrophoneRequired).Append("\n");
            sb.Append("  Intensity: ").Append(Intensity).Append("\n");
            sb.Append("  Tone: ").Append(Tone).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  PlayerSlotsTotal: ").Append(PlayerSlotsTotal).Append("\n");
            sb.Append("  PlayerSlotsRemaining: ").Append(PlayerSlotsRemaining).Append("\n");
            sb.Append("  Fireteam: ").Append(Fireteam).Append("\n");
            sb.Append("  KickedPlayerIds: ").Append(KickedPlayerIds).Append("\n");
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
            return this.Equals(input as ForumForumRecruitmentDetail);
        }

        /// <summary>
        /// Returns true if ForumForumRecruitmentDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ForumForumRecruitmentDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumForumRecruitmentDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopicId == input.TopicId ||
                    (this.TopicId != null &&
                    this.TopicId.Equals(input.TopicId))
                ) && 
                (
                    this.MicrophoneRequired == input.MicrophoneRequired ||
                    (this.MicrophoneRequired != null &&
                    this.MicrophoneRequired.Equals(input.MicrophoneRequired))
                ) && 
                (
                    this.Intensity == input.Intensity ||
                    (this.Intensity != null &&
                    this.Intensity.Equals(input.Intensity))
                ) && 
                (
                    this.Tone == input.Tone ||
                    (this.Tone != null &&
                    this.Tone.Equals(input.Tone))
                ) && 
                (
                    this.Approved == input.Approved ||
                    (this.Approved != null &&
                    this.Approved.Equals(input.Approved))
                ) && 
                (
                    this.ConversationId == input.ConversationId ||
                    (this.ConversationId != null &&
                    this.ConversationId.Equals(input.ConversationId))
                ) && 
                (
                    this.PlayerSlotsTotal == input.PlayerSlotsTotal ||
                    (this.PlayerSlotsTotal != null &&
                    this.PlayerSlotsTotal.Equals(input.PlayerSlotsTotal))
                ) && 
                (
                    this.PlayerSlotsRemaining == input.PlayerSlotsRemaining ||
                    (this.PlayerSlotsRemaining != null &&
                    this.PlayerSlotsRemaining.Equals(input.PlayerSlotsRemaining))
                ) && 
                (
                    this.Fireteam == input.Fireteam ||
                    this.Fireteam != null &&
                    this.Fireteam.SequenceEqual(input.Fireteam)
                ) && 
                (
                    this.KickedPlayerIds == input.KickedPlayerIds ||
                    this.KickedPlayerIds != null &&
                    this.KickedPlayerIds.SequenceEqual(input.KickedPlayerIds)
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
                if (this.TopicId != null)
                    hashCode = hashCode * 59 + this.TopicId.GetHashCode();
                if (this.MicrophoneRequired != null)
                    hashCode = hashCode * 59 + this.MicrophoneRequired.GetHashCode();
                if (this.Intensity != null)
                    hashCode = hashCode * 59 + this.Intensity.GetHashCode();
                if (this.Tone != null)
                    hashCode = hashCode * 59 + this.Tone.GetHashCode();
                if (this.Approved != null)
                    hashCode = hashCode * 59 + this.Approved.GetHashCode();
                if (this.ConversationId != null)
                    hashCode = hashCode * 59 + this.ConversationId.GetHashCode();
                if (this.PlayerSlotsTotal != null)
                    hashCode = hashCode * 59 + this.PlayerSlotsTotal.GetHashCode();
                if (this.PlayerSlotsRemaining != null)
                    hashCode = hashCode * 59 + this.PlayerSlotsRemaining.GetHashCode();
                if (this.Fireteam != null)
                    hashCode = hashCode * 59 + this.Fireteam.GetHashCode();
                if (this.KickedPlayerIds != null)
                    hashCode = hashCode * 59 + this.KickedPlayerIds.GetHashCode();
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
