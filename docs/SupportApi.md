# Ehelply.Sdk.Api.SupportApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateContactSupportContactPost**](SupportApi.md#createcontactsupportcontactpost) | **POST** /sam/support/contact | Create Contact
[**CreateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsPost**](SupportApi.md#createticketsupportprojectsprojectuuidmembersmemberuuidticketspost) | **POST** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets | Create Ticket
[**DeleteContactSupportContactDelete**](SupportApi.md#deletecontactsupportcontactdelete) | **DELETE** /sam/support/contact | Delete Contact
[**ListTicketsSupportProjectsProjectUuidMembersMemberUuidTicketsGet**](SupportApi.md#listticketssupportprojectsprojectuuidmembersmemberuuidticketsget) | **GET** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets | List Tickets
[**UpdateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdPut**](SupportApi.md#updateticketsupportprojectsprojectuuidmembersmemberuuidticketsticketidput) | **PUT** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets/{ticket_id} | Update Ticket
[**ViewTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdGet**](SupportApi.md#viewticketsupportprojectsprojectuuidmembersmemberuuidticketsticketidget) | **GET** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets/{ticket_id} | View Ticket


<a name="createcontactsupportcontactpost"></a>
# **CreateContactSupportContactPost**
> ContactResponse CreateContactSupportContactPost (Contact contact, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Create Contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateContactSupportContactPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SupportApi(config);
            var contact = new Contact(); // Contact | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Create Contact
                ContactResponse result = apiInstance.CreateContactSupportContactPost(contact, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupportApi.CreateContactSupportContactPost: " + e.Message );
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
 **contact** | [**Contact**](Contact.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**ContactResponse**](ContactResponse.md)

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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createticketsupportprojectsprojectuuidmembersmemberuuidticketspost"></a>
# **CreateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsPost**
> TicketResponse CreateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsPost (string projectUuid, string memberUuid, CreateTicket createTicket, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Create Ticket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SupportApi(config);
            var projectUuid = projectUuid_example;  // string | 
            var memberUuid = memberUuid_example;  // string | 
            var createTicket = new CreateTicket(); // CreateTicket | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Create Ticket
                TicketResponse result = apiInstance.CreateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsPost(projectUuid, memberUuid, createTicket, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupportApi.CreateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsPost: " + e.Message );
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
 **projectUuid** | **string**|  | 
 **memberUuid** | **string**|  | 
 **createTicket** | [**CreateTicket**](CreateTicket.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**TicketResponse**](TicketResponse.md)

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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontactsupportcontactdelete"></a>
# **DeleteContactSupportContactDelete**
> Object DeleteContactSupportContactDelete (string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Delete Contact

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteContactSupportContactDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SupportApi(config);
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Delete Contact
                Object result = apiInstance.DeleteContactSupportContactDelete(xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupportApi.DeleteContactSupportContactDelete: " + e.Message );
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

<a name="listticketssupportprojectsprojectuuidmembersmemberuuidticketsget"></a>
# **ListTicketsSupportProjectsProjectUuidMembersMemberUuidTicketsGet**
> List&lt;TicketsResponse&gt; ListTicketsSupportProjectsProjectUuidMembersMemberUuidTicketsGet (string projectUuid, string memberUuid, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

List Tickets

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ListTicketsSupportProjectsProjectUuidMembersMemberUuidTicketsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SupportApi(config);
            var projectUuid = projectUuid_example;  // string | 
            var memberUuid = memberUuid_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // List Tickets
                List<TicketsResponse> result = apiInstance.ListTicketsSupportProjectsProjectUuidMembersMemberUuidTicketsGet(projectUuid, memberUuid, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupportApi.ListTicketsSupportProjectsProjectUuidMembersMemberUuidTicketsGet: " + e.Message );
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
 **projectUuid** | **string**|  | 
 **memberUuid** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**List&lt;TicketsResponse&gt;**](TicketsResponse.md)

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
| **404** | Record does not exist |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateticketsupportprojectsprojectuuidmembersmemberuuidticketsticketidput"></a>
# **UpdateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdPut**
> TicketResponse UpdateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdPut (string projectUuid, string memberUuid, string ticketId, CreateTicket createTicket, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Update Ticket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SupportApi(config);
            var projectUuid = projectUuid_example;  // string | 
            var memberUuid = memberUuid_example;  // string | 
            var ticketId = ticketId_example;  // string | 
            var createTicket = new CreateTicket(); // CreateTicket | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // Update Ticket
                TicketResponse result = apiInstance.UpdateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdPut(projectUuid, memberUuid, ticketId, createTicket, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupportApi.UpdateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdPut: " + e.Message );
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
 **projectUuid** | **string**|  | 
 **memberUuid** | **string**|  | 
 **ticketId** | **string**|  | 
 **createTicket** | [**CreateTicket**](CreateTicket.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**TicketResponse**](TicketResponse.md)

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
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="viewticketsupportprojectsprojectuuidmembersmemberuuidticketsticketidget"></a>
# **ViewTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdGet**
> TicketResponse ViewTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdGet (string projectUuid, string memberUuid, string ticketId, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

View Ticket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ViewTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SupportApi(config);
            var projectUuid = projectUuid_example;  // string | 
            var memberUuid = memberUuid_example;  // string | 
            var ticketId = ticketId_example;  // string | 
            var xAccessToken = xAccessToken_example;  // string |  (optional) 
            var xSecretToken = xSecretToken_example;  // string |  (optional) 
            var authorization = authorization_example;  // string |  (optional) 
            var ehelplyActiveParticipant = ehelplyActiveParticipant_example;  // string |  (optional) 
            var ehelplyProject = ehelplyProject_example;  // string |  (optional) 
            var ehelplyData = ehelplyData_example;  // string |  (optional) 

            try
            {
                // View Ticket
                TicketResponse result = apiInstance.ViewTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdGet(projectUuid, memberUuid, ticketId, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SupportApi.ViewTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdGet: " + e.Message );
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
 **projectUuid** | **string**|  | 
 **memberUuid** | **string**|  | 
 **ticketId** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**TicketResponse**](TicketResponse.md)

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

