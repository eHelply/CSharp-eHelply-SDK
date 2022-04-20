/*
 * eHelply SDK - 1.1.55
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.55
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
    ///  Class for testing MonitorApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MonitorApiTests : IDisposable
    {
        private MonitorApi instance;

        public MonitorApiTests()
        {
            instance = new MonitorApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MonitorApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MonitorApi
            //Assert.IsType<MonitorApi>(instance);
        }

        /// <summary>
        /// Test AckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost
        /// </summary>
        [Fact]
        public void AckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost bodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost = null;
            //var response = instance.AckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost(service, stage, alarmUuid, bodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost
        /// </summary>
        [Fact]
        public void AssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost bodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost = null;
            //var response = instance.AssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost(service, stage, alarmUuid, bodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost
        /// </summary>
        [Fact]
        public void AttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost bodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost = null;
            //var response = instance.AttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost(service, stage, alarmUuid, bodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test AttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost
        /// </summary>
        [Fact]
        public void AttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost bodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost = null;
            //var response = instance.AttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost(service, stage, alarmUuid, bodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ClearAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidClearPost
        /// </summary>
        [Fact]
        public void ClearAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidClearPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //var response = instance.ClearAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidClearPost(service, stage, alarmUuid);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServiceAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidGet
        /// </summary>
        [Fact]
        public void GetServiceAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //var response = instance.GetServiceAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidGet(service, stage, alarmUuid);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServiceAlarmsMonitorServicesServiceStagesStageAlarmsGet
        /// </summary>
        [Fact]
        public void GetServiceAlarmsMonitorServicesServiceStagesStageAlarmsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //int? history = null;
            //bool? includeTerminated = null;
            //bool? includeCleared = null;
            //var response = instance.GetServiceAlarmsMonitorServicesServiceStagesStageAlarmsGet(service, stage, history, includeTerminated, includeCleared);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServiceHeartbeatsMonitorServicesServiceStagesStageHeartbeatsGet
        /// </summary>
        [Fact]
        public void GetServiceHeartbeatsMonitorServicesServiceStagesStageHeartbeatsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //int? history = null;
            //var response = instance.GetServiceHeartbeatsMonitorServicesServiceStagesStageHeartbeatsGet(service, stage, history);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServiceKpisMonitorServicesServiceKpisGet
        /// </summary>
        [Fact]
        public void GetServiceKpisMonitorServicesServiceKpisGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //int? history = null;
            //var response = instance.GetServiceKpisMonitorServicesServiceKpisGet(service, history);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServiceMonitorServicesServiceGet
        /// </summary>
        [Fact]
        public void GetServiceMonitorServicesServiceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //bool? heartbeats = null;
            //int? heartbeatLimit = null;
            //bool? alarms = null;
            //int? alarmLimit = null;
            //string stage = null;
            //var response = instance.GetServiceMonitorServicesServiceGet(service, heartbeats, heartbeatLimit, alarms, alarmLimit, stage);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServiceSpec
        /// </summary>
        [Fact]
        public void GetServiceSpecTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string spec = null;
            //bool? asJson = null;
            //var response = instance.GetServiceSpec(service, spec, asJson);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServiceSpecs
        /// </summary>
        [Fact]
        public void GetServiceSpecsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //var response = instance.GetServiceSpecs(service);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServiceVitalsMonitorServicesServiceStagesStageVitalsGet
        /// </summary>
        [Fact]
        public void GetServiceVitalsMonitorServicesServiceStagesStageVitalsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //int? history = null;
            //var response = instance.GetServiceVitalsMonitorServicesServiceStagesStageVitalsGet(service, stage, history);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServicesMonitorServicesGet
        /// </summary>
        [Fact]
        public void GetServicesMonitorServicesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? heartbeats = null;
            //int? heartbeatLimit = null;
            //bool? alarms = null;
            //int? alarmLimit = null;
            //bool? includeHidden = null;
            //string stage = null;
            //string key = null;
            //var response = instance.GetServicesMonitorServicesGet(heartbeats, heartbeatLimit, alarms, alarmLimit, includeHidden, stage, key);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetServicesWithSpecs
        /// </summary>
        [Fact]
        public void GetServicesWithSpecsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetServicesWithSpecs();
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test HideServiceMonitorServicesServiceStagesStageHidePost
        /// </summary>
        [Fact]
        public void HideServiceMonitorServicesServiceStagesStageHidePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //var response = instance.HideServiceMonitorServicesServiceStagesStageHidePost(service, stage);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test IgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost
        /// </summary>
        [Fact]
        public void IgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost bodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost = null;
            //var response = instance.IgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost(service, stage, alarmUuid, bodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test RegisterServiceMonitorServicesPost
        /// </summary>
        [Fact]
        public void RegisterServiceMonitorServicesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BodyRegisterServiceMonitorServicesPost bodyRegisterServiceMonitorServicesPost = null;
            //var response = instance.RegisterServiceMonitorServicesPost(bodyRegisterServiceMonitorServicesPost);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SearchAlarmsMonitorServicesServiceAlarmsGet
        /// </summary>
        [Fact]
        public void SearchAlarmsMonitorServicesServiceAlarmsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //int? page = null;
            //int? pageSize = null;
            //string search = null;
            //string searchOn = null;
            //string sortOn = null;
            //bool? sortDesc = null;
            //var response = instance.SearchAlarmsMonitorServicesServiceAlarmsGet(service, page, pageSize, search, searchOn, sortOn, sortDesc);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ShowServiceMonitorServicesServiceStagesStageShowPost
        /// </summary>
        [Fact]
        public void ShowServiceMonitorServicesServiceStagesStageShowPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //var response = instance.ShowServiceMonitorServicesServiceStagesStageShowPost(service, stage);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test TerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost
        /// </summary>
        [Fact]
        public void TerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost bodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost = null;
            //var response = instance.TerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost(service, stage, alarmUuid, bodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test TriggerAlarmMonitorServicesServiceStagesStageAlarmsPost
        /// </summary>
        [Fact]
        public void TriggerAlarmMonitorServicesServiceStagesStageAlarmsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost bodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost = null;
            //var response = instance.TriggerAlarmMonitorServicesServiceStagesStageAlarmsPost(service, stage, bodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost);
            //Assert.IsType<Object>(response);
        }
    }
}
