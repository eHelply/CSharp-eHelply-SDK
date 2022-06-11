# Ehelply.Sdk.Api.MonitorApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcknowledgeAlarm**](MonitorApi.md#acknowledgealarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/acknowledge | Acknowledgealarm
[**AssignAlarm**](MonitorApi.md#assignalarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/assign | Assignalarm
[**AttachAlarmNote**](MonitorApi.md#attachalarmnote) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/note | Attachalarmnote
[**AttachAlarmTicket**](MonitorApi.md#attachalarmticket) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/ticket | Attachalarmticket
[**ClearAlarm**](MonitorApi.md#clearalarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/clear | Clearalarm
[**GetService**](MonitorApi.md#getservice) | **GET** /sam/monitor/services/{service} | Getservice
[**GetServiceAlarm**](MonitorApi.md#getservicealarm) | **GET** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid} | Getservicealarm
[**GetServiceAlarms**](MonitorApi.md#getservicealarms) | **GET** /sam/monitor/services/{service}/stages/{stage}/alarms | Getservicealarms
[**GetServiceHeartbeat**](MonitorApi.md#getserviceheartbeat) | **GET** /sam/monitor/services/{service}/stages/{stage}/heartbeats | Getserviceheartbeat
[**GetServiceKpis**](MonitorApi.md#getservicekpis) | **GET** /sam/monitor/services/{service}/kpis | Getservicekpis
[**GetServiceSpec**](MonitorApi.md#getservicespec) | **GET** /sam/monitor/services/{service}/specs/{spec} | Getservicespec
[**GetServiceSpecs**](MonitorApi.md#getservicespecs) | **GET** /sam/monitor/services/{service}/specs | Getservicespecs
[**GetServiceVitals**](MonitorApi.md#getservicevitals) | **GET** /sam/monitor/services/{service}/stages/{stage}/vitals | Getservicevitals
[**GetServices**](MonitorApi.md#getservices) | **GET** /sam/monitor/services | Getservices
[**GetServicesWithSpecs**](MonitorApi.md#getserviceswithspecs) | **GET** /sam/monitor/specs/services | Getserviceswithspecs
[**HideService**](MonitorApi.md#hideservice) | **POST** /sam/monitor/services/{service}/stages/{stage}/hide | Hideservice
[**IgnoreAlarm**](MonitorApi.md#ignorealarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/ignore | Ignorealarm
[**RegisterService**](MonitorApi.md#registerservice) | **POST** /sam/monitor/services | Registerservice
[**SearchAlarms**](MonitorApi.md#searchalarms) | **GET** /sam/monitor/services/{service}/alarms | Searchalarms
[**ShowService**](MonitorApi.md#showservice) | **POST** /sam/monitor/services/{service}/stages/{stage}/show | Showservice
[**TerminateAlarm**](MonitorApi.md#terminatealarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/terminate | Terminatealarm
[**TriggerAlarm**](MonitorApi.md#triggeralarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms | Triggeralarm


<a name="acknowledgealarm"></a>
# **AcknowledgeAlarm**
> AlarmResponse AcknowledgeAlarm (string service, string stage, string alarmUuid, AlarmAcknowledge alarmAcknowledge)

Acknowledgealarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AcknowledgeAlarmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var alarmAcknowledge = new AlarmAcknowledge(); // AlarmAcknowledge | 

            try
            {
                // Acknowledgealarm
                AlarmResponse result = apiInstance.AcknowledgeAlarm(service, stage, alarmUuid, alarmAcknowledge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.AcknowledgeAlarm: " + e.Message );
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
 **stage** | **string**|  | 
 **alarmUuid** | **string**|  | 
 **alarmAcknowledge** | [**AlarmAcknowledge**](AlarmAcknowledge.md)|  | 

### Return type

[**AlarmResponse**](AlarmResponse.md)

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

<a name="assignalarm"></a>
# **AssignAlarm**
> AlarmResponse AssignAlarm (string service, string stage, string alarmUuid, AlarmAssign alarmAssign)

Assignalarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AssignAlarmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var alarmAssign = new AlarmAssign(); // AlarmAssign | 

            try
            {
                // Assignalarm
                AlarmResponse result = apiInstance.AssignAlarm(service, stage, alarmUuid, alarmAssign);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.AssignAlarm: " + e.Message );
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
 **stage** | **string**|  | 
 **alarmUuid** | **string**|  | 
 **alarmAssign** | [**AlarmAssign**](AlarmAssign.md)|  | 

### Return type

[**AlarmResponse**](AlarmResponse.md)

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

<a name="attachalarmnote"></a>
# **AttachAlarmNote**
> AlarmResponse AttachAlarmNote (string service, string stage, string alarmUuid, AlarmNote alarmNote)

Attachalarmnote

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AttachAlarmNoteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var alarmNote = new AlarmNote(); // AlarmNote | 

            try
            {
                // Attachalarmnote
                AlarmResponse result = apiInstance.AttachAlarmNote(service, stage, alarmUuid, alarmNote);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.AttachAlarmNote: " + e.Message );
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
 **stage** | **string**|  | 
 **alarmUuid** | **string**|  | 
 **alarmNote** | [**AlarmNote**](AlarmNote.md)|  | 

### Return type

[**AlarmResponse**](AlarmResponse.md)

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

<a name="attachalarmticket"></a>
# **AttachAlarmTicket**
> AlarmResponse AttachAlarmTicket (string service, string stage, string alarmUuid, AlarmTicket alarmTicket)

Attachalarmticket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AttachAlarmTicketExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var alarmTicket = new AlarmTicket(); // AlarmTicket | 

            try
            {
                // Attachalarmticket
                AlarmResponse result = apiInstance.AttachAlarmTicket(service, stage, alarmUuid, alarmTicket);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.AttachAlarmTicket: " + e.Message );
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
 **stage** | **string**|  | 
 **alarmUuid** | **string**|  | 
 **alarmTicket** | [**AlarmTicket**](AlarmTicket.md)|  | 

### Return type

[**AlarmResponse**](AlarmResponse.md)

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

<a name="clearalarm"></a>
# **ClearAlarm**
> AlarmResponse ClearAlarm (string service, string stage, string alarmUuid)

Clearalarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ClearAlarmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 

            try
            {
                // Clearalarm
                AlarmResponse result = apiInstance.ClearAlarm(service, stage, alarmUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.ClearAlarm: " + e.Message );
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
 **stage** | **string**|  | 
 **alarmUuid** | **string**|  | 

### Return type

[**AlarmResponse**](AlarmResponse.md)

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

<a name="getservice"></a>
# **GetService**
> ServiceResponse GetService (string service, bool? heartbeats = null, int? heartbeatLimit = null, bool? alarms = null, int? alarmLimit = null, string stage = null)

Getservice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var heartbeats = false;  // bool? |  (optional)  (default to false)
            var heartbeatLimit = 5;  // int? |  (optional)  (default to 5)
            var alarms = false;  // bool? |  (optional)  (default to false)
            var alarmLimit = 5;  // int? |  (optional)  (default to 5)
            var stage = "stage_example";  // string |  (optional) 

            try
            {
                // Getservice
                ServiceResponse result = apiInstance.GetService(service, heartbeats, heartbeatLimit, alarms, alarmLimit, stage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetService: " + e.Message );
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
 **heartbeats** | **bool?**|  | [optional] [default to false]
 **heartbeatLimit** | **int?**|  | [optional] [default to 5]
 **alarms** | **bool?**|  | [optional] [default to false]
 **alarmLimit** | **int?**|  | [optional] [default to 5]
 **stage** | **string**|  | [optional] 

### Return type

[**ServiceResponse**](ServiceResponse.md)

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

<a name="getservicealarm"></a>
# **GetServiceAlarm**
> AlarmResponse GetServiceAlarm (string service, string stage, string alarmUuid)

Getservicealarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceAlarmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 

            try
            {
                // Getservicealarm
                AlarmResponse result = apiInstance.GetServiceAlarm(service, stage, alarmUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceAlarm: " + e.Message );
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
 **stage** | **string**|  | 
 **alarmUuid** | **string**|  | 

### Return type

[**AlarmResponse**](AlarmResponse.md)

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

<a name="getservicealarms"></a>
# **GetServiceAlarms**
> List&lt;AlarmResponse&gt; GetServiceAlarms (string service, string stage, int? history = null, bool? includeTerminated = null, bool? includeCleared = null)

Getservicealarms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceAlarmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var history = 5;  // int? |  (optional)  (default to 5)
            var includeTerminated = false;  // bool? |  (optional)  (default to false)
            var includeCleared = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Getservicealarms
                List<AlarmResponse> result = apiInstance.GetServiceAlarms(service, stage, history, includeTerminated, includeCleared);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceAlarms: " + e.Message );
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
 **stage** | **string**|  | 
 **history** | **int?**|  | [optional] [default to 5]
 **includeTerminated** | **bool?**|  | [optional] [default to false]
 **includeCleared** | **bool?**|  | [optional] [default to false]

### Return type

[**List&lt;AlarmResponse&gt;**](AlarmResponse.md)

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

<a name="getserviceheartbeat"></a>
# **GetServiceHeartbeat**
> List&lt;HeartbeatResponse&gt; GetServiceHeartbeat (string service, string stage, int? history = null)

Getserviceheartbeat

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceHeartbeatExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var history = 5;  // int? |  (optional)  (default to 5)

            try
            {
                // Getserviceheartbeat
                List<HeartbeatResponse> result = apiInstance.GetServiceHeartbeat(service, stage, history);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceHeartbeat: " + e.Message );
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
 **stage** | **string**|  | 
 **history** | **int?**|  | [optional] [default to 5]

### Return type

[**List&lt;HeartbeatResponse&gt;**](HeartbeatResponse.md)

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

<a name="getservicekpis"></a>
# **GetServiceKpis**
> List&lt;KpiResponse&gt; GetServiceKpis (string service, int? history = null)

Getservicekpis

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceKpisExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var history = 5;  // int? |  (optional)  (default to 5)

            try
            {
                // Getservicekpis
                List<KpiResponse> result = apiInstance.GetServiceKpis(service, history);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceKpis: " + e.Message );
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
 **history** | **int?**|  | [optional] [default to 5]

### Return type

[**List&lt;KpiResponse&gt;**](KpiResponse.md)

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

<a name="getservicespec"></a>
# **GetServiceSpec**
> ResponseGetservicespec GetServiceSpec (string service, string spec, bool? asJson = null)

Getservicespec

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceSpecExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var spec = "spec_example";  // string | 
            var asJson = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Getservicespec
                ResponseGetservicespec result = apiInstance.GetServiceSpec(service, spec, asJson);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceSpec: " + e.Message );
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
 **spec** | **string**|  | 
 **asJson** | **bool?**|  | [optional] [default to false]

### Return type

[**ResponseGetservicespec**](ResponseGetservicespec.md)

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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservicespecs"></a>
# **GetServiceSpecs**
> ResponseGetservicespecs GetServiceSpecs (string service)

Getservicespecs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceSpecsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 

            try
            {
                // Getservicespecs
                ResponseGetservicespecs result = apiInstance.GetServiceSpecs(service);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceSpecs: " + e.Message );
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

### Return type

[**ResponseGetservicespecs**](ResponseGetservicespecs.md)

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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getservicevitals"></a>
# **GetServiceVitals**
> List&lt;StatsVitalsResponse&gt; GetServiceVitals (string service, string stage, int? history = null)

Getservicevitals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceVitalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var history = 5;  // int? |  (optional)  (default to 5)

            try
            {
                // Getservicevitals
                List<StatsVitalsResponse> result = apiInstance.GetServiceVitals(service, stage, history);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceVitals: " + e.Message );
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
 **stage** | **string**|  | 
 **history** | **int?**|  | [optional] [default to 5]

### Return type

[**List&lt;StatsVitalsResponse&gt;**](StatsVitalsResponse.md)

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

<a name="getservices"></a>
# **GetServices**
> List&lt;ServiceResponse&gt; GetServices (bool? heartbeats = null, int? heartbeatLimit = null, bool? alarms = null, int? alarmLimit = null, bool? includeHidden = null, string stage = null, string key = null)

Getservices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var heartbeats = false;  // bool? |  (optional)  (default to false)
            var heartbeatLimit = 5;  // int? |  (optional)  (default to 5)
            var alarms = false;  // bool? |  (optional)  (default to false)
            var alarmLimit = 5;  // int? |  (optional)  (default to 5)
            var includeHidden = false;  // bool? |  (optional)  (default to false)
            var stage = "stage_example";  // string |  (optional) 
            var key = "key_example";  // string |  (optional) 

            try
            {
                // Getservices
                List<ServiceResponse> result = apiInstance.GetServices(heartbeats, heartbeatLimit, alarms, alarmLimit, includeHidden, stage, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServices: " + e.Message );
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
 **heartbeats** | **bool?**|  | [optional] [default to false]
 **heartbeatLimit** | **int?**|  | [optional] [default to 5]
 **alarms** | **bool?**|  | [optional] [default to false]
 **alarmLimit** | **int?**|  | [optional] [default to 5]
 **includeHidden** | **bool?**|  | [optional] [default to false]
 **stage** | **string**|  | [optional] 
 **key** | **string**|  | [optional] 

### Return type

[**List&lt;ServiceResponse&gt;**](ServiceResponse.md)

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

<a name="getserviceswithspecs"></a>
# **GetServicesWithSpecs**
> ResponseGetserviceswithspecs GetServicesWithSpecs ()

Getserviceswithspecs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServicesWithSpecsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);

            try
            {
                // Getserviceswithspecs
                ResponseGetserviceswithspecs result = apiInstance.GetServicesWithSpecs();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServicesWithSpecs: " + e.Message );
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

[**ResponseGetserviceswithspecs**](ResponseGetserviceswithspecs.md)

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
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hideservice"></a>
# **HideService**
> ServiceMessageResponse HideService (string service, string stage)

Hideservice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class HideServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 

            try
            {
                // Hideservice
                ServiceMessageResponse result = apiInstance.HideService(service, stage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.HideService: " + e.Message );
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
 **stage** | **string**|  | 

### Return type

[**ServiceMessageResponse**](ServiceMessageResponse.md)

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

<a name="ignorealarm"></a>
# **IgnoreAlarm**
> AlarmResponse IgnoreAlarm (string service, string stage, string alarmUuid, AlarmIgnore alarmIgnore)

Ignorealarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class IgnoreAlarmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var alarmIgnore = new AlarmIgnore(); // AlarmIgnore | 

            try
            {
                // Ignorealarm
                AlarmResponse result = apiInstance.IgnoreAlarm(service, stage, alarmUuid, alarmIgnore);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.IgnoreAlarm: " + e.Message );
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
 **stage** | **string**|  | 
 **alarmUuid** | **string**|  | 
 **alarmIgnore** | [**AlarmIgnore**](AlarmIgnore.md)|  | 

### Return type

[**AlarmResponse**](AlarmResponse.md)

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

<a name="registerservice"></a>
# **RegisterService**
> ServiceResponse RegisterService (ServiceCreate serviceCreate)

Registerservice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class RegisterServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var serviceCreate = new ServiceCreate(); // ServiceCreate | 

            try
            {
                // Registerservice
                ServiceResponse result = apiInstance.RegisterService(serviceCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.RegisterService: " + e.Message );
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
 **serviceCreate** | [**ServiceCreate**](ServiceCreate.md)|  | 

### Return type

[**ServiceResponse**](ServiceResponse.md)

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

<a name="searchalarms"></a>
# **SearchAlarms**
> Page SearchAlarms (string service, int? page = null, int? pageSize = null, string search = null, string searchOn = null, string sortOn = null, bool? sortDesc = null)

Searchalarms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchAlarmsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var page = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 25;  // int? |  (optional)  (default to 25)
            var search = "search_example";  // string |  (optional) 
            var searchOn = "searchOn_example";  // string |  (optional) 
            var sortOn = "sortOn_example";  // string |  (optional) 
            var sortDesc = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Searchalarms
                Page result = apiInstance.SearchAlarms(service, page, pageSize, search, searchOn, sortOn, sortDesc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.SearchAlarms: " + e.Message );
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
 **page** | **int?**|  | [optional] [default to 1]
 **pageSize** | **int?**|  | [optional] [default to 25]
 **search** | **string**|  | [optional] 
 **searchOn** | **string**|  | [optional] 
 **sortOn** | **string**|  | [optional] 
 **sortDesc** | **bool?**|  | [optional] [default to false]

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

<a name="showservice"></a>
# **ShowService**
> ServiceMessageResponse ShowService (string service, string stage)

Showservice

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ShowServiceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 

            try
            {
                // Showservice
                ServiceMessageResponse result = apiInstance.ShowService(service, stage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.ShowService: " + e.Message );
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
 **stage** | **string**|  | 

### Return type

[**ServiceMessageResponse**](ServiceMessageResponse.md)

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

<a name="terminatealarm"></a>
# **TerminateAlarm**
> AlarmResponse TerminateAlarm (string service, string stage, string alarmUuid, AlarmTerminate alarmTerminate)

Terminatealarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class TerminateAlarmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var alarmTerminate = new AlarmTerminate(); // AlarmTerminate | 

            try
            {
                // Terminatealarm
                AlarmResponse result = apiInstance.TerminateAlarm(service, stage, alarmUuid, alarmTerminate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.TerminateAlarm: " + e.Message );
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
 **stage** | **string**|  | 
 **alarmUuid** | **string**|  | 
 **alarmTerminate** | [**AlarmTerminate**](AlarmTerminate.md)|  | 

### Return type

[**AlarmResponse**](AlarmResponse.md)

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

<a name="triggeralarm"></a>
# **TriggerAlarm**
> AlarmResponse TriggerAlarm (string service, string stage, AlarmCreate alarmCreate)

Triggeralarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class TriggerAlarmExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmCreate = new AlarmCreate(); // AlarmCreate | 

            try
            {
                // Triggeralarm
                AlarmResponse result = apiInstance.TriggerAlarm(service, stage, alarmCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.TriggerAlarm: " + e.Message );
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
 **stage** | **string**|  | 
 **alarmCreate** | [**AlarmCreate**](AlarmCreate.md)|  | 

### Return type

[**AlarmResponse**](AlarmResponse.md)

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

