/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * OpenAPI spec version: 2.1.1
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

namespace BungieNetPlatform.Model
{
    /// <summary>
    /// Defines GroupsV2.Capabilities
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupsV2Capabilities
    {
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "0")]
        None,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "1")]
        Leaderboards,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "2")]
        Callsign,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "4")]
        OptionalConversations,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "8")]
        ClanBanner,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "16")]
        D2InvestmentData,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "32")]
        Tags,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "64")]
        Alliances
    }

}
