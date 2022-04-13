/*
 * eHelply SDK - 1.1.63
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.63
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
        /// Test CreateTagTagsPost
        /// </summary>
        [Fact]
        public void CreateTagTagsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TagBase tagBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateTagTagsPost(tagBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TagDb>(response);
        }

        /// <summary>
        /// Test DeleteTagTagsTagUuidDelete
        /// </summary>
        [Fact]
        public void DeleteTagTagsTagUuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteTagTagsTagUuidDelete(tagUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetTagTagsTagUuidGet
        /// </summary>
        [Fact]
        public void GetTagTagsTagUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetTagTagsTagUuidGet(tagUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TagBase>(response);
        }

        /// <summary>
        /// Test SearchTagsTagsGet
        /// </summary>
        [Fact]
        public void SearchTagsTagsGetTest()
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
            //var response = instance.SearchTagsTagsGet(projectUuid, name, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateTagTagsTagUuidPut
        /// </summary>
        [Fact]
        public void UpdateTagTagsTagUuidPutTest()
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
            //var response = instance.UpdateTagTagsTagUuidPut(tagUuid, tagBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TagBase>(response);
        }
    }
}
