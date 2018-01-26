# BungieNetPlatform.Model.DestinyMilestonesDestinyMilestoneRewardEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RewardEntryHash** | **uint?** | The identifier for the reward entry in question. It is important to look up the related DestinyMilestoneRewardEntryDefinition to get the static details about the reward, which you can do by looking up the milestone&#39;s DestinyMilestoneDefinition and examining the DestinyMilestoneDefinition.rewards[rewardCategoryHash].rewardEntries[rewardEntryHash] data. | [optional] 
**Earned** | **bool?** | If TRUE, the player has earned this reward. | [optional] 
**Redeemed** | **bool?** | If TRUE, the player has redeemed/picked up/obtained this reward. Feel free to alias this to \&quot;gotTheShinyBauble\&quot; in your own codebase. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

