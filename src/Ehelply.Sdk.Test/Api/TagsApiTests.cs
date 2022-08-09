/*
 * eHelply SDK - 1.1.107
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.107
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
    ///  Class for testing TagsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TagsApiTests : IDisposable
    {
        private TagsApi instance;

        public TagsApiTests()
        {
            instance = new TagsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TagsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TagsApi
            //Assert.IsType<TagsApi>(instance);
        }

        /// <summary>
        /// Test CreateTag
        /// </summary>
        [Fact]
        public void CreateTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TagBase tagBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateTag(tagBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TagDb>(response);
        }

        /// <summary>
        /// Test GetTag
        /// </summary>
        [Fact]
        public void GetTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetTag(tagUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TagBase>(response);
        }

        /// <summary>
        /// Test SearchTag
        /// </summary>
        [Fact]
        public void SearchTagTest()
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
            //var response = instance.SearchTag(projectUuid, name, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateTag
        /// </summary>
        [Fact]
        public void UpdateTagTest()
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
            //var response = instance.UpdateTag(tagUuid, tagBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TagBase>(response);
        }
    }
}
