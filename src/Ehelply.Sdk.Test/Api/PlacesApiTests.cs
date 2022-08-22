/*
 * eHelply SDK - 1.1.103
 *
 * eHelply SDK for SuperStack Services
 *
 * The version of the OpenAPI document: 1.1.103
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
        /// Test AdvancedSearchPlaces
        /// </summary>
        [Fact]
        public void AdvancedSearchPlacesTest()
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
            //var response = instance.AdvancedSearchPlaces(searchString, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test CreatePlacePlacesPlacesPost
        /// </summary>
        [Fact]
        public void CreatePlacePlacesPlacesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PlaceBase placeBase = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.CreatePlacePlacesPlacesPost(placeBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<PlaceResponse>(response);
        }

        /// <summary>
        /// Test DeletePlace
        /// </summary>
        [Fact]
        public void DeletePlaceTest()
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
            //var response = instance.DeletePlace(placeUuid, softDelete, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ForwardGeocodingPlacesGeocodingForwardGet
        /// </summary>
        [Fact]
        public void ForwardGeocodingPlacesGeocodingForwardGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchingPlace = null;
            //string xAccessToken = null;
            //string xSecretToken = null;
            //string authorization = null;
            //string ehelplyActiveParticipant = null;
            //string ehelplyProject = null;
            //string ehelplyData = null;
            //var response = instance.ForwardGeocodingPlacesGeocodingForwardGet(searchingPlace, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetPlace
        /// </summary>
        [Fact]
        public void GetPlaceTest()
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
            //var response = instance.GetPlace(placeUuid, withMeta, withCatalog, withReviews, withSchedule, withCollection, withBlog, withTags, withCategories, withCompany, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<PlaceResponse>(response);
        }

        /// <summary>
        /// Test ReverseGeocodingPlacesGeocodingReverseGet
        /// </summary>
        [Fact]
        public void ReverseGeocodingPlacesGeocodingReverseGetTest()
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
            //var response = instance.ReverseGeocodingPlacesGeocodingReverseGet(_long, lat, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test SearchPlaces
        /// </summary>
        [Fact]
        public void SearchPlacesTest()
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
            //var response = instance.SearchPlaces(projectUuid, name, addressLine1, addressLine2, city, provinceState, country, postalZipCode, lat, lng, email, isPublic, isDeleted, withCompany, withMeta, withCatalog, withReviews, withSchedule, withCollection, withBlog, withTags, withCategories, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<Page>(response);
        }

        /// <summary>
        /// Test UpdatePlace
        /// </summary>
        [Fact]
        public void UpdatePlaceTest()
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
            //var response = instance.UpdatePlace(placeUuid, placeBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
            //Assert.IsType<PlaceResponse>(response);
        }
    }
}
