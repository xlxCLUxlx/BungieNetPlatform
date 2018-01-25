# BungieNetPlatform.BungieNetPlatform.Model.DestinyActivitiesDestinyPublicActivityStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChallengeObjectiveHashes** | **List&lt;uint?&gt;** | Active Challenges for the activity, if any - represented as hashes for DestinyObjectiveDefinitions. | [optional] 
**ModifierHashes** | **List&lt;uint?&gt;** | The active modifiers on this activity, if any - represented as hashes for DestinyActivityModifierDefinitions. | [optional] 
**RewardTooltipItems** | [**List&lt;DestinyDestinyItemQuantity&gt;**](DestinyDestinyItemQuantity.md) | If the activity itself provides any specific \&quot;mock\&quot; rewards, this will be the items and their quantity.  Why \&quot;mock\&quot;, you ask? Because these are the rewards as they are represented in the tooltip of the Activity.  These are often pointers to fake items that look good in a tooltip, but represent an abstract concept of what you will get for a reward rather than the specific items you may obtain. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

