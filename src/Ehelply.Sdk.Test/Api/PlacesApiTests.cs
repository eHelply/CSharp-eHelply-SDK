/*
 * eHelply SDK - 1.1.70
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.70
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
    ///  Class for testing PlacesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PlacesApiTests : IDisposable
    {
        private PlacesApi instance;

        public PlacesApiTests()
        {
            instance = new PlacesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PlacesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PlacesApi
            //Assert.IsType<PlacesApi>(instance);
        }

        /// <summary>
        /// Test CreatePlacePlacesPost
        /// </summary>
        [Fact]
        public void CreatePlacePlacesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PlaceBase placeBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreatePlacePlacesPost(placeBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<PlaceResponse>(response);
        }

        /// <summary>
        /// Test DeletePlacePlacesPlaceUuidDelete
        /// </summary>
        [Fact]
        public void DeletePlacePlacesPlaceUuidDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string placeUuid = null;
            //bool? softDelete = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.DeletePlacePlacesPlaceUuidDelete(placeUuid, softDelete, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ForwardGeocodingPlacesForwardGeocodingGet
        /// </summary>
        [Fact]
        public void ForwardGeocodingPlacesForwardGeocodingGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchingPlace = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.ForwardGeocodingPlacesForwardGeocodingGet(searchingPlace, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetPlacePlacesPlaceUuidGet
        /// </summary>
        [Fact]
        public void GetPlacePlacesPlaceUuidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string placeUuid = null;
            //bool? withMeta = null;
            //bool? withCatalog = null;
            //bool? withReviews = null;
            //bool? withSchedule = null;
            //bool? withCollection = null;
            //bool? withBlog = null;
            //bool? withTags = null;
            //bool? withCategories = null;
            //bool? withCompany = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.GetPlacePlacesPlaceUuidGet(placeUuid, withMeta, withCatalog, withReviews, withSchedule, withCollection, withBlog, withTags, withCategories, withCompany, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<PlaceResponse>(response);
        }

        /// <summary>
        /// Test ReverseGeocodingPlacesReverseGeocodingGet
        /// </summary>
        [Fact]
        public void ReverseGeocodingPlacesReverseGeocodingGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal _long = null;
            //decimal lat = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.ReverseGeocodingPlacesReverseGeocodingGet(_long, lat, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SearchPlacesByAreaPlacesSearchLocationGet
        /// </summary>
        [Fact]
        public void SearchPlacesByAreaPlacesSearchLocationGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SearchPlacesByAreaPlacesSearchLocationGet();
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test SearchPlacesBySearchStringPlacesSearchGet
        /// </summary>
        [Fact]
        public void SearchPlacesBySearchStringPlacesSearchGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchString = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortOn = null;
            //bool? sortDesc = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.SearchPlacesBySearchStringPlacesSearchGet(searchString, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test SearchPlacesPlacesGet
        /// </summary>
        [Fact]
        public void SearchPlacesPlacesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectUuid = null;
            //string name = null;
            //string addressLine1 = null;
            //string addressLine2 = null;
            //string city = null;
            //string provinceState = null;
            //string country = null;
            //string postalZipCode = null;
            //string lat = null;
            //string lng = null;
            //string email = null;
            //bool? isPublic = null;
            //bool? isDeleted = null;
            //bool? withCompany = null;
            //bool? withMeta = null;
            //bool? withCatalog = null;
            //bool? withReviews = null;
            //bool? withSchedule = null;
            //bool? withCollection = null;
            //bool? withBlog = null;
            //bool? withTags = null;
            //bool? withCategories = null;
            //int? page = null;
            //int? pageSize = null;
            //string sortOn = null;
            //bool? sortDesc = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.SearchPlacesPlacesGet(projectUuid, name, addressLine1, addressLine2, city, provinceState, country, postalZipCode, lat, lng, email, isPublic, isDeleted, withCompany, withMeta, withCatalog, withReviews, withSchedule, withCollection, withBlog, withTags, withCategories, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdatePlacePlacesPlaceUuidPut
        /// </summary>
        [Fact]
        public void UpdatePlacePlacesPlaceUuidPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string placeUuid = null;
            //PlaceBase placeBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.UpdatePlacePlacesPlaceUuidPut(placeUuid, placeBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<PlaceResponse>(response);
        }
    }
}
