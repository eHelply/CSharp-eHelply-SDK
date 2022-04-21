# Ehelply.Sdk.Api.DefaultApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttachEntityToAppointment**](DefaultApi.md#attachentitytoappointment) | **POST** /appointments/{appointment_uuid}/entities/{entity_uuid} | Attach Entity To Appointment
[**CreateAppointment**](DefaultApi.md#createappointment) | **POST** /appointments | Create Appointment
[**DeleteAppointment**](DefaultApi.md#deleteappointment) | **DELETE** /appointments/{appointment_uuid} | Delete Appointment
[**DetachEntityFromAppointment**](DefaultApi.md#detachentityfromappointment) | **DELETE** /appointments/{appointment_uuid}/entities/{entity_uuid} | Detach Entity From Appointment
[**GetAppointment**](DefaultApi.md#getappointment) | **GET** /appointments/{appointment_uuid} | Get Appointment
[**SearchAppointment**](DefaultApi.md#searchappointment) | **GET** /appointments | Search Appointment
[**SearchAppointmentEntities**](DefaultApi.md#searchappointmententities) | **GET** /appointments/{appointment_uuid}/entities | Search Appointment Entities
[**UpdateAppointment**](DefaultApi.md#updateappointment) | **PUT** /appointments/{appointment_uuid} | Update Appointment


<a name="attachentitytoappointment"></a>
# **AttachEntityToAppointment**
> Object AttachEntityToAppointment (string appointmentUuid, string entityUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

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
                Object result = apiInstance.AttachEntityToAppointment(appointmentUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
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

<a name="deleteappointment"></a>
# **DeleteAppointment**
> Object DeleteAppointment (string appointmentUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

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
                Object result = apiInstance.DeleteAppointment(appointmentUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
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
> Object DetachEntityFromAppointment (string appointmentUuid, string entityUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

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
                Object result = apiInstance.DetachEntityFromAppointment(appointmentUuid, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
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

