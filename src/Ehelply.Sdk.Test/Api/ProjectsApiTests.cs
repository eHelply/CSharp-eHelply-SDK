/*
 * eHelply SDK - 1.1.108
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.108
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
        /// Test AddMemberToProject
        /// </summary>
        [Fact]
        public void AddMemberToProjectTest()
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
            //var response = instance.AddMemberToProject(projectUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ResponseAddmembertoproject>(response);
        }

        /// <summary>
        /// Test ArchiveProject
        /// </summary>
        [Fact]
        public void ArchiveProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.ArchiveProject(projectUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ResponseArchiveproject>(response);
        }

        /// <summary>
        /// Test CreateProject
        /// </summary>
        [Fact]
        public void CreateProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProjectsProjectCreate projectsProjectCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateProject(projectsProjectCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProjectDB>(response);
        }

        /// <summary>
        /// Test CreateProjectCredential
        /// </summary>
        [Fact]
        public void CreateProjectCredentialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //CreateProjectCredential createProjectCredential = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateProjectCredential(projectUuid, createProjectCredential, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ResponseCreateprojectcredential>(response);
        }

        /// <summary>
        /// Test CreateProjectInvoice
        /// </summary>
        [Fact]
        public void CreateProjectInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //CreateProjectInvoice createProjectInvoice = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateProjectInvoice(projectUuid, createProjectInvoice, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ResponseCreateprojectinvoice>(response);
        }

        /// <summary>
        /// Test CreateProjectKey
        /// </summary>
        [Fact]
        public void CreateProjectKeyTest()
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
            //var response = instance.CreateProjectKey(projectUuid, securityKeyCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<CreateKeyResponse>(response);
        }

        /// <summary>
        /// Test CreateUsageType
        /// </summary>
        [Fact]
        public void CreateUsageTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProjectsUsageTypeCreate projectsUsageTypeCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateUsageType(projectsUsageTypeCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProjectsUsageTypeDB>(response);
        }

        /// <summary>
        /// Test DeleteProjectCredential
        /// </summary>
        [Fact]
        public void DeleteProjectCredentialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string serviceName = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteProjectCredential(projectUuid, serviceName, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ResponseDeleteprojectcredential>(response);
        }

        /// <summary>
        /// Test DeleteProjectKey
        /// </summary>
        [Fact]
        public void DeleteProjectKeyTest()
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
            //var response = instance.DeleteProjectKey(projectUuid, accessToken, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test DeleteUsageType
        /// </summary>
        [Fact]
        public void DeleteUsageTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string usageTypeKey = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteUsageType(usageTypeKey, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ResponseDeleteusagetype>(response);
        }

        /// <summary>
        /// Test GetAllProjectCredentials
        /// </summary>
        [Fact]
        public void GetAllProjectCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetAllProjectCredentials(projectUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<GetProjectCredential>>(response);
        }

        /// <summary>
        /// Test GetAllProjectUsage
        /// </summary>
        [Fact]
        public void GetAllProjectUsageTest()
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
            //var response = instance.GetAllProjectUsage(projectUuid, year, month, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<ProjectsProjectUsageDB>>(response);
        }

        /// <summary>
        /// Test GetMemberProjects
        /// </summary>
        [Fact]
        public void GetMemberProjectsTest()
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
            //var response = instance.GetMemberProjects(entityUuid, role, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<ProjectsProjectGet>>(response);
        }

        /// <summary>
        /// Test GetProject
        /// </summary>
        [Fact]
        public void GetProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetProject(projectUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProjectDB>(response);
        }

        /// <summary>
        /// Test GetProjectInvoice
        /// </summary>
        [Fact]
        public void GetProjectInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //bool? withInvoice = null;
            //int? year = null;
            //int? month = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetProjectInvoice(projectUuid, withInvoice, year, month, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<GetProjectInvoiceResponse>(response);
        }

        /// <summary>
        /// Test GetProjectInvoiceHistory
        /// </summary>
        [Fact]
        public void GetProjectInvoiceHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetProjectInvoiceHistory(projectUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<GetProjectInvoiceHistory>(response);
        }

        /// <summary>
        /// Test GetProjectKeys
        /// </summary>
        [Fact]
        public void GetProjectKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetProjectKeys(projectUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<ProjectsProjectMemberDB>>(response);
        }

        /// <summary>
        /// Test GetProjectMembers
        /// </summary>
        [Fact]
        public void GetProjectMembersTest()
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
            //var response = instance.GetProjectMembers(projectUuid, role, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<ProjectsProjectMemberDB>>(response);
        }

        /// <summary>
        /// Test GetSpecificProjectCredential
        /// </summary>
        [Fact]
        public void GetSpecificProjectCredentialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string serviceName = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetSpecificProjectCredential(projectUuid, serviceName, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<GetProjectCredential>(response);
        }

        /// <summary>
        /// Test GetSpecificProjectUsage
        /// </summary>
        [Fact]
        public void GetSpecificProjectUsageTest()
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
            //var response = instance.GetSpecificProjectUsage(usageTypeKey, projectUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProjectsProjectUsageDB>(response);
        }

        /// <summary>
        /// Test GetUsageType
        /// </summary>
        [Fact]
        public void GetUsageTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string usageTypeKey = null;
            //var response = instance.GetUsageType(usageTypeKey);
            //Assert.IsType<ProjectsUsageTypeGet>(response);
        }

        /// <summary>
        /// Test RemoveMemberFromProject
        /// </summary>
        [Fact]
        public void RemoveMemberFromProjectTest()
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
            //var response = instance.RemoveMemberFromProject(projectUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ResponseRemovememberfromproject>(response);
        }

        /// <summary>
        /// Test SearchProjects
        /// </summary>
        [Fact]
        public void SearchProjectsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? isActive = null;
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
            //var response = instance.SearchProjects(isActive, page, pageSize, search, searchOn, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test SearchUsageType
        /// </summary>
        [Fact]
        public void SearchUsageTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? pageSize = null;
            //string search = null;
            //string searchOn = null;
            //string sortOn = null;
            //bool? sortDesc = null;
            //var response = instance.SearchUsageType(page, pageSize, search, searchOn, sortOn, sortDesc);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdateProject
        /// </summary>
        [Fact]
        public void UpdateProjectTest()
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
            //var response = instance.UpdateProject(projectUuid, projectsProjectUpdate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateProjectCredential
        /// </summary>
        [Fact]
        public void UpdateProjectCredentialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string serviceName = null;
            //UpdateProjectCredentialRequest updateProjectCredentialRequest = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateProjectCredential(projectUuid, serviceName, updateProjectCredentialRequest, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ResponseUpdateprojectcredential>(response);
        }

        /// <summary>
        /// Test UpdateUsageType
        /// </summary>
        [Fact]
        public void UpdateUsageTypeTest()
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
            //var response = instance.UpdateUsageType(usageTypeKey, projectsUsageTypeUpdate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ProjectsUsageTypeDB>(response);
        }
    }
}
