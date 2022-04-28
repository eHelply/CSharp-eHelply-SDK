/*
 * eHelply SDK - 1.1.72
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.72
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
    ///  Class for testing CategoryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CategoryApiTests : IDisposable
    {
        private CategoryApi instance;

        public CategoryApiTests()
        {
            instance = new CategoryApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CategoryApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CategoryApi
            //Assert.IsType<CategoryApi>(instance);
        }

        /// <summary>
        /// Test CreateCategoryCategoriesPost
        /// </summary>
        [Fact]
        public void CreateCategoryCategoriesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CategoryBase categoryBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateCategoryCategoriesPost(categoryBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CategoryDb>(response);
        }

        /// <summary>
        /// Test DeleteCategoryCategoriesCategoryUuidDelete
        /// </summary>
        [Fact]
        public void DeleteCategoryCategoriesCategoryUuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteCategoryCategoriesCategoryUuidDelete(categoryUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetCategoryCategoriesCategoryUuidGet
        /// </summary>
        [Fact]
        public void GetCategoryCategoriesCategoryUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryUuid = null;
            //bool? withMeta = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetCategoryCategoriesCategoryUuidGet(categoryUuid, withMeta, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CategoryBase>(response);
        }

        /// <summary>
        /// Test SearchCategoriesCategoriesGet
        /// </summary>
        [Fact]
        public void SearchCategoriesCategoriesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string name = null;
            //bool? withMeta = null;
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
            //var response = instance.SearchCategoriesCategoriesGet(projectUuid, name, withMeta, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateCategoryCategoriesCategoryUuidPut
        /// </summary>
        [Fact]
        public void UpdateCategoryCategoriesCategoryUuidPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryUuid = null;
            //CategoryBase categoryBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateCategoryCategoriesCategoryUuidPut(categoryUuid, categoryBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CategoryBase>(response);
        }
    }
}
