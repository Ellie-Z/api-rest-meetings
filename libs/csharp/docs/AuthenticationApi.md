# IO.Swagger.Api.AuthenticationApi

All URIs are relative to *https://api.bluejeans.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Oauth2TokenClientPost**](AuthenticationApi.md#oauth2tokenclientpost) | **POST** /oauth2/token?Client | Authentication via Client Grant Type
[**Oauth2TokenMeetingPost**](AuthenticationApi.md#oauth2tokenmeetingpost) | **POST** /oauth2/token?Meeting | Authentication via Meeting Grant Type
[**Oauth2TokenPasswordPost**](AuthenticationApi.md#oauth2tokenpasswordpost) | **POST** /oauth2/token?Password | Authentication via Password Grant Type


<a name="oauth2tokenclientpost"></a>
# **Oauth2TokenClientPost**
> Grant Oauth2TokenClientPost (Payload payload)

Authentication via Client Grant Type

This grant type is commonly used by an app. Client ID and Secret are provisioned within the BlueJeans Enterprise Administration console.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Oauth2TokenClientPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new AuthenticationApi();
            var payload = new Payload(); // Payload | Contains information about the type of grant you are requesting.

            try
            {
                // Authentication via Client Grant Type
                Grant result = apiInstance.Oauth2TokenClientPost(payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Oauth2TokenClientPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payload** | [**Payload**](Payload.md)| Contains information about the type of grant you are requesting. | 

### Return type

[**Grant**](Grant.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauth2tokenmeetingpost"></a>
# **Oauth2TokenMeetingPost**
> Grant Oauth2TokenMeetingPost (Payload1 payload)

Authentication via Meeting Grant Type

This is not a traditional OAuth grant type, but it behaves closely to the password grant type. This level of authentication allows for obtaining access to the meeting only. If a Moderator passcode is sent, moderator privileges are granted. If an Attendee access code is passed, the access token will have a limited scope of access that an attendee has within a meeting.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Oauth2TokenMeetingPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new AuthenticationApi();
            var payload = new Payload1(); // Payload1 | Contains information about the type of grant you are requesting.

            try
            {
                // Authentication via Meeting Grant Type
                Grant result = apiInstance.Oauth2TokenMeetingPost(payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Oauth2TokenMeetingPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payload** | [**Payload1**](Payload1.md)| Contains information about the type of grant you are requesting. | 

### Return type

[**Grant**](Grant.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oauth2tokenpasswordpost"></a>
# **Oauth2TokenPasswordPost**
> Grant Oauth2TokenPasswordPost (Payload2 payload)

Authentication via Password Grant Type

An access token can be obtained by using a user’s username and password.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Oauth2TokenPasswordPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: access_token
            Configuration.Default.ApiKey.Add("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("access_token", "Bearer");

            var apiInstance = new AuthenticationApi();
            var payload = new Payload2(); // Payload2 | Contains information about the type of grant you are requesting.

            try
            {
                // Authentication via Password Grant Type
                Grant result = apiInstance.Oauth2TokenPasswordPost(payload);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Oauth2TokenPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payload** | [**Payload2**](Payload2.md)| Contains information about the type of grant you are requesting. | 

### Return type

[**Grant**](Grant.md)

### Authorization

[access_token](../README.md#access_token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

