# coding: utf-8

"""
    BlueJeans onVideo REST API

     ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by an access code.  THe access code can ensure security of participants who can join, and also designate user(s) who need an ability to moderate a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>, and may be assigned a moderator passcode allowing designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About onVideo Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 

    OpenAPI spec version: 1.0.0
    Contact: brandon@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from pprint import pformat
from six import iteritems
import re


class RecordingSession(object):
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
        'id': 'int',
        'content_status': 'str',
        'recording_type': 'str',
        'content_id': 'int',
        'thumbnail_url': 'str',
        'start_time_offset': 'int',
        'end_time_offset': 'int',
        'duration': 'int',
        'started_by': 'RecordingSessionStartedBy',
        'stopped_by': 'RecordingSessionStartedBy'
    }

    attribute_map = {
        'id': 'id',
        'content_status': 'contentStatus',
        'recording_type': 'recordingType',
        'content_id': 'contentId',
        'thumbnail_url': 'thumbnailUrl',
        'start_time_offset': 'startTimeOffset',
        'end_time_offset': 'endTimeOffset',
        'duration': 'duration',
        'started_by': 'startedBy',
        'stopped_by': 'stoppedBy'
    }

    def __init__(self, id=None, content_status=None, recording_type=None, content_id=None, thumbnail_url=None, start_time_offset=None, end_time_offset=None, duration=None, started_by=None, stopped_by=None):
        """
        RecordingSession - a model defined in Swagger
        """

        self._id = None
        self._content_status = None
        self._recording_type = None
        self._content_id = None
        self._thumbnail_url = None
        self._start_time_offset = None
        self._end_time_offset = None
        self._duration = None
        self._started_by = None
        self._stopped_by = None

        if id is not None:
          self.id = id
        if content_status is not None:
          self.content_status = content_status
        if recording_type is not None:
          self.recording_type = recording_type
        if content_id is not None:
          self.content_id = content_id
        if thumbnail_url is not None:
          self.thumbnail_url = thumbnail_url
        if start_time_offset is not None:
          self.start_time_offset = start_time_offset
        if end_time_offset is not None:
          self.end_time_offset = end_time_offset
        if duration is not None:
          self.duration = duration
        if started_by is not None:
          self.started_by = started_by
        if stopped_by is not None:
          self.stopped_by = stopped_by

    @property
    def id(self):
        """
        Gets the id of this RecordingSession.

        :return: The id of this RecordingSession.
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """
        Sets the id of this RecordingSession.

        :param id: The id of this RecordingSession.
        :type: int
        """

        self._id = id

    @property
    def content_status(self):
        """
        Gets the content_status of this RecordingSession.

        :return: The content_status of this RecordingSession.
        :rtype: str
        """
        return self._content_status

    @content_status.setter
    def content_status(self, content_status):
        """
        Sets the content_status of this RecordingSession.

        :param content_status: The content_status of this RecordingSession.
        :type: str
        """

        self._content_status = content_status

    @property
    def recording_type(self):
        """
        Gets the recording_type of this RecordingSession.

        :return: The recording_type of this RecordingSession.
        :rtype: str
        """
        return self._recording_type

    @recording_type.setter
    def recording_type(self, recording_type):
        """
        Sets the recording_type of this RecordingSession.

        :param recording_type: The recording_type of this RecordingSession.
        :type: str
        """

        self._recording_type = recording_type

    @property
    def content_id(self):
        """
        Gets the content_id of this RecordingSession.

        :return: The content_id of this RecordingSession.
        :rtype: int
        """
        return self._content_id

    @content_id.setter
    def content_id(self, content_id):
        """
        Sets the content_id of this RecordingSession.

        :param content_id: The content_id of this RecordingSession.
        :type: int
        """

        self._content_id = content_id

    @property
    def thumbnail_url(self):
        """
        Gets the thumbnail_url of this RecordingSession.

        :return: The thumbnail_url of this RecordingSession.
        :rtype: str
        """
        return self._thumbnail_url

    @thumbnail_url.setter
    def thumbnail_url(self, thumbnail_url):
        """
        Sets the thumbnail_url of this RecordingSession.

        :param thumbnail_url: The thumbnail_url of this RecordingSession.
        :type: str
        """

        self._thumbnail_url = thumbnail_url

    @property
    def start_time_offset(self):
        """
        Gets the start_time_offset of this RecordingSession.

        :return: The start_time_offset of this RecordingSession.
        :rtype: int
        """
        return self._start_time_offset

    @start_time_offset.setter
    def start_time_offset(self, start_time_offset):
        """
        Sets the start_time_offset of this RecordingSession.

        :param start_time_offset: The start_time_offset of this RecordingSession.
        :type: int
        """

        self._start_time_offset = start_time_offset

    @property
    def end_time_offset(self):
        """
        Gets the end_time_offset of this RecordingSession.

        :return: The end_time_offset of this RecordingSession.
        :rtype: int
        """
        return self._end_time_offset

    @end_time_offset.setter
    def end_time_offset(self, end_time_offset):
        """
        Sets the end_time_offset of this RecordingSession.

        :param end_time_offset: The end_time_offset of this RecordingSession.
        :type: int
        """

        self._end_time_offset = end_time_offset

    @property
    def duration(self):
        """
        Gets the duration of this RecordingSession.

        :return: The duration of this RecordingSession.
        :rtype: int
        """
        return self._duration

    @duration.setter
    def duration(self, duration):
        """
        Sets the duration of this RecordingSession.

        :param duration: The duration of this RecordingSession.
        :type: int
        """

        self._duration = duration

    @property
    def started_by(self):
        """
        Gets the started_by of this RecordingSession.

        :return: The started_by of this RecordingSession.
        :rtype: RecordingSessionStartedBy
        """
        return self._started_by

    @started_by.setter
    def started_by(self, started_by):
        """
        Sets the started_by of this RecordingSession.

        :param started_by: The started_by of this RecordingSession.
        :type: RecordingSessionStartedBy
        """

        self._started_by = started_by

    @property
    def stopped_by(self):
        """
        Gets the stopped_by of this RecordingSession.

        :return: The stopped_by of this RecordingSession.
        :rtype: RecordingSessionStartedBy
        """
        return self._stopped_by

    @stopped_by.setter
    def stopped_by(self, stopped_by):
        """
        Sets the stopped_by of this RecordingSession.

        :param stopped_by: The stopped_by of this RecordingSession.
        :type: RecordingSessionStartedBy
        """

        self._stopped_by = stopped_by

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
        if not isinstance(other, RecordingSession):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
