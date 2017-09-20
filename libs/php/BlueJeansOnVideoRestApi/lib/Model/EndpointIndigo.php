<?php
/**
 * EndpointIndigo
 *
 * PHP version 5
 *
 * @category Class
 * @package  BlueJeansOnVideoRestApi
 * @author   Swaagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * BlueJeans onVideo REST API
 *
 * ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by an access code.  THe access code can ensure security of participants who can join, and also designate user(s) who need an ability to moderate a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>, and may be assigned a moderator passcode allowing designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About onVideo Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr>
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

namespace BlueJeansOnVideoRestApi\Model;

use \ArrayAccess;

/**
 * EndpointIndigo Class Doc Comment
 *
 * @category    Class
 * @package     BlueJeansOnVideoRestApi
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class EndpointIndigo implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'EndpointIndigo';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'id' => 'int',
        'callguid' => 'string',
        'name' => 'string',
        'endpoint' => 'string',
        'vendor' => 'string',
        'version' => 'string',
        'uniq_id' => 'string',
        'remote_address' => 'string',
        'leader' => 'bool',
        'secure_call' => 'bool',
        'nat_detected' => 'bool',
        'proxy' => 'bool',
        'roi_distance' => 'float',
        'mpls' => 'bool',
        'video_share' => 'bool',
        'recording' => 'bool',
        'creation_time' => 'int',
        'meeting_join_time' => 'int',
        'meeting_leave_time' => 'int',
        'did_number' => 'string',
        'location' => '\BlueJeansOnVideoRestApi\Model\EndpointIndigoLocation',
        'summary_stats' => '\BlueJeansOnVideoRestApi\Model\EndpointIndigoSummaryStats',
        'endpoint_attributes1' => '\BlueJeansOnVideoRestApi\Model\EndpointIndigoEndpointAttributes1',
        'traceroute' => '\BlueJeansOnVideoRestApi\Model\EndpointIndigoTraceroute',
        'mhtask_stopped' => 'bool'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerFormats = [
        'id' => null,
        'callguid' => null,
        'name' => null,
        'endpoint' => null,
        'vendor' => null,
        'version' => null,
        'uniq_id' => null,
        'remote_address' => null,
        'leader' => null,
        'secure_call' => null,
        'nat_detected' => null,
        'proxy' => null,
        'roi_distance' => 'float',
        'mpls' => null,
        'video_share' => null,
        'recording' => null,
        'creation_time' => 'int64',
        'meeting_join_time' => 'int64',
        'meeting_leave_time' => 'int64',
        'did_number' => null,
        'location' => null,
        'summary_stats' => null,
        'endpoint_attributes1' => null,
        'traceroute' => null,
        'mhtask_stopped' => null
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
        'callguid' => 'callguid',
        'name' => 'name',
        'endpoint' => 'endpoint',
        'vendor' => 'vendor',
        'version' => 'version',
        'uniq_id' => 'uniqId',
        'remote_address' => 'remoteAddress',
        'leader' => 'leader',
        'secure_call' => 'secureCall',
        'nat_detected' => 'natDetected',
        'proxy' => 'proxy',
        'roi_distance' => 'roiDistance',
        'mpls' => 'mpls',
        'video_share' => 'videoShare',
        'recording' => 'recording',
        'creation_time' => 'creationTime',
        'meeting_join_time' => 'meetingJoinTime',
        'meeting_leave_time' => 'meetingLeaveTime',
        'did_number' => 'didNumber',
        'location' => 'location',
        'summary_stats' => 'summaryStats',
        'endpoint_attributes1' => 'endpointAttributes1',
        'traceroute' => 'traceroute',
        'mhtask_stopped' => 'mhtaskStopped'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'id' => 'setId',
        'callguid' => 'setCallguid',
        'name' => 'setName',
        'endpoint' => 'setEndpoint',
        'vendor' => 'setVendor',
        'version' => 'setVersion',
        'uniq_id' => 'setUniqId',
        'remote_address' => 'setRemoteAddress',
        'leader' => 'setLeader',
        'secure_call' => 'setSecureCall',
        'nat_detected' => 'setNatDetected',
        'proxy' => 'setProxy',
        'roi_distance' => 'setRoiDistance',
        'mpls' => 'setMpls',
        'video_share' => 'setVideoShare',
        'recording' => 'setRecording',
        'creation_time' => 'setCreationTime',
        'meeting_join_time' => 'setMeetingJoinTime',
        'meeting_leave_time' => 'setMeetingLeaveTime',
        'did_number' => 'setDidNumber',
        'location' => 'setLocation',
        'summary_stats' => 'setSummaryStats',
        'endpoint_attributes1' => 'setEndpointAttributes1',
        'traceroute' => 'setTraceroute',
        'mhtask_stopped' => 'setMhtaskStopped'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'id' => 'getId',
        'callguid' => 'getCallguid',
        'name' => 'getName',
        'endpoint' => 'getEndpoint',
        'vendor' => 'getVendor',
        'version' => 'getVersion',
        'uniq_id' => 'getUniqId',
        'remote_address' => 'getRemoteAddress',
        'leader' => 'getLeader',
        'secure_call' => 'getSecureCall',
        'nat_detected' => 'getNatDetected',
        'proxy' => 'getProxy',
        'roi_distance' => 'getRoiDistance',
        'mpls' => 'getMpls',
        'video_share' => 'getVideoShare',
        'recording' => 'getRecording',
        'creation_time' => 'getCreationTime',
        'meeting_join_time' => 'getMeetingJoinTime',
        'meeting_leave_time' => 'getMeetingLeaveTime',
        'did_number' => 'getDidNumber',
        'location' => 'getLocation',
        'summary_stats' => 'getSummaryStats',
        'endpoint_attributes1' => 'getEndpointAttributes1',
        'traceroute' => 'getTraceroute',
        'mhtask_stopped' => 'getMhtaskStopped'
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
        $this->container['callguid'] = isset($data['callguid']) ? $data['callguid'] : null;
        $this->container['name'] = isset($data['name']) ? $data['name'] : null;
        $this->container['endpoint'] = isset($data['endpoint']) ? $data['endpoint'] : null;
        $this->container['vendor'] = isset($data['vendor']) ? $data['vendor'] : null;
        $this->container['version'] = isset($data['version']) ? $data['version'] : null;
        $this->container['uniq_id'] = isset($data['uniq_id']) ? $data['uniq_id'] : null;
        $this->container['remote_address'] = isset($data['remote_address']) ? $data['remote_address'] : null;
        $this->container['leader'] = isset($data['leader']) ? $data['leader'] : null;
        $this->container['secure_call'] = isset($data['secure_call']) ? $data['secure_call'] : null;
        $this->container['nat_detected'] = isset($data['nat_detected']) ? $data['nat_detected'] : null;
        $this->container['proxy'] = isset($data['proxy']) ? $data['proxy'] : null;
        $this->container['roi_distance'] = isset($data['roi_distance']) ? $data['roi_distance'] : null;
        $this->container['mpls'] = isset($data['mpls']) ? $data['mpls'] : null;
        $this->container['video_share'] = isset($data['video_share']) ? $data['video_share'] : null;
        $this->container['recording'] = isset($data['recording']) ? $data['recording'] : null;
        $this->container['creation_time'] = isset($data['creation_time']) ? $data['creation_time'] : null;
        $this->container['meeting_join_time'] = isset($data['meeting_join_time']) ? $data['meeting_join_time'] : null;
        $this->container['meeting_leave_time'] = isset($data['meeting_leave_time']) ? $data['meeting_leave_time'] : null;
        $this->container['did_number'] = isset($data['did_number']) ? $data['did_number'] : null;
        $this->container['location'] = isset($data['location']) ? $data['location'] : null;
        $this->container['summary_stats'] = isset($data['summary_stats']) ? $data['summary_stats'] : null;
        $this->container['endpoint_attributes1'] = isset($data['endpoint_attributes1']) ? $data['endpoint_attributes1'] : null;
        $this->container['traceroute'] = isset($data['traceroute']) ? $data['traceroute'] : null;
        $this->container['mhtask_stopped'] = isset($data['mhtask_stopped']) ? $data['mhtask_stopped'] : null;
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
     * Gets callguid
     * @return string
     */
    public function getCallguid()
    {
        return $this->container['callguid'];
    }

    /**
     * Sets callguid
     * @param string $callguid
     * @return $this
     */
    public function setCallguid($callguid)
    {
        $this->container['callguid'] = $callguid;

        return $this;
    }

    /**
     * Gets name
     * @return string
     */
    public function getName()
    {
        return $this->container['name'];
    }

    /**
     * Sets name
     * @param string $name
     * @return $this
     */
    public function setName($name)
    {
        $this->container['name'] = $name;

        return $this;
    }

    /**
     * Gets endpoint
     * @return string
     */
    public function getEndpoint()
    {
        return $this->container['endpoint'];
    }

    /**
     * Sets endpoint
     * @param string $endpoint
     * @return $this
     */
    public function setEndpoint($endpoint)
    {
        $this->container['endpoint'] = $endpoint;

        return $this;
    }

    /**
     * Gets vendor
     * @return string
     */
    public function getVendor()
    {
        return $this->container['vendor'];
    }

    /**
     * Sets vendor
     * @param string $vendor
     * @return $this
     */
    public function setVendor($vendor)
    {
        $this->container['vendor'] = $vendor;

        return $this;
    }

    /**
     * Gets version
     * @return string
     */
    public function getVersion()
    {
        return $this->container['version'];
    }

    /**
     * Sets version
     * @param string $version
     * @return $this
     */
    public function setVersion($version)
    {
        $this->container['version'] = $version;

        return $this;
    }

    /**
     * Gets uniq_id
     * @return string
     */
    public function getUniqId()
    {
        return $this->container['uniq_id'];
    }

    /**
     * Sets uniq_id
     * @param string $uniq_id
     * @return $this
     */
    public function setUniqId($uniq_id)
    {
        $this->container['uniq_id'] = $uniq_id;

        return $this;
    }

    /**
     * Gets remote_address
     * @return string
     */
    public function getRemoteAddress()
    {
        return $this->container['remote_address'];
    }

    /**
     * Sets remote_address
     * @param string $remote_address
     * @return $this
     */
    public function setRemoteAddress($remote_address)
    {
        $this->container['remote_address'] = $remote_address;

        return $this;
    }

    /**
     * Gets leader
     * @return bool
     */
    public function getLeader()
    {
        return $this->container['leader'];
    }

    /**
     * Sets leader
     * @param bool $leader
     * @return $this
     */
    public function setLeader($leader)
    {
        $this->container['leader'] = $leader;

        return $this;
    }

    /**
     * Gets secure_call
     * @return bool
     */
    public function getSecureCall()
    {
        return $this->container['secure_call'];
    }

    /**
     * Sets secure_call
     * @param bool $secure_call
     * @return $this
     */
    public function setSecureCall($secure_call)
    {
        $this->container['secure_call'] = $secure_call;

        return $this;
    }

    /**
     * Gets nat_detected
     * @return bool
     */
    public function getNatDetected()
    {
        return $this->container['nat_detected'];
    }

    /**
     * Sets nat_detected
     * @param bool $nat_detected
     * @return $this
     */
    public function setNatDetected($nat_detected)
    {
        $this->container['nat_detected'] = $nat_detected;

        return $this;
    }

    /**
     * Gets proxy
     * @return bool
     */
    public function getProxy()
    {
        return $this->container['proxy'];
    }

    /**
     * Sets proxy
     * @param bool $proxy
     * @return $this
     */
    public function setProxy($proxy)
    {
        $this->container['proxy'] = $proxy;

        return $this;
    }

    /**
     * Gets roi_distance
     * @return float
     */
    public function getRoiDistance()
    {
        return $this->container['roi_distance'];
    }

    /**
     * Sets roi_distance
     * @param float $roi_distance
     * @return $this
     */
    public function setRoiDistance($roi_distance)
    {
        $this->container['roi_distance'] = $roi_distance;

        return $this;
    }

    /**
     * Gets mpls
     * @return bool
     */
    public function getMpls()
    {
        return $this->container['mpls'];
    }

    /**
     * Sets mpls
     * @param bool $mpls
     * @return $this
     */
    public function setMpls($mpls)
    {
        $this->container['mpls'] = $mpls;

        return $this;
    }

    /**
     * Gets video_share
     * @return bool
     */
    public function getVideoShare()
    {
        return $this->container['video_share'];
    }

    /**
     * Sets video_share
     * @param bool $video_share
     * @return $this
     */
    public function setVideoShare($video_share)
    {
        $this->container['video_share'] = $video_share;

        return $this;
    }

    /**
     * Gets recording
     * @return bool
     */
    public function getRecording()
    {
        return $this->container['recording'];
    }

    /**
     * Sets recording
     * @param bool $recording
     * @return $this
     */
    public function setRecording($recording)
    {
        $this->container['recording'] = $recording;

        return $this;
    }

    /**
     * Gets creation_time
     * @return int
     */
    public function getCreationTime()
    {
        return $this->container['creation_time'];
    }

    /**
     * Sets creation_time
     * @param int $creation_time
     * @return $this
     */
    public function setCreationTime($creation_time)
    {
        $this->container['creation_time'] = $creation_time;

        return $this;
    }

    /**
     * Gets meeting_join_time
     * @return int
     */
    public function getMeetingJoinTime()
    {
        return $this->container['meeting_join_time'];
    }

    /**
     * Sets meeting_join_time
     * @param int $meeting_join_time
     * @return $this
     */
    public function setMeetingJoinTime($meeting_join_time)
    {
        $this->container['meeting_join_time'] = $meeting_join_time;

        return $this;
    }

    /**
     * Gets meeting_leave_time
     * @return int
     */
    public function getMeetingLeaveTime()
    {
        return $this->container['meeting_leave_time'];
    }

    /**
     * Sets meeting_leave_time
     * @param int $meeting_leave_time
     * @return $this
     */
    public function setMeetingLeaveTime($meeting_leave_time)
    {
        $this->container['meeting_leave_time'] = $meeting_leave_time;

        return $this;
    }

    /**
     * Gets did_number
     * @return string
     */
    public function getDidNumber()
    {
        return $this->container['did_number'];
    }

    /**
     * Sets did_number
     * @param string $did_number
     * @return $this
     */
    public function setDidNumber($did_number)
    {
        $this->container['did_number'] = $did_number;

        return $this;
    }

    /**
     * Gets location
     * @return \BlueJeansOnVideoRestApi\Model\EndpointIndigoLocation
     */
    public function getLocation()
    {
        return $this->container['location'];
    }

    /**
     * Sets location
     * @param \BlueJeansOnVideoRestApi\Model\EndpointIndigoLocation $location
     * @return $this
     */
    public function setLocation($location)
    {
        $this->container['location'] = $location;

        return $this;
    }

    /**
     * Gets summary_stats
     * @return \BlueJeansOnVideoRestApi\Model\EndpointIndigoSummaryStats
     */
    public function getSummaryStats()
    {
        return $this->container['summary_stats'];
    }

    /**
     * Sets summary_stats
     * @param \BlueJeansOnVideoRestApi\Model\EndpointIndigoSummaryStats $summary_stats
     * @return $this
     */
    public function setSummaryStats($summary_stats)
    {
        $this->container['summary_stats'] = $summary_stats;

        return $this;
    }

    /**
     * Gets endpoint_attributes1
     * @return \BlueJeansOnVideoRestApi\Model\EndpointIndigoEndpointAttributes1
     */
    public function getEndpointAttributes1()
    {
        return $this->container['endpoint_attributes1'];
    }

    /**
     * Sets endpoint_attributes1
     * @param \BlueJeansOnVideoRestApi\Model\EndpointIndigoEndpointAttributes1 $endpoint_attributes1
     * @return $this
     */
    public function setEndpointAttributes1($endpoint_attributes1)
    {
        $this->container['endpoint_attributes1'] = $endpoint_attributes1;

        return $this;
    }

    /**
     * Gets traceroute
     * @return \BlueJeansOnVideoRestApi\Model\EndpointIndigoTraceroute
     */
    public function getTraceroute()
    {
        return $this->container['traceroute'];
    }

    /**
     * Sets traceroute
     * @param \BlueJeansOnVideoRestApi\Model\EndpointIndigoTraceroute $traceroute
     * @return $this
     */
    public function setTraceroute($traceroute)
    {
        $this->container['traceroute'] = $traceroute;

        return $this;
    }

    /**
     * Gets mhtask_stopped
     * @return bool
     */
    public function getMhtaskStopped()
    {
        return $this->container['mhtask_stopped'];
    }

    /**
     * Sets mhtask_stopped
     * @param bool $mhtask_stopped
     * @return $this
     */
    public function setMhtaskStopped($mhtask_stopped)
    {
        $this->container['mhtask_stopped'] = $mhtask_stopped;

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
            return json_encode(\BlueJeansOnVideoRestApi\ObjectSerializer::sanitizeForSerialization($this), JSON_PRETTY_PRINT);
        }

        return json_encode(\BlueJeansOnVideoRestApi\ObjectSerializer::sanitizeForSerialization($this));
    }
}


