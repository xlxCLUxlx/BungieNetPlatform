# BungieNetPlatform.Model.DestinyDefinitionsDestinyFactionDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**ProgressionHash** | **uint?** | The hash identifier for the DestinyProgressionDefinition that indicates the character&#39;s relationship with this faction in terms of experience and levels. | [optional] 
**BackgroundImagePath** | **string** | The relative path to the background image, for use in a banner. | [optional] 
**TokenValues** | **Dictionary&lt;string, uint?&gt;** | The faction token item hashes, and their respective progression values. | [optional] 
**RewardItemHash** | **uint?** | The faction reward item hash, usually an engram. | [optional] 
**RewardVendorHash** | **uint?** | The faction reward vendor hash, used for faction engram previews. | [optional] 
**RewardVendorPreviewCategoryHashes** | **List&lt;uint?&gt;** | For the faction reward vendor, the category hashes to be shown as reward previews. | [optional] 
**Hash** | **uint?** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int?** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool?** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

