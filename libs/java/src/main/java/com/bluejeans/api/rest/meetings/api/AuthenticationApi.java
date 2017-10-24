/*
 * BlueJeans Meetings REST API
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bluejeans.api.rest.meetings.api;

import com.bluejeans.api.rest.meetings.ApiCallback;
import com.bluejeans.api.rest.meetings.ApiClient;
import com.bluejeans.api.rest.meetings.ApiException;
import com.bluejeans.api.rest.meetings.ApiResponse;
import com.bluejeans.api.rest.meetings.Configuration;
import com.bluejeans.api.rest.meetings.Pair;
import com.bluejeans.api.rest.meetings.ProgressRequestBody;
import com.bluejeans.api.rest.meetings.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import com.bluejeans.api.rest.meetings.model.Error;
import com.bluejeans.api.rest.meetings.model.GrantClient;
import com.bluejeans.api.rest.meetings.model.GrantCode;
import com.bluejeans.api.rest.meetings.model.GrantMeeting;
import com.bluejeans.api.rest.meetings.model.GrantPassword;
import com.bluejeans.api.rest.meetings.model.GrantRefresh;
import com.bluejeans.api.rest.meetings.model.GrantRequestClient;
import com.bluejeans.api.rest.meetings.model.GrantRequestCode;
import com.bluejeans.api.rest.meetings.model.GrantRequestMeeting;
import com.bluejeans.api.rest.meetings.model.GrantRequestPassword;
import com.bluejeans.api.rest.meetings.model.GrantRequestRefresh;
import com.bluejeans.api.rest.meetings.model.GrantRequestRevoke;
import com.bluejeans.api.rest.meetings.model.InlineResponse200;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class AuthenticationApi {
    private ApiClient apiClient;

    public AuthenticationApi() {
        this(Configuration.getDefaultApiClient());
    }

    public AuthenticationApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for getAuthorizationCode
     * @param clientId The 32 character client ID generated when you created the client application. (optional)
     * @param redirectUri The URL where the authorization code will be returned via redirect.  The URL must match a URL registered with the client application. (optional)
     * @param state Client application specific state passed through and returned in the redirect URL. May be useful for identifying operations or users. (optional)
     * @param scope A comma delimited list of scopes requested. Scopes may be list_meetings, modify_meetings, user_info. Unfortunately, not all operations in the API are available via this authentication method at the current time. (optional)
     * @param responseType The type of authorization you are peforrming.  Set to \&quot;code\&quot;. (optional, default to code)
     * @param appName The name of the client application shown to user during authorization. (optional)
     * @param appLogoUrl URL to an 84x84 image shown to user during authorization. (optional)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getAuthorizationCodeCall(String clientId, String redirectUri, String state, String scope, String responseType, String appName, String appLogoUrl, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/oauth2/authorize";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (clientId != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "clientId", clientId));
        if (redirectUri != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "redirectUri", redirectUri));
        if (state != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "state", state));
        if (scope != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "scope", scope));
        if (responseType != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "responseType", responseType));
        if (appName != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "appName", appName));
        if (appLogoUrl != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "appLogoUrl", appLogoUrl));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getAuthorizationCodeValidateBeforeCall(String clientId, String redirectUri, String state, String scope, String responseType, String appName, String appLogoUrl, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        
        com.squareup.okhttp.Call call = getAuthorizationCodeCall(clientId, redirectUri, state, scope, responseType, appName, appLogoUrl, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get Authorization Code
     * This is **not a true REST endpoint**. &lt;br /&gt; This URL should be used by a user&#39;s browser-client application to perform authorization. &lt;br /&gt;Upon completion, the user will be redirected back to the client application with state and code return parameters. Use \&quot;bluejeans.com\&quot; as hostname. &lt;br /&gt;**Note:**&lt;br /&gt;&amp;nbsp;&amp;nbsp;The code returned is only valid for *30 seconds.*  Your application must call as soon as possible the /oauth2/token API to generate an access token from the returned code.
     * @param clientId The 32 character client ID generated when you created the client application. (optional)
     * @param redirectUri The URL where the authorization code will be returned via redirect.  The URL must match a URL registered with the client application. (optional)
     * @param state Client application specific state passed through and returned in the redirect URL. May be useful for identifying operations or users. (optional)
     * @param scope A comma delimited list of scopes requested. Scopes may be list_meetings, modify_meetings, user_info. Unfortunately, not all operations in the API are available via this authentication method at the current time. (optional)
     * @param responseType The type of authorization you are peforrming.  Set to \&quot;code\&quot;. (optional, default to code)
     * @param appName The name of the client application shown to user during authorization. (optional)
     * @param appLogoUrl URL to an 84x84 image shown to user during authorization. (optional)
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public void getAuthorizationCode(String clientId, String redirectUri, String state, String scope, String responseType, String appName, String appLogoUrl) throws ApiException {
        getAuthorizationCodeWithHttpInfo(clientId, redirectUri, state, scope, responseType, appName, appLogoUrl);
    }

    /**
     * Get Authorization Code
     * This is **not a true REST endpoint**. &lt;br /&gt; This URL should be used by a user&#39;s browser-client application to perform authorization. &lt;br /&gt;Upon completion, the user will be redirected back to the client application with state and code return parameters. Use \&quot;bluejeans.com\&quot; as hostname. &lt;br /&gt;**Note:**&lt;br /&gt;&amp;nbsp;&amp;nbsp;The code returned is only valid for *30 seconds.*  Your application must call as soon as possible the /oauth2/token API to generate an access token from the returned code.
     * @param clientId The 32 character client ID generated when you created the client application. (optional)
     * @param redirectUri The URL where the authorization code will be returned via redirect.  The URL must match a URL registered with the client application. (optional)
     * @param state Client application specific state passed through and returned in the redirect URL. May be useful for identifying operations or users. (optional)
     * @param scope A comma delimited list of scopes requested. Scopes may be list_meetings, modify_meetings, user_info. Unfortunately, not all operations in the API are available via this authentication method at the current time. (optional)
     * @param responseType The type of authorization you are peforrming.  Set to \&quot;code\&quot;. (optional, default to code)
     * @param appName The name of the client application shown to user during authorization. (optional)
     * @param appLogoUrl URL to an 84x84 image shown to user during authorization. (optional)
     * @return ApiResponse&lt;Void&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<Void> getAuthorizationCodeWithHttpInfo(String clientId, String redirectUri, String state, String scope, String responseType, String appName, String appLogoUrl) throws ApiException {
        com.squareup.okhttp.Call call = getAuthorizationCodeValidateBeforeCall(clientId, redirectUri, state, scope, responseType, appName, appLogoUrl, null, null);
        return apiClient.execute(call);
    }

    /**
     * Get Authorization Code (asynchronously)
     * This is **not a true REST endpoint**. &lt;br /&gt; This URL should be used by a user&#39;s browser-client application to perform authorization. &lt;br /&gt;Upon completion, the user will be redirected back to the client application with state and code return parameters. Use \&quot;bluejeans.com\&quot; as hostname. &lt;br /&gt;**Note:**&lt;br /&gt;&amp;nbsp;&amp;nbsp;The code returned is only valid for *30 seconds.*  Your application must call as soon as possible the /oauth2/token API to generate an access token from the returned code.
     * @param clientId The 32 character client ID generated when you created the client application. (optional)
     * @param redirectUri The URL where the authorization code will be returned via redirect.  The URL must match a URL registered with the client application. (optional)
     * @param state Client application specific state passed through and returned in the redirect URL. May be useful for identifying operations or users. (optional)
     * @param scope A comma delimited list of scopes requested. Scopes may be list_meetings, modify_meetings, user_info. Unfortunately, not all operations in the API are available via this authentication method at the current time. (optional)
     * @param responseType The type of authorization you are peforrming.  Set to \&quot;code\&quot;. (optional, default to code)
     * @param appName The name of the client application shown to user during authorization. (optional)
     * @param appLogoUrl URL to an 84x84 image shown to user during authorization. (optional)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getAuthorizationCodeAsync(String clientId, String redirectUri, String state, String scope, String responseType, String appName, String appLogoUrl, final ApiCallback<Void> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getAuthorizationCodeValidateBeforeCall(clientId, redirectUri, state, scope, responseType, appName, appLogoUrl, progressListener, progressRequestListener);
        apiClient.executeAsync(call, callback);
        return call;
    }
    /**
     * Build call for getTokenByClient
     * @param grantRequestClient Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *client_credentials*. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getTokenByClientCall(GrantRequestClient grantRequestClient, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = grantRequestClient;
        
        // create path and map variables
        String localVarPath = "/oauth2/token?Client";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getTokenByClientValidateBeforeCall(GrantRequestClient grantRequestClient, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'grantRequestClient' is set
        if (grantRequestClient == null) {
            throw new ApiException("Missing the required parameter 'grantRequestClient' when calling getTokenByClient(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getTokenByClientCall(grantRequestClient, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Authentication via Client Grant Type
     * This API is typically called from an application that needs to make API requests.  The values for the calling parameters, Client ID, and Secret, are provisioned within the BlueJeans Enterprise Administration console.  A BlueJeans administrator must generate these parameters and provide them to the customer/developer. &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**client_credentials**\&quot; (string).
     * @param grantRequestClient Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *client_credentials*. (required)
     * @return GrantClient
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public GrantClient getTokenByClient(GrantRequestClient grantRequestClient) throws ApiException {
        ApiResponse<GrantClient> resp = getTokenByClientWithHttpInfo(grantRequestClient);
        return resp.getData();
    }

    /**
     * Authentication via Client Grant Type
     * This API is typically called from an application that needs to make API requests.  The values for the calling parameters, Client ID, and Secret, are provisioned within the BlueJeans Enterprise Administration console.  A BlueJeans administrator must generate these parameters and provide them to the customer/developer. &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**client_credentials**\&quot; (string).
     * @param grantRequestClient Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *client_credentials*. (required)
     * @return ApiResponse&lt;GrantClient&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<GrantClient> getTokenByClientWithHttpInfo(GrantRequestClient grantRequestClient) throws ApiException {
        com.squareup.okhttp.Call call = getTokenByClientValidateBeforeCall(grantRequestClient, null, null);
        Type localVarReturnType = new TypeToken<GrantClient>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Authentication via Client Grant Type (asynchronously)
     * This API is typically called from an application that needs to make API requests.  The values for the calling parameters, Client ID, and Secret, are provisioned within the BlueJeans Enterprise Administration console.  A BlueJeans administrator must generate these parameters and provide them to the customer/developer. &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**client_credentials**\&quot; (string).
     * @param grantRequestClient Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *client_credentials*. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getTokenByClientAsync(GrantRequestClient grantRequestClient, final ApiCallback<GrantClient> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getTokenByClientValidateBeforeCall(grantRequestClient, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<GrantClient>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getTokenByCode
     * @param grantRequestCode Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *authorization_code*. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getTokenByCodeCall(GrantRequestCode grantRequestCode, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = grantRequestCode;
        
        // create path and map variables
        String localVarPath = "/oauth2/token?Code";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getTokenByCodeValidateBeforeCall(GrantRequestCode grantRequestCode, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'grantRequestCode' is set
        if (grantRequestCode == null) {
            throw new ApiException("Missing the required parameter 'grantRequestCode' when calling getTokenByCode(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getTokenByCodeCall(grantRequestCode, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Authentication via Code Grant Type
     * This API is part of the 3-legged OAuth 2.0 authorization flow.  The user will be redirected to a BlueJeans page to authenticate.  You must pass to this API your OAuth client and secret keys as well as a *success URL* to which the user will be redirected upon successful authentication. &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**authorization_code**\&quot; (string).
     * @param grantRequestCode Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *authorization_code*. (required)
     * @return GrantCode
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public GrantCode getTokenByCode(GrantRequestCode grantRequestCode) throws ApiException {
        ApiResponse<GrantCode> resp = getTokenByCodeWithHttpInfo(grantRequestCode);
        return resp.getData();
    }

    /**
     * Authentication via Code Grant Type
     * This API is part of the 3-legged OAuth 2.0 authorization flow.  The user will be redirected to a BlueJeans page to authenticate.  You must pass to this API your OAuth client and secret keys as well as a *success URL* to which the user will be redirected upon successful authentication. &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**authorization_code**\&quot; (string).
     * @param grantRequestCode Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *authorization_code*. (required)
     * @return ApiResponse&lt;GrantCode&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<GrantCode> getTokenByCodeWithHttpInfo(GrantRequestCode grantRequestCode) throws ApiException {
        com.squareup.okhttp.Call call = getTokenByCodeValidateBeforeCall(grantRequestCode, null, null);
        Type localVarReturnType = new TypeToken<GrantCode>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Authentication via Code Grant Type (asynchronously)
     * This API is part of the 3-legged OAuth 2.0 authorization flow.  The user will be redirected to a BlueJeans page to authenticate.  You must pass to this API your OAuth client and secret keys as well as a *success URL* to which the user will be redirected upon successful authentication. &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**authorization_code**\&quot; (string).
     * @param grantRequestCode Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *authorization_code*. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getTokenByCodeAsync(GrantRequestCode grantRequestCode, final ApiCallback<GrantCode> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getTokenByCodeValidateBeforeCall(grantRequestCode, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<GrantCode>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getTokenByMeeting
     * @param grantRequestMeeting Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *meeting_passcode*. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getTokenByMeetingCall(GrantRequestMeeting grantRequestMeeting, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = grantRequestMeeting;
        
        // create path and map variables
        String localVarPath = "/oauth2/token?Meeting";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getTokenByMeetingValidateBeforeCall(GrantRequestMeeting grantRequestMeeting, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'grantRequestMeeting' is set
        if (grantRequestMeeting == null) {
            throw new ApiException("Missing the required parameter 'grantRequestMeeting' when calling getTokenByMeeting(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getTokenByMeetingCall(grantRequestMeeting, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Authentication via Meeting Grant Type
     * This API uses an OAuth-like grant/request method similar to the Password grant type.  The API returns an access token whose scope is limited to the meeting only. &lt;br /&gt;Call this API with the meeting&#39;s numeric ID, and the meeting passcode (if one exists). &lt;br /&gt;&amp;nbsp;&amp;nbsp;If you call the API with a Moderator passcode, moderator privileges are granted. &lt;br /&gt;&amp;nbsp;&amp;nbsp;If an Attendee access code is passed, the access token will grant attendee abilities.&lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**meeting_passcode**\&quot; (string).
     * @param grantRequestMeeting Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *meeting_passcode*. (required)
     * @return GrantMeeting
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public GrantMeeting getTokenByMeeting(GrantRequestMeeting grantRequestMeeting) throws ApiException {
        ApiResponse<GrantMeeting> resp = getTokenByMeetingWithHttpInfo(grantRequestMeeting);
        return resp.getData();
    }

    /**
     * Authentication via Meeting Grant Type
     * This API uses an OAuth-like grant/request method similar to the Password grant type.  The API returns an access token whose scope is limited to the meeting only. &lt;br /&gt;Call this API with the meeting&#39;s numeric ID, and the meeting passcode (if one exists). &lt;br /&gt;&amp;nbsp;&amp;nbsp;If you call the API with a Moderator passcode, moderator privileges are granted. &lt;br /&gt;&amp;nbsp;&amp;nbsp;If an Attendee access code is passed, the access token will grant attendee abilities.&lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**meeting_passcode**\&quot; (string).
     * @param grantRequestMeeting Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *meeting_passcode*. (required)
     * @return ApiResponse&lt;GrantMeeting&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<GrantMeeting> getTokenByMeetingWithHttpInfo(GrantRequestMeeting grantRequestMeeting) throws ApiException {
        com.squareup.okhttp.Call call = getTokenByMeetingValidateBeforeCall(grantRequestMeeting, null, null);
        Type localVarReturnType = new TypeToken<GrantMeeting>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Authentication via Meeting Grant Type (asynchronously)
     * This API uses an OAuth-like grant/request method similar to the Password grant type.  The API returns an access token whose scope is limited to the meeting only. &lt;br /&gt;Call this API with the meeting&#39;s numeric ID, and the meeting passcode (if one exists). &lt;br /&gt;&amp;nbsp;&amp;nbsp;If you call the API with a Moderator passcode, moderator privileges are granted. &lt;br /&gt;&amp;nbsp;&amp;nbsp;If an Attendee access code is passed, the access token will grant attendee abilities.&lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**meeting_passcode**\&quot; (string).
     * @param grantRequestMeeting Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *meeting_passcode*. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getTokenByMeetingAsync(GrantRequestMeeting grantRequestMeeting, final ApiCallback<GrantMeeting> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getTokenByMeetingValidateBeforeCall(grantRequestMeeting, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<GrantMeeting>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getTokenByPassword
     * @param grantRequestPassword Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *password*. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getTokenByPasswordCall(GrantRequestPassword grantRequestPassword, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = grantRequestPassword;
        
        // create path and map variables
        String localVarPath = "/oauth2/token?Password";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getTokenByPasswordValidateBeforeCall(GrantRequestPassword grantRequestPassword, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'grantRequestPassword' is set
        if (grantRequestPassword == null) {
            throw new ApiException("Missing the required parameter 'grantRequestPassword' when calling getTokenByPassword(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getTokenByPasswordCall(grantRequestPassword, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Authentication via Password Grant Type
     * This API performs an authentication based upon a username and password.   Call this API and provide a valid username and password. &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**password**\&quot; (string).
     * @param grantRequestPassword Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *password*. (required)
     * @return GrantPassword
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public GrantPassword getTokenByPassword(GrantRequestPassword grantRequestPassword) throws ApiException {
        ApiResponse<GrantPassword> resp = getTokenByPasswordWithHttpInfo(grantRequestPassword);
        return resp.getData();
    }

    /**
     * Authentication via Password Grant Type
     * This API performs an authentication based upon a username and password.   Call this API and provide a valid username and password. &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**password**\&quot; (string).
     * @param grantRequestPassword Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *password*. (required)
     * @return ApiResponse&lt;GrantPassword&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<GrantPassword> getTokenByPasswordWithHttpInfo(GrantRequestPassword grantRequestPassword) throws ApiException {
        com.squareup.okhttp.Call call = getTokenByPasswordValidateBeforeCall(grantRequestPassword, null, null);
        Type localVarReturnType = new TypeToken<GrantPassword>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Authentication via Password Grant Type (asynchronously)
     * This API performs an authentication based upon a username and password.   Call this API and provide a valid username and password. &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**password**\&quot; (string).
     * @param grantRequestPassword Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *password*. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getTokenByPasswordAsync(GrantRequestPassword grantRequestPassword, final ApiCallback<GrantPassword> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getTokenByPasswordValidateBeforeCall(grantRequestPassword, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<GrantPassword>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getTokenByRefresh
     * @param grantRequestRefresh Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *refresh_token*. (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getTokenByRefreshCall(GrantRequestRefresh grantRequestRefresh, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = grantRequestRefresh;
        
        // create path and map variables
        String localVarPath = "/oauth2/token?Refresh";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getTokenByRefreshValidateBeforeCall(GrantRequestRefresh grantRequestRefresh, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'grantRequestRefresh' is set
        if (grantRequestRefresh == null) {
            throw new ApiException("Missing the required parameter 'grantRequestRefresh' when calling getTokenByRefresh(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getTokenByRefreshCall(grantRequestRefresh, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Authentication via Refresh Grant Type
     * This API is part of the 3-legged OAuth 2.0 authorization flow.  It only works for access tokens obtained via /oauth2/token?Code endpoint. It allows an application to refresh an existing access token.  You must pass to this API your OAuth client and secret keys as well as the current access token being refreshed.  &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**refresh_token**\&quot; (string).
     * @param grantRequestRefresh Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *refresh_token*. (required)
     * @return GrantRefresh
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public GrantRefresh getTokenByRefresh(GrantRequestRefresh grantRequestRefresh) throws ApiException {
        ApiResponse<GrantRefresh> resp = getTokenByRefreshWithHttpInfo(grantRequestRefresh);
        return resp.getData();
    }

    /**
     * Authentication via Refresh Grant Type
     * This API is part of the 3-legged OAuth 2.0 authorization flow.  It only works for access tokens obtained via /oauth2/token?Code endpoint. It allows an application to refresh an existing access token.  You must pass to this API your OAuth client and secret keys as well as the current access token being refreshed.  &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**refresh_token**\&quot; (string).
     * @param grantRequestRefresh Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *refresh_token*. (required)
     * @return ApiResponse&lt;GrantRefresh&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<GrantRefresh> getTokenByRefreshWithHttpInfo(GrantRequestRefresh grantRequestRefresh) throws ApiException {
        com.squareup.okhttp.Call call = getTokenByRefreshValidateBeforeCall(grantRequestRefresh, null, null);
        Type localVarReturnType = new TypeToken<GrantRefresh>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Authentication via Refresh Grant Type (asynchronously)
     * This API is part of the 3-legged OAuth 2.0 authorization flow.  It only works for access tokens obtained via /oauth2/token?Code endpoint. It allows an application to refresh an existing access token.  You must pass to this API your OAuth client and secret keys as well as the current access token being refreshed.  &lt;br /&gt;**NOTE:** &lt;br /&gt;&amp;nbsp;&amp;nbsp;When calling this API, you must set the field, **grant_type** to equal \&quot;**refresh_token**\&quot; (string).
     * @param grantRequestRefresh Contains information about the type of grant you are requesting.  **Remember**, the field *grant_type* must be set to *refresh_token*. (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getTokenByRefreshAsync(GrantRequestRefresh grantRequestRefresh, final ApiCallback<GrantRefresh> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getTokenByRefreshValidateBeforeCall(grantRequestRefresh, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<GrantRefresh>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getTokenInfo
     * @param accessToken  (optional)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getTokenInfoCall(String accessToken, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/oauth2/tokenInfo";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (accessToken != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "access_token", accessToken));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getTokenInfoValidateBeforeCall(String accessToken, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        
        com.squareup.okhttp.Call call = getTokenInfoCall(accessToken, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Validate a Token
     * This endpoint will determine if a token is valid or not.  If the token is valid, it returns the user ID for the owner of the token.
     * @param accessToken  (optional)
     * @return InlineResponse200
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public InlineResponse200 getTokenInfo(String accessToken) throws ApiException {
        ApiResponse<InlineResponse200> resp = getTokenInfoWithHttpInfo(accessToken);
        return resp.getData();
    }

    /**
     * Validate a Token
     * This endpoint will determine if a token is valid or not.  If the token is valid, it returns the user ID for the owner of the token.
     * @param accessToken  (optional)
     * @return ApiResponse&lt;InlineResponse200&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<InlineResponse200> getTokenInfoWithHttpInfo(String accessToken) throws ApiException {
        com.squareup.okhttp.Call call = getTokenInfoValidateBeforeCall(accessToken, null, null);
        Type localVarReturnType = new TypeToken<InlineResponse200>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Validate a Token (asynchronously)
     * This endpoint will determine if a token is valid or not.  If the token is valid, it returns the user ID for the owner of the token.
     * @param accessToken  (optional)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getTokenInfoAsync(String accessToken, final ApiCallback<InlineResponse200> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getTokenInfoValidateBeforeCall(accessToken, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<InlineResponse200>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for revokeAccessToken
     * @param grantRequestRevoke Contains information about the type of grant you are revoking. (required)
     * @param accessToken  (optional)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call revokeAccessTokenCall(GrantRequestRevoke grantRequestRevoke, String accessToken, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = grantRequestRevoke;
        
        // create path and map variables
        String localVarPath = "/oauth2/token?Revoke";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        if (accessToken != null)
        localVarQueryParams.addAll(apiClient.parameterToPairs("", "access_token", accessToken));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "access_token" };
        return apiClient.buildCall(localVarPath, "DELETE", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call revokeAccessTokenValidateBeforeCall(GrantRequestRevoke grantRequestRevoke, String accessToken, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'grantRequestRevoke' is set
        if (grantRequestRevoke == null) {
            throw new ApiException("Missing the required parameter 'grantRequestRevoke' when calling revokeAccessToken(Async)");
        }
        
        
        com.squareup.okhttp.Call call = revokeAccessTokenCall(grantRequestRevoke, accessToken, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Revoke Access Token
     * This API is part of the 3-legged OAuth 2.0 authorization flow.
     * @param grantRequestRevoke Contains information about the type of grant you are revoking. (required)
     * @param accessToken  (optional)
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public void revokeAccessToken(GrantRequestRevoke grantRequestRevoke, String accessToken) throws ApiException {
        revokeAccessTokenWithHttpInfo(grantRequestRevoke, accessToken);
    }

    /**
     * Revoke Access Token
     * This API is part of the 3-legged OAuth 2.0 authorization flow.
     * @param grantRequestRevoke Contains information about the type of grant you are revoking. (required)
     * @param accessToken  (optional)
     * @return ApiResponse&lt;Void&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<Void> revokeAccessTokenWithHttpInfo(GrantRequestRevoke grantRequestRevoke, String accessToken) throws ApiException {
        com.squareup.okhttp.Call call = revokeAccessTokenValidateBeforeCall(grantRequestRevoke, accessToken, null, null);
        return apiClient.execute(call);
    }

    /**
     * Revoke Access Token (asynchronously)
     * This API is part of the 3-legged OAuth 2.0 authorization flow.
     * @param grantRequestRevoke Contains information about the type of grant you are revoking. (required)
     * @param accessToken  (optional)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call revokeAccessTokenAsync(GrantRequestRevoke grantRequestRevoke, String accessToken, final ApiCallback<Void> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = revokeAccessTokenValidateBeforeCall(grantRequestRevoke, accessToken, progressListener, progressRequestListener);
        apiClient.executeAsync(call, callback);
        return call;
    }
}
