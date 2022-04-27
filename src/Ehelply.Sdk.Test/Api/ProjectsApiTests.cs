/*
 * eHelply SDK - 1.1.59
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.59
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
    ///  Class for testing ProjectsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectsApiTests : IDisposable
    {
        private ProjectsApi instance;

        public ProjectsApiTests()
        {
            instance = new ProjectsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProjectsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProjectsApi
            //Assert.IsType<ProjectsApi>(instance);
        }

        /// <summary>
        /// Test AddMemberToProjectProjectsProjectsProjectUuidMembersEntityUuidPost
        /// </summary>
        [Fact]
        public void AddMemberToProjectProjectsProjectsProjectUuidMembersEntityUuidPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string entityUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.AddMemberToProjectProjectsProjectsProjectUuidMembersEntityUuidPost(projectUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ArchiveProjectProjectsProjectsProjectUuidDelete
        /// </summary>
        [Fact]
        public void ArchiveProjectProjectsProjectsProjectUuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.ArchiveProjectProjectsProjectsProjectUuidDelete(projectUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test CreateProjectKeyProjectsProjectsProjectUuidKeysPost
        /// </summary>
        [Fact]
        public void CreateProjectKeyProjectsProjectsProjectUuidKeysPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //SecurityKeyCreate securityKeyCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateProjectKeyProjectsProjectsProjectUuidKeysPost(projectUuid, securityKeyCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CreateKeyResponse>(response);
        }

        /// <summary>
        /// Test CreateProjectProjectsProjectsPost
        /// </summary>
        [Fact]
        public void CreateProjectProjectsProjectsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProjectsProjectCreate projectsProjectCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateProjectProjectsProjectsPost(projectsProjectCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test CreateUsageTypeProjectsUsageTypesPost
        /// </summary>
        [Fact]
        public void CreateUsageTypeProjectsUsageTypesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProjectsUsageTypeCreate projectsUsageTypeCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateUsageTypeProjectsUsageTypesPost(projectsUsageTypeCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProjectsUsageTypeDB>(response);
        }

        /// <summary>
        /// Test DeleteUsageTypeProjectsUsageTypesUsageTypeKeyDelete
        /// </summary>
        [Fact]
        public void DeleteUsageTypeProjectsUsageTypesUsageTypeKeyDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string usageTypeKey = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteUsageTypeProjectsUsageTypesUsageTypeKeyDelete(usageTypeKey, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetAllProjectUsageProjectsProjectsProjectUuidUsageGet
        /// </summary>
        [Fact]
        public void GetAllProjectUsageProjectsProjectsProjectUuidUsageGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //int? year = null;
            //int? month = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetAllProjectUsageProjectsProjectsProjectUuidUsageGet(projectUuid, year, month, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<ProjectsProjectUsageDB>>(response);
        }

        /// <summary>
        /// Test GetMemberProjectsProjectsMembersEntityUuidProjectsGet
        /// </summary>
        [Fact]
        public void GetMemberProjectsProjectsMembersEntityUuidProjectsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string entityUuid = null;
            //string role = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetMemberProjectsProjectsMembersEntityUuidProjectsGet(entityUuid, role, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<ProjectsProjectGet>>(response);
        }

        /// <summary>
        /// Test GetProjectKeysProjectsProjectsProjectUuidKeysGet
        /// </summary>
        [Fact]
        public void GetProjectKeysProjectsProjectsProjectUuidKeysGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetProjectKeysProjectsProjectsProjectUuidKeysGet(projectUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<ProjectsProjectMemberDB>>(response);
        }

        /// <summary>
        /// Test GetProjectMembersProjectsProjectsProjectUuidMembersGet
        /// </summary>
        [Fact]
        public void GetProjectMembersProjectsProjectsProjectUuidMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string role = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetProjectMembersProjectsProjectsProjectUuidMembersGet(projectUuid, role, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<ProjectsProjectMemberDB>>(response);
        }

        /// <summary>
        /// Test GetProjectProjectsProjectsProjectUuidGet
        /// </summary>
        [Fact]
        public void GetProjectProjectsProjectsProjectUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetProjectProjectsProjectsProjectUuidGet(projectUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetSpecificProjectUsageProjectsProjectsProjectUuidUsageUsageTypeKeyGet
        /// </summary>
        [Fact]
        public void GetSpecificProjectUsageProjectsProjectsProjectUuidUsageUsageTypeKeyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string usageTypeKey = null;
            //string projectUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetSpecificProjectUsageProjectsProjectsProjectUuidUsageUsageTypeKeyGet(usageTypeKey, projectUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProjectsProjectUsageDB>(response);
        }

        /// <summary>
        /// Test GetUsageTypeProjectsUsageTypesUsageTypeKeyGet
        /// </summary>
        [Fact]
        public void GetUsageTypeProjectsUsageTypesUsageTypeKeyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string usageTypeKey = null;
            //var response = instance.GetUsageTypeProjectsUsageTypesUsageTypeKeyGet(usageTypeKey);
            //Assert.IsType<ProjectsUsageTypeGet>(response);
        }

        /// <summary>
        /// Test RemoveMemberFromProjectProjectsProjectsProjectUuidMembersEntityUuidDelete
        /// </summary>
        [Fact]
        public void RemoveMemberFromProjectProjectsProjectsProjectUuidMembersEntityUuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string entityUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.RemoveMemberFromProjectProjectsProjectsProjectUuidMembersEntityUuidDelete(projectUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test RemoveProjectKeyProjectsProjectsProjectUuidKeysDelete
        /// </summary>
        [Fact]
        public void RemoveProjectKeyProjectsProjectsProjectUuidKeysDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string accessToken = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.RemoveProjectKeyProjectsProjectsProjectUuidKeysDelete(projectUuid, accessToken, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SandboxProjectsSandboxGet
        /// </summary>
        [Fact]
        public void SandboxProjectsSandboxGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.SandboxProjectsSandboxGet(xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SearchProjectsProjectsProjectsGet
        /// </summary>
        [Fact]
        public void SearchProjectsProjectsProjectsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? pageSize = null;
            //string search = null;
            //string searchOn = null;
            //string sortOn = null;
            //bool? sortDesc = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.SearchProjectsProjectsProjectsGet(page, pageSize, search, searchOn, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test SearchUsageTypeProjectsUsageTypesGet
        /// </summary>
        [Fact]
        public void SearchUsageTypeProjectsUsageTypesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? pageSize = null;
            //string search = null;
            //string searchOn = null;
            //string sortOn = null;
            //bool? sortDesc = null;
            //var response = instance.SearchUsageTypeProjectsUsageTypesGet(page, pageSize, search, searchOn, sortOn, sortDesc);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateProjectProjectsProjectsProjectUuidPut
        /// </summary>
        [Fact]
        public void UpdateProjectProjectsProjectsProjectUuidPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //ProjectsProjectUpdate projectsProjectUpdate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateProjectProjectsProjectsProjectUuidPut(projectUuid, projectsProjectUpdate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateUsageTypeProjectsUsageTypesUsageTypeKeyPut
        /// </summary>
        [Fact]
        public void UpdateUsageTypeProjectsUsageTypesUsageTypeKeyPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string usageTypeKey = null;
            //ProjectsUsageTypeUpdate projectsUsageTypeUpdate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateUsageTypeProjectsUsageTypesUsageTypeKeyPut(usageTypeKey, projectsUsageTypeUpdate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProjectsUsageTypeDB>(response);
        }
    }
}
