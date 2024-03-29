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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' UsersApi
            //Assert.IsInstanceOf(typeof(UsersApi), instance);
        }

        
        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Test]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UsersEditable usersEditable = null;
            //var response = instance.CreateUser(usersEditable);
            //Assert.IsInstanceOf(typeof(Users), response, "response is Users");
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.DeleteUser(userId);
            //Assert.IsInstanceOf(typeof(Users), response, "response is Users");
        }
        
        /// <summary>
        /// Test GetUserById
        /// </summary>
        [Test]
        public void GetUserByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.GetUserById(userId);
            //Assert.IsInstanceOf(typeof(Users), response, "response is Users");
        }
        
        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Test]
        public void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderBy = null;
            //string orderDirection = null;
            //int? perPage = null;
            //string include = null;
            //var response = instance.GetUsers(filter, orderBy, orderDirection, perPage, include);
            //Assert.IsInstanceOf(typeof(InlineResponse20019), response, "response is InlineResponse20019");
        }
        
        /// <summary>
        /// Test UpdateUsers
        /// </summary>
        [Test]
        public void UpdateUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //UsersEditable usersEditable = null;
            //var response = instance.UpdateUsers(userId, usersEditable);
            //Assert.IsInstanceOf(typeof(Users), response, "response is Users");
        }
        
    }

}
