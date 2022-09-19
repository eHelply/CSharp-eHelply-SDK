# Ehelply.Sdk.Api.LoggingApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSubjectLogs**](LoggingApi.md#getsubjectlogs) | **GET** /sam/logging/logs/services/{service}/subjects/{subject} | Getsubjectlogs


<a name="getsubjectlogs"></a>
# **GetSubjectLogs**
> List&lt;LoggingDynamo&gt; GetSubjectLogs (string service, string subject, string dateStart = null, string dateEnd = null, bool? desc = null, int? limit = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

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
                List<LoggingDynamo> result = apiInstance.GetSubjectLogs(service, subject, dateStart, dateEnd, desc, limit, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoggingApi.GetSubjectLogs: " + e.Message );
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

