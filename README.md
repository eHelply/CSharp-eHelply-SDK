# Ehelply.Sdk - the C# library for the eHelply SDK - 1.1.86

eHelply SDK for SuperStack Services

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.1.86
- SDK version: 1.1.86
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://superstack.ehelply.com/support](https://superstack.ehelply.com/support)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
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
            var apiInstance = new BillingApi(config);
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Createbillingaccount
                StripeAccountResponse result = apiInstance.CreateBillingAccount(xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BillingApi.CreateBillingAccount: " + e.Message );
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
*BillingApi* | [**CreateBillingAccount**](docs/BillingApi.md#createbillingaccount) | **POST** /sam/billing/create_billing_account | Createbillingaccount
*BillingApi* | [**GetClientSecret**](docs/BillingApi.md#getclientsecret) | **GET** /sam/billing/retrieve_secret | Getclientsecret
*BillingApi* | [**HasPayment**](docs/BillingApi.md#haspayment) | **GET** /sam/billing/has_payment | Haspayment
*BillingApi* | [**ListPaymentMethods**](docs/BillingApi.md#listpaymentmethods) | **GET** /sam/billing/view_payment_method | Listpaymentmethods
*BillingApi* | [**ProcessPayment**](docs/BillingApi.md#processpayment) | **POST** /sam/billing/process_payment | Processpayment
*BillingApi* | [**ReconcilePaymentMethod**](docs/BillingApi.md#reconcilepaymentmethod) | **GET** /sam/billing/reconcile_payment | Reconcilepaymentmethod
*BillingApi* | [**RemovePaymentMethod**](docs/BillingApi.md#removepaymentmethod) | **DELETE** /sam/billing/remove_payment_method | Removepaymentmethod
*CategoryApi* | [**CreateCategoryPlacesCategoriesPost**](docs/CategoryApi.md#createcategoryplacescategoriespost) | **POST** /places/categories | Create Category
*CategoryApi* | [**DeleteCategoryPlacesCategoriesCategoryUuidDelete**](docs/CategoryApi.md#deletecategoryplacescategoriescategoryuuiddelete) | **DELETE** /places/categories/{category_uuid} | Delete Category
*CategoryApi* | [**GetCategoryPlacesCategoriesCategoryUuidGet**](docs/CategoryApi.md#getcategoryplacescategoriescategoryuuidget) | **GET** /places/categories/{category_uuid} | Get Category
*CategoryApi* | [**SearchCategoriesPlacesCategoriesGet**](docs/CategoryApi.md#searchcategoriesplacescategoriesget) | **GET** /places/categories | Search Categories
*CategoryApi* | [**UpdateCategoryPlacesCategoriesCategoryUuidPut**](docs/CategoryApi.md#updatecategoryplacescategoriescategoryuuidput) | **PUT** /places/categories/{category_uuid} | Update Category
*CompaniesApi* | [**CreateCompanyPlacesCompaniesPost**](docs/CompaniesApi.md#createcompanyplacescompaniespost) | **POST** /places/companies | Create Company
*CompaniesApi* | [**DeletePlacePlacesCompaniesCompanyUuidDelete**](docs/CompaniesApi.md#deleteplaceplacescompaniescompanyuuiddelete) | **DELETE** /places/companies/{company_uuid} | Delete Place
*CompaniesApi* | [**GetCompanyPlacesCompaniesCompanyUuidGet**](docs/CompaniesApi.md#getcompanyplacescompaniescompanyuuidget) | **GET** /places/companies/{company_uuid} | Get Company
*CompaniesApi* | [**SearchCompaniesPlacesCompaniesGet**](docs/CompaniesApi.md#searchcompaniesplacescompaniesget) | **GET** /places/companies | Search Companies
*CompaniesApi* | [**UpdateCompanyPlacesCompaniesCompanyUuidPut**](docs/CompaniesApi.md#updatecompanyplacescompaniescompanyuuidput) | **PUT** /places/companies/{company_uuid} | Update Company
*DefaultApi* | [**AttachEntityToAppointment**](docs/DefaultApi.md#attachentitytoappointment) | **POST** /appointments/appointments/{appointment_uuid}/entities/{entity_uuid} | Attach Entity To Appointment
*DefaultApi* | [**AttachProductToCatalog**](docs/DefaultApi.md#attachproducttocatalog) | **POST** /products/catalogs/{catalog_uuid}/products/{product_uuid} | Attach Product To Catalog
*DefaultApi* | [**CreateAppointment**](docs/DefaultApi.md#createappointment) | **POST** /appointments/appointments | Create Appointment
*DefaultApi* | [**CreateCatalog**](docs/DefaultApi.md#createcatalog) | **POST** /products/catalogs | Create Catalog
*DefaultApi* | [**CreateProduct**](docs/DefaultApi.md#createproduct) | **POST** /products/products | Create Product
*DefaultApi* | [**CreateReview**](docs/DefaultApi.md#createreview) | **POST** /products/reviews/types/{entity_type}/entities/{entity_uuid} | Create Review
*DefaultApi* | [**DeleteAppointment**](docs/DefaultApi.md#deleteappointment) | **DELETE** /appointments/appointments/{appointment_uuid} | Delete Appointment
*DefaultApi* | [**DeleteCatalog**](docs/DefaultApi.md#deletecatalog) | **DELETE** /products/catalogs/{catalog_uuid} | Delete Catalog
*DefaultApi* | [**DeleteProduct**](docs/DefaultApi.md#deleteproduct) | **DELETE** /products/products/{product_uuid} | Delete Product
*DefaultApi* | [**DeleteReview**](docs/DefaultApi.md#deletereview) | **DELETE** /products/reviews/types/{entity_type}/entities/{entity_uuid}/reviews/{review_uuid} | Delete Review
*DefaultApi* | [**DetachEntityFromAppointment**](docs/DefaultApi.md#detachentityfromappointment) | **DELETE** /appointments/appointments/{appointment_uuid}/entities/{entity_uuid} | Detach Entity From Appointment
*DefaultApi* | [**DetachProductFromCatalog**](docs/DefaultApi.md#detachproductfromcatalog) | **DELETE** /products/catalogs/{catalog_uuid}/products/{product_uuid} | Detach Product From Catalog
*DefaultApi* | [**GetAppointment**](docs/DefaultApi.md#getappointment) | **GET** /appointments/appointments/{appointment_uuid} | Get Appointment
*DefaultApi* | [**GetCatalog**](docs/DefaultApi.md#getcatalog) | **GET** /products/catalogs/{catalog_uuid} | Get Catalog
*DefaultApi* | [**GetProduct**](docs/DefaultApi.md#getproduct) | **GET** /products/products/{product_uuid} | Get Product
*DefaultApi* | [**GetReview**](docs/DefaultApi.md#getreview) | **GET** /products/reviews/types/{entity_type}/entities/{entity_uuid}/reviews/{review_uuid} | Get Review
*DefaultApi* | [**SearchAppointment**](docs/DefaultApi.md#searchappointment) | **GET** /appointments/appointments | Search Appointment
*DefaultApi* | [**SearchAppointmentEntities**](docs/DefaultApi.md#searchappointmententities) | **GET** /appointments/appointments/{appointment_uuid}/entities | Search Appointment Entities
*DefaultApi* | [**SearchCatalogProducts**](docs/DefaultApi.md#searchcatalogproducts) | **GET** /products/catalogs/{catalog_uuid}/products | Search Catalog Products
*DefaultApi* | [**SearchCatalogs**](docs/DefaultApi.md#searchcatalogs) | **GET** /products/catalogs | Search Catalogs
*DefaultApi* | [**SearchEntityAppointments**](docs/DefaultApi.md#searchentityappointments) | **GET** /appointments/appointments/entities/{entity_uuid}/appointments | Get Entities Appointments
*DefaultApi* | [**SearchProduct**](docs/DefaultApi.md#searchproduct) | **GET** /products/products | Search Products
*DefaultApi* | [**SearchProductCatalog**](docs/DefaultApi.md#searchproductcatalog) | **GET** /products/products/{product_uuid}/catalogs | Search Product Catalogs
*DefaultApi* | [**SearchReviews**](docs/DefaultApi.md#searchreviews) | **GET** /products/reviews/types/{entity_type}/entities/{entity_uuid} | Search Review
*DefaultApi* | [**UpdateAppointment**](docs/DefaultApi.md#updateappointment) | **PUT** /appointments/appointments/{appointment_uuid} | Update Appointment
*DefaultApi* | [**UpdateCatalog**](docs/DefaultApi.md#updatecatalog) | **PUT** /products/catalogs/{catalog_uuid} | Update Catalog
*DefaultApi* | [**UpdateProduct**](docs/DefaultApi.md#updateproduct) | **PUT** /products/products/{product_uuid} | Update Product
*DefaultApi* | [**UpdateReview**](docs/DefaultApi.md#updatereview) | **PUT** /products/reviews/types/{entity_type}/entities/{entity_uuid}/reviews/{review_uuid} | Update Review
*LoggingApi* | [**GetLogs**](docs/LoggingApi.md#getlogs) | **GET** /sam/logging/logs | Getlogs
*LoggingApi* | [**GetServiceLogs**](docs/LoggingApi.md#getservicelogs) | **GET** /sam/logging/logs/services/{service} | Getservicelogs
*LoggingApi* | [**GetSubjectLogs**](docs/LoggingApi.md#getsubjectlogs) | **GET** /sam/logging/logs/services/{service}/subjects/{subject} | Getsubjectlogs
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
*MonitorApi* | [**AcknowledgeAlarm**](docs/MonitorApi.md#acknowledgealarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/acknowledge | Acknowledgealarm
*MonitorApi* | [**AssignAlarm**](docs/MonitorApi.md#assignalarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/assign | Assignalarm
*MonitorApi* | [**AttachAlarmNote**](docs/MonitorApi.md#attachalarmnote) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/note | Attachalarmnote
*MonitorApi* | [**AttachAlarmTicket**](docs/MonitorApi.md#attachalarmticket) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/ticket | Attachalarmticket
*MonitorApi* | [**ClearAlarm**](docs/MonitorApi.md#clearalarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/clear | Clearalarm
*MonitorApi* | [**GetService**](docs/MonitorApi.md#getservice) | **GET** /sam/monitor/services/{service} | Getservice
*MonitorApi* | [**GetServiceAlarm**](docs/MonitorApi.md#getservicealarm) | **GET** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid} | Getservicealarm
*MonitorApi* | [**GetServiceAlarms**](docs/MonitorApi.md#getservicealarms) | **GET** /sam/monitor/services/{service}/stages/{stage}/alarms | Getservicealarms
*MonitorApi* | [**GetServiceHeartbeat**](docs/MonitorApi.md#getserviceheartbeat) | **GET** /sam/monitor/services/{service}/stages/{stage}/heartbeats | Getserviceheartbeat
*MonitorApi* | [**GetServiceKpis**](docs/MonitorApi.md#getservicekpis) | **GET** /sam/monitor/services/{service}/kpis | Getservicekpis
*MonitorApi* | [**GetServiceSpec**](docs/MonitorApi.md#getservicespec) | **GET** /sam/monitor/services/{service}/specs/{spec} | Getservicespec
*MonitorApi* | [**GetServiceSpecs**](docs/MonitorApi.md#getservicespecs) | **GET** /sam/monitor/services/{service}/specs | Getservicespecs
*MonitorApi* | [**GetServiceVitals**](docs/MonitorApi.md#getservicevitals) | **GET** /sam/monitor/services/{service}/stages/{stage}/vitals | Getservicevitals
*MonitorApi* | [**GetServices**](docs/MonitorApi.md#getservices) | **GET** /sam/monitor/services | Getservices
*MonitorApi* | [**GetServicesWithSpecs**](docs/MonitorApi.md#getserviceswithspecs) | **GET** /sam/monitor/specs/services | Getserviceswithspecs
*MonitorApi* | [**HideService**](docs/MonitorApi.md#hideservice) | **POST** /sam/monitor/services/{service}/stages/{stage}/hide | Hideservice
*MonitorApi* | [**IgnoreAlarm**](docs/MonitorApi.md#ignorealarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/ignore | Ignorealarm
*MonitorApi* | [**RegisterService**](docs/MonitorApi.md#registerservice) | **POST** /sam/monitor/services | Registerservice
*MonitorApi* | [**SearchAlarms**](docs/MonitorApi.md#searchalarms) | **GET** /sam/monitor/services/{service}/alarms | Searchalarms
*MonitorApi* | [**ShowService**](docs/MonitorApi.md#showservice) | **POST** /sam/monitor/services/{service}/stages/{stage}/show | Showservice
*MonitorApi* | [**TerminateAlarm**](docs/MonitorApi.md#terminatealarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms/{alarm_uuid}/terminate | Terminatealarm
*MonitorApi* | [**TriggerAlarm**](docs/MonitorApi.md#triggeralarm) | **POST** /sam/monitor/services/{service}/stages/{stage}/alarms | Triggeralarm
*NotesApi* | [**CreateNote**](docs/NotesApi.md#createnote) | **POST** /notes/notes | Create Note
*NotesApi* | [**DeleteNote**](docs/NotesApi.md#deletenote) | **DELETE** /notes/notes/{note_id} | Delete Note
*NotesApi* | [**GetNote**](docs/NotesApi.md#getnote) | **GET** /notes/notes/{note_id} | Get Note
*NotesApi* | [**UpdateNote**](docs/NotesApi.md#updatenote) | **PUT** /notes/notes/{note_id} | Update Note
*PlacesApi* | [**CreatePlacePlacesPlacesPost**](docs/PlacesApi.md#createplaceplacesplacespost) | **POST** /places/places | Create Place
*PlacesApi* | [**DeletePlacePlacesPlacesPlaceUuidDelete**](docs/PlacesApi.md#deleteplaceplacesplacesplaceuuiddelete) | **DELETE** /places/places/{place_uuid} | Delete Place
*PlacesApi* | [**ForwardGeocodingPlacesGeocodingForwardGet**](docs/PlacesApi.md#forwardgeocodingplacesgeocodingforwardget) | **GET** /places/geocoding/forward | Forward Geocoding
*PlacesApi* | [**GetPlacePlacesPlacesPlaceUuidGet**](docs/PlacesApi.md#getplaceplacesplacesplaceuuidget) | **GET** /places/places/{place_uuid} | Get Place
*PlacesApi* | [**ReverseGeocodingPlacesGeocodingReverseGet**](docs/PlacesApi.md#reversegeocodingplacesgeocodingreverseget) | **GET** /places/geocoding/reverse | Reverse Geocoding
*PlacesApi* | [**SearchPlacesBySearchStringPlacesSearchPlacesStringGet**](docs/PlacesApi.md#searchplacesbysearchstringplacessearchplacesstringget) | **GET** /places/search/places/string | Search Places By Search String
*PlacesApi* | [**SearchPlacesPlacesPlacesGet**](docs/PlacesApi.md#searchplacesplacesplacesget) | **GET** /places/places | Search Places
*PlacesApi* | [**UpdatePlacePlacesPlacesPlaceUuidPut**](docs/PlacesApi.md#updateplaceplacesplacesplaceuuidput) | **PUT** /places/places/{place_uuid} | Update Place
*ProjectsApi* | [**AddMemberToProject**](docs/ProjectsApi.md#addmembertoproject) | **POST** /sam/projects/projects/{project_uuid}/members/{entity_uuid} | Addmembertoproject
*ProjectsApi* | [**ArchiveProject**](docs/ProjectsApi.md#archiveproject) | **DELETE** /sam/projects/projects/{project_uuid} | Archiveproject
*ProjectsApi* | [**CreateProject**](docs/ProjectsApi.md#createproject) | **POST** /sam/projects/projects | Createproject
*ProjectsApi* | [**CreateProjectKey**](docs/ProjectsApi.md#createprojectkey) | **POST** /sam/projects/projects/{project_uuid}/keys | Createprojectkey
*ProjectsApi* | [**CreateUsageType**](docs/ProjectsApi.md#createusagetype) | **POST** /sam/projects/usage/types | Createusagetype
*ProjectsApi* | [**DeleteProjectKey**](docs/ProjectsApi.md#deleteprojectkey) | **DELETE** /sam/projects/projects/{project_uuid}/keys | Deleteprojectkey
*ProjectsApi* | [**DeleteUsageType**](docs/ProjectsApi.md#deleteusagetype) | **DELETE** /sam/projects/usage/types/{usage_type_key} | Deleteusagetype
*ProjectsApi* | [**GetAllProjectUsage**](docs/ProjectsApi.md#getallprojectusage) | **GET** /sam/projects/projects/{project_uuid}/usage | Getallprojectusage
*ProjectsApi* | [**GetMemberProjects**](docs/ProjectsApi.md#getmemberprojects) | **GET** /sam/projects/members/{entity_uuid}/projects | Getmemberprojects
*ProjectsApi* | [**GetProject**](docs/ProjectsApi.md#getproject) | **GET** /sam/projects/projects/{project_uuid} | Getproject
*ProjectsApi* | [**GetProjectKeys**](docs/ProjectsApi.md#getprojectkeys) | **GET** /sam/projects/projects/{project_uuid}/keys | Getprojectkeys
*ProjectsApi* | [**GetProjectMembers**](docs/ProjectsApi.md#getprojectmembers) | **GET** /sam/projects/projects/{project_uuid}/members | Getprojectmembers
*ProjectsApi* | [**GetSpecificProjectUsage**](docs/ProjectsApi.md#getspecificprojectusage) | **GET** /sam/projects/projects/{project_uuid}/usage/{usage_type_key} | Getspecificprojectusage
*ProjectsApi* | [**GetUsageType**](docs/ProjectsApi.md#getusagetype) | **GET** /sam/projects/usage/types/{usage_type_key} | Getusagetype
*ProjectsApi* | [**RemoveMemberFromProject**](docs/ProjectsApi.md#removememberfromproject) | **DELETE** /sam/projects/projects/{project_uuid}/members/{entity_uuid} | Removememberfromproject
*ProjectsApi* | [**SearchProjects**](docs/ProjectsApi.md#searchprojects) | **GET** /sam/projects/projects | Searchprojects
*ProjectsApi* | [**SearchUsageType**](docs/ProjectsApi.md#searchusagetype) | **GET** /sam/projects/usage/types | Searchusagetype
*ProjectsApi* | [**UpdateProject**](docs/ProjectsApi.md#updateproject) | **PUT** /sam/projects/projects/{project_uuid} | Updateproject
*ProjectsApi* | [**UpdateUsageType**](docs/ProjectsApi.md#updateusagetype) | **PUT** /sam/projects/usage/types/{usage_type_key} | Updateusagetype
*SecurityApi* | [**CreateEncryptionKey**](docs/SecurityApi.md#createencryptionkey) | **POST** /sam/security/encryption/categories/{category}/keys | Createencryptionkey
*SecurityApi* | [**CreateKey**](docs/SecurityApi.md#createkey) | **POST** /sam/security/keys | Createkey
*SecurityApi* | [**DeleteKey**](docs/SecurityApi.md#deletekey) | **DELETE** /sam/security/keys/{key_uuid} | Deletekey
*SecurityApi* | [**GenerateToken**](docs/SecurityApi.md#generatetoken) | **POST** /sam/security/tokens | Generatetoken
*SecurityApi* | [**GetEncryptionKey**](docs/SecurityApi.md#getencryptionkey) | **GET** /sam/security/encryption/categories/{category}/keys | Getencryptionkey
*SecurityApi* | [**GetKey**](docs/SecurityApi.md#getkey) | **GET** /sam/security/keys/{key_uuid} | Getkey
*SecurityApi* | [**SearchKeys**](docs/SecurityApi.md#searchkeys) | **GET** /sam/security/keys | Searchkeys
*SecurityApi* | [**VerifyKey**](docs/SecurityApi.md#verifykey) | **POST** /sam/security/keys/verify | Verifykey
*StaffApi* | [**CreateStaffPlacesStaffPost**](docs/StaffApi.md#createstaffplacesstaffpost) | **POST** /places/staff | Create Staff
*StaffApi* | [**DeleteStaffPlacesStaffStaffUuidDelete**](docs/StaffApi.md#deletestaffplacesstaffstaffuuiddelete) | **DELETE** /places/staff/{staff_uuid} | Delete Staff
*StaffApi* | [**GetStaffPlacesStaffStaffUuidGet**](docs/StaffApi.md#getstaffplacesstaffstaffuuidget) | **GET** /places/staff/{staff_uuid} | Get Staff
*StaffApi* | [**SearchStaffPlacesStaffGet**](docs/StaffApi.md#searchstaffplacesstaffget) | **GET** /places/staff | Search Staff
*StaffApi* | [**UpdateStaffPlacesStaffStaffUuidPut**](docs/StaffApi.md#updatestaffplacesstaffstaffuuidput) | **PUT** /places/staff/{staff_uuid} | Update Staff
*SupportApi* | [**CreateContact**](docs/SupportApi.md#createcontact) | **POST** /sam/support/contact | Createcontact
*SupportApi* | [**CreateTicket**](docs/SupportApi.md#createticket) | **POST** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets | Createticket
*SupportApi* | [**ListTickets**](docs/SupportApi.md#listtickets) | **GET** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets | Listtickets
*SupportApi* | [**UpdateTicket**](docs/SupportApi.md#updateticket) | **PUT** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets/{ticket_id} | Updateticket
*SupportApi* | [**ViewTicket**](docs/SupportApi.md#viewticket) | **GET** /sam/support/projects/{project_uuid}/members/{member_uuid}/tickets/{ticket_id} | Viewticket
*TagApi* | [**CreateTagPlacesTagsPost**](docs/TagApi.md#createtagplacestagspost) | **POST** /places/tags | Create Tag
*TagApi* | [**DeleteTagPlacesTagsTagUuidDelete**](docs/TagApi.md#deletetagplacestagstaguuiddelete) | **DELETE** /places/tags/{tag_uuid} | Delete Tag
*TagApi* | [**GetTagPlacesTagsTagUuidGet**](docs/TagApi.md#gettagplacestagstaguuidget) | **GET** /places/tags/{tag_uuid} | Get Tag
*TagApi* | [**SearchTagsPlacesTagsGet**](docs/TagApi.md#searchtagsplacestagsget) | **GET** /places/tags | Search Tags
*TagApi* | [**UpdateTagPlacesTagsTagUuidPut**](docs/TagApi.md#updatetagplacestagstaguuidput) | **PUT** /places/tags/{tag_uuid} | Update Tag
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
*UsersApi* | [**ResetPasswordConfirmation**](docs/UsersApi.md#resetpasswordconfirmation) | **POST** /sam/users/auth/password/reset/confirm | Resetpasswordconfirmation
*UsersApi* | [**SearchParticipants**](docs/UsersApi.md#searchparticipants) | **GET** /sam/users/participants | Searchparticipants
*UsersApi* | [**Signup**](docs/UsersApi.md#signup) | **POST** /sam/users/auth/signup | Signup
*UsersApi* | [**UpdateParticipant**](docs/UsersApi.md#updateparticipant) | **PUT** /sam/users/participants/{participant_id} | Updateparticipant
*UsersApi* | [**UpdateUser**](docs/UsersApi.md#updateuser) | **PUT** /sam/users/{user_id} | Updateuser
*UsersApi* | [**UserValidations**](docs/UsersApi.md#uservalidations) | **POST** /sam/users/validations/{field} | Uservalidations


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressBase](docs/AddressBase.md)
 - [Model.AlarmAcknowledge](docs/AlarmAcknowledge.md)
 - [Model.AlarmAssign](docs/AlarmAssign.md)
 - [Model.AlarmCreate](docs/AlarmCreate.md)
 - [Model.AlarmIgnore](docs/AlarmIgnore.md)
 - [Model.AlarmNote](docs/AlarmNote.md)
 - [Model.AlarmResponse](docs/AlarmResponse.md)
 - [Model.AlarmTerminate](docs/AlarmTerminate.md)
 - [Model.AlarmTicket](docs/AlarmTicket.md)
 - [Model.AppointmentBase](docs/AppointmentBase.md)
 - [Model.AppointmentResponse](docs/AppointmentResponse.md)
 - [Model.AttachPaymentToProject](docs/AttachPaymentToProject.md)
 - [Model.Basic](docs/Basic.md)
 - [Model.BasicMeta](docs/BasicMeta.md)
 - [Model.BasicMetaCreate](docs/BasicMetaCreate.md)
 - [Model.CatalogBase](docs/CatalogBase.md)
 - [Model.CatalogReturn](docs/CatalogReturn.md)
 - [Model.CategoryBase](docs/CategoryBase.md)
 - [Model.CategoryDb](docs/CategoryDb.md)
 - [Model.Company](docs/Company.md)
 - [Model.CompanyBase](docs/CompanyBase.md)
 - [Model.CompanyResponse](docs/CompanyResponse.md)
 - [Model.Contact](docs/Contact.md)
 - [Model.ContactBase](docs/ContactBase.md)
 - [Model.ContactMethod](docs/ContactMethod.md)
 - [Model.ContactResponse](docs/ContactResponse.md)
 - [Model.CreateKeyResponse](docs/CreateKeyResponse.md)
 - [Model.CreateReview](docs/CreateReview.md)
 - [Model.CreateTicket](docs/CreateTicket.md)
 - [Model.CustomList](docs/CustomList.md)
 - [Model.DatesMeta](docs/DatesMeta.md)
 - [Model.Detailed](docs/Detailed.md)
 - [Model.DetailedMeta](docs/DetailedMeta.md)
 - [Model.DetailedMetaCreate](docs/DetailedMetaCreate.md)
 - [Model.Email](docs/Email.md)
 - [Model.Field](docs/Field.md)
 - [Model.FieldDynamo](docs/FieldDynamo.md)
 - [Model.GetAppointment403Response](docs/GetAppointment403Response.md)
 - [Model.GetServiceServiceWithSpecsResponse](docs/GetServiceServiceWithSpecsResponse.md)
 - [Model.GetServiceSpecResponse](docs/GetServiceSpecResponse.md)
 - [Model.GetServiceSpecsResponse](docs/GetServiceSpecsResponse.md)
 - [Model.HTTPValidationError](docs/HTTPValidationError.md)
 - [Model.HeartbeatResponse](docs/HeartbeatResponse.md)
 - [Model.KpiResponse](docs/KpiResponse.md)
 - [Model.LoggingDynamo](docs/LoggingDynamo.md)
 - [Model.MetaChildren](docs/MetaChildren.md)
 - [Model.MetaCreate](docs/MetaCreate.md)
 - [Model.MetaCustom](docs/MetaCustom.md)
 - [Model.MetaDynamo](docs/MetaDynamo.md)
 - [Model.MetaSlugger](docs/MetaSlugger.md)
 - [Model.NoteBase](docs/NoteBase.md)
 - [Model.NoteDynamo](docs/NoteDynamo.md)
 - [Model.NoteDynamoHistory](docs/NoteDynamoHistory.md)
 - [Model.NoteMeta](docs/NoteMeta.md)
 - [Model.NotesHTTPValidationError](docs/NotesHTTPValidationError.md)
 - [Model.NotesValidationError](docs/NotesValidationError.md)
 - [Model.OptionGroup](docs/OptionGroup.md)
 - [Model.Options](docs/Options.md)
 - [Model.Page](docs/Page.md)
 - [Model.Pagination](docs/Pagination.md)
 - [Model.ParticipantCreate](docs/ParticipantCreate.md)
 - [Model.ParticipantUpdate](docs/ParticipantUpdate.md)
 - [Model.ParticipantUserReturn](docs/ParticipantUserReturn.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.PaymentMethodResponse](docs/PaymentMethodResponse.md)
 - [Model.PlaceBase](docs/PlaceBase.md)
 - [Model.PlaceResponse](docs/PlaceResponse.md)
 - [Model.ProductBase](docs/ProductBase.md)
 - [Model.ProductReturn](docs/ProductReturn.md)
 - [Model.ProjectDB](docs/ProjectDB.md)
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
 - [Model.ResponseAddmembertoproject](docs/ResponseAddmembertoproject.md)
 - [Model.ResponseArchiveproject](docs/ResponseArchiveproject.md)
 - [Model.ResponseCreatekey](docs/ResponseCreatekey.md)
 - [Model.ResponseDeletekey](docs/ResponseDeletekey.md)
 - [Model.ResponseDeleteusagetype](docs/ResponseDeleteusagetype.md)
 - [Model.ResponseGeneratetoken](docs/ResponseGeneratetoken.md)
 - [Model.ResponseRemovememberfromproject](docs/ResponseRemovememberfromproject.md)
 - [Model.SecurityCreateToken](docs/SecurityCreateToken.md)
 - [Model.SecurityEncryptionKeyGet](docs/SecurityEncryptionKeyGet.md)
 - [Model.SecurityEncryptionKeyResponse](docs/SecurityEncryptionKeyResponse.md)
 - [Model.SecurityKeyCreate](docs/SecurityKeyCreate.md)
 - [Model.SecurityKeyGet](docs/SecurityKeyGet.md)
 - [Model.SecurityKeyVerify](docs/SecurityKeyVerify.md)
 - [Model.Selection](docs/Selection.md)
 - [Model.ServiceCreate](docs/ServiceCreate.md)
 - [Model.ServiceMessageResponse](docs/ServiceMessageResponse.md)
 - [Model.ServiceResponse](docs/ServiceResponse.md)
 - [Model.StaffCreate](docs/StaffCreate.md)
 - [Model.StaffDb](docs/StaffDb.md)
 - [Model.StaffResponse](docs/StaffResponse.md)
 - [Model.StatsVitalsResponse](docs/StatsVitalsResponse.md)
 - [Model.StripeAccountResponse](docs/StripeAccountResponse.md)
 - [Model.StripeCustomerSecretResponse](docs/StripeCustomerSecretResponse.md)
 - [Model.TagBase](docs/TagBase.md)
 - [Model.TagDb](docs/TagDb.md)
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
 - [Model.Validations](docs/Validations.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
