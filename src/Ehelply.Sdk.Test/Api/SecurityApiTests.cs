/*
 * eHelply SDK - 1.1.58
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.58
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
        /// Test CreateEncryptionKeySecurityEncryptionCategoriesCategoryKeysPost
        /// </summary>
        [Fact]
        public void CreateEncryptionKeySecurityEncryptionCategoriesCategoryKeysPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //string ehelplySecuritySecretKey = null;
            //var response = instance.CreateEncryptionKeySecurityEncryptionCategoriesCategoryKeysPost(category, ehelplySecuritySecretKey);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test CreateKeySecurityKeysPost
        /// </summary>
        [Fact]
        public void CreateKeySecurityKeysPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BodyCreateKeySecurityKeysPost bodyCreateKeySecurityKeysPost = null;
            //int? accessLength = null;
            //int? secretLength = null;
            //var response = instance.CreateKeySecurityKeysPost(bodyCreateKeySecurityKeysPost, accessLength, secretLength);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test DeleteKeySecurityKeysKeyUuidDelete
        /// </summary>
        [Fact]
        public void DeleteKeySecurityKeysKeyUuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keyUuid = null;
            //var response = instance.DeleteKeySecurityKeysKeyUuidDelete(keyUuid);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GenerateTokenSecurityTokensPost
        /// </summary>
        [Fact]
        public void GenerateTokenSecurityTokensPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BodyGenerateTokenSecurityTokensPost bodyGenerateTokenSecurityTokensPost = null;
            //var response = instance.GenerateTokenSecurityTokensPost(bodyGenerateTokenSecurityTokensPost);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetEncryptionKeySecurityEncryptionCategoriesCategoryKeysGet
        /// </summary>
        [Fact]
        public void GetEncryptionKeySecurityEncryptionCategoriesCategoryKeysGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //string ehelplySecuritySecretKey = null;
            //var response = instance.GetEncryptionKeySecurityEncryptionCategoriesCategoryKeysGet(category, ehelplySecuritySecretKey);
            //Assert.IsType<List<SecurityEncryptionKeyGet>>(response);
        }

        /// <summary>
        /// Test GetKeySecurityKeysKeyUuidGet
        /// </summary>
        [Fact]
        public void GetKeySecurityKeysKeyUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keyUuid = null;
            //var response = instance.GetKeySecurityKeysKeyUuidGet(keyUuid);
            //Assert.IsType<SecurityKeyGet>(response);
        }

        /// <summary>
        /// Test SearchKeysSecurityKeysGet
        /// </summary>
        [Fact]
        public void SearchKeysSecurityKeysGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SearchKeysSecurityKeysGet();
            //Assert.IsType<List<SecurityKeyGet>>(response);
        }

        /// <summary>
        /// Test VerifyKeySecurityKeysVerifyPost
        /// </summary>
        [Fact]
        public void VerifyKeySecurityKeysVerifyPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BodyVerifyKeySecurityKeysVerifyPost bodyVerifyKeySecurityKeysVerifyPost = null;
            //var response = instance.VerifyKeySecurityKeysVerifyPost(bodyVerifyKeySecurityKeysVerifyPost);
            //Assert.IsType<SecurityKeyGet>(response);
        }
    }
}
