# Ehelply.Sdk.Api.DefaultApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppointmentssearchAppointmentEntities**](DefaultApi.md#appointmentssearchappointmententities) | **GET** /appointments/appointments/entities/{entity_uuid}/appointments | Get Entities Appointments
[**AttachEntityToAppointment**](DefaultApi.md#attachentitytoappointment) | **POST** /appointments/appointments/{appointment_uuid}/entities/{entity_uuid} | Attach Entity To Appointment
[**AttachProductToCatalog**](DefaultApi.md#attachproducttocatalog) | **POST** /catalogs/{catalog_uuid}/products/{product_uuid} | Attach Product To Catalog
[**CreateAppointment**](DefaultApi.md#createappointment) | **POST** /appointments/appointments | Create Appointment
[**CreateCatalog**](DefaultApi.md#createcatalog) | **POST** /catalogs | Create Catalog
[**CreateProduct**](DefaultApi.md#createproduct) | **POST** /products | Create Product
[**CreateReview**](DefaultApi.md#createreview) | **POST** /reviews/types/{entity_type}/entities/{entity_uuid} | Create Review
[**DeleteAppointment**](DefaultApi.md#deleteappointment) | **DELETE** /appointments/appointments/{appointment_uuid} | Delete Appointment
[**DeleteCatalog**](DefaultApi.md#deletecatalog) | **DELETE** /catalogs/{catalog_uuid} | Delete Catalog
[**DeleteProduct**](DefaultApi.md#deleteproduct) | **DELETE** /products/{product_uuid} | Delete Product
[**DeleteReview**](DefaultApi.md#deletereview) | **DELETE** /reviews/types/{entity_type}/entities/{entity_uuid}/reviews/{review_uuid} | Delete Review
[**DetachEntityFromAppointment**](DefaultApi.md#detachentityfromappointment) | **DELETE** /appointments/appointments/{appointment_uuid}/entities/{entity_uuid} | Detach Entity From Appointment
[**DetachProductFromCatalog**](DefaultApi.md#detachproductfromcatalog) | **DELETE** /catalogs/{catalog_uuid}/products/{product_uuid} | Detach Product From Catalog
[**GetAppointment**](DefaultApi.md#getappointment) | **GET** /appointments/appointments/{appointment_uuid} | Get Appointment
[**GetCatalog**](DefaultApi.md#getcatalog) | **GET** /catalogs/{catalog_uuid} | Get Catalog
[**GetProduct**](DefaultApi.md#getproduct) | **GET** /products/{product_uuid} | Get Product
[**GetReview**](DefaultApi.md#getreview) | **GET** /reviews/types/{entity_type}/entities/{entity_uuid}/reviews/{review_uuid} | Get Review
[**SearchAppointment**](DefaultApi.md#searchappointment) | **GET** /appointments/appointments | Search Appointment
[**SearchAppointmentEntities**](DefaultApi.md#searchappointmententities) | **GET** /appointments/appointments/{appointment_uuid}/entities | Search Appointment Entities
[**SearchCatalogProducts**](DefaultApi.md#searchcatalogproducts) | **GET** /catalogs/{catalog_uuid}/products | Search Catalog Products
[**SearchCatalogs**](DefaultApi.md#searchcatalogs) | **GET** /catalogs | Search Catalogs
[**SearchProduct**](DefaultApi.md#searchproduct) | **GET** /products | Search Products
[**SearchProductCatalog**](DefaultApi.md#searchproductcatalog) | **GET** /products/{product_uuid}/catalogs | Search Product Catalogs
[**SearchReviews**](DefaultApi.md#searchreviews) | **GET** /reviews/types/{entity_type}/entities/{entity_uuid} | Search Review
[**UpdateAppointment**](DefaultApi.md#updateappointment) | **PUT** /appointments/appointments/{appointment_uuid} | Update Appointment
[**UpdateCatalog**](DefaultApi.md#updatecatalog) | **PUT** /catalogs/{catalog_uuid} | Update Catalog
[**UpdateProduct**](DefaultApi.md#updateproduct) | **PUT** /products/{product_uuid} | Update Product
[**UpdateReview**](DefaultApi.md#updatereview) | **PUT** /reviews/types/{entity_type}/entities/{entity_uuid}/reviews/{review_uuid} | Update Review


<a name="appointmentssearchappointmententities"></a>
# **AppointmentssearchAppointmentEntities**
> Object AppointmentssearchAppointmentEntities (string entityUuid, string startDate = null, string endDate = null, bool? includeCancelled = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Entities Appointments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AppointmentssearchAppointmentEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var entityUuid = entityUuid_example;  // string | 
            var startDate = startDate_example;  // string |  (optional) 
            var endDate = endDate_example;  // string |  (optional) 
            var includeCancelled = true;  // bool? |  (optional)  (default to false)
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Get Entities Appointments
                Object result = apiInstance.AppointmentssearchAppointmentEntities(entityUuid, startDate, endDate, includeCancelled, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AppointmentssearchAppointmentEntities: " + e.Message );
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
 **entityUuid** | **string**|  | 
 **startDate** | **string**|  | [optional] 
 **endDate** | **string**|  | [optional] 
 **includeCancelled** | **bool?**|  | [optional] [default to false]
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachentitytoappointment"></a>
# **AttachEntityToAppointment**
> bool AttachEntityToAppointment (string appointmentUuid, string entityUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Attach Entity To Appointment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AttachEntityToAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var appointmentUuid = appointmentUuid_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Attach Entity To Appointment
                bool result = apiInstance.AttachEntityToAppointment(appointmentUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AttachEntityToAppointment: " + e.Message );
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
 **appointmentUuid** | **string**|  | 
 **entityUuid** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attachproducttocatalog"></a>
# **AttachProductToCatalog**
> Object AttachProductToCatalog (string catalogUuid, string productUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Attach Product To Catalog

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AttachProductToCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var catalogUuid = catalogUuid_example;  // string | 
            var productUuid = productUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Attach Product To Catalog
                Object result = apiInstance.AttachProductToCatalog(catalogUuid, productUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AttachProductToCatalog: " + e.Message );
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
 **catalogUuid** | **string**|  | 
 **productUuid** | **string**|  | 
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createappointment"></a>
# **CreateAppointment**
> AppointmentResponse CreateAppointment (AppointmentBase appointmentBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Create Appointment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var appointmentBase = new AppointmentBase(); // AppointmentBase | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Create Appointment
                AppointmentResponse result = apiInstance.CreateAppointment(appointmentBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAppointment: " + e.Message );
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
 **appointmentBase** | [**AppointmentBase**](AppointmentBase.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**AppointmentResponse**](AppointmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcatalog"></a>
# **CreateCatalog**
> CatalogReturn CreateCatalog (CatalogBase catalogBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Create Catalog

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var catalogBase = new CatalogBase(); // CatalogBase | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Create Catalog
                CatalogReturn result = apiInstance.CreateCatalog(catalogBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateCatalog: " + e.Message );
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
 **catalogBase** | [**CatalogBase**](CatalogBase.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**CatalogReturn**](CatalogReturn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createproduct"></a>
# **CreateProduct**
> ProductReturn CreateProduct (ProductBase productBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Create Product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var productBase = new ProductBase(); // ProductBase | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Create Product
                ProductReturn result = apiInstance.CreateProduct(productBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateProduct: " + e.Message );
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
 **productBase** | [**ProductBase**](ProductBase.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**ProductReturn**](ProductReturn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createreview"></a>
# **CreateReview**
> Object CreateReview (string entityType, string entityUuid, CreateReview createReview, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Create Review

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var entityType = entityType_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var createReview = new CreateReview(); // CreateReview | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Create Review
                Object result = apiInstance.CreateReview(entityType, entityUuid, createReview, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateReview: " + e.Message );
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
 **entityType** | **string**|  | 
 **entityUuid** | **string**|  | 
 **createReview** | [**CreateReview**](CreateReview.md)|  | 
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

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteappointment"></a>
# **DeleteAppointment**
> bool DeleteAppointment (string appointmentUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Delete Appointment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var appointmentUuid = appointmentUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Delete Appointment
                bool result = apiInstance.DeleteAppointment(appointmentUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAppointment: " + e.Message );
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
 **appointmentUuid** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecatalog"></a>
# **DeleteCatalog**
> bool DeleteCatalog (string catalogUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Delete Catalog

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var catalogUuid = catalogUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Delete Catalog
                bool result = apiInstance.DeleteCatalog(catalogUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteCatalog: " + e.Message );
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
 **catalogUuid** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproduct"></a>
# **DeleteProduct**
> bool DeleteProduct (string productUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Delete Product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var productUuid = productUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Delete Product
                bool result = apiInstance.DeleteProduct(productUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteProduct: " + e.Message );
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
 **productUuid** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereview"></a>
# **DeleteReview**
> Object DeleteReview (string entityType, string entityUuid, string reviewUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Delete Review

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var entityType = entityType_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var reviewUuid = reviewUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Delete Review
                Object result = apiInstance.DeleteReview(entityType, entityUuid, reviewUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteReview: " + e.Message );
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
 **entityType** | **string**|  | 
 **entityUuid** | **string**|  | 
 **reviewUuid** | **string**|  | 
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="detachentityfromappointment"></a>
# **DetachEntityFromAppointment**
> bool DetachEntityFromAppointment (string appointmentUuid, string entityUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Detach Entity From Appointment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DetachEntityFromAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var appointmentUuid = appointmentUuid_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Detach Entity From Appointment
                bool result = apiInstance.DetachEntityFromAppointment(appointmentUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DetachEntityFromAppointment: " + e.Message );
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
 **appointmentUuid** | **string**|  | 
 **entityUuid** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="detachproductfromcatalog"></a>
# **DetachProductFromCatalog**
> Object DetachProductFromCatalog (string catalogUuid, string productUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Detach Product From Catalog

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DetachProductFromCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var catalogUuid = catalogUuid_example;  // string | 
            var productUuid = productUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Detach Product From Catalog
                Object result = apiInstance.DetachProductFromCatalog(catalogUuid, productUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DetachProductFromCatalog: " + e.Message );
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
 **catalogUuid** | **string**|  | 
 **productUuid** | **string**|  | 
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappointment"></a>
# **GetAppointment**
> AppointmentResponse GetAppointment (string appointmentUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Appointment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var appointmentUuid = appointmentUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Get Appointment
                AppointmentResponse result = apiInstance.GetAppointment(appointmentUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAppointment: " + e.Message );
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
 **appointmentUuid** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**AppointmentResponse**](AppointmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **403** | Unauthorized - Denied by eHelply |  -  |
| **404** | Appointment does not exist |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcatalog"></a>
# **GetCatalog**
> CatalogReturn GetCatalog (string catalogUuid, bool? withMeta = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Catalog

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var catalogUuid = catalogUuid_example;  // string | 
            var withMeta = true;  // bool? |  (optional)  (default to false)
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Get Catalog
                CatalogReturn result = apiInstance.GetCatalog(catalogUuid, withMeta, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetCatalog: " + e.Message );
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
 **catalogUuid** | **string**|  | 
 **withMeta** | **bool?**|  | [optional] [default to false]
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**CatalogReturn**](CatalogReturn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproduct"></a>
# **GetProduct**
> ProductReturn GetProduct (string productUuid, bool? withAddons = null, bool? withMeta = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var productUuid = productUuid_example;  // string | 
            var withAddons = true;  // bool? |  (optional)  (default to false)
            var withMeta = true;  // bool? |  (optional)  (default to false)
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Get Product
                ProductReturn result = apiInstance.GetProduct(productUuid, withAddons, withMeta, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetProduct: " + e.Message );
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
 **productUuid** | **string**|  | 
 **withAddons** | **bool?**|  | [optional] [default to false]
 **withMeta** | **bool?**|  | [optional] [default to false]
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**ProductReturn**](ProductReturn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreview"></a>
# **GetReview**
> Object GetReview (string entityType, string entityUuid, string reviewUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Review

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var entityType = entityType_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var reviewUuid = reviewUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Get Review
                Object result = apiInstance.GetReview(entityType, entityUuid, reviewUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetReview: " + e.Message );
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
 **entityType** | **string**|  | 
 **entityUuid** | **string**|  | 
 **reviewUuid** | **string**|  | 
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchappointment"></a>
# **SearchAppointment**
> Object SearchAppointment (string placeUuid = null, bool? excludeCancelled = null, bool? isDeleted = null, string startRange = null, string endRange = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string search = null, string searchOn = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Appointment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var placeUuid = placeUuid_example;  // string |  (optional) 
            var excludeCancelled = true;  // bool? |  (optional)  (default to false)
            var isDeleted = true;  // bool? |  (optional)  (default to false)
            var startRange = startRange_example;  // string |  (optional) 
            var endRange = endRange_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var sortOn = sortOn_example;  // string |  (optional) 
            var sortDesc = true;  // bool? |  (optional)  (default to false)
            var search = search_example;  // string |  (optional) 
            var searchOn = searchOn_example;  // string |  (optional) 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Search Appointment
                Object result = apiInstance.SearchAppointment(placeUuid, excludeCancelled, isDeleted, startRange, endRange, page, pageSize, sortOn, sortDesc, search, searchOn, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SearchAppointment: " + e.Message );
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
 **placeUuid** | **string**|  | [optional] 
 **excludeCancelled** | **bool?**|  | [optional] [default to false]
 **isDeleted** | **bool?**|  | [optional] [default to false]
 **startRange** | **string**|  | [optional] 
 **endRange** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] [default to 1]
 **pageSize** | **int?**|  | [optional] [default to 25]
 **sortOn** | **string**|  | [optional] 
 **sortDesc** | **bool?**|  | [optional] [default to false]
 **search** | **string**|  | [optional] 
 **searchOn** | **string**|  | [optional] 
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchappointmententities"></a>
# **SearchAppointmentEntities**
> Object SearchAppointmentEntities (string appointmentUuid, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string search = null, string searchOn = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Appointment Entities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchAppointmentEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var appointmentUuid = appointmentUuid_example;  // string | 
            var page = 56;  // int? |  (optional)  (default to 1)
            var pageSize = 56;  // int? |  (optional)  (default to 25)
            var sortOn = sortOn_example;  // string |  (optional) 
            var sortDesc = true;  // bool? |  (optional)  (default to false)
            var search = search_example;  // string |  (optional) 
            var searchOn = searchOn_example;  // string |  (optional) 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Search Appointment Entities
                Object result = apiInstance.SearchAppointmentEntities(appointmentUuid, page, pageSize, sortOn, sortDesc, search, searchOn, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SearchAppointmentEntities: " + e.Message );
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
 **appointmentUuid** | **string**|  | 
 **page** | **int?**|  | [optional] [default to 1]
 **pageSize** | **int?**|  | [optional] [default to 25]
 **sortOn** | **string**|  | [optional] 
 **sortDesc** | **bool?**|  | [optional] [default to false]
 **search** | **string**|  | [optional] 
 **searchOn** | **string**|  | [optional] 
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcatalogproducts"></a>
# **SearchCatalogProducts**
> Page SearchCatalogProducts (string catalogUuid, bool? withMeta = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Catalog Products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchCatalogProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var catalogUuid = catalogUuid_example;  // string | 
            var withMeta = true;  // bool? |  (optional)  (default to false)
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
                // Search Catalog Products
                Page result = apiInstance.SearchCatalogProducts(catalogUuid, withMeta, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SearchCatalogProducts: " + e.Message );
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
 **catalogUuid** | **string**|  | 
 **withMeta** | **bool?**|  | [optional] [default to false]
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcatalogs"></a>
# **SearchCatalogs**
> Page SearchCatalogs (bool? withMeta = null, string name = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Catalogs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchCatalogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var withMeta = true;  // bool? |  (optional)  (default to false)
            var name = name_example;  // string |  (optional) 
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
                // Search Catalogs
                Page result = apiInstance.SearchCatalogs(withMeta, name, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SearchCatalogs: " + e.Message );
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
 **withMeta** | **bool?**|  | [optional] [default to false]
 **name** | **string**|  | [optional] 
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchproduct"></a>
# **SearchProduct**
> Page SearchProduct (bool? withMeta = null, string name = null, List<string> addons = null, int? priceMax = null, int? priceMin = null, bool? quantityAvailable = null, bool? isDeleted = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Products

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var withMeta = true;  // bool? |  (optional)  (default to false)
            var name = name_example;  // string |  (optional) 
            var addons = new List<string>(); // List<string> |  (optional) 
            var priceMax = 56;  // int? |  (optional) 
            var priceMin = 56;  // int? |  (optional) 
            var quantityAvailable = true;  // bool? |  (optional)  (default to false)
            var isDeleted = true;  // bool? |  (optional)  (default to false)
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
                // Search Products
                Page result = apiInstance.SearchProduct(withMeta, name, addons, priceMax, priceMin, quantityAvailable, isDeleted, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SearchProduct: " + e.Message );
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
 **withMeta** | **bool?**|  | [optional] [default to false]
 **name** | **string**|  | [optional] 
 **addons** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **priceMax** | **int?**|  | [optional] 
 **priceMin** | **int?**|  | [optional] 
 **quantityAvailable** | **bool?**|  | [optional] [default to false]
 **isDeleted** | **bool?**|  | [optional] [default to false]
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchproductcatalog"></a>
# **SearchProductCatalog**
> Page SearchProductCatalog (string productUuid, bool? withMeta = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Product Catalogs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchProductCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var productUuid = productUuid_example;  // string | 
            var withMeta = true;  // bool? |  (optional)  (default to false)
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
                // Search Product Catalogs
                Page result = apiInstance.SearchProductCatalog(productUuid, withMeta, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SearchProductCatalog: " + e.Message );
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
 **productUuid** | **string**|  | 
 **withMeta** | **bool?**|  | [optional] [default to false]
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchreviews"></a>
# **SearchReviews**
> Object SearchReviews (string entityType, string entityUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Review

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchReviewsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var entityType = entityType_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Search Review
                Object result = apiInstance.SearchReviews(entityType, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SearchReviews: " + e.Message );
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
 **entityType** | **string**|  | 
 **entityUuid** | **string**|  | 
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappointment"></a>
# **UpdateAppointment**
> AppointmentResponse UpdateAppointment (string appointmentUuid, AppointmentBase appointmentBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Update Appointment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var appointmentUuid = appointmentUuid_example;  // string | 
            var appointmentBase = new AppointmentBase(); // AppointmentBase | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Update Appointment
                AppointmentResponse result = apiInstance.UpdateAppointment(appointmentUuid, appointmentBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAppointment: " + e.Message );
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
 **appointmentUuid** | **string**|  | 
 **appointmentBase** | [**AppointmentBase**](AppointmentBase.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**AppointmentResponse**](AppointmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **403** | Unauthorized - Denied by eHelply |  -  |
| **404** | Appointment does not exist |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecatalog"></a>
# **UpdateCatalog**
> CatalogReturn UpdateCatalog (string catalogUuid, CatalogBase catalogBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Update Catalog

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var catalogUuid = catalogUuid_example;  // string | 
            var catalogBase = new CatalogBase(); // CatalogBase | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Update Catalog
                CatalogReturn result = apiInstance.UpdateCatalog(catalogUuid, catalogBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateCatalog: " + e.Message );
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
 **catalogUuid** | **string**|  | 
 **catalogBase** | [**CatalogBase**](CatalogBase.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**CatalogReturn**](CatalogReturn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproduct"></a>
# **UpdateProduct**
> ProductReturn UpdateProduct (string productUuid, ProductBase productBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Update Product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var productUuid = productUuid_example;  // string | 
            var productBase = new ProductBase(); // ProductBase | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Update Product
                ProductReturn result = apiInstance.UpdateProduct(productUuid, productBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateProduct: " + e.Message );
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
 **productUuid** | **string**|  | 
 **productBase** | [**ProductBase**](ProductBase.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**ProductReturn**](ProductReturn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereview"></a>
# **UpdateReview**
> Object UpdateReview (string entityType, string entityUuid, string reviewUuid, UpdateReview updateReview, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Update Review

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new DefaultApi(config);
            var entityType = entityType_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var reviewUuid = reviewUuid_example;  // string | 
            var updateReview = new UpdateReview(); // UpdateReview | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Update Review
                Object result = apiInstance.UpdateReview(entityType, entityUuid, reviewUuid, updateReview, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateReview: " + e.Message );
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
 **entityType** | **string**|  | 
 **entityUuid** | **string**|  | 
 **reviewUuid** | **string**|  | 
 **updateReview** | [**UpdateReview**](UpdateReview.md)|  | 
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

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

