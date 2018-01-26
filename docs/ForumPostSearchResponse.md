# BungieNetPlatform.Model.ForumPostSearchResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RelatedPosts** | [**List&lt;ForumPostResponse&gt;**](ForumPostResponse.md) |  | [optional] 
**Authors** | [**List&lt;UserGeneralUser&gt;**](UserGeneralUser.md) |  | [optional] 
**Groups** | [**List&lt;GroupsV2GroupResponse&gt;**](GroupsV2GroupResponse.md) |  | [optional] 
**SearchedTags** | [**List&lt;TagsModelsContractsTagResponse&gt;**](TagsModelsContractsTagResponse.md) |  | [optional] 
**Polls** | [**List&lt;ForumPollResponse&gt;**](ForumPollResponse.md) |  | [optional] 
**RecruitmentDetails** | [**List&lt;ForumForumRecruitmentDetail&gt;**](ForumForumRecruitmentDetail.md) |  | [optional] 
**AvailablePages** | **int?** |  | [optional] 
**Results** | [**List&lt;ForumPostResponse&gt;**](ForumPostResponse.md) |  | [optional] 
**TotalResults** | **int?** |  | [optional] 
**HasMore** | **bool?** |  | [optional] 
**Query** | [**QueriesPagedQuery**](QueriesPagedQuery.md) |  | [optional] 
**ReplacementContinuationToken** | **string** |  | [optional] 
**UseTotalResults** | **bool?** | If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

