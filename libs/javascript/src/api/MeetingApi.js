/**
 * BlueJeans Meetings REST API
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/23/2018 </alert>Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.4407232018
 * Contact: glenn@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.0-SNAPSHOT
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/DialoutPstn', 'model/Endpoint', 'model/Endpoints', 'model/Error', 'model/Layout', 'model/Meeting', 'model/MeetingEmails', 'model/MeetingState', 'model/Numbers', 'model/PairingCodePSTN', 'model/PairingCodeSIP', 'model/PairingCodeWebRTC', 'model/PayloadDialout', 'model/PayloadInvite', 'model/PayloadMeetingState', 'model/PayloadPairingCodePstn', 'model/PayloadPairingCodeSIP', 'model/PayloadPairingCodeWebRTC', 'model/ScheduleMeetingMinComp'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/DialoutPstn'), require('../model/Endpoint'), require('../model/Endpoints'), require('../model/Error'), require('../model/Layout'), require('../model/Meeting'), require('../model/MeetingEmails'), require('../model/MeetingState'), require('../model/Numbers'), require('../model/PairingCodePSTN'), require('../model/PairingCodeSIP'), require('../model/PairingCodeWebRTC'), require('../model/PayloadDialout'), require('../model/PayloadInvite'), require('../model/PayloadMeetingState'), require('../model/PayloadPairingCodePstn'), require('../model/PayloadPairingCodeSIP'), require('../model/PayloadPairingCodeWebRTC'), require('../model/ScheduleMeetingMinComp'));
  } else {
    // Browser globals (root is window)
    if (!root.BlueJeansMeetingsRestApi) {
      root.BlueJeansMeetingsRestApi = {};
    }
    root.BlueJeansMeetingsRestApi.MeetingApi = factory(root.BlueJeansMeetingsRestApi.ApiClient, root.BlueJeansMeetingsRestApi.DialoutPstn, root.BlueJeansMeetingsRestApi.Endpoint, root.BlueJeansMeetingsRestApi.Endpoints, root.BlueJeansMeetingsRestApi.Error, root.BlueJeansMeetingsRestApi.Layout, root.BlueJeansMeetingsRestApi.Meeting, root.BlueJeansMeetingsRestApi.MeetingEmails, root.BlueJeansMeetingsRestApi.MeetingState, root.BlueJeansMeetingsRestApi.Numbers, root.BlueJeansMeetingsRestApi.PairingCodePSTN, root.BlueJeansMeetingsRestApi.PairingCodeSIP, root.BlueJeansMeetingsRestApi.PairingCodeWebRTC, root.BlueJeansMeetingsRestApi.PayloadDialout, root.BlueJeansMeetingsRestApi.PayloadInvite, root.BlueJeansMeetingsRestApi.PayloadMeetingState, root.BlueJeansMeetingsRestApi.PayloadPairingCodePstn, root.BlueJeansMeetingsRestApi.PayloadPairingCodeSIP, root.BlueJeansMeetingsRestApi.PayloadPairingCodeWebRTC, root.BlueJeansMeetingsRestApi.ScheduleMeetingMinComp);
  }
}(this, function(ApiClient, DialoutPstn, Endpoint, Endpoints, Error, Layout, Meeting, MeetingEmails, MeetingState, Numbers, PairingCodePSTN, PairingCodeSIP, PairingCodeWebRTC, PayloadDialout, PayloadInvite, PayloadMeetingState, PayloadPairingCodePstn, PayloadPairingCodeSIP, PayloadPairingCodeWebRTC, ScheduleMeetingMinComp) {
  'use strict';

  /**
   * Meeting service.
   * @module api/MeetingApi
   * @version 1.0.4407232018
   */

  /**
   * Constructs a new MeetingApi. 
   * @alias module:api/MeetingApi
   * @class
   * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
   * default to {@link module:ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the cancelMeeting operation.
     * @callback module:api/MeetingApi~cancelMeetingCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Cancel Meeting
     * This endpoint deletes a scheuled meeting.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} meetingId The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.
     * @param {Object} opts Optional parameters
     * @param {Boolean} opts.email Dispatch an email to participants with the specified cancellation message. (default to false)
     * @param {String} opts.cancellationMessage Message sent to participants when meeting is deleted and email is selected
     * @param {module:api/MeetingApi~cancelMeetingCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.cancelMeeting = function(userId, meetingId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling cancelMeeting");
      }

      // verify the required parameter 'meetingId' is set
      if (meetingId === undefined || meetingId === null) {
        throw new Error("Missing the required parameter 'meetingId' when calling cancelMeeting");
      }


      var pathParams = {
        'user_id': userId,
        'meeting_id': meetingId
      };
      var queryParams = {
        'email': opts['email'],
        'cancellationMessage': opts['cancellationMessage'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/scheduled_meeting/{meeting_id}', 'DELETE',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the createMeeting operation.
     * @callback module:api/MeetingApi~createMeetingCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Meeting} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create Meeting
     * This endpoint will create a scheduled meeting.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {module:model/ScheduleMeetingMinComp} meeting The desired configuration for the meeting. (&lt;b&gt;NOTE&lt;/b&gt; The model provided here is a &lt;i&gt;typical&lt;/i&gt; minimum set of meeting parameters.)
     * @param {Object} opts Optional parameters
     * @param {Boolean} opts.email If set to true, sends invitation emails to all listed participants.
     * @param {module:api/MeetingApi~createMeetingCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Meeting}
     */
    this.createMeeting = function(userId, meeting, opts, callback) {
      opts = opts || {};
      var postBody = meeting;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling createMeeting");
      }

      // verify the required parameter 'meeting' is set
      if (meeting === undefined || meeting === null) {
        throw new Error("Missing the required parameter 'meeting' when calling createMeeting");
      }


      var pathParams = {
        'user_id': userId
      };
      var queryParams = {
        'email': opts['email'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = Meeting;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/scheduled_meeting', 'POST',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the dialoutPstn operation.
     * @callback module:api/MeetingApi~dialoutPstnCallback
     * @param {String} error Error message, if any.
     * @param {module:model/DialoutPstn} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Dialout via PSTN
     * Places a PSTN call to a user to join meeting. **Note:** call this API using a meeting access token
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {module:model/PayloadDialout} payloadDialout 
     * @param {module:api/MeetingApi~dialoutPstnCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/DialoutPstn}
     */
    this.dialoutPstn = function(userId, numericMeetingId, payloadDialout, callback) {
      var postBody = payloadDialout;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling dialoutPstn");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling dialoutPstn");
      }

      // verify the required parameter 'payloadDialout' is set
      if (payloadDialout === undefined || payloadDialout === null) {
        throw new Error("Missing the required parameter 'payloadDialout' when calling dialoutPstn");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = DialoutPstn;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/dialout/pstn', 'POST',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the generatePairingCodePstn operation.
     * @callback module:api/MeetingApi~generatePairingCodePstnCallback
     * @param {String} error Error message, if any.
     * @param {module:model/PairingCodePSTN} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Generate Pairing Code (PSTN)
     * This endpoint generates a PSTN pairing code that can be used to connect to a meeting via telephone. **Note:** call this API using a meeting access token
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {module:model/PayloadPairingCodePstn} payloadPairingCodePstn 
     * @param {Object} opts Optional parameters
     * @param {String} opts.role  (default to USER)
     * @param {module:api/MeetingApi~generatePairingCodePstnCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/PairingCodePSTN}
     */
    this.generatePairingCodePstn = function(userId, numericMeetingId, payloadPairingCodePstn, opts, callback) {
      opts = opts || {};
      var postBody = payloadPairingCodePstn;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling generatePairingCodePstn");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling generatePairingCodePstn");
      }

      // verify the required parameter 'payloadPairingCodePstn' is set
      if (payloadPairingCodePstn === undefined || payloadPairingCodePstn === null) {
        throw new Error("Missing the required parameter 'payloadPairingCodePstn' when calling generatePairingCodePstn");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId
      };
      var queryParams = {
        'role': opts['role'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = PairingCodePSTN;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/pairing_code/PSTN', 'POST',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the generatePairingCodeSip operation.
     * @callback module:api/MeetingApi~generatePairingCodeSipCallback
     * @param {String} error Error message, if any.
     * @param {module:model/PairingCodeSIP} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Generate Pairing Code (SIP)
     * This endpoint generates a SIP pairing code that can be used to connect to a meeting. **Note:** call this API using a meeting access token
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {module:model/PayloadPairingCodeSIP} payloadPairingCodeSIP Information about the device that will be joining via SIP.
     * @param {module:api/MeetingApi~generatePairingCodeSipCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/PairingCodeSIP}
     */
    this.generatePairingCodeSip = function(userId, numericMeetingId, payloadPairingCodeSIP, callback) {
      var postBody = payloadPairingCodeSIP;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling generatePairingCodeSip");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling generatePairingCodeSip");
      }

      // verify the required parameter 'payloadPairingCodeSIP' is set
      if (payloadPairingCodeSIP === undefined || payloadPairingCodeSIP === null) {
        throw new Error("Missing the required parameter 'payloadPairingCodeSIP' when calling generatePairingCodeSip");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = PairingCodeSIP;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/pairing_code/SIP', 'POST',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the generatePairingCodeWebRtc operation.
     * @callback module:api/MeetingApi~generatePairingCodeWebRtcCallback
     * @param {String} error Error message, if any.
     * @param {module:model/PairingCodeWebRTC} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Generate Pairing Code (WebRTC)
     * This endpoint generates a WebRTC pairing code that can be used to connect to a meeting. **Note:** call this API using a meeting access token
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {module:model/PayloadPairingCodeWebRTC} payloadPairingCodeWebRTC 
     * @param {Object} opts Optional parameters
     * @param {String} opts.role  (default to USER)
     * @param {module:api/MeetingApi~generatePairingCodeWebRtcCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/PairingCodeWebRTC}
     */
    this.generatePairingCodeWebRtc = function(userId, numericMeetingId, payloadPairingCodeWebRTC, opts, callback) {
      opts = opts || {};
      var postBody = payloadPairingCodeWebRTC;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling generatePairingCodeWebRtc");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling generatePairingCodeWebRtc");
      }

      // verify the required parameter 'payloadPairingCodeWebRTC' is set
      if (payloadPairingCodeWebRTC === undefined || payloadPairingCodeWebRTC === null) {
        throw new Error("Missing the required parameter 'payloadPairingCodeWebRTC' when calling generatePairingCodeWebRtc");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId
      };
      var queryParams = {
        'role': opts['role'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = PairingCodeWebRTC;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/pairing_code/webrtc', 'POST',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getEndpointLayout operation.
     * @callback module:api/MeetingApi~getEndpointLayoutCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Layout} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Endpoint Layout
     * This endpoint allows you to retrieve an individual endpoint’s current layout setting.  Can use either of a general or meeting access token.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {String} endpointGuid The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint.
     * @param {module:api/MeetingApi~getEndpointLayoutCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Layout}
     */
    this.getEndpointLayout = function(userId, numericMeetingId, endpointGuid, callback) {
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling getEndpointLayout");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling getEndpointLayout");
      }

      // verify the required parameter 'endpointGuid' is set
      if (endpointGuid === undefined || endpointGuid === null) {
        throw new Error("Missing the required parameter 'endpointGuid' when calling getEndpointLayout");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId,
        'endpoint_guid': endpointGuid
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = Layout;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid}/layout', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getMeeting operation.
     * @callback module:api/MeetingApi~getMeetingCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Meeting} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Meeting
     * This endpoint gets the settings for a user&#39;s meeting.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} meetingId The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property. This is not the numeric meeting ID visible to users.
     * @param {module:api/MeetingApi~getMeetingCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Meeting}
     */
    this.getMeeting = function(userId, meetingId, callback) {
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling getMeeting");
      }

      // verify the required parameter 'meetingId' is set
      if (meetingId === undefined || meetingId === null) {
        throw new Error("Missing the required parameter 'meetingId' when calling getMeeting");
      }


      var pathParams = {
        'user_id': userId,
        'meeting_id': meetingId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = Meeting;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/scheduled_meeting/{meeting_id}', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getMeetingEmails operation.
     * @callback module:api/MeetingApi~getMeetingEmailsCallback
     * @param {String} error Error message, if any.
     * @param {module:model/MeetingEmails} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Meeting Email
     * This endpoint retrieves the email object for a scheduled meeting.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} meetingId The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.
     * @param {Object} opts Optional parameters
     * @param {module:model/String} opts.type TEXT, ICS, HTML
     * @param {module:model/String} opts.role moderator, participant
     * @param {module:model/String} opts.action create, edit, delete
     * @param {module:api/MeetingApi~getMeetingEmailsCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/MeetingEmails}
     */
    this.getMeetingEmails = function(userId, meetingId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling getMeetingEmails");
      }

      // verify the required parameter 'meetingId' is set
      if (meetingId === undefined || meetingId === null) {
        throw new Error("Missing the required parameter 'meetingId' when calling getMeetingEmails");
      }


      var pathParams = {
        'user_id': userId,
        'meeting_id': meetingId
      };
      var queryParams = {
        'type': opts['type'],
        'role': opts['role'],
        'action': opts['action'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = MeetingEmails;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/scheduled_meeting/{meeting_id}/emails', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getMeetingEndpoint operation.
     * @callback module:api/MeetingApi~getMeetingEndpointCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Endpoint} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Endpoint Information
     * This endpoint allows you to retrieve information about an endpoint in the meeting.  Can use either of a general or meeting access token.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {String} endpointGuid The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint.
     * @param {module:api/MeetingApi~getMeetingEndpointCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Endpoint}
     */
    this.getMeetingEndpoint = function(userId, numericMeetingId, endpointGuid, callback) {
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling getMeetingEndpoint");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling getMeetingEndpoint");
      }

      // verify the required parameter 'endpointGuid' is set
      if (endpointGuid === undefined || endpointGuid === null) {
        throw new Error("Missing the required parameter 'endpointGuid' when calling getMeetingEndpoint");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId,
        'endpoint_guid': endpointGuid
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = Endpoint;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid}', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getMeetingEndpoints operation.
     * @callback module:api/MeetingApi~getMeetingEndpointsCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Endpoints} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * List Meeting Endpoints
     * This endpoint returns an array of all endpoints in the current meeting.  Can use either of a general or meeting access token.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {module:api/MeetingApi~getMeetingEndpointsCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Endpoints}
     */
    this.getMeetingEndpoints = function(userId, numericMeetingId, callback) {
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling getMeetingEndpoints");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling getMeetingEndpoints");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = Endpoints;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getMeetingNumbers operation.
     * @callback module:api/MeetingApi~getMeetingNumbersCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Numbers} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Meeting Join Info
     * This endpoint retrieves the join information for a scheduled meeting.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} meetingId The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.
     * @param {module:api/MeetingApi~getMeetingNumbersCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Numbers}
     */
    this.getMeetingNumbers = function(userId, meetingId, callback) {
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling getMeetingNumbers");
      }

      // verify the required parameter 'meetingId' is set
      if (meetingId === undefined || meetingId === null) {
        throw new Error("Missing the required parameter 'meetingId' when calling getMeetingNumbers");
      }


      var pathParams = {
        'user_id': userId,
        'meeting_id': meetingId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = Numbers;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/meetings/{meeting_id}/numbers', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getMeetingState operation.
     * @callback module:api/MeetingApi~getMeetingStateCallback
     * @param {String} error Error message, if any.
     * @param {module:model/MeetingState} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Meeting State
     * This endpoint’s purpose is to return whether the meeting is in progress or not.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {module:api/MeetingApi~getMeetingStateCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/MeetingState}
     */
    this.getMeetingState = function(userId, numericMeetingId, callback) {
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling getMeetingState");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling getMeetingState");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = MeetingState;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the listMeetings operation.
     * @callback module:api/MeetingApi~listMeetingsCallback
     * @param {String} error Error message, if any.
     * @param {Array.<module:model/Meeting>} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * List Meetings
     * This endpoint gets a list of the user&#39;s scheduled upcoming meetings.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Object} opts Optional parameters
     * @param {String} opts.numericMeetingId Filter the results by the meeting ID that participants will see and use to join the conference.
     * @param {module:api/MeetingApi~listMeetingsCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link Array.<module:model/Meeting>}
     */
    this.listMeetings = function(userId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling listMeetings");
      }


      var pathParams = {
        'user_id': userId
      };
      var queryParams = {
        'numericMeetingId': opts['numericMeetingId'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = [Meeting];

      return this.apiClient.callApi(
        '/v1/user/{user_id}/scheduled_meeting', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the sendMeetingInvite operation.
     * @callback module:api/MeetingApi~sendMeetingInviteCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Send Email Invite
     * This endpoint generates an email invite to the specified meeting. **Note:** call this API using a meeting access token
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {module:model/PayloadInvite} payloadInvite 
     * @param {module:api/MeetingApi~sendMeetingInviteCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.sendMeetingInvite = function(userId, numericMeetingId, payloadInvite, callback) {
      var postBody = payloadInvite;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling sendMeetingInvite");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling sendMeetingInvite");
      }

      // verify the required parameter 'payloadInvite' is set
      if (payloadInvite === undefined || payloadInvite === null) {
        throw new Error("Missing the required parameter 'payloadInvite' when calling sendMeetingInvite");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/invite', 'POST',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updateEndpointLayout operation.
     * @callback module:api/MeetingApi~updateEndpointLayoutCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Layout} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update Endpoint Layout
     * This endpoint allows you to update an individual endpoint’s current layout setting. Requires Meeting access token with moderator privileges
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {String} endpointGuid The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint.
     * @param {Object} opts Optional parameters
     * @param {Boolean} opts.isLeader 
     * @param {Boolean} opts.push 
     * @param {module:api/MeetingApi~updateEndpointLayoutCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Layout}
     */
    this.updateEndpointLayout = function(userId, numericMeetingId, endpointGuid, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling updateEndpointLayout");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling updateEndpointLayout");
      }

      // verify the required parameter 'endpointGuid' is set
      if (endpointGuid === undefined || endpointGuid === null) {
        throw new Error("Missing the required parameter 'endpointGuid' when calling updateEndpointLayout");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId,
        'endpoint_guid': endpointGuid
      };
      var queryParams = {
        'isLeader': opts['isLeader'],
        'push': opts['push'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = Layout;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid}/layout', 'PUT',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updateMeeting operation.
     * @callback module:api/MeetingApi~updateMeetingCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Meeting} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update Meeting
     * This endpoint changes the settings for a user&#39;s meeting. For example, use for rescheduling.
     * @param {Number} userId The ID of the user of interest.  This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} meetingId The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \&quot;id\&quot; property.
     * @param {module:model/Meeting} meeting The user&#39;s room details that you wish to update.
     * @param {module:api/MeetingApi~updateMeetingCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Meeting}
     */
    this.updateMeeting = function(userId, meetingId, meeting, callback) {
      var postBody = meeting;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling updateMeeting");
      }

      // verify the required parameter 'meetingId' is set
      if (meetingId === undefined || meetingId === null) {
        throw new Error("Missing the required parameter 'meetingId' when calling updateMeeting");
      }

      // verify the required parameter 'meeting' is set
      if (meeting === undefined || meeting === null) {
        throw new Error("Missing the required parameter 'meeting' when calling updateMeeting");
      }


      var pathParams = {
        'user_id': userId,
        'meeting_id': meetingId
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = Meeting;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/scheduled_meeting/{meeting_id}', 'PUT',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updateMeetingEndpoint operation.
     * @callback module:api/MeetingApi~updateMeetingEndpointCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Endpoint} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update Endpoint Video/Audio State
     * This endpoint allows you to update an individual endpoint’s ability to send audio or video, and also allows removing an endpoint from the meeting. Requires Meeting access token with moderator privileges
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {String} endpointGuid The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint.
     * @param {Object} opts Optional parameters
     * @param {Boolean} opts.muteAudio Toggle the audio source mute.
     * @param {Boolean} opts.muteVideo Toggle the video source mute.
     * @param {Boolean} opts.leaveMeeting Remove the user from the meeting.
     * @param {module:api/MeetingApi~updateMeetingEndpointCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Endpoint}
     */
    this.updateMeetingEndpoint = function(userId, numericMeetingId, endpointGuid, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling updateMeetingEndpoint");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling updateMeetingEndpoint");
      }

      // verify the required parameter 'endpointGuid' is set
      if (endpointGuid === undefined || endpointGuid === null) {
        throw new Error("Missing the required parameter 'endpointGuid' when calling updateMeetingEndpoint");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId,
        'endpoint_guid': endpointGuid
      };
      var queryParams = {
        'muteAudio': opts['muteAudio'],
        'muteVideo': opts['muteVideo'],
        'leaveMeeting': opts['leaveMeeting'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = Endpoint;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid}', 'PUT',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updateMeetingEndpoints operation.
     * @callback module:api/MeetingApi~updateMeetingEndpointsCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update Meeting Endpoints State
     * This endpoint’s purpose is to be able to modify the endpoints in a meeting. Requires Meeting access token with moderator privileges
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {Object} opts Optional parameters
     * @param {Boolean} opts.mute Allows you to mute/unmute all participants in a meeting. Set mute to true to mute.  Set mute to false to unmute.
     * @param {module:model/String} opts.media Specify the type of media you which to mute/unmute.
     * @param {module:api/MeetingApi~updateMeetingEndpointsCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.updateMeetingEndpoints = function(userId, numericMeetingId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling updateMeetingEndpoints");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling updateMeetingEndpoints");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId
      };
      var queryParams = {
        'mute': opts['mute'],
        'media': opts['media'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints', 'PUT',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updateMeetingState operation.
     * @callback module:api/MeetingApi~updateMeetingStateCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Meeting} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update Meeting State
     * This endpoint’s purpose is to be able to modify a meeting. Actions include locking the meeting, or terminating the meeting.  This API requires a meeting access token with moderator privileges.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {Number} numericMeetingId The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.
     * @param {module:model/PayloadMeetingState} payloadMeetingState The meeting properties that you wish to update.
     * @param {Object} opts Optional parameters
     * @param {Number} opts.delay Number of seconds to delay the end meeting operation.
     * @param {module:api/MeetingApi~updateMeetingStateCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Meeting}
     */
    this.updateMeetingState = function(userId, numericMeetingId, payloadMeetingState, opts, callback) {
      opts = opts || {};
      var postBody = payloadMeetingState;

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling updateMeetingState");
      }

      // verify the required parameter 'numericMeetingId' is set
      if (numericMeetingId === undefined || numericMeetingId === null) {
        throw new Error("Missing the required parameter 'numericMeetingId' when calling updateMeetingState");
      }

      // verify the required parameter 'payloadMeetingState' is set
      if (payloadMeetingState === undefined || payloadMeetingState === null) {
        throw new Error("Missing the required parameter 'payloadMeetingState' when calling updateMeetingState");
      }


      var pathParams = {
        'user_id': userId,
        'numeric_meeting_id': numericMeetingId
      };
      var queryParams = {
        'delay': opts['delay'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['access_token'];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = Meeting;

      return this.apiClient.callApi(
        '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}', 'PUT',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
