# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsDestinyClassDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClassType** | [**DestinyDestinyClass**](DestinyDestinyClass.md) | In Destiny 1, we added a convenience Enumeration for referring to classes. We&#39;ve kept it, though mostly for posterity. This is the enum value for this definition&#39;s class. | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**GenderedClassNames** | **Dictionary&lt;string, string&gt;** | A localized string referring to the singular form of the Class&#39;s name when referred to in gendered form. Keyed by the DestinyGender. | [optional] 
**MentorVendorHash** | **uint?** | If the Class has a Mentor (all classes *should*), this will be the hash identifier for that Vendor if you care. | [optional] 
**Hash** | **uint?** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int?** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool?** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

