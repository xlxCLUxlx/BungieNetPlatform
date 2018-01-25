# BungieNetPlatform.BungieNetPlatform.Model.TrendingTrendingEntry
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Weight** | **double?** | The weighted score of this trending item. | [optional] 
**IsFeatured** | **bool?** |  | [optional] 
**Identifier** | **string** | We don&#39;t know whether the identifier will be a string, a uint, or a long... so we&#39;re going to cast it all to a string. But either way, we need any trending item created to have a single unique identifier for its type. | [optional] 
**EntityType** | [**TrendingTrendingEntryType**](TrendingTrendingEntryType.md) | An enum - unfortunately - dictating all of the possible kinds of trending items that you might get in your result set, in case you want to do custom rendering or call to get the details of the item. | [optional] 
**DisplayName** | **string** | The localized \&quot;display name/article title/&#39;primary localized identifier&#39;\&quot; of the entity. | [optional] 
**Tagline** | **string** | If the entity has a localized tagline/subtitle/motto/whatever, that is found here. | [optional] 
**Image** | **string** |  | [optional] 
**StartDate** | **DateTime?** |  | [optional] 
**EndDate** | **DateTime?** |  | [optional] 
**Link** | **string** |  | [optional] 
**WebmVideo** | **string** | If this is populated, the entry has a related WebM video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo | [optional] 
**Mp4Video** | **string** | If this is populated, the entry has a related MP4 video to show. I am 100% certain I am going to regret putting this directly on TrendingEntry, but it will work so yolo | [optional] 
**FeatureImage** | **string** | If isFeatured, this image will be populated with whatever the featured image is. Note that this will likely be a very large image, so don&#39;t use it all the time. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

