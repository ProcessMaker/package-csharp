# ProcessMakerSDK.Api.EnvironmentVariablesApi

All URIs are relative to *http://localhost/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateEnvironmentVariables**](EnvironmentVariablesApi.md#createenvironmentvariables) | **POST** /environment_variables | Save a new environment_variables
[**DeleteEnvironmentVariables**](EnvironmentVariablesApi.md#deleteenvironmentvariables) | **DELETE** /environment_variables/{environment_variables_id} | Delete a environment_variables
[**GetEnvironmentVariables**](EnvironmentVariablesApi.md#getenvironmentvariables) | **GET** /environment_variables | Returns all environmentVariables that the user has access to
[**GetEnvironmentVariablesById**](EnvironmentVariablesApi.md#getenvironmentvariablesbyid) | **GET** /environment_variables/{environment_variables_id} | Get single environment_variables by ID
[**UpdateEnvironmentVariables**](EnvironmentVariablesApi.md#updateenvironmentvariables) | **PUT** /environment_variables/{environment_variables_id} | Update a environment_variables



## CreateEnvironmentVariables

> EnvironmentVariables CreateEnvironmentVariables (EnvironmentVariablesEditable environmentVariablesEditable)

Save a new environment_variables

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class CreateEnvironmentVariablesExample
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

            var apiInstance = new EnvironmentVariablesApi(Configuration.Default);
            var environmentVariablesEditable = new EnvironmentVariablesEditable(); // EnvironmentVariablesEditable | 

            try
            {
                // Save a new environment_variables
                EnvironmentVariables result = apiInstance.CreateEnvironmentVariables(environmentVariablesEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnvironmentVariablesApi.CreateEnvironmentVariables: " + e.Message );
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
 **environmentVariablesEditable** | [**EnvironmentVariablesEditable**](EnvironmentVariablesEditable.md)|  | 

### Return type

[**EnvironmentVariables**](EnvironmentVariables.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteEnvironmentVariables

> EnvironmentVariables DeleteEnvironmentVariables (string environmentVariablesId)

Delete a environment_variables

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class DeleteEnvironmentVariablesExample
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

            var apiInstance = new EnvironmentVariablesApi(Configuration.Default);
            var environmentVariablesId = environmentVariablesId_example;  // string | ID of environment_variables to return

            try
            {
                // Delete a environment_variables
                EnvironmentVariables result = apiInstance.DeleteEnvironmentVariables(environmentVariablesId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnvironmentVariablesApi.DeleteEnvironmentVariables: " + e.Message );
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
 **environmentVariablesId** | **string**| ID of environment_variables to return | 

### Return type

[**EnvironmentVariables**](EnvironmentVariables.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEnvironmentVariables

> InlineResponse2001 GetEnvironmentVariables (string filter = null, string orderBy = null, string orderDirection = null, int? perPage = null, string include = null)

Returns all environmentVariables that the user has access to

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetEnvironmentVariablesExample
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

            var apiInstance = new EnvironmentVariablesApi(Configuration.Default);
            var filter = filter_example;  // string | Filter results by string. Searches Name, Description, and Status. Status must match exactly. Others can be a substring. (optional) 
            var orderBy = orderBy_example;  // string | Field to order results by (optional) 
            var orderDirection = orderDirection_example;  // string |  (optional)  (default to asc)
            var perPage = 56;  // int? |  (optional) 
            var include = include_example;  // string | Include data from related models in payload. Comma seperated list. (optional)  (default to "")

            try
            {
                // Returns all environmentVariables that the user has access to
                InlineResponse2001 result = apiInstance.GetEnvironmentVariables(filter, orderBy, orderDirection, perPage, include);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnvironmentVariablesApi.GetEnvironmentVariables: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetEnvironmentVariablesById

> EnvironmentVariables GetEnvironmentVariablesById (string environmentVariablesId)

Get single environment_variables by ID

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetEnvironmentVariablesByIdExample
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

            var apiInstance = new EnvironmentVariablesApi(Configuration.Default);
            var environmentVariablesId = environmentVariablesId_example;  // string | ID of environment_variables to return

            try
            {
                // Get single environment_variables by ID
                EnvironmentVariables result = apiInstance.GetEnvironmentVariablesById(environmentVariablesId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnvironmentVariablesApi.GetEnvironmentVariablesById: " + e.Message );
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
 **environmentVariablesId** | **string**| ID of environment_variables to return | 

### Return type

[**EnvironmentVariables**](EnvironmentVariables.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateEnvironmentVariables

> EnvironmentVariables UpdateEnvironmentVariables (string environmentVariablesId, EnvironmentVariablesEditable environmentVariablesEditable)

Update a environment_variables

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class UpdateEnvironmentVariablesExample
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

            var apiInstance = new EnvironmentVariablesApi(Configuration.Default);
            var environmentVariablesId = environmentVariablesId_example;  // string | ID of environment_variables to return
            var environmentVariablesEditable = new EnvironmentVariablesEditable(); // EnvironmentVariablesEditable | 

            try
            {
                // Update a environment_variables
                EnvironmentVariables result = apiInstance.UpdateEnvironmentVariables(environmentVariablesId, environmentVariablesEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling EnvironmentVariablesApi.UpdateEnvironmentVariables: " + e.Message );
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
 **environmentVariablesId** | **string**| ID of environment_variables to return | 
 **environmentVariablesEditable** | [**EnvironmentVariablesEditable**](EnvironmentVariablesEditable.md)|  | 

### Return type

[**EnvironmentVariables**](EnvironmentVariables.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

