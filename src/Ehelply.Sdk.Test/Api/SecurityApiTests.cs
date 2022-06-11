/*
 * eHelply SDK - 1.1.75
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.75
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
    ///  Class for testing SecurityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SecurityApiTests : IDisposable
    {
        private SecurityApi instance;

        public SecurityApiTests()
        {
            instance = new SecurityApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SecurityApi
            //Assert.IsType<SecurityApi>(instance);
        }

        /// <summary>
        /// Test CreateEncryptionKey
        /// </summary>
        [Fact]
        public void CreateEncryptionKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //string ehelplySecuritySecretKey = null;
            //var response = instance.CreateEncryptionKey(category, ehelplySecuritySecretKey);
            //Assert.IsType<SecurityEncryptionKeyResponse>(response);
        }

        /// <summary>
        /// Test CreateKey
        /// </summary>
        [Fact]
        public void CreateKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SecurityKeyCreate securityKeyCreate = null;
            //int? accessLength = null;
            //int? secretLength = null;
            //var response = instance.CreateKey(securityKeyCreate, accessLength, secretLength);
            //Assert.IsType<ResponseCreatekey>(response);
        }

        /// <summary>
        /// Test DeleteKey
        /// </summary>
        [Fact]
        public void DeleteKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keyUuid = null;
            //var response = instance.DeleteKey(keyUuid);
            //Assert.IsType<ResponseDeletekey>(response);
        }

        /// <summary>
        /// Test GenerateToken
        /// </summary>
        [Fact]
        public void GenerateTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SecurityCreateToken securityCreateToken = null;
            //var response = instance.GenerateToken(securityCreateToken);
            //Assert.IsType<ResponseGeneratetoken>(response);
        }

        /// <summary>
        /// Test GetEncryptionKey
        /// </summary>
        [Fact]
        public void GetEncryptionKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //string ehelplySecuritySecretKey = null;
            //var response = instance.GetEncryptionKey(category, ehelplySecuritySecretKey);
            //Assert.IsType<List<SecurityEncryptionKeyGet>>(response);
        }

        /// <summary>
        /// Test GetKey
        /// </summary>
        [Fact]
        public void GetKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keyUuid = null;
            //var response = instance.GetKey(keyUuid);
            //Assert.IsType<SecurityKeyGet>(response);
        }

        /// <summary>
        /// Test SearchKeys
        /// </summary>
        [Fact]
        public void SearchKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SearchKeys();
            //Assert.IsType<List<SecurityKeyGet>>(response);
        }

        /// <summary>
        /// Test VerifyKey
        /// </summary>
        [Fact]
        public void VerifyKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SecurityKeyVerify securityKeyVerify = null;
            //var response = instance.VerifyKey(securityKeyVerify);
            //Assert.IsType<SecurityKeyGet>(response);
        }
    }
}
