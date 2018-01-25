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
    /// Defines Forum.ForumPostCategoryEnums
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ForumForumPostCategoryEnums
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
        TextOnly,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "2")]
        Media,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "4")]
        Link,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "8")]
        Poll,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "16")]
        Question,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "32")]
        Answered,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "64")]
        Announcement,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "128")]
        ContentComment,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "256")]
        BungieOfficial,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "512")]
        NinjaOfficial,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "1024")]
        Recruitment
    }

}
