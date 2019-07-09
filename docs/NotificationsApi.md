# ProcessMakerSDK.Api.NotificationsApi

All URIs are relative to *http://localhost/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNotification**](NotificationsApi.md#createnotification) | **POST** /notifications | Save a new notifications
[**DeleteNotification**](NotificationsApi.md#deletenotification) | **DELETE** /notifications/notificationId | Delete a notification
[**GetNotificationById**](NotificationsApi.md#getnotificationbyid) | **GET** /notifications/notificationId | Get single notification by ID
[**GetNotifications**](NotificationsApi.md#getnotifications) | **GET** /notifications | Returns all notifications that the user has access to
[**ProcessMakerHttpControllersApiNotificationControllerUpdateAsRead**](NotificationsApi.md#processmakerhttpcontrollersapinotificationcontrollerupdateasread) | **PUT** /read_notifications | Mark notifications as read by the user
[**ProcessMakerHttpControllersApiNotificationControllerUpdateAsReadAll**](NotificationsApi.md#processmakerhttpcontrollersapinotificationcontrollerupdateasreadall) | **PUT** /read_all_notifications | Mark notifications as read by id and type
[**UpdateNotification**](NotificationsApi.md#updatenotification) | **PUT** /notifications/notificationId | Update a notification



## CreateNotification

> Notifications CreateNotification (NotificationsEditable notificationsEditable)

Save a new notifications

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class CreateNotificationExample
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

            var apiInstance = new NotificationsApi(Configuration.Default);
            var notificationsEditable = new NotificationsEditable(); // NotificationsEditable | 

            try
            {
                // Save a new notifications
                Notifications result = apiInstance.CreateNotification(notificationsEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationsApi.CreateNotification: " + e.Message );
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
 **notificationsEditable** | [**NotificationsEditable**](NotificationsEditable.md)|  | 

### Return type

[**Notifications**](Notifications.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteNotification

> Notifications DeleteNotification (string notificationId)

Delete a notification

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class DeleteNotificationExample
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

            var apiInstance = new NotificationsApi(Configuration.Default);
            var notificationId = notificationId_example;  // string | ID of notification to return

            try
            {
                // Delete a notification
                Notifications result = apiInstance.DeleteNotification(notificationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationsApi.DeleteNotification: " + e.Message );
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
 **notificationId** | **string**| ID of notification to return | 

### Return type

[**Notifications**](Notifications.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetNotificationById

> Notifications GetNotificationById (string notificationId)

Get single notification by ID

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetNotificationByIdExample
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

            var apiInstance = new NotificationsApi(Configuration.Default);
            var notificationId = notificationId_example;  // string | ID of notification to return

            try
            {
                // Get single notification by ID
                Notifications result = apiInstance.GetNotificationById(notificationId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotificationById: " + e.Message );
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
 **notificationId** | **string**| ID of notification to return | 

### Return type

[**Notifications**](Notifications.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetNotifications

> InlineResponse20010 GetNotifications (string status = null, string filter = null, string orderBy = null, string orderDirection = null, int? perPage = null, string include = null)

Returns all notifications that the user has access to

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetNotificationsExample
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

            var apiInstance = new NotificationsApi(Configuration.Default);
            var status = status_example;  // string | Only return notifications by status (unread, all, etc.) (optional) 
            var filter = filter_example;  // string | Filter results by string. Searches Name, Description, and Status. Status must match exactly. Others can be a substring. (optional) 
            var orderBy = orderBy_example;  // string | Field to order results by (optional) 
            var orderDirection = orderDirection_example;  // string |  (optional)  (default to asc)
            var perPage = 56;  // int? |  (optional) 
            var include = include_example;  // string | Include data from related models in payload. Comma seperated list. (optional)  (default to "")

            try
            {
                // Returns all notifications that the user has access to
                InlineResponse20010 result = apiInstance.GetNotifications(status, filter, orderBy, orderDirection, perPage, include);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotifications: " + e.Message );
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
 **status** | **string**| Only return notifications by status (unread, all, etc.) | [optional] 
 **filter** | **string**| Filter results by string. Searches Name, Description, and Status. Status must match exactly. Others can be a substring. | [optional] 
 **orderBy** | **string**| Field to order results by | [optional] 
 **orderDirection** | **string**|  | [optional] [default to asc]
 **perPage** | **int?**|  | [optional] 
 **include** | **string**| Include data from related models in payload. Comma seperated list. | [optional] [default to &quot;&quot;]

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ProcessMakerHttpControllersApiNotificationControllerUpdateAsRead

> void ProcessMakerHttpControllersApiNotificationControllerUpdateAsRead (InlineObject2 inlineObject2)

Mark notifications as read by the user

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class ProcessMakerHttpControllersApiNotificationControllerUpdateAsReadExample
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

            var apiInstance = new NotificationsApi(Configuration.Default);
            var inlineObject2 = new InlineObject2(); // InlineObject2 | 

            try
            {
                // Mark notifications as read by the user
                apiInstance.ProcessMakerHttpControllersApiNotificationControllerUpdateAsRead(inlineObject2);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationsApi.ProcessMakerHttpControllersApiNotificationControllerUpdateAsRead: " + e.Message );
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
 **inlineObject2** | [**InlineObject2**](InlineObject2.md)|  | 

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


## ProcessMakerHttpControllersApiNotificationControllerUpdateAsReadAll

> void ProcessMakerHttpControllersApiNotificationControllerUpdateAsReadAll (InlineObject3 inlineObject3)

Mark notifications as read by id and type

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class ProcessMakerHttpControllersApiNotificationControllerUpdateAsReadAllExample
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

            var apiInstance = new NotificationsApi(Configuration.Default);
            var inlineObject3 = new InlineObject3(); // InlineObject3 | 

            try
            {
                // Mark notifications as read by id and type
                apiInstance.ProcessMakerHttpControllersApiNotificationControllerUpdateAsReadAll(inlineObject3);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationsApi.ProcessMakerHttpControllersApiNotificationControllerUpdateAsReadAll: " + e.Message );
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
 **inlineObject3** | [**InlineObject3**](InlineObject3.md)|  | 

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


## UpdateNotification

> Notifications UpdateNotification (string notificationId, NotificationsEditable notificationsEditable)

Update a notification

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class UpdateNotificationExample
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

            var apiInstance = new NotificationsApi(Configuration.Default);
            var notificationId = notificationId_example;  // string | ID of notification to return
            var notificationsEditable = new NotificationsEditable(); // NotificationsEditable | 

            try
            {
                // Update a notification
                Notifications result = apiInstance.UpdateNotification(notificationId, notificationsEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotificationsApi.UpdateNotification: " + e.Message );
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
 **notificationId** | **string**| ID of notification to return | 
 **notificationsEditable** | [**NotificationsEditable**](NotificationsEditable.md)|  | 

### Return type

[**Notifications**](Notifications.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

