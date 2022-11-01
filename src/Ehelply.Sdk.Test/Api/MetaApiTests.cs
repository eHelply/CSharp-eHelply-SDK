/*
 * eHelply SDK - 1.1.117
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.117
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
    ///  Class for testing MetaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MetaApiTests : IDisposable
    {
        private MetaApi instance;

        public MetaApiTests()
        {
            instance = new MetaApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MetaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MetaApi
            //Assert.IsType<MetaApi>(instance);
        }

        /// <summary>
        /// Test CreateMeta
        /// </summary>
        [Fact]
        public void CreateMetaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string typeName = null;
            //string entityUuid = null;
            //MetaCreate metaCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateMeta(service, typeName, entityUuid, metaCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CreateMeta200Response>(response);
        }

        /// <summary>
        /// Test CreateSlug
        /// </summary>
        [Fact]
        public void CreateSlugTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Slugger slugger = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateSlug(slugger, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CreateSlug200Response>(response);
        }

        /// <summary>
        /// Test DeleteMeta
        /// </summary>
        [Fact]
        public void DeleteMetaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string metaUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteMeta(metaUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<DeleteMeta200Response>(response);
        }

        /// <summary>
        /// Test DeleteMetaFromParts
        /// </summary>
        [Fact]
        public void DeleteMetaFromPartsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string typeName = null;
            //string entityUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteMetaFromParts(service, typeName, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<DeleteMeta200Response>(response);
        }

        /// <summary>
        /// Test GetMeta
        /// </summary>
        [Fact]
        public void GetMetaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string metaUuid = null;
            //bool? detailed = null;
            //bool? custom = null;
            //int? history = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetMeta(metaUuid, detailed, custom, history, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<MetaDynamo>(response);
        }

        /// <summary>
        /// Test GetMetaFromParts
        /// </summary>
        [Fact]
        public void GetMetaFromPartsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string typeName = null;
            //string entityUuid = null;
            //bool? detailed = null;
            //bool? custom = null;
            //int? history = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetMetaFromParts(service, typeName, entityUuid, detailed, custom, history, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<MetaDynamo>(response);
        }

        /// <summary>
        /// Test TouchMeta
        /// </summary>
        [Fact]
        public void TouchMetaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string metaUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.TouchMeta(metaUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TouchMeta200Response>(response);
        }

        /// <summary>
        /// Test UpdateMeta
        /// </summary>
        [Fact]
        public void UpdateMetaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string metaUuid = null;
            //MetaCreate metaCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateMeta(metaUuid, metaCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<UpdateMeta200Response>(response);
        }

        /// <summary>
        /// Test UpdateMetaFromParts
        /// </summary>
        [Fact]
        public void UpdateMetaFromPartsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string typeName = null;
            //string entityUuid = null;
            //MetaCreate metaCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateMetaFromParts(service, typeName, entityUuid, metaCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<UpdateMeta200Response>(response);
        }
    }
}
