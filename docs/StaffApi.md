# Ehelply.Sdk.Api.StaffApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStaffPlacesStaffPost**](StaffApi.md#createstaffplacesstaffpost) | **POST** /places/staff | Create Staff
[**DeleteStaffPlacesStaffStaffUuidDelete**](StaffApi.md#deletestaffplacesstaffstaffuuiddelete) | **DELETE** /places/staff/{staff_uuid} | Delete Staff
[**GetStaffPlacesStaffStaffUuidGet**](StaffApi.md#getstaffplacesstaffstaffuuidget) | **GET** /places/staff/{staff_uuid} | Get Staff
[**SearchStaffPlacesStaffGet**](StaffApi.md#searchstaffplacesstaffget) | **GET** /places/staff | Search Staff
[**UpdateStaffPlacesStaffStaffUuidPut**](StaffApi.md#updatestaffplacesstaffstaffuuidput) | **PUT** /places/staff/{staff_uuid} | Update Staff


<a name="createstaffplacesstaffpost"></a>
# **CreateStaffPlacesStaffPost**
> StaffDb CreateStaffPlacesStaffPost (StaffCreate staffCreate, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Create Staff

Creates a staff member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateStaffPlacesStaffPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new StaffApi(config);
            var staffCreate = new StaffCreate(); // StaffCreate | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Create Staff
                StaffDb result = apiInstance.CreateStaffPlacesStaffPost(staffCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffApi.CreateStaffPlacesStaffPost: " + e.Message );
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
 **staffCreate** | [**StaffCreate**](StaffCreate.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**StaffDb**](StaffDb.md)

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

<a name="deletestaffplacesstaffstaffuuiddelete"></a>
# **DeleteStaffPlacesStaffStaffUuidDelete**
> Object DeleteStaffPlacesStaffStaffUuidDelete (string staffUuid, bool? softDelete = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Delete Staff

Deletes the staff member with the given ID and returns True if successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteStaffPlacesStaffStaffUuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new StaffApi(config);
            var staffUuid = "staffUuid_example";  // string | 
            var softDelete = true;  // bool? |  (optional)  (default to true)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Delete Staff
                Object result = apiInstance.DeleteStaffPlacesStaffStaffUuidDelete(staffUuid, softDelete, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteStaffPlacesStaffStaffUuidDelete: " + e.Message );
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
 **staffUuid** | **string**|  | 
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

<a name="getstaffplacesstaffstaffuuidget"></a>
# **GetStaffPlacesStaffStaffUuidGet**
> StaffResponse GetStaffPlacesStaffStaffUuidGet (string staffUuid, bool? withPlaces = null, bool? withCompanies = null, bool? withCatalog = null, bool? withSchedule = null, bool? withRoles = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Staff

Gets the staff member information given the staff ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetStaffPlacesStaffStaffUuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new StaffApi(config);
            var staffUuid = "staffUuid_example";  // string | 
            var withPlaces = false;  // bool? |  (optional)  (default to false)
            var withCompanies = false;  // bool? |  (optional)  (default to false)
            var withCatalog = false;  // bool? |  (optional)  (default to false)
            var withSchedule = false;  // bool? |  (optional)  (default to false)
            var withRoles = false;  // bool? |  (optional)  (default to false)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Get Staff
                StaffResponse result = apiInstance.GetStaffPlacesStaffStaffUuidGet(staffUuid, withPlaces, withCompanies, withCatalog, withSchedule, withRoles, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffApi.GetStaffPlacesStaffStaffUuidGet: " + e.Message );
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
 **staffUuid** | **string**|  | 
 **withPlaces** | **bool?**|  | [optional] [default to false]
 **withCompanies** | **bool?**|  | [optional] [default to false]
 **withCatalog** | **bool?**|  | [optional] [default to false]
 **withSchedule** | **bool?**|  | [optional] [default to false]
 **withRoles** | **bool?**|  | [optional] [default to false]
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**StaffResponse**](StaffResponse.md)

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

<a name="searchstaffplacesstaffget"></a>
# **SearchStaffPlacesStaffGet**
> Page SearchStaffPlacesStaffGet (string projectUuid = null, string firstName = null, string lastName = null, bool? isDeleted = null, bool? withCompanies = null, bool? withPlaces = null, bool? withSchedule = null, bool? withCatalog = null, bool? withReviews = null, bool? withRoles = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Staff

TODO Item return format: ``` {     uuid                                **type:** string     project_uuid                        **type:** string or None      entity                              **type:** string or None      place                               **type:** dict or None      company                             **type:** dict or None      schedule                            **type:** dict or None      catalog                             **type:** dict or None      reviews                             **type:** dict or None      created_at                          **type:** string or None      updated_at                          **type:** string or None      deleted_at                          **type:** string or None  } ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchStaffPlacesStaffGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new StaffApi(config);
            var projectUuid = "projectUuid_example";  // string |  (optional) 
            var firstName = "firstName_example";  // string |  (optional) 
            var lastName = "lastName_example";  // string |  (optional) 
            var isDeleted = false;  // bool? |  (optional)  (default to false)
            var withCompanies = false;  // bool? |  (optional)  (default to false)
            var withPlaces = false;  // bool? |  (optional)  (default to false)
            var withSchedule = false;  // bool? |  (optional)  (default to false)
            var withCatalog = false;  // bool? |  (optional)  (default to false)
            var withReviews = false;  // bool? |  (optional)  (default to false)
            var withRoles = false;  // bool? |  (optional)  (default to false)
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
                // Search Staff
                Page result = apiInstance.SearchStaffPlacesStaffGet(projectUuid, firstName, lastName, isDeleted, withCompanies, withPlaces, withSchedule, withCatalog, withReviews, withRoles, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffApi.SearchStaffPlacesStaffGet: " + e.Message );
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
 **firstName** | **string**|  | [optional] 
 **lastName** | **string**|  | [optional] 
 **isDeleted** | **bool?**|  | [optional] [default to false]
 **withCompanies** | **bool?**|  | [optional] [default to false]
 **withPlaces** | **bool?**|  | [optional] [default to false]
 **withSchedule** | **bool?**|  | [optional] [default to false]
 **withCatalog** | **bool?**|  | [optional] [default to false]
 **withReviews** | **bool?**|  | [optional] [default to false]
 **withRoles** | **bool?**|  | [optional] [default to false]
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

<a name="updatestaffplacesstaffstaffuuidput"></a>
# **UpdateStaffPlacesStaffStaffUuidPut**
> StaffResponse UpdateStaffPlacesStaffStaffUuidPut (string staffUuid, StaffCreate staffCreate, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Update Staff

Update staff with given info, only updating the fields supplied. Staff Uuid must be sent however.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateStaffPlacesStaffStaffUuidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new StaffApi(config);
            var staffUuid = "staffUuid_example";  // string | 
            var staffCreate = new StaffCreate(); // StaffCreate | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Update Staff
                StaffResponse result = apiInstance.UpdateStaffPlacesStaffStaffUuidPut(staffUuid, staffCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateStaffPlacesStaffStaffUuidPut: " + e.Message );
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
 **staffUuid** | **string**|  | 
 **staffCreate** | [**StaffCreate**](StaffCreate.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**StaffResponse**](StaffResponse.md)

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

