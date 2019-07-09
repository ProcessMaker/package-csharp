# ProcessMakerSDK.Api.ScriptsApi

All URIs are relative to *http://localhost/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateScript**](ScriptsApi.md#createscript) | **POST** /scripts | Save a new script
[**DeleteScript**](ScriptsApi.md#deletescript) | **DELETE** /scripts/scriptsId | Delete a script
[**DuplicateScreen**](ScriptsApi.md#duplicatescreen) | **PUT** /scripts/scriptsId/duplicate | duplicate a script
[**GetScripts**](ScriptsApi.md#getscripts) | **GET** /scripts | Returns all scripts that the user has access to
[**GetScriptsById**](ScriptsApi.md#getscriptsbyid) | **GET** /scripts/scriptsId | Get single script by ID
[**GetScriptsPreview**](ScriptsApi.md#getscriptspreview) | **GET** /scripts/{script_id}/preview | Test script code without saving it
[**UpdateScript**](ScriptsApi.md#updatescript) | **PUT** /scripts/scriptsId | Update a script



## CreateScript

> Scripts CreateScript (ScriptsEditable scriptsEditable)

Save a new script

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class CreateScriptExample
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

            var apiInstance = new ScriptsApi(Configuration.Default);
            var scriptsEditable = new ScriptsEditable(); // ScriptsEditable | 

            try
            {
                // Save a new script
                Scripts result = apiInstance.CreateScript(scriptsEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScriptsApi.CreateScript: " + e.Message );
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
 **scriptsEditable** | [**ScriptsEditable**](ScriptsEditable.md)|  | 

### Return type

[**Scripts**](Scripts.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteScript

> Scripts DeleteScript (string scriptId)

Delete a script

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class DeleteScriptExample
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

            var apiInstance = new ScriptsApi(Configuration.Default);
            var scriptId = scriptId_example;  // string | ID of script to return

            try
            {
                // Delete a script
                Scripts result = apiInstance.DeleteScript(scriptId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScriptsApi.DeleteScript: " + e.Message );
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
 **scriptId** | **string**| ID of script to return | 

### Return type

[**Scripts**](Scripts.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DuplicateScreen

> Scripts DuplicateScreen (string screensId, ScreensEditable screensEditable)

duplicate a script

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class DuplicateScreenExample
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

            var apiInstance = new ScriptsApi(Configuration.Default);
            var screensId = screensId_example;  // string | ID of script to return
            var screensEditable = new ScreensEditable(); // ScreensEditable | 

            try
            {
                // duplicate a script
                Scripts result = apiInstance.DuplicateScreen(screensId, screensEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScriptsApi.DuplicateScreen: " + e.Message );
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
 **screensId** | **string**| ID of script to return | 
 **screensEditable** | [**ScreensEditable**](ScreensEditable.md)|  | 

### Return type

[**Scripts**](Scripts.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetScripts

> InlineResponse20017 GetScripts (string filter = null, string orderBy = null, string orderDirection = null, int? perPage = null, string include = null)

Returns all scripts that the user has access to

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetScriptsExample
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

            var apiInstance = new ScriptsApi(Configuration.Default);
            var filter = filter_example;  // string | Filter results by string. Searches Name, Description, and Status. Status must match exactly. Others can be a substring. (optional) 
            var orderBy = orderBy_example;  // string | Field to order results by (optional) 
            var orderDirection = orderDirection_example;  // string |  (optional)  (default to asc)
            var perPage = 56;  // int? |  (optional) 
            var include = include_example;  // string | Include data from related models in payload. Comma seperated list. (optional)  (default to "")

            try
            {
                // Returns all scripts that the user has access to
                InlineResponse20017 result = apiInstance.GetScripts(filter, orderBy, orderDirection, perPage, include);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScripts: " + e.Message );
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
 **filter** | **string**| Filter results by string. Searches Name, Description, and Status. Status must match exactly. Others can be a substring. | [optional] 
 **orderBy** | **string**| Field to order results by | [optional] 
 **orderDirection** | **string**|  | [optional] [default to asc]
 **perPage** | **int?**|  | [optional] 
 **include** | **string**| Include data from related models in payload. Comma seperated list. | [optional] [default to &quot;&quot;]

### Return type

[**InlineResponse20017**](InlineResponse20017.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetScriptsById

> Scripts GetScriptsById (string scriptId)

Get single script by ID

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetScriptsByIdExample
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

            var apiInstance = new ScriptsApi(Configuration.Default);
            var scriptId = scriptId_example;  // string | ID of script to return

            try
            {
                // Get single script by ID
                Scripts result = apiInstance.GetScriptsById(scriptId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsById: " + e.Message );
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
 **scriptId** | **string**| ID of script to return | 

### Return type

[**Scripts**](Scripts.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetScriptsPreview

> Object GetScriptsPreview (int? scriptId, string data = null, string config = null, string code = null)

Test script code without saving it

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetScriptsPreviewExample
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

            var apiInstance = new ScriptsApi(Configuration.Default);
            var scriptId = 56;  // int? | 
            var data = data_example;  // string |  (optional) 
            var config = config_example;  // string |  (optional) 
            var code = code_example;  // string |  (optional) 

            try
            {
                // Test script code without saving it
                Object result = apiInstance.GetScriptsPreview(scriptId, data, config, code);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScriptsPreview: " + e.Message );
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
 **scriptId** | **int?**|  | 
 **data** | **string**|  | [optional] 
 **config** | **string**|  | [optional] 
 **code** | **string**|  | [optional] 

### Return type

**Object**

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateScript

> Scripts UpdateScript (string scriptId, ScriptsEditable scriptsEditable)

Update a script

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class UpdateScriptExample
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

            var apiInstance = new ScriptsApi(Configuration.Default);
            var scriptId = scriptId_example;  // string | ID of script to return
            var scriptsEditable = new ScriptsEditable(); // ScriptsEditable | 

            try
            {
                // Update a script
                Scripts result = apiInstance.UpdateScript(scriptId, scriptsEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScriptsApi.UpdateScript: " + e.Message );
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
 **scriptId** | **string**| ID of script to return | 
 **scriptsEditable** | [**ScriptsEditable**](ScriptsEditable.md)|  | 

### Return type

[**Scripts**](Scripts.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

