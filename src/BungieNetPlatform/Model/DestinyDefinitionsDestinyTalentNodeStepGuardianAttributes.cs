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
    /// Defines Destiny.Definitions.DestinyTalentNodeStepGuardianAttributes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestinyDefinitionsDestinyTalentNodeStepGuardianAttributes
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
        Stats,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "2")]
        Shields,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "4")]
        Health,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "8")]
        Revive,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "16")]
        AimUnderFire,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "32")]
        Radar,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "64")]
        Invisibility,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "128")]
        Reputations,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "255")]
        All
    }

}
