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
    /// The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.
    /// </summary>
    /// <value>The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BungieMembershipType
    {
        
		/// <summary>
		/// The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.
		/// </summary>
		[EnumMember(Value = "0")]
        None,
        
		/// <summary>
		/// The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.
		/// </summary>
		[EnumMember(Value = "1")]
        TigerXbox,
        
		/// <summary>
		/// The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.
		/// </summary>
		[EnumMember(Value = "2")]
        TigerPsn,
        
		/// <summary>
		/// The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.
		/// </summary>
		[EnumMember(Value = "4")]
        TigerBlizzard,
        
		/// <summary>
		/// The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.
		/// </summary>
		[EnumMember(Value = "10")]
        TigerDemon,
        
		/// <summary>
		/// The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.
		/// </summary>
		[EnumMember(Value = "254")]
        BungieNext,
        
		/// <summary>
		/// &quot;All&quot; is only valid for searching capabilities: you need to pass the actual matching BungieMembershipType for any query where you pass a known membershipId.
		/// </summary>
		[EnumMember(Value = "-1")]
        All
    }

}
