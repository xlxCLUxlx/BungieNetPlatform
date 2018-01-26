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
    ///  Class for testing TrendingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TrendingApiTests
    {
        private TrendingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TrendingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TrendingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TrendingApi
            //Assert.IsInstanceOfType(typeof(TrendingApi), instance, "instance is a TrendingApi");
        }

        
        /// <summary>
        /// Test TrendingGetTrendingCategories
        /// </summary>
        [Test]
        public void TrendingGetTrendingCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TrendingGetTrendingCategories();
            //Assert.IsInstanceOf<InlineResponse20053> (response, "response is InlineResponse20053");
        }
        
        /// <summary>
        /// Test TrendingGetTrendingCategory
        /// </summary>
        [Test]
        public void TrendingGetTrendingCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryId = null;
            //int? pageNumber = null;
            //var response = instance.TrendingGetTrendingCategory(categoryId, pageNumber);
            //Assert.IsInstanceOf<InlineResponse20054> (response, "response is InlineResponse20054");
        }
        
        /// <summary>
        /// Test TrendingGetTrendingEntryDetail
        /// </summary>
        [Test]
        public void TrendingGetTrendingEntryDetailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string identifier = null;
            //int? trendingEntryType = null;
            //var response = instance.TrendingGetTrendingEntryDetail(identifier, trendingEntryType);
            //Assert.IsInstanceOf<InlineResponse20055> (response, "response is InlineResponse20055");
        }
        
    }

}