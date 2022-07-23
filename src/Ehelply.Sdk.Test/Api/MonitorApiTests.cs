/*
 * eHelply SDK - 1.1.90
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.90
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
        /// Test AcknowledgeAlarm
        /// </summary>
        [Fact]
        public void AcknowledgeAlarmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //AlarmAcknowledge alarmAcknowledge = null;
            //var response = instance.AcknowledgeAlarm(service, stage, alarmUuid, alarmAcknowledge);
            //Assert.IsType<AlarmResponse>(response);
        }

        /// <summary>
        /// Test AssignAlarm
        /// </summary>
        [Fact]
        public void AssignAlarmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //AlarmAssign alarmAssign = null;
            //var response = instance.AssignAlarm(service, stage, alarmUuid, alarmAssign);
            //Assert.IsType<AlarmResponse>(response);
        }

        /// <summary>
        /// Test AttachAlarmNote
        /// </summary>
        [Fact]
        public void AttachAlarmNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //AlarmNote alarmNote = null;
            //var response = instance.AttachAlarmNote(service, stage, alarmUuid, alarmNote);
            //Assert.IsType<AlarmResponse>(response);
        }

        /// <summary>
        /// Test AttachAlarmTicket
        /// </summary>
        [Fact]
        public void AttachAlarmTicketTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //AlarmTicket alarmTicket = null;
            //var response = instance.AttachAlarmTicket(service, stage, alarmUuid, alarmTicket);
            //Assert.IsType<AlarmResponse>(response);
        }

        /// <summary>
        /// Test ClearAlarm
        /// </summary>
        [Fact]
        public void ClearAlarmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //var response = instance.ClearAlarm(service, stage, alarmUuid);
            //Assert.IsType<AlarmResponse>(response);
        }

        /// <summary>
        /// Test GetService
        /// </summary>
        [Fact]
        public void GetServiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //bool? heartbeats = null;
            //int? heartbeatLimit = null;
            //bool? alarms = null;
            //int? alarmLimit = null;
            //string stage = null;
            //var response = instance.GetService(service, heartbeats, heartbeatLimit, alarms, alarmLimit, stage);
            //Assert.IsType<ServiceResponse>(response);
        }

        /// <summary>
        /// Test GetServiceAlarm
        /// </summary>
        [Fact]
        public void GetServiceAlarmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //var response = instance.GetServiceAlarm(service, stage, alarmUuid);
            //Assert.IsType<AlarmResponse>(response);
        }

        /// <summary>
        /// Test GetServiceAlarms
        /// </summary>
        [Fact]
        public void GetServiceAlarmsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //int? history = null;
            //bool? includeTerminated = null;
            //bool? includeCleared = null;
            //var response = instance.GetServiceAlarms(service, stage, history, includeTerminated, includeCleared);
            //Assert.IsType<List<AlarmResponse>>(response);
        }

        /// <summary>
        /// Test GetServiceHeartbeat
        /// </summary>
        [Fact]
        public void GetServiceHeartbeatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //int? history = null;
            //var response = instance.GetServiceHeartbeat(service, stage, history);
            //Assert.IsType<List<HeartbeatResponse>>(response);
        }

        /// <summary>
        /// Test GetServiceKpis
        /// </summary>
        [Fact]
        public void GetServiceKpisTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //int? history = null;
            //var response = instance.GetServiceKpis(service, history);
            //Assert.IsType<List<KpiResponse>>(response);
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
            //var response = instance.GetServiceSpec(service, spec);
            //Assert.IsType<GetServiceSpecResponse>(response);
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
            //Assert.IsType<GetServiceSpecsResponse>(response);
        }

        /// <summary>
        /// Test GetServiceVitals
        /// </summary>
        [Fact]
        public void GetServiceVitalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //int? history = null;
            //var response = instance.GetServiceVitals(service, stage, history);
            //Assert.IsType<List<StatsVitalsResponse>>(response);
        }

        /// <summary>
        /// Test GetServices
        /// </summary>
        [Fact]
        public void GetServicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? heartbeats = null;
            //int? heartbeatLimit = null;
            //bool? alarms = null;
            //int? alarmLimit = null;
            //bool? includeHidden = null;
            //string stage = null;
            //string key = null;
            //var response = instance.GetServices(heartbeats, heartbeatLimit, alarms, alarmLimit, includeHidden, stage, key);
            //Assert.IsType<List<ServiceResponse>>(response);
        }

        /// <summary>
        /// Test GetServicesWithSpecs
        /// </summary>
        [Fact]
        public void GetServicesWithSpecsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetServicesWithSpecs();
            //Assert.IsType<GetServiceServiceWithSpecsResponse>(response);
        }

        /// <summary>
        /// Test HideService
        /// </summary>
        [Fact]
        public void HideServiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //var response = instance.HideService(service, stage);
            //Assert.IsType<ServiceMessageResponse>(response);
        }

        /// <summary>
        /// Test IgnoreAlarm
        /// </summary>
        [Fact]
        public void IgnoreAlarmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //AlarmIgnore alarmIgnore = null;
            //var response = instance.IgnoreAlarm(service, stage, alarmUuid, alarmIgnore);
            //Assert.IsType<AlarmResponse>(response);
        }

        /// <summary>
        /// Test RegisterService
        /// </summary>
        [Fact]
        public void RegisterServiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ServiceCreate serviceCreate = null;
            //var response = instance.RegisterService(serviceCreate);
            //Assert.IsType<ServiceResponse>(response);
        }

        /// <summary>
        /// Test SearchAlarms
        /// </summary>
        [Fact]
        public void SearchAlarmsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //int? page = null;
            //int? pageSize = null;
            //string search = null;
            //string searchOn = null;
            //string sortOn = null;
            //bool? sortDesc = null;
            //var response = instance.SearchAlarms(service, page, pageSize, search, searchOn, sortOn, sortDesc);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test ShowService
        /// </summary>
        [Fact]
        public void ShowServiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //var response = instance.ShowService(service, stage);
            //Assert.IsType<ServiceMessageResponse>(response);
        }

        /// <summary>
        /// Test TerminateAlarm
        /// </summary>
        [Fact]
        public void TerminateAlarmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //string alarmUuid = null;
            //AlarmTerminate alarmTerminate = null;
            //var response = instance.TerminateAlarm(service, stage, alarmUuid, alarmTerminate);
            //Assert.IsType<AlarmResponse>(response);
        }

        /// <summary>
        /// Test TriggerAlarm
        /// </summary>
        [Fact]
        public void TriggerAlarmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string service = null;
            //string stage = null;
            //AlarmCreate alarmCreate = null;
            //var response = instance.TriggerAlarm(service, stage, alarmCreate);
            //Assert.IsType<AlarmResponse>(response);
        }
    }
}
