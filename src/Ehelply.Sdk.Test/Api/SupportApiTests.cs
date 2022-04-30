/*
 * eHelply SDK - 1.1.73
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.73
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
    ///  Class for testing SupportApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SupportApiTests : IDisposable
    {
        private SupportApi instance;

        public SupportApiTests()
        {
            instance = new SupportApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SupportApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SupportApi
            //Assert.IsType<SupportApi>(instance);
        }

        /// <summary>
        /// Test CreateContactSupportContactPost
        /// </summary>
        [Fact]
        public void CreateContactSupportContactPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Contact contact = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateContactSupportContactPost(contact, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ContactResponse>(response);
        }

        /// <summary>
        /// Test CreateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsPost
        /// </summary>
        [Fact]
        public void CreateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string memberUuid = null;
            //CreateTicket createTicket = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsPost(projectUuid, memberUuid, createTicket, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TicketResponse>(response);
        }

        /// <summary>
        /// Test DeleteContactSupportContactDelete
        /// </summary>
        [Fact]
        public void DeleteContactSupportContactDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteContactSupportContactDelete(xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ListTicketsSupportProjectsProjectUuidMembersMemberUuidTicketsGet
        /// </summary>
        [Fact]
        public void ListTicketsSupportProjectsProjectUuidMembersMemberUuidTicketsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string memberUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.ListTicketsSupportProjectsProjectUuidMembersMemberUuidTicketsGet(projectUuid, memberUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<TicketsResponse>>(response);
        }

        /// <summary>
        /// Test UpdateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdPut
        /// </summary>
        [Fact]
        public void UpdateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string memberUuid = null;
            //string ticketId = null;
            //CreateTicket createTicket = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdPut(projectUuid, memberUuid, ticketId, createTicket, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TicketResponse>(response);
        }

        /// <summary>
        /// Test ViewTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdGet
        /// </summary>
        [Fact]
        public void ViewTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string memberUuid = null;
            //string ticketId = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.ViewTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdGet(projectUuid, memberUuid, ticketId, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<TicketResponse>(response);
        }
    }
}
