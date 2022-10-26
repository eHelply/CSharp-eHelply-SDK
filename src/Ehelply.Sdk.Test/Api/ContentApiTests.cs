/*
 * eHelply SDK - 1.1.113
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.113
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
    ///  Class for testing ContentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ContentApiTests : IDisposable
    {
        private ContentApi instance;

        public ContentApiTests()
        {
            instance = new ContentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ContentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ContentApi
            //Assert.IsType<ContentApi>(instance);
        }

        /// <summary>
        /// Test CreateFile
        /// </summary>
        [Fact]
        public void CreateFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateFile(file, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CreateFile200Response>(response);
        }

        /// <summary>
        /// Test DeleteFile
        /// </summary>
        [Fact]
        public void DeleteFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteFile(fileUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<DeleteFile200Response>(response);
        }

        /// <summary>
        /// Test GetFile
        /// </summary>
        [Fact]
        public void GetFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetFile(fileUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test UpdateFile
        /// </summary>
        [Fact]
        public void UpdateFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileUuid = null;
            //System.IO.Stream file = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateFile(fileUuid, file, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<UpdateFile200Response>(response);
        }
    }
}
