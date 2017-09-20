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
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.BlueJeansOnVideoRestApi) {
      root.BlueJeansOnVideoRestApi = {};
    }
    root.BlueJeansOnVideoRestApi.PayloadPairingCodeSIP = factory(root.BlueJeansOnVideoRestApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The PayloadPairingCodeSIP model module.
   * @module model/PayloadPairingCodeSIP
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>PayloadPairingCodeSIP</code>.
   * @alias module:model/PayloadPairingCodeSIP
   * @class
   * @param endpointType {Number} 1:GENERIC 2:LYNC 3:JABBER 4:BluejeansBrowser 5:BluejeansMobile
   */
  var exports = function(endpointType) {
    var _this = this;

    _this['endpointType'] = endpointType;



  };

  /**
   * Constructs a <code>PayloadPairingCodeSIP</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PayloadPairingCodeSIP} obj Optional instance to populate.
   * @return {module:model/PayloadPairingCodeSIP} The populated <code>PayloadPairingCodeSIP</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('endpointType')) {
        obj['endpointType'] = ApiClient.convertToType(data['endpointType'], 'Number');
      }
      if (data.hasOwnProperty('userId')) {
        obj['userId'] = ApiClient.convertToType(data['userId'], 'Number');
      }
      if (data.hasOwnProperty('languageCode')) {
        obj['languageCode'] = ApiClient.convertToType(data['languageCode'], 'String');
      }
      if (data.hasOwnProperty('endpointName')) {
        obj['endpointName'] = ApiClient.convertToType(data['endpointName'], 'String');
      }
    }
    return obj;
  }

  /**
   * 1:GENERIC 2:LYNC 3:JABBER 4:BluejeansBrowser 5:BluejeansMobile
   * @member {Number} endpointType
   */
  exports.prototype['endpointType'] = undefined;
  /**
   * Optional database id of user associated with endpoint
   * @member {Number} userId
   */
  exports.prototype['userId'] = undefined;
  /**
   * Optional language code
   * @member {module:model/PayloadPairingCodeSIP.LanguageCodeEnum} languageCode
   * @default 'en'
   */
  exports.prototype['languageCode'] = 'en';
  /**
   * Optional name of endpoint
   * @member {String} endpointName
   * @default 'My Test Endpoint'
   */
  exports.prototype['endpointName'] = 'My Test Endpoint';


  /**
   * Allowed values for the <code>languageCode</code> property.
   * @enum {String}
   * @readonly
   */
  exports.LanguageCodeEnum = {
    /**
     * value: "en"
     * @const
     */
    "en": "en",
    /**
     * value: "en-us"
     * @const
     */
    "en-us": "en-us",
    /**
     * value: "en-gb"
     * @const
     */
    "en-gb": "en-gb",
    /**
     * value: "de"
     * @const
     */
    "de": "de"  };


  return exports;
}));


