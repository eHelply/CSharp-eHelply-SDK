# Ehelply.Sdk.Api.AuthApi

All URIs are relative to *https://api.prod.ehelply.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost**](AuthApi.md#resetpasswordconfirmationusersauthpasswordresetconfirmpost) | **POST** /sam/users/auth/password/reset/confirm | Reset Password Confirmation


<a name="resetpasswordconfirmationusersauthpasswordresetconfirmpost"></a>
# **ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost**
> Object ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost (UserPasswordResetConfirmation userPasswordResetConfirmation)

Reset Password Confirmation

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
    public class ResetPasswordConfirmationUsersAuthPasswordResetConfirmPostExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.ResetPasswordConfirmationUsersAuthPasswordResetConfirmPost: " + e.Message );
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

