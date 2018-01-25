# BungieNetPlatform.BungieNetPlatform.Api.Destiny2Api

All URIs are relative to *https://www.bungie.net/Platform*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Destiny2ActivateTalentNode**](Destiny2Api.md#destiny2activatetalentnode) | **POST** /Destiny2/Actions/Items/ActivateTalentNode/ | 
[**Destiny2EquipItem**](Destiny2Api.md#destiny2equipitem) | **POST** /Destiny2/Actions/Items/EquipItem/ | 
[**Destiny2EquipItems**](Destiny2Api.md#destiny2equipitems) | **POST** /Destiny2/Actions/Items/EquipItems/ | 
[**Destiny2GetActivityHistory**](Destiny2Api.md#destiny2getactivityhistory) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/Activities/ | 
[**Destiny2GetCharacter**](Destiny2Api.md#destiny2getcharacter) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/ | 
[**Destiny2GetClanAggregateStats**](Destiny2Api.md#destiny2getclanaggregatestats) | **GET** /Destiny2/Stats/AggregateClanStats/{groupId}/ | 
[**Destiny2GetClanLeaderboards**](Destiny2Api.md#destiny2getclanleaderboards) | **GET** /Destiny2/Stats/Leaderboards/Clans/{groupId}/ | 
[**Destiny2GetClanWeeklyRewardState**](Destiny2Api.md#destiny2getclanweeklyrewardstate) | **GET** /Destiny2/Clan/{groupId}/WeeklyRewardState/ | 
[**Destiny2GetDestinyAggregateActivityStats**](Destiny2Api.md#destiny2getdestinyaggregateactivitystats) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/AggregateActivityStats/ | 
[**Destiny2GetDestinyEntityDefinition**](Destiny2Api.md#destiny2getdestinyentitydefinition) | **GET** /Destiny2/Manifest/{entityType}/{hashIdentifier}/ | 
[**Destiny2GetDestinyManifest**](Destiny2Api.md#destiny2getdestinymanifest) | **GET** /Destiny2/Manifest/ | 
[**Destiny2GetHistoricalStats**](Destiny2Api.md#destiny2gethistoricalstats) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/ | 
[**Destiny2GetHistoricalStatsDefinition**](Destiny2Api.md#destiny2gethistoricalstatsdefinition) | **GET** /Destiny2/Stats/Definition/ | 
[**Destiny2GetHistoricalStatsForAccount**](Destiny2Api.md#destiny2gethistoricalstatsforaccount) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/ | 
[**Destiny2GetItem**](Destiny2Api.md#destiny2getitem) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Item/{itemInstanceId}/ | 
[**Destiny2GetLeaderboards**](Destiny2Api.md#destiny2getleaderboards) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/Leaderboards/ | 
[**Destiny2GetLeaderboardsForCharacter**](Destiny2Api.md#destiny2getleaderboardsforcharacter) | **GET** /Destiny2/Stats/Leaderboards/{membershipType}/{destinyMembershipId}/{characterId}/ | 
[**Destiny2GetPostGameCarnageReport**](Destiny2Api.md#destiny2getpostgamecarnagereport) | **GET** /Destiny2/Stats/PostGameCarnageReport/{activityId}/ | 
[**Destiny2GetProfile**](Destiny2Api.md#destiny2getprofile) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/ | 
[**Destiny2GetPublicMilestoneContent**](Destiny2Api.md#destiny2getpublicmilestonecontent) | **GET** /Destiny2/Milestones/{milestoneHash}/Content/ | 
[**Destiny2GetPublicMilestones**](Destiny2Api.md#destiny2getpublicmilestones) | **GET** /Destiny2/Milestones/ | 
[**Destiny2GetUniqueWeaponHistory**](Destiny2Api.md#destiny2getuniqueweaponhistory) | **GET** /Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/UniqueWeapons/ | 
[**Destiny2GetVendor**](Destiny2Api.md#destiny2getvendor) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/{vendorHash}/ | 
[**Destiny2GetVendors**](Destiny2Api.md#destiny2getvendors) | **GET** /Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/ | 
[**Destiny2InsertSocketPlug**](Destiny2Api.md#destiny2insertsocketplug) | **POST** /Destiny2/Actions/Items/InsertSocketPlug/ | 
[**Destiny2SearchDestinyEntities**](Destiny2Api.md#destiny2searchdestinyentities) | **GET** /Destiny2/Armory/Search/{type}/{searchTerm}/ | 
[**Destiny2SearchDestinyPlayer**](Destiny2Api.md#destiny2searchdestinyplayer) | **GET** /Destiny2/SearchDestinyPlayer/{membershipType}/{displayName}/ | 
[**Destiny2SetItemLockState**](Destiny2Api.md#destiny2setitemlockstate) | **POST** /Destiny2/Actions/Items/SetLockState/ | 
[**Destiny2TransferItem**](Destiny2Api.md#destiny2transferitem) | **POST** /Destiny2/Actions/Items/TransferItem/ | 


<a name="destiny2activatetalentnode"></a>
# **Destiny2ActivateTalentNode**
> InlineResponse20015 Destiny2ActivateTalentNode ()



Activate a Talent Node. Chill out, everyone: we haven't decided yet whether this will be able to activate nodes with costs, but if we do it will require special scope permission for an application attempting to do so. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. PREVIEW: This service is not actually implemented yet, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2ActivateTalentNodeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20015 result = apiInstance.Destiny2ActivateTalentNode();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2ActivateTalentNode: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2equipitem"></a>
# **Destiny2EquipItem**
> InlineResponse20015 Destiny2EquipItem ()



Equip an item. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2EquipItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20015 result = apiInstance.Destiny2EquipItem();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2EquipItem: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2equipitems"></a>
# **Destiny2EquipItems**
> InlineResponse20038 Destiny2EquipItems ()



Equip a list of items by itemInstanceIds. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. Any items not found on your character will be ignored.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2EquipItemsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20038 result = apiInstance.Destiny2EquipItems();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2EquipItems: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20038**](InlineResponse20038.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getactivityhistory"></a>
# **Destiny2GetActivityHistory**
> InlineResponse20046 Destiny2GetActivityHistory (long? characterId, long? destinyMembershipId, int? membershipType, int? count = null, int? mode = null, int? page = null)



Gets activity history stats for indicated character. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetActivityHistoryExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The id of the character to retrieve.
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var count = 56;  // int? | Number of rows to return (optional) 
            var mode = 56;  // int? | A filter for the activity mode to be returned. None returns all activities. See the documentation for DestinyActivityModeType for valid values, and pass in string representation. (optional) 
            var page = 56;  // int? | Page number to return, starting with 0. (optional) 

            try
            {
                InlineResponse20046 result = apiInstance.Destiny2GetActivityHistory(characterId, destinyMembershipId, membershipType, count, mode, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetActivityHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The id of the character to retrieve. | 
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **count** | **int?**| Number of rows to return | [optional] 
 **mode** | **int?**| A filter for the activity mode to be returned. None returns all activities. See the documentation for DestinyActivityModeType for valid values, and pass in string representation. | [optional] 
 **page** | **int?**| Page number to return, starting with 0. | [optional] 

### Return type

[**InlineResponse20046**](InlineResponse20046.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getcharacter"></a>
# **Destiny2GetCharacter**
> InlineResponse20033 Destiny2GetCharacter (long? characterId, long? destinyMembershipId, int? membershipType, List<DestinyDestinyComponentType> components = null)



Returns character information for the supplied character.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetCharacterExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | ID of the character.
            var destinyMembershipId = 789;  // long? | Destiny membership ID.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var components = new List<DestinyDestinyComponentType>(); // List<DestinyDestinyComponentType> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20033 result = apiInstance.Destiny2GetCharacter(characterId, destinyMembershipId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetCharacter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| ID of the character. | 
 **destinyMembershipId** | **long?**| Destiny membership ID. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **components** | [**List&lt;DestinyDestinyComponentType&gt;**](DestinyDestinyComponentType.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20033**](InlineResponse20033.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getclanaggregatestats"></a>
# **Destiny2GetClanAggregateStats**
> InlineResponse20042 Destiny2GetClanAggregateStats (long? groupId, string modes = null)



Gets aggregated stats for a clan using the same categories as the clan leaderboards. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetClanAggregateStatsExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var groupId = 789;  // long? | Group ID of the clan whose leaderboards you wish to fetch.
            var modes = modes_example;  // string | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 

            try
            {
                InlineResponse20042 result = apiInstance.Destiny2GetClanAggregateStats(groupId, modes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanAggregateStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Group ID of the clan whose leaderboards you wish to fetch. | 
 **modes** | **string**| List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional] 

### Return type

[**InlineResponse20042**](InlineResponse20042.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getclanleaderboards"></a>
# **Destiny2GetClanLeaderboards**
> InlineResponse20041 Destiny2GetClanLeaderboards (long? groupId, int? maxtop = null, string modes = null, string statid = null)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetClanLeaderboardsExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var groupId = 789;  // long? | Group ID of the clan whose leaderboards you wish to fetch.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = modes_example;  // string | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = statid_example;  // string | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                InlineResponse20041 result = apiInstance.Destiny2GetClanLeaderboards(groupId, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanLeaderboards: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| Group ID of the clan whose leaderboards you wish to fetch. | 
 **maxtop** | **int?**| Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional] 
 **modes** | **string**| List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional] 
 **statid** | **string**| ID of stat to return rather than returning all Leaderboard stats. | [optional] 

### Return type

[**InlineResponse20041**](InlineResponse20041.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getclanweeklyrewardstate"></a>
# **Destiny2GetClanWeeklyRewardState**
> InlineResponse20034 Destiny2GetClanWeeklyRewardState (long? groupId)



Returns information on the weekly clan rewards and if the clan has earned them or not. Note that this will always report rewards as not redeemed.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetClanWeeklyRewardStateExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var groupId = 789;  // long? | A valid group id of clan.

            try
            {
                InlineResponse20034 result = apiInstance.Destiny2GetClanWeeklyRewardState(groupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetClanWeeklyRewardState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **long?**| A valid group id of clan. | 

### Return type

[**InlineResponse20034**](InlineResponse20034.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getdestinyaggregateactivitystats"></a>
# **Destiny2GetDestinyAggregateActivityStats**
> InlineResponse20048 Destiny2GetDestinyAggregateActivityStats (long? characterId, long? destinyMembershipId, int? membershipType)



Gets all activities the character has participated in together with aggregate statistics for those activities. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetDestinyAggregateActivityStatsExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The specific character whose activities should be returned.
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.

            try
            {
                InlineResponse20048 result = apiInstance.Destiny2GetDestinyAggregateActivityStats(characterId, destinyMembershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyAggregateActivityStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The specific character whose activities should be returned. | 
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 

### Return type

[**InlineResponse20048**](InlineResponse20048.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getdestinyentitydefinition"></a>
# **Destiny2GetDestinyEntityDefinition**
> InlineResponse20030 Destiny2GetDestinyEntityDefinition (string entityType, uint? hashIdentifier)



Returns the static definition of an entity of the given Type and hash identifier. Examine the API Documentation for the Type Names of entities that have their own definitions. Note that the return type will always *inherit from* DestinyDefinition, but the specific type returned will be the requested entity type if it can be found. Please don't use this as a chatty alternative to the Manifest database if you require large sets of data, but for simple and one-off accesses this should be handy.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetDestinyEntityDefinitionExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var entityType = entityType_example;  // string | The type of entity for whom you would like results. These correspond to the entity's definition contract name. For instance, if you are looking for items, this property should be 'DestinyInventoryItemDefinition'. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation.
            var hashIdentifier = 56;  // uint? | The hash identifier for the specific Entity you want returned.

            try
            {
                InlineResponse20030 result = apiInstance.Destiny2GetDestinyEntityDefinition(entityType, hashIdentifier);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyEntityDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityType** | **string**| The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation. | 
 **hashIdentifier** | **uint?**| The hash identifier for the specific Entity you want returned. | 

### Return type

[**InlineResponse20030**](InlineResponse20030.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getdestinymanifest"></a>
# **Destiny2GetDestinyManifest**
> InlineResponse20029 Destiny2GetDestinyManifest ()



Returns the current version of the manifest as a json object.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetDestinyManifestExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20029 result = apiInstance.Destiny2GetDestinyManifest();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetDestinyManifest: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20029**](InlineResponse20029.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2gethistoricalstats"></a>
# **Destiny2GetHistoricalStats**
> InlineResponse20044 Destiny2GetHistoricalStats (long? characterId, long? destinyMembershipId, int? membershipType, DateTime? dayend = null, DateTime? daystart = null, List<DestinyHistoricalStatsDefinitionsDestinyStatsGroupType> groups = null, List<DestinyHistoricalStatsDefinitionsDestinyActivityModeType> modes = null, int? periodType = null)



Gets historical stats for indicated character. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetHistoricalStatsExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The id of the character to retrieve. You can omit this character ID or set it to 0 to get aggregate stats across all characters.
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var dayend = 2013-10-20T19:20:30+01:00;  // DateTime? | Last day to return when daily stats are requested. Use the format YYYY-MM-DD. (optional) 
            var daystart = 2013-10-20T19:20:30+01:00;  // DateTime? | First day to return when daily stats are requested. Use the format YYYY-MM-DD (optional) 
            var groups = new List<DestinyHistoricalStatsDefinitionsDestinyStatsGroupType>(); // List<DestinyHistoricalStatsDefinitionsDestinyStatsGroupType> | Group of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals (optional) 
            var modes = new List<DestinyHistoricalStatsDefinitionsDestinyActivityModeType>(); // List<DestinyHistoricalStatsDefinitionsDestinyActivityModeType> | Game modes to return. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var periodType = 56;  // int? | Indicates a specific period type to return. Optional. May be: Daily, AllTime, or Activity (optional) 

            try
            {
                InlineResponse20044 result = apiInstance.Destiny2GetHistoricalStats(characterId, destinyMembershipId, membershipType, dayend, daystart, groups, modes, periodType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The id of the character to retrieve. You can omit this character ID or set it to 0 to get aggregate stats across all characters. | 
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **dayend** | **DateTime?**| Last day to return when daily stats are requested. Use the format YYYY-MM-DD. | [optional] 
 **daystart** | **DateTime?**| First day to return when daily stats are requested. Use the format YYYY-MM-DD | [optional] 
 **groups** | [**List&lt;DestinyHistoricalStatsDefinitionsDestinyStatsGroupType&gt;**](DestinyHistoricalStatsDefinitionsDestinyStatsGroupType.md)| Group of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals | [optional] 
 **modes** | [**List&lt;DestinyHistoricalStatsDefinitionsDestinyActivityModeType&gt;**](DestinyHistoricalStatsDefinitionsDestinyActivityModeType.md)| Game modes to return. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional] 
 **periodType** | **int?**| Indicates a specific period type to return. Optional. May be: Daily, AllTime, or Activity | [optional] 

### Return type

[**InlineResponse20044**](InlineResponse20044.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2gethistoricalstatsdefinition"></a>
# **Destiny2GetHistoricalStatsDefinition**
> InlineResponse20040 Destiny2GetHistoricalStatsDefinition ()



Gets historical stats definitions.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetHistoricalStatsDefinitionExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20040 result = apiInstance.Destiny2GetHistoricalStatsDefinition();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStatsDefinition: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20040**](InlineResponse20040.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2gethistoricalstatsforaccount"></a>
# **Destiny2GetHistoricalStatsForAccount**
> InlineResponse20045 Destiny2GetHistoricalStatsForAccount (long? destinyMembershipId, int? membershipType, List<DestinyHistoricalStatsDefinitionsDestinyStatsGroupType> groups = null)



Gets aggregate historical stats organized around each character for a given account. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetHistoricalStatsForAccountExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var groups = new List<DestinyHistoricalStatsDefinitionsDestinyStatsGroupType>(); // List<DestinyHistoricalStatsDefinitionsDestinyStatsGroupType> | Groups of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals. (optional) 

            try
            {
                InlineResponse20045 result = apiInstance.Destiny2GetHistoricalStatsForAccount(destinyMembershipId, membershipType, groups);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetHistoricalStatsForAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **groups** | [**List&lt;DestinyHistoricalStatsDefinitionsDestinyStatsGroupType&gt;**](DestinyHistoricalStatsDefinitionsDestinyStatsGroupType.md)| Groups of stats to include, otherwise only general stats are returned. Comma separated list is allowed. Values: General, Weapons, Medals. | [optional] 

### Return type

[**InlineResponse20045**](InlineResponse20045.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getitem"></a>
# **Destiny2GetItem**
> InlineResponse20035 Destiny2GetItem (long? destinyMembershipId, long? itemInstanceId, int? membershipType, List<DestinyDestinyComponentType> components = null)



Retrieve the details of an instanced Destiny Item. An instanced Destiny item is one with an ItemInstanceId. Non-instanced items, such as materials, have no useful instance-specific details and thus are not queryable here.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetItemExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var destinyMembershipId = 789;  // long? | The membership ID of the destiny profile.
            var itemInstanceId = 789;  // long? | The Instance ID of the destiny item.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var components = new List<DestinyDestinyComponentType>(); // List<DestinyDestinyComponentType> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20035 result = apiInstance.Destiny2GetItem(destinyMembershipId, itemInstanceId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinyMembershipId** | **long?**| The membership ID of the destiny profile. | 
 **itemInstanceId** | **long?**| The Instance ID of the destiny item. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **components** | [**List&lt;DestinyDestinyComponentType&gt;**](DestinyDestinyComponentType.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20035**](InlineResponse20035.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getleaderboards"></a>
# **Destiny2GetLeaderboards**
> InlineResponse20041 Destiny2GetLeaderboards (long? destinyMembershipId, int? membershipType, int? maxtop = null, string modes = null, string statid = null)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint has not yet been implemented. It is being returned for a preview of future functionality, and for public comment/suggestion/preparation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetLeaderboardsExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = modes_example;  // string | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = statid_example;  // string | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                InlineResponse20041 result = apiInstance.Destiny2GetLeaderboards(destinyMembershipId, membershipType, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetLeaderboards: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **maxtop** | **int?**| Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional] 
 **modes** | **string**| List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional] 
 **statid** | **string**| ID of stat to return rather than returning all Leaderboard stats. | [optional] 

### Return type

[**InlineResponse20041**](InlineResponse20041.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getleaderboardsforcharacter"></a>
# **Destiny2GetLeaderboardsForCharacter**
> InlineResponse20041 Destiny2GetLeaderboardsForCharacter (long? characterId, long? destinyMembershipId, int? membershipType, int? maxtop = null, string modes = null, string statid = null)



Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetLeaderboardsForCharacterExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The specific character to build the leaderboard around for the provided Destiny Membership.
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var maxtop = 56;  // int? | Maximum number of top players to return. Use a large number to get entire leaderboard. (optional) 
            var modes = modes_example;  // string | List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. (optional) 
            var statid = statid_example;  // string | ID of stat to return rather than returning all Leaderboard stats. (optional) 

            try
            {
                InlineResponse20041 result = apiInstance.Destiny2GetLeaderboardsForCharacter(characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetLeaderboardsForCharacter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The specific character to build the leaderboard around for the provided Destiny Membership. | 
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **maxtop** | **int?**| Maximum number of top players to return. Use a large number to get entire leaderboard. | [optional] 
 **modes** | **string**| List of game modes for which to get leaderboards. See the documentation for DestinyActivityModeType for valid values, and pass in string representation, comma delimited. | [optional] 
 **statid** | **string**| ID of stat to return rather than returning all Leaderboard stats. | [optional] 

### Return type

[**InlineResponse20041**](InlineResponse20041.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getpostgamecarnagereport"></a>
# **Destiny2GetPostGameCarnageReport**
> InlineResponse20039 Destiny2GetPostGameCarnageReport (long? activityId)



Gets the available post game carnage report for the activity ID.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetPostGameCarnageReportExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var activityId = 789;  // long? | The ID of the activity whose PGCR is requested.

            try
            {
                InlineResponse20039 result = apiInstance.Destiny2GetPostGameCarnageReport(activityId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPostGameCarnageReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **activityId** | **long?**| The ID of the activity whose PGCR is requested. | 

### Return type

[**InlineResponse20039**](InlineResponse20039.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getprofile"></a>
# **Destiny2GetProfile**
> InlineResponse20032 Destiny2GetProfile (long? destinyMembershipId, int? membershipType, List<DestinyDestinyComponentType> components = null)



Returns Destiny Profile information for the supplied membership.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetProfileExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var destinyMembershipId = 789;  // long? | Destiny membership ID.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var components = new List<DestinyDestinyComponentType>(); // List<DestinyDestinyComponentType> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20032 result = apiInstance.Destiny2GetProfile(destinyMembershipId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **destinyMembershipId** | **long?**| Destiny membership ID. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **components** | [**List&lt;DestinyDestinyComponentType&gt;**](DestinyDestinyComponentType.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20032**](InlineResponse20032.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getpublicmilestonecontent"></a>
# **Destiny2GetPublicMilestoneContent**
> InlineResponse20049 Destiny2GetPublicMilestoneContent (uint? milestoneHash)



Gets custom localized content for the milestone of the given hash, if it exists.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetPublicMilestoneContentExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var milestoneHash = 56;  // uint? | The identifier for the milestone to be returned.

            try
            {
                InlineResponse20049 result = apiInstance.Destiny2GetPublicMilestoneContent(milestoneHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicMilestoneContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **milestoneHash** | **uint?**| The identifier for the milestone to be returned. | 

### Return type

[**InlineResponse20049**](InlineResponse20049.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getpublicmilestones"></a>
# **Destiny2GetPublicMilestones**
> InlineResponse20050 Destiny2GetPublicMilestones ()



Gets public information about currently available Milestones.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetPublicMilestonesExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20050 result = apiInstance.Destiny2GetPublicMilestones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetPublicMilestones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20050**](InlineResponse20050.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getuniqueweaponhistory"></a>
# **Destiny2GetUniqueWeaponHistory**
> InlineResponse20047 Destiny2GetUniqueWeaponHistory (long? characterId, long? destinyMembershipId, int? membershipType)



Gets details about unique weapon usage, including all exotic weapons. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is in final form, but there may be bugs that prevent desirable operation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetUniqueWeaponHistoryExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The id of the character to retrieve.
            var destinyMembershipId = 789;  // long? | The Destiny membershipId of the user to retrieve.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.

            try
            {
                InlineResponse20047 result = apiInstance.Destiny2GetUniqueWeaponHistory(characterId, destinyMembershipId, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetUniqueWeaponHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The id of the character to retrieve. | 
 **destinyMembershipId** | **long?**| The Destiny membershipId of the user to retrieve. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 

### Return type

[**InlineResponse20047**](InlineResponse20047.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getvendor"></a>
# **Destiny2GetVendor**
> InlineResponse20037 Destiny2GetVendor (long? characterId, long? destinyMembershipId, int? membershipType, uint? vendorHash, List<DestinyDestinyComponentType> components = null)



Get the details of a specific Vendor. PREVIEW: This service is not yet active, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetVendorExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The Destiny Character ID of the character for whom we're getting vendor info.
            var destinyMembershipId = 789;  // long? | Destiny membership ID of another user. You may be denied.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var vendorHash = 56;  // uint? | The Hash identifier of the Vendor to be returned.
            var components = new List<DestinyDestinyComponentType>(); // List<DestinyDestinyComponentType> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20037 result = apiInstance.Destiny2GetVendor(characterId, destinyMembershipId, membershipType, vendorHash, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetVendor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The Destiny Character ID of the character for whom we&#39;re getting vendor info. | 
 **destinyMembershipId** | **long?**| Destiny membership ID of another user. You may be denied. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **vendorHash** | **uint?**| The Hash identifier of the Vendor to be returned. | 
 **components** | [**List&lt;DestinyDestinyComponentType&gt;**](DestinyDestinyComponentType.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20037**](InlineResponse20037.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2getvendors"></a>
# **Destiny2GetVendors**
> InlineResponse20036 Destiny2GetVendors (long? characterId, long? destinyMembershipId, int? membershipType, List<DestinyDestinyComponentType> components = null)



Get currently available vendors. PREVIEW: This service is not yet active, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2GetVendorsExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var characterId = 789;  // long? | The Destiny Character ID of the character for whom we're getting vendor info.
            var destinyMembershipId = 789;  // long? | Destiny membership ID of another user. You may be denied.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type.
            var components = new List<DestinyDestinyComponentType>(); // List<DestinyDestinyComponentType> | A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. (optional) 

            try
            {
                InlineResponse20036 result = apiInstance.Destiny2GetVendors(characterId, destinyMembershipId, membershipType, components);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2GetVendors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **characterId** | **long?**| The Destiny Character ID of the character for whom we&#39;re getting vendor info. | 
 **destinyMembershipId** | **long?**| Destiny membership ID of another user. You may be denied. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type. | 
 **components** | [**List&lt;DestinyDestinyComponentType&gt;**](DestinyDestinyComponentType.md)| A comma separated list of components to return (as strings or numeric values). See the DestinyComponentType enum for valid components to request. You must request at least one component to receive results. | [optional] 

### Return type

[**InlineResponse20036**](InlineResponse20036.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2insertsocketplug"></a>
# **Destiny2InsertSocketPlug**
> InlineResponse20015 Destiny2InsertSocketPlug ()



Insert a plug into a socketed item. I know how it sounds, but I assure you it's much more G-rated than you might be guessing. We haven't decided yet whether this will be able to insert plugs that have side effects, but if we do it will require special scope permission for an application attempting to do so. You must have a valid Destiny Account, and either be in a social space, in orbit, or offline. PREVIEW: This service is not yet active, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2InsertSocketPlugExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20015 result = apiInstance.Destiny2InsertSocketPlug();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2InsertSocketPlug: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2searchdestinyentities"></a>
# **Destiny2SearchDestinyEntities**
> InlineResponse20043 Destiny2SearchDestinyEntities (string searchTerm, string type, int? page = null)



Gets a page list of Destiny items.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2SearchDestinyEntitiesExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var searchTerm = searchTerm_example;  // string | The string to use when searching for Destiny entities.
            var type = type_example;  // string | The type of entity for whom you would like results. These correspond to the entity's definition contract name. For instance, if you are looking for items, this property should be 'DestinyInventoryItemDefinition'. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation.
            var page = 56;  // int? | Page number to return, starting with 0. (optional) 

            try
            {
                InlineResponse20043 result = apiInstance.Destiny2SearchDestinyEntities(searchTerm, type, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SearchDestinyEntities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchTerm** | **string**| The string to use when searching for Destiny entities. | 
 **type** | **string**| The type of entity for whom you would like results. These correspond to the entity&#39;s definition contract name. For instance, if you are looking for items, this property should be &#39;DestinyInventoryItemDefinition&#39;. PREVIEW: This endpoint is still in beta, and may experience rough edges. The schema is tentatively in final form, but there may be bugs that prevent desirable operation. | 
 **page** | **int?**| Page number to return, starting with 0. | [optional] 

### Return type

[**InlineResponse20043**](InlineResponse20043.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2searchdestinyplayer"></a>
# **Destiny2SearchDestinyPlayer**
> InlineResponse20031 Destiny2SearchDestinyPlayer (string displayName, int? membershipType)



Returns a list of Destiny memberships given a full Gamertag or PSN ID.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2SearchDestinyPlayerExample
    {
        public void main()
        {
            var apiInstance = new Destiny2Api();
            var displayName = displayName_example;  // string | The full gamertag or PSN id of the player. Spaces and case are ignored.
            var membershipType = 56;  // int? | A valid non-BungieNet membership type, or All.

            try
            {
                InlineResponse20031 result = apiInstance.Destiny2SearchDestinyPlayer(displayName, membershipType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SearchDestinyPlayer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **displayName** | **string**| The full gamertag or PSN id of the player. Spaces and case are ignored. | 
 **membershipType** | **int?**| A valid non-BungieNet membership type, or All. | 

### Return type

[**InlineResponse20031**](InlineResponse20031.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2setitemlockstate"></a>
# **Destiny2SetItemLockState**
> InlineResponse20015 Destiny2SetItemLockState ()



Set the Lock State for an instanced item. You must have a valid Destiny Account.

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2SetItemLockStateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20015 result = apiInstance.Destiny2SetItemLockState();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2SetItemLockState: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="destiny2transferitem"></a>
# **Destiny2TransferItem**
> InlineResponse20015 Destiny2TransferItem ()



Transfer an item to/from your vault. You must have a valid Destiny account. You must also pass BOTH a reference AND an instance ID if it's an instanced item. itshappening.gif

### Example
```csharp
using System;
using System.Diagnostics;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace Example
{
    public class Destiny2TransferItemExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new Destiny2Api();

            try
            {
                InlineResponse20015 result = apiInstance.Destiny2TransferItem();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling Destiny2Api.Destiny2TransferItem: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

