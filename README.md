# Ehelply.Sdk - the C# library for the eHelply SDK - 1.1.57

eHelply SDK for SuperStack Services

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.1.57
- SDK version: 1.1.57
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://superstack.ehelply.com/support](https://superstack.ehelply.com/support)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new AuthApi(config);
            var userPasswordResetConfirmation = new UserPasswordResetConfirmation(); // UserPasswordResetConfirmation | 

            try
            {
                // Reset Password Confirmation
                Object result = apiInstance.ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost(userPasswordResetConfirmation);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthApi.ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.prod.ehelply.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthApi* | [**ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost**](docs/AuthApi.md#resetpasswordconfirmationusersauthpasswordresetconfirmpost) | **POST** /sam/users/auth/password/reset/confirm | Reset Password Confirmation
*BillingApi* | [**AttachPaymentToProjectBillingAttachPaymentToProjectPost**](docs/BillingApi.md#attachpaymenttoprojectbillingattachpaymenttoprojectpost) | **POST** /sam/billing/attach_payment_to_project | Attach Payment To Project
*BillingApi* | [**AttachPaymentToProjectBillingAttachPaymentToProjectPost_0**](docs/BillingApi.md#attachpaymenttoprojectbillingattachpaymenttoprojectpost_0) | **POST** /sam/billing/attach_payment_to_project | Attach Payment To Project
*BillingApi* | [**CreateBillingAccountBillingCreateBillingAccountPost**](docs/BillingApi.md#createbillingaccountbillingcreatebillingaccountpost) | **POST** /sam/billing/create_billing_account | Create Billing Account
*BillingApi* | [**CreateBillingAccountBillingCreateBillingAccountPost_0**](docs/BillingApi.md#createbillingaccountbillingcreatebillingaccountpost_0) | **POST** /sam/billing/create_billing_account | Create Billing Account
*BillingApi* | [**DeleteBillingAccountBillingDeleteBillingAccountDelete**](docs/BillingApi.md#deletebillingaccountbillingdeletebillingaccountdelete) | **DELETE** /sam/billing/delete_billing_account | Delete Billing Account
*BillingApi* | [**DeleteBillingAccountBillingDeleteBillingAccountDelete_0**](docs/BillingApi.md#deletebillingaccountbillingdeletebillingaccountdelete_0) | **DELETE** /sam/billing/delete_billing_account | Delete Billing Account
*BillingApi* | [**GetClientSecretBillingRetrieveSecretGet**](docs/BillingApi.md#getclientsecretbillingretrievesecretget) | **GET** /sam/billing/retrieve_secret | Get Client Secret
*BillingApi* | [**GetClientSecretBillingRetrieveSecretGet_0**](docs/BillingApi.md#getclientsecretbillingretrievesecretget_0) | **GET** /sam/billing/retrieve_secret | Get Client Secret
*BillingApi* | [**HasPaymentBillingHasPaymentGet**](docs/BillingApi.md#haspaymentbillinghaspaymentget) | **GET** /sam/billing/has_payment | Has Payment
*BillingApi* | [**HasPaymentBillingHasPaymentGet_0**](docs/BillingApi.md#haspaymentbillinghaspaymentget_0) | **GET** /sam/billing/has_payment | Has Payment
*BillingApi* | [**ProcessPaymentBillingProcessPaymentPost**](docs/BillingApi.md#processpaymentbillingprocesspaymentpost) | **POST** /sam/billing/process_payment | Process Payment
*BillingApi* | [**ProcessPaymentBillingProcessPaymentPost_0**](docs/BillingApi.md#processpaymentbillingprocesspaymentpost_0) | **POST** /sam/billing/process_payment | Process Payment
*BillingApi* | [**ReconcilePaymentMethodsBillingReconcilePaymentGet**](docs/BillingApi.md#reconcilepaymentmethodsbillingreconcilepaymentget) | **GET** /sam/billing/reconcile_payment | Reconcile Payment Methods
*BillingApi* | [**RemovePaymentMethodBillingRemovePaymentMethodDelete**](docs/BillingApi.md#removepaymentmethodbillingremovepaymentmethoddelete) | **DELETE** /sam/billing/remove_payment_method | Remove Payment Method
*BillingApi* | [**RemovePaymentMethodBillingRemovePaymentMethodDelete_0**](docs/BillingApi.md#removepaymentmethodbillingremovepaymentmethoddelete_0) | **DELETE** /sam/billing/remove_payment_method | Remove Payment Method
*BillingApi* | [**ViewPaymentMethodBillingViewPaymentMethodGet**](docs/BillingApi.md#viewpaymentmethodbillingviewpaymentmethodget) | **GET** /sam/billing/view_payment_method | View Payment Method
*BillingApi* | [**ViewPaymentMethodBillingViewPaymentMethodGet_0**](docs/BillingApi.md#viewpaymentmethodbillingviewpaymentmethodget_0) | **GET** /sam/billing/view_payment_method | View Payment Method
*DefaultApi* | [**AttachEntityToAppointment**](docs/DefaultApi.md#attachentitytoappointment) | **POST** /appointments/{appointment_uuid}/entities/{entity_uuid} | Attach Entity To Appointment
*DefaultApi* | [**AttachProductToCatalog**](docs/DefaultApi.md#attachproducttocatalog) | **POST** /catalogs/{catalog_uuid}/products/{product_uuid} | Attach Product To Catalog
*DefaultApi* | [**CreateAppointment**](docs/DefaultApi.md#createappointment) | **POST** /appointments | Create Appointment
*DefaultApi* | [**CreateCatalog**](docs/DefaultApi.md#createcatalog) | **POST** /catalogs | Create Catalog
*DefaultApi* | [**CreateProduct**](docs/DefaultApi.md#createproduct) | **POST** /products | Create Product
*DefaultApi* | [**CreateReview**](docs/DefaultApi.md#createreview) | **POST** /reviews/types/{entity_type}/entities/{entity_uuid} | Create Review
*DefaultApi* | [**DeleteAppointment**](docs/DefaultApi.md#deleteappointment) | **DELETE** /appointments/{appointment_uuid} | Delete Appointment
*DefaultApi* | [**DeleteCatalog**](docs/DefaultApi.md#deletecatalog) | **DELETE** /catalogs/{catalog_uuid} | Delete Catalog
*DefaultApi* | [**DeleteProduct**](docs/DefaultApi.md#deleteproduct) | **DELETE** /products/{product_uuid} | Delete Product
*DefaultApi* | [**DeleteReview**](docs/DefaultApi.md#deletereview) | **DELETE** /reviews/types/{entity_type}/entities/{entity_uuid}/reviews/{review_uuid} | Delete Review
*DefaultApi* | [**DetachEntityFromAppointment**](docs/DefaultApi.md#detachentityfromappointment) | **DELETE** /appointments/{appointment_uuid}/entities/{entity_uuid} | Detach Entity From Appointment
*DefaultApi* | [**DetachProductFromCatalog**](docs/DefaultApi.md#detachproductfromcatalog) | **DELETE** /catalogs/{catalog_uuid}/products/{product_uuid} | Detach Product From Catalog
*DefaultApi* | [**GetAppointment**](docs/DefaultApi.md#getappointment) | **GET** /appointments/{appointment_uuid} | Get Appointment
*DefaultApi* | [**GetCatalog**](docs/DefaultApi.md#getcatalog) | **GET** /catalogs/{catalog_uuid} | Get Catalog
*DefaultApi* | [**GetProduct**](docs/DefaultApi.md#getproduct) | **GET** /products/{product_uuid} | Get Product
*DefaultApi* | [**GetReview**](docs/DefaultApi.md#getreview) | **GET** /reviews/types/{entity_type}/entities/{entity_uuid}/reviews/{review_uuid} | Get Review
*DefaultApi* | [**SearchAppointment**](docs/DefaultApi.md#searchappointment) | **GET** /appointments | Search Appointment
*DefaultApi* | [**SearchAppointmentEntities**](docs/DefaultApi.md#searchappointmententities) | **GET** /appointments/{appointment_uuid}/entities | Search Appointment Entities
*DefaultApi* | [**SearchCatalogProducts**](docs/DefaultApi.md#searchcatalogproducts) | **GET** /catalogs/{catalog_uuid}/products | Search Catalog Products
*DefaultApi* | [**SearchCatalogs**](docs/DefaultApi.md#searchcatalogs) | **GET** /catalogs | Search Catalogs
*DefaultApi* | [**SearchProduct**](docs/DefaultApi.md#searchproduct) | **GET** /products | Search Products
*DefaultApi* | [**SearchProductCatalog**](docs/DefaultApi.md#searchproductcatalog) | **GET** /products/{product_uuid}/catalogs | Search Product Catalogs
*DefaultApi* | [**SearchReviews**](docs/DefaultApi.md#searchreviews) | **GET** /reviews/types/{entity_type}/entities/{entity_uuid} | Search Review
*DefaultApi* | [**UpdateAppointment**](docs/DefaultApi.md#updateappointment) | **PUT** /appointments/{appointment_uuid} | Update Appointment
*DefaultApi* | [**UpdateCatalog**](docs/DefaultApi.md#updatecatalog) | **PUT** /catalogs/{catalog_uuid} | Update Catalog
*DefaultApi* | [**UpdateProduct**](docs/DefaultApi.md#updateproduct) | **PUT** /products/{product_uuid} | Update Product
*DefaultApi* | [**UpdateReview**](docs/DefaultApi.md#updatereview) | **PUT** /reviews/types/{entity_type}/entities/{entity_uuid}/reviews/{review_uuid} | Update Review
*LoggingApi* | [**GetLogsLoggingLogsGet**](docs/LoggingApi.md#getlogslogginglogsget) | **GET** /sam/logging/logs | Get Logs
*LoggingApi* | [**GetServiceLogsLoggingLogsServicesServiceGet**](docs/LoggingApi.md#getservicelogslogginglogsservicesserviceget) | **GET** /sam/logging/logs/services/{service} | Get Service Logs
*LoggingApi* | [**GetSubjectLogsLoggingLogsServicesServiceSubjectsSubjectGet**](docs/LoggingApi.md#getsubjectlogslogginglogsservicesservicesubjectssubjectget) | **GET** /sam/logging/logs/services/{service}/subjects/{subject} | Get Subject Logs
*MetaApi* | [**CreateField**](docs/MetaApi.md#createfield) | **POST** /meta/field | Create Field
*MetaApi* | [**CreateMeta**](docs/MetaApi.md#createmeta) | **POST** /meta/meta/service/{service}/type/{type_str}/entity/{entity_uuid} | Create Meta
*MetaApi* | [**DeleteField**](docs/MetaApi.md#deletefield) | **DELETE** /meta/field/{field_uuid} | Delete Field
*MetaApi* | [**DeleteMeta**](docs/MetaApi.md#deletemeta) | **DELETE** /meta/meta/service/{service}/type/{type_str}/entity/{entity_uuid} | Delete Meta
*MetaApi* | [**DeleteMetaFromUuid**](docs/MetaApi.md#deletemetafromuuid) | **DELETE** /meta/meta/{meta_uuid} | Delete Meta From Uuid
*MetaApi* | [**GetField**](docs/MetaApi.md#getfield) | **GET** /meta/field/{field_uuid} | Get Field
*MetaApi* | [**GetMeta**](docs/MetaApi.md#getmeta) | **GET** /meta/meta/service/{service}/type/{type_str}/entity/{entity_uuid} | Get Meta
*MetaApi* | [**GetMetaFromUuid**](docs/MetaApi.md#getmetafromuuid) | **GET** /meta/meta/{meta_uuid} | Get Meta From Uuid
*MetaApi* | [**MakeSlug**](docs/MetaApi.md#makeslug) | **POST** /meta/meta/slug | Make Slug
*MetaApi* | [**TouchMeta**](docs/MetaApi.md#touchmeta) | **POST** /meta/meta/service/{service}/type/{type_str}/entity/{entity_uuid}/touch | Touch Meta
*MetaApi* | [**UpdateField**](docs/MetaApi.md#updatefield) | **PUT** /meta/field/{field_uuid} | Update Field
*MetaApi* | [**UpdateMeta**](docs/MetaApi.md#updatemeta) | **PUT** /meta/meta/service/{service}/type/{type_str}/entity/{entity_uuid} | Update Meta
*MetaApi* | [**UpdateMetaFromUuid**](docs/MetaApi.md#updatemetafromuuid) | **PUT** /meta/meta/{meta_uuid} | Update Meta From Uuid
*MonitorApi* | [**AckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost**](docs/MonitorApi.md#ackalarmmonitorservicesservicestagesstagealarmsalarmuuidacknowledgepost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/acknowledge | Ack Alarm
*MonitorApi* | [**AssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost**](docs/MonitorApi.md#assignalarmmonitorservicesservicestagesstagealarmsalarmuuidassignpost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/assign | Assign Alarm
*MonitorApi* | [**AttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost**](docs/MonitorApi.md#attachalarmnotemonitorservicesservicestagesstagealarmsalarmuuidnotepost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/note | Attach Alarm Note
*MonitorApi* | [**AttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost**](docs/MonitorApi.md#attachalarmticketmonitorservicesservicestagesstagealarmsalarmuuidticketpost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/ticket | Attach Alarm Ticket
*MonitorApi* | [**ClearAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidClearPost**](docs/MonitorApi.md#clearalarmmonitorservicesservicestagesstagealarmsalarmuuidclearpost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/clear | Clear Alarm
*MonitorApi* | [**GetServiceAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidGet**](docs/MonitorApi.md#getservicealarmmonitorservicesservicestagesstagealarmsalarmuuidget) | **GET** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid} | Get Service Alarm
*MonitorApi* | [**GetServiceAlarmsMonitorServicesServiceStagesStageAlarmsGet**](docs/MonitorApi.md#getservicealarmsmonitorservicesservicestagesstagealarmsget) | **GET** /sam/monitor/services/{service}/stages/{stage}/alarms | Get Service Alarms
*MonitorApi* | [**GetServiceHeartbeatsMonitorServicesServiceStagesStageHeartbeatsGet**](docs/MonitorApi.md#getserviceheartbeatsmonitorservicesservicestagesstageheartbeatsget) | **GET** /sam/monitor/services/{service}/stages/{stage}/heartbeats | Get Service Heartbeats
*MonitorApi* | [**GetServiceKpisMonitorServicesServiceKpisGet**](docs/MonitorApi.md#getservicekpismonitorservicesservicekpisget) | **GET** /sam/monitor/services/{service}/kpis | Get Service Kpis
*MonitorApi* | [**GetServiceMonitorServicesServiceGet**](docs/MonitorApi.md#getservicemonitorservicesserviceget) | **GET** /sam/monitor/services/{service} | Get Service
*MonitorApi* | [**GetServiceSpec**](docs/MonitorApi.md#getservicespec) | **GET** /sam/monitor/services/{service}/specs/{spec} | Getservicespec
*MonitorApi* | [**GetServiceSpecs**](docs/MonitorApi.md#getservicespecs) | **GET** /sam/monitor/services/{service}/specs | Getservicespecs
*MonitorApi* | [**GetServiceVitalsMonitorServicesServiceStagesStageVitalsGet**](docs/MonitorApi.md#getservicevitalsmonitorservicesservicestagesstagevitalsget) | **GET** /sam/monitor/services/{service}/stages/{stage}/vitals | Get Service Vitals
*MonitorApi* | [**GetServicesMonitorServicesGet**](docs/MonitorApi.md#getservicesmonitorservicesget) | **GET** /sam/monitor/services | Get Services
*MonitorApi* | [**GetServicesWithSpecs**](docs/MonitorApi.md#getserviceswithspecs) | **GET** /sam/monitor/specs/services | Getserviceswithspecs
*MonitorApi* | [**HideServiceMonitorServicesServiceStagesStageHidePost**](docs/MonitorApi.md#hideservicemonitorservicesservicestagesstagehidepost) | **POST** /sam/monitor/services/{service}/stages/{stage}/hide | Hide Service
*MonitorApi* | [**IgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost**](docs/MonitorApi.md#ignorealarmmonitorservicesservicestagesstagealarmsalarmuuidignorepost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/ignore | Ignore Alarm
*MonitorApi* | [**RegisterServiceMonitorServicesPost**](docs/MonitorApi.md#registerservicemonitorservicespost) | **POST** /sam/monitor/services | Register Service
*MonitorApi* | [**SearchAlarmsMonitorServicesServiceAlarmsGet**](docs/MonitorApi.md#searchalarmsmonitorservicesservicealarmsget) | **GET** /sam/monitor/services/{service}/alarms | Search Alarms
*MonitorApi* | [**ShowServiceMonitorServicesServiceStagesStageShowPost**](docs/MonitorApi.md#showservicemonitorservicesservicestagesstageshowpost) | **POST** /sam/monitor/services/{service}/stages/{stage}/show | Show Service
*MonitorApi* | [**TerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost**](docs/MonitorApi.md#terminatealarmmonitorservicesservicestagesstagealarmsalarmuuidterminatepost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/terminate | Terminate Alarm
*MonitorApi* | [**TriggerAlarmMonitorServicesServiceStagesStageAlarmsPost**](docs/MonitorApi.md#triggeralarmmonitorservicesservicestagesstagealarmspost) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms | Trigger Alarm
*NotesApi* | [**CreateNote**](docs/NotesApi.md#createnote) | **POST** /notes/notes | Create Note
*NotesApi* | [**DeleteNote**](docs/NotesApi.md#deletenote) | **DELETE** /notes/notes/{note_id} | Delete Note
*NotesApi* | [**GetNote**](docs/NotesApi.md#getnote) | **GET** /notes/notes/{note_id} | Get Note
*NotesApi* | [**UpdateNote**](docs/NotesApi.md#updatenote) | **PUT** /notes/notes/{note_id} | Update Note
*ProjectsApi* | [**AddMemberToProjectProjectsProjectsProjectUuidMembersEntityUuidPost**](docs/ProjectsApi.md#addmembertoprojectprojectsprojectsprojectuuidmembersentityuuidpost) | **POST** /sam/projects/projects/{project_uuid}/members/{entity_uuid} | Add Member To Project
*ProjectsApi* | [**ArchiveProjectProjectsProjectsProjectUuidDelete**](docs/ProjectsApi.md#archiveprojectprojectsprojectsprojectuuiddelete) | **DELETE** /sam/projects/projects/{project_uuid} | Archive Project
*ProjectsApi* | [**CreateProjectKeyProjectsProjectsProjectUuidKeysPost**](docs/ProjectsApi.md#createprojectkeyprojectsprojectsprojectuuidkeyspost) | **POST** /sam/projects/projects/{project_uuid}/keys | Create Project Key
*ProjectsApi* | [**CreateProjectProjectsProjectsPost**](docs/ProjectsApi.md#createprojectprojectsprojectspost) | **POST** /sam/projects/projects | Create Project
*ProjectsApi* | [**CreateUsageTypeProjectsUsageTypesPost**](docs/ProjectsApi.md#createusagetypeprojectsusagetypespost) | **POST** /sam/projects/usage/types | Create Usage Type
*ProjectsApi* | [**DeleteUsageTypeProjectsUsageTypesUsageTypeKeyDelete**](docs/ProjectsApi.md#deleteusagetypeprojectsusagetypesusagetypekeydelete) | **DELETE** /sam/projects/usage/types/{usage_type_key} | Delete Usage Type
*ProjectsApi* | [**GetAllProjectUsageProjectsProjectsProjectUuidUsageGet**](docs/ProjectsApi.md#getallprojectusageprojectsprojectsprojectuuidusageget) | **GET** /sam/projects/projects/{project_uuid}/usage | Get All Project Usage
*ProjectsApi* | [**GetMemberProjectsProjectsMembersEntityUuidProjectsGet**](docs/ProjectsApi.md#getmemberprojectsprojectsmembersentityuuidprojectsget) | **GET** /sam/projects/members/{entity_uuid}/projects | Get Member Projects
*ProjectsApi* | [**GetProjectKeysProjectsProjectsProjectUuidKeysGet**](docs/ProjectsApi.md#getprojectkeysprojectsprojectsprojectuuidkeysget) | **GET** /sam/projects/projects/{project_uuid}/keys | Get Project Keys
*ProjectsApi* | [**GetProjectMembersProjectsProjectsProjectUuidMembersGet**](docs/ProjectsApi.md#getprojectmembersprojectsprojectsprojectuuidmembersget) | **GET** /sam/projects/projects/{project_uuid}/members | Get Project Members
*ProjectsApi* | [**GetProjectProjectsProjectsProjectUuidGet**](docs/ProjectsApi.md#getprojectprojectsprojectsprojectuuidget) | **GET** /sam/projects/projects/{project_uuid} | Get Project
*ProjectsApi* | [**GetSpecificProjectUsageProjectsProjectsProjectUuidUsageUsageTypeKeyGet**](docs/ProjectsApi.md#getspecificprojectusageprojectsprojectsprojectuuidusageusagetypekeyget) | **GET** /sam/projects/projects/{project_uuid}/usage/{usage_type_key} | Get Specific Project Usage
*ProjectsApi* | [**GetUsageTypeProjectsUsageTypesUsageTypeKeyGet**](docs/ProjectsApi.md#getusagetypeprojectsusagetypesusagetypekeyget) | **GET** /sam/projects/usage/types/{usage_type_key} | Get Usage Type
*ProjectsApi* | [**RemoveMemberFromProjectProjectsProjectsProjectUuidMembersEntityUuidDelete**](docs/ProjectsApi.md#removememberfromprojectprojectsprojectsprojectuuidmembersentityuuiddelete) | **DELETE** /sam/projects/projects/{project_uuid}/members/{entity_uuid} | Remove Member From Project
*ProjectsApi* | [**RemoveProjectKeyProjectsProjectsProjectUuidKeysDelete**](docs/ProjectsApi.md#removeprojectkeyprojectsprojectsprojectuuidkeysdelete) | **DELETE** /sam/projects/projects/{project_uuid}/keys | Remove Project Key
*ProjectsApi* | [**SandboxProjectsSandboxGet**](docs/ProjectsApi.md#sandboxprojectssandboxget) | **GET** /sam/projects/sandbox | Sandbox
*ProjectsApi* | [**SearchProjectsProjectsProjectsGet**](docs/ProjectsApi.md#searchprojectsprojectsprojectsget) | **GET** /sam/projects/projects | Search Projects
*ProjectsApi* | [**SearchUsageTypeProjectsUsageTypesGet**](docs/ProjectsApi.md#searchusagetypeprojectsusagetypesget) | **GET** /sam/projects/usage/types | Search Usage Type
*ProjectsApi* | [**UpdateProjectProjectsProjectsProjectUuidPut**](docs/ProjectsApi.md#updateprojectprojectsprojectsprojectuuidput) | **PUT** /sam/projects/projects/{project_uuid} | Update Project
*ProjectsApi* | [**UpdateUsageTypeProjectsUsageTypesUsageTypeKeyPut**](docs/ProjectsApi.md#updateusagetypeprojectsusagetypesusagetypekeyput) | **PUT** /sam/projects/usage/types/{usage_type_key} | Update Usage Type
*SecurityApi* | [**CreateEncryptionKeySecurityEncryptionCategoriesCategoryKeysPost**](docs/SecurityApi.md#createencryptionkeysecurityencryptioncategoriescategorykeyspost) | **POST** /sam/security/encryption/categories/{category}/keys | Create Encryption Key
*SecurityApi* | [**CreateKeySecurityKeysPost**](docs/SecurityApi.md#createkeysecuritykeyspost) | **POST** /sam/security/keys | Create Key
*SecurityApi* | [**DeleteKeySecurityKeysKeyUuidDelete**](docs/SecurityApi.md#deletekeysecuritykeyskeyuuiddelete) | **DELETE** /sam/security/keys/{key_uuid} | Delete Key
*SecurityApi* | [**GenerateTokenSecurityTokensPost**](docs/SecurityApi.md#generatetokensecuritytokenspost) | **POST** /sam/security/tokens | Generate Token
*SecurityApi* | [**GetEncryptionKeySecurityEncryptionCategoriesCategoryKeysGet**](docs/SecurityApi.md#getencryptionkeysecurityencryptioncategoriescategorykeysget) | **GET** /sam/security/encryption/categories/{category}/keys | Get Encryption Key
*SecurityApi* | [**GetKeySecurityKeysKeyUuidGet**](docs/SecurityApi.md#getkeysecuritykeyskeyuuidget) | **GET** /sam/security/keys/{key_uuid} | Get Key
*SecurityApi* | [**SearchKeysSecurityKeysGet**](docs/SecurityApi.md#searchkeyssecuritykeysget) | **GET** /sam/security/keys | Search Keys
*SecurityApi* | [**VerifyKeySecurityKeysVerifyPost**](docs/SecurityApi.md#verifykeysecuritykeysverifypost) | **POST** /sam/security/keys/verify | Verify Key
*SupportApi* | [**CreateContactSupportContactPost**](docs/SupportApi.md#createcontactsupportcontactpost) | **POST** /sam/support/contact | Create Contact
*SupportApi* | [**CreateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsPost**](docs/SupportApi.md#createticketsupportprojectsprojectuuidmembersmemberuuidticketspost) | **POST** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets | Create Ticket
*SupportApi* | [**DeleteContactSupportContactDelete**](docs/SupportApi.md#deletecontactsupportcontactdelete) | **DELETE** /sam/support/contact | Delete Contact
*SupportApi* | [**ListTicketsSupportProjectsProjectUuidMembersMemberUuidTicketsGet**](docs/SupportApi.md#listticketssupportprojectsprojectuuidmembersmemberuuidticketsget) | **GET** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets | List Tickets
*SupportApi* | [**UpdateTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdPut**](docs/SupportApi.md#updateticketsupportprojectsprojectuuidmembersmemberuuidticketsticketidput) | **PUT** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets/{ticket_id} | Update Ticket
*SupportApi* | [**ViewTicketSupportProjectsProjectUuidMembersMemberUuidTicketsTicketIdGet**](docs/SupportApi.md#viewticketsupportprojectsprojectuuidmembersmemberuuidticketsticketidget) | **GET** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets/{ticket_id} | View Ticket
*UsersApi* | [**ConfirmSignup**](docs/UsersApi.md#confirmsignup) | **POST** /sam/users/auth/signup/confirm | Confirmsignup
*UsersApi* | [**CreateParticipant**](docs/UsersApi.md#createparticipant) | **POST** /sam/users/participants | Createparticipant
*UsersApi* | [**CreateUser**](docs/UsersApi.md#createuser) | **POST** /sam/users | Createuser
*UsersApi* | [**DeleteParticipant**](docs/UsersApi.md#deleteparticipant) | **DELETE** /sam/users/participants/{participant_id} | Deleteparticipant
*UsersApi* | [**DeleteUser**](docs/UsersApi.md#deleteuser) | **DELETE** /sam/users/{user_id} | Deleteuser
*UsersApi* | [**GetParticipant**](docs/UsersApi.md#getparticipant) | **GET** /sam/users/participants/{participant_id} | Getparticipant
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /sam/users/{user_id} | Getuser
*UsersApi* | [**Login**](docs/UsersApi.md#login) | **POST** /sam/users/auth/login | Login
*UsersApi* | [**RefreshToken**](docs/UsersApi.md#refreshtoken) | **POST** /sam/users/auth/{app_client}/refresh-token | Refreshtoken
*UsersApi* | [**ResetPassword**](docs/UsersApi.md#resetpassword) | **POST** /sam/users/auth/password/reset | Resetpassword
*UsersApi* | [**ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost**](docs/UsersApi.md#resetpasswordconfirmationusersauthpasswordresetconfirmpost) | **POST** /sam/users/auth/password/reset/confirm | Reset Password Confirmation
*UsersApi* | [**SearchParticipants**](docs/UsersApi.md#searchparticipants) | **GET** /sam/users/participants | Searchparticipants
*UsersApi* | [**Signup**](docs/UsersApi.md#signup) | **POST** /sam/users/auth/signup | Signup
*UsersApi* | [**UpdateParticipant**](docs/UsersApi.md#updateparticipant) | **PUT** /sam/users/participants/{participant_id} | Updateparticipant
*UsersApi* | [**UpdateUser**](docs/UsersApi.md#updateuser) | **PUT** /sam/users/{user_id} | Updateuser
*UsersApi* | [**UserValidations**](docs/UsersApi.md#uservalidations) | **POST** /sam/users/validations/{field} | Uservalidations


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AlarmAcknowledge](docs/AlarmAcknowledge.md)
 - [Model.AlarmAssign](docs/AlarmAssign.md)
 - [Model.AlarmCreate](docs/AlarmCreate.md)
 - [Model.AlarmIgnore](docs/AlarmIgnore.md)
 - [Model.AlarmNote](docs/AlarmNote.md)
 - [Model.AlarmTerminate](docs/AlarmTerminate.md)
 - [Model.AlarmTicket](docs/AlarmTicket.md)
 - [Model.AppointmentBase](docs/AppointmentBase.md)
 - [Model.AppointmentResponse](docs/AppointmentResponse.md)
 - [Model.AttachPaymentToProject](docs/AttachPaymentToProject.md)
 - [Model.BasicMeta](docs/BasicMeta.md)
 - [Model.BasicMetaCreate](docs/BasicMetaCreate.md)
 - [Model.BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost](docs/BodyAckAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAcknowledgePost.md)
 - [Model.BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost](docs/BodyAssignAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidAssignPost.md)
 - [Model.BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost](docs/BodyAttachAlarmNoteMonitorServicesServiceStagesStageAlarmsAlarmUuidNotePost.md)
 - [Model.BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost](docs/BodyAttachAlarmTicketMonitorServicesServiceStagesStageAlarmsAlarmUuidTicketPost.md)
 - [Model.BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost](docs/BodyAttachPaymentToProjectBillingAttachPaymentToProjectPost.md)
 - [Model.BodyCreateKeySecurityKeysPost](docs/BodyCreateKeySecurityKeysPost.md)
 - [Model.BodyGenerateTokenSecurityTokensPost](docs/BodyGenerateTokenSecurityTokensPost.md)
 - [Model.BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost](docs/BodyIgnoreAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidIgnorePost.md)
 - [Model.BodyProcessPaymentBillingProcessPaymentPost](docs/BodyProcessPaymentBillingProcessPaymentPost.md)
 - [Model.BodyRegisterServiceMonitorServicesPost](docs/BodyRegisterServiceMonitorServicesPost.md)
 - [Model.BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost](docs/BodyTerminateAlarmMonitorServicesServiceStagesStageAlarmsAlarmUuidTerminatePost.md)
 - [Model.BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost](docs/BodyTriggerAlarmMonitorServicesServiceStagesStageAlarmsPost.md)
 - [Model.BodyVerifyKeySecurityKeysVerifyPost](docs/BodyVerifyKeySecurityKeysVerifyPost.md)
 - [Model.CatalogBase](docs/CatalogBase.md)
 - [Model.CatalogReturn](docs/CatalogReturn.md)
 - [Model.Contact](docs/Contact.md)
 - [Model.ContactResponse](docs/ContactResponse.md)
 - [Model.CreateKeyResponse](docs/CreateKeyResponse.md)
 - [Model.CreateReview](docs/CreateReview.md)
 - [Model.CreateTicket](docs/CreateTicket.md)
 - [Model.DatesMeta](docs/DatesMeta.md)
 - [Model.DetailedMeta](docs/DetailedMeta.md)
 - [Model.DetailedMetaCreate](docs/DetailedMetaCreate.md)
 - [Model.Field](docs/Field.md)
 - [Model.FieldDynamo](docs/FieldDynamo.md)
 - [Model.HTTPValidationError](docs/HTTPValidationError.md)
 - [Model.MetaCreate](docs/MetaCreate.md)
 - [Model.MetaDynamo](docs/MetaDynamo.md)
 - [Model.MetaHTTPValidationError](docs/MetaHTTPValidationError.md)
 - [Model.MetaSlugger](docs/MetaSlugger.md)
 - [Model.MetaValidationError](docs/MetaValidationError.md)
 - [Model.NoteBase](docs/NoteBase.md)
 - [Model.NoteDynamo](docs/NoteDynamo.md)
 - [Model.NoteDynamoHistory](docs/NoteDynamoHistory.md)
 - [Model.NoteMeta](docs/NoteMeta.md)
 - [Model.Page](docs/Page.md)
 - [Model.Pagination](docs/Pagination.md)
 - [Model.ParticipantCreate](docs/ParticipantCreate.md)
 - [Model.ParticipantUpdate](docs/ParticipantUpdate.md)
 - [Model.ParticipantUserReturn](docs/ParticipantUserReturn.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.PaymentMethodResponse](docs/PaymentMethodResponse.md)
 - [Model.ProductBase](docs/ProductBase.md)
 - [Model.ProductReturn](docs/ProductReturn.md)
 - [Model.ProductsHTTPValidationError](docs/ProductsHTTPValidationError.md)
 - [Model.ProductsValidationError](docs/ProductsValidationError.md)
 - [Model.ProjectsProjectCreate](docs/ProjectsProjectCreate.md)
 - [Model.ProjectsProjectGet](docs/ProjectsProjectGet.md)
 - [Model.ProjectsProjectMemberDB](docs/ProjectsProjectMemberDB.md)
 - [Model.ProjectsProjectUpdate](docs/ProjectsProjectUpdate.md)
 - [Model.ProjectsProjectUsageDB](docs/ProjectsProjectUsageDB.md)
 - [Model.ProjectsUsageTypeCreate](docs/ProjectsUsageTypeCreate.md)
 - [Model.ProjectsUsageTypeDB](docs/ProjectsUsageTypeDB.md)
 - [Model.ProjectsUsageTypeGet](docs/ProjectsUsageTypeGet.md)
 - [Model.ProjectsUsageTypeUnitPrice](docs/ProjectsUsageTypeUnitPrice.md)
 - [Model.ProjectsUsageTypeUpdate](docs/ProjectsUsageTypeUpdate.md)
 - [Model.SecurityCreateToken](docs/SecurityCreateToken.md)
 - [Model.SecurityEncryptionKeyGet](docs/SecurityEncryptionKeyGet.md)
 - [Model.SecurityKeyCreate](docs/SecurityKeyCreate.md)
 - [Model.SecurityKeyGet](docs/SecurityKeyGet.md)
 - [Model.SecurityKeyVerify](docs/SecurityKeyVerify.md)
 - [Model.ServiceCreate](docs/ServiceCreate.md)
 - [Model.StripeAccountResponse](docs/StripeAccountResponse.md)
 - [Model.TicketResponse](docs/TicketResponse.md)
 - [Model.TicketsResponse](docs/TicketsResponse.md)
 - [Model.UpdateReview](docs/UpdateReview.md)
 - [Model.User](docs/User.md)
 - [Model.UserConfirmation](docs/UserConfirmation.md)
 - [Model.UserEmail](docs/UserEmail.md)
 - [Model.UserFlags](docs/UserFlags.md)
 - [Model.UserLogin](docs/UserLogin.md)
 - [Model.UserLoginReturn](docs/UserLoginReturn.md)
 - [Model.UserPasswordReset](docs/UserPasswordReset.md)
 - [Model.UserPasswordResetConfirmation](docs/UserPasswordResetConfirmation.md)
 - [Model.UserResponse](docs/UserResponse.md)
 - [Model.UserSignup](docs/UserSignup.md)
 - [Model.UserSignupReturn](docs/UserSignupReturn.md)
 - [Model.UserTokenReturn](docs/UserTokenReturn.md)
 - [Model.UserValidations](docs/UserValidations.md)
 - [Model.ValidationError](docs/ValidationError.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
