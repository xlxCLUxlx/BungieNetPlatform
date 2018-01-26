# BungieNetPlatform.Api.CommunityContentApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CommunityContentGetCommunityContent**](CommunityContentApi.md#communitycontentgetcommunitycontent) | **GET** /CommunityContent/Get/{sort}/{mediaFilter}/{page}/ | 
[**CommunityContentGetCommunityLiveStatuses**](CommunityContentApi.md#communitycontentgetcommunitylivestatuses) | **GET** /CommunityContent/Live/All/{partnershipType}/{sort}/{page}/ | 
[**CommunityContentGetCommunityLiveStatusesForClanmates**](CommunityContentApi.md#communitycontentgetcommunitylivestatusesforclanmates) | **GET** /CommunityContent/Live/Clan/{partnershipType}/{sort}/{page}/ | 
[**CommunityContentGetCommunityLiveStatusesForFriends**](CommunityContentApi.md#communitycontentgetcommunitylivestatusesforfriends) | **GET** /CommunityContent/Live/Friends/{partnershipType}/{sort}/{page}/ | 
[**CommunityContentGetFeaturedCommunityLiveStatuses**](CommunityContentApi.md#communitycontentgetfeaturedcommunitylivestatuses) | **GET** /CommunityContent/Live/Featured/{partnershipType}/{sort}/{page}/ | 
[**CommunityContentGetStreamingStatusForMember**](CommunityContentApi.md#communitycontentgetstreamingstatusformember) | **GET** /CommunityContent/Live/Users/{partnershipType}/{membershipType}/{membershipId}/ | 


<a name="communitycontentgetcommunitycontent"></a>
# **CommunityContentGetCommunityContent**
> InlineResponse2006 CommunityContentGetCommunityContent (int? mediaFilter, int? page, int? sort)



Returns community content.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class CommunityContentGetCommunityContentExample
    {
        public void main()
        {
            var apiInstance = new CommunityContentApi();
            var mediaFilter = 56;  // int? | The type of media to get
            var page = 56;  // int? | Zero based page
            var sort = 56;  // int? | The sort mode.

            try
            {
                InlineResponse2006 result = apiInstance.CommunityContentGetCommunityContent(mediaFilter, page, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityContentApi.CommunityContentGetCommunityContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaFilter** | **int?**| The type of media to get | 
 **page** | **int?**| Zero based page | 
 **sort** | **int?**| The sort mode. | 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="communitycontentgetcommunitylivestatuses"></a>
# **CommunityContentGetCommunityLiveStatuses**
> InlineResponse20051 CommunityContentGetCommunityLiveStatuses (int? page, int? partnershipType, int? sort, uint? modeHash = null, string streamLocale = null)



Returns info about community members who are live streaming.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class CommunityContentGetCommunityLiveStatusesExample
    {
        public void main()
        {
            var apiInstance = new CommunityContentApi();
            var page = 56;  // int? | Zero based page.
            var partnershipType = 56;  // int? | The type of partnership for which the status should be returned.
            var sort = 56;  // int? | The sort mode.
            var modeHash = 56;  // uint? | The hash of the Activity Mode for which streams should be retrieved. Don't pass it in or pass 0 to not filter by mode. (optional) 
            var streamLocale = streamLocale_example;  // string | The locale for streams you'd like to see. Don't pass this to fall back on your BNet locale. Pass 'ALL' to not filter by locale. (optional) 

            try
            {
                InlineResponse20051 result = apiInstance.CommunityContentGetCommunityLiveStatuses(page, partnershipType, sort, modeHash, streamLocale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityContentApi.CommunityContentGetCommunityLiveStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Zero based page. | 
 **partnershipType** | **int?**| The type of partnership for which the status should be returned. | 
 **sort** | **int?**| The sort mode. | 
 **modeHash** | **uint?**| The hash of the Activity Mode for which streams should be retrieved. Don&#39;t pass it in or pass 0 to not filter by mode. | [optional] 
 **streamLocale** | **string**| The locale for streams you&#39;d like to see. Don&#39;t pass this to fall back on your BNet locale. Pass &#39;ALL&#39; to not filter by locale. | [optional] 

### Return type

[**InlineResponse20051**](InlineResponse20051.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="communitycontentgetcommunitylivestatusesforclanmates"></a>
# **CommunityContentGetCommunityLiveStatusesForClanmates**
> InlineResponse20051 CommunityContentGetCommunityLiveStatusesForClanmates (int? page, int? partnershipType, int? sort)



Returns info about community members who are live streaming in your clans.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class CommunityContentGetCommunityLiveStatusesForClanmatesExample
    {
        public void main()
        {
            var apiInstance = new CommunityContentApi();
            var page = 56;  // int? | Zero based page.
            var partnershipType = 56;  // int? | The type of partnership for which the status should be returned.
            var sort = 56;  // int? | The sort mode.

            try
            {
                InlineResponse20051 result = apiInstance.CommunityContentGetCommunityLiveStatusesForClanmates(page, partnershipType, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityContentApi.CommunityContentGetCommunityLiveStatusesForClanmates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Zero based page. | 
 **partnershipType** | **int?**| The type of partnership for which the status should be returned. | 
 **sort** | **int?**| The sort mode. | 

### Return type

[**InlineResponse20051**](InlineResponse20051.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="communitycontentgetcommunitylivestatusesforfriends"></a>
# **CommunityContentGetCommunityLiveStatusesForFriends**
> InlineResponse20051 CommunityContentGetCommunityLiveStatusesForFriends (int? page, int? partnershipType, int? sort)



Returns info about community members who are live streaming among your friends.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class CommunityContentGetCommunityLiveStatusesForFriendsExample
    {
        public void main()
        {
            var apiInstance = new CommunityContentApi();
            var page = 56;  // int? | Zero based page.
            var partnershipType = 56;  // int? | The type of partnership for which the status should be returned.
            var sort = 56;  // int? | The sort mode.

            try
            {
                InlineResponse20051 result = apiInstance.CommunityContentGetCommunityLiveStatusesForFriends(page, partnershipType, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityContentApi.CommunityContentGetCommunityLiveStatusesForFriends: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Zero based page. | 
 **partnershipType** | **int?**| The type of partnership for which the status should be returned. | 
 **sort** | **int?**| The sort mode. | 

### Return type

[**InlineResponse20051**](InlineResponse20051.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="communitycontentgetfeaturedcommunitylivestatuses"></a>
# **CommunityContentGetFeaturedCommunityLiveStatuses**
> InlineResponse20051 CommunityContentGetFeaturedCommunityLiveStatuses (int? page, int? partnershipType, int? sort, string streamLocale = null)



Returns info about Featured live streams.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class CommunityContentGetFeaturedCommunityLiveStatusesExample
    {
        public void main()
        {
            var apiInstance = new CommunityContentApi();
            var page = 56;  // int? | Zero based page.
            var partnershipType = 56;  // int? | The type of partnership for which the status should be returned.
            var sort = 56;  // int? | The sort mode.
            var streamLocale = streamLocale_example;  // string | The locale for streams you'd like to see. Don't pass this to fall back on your BNet locale. Pass 'ALL' to not filter by locale. (optional) 

            try
            {
                InlineResponse20051 result = apiInstance.CommunityContentGetFeaturedCommunityLiveStatuses(page, partnershipType, sort, streamLocale);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityContentApi.CommunityContentGetFeaturedCommunityLiveStatuses: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Zero based page. | 
 **partnershipType** | **int?**| The type of partnership for which the status should be returned. | 
 **sort** | **int?**| The sort mode. | 
 **streamLocale** | **string**| The locale for streams you&#39;d like to see. Don&#39;t pass this to fall back on your BNet locale. Pass &#39;ALL&#39; to not filter by locale. | [optional] 

### Return type

[**InlineResponse20051**](InlineResponse20051.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="communitycontentgetstreamingstatusformember"></a>
# **CommunityContentGetStreamingStatusForMember**
> InlineResponse20052 CommunityContentGetStreamingStatusForMember (long? membershipId, int? membershipType, int? partnershipType)



Gets the Live Streaming status of a particular Account and Membership Type.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class CommunityContentGetStreamingStatusForMemberExample
    {
        public void main()
        {
            var apiInstance = new CommunityContentApi();
            var membershipId = 789;  // long? | The membershipId related to that type.
            var membershipType = 56;  // int? | The type of account for which info will be extracted.
            var partnershipType = 56;  // int? | The type of partnership for which info will be extracted.

            try
            {
                InlineResponse20052 result = apiInstance.CommunityContentGetStreamingStatusForMember(membershipId, membershipType, partnershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommunityContentApi.CommunityContentGetStreamingStatusForMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **membershipId** | **long?**| The membershipId related to that type. | 
 **membershipType** | **int?**| The type of account for which info will be extracted. | 
 **partnershipType** | **int?**| The type of partnership for which info will be extracted. | 

### Return type

[**InlineResponse20052**](InlineResponse20052.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

