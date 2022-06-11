# Ehelply.Sdk.Api.SecurityApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEncryptionKey**](SecurityApi.md#createencryptionkey) | **POST** /sam/security/encryption/categories/{category}/keys | Createencryptionkey
[**CreateKey**](SecurityApi.md#createkey) | **POST** /sam/security/keys | Createkey
[**DeleteKey**](SecurityApi.md#deletekey) | **DELETE** /sam/security/keys/{key_uuid} | Deletekey
[**GenerateToken**](SecurityApi.md#generatetoken) | **POST** /sam/security/tokens | Generatetoken
[**GetEncryptionKey**](SecurityApi.md#getencryptionkey) | **GET** /sam/security/encryption/categories/{category}/keys | Getencryptionkey
[**GetKey**](SecurityApi.md#getkey) | **GET** /sam/security/keys/{key_uuid} | Getkey
[**SearchKeys**](SecurityApi.md#searchkeys) | **GET** /sam/security/keys | Searchkeys
[**VerifyKey**](SecurityApi.md#verifykey) | **POST** /sam/security/keys/verify | Verifykey


<a name="createencryptionkey"></a>
# **CreateEncryptionKey**
> SecurityEncryptionKeyResponse CreateEncryptionKey (string category, string ehelplySecuritySecretKey = null)

Createencryptionkey

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateEncryptionKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var category = "category_example";  // string | 
            var ehelplySecuritySecretKey = "ehelplySecuritySecretKey_example";  // string |  (optional) 

            try
            {
                // Createencryptionkey
                SecurityEncryptionKeyResponse result = apiInstance.CreateEncryptionKey(category, ehelplySecuritySecretKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.CreateEncryptionKey: " + e.Message );
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
 **category** | **string**|  | 
 **ehelplySecuritySecretKey** | **string**|  | [optional] 

### Return type

[**SecurityEncryptionKeyResponse**](SecurityEncryptionKeyResponse.md)

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

<a name="createkey"></a>
# **CreateKey**
> ResponseCreatekey CreateKey (SecurityKeyCreate securityKeyCreate, int? accessLength = null, int? secretLength = null)

Createkey

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var securityKeyCreate = new SecurityKeyCreate(); // SecurityKeyCreate | 
            var accessLength = 64;  // int? |  (optional)  (default to 64)
            var secretLength = 64;  // int? |  (optional)  (default to 64)

            try
            {
                // Createkey
                ResponseCreatekey result = apiInstance.CreateKey(securityKeyCreate, accessLength, secretLength);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.CreateKey: " + e.Message );
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
 **securityKeyCreate** | [**SecurityKeyCreate**](SecurityKeyCreate.md)|  | 
 **accessLength** | **int?**|  | [optional] [default to 64]
 **secretLength** | **int?**|  | [optional] [default to 64]

### Return type

[**ResponseCreatekey**](ResponseCreatekey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Access token and secret token lengths must be greater than 48 characters and less than 1024 characters to guarantee adequate security.  |  -  |
| **403** | Unauthorized - Denied by eHelply |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletekey"></a>
# **DeleteKey**
> ResponseDeletekey DeleteKey (string keyUuid)

Deletekey

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var keyUuid = "keyUuid_example";  // string | 

            try
            {
                // Deletekey
                ResponseDeletekey result = apiInstance.DeleteKey(keyUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.DeleteKey: " + e.Message );
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
 **keyUuid** | **string**|  | 

### Return type

[**ResponseDeletekey**](ResponseDeletekey.md)

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

<a name="generatetoken"></a>
# **GenerateToken**
> ResponseGeneratetoken GenerateToken (SecurityCreateToken securityCreateToken)

Generatetoken

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GenerateTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var securityCreateToken = new SecurityCreateToken(); // SecurityCreateToken | 

            try
            {
                // Generatetoken
                ResponseGeneratetoken result = apiInstance.GenerateToken(securityCreateToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.GenerateToken: " + e.Message );
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
 **securityCreateToken** | [**SecurityCreateToken**](SecurityCreateToken.md)|  | 

### Return type

[**ResponseGeneratetoken**](ResponseGeneratetoken.md)

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

<a name="getencryptionkey"></a>
# **GetEncryptionKey**
> List&lt;SecurityEncryptionKeyGet&gt; GetEncryptionKey (string category, string ehelplySecuritySecretKey = null)

Getencryptionkey

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetEncryptionKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var category = "category_example";  // string | 
            var ehelplySecuritySecretKey = "ehelplySecuritySecretKey_example";  // string |  (optional) 

            try
            {
                // Getencryptionkey
                List<SecurityEncryptionKeyGet> result = apiInstance.GetEncryptionKey(category, ehelplySecuritySecretKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.GetEncryptionKey: " + e.Message );
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
 **category** | **string**|  | 
 **ehelplySecuritySecretKey** | **string**|  | [optional] 

### Return type

[**List&lt;SecurityEncryptionKeyGet&gt;**](SecurityEncryptionKeyGet.md)

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

<a name="getkey"></a>
# **GetKey**
> SecurityKeyGet GetKey (string keyUuid)

Getkey

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var keyUuid = "keyUuid_example";  // string | 

            try
            {
                // Getkey
                SecurityKeyGet result = apiInstance.GetKey(keyUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.GetKey: " + e.Message );
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
 **keyUuid** | **string**|  | 

### Return type

[**SecurityKeyGet**](SecurityKeyGet.md)

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
| **404** | Key does not exist |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchkeys"></a>
# **SearchKeys**
> List&lt;SecurityKeyGet&gt; SearchKeys ()

Searchkeys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);

            try
            {
                // Searchkeys
                List<SecurityKeyGet> result = apiInstance.SearchKeys();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SearchKeys: " + e.Message );
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

[**List&lt;SecurityKeyGet&gt;**](SecurityKeyGet.md)

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

<a name="verifykey"></a>
# **VerifyKey**
> SecurityKeyGet VerifyKey (SecurityKeyVerify securityKeyVerify)

Verifykey

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class VerifyKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var securityKeyVerify = new SecurityKeyVerify(); // SecurityKeyVerify | 

            try
            {
                // Verifykey
                SecurityKeyGet result = apiInstance.VerifyKey(securityKeyVerify);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.VerifyKey: " + e.Message );
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
 **securityKeyVerify** | [**SecurityKeyVerify**](SecurityKeyVerify.md)|  | 

### Return type

[**SecurityKeyGet**](SecurityKeyGet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Access token and secret token lengths must be greater than 48 characters and less than 1024 characters to guarantee adequate security.  |  -  |
| **403** | Key |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

