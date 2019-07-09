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
    ///  Class for testing EnvironmentVariablesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EnvironmentVariablesApiTests
    {
        private EnvironmentVariablesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EnvironmentVariablesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EnvironmentVariablesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' EnvironmentVariablesApi
            //Assert.IsInstanceOf(typeof(EnvironmentVariablesApi), instance);
        }

        
        /// <summary>
        /// Test CreateEnvironmentVariables
        /// </summary>
        [Test]
        public void CreateEnvironmentVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EnvironmentVariablesEditable environmentVariablesEditable = null;
            //var response = instance.CreateEnvironmentVariables(environmentVariablesEditable);
            //Assert.IsInstanceOf(typeof(EnvironmentVariables), response, "response is EnvironmentVariables");
        }
        
        /// <summary>
        /// Test DeleteEnvironmentVariables
        /// </summary>
        [Test]
        public void DeleteEnvironmentVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string environmentVariablesId = null;
            //var response = instance.DeleteEnvironmentVariables(environmentVariablesId);
            //Assert.IsInstanceOf(typeof(EnvironmentVariables), response, "response is EnvironmentVariables");
        }
        
        /// <summary>
        /// Test GetEnvironmentVariables
        /// </summary>
        [Test]
        public void GetEnvironmentVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderBy = null;
            //string orderDirection = null;
            //int? perPage = null;
            //string include = null;
            //var response = instance.GetEnvironmentVariables(filter, orderBy, orderDirection, perPage, include);
            //Assert.IsInstanceOf(typeof(InlineResponse2001), response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test GetEnvironmentVariablesById
        /// </summary>
        [Test]
        public void GetEnvironmentVariablesByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string environmentVariablesId = null;
            //var response = instance.GetEnvironmentVariablesById(environmentVariablesId);
            //Assert.IsInstanceOf(typeof(EnvironmentVariables), response, "response is EnvironmentVariables");
        }
        
        /// <summary>
        /// Test UpdateEnvironmentVariables
        /// </summary>
        [Test]
        public void UpdateEnvironmentVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string environmentVariablesId = null;
            //EnvironmentVariablesEditable environmentVariablesEditable = null;
            //var response = instance.UpdateEnvironmentVariables(environmentVariablesId, environmentVariablesEditable);
            //Assert.IsInstanceOf(typeof(EnvironmentVariables), response, "response is EnvironmentVariables");
        }
        
    }

}
