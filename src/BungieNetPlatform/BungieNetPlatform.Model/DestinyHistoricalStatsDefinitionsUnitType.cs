/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * OpenAPI spec version: 2.0.1
 * Contact: support@bungie.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = BungieNetPlatform.Client.SwaggerDateConverter;

namespace BungieNetPlatform.BungieNetPlatform.Model
{
    /// <summary>
    /// Defines Destiny.HistoricalStats.Definitions.UnitType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestinyHistoricalStatsDefinitionsUnitType
    {
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "0")]
        None,
        
		/// <summary>
		/// Indicates the statistic is a simple count of something.
		/// </summary>
		[EnumMember(Value = "1")]
        Count,
        
		/// <summary>
		/// Indicates the statistic is a per game average.
		/// </summary>
		[EnumMember(Value = "2")]
        PerGame,
        
		/// <summary>
		/// Indicates the number of seconds
		/// </summary>
		[EnumMember(Value = "3")]
        Seconds,
        
		/// <summary>
		/// Indicates the number of points earned
		/// </summary>
		[EnumMember(Value = "4")]
        Points,
        
		/// <summary>
		/// Values represents a team ID
		/// </summary>
		[EnumMember(Value = "5")]
        Team,
        
		/// <summary>
		/// Values represents a distance (units to-be-determined)
		/// </summary>
		[EnumMember(Value = "6")]
        Distance,
        
		/// <summary>
		/// Ratio represented as a whole value from 0 to 100.
		/// </summary>
		[EnumMember(Value = "7")]
        Percent,
        
		/// <summary>
		/// Ratio of something, shown with decimal places
		/// </summary>
		[EnumMember(Value = "8")]
        Ratio,
        
		/// <summary>
		/// True or false
		/// </summary>
		[EnumMember(Value = "9")]
        Boolean,
        
		/// <summary>
		/// The stat is actually a weapon type.
		/// </summary>
		[EnumMember(Value = "10")]
        WeaponType,
        
		/// <summary>
		/// Indicates victory, defeat, or something in between.
		/// </summary>
		[EnumMember(Value = "11")]
        Standing,
        
		/// <summary>
		/// Number of milliseconds some event spanned. For example, race time, or lap time.
		/// </summary>
		[EnumMember(Value = "12")]
        Milliseconds
    }

}