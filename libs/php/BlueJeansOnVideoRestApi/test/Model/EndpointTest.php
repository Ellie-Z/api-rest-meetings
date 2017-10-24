<?php
/**
 * EndpointTest
 *
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
 * Please update the test case below to test the model.
 */

namespace BlueJeansOnVideoRestApi;

/**
 * EndpointTest Class Doc Comment
 *
 * @category    Class */
// * @description Endpoint
/**
 * @package     BlueJeansOnVideoRestApi
 * @author      Swagger Codegen team
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class EndpointTest extends \PHPUnit_Framework_TestCase
{

    /**
     * Setup before running any test case
     */
    public static function setUpBeforeClass()
    {
    }

    /**
     * Setup before running each test case
     */
    public function setUp()
    {
    }

    /**
     * Clean up after running each test case
     */
    public function tearDown()
    {
    }

    /**
     * Clean up after running all test cases
     */
    public static function tearDownAfterClass()
    {
    }

    /**
     * Test "Endpoint"
     */
    public function testEndpoint()
    {
    }

    /**
     * Test attribute "ec_mode"
     */
    public function testPropertyEcMode()
    {
    }

    /**
     * Test attribute "creationtime"
     */
    public function testPropertyCreationtime()
    {
    }

    /**
     * Test attribute "audio_remote_rtcp_address"
     */
    public function testPropertyAudioRemoteRtcpAddress()
    {
    }

    /**
     * Test attribute "video_send_codec"
     */
    public function testPropertyVideoSendCodec()
    {
    }

    /**
     * Test attribute "audio_play_id"
     */
    public function testPropertyAudioPlayId()
    {
    }

    /**
     * Test attribute "call_quality_recv"
     */
    public function testPropertyCallQualityRecv()
    {
    }

    /**
     * Test attribute "session_out"
     */
    public function testPropertySessionOut()
    {
    }

    /**
     * Test attribute "audio_local_address"
     */
    public function testPropertyAudioLocalAddress()
    {
    }

    /**
     * Test attribute "meetingid"
     */
    public function testPropertyMeetingid()
    {
    }

    /**
     * Test attribute "video_send_width"
     */
    public function testPropertyVideoSendWidth()
    {
    }

    /**
     * Test attribute "call_quality_send"
     */
    public function testPropertyCallQualitySend()
    {
    }

    /**
     * Test attribute "mhaddress"
     */
    public function testPropertyMhaddress()
    {
    }

    /**
     * Test attribute "rdc_controllee_capable"
     */
    public function testPropertyRdcControlleeCapable()
    {
    }

    /**
     * Test attribute "audio_cap_name"
     */
    public function testPropertyAudioCapName()
    {
    }

    /**
     * Test attribute "proxy_info"
     */
    public function testPropertyProxyInfo()
    {
    }

    /**
     * Test attribute "audio_send_codec"
     */
    public function testPropertyAudioSendCodec()
    {
    }

    /**
     * Test attribute "vendor"
     */
    public function testPropertyVendor()
    {
    }

    /**
     * Test attribute "video_recv_width"
     */
    public function testPropertyVideoRecvWidth()
    {
    }

    /**
     * Test attribute "conaddress"
     */
    public function testPropertyConaddress()
    {
    }

    /**
     * Test attribute "talk_detected"
     */
    public function testPropertyTalkDetected()
    {
    }

    /**
     * Test attribute "sub_layout"
     */
    public function testPropertySubLayout()
    {
    }

    /**
     * Test attribute "audio_rtcp_relay"
     */
    public function testPropertyAudioRtcpRelay()
    {
    }

    /**
     * Test attribute "audio_recv_local_mute"
     */
    public function testPropertyAudioRecvLocalMute()
    {
    }

    /**
     * Test attribute "name"
     */
    public function testPropertyName()
    {
    }

    /**
     * Test attribute "video_local_address"
     */
    public function testPropertyVideoLocalAddress()
    {
    }

    /**
     * Test attribute "audio_local_rtcp_address"
     */
    public function testPropertyAudioLocalRtcpAddress()
    {
    }

    /**
     * Test attribute "content_rtp_relay"
     */
    public function testPropertyContentRtpRelay()
    {
    }

    /**
     * Test attribute "content_local_rtcp_address"
     */
    public function testPropertyContentLocalRtcpAddress()
    {
    }

    /**
     * Test attribute "remote_connection_count"
     */
    public function testPropertyRemoteConnectionCount()
    {
    }

    /**
     * Test attribute "callrate"
     */
    public function testPropertyCallrate()
    {
    }

    /**
     * Test attribute "mixer_guid"
     */
    public function testPropertyMixerGuid()
    {
    }

    /**
     * Test attribute "transport"
     */
    public function testPropertyTransport()
    {
    }

    /**
     * Test attribute "audio_cap_select_id"
     */
    public function testPropertyAudioCapSelectId()
    {
    }

    /**
     * Test attribute "country_code"
     */
    public function testPropertyCountryCode()
    {
    }

    /**
     * Test attribute "rdc_controller_capable"
     */
    public function testPropertyRdcControllerCapable()
    {
    }

    /**
     * Test attribute "pairedname"
     */
    public function testPropertyPairedname()
    {
    }

    /**
     * Test attribute "video_rtcp_relay"
     */
    public function testPropertyVideoRtcpRelay()
    {
    }

    /**
     * Test attribute "endpoint_cpu_params"
     */
    public function testPropertyEndpointCpuParams()
    {
    }

    /**
     * Test attribute "video_remote_address"
     */
    public function testPropertyVideoRemoteAddress()
    {
    }

    /**
     * Test attribute "version"
     */
    public function testPropertyVersion()
    {
    }

    /**
     * Test attribute "content_recv"
     */
    public function testPropertyContentRecv()
    {
    }

    /**
     * Test attribute "local_name"
     */
    public function testPropertyLocalName()
    {
    }

    /**
     * Test attribute "bjn_user_id"
     */
    public function testPropertyBjnUserId()
    {
    }

    /**
     * Test attribute "content_remote_address"
     */
    public function testPropertyContentRemoteAddress()
    {
    }

    /**
     * Test attribute "audio_send"
     */
    public function testPropertyAudioSend()
    {
    }

    /**
     * Test attribute "participant_dtmf_menus"
     */
    public function testPropertyParticipantDtmfMenus()
    {
    }

    /**
     * Test attribute "video_rtcp_transpor"
     */
    public function testPropertyVideoRtcpTranspor()
    {
    }

    /**
     * Test attribute "audio_rtcp_transport"
     */
    public function testPropertyAudioRtcpTransport()
    {
    }

    /**
     * Test attribute "relay_node_id"
     */
    public function testPropertyRelayNodeId()
    {
    }

    /**
     * Test attribute "content_remote_rtcp_address"
     */
    public function testPropertyContentRemoteRtcpAddress()
    {
    }

    /**
     * Test attribute "audio_rtp_relay"
     */
    public function testPropertyAudioRtpRelay()
    {
    }

    /**
     * Test attribute "video_rtp_transport"
     */
    public function testPropertyVideoRtpTransport()
    {
    }

    /**
     * Test attribute "content_recv_local_mute"
     */
    public function testPropertyContentRecvLocalMute()
    {
    }

    /**
     * Test attribute "layout"
     */
    public function testPropertyLayout()
    {
    }

    /**
     * Test attribute "content_send"
     */
    public function testPropertyContentSend()
    {
    }

    /**
     * Test attribute "remoteaddress"
     */
    public function testPropertyRemoteaddress()
    {
    }

    /**
     * Test attribute "meeting_guid"
     */
    public function testPropertyMeetingGuid()
    {
    }

    /**
     * Test attribute "connecttime"
     */
    public function testPropertyConnecttime()
    {
    }

    /**
     * Test attribute "localaddress"
     */
    public function testPropertyLocaladdress()
    {
    }

    /**
     * Test attribute "audio_remote_address"
     */
    public function testPropertyAudioRemoteAddress()
    {
    }

    /**
     * Test attribute "bonded_audio_guid"
     */
    public function testPropertyBondedAudioGuid()
    {
    }

    /**
     * Test attribute "audio_recv_remote_mute"
     */
    public function testPropertyAudioRecvRemoteMute()
    {
    }

    /**
     * Test attribute "session_out_relay"
     */
    public function testPropertySessionOutRelay()
    {
    }

    /**
     * Test attribute "leader"
     */
    public function testPropertyLeader()
    {
    }

    /**
     * Test attribute "content_local_address"
     */
    public function testPropertyContentLocalAddress()
    {
    }

    /**
     * Test attribute "movie_capable"
     */
    public function testPropertyMovieCapable()
    {
    }

    /**
     * Test attribute "video_recv_local_mute"
     */
    public function testPropertyVideoRecvLocalMute()
    {
    }

    /**
     * Test attribute "content_rtp_transport"
     */
    public function testPropertyContentRtpTransport()
    {
    }

    /**
     * Test attribute "rdc_version"
     */
    public function testPropertyRdcVersion()
    {
    }

    /**
     * Test attribute "audio_recv"
     */
    public function testPropertyAudioRecv()
    {
    }

    /**
     * Test attribute "content_relay_server"
     */
    public function testPropertyContentRelayServer()
    {
    }

    /**
     * Test attribute "video_recv"
     */
    public function testPropertyVideoRecv()
    {
    }

    /**
     * Test attribute "visibility"
     */
    public function testPropertyVisibility()
    {
    }

    /**
     * Test attribute "sessionid"
     */
    public function testPropertySessionid()
    {
    }

    /**
     * Test attribute "content_rtcp_relay"
     */
    public function testPropertyContentRtcpRelay()
    {
    }

    /**
     * Test attribute "locales"
     */
    public function testPropertyLocales()
    {
    }

    /**
     * Test attribute "medaddress"
     */
    public function testPropertyMedaddress()
    {
    }

    /**
     * Test attribute "html_layout_guid"
     */
    public function testPropertyHtmlLayoutGuid()
    {
    }

    /**
     * Test attribute "endpoint"
     */
    public function testPropertyEndpoint()
    {
    }

    /**
     * Test attribute "video_drop"
     */
    public function testPropertyVideoDrop()
    {
    }

    /**
     * Test attribute "content_rtcp_transport"
     */
    public function testPropertyContentRtcpTransport()
    {
    }

    /**
     * Test attribute "video_remote_rtcp_address"
     */
    public function testPropertyVideoRemoteRtcpAddress()
    {
    }

    /**
     * Test attribute "video_rtp_relay"
     */
    public function testPropertyVideoRtpRelay()
    {
    }

    /**
     * Test attribute "mixaddress"
     */
    public function testPropertyMixaddress()
    {
    }

    /**
     * Test attribute "siphttp_proxy_transport"
     */
    public function testPropertySiphttpProxyTransport()
    {
    }

    /**
     * Test attribute "video_recv_codec"
     */
    public function testPropertyVideoRecvCodec()
    {
    }

    /**
     * Test attribute "audio_recv_codec"
     */
    public function testPropertyAudioRecvCodec()
    {
    }

    /**
     * Test attribute "session_in"
     */
    public function testPropertySessionIn()
    {
    }

    /**
     * Test attribute "bonded_video_guid"
     */
    public function testPropertyBondedVideoGuid()
    {
    }

    /**
     * Test attribute "call_quality"
     */
    public function testPropertyCallQuality()
    {
    }

    /**
     * Test attribute "meetingjointime"
     */
    public function testPropertyMeetingjointime()
    {
    }

    /**
     * Test attribute "session_in_relay"
     */
    public function testPropertySessionInRelay()
    {
    }

    /**
     * Test attribute "pairedremoteaddress"
     */
    public function testPropertyPairedremoteaddress()
    {
    }

    /**
     * Test attribute "video_send_height"
     */
    public function testPropertyVideoSendHeight()
    {
    }

    /**
     * Test attribute "video_recv_height"
     */
    public function testPropertyVideoRecvHeight()
    {
    }

    /**
     * Test attribute "secure_call"
     */
    public function testPropertySecureCall()
    {
    }

    /**
     * Test attribute "video_local_rtcp_address"
     */
    public function testPropertyVideoLocalRtcpAddress()
    {
    }

    /**
     * Test attribute "audio_play_name"
     */
    public function testPropertyAudioPlayName()
    {
    }

    /**
     * Test attribute "video_cap_id"
     */
    public function testPropertyVideoCapId()
    {
    }

    /**
     * Test attribute "audio_rtp_transport"
     */
    public function testPropertyAudioRtpTransport()
    {
    }

    /**
     * Test attribute "meeting_info_mode"
     */
    public function testPropertyMeetingInfoMode()
    {
    }

    /**
     * Test attribute "callhostname"
     */
    public function testPropertyCallhostname()
    {
    }

    /**
     * Test attribute "callguid"
     */
    public function testPropertyCallguid()
    {
    }

    /**
     * Test attribute "audio_cap_id"
     */
    public function testPropertyAudioCapId()
    {
    }

    /**
     * Test attribute "video_send"
     */
    public function testPropertyVideoSend()
    {
    }

    /**
     * Test attribute "content_recv_codec"
     */
    public function testPropertyContentRecvCodec()
    {
    }

    /**
     * Test attribute "session_relay"
     */
    public function testPropertySessionRelay()
    {
    }

    /**
     * Test attribute "video_recv_remote_mute"
     */
    public function testPropertyVideoRecvRemoteMute()
    {
    }

    /**
     * Test attribute "id"
     */
    public function testPropertyId()
    {
    }

    /**
     * Test attribute "bonded_video_name"
     */
    public function testPropertyBondedVideoName()
    {
    }

    /**
     * Test attribute "is_in_roster"
     */
    public function testPropertyIsInRoster()
    {
    }
}
