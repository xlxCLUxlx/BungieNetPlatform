# BungieNetPlatform.Model.DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Period** | **DateTime?** | Period for the group. If the stat periodType is day, then this will have a specific day. If the type is monthly, then this value will be the first day of the applicable month. This value is not set when the periodType is &#39;all time&#39;. | [optional] 
**ActivityDetails** | [**DestinyHistoricalStatsDestinyHistoricalStatsActivity**](DestinyHistoricalStatsDestinyHistoricalStatsActivity.md) | If the period group is for a specific activity, this property will be set. | [optional] 
**Values** | [**Dictionary&lt;string, DestinyHistoricalStatsDestinyHistoricalStatsValue&gt;**](DestinyHistoricalStatsDestinyHistoricalStatsValue.md) | Collection of stats for the period. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

