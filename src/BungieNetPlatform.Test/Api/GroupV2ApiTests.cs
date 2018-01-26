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
    ///  Class for testing GroupV2Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GroupV2ApiTests
    {
        private GroupV2Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupV2Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupV2Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupV2Api
            //Assert.IsInstanceOfType(typeof(GroupV2Api), instance, "instance is a GroupV2Api");
        }

        
        /// <summary>
        /// Test GroupV2AbdicateFoundership
        /// </summary>
        [Test]
        public void GroupV2AbdicateFoundershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? founderIdNew = null;
            //long? groupId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2AbdicateFoundership(founderIdNew, groupId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20014> (response, "response is InlineResponse20014");
        }
        
        /// <summary>
        /// Test GroupV2AddOptionalConversation
        /// </summary>
        [Test]
        public void GroupV2AddOptionalConversationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.GroupV2AddOptionalConversation(groupId);
            //Assert.IsInstanceOf<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test GroupV2ApproveAllPending
        /// </summary>
        [Test]
        public void GroupV2ApproveAllPendingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.GroupV2ApproveAllPending(groupId);
            //Assert.IsInstanceOf<InlineResponse20026> (response, "response is InlineResponse20026");
        }
        
        /// <summary>
        /// Test GroupV2ApprovePending
        /// </summary>
        [Test]
        public void GroupV2ApprovePendingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //long? membershipId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2ApprovePending(groupId, membershipId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20014> (response, "response is InlineResponse20014");
        }
        
        /// <summary>
        /// Test GroupV2ApprovePendingForList
        /// </summary>
        [Test]
        public void GroupV2ApprovePendingForListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.GroupV2ApprovePendingForList(groupId);
            //Assert.IsInstanceOf<InlineResponse20026> (response, "response is InlineResponse20026");
        }
        
        /// <summary>
        /// Test GroupV2BanMember
        /// </summary>
        [Test]
        public void GroupV2BanMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //long? membershipId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2BanMember(groupId, membershipId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test GroupV2CreateGroup
        /// </summary>
        [Test]
        public void GroupV2CreateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GroupV2CreateGroup();
            //Assert.IsInstanceOf<InlineResponse20020> (response, "response is InlineResponse20020");
        }
        
        /// <summary>
        /// Test GroupV2DenyAllPending
        /// </summary>
        [Test]
        public void GroupV2DenyAllPendingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.GroupV2DenyAllPending(groupId);
            //Assert.IsInstanceOf<InlineResponse20026> (response, "response is InlineResponse20026");
        }
        
        /// <summary>
        /// Test GroupV2DenyPendingForList
        /// </summary>
        [Test]
        public void GroupV2DenyPendingForListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.GroupV2DenyPendingForList(groupId);
            //Assert.IsInstanceOf<InlineResponse20026> (response, "response is InlineResponse20026");
        }
        
        /// <summary>
        /// Test GroupV2EditClanBanner
        /// </summary>
        [Test]
        public void GroupV2EditClanBannerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.GroupV2EditClanBanner(groupId);
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test GroupV2EditFounderOptions
        /// </summary>
        [Test]
        public void GroupV2EditFounderOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.GroupV2EditFounderOptions(groupId);
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test GroupV2EditGroup
        /// </summary>
        [Test]
        public void GroupV2EditGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.GroupV2EditGroup(groupId);
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test GroupV2EditGroupMembership
        /// </summary>
        [Test]
        public void GroupV2EditGroupMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //long? membershipId = null;
            //int? membershipType = null;
            //int? memberType = null;
            //var response = instance.GroupV2EditGroupMembership(groupId, membershipId, membershipType, memberType);
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test GroupV2EditOptionalConversation
        /// </summary>
        [Test]
        public void GroupV2EditOptionalConversationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? conversationId = null;
            //long? groupId = null;
            //var response = instance.GroupV2EditOptionalConversation(conversationId, groupId);
            //Assert.IsInstanceOf<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test GroupV2GetAdminsAndFounderOfGroup
        /// </summary>
        [Test]
        public void GroupV2GetAdminsAndFounderOfGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? currentpage = null;
            //long? groupId = null;
            //var response = instance.GroupV2GetAdminsAndFounderOfGroup(currentpage, groupId);
            //Assert.IsInstanceOf<InlineResponse20021> (response, "response is InlineResponse20021");
        }
        
        /// <summary>
        /// Test GroupV2GetAvailableAvatars
        /// </summary>
        [Test]
        public void GroupV2GetAvailableAvatarsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GroupV2GetAvailableAvatars();
            //Assert.IsInstanceOf<InlineResponse20012> (response, "response is InlineResponse20012");
        }
        
        /// <summary>
        /// Test GroupV2GetAvailableThemes
        /// </summary>
        [Test]
        public void GroupV2GetAvailableThemesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GroupV2GetAvailableThemes();
            //Assert.IsInstanceOf<InlineResponse20013> (response, "response is InlineResponse20013");
        }
        
        /// <summary>
        /// Test GroupV2GetBannedMembersOfGroup
        /// </summary>
        [Test]
        public void GroupV2GetBannedMembersOfGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? currentpage = null;
            //long? groupId = null;
            //var response = instance.GroupV2GetBannedMembersOfGroup(currentpage, groupId);
            //Assert.IsInstanceOf<InlineResponse20023> (response, "response is InlineResponse20023");
        }
        
        /// <summary>
        /// Test GroupV2GetGroup
        /// </summary>
        [Test]
        public void GroupV2GetGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.GroupV2GetGroup(groupId);
            //Assert.IsInstanceOf<InlineResponse20018> (response, "response is InlineResponse20018");
        }
        
        /// <summary>
        /// Test GroupV2GetGroupByName
        /// </summary>
        [Test]
        public void GroupV2GetGroupByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupName = null;
            //int? groupType = null;
            //var response = instance.GroupV2GetGroupByName(groupName, groupType);
            //Assert.IsInstanceOf<InlineResponse20018> (response, "response is InlineResponse20018");
        }
        
        /// <summary>
        /// Test GroupV2GetGroupOptionalConversations
        /// </summary>
        [Test]
        public void GroupV2GetGroupOptionalConversationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //var response = instance.GroupV2GetGroupOptionalConversations(groupId);
            //Assert.IsInstanceOf<InlineResponse20019> (response, "response is InlineResponse20019");
        }
        
        /// <summary>
        /// Test GroupV2GetGroupsForMember
        /// </summary>
        [Test]
        public void GroupV2GetGroupsForMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? filter = null;
            //int? groupType = null;
            //long? membershipId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2GetGroupsForMember(filter, groupType, membershipId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20027> (response, "response is InlineResponse20027");
        }
        
        /// <summary>
        /// Test GroupV2GetInvitedIndividuals
        /// </summary>
        [Test]
        public void GroupV2GetInvitedIndividualsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? currentpage = null;
            //long? groupId = null;
            //var response = instance.GroupV2GetInvitedIndividuals(currentpage, groupId);
            //Assert.IsInstanceOf<InlineResponse20025> (response, "response is InlineResponse20025");
        }
        
        /// <summary>
        /// Test GroupV2GetMembersOfGroup
        /// </summary>
        [Test]
        public void GroupV2GetMembersOfGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? currentpage = null;
            //long? groupId = null;
            //int? memberType = null;
            //string nameSearch = null;
            //var response = instance.GroupV2GetMembersOfGroup(currentpage, groupId, memberType, nameSearch);
            //Assert.IsInstanceOf<InlineResponse20021> (response, "response is InlineResponse20021");
        }
        
        /// <summary>
        /// Test GroupV2GetPendingMemberships
        /// </summary>
        [Test]
        public void GroupV2GetPendingMembershipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? currentpage = null;
            //long? groupId = null;
            //var response = instance.GroupV2GetPendingMemberships(currentpage, groupId);
            //Assert.IsInstanceOf<InlineResponse20025> (response, "response is InlineResponse20025");
        }
        
        /// <summary>
        /// Test GroupV2GetPotentialGroupsForMember
        /// </summary>
        [Test]
        public void GroupV2GetPotentialGroupsForMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? filter = null;
            //int? groupType = null;
            //long? membershipId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2GetPotentialGroupsForMember(filter, groupType, membershipId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20028> (response, "response is InlineResponse20028");
        }
        
        /// <summary>
        /// Test GroupV2GetRecommendedGroups
        /// </summary>
        [Test]
        public void GroupV2GetRecommendedGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? createDateRange = null;
            //int? groupType = null;
            //var response = instance.GroupV2GetRecommendedGroups(createDateRange, groupType);
            //Assert.IsInstanceOf<InlineResponse20016> (response, "response is InlineResponse20016");
        }
        
        /// <summary>
        /// Test GroupV2GetUserClanInviteSetting
        /// </summary>
        [Test]
        public void GroupV2GetUserClanInviteSettingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? mType = null;
            //var response = instance.GroupV2GetUserClanInviteSetting(mType);
            //Assert.IsInstanceOf<InlineResponse20014> (response, "response is InlineResponse20014");
        }
        
        /// <summary>
        /// Test GroupV2GroupSearch
        /// </summary>
        [Test]
        public void GroupV2GroupSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GroupV2GroupSearch();
            //Assert.IsInstanceOf<InlineResponse20017> (response, "response is InlineResponse20017");
        }
        
        /// <summary>
        /// Test GroupV2IndividualGroupInvite
        /// </summary>
        [Test]
        public void GroupV2IndividualGroupInviteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //long? membershipId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2IndividualGroupInvite(groupId, membershipId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20024> (response, "response is InlineResponse20024");
        }
        
        /// <summary>
        /// Test GroupV2IndividualGroupInviteCancel
        /// </summary>
        [Test]
        public void GroupV2IndividualGroupInviteCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //long? membershipId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2IndividualGroupInviteCancel(groupId, membershipId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20024> (response, "response is InlineResponse20024");
        }
        
        /// <summary>
        /// Test GroupV2KickMember
        /// </summary>
        [Test]
        public void GroupV2KickMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //long? membershipId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2KickMember(groupId, membershipId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20022> (response, "response is InlineResponse20022");
        }
        
        /// <summary>
        /// Test GroupV2RequestGroupMembership
        /// </summary>
        [Test]
        public void GroupV2RequestGroupMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2RequestGroupMembership(groupId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20024> (response, "response is InlineResponse20024");
        }
        
        /// <summary>
        /// Test GroupV2RescindGroupMembership
        /// </summary>
        [Test]
        public void GroupV2RescindGroupMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2RescindGroupMembership(groupId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20022> (response, "response is InlineResponse20022");
        }
        
        /// <summary>
        /// Test GroupV2SetUserClanInviteSetting
        /// </summary>
        [Test]
        public void GroupV2SetUserClanInviteSettingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? allowInvites = null;
            //int? mType = null;
            //var response = instance.GroupV2SetUserClanInviteSetting(allowInvites, mType);
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test GroupV2UnbanMember
        /// </summary>
        [Test]
        public void GroupV2UnbanMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? groupId = null;
            //long? membershipId = null;
            //int? membershipType = null;
            //var response = instance.GroupV2UnbanMember(groupId, membershipId, membershipType);
            //Assert.IsInstanceOf<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
    }

}