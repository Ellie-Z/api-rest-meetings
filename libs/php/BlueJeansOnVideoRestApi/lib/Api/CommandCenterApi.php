<?php
/**
 * CommandCenterApi
 * PHP version 5
 *
 * @category Class
 * @package  BlueJeansOnVideoRestApi
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * BlueJeans Meetings REST API
 *
 * ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr>
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace BlueJeansOnVideoRestApi\Api;

use \BlueJeansOnVideoRestApi\ApiClient;
use \BlueJeansOnVideoRestApi\ApiException;
use \BlueJeansOnVideoRestApi\Configuration;
use \BlueJeansOnVideoRestApi\ObjectSerializer;

/**
 * CommandCenterApi Class Doc Comment
 *
 * @category Class
 * @package  BlueJeansOnVideoRestApi
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class CommandCenterApi
{
    /**
     * API Client
     *
     * @var \BlueJeansOnVideoRestApi\ApiClient instance of the ApiClient
     */
    protected $apiClient;

    /**
     * Constructor
     *
     * @param \BlueJeansOnVideoRestApi\ApiClient|null $apiClient The api client to use
     */
    public function __construct(\BlueJeansOnVideoRestApi\ApiClient $apiClient = null)
    {
        if ($apiClient === null) {
            $apiClient = new ApiClient();
        }

        $this->apiClient = $apiClient;
    }

    /**
     * Get API client
     *
     * @return \BlueJeansOnVideoRestApi\ApiClient get the API client
     */
    public function getApiClient()
    {
        return $this->apiClient;
    }

    /**
     * Set the API client
     *
     * @param \BlueJeansOnVideoRestApi\ApiClient $apiClient set the API client
     *
     * @return CommandCenterApi
     */
    public function setApiClient(\BlueJeansOnVideoRestApi\ApiClient $apiClient)
    {
        $this->apiClient = $apiClient;
        return $this;
    }

    /**
     * Operation getEndpointDistribution
     *
     * Endpoint Distribution
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"creation_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"creation_time"}])
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\AnalyticsEndpointDistribution
     */
    public function getEndpointDistribution($enterprise_id, $filter = '[{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"creation_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"creation_time"}]')
    {
        list($response) = $this->getEndpointDistributionWithHttpInfo($enterprise_id, $filter);
        return $response;
    }

    /**
     * Operation getEndpointDistributionWithHttpInfo
     *
     * Endpoint Distribution
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"creation_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"creation_time"}])
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\AnalyticsEndpointDistribution, HTTP status code, HTTP response headers (array of strings)
     */
    public function getEndpointDistributionWithHttpInfo($enterprise_id, $filter = '[{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"creation_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"creation_time"}]')
    {
        // verify the required parameter 'enterprise_id' is set
        if ($enterprise_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $enterprise_id when calling getEndpointDistribution');
        }
        // parse inputs
        $resourcePath = "/v1/enterprise/{enterprise_id}/indigo/analytics/endpoints/distribution";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // query params
        if ($filter !== null) {
            $queryParams['filter'] = $this->apiClient->getSerializer()->toQueryValue($filter);
        }
        // path params
        if ($enterprise_id !== null) {
            $resourcePath = str_replace(
                "{" . "enterprise_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($enterprise_id),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\AnalyticsEndpointDistribution',
                '/v1/enterprise/{enterprise_id}/indigo/analytics/endpoints/distribution'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\AnalyticsEndpointDistribution', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\AnalyticsEndpointDistribution', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getFeedbackComments
     *
     * Survey Feedback Comments
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param string $end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\AnalyticsFeedbackComments
     */
    public function getFeedbackComments($enterprise_id, $start, $end)
    {
        list($response) = $this->getFeedbackCommentsWithHttpInfo($enterprise_id, $start, $end);
        return $response;
    }

    /**
     * Operation getFeedbackCommentsWithHttpInfo
     *
     * Survey Feedback Comments
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param string $end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\AnalyticsFeedbackComments, HTTP status code, HTTP response headers (array of strings)
     */
    public function getFeedbackCommentsWithHttpInfo($enterprise_id, $start, $end)
    {
        // verify the required parameter 'enterprise_id' is set
        if ($enterprise_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $enterprise_id when calling getFeedbackComments');
        }
        // verify the required parameter 'start' is set
        if ($start === null) {
            throw new \InvalidArgumentException('Missing the required parameter $start when calling getFeedbackComments');
        }
        // verify the required parameter 'end' is set
        if ($end === null) {
            throw new \InvalidArgumentException('Missing the required parameter $end when calling getFeedbackComments');
        }
        // parse inputs
        $resourcePath = "/v1/enterprise/{enterprise_id}/indigo/analytics/feedback/comments";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // query params
        if ($start !== null) {
            $queryParams['start'] = $this->apiClient->getSerializer()->toQueryValue($start);
        }
        // query params
        if ($end !== null) {
            $queryParams['end'] = $this->apiClient->getSerializer()->toQueryValue($end);
        }
        // path params
        if ($enterprise_id !== null) {
            $resourcePath = str_replace(
                "{" . "enterprise_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($enterprise_id),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\AnalyticsFeedbackComments',
                '/v1/enterprise/{enterprise_id}/indigo/analytics/feedback/comments'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\AnalyticsFeedbackComments', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\AnalyticsFeedbackComments', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getFeedbackCount
     *
     * Survey Feedback Scores
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param string $end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\AnalyticsFeedbackScores
     */
    public function getFeedbackCount($enterprise_id, $start, $end)
    {
        list($response) = $this->getFeedbackCountWithHttpInfo($enterprise_id, $start, $end);
        return $response;
    }

    /**
     * Operation getFeedbackCountWithHttpInfo
     *
     * Survey Feedback Scores
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $start Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @param string $end Date and time in an [ISO 8601](https://www.w3.org/TR/NOTE-datetime) format. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\AnalyticsFeedbackScores, HTTP status code, HTTP response headers (array of strings)
     */
    public function getFeedbackCountWithHttpInfo($enterprise_id, $start, $end)
    {
        // verify the required parameter 'enterprise_id' is set
        if ($enterprise_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $enterprise_id when calling getFeedbackCount');
        }
        // verify the required parameter 'start' is set
        if ($start === null) {
            throw new \InvalidArgumentException('Missing the required parameter $start when calling getFeedbackCount');
        }
        // verify the required parameter 'end' is set
        if ($end === null) {
            throw new \InvalidArgumentException('Missing the required parameter $end when calling getFeedbackCount');
        }
        // parse inputs
        $resourcePath = "/v1/enterprise/{enterprise_id}/indigo/feedback/count";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // query params
        if ($start !== null) {
            $queryParams['start'] = $this->apiClient->getSerializer()->toQueryValue($start);
        }
        // query params
        if ($end !== null) {
            $queryParams['end'] = $this->apiClient->getSerializer()->toQueryValue($end);
        }
        // path params
        if ($enterprise_id !== null) {
            $resourcePath = str_replace(
                "{" . "enterprise_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($enterprise_id),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\AnalyticsFeedbackScores',
                '/v1/enterprise/{enterprise_id}/indigo/feedback/count'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\AnalyticsFeedbackScores', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\AnalyticsFeedbackScores', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getMeetingLiveByEnterprise
     *
     * List Live Meeting Endpoints by Enterprise
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $meeting_uuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo
     */
    public function getMeetingLiveByEnterprise($enterprise_id, $meeting_uuid)
    {
        list($response) = $this->getMeetingLiveByEnterpriseWithHttpInfo($enterprise_id, $meeting_uuid);
        return $response;
    }

    /**
     * Operation getMeetingLiveByEnterpriseWithHttpInfo
     *
     * List Live Meeting Endpoints by Enterprise
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $meeting_uuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo, HTTP status code, HTTP response headers (array of strings)
     */
    public function getMeetingLiveByEnterpriseWithHttpInfo($enterprise_id, $meeting_uuid)
    {
        // verify the required parameter 'enterprise_id' is set
        if ($enterprise_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $enterprise_id when calling getMeetingLiveByEnterprise');
        }
        // verify the required parameter 'meeting_uuid' is set
        if ($meeting_uuid === null) {
            throw new \InvalidArgumentException('Missing the required parameter $meeting_uuid when calling getMeetingLiveByEnterprise');
        }
        // parse inputs
        $resourcePath = "/v1/enterprise/{enterprise_id}/indigo/meetings/live/{meeting_uuid}/endpoints/";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // path params
        if ($enterprise_id !== null) {
            $resourcePath = str_replace(
                "{" . "enterprise_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($enterprise_id),
                $resourcePath
            );
        }
        // path params
        if ($meeting_uuid !== null) {
            $resourcePath = str_replace(
                "{" . "meeting_uuid" . "}",
                $this->apiClient->getSerializer()->toPathValue($meeting_uuid),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo',
                '/v1/enterprise/{enterprise_id}/indigo/meetings/live/{meeting_uuid}/endpoints/'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getMeetingPastByEnterprise
     *
     * List Meeting Endpoints & Stats by Enterprise
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $meeting_uuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @param bool $include_endpoints Option to include detailed data on endpoints (optional)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo
     */
    public function getMeetingPastByEnterprise($enterprise_id, $meeting_uuid, $include_endpoints = null)
    {
        list($response) = $this->getMeetingPastByEnterpriseWithHttpInfo($enterprise_id, $meeting_uuid, $include_endpoints);
        return $response;
    }

    /**
     * Operation getMeetingPastByEnterpriseWithHttpInfo
     *
     * List Meeting Endpoints & Stats by Enterprise
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $meeting_uuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @param bool $include_endpoints Option to include detailed data on endpoints (optional)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo, HTTP status code, HTTP response headers (array of strings)
     */
    public function getMeetingPastByEnterpriseWithHttpInfo($enterprise_id, $meeting_uuid, $include_endpoints = null)
    {
        // verify the required parameter 'enterprise_id' is set
        if ($enterprise_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $enterprise_id when calling getMeetingPastByEnterprise');
        }
        // verify the required parameter 'meeting_uuid' is set
        if ($meeting_uuid === null) {
            throw new \InvalidArgumentException('Missing the required parameter $meeting_uuid when calling getMeetingPastByEnterprise');
        }
        // parse inputs
        $resourcePath = "/v1/enterprise/{enterprise_id}/indigo/meetings/{meeting_uuid}";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // query params
        if ($include_endpoints !== null) {
            $queryParams['includeEndpoints'] = $this->apiClient->getSerializer()->toQueryValue($include_endpoints);
        }
        // path params
        if ($enterprise_id !== null) {
            $resourcePath = str_replace(
                "{" . "enterprise_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($enterprise_id),
                $resourcePath
            );
        }
        // path params
        if ($meeting_uuid !== null) {
            $resourcePath = str_replace(
                "{" . "meeting_uuid" . "}",
                $this->apiClient->getSerializer()->toPathValue($meeting_uuid),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo',
                '/v1/enterprise/{enterprise_id}/indigo/meetings/{meeting_uuid}'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getMeetingPastByUser
     *
     * List Meeting Endpoints & Stats by User
     *
     * @param int $user_id The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @param string $meeting_uuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo
     */
    public function getMeetingPastByUser($user_id, $meeting_uuid)
    {
        list($response) = $this->getMeetingPastByUserWithHttpInfo($user_id, $meeting_uuid);
        return $response;
    }

    /**
     * Operation getMeetingPastByUserWithHttpInfo
     *
     * List Meeting Endpoints & Stats by User
     *
     * @param int $user_id The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @param string $meeting_uuid The universally unique identifier (UUID) of the meeting of interest. This value is a string which contains 6 alphanumeric segments separated by dashes. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo, HTTP status code, HTTP response headers (array of strings)
     */
    public function getMeetingPastByUserWithHttpInfo($user_id, $meeting_uuid)
    {
        // verify the required parameter 'user_id' is set
        if ($user_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $user_id when calling getMeetingPastByUser');
        }
        // verify the required parameter 'meeting_uuid' is set
        if ($meeting_uuid === null) {
            throw new \InvalidArgumentException('Missing the required parameter $meeting_uuid when calling getMeetingPastByUser');
        }
        // parse inputs
        $resourcePath = "/v1/user/{user_id}/indigo/meetings/{meeting_uuid}";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // path params
        if ($user_id !== null) {
            $resourcePath = str_replace(
                "{" . "user_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($user_id),
                $resourcePath
            );
        }
        // path params
        if ($meeting_uuid !== null) {
            $resourcePath = str_replace(
                "{" . "meeting_uuid" . "}",
                $this->apiClient->getSerializer()->toPathValue($meeting_uuid),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo',
                '/v1/user/{user_id}/indigo/meetings/{meeting_uuid}'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\MeetingExtendedIndigo', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getMeetingUsage
     *
     * Meeting Usage Over Time
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $client_tz Based on standard TZ code. (optional, default to America/Denver)
     * @param string $filter URL-encoded JSON string (optional, default to [{"type":"string","comparison":"eq","value":"DAY","field":"groupInterval"},{"type":"date","comparison":"eq","value":"2017-01-16T00:00:00-07:00","field":"lowts"},{"type":"date","comparison":"eq","value":"2017-01-23T23:59:59-07:00","field":"hights"}])
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\AnalyticsUsage
     */
    public function getMeetingUsage($enterprise_id, $client_tz = 'America/Denver', $filter = '[{"type":"string","comparison":"eq","value":"DAY","field":"groupInterval"},{"type":"date","comparison":"eq","value":"2017-01-16T00:00:00-07:00","field":"lowts"},{"type":"date","comparison":"eq","value":"2017-01-23T23:59:59-07:00","field":"hights"}]')
    {
        list($response) = $this->getMeetingUsageWithHttpInfo($enterprise_id, $client_tz, $filter);
        return $response;
    }

    /**
     * Operation getMeetingUsageWithHttpInfo
     *
     * Meeting Usage Over Time
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $client_tz Based on standard TZ code. (optional, default to America/Denver)
     * @param string $filter URL-encoded JSON string (optional, default to [{"type":"string","comparison":"eq","value":"DAY","field":"groupInterval"},{"type":"date","comparison":"eq","value":"2017-01-16T00:00:00-07:00","field":"lowts"},{"type":"date","comparison":"eq","value":"2017-01-23T23:59:59-07:00","field":"hights"}])
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\AnalyticsUsage, HTTP status code, HTTP response headers (array of strings)
     */
    public function getMeetingUsageWithHttpInfo($enterprise_id, $client_tz = 'America/Denver', $filter = '[{"type":"string","comparison":"eq","value":"DAY","field":"groupInterval"},{"type":"date","comparison":"eq","value":"2017-01-16T00:00:00-07:00","field":"lowts"},{"type":"date","comparison":"eq","value":"2017-01-23T23:59:59-07:00","field":"hights"}]')
    {
        // verify the required parameter 'enterprise_id' is set
        if ($enterprise_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $enterprise_id when calling getMeetingUsage');
        }
        // parse inputs
        $resourcePath = "/v1/enterprise/{enterprise_id}/indigo/analytics/meetings/usage";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // query params
        if ($client_tz !== null) {
            $queryParams['clientTZ'] = $this->apiClient->getSerializer()->toQueryValue($client_tz);
        }
        // query params
        if ($filter !== null) {
            $queryParams['filter'] = $this->apiClient->getSerializer()->toQueryValue($filter);
        }
        // path params
        if ($enterprise_id !== null) {
            $resourcePath = str_replace(
                "{" . "enterprise_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($enterprise_id),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\AnalyticsUsage',
                '/v1/enterprise/{enterprise_id}/indigo/analytics/meetings/usage'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\AnalyticsUsage', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\AnalyticsUsage', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getMeetingsLiveByEnterprise
     *
     * Live Meetings Summary by Enterprise
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\MeetingIndigoList
     */
    public function getMeetingsLiveByEnterprise($enterprise_id)
    {
        list($response) = $this->getMeetingsLiveByEnterpriseWithHttpInfo($enterprise_id);
        return $response;
    }

    /**
     * Operation getMeetingsLiveByEnterpriseWithHttpInfo
     *
     * Live Meetings Summary by Enterprise
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\MeetingIndigoList, HTTP status code, HTTP response headers (array of strings)
     */
    public function getMeetingsLiveByEnterpriseWithHttpInfo($enterprise_id)
    {
        // verify the required parameter 'enterprise_id' is set
        if ($enterprise_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $enterprise_id when calling getMeetingsLiveByEnterprise');
        }
        // parse inputs
        $resourcePath = "/v1/enterprise/{enterprise_id}/indigo/meetings/live";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // path params
        if ($enterprise_id !== null) {
            $resourcePath = str_replace(
                "{" . "enterprise_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($enterprise_id),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\MeetingIndigoList',
                '/v1/enterprise/{enterprise_id}/indigo/meetings/live'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\MeetingIndigoList', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\MeetingIndigoList', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getMeetingsPastByEnterprise
     *
     * List Past Meetings by Enterprise
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param int $offset Page Number (optional)
     * @param int $limit Per page (optional)
     * @param string $filter URL-encoded JSON string (optional)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\MeetingIndigoList
     */
    public function getMeetingsPastByEnterprise($enterprise_id, $offset = null, $limit = null, $filter = null)
    {
        list($response) = $this->getMeetingsPastByEnterpriseWithHttpInfo($enterprise_id, $offset, $limit, $filter);
        return $response;
    }

    /**
     * Operation getMeetingsPastByEnterpriseWithHttpInfo
     *
     * List Past Meetings by Enterprise
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param int $offset Page Number (optional)
     * @param int $limit Per page (optional)
     * @param string $filter URL-encoded JSON string (optional)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\MeetingIndigoList, HTTP status code, HTTP response headers (array of strings)
     */
    public function getMeetingsPastByEnterpriseWithHttpInfo($enterprise_id, $offset = null, $limit = null, $filter = null)
    {
        // verify the required parameter 'enterprise_id' is set
        if ($enterprise_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $enterprise_id when calling getMeetingsPastByEnterprise');
        }
        // parse inputs
        $resourcePath = "/v1/enterprise/{enterprise_id}/indigo/meetings";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // query params
        if ($offset !== null) {
            $queryParams['offset'] = $this->apiClient->getSerializer()->toQueryValue($offset);
        }
        // query params
        if ($limit !== null) {
            $queryParams['limit'] = $this->apiClient->getSerializer()->toQueryValue($limit);
        }
        // query params
        if ($filter !== null) {
            $queryParams['filter'] = $this->apiClient->getSerializer()->toQueryValue($filter);
        }
        // path params
        if ($enterprise_id !== null) {
            $resourcePath = str_replace(
                "{" . "enterprise_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($enterprise_id),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\MeetingIndigoList',
                '/v1/enterprise/{enterprise_id}/indigo/meetings'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\MeetingIndigoList', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\MeetingIndigoList', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getMeetingsPastByUser
     *
     * List Past Meetings by User
     *
     * @param int $user_id The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\MeetingIndigoList
     */
    public function getMeetingsPastByUser($user_id)
    {
        list($response) = $this->getMeetingsPastByUserWithHttpInfo($user_id);
        return $response;
    }

    /**
     * Operation getMeetingsPastByUserWithHttpInfo
     *
     * List Past Meetings by User
     *
     * @param int $user_id The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\MeetingIndigoList, HTTP status code, HTTP response headers (array of strings)
     */
    public function getMeetingsPastByUserWithHttpInfo($user_id)
    {
        // verify the required parameter 'user_id' is set
        if ($user_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $user_id when calling getMeetingsPastByUser');
        }
        // parse inputs
        $resourcePath = "/v1/user/{user_id}/indigo/meetings";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // path params
        if ($user_id !== null) {
            $resourcePath = str_replace(
                "{" . "user_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($user_id),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\MeetingIndigoList',
                '/v1/user/{user_id}/indigo/meetings'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\MeetingIndigoList', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\MeetingIndigoList', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getRoiRanges
     *
     * ROI Data
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $filter URL-encoded JSON string (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\AnalyticsRoiData
     */
    public function getRoiRanges($enterprise_id, $filter)
    {
        list($response) = $this->getRoiRangesWithHttpInfo($enterprise_id, $filter);
        return $response;
    }

    /**
     * Operation getRoiRangesWithHttpInfo
     *
     * ROI Data
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $filter URL-encoded JSON string (required)
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\AnalyticsRoiData, HTTP status code, HTTP response headers (array of strings)
     */
    public function getRoiRangesWithHttpInfo($enterprise_id, $filter)
    {
        // verify the required parameter 'enterprise_id' is set
        if ($enterprise_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $enterprise_id when calling getRoiRanges');
        }
        // verify the required parameter 'filter' is set
        if ($filter === null) {
            throw new \InvalidArgumentException('Missing the required parameter $filter when calling getRoiRanges');
        }
        // parse inputs
        $resourcePath = "/v1/enterprise/{enterprise_id}/indigo/analytics/roi_ranges";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // query params
        if ($filter !== null) {
            $queryParams['filter'] = $this->apiClient->getSerializer()->toQueryValue($filter);
        }
        // path params
        if ($enterprise_id !== null) {
            $resourcePath = str_replace(
                "{" . "enterprise_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($enterprise_id),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\AnalyticsRoiData',
                '/v1/enterprise/{enterprise_id}/indigo/analytics/roi_ranges'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\AnalyticsRoiData', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\AnalyticsRoiData', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getTopUsers
     *
     * Top Users
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"start_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"end_time"}])
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return \BlueJeansOnVideoRestApi\Model\AnalyticsTopUsers
     */
    public function getTopUsers($enterprise_id, $filter = '[{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"start_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"end_time"}]')
    {
        list($response) = $this->getTopUsersWithHttpInfo($enterprise_id, $filter);
        return $response;
    }

    /**
     * Operation getTopUsersWithHttpInfo
     *
     * Top Users
     *
     * @param int $enterprise_id The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint. (required)
     * @param string $filter URL-encoded JSON string (optional, default to [{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"start_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"end_time"}])
     * @throws \BlueJeansOnVideoRestApi\ApiException on non-2xx response
     * @return array of \BlueJeansOnVideoRestApi\Model\AnalyticsTopUsers, HTTP status code, HTTP response headers (array of strings)
     */
    public function getTopUsersWithHttpInfo($enterprise_id, $filter = '[{"type":"date","comparison":"gt","value":"2017-01-16T00:00:00-07:00","field":"start_time"},{"type":"date","comparison":"lt","value":"2017-01-23T23:59:59-07:00","field":"end_time"}]')
    {
        // verify the required parameter 'enterprise_id' is set
        if ($enterprise_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $enterprise_id when calling getTopUsers');
        }
        // parse inputs
        $resourcePath = "/v1/enterprise/{enterprise_id}/indigo/analytics/users/usage";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType([]);

        // query params
        if ($filter !== null) {
            $queryParams['filter'] = $this->apiClient->getSerializer()->toQueryValue($filter);
        }
        // path params
        if ($enterprise_id !== null) {
            $resourcePath = str_replace(
                "{" . "enterprise_id" . "}",
                $this->apiClient->getSerializer()->toPathValue($enterprise_id),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('access_token');
        if (strlen($apiKey) !== 0) {
            $queryParams['access_token'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\BlueJeansOnVideoRestApi\Model\AnalyticsTopUsers',
                '/v1/enterprise/{enterprise_id}/indigo/analytics/users/usage'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\BlueJeansOnVideoRestApi\Model\AnalyticsTopUsers', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\AnalyticsTopUsers', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
                default:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\BlueJeansOnVideoRestApi\Model\Error', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }
}
