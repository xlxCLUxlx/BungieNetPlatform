# BungieNetPlatform.BungieNetPlatform.Model.DestinyDefinitionsDestinyInventoryBucketDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayProperties** | [**DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition**](DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition.md) |  | [optional] 
**Scope** | [**DestinyBucketScope**](DestinyBucketScope.md) | Where the bucket is found. 0 &#x3D; Character, 1 &#x3D; Account | [optional] 
**Category** | [**DestinyBucketCategory**](DestinyBucketCategory.md) | An enum value for what items can be found in the bucket. See the BucketCategory enum for more details. | [optional] 
**BucketOrder** | **int?** | Use this property to provide a quick-and-dirty recommended ordering for buckets in the UI. Most UIs will likely want to forsake this for something more custom and manual. | [optional] 
**ItemCount** | **int?** | The maximum # of item \&quot;slots\&quot; in a bucket. A slot is a given combination of item + quantity.  For instance, a Weapon will always take up a single slot, and always have a quantity of 1. But a material could take up only a single slot with hundreds of quantity. | [optional] 
**Location** | [**DestinyItemLocation**](DestinyItemLocation.md) | Sometimes, inventory buckets represent conceptual \&quot;locations\&quot; in the game that might not be expected. This value indicates the conceptual location of the bucket, regardless of where it is actually contained on the character/account.   See ItemLocation for details.   Note that location includes the Vault and the Postmaster (both of whom being just inventory buckets with additional actions that can be performed on them through a Vendor) | [optional] 
**HasTransferDestination** | **bool?** | If TRUE, there is at least one Vendor that can transfer items to/from this bucket. See the DestinyVendorDefinition&#39;s acceptedItems property for more information on how transferring works. | [optional] 
**Enabled** | **bool?** | If True, this bucket is enabled. Disabled buckets may include buckets that were included for test purposes, or that were going to be used but then were abandoned but never removed from content *cough*. | [optional] 
**Fifo** | **bool?** | if a FIFO bucket fills up, it will delete the oldest item from said bucket when a new item tries to be added to it. If this is FALSE, the bucket will not allow new items to be placed in it until room is made by the user manually deleting items from it. You can see an example of this with the Postmaster&#39;s bucket. | [optional] 
**Hash** | **uint?** | The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to. | [optional] 
**Index** | **int?** | The index of the entity as it was found in the investment tables. | [optional] 
**Redacted** | **bool?** | If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry! | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

