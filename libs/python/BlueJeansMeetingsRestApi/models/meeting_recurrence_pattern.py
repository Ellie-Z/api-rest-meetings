# coding: utf-8

"""
    BlueJeans Meetings REST API

     ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/23/2018 </alert>Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr>   # noqa: E501

    OpenAPI spec version: 1.0.4407232018
    Contact: glenn@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six


class MeetingRecurrencePattern(object):
    """NOTE: This class is auto generated by the swagger code generator program.

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
        'recurrence_type': 'str',
        'end_date': 'int',
        'recurrence_count': 'int',
        'frequency': 'int',
        'days_of_week_mask': 'int',
        'day_of_month': 'int',
        'week_of_month': 'str',
        'month_of_year': 'str'
    }

    attribute_map = {
        'recurrence_type': 'recurrenceType',
        'end_date': 'endDate',
        'recurrence_count': 'recurrenceCount',
        'frequency': 'frequency',
        'days_of_week_mask': 'daysOfWeekMask',
        'day_of_month': 'dayOfMonth',
        'week_of_month': 'weekOfMonth',
        'month_of_year': 'monthOfYear'
    }

    def __init__(self, recurrence_type=None, end_date=None, recurrence_count=None, frequency=None, days_of_week_mask=None, day_of_month=None, week_of_month='NONE', month_of_year='NONE'):  # noqa: E501
        """MeetingRecurrencePattern - a model defined in Swagger"""  # noqa: E501

        self._recurrence_type = None
        self._end_date = None
        self._recurrence_count = None
        self._frequency = None
        self._days_of_week_mask = None
        self._day_of_month = None
        self._week_of_month = None
        self._month_of_year = None
        self.discriminator = None

        if recurrence_type is not None:
            self.recurrence_type = recurrence_type
        if end_date is not None:
            self.end_date = end_date
        if recurrence_count is not None:
            self.recurrence_count = recurrence_count
        if frequency is not None:
            self.frequency = frequency
        if days_of_week_mask is not None:
            self.days_of_week_mask = days_of_week_mask
        if day_of_month is not None:
            self.day_of_month = day_of_month
        if week_of_month is not None:
            self.week_of_month = week_of_month
        if month_of_year is not None:
            self.month_of_year = month_of_year

    @property
    def recurrence_type(self):
        """Gets the recurrence_type of this MeetingRecurrencePattern.  # noqa: E501


        :return: The recurrence_type of this MeetingRecurrencePattern.  # noqa: E501
        :rtype: str
        """
        return self._recurrence_type

    @recurrence_type.setter
    def recurrence_type(self, recurrence_type):
        """Sets the recurrence_type of this MeetingRecurrencePattern.


        :param recurrence_type: The recurrence_type of this MeetingRecurrencePattern.  # noqa: E501
        :type: str
        """
        allowed_values = ["DAILY", "WEEKLY", "MONTHLY"]  # noqa: E501
        if recurrence_type not in allowed_values:
            raise ValueError(
                "Invalid value for `recurrence_type` ({0}), must be one of {1}"  # noqa: E501
                .format(recurrence_type, allowed_values)
            )

        self._recurrence_type = recurrence_type

    @property
    def end_date(self):
        """Gets the end_date of this MeetingRecurrencePattern.  # noqa: E501

        This is the epoch-based ending-time (in milliseconds) for the recurrence chain of meetings.  # noqa: E501

        :return: The end_date of this MeetingRecurrencePattern.  # noqa: E501
        :rtype: int
        """
        return self._end_date

    @end_date.setter
    def end_date(self, end_date):
        """Sets the end_date of this MeetingRecurrencePattern.

        This is the epoch-based ending-time (in milliseconds) for the recurrence chain of meetings.  # noqa: E501

        :param end_date: The end_date of this MeetingRecurrencePattern.  # noqa: E501
        :type: int
        """

        self._end_date = end_date

    @property
    def recurrence_count(self):
        """Gets the recurrence_count of this MeetingRecurrencePattern.  # noqa: E501

        The number of reoccurring meetings  # noqa: E501

        :return: The recurrence_count of this MeetingRecurrencePattern.  # noqa: E501
        :rtype: int
        """
        return self._recurrence_count

    @recurrence_count.setter
    def recurrence_count(self, recurrence_count):
        """Sets the recurrence_count of this MeetingRecurrencePattern.

        The number of reoccurring meetings  # noqa: E501

        :param recurrence_count: The recurrence_count of this MeetingRecurrencePattern.  # noqa: E501
        :type: int
        """

        self._recurrence_count = recurrence_count

    @property
    def frequency(self):
        """Gets the frequency of this MeetingRecurrencePattern.  # noqa: E501

        the interval of reoccurring meetings.  # noqa: E501

        :return: The frequency of this MeetingRecurrencePattern.  # noqa: E501
        :rtype: int
        """
        return self._frequency

    @frequency.setter
    def frequency(self, frequency):
        """Sets the frequency of this MeetingRecurrencePattern.

        the interval of reoccurring meetings.  # noqa: E501

        :param frequency: The frequency of this MeetingRecurrencePattern.  # noqa: E501
        :type: int
        """

        self._frequency = frequency

    @property
    def days_of_week_mask(self):
        """Gets the days_of_week_mask of this MeetingRecurrencePattern.  # noqa: E501

        bit mask for selecting which days of the week.  Sunday:1, Monday:2, Tuesday:4, Wednesday:8, Thursday:16, Friday:32, and Saturday:64  # noqa: E501

        :return: The days_of_week_mask of this MeetingRecurrencePattern.  # noqa: E501
        :rtype: int
        """
        return self._days_of_week_mask

    @days_of_week_mask.setter
    def days_of_week_mask(self, days_of_week_mask):
        """Sets the days_of_week_mask of this MeetingRecurrencePattern.

        bit mask for selecting which days of the week.  Sunday:1, Monday:2, Tuesday:4, Wednesday:8, Thursday:16, Friday:32, and Saturday:64  # noqa: E501

        :param days_of_week_mask: The days_of_week_mask of this MeetingRecurrencePattern.  # noqa: E501
        :type: int
        """

        self._days_of_week_mask = days_of_week_mask

    @property
    def day_of_month(self):
        """Gets the day_of_month of this MeetingRecurrencePattern.  # noqa: E501

        the numerical day in the month for monthly reoccurring meetings.  # noqa: E501

        :return: The day_of_month of this MeetingRecurrencePattern.  # noqa: E501
        :rtype: int
        """
        return self._day_of_month

    @day_of_month.setter
    def day_of_month(self, day_of_month):
        """Sets the day_of_month of this MeetingRecurrencePattern.

        the numerical day in the month for monthly reoccurring meetings.  # noqa: E501

        :param day_of_month: The day_of_month of this MeetingRecurrencePattern.  # noqa: E501
        :type: int
        """

        self._day_of_month = day_of_month

    @property
    def week_of_month(self):
        """Gets the week_of_month of this MeetingRecurrencePattern.  # noqa: E501

        the numerical week in the month for reoccuring meetings.  # noqa: E501

        :return: The week_of_month of this MeetingRecurrencePattern.  # noqa: E501
        :rtype: str
        """
        return self._week_of_month

    @week_of_month.setter
    def week_of_month(self, week_of_month):
        """Sets the week_of_month of this MeetingRecurrencePattern.

        the numerical week in the month for reoccuring meetings.  # noqa: E501

        :param week_of_month: The week_of_month of this MeetingRecurrencePattern.  # noqa: E501
        :type: str
        """
        allowed_values = ["NONE", "FIRST", "SECOND", "THIRD", "FOURTH", "LAST"]  # noqa: E501
        if week_of_month not in allowed_values:
            raise ValueError(
                "Invalid value for `week_of_month` ({0}), must be one of {1}"  # noqa: E501
                .format(week_of_month, allowed_values)
            )

        self._week_of_month = week_of_month

    @property
    def month_of_year(self):
        """Gets the month_of_year of this MeetingRecurrencePattern.  # noqa: E501

        the month in the year for reoccurring meetings.  # noqa: E501

        :return: The month_of_year of this MeetingRecurrencePattern.  # noqa: E501
        :rtype: str
        """
        return self._month_of_year

    @month_of_year.setter
    def month_of_year(self, month_of_year):
        """Sets the month_of_year of this MeetingRecurrencePattern.

        the month in the year for reoccurring meetings.  # noqa: E501

        :param month_of_year: The month_of_year of this MeetingRecurrencePattern.  # noqa: E501
        :type: str
        """
        allowed_values = ["NONE", "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"]  # noqa: E501
        if month_of_year not in allowed_values:
            raise ValueError(
                "Invalid value for `month_of_year` ({0}), must be one of {1}"  # noqa: E501
                .format(month_of_year, allowed_values)
            )

        self._month_of_year = month_of_year

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
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
        if issubclass(MeetingRecurrencePattern, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, MeetingRecurrencePattern):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
