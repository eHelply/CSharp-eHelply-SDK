# Ehelply.Sdk.Api.LoggingApi

All URIs are relative to *https://api.prod.ehelply.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLogs**](LoggingApi.md#getlogs) | **GET** /sam/logging/logs | Getlogs |
| [**GetServiceLogs**](LoggingApi.md#getservicelogs) | **GET** /sam/logging/logs/services/{service} | Getservicelogs |
| [**GetSubjectLogs**](LoggingApi.md#getsubjectlogs) | **GET** /sam/logging/logs/services/{service}/subjects/{subject} | Getsubjectlogs |

<a name="getlogs"></a>
# **GetLogs**
> List&lt;LoggingDynamo&gt; GetLogs (string service = null, string dateStart = null, string dateEnd = null, bool? desc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Getlogs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetLogsExample
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
                // Getlogs
                List<LoggingDynamo> result = apiInstance.GetLogs(service, dateStart, dateEnd, desc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.GetLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Getlogs
    ApiResponse<List<LoggingDynamo>> response = apiInstance.GetLogsWithHttpInfo(service, dateStart, dateEnd, desc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoggingApi.GetLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **string** |  | [optional]  |
| **dateStart** | **string** |  | [optional]  |
| **dateEnd** | **string** |  | [optional]  |
| **desc** | **bool?** |  | [optional] [default to true] |
| **xAccessToken** | **string** |  | [optional]  |
| **xSecretToken** | **string** |  | [optional]  |
| **authorization** | **string** |  | [optional]  |
| **ehelplyActiveParticipant** | **string** |  | [optional]  |
| **ehelplyProject** | **string** |  | [optional]  |
| **ehelplyData** | **string** |  | [optional]  |

### Return type

[**List&lt;LoggingDynamo&gt;**](LoggingDynamo.md)

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

<a name="getservicelogs"></a>
# **GetServiceLogs**
> List&lt;LoggingDynamo&gt; GetServiceLogs (string service, string dateStart = null, string dateEnd = null, bool? desc = null, int? limit = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Getservicelogs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceLogsExample
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
                // Getservicelogs
                List<LoggingDynamo> result = apiInstance.GetServiceLogs(service, dateStart, dateEnd, desc, limit, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.GetServiceLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServiceLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Getservicelogs
    ApiResponse<List<LoggingDynamo>> response = apiInstance.GetServiceLogsWithHttpInfo(service, dateStart, dateEnd, desc, limit, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoggingApi.GetServiceLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **string** |  |  |
| **dateStart** | **string** |  | [optional]  |
| **dateEnd** | **string** |  | [optional]  |
| **desc** | **bool?** |  | [optional] [default to true] |
| **limit** | **int?** |  | [optional] [default to 50] |
| **xAccessToken** | **string** |  | [optional]  |
| **xSecretToken** | **string** |  | [optional]  |
| **authorization** | **string** |  | [optional]  |
| **ehelplyActiveParticipant** | **string** |  | [optional]  |
| **ehelplyProject** | **string** |  | [optional]  |
| **ehelplyData** | **string** |  | [optional]  |

### Return type

[**List&lt;LoggingDynamo&gt;**](LoggingDynamo.md)

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

<a name="getsubjectlogs"></a>
# **GetSubjectLogs**
> Object GetSubjectLogs (string service, string subject, string dateStart = null, string dateEnd = null, bool? desc = null, int? limit = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Getsubjectlogs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetSubjectLogsExample
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
                // Getsubjectlogs
                Object result = apiInstance.GetSubjectLogs(service, subject, dateStart, dateEnd, desc, limit, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.GetSubjectLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubjectLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Getsubjectlogs
    ApiResponse<Object> response = apiInstance.GetSubjectLogsWithHttpInfo(service, subject, dateStart, dateEnd, desc, limit, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoggingApi.GetSubjectLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **service** | **string** |  |  |
| **subject** | **string** |  |  |
| **dateStart** | **string** |  | [optional]  |
| **dateEnd** | **string** |  | [optional]  |
| **desc** | **bool?** |  | [optional] [default to true] |
| **limit** | **int?** |  | [optional] [default to 50] |
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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

