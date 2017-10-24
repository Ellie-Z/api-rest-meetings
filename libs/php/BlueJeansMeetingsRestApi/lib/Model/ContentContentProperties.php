<?php
/**
 * ContentContentProperties
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

namespace BlueJeansMeetingsRestApi\Model;

use \ArrayAccess;

/**
 * ContentContentProperties Class Doc Comment
 *
 * @category    Class
 * @package     BlueJeansMeetingsRestApi
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class ContentContentProperties implements ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'Content_contentProperties';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = [
        'duration' => 'int',
        'thumbnail' => 'string',
        'thumbnail_sprite' => 'string',
        'hds_url' => 'string',
        'thumbnail_count' => 'int',
        'thumbnail_width' => 'int',
        'thumbnail_height' => 'int',
        'thumbnail_interval' => 'int',
        'hls_url' => 'string',
        'levels' => '\BlueJeansMeetingsRestApi\Model\ContentContentPropertiesLevels[]'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerFormats = [
        'duration' => null,
        'thumbnail' => null,
        'thumbnail_sprite' => null,
        'hds_url' => null,
        'thumbnail_count' => null,
        'thumbnail_width' => null,
        'thumbnail_height' => null,
        'thumbnail_interval' => null,
        'hls_url' => null,
        'levels' => null
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
        'duration' => 'duration',
        'thumbnail' => 'thumbnail',
        'thumbnail_sprite' => 'thumbnailSprite',
        'hds_url' => 'hdsUrl',
        'thumbnail_count' => 'thumbnailCount',
        'thumbnail_width' => 'thumbnailWidth',
        'thumbnail_height' => 'thumbnailHeight',
        'thumbnail_interval' => 'thumbnailInterval',
        'hls_url' => 'hlsUrl',
        'levels' => 'levels'
    ];


    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = [
        'duration' => 'setDuration',
        'thumbnail' => 'setThumbnail',
        'thumbnail_sprite' => 'setThumbnailSprite',
        'hds_url' => 'setHdsUrl',
        'thumbnail_count' => 'setThumbnailCount',
        'thumbnail_width' => 'setThumbnailWidth',
        'thumbnail_height' => 'setThumbnailHeight',
        'thumbnail_interval' => 'setThumbnailInterval',
        'hls_url' => 'setHlsUrl',
        'levels' => 'setLevels'
    ];


    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = [
        'duration' => 'getDuration',
        'thumbnail' => 'getThumbnail',
        'thumbnail_sprite' => 'getThumbnailSprite',
        'hds_url' => 'getHdsUrl',
        'thumbnail_count' => 'getThumbnailCount',
        'thumbnail_width' => 'getThumbnailWidth',
        'thumbnail_height' => 'getThumbnailHeight',
        'thumbnail_interval' => 'getThumbnailInterval',
        'hls_url' => 'getHlsUrl',
        'levels' => 'getLevels'
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
        $this->container['duration'] = isset($data['duration']) ? $data['duration'] : null;
        $this->container['thumbnail'] = isset($data['thumbnail']) ? $data['thumbnail'] : null;
        $this->container['thumbnail_sprite'] = isset($data['thumbnail_sprite']) ? $data['thumbnail_sprite'] : null;
        $this->container['hds_url'] = isset($data['hds_url']) ? $data['hds_url'] : null;
        $this->container['thumbnail_count'] = isset($data['thumbnail_count']) ? $data['thumbnail_count'] : null;
        $this->container['thumbnail_width'] = isset($data['thumbnail_width']) ? $data['thumbnail_width'] : null;
        $this->container['thumbnail_height'] = isset($data['thumbnail_height']) ? $data['thumbnail_height'] : null;
        $this->container['thumbnail_interval'] = isset($data['thumbnail_interval']) ? $data['thumbnail_interval'] : null;
        $this->container['hls_url'] = isset($data['hls_url']) ? $data['hls_url'] : null;
        $this->container['levels'] = isset($data['levels']) ? $data['levels'] : null;
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
     * Gets thumbnail
     * @return string
     */
    public function getThumbnail()
    {
        return $this->container['thumbnail'];
    }

    /**
     * Sets thumbnail
     * @param string $thumbnail
     * @return $this
     */
    public function setThumbnail($thumbnail)
    {
        $this->container['thumbnail'] = $thumbnail;

        return $this;
    }

    /**
     * Gets thumbnail_sprite
     * @return string
     */
    public function getThumbnailSprite()
    {
        return $this->container['thumbnail_sprite'];
    }

    /**
     * Sets thumbnail_sprite
     * @param string $thumbnail_sprite
     * @return $this
     */
    public function setThumbnailSprite($thumbnail_sprite)
    {
        $this->container['thumbnail_sprite'] = $thumbnail_sprite;

        return $this;
    }

    /**
     * Gets hds_url
     * @return string
     */
    public function getHdsUrl()
    {
        return $this->container['hds_url'];
    }

    /**
     * Sets hds_url
     * @param string $hds_url
     * @return $this
     */
    public function setHdsUrl($hds_url)
    {
        $this->container['hds_url'] = $hds_url;

        return $this;
    }

    /**
     * Gets thumbnail_count
     * @return int
     */
    public function getThumbnailCount()
    {
        return $this->container['thumbnail_count'];
    }

    /**
     * Sets thumbnail_count
     * @param int $thumbnail_count
     * @return $this
     */
    public function setThumbnailCount($thumbnail_count)
    {
        $this->container['thumbnail_count'] = $thumbnail_count;

        return $this;
    }

    /**
     * Gets thumbnail_width
     * @return int
     */
    public function getThumbnailWidth()
    {
        return $this->container['thumbnail_width'];
    }

    /**
     * Sets thumbnail_width
     * @param int $thumbnail_width
     * @return $this
     */
    public function setThumbnailWidth($thumbnail_width)
    {
        $this->container['thumbnail_width'] = $thumbnail_width;

        return $this;
    }

    /**
     * Gets thumbnail_height
     * @return int
     */
    public function getThumbnailHeight()
    {
        return $this->container['thumbnail_height'];
    }

    /**
     * Sets thumbnail_height
     * @param int $thumbnail_height
     * @return $this
     */
    public function setThumbnailHeight($thumbnail_height)
    {
        $this->container['thumbnail_height'] = $thumbnail_height;

        return $this;
    }

    /**
     * Gets thumbnail_interval
     * @return int
     */
    public function getThumbnailInterval()
    {
        return $this->container['thumbnail_interval'];
    }

    /**
     * Sets thumbnail_interval
     * @param int $thumbnail_interval
     * @return $this
     */
    public function setThumbnailInterval($thumbnail_interval)
    {
        $this->container['thumbnail_interval'] = $thumbnail_interval;

        return $this;
    }

    /**
     * Gets hls_url
     * @return string
     */
    public function getHlsUrl()
    {
        return $this->container['hls_url'];
    }

    /**
     * Sets hls_url
     * @param string $hls_url
     * @return $this
     */
    public function setHlsUrl($hls_url)
    {
        $this->container['hls_url'] = $hls_url;

        return $this;
    }

    /**
     * Gets levels
     * @return \BlueJeansMeetingsRestApi\Model\ContentContentPropertiesLevels[]
     */
    public function getLevels()
    {
        return $this->container['levels'];
    }

    /**
     * Sets levels
     * @param \BlueJeansMeetingsRestApi\Model\ContentContentPropertiesLevels[] $levels
     * @return $this
     */
    public function setLevels($levels)
    {
        $this->container['levels'] = $levels;

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


