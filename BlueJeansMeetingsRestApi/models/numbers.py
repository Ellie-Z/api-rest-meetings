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


class Numbers(object):
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
        'meeting_id': 'str',
        'allow_direct_dial': 'bool',
        'use_attendee_passcode': 'bool',
        'pstn_numbers_url': 'str',
        'moderator_passcode': 'str',
        'precision': 'str',
        'pstn_localization_supported': 'bool',
        'partner_integrated_meeting': 'bool',
        'numbers': 'list[NumbersNumbers]'
    }

    attribute_map = {
        'meeting_id': 'meetingId',
        'allow_direct_dial': 'allowDirectDial',
        'use_attendee_passcode': 'useAttendeePasscode',
        'pstn_numbers_url': 'pstnNumbersUrl',
        'moderator_passcode': 'moderatorPasscode',
        'precision': 'precision',
        'pstn_localization_supported': 'pstnLocalizationSupported',
        'partner_integrated_meeting': 'partnerIntegratedMeeting',
        'numbers': 'numbers'
    }

    def __init__(self, meeting_id=None, allow_direct_dial=None, use_attendee_passcode=None, pstn_numbers_url=None, moderator_passcode=None, precision=None, pstn_localization_supported=None, partner_integrated_meeting=None, numbers=None):
        """
        Numbers - a model defined in Swagger
        """

        self._meeting_id = None
        self._allow_direct_dial = None
        self._use_attendee_passcode = None
        self._pstn_numbers_url = None
        self._moderator_passcode = None
        self._precision = None
        self._pstn_localization_supported = None
        self._partner_integrated_meeting = None
        self._numbers = None

        if meeting_id is not None:
          self.meeting_id = meeting_id
        if allow_direct_dial is not None:
          self.allow_direct_dial = allow_direct_dial
        if use_attendee_passcode is not None:
          self.use_attendee_passcode = use_attendee_passcode
        if pstn_numbers_url is not None:
          self.pstn_numbers_url = pstn_numbers_url
        if moderator_passcode is not None:
          self.moderator_passcode = moderator_passcode
        if precision is not None:
          self.precision = precision
        if pstn_localization_supported is not None:
          self.pstn_localization_supported = pstn_localization_supported
        if partner_integrated_meeting is not None:
          self.partner_integrated_meeting = partner_integrated_meeting
        if numbers is not None:
          self.numbers = numbers

    @property
    def meeting_id(self):
        """
        Gets the meeting_id of this Numbers.

        :return: The meeting_id of this Numbers.
        :rtype: str
        """
        return self._meeting_id

    @meeting_id.setter
    def meeting_id(self, meeting_id):
        """
        Sets the meeting_id of this Numbers.

        :param meeting_id: The meeting_id of this Numbers.
        :type: str
        """

        self._meeting_id = meeting_id

    @property
    def allow_direct_dial(self):
        """
        Gets the allow_direct_dial of this Numbers.

        :return: The allow_direct_dial of this Numbers.
        :rtype: bool
        """
        return self._allow_direct_dial

    @allow_direct_dial.setter
    def allow_direct_dial(self, allow_direct_dial):
        """
        Sets the allow_direct_dial of this Numbers.

        :param allow_direct_dial: The allow_direct_dial of this Numbers.
        :type: bool
        """

        self._allow_direct_dial = allow_direct_dial

    @property
    def use_attendee_passcode(self):
        """
        Gets the use_attendee_passcode of this Numbers.

        :return: The use_attendee_passcode of this Numbers.
        :rtype: bool
        """
        return self._use_attendee_passcode

    @use_attendee_passcode.setter
    def use_attendee_passcode(self, use_attendee_passcode):
        """
        Sets the use_attendee_passcode of this Numbers.

        :param use_attendee_passcode: The use_attendee_passcode of this Numbers.
        :type: bool
        """

        self._use_attendee_passcode = use_attendee_passcode

    @property
    def pstn_numbers_url(self):
        """
        Gets the pstn_numbers_url of this Numbers.

        :return: The pstn_numbers_url of this Numbers.
        :rtype: str
        """
        return self._pstn_numbers_url

    @pstn_numbers_url.setter
    def pstn_numbers_url(self, pstn_numbers_url):
        """
        Sets the pstn_numbers_url of this Numbers.

        :param pstn_numbers_url: The pstn_numbers_url of this Numbers.
        :type: str
        """

        self._pstn_numbers_url = pstn_numbers_url

    @property
    def moderator_passcode(self):
        """
        Gets the moderator_passcode of this Numbers.

        :return: The moderator_passcode of this Numbers.
        :rtype: str
        """
        return self._moderator_passcode

    @moderator_passcode.setter
    def moderator_passcode(self, moderator_passcode):
        """
        Sets the moderator_passcode of this Numbers.

        :param moderator_passcode: The moderator_passcode of this Numbers.
        :type: str
        """

        self._moderator_passcode = moderator_passcode

    @property
    def precision(self):
        """
        Gets the precision of this Numbers.

        :return: The precision of this Numbers.
        :rtype: str
        """
        return self._precision

    @precision.setter
    def precision(self, precision):
        """
        Sets the precision of this Numbers.

        :param precision: The precision of this Numbers.
        :type: str
        """

        self._precision = precision

    @property
    def pstn_localization_supported(self):
        """
        Gets the pstn_localization_supported of this Numbers.

        :return: The pstn_localization_supported of this Numbers.
        :rtype: bool
        """
        return self._pstn_localization_supported

    @pstn_localization_supported.setter
    def pstn_localization_supported(self, pstn_localization_supported):
        """
        Sets the pstn_localization_supported of this Numbers.

        :param pstn_localization_supported: The pstn_localization_supported of this Numbers.
        :type: bool
        """

        self._pstn_localization_supported = pstn_localization_supported

    @property
    def partner_integrated_meeting(self):
        """
        Gets the partner_integrated_meeting of this Numbers.

        :return: The partner_integrated_meeting of this Numbers.
        :rtype: bool
        """
        return self._partner_integrated_meeting

    @partner_integrated_meeting.setter
    def partner_integrated_meeting(self, partner_integrated_meeting):
        """
        Sets the partner_integrated_meeting of this Numbers.

        :param partner_integrated_meeting: The partner_integrated_meeting of this Numbers.
        :type: bool
        """

        self._partner_integrated_meeting = partner_integrated_meeting

    @property
    def numbers(self):
        """
        Gets the numbers of this Numbers.

        :return: The numbers of this Numbers.
        :rtype: list[NumbersNumbers]
        """
        return self._numbers

    @numbers.setter
    def numbers(self, numbers):
        """
        Sets the numbers of this Numbers.

        :param numbers: The numbers of this Numbers.
        :type: list[NumbersNumbers]
        """

        self._numbers = numbers

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
        if not isinstance(other, Numbers):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
