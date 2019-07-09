# ProcessMakerSDK.Api.PermissionsApi

All URIs are relative to *http://localhost/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProcessMakerHttpControllersApiPermissionControllerUpdate**](PermissionsApi.md#processmakerhttpcontrollersapipermissioncontrollerupdate) | **PUT** /permissions | Update the permissions of an user



## ProcessMakerHttpControllersApiPermissionControllerUpdate

> void ProcessMakerHttpControllersApiPermissionControllerUpdate (InlineObject4 inlineObject4)

Update the permissions of an user

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class ProcessMakerHttpControllersApiPermissionControllerUpdateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api/1.0";
            // Configure OAuth2 access token for authorization: pm_api_auth_code
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: pm_api_key
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PermissionsApi(Configuration.Default);
            var inlineObject4 = new InlineObject4(); // InlineObject4 | 

            try
            {
                // Update the permissions of an user
                apiInstance.ProcessMakerHttpControllersApiPermissionControllerUpdate(inlineObject4);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PermissionsApi.ProcessMakerHttpControllersApiPermissionControllerUpdate: " + e.Message );
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
 **inlineObject4** | [**InlineObject4**](InlineObject4.md)|  | 

### Return type

void (empty response body)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

