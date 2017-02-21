# Swagger\Client\HistoryApi

All URIs are relative to *https://api.bluejeans.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getRecording**](HistoryApi.md#getRecording) | **GET** /v1/user/{user_id}/meeting_history/recordings/{recording_entity_id} | Get Recording
[**listMeetingsByEnterprise**](HistoryApi.md#listMeetingsByEnterprise) | **GET** /v1/enterprise/{enterprise_id}/meeting_history | List Meetings
[**listMeetingsByUser**](HistoryApi.md#listMeetingsByUser) | **GET** /v1/user/{user_id}/meeting_history | List Meetings
[**listRecordings**](HistoryApi.md#listRecordings) | **GET** /v1/user/{user_id}/meeting_history/recordings | List Meeting Recordings
[**v1EnterpriseEnterpriseIdMeetingHistoryMeetingGuidGet**](HistoryApi.md#v1EnterpriseEnterpriseIdMeetingHistoryMeetingGuidGet) | **GET** /v1/enterprise/{enterprise_id}/meeting_history/{meeting_guid} | List Meetings
[**v1UserUserIdMeetingHistoryMeetingGuidGet**](HistoryApi.md#v1UserUserIdMeetingHistoryMeetingGuidGet) | **GET** /v1/user/{user_id}/meeting_history/{meeting_guid} | List Meetings


# **getRecording**
> \Swagger\Client\Model\Recording getRecording($user_id, $recording_entity_id)

Get Recording

This endpoint retrieves the details about a meeting recording.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'Bearer');

$api_instance = new Swagger\Client\Api\HistoryApi();
$user_id = 56; // int | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
$recording_entity_id = 56; // int | The ID of the meeting recording. This value is shown in meeting recording lists as recordingEntityId.

try {
    $result = $api_instance->getRecording($user_id, $recording_entity_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HistoryApi->getRecording: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user_id** | **int**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. |
 **recording_entity_id** | **int**| The ID of the meeting recording. This value is shown in meeting recording lists as recordingEntityId. |

### Return type

[**\Swagger\Client\Model\Recording**](../Model/Recording.md)

### Authorization

[access_token](../../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **listMeetingsByEnterprise**
> \Swagger\Client\Model\MeetingHistory[] listMeetingsByEnterprise($enterprise_id)

List Meetings

This endpoint retrieves a list of meetings.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'Bearer');

$api_instance = new Swagger\Client\Api\HistoryApi();
$enterprise_id = 56; // int | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.

try {
    $result = $api_instance->listMeetingsByEnterprise($enterprise_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HistoryApi->listMeetingsByEnterprise: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise_id** | **int**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. |

### Return type

[**\Swagger\Client\Model\MeetingHistory[]**](../Model/MeetingHistory.md)

### Authorization

[access_token](../../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **listMeetingsByUser**
> \Swagger\Client\Model\MeetingHistory[] listMeetingsByUser($user_id, $meeting_id, $start_date, $end_date, $page_size, $page_number, $order)

List Meetings

This endpoint retrieves a list of meetings.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'Bearer');

$api_instance = new Swagger\Client\Api\HistoryApi();
$user_id = 56; // int | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
$meeting_id = "meeting_id_example"; // string | Return meetings with the specified Meeting ID (recurring & Personal Meeting ID).
$start_date = "start_date_example"; // string | Return meetings starting from the specified date. MM/DD/YYYY
$end_date = "end_date_example"; // string | Return meetings up until the specified date. MM/DD/YYYY
$page_size = 56; // int | Sets number of items returned per page.
$page_number = 56; // int | Selects which page of results to return.
$order = "order_example"; // string | Puts results in ascending or descending order. asc/desc

try {
    $result = $api_instance->listMeetingsByUser($user_id, $meeting_id, $start_date, $end_date, $page_size, $page_number, $order);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HistoryApi->listMeetingsByUser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user_id** | **int**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. |
 **meeting_id** | **string**| Return meetings with the specified Meeting ID (recurring &amp; Personal Meeting ID). | [optional]
 **start_date** | **string**| Return meetings starting from the specified date. MM/DD/YYYY | [optional]
 **end_date** | **string**| Return meetings up until the specified date. MM/DD/YYYY | [optional]
 **page_size** | **int**| Sets number of items returned per page. | [optional]
 **page_number** | **int**| Selects which page of results to return. | [optional]
 **order** | **string**| Puts results in ascending or descending order. asc/desc | [optional]

### Return type

[**\Swagger\Client\Model\MeetingHistory[]**](../Model/MeetingHistory.md)

### Authorization

[access_token](../../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **listRecordings**
> \Swagger\Client\Model\RecordingSummary[] listRecordings($user_id, $page_size, $page_number, $sort_by, $order)

List Meeting Recordings

This endpoint retrieves a list of meeting recordings.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'Bearer');

$api_instance = new Swagger\Client\Api\HistoryApi();
$user_id = 56; // int | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
$page_size = 10; // int | Sets number of items returned per page.
$page_number = 1; // int | Selects which page of results to return.
$sort_by = "start_time"; // string | Selects which page of results to return.
$order = "desc"; // string | Puts results in ascending or descending order.

try {
    $result = $api_instance->listRecordings($user_id, $page_size, $page_number, $sort_by, $order);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HistoryApi->listRecordings: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user_id** | **int**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. |
 **page_size** | **int**| Sets number of items returned per page. | [optional] [default to 10]
 **page_number** | **int**| Selects which page of results to return. | [optional] [default to 1]
 **sort_by** | **string**| Selects which page of results to return. | [optional] [default to start_time]
 **order** | **string**| Puts results in ascending or descending order. | [optional] [default to desc]

### Return type

[**\Swagger\Client\Model\RecordingSummary[]**](../Model/RecordingSummary.md)

### Authorization

[access_token](../../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1EnterpriseEnterpriseIdMeetingHistoryMeetingGuidGet**
> \Swagger\Client\Model\Meeting v1EnterpriseEnterpriseIdMeetingHistoryMeetingGuidGet($enterprise_id, $meeting_guid)

List Meetings

This endpoint retrieves a list of meetings.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'Bearer');

$api_instance = new Swagger\Client\Api\HistoryApi();
$enterprise_id = 56; // int | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
$meeting_guid = "meeting_guid_example"; // string | The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest.

try {
    $result = $api_instance->v1EnterpriseEnterpriseIdMeetingHistoryMeetingGuidGet($enterprise_id, $meeting_guid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HistoryApi->v1EnterpriseEnterpriseIdMeetingHistoryMeetingGuidGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise_id** | **int**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. |
 **meeting_guid** | **string**| The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest. |

### Return type

[**\Swagger\Client\Model\Meeting**](../Model/Meeting.md)

### Authorization

[access_token](../../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1UserUserIdMeetingHistoryMeetingGuidGet**
> \Swagger\Client\Model\Meeting v1UserUserIdMeetingHistoryMeetingGuidGet($user_id, $meeting_guid)

List Meetings

This endpoint retrieves a list of meetings.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'Bearer');

$api_instance = new Swagger\Client\Api\HistoryApi();
$user_id = 56; // int | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
$meeting_guid = "meeting_guid_example"; // string | The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest.

try {
    $result = $api_instance->v1UserUserIdMeetingHistoryMeetingGuidGet($user_id, $meeting_guid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HistoryApi->v1UserUserIdMeetingHistoryMeetingGuidGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user_id** | **int**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. |
 **meeting_guid** | **string**| The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest. |

### Return type

[**\Swagger\Client\Model\Meeting**](../Model/Meeting.md)

### Authorization

[access_token](../../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

