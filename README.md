# ProcessMakerSDK - the C# library for the ProcessMaker API

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://github.com/ProcessMaker/processmaker](https://github.com/ProcessMaker/processmaker)

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out ProcessMakerSDK.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Diagnostics;
using ProcessMakerSDK.Api;
using ProcessMakerSDK.Client;
using ProcessMakerSDK.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "http://localhost/api/1.0";
            // Configure OAuth2 access token for authorization: pm_api_auth_code
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: pm_api_key
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

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

## Documentation for API Endpoints

All URIs are relative to *http://localhost/api/1.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CommentsApi* | [**CreateComments**](docs/CommentsApi.md#createcomments) | **POST** /comments | Save a new comment
*CommentsApi* | [**DeleteComments**](docs/CommentsApi.md#deletecomments) | **DELETE** /comments/id | Delete a comments
*CommentsApi* | [**GetCommentById**](docs/CommentsApi.md#getcommentbyid) | **GET** /comments/commentId | Get single comment by ID
*CommentsApi* | [**GetComments**](docs/CommentsApi.md#getcomments) | **GET** /comments | Returns all comments for a given type
*CommentsApi* | [**UpdateComment**](docs/CommentsApi.md#updatecomment) | **PUT** /comments/commentId | Update a comment
*EnvironmentVariablesApi* | [**CreateEnvironmentVariables**](docs/EnvironmentVariablesApi.md#createenvironmentvariables) | **POST** /environment_variables | Save a new environment_variables
*EnvironmentVariablesApi* | [**DeleteEnvironmentVariables**](docs/EnvironmentVariablesApi.md#deleteenvironmentvariables) | **DELETE** /environment_variables/{environment_variables_id} | Delete a environment_variables
*EnvironmentVariablesApi* | [**GetEnvironmentVariables**](docs/EnvironmentVariablesApi.md#getenvironmentvariables) | **GET** /environment_variables | Returns all environmentVariables that the user has access to
*EnvironmentVariablesApi* | [**GetEnvironmentVariablesById**](docs/EnvironmentVariablesApi.md#getenvironmentvariablesbyid) | **GET** /environment_variables/{environment_variables_id} | Get single environment_variables by ID
*EnvironmentVariablesApi* | [**UpdateEnvironmentVariables**](docs/EnvironmentVariablesApi.md#updateenvironmentvariables) | **PUT** /environment_variables/{environment_variables_id} | Update a environment_variables
*FilesApi* | [**CreateFile**](docs/FilesApi.md#createfile) | **POST** /requests/{request_id}/files | Save a new media file
*FilesApi* | [**DeleteFile**](docs/FilesApi.md#deletefile) | **DELETE** /requests/{request_id} | Delete a media file
*FilesApi* | [**GetFiles**](docs/FilesApi.md#getfiles) | **GET** /requests/{request_id}/files | Returns the list of files associated to a request
*FilesApi* | [**GetFilesById**](docs/FilesApi.md#getfilesbyid) | **GET** /requests/{request_id}/files/{file_id} | Get a file uploaded to a request
*FilesApi* | [**UpdateFile**](docs/FilesApi.md#updatefile) | **PUT** /requests/{request_id}/files/{file_id} | Update a media file
*GroupMembersApi* | [**CreateGroupMember**](docs/GroupMembersApi.md#creategroupmember) | **POST** /group_members | Save a new group member
*GroupMembersApi* | [**DeleteGroupMember**](docs/GroupMembersApi.md#deletegroupmember) | **DELETE** /group_members/{group_member_id} | Delete a group member
*GroupMembersApi* | [**GetGroupMemberById**](docs/GroupMembersApi.md#getgroupmemberbyid) | **GET** /group_members/{group_member_id} | Get single group member by ID
*GroupMembersApi* | [**GetGroupMembers**](docs/GroupMembersApi.md#getgroupmembers) | **GET** /group_members | Returns all groups for a given member
*GroupMembersApi* | [**GetGroupMembersAvailable**](docs/GroupMembersApi.md#getgroupmembersavailable) | **GET** /group_members_available | Returns all groups available for a given member
*GroupMembersApi* | [**GetUserMembersAvailable**](docs/GroupMembersApi.md#getusermembersavailable) | **GET** /user_members_available | Returns all users available for a given member
*GroupUsersApi* | [**GetMembers**](docs/GroupUsersApi.md#getmembers) | **GET** /group_users | Returns all users of a group
*GroupsApi* | [**CreateGroup**](docs/GroupsApi.md#creategroup) | **POST** /groups | Save a new group
*GroupsApi* | [**DeleteGroup**](docs/GroupsApi.md#deletegroup) | **DELETE** /groups/{group_id} | Delete a group
*GroupsApi* | [**GetGroupById**](docs/GroupsApi.md#getgroupbyid) | **GET** /groups/{group_id} | Get single group by ID
*GroupsApi* | [**GetGroups**](docs/GroupsApi.md#getgroups) | **GET** /groups | Returns all groups that the user has access to
*GroupsApi* | [**UpdateGroup**](docs/GroupsApi.md#updategroup) | **PUT** /groups/{group_id} | Update a group
*NotificationsApi* | [**CreateNotification**](docs/NotificationsApi.md#createnotification) | **POST** /notifications | Save a new notifications
*NotificationsApi* | [**DeleteNotification**](docs/NotificationsApi.md#deletenotification) | **DELETE** /notifications/notificationId | Delete a notification
*NotificationsApi* | [**GetNotificationById**](docs/NotificationsApi.md#getnotificationbyid) | **GET** /notifications/notificationId | Get single notification by ID
*NotificationsApi* | [**GetNotifications**](docs/NotificationsApi.md#getnotifications) | **GET** /notifications | Returns all notifications that the user has access to
*NotificationsApi* | [**ProcessMakerHttpControllersApiNotificationControllerUpdateAsRead**](docs/NotificationsApi.md#processmakerhttpcontrollersapinotificationcontrollerupdateasread) | **PUT** /read_notifications | Mark notifications as read by the user
*NotificationsApi* | [**ProcessMakerHttpControllersApiNotificationControllerUpdateAsReadAll**](docs/NotificationsApi.md#processmakerhttpcontrollersapinotificationcontrollerupdateasreadall) | **PUT** /read_all_notifications | Mark notifications as read by id and type
*NotificationsApi* | [**UpdateNotification**](docs/NotificationsApi.md#updatenotification) | **PUT** /notifications/notificationId | Update a notification
*PermissionsApi* | [**ProcessMakerHttpControllersApiPermissionControllerUpdate**](docs/PermissionsApi.md#processmakerhttpcontrollersapipermissioncontrollerupdate) | **PUT** /permissions | Update the permissions of an user
*ProcessCategoriesApi* | [**CreateProcessCategory**](docs/ProcessCategoriesApi.md#createprocesscategory) | **POST** /process_categories | Save a new process Category
*ProcessCategoriesApi* | [**DeleteProcessCategory**](docs/ProcessCategoriesApi.md#deleteprocesscategory) | **DELETE** /process_categories/{process_category_id} | Delete a process category
*ProcessCategoriesApi* | [**GetProcessCategories**](docs/ProcessCategoriesApi.md#getprocesscategories) | **GET** /process_categories | Returns all processes categories that the user has access to
*ProcessCategoriesApi* | [**GetProcessCategoryById**](docs/ProcessCategoriesApi.md#getprocesscategorybyid) | **GET** /process_categories/{process_category_id} | Get single process category by ID
*ProcessCategoriesApi* | [**UpdateProcessCategory**](docs/ProcessCategoriesApi.md#updateprocesscategory) | **PUT** /process_categories/{process_category_id} | Update a process Category
*ProcessRequestsApi* | [**DeleteProcessRequest**](docs/ProcessRequestsApi.md#deleteprocessrequest) | **DELETE** /requests/{process_request_id} | Delete a process request
*ProcessRequestsApi* | [**GetProcessRequestById**](docs/ProcessRequestsApi.md#getprocessrequestbyid) | **GET** /requests/{process_request_id} | Get single process request by ID
*ProcessRequestsApi* | [**GetProcessesRequests**](docs/ProcessRequestsApi.md#getprocessesrequests) | **GET** /requests | Returns all process Requests that the user has access to
*ProcessRequestsApi* | [**UpdateProcessRequest**](docs/ProcessRequestsApi.md#updateprocessrequest) | **PUT** /requests/{process_request_id} | Update a process request
*ProcessesApi* | [**AssignmentProcess**](docs/ProcessesApi.md#assignmentprocess) | **POST** /processes/{process_id}/import/assignments | Update assignments after import
*ProcessesApi* | [**CreateProcess**](docs/ProcessesApi.md#createprocess) | **POST** /processes | Save a new process
*ProcessesApi* | [**DeleteProcess**](docs/ProcessesApi.md#deleteprocess) | **DELETE** /processes/{processId} | Delete a process
*ProcessesApi* | [**ExportProcess**](docs/ProcessesApi.md#exportprocess) | **GET** /processes/{processId}/export | Export a single process by ID
*ProcessesApi* | [**GetProcessById**](docs/ProcessesApi.md#getprocessbyid) | **GET** /processes/{processId} | Get single process by ID
*ProcessesApi* | [**GetProcesses**](docs/ProcessesApi.md#getprocesses) | **GET** /processes | Returns all processes that the user has access to
*ProcessesApi* | [**ImportProcess**](docs/ProcessesApi.md#importprocess) | **POST** /processes/import | Import a new process
*ProcessesApi* | [**RestoreProcess**](docs/ProcessesApi.md#restoreprocess) | **PUT** /processes/{processId}/restore | Restore an inactive process
*ProcessesApi* | [**StartProcesses**](docs/ProcessesApi.md#startprocesses) | **GET** /start_processes | Returns the list of processes that the user can start
*ProcessesApi* | [**TriggerStartEvent**](docs/ProcessesApi.md#triggerstartevent) | **POST** /process_events/{process_id} | Start a new process
*ProcessesApi* | [**UpdateProcess**](docs/ProcessesApi.md#updateprocess) | **PUT** /processes/{processId} | Update a process
*ScreenCategoriesApi* | [**CreateScreenCategory**](docs/ScreenCategoriesApi.md#createscreencategory) | **POST** /screen_categories | Save a new Screen Category
*ScreenCategoriesApi* | [**DeleteScreenCategory**](docs/ScreenCategoriesApi.md#deletescreencategory) | **DELETE** /screen_categories/screen_category_id | Delete a screen category
*ScreenCategoriesApi* | [**GetScreenCategories**](docs/ScreenCategoriesApi.md#getscreencategories) | **GET** /screen_categories | Returns all screens categories that the user has access to
*ScreenCategoriesApi* | [**GetScreenCategoryById**](docs/ScreenCategoriesApi.md#getscreencategorybyid) | **GET** /screen_categories/screen_category_id | Get single screen category by ID
*ScreenCategoriesApi* | [**UpdateScreenCategory**](docs/ScreenCategoriesApi.md#updatescreencategory) | **PUT** /screen_categories/screen_category_id | Update a screen Category
*ScreensApi* | [**CreateScreens**](docs/ScreensApi.md#createscreens) | **POST** /screens | Save a new screens
*ScreensApi* | [**DeleteScreen**](docs/ScreensApi.md#deletescreen) | **DELETE** /screens/screensId | Delete a screen
*ScreensApi* | [**DuplicateScript**](docs/ScreensApi.md#duplicatescript) | **PUT** /screens/screensId/duplicate | duplicate a screen
*ScreensApi* | [**ExportScreen**](docs/ScreensApi.md#exportscreen) | **GET** /screens/screensId/export | Export a single screen by ID
*ScreensApi* | [**GetScreens**](docs/ScreensApi.md#getscreens) | **GET** /screens | Returns all screens that the user has access to
*ScreensApi* | [**GetScreensById**](docs/ScreensApi.md#getscreensbyid) | **GET** /screens/screensId | Get single screens by ID
*ScreensApi* | [**ImportScreen**](docs/ScreensApi.md#importscreen) | **POST** /screens/import | Import a new screen
*ScreensApi* | [**UpdateScreen**](docs/ScreensApi.md#updatescreen) | **PUT** /screens/screensId | Update a screen
*ScriptsApi* | [**CreateScript**](docs/ScriptsApi.md#createscript) | **POST** /scripts | Save a new script
*ScriptsApi* | [**DeleteScript**](docs/ScriptsApi.md#deletescript) | **DELETE** /scripts/scriptsId | Delete a script
*ScriptsApi* | [**DuplicateScreen**](docs/ScriptsApi.md#duplicatescreen) | **PUT** /scripts/scriptsId/duplicate | duplicate a script
*ScriptsApi* | [**GetScripts**](docs/ScriptsApi.md#getscripts) | **GET** /scripts | Returns all scripts that the user has access to
*ScriptsApi* | [**GetScriptsById**](docs/ScriptsApi.md#getscriptsbyid) | **GET** /scripts/scriptsId | Get single script by ID
*ScriptsApi* | [**GetScriptsPreview**](docs/ScriptsApi.md#getscriptspreview) | **GET** /scripts/{script_id}/preview | Test script code without saving it
*ScriptsApi* | [**UpdateScript**](docs/ScriptsApi.md#updatescript) | **PUT** /scripts/scriptsId | Update a script
*TaskAssignmentsApi* | [**CreateTaskAssignments**](docs/TaskAssignmentsApi.md#createtaskassignments) | **POST** /task_assignments | Save a new task assignments
*TaskAssignmentsApi* | [**UpdateTaskAssignments**](docs/TaskAssignmentsApi.md#updatetaskassignments) | **PUT** /task_assignments/{task_assignments_id} | Update a task assignments
*TasksApi* | [**GetTasks**](docs/TasksApi.md#gettasks) | **GET** /tasks | Returns all tasks that the user has access to
*TasksApi* | [**UpdateTask**](docs/TasksApi.md#updatetask) | **PUT** /tasks/{task_id} | Update a task
*UsersApi* | [**CreateUser**](docs/UsersApi.md#createuser) | **POST** /users | Save a new users
*UsersApi* | [**DeleteUser**](docs/UsersApi.md#deleteuser) | **DELETE** /users/{user_id} | Delete a user
*UsersApi* | [**GetUserById**](docs/UsersApi.md#getuserbyid) | **GET** /users/{user_id} | Get single user by ID
*UsersApi* | [**GetUsers**](docs/UsersApi.md#getusers) | **GET** /users | Returns all users
*UsersApi* | [**UpdateUsers**](docs/UsersApi.md#updateusers) | **PUT** /users/{user_id} | Update a user


## Documentation for Models

 - [Model.Comments](docs/Comments.md)
 - [Model.CommentsEditable](docs/CommentsEditable.md)
 - [Model.DateTime](docs/DateTime.md)
 - [Model.EnvironmentVariables](docs/EnvironmentVariables.md)
 - [Model.EnvironmentVariablesEditable](docs/EnvironmentVariablesEditable.md)
 - [Model.GroupMembers](docs/GroupMembers.md)
 - [Model.GroupMembersAllOf](docs/GroupMembersAllOf.md)
 - [Model.GroupMembersEditable](docs/GroupMembersEditable.md)
 - [Model.Groups](docs/Groups.md)
 - [Model.GroupsAllOf](docs/GroupsAllOf.md)
 - [Model.GroupsEditable](docs/GroupsEditable.md)
 - [Model.InlineObject](docs/InlineObject.md)
 - [Model.InlineObject1](docs/InlineObject1.md)
 - [Model.InlineObject2](docs/InlineObject2.md)
 - [Model.InlineObject3](docs/InlineObject3.md)
 - [Model.InlineObject4](docs/InlineObject4.md)
 - [Model.InlineObject5](docs/InlineObject5.md)
 - [Model.InlineObject6](docs/InlineObject6.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse20010](docs/InlineResponse20010.md)
 - [Model.InlineResponse20011](docs/InlineResponse20011.md)
 - [Model.InlineResponse20012](docs/InlineResponse20012.md)
 - [Model.InlineResponse20013](docs/InlineResponse20013.md)
 - [Model.InlineResponse20014](docs/InlineResponse20014.md)
 - [Model.InlineResponse20015](docs/InlineResponse20015.md)
 - [Model.InlineResponse20016](docs/InlineResponse20016.md)
 - [Model.InlineResponse20017](docs/InlineResponse20017.md)
 - [Model.InlineResponse20018](docs/InlineResponse20018.md)
 - [Model.InlineResponse20019](docs/InlineResponse20019.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse2008](docs/InlineResponse2008.md)
 - [Model.InlineResponse2009](docs/InlineResponse2009.md)
 - [Model.Media](docs/Media.md)
 - [Model.MediaEditable](docs/MediaEditable.md)
 - [Model.Metadata](docs/Metadata.md)
 - [Model.Notifications](docs/Notifications.md)
 - [Model.NotificationsEditable](docs/NotificationsEditable.md)
 - [Model.Process](docs/Process.md)
 - [Model.ProcessAllOf](docs/ProcessAllOf.md)
 - [Model.ProcessCategory](docs/ProcessCategory.md)
 - [Model.ProcessCategoryAllOf](docs/ProcessCategoryAllOf.md)
 - [Model.ProcessCategoryEditable](docs/ProcessCategoryEditable.md)
 - [Model.ProcessEditable](docs/ProcessEditable.md)
 - [Model.ProcessPermissions](docs/ProcessPermissions.md)
 - [Model.ProcessPermissionsEditable](docs/ProcessPermissionsEditable.md)
 - [Model.ProcessRequest](docs/ProcessRequest.md)
 - [Model.ProcessRequestAllOf](docs/ProcessRequestAllOf.md)
 - [Model.ProcessRequestEditable](docs/ProcessRequestEditable.md)
 - [Model.ProcessRequestToken](docs/ProcessRequestToken.md)
 - [Model.ProcessRequestTokenAllOf](docs/ProcessRequestTokenAllOf.md)
 - [Model.ProcessRequestTokenEditable](docs/ProcessRequestTokenEditable.md)
 - [Model.ProcessStartEvents](docs/ProcessStartEvents.md)
 - [Model.ProcessWithStartEvents](docs/ProcessWithStartEvents.md)
 - [Model.ProcessWithStartEventsAllOf](docs/ProcessWithStartEventsAllOf.md)
 - [Model.ScreenCategory](docs/ScreenCategory.md)
 - [Model.ScreenCategoryEditable](docs/ScreenCategoryEditable.md)
 - [Model.ScreenType](docs/ScreenType.md)
 - [Model.ScreenTypeEditable](docs/ScreenTypeEditable.md)
 - [Model.Screens](docs/Screens.md)
 - [Model.ScreensEditable](docs/ScreensEditable.md)
 - [Model.Scripts](docs/Scripts.md)
 - [Model.ScriptsEditable](docs/ScriptsEditable.md)
 - [Model.TaskAssignments](docs/TaskAssignments.md)
 - [Model.TaskAssignmentsEditable](docs/TaskAssignmentsEditable.md)
 - [Model.TaskMetadata](docs/TaskMetadata.md)
 - [Model.TaskMetadataAllOf](docs/TaskMetadataAllOf.md)
 - [Model.Users](docs/Users.md)
 - [Model.UsersAllOf](docs/UsersAllOf.md)
 - [Model.UsersEditable](docs/UsersEditable.md)


## Documentation for Authorization


### pm_api_auth_code


- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: /oauth/authorize
- **Scopes**: N/A


### pm_api_bearer


- **Type**: HTTP basic authentication


### pm_api_key

- **Type**: API key

- **API key parameter name**: Authorization
- **Location**: HTTP header

