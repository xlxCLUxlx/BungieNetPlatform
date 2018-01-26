# BungieNetPlatform.Model.DestinyDefinitionsItemsDestinyDerivedItemDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemHash** | **uint?** | The hash for the DestinyInventoryItemDefinition of this derived item, if there is one. Sometimes we are given this information as a manual override, in which case there won&#39;t be an actual DestinyInventoryItemDefinition for what we display, but you can still show the strings from this object itself. | [optional] 
**ItemName** | **string** | The name of the derived item. | [optional] 
**ItemDetail** | **string** | Additional details about the derived item, in addition to the description. | [optional] 
**ItemDescription** | **string** | A brief description of the item. | [optional] 
**IconPath** | **string** | An icon for the item. | [optional] 
**VendorItemIndex** | **int?** | If the item was derived from a \&quot;Preview Vendor\&quot;, this will be an index into the DestinyVendorDefinition&#39;s itemList property. Otherwise, -1. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

