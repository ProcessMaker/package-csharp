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
    ///  Class for testing TasksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TasksApiTests
    {
        private TasksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TasksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TasksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TasksApi
            //Assert.IsInstanceOf(typeof(TasksApi), instance);
        }

        
        /// <summary>
        /// Test GetTasks
        /// </summary>
        [Test]
        public void GetTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? processRequestId = null;
            //string filter = null;
            //string orderBy = null;
            //string orderDirection = null;
            //var response = instance.GetTasks(processRequestId, filter, orderBy, orderDirection);
            //Assert.IsInstanceOf(typeof(InlineResponse20018), response, "response is InlineResponse20018");
        }
        
        /// <summary>
        /// Test UpdateTask
        /// </summary>
        [Test]
        public void UpdateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //ProcessRequestTokenEditable processRequestTokenEditable = null;
            //var response = instance.UpdateTask(taskId, processRequestTokenEditable);
            //Assert.IsInstanceOf(typeof(ProcessRequestToken), response, "response is ProcessRequestToken");
        }
        
    }

}
