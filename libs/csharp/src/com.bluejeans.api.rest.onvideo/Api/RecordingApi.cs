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
using com.bluejeans.api.rest.onvideo.Client;
using com.bluejeans.api.rest.onvideo.Model;

namespace com.bluejeans.api.rest.onvideo.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRecordingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get All Recordings for a Specified Meeting ID
        /// </summary>
        /// <remarks>
        /// This endpoint lists the recordings for a meeting.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest. (optional)</param>
        /// <returns>RecordingHistoryList</returns>
        RecordingHistoryList GetMeetingRecordings (int? userId, int? meetingId, string meetingGuid = null);

        /// <summary>
        /// Get All Recordings for a Specified Meeting ID
        /// </summary>
        /// <remarks>
        /// This endpoint lists the recordings for a meeting.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest. (optional)</param>
        /// <returns>ApiResponse of RecordingHistoryList</returns>
        ApiResponse<RecordingHistoryList> GetMeetingRecordingsWithHttpInfo (int? userId, int? meetingId, string meetingGuid = null);
        /// <summary>
        /// Get Recording Download Link
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves properties about the recording chapter.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="contentId">The recording properties fetched with other API endpoints will return a compositeContentId or a contentId. That value can be used for this argument.</param>
        /// <param name="isDownloadable">Set to true.</param>
        /// <returns>Content</returns>
        Content GetRecordingContent (int? userId, int? contentId, bool? isDownloadable);

        /// <summary>
        /// Get Recording Download Link
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves properties about the recording chapter.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="contentId">The recording properties fetched with other API endpoints will return a compositeContentId or a contentId. That value can be used for this argument.</param>
        /// <param name="isDownloadable">Set to true.</param>
        /// <returns>ApiResponse of Content</returns>
        ApiResponse<Content> GetRecordingContentWithHttpInfo (int? userId, int? contentId, bool? isDownloadable);
        /// <summary>
        /// Start Recording
        /// </summary>
        /// <remarks>
        /// This endpoint starts recording for a meeting in progress. Note that this is a POST operation. Stop is a PUT operation.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;start\&quot; in order to start recording.</param>
        /// <returns></returns>
        void StartRecording (int? userId, int? meetingId, string action);

        /// <summary>
        /// Start Recording
        /// </summary>
        /// <remarks>
        /// This endpoint starts recording for a meeting in progress. Note that this is a POST operation. Stop is a PUT operation.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;start\&quot; in order to start recording.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> StartRecordingWithHttpInfo (int? userId, int? meetingId, string action);
        /// <summary>
        /// Stop Recording
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress. Note that this is a PUT operation. Start is a POST operation.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;stop\&quot; in order to stop recording.</param>
        /// <returns></returns>
        void StopRecording (int? userId, int? meetingId, string action);

        /// <summary>
        /// Stop Recording
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress. Note that this is a PUT operation. Start is a POST operation.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;stop\&quot; in order to stop recording.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> StopRecordingWithHttpInfo (int? userId, int? meetingId, string action);
        /// <summary>
        /// Delete All Recordings for a Specified Meeting GUID
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress. 
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest.</param>
        /// <returns>Meeting</returns>
        Meeting V1UserUserIdMeetingHistoryMeetingGuidRecordingsDelete (int? userId, string meetingGuid);

        /// <summary>
        /// Delete All Recordings for a Specified Meeting GUID
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress. 
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest.</param>
        /// <returns>ApiResponse of Meeting</returns>
        ApiResponse<Meeting> V1UserUserIdMeetingHistoryMeetingGuidRecordingsDeleteWithHttpInfo (int? userId, string meetingGuid);
        /// <summary>
        /// Delete a Specified Recording Chapter
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="recordingChapterId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <returns>Meeting</returns>
        Meeting V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete (int? userId, int? meetingId, int? recordingChapterId);

        /// <summary>
        /// Delete a Specified Recording Chapter
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="recordingChapterId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <returns>ApiResponse of Meeting</returns>
        ApiResponse<Meeting> V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDeleteWithHttpInfo (int? userId, int? meetingId, int? recordingChapterId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get All Recordings for a Specified Meeting ID
        /// </summary>
        /// <remarks>
        /// This endpoint lists the recordings for a meeting.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest. (optional)</param>
        /// <returns>Task of RecordingHistoryList</returns>
        System.Threading.Tasks.Task<RecordingHistoryList> GetMeetingRecordingsAsync (int? userId, int? meetingId, string meetingGuid = null);

        /// <summary>
        /// Get All Recordings for a Specified Meeting ID
        /// </summary>
        /// <remarks>
        /// This endpoint lists the recordings for a meeting.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest. (optional)</param>
        /// <returns>Task of ApiResponse (RecordingHistoryList)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingHistoryList>> GetMeetingRecordingsAsyncWithHttpInfo (int? userId, int? meetingId, string meetingGuid = null);
        /// <summary>
        /// Get Recording Download Link
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves properties about the recording chapter.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="contentId">The recording properties fetched with other API endpoints will return a compositeContentId or a contentId. That value can be used for this argument.</param>
        /// <param name="isDownloadable">Set to true.</param>
        /// <returns>Task of Content</returns>
        System.Threading.Tasks.Task<Content> GetRecordingContentAsync (int? userId, int? contentId, bool? isDownloadable);

        /// <summary>
        /// Get Recording Download Link
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves properties about the recording chapter.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="contentId">The recording properties fetched with other API endpoints will return a compositeContentId or a contentId. That value can be used for this argument.</param>
        /// <param name="isDownloadable">Set to true.</param>
        /// <returns>Task of ApiResponse (Content)</returns>
        System.Threading.Tasks.Task<ApiResponse<Content>> GetRecordingContentAsyncWithHttpInfo (int? userId, int? contentId, bool? isDownloadable);
        /// <summary>
        /// Start Recording
        /// </summary>
        /// <remarks>
        /// This endpoint starts recording for a meeting in progress. Note that this is a POST operation. Stop is a PUT operation.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;start\&quot; in order to start recording.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task StartRecordingAsync (int? userId, int? meetingId, string action);

        /// <summary>
        /// Start Recording
        /// </summary>
        /// <remarks>
        /// This endpoint starts recording for a meeting in progress. Note that this is a POST operation. Stop is a PUT operation.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;start\&quot; in order to start recording.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> StartRecordingAsyncWithHttpInfo (int? userId, int? meetingId, string action);
        /// <summary>
        /// Stop Recording
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress. Note that this is a PUT operation. Start is a POST operation.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;stop\&quot; in order to stop recording.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task StopRecordingAsync (int? userId, int? meetingId, string action);

        /// <summary>
        /// Stop Recording
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress. Note that this is a PUT operation. Start is a POST operation.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;stop\&quot; in order to stop recording.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> StopRecordingAsyncWithHttpInfo (int? userId, int? meetingId, string action);
        /// <summary>
        /// Delete All Recordings for a Specified Meeting GUID
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress. 
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest.</param>
        /// <returns>Task of Meeting</returns>
        System.Threading.Tasks.Task<Meeting> V1UserUserIdMeetingHistoryMeetingGuidRecordingsDeleteAsync (int? userId, string meetingGuid);

        /// <summary>
        /// Delete All Recordings for a Specified Meeting GUID
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress. 
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest.</param>
        /// <returns>Task of ApiResponse (Meeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Meeting>> V1UserUserIdMeetingHistoryMeetingGuidRecordingsDeleteAsyncWithHttpInfo (int? userId, string meetingGuid);
        /// <summary>
        /// Delete a Specified Recording Chapter
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="recordingChapterId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <returns>Task of Meeting</returns>
        System.Threading.Tasks.Task<Meeting> V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDeleteAsync (int? userId, int? meetingId, int? recordingChapterId);

        /// <summary>
        /// Delete a Specified Recording Chapter
        /// </summary>
        /// <remarks>
        /// This endpoint stops recording for a meeting in progress.
        /// </remarks>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="recordingChapterId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <returns>Task of ApiResponse (Meeting)</returns>
        System.Threading.Tasks.Task<ApiResponse<Meeting>> V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDeleteAsyncWithHttpInfo (int? userId, int? meetingId, int? recordingChapterId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RecordingApi : IRecordingApi
    {
        private com.bluejeans.api.rest.onvideo.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecordingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = com.bluejeans.api.rest.onvideo.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RecordingApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.bluejeans.api.rest.onvideo.Client.Configuration.DefaultExceptionFactory;

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
        public com.bluejeans.api.rest.onvideo.Client.ExceptionFactory ExceptionFactory
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
        /// Get All Recordings for a Specified Meeting ID This endpoint lists the recordings for a meeting.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest. (optional)</param>
        /// <returns>RecordingHistoryList</returns>
        public RecordingHistoryList GetMeetingRecordings (int? userId, int? meetingId, string meetingGuid = null)
        {
             ApiResponse<RecordingHistoryList> localVarResponse = GetMeetingRecordingsWithHttpInfo(userId, meetingId, meetingGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Recordings for a Specified Meeting ID This endpoint lists the recordings for a meeting.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest. (optional)</param>
        /// <returns>ApiResponse of RecordingHistoryList</returns>
        public ApiResponse< RecordingHistoryList > GetMeetingRecordingsWithHttpInfo (int? userId, int? meetingId, string meetingGuid = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->GetMeetingRecordings");
            // verify the required parameter 'meetingId' is set
            if (meetingId == null)
                throw new ApiException(400, "Missing required parameter 'meetingId' when calling RecordingApi->GetMeetingRecordings");

            var localVarPath = "/v1/user/{user_id}/meeting_history/{meeting_id}/recordings";
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
            if (meetingId != null) localVarPathParams.Add("meeting_id", Configuration.ApiClient.ParameterToString(meetingId)); // path parameter
            if (meetingGuid != null) localVarQueryParams.Add("meetingGuid", Configuration.ApiClient.ParameterToString(meetingGuid)); // query parameter

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
                Exception exception = ExceptionFactory("GetMeetingRecordings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RecordingHistoryList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecordingHistoryList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingHistoryList)));
        }

        /// <summary>
        /// Get All Recordings for a Specified Meeting ID This endpoint lists the recordings for a meeting.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest. (optional)</param>
        /// <returns>Task of RecordingHistoryList</returns>
        public async System.Threading.Tasks.Task<RecordingHistoryList> GetMeetingRecordingsAsync (int? userId, int? meetingId, string meetingGuid = null)
        {
             ApiResponse<RecordingHistoryList> localVarResponse = await GetMeetingRecordingsAsyncWithHttpInfo(userId, meetingId, meetingGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Recordings for a Specified Meeting ID This endpoint lists the recordings for a meeting.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest. (optional)</param>
        /// <returns>Task of ApiResponse (RecordingHistoryList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingHistoryList>> GetMeetingRecordingsAsyncWithHttpInfo (int? userId, int? meetingId, string meetingGuid = null)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->GetMeetingRecordings");
            // verify the required parameter 'meetingId' is set
            if (meetingId == null)
                throw new ApiException(400, "Missing required parameter 'meetingId' when calling RecordingApi->GetMeetingRecordings");

            var localVarPath = "/v1/user/{user_id}/meeting_history/{meeting_id}/recordings";
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
            if (meetingId != null) localVarPathParams.Add("meeting_id", Configuration.ApiClient.ParameterToString(meetingId)); // path parameter
            if (meetingGuid != null) localVarQueryParams.Add("meetingGuid", Configuration.ApiClient.ParameterToString(meetingGuid)); // query parameter

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
                Exception exception = ExceptionFactory("GetMeetingRecordings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RecordingHistoryList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecordingHistoryList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingHistoryList)));
        }

        /// <summary>
        /// Get Recording Download Link This endpoint retrieves properties about the recording chapter.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="contentId">The recording properties fetched with other API endpoints will return a compositeContentId or a contentId. That value can be used for this argument.</param>
        /// <param name="isDownloadable">Set to true.</param>
        /// <returns>Content</returns>
        public Content GetRecordingContent (int? userId, int? contentId, bool? isDownloadable)
        {
             ApiResponse<Content> localVarResponse = GetRecordingContentWithHttpInfo(userId, contentId, isDownloadable);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Recording Download Link This endpoint retrieves properties about the recording chapter.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="contentId">The recording properties fetched with other API endpoints will return a compositeContentId or a contentId. That value can be used for this argument.</param>
        /// <param name="isDownloadable">Set to true.</param>
        /// <returns>ApiResponse of Content</returns>
        public ApiResponse< Content > GetRecordingContentWithHttpInfo (int? userId, int? contentId, bool? isDownloadable)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->GetRecordingContent");
            // verify the required parameter 'contentId' is set
            if (contentId == null)
                throw new ApiException(400, "Missing required parameter 'contentId' when calling RecordingApi->GetRecordingContent");
            // verify the required parameter 'isDownloadable' is set
            if (isDownloadable == null)
                throw new ApiException(400, "Missing required parameter 'isDownloadable' when calling RecordingApi->GetRecordingContent");

            var localVarPath = "/v1/user/{user_id}/cms/{content_id}";
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
            if (contentId != null) localVarPathParams.Add("content_id", Configuration.ApiClient.ParameterToString(contentId)); // path parameter
            if (isDownloadable != null) localVarQueryParams.Add("isDownloadable", Configuration.ApiClient.ParameterToString(isDownloadable)); // query parameter

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
                Exception exception = ExceptionFactory("GetRecordingContent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Content>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Content) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Content)));
        }

        /// <summary>
        /// Get Recording Download Link This endpoint retrieves properties about the recording chapter.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="contentId">The recording properties fetched with other API endpoints will return a compositeContentId or a contentId. That value can be used for this argument.</param>
        /// <param name="isDownloadable">Set to true.</param>
        /// <returns>Task of Content</returns>
        public async System.Threading.Tasks.Task<Content> GetRecordingContentAsync (int? userId, int? contentId, bool? isDownloadable)
        {
             ApiResponse<Content> localVarResponse = await GetRecordingContentAsyncWithHttpInfo(userId, contentId, isDownloadable);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Recording Download Link This endpoint retrieves properties about the recording chapter.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="contentId">The recording properties fetched with other API endpoints will return a compositeContentId or a contentId. That value can be used for this argument.</param>
        /// <param name="isDownloadable">Set to true.</param>
        /// <returns>Task of ApiResponse (Content)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Content>> GetRecordingContentAsyncWithHttpInfo (int? userId, int? contentId, bool? isDownloadable)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->GetRecordingContent");
            // verify the required parameter 'contentId' is set
            if (contentId == null)
                throw new ApiException(400, "Missing required parameter 'contentId' when calling RecordingApi->GetRecordingContent");
            // verify the required parameter 'isDownloadable' is set
            if (isDownloadable == null)
                throw new ApiException(400, "Missing required parameter 'isDownloadable' when calling RecordingApi->GetRecordingContent");

            var localVarPath = "/v1/user/{user_id}/cms/{content_id}";
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
            if (contentId != null) localVarPathParams.Add("content_id", Configuration.ApiClient.ParameterToString(contentId)); // path parameter
            if (isDownloadable != null) localVarQueryParams.Add("isDownloadable", Configuration.ApiClient.ParameterToString(isDownloadable)); // query parameter

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
                Exception exception = ExceptionFactory("GetRecordingContent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Content>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Content) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Content)));
        }

        /// <summary>
        /// Start Recording This endpoint starts recording for a meeting in progress. Note that this is a POST operation. Stop is a PUT operation.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;start\&quot; in order to start recording.</param>
        /// <returns></returns>
        public void StartRecording (int? userId, int? meetingId, string action)
        {
             StartRecordingWithHttpInfo(userId, meetingId, action);
        }

        /// <summary>
        /// Start Recording This endpoint starts recording for a meeting in progress. Note that this is a POST operation. Stop is a PUT operation.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;start\&quot; in order to start recording.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> StartRecordingWithHttpInfo (int? userId, int? meetingId, string action)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->StartRecording");
            // verify the required parameter 'meetingId' is set
            if (meetingId == null)
                throw new ApiException(400, "Missing required parameter 'meetingId' when calling RecordingApi->StartRecording");
            // verify the required parameter 'action' is set
            if (action == null)
                throw new ApiException(400, "Missing required parameter 'action' when calling RecordingApi->StartRecording");

            var localVarPath = "/v1/user/{user_id}/live_meetings/{meeting_id}/recordings";
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
            if (meetingId != null) localVarPathParams.Add("meeting_id", Configuration.ApiClient.ParameterToString(meetingId)); // path parameter
            if (action != null) localVarQueryParams.Add("action", Configuration.ApiClient.ParameterToString(action)); // query parameter

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
                Exception exception = ExceptionFactory("StartRecording", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Start Recording This endpoint starts recording for a meeting in progress. Note that this is a POST operation. Stop is a PUT operation.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;start\&quot; in order to start recording.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task StartRecordingAsync (int? userId, int? meetingId, string action)
        {
             await StartRecordingAsyncWithHttpInfo(userId, meetingId, action);

        }

        /// <summary>
        /// Start Recording This endpoint starts recording for a meeting in progress. Note that this is a POST operation. Stop is a PUT operation.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;start\&quot; in order to start recording.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> StartRecordingAsyncWithHttpInfo (int? userId, int? meetingId, string action)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->StartRecording");
            // verify the required parameter 'meetingId' is set
            if (meetingId == null)
                throw new ApiException(400, "Missing required parameter 'meetingId' when calling RecordingApi->StartRecording");
            // verify the required parameter 'action' is set
            if (action == null)
                throw new ApiException(400, "Missing required parameter 'action' when calling RecordingApi->StartRecording");

            var localVarPath = "/v1/user/{user_id}/live_meetings/{meeting_id}/recordings";
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
            if (meetingId != null) localVarPathParams.Add("meeting_id", Configuration.ApiClient.ParameterToString(meetingId)); // path parameter
            if (action != null) localVarQueryParams.Add("action", Configuration.ApiClient.ParameterToString(action)); // query parameter

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
                Exception exception = ExceptionFactory("StartRecording", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Stop Recording This endpoint stops recording for a meeting in progress. Note that this is a PUT operation. Start is a POST operation.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;stop\&quot; in order to stop recording.</param>
        /// <returns></returns>
        public void StopRecording (int? userId, int? meetingId, string action)
        {
             StopRecordingWithHttpInfo(userId, meetingId, action);
        }

        /// <summary>
        /// Stop Recording This endpoint stops recording for a meeting in progress. Note that this is a PUT operation. Start is a POST operation.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;stop\&quot; in order to stop recording.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> StopRecordingWithHttpInfo (int? userId, int? meetingId, string action)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->StopRecording");
            // verify the required parameter 'meetingId' is set
            if (meetingId == null)
                throw new ApiException(400, "Missing required parameter 'meetingId' when calling RecordingApi->StopRecording");
            // verify the required parameter 'action' is set
            if (action == null)
                throw new ApiException(400, "Missing required parameter 'action' when calling RecordingApi->StopRecording");

            var localVarPath = "/v1/user/{user_id}/live_meetings/{meeting_id}/recordings";
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
            if (meetingId != null) localVarPathParams.Add("meeting_id", Configuration.ApiClient.ParameterToString(meetingId)); // path parameter
            if (action != null) localVarQueryParams.Add("action", Configuration.ApiClient.ParameterToString(action)); // query parameter

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
                Exception exception = ExceptionFactory("StopRecording", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Stop Recording This endpoint stops recording for a meeting in progress. Note that this is a PUT operation. Start is a POST operation.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;stop\&quot; in order to stop recording.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task StopRecordingAsync (int? userId, int? meetingId, string action)
        {
             await StopRecordingAsyncWithHttpInfo(userId, meetingId, action);

        }

        /// <summary>
        /// Stop Recording This endpoint stops recording for a meeting in progress. Note that this is a PUT operation. Start is a POST operation.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="action">Always set to \&quot;stop\&quot; in order to stop recording.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> StopRecordingAsyncWithHttpInfo (int? userId, int? meetingId, string action)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->StopRecording");
            // verify the required parameter 'meetingId' is set
            if (meetingId == null)
                throw new ApiException(400, "Missing required parameter 'meetingId' when calling RecordingApi->StopRecording");
            // verify the required parameter 'action' is set
            if (action == null)
                throw new ApiException(400, "Missing required parameter 'action' when calling RecordingApi->StopRecording");

            var localVarPath = "/v1/user/{user_id}/live_meetings/{meeting_id}/recordings";
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
            if (meetingId != null) localVarPathParams.Add("meeting_id", Configuration.ApiClient.ParameterToString(meetingId)); // path parameter
            if (action != null) localVarQueryParams.Add("action", Configuration.ApiClient.ParameterToString(action)); // query parameter

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
                Exception exception = ExceptionFactory("StopRecording", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete All Recordings for a Specified Meeting GUID This endpoint stops recording for a meeting in progress. 
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest.</param>
        /// <returns>Meeting</returns>
        public Meeting V1UserUserIdMeetingHistoryMeetingGuidRecordingsDelete (int? userId, string meetingGuid)
        {
             ApiResponse<Meeting> localVarResponse = V1UserUserIdMeetingHistoryMeetingGuidRecordingsDeleteWithHttpInfo(userId, meetingGuid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete All Recordings for a Specified Meeting GUID This endpoint stops recording for a meeting in progress. 
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest.</param>
        /// <returns>ApiResponse of Meeting</returns>
        public ApiResponse< Meeting > V1UserUserIdMeetingHistoryMeetingGuidRecordingsDeleteWithHttpInfo (int? userId, string meetingGuid)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->V1UserUserIdMeetingHistoryMeetingGuidRecordingsDelete");
            // verify the required parameter 'meetingGuid' is set
            if (meetingGuid == null)
                throw new ApiException(400, "Missing required parameter 'meetingGuid' when calling RecordingApi->V1UserUserIdMeetingHistoryMeetingGuidRecordingsDelete");

            var localVarPath = "/v1/user/{user_id}/meeting_history/{meeting_guid}/recordings/";
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
            if (meetingGuid != null) localVarPathParams.Add("meeting_guid", Configuration.ApiClient.ParameterToString(meetingGuid)); // path parameter

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
                Exception exception = ExceptionFactory("V1UserUserIdMeetingHistoryMeetingGuidRecordingsDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Meeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Meeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Meeting)));
        }

        /// <summary>
        /// Delete All Recordings for a Specified Meeting GUID This endpoint stops recording for a meeting in progress. 
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest.</param>
        /// <returns>Task of Meeting</returns>
        public async System.Threading.Tasks.Task<Meeting> V1UserUserIdMeetingHistoryMeetingGuidRecordingsDeleteAsync (int? userId, string meetingGuid)
        {
             ApiResponse<Meeting> localVarResponse = await V1UserUserIdMeetingHistoryMeetingGuidRecordingsDeleteAsyncWithHttpInfo(userId, meetingGuid);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete All Recordings for a Specified Meeting GUID This endpoint stops recording for a meeting in progress. 
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingGuid">The globally unique identifier (GUID) of the meeting of interest. This value is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 5 alphanumeric segments separated by dashes. Since a given numeric meeting ID can have multiple instantiations over time, the GUID helps identify the instance of interest.</param>
        /// <returns>Task of ApiResponse (Meeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Meeting>> V1UserUserIdMeetingHistoryMeetingGuidRecordingsDeleteAsyncWithHttpInfo (int? userId, string meetingGuid)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->V1UserUserIdMeetingHistoryMeetingGuidRecordingsDelete");
            // verify the required parameter 'meetingGuid' is set
            if (meetingGuid == null)
                throw new ApiException(400, "Missing required parameter 'meetingGuid' when calling RecordingApi->V1UserUserIdMeetingHistoryMeetingGuidRecordingsDelete");

            var localVarPath = "/v1/user/{user_id}/meeting_history/{meeting_guid}/recordings/";
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
            if (meetingGuid != null) localVarPathParams.Add("meeting_guid", Configuration.ApiClient.ParameterToString(meetingGuid)); // path parameter

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
                Exception exception = ExceptionFactory("V1UserUserIdMeetingHistoryMeetingGuidRecordingsDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Meeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Meeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Meeting)));
        }

        /// <summary>
        /// Delete a Specified Recording Chapter This endpoint stops recording for a meeting in progress.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="recordingChapterId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <returns>Meeting</returns>
        public Meeting V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete (int? userId, int? meetingId, int? recordingChapterId)
        {
             ApiResponse<Meeting> localVarResponse = V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDeleteWithHttpInfo(userId, meetingId, recordingChapterId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Specified Recording Chapter This endpoint stops recording for a meeting in progress.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="recordingChapterId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <returns>ApiResponse of Meeting</returns>
        public ApiResponse< Meeting > V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDeleteWithHttpInfo (int? userId, int? meetingId, int? recordingChapterId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete");
            // verify the required parameter 'meetingId' is set
            if (meetingId == null)
                throw new ApiException(400, "Missing required parameter 'meetingId' when calling RecordingApi->V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete");
            // verify the required parameter 'recordingChapterId' is set
            if (recordingChapterId == null)
                throw new ApiException(400, "Missing required parameter 'recordingChapterId' when calling RecordingApi->V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete");

            var localVarPath = "/v1/user/{user_id}/meeting_history/{meeting_id}/recordings/{recording_chapter_id}/";
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
            if (meetingId != null) localVarPathParams.Add("meeting_id", Configuration.ApiClient.ParameterToString(meetingId)); // path parameter
            if (recordingChapterId != null) localVarPathParams.Add("recording_chapter_id", Configuration.ApiClient.ParameterToString(recordingChapterId)); // path parameter

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
                Exception exception = ExceptionFactory("V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Meeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Meeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Meeting)));
        }

        /// <summary>
        /// Delete a Specified Recording Chapter This endpoint stops recording for a meeting in progress.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="recordingChapterId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <returns>Task of Meeting</returns>
        public async System.Threading.Tasks.Task<Meeting> V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDeleteAsync (int? userId, int? meetingId, int? recordingChapterId)
        {
             ApiResponse<Meeting> localVarResponse = await V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDeleteAsyncWithHttpInfo(userId, meetingId, recordingChapterId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Specified Recording Chapter This endpoint stops recording for a meeting in progress.
        /// </summary>
        /// <exception cref="com.bluejeans.api.rest.onvideo.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.</param>
        /// <param name="meetingId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <param name="recordingChapterId">The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.</param>
        /// <returns>Task of ApiResponse (Meeting)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Meeting>> V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDeleteAsyncWithHttpInfo (int? userId, int? meetingId, int? recordingChapterId)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling RecordingApi->V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete");
            // verify the required parameter 'meetingId' is set
            if (meetingId == null)
                throw new ApiException(400, "Missing required parameter 'meetingId' when calling RecordingApi->V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete");
            // verify the required parameter 'recordingChapterId' is set
            if (recordingChapterId == null)
                throw new ApiException(400, "Missing required parameter 'recordingChapterId' when calling RecordingApi->V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete");

            var localVarPath = "/v1/user/{user_id}/meeting_history/{meeting_id}/recordings/{recording_chapter_id}/";
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
            if (meetingId != null) localVarPathParams.Add("meeting_id", Configuration.ApiClient.ParameterToString(meetingId)); // path parameter
            if (recordingChapterId != null) localVarPathParams.Add("recording_chapter_id", Configuration.ApiClient.ParameterToString(recordingChapterId)); // path parameter

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
                Exception exception = ExceptionFactory("V1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Meeting>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Meeting) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Meeting)));
        }

    }
}
