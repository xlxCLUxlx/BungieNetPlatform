# BungieNetPlatform.Model.GroupsV2GroupOptionsEditAction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvitePermissionOverride** | **bool?** | Minimum Member Level allowed to invite new members to group  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups. | [optional] 
**UpdateCulturePermissionOverride** | **bool?** | Minimum Member Level allowed to update group culture  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups. | [optional] 
**HostGuidedGamePermissionOverride** | **int?** | Minimum Member Level allowed to host guided games  Always Allowed: Founder, Acting Founder, Admin  Allowed Overrides: None, Member, Beginner  Default is Member for clans, None for groups, although this means nothing for groups. | [optional] 
**UpdateBannerPermissionOverride** | **bool?** | Minimum Member Level allowed to update banner  Always Allowed: Founder, Acting Founder  True means admins have this power, false means they don&#39;t  Default is false for clans, true for groups. | [optional] 
**JoinLevel** | **int?** | Level to join a member at when accepting an invite, application, or joining an open clan  Default is Beginner. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

