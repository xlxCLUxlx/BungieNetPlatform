# BungieNetPlatform.BungieNetPlatform.Model.DestinyComponentsItemsDestinyItemPlugComponent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InsertFailIndexes** | **List&lt;int?&gt;** | If the plug cannot be inserted for some reason, this will have the indexes into the plug item definition&#39;s plug.insertionRules property, so you can show the reasons why it can&#39;t be inserted.  This list will be empty if the plug can be inserted. | [optional] 
**EnableFailIndexes** | **List&lt;int?&gt;** | If a plug is not enabled, this will be populated with indexes into the plug item definition&#39;s plug.enabledRules property, so that you can show the reasons why it is not enabled.  This list will be empty if the plug is enabled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

