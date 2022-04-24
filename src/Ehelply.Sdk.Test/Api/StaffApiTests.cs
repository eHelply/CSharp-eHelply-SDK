/*
 * eHelply SDK - 1.1.67
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.67
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
    ///  Class for testing StaffApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StaffApiTests : IDisposable
    {
        private StaffApi instance;

        public StaffApiTests()
        {
            instance = new StaffApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of StaffApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' StaffApi
            //Assert.IsType<StaffApi>(instance);
        }

        /// <summary>
        /// Test CreateStaffStaffPost
        /// </summary>
        [Fact]
        public void CreateStaffStaffPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //StaffCreate staffCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateStaffStaffPost(staffCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<StaffDb>(response);
        }

        /// <summary>
        /// Test DeleteStaffStaffStaffUuidDelete
        /// </summary>
        [Fact]
        public void DeleteStaffStaffStaffUuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string staffUuid = null;
            //bool? softDelete = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteStaffStaffStaffUuidDelete(staffUuid, softDelete, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetStaffStaffStaffUuidGet
        /// </summary>
        [Fact]
        public void GetStaffStaffStaffUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string staffUuid = null;
            //bool? withPlaces = null;
            //bool? withCompanies = null;
            //bool? withCatalog = null;
            //bool? withSchedule = null;
            //bool? withRoles = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetStaffStaffStaffUuidGet(staffUuid, withPlaces, withCompanies, withCatalog, withSchedule, withRoles, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<StaffResponse>(response);
        }

        /// <summary>
        /// Test SearchStaffStaffGet
        /// </summary>
        [Fact]
        public void SearchStaffStaffGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string firstName = null;
            //string lastName = null;
            //bool? isDeleted = null;
            //bool? withCompanies = null;
            //bool? withPlaces = null;
            //bool? withSchedule = null;
            //bool? withCatalog = null;
            //bool? withReviews = null;
            //bool? withRoles = null;
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
            //var response = instance.SearchStaffStaffGet(projectUuid, firstName, lastName, isDeleted, withCompanies, withPlaces, withSchedule, withCatalog, withReviews, withRoles, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateStaffStaffStaffUuidPut
        /// </summary>
        [Fact]
        public void UpdateStaffStaffStaffUuidPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string staffUuid = null;
            //StaffCreate staffCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateStaffStaffStaffUuidPut(staffUuid, staffCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<StaffResponse>(response);
        }
    }
}
