# BungieNetPlatform.BungieNetPlatform.Model.DestinyEntitiesProfilesDestinyProfileComponent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserInfo** | [**UserUserInfoCard**](UserUserInfoCard.md) | If you need to render the Profile (their platform name, icon, etc...) somewhere, this property contains that information. | [optional] 
**DateLastPlayed** | **DateTime?** | The last time the user played with any character on this Profile. | [optional] 
**VersionsOwned** | [**DestinyDestinyGameVersions**](DestinyDestinyGameVersions.md) | If you want to know what expansions they own, this will contain that data. | [optional] 
**CharacterIds** | **List&lt;long?&gt;** | A list of the character IDs, for further querying on your part. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

