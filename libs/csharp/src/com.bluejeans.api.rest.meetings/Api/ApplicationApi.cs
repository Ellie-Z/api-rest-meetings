/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/23/2018 </alert>Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.4407232018
 * Contact: glenn@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using com.bluejeans.api.rest.meetings.Client;
using com.bluejeans.api.rest.meetings.Model;

namespace com.bluejeans.api.rest.meetings.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApplicationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Client Application
        /// </summary>
        /// <remarks>
        /// This endpoint creates a client application for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Application</returns>
        Application CreateClientApplication (int? userId, Application application);

        /// <summary>
        /// Create Client Application
        /// </summary>
        /// <remarks>
        /// This endpoint creates a client application for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>ApiResponse of Application</returns>
        ApiResponse<Application> CreateClientApplicationWithHttpInfo (int? userId, Application application);
        /// <summary>
        /// List Client Applications
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the client applications associated with the access_token.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>ApplicationList</returns>
        ApplicationList ListClientApplications (int? userId);

        /// <summary>
        /// List Client Applications
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the client applications associated with the access_token.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>ApiResponse of ApplicationList</returns>
        ApiResponse<ApplicationList> ListClientApplicationsWithHttpInfo (int? userId);
        /// <summary>
        /// Regenerate Client Application Secret
        /// </summary>
        /// <remarks>
        /// This endpoint forces the regeneration of a client application secret for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <returns>ApplicationSecret</returns>
        ApplicationSecret RegenerateClientApplicationSecret (int? userId, string clientId);

        /// <summary>
        /// Regenerate Client Application Secret
        /// </summary>
        /// <remarks>
        /// This endpoint forces the regeneration of a client application secret for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <returns>ApiResponse of ApplicationSecret</returns>
        ApiResponse<ApplicationSecret> RegenerateClientApplicationSecretWithHttpInfo (int? userId, string clientId);
        /// <summary>
        /// Update Client Application
        /// </summary>
        /// <remarks>
        /// This endpoint updates a client application for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Application</returns>
        Application UpdateClientApplication (int? userId, string clientId, Application application);

        /// <summary>
        /// Update Client Application
        /// </summary>
        /// <remarks>
        /// This endpoint updates a client application for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>ApiResponse of Application</returns>
        ApiResponse<Application> UpdateClientApplicationWithHttpInfo (int? userId, string clientId, Application application);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Client Application
        /// </summary>
        /// <remarks>
        /// This endpoint creates a client application for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Task of Application</returns>
        System.Threading.Tasks.Task<Application> CreateClientApplicationAsync (int? userId, Application application);

        /// <summary>
        /// Create Client Application
        /// </summary>
        /// <remarks>
        /// This endpoint creates a client application for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Task of ApiResponse (Application)</returns>
        System.Threading.Tasks.Task<ApiResponse<Application>> CreateClientApplicationAsyncWithHttpInfo (int? userId, Application application);
        /// <summary>
        /// List Client Applications
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the client applications associated with the access_token.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of ApplicationList</returns>
        System.Threading.Tasks.Task<ApplicationList> ListClientApplicationsAsync (int? userId);

        /// <summary>
        /// List Client Applications
        /// </summary>
        /// <remarks>
        /// This endpoint lists all the client applications associated with the access_token.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of ApiResponse (ApplicationList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationList>> ListClientApplicationsAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// Regenerate Client Application Secret
        /// </summary>
        /// <remarks>
        /// This endpoint forces the regeneration of a client application secret for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <returns>Task of ApplicationSecret</returns>
        System.Threading.Tasks.Task<ApplicationSecret> RegenerateClientApplicationSecretAsync (int? userId, string clientId);

        /// <summary>
        /// Regenerate Client Application Secret
        /// </summary>
        /// <remarks>
        /// This endpoint forces the regeneration of a client application secret for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <returns>Task of ApiResponse (ApplicationSecret)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApplicationSecret>> RegenerateClientApplicationSecretAsyncWithHttpInfo (int? userId, string clientId);
        /// <summary>
        /// Update Client Application
        /// </summary>
        /// <remarks>
        /// This endpoint updates a client application for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Task of Application</returns>
        System.Threading.Tasks.Task<Application> UpdateClientApplicationAsync (int? userId, string clientId, Application application);

        /// <summary>
        /// Update Client Application
        /// </summary>
        /// <remarks>
        /// This endpoint updates a client application for use in 3-legged OAuth2 authorization.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Task of ApiResponse (Application)</returns>
        System.Threading.Tasks.Task<ApiResponse<Application>> UpdateClientApplicationAsyncWithHttpInfo (int? userId, string clientId, Application application);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ApplicationApi : IApplicationApi
    {
        private com.bluejeans.api.rest.meetings.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationApi(String basePath)
        {
            this.Configuration = new com.bluejeans.api.rest.meetings.Client.Configuration { BasePath = basePath };

            ExceptionFactory = com.bluejeans.api.rest.meetings.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ApplicationApi(com.bluejeans.api.rest.meetings.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = com.bluejeans.api.rest.meetings.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.bluejeans.api.rest.meetings.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public com.bluejeans.api.rest.meetings.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public com.bluejeans.api.rest.meetings.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create Client Application This endpoint creates a client application for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Application</returns>
        public Application CreateClientApplication (int? userId, Application application)
        {
             ApiResponse<Application> localVarResponse = CreateClientApplicationWithHttpInfo(userId, application);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Client Application This endpoint creates a client application for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>ApiResponse of Application</returns>
        public ApiResponse< Application > CreateClientApplicationWithHttpInfo (int? userId, Application application)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ApplicationApi->CreateClientApplication");
            // verify the required parameter 'application' is set
            if (application == null)
                throw new ApiException(400, "Missing required parameter 'application' when calling ApplicationApi->CreateClientApplication");

            var localVarPath = "/v1/user/{user_id}/developer_applications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("user_id", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (application != null && application.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(application); // http body (model) parameter
            }
            else
            {
                localVarPostBody = application; // byte array
            }

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", this.Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateClientApplication", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Application>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Application) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Application)));
        }

        /// <summary>
        /// Create Client Application This endpoint creates a client application for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Task of Application</returns>
        public async System.Threading.Tasks.Task<Application> CreateClientApplicationAsync (int? userId, Application application)
        {
             ApiResponse<Application> localVarResponse = await CreateClientApplicationAsyncWithHttpInfo(userId, application);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Client Application This endpoint creates a client application for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Task of ApiResponse (Application)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Application>> CreateClientApplicationAsyncWithHttpInfo (int? userId, Application application)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ApplicationApi->CreateClientApplication");
            // verify the required parameter 'application' is set
            if (application == null)
                throw new ApiException(400, "Missing required parameter 'application' when calling ApplicationApi->CreateClientApplication");

            var localVarPath = "/v1/user/{user_id}/developer_applications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("user_id", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (application != null && application.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(application); // http body (model) parameter
            }
            else
            {
                localVarPostBody = application; // byte array
            }

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", this.Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateClientApplication", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Application>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Application) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Application)));
        }

        /// <summary>
        /// List Client Applications This endpoint lists all the client applications associated with the access_token.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>ApplicationList</returns>
        public ApplicationList ListClientApplications (int? userId)
        {
             ApiResponse<ApplicationList> localVarResponse = ListClientApplicationsWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Client Applications This endpoint lists all the client applications associated with the access_token.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>ApiResponse of ApplicationList</returns>
        public ApiResponse< ApplicationList > ListClientApplicationsWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ApplicationApi->ListClientApplications");

            var localVarPath = "/v1/user/{user_id}/developer_applications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("user_id", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", this.Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListClientApplications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApplicationList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApplicationList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApplicationList)));
        }

        /// <summary>
        /// List Client Applications This endpoint lists all the client applications associated with the access_token.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of ApplicationList</returns>
        public async System.Threading.Tasks.Task<ApplicationList> ListClientApplicationsAsync (int? userId)
        {
             ApiResponse<ApplicationList> localVarResponse = await ListClientApplicationsAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Client Applications This endpoint lists all the client applications associated with the access_token.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of ApiResponse (ApplicationList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApplicationList>> ListClientApplicationsAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ApplicationApi->ListClientApplications");

            var localVarPath = "/v1/user/{user_id}/developer_applications";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("user_id", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", this.Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ListClientApplications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApplicationList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApplicationList) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApplicationList)));
        }

        /// <summary>
        /// Regenerate Client Application Secret This endpoint forces the regeneration of a client application secret for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <returns>ApplicationSecret</returns>
        public ApplicationSecret RegenerateClientApplicationSecret (int? userId, string clientId)
        {
             ApiResponse<ApplicationSecret> localVarResponse = RegenerateClientApplicationSecretWithHttpInfo(userId, clientId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Regenerate Client Application Secret This endpoint forces the regeneration of a client application secret for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <returns>ApiResponse of ApplicationSecret</returns>
        public ApiResponse< ApplicationSecret > RegenerateClientApplicationSecretWithHttpInfo (int? userId, string clientId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ApplicationApi->RegenerateClientApplicationSecret");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ApplicationApi->RegenerateClientApplicationSecret");

            var localVarPath = "/v1/user/{user_id}/developer_applications/{client_id}/secret";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("user_id", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) localVarPathParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", this.Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RegenerateClientApplicationSecret", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApplicationSecret>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApplicationSecret) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApplicationSecret)));
        }

        /// <summary>
        /// Regenerate Client Application Secret This endpoint forces the regeneration of a client application secret for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <returns>Task of ApplicationSecret</returns>
        public async System.Threading.Tasks.Task<ApplicationSecret> RegenerateClientApplicationSecretAsync (int? userId, string clientId)
        {
             ApiResponse<ApplicationSecret> localVarResponse = await RegenerateClientApplicationSecretAsyncWithHttpInfo(userId, clientId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Regenerate Client Application Secret This endpoint forces the regeneration of a client application secret for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <returns>Task of ApiResponse (ApplicationSecret)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApplicationSecret>> RegenerateClientApplicationSecretAsyncWithHttpInfo (int? userId, string clientId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ApplicationApi->RegenerateClientApplicationSecret");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ApplicationApi->RegenerateClientApplicationSecret");

            var localVarPath = "/v1/user/{user_id}/developer_applications/{client_id}/secret";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("user_id", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) localVarPathParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", this.Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RegenerateClientApplicationSecret", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApplicationSecret>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApplicationSecret) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApplicationSecret)));
        }

        /// <summary>
        /// Update Client Application This endpoint updates a client application for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Application</returns>
        public Application UpdateClientApplication (int? userId, string clientId, Application application)
        {
             ApiResponse<Application> localVarResponse = UpdateClientApplicationWithHttpInfo(userId, clientId, application);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Client Application This endpoint updates a client application for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>ApiResponse of Application</returns>
        public ApiResponse< Application > UpdateClientApplicationWithHttpInfo (int? userId, string clientId, Application application)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ApplicationApi->UpdateClientApplication");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ApplicationApi->UpdateClientApplication");
            // verify the required parameter 'application' is set
            if (application == null)
                throw new ApiException(400, "Missing required parameter 'application' when calling ApplicationApi->UpdateClientApplication");

            var localVarPath = "/v1/user/{user_id}/developer_applications/{client_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("user_id", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) localVarPathParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            if (application != null && application.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(application); // http body (model) parameter
            }
            else
            {
                localVarPostBody = application; // byte array
            }

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", this.Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateClientApplication", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Application>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Application) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Application)));
        }

        /// <summary>
        /// Update Client Application This endpoint updates a client application for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Task of Application</returns>
        public async System.Threading.Tasks.Task<Application> UpdateClientApplicationAsync (int? userId, string clientId, Application application)
        {
             ApiResponse<Application> localVarResponse = await UpdateClientApplicationAsyncWithHttpInfo(userId, clientId, application);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Client Application This endpoint updates a client application for use in 3-legged OAuth2 authorization.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="clientId">The ID of the client application of interest. This value was given as a response during client application creation.</param>
        /// <param name="application">The information about the new client application.</param>
        /// <returns>Task of ApiResponse (Application)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Application>> UpdateClientApplicationAsyncWithHttpInfo (int? userId, string clientId, Application application)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling ApplicationApi->UpdateClientApplication");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ApplicationApi->UpdateClientApplication");
            // verify the required parameter 'application' is set
            if (application == null)
                throw new ApiException(400, "Missing required parameter 'application' when calling ApplicationApi->UpdateClientApplication");

            var localVarPath = "/v1/user/{user_id}/developer_applications/{client_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarPathParams.Add("user_id", this.Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (clientId != null) localVarPathParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // path parameter
            if (application != null && application.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(application); // http body (model) parameter
            }
            else
            {
                localVarPostBody = application; // byte array
            }

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "access_token", this.Configuration.GetApiKeyWithPrefix("access_token")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateClientApplication", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Application>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Application) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Application)));
        }

    }
}
