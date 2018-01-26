# BungieNetPlatform.Model.DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CategoryHash** | **uint?** | Identifies the reward category. Only guaranteed unique within this specific component! | [optional] 
**CategoryIdentifier** | **string** | The string identifier for the category, if you want to use it for some end. Guaranteed unique within the specific component. | [optional] 
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) | Hopefully this is obvious by now. | [optional] 
**RewardEntries** | [**Dictionary&lt;string, DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition&gt;**](DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition.md) | If this milestone can provide rewards, this will define the sets of rewards that can be earned, the conditions under which they can be acquired, internal data that we&#39;ll use at runtime to determine whether you&#39;ve already earned or redeemed this set of rewards, and the category that this reward should be placed under. | [optional] 
**Order** | **int?** | If you want to use BNet&#39;s recommended order for rendering categories programmatically, use this value and compare it to other categories to determine the order in which they should be rendered. I don&#39;t feel great about putting this here, I won&#39;t lie. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

