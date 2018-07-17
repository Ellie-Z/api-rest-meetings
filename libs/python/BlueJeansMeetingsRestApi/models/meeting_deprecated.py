# coding: utf-8

"""
    BlueJeans Meetings REST API

     ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/010/2018 </alert>Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 

    OpenAPI spec version: 1.0.0.mm44 (7/06/2018)
    Contact: glenn@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from pprint import pformat
from six import iteritems
import re


class MeetingDeprecated(object):
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
        'title': 'str',
        'description': 'str',
        'start': 'int',
        'end': 'int',
        'timezone': 'str',
        'numeric_meeting_id': 'str',
        'attendee_passcode': 'str',
        'is_personal_meeting': 'bool',
        'is_large_meeting': 'bool',
        'add_attendee_passcode': 'bool',
        'end_point_version': 'str',
        'end_point_type': 'str',
        'attendees': 'list[Attendee]',
        'advanced_meeting_options': 'MeetingDeprecatedAdvancedMeetingOptions',
        'recurrence_pattern': 'MeetingRecurrencePattern'
    }

    attribute_map = {
        'id': 'id',
        'title': 'title',
        'description': 'description',
        'start': 'start',
        'end': 'end',
        'timezone': 'timezone',
        'numeric_meeting_id': 'numericMeetingId',
        'attendee_passcode': 'attendeePasscode',
        'is_personal_meeting': 'isPersonalMeeting',
        'is_large_meeting': 'isLargeMeeting',
        'add_attendee_passcode': 'addAttendeePasscode',
        'end_point_version': 'endPointVersion',
        'end_point_type': 'endPointType',
        'attendees': 'attendees',
        'advanced_meeting_options': 'advancedMeetingOptions',
        'recurrence_pattern': 'recurrencePattern'
    }

    def __init__(self, id=None, title='My Test Meeting', description=None, start=None, end=None, timezone='America/New_York', numeric_meeting_id=None, attendee_passcode=None, is_personal_meeting=False, is_large_meeting=None, add_attendee_passcode=None, end_point_version='2.10', end_point_type='WEB_APP', attendees=None, advanced_meeting_options=None, recurrence_pattern=None):
        """
        MeetingDeprecated - a model defined in Swagger
        """

        self._id = None
        self._title = None
        self._description = None
        self._start = None
        self._end = None
        self._timezone = None
        self._numeric_meeting_id = None
        self._attendee_passcode = None
        self._is_personal_meeting = None
        self._is_large_meeting = None
        self._add_attendee_passcode = None
        self._end_point_version = None
        self._end_point_type = None
        self._attendees = None
        self._advanced_meeting_options = None
        self._recurrence_pattern = None

        if id is not None:
          self.id = id
        self.title = title
        if description is not None:
          self.description = description
        self.start = start
        self.end = end
        if timezone is not None:
          self.timezone = timezone
        if numeric_meeting_id is not None:
          self.numeric_meeting_id = numeric_meeting_id
        if attendee_passcode is not None:
          self.attendee_passcode = attendee_passcode
        if is_personal_meeting is not None:
          self.is_personal_meeting = is_personal_meeting
        if is_large_meeting is not None:
          self.is_large_meeting = is_large_meeting
        if add_attendee_passcode is not None:
          self.add_attendee_passcode = add_attendee_passcode
        self.end_point_version = end_point_version
        self.end_point_type = end_point_type
        if attendees is not None:
          self.attendees = attendees
        if advanced_meeting_options is not None:
          self.advanced_meeting_options = advanced_meeting_options
        if recurrence_pattern is not None:
          self.recurrence_pattern = recurrence_pattern

    @property
    def id(self):
        """
        Gets the id of this MeetingDeprecated.
        Unique identifier for meeting.

        :return: The id of this MeetingDeprecated.
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """
        Sets the id of this MeetingDeprecated.
        Unique identifier for meeting.

        :param id: The id of this MeetingDeprecated.
        :type: int
        """

        self._id = id

    @property
    def title(self):
        """
        Gets the title of this MeetingDeprecated.

        :return: The title of this MeetingDeprecated.
        :rtype: str
        """
        return self._title

    @title.setter
    def title(self, title):
        """
        Sets the title of this MeetingDeprecated.

        :param title: The title of this MeetingDeprecated.
        :type: str
        """
        if title is None:
            raise ValueError("Invalid value for `title`, must not be `None`")

        self._title = title

    @property
    def description(self):
        """
        Gets the description of this MeetingDeprecated.

        :return: The description of this MeetingDeprecated.
        :rtype: str
        """
        return self._description

    @description.setter
    def description(self, description):
        """
        Sets the description of this MeetingDeprecated.

        :param description: The description of this MeetingDeprecated.
        :type: str
        """

        self._description = description

    @property
    def start(self):
        """
        Gets the start of this MeetingDeprecated.
        A [UNIX Timestamp](https://currentmillis.com/) in milliseconds

        :return: The start of this MeetingDeprecated.
        :rtype: int
        """
        return self._start

    @start.setter
    def start(self, start):
        """
        Sets the start of this MeetingDeprecated.
        A [UNIX Timestamp](https://currentmillis.com/) in milliseconds

        :param start: The start of this MeetingDeprecated.
        :type: int
        """
        if start is None:
            raise ValueError("Invalid value for `start`, must not be `None`")

        self._start = start

    @property
    def end(self):
        """
        Gets the end of this MeetingDeprecated.
        A [UNIX Timestamp](https://currentmillis.com/) in milliseconds

        :return: The end of this MeetingDeprecated.
        :rtype: int
        """
        return self._end

    @end.setter
    def end(self, end):
        """
        Sets the end of this MeetingDeprecated.
        A [UNIX Timestamp](https://currentmillis.com/) in milliseconds

        :param end: The end of this MeetingDeprecated.
        :type: int
        """
        if end is None:
            raise ValueError("Invalid value for `end`, must not be `None`")

        self._end = end

    @property
    def timezone(self):
        """
        Gets the timezone of this MeetingDeprecated.

        :return: The timezone of this MeetingDeprecated.
        :rtype: str
        """
        return self._timezone

    @timezone.setter
    def timezone(self, timezone):
        """
        Sets the timezone of this MeetingDeprecated.

        :param timezone: The timezone of this MeetingDeprecated.
        :type: str
        """

        self._timezone = timezone

    @property
    def numeric_meeting_id(self):
        """
        Gets the numeric_meeting_id of this MeetingDeprecated.
        The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

        :return: The numeric_meeting_id of this MeetingDeprecated.
        :rtype: str
        """
        return self._numeric_meeting_id

    @numeric_meeting_id.setter
    def numeric_meeting_id(self, numeric_meeting_id):
        """
        Sets the numeric_meeting_id of this MeetingDeprecated.
        The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join.

        :param numeric_meeting_id: The numeric_meeting_id of this MeetingDeprecated.
        :type: str
        """

        self._numeric_meeting_id = numeric_meeting_id

    @property
    def attendee_passcode(self):
        """
        Gets the attendee_passcode of this MeetingDeprecated.

        :return: The attendee_passcode of this MeetingDeprecated.
        :rtype: str
        """
        return self._attendee_passcode

    @attendee_passcode.setter
    def attendee_passcode(self, attendee_passcode):
        """
        Sets the attendee_passcode of this MeetingDeprecated.

        :param attendee_passcode: The attendee_passcode of this MeetingDeprecated.
        :type: str
        """

        self._attendee_passcode = attendee_passcode

    @property
    def is_personal_meeting(self):
        """
        Gets the is_personal_meeting of this MeetingDeprecated.
        Use the scheduler's personal meeting room and Id for this meeting.

        :return: The is_personal_meeting of this MeetingDeprecated.
        :rtype: bool
        """
        return self._is_personal_meeting

    @is_personal_meeting.setter
    def is_personal_meeting(self, is_personal_meeting):
        """
        Sets the is_personal_meeting of this MeetingDeprecated.
        Use the scheduler's personal meeting room and Id for this meeting.

        :param is_personal_meeting: The is_personal_meeting of this MeetingDeprecated.
        :type: bool
        """

        self._is_personal_meeting = is_personal_meeting

    @property
    def is_large_meeting(self):
        """
        Gets the is_large_meeting of this MeetingDeprecated.
        If true, the meeting is assumed to be large and thus no announcement will be made when a participant joins.

        :return: The is_large_meeting of this MeetingDeprecated.
        :rtype: bool
        """
        return self._is_large_meeting

    @is_large_meeting.setter
    def is_large_meeting(self, is_large_meeting):
        """
        Sets the is_large_meeting of this MeetingDeprecated.
        If true, the meeting is assumed to be large and thus no announcement will be made when a participant joins.

        :param is_large_meeting: The is_large_meeting of this MeetingDeprecated.
        :type: bool
        """

        self._is_large_meeting = is_large_meeting

    @property
    def add_attendee_passcode(self):
        """
        Gets the add_attendee_passcode of this MeetingDeprecated.
        Indicate if you want the attendees to be forced to enter a passcode on entry for extra security. The passcode will be randomly generated at schedule and will be returned in attendeePasscode property of the meeting.

        :return: The add_attendee_passcode of this MeetingDeprecated.
        :rtype: bool
        """
        return self._add_attendee_passcode

    @add_attendee_passcode.setter
    def add_attendee_passcode(self, add_attendee_passcode):
        """
        Sets the add_attendee_passcode of this MeetingDeprecated.
        Indicate if you want the attendees to be forced to enter a passcode on entry for extra security. The passcode will be randomly generated at schedule and will be returned in attendeePasscode property of the meeting.

        :param add_attendee_passcode: The add_attendee_passcode of this MeetingDeprecated.
        :type: bool
        """

        self._add_attendee_passcode = add_attendee_passcode

    @property
    def end_point_version(self):
        """
        Gets the end_point_version of this MeetingDeprecated.

        :return: The end_point_version of this MeetingDeprecated.
        :rtype: str
        """
        return self._end_point_version

    @end_point_version.setter
    def end_point_version(self, end_point_version):
        """
        Sets the end_point_version of this MeetingDeprecated.

        :param end_point_version: The end_point_version of this MeetingDeprecated.
        :type: str
        """
        if end_point_version is None:
            raise ValueError("Invalid value for `end_point_version`, must not be `None`")

        self._end_point_version = end_point_version

    @property
    def end_point_type(self):
        """
        Gets the end_point_type of this MeetingDeprecated.

        :return: The end_point_type of this MeetingDeprecated.
        :rtype: str
        """
        return self._end_point_type

    @end_point_type.setter
    def end_point_type(self, end_point_type):
        """
        Sets the end_point_type of this MeetingDeprecated.

        :param end_point_type: The end_point_type of this MeetingDeprecated.
        :type: str
        """
        if end_point_type is None:
            raise ValueError("Invalid value for `end_point_type`, must not be `None`")

        self._end_point_type = end_point_type

    @property
    def attendees(self):
        """
        Gets the attendees of this MeetingDeprecated.

        :return: The attendees of this MeetingDeprecated.
        :rtype: list[Attendee]
        """
        return self._attendees

    @attendees.setter
    def attendees(self, attendees):
        """
        Sets the attendees of this MeetingDeprecated.

        :param attendees: The attendees of this MeetingDeprecated.
        :type: list[Attendee]
        """

        self._attendees = attendees

    @property
    def advanced_meeting_options(self):
        """
        Gets the advanced_meeting_options of this MeetingDeprecated.

        :return: The advanced_meeting_options of this MeetingDeprecated.
        :rtype: MeetingDeprecatedAdvancedMeetingOptions
        """
        return self._advanced_meeting_options

    @advanced_meeting_options.setter
    def advanced_meeting_options(self, advanced_meeting_options):
        """
        Sets the advanced_meeting_options of this MeetingDeprecated.

        :param advanced_meeting_options: The advanced_meeting_options of this MeetingDeprecated.
        :type: MeetingDeprecatedAdvancedMeetingOptions
        """

        self._advanced_meeting_options = advanced_meeting_options

    @property
    def recurrence_pattern(self):
        """
        Gets the recurrence_pattern of this MeetingDeprecated.

        :return: The recurrence_pattern of this MeetingDeprecated.
        :rtype: MeetingRecurrencePattern
        """
        return self._recurrence_pattern

    @recurrence_pattern.setter
    def recurrence_pattern(self, recurrence_pattern):
        """
        Sets the recurrence_pattern of this MeetingDeprecated.

        :param recurrence_pattern: The recurrence_pattern of this MeetingDeprecated.
        :type: MeetingRecurrencePattern
        """

        self._recurrence_pattern = recurrence_pattern

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
        if not isinstance(other, MeetingDeprecated):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
