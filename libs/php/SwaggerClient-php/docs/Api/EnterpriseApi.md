# Swagger\Client\EnterpriseApi

All URIs are relative to *https://api.bluejeans.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1EnterpriseEnterpriseIdUsersGet**](EnterpriseApi.md#v1EnterpriseEnterpriseIdUsersGet) | **GET** /v1/enterprise/{enterprise_id}/users | List Enterprise Users
[**v1EnterpriseEnterpriseIdUsersPost**](EnterpriseApi.md#v1EnterpriseEnterpriseIdUsersPost) | **POST** /v1/enterprise/{enterprise_id}/users | Create Enterprise User
[**v1EnterpriseEnterpriseIdUsersUserIdDelete**](EnterpriseApi.md#v1EnterpriseEnterpriseIdUsersUserIdDelete) | **DELETE** /v1/enterprise/{enterprise_id}/users/{user_id} | Remove Enterprise User
[**v1UserUserIdEnterpriseProfileGet**](EnterpriseApi.md#v1UserUserIdEnterpriseProfileGet) | **GET** /v1/user/{user_id}/enterprise_profile | Get Enterprise Profile


# **v1EnterpriseEnterpriseIdUsersGet**
> \Swagger\Client\Model\Room v1EnterpriseEnterpriseIdUsersGet($enterprise_id, $page_size, $page_number, $email_id)

List Enterprise Users

This endpoint allows listing the users that are associated with an enterprise account. Requires enterprise admin access level.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'Bearer');

$api_instance = new Swagger\Client\Api\EnterpriseApi();
$enterprise_id = 56; // int | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
$page_size = 56; // int | Sets number of items returned per page.
$page_number = 56; // int | Selects which page of results to return.
$email_id = "email_id_example"; // string | Allows filtering the response by a user’s email address.

try {
    $result = $api_instance->v1EnterpriseEnterpriseIdUsersGet($enterprise_id, $page_size, $page_number, $email_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->v1EnterpriseEnterpriseIdUsersGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise_id** | **int**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. |
 **page_size** | **int**| Sets number of items returned per page. | [optional]
 **page_number** | **int**| Selects which page of results to return. | [optional]
 **email_id** | **string**| Allows filtering the response by a user’s email address. | [optional]

### Return type

[**\Swagger\Client\Model\Room**](../Model/Room.md)

### Authorization

[access_token](../../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1EnterpriseEnterpriseIdUsersPost**
> \Swagger\Client\Model\Room v1EnterpriseEnterpriseIdUsersPost($enterprise_id, $force_password_change, $send_verification_mail)

Create Enterprise User

This endpoint allows adding a user to an existing enterprise. Requires enterprise admin access level.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'Bearer');

$api_instance = new Swagger\Client\Api\EnterpriseApi();
$enterprise_id = 56; // int | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
$force_password_change = true; // bool | Forces the user to change his or her password on first log in.
$send_verification_mail = true; // bool | Prevents welcome emails from being sent to the newly created user.

try {
    $result = $api_instance->v1EnterpriseEnterpriseIdUsersPost($enterprise_id, $force_password_change, $send_verification_mail);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->v1EnterpriseEnterpriseIdUsersPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise_id** | **int**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. |
 **force_password_change** | **bool**| Forces the user to change his or her password on first log in. | [optional]
 **send_verification_mail** | **bool**| Prevents welcome emails from being sent to the newly created user. | [optional]

### Return type

[**\Swagger\Client\Model\Room**](../Model/Room.md)

### Authorization

[access_token](../../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1EnterpriseEnterpriseIdUsersUserIdDelete**
> \Swagger\Client\Model\Room v1EnterpriseEnterpriseIdUsersUserIdDelete($enterprise_id, $user_id)

Remove Enterprise User

This endpoint allows removing a user from an enterprise; it does not delete the user. Requires enterprise admin access level.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'Bearer');

$api_instance = new Swagger\Client\Api\EnterpriseApi();
$enterprise_id = 56; // int | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
$user_id = 56; // int | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

try {
    $result = $api_instance->v1EnterpriseEnterpriseIdUsersUserIdDelete($enterprise_id, $user_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->v1EnterpriseEnterpriseIdUsersUserIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise_id** | **int**| The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. |
 **user_id** | **int**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. |

### Return type

[**\Swagger\Client\Model\Room**](../Model/Room.md)

### Authorization

[access_token](../../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1UserUserIdEnterpriseProfileGet**
> \Swagger\Client\Model\Enterprise v1UserUserIdEnterpriseProfileGet($user_id)

Get Enterprise Profile

This endpoint retrieves the enterprise profile associated with the user.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: access_token
Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('access_token', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('access_token', 'Bearer');

$api_instance = new Swagger\Client\Api\EnterpriseApi();
$user_id = 56; // int | The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.

try {
    $result = $api_instance->v1UserUserIdEnterpriseProfileGet($user_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EnterpriseApi->v1UserUserIdEnterpriseProfileGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user_id** | **int**| The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. |

### Return type

[**\Swagger\Client\Model\Enterprise**](../Model/Enterprise.md)

### Authorization

[access_token](../../README.md#access_token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

