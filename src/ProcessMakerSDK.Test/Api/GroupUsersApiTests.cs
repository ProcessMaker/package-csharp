/* 
 * ProcessMaker API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@processmaker.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ProcessMakerSDK.Client;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Model;

namespace ProcessMakerSDK.Test
{
    /// <summary>
    ///  Class for testing GroupUsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupUsersApiTests
    {
        private GroupUsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupUsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupUsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' GroupUsersApi
            //Assert.IsInstanceOf(typeof(GroupUsersApi), instance);
        }

        
        /// <summary>
        /// Test GetMembers
        /// </summary>
        [Test]
        public void GetMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderBy = null;
            //string orderDirection = null;
            //int? perPage = null;
            //string include = null;
            //var response = instance.GetMembers(filter, orderBy, orderDirection, perPage, include);
            //Assert.IsInstanceOf(typeof(InlineResponse2006), response, "response is InlineResponse2006");
        }
        
    }

}
