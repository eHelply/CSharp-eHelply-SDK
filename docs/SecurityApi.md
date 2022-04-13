# Ehelply.Sdk.Api.SecurityApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEncryptionKeySecurityEncryptionCategoriesCategoryKeysPost**](SecurityApi.md#createencryptionkeysecurityencryptioncategoriescategorykeyspost) | **POST** /sam/security/encryption/categories/{category}/keys | Create Encryption Key
[**CreateKeySecurityKeysPost**](SecurityApi.md#createkeysecuritykeyspost) | **POST** /sam/security/keys | Create Key
[**DeleteKeySecurityKeysKeyUuidDelete**](SecurityApi.md#deletekeysecuritykeyskeyuuiddelete) | **DELETE** /sam/security/keys/{key_uuid} | Delete Key
[**GenerateTokenSecurityTokensPost**](SecurityApi.md#generatetokensecuritytokenspost) | **POST** /sam/security/tokens | Generate Token
[**GetEncryptionKeySecurityEncryptionCategoriesCategoryKeysGet**](SecurityApi.md#getencryptionkeysecurityencryptioncategoriescategorykeysget) | **GET** /sam/security/encryption/categories/{category}/keys | Get Encryption Key
[**GetKeySecurityKeysKeyUuidGet**](SecurityApi.md#getkeysecuritykeyskeyuuidget) | **GET** /sam/security/keys/{key_uuid} | Get Key
[**SearchKeysSecurityKeysGet**](SecurityApi.md#searchkeyssecuritykeysget) | **GET** /sam/security/keys | Search Keys
[**VerifyKeySecurityKeysVerifyPost**](SecurityApi.md#verifykeysecuritykeysverifypost) | **POST** /sam/security/keys/verify | Verify Key


<a name="createencryptionkeysecurityencryptioncategoriescategorykeyspost"></a>
# **CreateEncryptionKeySecurityEncryptionCategoriesCategoryKeysPost**
> Object CreateEncryptionKeySecurityEncryptionCategoriesCategoryKeysPost (string category, string ehelplySecuritySecretKey = null)

Create Encryption Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateEncryptionKeySecurityEncryptionCategoriesCategoryKeysPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var category = category_example;  // string | 
            var ehelplySecuritySecretKey = ehelplySecuritySecretKey_example;  // string |  (optional) 

            try
            {
                // Create Encryption Key
                Object result = apiInstance.CreateEncryptionKeySecurityEncryptionCategoriesCategoryKeysPost(category, ehelplySecuritySecretKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.CreateEncryptionKeySecurityEncryptionCategoriesCategoryKeysPost: " + e.Message );
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

<a name="createkeysecuritykeyspost"></a>
# **CreateKeySecurityKeysPost**
> Object CreateKeySecurityKeysPost (BodyCreateKeySecurityKeysPost bodyCreateKeySecurityKeysPost, int? accessLength = null, int? secretLength = null)

Create Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateKeySecurityKeysPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var bodyCreateKeySecurityKeysPost = new BodyCreateKeySecurityKeysPost(); // BodyCreateKeySecurityKeysPost | 
            var accessLength = 56;  // int? |  (optional)  (default to 64)
            var secretLength = 56;  // int? |  (optional)  (default to 64)

            try
            {
                // Create Key
                Object result = apiInstance.CreateKeySecurityKeysPost(bodyCreateKeySecurityKeysPost, accessLength, secretLength);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.CreateKeySecurityKeysPost: " + e.Message );
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
 **bodyCreateKeySecurityKeysPost** | [**BodyCreateKeySecurityKeysPost**](BodyCreateKeySecurityKeysPost.md)|  | 
 **accessLength** | **int?**|  | [optional] [default to 64]
 **secretLength** | **int?**|  | [optional] [default to 64]

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
| **400** | Access token and secret token lengths must be greater than 48 characters and less than 1024 characters to guarantee adequate security.  |  -  |
| **403** | Unauthorized - Denied by eHelply |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletekeysecuritykeyskeyuuiddelete"></a>
# **DeleteKeySecurityKeysKeyUuidDelete**
> Object DeleteKeySecurityKeysKeyUuidDelete (string keyUuid)

Delete Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteKeySecurityKeysKeyUuidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var keyUuid = keyUuid_example;  // string | 

            try
            {
                // Delete Key
                Object result = apiInstance.DeleteKeySecurityKeysKeyUuidDelete(keyUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.DeleteKeySecurityKeysKeyUuidDelete: " + e.Message );
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
| **403** | Unauthorized - Denied by eHelply |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatetokensecuritytokenspost"></a>
# **GenerateTokenSecurityTokensPost**
> Object GenerateTokenSecurityTokensPost (BodyGenerateTokenSecurityTokensPost bodyGenerateTokenSecurityTokensPost)

Generate Token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GenerateTokenSecurityTokensPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var bodyGenerateTokenSecurityTokensPost = new BodyGenerateTokenSecurityTokensPost(); // BodyGenerateTokenSecurityTokensPost | 

            try
            {
                // Generate Token
                Object result = apiInstance.GenerateTokenSecurityTokensPost(bodyGenerateTokenSecurityTokensPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.GenerateTokenSecurityTokensPost: " + e.Message );
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
 **bodyGenerateTokenSecurityTokensPost** | [**BodyGenerateTokenSecurityTokensPost**](BodyGenerateTokenSecurityTokensPost.md)|  | 

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
| **403** | Unauthorized - Denied by eHelply |  -  |
| **404** | Not found |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getencryptionkeysecurityencryptioncategoriescategorykeysget"></a>
# **GetEncryptionKeySecurityEncryptionCategoriesCategoryKeysGet**
> List&lt;SecurityEncryptionKeyGet&gt; GetEncryptionKeySecurityEncryptionCategoriesCategoryKeysGet (string category, string ehelplySecuritySecretKey = null)

Get Encryption Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetEncryptionKeySecurityEncryptionCategoriesCategoryKeysGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var category = category_example;  // string | 
            var ehelplySecuritySecretKey = ehelplySecuritySecretKey_example;  // string |  (optional) 

            try
            {
                // Get Encryption Key
                List<SecurityEncryptionKeyGet> result = apiInstance.GetEncryptionKeySecurityEncryptionCategoriesCategoryKeysGet(category, ehelplySecuritySecretKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.GetEncryptionKeySecurityEncryptionCategoriesCategoryKeysGet: " + e.Message );
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

<a name="getkeysecuritykeyskeyuuidget"></a>
# **GetKeySecurityKeysKeyUuidGet**
> SecurityKeyGet GetKeySecurityKeysKeyUuidGet (string keyUuid)

Get Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetKeySecurityKeysKeyUuidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var keyUuid = keyUuid_example;  // string | 

            try
            {
                // Get Key
                SecurityKeyGet result = apiInstance.GetKeySecurityKeysKeyUuidGet(keyUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.GetKeySecurityKeysKeyUuidGet: " + e.Message );
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

<a name="searchkeyssecuritykeysget"></a>
# **SearchKeysSecurityKeysGet**
> List&lt;SecurityKeyGet&gt; SearchKeysSecurityKeysGet ()

Search Keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchKeysSecurityKeysGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);

            try
            {
                // Search Keys
                List<SecurityKeyGet> result = apiInstance.SearchKeysSecurityKeysGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.SearchKeysSecurityKeysGet: " + e.Message );
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

<a name="verifykeysecuritykeysverifypost"></a>
# **VerifyKeySecurityKeysVerifyPost**
> SecurityKeyGet VerifyKeySecurityKeysVerifyPost (BodyVerifyKeySecurityKeysVerifyPost bodyVerifyKeySecurityKeysVerifyPost)

Verify Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class VerifyKeySecurityKeysVerifyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new SecurityApi(config);
            var bodyVerifyKeySecurityKeysVerifyPost = new BodyVerifyKeySecurityKeysVerifyPost(); // BodyVerifyKeySecurityKeysVerifyPost | 

            try
            {
                // Verify Key
                SecurityKeyGet result = apiInstance.VerifyKeySecurityKeysVerifyPost(bodyVerifyKeySecurityKeysVerifyPost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SecurityApi.VerifyKeySecurityKeysVerifyPost: " + e.Message );
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
 **bodyVerifyKeySecurityKeysVerifyPost** | [**BodyVerifyKeySecurityKeysVerifyPost**](BodyVerifyKeySecurityKeysVerifyPost.md)|  | 

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

