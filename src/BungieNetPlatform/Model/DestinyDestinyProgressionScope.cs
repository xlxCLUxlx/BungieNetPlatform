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
    /// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
    /// </summary>
    /// <value>There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestinyDestinyProgressionScope
    {
        
		/// <summary>
		/// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
		/// </summary>
		[EnumMember(Value = "0")]
        Account,
        
		/// <summary>
		/// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
		/// </summary>
		[EnumMember(Value = "1")]
        Character,
        
		/// <summary>
		/// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
		/// </summary>
		[EnumMember(Value = "2")]
        Clan,
        
		/// <summary>
		/// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
		/// </summary>
		[EnumMember(Value = "3")]
        Item,
        
		/// <summary>
		/// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
		/// </summary>
		[EnumMember(Value = "4")]
        ImplicitFromEquipment,
        
		/// <summary>
		/// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
		/// </summary>
		[EnumMember(Value = "5")]
        Mapped,
        
		/// <summary>
		/// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
		/// </summary>
		[EnumMember(Value = "6")]
        MappedAggregate,
        
		/// <summary>
		/// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
		/// </summary>
		[EnumMember(Value = "7")]
        MappedStat,
        
		/// <summary>
		/// There are many Progressions in Destiny (think Character Level, or Reputation). These are the various \&quot;Scopes\&quot; of Progressions, which affect many things: * Where/if they are stored * How they are calculated * Where they can be used in other game logic
		/// </summary>
		[EnumMember(Value = "8")]
        MappedUnlockValue
    }

}
