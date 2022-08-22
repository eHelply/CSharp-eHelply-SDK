/*
 * eHelply SDK - 1.1.103
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.103
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
    ///  Class for testing AppointmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppointmentsApiTests : IDisposable
    {
        private AppointmentsApi instance;

        public AppointmentsApiTests()
        {
            instance = new AppointmentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppointmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppointmentsApi
            //Assert.IsType<AppointmentsApi>(instance);
        }

        /// <summary>
        /// Test AddEntityToAppointment
        /// </summary>
        [Fact]
        public void AddEntityToAppointmentTest()
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
            //var response = instance.AddEntityToAppointment(appointmentUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<bool>(response);
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
            //Assert.IsType<bool>(response);
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
            //Assert.IsType<bool>(response);
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
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.SearchAppointment(placeUuid, excludeCancelled, isDeleted, startRange, endRange, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
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
        /// Test SearchEntityAppointments
        /// </summary>
        [Fact]
        public void SearchEntityAppointmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entityUuid = null;
            //string startDate = null;
            //string endDate = null;
            //bool? excludeCancelled = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.SearchEntityAppointments(entityUuid, startDate, endDate, excludeCancelled, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
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
    }
}