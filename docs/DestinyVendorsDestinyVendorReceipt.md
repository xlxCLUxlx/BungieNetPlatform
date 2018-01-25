# BungieNetPlatform.BungieNetPlatform.Model.DestinyVendorsDestinyVendorReceipt
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrencyPaid** | [**List&lt;DestinyDestinyItemQuantity&gt;**](DestinyDestinyItemQuantity.md) | The amount paid for the item, in terms of items that were consumed in the purchase and their quantity. | [optional] 
**ItemReceived** | [**DestinyDestinyItemQuantity**](DestinyDestinyItemQuantity.md) | The item that was received, and its quantity. | [optional] 
**LicenseUnlockHash** | **uint?** | The unlock flag used to determine whether you still have the purchased item. | [optional] 
**PurchasedByCharacterId** | **long?** | The ID of the character who made the purchase. | [optional] 
**RefundPolicy** | [**DestinyDestinyVendorItemRefundPolicy**](DestinyDestinyVendorItemRefundPolicy.md) | Whether you can get a refund, and what happens in order for the refund to be received. See the DestinyVendorItemRefundPolicy enum for details. | [optional] 
**SequenceNumber** | **int?** | The identifier of this receipt. | [optional] 
**TimeToExpiration** | **long?** | The seconds since epoch at which this receipt is rendered invalid. | [optional] 
**ExpiresOn** | **DateTime?** | The date at which this receipt is rendered invalid. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

