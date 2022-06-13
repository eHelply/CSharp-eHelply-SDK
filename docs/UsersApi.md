# Ehelply.Sdk.Api.UsersApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfirmSignup**](UsersApi.md#confirmsignup) | **POST** /sam/users/auth/signup/confirm | Confirmsignup
[**CreateParticipant**](UsersApi.md#createparticipant) | **POST** /sam/users/participants | Createparticipant
[**CreateUser**](UsersApi.md#createuser) | **POST** /sam/users | Createuser
[**DeleteParticipant**](UsersApi.md#deleteparticipant) | **DELETE** /sam/users/participants/{participant_id} | Deleteparticipant
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /sam/users/{user_id} | Deleteuser
[**GetParticipant**](UsersApi.md#getparticipant) | **GET** /sam/users/participants/{participant_id} | Getparticipant
[**GetUser**](UsersApi.md#getuser) | **GET** /sam/users/{user_id} | Getuser
[**Login**](UsersApi.md#login) | **POST** /sam/users/auth/login | Login
[**RefreshToken**](UsersApi.md#refreshtoken) | **POST** /sam/users/auth/{app_client}/refresh-token | Refreshtoken
[**ResetPassword**](UsersApi.md#resetpassword) | **POST** /sam/users/auth/password/reset | Resetpassword
[**ResetPasswordConfirmation**](UsersApi.md#resetpasswordconfirmation) | **POST** /sam/users/auth/password/reset/confirm | Resetpasswordconfirmation
[**SearchParticipants**](UsersApi.md#searchparticipants) | **GET** /sam/users/participants | Searchparticipants
[**Signup**](UsersApi.md#signup) | **POST** /sam/users/auth/signup | Signup
[**UpdateParticipant**](UsersApi.md#updateparticipant) | **PUT** /sam/users/participants/{participant_id} | Updateparticipant
[**UpdateUser**](UsersApi.md#updateuser) | **PUT** /sam/users/{user_id} | Updateuser
[**UserValidations**](UsersApi.md#uservalidations) | **POST** /sam/users/validations/{field} | Uservalidations


<a name="confirmsignup"></a>
# **ConfirmSignup**
> Object ConfirmSignup (UserConfirmation userConfirmation)

Confirmsignup

Validates a user signup with a given confirmation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ConfirmSignupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var userConfirmation = new UserConfirmation(); // UserConfirmation | 

            try
            {
                // Confirmsignup
                Object result = apiInstance.ConfirmSignup(userConfirmation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ConfirmSignup: " + e.Message );
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
 **userConfirmation** | [**UserConfirmation**](UserConfirmation.md)|  | 

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

<a name="createparticipant"></a>
# **CreateParticipant**
> ParticipantUserReturn CreateParticipant (ParticipantCreate participantCreate, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Createparticipant

Creates a participant given the participant info (meta and user_id)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var participantCreate = new ParticipantCreate(); // ParticipantCreate | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Createparticipant
                ParticipantUserReturn result = apiInstance.CreateParticipant(participantCreate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CreateParticipant: " + e.Message );
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
 **participantCreate** | [**ParticipantCreate**](ParticipantCreate.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**ParticipantUserReturn**](ParticipantUserReturn.md)

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

<a name="createuser"></a>
# **CreateUser**
> UserResponse CreateUser (string authorization = null)

Createuser

Usually ran after login and will do the following: - If no user exists (AKA signed in with social media) it will create a new user and default participant - If a user exists, sync Cognito data from Cognito to the user - Determine missing fields that SHOULD be filled

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class CreateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var authorization = "authorization_example";  // string |  (optional) 

            try
            {
                // Createuser
                UserResponse result = apiInstance.CreateUser(authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUser: " + e.Message );
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
 **authorization** | **string**|  | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

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

<a name="deleteparticipant"></a>
# **DeleteParticipant**
> bool DeleteParticipant (string participantId, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Deleteparticipant

Delete participants related to the given participant_id, returns True if successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var participantId = "participantId_example";  // string | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Deleteparticipant
                bool result = apiInstance.DeleteParticipant(participantId, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteParticipant: " + e.Message );
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
 **participantId** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

**bool**

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

<a name="deleteuser"></a>
# **DeleteUser**
> bool DeleteUser (string userId, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Deleteuser

Soft deletes the user with the provided user id, granted the deleter is the same person or an admin. Returns True if successful

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Deleteuser
                bool result = apiInstance.DeleteUser(userId, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
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
 **userId** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

**bool**

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

<a name="getparticipant"></a>
# **GetParticipant**
> ParticipantUserReturn GetParticipant (string participantId, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Getparticipant

Gets a participant given their participant ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var participantId = "participantId_example";  // string | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Getparticipant
                ParticipantUserReturn result = apiInstance.GetParticipant(participantId, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetParticipant: " + e.Message );
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
 **participantId** | **string**|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**ParticipantUserReturn**](ParticipantUserReturn.md)

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

<a name="getuser"></a>
# **GetUser**
> UserResponse GetUser (string userId, string idType = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Getuser

Gets the user object given user id (uuid) or cognito id (cognito)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class GetUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 
            var idType = cognito OR uuid;  // string |  (optional) 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Getuser
                UserResponse result = apiInstance.GetUser(userId, idType, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
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
 **userId** | **string**|  | 
 **idType** | **string**|  | [optional] 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

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

<a name="login"></a>
# **Login**
> UserLoginReturn Login (UserLogin userLogin)

Login

Login endpoint, returns tokens. EMAIL NEEDS TO BE VERIFIED (can be done through the email the user received).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var userLogin = new UserLogin(); // UserLogin | 

            try
            {
                // Login
                UserLoginReturn result = apiInstance.Login(userLogin);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.Login: " + e.Message );
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
 **userLogin** | [**UserLogin**](UserLogin.md)|  | 

### Return type

[**UserLoginReturn**](UserLoginReturn.md)

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

<a name="refreshtoken"></a>
# **RefreshToken**
> UserTokenReturn RefreshToken (string appClient, string body)

Refreshtoken

Refreshes tokens given a refresh token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class RefreshTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var appClient = "appClient_example";  // string | 
            var body = "body_example";  // string | 

            try
            {
                // Refreshtoken
                UserTokenReturn result = apiInstance.RefreshToken(appClient, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.RefreshToken: " + e.Message );
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
 **appClient** | **string**|  | 
 **body** | **string**|  | 

### Return type

[**UserTokenReturn**](UserTokenReturn.md)

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

<a name="resetpassword"></a>
# **ResetPassword**
> Object ResetPassword (UserPasswordReset userPasswordReset)

Resetpassword

Sends the user an email with a confirmation code so they can reset their password

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ResetPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var userPasswordReset = new UserPasswordReset(); // UserPasswordReset | 

            try
            {
                // Resetpassword
                Object result = apiInstance.ResetPassword(userPasswordReset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ResetPassword: " + e.Message );
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
 **userPasswordReset** | [**UserPasswordReset**](UserPasswordReset.md)|  | 

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

<a name="resetpasswordconfirmation"></a>
# **ResetPasswordConfirmation**
> Object ResetPasswordConfirmation (UserPasswordResetConfirmation userPasswordResetConfirmation)

Resetpasswordconfirmation

Resets the given user's password to the given password when the proper code is provided

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class ResetPasswordConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var userPasswordResetConfirmation = new UserPasswordResetConfirmation(); // UserPasswordResetConfirmation | 

            try
            {
                // Resetpasswordconfirmation
                Object result = apiInstance.ResetPasswordConfirmation(userPasswordResetConfirmation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ResetPasswordConfirmation: " + e.Message );
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
 **userPasswordResetConfirmation** | [**UserPasswordResetConfirmation**](UserPasswordResetConfirmation.md)|  | 

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

<a name="searchparticipants"></a>
# **SearchParticipants**
> Page SearchParticipants (int? page = null, int? pageSize = null, string search = null, string searchOn = null, string sortOn = null, bool? sortDesc = null, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Searchparticipants

Search participants using a user uuid, returns pagination information and list of `items` (ParticipantUserReturn from GET Participant). Can search on \"user_uuid\", and sort on any field. To search enter search value into \"search\" query param and the field into \"search on\" (currently only \"user\"uuid\"). For sorting fill out \"sort_desc\" field with either true/false and the \"sort_on\" query parameter with column you want to sort on (ex: date_created). Max pagination items per page is 50.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SearchParticipantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var page = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 25;  // int? |  (optional)  (default to 25)
            var search = "search_example";  // string |  (optional) 
            var searchOn = "searchOn_example";  // string |  (optional) 
            var sortOn = "sortOn_example";  // string |  (optional) 
            var sortDesc = false;  // bool? |  (optional)  (default to false)
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Searchparticipants
                Page result = apiInstance.SearchParticipants(page, pageSize, search, searchOn, sortOn, sortDesc, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.SearchParticipants: " + e.Message );
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
 **page** | **int?**|  | [optional] [default to 1]
 **pageSize** | **int?**|  | [optional] [default to 25]
 **search** | **string**|  | [optional] 
 **searchOn** | **string**|  | [optional] 
 **sortOn** | **string**|  | [optional] 
 **sortDesc** | **bool?**|  | [optional] [default to false]
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

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

<a name="signup"></a>
# **Signup**
> UserSignupReturn Signup (UserSignup userSignup)

Signup

Signup to eHelply, creates a user and default participant behind the scenes. Does not verify email.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class SignupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var userSignup = new UserSignup(); // UserSignup | 

            try
            {
                // Signup
                UserSignupReturn result = apiInstance.Signup(userSignup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.Signup: " + e.Message );
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
 **userSignup** | [**UserSignup**](UserSignup.md)|  | 

### Return type

[**UserSignupReturn**](UserSignupReturn.md)

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

<a name="updateparticipant"></a>
# **UpdateParticipant**
> ParticipantUserReturn UpdateParticipant (string participantId, ParticipantUpdate participantUpdate, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Updateparticipant

Update participant data given

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var participantId = "participantId_example";  // string | 
            var participantUpdate = new ParticipantUpdate(); // ParticipantUpdate | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Updateparticipant
                ParticipantUserReturn result = apiInstance.UpdateParticipant(participantId, participantUpdate, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateParticipant: " + e.Message );
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
 **participantId** | **string**|  | 
 **participantUpdate** | [**ParticipantUpdate**](ParticipantUpdate.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**ParticipantUserReturn**](ParticipantUserReturn.md)

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

<a name="updateuser"></a>
# **UpdateUser**
> UserResponse UpdateUser (string userId, User user, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Updateuser

Update the given user and sync the cognito data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 
            var user = new User(); // User | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Updateuser
                UserResponse result = apiInstance.UpdateUser(userId, user, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
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
 **userId** | **string**|  | 
 **user** | [**User**](User.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

[**UserResponse**](UserResponse.md)

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

<a name="uservalidations"></a>
# **UserValidations**
> bool UserValidations (string field, UserValidations userValidations, string xAccessToken = null, string xSecretToken = null, string authorization = null, string ehelplyActiveParticipant = null, string ehelplyProject = null, string ehelplyData = null)

Uservalidations

Validates a certain field.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Ehelply.Sdk.Api;
using Ehelply.Sdk.Client;
using Ehelply.Sdk.Model;

namespace Example
{
    public class UserValidationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.ehelply.com";
            var apiInstance = new UsersApi(config);
            var field = email;  // string | 
            var userValidations = new UserValidations(); // UserValidations | 
            var xAccessToken = "xAccessToken_example";  // string |  (optional) 
            var xSecretToken = "xSecretToken_example";  // string |  (optional) 
            var authorization = "authorization_example";  // string |  (optional) 
            var ehelplyActiveParticipant = "ehelplyActiveParticipant_example";  // string |  (optional) 
            var ehelplyProject = "ehelplyProject_example";  // string |  (optional) 
            var ehelplyData = "ehelplyData_example";  // string |  (optional) 

            try
            {
                // Uservalidations
                bool result = apiInstance.UserValidations(field, userValidations, xAccessToken, xSecretToken, authorization, ehelplyActiveParticipant, ehelplyProject, ehelplyData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UserValidations: " + e.Message );
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
 **field** | **string**|  | 
 **userValidations** | [**UserValidations**](UserValidations.md)|  | 
 **xAccessToken** | **string**|  | [optional] 
 **xSecretToken** | **string**|  | [optional] 
 **authorization** | **string**|  | [optional] 
 **ehelplyActiveParticipant** | **string**|  | [optional] 
 **ehelplyProject** | **string**|  | [optional] 
 **ehelplyData** | **string**|  | [optional] 

### Return type

**bool**

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

