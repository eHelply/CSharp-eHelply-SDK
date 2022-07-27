# Ehelply.Sdk.Api.PlacesApi

All URIs are relative to *https://api.prod.ehelply.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AdvancedSearchPlaces**](PlacesApi.md#advancedsearchplaces) | **GET** /places/search/places/string | Advancedsearchplaces |
| [**CreatePlacePlacesPlacesPost**](PlacesApi.md#createplaceplacesplacespost) | **POST** /places/places | Create Place |
| [**DeletePlace**](PlacesApi.md#deleteplace) | **DELETE** /places/places/{place_uuid} | Deleteplace |
| [**ForwardGeocodingPlacesGeocodingForwardGet**](PlacesApi.md#forwardgeocodingplacesgeocodingforwardget) | **GET** /places/geocoding/forward | Forward Geocoding |
| [**GetPlace**](PlacesApi.md#getplace) | **GET** /places/places/{place_uuid} | Getplace |
| [**ReverseGeocodingPlacesGeocodingReverseGet**](PlacesApi.md#reversegeocodingplacesgeocodingreverseget) | **GET** /places/geocoding/reverse | Reverse Geocoding |
| [**SearchPlaces**](PlacesApi.md#searchplaces) | **GET** /places/places | Searchplaces |
| [**UpdatePlace**](PlacesApi.md#updateplace) | **PUT** /places/places/{place_uuid} | Updateplace |

<a name="advancedsearchplaces"></a>
# **AdvancedSearchPlaces**
> Page AdvancedSearchPlaces (string searchString = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Advancedsearchplaces

Search places by a search string

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AdvancedSearchPlacesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var searchString = "\"\"";  // string |  (optional)  (default to "")
            var page = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 25;  // int? |  (optional)  (default to 25)
            var sortOn = "sortOn_example";  // string |  (optional) 
            var sortDesc = false;  // bool? |  (optional)  (default to false)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Advancedsearchplaces
                Page result = apiInstance.AdvancedSearchPlaces(searchString, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.AdvancedSearchPlaces: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AdvancedSearchPlacesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Advancedsearchplaces
    ApiResponse<Page> response = apiInstance.AdvancedSearchPlacesWithHttpInfo(searchString, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlacesApi.AdvancedSearchPlacesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchString** | **string** |  | [optional] [default to &quot;&quot;] |
| **page** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 25] |
| **sortOn** | **string** |  | [optional]  |
| **sortDesc** | **bool?** |  | [optional] [default to false] |
| **xAccessToken** | **string** |  | [optional]  |
| **xSecretToken** | **string** |  | [optional]  |
| **authorization** | **string** |  | [optional]  |
| **ehelplyActiveParticipant** | **string** |  | [optional]  |
| **ehelplyProject** | **string** |  | [optional]  |
| **ehelplyData** | **string** |  | [optional]  |

### Return type

[**Page**](Page.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Route not found - Denied by eHelply |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createplaceplacesplacespost"></a>
# **CreatePlacePlacesPlacesPost**
> PlaceResponse CreatePlacePlacesPlacesPost (PlaceBase placeBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Create Place

Creates a Place.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreatePlacePlacesPlacesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var placeBase = new PlaceBase(); // PlaceBase | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Create Place
                PlaceResponse result = apiInstance.CreatePlacePlacesPlacesPost(placeBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.CreatePlacePlacesPlacesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePlacePlacesPlacesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Place
    ApiResponse<PlaceResponse> response = apiInstance.CreatePlacePlacesPlacesPostWithHttpInfo(placeBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlacesApi.CreatePlacePlacesPlacesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **placeBase** | [**PlaceBase**](PlaceBase.md) |  |  |
| **xAccessToken** | **string** |  | [optional]  |
| **xSecretToken** | **string** |  | [optional]  |
| **authorization** | **string** |  | [optional]  |
| **ehelplyActiveParticipant** | **string** |  | [optional]  |
| **ehelplyProject** | **string** |  | [optional]  |
| **ehelplyData** | **string** |  | [optional]  |

### Return type

[**PlaceResponse**](PlaceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Route not found - Denied by eHelply |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteplace"></a>
# **DeletePlace**
> Object DeletePlace (string placeUuid, bool? softDelete = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Deleteplace

Deletes the place with the given ID and returns True if successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeletePlaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var placeUuid = "placeUuid_example";  // string | 
            var softDelete = true;  // bool? |  (optional)  (default to true)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Deleteplace
                Object result = apiInstance.DeletePlace(placeUuid, softDelete, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.DeletePlace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePlaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deleteplace
    ApiResponse<Object> response = apiInstance.DeletePlaceWithHttpInfo(placeUuid, softDelete, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlacesApi.DeletePlaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **placeUuid** | **string** |  |  |
| **softDelete** | **bool?** |  | [optional] [default to true] |
| **xAccessToken** | **string** |  | [optional]  |
| **xSecretToken** | **string** |  | [optional]  |
| **authorization** | **string** |  | [optional]  |
| **ehelplyActiveParticipant** | **string** |  | [optional]  |
| **ehelplyProject** | **string** |  | [optional]  |
| **ehelplyData** | **string** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Route not found - Denied by eHelply |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="forwardgeocodingplacesgeocodingforwardget"></a>
# **ForwardGeocodingPlacesGeocodingForwardGet**
> Object ForwardGeocodingPlacesGeocodingForwardGet (string searchingPlace, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Forward Geocoding

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ForwardGeocodingPlacesGeocodingForwardGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var searchingPlace = "searchingPlace_example";  // string | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Forward Geocoding
                Object result = apiInstance.ForwardGeocodingPlacesGeocodingForwardGet(searchingPlace, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.ForwardGeocodingPlacesGeocodingForwardGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ForwardGeocodingPlacesGeocodingForwardGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Forward Geocoding
    ApiResponse<Object> response = apiInstance.ForwardGeocodingPlacesGeocodingForwardGetWithHttpInfo(searchingPlace, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlacesApi.ForwardGeocodingPlacesGeocodingForwardGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchingPlace** | **string** |  |  |
| **xAccessToken** | **string** |  | [optional]  |
| **xSecretToken** | **string** |  | [optional]  |
| **authorization** | **string** |  | [optional]  |
| **ehelplyActiveParticipant** | **string** |  | [optional]  |
| **ehelplyProject** | **string** |  | [optional]  |
| **ehelplyData** | **string** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Route not found - Denied by eHelply |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplace"></a>
# **GetPlace**
> PlaceResponse GetPlace (string placeUuid, bool? withMeta = null, bool? withCatalog = null, bool? withReviews = null, bool? withSchedule = null, bool? withCollection = null, bool? withBlog = null, bool? withTags = null, bool? withCategories = null, bool? withCompany = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Getplace

Gets the place information given the Place ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetPlaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var placeUuid = "placeUuid_example";  // string | 
            var withMeta = false;  // bool? |  (optional)  (default to false)
            var withCatalog = false;  // bool? |  (optional)  (default to false)
            var withReviews = false;  // bool? |  (optional)  (default to false)
            var withSchedule = false;  // bool? |  (optional)  (default to false)
            var withCollection = false;  // bool? |  (optional)  (default to false)
            var withBlog = false;  // bool? |  (optional)  (default to false)
            var withTags = false;  // bool? |  (optional)  (default to false)
            var withCategories = false;  // bool? |  (optional)  (default to false)
            var withCompany = false;  // bool? |  (optional)  (default to false)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Getplace
                PlaceResponse result = apiInstance.GetPlace(placeUuid, withMeta, withCatalog, withReviews, withSchedule, withCollection, withBlog, withTags, withCategories, withCompany, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.GetPlace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Getplace
    ApiResponse<PlaceResponse> response = apiInstance.GetPlaceWithHttpInfo(placeUuid, withMeta, withCatalog, withReviews, withSchedule, withCollection, withBlog, withTags, withCategories, withCompany, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlacesApi.GetPlaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **placeUuid** | **string** |  |  |
| **withMeta** | **bool?** |  | [optional] [default to false] |
| **withCatalog** | **bool?** |  | [optional] [default to false] |
| **withReviews** | **bool?** |  | [optional] [default to false] |
| **withSchedule** | **bool?** |  | [optional] [default to false] |
| **withCollection** | **bool?** |  | [optional] [default to false] |
| **withBlog** | **bool?** |  | [optional] [default to false] |
| **withTags** | **bool?** |  | [optional] [default to false] |
| **withCategories** | **bool?** |  | [optional] [default to false] |
| **withCompany** | **bool?** |  | [optional] [default to false] |
| **xAccessToken** | **string** |  | [optional]  |
| **xSecretToken** | **string** |  | [optional]  |
| **authorization** | **string** |  | [optional]  |
| **ehelplyActiveParticipant** | **string** |  | [optional]  |
| **ehelplyProject** | **string** |  | [optional]  |
| **ehelplyData** | **string** |  | [optional]  |

### Return type

[**PlaceResponse**](PlaceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Route not found - Denied by eHelply |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reversegeocodingplacesgeocodingreverseget"></a>
# **ReverseGeocodingPlacesGeocodingReverseGet**
> Object ReverseGeocodingPlacesGeocodingReverseGet (decimal _long, decimal lat, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Reverse Geocoding

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ReverseGeocodingPlacesGeocodingReverseGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var _long = 8.14D;  // decimal | 
            var lat = 8.14D;  // decimal | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Reverse Geocoding
                Object result = apiInstance.ReverseGeocodingPlacesGeocodingReverseGet(_long, lat, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.ReverseGeocodingPlacesGeocodingReverseGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReverseGeocodingPlacesGeocodingReverseGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reverse Geocoding
    ApiResponse<Object> response = apiInstance.ReverseGeocodingPlacesGeocodingReverseGetWithHttpInfo(_long, lat, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlacesApi.ReverseGeocodingPlacesGeocodingReverseGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **_long** | **decimal** |  |  |
| **lat** | **decimal** |  |  |
| **xAccessToken** | **string** |  | [optional]  |
| **xSecretToken** | **string** |  | [optional]  |
| **authorization** | **string** |  | [optional]  |
| **ehelplyActiveParticipant** | **string** |  | [optional]  |
| **ehelplyProject** | **string** |  | [optional]  |
| **ehelplyData** | **string** |  | [optional]  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Route not found - Denied by eHelply |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchplaces"></a>
# **SearchPlaces**
> Page SearchPlaces (string projectUuid = null, string name = null, string addressLine1 = null, string addressLine2 = null, string city = null, string provinceState = null, string country = null, string postalZipCode = null, string lat = null, string lng = null, string email = null, bool? isPublic = null, bool? isDeleted = null, bool? withCompany = null, bool? withMeta = null, bool? withCatalog = null, bool? withReviews = null, bool? withSchedule = null, bool? withCollection = null, bool? withBlog = null, bool? withTags = null, bool? withCategories = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Searchplaces

Search all places and returns paginated results with Places being stored in items field. Can search by `project_uuid, name, address, address_line_2, city, province_state, country, postal_zip_code, lat, lng email` string fields or the `is_public and is_deleted` boolean fields. To search with these fields use query params with string values. For sorting fill out \"sort_desc\" field with either true/false and the \"sort_on\" query parameter with column you want to sort on (ex: name). Max pagination items per page is 50. Item return format: ``` {     uuid                                **type:** string     project_uuid                        **type:** string or None      meta_uuid                           **type:** string or None      catalog_data                        **type:** dict or None      review_group_data                   **type:** dict or None      schedule_data                       **type:** dict or None      collection_data                     **type:** dict or None      blog_data                           **type:** dict or None      tags                                **type:** [TagBase] or None      categories                          **type:** [CategoryBase] or None      company                             **type:** CompanyBase or None      created_at                          **type:** string or None      updated_at                          **type:** string or None      deleted_at                          **type:** string or None  } ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchPlacesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var projectUuid = "projectUuid_example";  // string |  (optional) 
            var name = "name_example";  // string |  (optional) 
            var addressLine1 = "addressLine1_example";  // string |  (optional) 
            var addressLine2 = "addressLine2_example";  // string |  (optional) 
            var city = "city_example";  // string |  (optional) 
            var provinceState = "provinceState_example";  // string |  (optional) 
            var country = "country_example";  // string |  (optional) 
            var postalZipCode = "postalZipCode_example";  // string |  (optional) 
            var lat = "lat_example";  // string |  (optional) 
            var lng = "lng_example";  // string |  (optional) 
            var email = "email_example";  // string |  (optional) 
            var isPublic = true;  // bool? |  (optional)  (default to true)
            var isDeleted = false;  // bool? |  (optional)  (default to false)
            var withCompany = false;  // bool? |  (optional)  (default to false)
            var withMeta = false;  // bool? |  (optional)  (default to false)
            var withCatalog = false;  // bool? |  (optional)  (default to false)
            var withReviews = false;  // bool? |  (optional)  (default to false)
            var withSchedule = false;  // bool? |  (optional)  (default to false)
            var withCollection = false;  // bool? |  (optional)  (default to false)
            var withBlog = false;  // bool? |  (optional)  (default to false)
            var withTags = false;  // bool? |  (optional)  (default to false)
            var withCategories = false;  // bool? |  (optional)  (default to false)
            var page = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 25;  // int? |  (optional)  (default to 25)
            var sortOn = "sortOn_example";  // string |  (optional) 
            var sortDesc = false;  // bool? |  (optional)  (default to false)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Searchplaces
                Page result = apiInstance.SearchPlaces(projectUuid, name, addressLine1, addressLine2, city, provinceState, country, postalZipCode, lat, lng, email, isPublic, isDeleted, withCompany, withMeta, withCatalog, withReviews, withSchedule, withCollection, withBlog, withTags, withCategories, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.SearchPlaces: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchPlacesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Searchplaces
    ApiResponse<Page> response = apiInstance.SearchPlacesWithHttpInfo(projectUuid, name, addressLine1, addressLine2, city, provinceState, country, postalZipCode, lat, lng, email, isPublic, isDeleted, withCompany, withMeta, withCatalog, withReviews, withSchedule, withCollection, withBlog, withTags, withCategories, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlacesApi.SearchPlacesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectUuid** | **string** |  | [optional]  |
| **name** | **string** |  | [optional]  |
| **addressLine1** | **string** |  | [optional]  |
| **addressLine2** | **string** |  | [optional]  |
| **city** | **string** |  | [optional]  |
| **provinceState** | **string** |  | [optional]  |
| **country** | **string** |  | [optional]  |
| **postalZipCode** | **string** |  | [optional]  |
| **lat** | **string** |  | [optional]  |
| **lng** | **string** |  | [optional]  |
| **email** | **string** |  | [optional]  |
| **isPublic** | **bool?** |  | [optional] [default to true] |
| **isDeleted** | **bool?** |  | [optional] [default to false] |
| **withCompany** | **bool?** |  | [optional] [default to false] |
| **withMeta** | **bool?** |  | [optional] [default to false] |
| **withCatalog** | **bool?** |  | [optional] [default to false] |
| **withReviews** | **bool?** |  | [optional] [default to false] |
| **withSchedule** | **bool?** |  | [optional] [default to false] |
| **withCollection** | **bool?** |  | [optional] [default to false] |
| **withBlog** | **bool?** |  | [optional] [default to false] |
| **withTags** | **bool?** |  | [optional] [default to false] |
| **withCategories** | **bool?** |  | [optional] [default to false] |
| **page** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 25] |
| **sortOn** | **string** |  | [optional]  |
| **sortDesc** | **bool?** |  | [optional] [default to false] |
| **xAccessToken** | **string** |  | [optional]  |
| **xSecretToken** | **string** |  | [optional]  |
| **authorization** | **string** |  | [optional]  |
| **ehelplyActiveParticipant** | **string** |  | [optional]  |
| **ehelplyProject** | **string** |  | [optional]  |
| **ehelplyData** | **string** |  | [optional]  |

### Return type

[**Page**](Page.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Route not found - Denied by eHelply |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateplace"></a>
# **UpdatePlace**
> PlaceResponse UpdatePlace (string placeUuid, PlaceBase placeBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Updateplace

Update Place with given info, only updating the fields supplied. Place Uuid must be sent however.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdatePlaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var placeUuid = "placeUuid_example";  // string | 
            var placeBase = new PlaceBase(); // PlaceBase | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Updateplace
                PlaceResponse result = apiInstance.UpdatePlace(placeUuid, placeBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.UpdatePlace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePlaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updateplace
    ApiResponse<PlaceResponse> response = apiInstance.UpdatePlaceWithHttpInfo(placeUuid, placeBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlacesApi.UpdatePlaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **placeUuid** | **string** |  |  |
| **placeBase** | [**PlaceBase**](PlaceBase.md) |  |  |
| **xAccessToken** | **string** |  | [optional]  |
| **xSecretToken** | **string** |  | [optional]  |
| **authorization** | **string** |  | [optional]  |
| **ehelplyActiveParticipant** | **string** |  | [optional]  |
| **ehelplyProject** | **string** |  | [optional]  |
| **ehelplyData** | **string** |  | [optional]  |

### Return type

[**PlaceResponse**](PlaceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Route not found - Denied by eHelply |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

