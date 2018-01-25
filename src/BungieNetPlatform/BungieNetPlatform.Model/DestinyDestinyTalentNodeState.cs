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
    /// Defines Destiny.DestinyTalentNodeState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestinyDestinyTalentNodeState
    {
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "0")]
        Invalid,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "1")]
        CanUpgrade,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "2")]
        NoPoints,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "3")]
        NoPrerequisites,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "4")]
        NoSteps,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "5")]
        NoUnlock,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "6")]
        NoMaterial,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "7")]
        NoGridLevel,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "8")]
        SwappingLocked,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "9")]
        MustSwap,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "10")]
        Complete,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "11")]
        Unknown,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "12")]
        CreationOnly,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "13")]
        Hidden
    }

}
