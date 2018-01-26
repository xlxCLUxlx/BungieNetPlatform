# BungieNetPlatform.Model.DestinyDefinitionsDestinyTalentExclusiveGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupHash** | **uint?** | The identifier for this exclusive group. Only guaranteed unique within the talent grid, not globally. | [optional] 
**LoreHash** | **uint?** | If this group has an associated piece of lore to show next to it, this will be the identifier for that DestinyLoreDefinition. | [optional] 
**NodeHashes** | **List&lt;uint?&gt;** | A quick reference of the talent nodes that are part of this group, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash) | [optional] 
**OpposingGroupHashes** | **List&lt;uint?&gt;** | A quick reference of Groups whose nodes will be deactivated if any node in this group is activated. | [optional] 
**OpposingNodeHashes** | **List&lt;uint?&gt;** | A quick reference of Nodes that will be deactivated if any node in this group is activated, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

