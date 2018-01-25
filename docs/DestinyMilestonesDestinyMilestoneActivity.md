# BungieNetPlatform.BungieNetPlatform.Model.DestinyMilestonesDestinyMilestoneActivity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityHash** | **uint?** | The hash of an arbitrarily chosen variant of this activity. We&#39;ll go ahead and call that the \&quot;canonical\&quot; activity, because if you&#39;re using this value you should only use it for properties that are common across the variants: things like the name of the activity, it&#39;s location, etc... Use this hash to look up the DestinyActivityDefinition of this activity for rendering data. | [optional] 
**ModifierHashes** | **List&lt;uint?&gt;** | If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data. Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what&#39;s really live. | [optional] 
**Variants** | [**List&lt;DestinyMilestonesDestinyMilestoneActivityVariant&gt;**](DestinyMilestonesDestinyMilestoneActivityVariant.md) | If you want more than just name/location/etc... you&#39;re going to have to dig into and show the variants of the conceptual activity. These will differ in seemingly arbitrary ways, like difficulty level and modifiers applied. Show it in whatever way tickles your fancy. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

