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
    ///  Class for testing ScreensApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ScreensApiTests
    {
        private ScreensApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ScreensApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScreensApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ScreensApi
            //Assert.IsInstanceOf(typeof(ScreensApi), instance);
        }

        
        /// <summary>
        /// Test CreateScreens
        /// </summary>
        [Test]
        public void CreateScreensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ScreensEditable screensEditable = null;
            //var response = instance.CreateScreens(screensEditable);
            //Assert.IsInstanceOf(typeof(Screens), response, "response is Screens");
        }
        
        /// <summary>
        /// Test DeleteScreen
        /// </summary>
        [Test]
        public void DeleteScreenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string screensId = null;
            //var response = instance.DeleteScreen(screensId);
            //Assert.IsInstanceOf(typeof(Screens), response, "response is Screens");
        }
        
        /// <summary>
        /// Test DuplicateScript
        /// </summary>
        [Test]
        public void DuplicateScriptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string screensId = null;
            //ScreensEditable screensEditable = null;
            //var response = instance.DuplicateScript(screensId, screensEditable);
            //Assert.IsInstanceOf(typeof(Screens), response, "response is Screens");
        }
        
        /// <summary>
        /// Test ExportScreen
        /// </summary>
        [Test]
        public void ExportScreenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string screensId = null;
            //var response = instance.ExportScreen(screensId);
            //Assert.IsInstanceOf(typeof(Screens), response, "response is Screens");
        }
        
        /// <summary>
        /// Test GetScreens
        /// </summary>
        [Test]
        public void GetScreensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //string orderBy = null;
            //string orderDirection = null;
            //int? perPage = null;
            //string include = null;
            //var response = instance.GetScreens(filter, orderBy, orderDirection, perPage, include);
            //Assert.IsInstanceOf(typeof(InlineResponse20016), response, "response is InlineResponse20016");
        }
        
        /// <summary>
        /// Test GetScreensById
        /// </summary>
        [Test]
        public void GetScreensByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string screensId = null;
            //var response = instance.GetScreensById(screensId);
            //Assert.IsInstanceOf(typeof(Screens), response, "response is Screens");
        }
        
        /// <summary>
        /// Test ImportScreen
        /// </summary>
        [Test]
        public void ImportScreenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //var response = instance.ImportScreen(file);
            //Assert.IsInstanceOf(typeof(Screens), response, "response is Screens");
        }
        
        /// <summary>
        /// Test UpdateScreen
        /// </summary>
        [Test]
        public void UpdateScreenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string screensId = null;
            //ScreensEditable screensEditable = null;
            //var response = instance.UpdateScreen(screensId, screensEditable);
            //Assert.IsInstanceOf(typeof(Screens), response, "response is Screens");
        }
        
    }

}
