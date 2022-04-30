# Ehelply.Sdk.Api.MonitorApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost**](MonitorApi.md#ackalarmmonitorservicesservicestagesstagealarmsalarmuuidacknowledgepost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/acknowledge | Ack Alarm
[**AssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost**](MonitorApi.md#assignalarmmonitorservicesservicestagesstagealarmsalarmuuidassignpost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/assign | Assign Alarm
[**AttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost**](MonitorApi.md#attachalarmnotemonitorservicesservicestagesstagealarmsalarmuuidnotepost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/note | Attach Alarm Note
[**AttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost**](MonitorApi.md#attachalarmticketmonitorservicesservicestagesstagealarmsalarmuuidticketpost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/ticket | Attach Alarm Ticket
[**ClearAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidClearPost**](MonitorApi.md#clearalarmmonitorservicesservicestagesstagealarmsalarmuuidclearpost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/clear | Clear Alarm
[**GetServiceAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidGet**](MonitorApi.md#getservicealarmmonitorservicesservicestagesstagealarmsalarmuuidget) | **GET** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid} | Get Service Alarm
[**GetServiceAlarmsMonitorServicesServiceStagesStageAlarmsGet**](MonitorApi.md#getservicealarmsmonitorservicesservicestagesstagealarmsget) | **GET** /sam/monitor/services/{service}/stages/{stage}/alarms | Get Service Alarms
[**GetServiceHeartbeatsMonitorServicesServiceStagesStageHeartbeatsGet**](MonitorApi.md#getserviceheartbeatsmonitorservicesservicestagesstageheartbeatsget) | **GET** /sam/monitor/services/{service}/stages/{stage}/heartbeats | Get Service Heartbeats
[**GetServiceKpisMonitorServicesServiceKpisGet**](MonitorApi.md#getservicekpismonitorservicesservicekpisget) | **GET** /sam/monitor/services/{service}/kpis | Get Service Kpis
[**GetServiceMonitorServicesServiceGet**](MonitorApi.md#getservicemonitorservicesserviceget) | **GET** /sam/monitor/services/{service} | Get Service
[**GetServiceSpec**](MonitorApi.md#getservicespec) | **GET** /sam/monitor/services/{service}/specs/{spec} | Getservicespec
[**GetServiceSpecs**](MonitorApi.md#getservicespecs) | **GET** /sam/monitor/services/{service}/specs | Getservicespecs
[**GetServiceVitalsMonitorServicesServiceStagesStageVitalsGet**](MonitorApi.md#getservicevitalsmonitorservicesservicestagesstagevitalsget) | **GET** /sam/monitor/services/{service}/stages/{stage}/vitals | Get Service Vitals
[**GetServicesMonitorServicesGet**](MonitorApi.md#getservicesmonitorservicesget) | **GET** /sam/monitor/services | Get Services
[**GetServicesWithSpecs**](MonitorApi.md#getserviceswithspecs) | **GET** /sam/monitor/specs/services | Getserviceswithspecs
[**HideServiceMonitorServicesServiceStagesStageHidePost**](MonitorApi.md#hideservicemonitorservicesservicestagesstagehidepost) | **POST** /sam/monitor/services/{service}/stages/{stage}/hide | Hide Service
[**IgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost**](MonitorApi.md#ignorealarmmonitorservicesservicestagesstagealarmsalarmuuidignorepost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/ignore | Ignore Alarm
[**RegisterServiceMonitorServicesPost**](MonitorApi.md#registerservicemonitorservicespost) | **POST** /sam/monitor/services | Register Service
[**SearchAlarmsMonitorServicesServiceAlarmsGet**](MonitorApi.md#searchalarmsmonitorservicesservicealarmsget) | **GET** /sam/monitor/services/{service}/alarms | Search Alarms
[**ShowServiceMonitorServicesServiceStagesStageShowPost**](MonitorApi.md#showservicemonitorservicesservicestagesstageshowpost) | **POST** /sam/monitor/services/{service}/stages/{stage}/show | Show Service
[**TerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost**](MonitorApi.md#terminatealarmmonitorservicesservicestagesstagealarmsalarmuuidterminatepost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/terminate | Terminate Alarm
[**TriggerAlarmMonitorServicesServiceStagesStageAlarmsPost**](MonitorApi.md#triggeralarmmonitorservicesservicestagesstagealarmspost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms | Trigger Alarm


<a name="ackalarmmonitorservicesservicestagesstagealarmsalarmuuidacknowledgepost"></a>
# **AckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost**
> Object AckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost (string service, string stage, string alarmUuid, BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost bodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost)

Ack Alarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var bodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost = new BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost(); // BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost | 

            try
            {
                // Ack Alarm
                Object result = apiInstance.AckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost(service, stage, alarmUuid, bodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.AckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost: " + e.Message );
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
 **bodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost** | [**BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost**](BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost.md)|  | 

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

<a name="assignalarmmonitorservicesservicestagesstagealarmsalarmuuidassignpost"></a>
# **AssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost**
> Object AssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost (string service, string stage, string alarmUuid, BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost bodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost)

Assign Alarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var bodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost = new BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost(); // BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost | 

            try
            {
                // Assign Alarm
                Object result = apiInstance.AssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost(service, stage, alarmUuid, bodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.AssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost: " + e.Message );
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
 **bodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost** | [**BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost**](BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost.md)|  | 

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

<a name="attachalarmnotemonitorservicesservicestagesstagealarmsalarmuuidnotepost"></a>
# **AttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost**
> Object AttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost (string service, string stage, string alarmUuid, BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost bodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost)

Attach Alarm Note

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var bodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost = new BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost(); // BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost | 

            try
            {
                // Attach Alarm Note
                Object result = apiInstance.AttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost(service, stage, alarmUuid, bodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.AttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost: " + e.Message );
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
 **bodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost** | [**BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost**](BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost.md)|  | 

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

<a name="attachalarmticketmonitorservicesservicestagesstagealarmsalarmuuidticketpost"></a>
# **AttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost**
> Object AttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost (string service, string stage, string alarmUuid, BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost bodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost)

Attach Alarm Ticket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class AttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var bodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost = new BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost(); // BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost | 

            try
            {
                // Attach Alarm Ticket
                Object result = apiInstance.AttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost(service, stage, alarmUuid, bodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.AttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost: " + e.Message );
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
 **bodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost** | [**BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost**](BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost.md)|  | 

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

<a name="clearalarmmonitorservicesservicestagesstagealarmsalarmuuidclearpost"></a>
# **ClearAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidClearPost**
> Object ClearAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidClearPost (string service, string stage, string alarmUuid)

Clear Alarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ClearAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidClearPostExample
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
                // Clear Alarm
                Object result = apiInstance.ClearAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidClearPost(service, stage, alarmUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.ClearAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidClearPost: " + e.Message );
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

<a name="getservicealarmmonitorservicesservicestagesstagealarmsalarmuuidget"></a>
# **GetServiceAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidGet**
> Object GetServiceAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidGet (string service, string stage, string alarmUuid)

Get Service Alarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidGetExample
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
                // Get Service Alarm
                Object result = apiInstance.GetServiceAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidGet(service, stage, alarmUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidGet: " + e.Message );
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

<a name="getservicealarmsmonitorservicesservicestagesstagealarmsget"></a>
# **GetServiceAlarmsMonitorServicesServiceStagesStageAlarmsGet**
> Object GetServiceAlarmsMonitorServicesServiceStagesStageAlarmsGet (string service, string stage, int? history = null, bool? includeTerminated = null, bool? includeCleared = null)

Get Service Alarms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceAlarmsMonitorServicesServiceStagesStageAlarmsGetExample
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
                // Get Service Alarms
                Object result = apiInstance.GetServiceAlarmsMonitorServicesServiceStagesStageAlarmsGet(service, stage, history, includeTerminated, includeCleared);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceAlarmsMonitorServicesServiceStagesStageAlarmsGet: " + e.Message );
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

<a name="getserviceheartbeatsmonitorservicesservicestagesstageheartbeatsget"></a>
# **GetServiceHeartbeatsMonitorServicesServiceStagesStageHeartbeatsGet**
> Object GetServiceHeartbeatsMonitorServicesServiceStagesStageHeartbeatsGet (string service, string stage, int? history = null)

Get Service Heartbeats

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceHeartbeatsMonitorServicesServiceStagesStageHeartbeatsGetExample
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
                // Get Service Heartbeats
                Object result = apiInstance.GetServiceHeartbeatsMonitorServicesServiceStagesStageHeartbeatsGet(service, stage, history);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceHeartbeatsMonitorServicesServiceStagesStageHeartbeatsGet: " + e.Message );
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

<a name="getservicekpismonitorservicesservicekpisget"></a>
# **GetServiceKpisMonitorServicesServiceKpisGet**
> Object GetServiceKpisMonitorServicesServiceKpisGet (string service, int? history = null)

Get Service Kpis

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceKpisMonitorServicesServiceKpisGetExample
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
                // Get Service Kpis
                Object result = apiInstance.GetServiceKpisMonitorServicesServiceKpisGet(service, history);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceKpisMonitorServicesServiceKpisGet: " + e.Message );
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

<a name="getservicemonitorservicesserviceget"></a>
# **GetServiceMonitorServicesServiceGet**
> Object GetServiceMonitorServicesServiceGet (string service, bool? heartbeats = null, int? heartbeatLimit = null, bool? alarms = null, int? alarmLimit = null, string stage = null)

Get Service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceMonitorServicesServiceGetExample
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
                // Get Service
                Object result = apiInstance.GetServiceMonitorServicesServiceGet(service, heartbeats, heartbeatLimit, alarms, alarmLimit, stage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceMonitorServicesServiceGet: " + e.Message );
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

<a name="getservicespec"></a>
# **GetServiceSpec**
> InlineResponse2002 GetServiceSpec (string service, string spec, bool? asJson = null)

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
                InlineResponse2002 result = apiInstance.GetServiceSpec(service, spec, asJson);
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

[**InlineResponse2002**](InlineResponse2002.md)

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
> InlineResponse2001 GetServiceSpecs (string service)

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
                InlineResponse2001 result = apiInstance.GetServiceSpecs(service);
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

[**InlineResponse2001**](InlineResponse2001.md)

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

<a name="getservicevitalsmonitorservicesservicestagesstagevitalsget"></a>
# **GetServiceVitalsMonitorServicesServiceStagesStageVitalsGet**
> Object GetServiceVitalsMonitorServicesServiceStagesStageVitalsGet (string service, string stage, int? history = null)

Get Service Vitals

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServiceVitalsMonitorServicesServiceStagesStageVitalsGetExample
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
                // Get Service Vitals
                Object result = apiInstance.GetServiceVitalsMonitorServicesServiceStagesStageVitalsGet(service, stage, history);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServiceVitalsMonitorServicesServiceStagesStageVitalsGet: " + e.Message );
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

<a name="getservicesmonitorservicesget"></a>
# **GetServicesMonitorServicesGet**
> Object GetServicesMonitorServicesGet (bool? heartbeats = null, int? heartbeatLimit = null, bool? alarms = null, int? alarmLimit = null, bool? includeHidden = null, string stage = null, string key = null)

Get Services

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetServicesMonitorServicesGetExample
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
                // Get Services
                Object result = apiInstance.GetServicesMonitorServicesGet(heartbeats, heartbeatLimit, alarms, alarmLimit, includeHidden, stage, key);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.GetServicesMonitorServicesGet: " + e.Message );
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

<a name="getserviceswithspecs"></a>
# **GetServicesWithSpecs**
> InlineResponse200 GetServicesWithSpecs ()

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
                InlineResponse200 result = apiInstance.GetServicesWithSpecs();
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

[**InlineResponse200**](InlineResponse200.md)

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

<a name="hideservicemonitorservicesservicestagesstagehidepost"></a>
# **HideServiceMonitorServicesServiceStagesStageHidePost**
> Object HideServiceMonitorServicesServiceStagesStageHidePost (string service, string stage)

Hide Service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class HideServiceMonitorServicesServiceStagesStageHidePostExample
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
                // Hide Service
                Object result = apiInstance.HideServiceMonitorServicesServiceStagesStageHidePost(service, stage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.HideServiceMonitorServicesServiceStagesStageHidePost: " + e.Message );
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

<a name="ignorealarmmonitorservicesservicestagesstagealarmsalarmuuidignorepost"></a>
# **IgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost**
> Object IgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost (string service, string stage, string alarmUuid, BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost bodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost)

Ignore Alarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class IgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var bodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost = new BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost(); // BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost | 

            try
            {
                // Ignore Alarm
                Object result = apiInstance.IgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost(service, stage, alarmUuid, bodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.IgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost: " + e.Message );
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
 **bodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost** | [**BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost**](BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost.md)|  | 

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

<a name="registerservicemonitorservicespost"></a>
# **RegisterServiceMonitorServicesPost**
> Object RegisterServiceMonitorServicesPost (BodyRegisterServiceMonitorServicesPost bodyRegisterServiceMonitorServicesPost)

Register Service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class RegisterServiceMonitorServicesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var bodyRegisterServiceMonitorServicesPost = new BodyRegisterServiceMonitorServicesPost(); // BodyRegisterServiceMonitorServicesPost | 

            try
            {
                // Register Service
                Object result = apiInstance.RegisterServiceMonitorServicesPost(bodyRegisterServiceMonitorServicesPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.RegisterServiceMonitorServicesPost: " + e.Message );
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
 **bodyRegisterServiceMonitorServicesPost** | [**BodyRegisterServiceMonitorServicesPost**](BodyRegisterServiceMonitorServicesPost.md)|  | 

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

<a name="searchalarmsmonitorservicesservicealarmsget"></a>
# **SearchAlarmsMonitorServicesServiceAlarmsGet**
> Object SearchAlarmsMonitorServicesServiceAlarmsGet (string service, int? page = null, int? pageSize = null, string search = null, string searchOn = null, string sortOn = null, bool? sortDesc = null)

Search Alarms

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchAlarmsMonitorServicesServiceAlarmsGetExample
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
                // Search Alarms
                Object result = apiInstance.SearchAlarmsMonitorServicesServiceAlarmsGet(service, page, pageSize, search, searchOn, sortOn, sortDesc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.SearchAlarmsMonitorServicesServiceAlarmsGet: " + e.Message );
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

<a name="showservicemonitorservicesservicestagesstageshowpost"></a>
# **ShowServiceMonitorServicesServiceStagesStageShowPost**
> Object ShowServiceMonitorServicesServiceStagesStageShowPost (string service, string stage)

Show Service

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ShowServiceMonitorServicesServiceStagesStageShowPostExample
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
                // Show Service
                Object result = apiInstance.ShowServiceMonitorServicesServiceStagesStageShowPost(service, stage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.ShowServiceMonitorServicesServiceStagesStageShowPost: " + e.Message );
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

<a name="terminatealarmmonitorservicesservicestagesstagealarmsalarmuuidterminatepost"></a>
# **TerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost**
> Object TerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost (string service, string stage, string alarmUuid, BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost bodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost)

Terminate Alarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class TerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var alarmUuid = "alarmUuid_example";  // string | 
            var bodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost = new BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost(); // BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost | 

            try
            {
                // Terminate Alarm
                Object result = apiInstance.TerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost(service, stage, alarmUuid, bodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.TerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost: " + e.Message );
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
 **bodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost** | [**BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost**](BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost.md)|  | 

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

<a name="triggeralarmmonitorservicesservicestagesstagealarmspost"></a>
# **TriggerAlarmMonitorServicesServiceStagesStageAlarmsPost**
> Object TriggerAlarmMonitorServicesServiceStagesStageAlarmsPost (string service, string stage, BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost bodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost)

Trigger Alarm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class TriggerAlarmMonitorServicesServiceStagesStageAlarmsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new MonitorApi(config);
            var service = "service_example";  // string | 
            var stage = "stage_example";  // string | 
            var bodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost = new BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost(); // BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost | 

            try
            {
                // Trigger Alarm
                Object result = apiInstance.TriggerAlarmMonitorServicesServiceStagesStageAlarmsPost(service, stage, bodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitorApi.TriggerAlarmMonitorServicesServiceStagesStageAlarmsPost: " + e.Message );
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
 **bodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost** | [**BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost**](BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost.md)|  | 

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

