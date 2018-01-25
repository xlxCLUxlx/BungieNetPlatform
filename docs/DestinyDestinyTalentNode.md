# BungieNetPlatform.BungieNetPlatform.Model.DestinyDestinyTalentNode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeIndex** | **int?** | The index of the Talent Node being referred to (an index into DestinyTalentGridDefinition.nodes[]). CONTENT VERSION DEPENDENT. | [optional] 
**NodeHash** | **uint?** | The hash of the Talent Node being referred to (in DestinyTalentGridDefinition.nodes). Deceptively CONTENT VERSION DEPENDENT. We have no guarantee of the hash&#39;s immutability between content versions. | [optional] 
**State** | [**DestinyDestinyTalentNodeState**](DestinyDestinyTalentNodeState.md) | An DestinyTalentNodeState enum value indicating the node&#39;s state: whether it can be activated or swapped, and why not if neither can be performed. | [optional] 
**IsActivated** | **bool?** | If true, the node is activated: it&#39;s current step then provides its benefits. | [optional] 
**StepIndex** | **int?** | The currently relevant Step for the node. It is this step that has rendering data for the node and the benefits that are provided if the node is activated. (the actual rules for benefits provided are extremely complicated in theory, but with how Talent Grids are being used in Destiny 2 you don&#39;t have to worry about a lot of those old Destiny 1 rules.) This is an index into: DestinyTalentGridDefinition.nodes[nodeIndex].steps[stepIndex] | [optional] 
**MaterialsToUpgrade** | [**List&lt;DestinyDefinitionsDestinyMaterialRequirement&gt;**](DestinyDefinitionsDestinyMaterialRequirement.md) | If the node has material requirements to be activated, this is the list of those requirements. | [optional] 
**ActivationGridLevel** | **int?** | The progression level required on the Talent Grid in order to be able to activate this talent node. Talent Grids have their own Progression - similar to Character Level, but in this case it is experience related to the item itself. | [optional] 
**ProgressPercent** | **float?** | If you want to show a progress bar or circle for how close this talent node is to being activate-able, this is the percentage to show. It follows the node&#39;s underlying rules about when the progress bar should first show up, and when it should be filled. | [optional] 
**Hidden** | **bool?** | Whether or not the talent node is actually visible in the game&#39;s UI. Whether you want to show it in your own UI is up to you! I&#39;m not gonna tell you who to sock it to. | [optional] 
**NodeStatsBlock** | [**DestinyDestinyTalentNodeStatBlock**](DestinyDestinyTalentNodeStatBlock.md) | This property has some history. A talent grid can provide stats on both the item it&#39;s related to and the character equipping the item. This returns data about those stat bonuses. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

