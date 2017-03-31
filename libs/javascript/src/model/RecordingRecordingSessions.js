/**
 * BlueJeans onVideo REST API
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/RecordingStartedBy'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./RecordingStartedBy'));
  } else {
    // Browser globals (root is window)
    if (!root.BlueJeansOnVideoRestApi) {
      root.BlueJeansOnVideoRestApi = {};
    }
    root.BlueJeansOnVideoRestApi.RecordingRecordingSessions = factory(root.BlueJeansOnVideoRestApi.ApiClient, root.BlueJeansOnVideoRestApi.RecordingStartedBy);
  }
}(this, function(ApiClient, RecordingStartedBy) {
  'use strict';




  /**
   * The RecordingRecordingSessions model module.
   * @module model/RecordingRecordingSessions
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>RecordingRecordingSessions</code>.
   * @alias module:model/RecordingRecordingSessions
   * @class
   */
  var exports = function() {
    var _this = this;











  };

  /**
   * Constructs a <code>RecordingRecordingSessions</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RecordingRecordingSessions} obj Optional instance to populate.
   * @return {module:model/RecordingRecordingSessions} The populated <code>RecordingRecordingSessions</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'Integer');
      }
      if (data.hasOwnProperty('contentStatus')) {
        obj['contentStatus'] = ApiClient.convertToType(data['contentStatus'], 'String');
      }
      if (data.hasOwnProperty('recordingType')) {
        obj['recordingType'] = ApiClient.convertToType(data['recordingType'], 'String');
      }
      if (data.hasOwnProperty('contentId')) {
        obj['contentId'] = ApiClient.convertToType(data['contentId'], 'Integer');
      }
      if (data.hasOwnProperty('thumbnailUrl')) {
        obj['thumbnailUrl'] = ApiClient.convertToType(data['thumbnailUrl'], 'String');
      }
      if (data.hasOwnProperty('startTimeOffset')) {
        obj['startTimeOffset'] = ApiClient.convertToType(data['startTimeOffset'], 'Integer');
      }
      if (data.hasOwnProperty('endTimeOffset')) {
        obj['endTimeOffset'] = ApiClient.convertToType(data['endTimeOffset'], 'Integer');
      }
      if (data.hasOwnProperty('duration')) {
        obj['duration'] = ApiClient.convertToType(data['duration'], 'Integer');
      }
      if (data.hasOwnProperty('startedBy')) {
        obj['startedBy'] = RecordingStartedBy.constructFromObject(data['startedBy']);
      }
      if (data.hasOwnProperty('stoppedBy')) {
        obj['stoppedBy'] = RecordingStartedBy.constructFromObject(data['stoppedBy']);
      }
    }
    return obj;
  }

  /**
   * @member {Integer} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {String} contentStatus
   */
  exports.prototype['contentStatus'] = undefined;
  /**
   * @member {String} recordingType
   */
  exports.prototype['recordingType'] = undefined;
  /**
   * @member {Integer} contentId
   */
  exports.prototype['contentId'] = undefined;
  /**
   * @member {String} thumbnailUrl
   */
  exports.prototype['thumbnailUrl'] = undefined;
  /**
   * @member {Integer} startTimeOffset
   */
  exports.prototype['startTimeOffset'] = undefined;
  /**
   * @member {Integer} endTimeOffset
   */
  exports.prototype['endTimeOffset'] = undefined;
  /**
   * @member {Integer} duration
   */
  exports.prototype['duration'] = undefined;
  /**
   * @member {module:model/RecordingStartedBy} startedBy
   */
  exports.prototype['startedBy'] = undefined;
  /**
   * @member {module:model/RecordingStartedBy} stoppedBy
   */
  exports.prototype['stoppedBy'] = undefined;



  return exports;
}));


