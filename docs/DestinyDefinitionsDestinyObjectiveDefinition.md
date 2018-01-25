# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsDestinyObjectiveDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) | Ideally, this should tell you what your task is. I&#39;m not going to lie to you though. Sometimes this doesn&#39;t have useful information at all. Which sucks, but there&#39;s nothing either of us can do about it. | [optional] 
**CompletionValue** | **int?** | The value that the unlock value defined in unlockValueHash must reach in order for the objective to be considered Completed. Used in calculating progress and completion status. | [optional] 
**LocationHash** | **uint?** | OPTIONAL: a hash identifier for the location at which this objective must be accomplished, if there is a location defined. Look up the DestinyLocationDefinition for this hash for that additional location info. | [optional] 
**AllowNegativeValue** | **bool?** | If true, the value is allowed to go negative. | [optional] 
**AllowValueChangeWhenCompleted** | **bool?** | If true, you can effectively \&quot;un-complete\&quot; this objective if you lose progress after crossing the completion threshold.   If False, once you complete the task it will remain completed forever by locking the value. | [optional] 
**IsCountingDownward** | **bool?** | If true, completion means having an unlock value less than or equal to the completionValue.  If False, completion means having an unlock value greater than or equal to the completionValue. | [optional] 
**ValueStyle** | [**DestinyDestinyUnlockValueUIStyle**](DestinyDestinyUnlockValueUIStyle.md) | The UI style applied to the objective. It&#39;s an enum, take a look at DestinyUnlockValueUIStyle for details of the possible styles. Use this info as you wish to customize your UI. | [optional] 
**ProgressDescription** | **string** | Text to describe the progress bar. | [optional] 
**Perks** | [**DestinyDefinitionsDestinyObjectivePerkEntryDefinition**](DestinyDefinitionsDestinyObjectivePerkEntryDefinition.md) | If this objective enables Perks intrinsically, the conditions for that enabling are defined here. | [optional] 
**Stats** | [**DestinyDefinitionsDestinyObjectiveStatEntryDefinition**](DestinyDefinitionsDestinyObjectiveStatEntryDefinition.md) | If this objective enables modifications on a player&#39;s stats intrinsically, the conditions are defined here. | [optional] 
**Hash** | **uint?** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int?** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool?** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

