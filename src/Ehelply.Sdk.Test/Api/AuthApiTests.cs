/*
 * eHelply SDK - 1.1.47
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.47
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
    ///  Class for testing AuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthApiTests : IDisposable
    {
        private AuthApi instance;

        public AuthApiTests()
        {
            instance = new AuthApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuthApi
            //Assert.IsType<AuthApi>(instance);
        }

        /// <summary>
        /// Test ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost
        /// </summary>
        [Fact]
        public void ResetPasswordConfirmationUsersAuthPasswordResetConfirmPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserPasswordResetConfirmation userPasswordResetConfirmation = null;
            //var response = instance.ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost(userPasswordResetConfirmation);
            //Assert.IsType<Object>(response);
        }
    }
}