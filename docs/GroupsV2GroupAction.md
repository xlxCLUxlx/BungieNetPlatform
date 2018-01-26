# BungieNetPlatform.Model.GroupsV2GroupAction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupType** | [**GroupsV2GroupType**](GroupsV2GroupType.md) | Type of group, either Bungie.net hosted group, or a game services hosted clan. | [optional] 
**Name** | **string** |  | [optional] 
**About** | **string** |  | [optional] 
**Motto** | **string** |  | [optional] 
**Theme** | **string** |  | [optional] 
**AvatarImageIndex** | **int?** |  | [optional] 
**Tags** | **string** |  | [optional] 
**IsPublic** | **bool?** |  | [optional] 
**MembershipOption** | [**GroupsV2MembershipOption**](GroupsV2MembershipOption.md) |  | [optional] 
**IsPublicTopicAdminOnly** | **bool?** |  | [optional] 
**IsDefaultPostPublic** | **bool?** |  | [optional] 
**AllowChat** | **bool?** |  | [optional] 
**IsDefaultPostAlliance** | **bool?** |  | [optional] 
**ChatSecurity** | [**GroupsV2ChatSecuritySetting**](GroupsV2ChatSecuritySetting.md) |  | [optional] 
**Callsign** | **string** |  | [optional] 
**Locale** | **string** |  | [optional] 
**Homepage** | [**GroupsV2GroupHomepage**](GroupsV2GroupHomepage.md) |  | [optional] 
**PlatformMembershipType** | [**BungieMembershipType**](BungieMembershipType.md) | When operation needs a platform specific account ID for the present user, use this property. In particular, groupType of Clan requires this value to be set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

