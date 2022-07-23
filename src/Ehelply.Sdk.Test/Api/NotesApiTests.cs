/*
 * eHelply SDK - 1.1.98
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.98
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
    ///  Class for testing NotesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class NotesApiTests : IDisposable
    {
        private NotesApi instance;

        public NotesApiTests()
        {
            instance = new NotesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of NotesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' NotesApi
            //Assert.IsType<NotesApi>(instance);
        }

        /// <summary>
        /// Test CreateNote
        /// </summary>
        [Fact]
        public void CreateNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NoteBase noteBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreateNote(noteBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<NoteDynamoResponse>(response);
        }

        /// <summary>
        /// Test DeleteNote
        /// </summary>
        [Fact]
        public void DeleteNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string noteId = null;
            //string method = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeleteNote(noteId, method, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetNote
        /// </summary>
        [Fact]
        public void GetNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string noteId = null;
            //int? history = null;
            //bool? historyContent = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetNote(noteId, history, historyContent, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<NoteDynamoHistoryResponse>(response);
        }

        /// <summary>
        /// Test UpdateNote
        /// </summary>
        [Fact]
        public void UpdateNoteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string noteId = null;
            //NoteBase noteBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdateNote(noteId, noteBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<NoteDynamoResponse>(response);
        }
    }
}
