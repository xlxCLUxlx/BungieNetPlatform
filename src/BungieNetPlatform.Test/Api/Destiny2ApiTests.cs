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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using BungieNetPlatform.Client;
using BungieNetPlatform.Api;
using BungieNetPlatform.Model;

namespace BungieNetPlatform.Test
{
    /// <summary>
    ///  Class for testing Destiny2Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Destiny2ApiTests
    {
        private Destiny2Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Destiny2Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Destiny2Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Destiny2Api
            //Assert.IsInstanceOfType(typeof(Destiny2Api), instance, "instance is a Destiny2Api");
        }

        
        /// <summary>
        /// Test Destiny2ActivateTalentNode
        /// </summary>
        [Test]
        public void Destiny2ActivateTalentNodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Destiny2ActivateTalentNode();
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test Destiny2EquipItem
        /// </summary>
        [Test]
        public void Destiny2EquipItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Destiny2EquipItem();
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test Destiny2EquipItems
        /// </summary>
        [Test]
        public void Destiny2EquipItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Destiny2EquipItems();
            //Assert.IsInstanceOf<InlineResponse20038> (response, "response is InlineResponse20038");
        }
        
        /// <summary>
        /// Test Destiny2GetActivityHistory
        /// </summary>
        [Test]
        public void Destiny2GetActivityHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? characterId = null;
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //int? count = null;
            //int? mode = null;
            //int? page = null;
            //var response = instance.Destiny2GetActivityHistory(characterId, destinyMembershipId, membershipType, count, mode, page);
            //Assert.IsInstanceOf<InlineResponse20046> (response, "response is InlineResponse20046");
        }
        
        /// <summary>
        /// Test Destiny2GetCharacter
        /// </summary>
        [Test]
        public void Destiny2GetCharacterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? characterId = null;
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //List<DestinyDestinyComponentType> components = null;
            //var response = instance.Destiny2GetCharacter(characterId, destinyMembershipId, membershipType, components);
            //Assert.IsInstanceOf<InlineResponse20033> (response, "response is InlineResponse20033");
        }
        
        /// <summary>
        /// Test Destiny2GetClanAggregateStats
        /// </summary>
        [Test]
        public void Destiny2GetClanAggregateStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //string modes = null;
            //var response = instance.Destiny2GetClanAggregateStats(groupId, modes);
            //Assert.IsInstanceOf<InlineResponse20042> (response, "response is InlineResponse20042");
        }
        
        /// <summary>
        /// Test Destiny2GetClanLeaderboards
        /// </summary>
        [Test]
        public void Destiny2GetClanLeaderboardsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //int? maxtop = null;
            //string modes = null;
            //string statid = null;
            //var response = instance.Destiny2GetClanLeaderboards(groupId, maxtop, modes, statid);
            //Assert.IsInstanceOf<InlineResponse20041> (response, "response is InlineResponse20041");
        }
        
        /// <summary>
        /// Test Destiny2GetClanWeeklyRewardState
        /// </summary>
        [Test]
        public void Destiny2GetClanWeeklyRewardStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.Destiny2GetClanWeeklyRewardState(groupId);
            //Assert.IsInstanceOf<InlineResponse20034> (response, "response is InlineResponse20034");
        }
        
        /// <summary>
        /// Test Destiny2GetDestinyAggregateActivityStats
        /// </summary>
        [Test]
        public void Destiny2GetDestinyAggregateActivityStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? characterId = null;
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //var response = instance.Destiny2GetDestinyAggregateActivityStats(characterId, destinyMembershipId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20048> (response, "response is InlineResponse20048");
        }
        
        /// <summary>
        /// Test Destiny2GetDestinyEntityDefinition
        /// </summary>
        [Test]
        public void Destiny2GetDestinyEntityDefinitionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entityType = null;
            //uint? hashIdentifier = null;
            //var response = instance.Destiny2GetDestinyEntityDefinition(entityType, hashIdentifier);
            //Assert.IsInstanceOf<InlineResponse20030> (response, "response is InlineResponse20030");
        }
        
        /// <summary>
        /// Test Destiny2GetDestinyManifest
        /// </summary>
        [Test]
        public void Destiny2GetDestinyManifestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Destiny2GetDestinyManifest();
            //Assert.IsInstanceOf<InlineResponse20029> (response, "response is InlineResponse20029");
        }
        
        /// <summary>
        /// Test Destiny2GetHistoricalStats
        /// </summary>
        [Test]
        public void Destiny2GetHistoricalStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? characterId = null;
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //DateTime? dayend = null;
            //DateTime? daystart = null;
            //List<DestinyHistoricalStatsDefinitionsDestinyStatsGroupType> groups = null;
            //List<DestinyHistoricalStatsDefinitionsDestinyActivityModeType> modes = null;
            //int? periodType = null;
            //var response = instance.Destiny2GetHistoricalStats(characterId, destinyMembershipId, membershipType, dayend, daystart, groups, modes, periodType);
            //Assert.IsInstanceOf<InlineResponse20044> (response, "response is InlineResponse20044");
        }
        
        /// <summary>
        /// Test Destiny2GetHistoricalStatsDefinition
        /// </summary>
        [Test]
        public void Destiny2GetHistoricalStatsDefinitionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Destiny2GetHistoricalStatsDefinition();
            //Assert.IsInstanceOf<InlineResponse20040> (response, "response is InlineResponse20040");
        }
        
        /// <summary>
        /// Test Destiny2GetHistoricalStatsForAccount
        /// </summary>
        [Test]
        public void Destiny2GetHistoricalStatsForAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //List<DestinyHistoricalStatsDefinitionsDestinyStatsGroupType> groups = null;
            //var response = instance.Destiny2GetHistoricalStatsForAccount(destinyMembershipId, membershipType, groups);
            //Assert.IsInstanceOf<InlineResponse20045> (response, "response is InlineResponse20045");
        }
        
        /// <summary>
        /// Test Destiny2GetItem
        /// </summary>
        [Test]
        public void Destiny2GetItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? destinyMembershipId = null;
            //long? itemInstanceId = null;
            //int? membershipType = null;
            //List<DestinyDestinyComponentType> components = null;
            //var response = instance.Destiny2GetItem(destinyMembershipId, itemInstanceId, membershipType, components);
            //Assert.IsInstanceOf<InlineResponse20035> (response, "response is InlineResponse20035");
        }
        
        /// <summary>
        /// Test Destiny2GetLeaderboards
        /// </summary>
        [Test]
        public void Destiny2GetLeaderboardsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //int? maxtop = null;
            //string modes = null;
            //string statid = null;
            //var response = instance.Destiny2GetLeaderboards(destinyMembershipId, membershipType, maxtop, modes, statid);
            //Assert.IsInstanceOf<InlineResponse20041> (response, "response is InlineResponse20041");
        }
        
        /// <summary>
        /// Test Destiny2GetLeaderboardsForCharacter
        /// </summary>
        [Test]
        public void Destiny2GetLeaderboardsForCharacterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? characterId = null;
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //int? maxtop = null;
            //string modes = null;
            //string statid = null;
            //var response = instance.Destiny2GetLeaderboardsForCharacter(characterId, destinyMembershipId, membershipType, maxtop, modes, statid);
            //Assert.IsInstanceOf<InlineResponse20041> (response, "response is InlineResponse20041");
        }
        
        /// <summary>
        /// Test Destiny2GetPostGameCarnageReport
        /// </summary>
        [Test]
        public void Destiny2GetPostGameCarnageReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? activityId = null;
            //var response = instance.Destiny2GetPostGameCarnageReport(activityId);
            //Assert.IsInstanceOf<InlineResponse20039> (response, "response is InlineResponse20039");
        }
        
        /// <summary>
        /// Test Destiny2GetProfile
        /// </summary>
        [Test]
        public void Destiny2GetProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //List<DestinyDestinyComponentType> components = null;
            //var response = instance.Destiny2GetProfile(destinyMembershipId, membershipType, components);
            //Assert.IsInstanceOf<InlineResponse20032> (response, "response is InlineResponse20032");
        }
        
        /// <summary>
        /// Test Destiny2GetPublicMilestoneContent
        /// </summary>
        [Test]
        public void Destiny2GetPublicMilestoneContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //uint? milestoneHash = null;
            //var response = instance.Destiny2GetPublicMilestoneContent(milestoneHash);
            //Assert.IsInstanceOf<InlineResponse20049> (response, "response is InlineResponse20049");
        }
        
        /// <summary>
        /// Test Destiny2GetPublicMilestones
        /// </summary>
        [Test]
        public void Destiny2GetPublicMilestonesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Destiny2GetPublicMilestones();
            //Assert.IsInstanceOf<InlineResponse20050> (response, "response is InlineResponse20050");
        }
        
        /// <summary>
        /// Test Destiny2GetUniqueWeaponHistory
        /// </summary>
        [Test]
        public void Destiny2GetUniqueWeaponHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? characterId = null;
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //var response = instance.Destiny2GetUniqueWeaponHistory(characterId, destinyMembershipId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20047> (response, "response is InlineResponse20047");
        }
        
        /// <summary>
        /// Test Destiny2GetVendor
        /// </summary>
        [Test]
        public void Destiny2GetVendorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? characterId = null;
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //uint? vendorHash = null;
            //List<DestinyDestinyComponentType> components = null;
            //var response = instance.Destiny2GetVendor(characterId, destinyMembershipId, membershipType, vendorHash, components);
            //Assert.IsInstanceOf<InlineResponse20037> (response, "response is InlineResponse20037");
        }
        
        /// <summary>
        /// Test Destiny2GetVendors
        /// </summary>
        [Test]
        public void Destiny2GetVendorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? characterId = null;
            //long? destinyMembershipId = null;
            //int? membershipType = null;
            //List<DestinyDestinyComponentType> components = null;
            //var response = instance.Destiny2GetVendors(characterId, destinyMembershipId, membershipType, components);
            //Assert.IsInstanceOf<InlineResponse20036> (response, "response is InlineResponse20036");
        }
        
        /// <summary>
        /// Test Destiny2InsertSocketPlug
        /// </summary>
        [Test]
        public void Destiny2InsertSocketPlugTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Destiny2InsertSocketPlug();
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test Destiny2SearchDestinyEntities
        /// </summary>
        [Test]
        public void Destiny2SearchDestinyEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchTerm = null;
            //string type = null;
            //int? page = null;
            //var response = instance.Destiny2SearchDestinyEntities(searchTerm, type, page);
            //Assert.IsInstanceOf<InlineResponse20043> (response, "response is InlineResponse20043");
        }
        
        /// <summary>
        /// Test Destiny2SearchDestinyPlayer
        /// </summary>
        [Test]
        public void Destiny2SearchDestinyPlayerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string displayName = null;
            //int? membershipType = null;
            //var response = instance.Destiny2SearchDestinyPlayer(displayName, membershipType);
            //Assert.IsInstanceOf<InlineResponse20031> (response, "response is InlineResponse20031");
        }
        
        /// <summary>
        /// Test Destiny2SetItemLockState
        /// </summary>
        [Test]
        public void Destiny2SetItemLockStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Destiny2SetItemLockState();
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test Destiny2TransferItem
        /// </summary>
        [Test]
        public void Destiny2TransferItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Destiny2TransferItem();
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
    }

}
