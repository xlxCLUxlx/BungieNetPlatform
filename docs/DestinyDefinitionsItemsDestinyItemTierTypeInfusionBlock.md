# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseQualityTransferRatio** | **float?** | The default portion of quality that will transfer from the infuser to the infusee item. (InfuserQuality - InfuseeQuality) * baseQualityTransferRatio &#x3D; base quality transferred. | [optional] 
**MinimumQualityIncrement** | **int?** | As long as InfuserQuality &gt; InfuseeQuality, the amount of quality bestowed is guaranteed to be at least this value, even if the transferRatio would dictate that it should be less. The total amount of quality that ends up in the Infusee cannot exceed the Infuser&#39;s quality however (for instance, if you infuse a 300 item with a 301 item and the minimum quality increment is 10, the infused item will not end up with 310 quality) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

