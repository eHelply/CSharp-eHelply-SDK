/*
 * eHelply SDK - 1.1.107
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.107
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
    ///  Class for testing BillingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BillingApiTests : IDisposable
    {
        private BillingApi instance;

        public BillingApiTests()
        {
            instance = new BillingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BillingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BillingApi
            //Assert.IsType<BillingApi>(instance);
        }

        /// <summary>
        /// Test CreateBillingAccount
        /// </summary>
        [Fact]
        public void CreateBillingAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateBillingAccount(xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<StripeAccountResponse>(response);
        }

        /// <summary>
        /// Test GetClientSecret
        /// </summary>
        [Fact]
        public void GetClientSecretTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetClientSecret(xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<StripeCustomerSecretResponse>(response);
        }

        /// <summary>
        /// Test HasPayment
        /// </summary>
        [Fact]
        public void HasPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.HasPayment(xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test ListPaymentMethods
        /// </summary>
        [Fact]
        public void ListPaymentMethodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.ListPaymentMethods(xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<List<PaymentMethodResponse>>(response);
        }

        /// <summary>
        /// Test ProcessPayment
        /// </summary>
        [Fact]
        public void ProcessPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Payment payment = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.ProcessPayment(payment, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test ReconcilePaymentMethod
        /// </summary>
        [Fact]
        public void ReconcilePaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.ReconcilePaymentMethod(xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test RemovePaymentMethod
        /// </summary>
        [Fact]
        public void RemovePaymentMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.RemovePaymentMethod(xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<string>(response);
        }
    }
}
