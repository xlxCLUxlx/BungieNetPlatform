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
    /// The response for GetDestinyProfile, with components for character and item-level data.
    /// </summary>
    [DataContract]
    public partial class DestinyResponsesDestinyProfileResponse :  IEquatable<DestinyResponsesDestinyProfileResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyResponsesDestinyProfileResponse" /> class.
        /// </summary>
        /// <param name="VendorReceipts">Recent, refundable purchases you have made from vendors. When will you use it? Couldn&#39;t say...  COMPONENT TYPE: VendorReceipts.</param>
        /// <param name="ProfileInventory">The profile-level inventory of the Destiny Profile.  COMPONENT TYPE: ProfileInventories.</param>
        /// <param name="ProfileCurrencies">The profile-level currencies owned by the Destiny Profile.  COMPONENT TYPE: ProfileCurrencies.</param>
        /// <param name="Profile">The basic information about the Destiny Profile (formerly \&quot;Account\&quot;).  COMPONENT TYPE: Profiles.</param>
        /// <param name="ProfileKiosks">Items available from Kiosks that are available Profile-wide (i.e. across all characters)  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the characterKiosks property.  COMPONENT TYPE: Kiosks.</param>
        /// <param name="Characters">Basic information about each character, keyed by the CharacterId.  COMPONENT TYPE: Characters.</param>
        /// <param name="CharacterInventories">The character-level non-equipped inventory items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterInventories.</param>
        /// <param name="CharacterProgressions">Character-level progression data, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterProgressions.</param>
        /// <param name="CharacterRenderData">Character rendering data - a minimal set of info needed to render a character in 3D - keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterRenderData.</param>
        /// <param name="CharacterActivities">Character activity data - the activities available to this character and its status, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterActivities.</param>
        /// <param name="CharacterEquipment">The character&#39;s equipped items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterEquipment.</param>
        /// <param name="CharacterKiosks">Items available from Kiosks that are available to a specific character as opposed to the account as a whole. It must be combined with data from the profileKiosks property to get a full picture of the character&#39;s available items to check out of a kiosk.  This component returns information about what Kiosk items are available to you on a *Character* level. Usually, kiosk items will be earned for the entire Profile (all characters) at once. To find those, look in the profileKiosks property.  COMPONENT TYPE: Kiosks.</param>
        /// <param name="ItemComponents">Information about instanced items across all returned characters, keyed by the item&#39;s instance ID.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.].</param>
        public DestinyResponsesDestinyProfileResponse(SingleComponentResponseOfDestinyVendorReceiptsComponent VendorReceipts = default(SingleComponentResponseOfDestinyVendorReceiptsComponent), SingleComponentResponseOfDestinyInventoryComponent ProfileInventory = default(SingleComponentResponseOfDestinyInventoryComponent), SingleComponentResponseOfDestinyInventoryComponent ProfileCurrencies = default(SingleComponentResponseOfDestinyInventoryComponent), SingleComponentResponseOfDestinyProfileComponent Profile = default(SingleComponentResponseOfDestinyProfileComponent), SingleComponentResponseOfDestinyKiosksComponent ProfileKiosks = default(SingleComponentResponseOfDestinyKiosksComponent), DictionaryComponentResponseOfint64AndDestinyCharacterComponent Characters = default(DictionaryComponentResponseOfint64AndDestinyCharacterComponent), DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterInventories = default(DictionaryComponentResponseOfint64AndDestinyInventoryComponent), DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent CharacterProgressions = default(DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent), DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent CharacterRenderData = default(DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent), DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent CharacterActivities = default(DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent), DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterEquipment = default(DictionaryComponentResponseOfint64AndDestinyInventoryComponent), DictionaryComponentResponseOfint64AndDestinyKiosksComponent CharacterKiosks = default(DictionaryComponentResponseOfint64AndDestinyKiosksComponent), DestinyItemComponentSetOfint64 ItemComponents = default(DestinyItemComponentSetOfint64))
        {
            this.VendorReceipts = VendorReceipts;
            this.ProfileInventory = ProfileInventory;
            this.ProfileCurrencies = ProfileCurrencies;
            this.Profile = Profile;
            this.ProfileKiosks = ProfileKiosks;
            this.Characters = Characters;
            this.CharacterInventories = CharacterInventories;
            this.CharacterProgressions = CharacterProgressions;
            this.CharacterRenderData = CharacterRenderData;
            this.CharacterActivities = CharacterActivities;
            this.CharacterEquipment = CharacterEquipment;
            this.CharacterKiosks = CharacterKiosks;
            this.ItemComponents = ItemComponents;
        }
        
        /// <summary>
        /// Recent, refundable purchases you have made from vendors. When will you use it? Couldn&#39;t say...  COMPONENT TYPE: VendorReceipts
        /// </summary>
        /// <value>Recent, refundable purchases you have made from vendors. When will you use it? Couldn&#39;t say...  COMPONENT TYPE: VendorReceipts</value>
        [DataMember(Name="vendorReceipts", EmitDefaultValue=false)]
        public SingleComponentResponseOfDestinyVendorReceiptsComponent VendorReceipts { get; set; }

        /// <summary>
        /// The profile-level inventory of the Destiny Profile.  COMPONENT TYPE: ProfileInventories
        /// </summary>
        /// <value>The profile-level inventory of the Destiny Profile.  COMPONENT TYPE: ProfileInventories</value>
        [DataMember(Name="profileInventory", EmitDefaultValue=false)]
        public SingleComponentResponseOfDestinyInventoryComponent ProfileInventory { get; set; }

        /// <summary>
        /// The profile-level currencies owned by the Destiny Profile.  COMPONENT TYPE: ProfileCurrencies
        /// </summary>
        /// <value>The profile-level currencies owned by the Destiny Profile.  COMPONENT TYPE: ProfileCurrencies</value>
        [DataMember(Name="profileCurrencies", EmitDefaultValue=false)]
        public SingleComponentResponseOfDestinyInventoryComponent ProfileCurrencies { get; set; }

        /// <summary>
        /// The basic information about the Destiny Profile (formerly \&quot;Account\&quot;).  COMPONENT TYPE: Profiles
        /// </summary>
        /// <value>The basic information about the Destiny Profile (formerly \&quot;Account\&quot;).  COMPONENT TYPE: Profiles</value>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public SingleComponentResponseOfDestinyProfileComponent Profile { get; set; }

        /// <summary>
        /// Items available from Kiosks that are available Profile-wide (i.e. across all characters)  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the characterKiosks property.  COMPONENT TYPE: Kiosks
        /// </summary>
        /// <value>Items available from Kiosks that are available Profile-wide (i.e. across all characters)  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the characterKiosks property.  COMPONENT TYPE: Kiosks</value>
        [DataMember(Name="profileKiosks", EmitDefaultValue=false)]
        public SingleComponentResponseOfDestinyKiosksComponent ProfileKiosks { get; set; }

        /// <summary>
        /// Basic information about each character, keyed by the CharacterId.  COMPONENT TYPE: Characters
        /// </summary>
        /// <value>Basic information about each character, keyed by the CharacterId.  COMPONENT TYPE: Characters</value>
        [DataMember(Name="characters", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyCharacterComponent Characters { get; set; }

        /// <summary>
        /// The character-level non-equipped inventory items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterInventories
        /// </summary>
        /// <value>The character-level non-equipped inventory items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterInventories</value>
        [DataMember(Name="characterInventories", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterInventories { get; set; }

        /// <summary>
        /// Character-level progression data, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterProgressions
        /// </summary>
        /// <value>Character-level progression data, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterProgressions</value>
        [DataMember(Name="characterProgressions", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent CharacterProgressions { get; set; }

        /// <summary>
        /// Character rendering data - a minimal set of info needed to render a character in 3D - keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterRenderData
        /// </summary>
        /// <value>Character rendering data - a minimal set of info needed to render a character in 3D - keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterRenderData</value>
        [DataMember(Name="characterRenderData", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent CharacterRenderData { get; set; }

        /// <summary>
        /// Character activity data - the activities available to this character and its status, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterActivities
        /// </summary>
        /// <value>Character activity data - the activities available to this character and its status, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterActivities</value>
        [DataMember(Name="characterActivities", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent CharacterActivities { get; set; }

        /// <summary>
        /// The character&#39;s equipped items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterEquipment
        /// </summary>
        /// <value>The character&#39;s equipped items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterEquipment</value>
        [DataMember(Name="characterEquipment", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyInventoryComponent CharacterEquipment { get; set; }

        /// <summary>
        /// Items available from Kiosks that are available to a specific character as opposed to the account as a whole. It must be combined with data from the profileKiosks property to get a full picture of the character&#39;s available items to check out of a kiosk.  This component returns information about what Kiosk items are available to you on a *Character* level. Usually, kiosk items will be earned for the entire Profile (all characters) at once. To find those, look in the profileKiosks property.  COMPONENT TYPE: Kiosks
        /// </summary>
        /// <value>Items available from Kiosks that are available to a specific character as opposed to the account as a whole. It must be combined with data from the profileKiosks property to get a full picture of the character&#39;s available items to check out of a kiosk.  This component returns information about what Kiosk items are available to you on a *Character* level. Usually, kiosk items will be earned for the entire Profile (all characters) at once. To find those, look in the profileKiosks property.  COMPONENT TYPE: Kiosks</value>
        [DataMember(Name="characterKiosks", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyKiosksComponent CharacterKiosks { get; set; }

        /// <summary>
        /// Information about instanced items across all returned characters, keyed by the item&#39;s instance ID.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
        /// </summary>
        /// <value>Information about instanced items across all returned characters, keyed by the item&#39;s instance ID.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]</value>
        [DataMember(Name="itemComponents", EmitDefaultValue=false)]
        public DestinyItemComponentSetOfint64 ItemComponents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyResponsesDestinyProfileResponse {\n");
            sb.Append("  VendorReceipts: ").Append(VendorReceipts).Append("\n");
            sb.Append("  ProfileInventory: ").Append(ProfileInventory).Append("\n");
            sb.Append("  ProfileCurrencies: ").Append(ProfileCurrencies).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  ProfileKiosks: ").Append(ProfileKiosks).Append("\n");
            sb.Append("  Characters: ").Append(Characters).Append("\n");
            sb.Append("  CharacterInventories: ").Append(CharacterInventories).Append("\n");
            sb.Append("  CharacterProgressions: ").Append(CharacterProgressions).Append("\n");
            sb.Append("  CharacterRenderData: ").Append(CharacterRenderData).Append("\n");
            sb.Append("  CharacterActivities: ").Append(CharacterActivities).Append("\n");
            sb.Append("  CharacterEquipment: ").Append(CharacterEquipment).Append("\n");
            sb.Append("  CharacterKiosks: ").Append(CharacterKiosks).Append("\n");
            sb.Append("  ItemComponents: ").Append(ItemComponents).Append("\n");
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
            return this.Equals(input as DestinyResponsesDestinyProfileResponse);
        }

        /// <summary>
        /// Returns true if DestinyResponsesDestinyProfileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyResponsesDestinyProfileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyResponsesDestinyProfileResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VendorReceipts == input.VendorReceipts ||
                    (this.VendorReceipts != null &&
                    this.VendorReceipts.Equals(input.VendorReceipts))
                ) && 
                (
                    this.ProfileInventory == input.ProfileInventory ||
                    (this.ProfileInventory != null &&
                    this.ProfileInventory.Equals(input.ProfileInventory))
                ) && 
                (
                    this.ProfileCurrencies == input.ProfileCurrencies ||
                    (this.ProfileCurrencies != null &&
                    this.ProfileCurrencies.Equals(input.ProfileCurrencies))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.ProfileKiosks == input.ProfileKiosks ||
                    (this.ProfileKiosks != null &&
                    this.ProfileKiosks.Equals(input.ProfileKiosks))
                ) && 
                (
                    this.Characters == input.Characters ||
                    (this.Characters != null &&
                    this.Characters.Equals(input.Characters))
                ) && 
                (
                    this.CharacterInventories == input.CharacterInventories ||
                    (this.CharacterInventories != null &&
                    this.CharacterInventories.Equals(input.CharacterInventories))
                ) && 
                (
                    this.CharacterProgressions == input.CharacterProgressions ||
                    (this.CharacterProgressions != null &&
                    this.CharacterProgressions.Equals(input.CharacterProgressions))
                ) && 
                (
                    this.CharacterRenderData == input.CharacterRenderData ||
                    (this.CharacterRenderData != null &&
                    this.CharacterRenderData.Equals(input.CharacterRenderData))
                ) && 
                (
                    this.CharacterActivities == input.CharacterActivities ||
                    (this.CharacterActivities != null &&
                    this.CharacterActivities.Equals(input.CharacterActivities))
                ) && 
                (
                    this.CharacterEquipment == input.CharacterEquipment ||
                    (this.CharacterEquipment != null &&
                    this.CharacterEquipment.Equals(input.CharacterEquipment))
                ) && 
                (
                    this.CharacterKiosks == input.CharacterKiosks ||
                    (this.CharacterKiosks != null &&
                    this.CharacterKiosks.Equals(input.CharacterKiosks))
                ) && 
                (
                    this.ItemComponents == input.ItemComponents ||
                    (this.ItemComponents != null &&
                    this.ItemComponents.Equals(input.ItemComponents))
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
                if (this.VendorReceipts != null)
                    hashCode = hashCode * 59 + this.VendorReceipts.GetHashCode();
                if (this.ProfileInventory != null)
                    hashCode = hashCode * 59 + this.ProfileInventory.GetHashCode();
                if (this.ProfileCurrencies != null)
                    hashCode = hashCode * 59 + this.ProfileCurrencies.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.ProfileKiosks != null)
                    hashCode = hashCode * 59 + this.ProfileKiosks.GetHashCode();
                if (this.Characters != null)
                    hashCode = hashCode * 59 + this.Characters.GetHashCode();
                if (this.CharacterInventories != null)
                    hashCode = hashCode * 59 + this.CharacterInventories.GetHashCode();
                if (this.CharacterProgressions != null)
                    hashCode = hashCode * 59 + this.CharacterProgressions.GetHashCode();
                if (this.CharacterRenderData != null)
                    hashCode = hashCode * 59 + this.CharacterRenderData.GetHashCode();
                if (this.CharacterActivities != null)
                    hashCode = hashCode * 59 + this.CharacterActivities.GetHashCode();
                if (this.CharacterEquipment != null)
                    hashCode = hashCode * 59 + this.CharacterEquipment.GetHashCode();
                if (this.CharacterKiosks != null)
                    hashCode = hashCode * 59 + this.CharacterKiosks.GetHashCode();
                if (this.ItemComponents != null)
                    hashCode = hashCode * 59 + this.ItemComponents.GetHashCode();
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
