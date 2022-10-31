/*
 * eHelply SDK - 1.1.116
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.116
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
    ///  Class for testing CompaniesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CompaniesApiTests : IDisposable
    {
        private CompaniesApi instance;

        public CompaniesApiTests()
        {
            instance = new CompaniesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CompaniesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CompaniesApi
            //Assert.IsType<CompaniesApi>(instance);
        }

        /// <summary>
        /// Test CreateCompanyPlacesCompaniesPost
        /// </summary>
        [Fact]
        public void CreateCompanyPlacesCompaniesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CompanyBase companyBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateCompanyPlacesCompaniesPost(companyBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CompanyResponse>(response);
        }

        /// <summary>
        /// Test DeletePlacePlacesCompaniesCompanyUuidDelete
        /// </summary>
        [Fact]
        public void DeletePlacePlacesCompaniesCompanyUuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string companyUuid = null;
            //bool? softDelete = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeletePlacePlacesCompaniesCompanyUuidDelete(companyUuid, softDelete, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetCompanyPlacesCompaniesCompanyUuidGet
        /// </summary>
        [Fact]
        public void GetCompanyPlacesCompaniesCompanyUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string companyUuid = null;
            //bool? withMeta = null;
            //bool? withCatalog = null;
            //bool? withReviews = null;
            //bool? withSchedule = null;
            //bool? withBlog = null;
            //bool? withTags = null;
            //bool? withCategories = null;
            //bool? withPlaces = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetCompanyPlacesCompaniesCompanyUuidGet(companyUuid, withMeta, withCatalog, withReviews, withSchedule, withBlog, withTags, withCategories, withPlaces, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CompanyResponse>(response);
        }

        /// <summary>
        /// Test SearchCompaniesPlacesCompaniesGet
        /// </summary>
        [Fact]
        public void SearchCompaniesPlacesCompaniesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string name = null;
            //string email = null;
            //bool? isPublic = null;
            //bool? isDeleted = null;
            //bool? withPlaces = null;
            //bool? withMeta = null;
            //bool? withCatalog = null;
            //bool? withReviews = null;
            //bool? withSchedule = null;
            //bool? withBlog = null;
            //bool? withTags = null;
            //bool? withCategories = null;
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
            //var response = instance.SearchCompaniesPlacesCompaniesGet(projectUuid, name, email, isPublic, isDeleted, withPlaces, withMeta, withCatalog, withReviews, withSchedule, withBlog, withTags, withCategories, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateCompanyPlacesCompaniesCompanyUuidPut
        /// </summary>
        [Fact]
        public void UpdateCompanyPlacesCompaniesCompanyUuidPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string companyUuid = null;
            //CompanyBase companyBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateCompanyPlacesCompaniesCompanyUuidPut(companyUuid, companyBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CompanyResponse>(response);
        }
    }
}
