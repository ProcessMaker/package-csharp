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
    ///  Class for testing CommentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CommentsApiTests
    {
        private CommentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CommentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CommentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' CommentsApi
            //Assert.IsInstanceOf(typeof(CommentsApi), instance);
        }

        
        /// <summary>
        /// Test CreateComments
        /// </summary>
        [Test]
        public void CreateCommentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CommentsEditable commentsEditable = null;
            //var response = instance.CreateComments(commentsEditable);
            //Assert.IsInstanceOf(typeof(Comments), response, "response is Comments");
        }
        
        /// <summary>
        /// Test DeleteComments
        /// </summary>
        [Test]
        public void DeleteCommentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string commentId = null;
            //var response = instance.DeleteComments(commentId);
            //Assert.IsInstanceOf(typeof(Comments), response, "response is Comments");
        }
        
        /// <summary>
        /// Test GetCommentById
        /// </summary>
        [Test]
        public void GetCommentByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string commentId = null;
            //var response = instance.GetCommentById(commentId);
            //Assert.IsInstanceOf(typeof(Comments), response, "response is Comments");
        }
        
        /// <summary>
        /// Test GetComments
        /// </summary>
        [Test]
        public void GetCommentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? commentableId = null;
            //string commentableType = null;
            //string filter = null;
            //string orderBy = null;
            //string orderDirection = null;
            //int? perPage = null;
            //var response = instance.GetComments(commentableId, commentableType, filter, orderBy, orderDirection, perPage);
            //Assert.IsInstanceOf(typeof(InlineResponse200), response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test UpdateComment
        /// </summary>
        [Test]
        public void UpdateCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string commentId = null;
            //CommentsEditable commentsEditable = null;
            //var response = instance.UpdateComment(commentId, commentsEditable);
            //Assert.IsInstanceOf(typeof(Comments), response, "response is Comments");
        }
        
    }

}
