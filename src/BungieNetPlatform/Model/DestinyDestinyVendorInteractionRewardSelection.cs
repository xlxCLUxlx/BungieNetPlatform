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
    /// When a Vendor Interaction provides rewards, they&#39;ll either let you choose one or let you have all of them. This determines which it will be.
    /// </summary>
    /// <value>When a Vendor Interaction provides rewards, they&#39;ll either let you choose one or let you have all of them. This determines which it will be.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestinyDestinyVendorInteractionRewardSelection
    {
        
		/// <summary>
		/// When a Vendor Interaction provides rewards, they&#39;ll either let you choose one or let you have all of them. This determines which it will be.
		/// </summary>
		[EnumMember(Value = "0")]
        None,
        
		/// <summary>
		/// When a Vendor Interaction provides rewards, they&#39;ll either let you choose one or let you have all of them. This determines which it will be.
		/// </summary>
		[EnumMember(Value = "1")]
        One,
        
		/// <summary>
		/// When a Vendor Interaction provides rewards, they&#39;ll either let you choose one or let you have all of them. This determines which it will be.
		/// </summary>
		[EnumMember(Value = "2")]
        All
    }

}
