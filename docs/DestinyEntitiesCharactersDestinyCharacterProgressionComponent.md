# BungieNetPlatform.BungieNetPlatform.Model.DestinyEntitiesCharactersDestinyCharacterProgressionComponent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Progressions** | [**Dictionary&lt;string, DestinyDestinyProgression&gt;**](DestinyDestinyProgression.md) | A Dictionary of all known progressions for the Character, keyed by the Progression&#39;s hash.  Not all progressions have user-facing data, but those who do will have that data contained in the DestinyProgressionDefinition. | [optional] 
**Factions** | [**Dictionary&lt;string, DestinyProgressionDestinyFactionProgression&gt;**](DestinyProgressionDestinyFactionProgression.md) | A dictionary of all known Factions, keyed by the Faction&#39;s hash. It contains data about this character&#39;s status with the faction. | [optional] 
**Milestones** | [**Dictionary&lt;string, DestinyMilestonesDestinyMilestone&gt;**](DestinyMilestonesDestinyMilestone.md) | Milestones are related to the simple progressions shown in the game, but return additional and hopefully helpful information for users about the specifics of the Milestone&#39;s status. | [optional] 
**Quests** | [**List&lt;DestinyQuestsDestinyQuestStatus&gt;**](DestinyQuestsDestinyQuestStatus.md) | If the user has any active quests, the quests&#39; statuses will be returned here.  Note that quests have been largely supplanted by Milestones, but that doesn&#39;t mean that they won&#39;t make a comeback independent of milestones at some point. | [optional] 
**UninstancedItemObjectives** | **Dictionary&lt;string, List&lt;DestinyQuestsDestinyObjectiveProgress&gt;&gt;** | Sometimes, you have items in your inventory that don&#39;t have instances, but still have Objective information. This provides you that objective information for uninstanced items.   This dictionary is keyed by the item&#39;s hash: which you can use to look up the name and description for the overall task(s) implied by the objective. The value is the list of objectives for this item, and their statuses. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

