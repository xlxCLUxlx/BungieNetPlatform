# BungieNetPlatform.Model.DestinyDefinitionsDestinyItemActionBlockDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VerbName** | **string** | Localized text for the verb of the action being performed. | [optional] 
**VerbDescription** | **string** | Localized text describing the action being performed. | [optional] 
**IsPositive** | **bool?** | The content has this property, however it&#39;s not entirely clear how it is used. | [optional] 
**OverlayScreenName** | **string** | If the action has an overlay screen associated with it, this is the name of that screen. Unfortunately, we cannot return the screen&#39;s data itself. | [optional] 
**OverlayIcon** | **string** | The icon associated with the overlay screen for the action, if any. | [optional] 
**RequiredCooldownSeconds** | **int?** | The number of seconds to delay before allowing this action to be performed again. | [optional] 
**RequiredItems** | [**List&lt;DestinyDefinitionsDestinyItemActionRequiredItemDefinition&gt;**](DestinyDefinitionsDestinyItemActionRequiredItemDefinition.md) | If the action requires other items to exist or be destroyed, this is the list of those items and requirements. | [optional] 
**ProgressionRewards** | [**List&lt;DestinyDefinitionsDestinyProgressionRewardDefinition&gt;**](DestinyDefinitionsDestinyProgressionRewardDefinition.md) | If performing this action earns you Progression, this is the list of progressions and values granted for those progressions by performing this action. | [optional] 
**ActionTypeLabel** | **string** | The internal identifier for the action. | [optional] 
**RequiredLocation** | **string** | Theoretically, an item could have a localized string for a hint about the location in which the action should be performed. In practice, no items yet have this property. | [optional] 
**RequiredCooldownHash** | **uint?** | The identifier hash for the Cooldown associated with this action. We have not pulled this data yet for you to have more data to use for cooldowns. | [optional] 
**DeleteOnAction** | **bool?** | If true, the item is deleted when the action completes. | [optional] 
**ConsumeEntireStack** | **bool?** | If true, the entire stack is deleted when the action completes. | [optional] 
**UseOnAcquire** | **bool?** | If true, this action will be performed as soon as you earn this item. Some rewards work this way, providing you a single item to pick up from a reward-granting vendor in-game and then immediately consuming itself to provide you multiple items. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

