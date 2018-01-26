# BungieNetPlatform.Api.UserApi

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserGetAvailableThemes**](UserApi.md#usergetavailablethemes) | **GET** /User/GetAvailableThemes/ | 
[**UserGetBungieNetUserById**](UserApi.md#usergetbungienetuserbyid) | **GET** /User/GetBungieNetUserById/{id}/ | 
[**UserGetMembershipDataById**](UserApi.md#usergetmembershipdatabyid) | **GET** /User/GetMembershipsById/{membershipId}/{membershipType}/ | 
[**UserGetMembershipDataForCurrentUser**](UserApi.md#usergetmembershipdataforcurrentuser) | **GET** /User/GetMembershipsForCurrentUser/ | 
[**UserGetPartnerships**](UserApi.md#usergetpartnerships) | **GET** /User/{membershipId}/Partnerships/ | 
[**UserGetUserAliases**](UserApi.md#usergetuseraliases) | **GET** /User/GetUserAliases/{id}/ | 
[**UserSearchUsers**](UserApi.md#usersearchusers) | **GET** /User/SearchUsers/ | 


<a name="usergetavailablethemes"></a>
# **UserGetAvailableThemes**
> InlineResponse2003 UserGetAvailableThemes ()



Returns a list of all available user themes.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class UserGetAvailableThemesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();

            try
            {
                InlineResponse2003 result = apiInstance.UserGetAvailableThemes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserGetAvailableThemes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergetbungienetuserbyid"></a>
# **UserGetBungieNetUserById**
> InlineResponse200 UserGetBungieNetUserById (long? id)



Loads a bungienet user by membership id.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class UserGetBungieNetUserByIdExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var id = 789;  // long? | The requested Bungie.net membership id.

            try
            {
                InlineResponse200 result = apiInstance.UserGetBungieNetUserById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserGetBungieNetUserById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The requested Bungie.net membership id. | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergetmembershipdatabyid"></a>
# **UserGetMembershipDataById**
> InlineResponse2004 UserGetMembershipDataById (long? membershipId, int? membershipType)



Returns a list of accounts associated with the supplied membership ID and membership type. This will include all linked accounts (even when hidden) if supplied credentials permit it.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class UserGetMembershipDataByIdExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var membershipId = 789;  // long? | The membership ID of the target user.
            var membershipType = 56;  // int? | Type of the supplied membership ID.

            try
            {
                InlineResponse2004 result = apiInstance.UserGetMembershipDataById(membershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserGetMembershipDataById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **membershipId** | **long?**| The membership ID of the target user. | 
 **membershipType** | **int?**| Type of the supplied membership ID. | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergetmembershipdataforcurrentuser"></a>
# **UserGetMembershipDataForCurrentUser**
> InlineResponse2004 UserGetMembershipDataForCurrentUser ()



Returns a list of accounts associated with signed in user. This is useful for OAuth implementations that do not give you access to the token response.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class UserGetMembershipDataForCurrentUserExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserApi();

            try
            {
                InlineResponse2004 result = apiInstance.UserGetMembershipDataForCurrentUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserGetMembershipDataForCurrentUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergetpartnerships"></a>
# **UserGetPartnerships**
> InlineResponse2005 UserGetPartnerships (long? membershipId)



Returns a user's linked Partnerships.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class UserGetPartnershipsExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var membershipId = 789;  // long? | The ID of the member for whom partnerships should be returned.

            try
            {
                InlineResponse2005 result = apiInstance.UserGetPartnerships(membershipId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserGetPartnerships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **membershipId** | **long?**| The ID of the member for whom partnerships should be returned. | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergetuseraliases"></a>
# **UserGetUserAliases**
> InlineResponse2001 UserGetUserAliases (long? id)



Loads aliases of a bungienet membership id.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class UserGetUserAliasesExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var id = 789;  // long? | The requested Bungie.net membership id.

            try
            {
                InlineResponse2001 result = apiInstance.UserGetUserAliases(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserGetUserAliases: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| The requested Bungie.net membership id. | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersearchusers"></a>
# **UserSearchUsers**
> InlineResponse2002 UserSearchUsers (string q = null)



Returns a list of possible users based on the search string

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.Model;

namespace Example
{
    public class UserSearchUsersExample
    {
        public void main()
        {
            var apiInstance = new UserApi();
            var q = q_example;  // string | The search string. (optional) 

            try
            {
                InlineResponse2002 result = apiInstance.UserSearchUsers(q);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UserSearchUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| The search string. | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

