/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
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
    public interface ICommandCenterApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Endpoint Distribution
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;}])</param>
        /// <returns>AnalyticsEndpointDistribution</returns>
        AnalyticsEndpointDistribution GetEndpointDistribution (int? enterpriseId, string filter = null);

        /// <summary>
        /// Endpoint Distribution
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;}])</param>
        /// <returns>ApiResponse of AnalyticsEndpointDistribution</returns>
        ApiResponse<AnalyticsEndpointDistribution> GetEndpointDistributionWithHttpInfo (int? enterpriseId, string filter = null);
        /// <summary>
        /// Survey Feedback Comments
        /// </summary>
        /// <remarks>
        /// This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>AnalyticsFeedbackComments</returns>
        AnalyticsFeedbackComments GetFeedbackComments (int? enterpriseId, string start, string end);

        /// <summary>
        /// Survey Feedback Comments
        /// </summary>
        /// <remarks>
        /// This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>ApiResponse of AnalyticsFeedbackComments</returns>
        ApiResponse<AnalyticsFeedbackComments> GetFeedbackCommentsWithHttpInfo (int? enterpriseId, string start, string end);
        /// <summary>
        /// Survey Feedback Scores
        /// </summary>
        /// <remarks>
        /// This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>AnalyticsFeedbackScores</returns>
        AnalyticsFeedbackScores GetFeedbackCount (int? enterpriseId, string start, string end);

        /// <summary>
        /// Survey Feedback Scores
        /// </summary>
        /// <remarks>
        /// This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>ApiResponse of AnalyticsFeedbackScores</returns>
        ApiResponse<AnalyticsFeedbackScores> GetFeedbackCountWithHttpInfo (int? enterpriseId, string start, string end);
        /// <summary>
        /// List Live Meeting Endpoints by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>MeetingExtendedIndigo</returns>
        MeetingExtendedIndigo GetMeetingLiveByEnterprise (int? enterpriseId, string meetingUuid);

        /// <summary>
        /// List Live Meeting Endpoints by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>ApiResponse of MeetingExtendedIndigo</returns>
        ApiResponse<MeetingExtendedIndigo> GetMeetingLiveByEnterpriseWithHttpInfo (int? enterpriseId, string meetingUuid);
        /// <summary>
        /// List Meeting Endpoints &amp; Stats by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <param name="includeEndpoints">Option to include detailed data on endpoints (optional)</param>
        /// <returns>MeetingExtendedIndigo</returns>
        MeetingExtendedIndigo GetMeetingPastByEnterprise (int? enterpriseId, string meetingUuid, bool? includeEndpoints = null);

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <param name="includeEndpoints">Option to include detailed data on endpoints (optional)</param>
        /// <returns>ApiResponse of MeetingExtendedIndigo</returns>
        ApiResponse<MeetingExtendedIndigo> GetMeetingPastByEnterpriseWithHttpInfo (int? enterpriseId, string meetingUuid, bool? includeEndpoints = null);
        /// <summary>
        /// List Meeting Endpoints &amp; Stats by User
        /// </summary>
        /// <remarks>
        /// This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>MeetingExtendedIndigo</returns>
        MeetingExtendedIndigo GetMeetingPastByUser (int? userId, string meetingUuid);

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by User
        /// </summary>
        /// <remarks>
        /// This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>ApiResponse of MeetingExtendedIndigo</returns>
        ApiResponse<MeetingExtendedIndigo> GetMeetingPastByUserWithHttpInfo (int? userId, string meetingUuid);
        /// <summary>
        /// Meeting Usage Over Time
        /// </summary>
        /// <remarks>
        /// This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="clientTZ">Based on standard TZ code. (optional, default to America/Denver)</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;string&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;DAY&quot;,&quot;field&quot;:&quot;groupInterval&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;lowts&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;hights&quot;}])</param>
        /// <returns>AnalyticsUsage</returns>
        AnalyticsUsage GetMeetingUsage (int? enterpriseId, string clientTZ = null, string filter = null);

        /// <summary>
        /// Meeting Usage Over Time
        /// </summary>
        /// <remarks>
        /// This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="clientTZ">Based on standard TZ code. (optional, default to America/Denver)</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;string&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;DAY&quot;,&quot;field&quot;:&quot;groupInterval&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;lowts&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;hights&quot;}])</param>
        /// <returns>ApiResponse of AnalyticsUsage</returns>
        ApiResponse<AnalyticsUsage> GetMeetingUsageWithHttpInfo (int? enterpriseId, string clientTZ = null, string filter = null);
        /// <summary>
        /// Live Meetings Summary by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>MeetingIndigoList</returns>
        MeetingIndigoList GetMeetingsLiveByEnterprise (int? enterpriseId);

        /// <summary>
        /// Live Meetings Summary by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>ApiResponse of MeetingIndigoList</returns>
        ApiResponse<MeetingIndigoList> GetMeetingsLiveByEnterpriseWithHttpInfo (int? enterpriseId);
        /// <summary>
        /// List Past Meetings by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="offset">Page Number (optional)</param>
        /// <param name="limit">Per page (optional)</param>
        /// <param name="filter">URL-encoded JSON string (optional)</param>
        /// <returns>MeetingIndigoList</returns>
        MeetingIndigoList GetMeetingsPastByEnterprise (int? enterpriseId, int? offset = null, int? limit = null, string filter = null);

        /// <summary>
        /// List Past Meetings by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="offset">Page Number (optional)</param>
        /// <param name="limit">Per page (optional)</param>
        /// <param name="filter">URL-encoded JSON string (optional)</param>
        /// <returns>ApiResponse of MeetingIndigoList</returns>
        ApiResponse<MeetingIndigoList> GetMeetingsPastByEnterpriseWithHttpInfo (int? enterpriseId, int? offset = null, int? limit = null, string filter = null);
        /// <summary>
        /// List Past Meetings by User
        /// </summary>
        /// <remarks>
        /// This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>MeetingIndigoList</returns>
        MeetingIndigoList GetMeetingsPastByUser (int? userId);

        /// <summary>
        /// List Past Meetings by User
        /// </summary>
        /// <remarks>
        /// This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>ApiResponse of MeetingIndigoList</returns>
        ApiResponse<MeetingIndigoList> GetMeetingsPastByUserWithHttpInfo (int? userId);
        /// <summary>
        /// ROI Data
        /// </summary>
        /// <remarks>
        /// This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string</param>
        /// <returns>AnalyticsRoiData</returns>
        AnalyticsRoiData GetRoiRanges (int? enterpriseId, string filter);

        /// <summary>
        /// ROI Data
        /// </summary>
        /// <remarks>
        /// This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string</param>
        /// <returns>ApiResponse of AnalyticsRoiData</returns>
        ApiResponse<AnalyticsRoiData> GetRoiRangesWithHttpInfo (int? enterpriseId, string filter);
        /// <summary>
        /// Top Users
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;start_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;end_time&quot;}])</param>
        /// <returns>AnalyticsTopUsers</returns>
        AnalyticsTopUsers GetTopUsers (int? enterpriseId, string filter = null);

        /// <summary>
        /// Top Users
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;start_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;end_time&quot;}])</param>
        /// <returns>ApiResponse of AnalyticsTopUsers</returns>
        ApiResponse<AnalyticsTopUsers> GetTopUsersWithHttpInfo (int? enterpriseId, string filter = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Endpoint Distribution
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;}])</param>
        /// <returns>Task of AnalyticsEndpointDistribution</returns>
        System.Threading.Tasks.Task<AnalyticsEndpointDistribution> GetEndpointDistributionAsync (int? enterpriseId, string filter = null);

        /// <summary>
        /// Endpoint Distribution
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;}])</param>
        /// <returns>Task of ApiResponse (AnalyticsEndpointDistribution)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsEndpointDistribution>> GetEndpointDistributionAsyncWithHttpInfo (int? enterpriseId, string filter = null);
        /// <summary>
        /// Survey Feedback Comments
        /// </summary>
        /// <remarks>
        /// This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>Task of AnalyticsFeedbackComments</returns>
        System.Threading.Tasks.Task<AnalyticsFeedbackComments> GetFeedbackCommentsAsync (int? enterpriseId, string start, string end);

        /// <summary>
        /// Survey Feedback Comments
        /// </summary>
        /// <remarks>
        /// This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>Task of ApiResponse (AnalyticsFeedbackComments)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsFeedbackComments>> GetFeedbackCommentsAsyncWithHttpInfo (int? enterpriseId, string start, string end);
        /// <summary>
        /// Survey Feedback Scores
        /// </summary>
        /// <remarks>
        /// This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>Task of AnalyticsFeedbackScores</returns>
        System.Threading.Tasks.Task<AnalyticsFeedbackScores> GetFeedbackCountAsync (int? enterpriseId, string start, string end);

        /// <summary>
        /// Survey Feedback Scores
        /// </summary>
        /// <remarks>
        /// This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>Task of ApiResponse (AnalyticsFeedbackScores)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsFeedbackScores>> GetFeedbackCountAsyncWithHttpInfo (int? enterpriseId, string start, string end);
        /// <summary>
        /// List Live Meeting Endpoints by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>Task of MeetingExtendedIndigo</returns>
        System.Threading.Tasks.Task<MeetingExtendedIndigo> GetMeetingLiveByEnterpriseAsync (int? enterpriseId, string meetingUuid);

        /// <summary>
        /// List Live Meeting Endpoints by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>Task of ApiResponse (MeetingExtendedIndigo)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeetingExtendedIndigo>> GetMeetingLiveByEnterpriseAsyncWithHttpInfo (int? enterpriseId, string meetingUuid);
        /// <summary>
        /// List Meeting Endpoints &amp; Stats by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <param name="includeEndpoints">Option to include detailed data on endpoints (optional)</param>
        /// <returns>Task of MeetingExtendedIndigo</returns>
        System.Threading.Tasks.Task<MeetingExtendedIndigo> GetMeetingPastByEnterpriseAsync (int? enterpriseId, string meetingUuid, bool? includeEndpoints = null);

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <param name="includeEndpoints">Option to include detailed data on endpoints (optional)</param>
        /// <returns>Task of ApiResponse (MeetingExtendedIndigo)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeetingExtendedIndigo>> GetMeetingPastByEnterpriseAsyncWithHttpInfo (int? enterpriseId, string meetingUuid, bool? includeEndpoints = null);
        /// <summary>
        /// List Meeting Endpoints &amp; Stats by User
        /// </summary>
        /// <remarks>
        /// This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>Task of MeetingExtendedIndigo</returns>
        System.Threading.Tasks.Task<MeetingExtendedIndigo> GetMeetingPastByUserAsync (int? userId, string meetingUuid);

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by User
        /// </summary>
        /// <remarks>
        /// This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>Task of ApiResponse (MeetingExtendedIndigo)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeetingExtendedIndigo>> GetMeetingPastByUserAsyncWithHttpInfo (int? userId, string meetingUuid);
        /// <summary>
        /// Meeting Usage Over Time
        /// </summary>
        /// <remarks>
        /// This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="clientTZ">Based on standard TZ code. (optional, default to America/Denver)</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;string&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;DAY&quot;,&quot;field&quot;:&quot;groupInterval&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;lowts&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;hights&quot;}])</param>
        /// <returns>Task of AnalyticsUsage</returns>
        System.Threading.Tasks.Task<AnalyticsUsage> GetMeetingUsageAsync (int? enterpriseId, string clientTZ = null, string filter = null);

        /// <summary>
        /// Meeting Usage Over Time
        /// </summary>
        /// <remarks>
        /// This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="clientTZ">Based on standard TZ code. (optional, default to America/Denver)</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;string&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;DAY&quot;,&quot;field&quot;:&quot;groupInterval&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;lowts&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;hights&quot;}])</param>
        /// <returns>Task of ApiResponse (AnalyticsUsage)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsUsage>> GetMeetingUsageAsyncWithHttpInfo (int? enterpriseId, string clientTZ = null, string filter = null);
        /// <summary>
        /// Live Meetings Summary by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of MeetingIndigoList</returns>
        System.Threading.Tasks.Task<MeetingIndigoList> GetMeetingsLiveByEnterpriseAsync (int? enterpriseId);

        /// <summary>
        /// Live Meetings Summary by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of ApiResponse (MeetingIndigoList)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeetingIndigoList>> GetMeetingsLiveByEnterpriseAsyncWithHttpInfo (int? enterpriseId);
        /// <summary>
        /// List Past Meetings by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="offset">Page Number (optional)</param>
        /// <param name="limit">Per page (optional)</param>
        /// <param name="filter">URL-encoded JSON string (optional)</param>
        /// <returns>Task of MeetingIndigoList</returns>
        System.Threading.Tasks.Task<MeetingIndigoList> GetMeetingsPastByEnterpriseAsync (int? enterpriseId, int? offset = null, int? limit = null, string filter = null);

        /// <summary>
        /// List Past Meetings by Enterprise
        /// </summary>
        /// <remarks>
        /// This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="offset">Page Number (optional)</param>
        /// <param name="limit">Per page (optional)</param>
        /// <param name="filter">URL-encoded JSON string (optional)</param>
        /// <returns>Task of ApiResponse (MeetingIndigoList)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeetingIndigoList>> GetMeetingsPastByEnterpriseAsyncWithHttpInfo (int? enterpriseId, int? offset = null, int? limit = null, string filter = null);
        /// <summary>
        /// List Past Meetings by User
        /// </summary>
        /// <remarks>
        /// This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of MeetingIndigoList</returns>
        System.Threading.Tasks.Task<MeetingIndigoList> GetMeetingsPastByUserAsync (int? userId);

        /// <summary>
        /// List Past Meetings by User
        /// </summary>
        /// <remarks>
        /// This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of ApiResponse (MeetingIndigoList)</returns>
        System.Threading.Tasks.Task<ApiResponse<MeetingIndigoList>> GetMeetingsPastByUserAsyncWithHttpInfo (int? userId);
        /// <summary>
        /// ROI Data
        /// </summary>
        /// <remarks>
        /// This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string</param>
        /// <returns>Task of AnalyticsRoiData</returns>
        System.Threading.Tasks.Task<AnalyticsRoiData> GetRoiRangesAsync (int? enterpriseId, string filter);

        /// <summary>
        /// ROI Data
        /// </summary>
        /// <remarks>
        /// This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string</param>
        /// <returns>Task of ApiResponse (AnalyticsRoiData)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsRoiData>> GetRoiRangesAsyncWithHttpInfo (int? enterpriseId, string filter);
        /// <summary>
        /// Top Users
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;start_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;end_time&quot;}])</param>
        /// <returns>Task of AnalyticsTopUsers</returns>
        System.Threading.Tasks.Task<AnalyticsTopUsers> GetTopUsersAsync (int? enterpriseId, string filter = null);

        /// <summary>
        /// Top Users
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;start_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;end_time&quot;}])</param>
        /// <returns>Task of ApiResponse (AnalyticsTopUsers)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnalyticsTopUsers>> GetTopUsersAsyncWithHttpInfo (int? enterpriseId, string filter = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CommandCenterApi : ICommandCenterApi
    {
        private com.bluejeans.api.rest.meetings.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandCenterApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CommandCenterApi(String basePath)
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
        /// Initializes a new instance of the <see cref="CommandCenterApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CommandCenterApi(Configuration configuration = null)
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
        /// Endpoint Distribution This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;}])</param>
        /// <returns>AnalyticsEndpointDistribution</returns>
        public AnalyticsEndpointDistribution GetEndpointDistribution (int? enterpriseId, string filter = null)
        {
             ApiResponse<AnalyticsEndpointDistribution> localVarResponse = GetEndpointDistributionWithHttpInfo(enterpriseId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Endpoint Distribution This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;}])</param>
        /// <returns>ApiResponse of AnalyticsEndpointDistribution</returns>
        public ApiResponse< AnalyticsEndpointDistribution > GetEndpointDistributionWithHttpInfo (int? enterpriseId, string filter = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetEndpointDistribution");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/endpoints/distribution";
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
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("GetEndpointDistribution", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsEndpointDistribution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsEndpointDistribution) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsEndpointDistribution)));
        }

        /// <summary>
        /// Endpoint Distribution This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;}])</param>
        /// <returns>Task of AnalyticsEndpointDistribution</returns>
        public async System.Threading.Tasks.Task<AnalyticsEndpointDistribution> GetEndpointDistributionAsync (int? enterpriseId, string filter = null)
        {
             ApiResponse<AnalyticsEndpointDistribution> localVarResponse = await GetEndpointDistributionAsyncWithHttpInfo(enterpriseId, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Endpoint Distribution This endpoint retrieves endpoint connection type distribution by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;creation_time&quot;}])</param>
        /// <returns>Task of ApiResponse (AnalyticsEndpointDistribution)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsEndpointDistribution>> GetEndpointDistributionAsyncWithHttpInfo (int? enterpriseId, string filter = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetEndpointDistribution");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/endpoints/distribution";
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
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("GetEndpointDistribution", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsEndpointDistribution>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsEndpointDistribution) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsEndpointDistribution)));
        }

        /// <summary>
        /// Survey Feedback Comments This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>AnalyticsFeedbackComments</returns>
        public AnalyticsFeedbackComments GetFeedbackComments (int? enterpriseId, string start, string end)
        {
             ApiResponse<AnalyticsFeedbackComments> localVarResponse = GetFeedbackCommentsWithHttpInfo(enterpriseId, start, end);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Survey Feedback Comments This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>ApiResponse of AnalyticsFeedbackComments</returns>
        public ApiResponse< AnalyticsFeedbackComments > GetFeedbackCommentsWithHttpInfo (int? enterpriseId, string start, string end)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetFeedbackComments");
            // verify the required parameter 'start' is set
            if (start == null)
                throw new ApiException(400, "Missing required parameter 'start' when calling CommandCenterApi->GetFeedbackComments");
            // verify the required parameter 'end' is set
            if (end == null)
                throw new ApiException(400, "Missing required parameter 'end' when calling CommandCenterApi->GetFeedbackComments");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/feedback/comments";
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
            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (end != null) localVarQueryParams.Add("end", Configuration.ApiClient.ParameterToString(end)); // query parameter

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
                Exception exception = ExceptionFactory("GetFeedbackComments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsFeedbackComments>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsFeedbackComments) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsFeedbackComments)));
        }

        /// <summary>
        /// Survey Feedback Comments This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>Task of AnalyticsFeedbackComments</returns>
        public async System.Threading.Tasks.Task<AnalyticsFeedbackComments> GetFeedbackCommentsAsync (int? enterpriseId, string start, string end)
        {
             ApiResponse<AnalyticsFeedbackComments> localVarResponse = await GetFeedbackCommentsAsyncWithHttpInfo(enterpriseId, start, end);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Survey Feedback Comments This endpoint lists end of meeting survey comments by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>Task of ApiResponse (AnalyticsFeedbackComments)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsFeedbackComments>> GetFeedbackCommentsAsyncWithHttpInfo (int? enterpriseId, string start, string end)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetFeedbackComments");
            // verify the required parameter 'start' is set
            if (start == null)
                throw new ApiException(400, "Missing required parameter 'start' when calling CommandCenterApi->GetFeedbackComments");
            // verify the required parameter 'end' is set
            if (end == null)
                throw new ApiException(400, "Missing required parameter 'end' when calling CommandCenterApi->GetFeedbackComments");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/feedback/comments";
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
            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (end != null) localVarQueryParams.Add("end", Configuration.ApiClient.ParameterToString(end)); // query parameter

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
                Exception exception = ExceptionFactory("GetFeedbackComments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsFeedbackComments>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsFeedbackComments) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsFeedbackComments)));
        }

        /// <summary>
        /// Survey Feedback Scores This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>AnalyticsFeedbackScores</returns>
        public AnalyticsFeedbackScores GetFeedbackCount (int? enterpriseId, string start, string end)
        {
             ApiResponse<AnalyticsFeedbackScores> localVarResponse = GetFeedbackCountWithHttpInfo(enterpriseId, start, end);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Survey Feedback Scores This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>ApiResponse of AnalyticsFeedbackScores</returns>
        public ApiResponse< AnalyticsFeedbackScores > GetFeedbackCountWithHttpInfo (int? enterpriseId, string start, string end)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetFeedbackCount");
            // verify the required parameter 'start' is set
            if (start == null)
                throw new ApiException(400, "Missing required parameter 'start' when calling CommandCenterApi->GetFeedbackCount");
            // verify the required parameter 'end' is set
            if (end == null)
                throw new ApiException(400, "Missing required parameter 'end' when calling CommandCenterApi->GetFeedbackCount");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/feedback/count";
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
            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (end != null) localVarQueryParams.Add("end", Configuration.ApiClient.ParameterToString(end)); // query parameter

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
                Exception exception = ExceptionFactory("GetFeedbackCount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsFeedbackScores>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsFeedbackScores) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsFeedbackScores)));
        }

        /// <summary>
        /// Survey Feedback Scores This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>Task of AnalyticsFeedbackScores</returns>
        public async System.Threading.Tasks.Task<AnalyticsFeedbackScores> GetFeedbackCountAsync (int? enterpriseId, string start, string end)
        {
             ApiResponse<AnalyticsFeedbackScores> localVarResponse = await GetFeedbackCountAsyncWithHttpInfo(enterpriseId, start, end);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Survey Feedback Scores This endpoint lists end of meeting survey scores by enterprise by time period. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="start">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <param name="end">Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format.</param>
        /// <returns>Task of ApiResponse (AnalyticsFeedbackScores)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsFeedbackScores>> GetFeedbackCountAsyncWithHttpInfo (int? enterpriseId, string start, string end)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetFeedbackCount");
            // verify the required parameter 'start' is set
            if (start == null)
                throw new ApiException(400, "Missing required parameter 'start' when calling CommandCenterApi->GetFeedbackCount");
            // verify the required parameter 'end' is set
            if (end == null)
                throw new ApiException(400, "Missing required parameter 'end' when calling CommandCenterApi->GetFeedbackCount");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/feedback/count";
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
            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (end != null) localVarQueryParams.Add("end", Configuration.ApiClient.ParameterToString(end)); // query parameter

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
                Exception exception = ExceptionFactory("GetFeedbackCount", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsFeedbackScores>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsFeedbackScores) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsFeedbackScores)));
        }

        /// <summary>
        /// List Live Meeting Endpoints by Enterprise This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>MeetingExtendedIndigo</returns>
        public MeetingExtendedIndigo GetMeetingLiveByEnterprise (int? enterpriseId, string meetingUuid)
        {
             ApiResponse<MeetingExtendedIndigo> localVarResponse = GetMeetingLiveByEnterpriseWithHttpInfo(enterpriseId, meetingUuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Live Meeting Endpoints by Enterprise This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>ApiResponse of MeetingExtendedIndigo</returns>
        public ApiResponse< MeetingExtendedIndigo > GetMeetingLiveByEnterpriseWithHttpInfo (int? enterpriseId, string meetingUuid)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetMeetingLiveByEnterprise");
            // verify the required parameter 'meetingUuid' is set
            if (meetingUuid == null)
                throw new ApiException(400, "Missing required parameter 'meetingUuid' when calling CommandCenterApi->GetMeetingLiveByEnterprise");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings/live/{meeting_uuid}/endpoints/";
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
            if (meetingUuid != null) localVarPathParams.Add("meeting_uuid", Configuration.ApiClient.ParameterToString(meetingUuid)); // path parameter

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
                Exception exception = ExceptionFactory("GetMeetingLiveByEnterprise", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingExtendedIndigo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingExtendedIndigo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingExtendedIndigo)));
        }

        /// <summary>
        /// List Live Meeting Endpoints by Enterprise This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>Task of MeetingExtendedIndigo</returns>
        public async System.Threading.Tasks.Task<MeetingExtendedIndigo> GetMeetingLiveByEnterpriseAsync (int? enterpriseId, string meetingUuid)
        {
             ApiResponse<MeetingExtendedIndigo> localVarResponse = await GetMeetingLiveByEnterpriseAsyncWithHttpInfo(enterpriseId, meetingUuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Live Meeting Endpoints by Enterprise This endpoint lists endpoints for a given meeting in progress. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>Task of ApiResponse (MeetingExtendedIndigo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeetingExtendedIndigo>> GetMeetingLiveByEnterpriseAsyncWithHttpInfo (int? enterpriseId, string meetingUuid)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetMeetingLiveByEnterprise");
            // verify the required parameter 'meetingUuid' is set
            if (meetingUuid == null)
                throw new ApiException(400, "Missing required parameter 'meetingUuid' when calling CommandCenterApi->GetMeetingLiveByEnterprise");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings/live/{meeting_uuid}/endpoints/";
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
            if (meetingUuid != null) localVarPathParams.Add("meeting_uuid", Configuration.ApiClient.ParameterToString(meetingUuid)); // path parameter

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
                Exception exception = ExceptionFactory("GetMeetingLiveByEnterprise", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingExtendedIndigo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingExtendedIndigo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingExtendedIndigo)));
        }

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by Enterprise This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <param name="includeEndpoints">Option to include detailed data on endpoints (optional)</param>
        /// <returns>MeetingExtendedIndigo</returns>
        public MeetingExtendedIndigo GetMeetingPastByEnterprise (int? enterpriseId, string meetingUuid, bool? includeEndpoints = null)
        {
             ApiResponse<MeetingExtendedIndigo> localVarResponse = GetMeetingPastByEnterpriseWithHttpInfo(enterpriseId, meetingUuid, includeEndpoints);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by Enterprise This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <param name="includeEndpoints">Option to include detailed data on endpoints (optional)</param>
        /// <returns>ApiResponse of MeetingExtendedIndigo</returns>
        public ApiResponse< MeetingExtendedIndigo > GetMeetingPastByEnterpriseWithHttpInfo (int? enterpriseId, string meetingUuid, bool? includeEndpoints = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetMeetingPastByEnterprise");
            // verify the required parameter 'meetingUuid' is set
            if (meetingUuid == null)
                throw new ApiException(400, "Missing required parameter 'meetingUuid' when calling CommandCenterApi->GetMeetingPastByEnterprise");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings/{meeting_uuid}";
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
            if (meetingUuid != null) localVarPathParams.Add("meeting_uuid", Configuration.ApiClient.ParameterToString(meetingUuid)); // path parameter
            if (includeEndpoints != null) localVarQueryParams.Add("includeEndpoints", Configuration.ApiClient.ParameterToString(includeEndpoints)); // query parameter

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
                Exception exception = ExceptionFactory("GetMeetingPastByEnterprise", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingExtendedIndigo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingExtendedIndigo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingExtendedIndigo)));
        }

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by Enterprise This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <param name="includeEndpoints">Option to include detailed data on endpoints (optional)</param>
        /// <returns>Task of MeetingExtendedIndigo</returns>
        public async System.Threading.Tasks.Task<MeetingExtendedIndigo> GetMeetingPastByEnterpriseAsync (int? enterpriseId, string meetingUuid, bool? includeEndpoints = null)
        {
             ApiResponse<MeetingExtendedIndigo> localVarResponse = await GetMeetingPastByEnterpriseAsyncWithHttpInfo(enterpriseId, meetingUuid, includeEndpoints);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by Enterprise This endpoint lists meeting endpoints for completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <param name="includeEndpoints">Option to include detailed data on endpoints (optional)</param>
        /// <returns>Task of ApiResponse (MeetingExtendedIndigo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeetingExtendedIndigo>> GetMeetingPastByEnterpriseAsyncWithHttpInfo (int? enterpriseId, string meetingUuid, bool? includeEndpoints = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetMeetingPastByEnterprise");
            // verify the required parameter 'meetingUuid' is set
            if (meetingUuid == null)
                throw new ApiException(400, "Missing required parameter 'meetingUuid' when calling CommandCenterApi->GetMeetingPastByEnterprise");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings/{meeting_uuid}";
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
            if (meetingUuid != null) localVarPathParams.Add("meeting_uuid", Configuration.ApiClient.ParameterToString(meetingUuid)); // path parameter
            if (includeEndpoints != null) localVarQueryParams.Add("includeEndpoints", Configuration.ApiClient.ParameterToString(includeEndpoints)); // query parameter

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
                Exception exception = ExceptionFactory("GetMeetingPastByEnterprise", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingExtendedIndigo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingExtendedIndigo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingExtendedIndigo)));
        }

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by User This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>MeetingExtendedIndigo</returns>
        public MeetingExtendedIndigo GetMeetingPastByUser (int? userId, string meetingUuid)
        {
             ApiResponse<MeetingExtendedIndigo> localVarResponse = GetMeetingPastByUserWithHttpInfo(userId, meetingUuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by User This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>ApiResponse of MeetingExtendedIndigo</returns>
        public ApiResponse< MeetingExtendedIndigo > GetMeetingPastByUserWithHttpInfo (int? userId, string meetingUuid)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CommandCenterApi->GetMeetingPastByUser");
            // verify the required parameter 'meetingUuid' is set
            if (meetingUuid == null)
                throw new ApiException(400, "Missing required parameter 'meetingUuid' when calling CommandCenterApi->GetMeetingPastByUser");

            var localVarPath = "/v1/user/{user_id}/indigo/meetings/{meeting_uuid}";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (meetingUuid != null) localVarPathParams.Add("meeting_uuid", Configuration.ApiClient.ParameterToString(meetingUuid)); // path parameter

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
                Exception exception = ExceptionFactory("GetMeetingPastByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingExtendedIndigo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingExtendedIndigo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingExtendedIndigo)));
        }

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by User This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>Task of MeetingExtendedIndigo</returns>
        public async System.Threading.Tasks.Task<MeetingExtendedIndigo> GetMeetingPastByUserAsync (int? userId, string meetingUuid)
        {
             ApiResponse<MeetingExtendedIndigo> localVarResponse = await GetMeetingPastByUserAsyncWithHttpInfo(userId, meetingUuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Meeting Endpoints &amp; Stats by User This endpoint lists meeting endpoints for completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingUuid">The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes.</param>
        /// <returns>Task of ApiResponse (MeetingExtendedIndigo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeetingExtendedIndigo>> GetMeetingPastByUserAsyncWithHttpInfo (int? userId, string meetingUuid)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CommandCenterApi->GetMeetingPastByUser");
            // verify the required parameter 'meetingUuid' is set
            if (meetingUuid == null)
                throw new ApiException(400, "Missing required parameter 'meetingUuid' when calling CommandCenterApi->GetMeetingPastByUser");

            var localVarPath = "/v1/user/{user_id}/indigo/meetings/{meeting_uuid}";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter
            if (meetingUuid != null) localVarPathParams.Add("meeting_uuid", Configuration.ApiClient.ParameterToString(meetingUuid)); // path parameter

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
                Exception exception = ExceptionFactory("GetMeetingPastByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingExtendedIndigo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingExtendedIndigo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingExtendedIndigo)));
        }

        /// <summary>
        /// Meeting Usage Over Time This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="clientTZ">Based on standard TZ code. (optional, default to America/Denver)</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;string&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;DAY&quot;,&quot;field&quot;:&quot;groupInterval&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;lowts&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;hights&quot;}])</param>
        /// <returns>AnalyticsUsage</returns>
        public AnalyticsUsage GetMeetingUsage (int? enterpriseId, string clientTZ = null, string filter = null)
        {
             ApiResponse<AnalyticsUsage> localVarResponse = GetMeetingUsageWithHttpInfo(enterpriseId, clientTZ, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Meeting Usage Over Time This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="clientTZ">Based on standard TZ code. (optional, default to America/Denver)</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;string&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;DAY&quot;,&quot;field&quot;:&quot;groupInterval&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;lowts&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;hights&quot;}])</param>
        /// <returns>ApiResponse of AnalyticsUsage</returns>
        public ApiResponse< AnalyticsUsage > GetMeetingUsageWithHttpInfo (int? enterpriseId, string clientTZ = null, string filter = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetMeetingUsage");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/meetings/usage";
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
            if (clientTZ != null) localVarQueryParams.Add("clientTZ", Configuration.ApiClient.ParameterToString(clientTZ)); // query parameter
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("GetMeetingUsage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsUsage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsUsage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsUsage)));
        }

        /// <summary>
        /// Meeting Usage Over Time This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="clientTZ">Based on standard TZ code. (optional, default to America/Denver)</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;string&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;DAY&quot;,&quot;field&quot;:&quot;groupInterval&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;lowts&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;hights&quot;}])</param>
        /// <returns>Task of AnalyticsUsage</returns>
        public async System.Threading.Tasks.Task<AnalyticsUsage> GetMeetingUsageAsync (int? enterpriseId, string clientTZ = null, string filter = null)
        {
             ApiResponse<AnalyticsUsage> localVarResponse = await GetMeetingUsageAsyncWithHttpInfo(enterpriseId, clientTZ, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Meeting Usage Over Time This endpoint reports on meeting usage. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="clientTZ">Based on standard TZ code. (optional, default to America/Denver)</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;string&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;DAY&quot;,&quot;field&quot;:&quot;groupInterval&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;lowts&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;hights&quot;}])</param>
        /// <returns>Task of ApiResponse (AnalyticsUsage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsUsage>> GetMeetingUsageAsyncWithHttpInfo (int? enterpriseId, string clientTZ = null, string filter = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetMeetingUsage");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/meetings/usage";
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
            if (clientTZ != null) localVarQueryParams.Add("clientTZ", Configuration.ApiClient.ParameterToString(clientTZ)); // query parameter
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("GetMeetingUsage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsUsage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsUsage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsUsage)));
        }

        /// <summary>
        /// Live Meetings Summary by Enterprise This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>MeetingIndigoList</returns>
        public MeetingIndigoList GetMeetingsLiveByEnterprise (int? enterpriseId)
        {
             ApiResponse<MeetingIndigoList> localVarResponse = GetMeetingsLiveByEnterpriseWithHttpInfo(enterpriseId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Live Meetings Summary by Enterprise This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>ApiResponse of MeetingIndigoList</returns>
        public ApiResponse< MeetingIndigoList > GetMeetingsLiveByEnterpriseWithHttpInfo (int? enterpriseId)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetMeetingsLiveByEnterprise");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings/live";
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
                Exception exception = ExceptionFactory("GetMeetingsLiveByEnterprise", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingIndigoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingIndigoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingIndigoList)));
        }

        /// <summary>
        /// Live Meetings Summary by Enterprise This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of MeetingIndigoList</returns>
        public async System.Threading.Tasks.Task<MeetingIndigoList> GetMeetingsLiveByEnterpriseAsync (int? enterpriseId)
        {
             ApiResponse<MeetingIndigoList> localVarResponse = await GetMeetingsLiveByEnterpriseAsyncWithHttpInfo(enterpriseId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Live Meetings Summary by Enterprise This endpoint lists meetings in progress by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <returns>Task of ApiResponse (MeetingIndigoList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeetingIndigoList>> GetMeetingsLiveByEnterpriseAsyncWithHttpInfo (int? enterpriseId)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetMeetingsLiveByEnterprise");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings/live";
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
                Exception exception = ExceptionFactory("GetMeetingsLiveByEnterprise", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingIndigoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingIndigoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingIndigoList)));
        }

        /// <summary>
        /// List Past Meetings by Enterprise This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="offset">Page Number (optional)</param>
        /// <param name="limit">Per page (optional)</param>
        /// <param name="filter">URL-encoded JSON string (optional)</param>
        /// <returns>MeetingIndigoList</returns>
        public MeetingIndigoList GetMeetingsPastByEnterprise (int? enterpriseId, int? offset = null, int? limit = null, string filter = null)
        {
             ApiResponse<MeetingIndigoList> localVarResponse = GetMeetingsPastByEnterpriseWithHttpInfo(enterpriseId, offset, limit, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Past Meetings by Enterprise This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="offset">Page Number (optional)</param>
        /// <param name="limit">Per page (optional)</param>
        /// <param name="filter">URL-encoded JSON string (optional)</param>
        /// <returns>ApiResponse of MeetingIndigoList</returns>
        public ApiResponse< MeetingIndigoList > GetMeetingsPastByEnterpriseWithHttpInfo (int? enterpriseId, int? offset = null, int? limit = null, string filter = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetMeetingsPastByEnterprise");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings";
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
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("GetMeetingsPastByEnterprise", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingIndigoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingIndigoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingIndigoList)));
        }

        /// <summary>
        /// List Past Meetings by Enterprise This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="offset">Page Number (optional)</param>
        /// <param name="limit">Per page (optional)</param>
        /// <param name="filter">URL-encoded JSON string (optional)</param>
        /// <returns>Task of MeetingIndigoList</returns>
        public async System.Threading.Tasks.Task<MeetingIndigoList> GetMeetingsPastByEnterpriseAsync (int? enterpriseId, int? offset = null, int? limit = null, string filter = null)
        {
             ApiResponse<MeetingIndigoList> localVarResponse = await GetMeetingsPastByEnterpriseAsyncWithHttpInfo(enterpriseId, offset, limit, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Past Meetings by Enterprise This endpoint lists completed meetings by enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="offset">Page Number (optional)</param>
        /// <param name="limit">Per page (optional)</param>
        /// <param name="filter">URL-encoded JSON string (optional)</param>
        /// <returns>Task of ApiResponse (MeetingIndigoList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeetingIndigoList>> GetMeetingsPastByEnterpriseAsyncWithHttpInfo (int? enterpriseId, int? offset = null, int? limit = null, string filter = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetMeetingsPastByEnterprise");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/meetings";
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
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("GetMeetingsPastByEnterprise", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingIndigoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingIndigoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingIndigoList)));
        }

        /// <summary>
        /// List Past Meetings by User This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>MeetingIndigoList</returns>
        public MeetingIndigoList GetMeetingsPastByUser (int? userId)
        {
             ApiResponse<MeetingIndigoList> localVarResponse = GetMeetingsPastByUserWithHttpInfo(userId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List Past Meetings by User This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>ApiResponse of MeetingIndigoList</returns>
        public ApiResponse< MeetingIndigoList > GetMeetingsPastByUserWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CommandCenterApi->GetMeetingsPastByUser");

            var localVarPath = "/v1/user/{user_id}/indigo/meetings";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter

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
                Exception exception = ExceptionFactory("GetMeetingsPastByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingIndigoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingIndigoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingIndigoList)));
        }

        /// <summary>
        /// List Past Meetings by User This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of MeetingIndigoList</returns>
        public async System.Threading.Tasks.Task<MeetingIndigoList> GetMeetingsPastByUserAsync (int? userId)
        {
             ApiResponse<MeetingIndigoList> localVarResponse = await GetMeetingsPastByUserAsyncWithHttpInfo(userId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List Past Meetings by User This endpoint lists completed meetings by user. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <returns>Task of ApiResponse (MeetingIndigoList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MeetingIndigoList>> GetMeetingsPastByUserAsyncWithHttpInfo (int? userId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling CommandCenterApi->GetMeetingsPastByUser");

            var localVarPath = "/v1/user/{user_id}/indigo/meetings";
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

            if (userId != null) localVarPathParams.Add("user_id", Configuration.ApiClient.ParameterToString(userId)); // path parameter

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
                Exception exception = ExceptionFactory("GetMeetingsPastByUser", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MeetingIndigoList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MeetingIndigoList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MeetingIndigoList)));
        }

        /// <summary>
        /// ROI Data This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string</param>
        /// <returns>AnalyticsRoiData</returns>
        public AnalyticsRoiData GetRoiRanges (int? enterpriseId, string filter)
        {
             ApiResponse<AnalyticsRoiData> localVarResponse = GetRoiRangesWithHttpInfo(enterpriseId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ROI Data This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string</param>
        /// <returns>ApiResponse of AnalyticsRoiData</returns>
        public ApiResponse< AnalyticsRoiData > GetRoiRangesWithHttpInfo (int? enterpriseId, string filter)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetRoiRanges");
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling CommandCenterApi->GetRoiRanges");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/roi_ranges";
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
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("GetRoiRanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsRoiData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsRoiData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsRoiData)));
        }

        /// <summary>
        /// ROI Data This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string</param>
        /// <returns>Task of AnalyticsRoiData</returns>
        public async System.Threading.Tasks.Task<AnalyticsRoiData> GetRoiRangesAsync (int? enterpriseId, string filter)
        {
             ApiResponse<AnalyticsRoiData> localVarResponse = await GetRoiRangesAsyncWithHttpInfo(enterpriseId, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ROI Data This endpoint lists return on investment (ROI) data for meetings. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string</param>
        /// <returns>Task of ApiResponse (AnalyticsRoiData)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsRoiData>> GetRoiRangesAsyncWithHttpInfo (int? enterpriseId, string filter)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetRoiRanges");
            // verify the required parameter 'filter' is set
            if (filter == null)
                throw new ApiException(400, "Missing required parameter 'filter' when calling CommandCenterApi->GetRoiRanges");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/roi_ranges";
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
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("GetRoiRanges", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsRoiData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsRoiData) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsRoiData)));
        }

        /// <summary>
        /// Top Users This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;start_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;end_time&quot;}])</param>
        /// <returns>AnalyticsTopUsers</returns>
        public AnalyticsTopUsers GetTopUsers (int? enterpriseId, string filter = null)
        {
             ApiResponse<AnalyticsTopUsers> localVarResponse = GetTopUsersWithHttpInfo(enterpriseId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Top Users This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;start_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;end_time&quot;}])</param>
        /// <returns>ApiResponse of AnalyticsTopUsers</returns>
        public ApiResponse< AnalyticsTopUsers > GetTopUsersWithHttpInfo (int? enterpriseId, string filter = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetTopUsers");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/users/usage";
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
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("GetTopUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsTopUsers>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsTopUsers) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsTopUsers)));
        }

        /// <summary>
        /// Top Users This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;start_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;end_time&quot;}])</param>
        /// <returns>Task of AnalyticsTopUsers</returns>
        public async System.Threading.Tasks.Task<AnalyticsTopUsers> GetTopUsersAsync (int? enterpriseId, string filter = null)
        {
             ApiResponse<AnalyticsTopUsers> localVarResponse = await GetTopUsersAsyncWithHttpInfo(enterpriseId, filter);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Top Users This endpoint retrieves the top users by usage for an enterprise. Requires /oauth2/token?Password authentication.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.meetings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.</param>
        /// <param name="filter">URL-encoded JSON string (optional, default to [{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;gt&quot;,&quot;value&quot;:&quot;2017-01-16T00:00:00-07:00&quot;,&quot;field&quot;:&quot;start_time&quot;},{&quot;type&quot;:&quot;date&quot;,&quot;comparison&quot;:&quot;lt&quot;,&quot;value&quot;:&quot;2017-01-23T23:59:59-07:00&quot;,&quot;field&quot;:&quot;end_time&quot;}])</param>
        /// <returns>Task of ApiResponse (AnalyticsTopUsers)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnalyticsTopUsers>> GetTopUsersAsyncWithHttpInfo (int? enterpriseId, string filter = null)
        {
            // verify the required parameter 'enterpriseId' is set
            if (enterpriseId == null)
                throw new ApiException(400, "Missing required parameter 'enterpriseId' when calling CommandCenterApi->GetTopUsers");

            var localVarPath = "/v1/enterprise/{enterprise_id}/indigo/analytics/users/usage";
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
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter

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
                Exception exception = ExceptionFactory("GetTopUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnalyticsTopUsers>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnalyticsTopUsers) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AnalyticsTopUsers)));
        }

    }
}
