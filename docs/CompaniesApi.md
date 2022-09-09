# Ehelply.Sdk.Api.CompaniesApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCompanyPlacesCompaniesPost**](CompaniesApi.md#createcompanyplacescompaniespost) | **POST** /places/companies | Create Company
[**DeleteCompanyPlacesCompaniesCompanyUuidDelete**](CompaniesApi.md#deletecompanyplacescompaniescompanyuuiddelete) | **DELETE** /places/companies/{company_uuid} | Delete Company
[**GetCompanyPlacesCompaniesCompanyUuidGet**](CompaniesApi.md#getcompanyplacescompaniescompanyuuidget) | **GET** /places/companies/{company_uuid} | Get Company
[**SearchCompaniesPlacesCompaniesGet**](CompaniesApi.md#searchcompaniesplacescompaniesget) | **GET** /places/companies | Search Companies
[**UpdateCompanyPlacesCompaniesCompanyUuidPut**](CompaniesApi.md#updatecompanyplacescompaniescompanyuuidput) | **PUT** /places/companies/{company_uuid} | Update Company


<a name="createcompanyplacescompaniespost"></a>
# **CreateCompanyPlacesCompaniesPost**
> CompanyResponse CreateCompanyPlacesCompaniesPost (CompanyBase companyBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Create Company

Creates a company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateCompanyPlacesCompaniesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new CompaniesApi(config);
            var companyBase = new CompanyBase(); // CompanyBase | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Create Company
                CompanyResponse result = apiInstance.CreateCompanyPlacesCompaniesPost(companyBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesApi.CreateCompanyPlacesCompaniesPost: " + e.Message );
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
 **companyBase** | [**CompanyBase**](CompanyBase.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**CompanyResponse**](CompanyResponse.md)

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

<a name="deletecompanyplacescompaniescompanyuuiddelete"></a>
# **DeleteCompanyPlacesCompaniesCompanyUuidDelete**
> Object DeleteCompanyPlacesCompaniesCompanyUuidDelete (string companyUuid, bool? softDelete = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Delete Company

Deletes the company with the given ID and returns True if successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteCompanyPlacesCompaniesCompanyUuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new CompaniesApi(config);
            var companyUuid = "companyUuid_example";  // string | 
            var softDelete = true;  // bool? |  (optional)  (default to true)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Delete Company
                Object result = apiInstance.DeleteCompanyPlacesCompaniesCompanyUuidDelete(companyUuid, softDelete, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesApi.DeleteCompanyPlacesCompaniesCompanyUuidDelete: " + e.Message );
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
 **companyUuid** | **string**|  | 
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

<a name="getcompanyplacescompaniescompanyuuidget"></a>
# **GetCompanyPlacesCompaniesCompanyUuidGet**
> CompanyResponse GetCompanyPlacesCompaniesCompanyUuidGet (string companyUuid, bool? withMeta = null, bool? withCatalog = null, bool? withReviews = null, bool? withSchedule = null, bool? withBlog = null, bool? withTags = null, bool? withCategories = null, bool? withPlaces = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Company

Gets the company information given the Place ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetCompanyPlacesCompaniesCompanyUuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new CompaniesApi(config);
            var companyUuid = "companyUuid_example";  // string | 
            var withMeta = false;  // bool? |  (optional)  (default to false)
            var withCatalog = false;  // bool? |  (optional)  (default to false)
            var withReviews = false;  // bool? |  (optional)  (default to false)
            var withSchedule = false;  // bool? |  (optional)  (default to false)
            var withBlog = false;  // bool? |  (optional)  (default to false)
            var withTags = false;  // bool? |  (optional)  (default to false)
            var withCategories = false;  // bool? |  (optional)  (default to false)
            var withPlaces = false;  // bool? |  (optional)  (default to false)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Get Company
                CompanyResponse result = apiInstance.GetCompanyPlacesCompaniesCompanyUuidGet(companyUuid, withMeta, withCatalog, withReviews, withSchedule, withBlog, withTags, withCategories, withPlaces, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesApi.GetCompanyPlacesCompaniesCompanyUuidGet: " + e.Message );
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
 **companyUuid** | **string**|  | 
 **withMeta** | **bool?**|  | [optional] [default to false]
 **withCatalog** | **bool?**|  | [optional] [default to false]
 **withReviews** | **bool?**|  | [optional] [default to false]
 **withSchedule** | **bool?**|  | [optional] [default to false]
 **withBlog** | **bool?**|  | [optional] [default to false]
 **withTags** | **bool?**|  | [optional] [default to false]
 **withCategories** | **bool?**|  | [optional] [default to false]
 **withPlaces** | **bool?**|  | [optional] [default to false]
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**CompanyResponse**](CompanyResponse.md)

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

<a name="searchcompaniesplacescompaniesget"></a>
# **SearchCompaniesPlacesCompaniesGet**
> Page SearchCompaniesPlacesCompaniesGet (string projectUuid = null, string name = null, string email = null, bool? isPublic = null, bool? isDeleted = null, bool? withPlaces = null, bool? withMeta = null, bool? withCatalog = null, bool? withReviews = null, bool? withSchedule = null, bool? withBlog = null, bool? withTags = null, bool? withCategories = null, int? page = null, int? pageSize = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Search Companies

Search all companies and returns paginated results with Companies being stored in items field. Can search by `project_uuid, name, email` string fields or the `is_public and is_deleted` boolean fields. To search with these fields use query params with string values. For sorting fill out \"sort_desc\" field with either true/false and the \"sort_on\" query parameter with column you want to sort on (ex: name). Max pagination items per page is 50. Item return format: ``` {     uuid                                **type:** string     project_uuid                        **type:** string or None      meta_uuid                           **type:** string or None      catalog_data                        **type:** dict or None      review_group_data                   **type:** dict or None      schedule_data                       **type:** dict or None      blog_data                           **type:** dict or None      tags                                **type:** [TagBase] or None      categories                          **type:** [CategoryBase] or None      places                              **type:** PlaceBase or None      created_at                          **type:** string or None      updated_at                          **type:** string or None      deleted_at                          **type:** string or None  } ```

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchCompaniesPlacesCompaniesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new CompaniesApi(config);
            var projectUuid = "projectUuid_example";  // string |  (optional) 
            var name = "name_example";  // string |  (optional) 
            var email = "email_example";  // string |  (optional) 
            var isPublic = true;  // bool? |  (optional)  (default to true)
            var isDeleted = false;  // bool? |  (optional)  (default to false)
            var withPlaces = false;  // bool? |  (optional)  (default to false)
            var withMeta = false;  // bool? |  (optional)  (default to false)
            var withCatalog = false;  // bool? |  (optional)  (default to false)
            var withReviews = false;  // bool? |  (optional)  (default to false)
            var withSchedule = false;  // bool? |  (optional)  (default to false)
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
                // Search Companies
                Page result = apiInstance.SearchCompaniesPlacesCompaniesGet(projectUuid, name, email, isPublic, isDeleted, withPlaces, withMeta, withCatalog, withReviews, withSchedule, withBlog, withTags, withCategories, page, pageSize, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesApi.SearchCompaniesPlacesCompaniesGet: " + e.Message );
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
 **email** | **string**|  | [optional] 
 **isPublic** | **bool?**|  | [optional] [default to true]
 **isDeleted** | **bool?**|  | [optional] [default to false]
 **withPlaces** | **bool?**|  | [optional] [default to false]
 **withMeta** | **bool?**|  | [optional] [default to false]
 **withCatalog** | **bool?**|  | [optional] [default to false]
 **withReviews** | **bool?**|  | [optional] [default to false]
 **withSchedule** | **bool?**|  | [optional] [default to false]
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

<a name="updatecompanyplacescompaniescompanyuuidput"></a>
# **UpdateCompanyPlacesCompaniesCompanyUuidPut**
> CompanyResponse UpdateCompanyPlacesCompaniesCompanyUuidPut (string companyUuid, CompanyBase companyBase, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Update Company

Update company with given info, only updating the fields supplied. Company Uuid must be sent however.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateCompanyPlacesCompaniesCompanyUuidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new CompaniesApi(config);
            var companyUuid = "companyUuid_example";  // string | 
            var companyBase = new CompanyBase(); // CompanyBase | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Update Company
                CompanyResponse result = apiInstance.UpdateCompanyPlacesCompaniesCompanyUuidPut(companyUuid, companyBase, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesApi.UpdateCompanyPlacesCompaniesCompanyUuidPut: " + e.Message );
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
 **companyUuid** | **string**|  | 
 **companyBase** | [**CompanyBase**](CompanyBase.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**CompanyResponse**](CompanyResponse.md)

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

