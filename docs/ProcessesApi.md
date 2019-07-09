# ProcessMakerSDK.Api.ProcessesApi

All URIs are relative to *http://localhost/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AssignmentProcess**](ProcessesApi.md#assignmentprocess) | **POST** /processes/{process_id}/import/assignments | Update assignments after import
[**CreateProcess**](ProcessesApi.md#createprocess) | **POST** /processes | Save a new process
[**DeleteProcess**](ProcessesApi.md#deleteprocess) | **DELETE** /processes/{processId} | Delete a process
[**ExportProcess**](ProcessesApi.md#exportprocess) | **GET** /processes/{processId}/export | Export a single process by ID
[**GetProcessById**](ProcessesApi.md#getprocessbyid) | **GET** /processes/{processId} | Get single process by ID
[**GetProcesses**](ProcessesApi.md#getprocesses) | **GET** /processes | Returns all processes that the user has access to
[**ImportProcess**](ProcessesApi.md#importprocess) | **POST** /processes/import | Import a new process
[**RestoreProcess**](ProcessesApi.md#restoreprocess) | **PUT** /processes/{processId}/restore | Restore an inactive process
[**StartProcesses**](ProcessesApi.md#startprocesses) | **GET** /start_processes | Returns the list of processes that the user can start
[**TriggerStartEvent**](ProcessesApi.md#triggerstartevent) | **POST** /process_events/{process_id} | Start a new process
[**UpdateProcess**](ProcessesApi.md#updateprocess) | **PUT** /processes/{processId} | Update a process



## AssignmentProcess

> Process AssignmentProcess (ProcessEditable processEditable)

Update assignments after import

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class AssignmentProcessExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var processEditable = new ProcessEditable(); // ProcessEditable | 

            try
            {
                // Update assignments after import
                Process result = apiInstance.AssignmentProcess(processEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.AssignmentProcess: " + e.Message );
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
 **processEditable** | [**ProcessEditable**](ProcessEditable.md)|  | 

### Return type

[**Process**](Process.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateProcess

> Process CreateProcess (ProcessEditable processEditable)

Save a new process

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class CreateProcessExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var processEditable = new ProcessEditable(); // ProcessEditable | 

            try
            {
                // Save a new process
                Process result = apiInstance.CreateProcess(processEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.CreateProcess: " + e.Message );
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
 **processEditable** | [**ProcessEditable**](ProcessEditable.md)|  | 

### Return type

[**Process**](Process.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteProcess

> Process DeleteProcess (string processId)

Delete a process

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class DeleteProcessExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var processId = processId_example;  // string | ID of process to return

            try
            {
                // Delete a process
                Process result = apiInstance.DeleteProcess(processId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.DeleteProcess: " + e.Message );
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
 **processId** | **string**| ID of process to return | 

### Return type

[**Process**](Process.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ExportProcess

> Process ExportProcess (string processId)

Export a single process by ID

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class ExportProcessExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var processId = processId_example;  // string | ID of process to return

            try
            {
                // Export a single process by ID
                Process result = apiInstance.ExportProcess(processId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.ExportProcess: " + e.Message );
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
 **processId** | **string**| ID of process to return | 

### Return type

[**Process**](Process.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetProcessById

> Process GetProcessById (string processId)

Get single process by ID

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetProcessByIdExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var processId = processId_example;  // string | ID of process to return

            try
            {
                // Get single process by ID
                Process result = apiInstance.GetProcessById(processId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.GetProcessById: " + e.Message );
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
 **processId** | **string**| ID of process to return | 

### Return type

[**Process**](Process.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetProcesses

> InlineResponse20012 GetProcesses (string filter = null, string orderBy = null, string orderDirection = null, int? perPage = null, string status = null, string include = null)

Returns all processes that the user has access to

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetProcessesExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var filter = filter_example;  // string | Filter results by string. Searches Name, Description, and Status. Status must match exactly. Others can be a substring. (optional) 
            var orderBy = orderBy_example;  // string | Field to order results by (optional) 
            var orderDirection = orderDirection_example;  // string |  (optional)  (default to asc)
            var perPage = 56;  // int? |  (optional) 
            var status = status_example;  // string |  (optional)  (default to active)
            var include = include_example;  // string | Include data from related models in payload. Comma seperated list. (optional)  (default to "")

            try
            {
                // Returns all processes that the user has access to
                InlineResponse20012 result = apiInstance.GetProcesses(filter, orderBy, orderDirection, perPage, status, include);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.GetProcesses: " + e.Message );
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
 **status** | **string**|  | [optional] [default to active]
 **include** | **string**| Include data from related models in payload. Comma seperated list. | [optional] [default to &quot;&quot;]

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ImportProcess

> Process ImportProcess (System.IO.Stream file)

Import a new process

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class ImportProcessExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var file = new System.IO.Stream(); // System.IO.Stream | file to upload

            try
            {
                // Import a new process
                Process result = apiInstance.ImportProcess(file);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.ImportProcess: " + e.Message );
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
 **file** | [**System.IO.Stream**](System.IO.Stream.md)| file to upload | 

### Return type

[**Process**](Process.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RestoreProcess

> Process RestoreProcess (string processId, ProcessEditable processEditable)

Restore an inactive process

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class RestoreProcessExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var processId = processId_example;  // string | ID of process to return
            var processEditable = new ProcessEditable(); // ProcessEditable | 

            try
            {
                // Restore an inactive process
                Process result = apiInstance.RestoreProcess(processId, processEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.RestoreProcess: " + e.Message );
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
 **processId** | **string**| ID of process to return | 
 **processEditable** | [**ProcessEditable**](ProcessEditable.md)|  | 

### Return type

[**Process**](Process.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## StartProcesses

> InlineResponse20013 StartProcesses (string orderBy = null, string orderDirection = null, int? perPage = null, string include = null)

Returns the list of processes that the user can start

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class StartProcessesExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var orderBy = orderBy_example;  // string | Field to order results by (optional) 
            var orderDirection = orderDirection_example;  // string |  (optional)  (default to asc)
            var perPage = 56;  // int? |  (optional) 
            var include = include_example;  // string | Include data from related models in payload. Comma seperated list. (optional)  (default to "")

            try
            {
                // Returns the list of processes that the user can start
                InlineResponse20013 result = apiInstance.StartProcesses(orderBy, orderDirection, perPage, include);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.StartProcesses: " + e.Message );
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
 **orderBy** | **string**| Field to order results by | [optional] 
 **orderDirection** | **string**|  | [optional] [default to asc]
 **perPage** | **int?**|  | [optional] 
 **include** | **string**| Include data from related models in payload. Comma seperated list. | [optional] [default to &quot;&quot;]

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## TriggerStartEvent

> ProcessRequest TriggerStartEvent (string processId, string _event, Object body = null)

Start a new process

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class TriggerStartEventExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var processId = processId_example;  // string | ID of process to return
            var _event = _event_example;  // string | Node ID of the start event
            var body = ;  // Object |  (optional) 

            try
            {
                // Start a new process
                ProcessRequest result = apiInstance.TriggerStartEvent(processId, _event, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.TriggerStartEvent: " + e.Message );
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
 **processId** | **string**| ID of process to return | 
 **_event** | **string**| Node ID of the start event | 
 **body** | **Object**|  | [optional] 

### Return type

[**ProcessRequest**](ProcessRequest.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateProcess

> Process UpdateProcess (string processId, ProcessEditable processEditable)

Update a process

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class UpdateProcessExample
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

            var apiInstance = new ProcessesApi(Configuration.Default);
            var processId = processId_example;  // string | ID of process to return
            var processEditable = new ProcessEditable(); // ProcessEditable | 

            try
            {
                // Update a process
                Process result = apiInstance.UpdateProcess(processId, processEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ProcessesApi.UpdateProcess: " + e.Message );
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
 **processId** | **string**| ID of process to return | 
 **processEditable** | [**ProcessEditable**](ProcessEditable.md)|  | 

### Return type

[**Process**](Process.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

