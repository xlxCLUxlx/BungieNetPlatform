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
    /// Defines Forum.ForumTopicsSortEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ForumForumTopicsSortEnum
    {
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "0")]
        Default,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "1")]
        LastReplied,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "2")]
        MostReplied,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "3")]
        Popularity,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "4")]
        Controversiality,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "5")]
        Liked,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "6")]
        HighestRated,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "7")]
        MostUpvoted
    }

}
