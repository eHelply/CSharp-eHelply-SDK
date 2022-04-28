# Ehelply.Sdk.Api.PlacesApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePlacePlacesPost**](PlacesApi.md#createplaceplacespost) | **POST** /places | Create Place
[**DeletePlacePlacesPlaceUuidDelete**](PlacesApi.md#deleteplaceplacesplaceuuiddelete) | **DELETE** /places/{place_uuid} | Delete Place
[**ForwardGeocodingPlacesForwardGeocodingGet**](PlacesApi.md#forwardgeocodingplacesforwardgeocodingget) | **GET** /places/forward_geocoding | Forward Geocoding
[**GetPlacePlacesPlaceUuidGet**](PlacesApi.md#getplaceplacesplaceuuidget) | **GET** /places/{place_uuid} | Get Place
[**ReverseGeocodingPlacesReverseGeocodingGet**](PlacesApi.md#reversegeocodingplacesreversegeocodingget) | **GET** /places/reverse_geocoding | Reverse Geocoding
[**SearchPlacesByAreaPlacesSearchLocationGet**](PlacesApi.md#searchplacesbyareaplacessearchlocationget) | **GET** /places/search/location | Search Places By Area
[**SearchPlacesBySearchStringPlacesSearchGet**](PlacesApi.md#searchplacesbysearchstringplacessearchget) | **GET** /places/search | Search Places By Search String
[**SearchPlacesPlacesGet**](PlacesApi.md#searchplacesplacesget) | **GET** /places | Search Places
[**UpdatePlacePlacesPlaceUuidPut**](PlacesApi.md#updateplaceplacesplaceuuidput) | **PUT** /places/{place_uuid} | Update Place


<a name="createplaceplacespost"></a>
# **CreatePlacePlacesPost**
> PlaceResponse CreatePlacePlacesPost (PlaceBase placeBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

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
    public class CreatePlacePlacesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var placeBase = new PlaceBase(); // PlaceBase | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Create Place
                PlaceResponse result = apiInstance.CreatePlacePlacesPost(placeBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.CreatePlacePlacesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **placeBase** | [**PlaceBase**](PlaceBase.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

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

<a name="deleteplaceplacesplaceuuiddelete"></a>
# **DeletePlacePlacesPlaceUuidDelete**
> Object DeletePlacePlacesPlaceUuidDelete (string placeUuid, bool? softDelete = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Delete Place

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
    public class DeletePlacePlacesPlaceUuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var placeUuid = placeUuid_example;  // string | 
            var softDelete = true;  // bool? |  (optional)  (default to true)
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Delete Place
                Object result = apiInstance.DeletePlacePlacesPlaceUuidDelete(placeUuid, softDelete, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.DeletePlacePlacesPlaceUuidDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **placeUuid** | **string**|  | 
 **softDelete** | **bool?**|  | [optional] [default to true]
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

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

<a name="forwardgeocodingplacesforwardgeocodingget"></a>
# **ForwardGeocodingPlacesForwardGeocodingGet**
> Object ForwardGeocodingPlacesForwardGeocodingGet (string searchingPlace, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

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
    public class ForwardGeocodingPlacesForwardGeocodingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var searchingPlace = searchingPlace_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Forward Geocoding
                Object result = apiInstance.ForwardGeocodingPlacesForwardGeocodingGet(searchingPlace, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.ForwardGeocodingPlacesForwardGeocodingGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchingPlace** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

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

<a name="getplaceplacesplaceuuidget"></a>
# **GetPlacePlacesPlaceUuidGet**
> PlaceResponse GetPlacePlacesPlaceUuidGet (string placeUuid, bool? withMeta = null, bool? withCatalog = null, bool? withReviews = null, bool? withSchedule = null, bool? withCollection = null, bool? withBlog = null, bool? withTags = null, bool? withCategories = null, bool? withCompany = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Place

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
    public class GetPlacePlacesPlaceUuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var placeUuid = placeUuid_example;  // string | 
            var withMeta = true;  // bool? |  (optional)  (default to false)
            var withCatalog = true;  // bool? |  (optional)  (default to false)
            var withReviews = true;  // bool? |  (optional)  (default to false)
            var withSchedule = true;  // bool? |  (optional)  (default to false)
            var withCollection = true;  // bool? |  (optional)  (default to false)
            var withBlog = true;  // bool? |  (optional)  (default to false)
            var withTags = true;  // bool? |  (optional)  (default to false)
            var withCategories = true;  // bool? |  (optional)  (default to false)
            var withCompany = true;  // bool? |  (optional)  (default to false)
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Get Place
                PlaceResponse result = apiInstance.GetPlacePlacesPlaceUuidGet(placeUuid, withMeta, withCatalog, withReviews, withSchedule, withCollection, withBlog, withTags, withCategories, withCompany, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.GetPlacePlacesPlaceUuidGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **placeUuid** | **string**|  | 
 **withMeta** | **bool?**|  | [optional] [default to false]
 **withCatalog** | **bool?**|  | [optional] [default to false]
 **withReviews** | **bool?**|  | [optional] [default to false]
 **withSchedule** | **bool?**|  | [optional] [default to false]
 **withCollection** | **bool?**|  | [optional] [default to false]
 **withBlog** | **bool?**|  | [optional] [default to false]
 **withTags** | **bool?**|  | [optional] [default to false]
 **withCategories** | **bool?**|  | [optional] [default to false]
 **withCompany** | **bool?**|  | [optional] [default to false]
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

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

<a name="reversegeocodingplacesreversegeocodingget"></a>
# **ReverseGeocodingPlacesReverseGeocodingGet**
> Object ReverseGeocodingPlacesReverseGeocodingGet (decimal _long, decimal lat, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

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
    public class ReverseGeocodingPlacesReverseGeocodingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var _long = 8.14;  // decimal | 
            var lat = 8.14;  // decimal | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Reverse Geocoding
                Object result = apiInstance.ReverseGeocodingPlacesReverseGeocodingGet(_long, lat, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.ReverseGeocodingPlacesReverseGeocodingGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_long** | **decimal**|  | 
 **lat** | **decimal**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

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

<a name="searchplacesbyareaplacessearchlocationget"></a>
# **SearchPlacesByAreaPlacesSearchLocationGet**
> Page SearchPlacesByAreaPlacesSearchLocationGet ()

Search Places By Area

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchPlacesByAreaPlacesSearchLocationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);

            try
            {
                // Search Places By Area
                Page result = apiInstance.SearchPlacesByAreaPlacesSearchLocationGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.SearchPlacesByAreaPlacesSearchLocationGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchplacesbysearchstringplacessearchget"></a>
# **SearchPlacesBySearchStringPlacesSearchGet**
> Page SearchPlacesBySearchStringPlacesSearchGet (string searchString = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Places By Search String

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
    public class SearchPlacesBySearchStringPlacesSearchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var searchString = searchString_example;  // string |  (optional)  (default to "")
            var page = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var sortOn = sortOn_example;  // string |  (optional) 
            var sortDesc = true;  // bool? |  (optional)  (default to false)
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Search Places By Search String
                Page result = apiInstance.SearchPlacesBySearchStringPlacesSearchGet(searchString, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.SearchPlacesBySearchStringPlacesSearchGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchString** | **string**|  | [optional] [default to &quot;&quot;]
 **page** | **int?**|  | [optional] [default to 1]
 **pageSize** | **int?**|  | [optional] [default to 25]
 **sortOn** | **string**|  | [optional] 
 **sortDesc** | **bool?**|  | [optional] [default to false]
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

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

<a name="searchplacesplacesget"></a>
# **SearchPlacesPlacesGet**
> Page SearchPlacesPlacesGet (string projectUuid = null, string name = null, string addressLine1 = null, string addressLine2 = null, string city = null, string provinceState = null, string country = null, string postalZipCode = null, string lat = null, string lng = null, string email = null, bool? isPublic = null, bool? isDeleted = null, bool? withCompany = null, bool? withMeta = null, bool? withCatalog = null, bool? withReviews = null, bool? withSchedule = null, bool? withCollection = null, bool? withBlog = null, bool? withTags = null, bool? withCategories = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Places

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
    public class SearchPlacesPlacesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var projectUuid = projectUuid_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var addressLine1 = addressLine1_example;  // string |  (optional) 
            var addressLine2 = addressLine2_example;  // string |  (optional) 
            var city = city_example;  // string |  (optional) 
            var provinceState = provinceState_example;  // string |  (optional) 
            var country = country_example;  // string |  (optional) 
            var postalZipCode = postalZipCode_example;  // string |  (optional) 
            var lat = lat_example;  // string |  (optional) 
            var lng = lng_example;  // string |  (optional) 
            var email = email_example;  // string |  (optional) 
            var isPublic = true;  // bool? |  (optional)  (default to true)
            var isDeleted = true;  // bool? |  (optional)  (default to false)
            var withCompany = true;  // bool? |  (optional)  (default to false)
            var withMeta = true;  // bool? |  (optional)  (default to false)
            var withCatalog = true;  // bool? |  (optional)  (default to false)
            var withReviews = true;  // bool? |  (optional)  (default to false)
            var withSchedule = true;  // bool? |  (optional)  (default to false)
            var withCollection = true;  // bool? |  (optional)  (default to false)
            var withBlog = true;  // bool? |  (optional)  (default to false)
            var withTags = true;  // bool? |  (optional)  (default to false)
            var withCategories = true;  // bool? |  (optional)  (default to false)
            var page = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var sortOn = sortOn_example;  // string |  (optional) 
            var sortDesc = true;  // bool? |  (optional)  (default to false)
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Search Places
                Page result = apiInstance.SearchPlacesPlacesGet(projectUuid, name, addressLine1, addressLine2, city, provinceState, country, postalZipCode, lat, lng, email, isPublic, isDeleted, withCompany, withMeta, withCatalog, withReviews, withSchedule, withCollection, withBlog, withTags, withCategories, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.SearchPlacesPlacesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectUuid** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **addressLine1** | **string**|  | [optional] 
 **addressLine2** | **string**|  | [optional] 
 **city** | **string**|  | [optional] 
 **provinceState** | **string**|  | [optional] 
 **country** | **string**|  | [optional] 
 **postalZipCode** | **string**|  | [optional] 
 **lat** | **string**|  | [optional] 
 **lng** | **string**|  | [optional] 
 **email** | **string**|  | [optional] 
 **isPublic** | **bool?**|  | [optional] [default to true]
 **isDeleted** | **bool?**|  | [optional] [default to false]
 **withCompany** | **bool?**|  | [optional] [default to false]
 **withMeta** | **bool?**|  | [optional] [default to false]
 **withCatalog** | **bool?**|  | [optional] [default to false]
 **withReviews** | **bool?**|  | [optional] [default to false]
 **withSchedule** | **bool?**|  | [optional] [default to false]
 **withCollection** | **bool?**|  | [optional] [default to false]
 **withBlog** | **bool?**|  | [optional] [default to false]
 **withTags** | **bool?**|  | [optional] [default to false]
 **withCategories** | **bool?**|  | [optional] [default to false]
 **page** | **int?**|  | [optional] [default to 1]
 **pageSize** | **int?**|  | [optional] [default to 25]
 **sortOn** | **string**|  | [optional] 
 **sortDesc** | **bool?**|  | [optional] [default to false]
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

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

<a name="updateplaceplacesplaceuuidput"></a>
# **UpdatePlacePlacesPlaceUuidPut**
> PlaceResponse UpdatePlacePlacesPlaceUuidPut (string placeUuid, PlaceBase placeBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Update Place

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
    public class UpdatePlacePlacesPlaceUuidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new PlacesApi(config);
            var placeUuid = placeUuid_example;  // string | 
            var placeBase = new PlaceBase(); // PlaceBase | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Update Place
                PlaceResponse result = apiInstance.UpdatePlacePlacesPlaceUuidPut(placeUuid, placeBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlacesApi.UpdatePlacePlacesPlaceUuidPut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **placeUuid** | **string**|  | 
 **placeBase** | [**PlaceBase**](PlaceBase.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

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

