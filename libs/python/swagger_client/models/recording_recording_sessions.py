# coding: utf-8

"""
    BlueJeans onVideo REST API

    _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 

    OpenAPI spec version: 1.0.0
    Contact: brandon@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
"""

from pprint import pformat
from six import iteritems
import re


class RecordingRecordingSessions(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, id=None, content_status=None, recording_type=None, content_id=None, thumbnail_url=None, start_time_offset=None, end_time_offset=None, duration=None, started_by=None, stopped_by=None):
        """
        RecordingRecordingSessions - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'id': 'int',
            'content_status': 'str',
            'recording_type': 'str',
            'content_id': 'int',
            'thumbnail_url': 'str',
            'start_time_offset': 'int',
            'end_time_offset': 'int',
            'duration': 'int',
            'started_by': 'RecordingStartedBy',
            'stopped_by': 'RecordingStartedBy'
        }

        self.attribute_map = {
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

        self._id = id
        self._content_status = content_status
        self._recording_type = recording_type
        self._content_id = content_id
        self._thumbnail_url = thumbnail_url
        self._start_time_offset = start_time_offset
        self._end_time_offset = end_time_offset
        self._duration = duration
        self._started_by = started_by
        self._stopped_by = stopped_by

    @property
    def id(self):
        """
        Gets the id of this RecordingRecordingSessions.


        :return: The id of this RecordingRecordingSessions.
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """
        Sets the id of this RecordingRecordingSessions.


        :param id: The id of this RecordingRecordingSessions.
        :type: int
        """

        self._id = id

    @property
    def content_status(self):
        """
        Gets the content_status of this RecordingRecordingSessions.


        :return: The content_status of this RecordingRecordingSessions.
        :rtype: str
        """
        return self._content_status

    @content_status.setter
    def content_status(self, content_status):
        """
        Sets the content_status of this RecordingRecordingSessions.


        :param content_status: The content_status of this RecordingRecordingSessions.
        :type: str
        """

        self._content_status = content_status

    @property
    def recording_type(self):
        """
        Gets the recording_type of this RecordingRecordingSessions.


        :return: The recording_type of this RecordingRecordingSessions.
        :rtype: str
        """
        return self._recording_type

    @recording_type.setter
    def recording_type(self, recording_type):
        """
        Sets the recording_type of this RecordingRecordingSessions.


        :param recording_type: The recording_type of this RecordingRecordingSessions.
        :type: str
        """

        self._recording_type = recording_type

    @property
    def content_id(self):
        """
        Gets the content_id of this RecordingRecordingSessions.


        :return: The content_id of this RecordingRecordingSessions.
        :rtype: int
        """
        return self._content_id

    @content_id.setter
    def content_id(self, content_id):
        """
        Sets the content_id of this RecordingRecordingSessions.


        :param content_id: The content_id of this RecordingRecordingSessions.
        :type: int
        """

        self._content_id = content_id

    @property
    def thumbnail_url(self):
        """
        Gets the thumbnail_url of this RecordingRecordingSessions.


        :return: The thumbnail_url of this RecordingRecordingSessions.
        :rtype: str
        """
        return self._thumbnail_url

    @thumbnail_url.setter
    def thumbnail_url(self, thumbnail_url):
        """
        Sets the thumbnail_url of this RecordingRecordingSessions.


        :param thumbnail_url: The thumbnail_url of this RecordingRecordingSessions.
        :type: str
        """

        self._thumbnail_url = thumbnail_url

    @property
    def start_time_offset(self):
        """
        Gets the start_time_offset of this RecordingRecordingSessions.


        :return: The start_time_offset of this RecordingRecordingSessions.
        :rtype: int
        """
        return self._start_time_offset

    @start_time_offset.setter
    def start_time_offset(self, start_time_offset):
        """
        Sets the start_time_offset of this RecordingRecordingSessions.


        :param start_time_offset: The start_time_offset of this RecordingRecordingSessions.
        :type: int
        """

        self._start_time_offset = start_time_offset

    @property
    def end_time_offset(self):
        """
        Gets the end_time_offset of this RecordingRecordingSessions.


        :return: The end_time_offset of this RecordingRecordingSessions.
        :rtype: int
        """
        return self._end_time_offset

    @end_time_offset.setter
    def end_time_offset(self, end_time_offset):
        """
        Sets the end_time_offset of this RecordingRecordingSessions.


        :param end_time_offset: The end_time_offset of this RecordingRecordingSessions.
        :type: int
        """

        self._end_time_offset = end_time_offset

    @property
    def duration(self):
        """
        Gets the duration of this RecordingRecordingSessions.


        :return: The duration of this RecordingRecordingSessions.
        :rtype: int
        """
        return self._duration

    @duration.setter
    def duration(self, duration):
        """
        Sets the duration of this RecordingRecordingSessions.


        :param duration: The duration of this RecordingRecordingSessions.
        :type: int
        """

        self._duration = duration

    @property
    def started_by(self):
        """
        Gets the started_by of this RecordingRecordingSessions.


        :return: The started_by of this RecordingRecordingSessions.
        :rtype: RecordingStartedBy
        """
        return self._started_by

    @started_by.setter
    def started_by(self, started_by):
        """
        Sets the started_by of this RecordingRecordingSessions.


        :param started_by: The started_by of this RecordingRecordingSessions.
        :type: RecordingStartedBy
        """

        self._started_by = started_by

    @property
    def stopped_by(self):
        """
        Gets the stopped_by of this RecordingRecordingSessions.


        :return: The stopped_by of this RecordingRecordingSessions.
        :rtype: RecordingStartedBy
        """
        return self._stopped_by

    @stopped_by.setter
    def stopped_by(self, stopped_by):
        """
        Sets the stopped_by of this RecordingRecordingSessions.


        :param stopped_by: The stopped_by of this RecordingRecordingSessions.
        :type: RecordingStartedBy
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
        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
