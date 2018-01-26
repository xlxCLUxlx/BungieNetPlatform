# BungieNetPlatform.Model.DestinyEntitiesItemsDestinyItemTalentGridComponent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TalentGridHash** | **uint?** | Most items don&#39;t have useful talent grids anymore, but Builds in particular still do.  You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item. | [optional] 
**Nodes** | [**List&lt;DestinyDestinyTalentNode&gt;**](DestinyDestinyTalentNode.md) | Detailed information about the individual nodes in the talent grid.  A node represents a single visual \&quot;pip\&quot; in the talent grid or Build detail view, though each node may have multiple \&quot;steps\&quot; which indicate the actual bonuses and visual representation of that node. | [optional] 
**IsGridComplete** | **bool?** | Indicates whether the talent grid on this item is completed, and thus whether it should have a gold border around it.  Only will be true if the item actually *has* a talent grid, and only then if it is completed (i.e. every exclusive set has an activated node, and every non-exclusive set node has been activated) | [optional] 
**GridProgression** | [**DestinyDestinyProgression**](DestinyDestinyProgression.md) | If the item has a progression, it will be detailed here. A progression means that the item can gain experience. Thresholds of experience are what determines whether and when a talent node can be activated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

