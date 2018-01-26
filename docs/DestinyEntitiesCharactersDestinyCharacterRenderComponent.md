# BungieNetPlatform.Model.DestinyEntitiesCharactersDestinyCharacterRenderComponent
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomDyes** | [**List&lt;DestinyDyeReference&gt;**](DestinyDyeReference.md) | Custom dyes, calculated by iterating over the character&#39;s equipped items. Useful for pre-fetching all of the dye data needed from our server. | [optional] 
**Customization** | [**DestinyCharacterDestinyCharacterCustomization**](DestinyCharacterDestinyCharacterCustomization.md) | This is actually something that Spasm.js *doesn&#39;t* do right now, and that we don&#39;t return assets for yet. This is the data about what character customization options you picked. You can combine this with DestinyCharacterCustomizationOptionDefinition to show some cool info, and hopefully someday to actually render a user&#39;s face in 3D. We&#39;ll see if we ever end up with time for that. | [optional] 
**PeerView** | [**DestinyCharacterDestinyCharacterPeerView**](DestinyCharacterDestinyCharacterPeerView.md) | A minimal view of:  - Equipped items  - The rendering-related custom options on those equipped items  Combined, that should be enough to render all of the items on the equipped character. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

