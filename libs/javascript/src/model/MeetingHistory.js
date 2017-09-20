/**
 * BlueJeans onVideo REST API
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by an access code.  THe access code can ensure security of participants who can join, and also designate user(s) who need an ability to moderate a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>, and may be assigned a moderator passcode allowing designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About onVideo Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.2.3
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/MeetingHistoryLeaderInfo', 'model/MeetingHistoryParticipantList'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./MeetingHistoryLeaderInfo'), require('./MeetingHistoryParticipantList'));
  } else {
    // Browser globals (root is window)
    if (!root.BlueJeansOnVideoRestApi) {
      root.BlueJeansOnVideoRestApi = {};
    }
    root.BlueJeansOnVideoRestApi.MeetingHistory = factory(root.BlueJeansOnVideoRestApi.ApiClient, root.BlueJeansOnVideoRestApi.MeetingHistoryLeaderInfo, root.BlueJeansOnVideoRestApi.MeetingHistoryParticipantList);
  }
}(this, function(ApiClient, MeetingHistoryLeaderInfo, MeetingHistoryParticipantList) {
  'use strict';




  /**
   * The MeetingHistory model module.
   * @module model/MeetingHistory
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>MeetingHistory</code>.
   * @alias module:model/MeetingHistory
   * @class
   */
  var exports = function() {
    var _this = this;


























  };

  /**
   * Constructs a <code>MeetingHistory</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/MeetingHistory} obj Optional instance to populate.
   * @return {module:model/MeetingHistory} The populated <code>MeetingHistory</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('meetingGuid')) {
        obj['meetingGuid'] = ApiClient.convertToType(data['meetingGuid'], 'String');
      }
      if (data.hasOwnProperty('meetingNumericId')) {
        obj['meetingNumericId'] = ApiClient.convertToType(data['meetingNumericId'], 'String');
      }
      if (data.hasOwnProperty('title')) {
        obj['title'] = ApiClient.convertToType(data['title'], 'String');
      }
      if (data.hasOwnProperty('description')) {
        obj['description'] = ApiClient.convertToType(data['description'], 'String');
      }
      if (data.hasOwnProperty('leaderInfo')) {
        obj['leaderInfo'] = MeetingHistoryLeaderInfo.constructFromObject(data['leaderInfo']);
      }
      if (data.hasOwnProperty('userId')) {
        obj['userId'] = ApiClient.convertToType(data['userId'], 'Number');
      }
      if (data.hasOwnProperty('meetingDuration')) {
        obj['meetingDuration'] = ApiClient.convertToType(data['meetingDuration'], 'Number');
      }
      if (data.hasOwnProperty('maxParticipantCount')) {
        obj['maxParticipantCount'] = ApiClient.convertToType(data['maxParticipantCount'], 'Number');
      }
      if (data.hasOwnProperty('totalParticipantMinutes')) {
        obj['totalParticipantMinutes'] = ApiClient.convertToType(data['totalParticipantMinutes'], 'Number');
      }
      if (data.hasOwnProperty('maxParticipantMinutes')) {
        obj['maxParticipantMinutes'] = ApiClient.convertToType(data['maxParticipantMinutes'], 'Number');
      }
      if (data.hasOwnProperty('extraParticipantMinutes')) {
        obj['extraParticipantMinutes'] = ApiClient.convertToType(data['extraParticipantMinutes'], 'Number');
      }
      if (data.hasOwnProperty('isdnEndpoints')) {
        obj['isdnEndpoints'] = ApiClient.convertToType(data['isdnEndpoints'], 'Number');
      }
      if (data.hasOwnProperty('totalDialoutMinutes')) {
        obj['totalDialoutMinutes'] = ApiClient.convertToType(data['totalDialoutMinutes'], 'Number');
      }
      if (data.hasOwnProperty('totalTollFreeMinutes')) {
        obj['totalTollFreeMinutes'] = ApiClient.convertToType(data['totalTollFreeMinutes'], 'Number');
      }
      if (data.hasOwnProperty('callDIDMinutes')) {
        obj['callDIDMinutes'] = ApiClient.convertToType(data['callDIDMinutes'], 'Number');
      }
      if (data.hasOwnProperty('startTime')) {
        obj['startTime'] = ApiClient.convertToType(data['startTime'], 'Number');
      }
      if (data.hasOwnProperty('endTime')) {
        obj['endTime'] = ApiClient.convertToType(data['endTime'], 'Number');
      }
      if (data.hasOwnProperty('meetingStatus')) {
        obj['meetingStatus'] = ApiClient.convertToType(data['meetingStatus'], 'String');
      }
      if (data.hasOwnProperty('meetingThumbnail')) {
        obj['meetingThumbnail'] = ApiClient.convertToType(data['meetingThumbnail'], 'String');
      }
      if (data.hasOwnProperty('startTimeZone')) {
        obj['startTimeZone'] = ApiClient.convertToType(data['startTimeZone'], 'String');
      }
      if (data.hasOwnProperty('processingStatus')) {
        obj['processingStatus'] = ApiClient.convertToType(data['processingStatus'], 'String');
      }
      if (data.hasOwnProperty('concurrentCalls')) {
        obj['concurrentCalls'] = ApiClient.convertToType(data['concurrentCalls'], 'String');
      }
      if (data.hasOwnProperty('uploadStatus')) {
        obj['uploadStatus'] = ApiClient.convertToType(data['uploadStatus'], 'String');
      }
      if (data.hasOwnProperty('pstnonly')) {
        obj['pstnonly'] = ApiClient.convertToType(data['pstnonly'], 'Boolean');
      }
      if (data.hasOwnProperty('participantList')) {
        obj['participantList'] = ApiClient.convertToType(data['participantList'], [MeetingHistoryParticipantList]);
      }
    }
    return obj;
  }

  /**
   * @member {String} meetingGuid
   */
  exports.prototype['meetingGuid'] = undefined;
  /**
   * @member {String} meetingNumericId
   */
  exports.prototype['meetingNumericId'] = undefined;
  /**
   * @member {String} title
   */
  exports.prototype['title'] = undefined;
  /**
   * @member {String} description
   */
  exports.prototype['description'] = undefined;
  /**
   * @member {module:model/MeetingHistoryLeaderInfo} leaderInfo
   */
  exports.prototype['leaderInfo'] = undefined;
  /**
   * @member {Number} userId
   */
  exports.prototype['userId'] = undefined;
  /**
   * @member {Number} meetingDuration
   */
  exports.prototype['meetingDuration'] = undefined;
  /**
   * @member {Number} maxParticipantCount
   */
  exports.prototype['maxParticipantCount'] = undefined;
  /**
   * @member {Number} totalParticipantMinutes
   */
  exports.prototype['totalParticipantMinutes'] = undefined;
  /**
   * @member {Number} maxParticipantMinutes
   */
  exports.prototype['maxParticipantMinutes'] = undefined;
  /**
   * @member {Number} extraParticipantMinutes
   */
  exports.prototype['extraParticipantMinutes'] = undefined;
  /**
   * @member {Number} isdnEndpoints
   */
  exports.prototype['isdnEndpoints'] = undefined;
  /**
   * @member {Number} totalDialoutMinutes
   */
  exports.prototype['totalDialoutMinutes'] = undefined;
  /**
   * @member {Number} totalTollFreeMinutes
   */
  exports.prototype['totalTollFreeMinutes'] = undefined;
  /**
   * @member {Number} callDIDMinutes
   */
  exports.prototype['callDIDMinutes'] = undefined;
  /**
   * @member {Number} startTime
   */
  exports.prototype['startTime'] = undefined;
  /**
   * @member {Number} endTime
   */
  exports.prototype['endTime'] = undefined;
  /**
   * @member {module:model/MeetingHistory.MeetingStatusEnum} meetingStatus
   */
  exports.prototype['meetingStatus'] = undefined;
  /**
   * @member {String} meetingThumbnail
   */
  exports.prototype['meetingThumbnail'] = undefined;
  /**
   * @member {String} startTimeZone
   */
  exports.prototype['startTimeZone'] = undefined;
  /**
   * @member {module:model/MeetingHistory.ProcessingStatusEnum} processingStatus
   */
  exports.prototype['processingStatus'] = undefined;
  /**
   * @member {String} concurrentCalls
   */
  exports.prototype['concurrentCalls'] = undefined;
  /**
   * @member {String} uploadStatus
   */
  exports.prototype['uploadStatus'] = undefined;
  /**
   * @member {Boolean} pstnonly
   */
  exports.prototype['pstnonly'] = undefined;
  /**
   * @member {Array.<module:model/MeetingHistoryParticipantList>} participantList
   */
  exports.prototype['participantList'] = undefined;


  /**
   * Allowed values for the <code>meetingStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.MeetingStatusEnum = {
    /**
     * value: "Complete"
     * @const
     */
    "Complete": "Complete"  };

  /**
   * Allowed values for the <code>processingStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.ProcessingStatusEnum = {
    /**
     * value: "PROCESSED"
     * @const
     */
    "PROCESSED": "PROCESSED"  };


  return exports;
}));


