# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsDestinyNodeActivationRequirement
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GridLevel** | **int?** | The Progression level on the Talent Grid required to activate this node.  See DestinyTalentGridDefinition.progressionHash for the related Progression, and read DestinyProgressionDefinition&#39;s documentation to learn more about Progressions. | [optional] 
**MaterialRequirementHashes** | **List&lt;uint?&gt;** | The list of hash identifiers for material requirement sets: materials that are required for the node to be activated. See DestinyMaterialRequirementSetDefinition for more information about material requirements.  In this case, only a single DestinyMaterialRequirementSetDefinition will be chosen from this list, and we won&#39;t know which one will be chosen until an instance of the item is created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

