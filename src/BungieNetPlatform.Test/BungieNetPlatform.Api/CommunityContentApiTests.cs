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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using BungieNetPlatform.Client;
using BungieNetPlatform.BungieNetPlatform.Api;
using BungieNetPlatform.BungieNetPlatform.Model;

namespace BungieNetPlatform.Test
{
    /// <summary>
    ///  Class for testing CommunityContentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CommunityContentApiTests
    {
        private CommunityContentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CommunityContentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CommunityContentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CommunityContentApi
            //Assert.IsInstanceOfType(typeof(CommunityContentApi), instance, "instance is a CommunityContentApi");
        }

        
        /// <summary>
        /// Test CommunityContentGetCommunityContent
        /// </summary>
        [Test]
        public void CommunityContentGetCommunityContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? mediaFilter = null;
            //int? page = null;
            //int? sort = null;
            //var response = instance.CommunityContentGetCommunityContent(mediaFilter, page, sort);
            //Assert.IsInstanceOf<InlineResponse2006> (response, "response is InlineResponse2006");
        }
        
        /// <summary>
        /// Test CommunityContentGetCommunityLiveStatuses
        /// </summary>
        [Test]
        public void CommunityContentGetCommunityLiveStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? partnershipType = null;
            //int? sort = null;
            //uint? modeHash = null;
            //string streamLocale = null;
            //var response = instance.CommunityContentGetCommunityLiveStatuses(page, partnershipType, sort, modeHash, streamLocale);
            //Assert.IsInstanceOf<InlineResponse20051> (response, "response is InlineResponse20051");
        }
        
        /// <summary>
        /// Test CommunityContentGetCommunityLiveStatusesForClanmates
        /// </summary>
        [Test]
        public void CommunityContentGetCommunityLiveStatusesForClanmatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? partnershipType = null;
            //int? sort = null;
            //var response = instance.CommunityContentGetCommunityLiveStatusesForClanmates(page, partnershipType, sort);
            //Assert.IsInstanceOf<InlineResponse20051> (response, "response is InlineResponse20051");
        }
        
        /// <summary>
        /// Test CommunityContentGetCommunityLiveStatusesForFriends
        /// </summary>
        [Test]
        public void CommunityContentGetCommunityLiveStatusesForFriendsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? partnershipType = null;
            //int? sort = null;
            //var response = instance.CommunityContentGetCommunityLiveStatusesForFriends(page, partnershipType, sort);
            //Assert.IsInstanceOf<InlineResponse20051> (response, "response is InlineResponse20051");
        }
        
        /// <summary>
        /// Test CommunityContentGetFeaturedCommunityLiveStatuses
        /// </summary>
        [Test]
        public void CommunityContentGetFeaturedCommunityLiveStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? partnershipType = null;
            //int? sort = null;
            //string streamLocale = null;
            //var response = instance.CommunityContentGetFeaturedCommunityLiveStatuses(page, partnershipType, sort, streamLocale);
            //Assert.IsInstanceOf<InlineResponse20051> (response, "response is InlineResponse20051");
        }
        
        /// <summary>
        /// Test CommunityContentGetStreamingStatusForMember
        /// </summary>
        [Test]
        public void CommunityContentGetStreamingStatusForMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? membershipId = null;
            //int? membershipType = null;
            //int? partnershipType = null;
            //var response = instance.CommunityContentGetStreamingStatusForMember(membershipId, membershipType, partnershipType);
            //Assert.IsInstanceOf<InlineResponse20052> (response, "response is InlineResponse20052");
        }
        
    }

}
