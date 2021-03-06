# BungieNetPlatform.Model.DestinyResponsesDestinyProfileResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorReceipts** | [**SingleComponentResponseOfDestinyVendorReceiptsComponent**](SingleComponentResponseOfDestinyVendorReceiptsComponent.md) | Recent, refundable purchases you have made from vendors. When will you use it? Couldn&#39;t say...  COMPONENT TYPE: VendorReceipts | [optional] 
**ProfileInventory** | [**SingleComponentResponseOfDestinyInventoryComponent**](SingleComponentResponseOfDestinyInventoryComponent.md) | The profile-level inventory of the Destiny Profile.  COMPONENT TYPE: ProfileInventories | [optional] 
**ProfileCurrencies** | [**SingleComponentResponseOfDestinyInventoryComponent**](SingleComponentResponseOfDestinyInventoryComponent.md) | The profile-level currencies owned by the Destiny Profile.  COMPONENT TYPE: ProfileCurrencies | [optional] 
**Profile** | [**SingleComponentResponseOfDestinyProfileComponent**](SingleComponentResponseOfDestinyProfileComponent.md) | The basic information about the Destiny Profile (formerly \&quot;Account\&quot;).  COMPONENT TYPE: Profiles | [optional] 
**ProfileKiosks** | [**SingleComponentResponseOfDestinyKiosksComponent**](SingleComponentResponseOfDestinyKiosksComponent.md) | Items available from Kiosks that are available Profile-wide (i.e. across all characters)  This component returns information about what Kiosk items are available to you on a *Profile* level. It is theoretically possible for Kiosks to have items gated by specific Character as well. If you ever have those, you will find them on the characterKiosks property.  COMPONENT TYPE: Kiosks | [optional] 
**Characters** | [**DictionaryComponentResponseOfint64AndDestinyCharacterComponent**](DictionaryComponentResponseOfint64AndDestinyCharacterComponent.md) | Basic information about each character, keyed by the CharacterId.  COMPONENT TYPE: Characters | [optional] 
**CharacterInventories** | [**DictionaryComponentResponseOfint64AndDestinyInventoryComponent**](DictionaryComponentResponseOfint64AndDestinyInventoryComponent.md) | The character-level non-equipped inventory items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterInventories | [optional] 
**CharacterProgressions** | [**DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent**](DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent.md) | Character-level progression data, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterProgressions | [optional] 
**CharacterRenderData** | [**DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent**](DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent.md) | Character rendering data - a minimal set of info needed to render a character in 3D - keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterRenderData | [optional] 
**CharacterActivities** | [**DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent**](DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent.md) | Character activity data - the activities available to this character and its status, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterActivities | [optional] 
**CharacterEquipment** | [**DictionaryComponentResponseOfint64AndDestinyInventoryComponent**](DictionaryComponentResponseOfint64AndDestinyInventoryComponent.md) | The character&#39;s equipped items, keyed by the Character&#39;s Id.  COMPONENT TYPE: CharacterEquipment | [optional] 
**CharacterKiosks** | [**DictionaryComponentResponseOfint64AndDestinyKiosksComponent**](DictionaryComponentResponseOfint64AndDestinyKiosksComponent.md) | Items available from Kiosks that are available to a specific character as opposed to the account as a whole. It must be combined with data from the profileKiosks property to get a full picture of the character&#39;s available items to check out of a kiosk.  This component returns information about what Kiosk items are available to you on a *Character* level. Usually, kiosk items will be earned for the entire Profile (all characters) at once. To find those, look in the profileKiosks property.  COMPONENT TYPE: Kiosks | [optional] 
**ItemComponents** | [**DestinyItemComponentSetOfint64**](DestinyItemComponentSetOfint64.md) | Information about instanced items across all returned characters, keyed by the item&#39;s instance ID.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.] | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

