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
    define(['ApiClient', 'model/EnterpriseCreateUser', 'model/EnterpriseUserSearch', 'model/Error', 'model/TagListComp', 'model/UserId'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/EnterpriseCreateUser'), require('../model/EnterpriseUserSearch'), require('../model/Error'), require('../model/TagListComp'), require('../model/UserId'));
  } else {
    // Browser globals (root is window)
    if (!root.BlueJeansMeetingsRestApi) {
      root.BlueJeansMeetingsRestApi = {};
    }
    root.BlueJeansMeetingsRestApi.EnterpriseApi = factory(root.BlueJeansMeetingsRestApi.ApiClient, root.BlueJeansMeetingsRestApi.EnterpriseCreateUser, root.BlueJeansMeetingsRestApi.EnterpriseUserSearch, root.BlueJeansMeetingsRestApi.Error, root.BlueJeansMeetingsRestApi.TagListComp, root.BlueJeansMeetingsRestApi.UserId);
  }
}(this, function(ApiClient, EnterpriseCreateUser, EnterpriseUserSearch, Error, TagListComp, UserId) {
  'use strict';

  /**
   * Enterprise service.
   * @module api/EnterpriseApi
   * @version 1.0.4407232018
   */

  /**
   * Constructs a new EnterpriseApi. 
   * @alias module:api/EnterpriseApi
   * @class
   * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
   * default to {@link module:ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the changeEnterpriseTags operation.
     * @callback module:api/EnterpriseApi~changeEnterpriseTagsCallback
     * @param {String} error Error message, if any.
     * @param {module:model/TagListComp} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Set Enterprise Tags
     * This endpoint modifies the list of profile tags associated with the specified enterprise.
     * @param {Number} enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
     * @param {module:model/String} action Type of operation to be done
     * @param {String} tag The name of tag
     * @param {module:api/EnterpriseApi~changeEnterpriseTagsCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/TagListComp}
     */
    this.changeEnterpriseTags = function(enterpriseId, action, tag, callback) {
      var postBody = null;

      // verify the required parameter 'enterpriseId' is set
      if (enterpriseId === undefined || enterpriseId === null) {
        throw new Error("Missing the required parameter 'enterpriseId' when calling changeEnterpriseTags");
      }

      // verify the required parameter 'action' is set
      if (action === undefined || action === null) {
        throw new Error("Missing the required parameter 'action' when calling changeEnterpriseTags");
      }

      // verify the required parameter 'tag' is set
      if (tag === undefined || tag === null) {
        throw new Error("Missing the required parameter 'tag' when calling changeEnterpriseTags");
      }


      var pathParams = {
        'enterpriseId': enterpriseId
      };
      var queryParams = {
        'action': action,
        'tag': tag,
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
      var returnType = TagListComp;

      return this.apiClient.callApi(
        '/v1/enterprise/{enterpriseId}/tags', 'PUT',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the createEnterpriseUser operation.
     * @callback module:api/EnterpriseApi~createEnterpriseUserCallback
     * @param {String} error Error message, if any.
     * @param {module:model/UserId} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create User
     * This endpoint creates a user profile within the specified enterprise.  It is the first of the 2-step process to create a BlueJeans user.  It should be followed by an API call to create the user&#39;s personal meeting room.
     * @param {Number} enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
     * @param {module:model/EnterpriseCreateUser} enterpriseUser Basic Enterprise Account information
     * @param {Object} opts Optional parameters
     * @param {String} opts.billingCategory What general billing group does this profile belong? (default to ENTERPRISE)
     * @param {Boolean} opts.forcePasswordChange Create profile and force user to change password on next login
     * @param {Boolean} opts.isAdmin Create this account to have Administrative Privileges for the enterprise
     * @param {module:api/EnterpriseApi~createEnterpriseUserCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/UserId}
     */
    this.createEnterpriseUser = function(enterpriseId, enterpriseUser, opts, callback) {
      opts = opts || {};
      var postBody = enterpriseUser;

      // verify the required parameter 'enterpriseId' is set
      if (enterpriseId === undefined || enterpriseId === null) {
        throw new Error("Missing the required parameter 'enterpriseId' when calling createEnterpriseUser");
      }

      // verify the required parameter 'enterpriseUser' is set
      if (enterpriseUser === undefined || enterpriseUser === null) {
        throw new Error("Missing the required parameter 'enterpriseUser' when calling createEnterpriseUser");
      }


      var pathParams = {
        'enterpriseId': enterpriseId
      };
      var queryParams = {
        'billingCategory': opts['billingCategory'],
        'forcePasswordChange': opts['forcePasswordChange'],
        'isAdmin': opts['isAdmin'],
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
      var returnType = UserId;

      return this.apiClient.callApi(
        '/v1/enterprise/{enterpriseId}/users', 'POST',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the exportUsers operation.
     * @callback module:api/EnterpriseApi~exportUsersCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Export Enterprise Users
     * This endpoint exports existing users into a CSV file.
     * @param {Number} enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
     * @param {module:api/EnterpriseApi~exportUsersCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.exportUsers = function(enterpriseId, callback) {
      var postBody = null;

      // verify the required parameter 'enterpriseId' is set
      if (enterpriseId === undefined || enterpriseId === null) {
        throw new Error("Missing the required parameter 'enterpriseId' when calling exportUsers");
      }


      var pathParams = {
        'enterprise_id': enterpriseId
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
      var accepts = ['text/csv'];
      var returnType = null;

      return this.apiClient.callApi(
        '/v1/enterprise/{enterprise_id}/users/export', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getEnterpriseTags operation.
     * @callback module:api/EnterpriseApi~getEnterpriseTagsCallback
     * @param {String} error Error message, if any.
     * @param {module:model/TagListComp} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * List Enterprise Tags
     * This endpoint retrieves all profile tags defined for the specified enterprise.
     * @param {Number} enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
     * @param {module:api/EnterpriseApi~getEnterpriseTagsCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/TagListComp}
     */
    this.getEnterpriseTags = function(enterpriseId, callback) {
      var postBody = null;

      // verify the required parameter 'enterpriseId' is set
      if (enterpriseId === undefined || enterpriseId === null) {
        throw new Error("Missing the required parameter 'enterpriseId' when calling getEnterpriseTags");
      }


      var pathParams = {
        'enterpriseId': enterpriseId
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
      var returnType = TagListComp;

      return this.apiClient.callApi(
        '/v1/enterprise/{enterpriseId}/tags', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the removeUser operation.
     * @callback module:api/EnterpriseApi~removeUserCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Remove Enterprise User
     * This endpoint allows removing a user from an enterprise; it does not delete the user. Requires enterprise admin access level.
     * @param {Number} enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
     * @param {Number} userId The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint.
     * @param {module:api/EnterpriseApi~removeUserCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.removeUser = function(enterpriseId, userId, callback) {
      var postBody = null;

      // verify the required parameter 'enterpriseId' is set
      if (enterpriseId === undefined || enterpriseId === null) {
        throw new Error("Missing the required parameter 'enterpriseId' when calling removeUser");
      }

      // verify the required parameter 'userId' is set
      if (userId === undefined || userId === null) {
        throw new Error("Missing the required parameter 'userId' when calling removeUser");
      }


      var pathParams = {
        'enterprise_id': enterpriseId,
        'user_id': userId
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
        '/v1/enterprise/{enterprise_id}/users/{user_id}', 'DELETE',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the searchUsers operation.
     * @callback module:api/EnterpriseApi~searchUsersCallback
     * @param {String} error Error message, if any.
     * @param {module:model/EnterpriseUserSearch} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Search for User(s)
     * This endpoint provides a search facility for the specified enterprise.  &lt;ul&gt;&lt;li&gt;If textSearch is provided, the results will be a partial string-match search of the given textSearch value.&lt;/li&gt;&lt;li&gt; Otherwise, the search will return an exact lookup by emailId.&lt;/li&gt;&lt;/ul&gt;
     * @param {Number} enterpriseId The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
     * @param {Object} opts Optional parameters
     * @param {String} opts.fields A comma-separated list one or more of these BlueJeans enteprise profile fields to include in the API responses- username, firstName, middleName, lastName, isEnterpriseAdmin, enterpriseJoinDate, email
     * @param {module:model/String} opts.order If specificed, order defines how the API sorts results- ascending or descending
     * @param {String} opts.sortBy Name of BlueJeans profile field by with API response data is sorted
     * @param {String} opts.textSearch If specified textSearch provides a string (partial or complete) by which to search the list of BlueJeans users
     * @param {String} opts.emailId If specified, emailId specifies performing a search for the user profile associated with this email address.  Wildcards are &lt;b&gt;not&lt;/b&gt; supported for the email address value.
     * @param {Number} opts.pageSize Sets number of items returned per page.
     * @param {Number} opts.pageNumber Selects which page of results to return (1-based value)
     * @param {module:api/EnterpriseApi~searchUsersCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/EnterpriseUserSearch}
     */
    this.searchUsers = function(enterpriseId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'enterpriseId' is set
      if (enterpriseId === undefined || enterpriseId === null) {
        throw new Error("Missing the required parameter 'enterpriseId' when calling searchUsers");
      }


      var pathParams = {
        'enterpriseId': enterpriseId
      };
      var queryParams = {
        'fields': opts['fields'],
        'order': opts['order'],
        'sortBy': opts['sortBy'],
        'textSearch': opts['textSearch'],
        'emailId': opts['emailId'],
        'pageSize': opts['pageSize'],
        'pageNumber': opts['pageNumber'],
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
      var returnType = EnterpriseUserSearch;

      return this.apiClient.callApi(
        '/v1/enterprise/{enterpriseId}/users', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
