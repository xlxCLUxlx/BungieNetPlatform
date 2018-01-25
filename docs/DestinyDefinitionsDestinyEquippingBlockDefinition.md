# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsDestinyEquippingBlockDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GearsetItemHash** | **uint?** | If the item is part of a gearset, this is a reference to that gearset item. | [optional] 
**UniqueLabel** | **string** | If defined, this is the label used to check if the item has other items of matching types already equipped.   For instance, when you aren&#39;t allowed to equip more than one Exotic Weapon, that&#39;s because all exotic weapons have identical uniqueLabels and the game checks the to-be-equipped item&#39;s uniqueLabel vs. all other already equipped items (other than the item in the slot that&#39;s about to be occupied). | [optional] 
**UniqueLabelHash** | **uint?** | The hash of that unique label. Does not point to a specific definition. | [optional] 
**EquipmentSlotTypeHash** | **uint?** | An equipped item *must* be equipped in an Equipment Slot. This is the hash identifier of the DestinyEquipmentSlotDefinition into which it must be equipped. | [optional] 
**Attributes** | [**DestinyEquippingItemBlockAttributes**](DestinyEquippingItemBlockAttributes.md) | These are custom attributes on the equippability of the item.  For now, this can only be \&quot;equip on acquire\&quot;, which would mean that the item will be automatically equipped as soon as you pick it up. | [optional] 
**DisplayStrings** | **List&lt;string&gt;** | These are strings that represent the possible Game/Account/Character state failure conditions that can occur when trying to equip the item. They match up one-to-one with requiredUnlockExpressions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

