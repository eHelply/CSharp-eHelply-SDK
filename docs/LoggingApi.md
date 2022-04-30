# Ehelply.Sdk.Api.LoggingApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLogsLoggingLogsGet**](LoggingApi.md#getlogslogginglogsget) | **GET** /sam/logging/logs | Get Logs
[**GetServiceLogsLoggingLogsServicesServiceGet**](LoggingApi.md#getservicelogslogginglogsservicesserviceget) | **GET** /sam/logging/logs/services/{service} | Get Service Logs
[**GetSubjectLogsLoggingLogsServicesServiceSubjectsSubjectGet**](LoggingApi.md#getsubjectlogslogginglogsservicesservicesubjectssubjectget) | **GET** /sam/logging/logs/services/{service}/subjects/{subject} | Get Subject Logs


<a name="getlogslogginglogsget"></a>
# **GetLogsLoggingLogsGet**
> Object GetLogsLoggingLogsGet (string service = null, string dateStart = null, string dateEnd = null, bool? desc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetLogsLoggingLogsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new LoggingApi(config);
            var service = "service_example";  // string |  (optional) 
            var dateStart = "dateStart_example";  // string |  (optional) 
            var dateEnd = "dateEnd_example";  // string |  (optional) 
            var desc = true;  // bool? |  (optional)  (default to true)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Get Logs
                Object result = apiInstance.GetLogsLoggingLogsGet(service, dateStart, dateEnd, desc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.GetLogsLoggingLogsGet: " + e.Message );
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
 **service** | **string**|  | [optional] 
 **dateStart** | **string**|  | [optional] 
 **dateEnd** | **string**|  | [optional] 
 **desc** | **bool?**|  | [optional] [default to true]
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

<a name="getservicelogslogginglogsservicesserviceget"></a>
# **GetServiceLogsLoggingLogsServicesServiceGet**
> Object GetServiceLogsLoggingLogsServicesServiceGet (string service, string dateStart = null, string dateEnd = null, bool? desc = null, int? limit = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Service Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceLogsLoggingLogsServicesServiceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new LoggingApi(config);
            var service = "service_example";  // string | 
            var dateStart = "dateStart_example";  // string |  (optional) 
            var dateEnd = "dateEnd_example";  // string |  (optional) 
            var desc = true;  // bool? |  (optional)  (default to true)
            var limit = 50;  // int? |  (optional)  (default to 50)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Get Service Logs
                Object result = apiInstance.GetServiceLogsLoggingLogsServicesServiceGet(service, dateStart, dateEnd, desc, limit, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.GetServiceLogsLoggingLogsServicesServiceGet: " + e.Message );
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
 **dateStart** | **string**|  | [optional] 
 **dateEnd** | **string**|  | [optional] 
 **desc** | **bool?**|  | [optional] [default to true]
 **limit** | **int?**|  | [optional] [default to 50]
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

<a name="getsubjectlogslogginglogsservicesservicesubjectssubjectget"></a>
# **GetSubjectLogsLoggingLogsServicesServiceSubjectsSubjectGet**
> Object GetSubjectLogsLoggingLogsServicesServiceSubjectsSubjectGet (string service, string subject, string dateStart = null, string dateEnd = null, bool? desc = null, int? limit = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Get Subject Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetSubjectLogsLoggingLogsServicesServiceSubjectsSubjectGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new LoggingApi(config);
            var service = "service_example";  // string | 
            var subject = "subject_example";  // string | 
            var dateStart = "dateStart_example";  // string |  (optional) 
            var dateEnd = "dateEnd_example";  // string |  (optional) 
            var desc = true;  // bool? |  (optional)  (default to true)
            var limit = 50;  // int? |  (optional)  (default to 50)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Get Subject Logs
                Object result = apiInstance.GetSubjectLogsLoggingLogsServicesServiceSubjectsSubjectGet(service, subject, dateStart, dateEnd, desc, limit, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.GetSubjectLogsLoggingLogsServicesServiceSubjectsSubjectGet: " + e.Message );
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
 **subject** | **string**|  | 
 **dateStart** | **string**|  | [optional] 
 **dateEnd** | **string**|  | [optional] 
 **desc** | **bool?**|  | [optional] [default to true]
 **limit** | **int?**|  | [optional] [default to 50]
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

