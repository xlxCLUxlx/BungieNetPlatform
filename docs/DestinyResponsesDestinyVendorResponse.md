# BungieNetPlatform.Model.DestinyResponsesDestinyVendorResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vendor** | [**SingleComponentResponseOfDestinyVendorComponent**](SingleComponentResponseOfDestinyVendorComponent.md) | The base properties of the vendor.  COMPONENT TYPE: Vendors | [optional] 
**Categories** | [**SingleComponentResponseOfDestinyVendorCategoriesComponent**](SingleComponentResponseOfDestinyVendorCategoriesComponent.md) | Categories that the vendor has available, and references to the sales therein.  COMPONENT TYPE: VendorCategories | [optional] 
**Sales** | [**DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent**](DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent.md) | Sales, keyed by the vendorItemIndex of the item being sold.  COMPONENT TYPE: VendorSales | [optional] 
**Items** | [**DestinyItemComponentSetOfint32**](DestinyItemComponentSetOfint32.md) | Item components, keyed by the vendorItemIndex of the active sale items.  COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.] | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

