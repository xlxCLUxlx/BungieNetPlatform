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
    /// Defines Destiny.DestinyComponentType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DestinyDestinyComponentType
    {
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "0")]
        None,
        
		/// <summary>
		/// Profiles is the most basic component, only relevant when calling GetProfile. This returns basic information about the profile, which is almost nothing: a list of characterIds, some information about the last time you logged in, and that most sobering statistic: how long you&#39;ve played.
		/// </summary>
		[EnumMember(Value = "100")]
        Profiles,
        
		/// <summary>
		/// Only applicable for GetProfile, this will return information about receipts for refundable vendor items.
		/// </summary>
		[EnumMember(Value = "101")]
        VendorReceipts,
        
		/// <summary>
		/// Asking for this will get you the profile-level inventories, such as your Vault buckets (yeah, the Vault is really inventory buckets located on your Profile)
		/// </summary>
		[EnumMember(Value = "102")]
        ProfileInventories,
        
		/// <summary>
		/// This will get you a summary of items on your Profile that we consider to be &quot;currencies&quot;, such as Glimmer. I mean, if there&#39;s Glimmer in Destiny 2. I didn&#39;t say there was Glimmer.
		/// </summary>
		[EnumMember(Value = "103")]
        ProfileCurrencies,
        
		/// <summary>
		/// This will get you summary info about each of the characters in the profile.
		/// </summary>
		[EnumMember(Value = "200")]
        Characters,
        
		/// <summary>
		/// This will get you information about any non-equipped items on the character or character(s) in question, if you&#39;re allowed to see it. You have to either be authenticated as that user, or that user must allow anonymous viewing of their non-equipped items in Bungie.Net settings to actually get results.
		/// </summary>
		[EnumMember(Value = "201")]
        CharacterInventories,
        
		/// <summary>
		/// This will get you information about the progression (faction, experience, etc... &quot;levels&quot;) relevant to each character, if you are the currently authenticated user or the user has elected to allow anonymous viewing of its progression info.
		/// </summary>
		[EnumMember(Value = "202")]
        CharacterProgressions,
        
		/// <summary>
		/// This will get you just enough information to be able to render the character in 3D if you have written a 3D rendering library for Destiny Characters, or &quot;borrowed&quot; ours. It&#39;s okay, I won&#39;t tell anyone if you&#39;re using it. I&#39;m no snitch. (actually, we don&#39;t care if you use it - go to town)
		/// </summary>
		[EnumMember(Value = "203")]
        CharacterRenderData,
        
		/// <summary>
		/// This will return info about activities that a user can see and gating on it, if you are the currently authenticated user or the user has elected to allow anonymous viewing of its progression info. Note that the data returned by this can be unfortunately problematic and relatively unreliable in some cases. We&#39;ll eventually work on making it more consistently reliable.
		/// </summary>
		[EnumMember(Value = "204")]
        CharacterActivities,
        
		/// <summary>
		/// This will return info about the equipped items on the character(s). Everyone can see this.
		/// </summary>
		[EnumMember(Value = "205")]
        CharacterEquipment,
        
		/// <summary>
		/// This will return basic info about instanced items - whether they can be equipped, their tracked status, and some info commonly needed in many places (current damage type, primary stat value, etc)
		/// </summary>
		[EnumMember(Value = "300")]
        ItemInstances,
        
		/// <summary>
		/// Items can have Objectives (DestinyObjectiveDefinition) bound to them. If they do, this will return info for items that have such bound objectives.
		/// </summary>
		[EnumMember(Value = "301")]
        ItemObjectives,
        
		/// <summary>
		/// Items can have perks (DestinyPerkDefinition). If they do, this will return info for what perks are active on items.
		/// </summary>
		[EnumMember(Value = "302")]
        ItemPerks,
        
		/// <summary>
		/// If you just want to render the weapon, this is just enough info to do that rendering.
		/// </summary>
		[EnumMember(Value = "303")]
        ItemRenderData,
        
		/// <summary>
		/// Items can have stats, like rate of fire. Asking for this component will return requested item&#39;s stats if they have stats.
		/// </summary>
		[EnumMember(Value = "304")]
        ItemStats,
        
		/// <summary>
		/// Items can have sockets, where plugs can be inserted. Asking for this component will return all info relevant to the sockets on items that have them.
		/// </summary>
		[EnumMember(Value = "305")]
        ItemSockets,
        
		/// <summary>
		/// Items can have talent grids, though that matters a lot less frequently than it used to. Asking for this component will return all relevant info about activated Nodes and Steps on this talent grid, like the good ol&#39; days.
		/// </summary>
		[EnumMember(Value = "306")]
        ItemTalentGrids,
        
		/// <summary>
		/// Items that *aren&#39;t* instanced still have important information you need to know: how much of it you have, the itemHash so you can look up their DestinyInventoryItemDefinition, whether they&#39;re locked, etc... Both instanced and non-instanced items will have these properties. You will get this automatically with Inventory components - you only need to pass this when calling GetItem on a specific item.
		/// </summary>
		[EnumMember(Value = "307")]
        ItemCommonData,
        
		/// <summary>
		/// Items that are &quot;Plugs&quot; can be inserted into sockets. This returns statuses about those plugs and why they can/can&#39;t be inserted. I hear you giggling, there&#39;s nothing funny about inserting plugs. Get your head out of the gutter and pay attention!
		/// </summary>
		[EnumMember(Value = "308")]
        ItemPlugStates,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "400")]
        Vendors,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "401")]
        VendorCategories,
        
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(Value = "402")]
        VendorSales,
        
		/// <summary>
		/// Asking for this component will return you the account&#39;s Kiosk statuses: that is, what items have been filled out/acquired. But only if you are the currently authenticated user or the user has elected to allow anonymous viewing of its progression info.
		/// </summary>
		[EnumMember(Value = "500")]
        Kiosks
    }

}