# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RewardEntryHash** | **uint?** | The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone. | [optional] 
**RewardEntryIdentifier** | **string** | The string identifier, if you care about it. Only guaranteed unique within the specific Milestone. | [optional] 
**Items** | [**List&lt;DestinyDestinyItemQuantity&gt;**](DestinyDestinyItemQuantity.md) | The items you will get as rewards, and how much of it you&#39;ll get. | [optional] 
**VendorHash** | **uint?** | If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition. | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) | For us to bother returning this info, we should be able to return some kind of information about why these rewards are grouped together. This is ideally that information. Look at how confident I am that this will always remain true. | [optional] 
**Order** | **int?** | If you want to follow BNet&#39;s ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

