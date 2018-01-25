# BungieNetPlatform.BungieNetPlatform.Model.ContentContentItemPublicContract
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentId** | **long?** |  | [optional] 
**CType** | **string** |  | [optional] 
**CmsPath** | **string** |  | [optional] 
**CreationDate** | **DateTime?** |  | [optional] 
**ModifyDate** | **DateTime?** |  | [optional] 
**AllowComments** | **bool?** |  | [optional] 
**HasAgeGate** | **bool?** |  | [optional] 
**MinimumAge** | **int?** |  | [optional] 
**RatingImagePath** | **string** |  | [optional] 
**Author** | [**UserGeneralUser**](UserGeneralUser.md) |  | [optional] 
**AutoEnglishPropertyFallback** | **bool?** |  | [optional] 
**Properties** | **Dictionary&lt;string, Object&gt;** | Firehose content is really a collection of metadata and \&quot;properties\&quot;, which are the potentially-but-not-strictly localizable data that comprises the meat of whatever content is being shown.  As Cole Porter would have crooned, \&quot;Anything Goes\&quot; with Firehose properties. They are most often strings, but they can theoretically be anything. They are JSON encoded, and could be JSON structures, simple strings, numbers etc... The Content Type of the item (cType) will describe the properties, and thus how they ought to be deserialized. | [optional] 
**Representations** | [**List&lt;ContentContentRepresentation&gt;**](ContentContentRepresentation.md) |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**CommentSummary** | [**ContentCommentSummary**](ContentCommentSummary.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

