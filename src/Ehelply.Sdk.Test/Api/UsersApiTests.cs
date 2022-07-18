/*
 * eHelply SDK - 1.1.87
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.87
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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersApi
            //Assert.IsType<UsersApi>(instance);
        }

        /// <summary>
        /// Test ConfirmSignup
        /// </summary>
        [Fact]
        public void ConfirmSignupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserConfirmation userConfirmation = null;
            //var response = instance.ConfirmSignup(userConfirmation);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test CreateParticipant
        /// </summary>
        [Fact]
        public void CreateParticipantTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ParticipantCreate participantCreate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateParticipant(participantCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ParticipantUserReturn>(response);
        }

        /// <summary>
        /// Test CreateUser
        /// </summary>
        [Fact]
        public void CreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //var response = instance.CreateUser(authorization);
            //Assert.IsType<UserResponse>(response);
        }

        /// <summary>
        /// Test DeleteParticipant
        /// </summary>
        [Fact]
        public void DeleteParticipantTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string participantId = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteParticipant(participantId, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Fact]
        public void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteUser(userId, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test GetParticipant
        /// </summary>
        [Fact]
        public void GetParticipantTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string participantId = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetParticipant(participantId, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ParticipantUserReturn>(response);
        }

        /// <summary>
        /// Test GetUser
        /// </summary>
        [Fact]
        public void GetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string idType = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetUser(userId, idType, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<UserResponse>(response);
        }

        /// <summary>
        /// Test Login
        /// </summary>
        [Fact]
        public void LoginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserLogin userLogin = null;
            //var response = instance.Login(userLogin);
            //Assert.IsType<UserLoginReturn>(response);
        }

        /// <summary>
        /// Test RefreshToken
        /// </summary>
        [Fact]
        public void RefreshTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string appClient = null;
            //string body = null;
            //var response = instance.RefreshToken(appClient, body);
            //Assert.IsType<UserTokenReturn>(response);
        }

        /// <summary>
        /// Test ResetPassword
        /// </summary>
        [Fact]
        public void ResetPasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserPasswordReset userPasswordReset = null;
            //var response = instance.ResetPassword(userPasswordReset);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ResetPasswordConfirmation
        /// </summary>
        [Fact]
        public void ResetPasswordConfirmationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserPasswordResetConfirmation userPasswordResetConfirmation = null;
            //var response = instance.ResetPasswordConfirmation(userPasswordResetConfirmation);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SearchParticipants
        /// </summary>
        [Fact]
        public void SearchParticipantsTest()
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
            //var response = instance.SearchParticipants(page, pageSize, search, searchOn, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test Signup
        /// </summary>
        [Fact]
        public void SignupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserSignup userSignup = null;
            //var response = instance.Signup(userSignup);
            //Assert.IsType<UserSignupReturn>(response);
        }

        /// <summary>
        /// Test UpdateParticipant
        /// </summary>
        [Fact]
        public void UpdateParticipantTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string participantId = null;
            //ParticipantUpdate participantUpdate = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateParticipant(participantId, participantUpdate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<ParticipantUserReturn>(response);
        }

        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Fact]
        public void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //User user = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateUser(userId, user, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<UserResponse>(response);
        }

        /// <summary>
        /// Test UserValidations
        /// </summary>
        [Fact]
        public void UserValidationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string field = null;
            //UserValidations userValidations = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UserValidations(field, userValidations, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<bool>(response);
        }
    }
}
