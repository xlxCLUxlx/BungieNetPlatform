# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsDestinyEntitySearchResultItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hash** | **uint?** | The hash identifier of the entity. You will use this to look up the DestinyDefinition relevant for the entity found. | [optional] 
**EntityType** | **string** | The type of entity, returned as a string matching the DestinyDefinition&#39;s contract class name. You&#39;ll have to have your own mapping from class names to actually looking up those definitions in the manifest databases. | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) | Basic display properties on the entity, so you don&#39;t have to look up the definition to show basic results for the item. | [optional] 
**Weight** | **double?** | The ranking value for sorting that we calculated using our relevance formula. This will hopefully get better with time and iteration. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

