/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/010/2018 </alert>Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0.mm44 (7/06/2018)
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
    public interface IEnterpriseApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Set Enterprise Tags
        /// </summary>
        /// <remarks>
        /// This endpoint modifies the list of profile tags associated with the specified enterprise.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="action">Type of operation to be done</param>
        /// <param name="tag">The name of tag</param>
        /// <returns>ComponentstagList</returns>
        ComponentstagList ChangeEnterpriseTags (int? enterpriseId, string action, string tag);

        /// <summary>
        /// Set Enterprise Tags
        /// </summary>
        /// <remarks>
        /// This endpoint modifies the list of profile tags associated with the specified enterprise.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="action">Type of operation to be done</param>
        /// <param name="tag">The name of tag</param>
        /// <returns>ApiResponse of ComponentstagList</returns>
        ApiResponse<ComponentstagList> ChangeEnterpriseTagsWithHttpInfo (int? enterpriseId, string action, string tag);
        /// <summary>
        /// Create User
        /// </summary>
        /// <remarks>
        /// This endpoint creates a user profile within the specified enterprise.  It is the first of the 2-step process to create a BlueJeans user.  It should be followed by an API call to create the user&#39;s personal meeting room.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="enterpriseUser">Basic Enterprise Account information</param>
        /// <param name="billingCategory">What general billing group does this profile belong? (optional, default to ENTERPRISE)</param>
        /// <param name="forcePasswordChange">Create profile and force user to change password on next login (optional)</param>
        /// <param name="isAdmin">Create this account to have Administrative Privileges for the enterprise (optional)</param>
        /// <returns>UserId</returns>
        UserId CreateEnterpriseUser (int? enterpriseId, EnterpriseCreateUser enterpriseUser, string billingCategory = null, bool? forcePasswordChange = null, bool? isAdmin = null);

        /// <summary>
        /// Create User
        /// </summary>
        /// <remarks>
        /// This endpoint creates a user profile within the specified enterprise.  It is the first of the 2-step process to create a BlueJeans user.  It should be followed by an API call to create the user&#39;s personal meeting room.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="enterpriseUser">Basic Enterprise Account information</param>
        /// <param name="billingCategory">What general billing group does this profile belong? (optional, default to ENTERPRISE)</param>
        /// <param name="forcePasswordChange">Create profile and force user to change password on next login (optional)</param>
        /// <param name="isAdmin">Create this account to have Administrative Privileges for the enterprise (optional)</param>
        /// <returns>ApiResponse of UserId</returns>
        ApiResponse<UserId> CreateEnterpriseUserWithHttpInfo (int? enterpriseId, EnterpriseCreateUser enterpriseUser, string billingCategory = null, bool? forcePasswordChange = null, bool? isAdmin = null);
        /// <summary>
        /// Export Enterprise Users
        /// </summary>
        /// <remarks>
        /// This endpoint exports existing users into a CSV file.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns></returns>
        void ExportUsers (int? enterpriseId);

        /// <summary>
        /// Export Enterprise Users
        /// </summary>
        /// <remarks>
        /// This endpoint exports existing users into a CSV file.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ExportUsersWithHttpInfo (int? enterpriseId);
        /// <summary>
        /// List Enterprise Tags
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves all profile tags defined for the specified enterprise.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>ComponentstagList</returns>
        ComponentstagList GetEnterpriseTags (int? enterpriseId);

        /// <summary>
        /// List Enterprise Tags
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves all profile tags defined for the specified enterprise.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>ApiResponse of ComponentstagList</returns>
        ApiResponse<ComponentstagList> GetEnterpriseTagsWithHttpInfo (int? enterpriseId);
        /// <summary>
        /// Remove Enterprise User
        /// </summary>
        /// <remarks>
        /// This endpoint allows removing a user from an enterprise; it does not delete the user. Requires enterprise admin access level.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns></returns>
        void RemoveUser (int? enterpriseId, int? userId);

        /// <summary>
        /// Remove Enterprise User
        /// </summary>
        /// <remarks>
        /// This endpoint allows removing a user from an enterprise; it does not delete the user. Requires enterprise admin access level.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RemoveUserWithHttpInfo (int? enterpriseId, int? userId);
        /// <summary>
        /// Search for User(s)
        /// </summary>
        /// <remarks>
        /// This endpoint provides a search facility for the specified enterprise.  &lt;ul&gt;&lt;li&gt;If textSearch is provided, the results will be a partial string-match search of the given textSearch value.&lt;/li&gt;&lt;li&gt; Otherwise, the search will return an exact lookup by emailId.&lt;/li&gt;&lt;/ul&gt;
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="fields">A comma-separated list one or more of these BlueJeans enteprise profile fields to include in the API responses- username, firstName, middleName, lastName, isEnterpriseAdmin, enterpriseJoinDate, email (optional)</param>
        /// <param name="order">If specificed, order defines how the API sorts results- ascending or descending (optional)</param>
        /// <param name="sortBy">Name of BlueJeans profile field by with API response data is sorted (optional)</param>
        /// <param name="textSearch">If specified textSearch provides a string (partial or complete) by which to search the list of BlueJeans users (optional)</param>
        /// <param name="emailId">If specified, emailId specifies performing a search for the user profile associated with this email address.  Wildcards are &lt;b&gt;not&lt;/b&gt; supported for the email address value. (optional)</param>
        /// <param name="pageSize">Sets number of items returned per page. (optional)</param>
        /// <param name="pageNumber">Selects which page of results to return (1-based value) (optional)</param>
        /// <returns>EnterpriseUserSearch</returns>
        EnterpriseUserSearch SearchUsers (int? enterpriseId, string fields = null, string order = null, string sortBy = null, string textSearch = null, string emailId = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Search for User(s)
        /// </summary>
        /// <remarks>
        /// This endpoint provides a search facility for the specified enterprise.  &lt;ul&gt;&lt;li&gt;If textSearch is provided, the results will be a partial string-match search of the given textSearch value.&lt;/li&gt;&lt;li&gt; Otherwise, the search will return an exact lookup by emailId.&lt;/li&gt;&lt;/ul&gt;
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="fields">A comma-separated list one or more of these BlueJeans enteprise profile fields to include in the API responses- username, firstName, middleName, lastName, isEnterpriseAdmin, enterpriseJoinDate, email (optional)</param>
        /// <param name="order">If specificed, order defines how the API sorts results- ascending or descending (optional)</param>
        /// <param name="sortBy">Name of BlueJeans profile field by with API response data is sorted (optional)</param>
        /// <param name="textSearch">If specified textSearch provides a string (partial or complete) by which to search the list of BlueJeans users (optional)</param>
        /// <param name="emailId">If specified, emailId specifies performing a search for the user profile associated with this email address.  Wildcards are &lt;b&gt;not&lt;/b&gt; supported for the email address value. (optional)</param>
        /// <param name="pageSize">Sets number of items returned per page. (optional)</param>
        /// <param name="pageNumber">Selects which page of results to return (1-based value) (optional)</param>
        /// <returns>ApiResponse of EnterpriseUserSearch</returns>
        ApiResponse<EnterpriseUserSearch> SearchUsersWithHttpInfo (int? enterpriseId, string fields = null, string order = null, string sortBy = null, string textSearch = null, string emailId = null, int? pageSize = null, int? pageNumber = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Set Enterprise Tags
        /// </summary>
        /// <remarks>
        /// This endpoint modifies the list of profile tags associated with the specified enterprise.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="action">Type of operation to be done</param>
        /// <param name="tag">The name of tag</param>
        /// <returns>Task of ComponentstagList</returns>
        System.Threading.Tasks.Task<ComponentstagList> ChangeEnterpriseTagsAsync (int? enterpriseId, string action, string tag);

        /// <summary>
        /// Set Enterprise Tags
        /// </summary>
        /// <remarks>
        /// This endpoint modifies the list of profile tags associated with the specified enterprise.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="action">Type of operation to be done</param>
        /// <param name="tag">The name of tag</param>
        /// <returns>Task of ApiResponse (ComponentstagList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ComponentstagList>> ChangeEnterpriseTagsAsyncWithHttpInfo (int? enterpriseId, string action, string tag);
        /// <summary>
        /// Create User
        /// </summary>
        /// <remarks>
        /// This endpoint creates a user profile within the specified enterprise.  It is the first of the 2-step process to create a BlueJeans user.  It should be followed by an API call to create the user&#39;s personal meeting room.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="enterpriseUser">Basic Enterprise Account information</param>
        /// <param name="billingCategory">What general billing group does this profile belong? (optional, default to ENTERPRISE)</param>
        /// <param name="forcePasswordChange">Create profile and force user to change password on next login (optional)</param>
        /// <param name="isAdmin">Create this account to have Administrative Privileges for the enterprise (optional)</param>
        /// <returns>Task of UserId</returns>
        System.Threading.Tasks.Task<UserId> CreateEnterpriseUserAsync (int? enterpriseId, EnterpriseCreateUser enterpriseUser, string billingCategory = null, bool? forcePasswordChange = null, bool? isAdmin = null);

        /// <summary>
        /// Create User
        /// </summary>
        /// <remarks>
        /// This endpoint creates a user profile within the specified enterprise.  It is the first of the 2-step process to create a BlueJeans user.  It should be followed by an API call to create the user&#39;s personal meeting room.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="enterpriseUser">Basic Enterprise Account information</param>
        /// <param name="billingCategory">What general billing group does this profile belong? (optional, default to ENTERPRISE)</param>
        /// <param name="forcePasswordChange">Create profile and force user to change password on next login (optional)</param>
        /// <param name="isAdmin">Create this account to have Administrative Privileges for the enterprise (optional)</param>
        /// <returns>Task of ApiResponse (UserId)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserId>> CreateEnterpriseUserAsyncWithHttpInfo (int? enterpriseId, EnterpriseCreateUser enterpriseUser, string billingCategory = null, bool? forcePasswordChange = null, bool? isAdmin = null);
        /// <summary>
        /// Export Enterprise Users
        /// </summary>
        /// <remarks>
        /// This endpoint exports existing users into a CSV file.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ExportUsersAsync (int? enterpriseId);

        /// <summary>
        /// Export Enterprise Users
        /// </summary>
        /// <remarks>
        /// This endpoint exports existing users into a CSV file.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ExportUsersAsyncWithHttpInfo (int? enterpriseId);
        /// <summary>
        /// List Enterprise Tags
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves all profile tags defined for the specified enterprise.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of ComponentstagList</returns>
        System.Threading.Tasks.Task<ComponentstagList> GetEnterpriseTagsAsync (int? enterpriseId);

        /// <summary>
        /// List Enterprise Tags
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves all profile tags defined for the specified enterprise.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of ApiResponse (ComponentstagList)</returns>
        System.Threading.Tasks.Task<ApiResponse<ComponentstagList>> GetEnterpriseTagsAsyncWithHttpInfo (int? enterpriseId);
        /// <summary>
        /// Remove Enterprise User
        /// </summary>
        /// <remarks>
        /// This endpoint allows removing a user from an enterprise; it does not delete the user. Requires enterprise admin access level.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveUserAsync (int? enterpriseId, int? userId);

        /// <summary>
        /// Remove Enterprise User
        /// </summary>
        /// <remarks>
        /// This endpoint allows removing a user from an enterprise; it does not delete the user. Requires enterprise admin access level.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RemoveUserAsyncWithHttpInfo (int? enterpriseId, int? userId);
        /// <summary>
        /// Search for User(s)
        /// </summary>
        /// <remarks>
        /// This endpoint provides a search facility for the specified enterprise.  &lt;ul&gt;&lt;li&gt;If textSearch is provided, the results will be a partial string-match search of the given textSearch value.&lt;/li&gt;&lt;li&gt; Otherwise, the search will return an exact lookup by emailId.&lt;/li&gt;&lt;/ul&gt;
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="fields">A comma-separated list one or more of these BlueJeans enteprise profile fields to include in the API responses- username, firstName, middleName, lastName, isEnterpriseAdmin, enterpriseJoinDate, email (optional)</param>
        /// <param name="order">If specificed, order defines how the API sorts results- ascending or descending (optional)</param>
        /// <param name="sortBy">Name of BlueJeans profile field by with API response data is sorted (optional)</param>
        /// <param name="textSearch">If specified textSearch provides a string (partial or complete) by which to search the list of BlueJeans users (optional)</param>
        /// <param name="emailId">If specified, emailId specifies performing a search for the user profile associated with this email address.  Wildcards are &lt;b&gt;not&lt;/b&gt; supported for the email address value. (optional)</param>
        /// <param name="pageSize">Sets number of items returned per page. (optional)</param>
        /// <param name="pageNumber">Selects which page of results to return (1-based value) (optional)</param>
        /// <returns>Task of EnterpriseUserSearch</returns>
        System.Threading.Tasks.Task<EnterpriseUserSearch> SearchUsersAsync (int? enterpriseId, string fields = null, string order = null, string sortBy = null, string textSearch = null, string emailId = null, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Search for User(s)
        /// </summary>
        /// <remarks>
        /// This endpoint provides a search facility for the specified enterprise.  &lt;ul&gt;&lt;li&gt;If textSearch is provided, the results will be a partial string-match search of the given textSearch value.&lt;/li&gt;&lt;li&gt; Otherwise, the search will return an exact lookup by emailId.&lt;/li&gt;&lt;/ul&gt;
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="fields">A comma-separated list one or more of these BlueJeans enteprise profile fields to include in the API responses- username, firstName, middleName, lastName, isEnterpriseAdmin, enterpriseJoinDate, email (optional)</param>
        /// <param name="order">If specificed, order defines how the API sorts results- ascending or descending (optional)</param>
        /// <param name="sortBy">Name of BlueJeans profile field by with API response data is sorted (optional)</param>
        /// <param name="textSearch">If specified textSearch provides a string (partial or complete) by which to search the list of BlueJeans users (optional)</param>
        /// <param name="emailId">If specified, emailId specifies performing a search for the user profile associated with this email address.  Wildcards are &lt;b&gt;not&lt;/b&gt; supported for the email address value. (optional)</param>
        /// <param name="pageSize">Sets number of items returned per page. (optional)</param>
        /// <param name="pageNumber">Selects which page of results to return (1-based value) (optional)</param>
        /// <returns>Task of ApiResponse (EnterpriseUserSearch)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnterpriseUserSearch>> SearchUsersAsyncWithHttpInfo (int? enterpriseId, string fields = null, string order = null, string sortBy = null, string textSearch = null, string emailId = null, int? pageSize = null, int? pageNumber = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EnterpriseApi : IEnterpriseApi
    {
        private com.bluejeans.api.rest.meetings.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EnterpriseApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = com.bluejeans.api.rest.meetings.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EnterpriseApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.bluejeans.api.rest.meetings.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Set Enterprise Tags This endpoint modifies the list of profile tags associated with the specified enterprise.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="action">Type of operation to be done</param>
        /// <param name="tag">The name of tag</param>
        /// <returns>ComponentstagList</returns>
        public ComponentstagList ChangeEnterpriseTags (int? enterpriseId, string action, string tag)
        {
             ApiResponse<ComponentstagList> localVarResponse = ChangeEnterpriseTagsWithHttpInfo(enterpriseId, action, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set Enterprise Tags This endpoint modifies the list of profile tags associated with the specified enterprise.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="action">Type of operation to be done</param>
        /// <param name="tag">The name of tag</param>
        /// <returns>ApiResponse of ComponentstagList</returns>
        public ApiResponse< ComponentstagList > ChangeEnterpriseTagsWithHttpInfo (int? enterpriseId, string action, string tag)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->ChangeEnterpriseTags");
            // verify the required parameter 'action' is set
            if (action == null)
                throw new ApiException(400, "Missing required parameter 'action' when calling EnterpriseApi->ChangeEnterpriseTags");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling EnterpriseApi->ChangeEnterpriseTags");

            var localVarPath = "/v1/enterprise/{enterpriseId}/tags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterpriseId", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter
            if (action != null) localVarQueryParams.Add("action", Configuration.ApiClient.ParameterToString(action)); // query parameter
            if (tag != null) localVarQueryParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // query parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChangeEnterpriseTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ComponentstagList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ComponentstagList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ComponentstagList)));
        }

        /// <summary>
        /// Set Enterprise Tags This endpoint modifies the list of profile tags associated with the specified enterprise.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="action">Type of operation to be done</param>
        /// <param name="tag">The name of tag</param>
        /// <returns>Task of ComponentstagList</returns>
        public async System.Threading.Tasks.Task<ComponentstagList> ChangeEnterpriseTagsAsync (int? enterpriseId, string action, string tag)
        {
             ApiResponse<ComponentstagList> localVarResponse = await ChangeEnterpriseTagsAsyncWithHttpInfo(enterpriseId, action, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set Enterprise Tags This endpoint modifies the list of profile tags associated with the specified enterprise.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="action">Type of operation to be done</param>
        /// <param name="tag">The name of tag</param>
        /// <returns>Task of ApiResponse (ComponentstagList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ComponentstagList>> ChangeEnterpriseTagsAsyncWithHttpInfo (int? enterpriseId, string action, string tag)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->ChangeEnterpriseTags");
            // verify the required parameter 'action' is set
            if (action == null)
                throw new ApiException(400, "Missing required parameter 'action' when calling EnterpriseApi->ChangeEnterpriseTags");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling EnterpriseApi->ChangeEnterpriseTags");

            var localVarPath = "/v1/enterprise/{enterpriseId}/tags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterpriseId", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter
            if (action != null) localVarQueryParams.Add("action", Configuration.ApiClient.ParameterToString(action)); // query parameter
            if (tag != null) localVarQueryParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // query parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChangeEnterpriseTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ComponentstagList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ComponentstagList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ComponentstagList)));
        }

        /// <summary>
        /// Create User This endpoint creates a user profile within the specified enterprise.  It is the first of the 2-step process to create a BlueJeans user.  It should be followed by an API call to create the user&#39;s personal meeting room.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="enterpriseUser">Basic Enterprise Account information</param>
        /// <param name="billingCategory">What general billing group does this profile belong? (optional, default to ENTERPRISE)</param>
        /// <param name="forcePasswordChange">Create profile and force user to change password on next login (optional)</param>
        /// <param name="isAdmin">Create this account to have Administrative Privileges for the enterprise (optional)</param>
        /// <returns>UserId</returns>
        public UserId CreateEnterpriseUser (int? enterpriseId, EnterpriseCreateUser enterpriseUser, string billingCategory = null, bool? forcePasswordChange = null, bool? isAdmin = null)
        {
             ApiResponse<UserId> localVarResponse = CreateEnterpriseUserWithHttpInfo(enterpriseId, enterpriseUser, billingCategory, forcePasswordChange, isAdmin);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create User This endpoint creates a user profile within the specified enterprise.  It is the first of the 2-step process to create a BlueJeans user.  It should be followed by an API call to create the user&#39;s personal meeting room.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="enterpriseUser">Basic Enterprise Account information</param>
        /// <param name="billingCategory">What general billing group does this profile belong? (optional, default to ENTERPRISE)</param>
        /// <param name="forcePasswordChange">Create profile and force user to change password on next login (optional)</param>
        /// <param name="isAdmin">Create this account to have Administrative Privileges for the enterprise (optional)</param>
        /// <returns>ApiResponse of UserId</returns>
        public ApiResponse< UserId > CreateEnterpriseUserWithHttpInfo (int? enterpriseId, EnterpriseCreateUser enterpriseUser, string billingCategory = null, bool? forcePasswordChange = null, bool? isAdmin = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->CreateEnterpriseUser");
            // verify the required parameter 'enterpriseUser' is set
            if (enterpriseUser == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseUser' when calling EnterpriseApi->CreateEnterpriseUser");

            var localVarPath = "/v1/enterprise/{enterpriseId}/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterpriseId", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter
            if (billingCategory != null) localVarQueryParams.Add("billingCategory", Configuration.ApiClient.ParameterToString(billingCategory)); // query parameter
            if (forcePasswordChange != null) localVarQueryParams.Add("forcePasswordChange", Configuration.ApiClient.ParameterToString(forcePasswordChange)); // query parameter
            if (isAdmin != null) localVarQueryParams.Add("isAdmin", Configuration.ApiClient.ParameterToString(isAdmin)); // query parameter
            if (enterpriseUser != null && enterpriseUser.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(enterpriseUser); // http body (model) parameter
            }
            else
            {
                localVarPostBody = enterpriseUser; // byte array
            }

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateEnterpriseUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserId>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserId) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserId)));
        }

        /// <summary>
        /// Create User This endpoint creates a user profile within the specified enterprise.  It is the first of the 2-step process to create a BlueJeans user.  It should be followed by an API call to create the user&#39;s personal meeting room.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="enterpriseUser">Basic Enterprise Account information</param>
        /// <param name="billingCategory">What general billing group does this profile belong? (optional, default to ENTERPRISE)</param>
        /// <param name="forcePasswordChange">Create profile and force user to change password on next login (optional)</param>
        /// <param name="isAdmin">Create this account to have Administrative Privileges for the enterprise (optional)</param>
        /// <returns>Task of UserId</returns>
        public async System.Threading.Tasks.Task<UserId> CreateEnterpriseUserAsync (int? enterpriseId, EnterpriseCreateUser enterpriseUser, string billingCategory = null, bool? forcePasswordChange = null, bool? isAdmin = null)
        {
             ApiResponse<UserId> localVarResponse = await CreateEnterpriseUserAsyncWithHttpInfo(enterpriseId, enterpriseUser, billingCategory, forcePasswordChange, isAdmin);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create User This endpoint creates a user profile within the specified enterprise.  It is the first of the 2-step process to create a BlueJeans user.  It should be followed by an API call to create the user&#39;s personal meeting room.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="enterpriseUser">Basic Enterprise Account information</param>
        /// <param name="billingCategory">What general billing group does this profile belong? (optional, default to ENTERPRISE)</param>
        /// <param name="forcePasswordChange">Create profile and force user to change password on next login (optional)</param>
        /// <param name="isAdmin">Create this account to have Administrative Privileges for the enterprise (optional)</param>
        /// <returns>Task of ApiResponse (UserId)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserId>> CreateEnterpriseUserAsyncWithHttpInfo (int? enterpriseId, EnterpriseCreateUser enterpriseUser, string billingCategory = null, bool? forcePasswordChange = null, bool? isAdmin = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->CreateEnterpriseUser");
            // verify the required parameter 'enterpriseUser' is set
            if (enterpriseUser == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseUser' when calling EnterpriseApi->CreateEnterpriseUser");

            var localVarPath = "/v1/enterprise/{enterpriseId}/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterpriseId", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter
            if (billingCategory != null) localVarQueryParams.Add("billingCategory", Configuration.ApiClient.ParameterToString(billingCategory)); // query parameter
            if (forcePasswordChange != null) localVarQueryParams.Add("forcePasswordChange", Configuration.ApiClient.ParameterToString(forcePasswordChange)); // query parameter
            if (isAdmin != null) localVarQueryParams.Add("isAdmin", Configuration.ApiClient.ParameterToString(isAdmin)); // query parameter
            if (enterpriseUser != null && enterpriseUser.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(enterpriseUser); // http body (model) parameter
            }
            else
            {
                localVarPostBody = enterpriseUser; // byte array
            }

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateEnterpriseUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserId>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserId) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserId)));
        }

        /// <summary>
        /// Export Enterprise Users This endpoint exports existing users into a CSV file.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns></returns>
        public void ExportUsers (int? enterpriseId)
        {
             ExportUsersWithHttpInfo(enterpriseId);
        }

        /// <summary>
        /// Export Enterprise Users This endpoint exports existing users into a CSV file.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ExportUsersWithHttpInfo (int? enterpriseId)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->ExportUsers");

            var localVarPath = "/v1/enterprise/{enterprise_id}/users/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/csv"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterprise_id", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExportUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Export Enterprise Users This endpoint exports existing users into a CSV file.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ExportUsersAsync (int? enterpriseId)
        {
             await ExportUsersAsyncWithHttpInfo(enterpriseId);

        }

        /// <summary>
        /// Export Enterprise Users This endpoint exports existing users into a CSV file.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ExportUsersAsyncWithHttpInfo (int? enterpriseId)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->ExportUsers");

            var localVarPath = "/v1/enterprise/{enterprise_id}/users/export";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/csv"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterprise_id", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExportUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// List Enterprise Tags This endpoint retrieves all profile tags defined for the specified enterprise.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>ComponentstagList</returns>
        public ComponentstagList GetEnterpriseTags (int? enterpriseId)
        {
             ApiResponse<ComponentstagList> localVarResponse = GetEnterpriseTagsWithHttpInfo(enterpriseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Enterprise Tags This endpoint retrieves all profile tags defined for the specified enterprise.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>ApiResponse of ComponentstagList</returns>
        public ApiResponse< ComponentstagList > GetEnterpriseTagsWithHttpInfo (int? enterpriseId)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->GetEnterpriseTags");

            var localVarPath = "/v1/enterprise/{enterpriseId}/tags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterpriseId", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEnterpriseTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ComponentstagList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ComponentstagList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ComponentstagList)));
        }

        /// <summary>
        /// List Enterprise Tags This endpoint retrieves all profile tags defined for the specified enterprise.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of ComponentstagList</returns>
        public async System.Threading.Tasks.Task<ComponentstagList> GetEnterpriseTagsAsync (int? enterpriseId)
        {
             ApiResponse<ComponentstagList> localVarResponse = await GetEnterpriseTagsAsyncWithHttpInfo(enterpriseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Enterprise Tags This endpoint retrieves all profile tags defined for the specified enterprise.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of ApiResponse (ComponentstagList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ComponentstagList>> GetEnterpriseTagsAsyncWithHttpInfo (int? enterpriseId)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->GetEnterpriseTags");

            var localVarPath = "/v1/enterprise/{enterpriseId}/tags";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterpriseId", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEnterpriseTags", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ComponentstagList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ComponentstagList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ComponentstagList)));
        }

        /// <summary>
        /// Remove Enterprise User This endpoint allows removing a user from an enterprise; it does not delete the user. Requires enterprise admin access level.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns></returns>
        public void RemoveUser (int? enterpriseId, int? userId)
        {
             RemoveUserWithHttpInfo(enterpriseId, userId);
        }

        /// <summary>
        /// Remove Enterprise User This endpoint allows removing a user from an enterprise; it does not delete the user. Requires enterprise admin access level.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RemoveUserWithHttpInfo (int? enterpriseId, int? userId)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->RemoveUser");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling EnterpriseApi->RemoveUser");

            var localVarPath = "/v1/enterprise/{enterprise_id}/users/{user_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterprise_id", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter
            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemoveUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Remove Enterprise User This endpoint allows removing a user from an enterprise; it does not delete the user. Requires enterprise admin access level.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveUserAsync (int? enterpriseId, int? userId)
        {
             await RemoveUserAsyncWithHttpInfo(enterpriseId, userId);

        }

        /// <summary>
        /// Remove Enterprise User This endpoint allows removing a user from an enterprise; it does not delete the user. Requires enterprise admin access level.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RemoveUserAsyncWithHttpInfo (int? enterpriseId, int? userId)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->RemoveUser");
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling EnterpriseApi->RemoveUser");

            var localVarPath = "/v1/enterprise/{enterprise_id}/users/{user_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterprise_id", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter
            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RemoveUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Search for User(s) This endpoint provides a search facility for the specified enterprise.  &lt;ul&gt;&lt;li&gt;If textSearch is provided, the results will be a partial string-match search of the given textSearch value.&lt;/li&gt;&lt;li&gt; Otherwise, the search will return an exact lookup by emailId.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="fields">A comma-separated list one or more of these BlueJeans enteprise profile fields to include in the API responses- username, firstName, middleName, lastName, isEnterpriseAdmin, enterpriseJoinDate, email (optional)</param>
        /// <param name="order">If specificed, order defines how the API sorts results- ascending or descending (optional)</param>
        /// <param name="sortBy">Name of BlueJeans profile field by with API response data is sorted (optional)</param>
        /// <param name="textSearch">If specified textSearch provides a string (partial or complete) by which to search the list of BlueJeans users (optional)</param>
        /// <param name="emailId">If specified, emailId specifies performing a search for the user profile associated with this email address.  Wildcards are &lt;b&gt;not&lt;/b&gt; supported for the email address value. (optional)</param>
        /// <param name="pageSize">Sets number of items returned per page. (optional)</param>
        /// <param name="pageNumber">Selects which page of results to return (1-based value) (optional)</param>
        /// <returns>EnterpriseUserSearch</returns>
        public EnterpriseUserSearch SearchUsers (int? enterpriseId, string fields = null, string order = null, string sortBy = null, string textSearch = null, string emailId = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EnterpriseUserSearch> localVarResponse = SearchUsersWithHttpInfo(enterpriseId, fields, order, sortBy, textSearch, emailId, pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search for User(s) This endpoint provides a search facility for the specified enterprise.  &lt;ul&gt;&lt;li&gt;If textSearch is provided, the results will be a partial string-match search of the given textSearch value.&lt;/li&gt;&lt;li&gt; Otherwise, the search will return an exact lookup by emailId.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="fields">A comma-separated list one or more of these BlueJeans enteprise profile fields to include in the API responses- username, firstName, middleName, lastName, isEnterpriseAdmin, enterpriseJoinDate, email (optional)</param>
        /// <param name="order">If specificed, order defines how the API sorts results- ascending or descending (optional)</param>
        /// <param name="sortBy">Name of BlueJeans profile field by with API response data is sorted (optional)</param>
        /// <param name="textSearch">If specified textSearch provides a string (partial or complete) by which to search the list of BlueJeans users (optional)</param>
        /// <param name="emailId">If specified, emailId specifies performing a search for the user profile associated with this email address.  Wildcards are &lt;b&gt;not&lt;/b&gt; supported for the email address value. (optional)</param>
        /// <param name="pageSize">Sets number of items returned per page. (optional)</param>
        /// <param name="pageNumber">Selects which page of results to return (1-based value) (optional)</param>
        /// <returns>ApiResponse of EnterpriseUserSearch</returns>
        public ApiResponse< EnterpriseUserSearch > SearchUsersWithHttpInfo (int? enterpriseId, string fields = null, string order = null, string sortBy = null, string textSearch = null, string emailId = null, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->SearchUsers");

            var localVarPath = "/v1/enterprise/{enterpriseId}/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterpriseId", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter
            if (fields != null) localVarQueryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (textSearch != null) localVarQueryParams.Add("textSearch", Configuration.ApiClient.ParameterToString(textSearch)); // query parameter
            if (emailId != null) localVarQueryParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EnterpriseUserSearch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnterpriseUserSearch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnterpriseUserSearch)));
        }

        /// <summary>
        /// Search for User(s) This endpoint provides a search facility for the specified enterprise.  &lt;ul&gt;&lt;li&gt;If textSearch is provided, the results will be a partial string-match search of the given textSearch value.&lt;/li&gt;&lt;li&gt; Otherwise, the search will return an exact lookup by emailId.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="fields">A comma-separated list one or more of these BlueJeans enteprise profile fields to include in the API responses- username, firstName, middleName, lastName, isEnterpriseAdmin, enterpriseJoinDate, email (optional)</param>
        /// <param name="order">If specificed, order defines how the API sorts results- ascending or descending (optional)</param>
        /// <param name="sortBy">Name of BlueJeans profile field by with API response data is sorted (optional)</param>
        /// <param name="textSearch">If specified textSearch provides a string (partial or complete) by which to search the list of BlueJeans users (optional)</param>
        /// <param name="emailId">If specified, emailId specifies performing a search for the user profile associated with this email address.  Wildcards are &lt;b&gt;not&lt;/b&gt; supported for the email address value. (optional)</param>
        /// <param name="pageSize">Sets number of items returned per page. (optional)</param>
        /// <param name="pageNumber">Selects which page of results to return (1-based value) (optional)</param>
        /// <returns>Task of EnterpriseUserSearch</returns>
        public async System.Threading.Tasks.Task<EnterpriseUserSearch> SearchUsersAsync (int? enterpriseId, string fields = null, string order = null, string sortBy = null, string textSearch = null, string emailId = null, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EnterpriseUserSearch> localVarResponse = await SearchUsersAsyncWithHttpInfo(enterpriseId, fields, order, sortBy, textSearch, emailId, pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search for User(s) This endpoint provides a search facility for the specified enterprise.  &lt;ul&gt;&lt;li&gt;If textSearch is provided, the results will be a partial string-match search of the given textSearch value.&lt;/li&gt;&lt;li&gt; Otherwise, the search will return an exact lookup by emailId.&lt;/li&gt;&lt;/ul&gt;
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="fields">A comma-separated list one or more of these BlueJeans enteprise profile fields to include in the API responses- username, firstName, middleName, lastName, isEnterpriseAdmin, enterpriseJoinDate, email (optional)</param>
        /// <param name="order">If specificed, order defines how the API sorts results- ascending or descending (optional)</param>
        /// <param name="sortBy">Name of BlueJeans profile field by with API response data is sorted (optional)</param>
        /// <param name="textSearch">If specified textSearch provides a string (partial or complete) by which to search the list of BlueJeans users (optional)</param>
        /// <param name="emailId">If specified, emailId specifies performing a search for the user profile associated with this email address.  Wildcards are &lt;b&gt;not&lt;/b&gt; supported for the email address value. (optional)</param>
        /// <param name="pageSize">Sets number of items returned per page. (optional)</param>
        /// <param name="pageNumber">Selects which page of results to return (1-based value) (optional)</param>
        /// <returns>Task of ApiResponse (EnterpriseUserSearch)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnterpriseUserSearch>> SearchUsersAsyncWithHttpInfo (int? enterpriseId, string fields = null, string order = null, string sortBy = null, string textSearch = null, string emailId = null, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling EnterpriseApi->SearchUsers");

            var localVarPath = "/v1/enterprise/{enterpriseId}/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (enterpriseId != null) localVarPathParams.Add("enterpriseId", Configuration.ApiClient.ParameterToString(enterpriseId)); // path parameter
            if (fields != null) localVarQueryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (textSearch != null) localVarQueryParams.Add("textSearch", Configuration.ApiClient.ParameterToString(textSearch)); // query parameter
            if (emailId != null) localVarQueryParams.Add("emailId", Configuration.ApiClient.ParameterToString(emailId)); // query parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter

            // authentication (access_token) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("access_token")))
            {
                localVarQueryParams["access_token"] = Configuration.GetApiKeyWithPrefix("access_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EnterpriseUserSearch>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnterpriseUserSearch) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnterpriseUserSearch)));
        }

    }
}
