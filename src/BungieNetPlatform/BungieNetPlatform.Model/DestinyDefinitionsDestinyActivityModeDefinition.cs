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
    /// This definition represents an \&quot;Activity Mode\&quot; as it exists in the Historical Stats endpoints. An individual Activity Mode represents a collection of activities that are played in a certain way. For example, Nightfall Strikes are part of a \&quot;Nightfall\&quot; activity mode, and any activities played as the PVP mode \&quot;Clash\&quot; are part of the \&quot;Clash activity mode.  Activity modes are nested under each other in a hierarchy, so that if you ask for - for example - \&quot;AllPvP\&quot;, you will get any PVP activities that the user has played, regardless of what specific PVP mode was being played.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyActivityModeDefinition :  IEquatable<DestinyDefinitionsDestinyActivityModeDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyActivityModeDefinition" /> class.
        /// </summary>
        /// <param name="DisplayProperties">DisplayProperties.</param>
        /// <param name="PgcrImage">If this activity mode has a related PGCR image, this will be the path to said image..</param>
        /// <param name="ModeType">The Enumeration value for this Activity Mode. Pass this identifier into Stats endpoints to get aggregate stats for this mode..</param>
        /// <param name="ActivityModeCategory">The type of play being performed in broad terms (PVP, PVE).</param>
        /// <param name="IsTeamBased">If True, this mode has oppositional teams fighting against each other rather than \&quot;Free-For-All\&quot; or Co-operative modes of play.  Note that Aggregate modes are never marked as team based, even if they happen to be team based at the moment. At any time, an aggregate whose subordinates are only team based could be changed so that one or more aren&#39;t team based, and then this boolean won&#39;t make much sense (the aggregation would become \&quot;sometimes team based\&quot;). Let&#39;s not deal with that right now..</param>
        /// <param name="IsAggregateMode">If true, this mode is an aggregation of other, more specific modes rather than being a mode in itself. This includes modes that group Features/Events rather than Gameplay, such as Trials of The Nine: Trials of the Nine being an Event that is interesting to see aggregate data for, but when you play the activities within Trials of the Nine they are more specific activity modes such as Clash..</param>
        /// <param name="ParentHashes">The hash identifiers of the DestinyActivityModeDefinitions that represent all of the \&quot;parent\&quot; modes for this mode. For instance, the Nightfall Mode is also a member of AllStrikes and AllPvE..</param>
        /// <param name="FriendlyName">A Friendly identifier you can use for referring to this Activity Mode. We really only used this in our URLs, so... you know, take that for whatever it&#39;s worth..</param>
        /// <param name="ActivityModeMappings">If this exists, the mode has specific Activities (referred to by the Key) that should instead map to other Activity Modes when they are played. This was useful in D1 for Private Matches, where we wanted to have Private Matches as an activity mode while still referring to the specific mode being played..</param>
        /// <param name="Display">If FALSE, we want to ignore this type when we&#39;re showing activity modes in BNet UI. It will still be returned in case 3rd parties want to use it for any purpose..</param>
        /// <param name="Order">The relative ordering of activity modes..</param>
        /// <param name="Hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="Index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="Redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsDestinyActivityModeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), string PgcrImage = default(string), DestinyHistoricalStatsDefinitionsDestinyActivityModeType ModeType = default(DestinyHistoricalStatsDefinitionsDestinyActivityModeType), DestinyDestinyActivityModeCategory ActivityModeCategory = default(DestinyDestinyActivityModeCategory), bool? IsTeamBased = default(bool?), bool? IsAggregateMode = default(bool?), List<uint?> ParentHashes = default(List<uint?>), string FriendlyName = default(string), Dictionary<string, DestinyHistoricalStatsDefinitionsDestinyActivityModeType> ActivityModeMappings = default(Dictionary<string, DestinyHistoricalStatsDefinitionsDestinyActivityModeType>), bool? Display = default(bool?), int? Order = default(int?), uint? Hash = default(uint?), int? Index = default(int?), bool? Redacted = default(bool?))
        {
            this.DisplayProperties = DisplayProperties;
            this.PgcrImage = PgcrImage;
            this.ModeType = ModeType;
            this.ActivityModeCategory = ActivityModeCategory;
            this.IsTeamBased = IsTeamBased;
            this.IsAggregateMode = IsAggregateMode;
            this.ParentHashes = ParentHashes;
            this.FriendlyName = FriendlyName;
            this.ActivityModeMappings = ActivityModeMappings;
            this.Display = Display;
            this.Order = Order;
            this.Hash = Hash;
            this.Index = Index;
            this.Redacted = Redacted;
        }
        
        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name="displayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// If this activity mode has a related PGCR image, this will be the path to said image.
        /// </summary>
        /// <value>If this activity mode has a related PGCR image, this will be the path to said image.</value>
        [DataMember(Name="pgcrImage", EmitDefaultValue=false)]
        public string PgcrImage { get; set; }

        /// <summary>
        /// The Enumeration value for this Activity Mode. Pass this identifier into Stats endpoints to get aggregate stats for this mode.
        /// </summary>
        /// <value>The Enumeration value for this Activity Mode. Pass this identifier into Stats endpoints to get aggregate stats for this mode.</value>
        [DataMember(Name="modeType", EmitDefaultValue=false)]
        public DestinyHistoricalStatsDefinitionsDestinyActivityModeType ModeType { get; set; }

        /// <summary>
        /// The type of play being performed in broad terms (PVP, PVE)
        /// </summary>
        /// <value>The type of play being performed in broad terms (PVP, PVE)</value>
        [DataMember(Name="activityModeCategory", EmitDefaultValue=false)]
        public DestinyDestinyActivityModeCategory ActivityModeCategory { get; set; }

        /// <summary>
        /// If True, this mode has oppositional teams fighting against each other rather than \&quot;Free-For-All\&quot; or Co-operative modes of play.  Note that Aggregate modes are never marked as team based, even if they happen to be team based at the moment. At any time, an aggregate whose subordinates are only team based could be changed so that one or more aren&#39;t team based, and then this boolean won&#39;t make much sense (the aggregation would become \&quot;sometimes team based\&quot;). Let&#39;s not deal with that right now.
        /// </summary>
        /// <value>If True, this mode has oppositional teams fighting against each other rather than \&quot;Free-For-All\&quot; or Co-operative modes of play.  Note that Aggregate modes are never marked as team based, even if they happen to be team based at the moment. At any time, an aggregate whose subordinates are only team based could be changed so that one or more aren&#39;t team based, and then this boolean won&#39;t make much sense (the aggregation would become \&quot;sometimes team based\&quot;). Let&#39;s not deal with that right now.</value>
        [DataMember(Name="isTeamBased", EmitDefaultValue=false)]
        public bool? IsTeamBased { get; set; }

        /// <summary>
        /// If true, this mode is an aggregation of other, more specific modes rather than being a mode in itself. This includes modes that group Features/Events rather than Gameplay, such as Trials of The Nine: Trials of the Nine being an Event that is interesting to see aggregate data for, but when you play the activities within Trials of the Nine they are more specific activity modes such as Clash.
        /// </summary>
        /// <value>If true, this mode is an aggregation of other, more specific modes rather than being a mode in itself. This includes modes that group Features/Events rather than Gameplay, such as Trials of The Nine: Trials of the Nine being an Event that is interesting to see aggregate data for, but when you play the activities within Trials of the Nine they are more specific activity modes such as Clash.</value>
        [DataMember(Name="isAggregateMode", EmitDefaultValue=false)]
        public bool? IsAggregateMode { get; set; }

        /// <summary>
        /// The hash identifiers of the DestinyActivityModeDefinitions that represent all of the \&quot;parent\&quot; modes for this mode. For instance, the Nightfall Mode is also a member of AllStrikes and AllPvE.
        /// </summary>
        /// <value>The hash identifiers of the DestinyActivityModeDefinitions that represent all of the \&quot;parent\&quot; modes for this mode. For instance, the Nightfall Mode is also a member of AllStrikes and AllPvE.</value>
        [DataMember(Name="parentHashes", EmitDefaultValue=false)]
        public List<uint?> ParentHashes { get; set; }

        /// <summary>
        /// A Friendly identifier you can use for referring to this Activity Mode. We really only used this in our URLs, so... you know, take that for whatever it&#39;s worth.
        /// </summary>
        /// <value>A Friendly identifier you can use for referring to this Activity Mode. We really only used this in our URLs, so... you know, take that for whatever it&#39;s worth.</value>
        [DataMember(Name="friendlyName", EmitDefaultValue=false)]
        public string FriendlyName { get; set; }

        /// <summary>
        /// If this exists, the mode has specific Activities (referred to by the Key) that should instead map to other Activity Modes when they are played. This was useful in D1 for Private Matches, where we wanted to have Private Matches as an activity mode while still referring to the specific mode being played.
        /// </summary>
        /// <value>If this exists, the mode has specific Activities (referred to by the Key) that should instead map to other Activity Modes when they are played. This was useful in D1 for Private Matches, where we wanted to have Private Matches as an activity mode while still referring to the specific mode being played.</value>
        [DataMember(Name="activityModeMappings", EmitDefaultValue=false)]
        public Dictionary<string, DestinyHistoricalStatsDefinitionsDestinyActivityModeType> ActivityModeMappings { get; set; }

        /// <summary>
        /// If FALSE, we want to ignore this type when we&#39;re showing activity modes in BNet UI. It will still be returned in case 3rd parties want to use it for any purpose.
        /// </summary>
        /// <value>If FALSE, we want to ignore this type when we&#39;re showing activity modes in BNet UI. It will still be returned in case 3rd parties want to use it for any purpose.</value>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public bool? Display { get; set; }

        /// <summary>
        /// The relative ordering of activity modes.
        /// </summary>
        /// <value>The relative ordering of activity modes.</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public uint? Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        /// <value>The index of the entity as it was found in the investment tables.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
        [DataMember(Name="redacted", EmitDefaultValue=false)]
        public bool? Redacted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyActivityModeDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  PgcrImage: ").Append(PgcrImage).Append("\n");
            sb.Append("  ModeType: ").Append(ModeType).Append("\n");
            sb.Append("  ActivityModeCategory: ").Append(ActivityModeCategory).Append("\n");
            sb.Append("  IsTeamBased: ").Append(IsTeamBased).Append("\n");
            sb.Append("  IsAggregateMode: ").Append(IsAggregateMode).Append("\n");
            sb.Append("  ParentHashes: ").Append(ParentHashes).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  ActivityModeMappings: ").Append(ActivityModeMappings).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyActivityModeDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyActivityModeDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyActivityModeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyActivityModeDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.PgcrImage == input.PgcrImage ||
                    (this.PgcrImage != null &&
                    this.PgcrImage.Equals(input.PgcrImage))
                ) && 
                (
                    this.ModeType == input.ModeType ||
                    (this.ModeType != null &&
                    this.ModeType.Equals(input.ModeType))
                ) && 
                (
                    this.ActivityModeCategory == input.ActivityModeCategory ||
                    (this.ActivityModeCategory != null &&
                    this.ActivityModeCategory.Equals(input.ActivityModeCategory))
                ) && 
                (
                    this.IsTeamBased == input.IsTeamBased ||
                    (this.IsTeamBased != null &&
                    this.IsTeamBased.Equals(input.IsTeamBased))
                ) && 
                (
                    this.IsAggregateMode == input.IsAggregateMode ||
                    (this.IsAggregateMode != null &&
                    this.IsAggregateMode.Equals(input.IsAggregateMode))
                ) && 
                (
                    this.ParentHashes == input.ParentHashes ||
                    this.ParentHashes != null &&
                    this.ParentHashes.SequenceEqual(input.ParentHashes)
                ) && 
                (
                    this.FriendlyName == input.FriendlyName ||
                    (this.FriendlyName != null &&
                    this.FriendlyName.Equals(input.FriendlyName))
                ) && 
                (
                    this.ActivityModeMappings == input.ActivityModeMappings ||
                    this.ActivityModeMappings != null &&
                    this.ActivityModeMappings.SequenceEqual(input.ActivityModeMappings)
                ) && 
                (
                    this.Display == input.Display ||
                    (this.Display != null &&
                    this.Display.Equals(input.Display))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Redacted == input.Redacted ||
                    (this.Redacted != null &&
                    this.Redacted.Equals(input.Redacted))
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
                if (this.DisplayProperties != null)
                    hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
                if (this.PgcrImage != null)
                    hashCode = hashCode * 59 + this.PgcrImage.GetHashCode();
                if (this.ModeType != null)
                    hashCode = hashCode * 59 + this.ModeType.GetHashCode();
                if (this.ActivityModeCategory != null)
                    hashCode = hashCode * 59 + this.ActivityModeCategory.GetHashCode();
                if (this.IsTeamBased != null)
                    hashCode = hashCode * 59 + this.IsTeamBased.GetHashCode();
                if (this.IsAggregateMode != null)
                    hashCode = hashCode * 59 + this.IsAggregateMode.GetHashCode();
                if (this.ParentHashes != null)
                    hashCode = hashCode * 59 + this.ParentHashes.GetHashCode();
                if (this.FriendlyName != null)
                    hashCode = hashCode * 59 + this.FriendlyName.GetHashCode();
                if (this.ActivityModeMappings != null)
                    hashCode = hashCode * 59 + this.ActivityModeMappings.GetHashCode();
                if (this.Display != null)
                    hashCode = hashCode * 59 + this.Display.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Redacted != null)
                    hashCode = hashCode * 59 + this.Redacted.GetHashCode();
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
