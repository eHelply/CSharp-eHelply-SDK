/*
 * eHelply SDK - 1.1.71
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.71
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
        /// Test CreateField
        /// </summary>
        [Fact]
        public void CreateFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Field field = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateField(field, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<FieldDynamo>(response);
        }

        /// <summary>
        /// Test CreateMeta
        /// </summary>
        [Fact]
        public void CreateMetaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string typeStr = null;
            //string entityUuid = null;
            //MetaCreate metaCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateMeta(service, typeStr, entityUuid, metaCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<MetaDynamo>(response);
        }

        /// <summary>
        /// Test DeleteField
        /// </summary>
        [Fact]
        public void DeleteFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fieldUuid = null;
            //bool? softDelete = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteField(fieldUuid, softDelete, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test DeleteMeta
        /// </summary>
        [Fact]
        public void DeleteMetaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string typeStr = null;
            //string entityUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteMeta(service, typeStr, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test DeleteMetaFromUuid
        /// </summary>
        [Fact]
        public void DeleteMetaFromUuidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string metaUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteMetaFromUuid(metaUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetField
        /// </summary>
        [Fact]
        public void GetFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fieldUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetField(fieldUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<FieldDynamo>(response);
        }

        /// <summary>
        /// Test GetMeta
        /// </summary>
        [Fact]
        public void GetMetaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string typeStr = null;
            //string entityUuid = null;
            //bool? detailed = null;
            //bool? custom = null;
            //bool? dates = null;
            //int? history = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetMeta(service, typeStr, entityUuid, detailed, custom, dates, history, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<MetaDynamo>(response);
        }

        /// <summary>
        /// Test GetMetaFromUuid
        /// </summary>
        [Fact]
        public void GetMetaFromUuidTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string metaUuid = null;
            //bool? detailed = null;
            //bool? custom = null;
            //bool? dates = null;
            //int? history = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetMetaFromUuid(metaUuid, detailed, custom, dates, history, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<MetaDynamo>(response);
        }

        /// <summary>
        /// Test MakeSlug
        /// </summary>
        [Fact]
        public void MakeSlugTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MetaSlugger metaSlugger = null;
            //var response = instance.MakeSlug(metaSlugger);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test TouchMeta
        /// </summary>
        [Fact]
        public void TouchMetaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string typeStr = null;
            //string entityUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.TouchMeta(service, typeStr, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<MetaDynamo>(response);
        }

        /// <summary>
        /// Test UpdateField
        /// </summary>
        [Fact]
        public void UpdateFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fieldUuid = null;
            //Field field = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateField(fieldUuid, field, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateMeta
        /// </summary>
        [Fact]
        public void UpdateMetaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string typeStr = null;
            //string entityUuid = null;
            //MetaCreate metaCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateMeta(service, typeStr, entityUuid, metaCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<MetaDynamo>(response);
        }

        /// <summary>
        /// Test UpdateMetaFromUuid
        /// </summary>
        [Fact]
        public void UpdateMetaFromUuidTest()
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
            //var response = instance.UpdateMetaFromUuid(metaUuid, metaCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<MetaDynamo>(response);
        }
    }
}
