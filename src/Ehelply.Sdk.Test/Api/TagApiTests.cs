/*
 * eHelply SDK - 1.1.90
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.90
 * Contact: support@ehelply.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Ehelply.Sdk.Client;
using Ehelply.Sdk.Api;
// uncomment below to import models
//using Ehelply.Sdk.Model;

namespace Ehelply.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing TagApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TagApiTests : IDisposable
    {
        private TagApi instance;

        public TagApiTests()
        {
            instance = new TagApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TagApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TagApi
            //Assert.IsType<TagApi>(instance);
        }

        /// <summary>
        /// Test CreateTagPlacesTagsPost
        /// </summary>
        [Fact]
        public void CreateTagPlacesTagsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TagBase tagBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateTagPlacesTagsPost(tagBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TagDb>(response);
        }

        /// <summary>
        /// Test DeleteTagPlacesTagsTagUuidDelete
        /// </summary>
        [Fact]
        public void DeleteTagPlacesTagsTagUuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteTagPlacesTagsTagUuidDelete(tagUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetTagPlacesTagsTagUuidGet
        /// </summary>
        [Fact]
        public void GetTagPlacesTagsTagUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetTagPlacesTagsTagUuidGet(tagUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TagBase>(response);
        }

        /// <summary>
        /// Test SearchTagsPlacesTagsGet
        /// </summary>
        [Fact]
        public void SearchTagsPlacesTagsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string name = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortOn = null;
            //bool? sortDesc = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.SearchTagsPlacesTagsGet(projectUuid, name, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateTagPlacesTagsTagUuidPut
        /// </summary>
        [Fact]
        public void UpdateTagPlacesTagsTagUuidPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagUuid = null;
            //TagBase tagBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateTagPlacesTagsTagUuidPut(tagUuid, tagBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TagBase>(response);
        }
    }
}
