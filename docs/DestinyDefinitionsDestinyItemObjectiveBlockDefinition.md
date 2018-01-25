# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsDestinyItemObjectiveBlockDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectiveHashes** | **List&lt;uint?&gt;** | The hashes to Objectives (DestinyObjectiveDefinition) that are part of this Quest Step, in the order that they should be rendered. | [optional] 
**DisplayActivityHashes** | **List&lt;uint?&gt;** | For every entry in objectiveHashes, there is a corresponding entry in this array at the same index. If the objective is meant to be associated with a specific DestinyActivityDefinition, there will be a valid hash at that index. Otherwise, it will be invalid (0). | [optional] 
**RequireFullObjectiveCompletion** | **bool?** | If True, all objectives must be completed for the step to be completed. If False, any one objective can be completed for the step to be completed. | [optional] 
**QuestlineItemHash** | **uint?** | The hash for the DestinyInventoryItemDefinition representing the Quest to which this Quest Step belongs. | [optional] 
**Narrative** | **string** | The localized string for narrative text related to this quest step, if any. | [optional] 
**ObjectiveVerbName** | **string** | The localized string describing an action to be performed associated with the objectives, if any. | [optional] 
**QuestTypeIdentifier** | **string** | The identifier for the type of quest being performed, if any. Not associated with any fixed definition, yet. | [optional] 
**QuestTypeHash** | **uint?** | A hashed value for the questTypeIdentifier, because apparently I like to be redundant. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

