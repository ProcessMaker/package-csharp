# ProcessMakerSDK.Api.CommentsApi

All URIs are relative to *http://localhost/api/1.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateComments**](CommentsApi.md#createcomments) | **POST** /comments | Save a new comment
[**DeleteComments**](CommentsApi.md#deletecomments) | **DELETE** /comments/id | Delete a comments
[**GetCommentById**](CommentsApi.md#getcommentbyid) | **GET** /comments/commentId | Get single comment by ID
[**GetComments**](CommentsApi.md#getcomments) | **GET** /comments | Returns all comments for a given type
[**UpdateComment**](CommentsApi.md#updatecomment) | **PUT** /comments/commentId | Update a comment



## CreateComments

> Comments CreateComments (CommentsEditable commentsEditable)

Save a new comment

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class CreateCommentsExample
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

            var apiInstance = new CommentsApi(Configuration.Default);
            var commentsEditable = new CommentsEditable(); // CommentsEditable | 

            try
            {
                // Save a new comment
                Comments result = apiInstance.CreateComments(commentsEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommentsApi.CreateComments: " + e.Message );
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
 **commentsEditable** | [**CommentsEditable**](CommentsEditable.md)|  | 

### Return type

[**Comments**](Comments.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteComments

> Comments DeleteComments (string commentId)

Delete a comments

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class DeleteCommentsExample
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

            var apiInstance = new CommentsApi(Configuration.Default);
            var commentId = commentId_example;  // string | ID of comments to return

            try
            {
                // Delete a comments
                Comments result = apiInstance.DeleteComments(commentId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommentsApi.DeleteComments: " + e.Message );
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
 **commentId** | **string**| ID of comments to return | 

### Return type

[**Comments**](Comments.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetCommentById

> Comments GetCommentById (string commentId)

Get single comment by ID

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetCommentByIdExample
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

            var apiInstance = new CommentsApi(Configuration.Default);
            var commentId = commentId_example;  // string | ID of comments to return

            try
            {
                // Get single comment by ID
                Comments result = apiInstance.GetCommentById(commentId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommentsApi.GetCommentById: " + e.Message );
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
 **commentId** | **string**| ID of comments to return | 

### Return type

[**Comments**](Comments.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetComments

> InlineResponse200 GetComments (int? commentableId = null, string commentableType = null, string filter = null, string orderBy = null, string orderDirection = null, int? perPage = null)

Returns all comments for a given type

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class GetCommentsExample
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

            var apiInstance = new CommentsApi(Configuration.Default);
            var commentableId = 56;  // int? |  (optional) 
            var commentableType = commentableType_example;  // string |  (optional)  (default to "")
            var filter = filter_example;  // string | Filter results by string. Searches Name, Description, and Status. Status must match exactly. Others can be a substring. (optional) 
            var orderBy = orderBy_example;  // string | Field to order results by (optional) 
            var orderDirection = orderDirection_example;  // string |  (optional)  (default to asc)
            var perPage = 56;  // int? |  (optional) 

            try
            {
                // Returns all comments for a given type
                InlineResponse200 result = apiInstance.GetComments(commentableId, commentableType, filter, orderBy, orderDirection, perPage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommentsApi.GetComments: " + e.Message );
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
 **commentableId** | **int?**|  | [optional] 
 **commentableType** | **string**|  | [optional] [default to &quot;&quot;]
 **filter** | **string**| Filter results by string. Searches Name, Description, and Status. Status must match exactly. Others can be a substring. | [optional] 
 **orderBy** | **string**| Field to order results by | [optional] 
 **orderDirection** | **string**|  | [optional] [default to asc]
 **perPage** | **int?**|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateComment

> Comments UpdateComment (string commentId, CommentsEditable commentsEditable)

Update a comment

### Example

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class UpdateCommentExample
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

            var apiInstance = new CommentsApi(Configuration.Default);
            var commentId = commentId_example;  // string | ID of comment to return
            var commentsEditable = new CommentsEditable(); // CommentsEditable | 

            try
            {
                // Update a comment
                Comments result = apiInstance.UpdateComment(commentId, commentsEditable);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CommentsApi.UpdateComment: " + e.Message );
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
 **commentId** | **string**| ID of comment to return | 
 **commentsEditable** | [**CommentsEditable**](CommentsEditable.md)|  | 

### Return type

[**Comments**](Comments.md)

### Authorization

[pm_api_auth_code](../README.md#pm_api_auth_code), [pm_api_key](../README.md#pm_api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

