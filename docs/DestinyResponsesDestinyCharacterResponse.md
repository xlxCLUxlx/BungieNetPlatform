# BungieNetPlatform.BungieNetPlatform.Model.DestinyResponsesDestinyCharacterResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Inventory** | [**SingleComponentResponseOfDestinyInventoryComponent**](SingleComponentResponseOfDestinyInventoryComponent.md) | The character-level non-equipped inventory items.  COMPONENT TYPE: CharacterInventories | [optional] 
**Character** | [**SingleComponentResponseOfDestinyCharacterComponent**](SingleComponentResponseOfDestinyCharacterComponent.md) | Base information about the character in question.  COMPONENT TYPE: Characters | [optional] 
**Progressions** | [**SingleComponentResponseOfDestinyCharacterProgressionComponent**](SingleComponentResponseOfDestinyCharacterProgressionComponent.md) | Character progression data, including Milestones.  COMPONENT TYPE: CharacterProgressions | [optional] 
**RenderData** | [**SingleComponentResponseOfDestinyCharacterRenderComponent**](SingleComponentResponseOfDestinyCharacterRenderComponent.md) | Character rendering data - a minimal set of information about equipment and dyes used for rendering.  COMPONENT TYPE: CharacterRenderData | [optional] 
**Activities** | [**SingleComponentResponseOfDestinyCharacterActivitiesComponent**](SingleComponentResponseOfDestinyCharacterActivitiesComponent.md) | Activity data - info about current activities available to the player.  COMPONENT TYPE: CharacterActivities | [optional] 
**Equipment** | [**SingleComponentResponseOfDestinyInventoryComponent**](SingleComponentResponseOfDestinyInventoryComponent.md) | Equipped items on the character.  COMPONENT TYPE: CharacterEquipment | [optional] 
**Kiosks** | [**SingleComponentResponseOfDestinyKiosksComponent**](SingleComponentResponseOfDestinyKiosksComponent.md) | Items available from Kiosks that are available to this specific character.   COMPONENT TYPE: Kiosks | [optional] 
**ItemComponents** | [**DestinyItemComponentSetOfint64**](DestinyItemComponentSetOfint64.md) | The set of components belonging to the player&#39;s instanced items.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.] | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

