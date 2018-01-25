# BungieNetPlatform.BungieNetPlatform.Api.ForumApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ForumApproveFireteamThread**](ForumApi.md#forumapprovefireteamthread) | **POST** /Forum/Recruit/Approve/{topicId}/ | 
[**ForumGetCoreTopicsPaged**](ForumApi.md#forumgetcoretopicspaged) | **GET** /Forum/GetCoreTopicsPaged/{page}/{sort}/{quickDate}/{categoryFilter}/ | 
[**ForumGetForumTagSuggestions**](ForumApi.md#forumgetforumtagsuggestions) | **GET** /Forum/GetForumTagSuggestions/ | 
[**ForumGetPoll**](ForumApi.md#forumgetpoll) | **GET** /Forum/Poll/{topicId}/ | 
[**ForumGetPostAndParent**](ForumApi.md#forumgetpostandparent) | **GET** /Forum/GetPostAndParent/{childPostId}/ | 
[**ForumGetPostAndParentAwaitingApproval**](ForumApi.md#forumgetpostandparentawaitingapproval) | **GET** /Forum/GetPostAndParentAwaitingApproval/{childPostId}/ | 
[**ForumGetPostsThreadedPaged**](ForumApi.md#forumgetpoststhreadedpaged) | **GET** /Forum/GetPostsThreadedPaged/{parentPostId}/{page}/{pageSize}/{replySize}/{getParentPost}/{rootThreadMode}/{sortMode}/ | 
[**ForumGetPostsThreadedPagedFromChild**](ForumApi.md#forumgetpoststhreadedpagedfromchild) | **GET** /Forum/GetPostsThreadedPagedFromChild/{childPostId}/{page}/{pageSize}/{replySize}/{rootThreadMode}/{sortMode}/ | 
[**ForumGetRecruitmentThreadSummaries**](ForumApi.md#forumgetrecruitmentthreadsummaries) | **POST** /Forum/Recruit/Summaries/ | 
[**ForumGetTopicForContent**](ForumApi.md#forumgettopicforcontent) | **GET** /Forum/GetTopicForContent/{contentId}/ | 
[**ForumGetTopicsPaged**](ForumApi.md#forumgettopicspaged) | **GET** /Forum/GetTopicsPaged/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}/ | 
[**ForumJoinFireteamThread**](ForumApi.md#forumjoinfireteamthread) | **POST** /Forum/Recruit/Join/{topicId}/ | 
[**ForumKickBanFireteamApplicant**](ForumApi.md#forumkickbanfireteamapplicant) | **POST** /Forum/Recruit/KickBan/{topicId}/{targetMembershipId}/ | 
[**ForumLeaveFireteamThread**](ForumApi.md#forumleavefireteamthread) | **POST** /Forum/Recruit/Leave/{topicId}/ | 


<a name="forumapprovefireteamthread"></a>
# **ForumApproveFireteamThread**
> InlineResponse20010 ForumApproveFireteamThread (long? topicId)



Allows the owner of a fireteam thread to approve all joined members and start a private message conversation with them.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumApproveFireteamThreadExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ForumApi();
            var topicId = 789;  // long? | The post id of the recruitment topic to approve.

            try
            {
                InlineResponse20010 result = apiInstance.ForumApproveFireteamThread(topicId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumApproveFireteamThread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topicId** | **long?**| The post id of the recruitment topic to approve. | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumgetcoretopicspaged"></a>
# **ForumGetCoreTopicsPaged**
> InlineResponse2006 ForumGetCoreTopicsPaged (int? categoryFilter, int? page, int? quickDate, int? sort, string locales = null)



Gets a listing of all topics marked as part of the core group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumGetCoreTopicsPagedExample
    {
        public void main()
        {
            var apiInstance = new ForumApi();
            var categoryFilter = 56;  // int? | The category filter.
            var page = 56;  // int? | Zero base page
            var quickDate = 56;  // int? | The date filter.
            var sort = 56;  // int? | The sort mode.
            var locales = locales_example;  // string | Comma seperated list of locales posts must match to return in the result list. Default 'en' (optional) 

            try
            {
                InlineResponse2006 result = apiInstance.ForumGetCoreTopicsPaged(categoryFilter, page, quickDate, sort, locales);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetCoreTopicsPaged: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryFilter** | **int?**| The category filter. | 
 **page** | **int?**| Zero base page | 
 **quickDate** | **int?**| The date filter. | 
 **sort** | **int?**| The sort mode. | 
 **locales** | **string**| Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39; | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumgetforumtagsuggestions"></a>
# **ForumGetForumTagSuggestions**
> InlineResponse2008 ForumGetForumTagSuggestions (string partialtag = null)



Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumGetForumTagSuggestionsExample
    {
        public void main()
        {
            var apiInstance = new ForumApi();
            var partialtag = partialtag_example;  // string | The partial tag input to generate suggestions from. (optional) 

            try
            {
                InlineResponse2008 result = apiInstance.ForumGetForumTagSuggestions(partialtag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetForumTagSuggestions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **partialtag** | **string**| The partial tag input to generate suggestions from. | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumgetpoll"></a>
# **ForumGetPoll**
> InlineResponse2006 ForumGetPoll (long? topicId)



Gets the specified forum poll.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumGetPollExample
    {
        public void main()
        {
            var apiInstance = new ForumApi();
            var topicId = 789;  // long? | The post id of the topic that has the poll.

            try
            {
                InlineResponse2006 result = apiInstance.ForumGetPoll(topicId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPoll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topicId** | **long?**| The post id of the topic that has the poll. | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumgetpostandparent"></a>
# **ForumGetPostAndParent**
> InlineResponse2006 ForumGetPostAndParent (ulong? childPostId, string showbanned = null)



Returns the post specified and its immediate parent.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumGetPostAndParentExample
    {
        public void main()
        {
            var apiInstance = new ForumApi();
            var childPostId = 56;  // ulong? | 
            var showbanned = showbanned_example;  // string | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                InlineResponse2006 result = apiInstance.ForumGetPostAndParent(childPostId, showbanned);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostAndParent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childPostId** | **ulong?**|  | 
 **showbanned** | **string**| If this value is not null or empty, banned posts are requested to be returned | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumgetpostandparentawaitingapproval"></a>
# **ForumGetPostAndParentAwaitingApproval**
> InlineResponse2006 ForumGetPostAndParentAwaitingApproval (ulong? childPostId, string showbanned = null)



Returns the post specified and its immediate parent of posts that are awaiting approval.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumGetPostAndParentAwaitingApprovalExample
    {
        public void main()
        {
            var apiInstance = new ForumApi();
            var childPostId = 56;  // ulong? | 
            var showbanned = showbanned_example;  // string | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                InlineResponse2006 result = apiInstance.ForumGetPostAndParentAwaitingApproval(childPostId, showbanned);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostAndParentAwaitingApproval: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childPostId** | **ulong?**|  | 
 **showbanned** | **string**| If this value is not null or empty, banned posts are requested to be returned | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumgetpoststhreadedpaged"></a>
# **ForumGetPostsThreadedPaged**
> InlineResponse2006 ForumGetPostsThreadedPaged (bool? getParentPost, int? page, int? pageSize, ulong? parentPostId, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned = null)



Returns a thread of posts at the given parent, optionally returning replies to those posts as well as the original parent.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumGetPostsThreadedPagedExample
    {
        public void main()
        {
            var apiInstance = new ForumApi();
            var getParentPost = true;  // bool? | 
            var page = 56;  // int? | 
            var pageSize = 56;  // int? | 
            var parentPostId = 56;  // ulong? | 
            var replySize = 56;  // int? | 
            var rootThreadMode = true;  // bool? | 
            var sortMode = 56;  // int? | 
            var showbanned = showbanned_example;  // string | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                InlineResponse2006 result = apiInstance.ForumGetPostsThreadedPaged(getParentPost, page, pageSize, parentPostId, replySize, rootThreadMode, sortMode, showbanned);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostsThreadedPaged: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getParentPost** | **bool?**|  | 
 **page** | **int?**|  | 
 **pageSize** | **int?**|  | 
 **parentPostId** | **ulong?**|  | 
 **replySize** | **int?**|  | 
 **rootThreadMode** | **bool?**|  | 
 **sortMode** | **int?**|  | 
 **showbanned** | **string**| If this value is not null or empty, banned posts are requested to be returned | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumgetpoststhreadedpagedfromchild"></a>
# **ForumGetPostsThreadedPagedFromChild**
> InlineResponse2006 ForumGetPostsThreadedPagedFromChild (ulong? childPostId, int? page, int? pageSize, int? replySize, bool? rootThreadMode, int? sortMode, string showbanned = null)



Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumGetPostsThreadedPagedFromChildExample
    {
        public void main()
        {
            var apiInstance = new ForumApi();
            var childPostId = 56;  // ulong? | 
            var page = 56;  // int? | 
            var pageSize = 56;  // int? | 
            var replySize = 56;  // int? | 
            var rootThreadMode = true;  // bool? | 
            var sortMode = 56;  // int? | 
            var showbanned = showbanned_example;  // string | If this value is not null or empty, banned posts are requested to be returned (optional) 

            try
            {
                InlineResponse2006 result = apiInstance.ForumGetPostsThreadedPagedFromChild(childPostId, page, pageSize, replySize, rootThreadMode, sortMode, showbanned);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetPostsThreadedPagedFromChild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **childPostId** | **ulong?**|  | 
 **page** | **int?**|  | 
 **pageSize** | **int?**|  | 
 **replySize** | **int?**|  | 
 **rootThreadMode** | **bool?**|  | 
 **sortMode** | **int?**|  | 
 **showbanned** | **string**| If this value is not null or empty, banned posts are requested to be returned | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumgetrecruitmentthreadsummaries"></a>
# **ForumGetRecruitmentThreadSummaries**
> InlineResponse20011 ForumGetRecruitmentThreadSummaries ()



Allows the caller to get a list of to 25 recruitment thread summary information objects.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumGetRecruitmentThreadSummariesExample
    {
        public void main()
        {
            var apiInstance = new ForumApi();

            try
            {
                InlineResponse20011 result = apiInstance.ForumGetRecruitmentThreadSummaries();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetRecruitmentThreadSummaries: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumgettopicforcontent"></a>
# **ForumGetTopicForContent**
> InlineResponse2007 ForumGetTopicForContent (long? contentId)



Gets the post Id for the given content item's comments, if it exists.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumGetTopicForContentExample
    {
        public void main()
        {
            var apiInstance = new ForumApi();
            var contentId = 789;  // long? | 

            try
            {
                InlineResponse2007 result = apiInstance.ForumGetTopicForContent(contentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetTopicForContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentId** | **long?**|  | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumgettopicspaged"></a>
# **ForumGetTopicsPaged**
> InlineResponse2006 ForumGetTopicsPaged (int? categoryFilter, long? group, int? page, int? pageSize, int? quickDate, int? sort, string locales = null, string tagstring = null)



Get topics from any forum.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumGetTopicsPagedExample
    {
        public void main()
        {
            var apiInstance = new ForumApi();
            var categoryFilter = 56;  // int? | A category filter
            var group = 789;  // long? | The group, if any.
            var page = 56;  // int? | Zero paged page number
            var pageSize = 56;  // int? | Unused
            var quickDate = 56;  // int? | A date filter.
            var sort = 56;  // int? | The sort mode.
            var locales = locales_example;  // string | Comma seperated list of locales posts must match to return in the result list. Default 'en' (optional) 
            var tagstring = tagstring_example;  // string | The tags to search, if any. (optional) 

            try
            {
                InlineResponse2006 result = apiInstance.ForumGetTopicsPaged(categoryFilter, group, page, pageSize, quickDate, sort, locales, tagstring);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumGetTopicsPaged: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryFilter** | **int?**| A category filter | 
 **group** | **long?**| The group, if any. | 
 **page** | **int?**| Zero paged page number | 
 **pageSize** | **int?**| Unused | 
 **quickDate** | **int?**| A date filter. | 
 **sort** | **int?**| The sort mode. | 
 **locales** | **string**| Comma seperated list of locales posts must match to return in the result list. Default &#39;en&#39; | [optional] 
 **tagstring** | **string**| The tags to search, if any. | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumjoinfireteamthread"></a>
# **ForumJoinFireteamThread**
> InlineResponse2009 ForumJoinFireteamThread (long? topicId)



Allows a user to slot themselves into a recruitment thread fireteam slot. Returns the new state of the fireteam.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumJoinFireteamThreadExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ForumApi();
            var topicId = 789;  // long? | The post id of the recruitment topic you wish to join.

            try
            {
                InlineResponse2009 result = apiInstance.ForumJoinFireteamThread(topicId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumJoinFireteamThread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topicId** | **long?**| The post id of the recruitment topic you wish to join. | 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumkickbanfireteamapplicant"></a>
# **ForumKickBanFireteamApplicant**
> InlineResponse2009 ForumKickBanFireteamApplicant (long? targetMembershipId, long? topicId)



Allows a recruitment thread owner to kick a join user from the fireteam. Returns the new state of the fireteam.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumKickBanFireteamApplicantExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ForumApi();
            var targetMembershipId = 789;  // long? | The id of the user you wish to kick.
            var topicId = 789;  // long? | The post id of the recruitment topic you wish to join.

            try
            {
                InlineResponse2009 result = apiInstance.ForumKickBanFireteamApplicant(targetMembershipId, topicId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumKickBanFireteamApplicant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **targetMembershipId** | **long?**| The id of the user you wish to kick. | 
 **topicId** | **long?**| The post id of the recruitment topic you wish to join. | 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forumleavefireteamthread"></a>
# **ForumLeaveFireteamThread**
> InlineResponse2009 ForumLeaveFireteamThread (long? topicId)



Allows a user to remove themselves from a recruitment thread fireteam slot. Returns the new state of the fireteam.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class ForumLeaveFireteamThreadExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ForumApi();
            var topicId = 789;  // long? | The post id of the recruitment topic you wish to leave.

            try
            {
                InlineResponse2009 result = apiInstance.ForumLeaveFireteamThread(topicId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumApi.ForumLeaveFireteamThread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **topicId** | **long?**| The post id of the recruitment topic you wish to leave. | 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

