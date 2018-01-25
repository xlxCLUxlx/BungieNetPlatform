# BungieNetPlatform.BungieNetPlatform.Model.DestinyEntitiesItemsDestinyItemComponent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ItemHash** | **uint?** | The identifier for the item&#39;s definition, which is where most of the useful static information for the item can be found. | [optional] 
**ItemInstanceId** | **long?** | If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size. | [optional] 
**Quantity** | **int?** | The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it) | [optional] 
**BindStatus** | [**DestinyItemBindStatus**](DestinyItemBindStatus.md) | If the item is bound to a location, it will be specified in this enum. | [optional] 
**Location** | [**DestinyItemLocation**](DestinyItemLocation.md) | An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items. | [optional] 
**BucketHash** | **uint?** | The hash identifier for the specific inventory bucket in which the item is located. | [optional] 
**TransferStatus** | [**DestinyTransferStatuses**](DestinyTransferStatuses.md) | If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer). | [optional] 
**Lockable** | **bool?** | If the item can be locked, this will indicate that state. | [optional] 
**State** | [**DestinyItemState**](DestinyItemState.md) | A flags enumeration indicating the states of the item: whether it&#39;s tracked or locked for example. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

