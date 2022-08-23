/*
 * eHelply SDK - 1.1.110
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.110
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
        /// Test CreateCategoryPlacesCategoriesPost
        /// </summary>
        [Fact]
        public void CreateCategoryPlacesCategoriesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CategoryBase categoryBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateCategoryPlacesCategoriesPost(categoryBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CategoryDb>(response);
        }

        /// <summary>
        /// Test DeleteCategoryPlacesCategoriesCategoryUuidDelete
        /// </summary>
        [Fact]
        public void DeleteCategoryPlacesCategoriesCategoryUuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteCategoryPlacesCategoriesCategoryUuidDelete(categoryUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetCategoryPlacesCategoriesCategoryUuidGet
        /// </summary>
        [Fact]
        public void GetCategoryPlacesCategoriesCategoryUuidGetTest()
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
            //var response = instance.GetCategoryPlacesCategoriesCategoryUuidGet(categoryUuid, withMeta, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CategoryBase>(response);
        }

        /// <summary>
        /// Test SearchCategoriesPlacesCategoriesGet
        /// </summary>
        [Fact]
        public void SearchCategoriesPlacesCategoriesGetTest()
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
            //var response = instance.SearchCategoriesPlacesCategoriesGet(projectUuid, name, withMeta, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateCategoryPlacesCategoriesCategoryUuidPut
        /// </summary>
        [Fact]
        public void UpdateCategoryPlacesCategoriesCategoryUuidPutTest()
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
            //var response = instance.UpdateCategoryPlacesCategoriesCategoryUuidPut(categoryUuid, categoryBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CategoryBase>(response);
        }
    }
}
