# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsItemsDestinyItemPlugDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InsertionRules** | [**List&lt;DestinyDefinitionsItemsDestinyPlugRuleDefinition&gt;**](DestinyDefinitionsItemsDestinyPlugRuleDefinition.md) | The rules around when this plug can be inserted into a socket, aside from the socket&#39;s individual restrictions.  The live data DestinyItemPlugComponent.insertFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user. | [optional] 
**PlugCategoryIdentifier** | **string** | The string identifier for the plug&#39;s category. Use the socket&#39;s DestinySocketTypeDefinition.plugWhitelist to determine whether this plug can be inserted into the socket. | [optional] 
**PlugCategoryHash** | **uint?** | The hash for the plugCategoryIdentifier. You can use this instead if you wish: I put both in the definition for debugging purposes. | [optional] 
**OnActionRecreateSelf** | **bool?** | If you successfully socket the item, this will determine whether or not you get \&quot;refunded\&quot; on the plug. | [optional] 
**InsertionMaterialRequirementHash** | **uint?** | If inserting this plug requires materials, this is the hash identifier for looking up the DestinyMaterialRequirementSetDefinition for those requirements. | [optional] 
**PreviewItemOverrideHash** | **uint?** | In the game, if you&#39;re inspecting a plug item directly, this will be the item shown with the plug attached. Look up the DestinyInventoryItemDefinition for this hash for the item. | [optional] 
**EnabledMaterialRequirementHash** | **uint?** | It&#39;s not enough for the plug to be inserted. It has to be enabled as well. For it to be enabled, it may require materials. This is the hash identifier for the DestinyMaterialRequirementSetDefinition for those requirements, if there is one. | [optional] 
**EnabledRules** | [**List&lt;DestinyDefinitionsItemsDestinyPlugRuleDefinition&gt;**](DestinyDefinitionsItemsDestinyPlugRuleDefinition.md) | The rules around whether the plug, once inserted, is enabled and providing its benefits.  The live data DestinyItemPlugComponent.enableFailIndexes will be an index into this array, so you can pull out the failure strings appropriate for the user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

