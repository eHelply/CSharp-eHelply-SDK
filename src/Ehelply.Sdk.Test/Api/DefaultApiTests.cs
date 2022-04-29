/*
 * eHelply SDK - 1.1.68
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.68
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
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DefaultApiTests : IDisposable
    {
        private DefaultApi instance;

        public DefaultApiTests()
        {
            instance = new DefaultApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DefaultApi
            //Assert.IsType<DefaultApi>(instance);
        }

        /// <summary>
        /// Test AppointmentssearchAppointmentEntities
        /// </summary>
        [Fact]
        public void AppointmentssearchAppointmentEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entityUuid = null;
            //string startDate = null;
            //string endDate = null;
            //bool? includeCancelled = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.AppointmentssearchAppointmentEntities(entityUuid, startDate, endDate, includeCancelled, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AttachEntityToAppointment
        /// </summary>
        [Fact]
        public void AttachEntityToAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appointmentUuid = null;
            //string entityUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.AttachEntityToAppointment(appointmentUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
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
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test CreateAppointment
        /// </summary>
        [Fact]
        public void CreateAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AppointmentBase appointmentBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateAppointment(appointmentBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<AppointmentResponse>(response);
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
        /// Test CreateReview
        /// </summary>
        [Fact]
        public void CreateReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entityType = null;
            //string entityUuid = null;
            //CreateReview createReview = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateReview(entityType, entityUuid, createReview, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test DeleteAppointment
        /// </summary>
        [Fact]
        public void DeleteAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appointmentUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteAppointment(appointmentUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
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
        /// Test DeleteReview
        /// </summary>
        [Fact]
        public void DeleteReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entityType = null;
            //string entityUuid = null;
            //string reviewUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteReview(entityType, entityUuid, reviewUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test DetachEntityFromAppointment
        /// </summary>
        [Fact]
        public void DetachEntityFromAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appointmentUuid = null;
            //string entityUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DetachEntityFromAppointment(appointmentUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
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
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetAppointment
        /// </summary>
        [Fact]
        public void GetAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appointmentUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetAppointment(appointmentUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<AppointmentResponse>(response);
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
        /// Test GetReview
        /// </summary>
        [Fact]
        public void GetReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entityType = null;
            //string entityUuid = null;
            //string reviewUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetReview(entityType, entityUuid, reviewUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SearchAppointment
        /// </summary>
        [Fact]
        public void SearchAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string placeUuid = null;
            //bool? excludeCancelled = null;
            //bool? isDeleted = null;
            //string startRange = null;
            //string endRange = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortOn = null;
            //bool? sortDesc = null;
            //string search = null;
            //string searchOn = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.SearchAppointment(placeUuid, excludeCancelled, isDeleted, startRange, endRange, page, pageSize, sortOn, sortDesc, search, searchOn, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SearchAppointmentEntities
        /// </summary>
        [Fact]
        public void SearchAppointmentEntitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appointmentUuid = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortOn = null;
            //bool? sortDesc = null;
            //string search = null;
            //string searchOn = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.SearchAppointmentEntities(appointmentUuid, page, pageSize, sortOn, sortDesc, search, searchOn, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
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
        /// Test SearchProduct
        /// </summary>
        [Fact]
        public void SearchProductTest()
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
            //var response = instance.SearchProduct(withMeta, name, addons, priceMax, priceMin, quantityAvailable, isDeleted, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
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
        /// Test SearchReviews
        /// </summary>
        [Fact]
        public void SearchReviewsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entityType = null;
            //string entityUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.SearchReviews(entityType, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateAppointment
        /// </summary>
        [Fact]
        public void UpdateAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appointmentUuid = null;
            //AppointmentBase appointmentBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateAppointment(appointmentUuid, appointmentBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<AppointmentResponse>(response);
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

        /// <summary>
        /// Test UpdateReview
        /// </summary>
        [Fact]
        public void UpdateReviewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entityType = null;
            //string entityUuid = null;
            //string reviewUuid = null;
            //UpdateReview updateReview = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateReview(entityType, entityUuid, reviewUuid, updateReview, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }
    }
}
