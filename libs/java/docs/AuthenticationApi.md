# AuthenticationApi

All URIs are relative to *https://api.bluejeans.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getTokenByClient**](AuthenticationApi.md#getTokenByClient) | **POST** /oauth2/token?Client | Authentication via Client Grant Type
[**getTokenByMeeting**](AuthenticationApi.md#getTokenByMeeting) | **POST** /oauth2/token?Meeting | Authentication via Meeting Grant Type
[**getTokenByPassword**](AuthenticationApi.md#getTokenByPassword) | **POST** /oauth2/token?Password | Authentication via Password Grant Type


<a name="getTokenByClient"></a>
# **getTokenByClient**
> GrantClient getTokenByClient(grantTypeClient)

Authentication via Client Grant Type

This grant type is commonly used by an app. Client ID and Secret are provisioned within the BlueJeans Enterprise Administration console.

### Example
```java
// Import classes:
//import com.bluejeans.api.rest.ApiClient;
//import com.bluejeans.api.rest.ApiException;
//import com.bluejeans.api.rest.Configuration;
//import com.bluejeans.api.rest.auth.*;
//import com.bluejeans.api.rest.onvideo.AuthenticationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: access_token
ApiKeyAuth access_token = (ApiKeyAuth) defaultClient.getAuthentication("access_token");
access_token.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.setApiKeyPrefix("Token");

AuthenticationApi apiInstance = new AuthenticationApi();
GrantRequestClient grantTypeClient = new GrantRequestClient(); // GrantRequestClient | Contains information about the type of grant you are requesting.
try {
    GrantClient result = apiInstance.getTokenByClient(grantTypeClient);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#getTokenByClient");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantTypeClient** | [**GrantRequestClient**](GrantRequestClient.md)| Contains information about the type of grant you are requesting. |

### Return type

[**GrantClient**](GrantClient.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getTokenByMeeting"></a>
# **getTokenByMeeting**
> GrantMeeting getTokenByMeeting(grantTypeMeeting)

Authentication via Meeting Grant Type

This is not a traditional OAuth grant type, but it behaves closely to the password grant type. This level of authentication allows for obtaining access to the meeting only. If a Moderator passcode is sent, moderator privileges are granted. If an Attendee access code is passed, the access token will have a limited scope of access that an attendee has within a meeting.

### Example
```java
// Import classes:
//import com.bluejeans.api.rest.ApiClient;
//import com.bluejeans.api.rest.ApiException;
//import com.bluejeans.api.rest.Configuration;
//import com.bluejeans.api.rest.auth.*;
//import com.bluejeans.api.rest.onvideo.AuthenticationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: access_token
ApiKeyAuth access_token = (ApiKeyAuth) defaultClient.getAuthentication("access_token");
access_token.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.setApiKeyPrefix("Token");

AuthenticationApi apiInstance = new AuthenticationApi();
GrantRequestMeeting grantTypeMeeting = new GrantRequestMeeting(); // GrantRequestMeeting | Contains information about the type of grant you are requesting.
try {
    GrantMeeting result = apiInstance.getTokenByMeeting(grantTypeMeeting);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#getTokenByMeeting");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantTypeMeeting** | [**GrantRequestMeeting**](GrantRequestMeeting.md)| Contains information about the type of grant you are requesting. |

### Return type

[**GrantMeeting**](GrantMeeting.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getTokenByPassword"></a>
# **getTokenByPassword**
> GrantPassword getTokenByPassword(grantRequestPassword)

Authentication via Password Grant Type

An access token can be obtained by using a user’s username and password.

### Example
```java
// Import classes:
//import com.bluejeans.api.rest.ApiClient;
//import com.bluejeans.api.rest.ApiException;
//import com.bluejeans.api.rest.Configuration;
//import com.bluejeans.api.rest.auth.*;
//import com.bluejeans.api.rest.onvideo.AuthenticationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: access_token
ApiKeyAuth access_token = (ApiKeyAuth) defaultClient.getAuthentication("access_token");
access_token.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//access_token.setApiKeyPrefix("Token");

AuthenticationApi apiInstance = new AuthenticationApi();
GrantRequestPassword grantRequestPassword = new GrantRequestPassword(); // GrantRequestPassword | Contains information about the type of grant you are requesting.
try {
    GrantPassword result = apiInstance.getTokenByPassword(grantRequestPassword);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#getTokenByPassword");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantRequestPassword** | [**GrantRequestPassword**](GrantRequestPassword.md)| Contains information about the type of grant you are requesting. |

### Return type

[**GrantPassword**](GrantPassword.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

