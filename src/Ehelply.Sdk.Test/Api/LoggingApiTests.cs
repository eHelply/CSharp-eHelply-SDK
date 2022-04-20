/*
 * eHelply SDK - 1.1.65
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.65
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
    ///  Class for testing LoggingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LoggingApiTests : IDisposable
    {
        private LoggingApi instance;

        public LoggingApiTests()
        {
            instance = new LoggingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LoggingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LoggingApi
            //Assert.IsType<LoggingApi>(instance);
        }

        /// <summary>
        /// Test GetLogsLoggingLogsGet
        /// </summary>
        [Fact]
        public void GetLogsLoggingLogsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string dateStart = null;
            //string dateEnd = null;
            //bool? desc = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetLogsLoggingLogsGet(service, dateStart, dateEnd, desc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServiceLogsLoggingLogsServicesServiceGet
        /// </summary>
        [Fact]
        public void GetServiceLogsLoggingLogsServicesServiceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string dateStart = null;
            //string dateEnd = null;
            //bool? desc = null;
            //int? limit = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetServiceLogsLoggingLogsServicesServiceGet(service, dateStart, dateEnd, desc, limit, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetSubjectLogsLoggingLogsServicesServiceSubjectsSubjectGet
        /// </summary>
        [Fact]
        public void GetSubjectLogsLoggingLogsServicesServiceSubjectsSubjectGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string subject = null;
            //string dateStart = null;
            //string dateEnd = null;
            //bool? desc = null;
            //int? limit = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetSubjectLogsLoggingLogsServicesServiceSubjectsSubjectGet(service, subject, dateStart, dateEnd, desc, limit, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }
    }
}
