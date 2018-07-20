<?php
/**
 * RecordingSession
 *
 * PHP version 5
 *
 * @category Class
 * @package  BlueJeansMeetingsRestApi
 * @author   Swaagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * BlueJeans Meetings REST API
 *
 * ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/010/2018 </alert>Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr>
 *
 * OpenAPI spec version: 1.0.4407102018
 * Contact: glenn@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace BlueJeansMeetingsRestApi\Model;

use \ArrayAccess;

/**
 * RecordingSession Class Doc Comment
 *
 * @category    Class
 * @package     BlueJeansMeetingsRestApi
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class RecordingSession implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'RecordingSession';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'id' => 'int',
        'content_status' => 'string',
        'recording_type' => 'string',
        'content_id' => 'int',
        'thumbnail_url' => 'string',
        'start_time_offset' => 'int',
        'end_time_offset' => 'int',
        'duration' => 'int',
        'started_by' => '\BlueJeansMeetingsRestApi\Model\RecordingSessionStartedBy',
        'stopped_by' => '\BlueJeansMeetingsRestApi\Model\RecordingSessionStartedBy'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerFormats = [
        'id' => null,
        'content_status' => null,
        'recording_type' => null,
        'content_id' => null,
        'thumbnail_url' => null,
        'start_time_offset' => null,
        'end_time_offset' => null,
        'duration' => null,
        'started_by' => null,
        'stopped_by' => null
    ];

    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name, and the value is the original name
     * @var string[]
     */
    protected static $attributeMap = [
        'id' => 'id',
        'content_status' => 'contentStatus',
        'recording_type' => 'recordingType',
        'content_id' => 'contentId',
        'thumbnail_url' => 'thumbnailUrl',
        'start_time_offset' => 'startTimeOffset',
        'end_time_offset' => 'endTimeOffset',
        'duration' => 'duration',
        'started_by' => 'startedBy',
        'stopped_by' => 'stoppedBy'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'id' => 'setId',
        'content_status' => 'setContentStatus',
        'recording_type' => 'setRecordingType',
        'content_id' => 'setContentId',
        'thumbnail_url' => 'setThumbnailUrl',
        'start_time_offset' => 'setStartTimeOffset',
        'end_time_offset' => 'setEndTimeOffset',
        'duration' => 'setDuration',
        'started_by' => 'setStartedBy',
        'stopped_by' => 'setStoppedBy'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'id' => 'getId',
        'content_status' => 'getContentStatus',
        'recording_type' => 'getRecordingType',
        'content_id' => 'getContentId',
        'thumbnail_url' => 'getThumbnailUrl',
        'start_time_offset' => 'getStartTimeOffset',
        'end_time_offset' => 'getEndTimeOffset',
        'duration' => 'getDuration',
        'started_by' => 'getStartedBy',
        'stopped_by' => 'getStoppedBy'
    ];

    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    public static function setters()
    {
        return self::$setters;
    }

    public static function getters()
    {
        return self::$getters;
    }

    

    

    /**
     * Associative array for storing property values
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     * @param mixed[] $data Associated array of property values initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['id'] = isset($data['id']) ? $data['id'] : null;
        $this->container['content_status'] = isset($data['content_status']) ? $data['content_status'] : null;
        $this->container['recording_type'] = isset($data['recording_type']) ? $data['recording_type'] : null;
        $this->container['content_id'] = isset($data['content_id']) ? $data['content_id'] : null;
        $this->container['thumbnail_url'] = isset($data['thumbnail_url']) ? $data['thumbnail_url'] : null;
        $this->container['start_time_offset'] = isset($data['start_time_offset']) ? $data['start_time_offset'] : null;
        $this->container['end_time_offset'] = isset($data['end_time_offset']) ? $data['end_time_offset'] : null;
        $this->container['duration'] = isset($data['duration']) ? $data['duration'] : null;
        $this->container['started_by'] = isset($data['started_by']) ? $data['started_by'] : null;
        $this->container['stopped_by'] = isset($data['stopped_by']) ? $data['stopped_by'] : null;
    }

    /**
     * show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalid_properties = [];

        return $invalid_properties;
    }

    /**
     * validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {

        return true;
    }


    /**
     * Gets id
     * @return int
     */
    public function getId()
    {
        return $this->container['id'];
    }

    /**
     * Sets id
     * @param int $id
     * @return $this
     */
    public function setId($id)
    {
        $this->container['id'] = $id;

        return $this;
    }

    /**
     * Gets content_status
     * @return string
     */
    public function getContentStatus()
    {
        return $this->container['content_status'];
    }

    /**
     * Sets content_status
     * @param string $content_status
     * @return $this
     */
    public function setContentStatus($content_status)
    {
        $this->container['content_status'] = $content_status;

        return $this;
    }

    /**
     * Gets recording_type
     * @return string
     */
    public function getRecordingType()
    {
        return $this->container['recording_type'];
    }

    /**
     * Sets recording_type
     * @param string $recording_type
     * @return $this
     */
    public function setRecordingType($recording_type)
    {
        $this->container['recording_type'] = $recording_type;

        return $this;
    }

    /**
     * Gets content_id
     * @return int
     */
    public function getContentId()
    {
        return $this->container['content_id'];
    }

    /**
     * Sets content_id
     * @param int $content_id
     * @return $this
     */
    public function setContentId($content_id)
    {
        $this->container['content_id'] = $content_id;

        return $this;
    }

    /**
     * Gets thumbnail_url
     * @return string
     */
    public function getThumbnailUrl()
    {
        return $this->container['thumbnail_url'];
    }

    /**
     * Sets thumbnail_url
     * @param string $thumbnail_url
     * @return $this
     */
    public function setThumbnailUrl($thumbnail_url)
    {
        $this->container['thumbnail_url'] = $thumbnail_url;

        return $this;
    }

    /**
     * Gets start_time_offset
     * @return int
     */
    public function getStartTimeOffset()
    {
        return $this->container['start_time_offset'];
    }

    /**
     * Sets start_time_offset
     * @param int $start_time_offset
     * @return $this
     */
    public function setStartTimeOffset($start_time_offset)
    {
        $this->container['start_time_offset'] = $start_time_offset;

        return $this;
    }

    /**
     * Gets end_time_offset
     * @return int
     */
    public function getEndTimeOffset()
    {
        return $this->container['end_time_offset'];
    }

    /**
     * Sets end_time_offset
     * @param int $end_time_offset
     * @return $this
     */
    public function setEndTimeOffset($end_time_offset)
    {
        $this->container['end_time_offset'] = $end_time_offset;

        return $this;
    }

    /**
     * Gets duration
     * @return int
     */
    public function getDuration()
    {
        return $this->container['duration'];
    }

    /**
     * Sets duration
     * @param int $duration
     * @return $this
     */
    public function setDuration($duration)
    {
        $this->container['duration'] = $duration;

        return $this;
    }

    /**
     * Gets started_by
     * @return \BlueJeansMeetingsRestApi\Model\RecordingSessionStartedBy
     */
    public function getStartedBy()
    {
        return $this->container['started_by'];
    }

    /**
     * Sets started_by
     * @param \BlueJeansMeetingsRestApi\Model\RecordingSessionStartedBy $started_by
     * @return $this
     */
    public function setStartedBy($started_by)
    {
        $this->container['started_by'] = $started_by;

        return $this;
    }

    /**
     * Gets stopped_by
     * @return \BlueJeansMeetingsRestApi\Model\RecordingSessionStartedBy
     */
    public function getStoppedBy()
    {
        return $this->container['stopped_by'];
    }

    /**
     * Sets stopped_by
     * @param \BlueJeansMeetingsRestApi\Model\RecordingSessionStartedBy $stopped_by
     * @return $this
     */
    public function setStoppedBy($stopped_by)
    {
        $this->container['stopped_by'] = $stopped_by;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     * @param  integer $offset Offset
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     * @param  integer $offset Offset
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     * @param  integer $offset Offset
     * @param  mixed   $value  Value to be set
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     * @param  integer $offset Offset
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(\BlueJeansMeetingsRestApi\ObjectSerializer::sanitizeForSerialization($this), JSON_PRETTY_PRINT);
        }

        return json_encode(\BlueJeansMeetingsRestApi\ObjectSerializer::sanitizeForSerialization($this));
    }
}


