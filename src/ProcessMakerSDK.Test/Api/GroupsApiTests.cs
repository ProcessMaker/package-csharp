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
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupsApiTests
    {
        private GroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' GroupsApi
            //Assert.IsInstanceOf(typeof(GroupsApi), instance);
        }

        
        /// <summary>
        /// Test CreateGroup
        /// </summary>
        [Test]
        public void CreateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GroupsEditable groupsEditable = null;
            //var response = instance.CreateGroup(groupsEditable);
            //Assert.IsInstanceOf(typeof(Groups), response, "response is Groups");
        }
        
        /// <summary>
        /// Test DeleteGroup
        /// </summary>
        [Test]
        public void DeleteGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //var response = instance.DeleteGroup(groupId);
            //Assert.IsInstanceOf(typeof(Groups), response, "response is Groups");
        }
        
        /// <summary>
        /// Test GetGroupById
        /// </summary>
        [Test]
        public void GetGroupByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //var response = instance.GetGroupById(groupId);
            //Assert.IsInstanceOf(typeof(Groups), response, "response is Groups");
        }
        
        /// <summary>
        /// Test GetGroups
        /// </summary>
        [Test]
        public void GetGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderBy = null;
            //string orderDirection = null;
            //int? perPage = null;
            //string include = null;
            //var response = instance.GetGroups(filter, orderBy, orderDirection, perPage, include);
            //Assert.IsInstanceOf(typeof(InlineResponse2005), response, "response is InlineResponse2005");
        }
        
        /// <summary>
        /// Test UpdateGroup
        /// </summary>
        [Test]
        public void UpdateGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupId = null;
            //GroupsEditable groupsEditable = null;
            //var response = instance.UpdateGroup(groupId, groupsEditable);
            //Assert.IsInstanceOf(typeof(Groups), response, "response is Groups");
        }
        
    }

}
