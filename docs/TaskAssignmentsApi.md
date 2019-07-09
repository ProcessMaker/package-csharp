# ProcessMakerSDK.Api.TaskAssignmentsApi

All URIs are relative to *http://localhost/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTaskAssignments**](TaskAssignmentsApi.md#createtaskassignments) | **POST** /task_assignments | Save a new task assignments
[**UpdateTaskAssignments**](TaskAssignmentsApi.md#updatetaskassignments) | **PUT** /task_assignments/{task_assignments_id} | Update a task assignments



## CreateTaskAssignments

> TaskAssignments CreateTaskAssignments (TaskAssignmentsEditable taskAssignmentsEditable)

Save a new task assignments

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class CreateTaskAssignmentsExample
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

            var apiInstance = new TaskAssignmentsApi(Configuration.Default);
            var taskAssignmentsEditable = new TaskAssignmentsEditable(); // TaskAssignmentsEditable | 

            try
            {
                // Save a new task assignments
                TaskAssignments result = apiInstance.CreateTaskAssignments(taskAssignmentsEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TaskAssignmentsApi.CreateTaskAssignments: " + e.Message );
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
 **taskAssignmentsEditable** | [**TaskAssignmentsEditable**](TaskAssignmentsEditable.md)|  | 

### Return type

[**TaskAssignments**](TaskAssignments.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateTaskAssignments

> TaskAssignments UpdateTaskAssignments (string taskAssignmentsId, TaskAssignmentsEditable taskAssignmentsEditable)

Update a task assignments

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class UpdateTaskAssignmentsExample
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

            var apiInstance = new TaskAssignmentsApi(Configuration.Default);
            var taskAssignmentsId = taskAssignmentsId_example;  // string | ID of task assignment to return
            var taskAssignmentsEditable = new TaskAssignmentsEditable(); // TaskAssignmentsEditable | 

            try
            {
                // Update a task assignments
                TaskAssignments result = apiInstance.UpdateTaskAssignments(taskAssignmentsId, taskAssignmentsEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TaskAssignmentsApi.UpdateTaskAssignments: " + e.Message );
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
 **taskAssignmentsId** | **string**| ID of task assignment to return | 
 **taskAssignmentsEditable** | [**TaskAssignmentsEditable**](TaskAssignmentsEditable.md)|  | 

### Return type

[**TaskAssignments**](TaskAssignments.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

