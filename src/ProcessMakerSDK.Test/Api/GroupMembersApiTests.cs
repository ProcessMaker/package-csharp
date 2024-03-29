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
    ///  Class for testing GroupMembersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupMembersApiTests
    {
        private GroupMembersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupMembersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupMembersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' GroupMembersApi
            //Assert.IsInstanceOf(typeof(GroupMembersApi), instance);
        }

        
        /// <summary>
        /// Test CreateGroupMember
        /// </summary>
        [Test]
        public void CreateGroupMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GroupMembersEditable groupMembersEditable = null;
            //var response = instance.CreateGroupMember(groupMembersEditable);
            //Assert.IsInstanceOf(typeof(GroupMembers), response, "response is GroupMembers");
        }
        
        /// <summary>
        /// Test DeleteGroupMember
        /// </summary>
        [Test]
        public void DeleteGroupMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupMemberId = null;
            //var response = instance.DeleteGroupMember(groupMemberId);
            //Assert.IsInstanceOf(typeof(GroupMembers), response, "response is GroupMembers");
        }
        
        /// <summary>
        /// Test GetGroupMemberById
        /// </summary>
        [Test]
        public void GetGroupMemberByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupMemberId = null;
            //var response = instance.GetGroupMemberById(groupMemberId);
            //Assert.IsInstanceOf(typeof(GroupMembers), response, "response is GroupMembers");
        }
        
        /// <summary>
        /// Test GetGroupMembers
        /// </summary>
        [Test]
        public void GetGroupMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? memberId = null;
            //string orderBy = null;
            //string orderDirection = null;
            //int? perPage = null;
            //var response = instance.GetGroupMembers(memberId, orderBy, orderDirection, perPage);
            //Assert.IsInstanceOf(typeof(InlineResponse2007), response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test GetGroupMembersAvailable
        /// </summary>
        [Test]
        public void GetGroupMembersAvailableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string memberId = null;
            //string memberType = null;
            //string filter = null;
            //string orderBy = null;
            //string orderDirection = null;
            //int? perPage = null;
            //var response = instance.GetGroupMembersAvailable(memberId, memberType, filter, orderBy, orderDirection, perPage);
            //Assert.IsInstanceOf(typeof(InlineResponse2008), response, "response is InlineResponse2008");
        }
        
        /// <summary>
        /// Test GetUserMembersAvailable
        /// </summary>
        [Test]
        public void GetUserMembersAvailableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //string filter = null;
            //string orderBy = null;
            //string orderDirection = null;
            //int? perPage = null;
            //var response = instance.GetUserMembersAvailable(groupId, filter, orderBy, orderDirection, perPage);
            //Assert.IsInstanceOf(typeof(InlineResponse2009), response, "response is InlineResponse2009");
        }
        
    }

}
