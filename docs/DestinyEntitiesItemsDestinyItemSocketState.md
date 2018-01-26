# BungieNetPlatform.Model.DestinyEntitiesItemsDestinyItemSocketState
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlugHash** | **uint?** | The currently active plug, if any.  Note that, because all plugs are statically defined, its effect on stats and perks can be statically determined using the plug item&#39;s definition. The stats and perks can be taken at face value on the plug item as the stats and perks it will provide to the user/item. | [optional] 
**IsEnabled** | **bool?** | Even if a plug is inserted, it doesn&#39;t mean it&#39;s enabled.  This flag indicates whether the plug is active and providing its benefits. | [optional] 
**EnableFailIndexes** | **List&lt;int?&gt;** | If a plug is inserted but not enabled, this will be populated with indexes into the plug item definition&#39;s plug.enabledRules property, so that you can show the reasons why it is not enabled. | [optional] 
**ReusablePlugHashes** | **List&lt;uint?&gt;** | If the item supports reusable plugs, this is the list of plug item hashes that are currently allowed to be used for this socket. (sometimes restrictions may cause reusable plugs defined on the item definition to not be valid, so you should trust the instanced reusablePlugHashes list rather than the definition&#39;s list)  A Reusable Plug is a plug that you can *always* insert into this socket, regardless of whether or not you have the plug in your inventory. In practice, a socket will *either* have reusable plugs *or* it will allow for plugs in your inventory to be inserted. See DestinyInventoryItemDefinition.socket for more info. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

