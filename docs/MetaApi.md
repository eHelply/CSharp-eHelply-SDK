# Ehelply.Sdk.Api.MetaApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteMetaFromUuidMetaMetaMetaUuidDelete**](MetaApi.md#deletemetafromuuidmetametametauuiddelete) | **DELETE** /meta/meta/meta/{meta_uuid} | Delete Meta From Uuid
[**DeleteMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidDelete**](MetaApi.md#deletemetametametaserviceservicetypetypeentityentityuuiddelete) | **DELETE** /meta/meta/meta/service/{service}/type/{type}/entity/{entity_uuid} | Delete Meta
[**GetMetaFromUuidMetaMetaMetaUuidGet**](MetaApi.md#getmetafromuuidmetametametauuidget) | **GET** /meta/meta/meta/{meta_uuid} | Get Meta From Uuid
[**GetMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidGet**](MetaApi.md#getmetametametaserviceservicetypetypeentityentityuuidget) | **GET** /meta/meta/meta/service/{service}/type/{type}/entity/{entity_uuid} | Get Meta
[**MakeSlugMetaMetaSlugPost**](MetaApi.md#makeslugmetametaslugpost) | **POST** /meta/meta/meta/slug | Make Slug
[**PostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost**](MetaApi.md#postmetametametaserviceservicetypetypestrentityentityuuidpost) | **POST** /meta/meta/meta/service/{service}/type/{type_str}/entity/{entity_uuid} | Post Meta
[**TouchMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidTouchPost**](MetaApi.md#touchmetametametaserviceservicetypetypeentityentityuuidtouchpost) | **POST** /meta/meta/meta/service/{service}/type/{type}/entity/{entity_uuid}/touch | Touch Meta
[**UpdateMetaFromUuidMetaMetaMetaUuidPut**](MetaApi.md#updatemetafromuuidmetametametauuidput) | **PUT** /meta/meta/meta/{meta_uuid} | Update Meta From Uuid
[**UpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut**](MetaApi.md#updatemetametametaserviceservicetypetypeentityentityuuidput) | **PUT** /meta/meta/meta/service/{service}/type/{type}/entity/{entity_uuid} | Update Meta


<a name="deletemetafromuuidmetametametauuiddelete"></a>
# **DeleteMetaFromUuidMetaMetaMetaUuidDelete**
> Object DeleteMetaFromUuidMetaMetaMetaUuidDelete (string metaUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Delete Meta From Uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteMetaFromUuidMetaMetaMetaUuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MetaApi(config);
            var metaUuid = metaUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Delete Meta From Uuid
                Object result = apiInstance.DeleteMetaFromUuidMetaMetaMetaUuidDelete(metaUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaApi.DeleteMetaFromUuidMetaMetaMetaUuidDelete: " + e.Message );
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
 **metaUuid** | **string**|  | 
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

<a name="deletemetametametaserviceservicetypetypeentityentityuuiddelete"></a>
# **DeleteMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidDelete**
> Object DeleteMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidDelete (string service, string type, string entityUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Delete Meta

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MetaApi(config);
            var service = service_example;  // string | 
            var type = type_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Delete Meta
                Object result = apiInstance.DeleteMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidDelete(service, type, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaApi.DeleteMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidDelete: " + e.Message );
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
 **service** | **string**|  | 
 **type** | **string**|  | 
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

<a name="getmetafromuuidmetametametauuidget"></a>
# **GetMetaFromUuidMetaMetaMetaUuidGet**
> Object GetMetaFromUuidMetaMetaMetaUuidGet (string metaUuid, bool? detailed = null, bool? custom = null, bool? dates = null, int? history = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Meta From Uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetMetaFromUuidMetaMetaMetaUuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MetaApi(config);
            var metaUuid = metaUuid_example;  // string | 
            var detailed = true;  // bool? |  (optional)  (default to false)
            var custom = true;  // bool? |  (optional)  (default to false)
            var dates = true;  // bool? |  (optional)  (default to false)
            var history = 56;  // int? |  (optional)  (default to 0)
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Get Meta From Uuid
                Object result = apiInstance.GetMetaFromUuidMetaMetaMetaUuidGet(metaUuid, detailed, custom, dates, history, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaApi.GetMetaFromUuidMetaMetaMetaUuidGet: " + e.Message );
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
 **metaUuid** | **string**|  | 
 **detailed** | **bool?**|  | [optional] [default to false]
 **custom** | **bool?**|  | [optional] [default to false]
 **dates** | **bool?**|  | [optional] [default to false]
 **history** | **int?**|  | [optional] [default to 0]
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

<a name="getmetametametaserviceservicetypetypeentityentityuuidget"></a>
# **GetMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidGet**
> Object GetMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidGet (string service, string type, string entityUuid, bool? detailed = null, bool? custom = null, bool? dates = null, int? history = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Meta

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MetaApi(config);
            var service = service_example;  // string | 
            var type = type_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var detailed = true;  // bool? |  (optional)  (default to false)
            var custom = true;  // bool? |  (optional)  (default to false)
            var dates = true;  // bool? |  (optional)  (default to false)
            var history = 56;  // int? |  (optional)  (default to 0)
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Get Meta
                Object result = apiInstance.GetMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidGet(service, type, entityUuid, detailed, custom, dates, history, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaApi.GetMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidGet: " + e.Message );
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
 **service** | **string**|  | 
 **type** | **string**|  | 
 **entityUuid** | **string**|  | 
 **detailed** | **bool?**|  | [optional] [default to false]
 **custom** | **bool?**|  | [optional] [default to false]
 **dates** | **bool?**|  | [optional] [default to false]
 **history** | **int?**|  | [optional] [default to 0]
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

<a name="makeslugmetametaslugpost"></a>
# **MakeSlugMetaMetaSlugPost**
> Object MakeSlugMetaMetaSlugPost (MetaSlugger metaSlugger)

Make Slug

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class MakeSlugMetaMetaSlugPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MetaApi(config);
            var metaSlugger = new MetaSlugger(); // MetaSlugger | 

            try
            {
                // Make Slug
                Object result = apiInstance.MakeSlugMetaMetaSlugPost(metaSlugger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaApi.MakeSlugMetaMetaSlugPost: " + e.Message );
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
 **metaSlugger** | [**MetaSlugger**](MetaSlugger.md)|  | 

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

<a name="postmetametametaserviceservicetypetypestrentityentityuuidpost"></a>
# **PostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost**
> MetaDynamo PostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost (string service, string typeStr, string entityUuid, BodyPostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost bodyPostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Post Meta

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class PostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MetaApi(config);
            var service = service_example;  // string | 
            var typeStr = typeStr_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var bodyPostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost = new BodyPostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost(); // BodyPostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Post Meta
                MetaDynamo result = apiInstance.PostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost(service, typeStr, entityUuid, bodyPostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaApi.PostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost: " + e.Message );
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
 **service** | **string**|  | 
 **typeStr** | **string**|  | 
 **entityUuid** | **string**|  | 
 **bodyPostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost** | [**BodyPostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost**](BodyPostMetaMetaMetaServiceServiceTypeTypeStrEntityEntityUuidPost.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**MetaDynamo**](MetaDynamo.md)

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

<a name="touchmetametametaserviceservicetypetypeentityentityuuidtouchpost"></a>
# **TouchMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidTouchPost**
> MetaDynamo TouchMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidTouchPost (string service, string type, string entityUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Touch Meta

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class TouchMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidTouchPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MetaApi(config);
            var service = service_example;  // string | 
            var type = type_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Touch Meta
                MetaDynamo result = apiInstance.TouchMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidTouchPost(service, type, entityUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaApi.TouchMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidTouchPost: " + e.Message );
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
 **service** | **string**|  | 
 **type** | **string**|  | 
 **entityUuid** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**MetaDynamo**](MetaDynamo.md)

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

<a name="updatemetafromuuidmetametametauuidput"></a>
# **UpdateMetaFromUuidMetaMetaMetaUuidPut**
> MetaDynamo UpdateMetaFromUuidMetaMetaMetaUuidPut (string metaUuid, BodyUpdateMetaFromUuidMetaMetaMetaUuidPut bodyUpdateMetaFromUuidMetaMetaMetaUuidPut, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Update Meta From Uuid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateMetaFromUuidMetaMetaMetaUuidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MetaApi(config);
            var metaUuid = metaUuid_example;  // string | 
            var bodyUpdateMetaFromUuidMetaMetaMetaUuidPut = new BodyUpdateMetaFromUuidMetaMetaMetaUuidPut(); // BodyUpdateMetaFromUuidMetaMetaMetaUuidPut | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Update Meta From Uuid
                MetaDynamo result = apiInstance.UpdateMetaFromUuidMetaMetaMetaUuidPut(metaUuid, bodyUpdateMetaFromUuidMetaMetaMetaUuidPut, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaApi.UpdateMetaFromUuidMetaMetaMetaUuidPut: " + e.Message );
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
 **metaUuid** | **string**|  | 
 **bodyUpdateMetaFromUuidMetaMetaMetaUuidPut** | [**BodyUpdateMetaFromUuidMetaMetaMetaUuidPut**](BodyUpdateMetaFromUuidMetaMetaMetaUuidPut.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**MetaDynamo**](MetaDynamo.md)

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

<a name="updatemetametametaserviceservicetypetypeentityentityuuidput"></a>
# **UpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut**
> MetaDynamo UpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut (string service, string type, string entityUuid, BodyUpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut bodyUpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Update Meta

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MetaApi(config);
            var service = service_example;  // string | 
            var type = type_example;  // string | 
            var entityUuid = entityUuid_example;  // string | 
            var bodyUpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut = new BodyUpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut(); // BodyUpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Update Meta
                MetaDynamo result = apiInstance.UpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut(service, type, entityUuid, bodyUpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MetaApi.UpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut: " + e.Message );
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
 **service** | **string**|  | 
 **type** | **string**|  | 
 **entityUuid** | **string**|  | 
 **bodyUpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut** | [**BodyUpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut**](BodyUpdateMetaMetaMetaServiceServiceTypeTypeEntityEntityUuidPut.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**MetaDynamo**](MetaDynamo.md)

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

