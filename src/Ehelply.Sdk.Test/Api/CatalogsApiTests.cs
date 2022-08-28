/*
 * eHelply SDK - 1.1.106
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.106
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
    ///  Class for testing CatalogsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CatalogsApiTests : IDisposable
    {
        private CatalogsApi instance;

        public CatalogsApiTests()
        {
            instance = new CatalogsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CatalogsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CatalogsApi
            //Assert.IsType<CatalogsApi>(instance);
        }

        /// <summary>
        /// Test AttachProductToCatalog
        /// </summary>
        [Fact]
        public void AttachProductToCatalogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string catalogUuid = null;
            //string productUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.AttachProductToCatalog(catalogUuid, productUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test CreateCatalog
        /// </summary>
        [Fact]
        public void CreateCatalogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CatalogBase catalogBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateCatalog(catalogBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CatalogReturn>(response);
        }

        /// <summary>
        /// Test DeleteCatalog
        /// </summary>
        [Fact]
        public void DeleteCatalogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string catalogUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteCatalog(catalogUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test DetachProductFromCatalog
        /// </summary>
        [Fact]
        public void DetachProductFromCatalogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string catalogUuid = null;
            //string productUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DetachProductFromCatalog(catalogUuid, productUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test GetCatalog
        /// </summary>
        [Fact]
        public void GetCatalogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string catalogUuid = null;
            //bool? withMeta = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetCatalog(catalogUuid, withMeta, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CatalogReturn>(response);
        }

        /// <summary>
        /// Test SearchCatalogProducts
        /// </summary>
        [Fact]
        public void SearchCatalogProductsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string catalogUuid = null;
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
            //var response = instance.SearchCatalogProducts(catalogUuid, withMeta, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test SearchCatalogs
        /// </summary>
        [Fact]
        public void SearchCatalogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? withMeta = null;
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
            //var response = instance.SearchCatalogs(withMeta, name, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateCatalog
        /// </summary>
        [Fact]
        public void UpdateCatalogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string catalogUuid = null;
            //CatalogBase catalogBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateCatalog(catalogUuid, catalogBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CatalogReturn>(response);
        }
    }
}
