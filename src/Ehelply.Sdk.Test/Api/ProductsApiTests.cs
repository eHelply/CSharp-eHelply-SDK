/*
 * eHelply SDK - 1.1.102
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.102
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
    ///  Class for testing ProductsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductsApiTests : IDisposable
    {
        private ProductsApi instance;

        public ProductsApiTests()
        {
            instance = new ProductsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductsApi
            //Assert.IsType<ProductsApi>(instance);
        }

        /// <summary>
        /// Test CreateProduct
        /// </summary>
        [Fact]
        public void CreateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductBase productBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateProduct(productBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProductReturn>(response);
        }

        /// <summary>
        /// Test DeleteProduct
        /// </summary>
        [Fact]
        public void DeleteProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteProduct(productUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test GetProduct
        /// </summary>
        [Fact]
        public void GetProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productUuid = null;
            //bool? withAddons = null;
            //bool? withMeta = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetProduct(productUuid, withAddons, withMeta, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProductReturn>(response);
        }

        /// <summary>
        /// Test SearchProductCatalog
        /// </summary>
        [Fact]
        public void SearchProductCatalogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productUuid = null;
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
            //var response = instance.SearchProductCatalog(productUuid, withMeta, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test SearchProducts
        /// </summary>
        [Fact]
        public void SearchProductsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? withMeta = null;
            //string name = null;
            //List<string> addons = null;
            //int? priceMax = null;
            //int? priceMin = null;
            //bool? quantityAvailable = null;
            //bool? isDeleted = null;
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
            //var response = instance.SearchProducts(withMeta, name, addons, priceMax, priceMin, quantityAvailable, isDeleted, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateProduct
        /// </summary>
        [Fact]
        public void UpdateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string productUuid = null;
            //ProductBase productBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateProduct(productUuid, productBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProductReturn>(response);
        }
    }
}
