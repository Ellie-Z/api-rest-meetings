# coding: utf-8

"""
    BlueJeans Meetings REST API

     ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 

    OpenAPI spec version: 1.0.0
    Contact: brandon@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from pprint import pformat
from six import iteritems
import re


class EndpointsInner(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """


    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'meetingid': 'str',
        'name': 'str',
        'call_quality': 'str',
        'leader': 'str',
        'callguid': 'str',
        'endpoint': 'str',
        'talk_detected': 'str',
        'secure_call': 'str',
        'layout': 'str',
        'sub_layout': 'str',
        'video_recv': 'str',
        'video_recv_local_mute': 'str',
        'video_recv_remote_mute': 'str',
        'audio_recv': 'str',
        'audio_recv_local_mute': 'str',
        'audio_recv_remote_mute': 'str',
        'audio_recv_codec': 'str',
        'audio_send_codec': 'str',
        'video_recv_codec': 'str',
        'video_recv_height': 'str',
        'video_recv_width': 'str',
        'video_send_codec': 'str',
        'video_send_height': 'str',
        'video_send_width': 'str',
        'visibility': 'str',
        'chat_endpoint_guid': 'str',
        'endpoint_guid': 'str',
        'rdc_version': 'str',
        'rdc_controller_capable': 'str',
        'rdc_controllee_capable': 'str',
        'connections': 'list[EndpointsInnerConnections]'
    }

    attribute_map = {
        'meetingid': 'meetingid',
        'name': 'name',
        'call_quality': 'CallQuality',
        'leader': 'Leader',
        'callguid': 'callguid',
        'endpoint': 'endpoint',
        'talk_detected': 'TalkDetected',
        'secure_call': 'SecureCall',
        'layout': 'Layout',
        'sub_layout': 'SubLayout',
        'video_recv': 'VideoRecv',
        'video_recv_local_mute': 'VideoRecvLocalMute',
        'video_recv_remote_mute': 'VideoRecvRemoteMute',
        'audio_recv': 'AudioRecv',
        'audio_recv_local_mute': 'AudioRecvLocalMute',
        'audio_recv_remote_mute': 'AudioRecvRemoteMute',
        'audio_recv_codec': 'AudioRecvCodec',
        'audio_send_codec': 'AudioSendCodec',
        'video_recv_codec': 'VideoRecvCodec',
        'video_recv_height': 'VideoRecvHeight',
        'video_recv_width': 'VideoRecvWidth',
        'video_send_codec': 'VideoSendCodec',
        'video_send_height': 'VideoSendHeight',
        'video_send_width': 'VideoSendWidth',
        'visibility': 'visibility',
        'chat_endpoint_guid': 'chatEndpointGuid',
        'endpoint_guid': 'endpointGuid',
        'rdc_version': 'RDCVersion',
        'rdc_controller_capable': 'RDCControllerCapable',
        'rdc_controllee_capable': 'RDCControlleeCapable',
        'connections': 'connections'
    }

    def __init__(self, meetingid=None, name=None, call_quality=None, leader=None, callguid=None, endpoint=None, talk_detected=None, secure_call=None, layout=None, sub_layout=None, video_recv=None, video_recv_local_mute=None, video_recv_remote_mute=None, audio_recv=None, audio_recv_local_mute=None, audio_recv_remote_mute=None, audio_recv_codec=None, audio_send_codec=None, video_recv_codec=None, video_recv_height=None, video_recv_width=None, video_send_codec=None, video_send_height=None, video_send_width=None, visibility=None, chat_endpoint_guid=None, endpoint_guid=None, rdc_version=None, rdc_controller_capable=None, rdc_controllee_capable=None, connections=None):
        """
        EndpointsInner - a model defined in Swagger
        """

        self._meetingid = None
        self._name = None
        self._call_quality = None
        self._leader = None
        self._callguid = None
        self._endpoint = None
        self._talk_detected = None
        self._secure_call = None
        self._layout = None
        self._sub_layout = None
        self._video_recv = None
        self._video_recv_local_mute = None
        self._video_recv_remote_mute = None
        self._audio_recv = None
        self._audio_recv_local_mute = None
        self._audio_recv_remote_mute = None
        self._audio_recv_codec = None
        self._audio_send_codec = None
        self._video_recv_codec = None
        self._video_recv_height = None
        self._video_recv_width = None
        self._video_send_codec = None
        self._video_send_height = None
        self._video_send_width = None
        self._visibility = None
        self._chat_endpoint_guid = None
        self._endpoint_guid = None
        self._rdc_version = None
        self._rdc_controller_capable = None
        self._rdc_controllee_capable = None
        self._connections = None

        if meetingid is not None:
          self.meetingid = meetingid
        if name is not None:
          self.name = name
        if call_quality is not None:
          self.call_quality = call_quality
        if leader is not None:
          self.leader = leader
        if callguid is not None:
          self.callguid = callguid
        if endpoint is not None:
          self.endpoint = endpoint
        if talk_detected is not None:
          self.talk_detected = talk_detected
        if secure_call is not None:
          self.secure_call = secure_call
        if layout is not None:
          self.layout = layout
        if sub_layout is not None:
          self.sub_layout = sub_layout
        if video_recv is not None:
          self.video_recv = video_recv
        if video_recv_local_mute is not None:
          self.video_recv_local_mute = video_recv_local_mute
        if video_recv_remote_mute is not None:
          self.video_recv_remote_mute = video_recv_remote_mute
        if audio_recv is not None:
          self.audio_recv = audio_recv
        if audio_recv_local_mute is not None:
          self.audio_recv_local_mute = audio_recv_local_mute
        if audio_recv_remote_mute is not None:
          self.audio_recv_remote_mute = audio_recv_remote_mute
        if audio_recv_codec is not None:
          self.audio_recv_codec = audio_recv_codec
        if audio_send_codec is not None:
          self.audio_send_codec = audio_send_codec
        if video_recv_codec is not None:
          self.video_recv_codec = video_recv_codec
        if video_recv_height is not None:
          self.video_recv_height = video_recv_height
        if video_recv_width is not None:
          self.video_recv_width = video_recv_width
        if video_send_codec is not None:
          self.video_send_codec = video_send_codec
        if video_send_height is not None:
          self.video_send_height = video_send_height
        if video_send_width is not None:
          self.video_send_width = video_send_width
        if visibility is not None:
          self.visibility = visibility
        if chat_endpoint_guid is not None:
          self.chat_endpoint_guid = chat_endpoint_guid
        if endpoint_guid is not None:
          self.endpoint_guid = endpoint_guid
        if rdc_version is not None:
          self.rdc_version = rdc_version
        if rdc_controller_capable is not None:
          self.rdc_controller_capable = rdc_controller_capable
        if rdc_controllee_capable is not None:
          self.rdc_controllee_capable = rdc_controllee_capable
        if connections is not None:
          self.connections = connections

    @property
    def meetingid(self):
        """
        Gets the meetingid of this EndpointsInner.

        :return: The meetingid of this EndpointsInner.
        :rtype: str
        """
        return self._meetingid

    @meetingid.setter
    def meetingid(self, meetingid):
        """
        Sets the meetingid of this EndpointsInner.

        :param meetingid: The meetingid of this EndpointsInner.
        :type: str
        """

        self._meetingid = meetingid

    @property
    def name(self):
        """
        Gets the name of this EndpointsInner.

        :return: The name of this EndpointsInner.
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """
        Sets the name of this EndpointsInner.

        :param name: The name of this EndpointsInner.
        :type: str
        """

        self._name = name

    @property
    def call_quality(self):
        """
        Gets the call_quality of this EndpointsInner.

        :return: The call_quality of this EndpointsInner.
        :rtype: str
        """
        return self._call_quality

    @call_quality.setter
    def call_quality(self, call_quality):
        """
        Sets the call_quality of this EndpointsInner.

        :param call_quality: The call_quality of this EndpointsInner.
        :type: str
        """

        self._call_quality = call_quality

    @property
    def leader(self):
        """
        Gets the leader of this EndpointsInner.

        :return: The leader of this EndpointsInner.
        :rtype: str
        """
        return self._leader

    @leader.setter
    def leader(self, leader):
        """
        Sets the leader of this EndpointsInner.

        :param leader: The leader of this EndpointsInner.
        :type: str
        """

        self._leader = leader

    @property
    def callguid(self):
        """
        Gets the callguid of this EndpointsInner.

        :return: The callguid of this EndpointsInner.
        :rtype: str
        """
        return self._callguid

    @callguid.setter
    def callguid(self, callguid):
        """
        Sets the callguid of this EndpointsInner.

        :param callguid: The callguid of this EndpointsInner.
        :type: str
        """

        self._callguid = callguid

    @property
    def endpoint(self):
        """
        Gets the endpoint of this EndpointsInner.

        :return: The endpoint of this EndpointsInner.
        :rtype: str
        """
        return self._endpoint

    @endpoint.setter
    def endpoint(self, endpoint):
        """
        Sets the endpoint of this EndpointsInner.

        :param endpoint: The endpoint of this EndpointsInner.
        :type: str
        """

        self._endpoint = endpoint

    @property
    def talk_detected(self):
        """
        Gets the talk_detected of this EndpointsInner.

        :return: The talk_detected of this EndpointsInner.
        :rtype: str
        """
        return self._talk_detected

    @talk_detected.setter
    def talk_detected(self, talk_detected):
        """
        Sets the talk_detected of this EndpointsInner.

        :param talk_detected: The talk_detected of this EndpointsInner.
        :type: str
        """

        self._talk_detected = talk_detected

    @property
    def secure_call(self):
        """
        Gets the secure_call of this EndpointsInner.

        :return: The secure_call of this EndpointsInner.
        :rtype: str
        """
        return self._secure_call

    @secure_call.setter
    def secure_call(self, secure_call):
        """
        Sets the secure_call of this EndpointsInner.

        :param secure_call: The secure_call of this EndpointsInner.
        :type: str
        """

        self._secure_call = secure_call

    @property
    def layout(self):
        """
        Gets the layout of this EndpointsInner.

        :return: The layout of this EndpointsInner.
        :rtype: str
        """
        return self._layout

    @layout.setter
    def layout(self, layout):
        """
        Sets the layout of this EndpointsInner.

        :param layout: The layout of this EndpointsInner.
        :type: str
        """

        self._layout = layout

    @property
    def sub_layout(self):
        """
        Gets the sub_layout of this EndpointsInner.

        :return: The sub_layout of this EndpointsInner.
        :rtype: str
        """
        return self._sub_layout

    @sub_layout.setter
    def sub_layout(self, sub_layout):
        """
        Sets the sub_layout of this EndpointsInner.

        :param sub_layout: The sub_layout of this EndpointsInner.
        :type: str
        """

        self._sub_layout = sub_layout

    @property
    def video_recv(self):
        """
        Gets the video_recv of this EndpointsInner.

        :return: The video_recv of this EndpointsInner.
        :rtype: str
        """
        return self._video_recv

    @video_recv.setter
    def video_recv(self, video_recv):
        """
        Sets the video_recv of this EndpointsInner.

        :param video_recv: The video_recv of this EndpointsInner.
        :type: str
        """

        self._video_recv = video_recv

    @property
    def video_recv_local_mute(self):
        """
        Gets the video_recv_local_mute of this EndpointsInner.

        :return: The video_recv_local_mute of this EndpointsInner.
        :rtype: str
        """
        return self._video_recv_local_mute

    @video_recv_local_mute.setter
    def video_recv_local_mute(self, video_recv_local_mute):
        """
        Sets the video_recv_local_mute of this EndpointsInner.

        :param video_recv_local_mute: The video_recv_local_mute of this EndpointsInner.
        :type: str
        """

        self._video_recv_local_mute = video_recv_local_mute

    @property
    def video_recv_remote_mute(self):
        """
        Gets the video_recv_remote_mute of this EndpointsInner.

        :return: The video_recv_remote_mute of this EndpointsInner.
        :rtype: str
        """
        return self._video_recv_remote_mute

    @video_recv_remote_mute.setter
    def video_recv_remote_mute(self, video_recv_remote_mute):
        """
        Sets the video_recv_remote_mute of this EndpointsInner.

        :param video_recv_remote_mute: The video_recv_remote_mute of this EndpointsInner.
        :type: str
        """

        self._video_recv_remote_mute = video_recv_remote_mute

    @property
    def audio_recv(self):
        """
        Gets the audio_recv of this EndpointsInner.

        :return: The audio_recv of this EndpointsInner.
        :rtype: str
        """
        return self._audio_recv

    @audio_recv.setter
    def audio_recv(self, audio_recv):
        """
        Sets the audio_recv of this EndpointsInner.

        :param audio_recv: The audio_recv of this EndpointsInner.
        :type: str
        """

        self._audio_recv = audio_recv

    @property
    def audio_recv_local_mute(self):
        """
        Gets the audio_recv_local_mute of this EndpointsInner.

        :return: The audio_recv_local_mute of this EndpointsInner.
        :rtype: str
        """
        return self._audio_recv_local_mute

    @audio_recv_local_mute.setter
    def audio_recv_local_mute(self, audio_recv_local_mute):
        """
        Sets the audio_recv_local_mute of this EndpointsInner.

        :param audio_recv_local_mute: The audio_recv_local_mute of this EndpointsInner.
        :type: str
        """

        self._audio_recv_local_mute = audio_recv_local_mute

    @property
    def audio_recv_remote_mute(self):
        """
        Gets the audio_recv_remote_mute of this EndpointsInner.

        :return: The audio_recv_remote_mute of this EndpointsInner.
        :rtype: str
        """
        return self._audio_recv_remote_mute

    @audio_recv_remote_mute.setter
    def audio_recv_remote_mute(self, audio_recv_remote_mute):
        """
        Sets the audio_recv_remote_mute of this EndpointsInner.

        :param audio_recv_remote_mute: The audio_recv_remote_mute of this EndpointsInner.
        :type: str
        """

        self._audio_recv_remote_mute = audio_recv_remote_mute

    @property
    def audio_recv_codec(self):
        """
        Gets the audio_recv_codec of this EndpointsInner.

        :return: The audio_recv_codec of this EndpointsInner.
        :rtype: str
        """
        return self._audio_recv_codec

    @audio_recv_codec.setter
    def audio_recv_codec(self, audio_recv_codec):
        """
        Sets the audio_recv_codec of this EndpointsInner.

        :param audio_recv_codec: The audio_recv_codec of this EndpointsInner.
        :type: str
        """

        self._audio_recv_codec = audio_recv_codec

    @property
    def audio_send_codec(self):
        """
        Gets the audio_send_codec of this EndpointsInner.

        :return: The audio_send_codec of this EndpointsInner.
        :rtype: str
        """
        return self._audio_send_codec

    @audio_send_codec.setter
    def audio_send_codec(self, audio_send_codec):
        """
        Sets the audio_send_codec of this EndpointsInner.

        :param audio_send_codec: The audio_send_codec of this EndpointsInner.
        :type: str
        """

        self._audio_send_codec = audio_send_codec

    @property
    def video_recv_codec(self):
        """
        Gets the video_recv_codec of this EndpointsInner.

        :return: The video_recv_codec of this EndpointsInner.
        :rtype: str
        """
        return self._video_recv_codec

    @video_recv_codec.setter
    def video_recv_codec(self, video_recv_codec):
        """
        Sets the video_recv_codec of this EndpointsInner.

        :param video_recv_codec: The video_recv_codec of this EndpointsInner.
        :type: str
        """

        self._video_recv_codec = video_recv_codec

    @property
    def video_recv_height(self):
        """
        Gets the video_recv_height of this EndpointsInner.

        :return: The video_recv_height of this EndpointsInner.
        :rtype: str
        """
        return self._video_recv_height

    @video_recv_height.setter
    def video_recv_height(self, video_recv_height):
        """
        Sets the video_recv_height of this EndpointsInner.

        :param video_recv_height: The video_recv_height of this EndpointsInner.
        :type: str
        """

        self._video_recv_height = video_recv_height

    @property
    def video_recv_width(self):
        """
        Gets the video_recv_width of this EndpointsInner.

        :return: The video_recv_width of this EndpointsInner.
        :rtype: str
        """
        return self._video_recv_width

    @video_recv_width.setter
    def video_recv_width(self, video_recv_width):
        """
        Sets the video_recv_width of this EndpointsInner.

        :param video_recv_width: The video_recv_width of this EndpointsInner.
        :type: str
        """

        self._video_recv_width = video_recv_width

    @property
    def video_send_codec(self):
        """
        Gets the video_send_codec of this EndpointsInner.

        :return: The video_send_codec of this EndpointsInner.
        :rtype: str
        """
        return self._video_send_codec

    @video_send_codec.setter
    def video_send_codec(self, video_send_codec):
        """
        Sets the video_send_codec of this EndpointsInner.

        :param video_send_codec: The video_send_codec of this EndpointsInner.
        :type: str
        """

        self._video_send_codec = video_send_codec

    @property
    def video_send_height(self):
        """
        Gets the video_send_height of this EndpointsInner.

        :return: The video_send_height of this EndpointsInner.
        :rtype: str
        """
        return self._video_send_height

    @video_send_height.setter
    def video_send_height(self, video_send_height):
        """
        Sets the video_send_height of this EndpointsInner.

        :param video_send_height: The video_send_height of this EndpointsInner.
        :type: str
        """

        self._video_send_height = video_send_height

    @property
    def video_send_width(self):
        """
        Gets the video_send_width of this EndpointsInner.

        :return: The video_send_width of this EndpointsInner.
        :rtype: str
        """
        return self._video_send_width

    @video_send_width.setter
    def video_send_width(self, video_send_width):
        """
        Sets the video_send_width of this EndpointsInner.

        :param video_send_width: The video_send_width of this EndpointsInner.
        :type: str
        """

        self._video_send_width = video_send_width

    @property
    def visibility(self):
        """
        Gets the visibility of this EndpointsInner.

        :return: The visibility of this EndpointsInner.
        :rtype: str
        """
        return self._visibility

    @visibility.setter
    def visibility(self, visibility):
        """
        Sets the visibility of this EndpointsInner.

        :param visibility: The visibility of this EndpointsInner.
        :type: str
        """

        self._visibility = visibility

    @property
    def chat_endpoint_guid(self):
        """
        Gets the chat_endpoint_guid of this EndpointsInner.

        :return: The chat_endpoint_guid of this EndpointsInner.
        :rtype: str
        """
        return self._chat_endpoint_guid

    @chat_endpoint_guid.setter
    def chat_endpoint_guid(self, chat_endpoint_guid):
        """
        Sets the chat_endpoint_guid of this EndpointsInner.

        :param chat_endpoint_guid: The chat_endpoint_guid of this EndpointsInner.
        :type: str
        """

        self._chat_endpoint_guid = chat_endpoint_guid

    @property
    def endpoint_guid(self):
        """
        Gets the endpoint_guid of this EndpointsInner.

        :return: The endpoint_guid of this EndpointsInner.
        :rtype: str
        """
        return self._endpoint_guid

    @endpoint_guid.setter
    def endpoint_guid(self, endpoint_guid):
        """
        Sets the endpoint_guid of this EndpointsInner.

        :param endpoint_guid: The endpoint_guid of this EndpointsInner.
        :type: str
        """

        self._endpoint_guid = endpoint_guid

    @property
    def rdc_version(self):
        """
        Gets the rdc_version of this EndpointsInner.

        :return: The rdc_version of this EndpointsInner.
        :rtype: str
        """
        return self._rdc_version

    @rdc_version.setter
    def rdc_version(self, rdc_version):
        """
        Sets the rdc_version of this EndpointsInner.

        :param rdc_version: The rdc_version of this EndpointsInner.
        :type: str
        """

        self._rdc_version = rdc_version

    @property
    def rdc_controller_capable(self):
        """
        Gets the rdc_controller_capable of this EndpointsInner.

        :return: The rdc_controller_capable of this EndpointsInner.
        :rtype: str
        """
        return self._rdc_controller_capable

    @rdc_controller_capable.setter
    def rdc_controller_capable(self, rdc_controller_capable):
        """
        Sets the rdc_controller_capable of this EndpointsInner.

        :param rdc_controller_capable: The rdc_controller_capable of this EndpointsInner.
        :type: str
        """

        self._rdc_controller_capable = rdc_controller_capable

    @property
    def rdc_controllee_capable(self):
        """
        Gets the rdc_controllee_capable of this EndpointsInner.

        :return: The rdc_controllee_capable of this EndpointsInner.
        :rtype: str
        """
        return self._rdc_controllee_capable

    @rdc_controllee_capable.setter
    def rdc_controllee_capable(self, rdc_controllee_capable):
        """
        Sets the rdc_controllee_capable of this EndpointsInner.

        :param rdc_controllee_capable: The rdc_controllee_capable of this EndpointsInner.
        :type: str
        """

        self._rdc_controllee_capable = rdc_controllee_capable

    @property
    def connections(self):
        """
        Gets the connections of this EndpointsInner.

        :return: The connections of this EndpointsInner.
        :rtype: list[EndpointsInnerConnections]
        """
        return self._connections

    @connections.setter
    def connections(self, connections):
        """
        Sets the connections of this EndpointsInner.

        :param connections: The connections of this EndpointsInner.
        :type: list[EndpointsInnerConnections]
        """

        self._connections = connections

    def to_dict(self):
        """
        Returns the model properties as a dict
        """
        result = {}

        for attr, _ in iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """
        Returns the string representation of the model
        """
        return pformat(self.to_dict())

    def __repr__(self):
        """
        For `print` and `pprint`
        """
        return self.to_str()

    def __eq__(self, other):
        """
        Returns true if both objects are equal
        """
        if not isinstance(other, EndpointsInner):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
