# BungieNetPlatform.Model.DestinyQuestsDestinyObjectiveProgress
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectiveHash** | **uint?** | The unique identifier of the Objective being referred to. Use to look up the DestinyObjectiveDefinition in static data. | [optional] 
**DestinationHash** | **uint?** | If the Objective has a Destination associated with it, this is the unique identifier of the Destination being referred to. Use to look up the DestinyDestinationDefinition in static data. This will give localized data about *where* in the universe the objective should be achieved. | [optional] 
**ActivityHash** | **uint?** | If the Objective has an Activity associated with it, this is the unique identifier of the Activity being referred to. Use to look up the DestinyActivityDefinition in static data. This will give localized data about *what* you should be playing for the objective to be achieved. | [optional] 
**Progress** | **int?** | If progress has been made, and the progress can be measured numerically, this will be the value of that progress. You can compare it to the DestinyObjectiveDefinition.completionValue property for current vs. upper bounds, and use DestinyObjectiveDefinition.valueStyle to determine how this should be rendered. Note that progress, in Destiny 2, need not be a literal numeric progression. It could be one of a number of possible values, even a Timestamp. Always examine DestinyObjectiveDefinition.valueStyle before rendering progress. | [optional] 
**Complete** | **bool?** | Whether or not the Objective is completed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

