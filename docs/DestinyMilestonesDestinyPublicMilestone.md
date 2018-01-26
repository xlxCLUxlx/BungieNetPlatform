# BungieNetPlatform.Model.DestinyMilestonesDestinyPublicMilestone
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MilestoneHash** | **uint?** | The hash identifier for the milestone. Use it to look up the DestinyMilestoneDefinition for static data about the Milestone. | [optional] 
**AvailableQuests** | [**List&lt;DestinyMilestonesDestinyPublicMilestoneQuest&gt;**](DestinyMilestonesDestinyPublicMilestoneQuest.md) | A milestone not need have even a single quest, but if there are active quests they will be returned here. | [optional] 
**VendorHashes** | **List&lt;uint?&gt;** | Sometimes milestones - or activities active in milestones - will have relevant vendors. These are the vendors that are currently relevant.  Deprecated, already, for the sake of the new \&quot;vendors\&quot; property that has more data. What was I thinking. | [optional] 
**Vendors** | [**List&lt;DestinyMilestonesDestinyPublicMilestoneVendor&gt;**](DestinyMilestonesDestinyPublicMilestoneVendor.md) | This is why we can&#39;t have nice things. This is the ordered list of vendors to be shown that relate to this milestone, potentially along with other interesting data. | [optional] 
**StartDate** | **DateTime?** | If known, this is the date when the Milestone started/became active. | [optional] 
**EndDate** | **DateTime?** | If known, this is the date when the Milestone will expire/recycle/end. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

