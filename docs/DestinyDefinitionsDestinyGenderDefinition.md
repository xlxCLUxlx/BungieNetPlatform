# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsDestinyGenderDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GenderType** | [**DestinyDestinyGender**](DestinyDestinyGender.md) | This is a quick reference enumeration for all of the currently defined Genders. We use the enumeration for quicker lookups in related data, like DestinyClassDefinition.genderedClassNames. | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**Hash** | **uint?** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int?** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool?** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

