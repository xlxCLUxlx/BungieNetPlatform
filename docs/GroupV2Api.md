# BungieNetPlatform.Api.GroupV2Api

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GroupV2AbdicateFoundership**](GroupV2Api.md#groupv2abdicatefoundership) | **POST** /GroupV2/{groupId}/Admin/AbdicateFoundership/{membershipType}/{founderIdNew}/ | 
[**GroupV2AddOptionalConversation**](GroupV2Api.md#groupv2addoptionalconversation) | **POST** /GroupV2/{groupId}/OptionalConversations/Add/ | 
[**GroupV2ApproveAllPending**](GroupV2Api.md#groupv2approveallpending) | **POST** /GroupV2/{groupId}/Members/ApproveAll/ | 
[**GroupV2ApprovePending**](GroupV2Api.md#groupv2approvepending) | **POST** /GroupV2/{groupId}/Members/Approve/{membershipType}/{membershipId}/ | 
[**GroupV2ApprovePendingForList**](GroupV2Api.md#groupv2approvependingforlist) | **POST** /GroupV2/{groupId}/Members/ApproveList/ | 
[**GroupV2BanMember**](GroupV2Api.md#groupv2banmember) | **POST** /GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Ban/ | 
[**GroupV2CreateGroup**](GroupV2Api.md#groupv2creategroup) | **POST** /GroupV2/Create/ | 
[**GroupV2DenyAllPending**](GroupV2Api.md#groupv2denyallpending) | **POST** /GroupV2/{groupId}/Members/DenyAll/ | 
[**GroupV2DenyPendingForList**](GroupV2Api.md#groupv2denypendingforlist) | **POST** /GroupV2/{groupId}/Members/DenyList/ | 
[**GroupV2EditClanBanner**](GroupV2Api.md#groupv2editclanbanner) | **POST** /GroupV2/{groupId}/EditClanBanner/ | 
[**GroupV2EditFounderOptions**](GroupV2Api.md#groupv2editfounderoptions) | **POST** /GroupV2/{groupId}/EditFounderOptions/ | 
[**GroupV2EditGroup**](GroupV2Api.md#groupv2editgroup) | **POST** /GroupV2/{groupId}/Edit/ | 
[**GroupV2EditGroupMembership**](GroupV2Api.md#groupv2editgroupmembership) | **POST** /GroupV2/{groupId}/Members/{membershipType}/{membershipId}/SetMembershipType/{memberType}/ | 
[**GroupV2EditOptionalConversation**](GroupV2Api.md#groupv2editoptionalconversation) | **POST** /GroupV2/{groupId}/OptionalConversations/Edit/{conversationId}/ | 
[**GroupV2GetAdminsAndFounderOfGroup**](GroupV2Api.md#groupv2getadminsandfounderofgroup) | **GET** /GroupV2/{groupId}/AdminsAndFounder/ | 
[**GroupV2GetAvailableAvatars**](GroupV2Api.md#groupv2getavailableavatars) | **GET** /GroupV2/GetAvailableAvatars/ | 
[**GroupV2GetAvailableThemes**](GroupV2Api.md#groupv2getavailablethemes) | **GET** /GroupV2/GetAvailableThemes/ | 
[**GroupV2GetBannedMembersOfGroup**](GroupV2Api.md#groupv2getbannedmembersofgroup) | **GET** /GroupV2/{groupId}/Banned/ | 
[**GroupV2GetGroup**](GroupV2Api.md#groupv2getgroup) | **GET** /GroupV2/{groupId}/ | 
[**GroupV2GetGroupByName**](GroupV2Api.md#groupv2getgroupbyname) | **GET** /GroupV2/Name/{groupName}/{groupType}/ | 
[**GroupV2GetGroupOptionalConversations**](GroupV2Api.md#groupv2getgroupoptionalconversations) | **GET** /GroupV2/{groupId}/OptionalConversations/ | 
[**GroupV2GetGroupsForMember**](GroupV2Api.md#groupv2getgroupsformember) | **GET** /GroupV2/User/{membershipType}/{membershipId}/{filter}/{groupType}/ | 
[**GroupV2GetInvitedIndividuals**](GroupV2Api.md#groupv2getinvitedindividuals) | **GET** /GroupV2/{groupId}/Members/InvitedIndividuals/ | 
[**GroupV2GetMembersOfGroup**](GroupV2Api.md#groupv2getmembersofgroup) | **GET** /GroupV2/{groupId}/Members/ | 
[**GroupV2GetPendingMemberships**](GroupV2Api.md#groupv2getpendingmemberships) | **GET** /GroupV2/{groupId}/Members/Pending/ | 
[**GroupV2GetPotentialGroupsForMember**](GroupV2Api.md#groupv2getpotentialgroupsformember) | **GET** /GroupV2/User/Potential/{membershipType}/{membershipId}/{filter}/{groupType}/ | 
[**GroupV2GetRecommendedGroups**](GroupV2Api.md#groupv2getrecommendedgroups) | **POST** /GroupV2/Recommended/{groupType}/{createDateRange}/ | 
[**GroupV2GetUserClanInviteSetting**](GroupV2Api.md#groupv2getuserclaninvitesetting) | **GET** /GroupV2/GetUserClanInviteSetting/{mType}/ | 
[**GroupV2GroupSearch**](GroupV2Api.md#groupv2groupsearch) | **POST** /GroupV2/Search/ | 
[**GroupV2IndividualGroupInvite**](GroupV2Api.md#groupv2individualgroupinvite) | **POST** /GroupV2/{groupId}/Members/IndividualInvite/{membershipType}/{membershipId}/ | 
[**GroupV2IndividualGroupInviteCancel**](GroupV2Api.md#groupv2individualgroupinvitecancel) | **POST** /GroupV2/{groupId}/Members/IndividualInviteCancel/{membershipType}/{membershipId}/ | 
[**GroupV2KickMember**](GroupV2Api.md#groupv2kickmember) | **POST** /GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Kick/ | 
[**GroupV2RequestGroupMembership**](GroupV2Api.md#groupv2requestgroupmembership) | **POST** /GroupV2/{groupId}/Members/Apply/{membershipType}/ | 
[**GroupV2RescindGroupMembership**](GroupV2Api.md#groupv2rescindgroupmembership) | **POST** /GroupV2/{groupId}/Members/Rescind/{membershipType}/ | 
[**GroupV2SetUserClanInviteSetting**](GroupV2Api.md#groupv2setuserclaninvitesetting) | **POST** /GroupV2/SetUserClanInviteSetting/{mType}/{allowInvites}/ | 
[**GroupV2UnbanMember**](GroupV2Api.md#groupv2unbanmember) | **POST** /GroupV2/{groupId}/Members/{membershipType}/{membershipId}/Unban/ | 


<a name="groupv2abdicatefoundership"></a>
# **GroupV2AbdicateFoundership**
> InlineResponse20014 GroupV2AbdicateFoundership (long? founderIdNew, long? groupId, int? membershipType)



An administrative method to allow the founder of a group or clan to give up their position to another admin permanently.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2AbdicateFoundershipExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();
            var founderIdNew = 789;  // long? | The new founder for this group. Must already be a group admin.
            var groupId = 789;  // long? | The target group id.
            var membershipType = 56;  // int? | Membership type of the provided founderIdNew.

            try
            {
                InlineResponse20014 result = apiInstance.GroupV2AbdicateFoundership(founderIdNew, groupId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2AbdicateFoundership: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **founderIdNew** | **long?**| The new founder for this group. Must already be a group admin. | 
 **groupId** | **long?**| The target group id. | 
 **membershipType** | **int?**| Membership type of the provided founderIdNew. | 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2addoptionalconversation"></a>
# **GroupV2AddOptionalConversation**
> InlineResponse2007 GroupV2AddOptionalConversation (long? groupId)



Add a new optional conversation/chat channel. Requires admin permissions to the group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2AddOptionalConversationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | Group ID of the group to edit.

            try
            {
                InlineResponse2007 result = apiInstance.GroupV2AddOptionalConversation(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2AddOptionalConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Group ID of the group to edit. | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2approveallpending"></a>
# **GroupV2ApproveAllPending**
> InlineResponse20026 GroupV2ApproveAllPending (long? groupId)



Approve all of the pending users for the given group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2ApproveAllPendingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | ID of the group.

            try
            {
                InlineResponse20026 result = apiInstance.GroupV2ApproveAllPending(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2ApproveAllPending: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| ID of the group. | 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2approvepending"></a>
# **GroupV2ApprovePending**
> InlineResponse20014 GroupV2ApprovePending (long? groupId, long? membershipId, int? membershipType)



Approve the given membershipId to join the group/clan as long as they have applied.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2ApprovePendingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | ID of the group.
            var membershipId = 789;  // long? | The membership id being approved.
            var membershipType = 56;  // int? | Membership type of the supplied membership ID.

            try
            {
                InlineResponse20014 result = apiInstance.GroupV2ApprovePending(groupId, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2ApprovePending: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| ID of the group. | 
 **membershipId** | **long?**| The membership id being approved. | 
 **membershipType** | **int?**| Membership type of the supplied membership ID. | 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2approvependingforlist"></a>
# **GroupV2ApprovePendingForList**
> InlineResponse20026 GroupV2ApprovePendingForList (long? groupId)



Approve all of the pending users for the given group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2ApprovePendingForListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | ID of the group.

            try
            {
                InlineResponse20026 result = apiInstance.GroupV2ApprovePendingForList(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2ApprovePendingForList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| ID of the group. | 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2banmember"></a>
# **GroupV2BanMember**
> InlineResponse20015 GroupV2BanMember (long? groupId, long? membershipId, int? membershipType)



Bans the requested member from the requested group for the specified period of time.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2BanMemberExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | Group ID that has the member to ban.
            var membershipId = 789;  // long? | Membership ID of the member to ban from the group.
            var membershipType = 56;  // int? | Membership type of the provided membership ID.

            try
            {
                InlineResponse20015 result = apiInstance.GroupV2BanMember(groupId, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2BanMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Group ID that has the member to ban. | 
 **membershipId** | **long?**| Membership ID of the member to ban from the group. | 
 **membershipType** | **int?**| Membership type of the provided membership ID. | 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2creategroup"></a>
# **GroupV2CreateGroup**
> InlineResponse20020 GroupV2CreateGroup ()



Create a new group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2CreateGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();

            try
            {
                InlineResponse20020 result = apiInstance.GroupV2CreateGroup();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2CreateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20020**](InlineResponse20020.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2denyallpending"></a>
# **GroupV2DenyAllPending**
> InlineResponse20026 GroupV2DenyAllPending (long? groupId)



Deny all of the pending users for the given group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2DenyAllPendingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | ID of the group.

            try
            {
                InlineResponse20026 result = apiInstance.GroupV2DenyAllPending(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2DenyAllPending: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| ID of the group. | 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2denypendingforlist"></a>
# **GroupV2DenyPendingForList**
> InlineResponse20026 GroupV2DenyPendingForList (long? groupId)



Deny all of the pending users for the given group that match the passed-in .

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2DenyPendingForListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | ID of the group.

            try
            {
                InlineResponse20026 result = apiInstance.GroupV2DenyPendingForList(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2DenyPendingForList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| ID of the group. | 

### Return type

[**InlineResponse20026**](InlineResponse20026.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2editclanbanner"></a>
# **GroupV2EditClanBanner**
> InlineResponse20015 GroupV2EditClanBanner (long? groupId)



Edit an existing group's clan banner. You must have suitable permissions in the group to perform this operation. All fields are required.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2EditClanBannerExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | Group ID of the group to edit.

            try
            {
                InlineResponse20015 result = apiInstance.GroupV2EditClanBanner(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2EditClanBanner: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Group ID of the group to edit. | 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2editfounderoptions"></a>
# **GroupV2EditFounderOptions**
> InlineResponse20015 GroupV2EditFounderOptions (long? groupId)



Edit group options only available to a founder. You must have suitable permissions in the group to perform this operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2EditFounderOptionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | Group ID of the group to edit.

            try
            {
                InlineResponse20015 result = apiInstance.GroupV2EditFounderOptions(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2EditFounderOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Group ID of the group to edit. | 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2editgroup"></a>
# **GroupV2EditGroup**
> InlineResponse20015 GroupV2EditGroup (long? groupId)



Edit an existing group. You must have suitable permissions in the group to perform this operation. This latest revision will only edit the fields you pass in - pass null for properties you want to leave unaltered.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2EditGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | Group ID of the group to edit.

            try
            {
                InlineResponse20015 result = apiInstance.GroupV2EditGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2EditGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Group ID of the group to edit. | 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2editgroupmembership"></a>
# **GroupV2EditGroupMembership**
> InlineResponse20015 GroupV2EditGroupMembership (long? groupId, long? membershipId, int? membershipType, int? memberType)



Edit the membership type of a given member. You must have suitable permissions in the group to perform this operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2EditGroupMembershipExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | ID of the group to which the member belongs.
            var membershipId = 789;  // long? | Membership ID to modify.
            var membershipType = 56;  // int? | Membership type of the provide membership ID.
            var memberType = 56;  // int? | New membertype for the specified member.

            try
            {
                InlineResponse20015 result = apiInstance.GroupV2EditGroupMembership(groupId, membershipId, membershipType, memberType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2EditGroupMembership: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| ID of the group to which the member belongs. | 
 **membershipId** | **long?**| Membership ID to modify. | 
 **membershipType** | **int?**| Membership type of the provide membership ID. | 
 **memberType** | **int?**| New membertype for the specified member. | 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2editoptionalconversation"></a>
# **GroupV2EditOptionalConversation**
> InlineResponse2007 GroupV2EditOptionalConversation (long? conversationId, long? groupId)



Edit the settings of an optional conversation/chat channel. Requires admin permissions to the group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2EditOptionalConversationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var conversationId = 789;  // long? | Conversation Id of the channel being edited.
            var groupId = 789;  // long? | Group ID of the group to edit.

            try
            {
                InlineResponse2007 result = apiInstance.GroupV2EditOptionalConversation(conversationId, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2EditOptionalConversation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **conversationId** | **long?**| Conversation Id of the channel being edited. | 
 **groupId** | **long?**| Group ID of the group to edit. | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getadminsandfounderofgroup"></a>
# **GroupV2GetAdminsAndFounderOfGroup**
> InlineResponse20021 GroupV2GetAdminsAndFounderOfGroup (int? currentpage, long? groupId)



Get the list of members in a given group who are of admin level or higher.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetAdminsAndFounderOfGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();
            var currentpage = 56;  // int? | Page number (starting with 1). Each page has a fixed size of 50 items per page.
            var groupId = 789;  // long? | The ID of the group.

            try
            {
                InlineResponse20021 result = apiInstance.GroupV2GetAdminsAndFounderOfGroup(currentpage, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetAdminsAndFounderOfGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentpage** | **int?**| Page number (starting with 1). Each page has a fixed size of 50 items per page. | 
 **groupId** | **long?**| The ID of the group. | 

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getavailableavatars"></a>
# **GroupV2GetAvailableAvatars**
> InlineResponse20012 GroupV2GetAvailableAvatars ()



Returns a list of all available group avatars for the signed-in user.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetAvailableAvatarsExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();

            try
            {
                InlineResponse20012 result = apiInstance.GroupV2GetAvailableAvatars();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetAvailableAvatars: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getavailablethemes"></a>
# **GroupV2GetAvailableThemes**
> InlineResponse20013 GroupV2GetAvailableThemes ()



Returns a list of all available group themes.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetAvailableThemesExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();

            try
            {
                InlineResponse20013 result = apiInstance.GroupV2GetAvailableThemes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetAvailableThemes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getbannedmembersofgroup"></a>
# **GroupV2GetBannedMembersOfGroup**
> InlineResponse20023 GroupV2GetBannedMembersOfGroup (int? currentpage, long? groupId)



Get the list of banned members in a given group. Only accessible to group Admins and above. Not applicable to all groups. Check group features.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetBannedMembersOfGroupExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var currentpage = 56;  // int? | Page number (starting with 1). Each page has a fixed size of 50 entries.
            var groupId = 789;  // long? | Group ID whose banned members you are fetching

            try
            {
                InlineResponse20023 result = apiInstance.GroupV2GetBannedMembersOfGroup(currentpage, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetBannedMembersOfGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentpage** | **int?**| Page number (starting with 1). Each page has a fixed size of 50 entries. | 
 **groupId** | **long?**| Group ID whose banned members you are fetching | 

### Return type

[**InlineResponse20023**](InlineResponse20023.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getgroup"></a>
# **GroupV2GetGroup**
> InlineResponse20018 GroupV2GetGroup (long? groupId)



Get information about a specific group of the given ID.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | Requested group's id.

            try
            {
                InlineResponse20018 result = apiInstance.GroupV2GetGroup(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Requested group&#39;s id. | 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getgroupbyname"></a>
# **GroupV2GetGroupByName**
> InlineResponse20018 GroupV2GetGroupByName (string groupName, int? groupType)



Get information about a specific group with the given name and type.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetGroupByNameExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();
            var groupName = groupName_example;  // string | Exact name of the group to find.
            var groupType = 56;  // int? | Type of group to find.

            try
            {
                InlineResponse20018 result = apiInstance.GroupV2GetGroupByName(groupName, groupType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupName** | **string**| Exact name of the group to find. | 
 **groupType** | **int?**| Type of group to find. | 

### Return type

[**InlineResponse20018**](InlineResponse20018.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getgroupoptionalconversations"></a>
# **GroupV2GetGroupOptionalConversations**
> InlineResponse20019 GroupV2GetGroupOptionalConversations (long? groupId)



Gets a list of available optional conversation channels and their settings.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetGroupOptionalConversationsExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | Requested group's id.

            try
            {
                InlineResponse20019 result = apiInstance.GroupV2GetGroupOptionalConversations(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupOptionalConversations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Requested group&#39;s id. | 

### Return type

[**InlineResponse20019**](InlineResponse20019.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getgroupsformember"></a>
# **GroupV2GetGroupsForMember**
> InlineResponse20027 GroupV2GetGroupsForMember (int? filter, int? groupType, long? membershipId, int? membershipType)



Get information about the groups that a given member has joined.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetGroupsForMemberExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();
            var filter = 56;  // int? | Filter apply to list of joined groups.
            var groupType = 56;  // int? | Type of group the supplied member founded.
            var membershipId = 789;  // long? | Membership ID to for which to find founded groups.
            var membershipType = 56;  // int? | Membership type of the supplied membership ID.

            try
            {
                InlineResponse20027 result = apiInstance.GroupV2GetGroupsForMember(filter, groupType, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetGroupsForMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **int?**| Filter apply to list of joined groups. | 
 **groupType** | **int?**| Type of group the supplied member founded. | 
 **membershipId** | **long?**| Membership ID to for which to find founded groups. | 
 **membershipType** | **int?**| Membership type of the supplied membership ID. | 

### Return type

[**InlineResponse20027**](InlineResponse20027.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getinvitedindividuals"></a>
# **GroupV2GetInvitedIndividuals**
> InlineResponse20025 GroupV2GetInvitedIndividuals (int? currentpage, long? groupId)



Get the list of users who have been invited into the group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetInvitedIndividualsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var currentpage = 56;  // int? | Page number (starting with 1). Each page has a fixed size of 50 items per page.
            var groupId = 789;  // long? | ID of the group.

            try
            {
                InlineResponse20025 result = apiInstance.GroupV2GetInvitedIndividuals(currentpage, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetInvitedIndividuals: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentpage** | **int?**| Page number (starting with 1). Each page has a fixed size of 50 items per page. | 
 **groupId** | **long?**| ID of the group. | 

### Return type

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getmembersofgroup"></a>
# **GroupV2GetMembersOfGroup**
> InlineResponse20021 GroupV2GetMembersOfGroup (int? currentpage, long? groupId, int? memberType = null, string nameSearch = null)



Get the list of members in a given group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetMembersOfGroupExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();
            var currentpage = 56;  // int? | Page number (starting with 1). Each page has a fixed size of 50 items per page.
            var groupId = 789;  // long? | The ID of the group.
            var memberType = 56;  // int? | Filter out other member types. Use None for all members. (optional) 
            var nameSearch = nameSearch_example;  // string | The name fragment upon which a search should be executed for members with matching display or unique names. (optional) 

            try
            {
                InlineResponse20021 result = apiInstance.GroupV2GetMembersOfGroup(currentpage, groupId, memberType, nameSearch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetMembersOfGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentpage** | **int?**| Page number (starting with 1). Each page has a fixed size of 50 items per page. | 
 **groupId** | **long?**| The ID of the group. | 
 **memberType** | **int?**| Filter out other member types. Use None for all members. | [optional] 
 **nameSearch** | **string**| The name fragment upon which a search should be executed for members with matching display or unique names. | [optional] 

### Return type

[**InlineResponse20021**](InlineResponse20021.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getpendingmemberships"></a>
# **GroupV2GetPendingMemberships**
> InlineResponse20025 GroupV2GetPendingMemberships (int? currentpage, long? groupId)



Get the list of users who are awaiting a decision on their application to join a given group. Modified to include application info.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetPendingMembershipsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var currentpage = 56;  // int? | Page number (starting with 1). Each page has a fixed size of 50 items per page.
            var groupId = 789;  // long? | ID of the group.

            try
            {
                InlineResponse20025 result = apiInstance.GroupV2GetPendingMemberships(currentpage, groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetPendingMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentpage** | **int?**| Page number (starting with 1). Each page has a fixed size of 50 items per page. | 
 **groupId** | **long?**| ID of the group. | 

### Return type

[**InlineResponse20025**](InlineResponse20025.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getpotentialgroupsformember"></a>
# **GroupV2GetPotentialGroupsForMember**
> InlineResponse20028 GroupV2GetPotentialGroupsForMember (int? filter, int? groupType, long? membershipId, int? membershipType)



Get information about the groups that a given member has applied to or been invited to.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetPotentialGroupsForMemberExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();
            var filter = 56;  // int? | Filter apply to list of potential joined groups.
            var groupType = 56;  // int? | Type of group the supplied member applied.
            var membershipId = 789;  // long? | Membership ID to for which to find applied groups.
            var membershipType = 56;  // int? | Membership type of the supplied membership ID.

            try
            {
                InlineResponse20028 result = apiInstance.GroupV2GetPotentialGroupsForMember(filter, groupType, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetPotentialGroupsForMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **int?**| Filter apply to list of potential joined groups. | 
 **groupType** | **int?**| Type of group the supplied member applied. | 
 **membershipId** | **long?**| Membership ID to for which to find applied groups. | 
 **membershipType** | **int?**| Membership type of the supplied membership ID. | 

### Return type

[**InlineResponse20028**](InlineResponse20028.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getrecommendedgroups"></a>
# **GroupV2GetRecommendedGroups**
> InlineResponse20016 GroupV2GetRecommendedGroups (int? createDateRange, int? groupType)



Gets groups recommended for you based on the groups to whom those you follow belong.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetRecommendedGroupsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var createDateRange = 56;  // int? | The date range of activity of groups for which we should search. Is that proper grammar I don't know
            var groupType = 56;  // int? | The type of group to get.

            try
            {
                InlineResponse20016 result = apiInstance.GroupV2GetRecommendedGroups(createDateRange, groupType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetRecommendedGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createDateRange** | **int?**| The date range of activity of groups for which we should search. Is that proper grammar I don&#39;t know | 
 **groupType** | **int?**| The type of group to get. | 

### Return type

[**InlineResponse20016**](InlineResponse20016.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2getuserclaninvitesetting"></a>
# **GroupV2GetUserClanInviteSetting**
> InlineResponse20014 GroupV2GetUserClanInviteSetting (int? mType)



Gets the state of the user's clan invite preferences for a particular membership type - true if they wish to be invited to clans, false otherwise.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GetUserClanInviteSettingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var mType = 56;  // int? | The Destiny membership type of the account we wish to access settings.

            try
            {
                InlineResponse20014 result = apiInstance.GroupV2GetUserClanInviteSetting(mType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GetUserClanInviteSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mType** | **int?**| The Destiny membership type of the account we wish to access settings. | 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2groupsearch"></a>
# **GroupV2GroupSearch**
> InlineResponse20017 GroupV2GroupSearch ()



Search for Groups.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2GroupSearchExample
    {
        public void main()
        {
            var apiInstance = new GroupV2Api();

            try
            {
                InlineResponse20017 result = apiInstance.GroupV2GroupSearch();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2GroupSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2individualgroupinvite"></a>
# **GroupV2IndividualGroupInvite**
> InlineResponse20024 GroupV2IndividualGroupInvite (long? groupId, long? membershipId, int? membershipType)



Invite a user to join this group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2IndividualGroupInviteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | ID of the group you would like to join.
            var membershipId = 789;  // long? | Membership id of the account being invited.
            var membershipType = 56;  // int? | MembershipType of the account being invited.

            try
            {
                InlineResponse20024 result = apiInstance.GroupV2IndividualGroupInvite(groupId, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2IndividualGroupInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| ID of the group you would like to join. | 
 **membershipId** | **long?**| Membership id of the account being invited. | 
 **membershipType** | **int?**| MembershipType of the account being invited. | 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2individualgroupinvitecancel"></a>
# **GroupV2IndividualGroupInviteCancel**
> InlineResponse20024 GroupV2IndividualGroupInviteCancel (long? groupId, long? membershipId, int? membershipType)



Cancels a pending invitation to join a group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2IndividualGroupInviteCancelExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | ID of the group you would like to join.
            var membershipId = 789;  // long? | Membership id of the account being cancelled.
            var membershipType = 56;  // int? | MembershipType of the account being cancelled.

            try
            {
                InlineResponse20024 result = apiInstance.GroupV2IndividualGroupInviteCancel(groupId, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2IndividualGroupInviteCancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| ID of the group you would like to join. | 
 **membershipId** | **long?**| Membership id of the account being cancelled. | 
 **membershipType** | **int?**| MembershipType of the account being cancelled. | 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2kickmember"></a>
# **GroupV2KickMember**
> InlineResponse20022 GroupV2KickMember (long? groupId, long? membershipId, int? membershipType)



Kick a member from the given group, forcing them to reapply if they wish to re-join the group. You must have suitable permissions in the group to perform this operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2KickMemberExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | Group ID to kick the user from.
            var membershipId = 789;  // long? | Membership ID to kick.
            var membershipType = 56;  // int? | Membership type of the provided membership ID.

            try
            {
                InlineResponse20022 result = apiInstance.GroupV2KickMember(groupId, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2KickMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Group ID to kick the user from. | 
 **membershipId** | **long?**| Membership ID to kick. | 
 **membershipType** | **int?**| Membership type of the provided membership ID. | 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2requestgroupmembership"></a>
# **GroupV2RequestGroupMembership**
> InlineResponse20024 GroupV2RequestGroupMembership (long? groupId, int? membershipType)



Request permission to join the given group.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2RequestGroupMembershipExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | ID of the group you would like to join.
            var membershipType = 56;  // int? | MembershipType of the account to use when joining.

            try
            {
                InlineResponse20024 result = apiInstance.GroupV2RequestGroupMembership(groupId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2RequestGroupMembership: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| ID of the group you would like to join. | 
 **membershipType** | **int?**| MembershipType of the account to use when joining. | 

### Return type

[**InlineResponse20024**](InlineResponse20024.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2rescindgroupmembership"></a>
# **GroupV2RescindGroupMembership**
> InlineResponse20022 GroupV2RescindGroupMembership (long? groupId, int? membershipType)



Rescind your application to join the given group or leave the group if you are already a member..

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2RescindGroupMembershipExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | ID of the group.
            var membershipType = 56;  // int? | MembershipType of the account to leave.

            try
            {
                InlineResponse20022 result = apiInstance.GroupV2RescindGroupMembership(groupId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2RescindGroupMembership: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| ID of the group. | 
 **membershipType** | **int?**| MembershipType of the account to leave. | 

### Return type

[**InlineResponse20022**](InlineResponse20022.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2setuserclaninvitesetting"></a>
# **GroupV2SetUserClanInviteSetting**
> InlineResponse20015 GroupV2SetUserClanInviteSetting (bool? allowInvites, int? mType)



Sets the state of the user's clan invite preferences - true if they wish to be invited to clans, false otherwise.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2SetUserClanInviteSettingExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var allowInvites = true;  // bool? | True to allow invites of this user to clans, false otherwise.
            var mType = 56;  // int? | The Destiny membership type of linked account we are manipulating.

            try
            {
                InlineResponse20015 result = apiInstance.GroupV2SetUserClanInviteSetting(allowInvites, mType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2SetUserClanInviteSetting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allowInvites** | **bool?**| True to allow invites of this user to clans, false otherwise. | 
 **mType** | **int?**| The Destiny membership type of linked account we are manipulating. | 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="groupv2unbanmember"></a>
# **GroupV2UnbanMember**
> InlineResponse20015 GroupV2UnbanMember (long? groupId, long? membershipId, int? membershipType)



Unbans the requested member, allowing them to re-apply for membership.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class GroupV2UnbanMemberExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupV2Api();
            var groupId = 789;  // long? | 
            var membershipId = 789;  // long? | Membership ID of the member to unban from the group
            var membershipType = 56;  // int? | Membership type of the provided membership ID.

            try
            {
                InlineResponse20015 result = apiInstance.GroupV2UnbanMember(groupId, membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupV2Api.GroupV2UnbanMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**|  | 
 **membershipId** | **long?**| Membership ID of the member to unban from the group | 
 **membershipType** | **int?**| Membership type of the provided membership ID. | 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

