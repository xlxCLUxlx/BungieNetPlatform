# BungieNetPlatform.BungieNetPlatform.Model.DestinyMilestonesDestinyPublicMilestoneQuest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuestItemHash** | **uint?** | Quests are defined as Items in content. As such, this is the hash identifier of the DestinyInventoryItemDefinition that represents this quest. It will have pointers to all of the steps in the quest, and display information for the quest (title, description, icon etc) Individual steps will be referred to in the Quest item&#39;s DestinyInventoryItemDefinition.setData property, and themselves are Items with their own renderable data. | [optional] 
**Activity** | [**DestinyMilestonesDestinyPublicMilestoneActivity**](DestinyMilestonesDestinyPublicMilestoneActivity.md) | A milestone need not have an active activity, but if there is one it will be returned here, along with any variant and additional information. | [optional] 
**Challenges** | [**List&lt;DestinyMilestonesDestinyPublicMilestoneChallenge&gt;**](DestinyMilestonesDestinyPublicMilestoneChallenge.md) | For the given quest there could be 0-to-Many challenges: mini quests that you can perform in the course of doing this quest, that may grant you rewards and benefits. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

