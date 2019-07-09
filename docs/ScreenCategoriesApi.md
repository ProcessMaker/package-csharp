# ProcessMakerSDK.Api.ScreenCategoriesApi

All URIs are relative to *http://localhost/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateScreenCategory**](ScreenCategoriesApi.md#createscreencategory) | **POST** /screen_categories | Save a new Screen Category
[**DeleteScreenCategory**](ScreenCategoriesApi.md#deletescreencategory) | **DELETE** /screen_categories/screen_category_id | Delete a screen category
[**GetScreenCategories**](ScreenCategoriesApi.md#getscreencategories) | **GET** /screen_categories | Returns all screens categories that the user has access to
[**GetScreenCategoryById**](ScreenCategoriesApi.md#getscreencategorybyid) | **GET** /screen_categories/screen_category_id | Get single screen category by ID
[**UpdateScreenCategory**](ScreenCategoriesApi.md#updatescreencategory) | **PUT** /screen_categories/screen_category_id | Update a screen Category



## CreateScreenCategory

> ScreenCategory CreateScreenCategory (ScreenCategoryEditable screenCategoryEditable)

Save a new Screen Category

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class CreateScreenCategoryExample
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

            var apiInstance = new ScreenCategoriesApi(Configuration.Default);
            var screenCategoryEditable = new ScreenCategoryEditable(); // ScreenCategoryEditable | 

            try
            {
                // Save a new Screen Category
                ScreenCategory result = apiInstance.CreateScreenCategory(screenCategoryEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScreenCategoriesApi.CreateScreenCategory: " + e.Message );
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
 **screenCategoryEditable** | [**ScreenCategoryEditable**](ScreenCategoryEditable.md)|  | 

### Return type

[**ScreenCategory**](ScreenCategory.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteScreenCategory

> ScreenCategory DeleteScreenCategory (string screenCategoryId)

Delete a screen category

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class DeleteScreenCategoryExample
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

            var apiInstance = new ScreenCategoriesApi(Configuration.Default);
            var screenCategoryId = screenCategoryId_example;  // string | ID of screen category to return

            try
            {
                // Delete a screen category
                ScreenCategory result = apiInstance.DeleteScreenCategory(screenCategoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScreenCategoriesApi.DeleteScreenCategory: " + e.Message );
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
 **screenCategoryId** | **string**| ID of screen category to return | 

### Return type

[**ScreenCategory**](ScreenCategory.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetScreenCategories

> InlineResponse20015 GetScreenCategories (string filter = null, string orderBy = null, string orderDirection = null, int? perPage = null, string include = null)

Returns all screens categories that the user has access to

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetScreenCategoriesExample
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

            var apiInstance = new ScreenCategoriesApi(Configuration.Default);
            var filter = filter_example;  // string | Filter results by string. Searches Name, Description, and Status. Status must match exactly. Others can be a substring. (optional) 
            var orderBy = orderBy_example;  // string | Field to order results by (optional) 
            var orderDirection = orderDirection_example;  // string |  (optional)  (default to asc)
            var perPage = 56;  // int? |  (optional) 
            var include = include_example;  // string | Include data from related models in payload. Comma seperated list. (optional)  (default to "")

            try
            {
                // Returns all screens categories that the user has access to
                InlineResponse20015 result = apiInstance.GetScreenCategories(filter, orderBy, orderDirection, perPage, include);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScreenCategoriesApi.GetScreenCategories: " + e.Message );
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

[**InlineResponse20015**](InlineResponse20015.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetScreenCategoryById

> ScreenCategory GetScreenCategoryById (string screenCategoryId)

Get single screen category by ID

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetScreenCategoryByIdExample
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

            var apiInstance = new ScreenCategoriesApi(Configuration.Default);
            var screenCategoryId = screenCategoryId_example;  // string | ID of screen category to return

            try
            {
                // Get single screen category by ID
                ScreenCategory result = apiInstance.GetScreenCategoryById(screenCategoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScreenCategoriesApi.GetScreenCategoryById: " + e.Message );
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
 **screenCategoryId** | **string**| ID of screen category to return | 

### Return type

[**ScreenCategory**](ScreenCategory.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateScreenCategory

> ScreenCategory UpdateScreenCategory (string screenCategoryId, ScreenCategoryEditable screenCategoryEditable)

Update a screen Category

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class UpdateScreenCategoryExample
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

            var apiInstance = new ScreenCategoriesApi(Configuration.Default);
            var screenCategoryId = screenCategoryId_example;  // string | ID of screen category to return
            var screenCategoryEditable = new ScreenCategoryEditable(); // ScreenCategoryEditable | 

            try
            {
                // Update a screen Category
                ScreenCategory result = apiInstance.UpdateScreenCategory(screenCategoryId, screenCategoryEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ScreenCategoriesApi.UpdateScreenCategory: " + e.Message );
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
 **screenCategoryId** | **string**| ID of screen category to return | 
 **screenCategoryEditable** | [**ScreenCategoryEditable**](ScreenCategoryEditable.md)|  | 

### Return type

[**ScreenCategory**](ScreenCategory.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

