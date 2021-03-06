# coding: utf-8

"""
    BlueJeans Meetings REST API

     ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/23/2018 </alert>Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr>   # noqa: E501

    OpenAPI spec version: 1.0.4407232018
    Contact: glenn@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import re  # noqa: F401

# python 2 and python 3 compatibility library
import six

from BlueJeansMeetingsRestApi.api_client import ApiClient


class MeetingApi(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def cancel_meeting(self, user_id, meeting_id, **kwargs):  # noqa: E501
        """Cancel Meeting  # noqa: E501

        This endpoint deletes a scheuled meeting.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.cancel_meeting(user_id, meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int meeting_id: The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. (required)
        :param bool email: Dispatch an email to participants with the specified cancellation message.
        :param str cancellation_message: Message sent to participants when meeting is deleted and email is selected
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.cancel_meeting_with_http_info(user_id, meeting_id, **kwargs)  # noqa: E501
        else:
            (data) = self.cancel_meeting_with_http_info(user_id, meeting_id, **kwargs)  # noqa: E501
            return data

    def cancel_meeting_with_http_info(self, user_id, meeting_id, **kwargs):  # noqa: E501
        """Cancel Meeting  # noqa: E501

        This endpoint deletes a scheuled meeting.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.cancel_meeting_with_http_info(user_id, meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int meeting_id: The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. (required)
        :param bool email: Dispatch an email to participants with the specified cancellation message.
        :param str cancellation_message: Message sent to participants when meeting is deleted and email is selected
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'meeting_id', 'email', 'cancellation_message']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method cancel_meeting" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `cancel_meeting`")  # noqa: E501
        # verify the required parameter 'meeting_id' is set
        if ('meeting_id' not in params or
                params['meeting_id'] is None):
            raise ValueError("Missing the required parameter `meeting_id` when calling `cancel_meeting`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'meeting_id' in params:
            path_params['meeting_id'] = params['meeting_id']  # noqa: E501

        query_params = []
        if 'email' in params:
            query_params.append(('email', params['email']))  # noqa: E501
        if 'cancellation_message' in params:
            query_params.append(('cancellationMessage', params['cancellation_message']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/scheduled_meeting/{meeting_id}', 'DELETE',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def create_meeting(self, user_id, meeting, **kwargs):  # noqa: E501
        """Create Meeting  # noqa: E501

        This endpoint will create a scheduled meeting.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.create_meeting(user_id, meeting, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param ScheduleMeetingMinComp meeting: The desired configuration for the meeting. (<b>NOTE</b> The model provided here is a <i>typical</i> minimum set of meeting parameters.) (required)
        :param bool email: If set to true, sends invitation emails to all listed participants.
        :return: Meeting
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.create_meeting_with_http_info(user_id, meeting, **kwargs)  # noqa: E501
        else:
            (data) = self.create_meeting_with_http_info(user_id, meeting, **kwargs)  # noqa: E501
            return data

    def create_meeting_with_http_info(self, user_id, meeting, **kwargs):  # noqa: E501
        """Create Meeting  # noqa: E501

        This endpoint will create a scheduled meeting.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.create_meeting_with_http_info(user_id, meeting, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param ScheduleMeetingMinComp meeting: The desired configuration for the meeting. (<b>NOTE</b> The model provided here is a <i>typical</i> minimum set of meeting parameters.) (required)
        :param bool email: If set to true, sends invitation emails to all listed participants.
        :return: Meeting
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'meeting', 'email']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method create_meeting" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `create_meeting`")  # noqa: E501
        # verify the required parameter 'meeting' is set
        if ('meeting' not in params or
                params['meeting'] is None):
            raise ValueError("Missing the required parameter `meeting` when calling `create_meeting`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501

        query_params = []
        if 'email' in params:
            query_params.append(('email', params['email']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'meeting' in params:
            body_params = params['meeting']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/scheduled_meeting', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Meeting',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def dialout_pstn(self, user_id, numeric_meeting_id, payload_dialout, **kwargs):  # noqa: E501
        """Dialout via PSTN  # noqa: E501

        Places a PSTN call to a user to join meeting. **Note:** call this API using a meeting access token  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.dialout_pstn(user_id, numeric_meeting_id, payload_dialout, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadDialout payload_dialout: (required)
        :return: DialoutPstn
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.dialout_pstn_with_http_info(user_id, numeric_meeting_id, payload_dialout, **kwargs)  # noqa: E501
        else:
            (data) = self.dialout_pstn_with_http_info(user_id, numeric_meeting_id, payload_dialout, **kwargs)  # noqa: E501
            return data

    def dialout_pstn_with_http_info(self, user_id, numeric_meeting_id, payload_dialout, **kwargs):  # noqa: E501
        """Dialout via PSTN  # noqa: E501

        Places a PSTN call to a user to join meeting. **Note:** call this API using a meeting access token  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.dialout_pstn_with_http_info(user_id, numeric_meeting_id, payload_dialout, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadDialout payload_dialout: (required)
        :return: DialoutPstn
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'payload_dialout']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method dialout_pstn" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `dialout_pstn`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `dialout_pstn`")  # noqa: E501
        # verify the required parameter 'payload_dialout' is set
        if ('payload_dialout' not in params or
                params['payload_dialout'] is None):
            raise ValueError("Missing the required parameter `payload_dialout` when calling `dialout_pstn`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'payload_dialout' in params:
            body_params = params['payload_dialout']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/dialout/pstn', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='DialoutPstn',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def generate_pairing_code_pstn(self, user_id, numeric_meeting_id, payload_pairing_code_pstn, **kwargs):  # noqa: E501
        """Generate Pairing Code (PSTN)  # noqa: E501

        This endpoint generates a PSTN pairing code that can be used to connect to a meeting via telephone. **Note:** call this API using a meeting access token  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.generate_pairing_code_pstn(user_id, numeric_meeting_id, payload_pairing_code_pstn, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadPairingCodePstn payload_pairing_code_pstn: (required)
        :param str role:
        :return: PairingCodePSTN
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.generate_pairing_code_pstn_with_http_info(user_id, numeric_meeting_id, payload_pairing_code_pstn, **kwargs)  # noqa: E501
        else:
            (data) = self.generate_pairing_code_pstn_with_http_info(user_id, numeric_meeting_id, payload_pairing_code_pstn, **kwargs)  # noqa: E501
            return data

    def generate_pairing_code_pstn_with_http_info(self, user_id, numeric_meeting_id, payload_pairing_code_pstn, **kwargs):  # noqa: E501
        """Generate Pairing Code (PSTN)  # noqa: E501

        This endpoint generates a PSTN pairing code that can be used to connect to a meeting via telephone. **Note:** call this API using a meeting access token  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.generate_pairing_code_pstn_with_http_info(user_id, numeric_meeting_id, payload_pairing_code_pstn, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadPairingCodePstn payload_pairing_code_pstn: (required)
        :param str role:
        :return: PairingCodePSTN
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'payload_pairing_code_pstn', 'role']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method generate_pairing_code_pstn" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `generate_pairing_code_pstn`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `generate_pairing_code_pstn`")  # noqa: E501
        # verify the required parameter 'payload_pairing_code_pstn' is set
        if ('payload_pairing_code_pstn' not in params or
                params['payload_pairing_code_pstn'] is None):
            raise ValueError("Missing the required parameter `payload_pairing_code_pstn` when calling `generate_pairing_code_pstn`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501

        query_params = []
        if 'role' in params:
            query_params.append(('role', params['role']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'payload_pairing_code_pstn' in params:
            body_params = params['payload_pairing_code_pstn']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/pairing_code/PSTN', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='PairingCodePSTN',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def generate_pairing_code_sip(self, user_id, numeric_meeting_id, payload_pairing_code_sip, **kwargs):  # noqa: E501
        """Generate Pairing Code (SIP)  # noqa: E501

        This endpoint generates a SIP pairing code that can be used to connect to a meeting. **Note:** call this API using a meeting access token  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.generate_pairing_code_sip(user_id, numeric_meeting_id, payload_pairing_code_sip, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadPairingCodeSIP payload_pairing_code_sip: Information about the device that will be joining via SIP. (required)
        :return: PairingCodeSIP
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.generate_pairing_code_sip_with_http_info(user_id, numeric_meeting_id, payload_pairing_code_sip, **kwargs)  # noqa: E501
        else:
            (data) = self.generate_pairing_code_sip_with_http_info(user_id, numeric_meeting_id, payload_pairing_code_sip, **kwargs)  # noqa: E501
            return data

    def generate_pairing_code_sip_with_http_info(self, user_id, numeric_meeting_id, payload_pairing_code_sip, **kwargs):  # noqa: E501
        """Generate Pairing Code (SIP)  # noqa: E501

        This endpoint generates a SIP pairing code that can be used to connect to a meeting. **Note:** call this API using a meeting access token  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.generate_pairing_code_sip_with_http_info(user_id, numeric_meeting_id, payload_pairing_code_sip, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadPairingCodeSIP payload_pairing_code_sip: Information about the device that will be joining via SIP. (required)
        :return: PairingCodeSIP
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'payload_pairing_code_sip']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method generate_pairing_code_sip" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `generate_pairing_code_sip`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `generate_pairing_code_sip`")  # noqa: E501
        # verify the required parameter 'payload_pairing_code_sip' is set
        if ('payload_pairing_code_sip' not in params or
                params['payload_pairing_code_sip'] is None):
            raise ValueError("Missing the required parameter `payload_pairing_code_sip` when calling `generate_pairing_code_sip`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'payload_pairing_code_sip' in params:
            body_params = params['payload_pairing_code_sip']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/pairing_code/SIP', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='PairingCodeSIP',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def generate_pairing_code_web_rtc(self, user_id, numeric_meeting_id, payload_pairing_code_web_rtc, **kwargs):  # noqa: E501
        """Generate Pairing Code (WebRTC)  # noqa: E501

        This endpoint generates a WebRTC pairing code that can be used to connect to a meeting. **Note:** call this API using a meeting access token  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.generate_pairing_code_web_rtc(user_id, numeric_meeting_id, payload_pairing_code_web_rtc, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadPairingCodeWebRTC payload_pairing_code_web_rtc: (required)
        :param str role:
        :return: PairingCodeWebRTC
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.generate_pairing_code_web_rtc_with_http_info(user_id, numeric_meeting_id, payload_pairing_code_web_rtc, **kwargs)  # noqa: E501
        else:
            (data) = self.generate_pairing_code_web_rtc_with_http_info(user_id, numeric_meeting_id, payload_pairing_code_web_rtc, **kwargs)  # noqa: E501
            return data

    def generate_pairing_code_web_rtc_with_http_info(self, user_id, numeric_meeting_id, payload_pairing_code_web_rtc, **kwargs):  # noqa: E501
        """Generate Pairing Code (WebRTC)  # noqa: E501

        This endpoint generates a WebRTC pairing code that can be used to connect to a meeting. **Note:** call this API using a meeting access token  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.generate_pairing_code_web_rtc_with_http_info(user_id, numeric_meeting_id, payload_pairing_code_web_rtc, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadPairingCodeWebRTC payload_pairing_code_web_rtc: (required)
        :param str role:
        :return: PairingCodeWebRTC
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'payload_pairing_code_web_rtc', 'role']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method generate_pairing_code_web_rtc" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `generate_pairing_code_web_rtc`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `generate_pairing_code_web_rtc`")  # noqa: E501
        # verify the required parameter 'payload_pairing_code_web_rtc' is set
        if ('payload_pairing_code_web_rtc' not in params or
                params['payload_pairing_code_web_rtc'] is None):
            raise ValueError("Missing the required parameter `payload_pairing_code_web_rtc` when calling `generate_pairing_code_web_rtc`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501

        query_params = []
        if 'role' in params:
            query_params.append(('role', params['role']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'payload_pairing_code_web_rtc' in params:
            body_params = params['payload_pairing_code_web_rtc']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/pairing_code/webrtc', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='PairingCodeWebRTC',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def get_endpoint_layout(self, user_id, numeric_meeting_id, endpoint_guid, **kwargs):  # noqa: E501
        """Get Endpoint Layout  # noqa: E501

        This endpoint allows you to retrieve an individual endpoint’s current layout setting.  Can use either of a general or meeting access token.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_endpoint_layout(user_id, numeric_meeting_id, endpoint_guid, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param str endpoint_guid: The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. (required)
        :return: Layout
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.get_endpoint_layout_with_http_info(user_id, numeric_meeting_id, endpoint_guid, **kwargs)  # noqa: E501
        else:
            (data) = self.get_endpoint_layout_with_http_info(user_id, numeric_meeting_id, endpoint_guid, **kwargs)  # noqa: E501
            return data

    def get_endpoint_layout_with_http_info(self, user_id, numeric_meeting_id, endpoint_guid, **kwargs):  # noqa: E501
        """Get Endpoint Layout  # noqa: E501

        This endpoint allows you to retrieve an individual endpoint’s current layout setting.  Can use either of a general or meeting access token.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_endpoint_layout_with_http_info(user_id, numeric_meeting_id, endpoint_guid, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param str endpoint_guid: The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. (required)
        :return: Layout
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'endpoint_guid']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_endpoint_layout" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `get_endpoint_layout`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `get_endpoint_layout`")  # noqa: E501
        # verify the required parameter 'endpoint_guid' is set
        if ('endpoint_guid' not in params or
                params['endpoint_guid'] is None):
            raise ValueError("Missing the required parameter `endpoint_guid` when calling `get_endpoint_layout`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501
        if 'endpoint_guid' in params:
            path_params['endpoint_guid'] = params['endpoint_guid']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid}/layout', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Layout',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def get_meeting(self, user_id, meeting_id, **kwargs):  # noqa: E501
        """Get Meeting  # noqa: E501

        This endpoint gets the settings for a user's meeting.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting(user_id, meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int meeting_id: The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. This is not the numeric meeting ID visible to users. (required)
        :return: Meeting
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.get_meeting_with_http_info(user_id, meeting_id, **kwargs)  # noqa: E501
        else:
            (data) = self.get_meeting_with_http_info(user_id, meeting_id, **kwargs)  # noqa: E501
            return data

    def get_meeting_with_http_info(self, user_id, meeting_id, **kwargs):  # noqa: E501
        """Get Meeting  # noqa: E501

        This endpoint gets the settings for a user's meeting.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_with_http_info(user_id, meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int meeting_id: The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. This is not the numeric meeting ID visible to users. (required)
        :return: Meeting
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'meeting_id']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_meeting" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `get_meeting`")  # noqa: E501
        # verify the required parameter 'meeting_id' is set
        if ('meeting_id' not in params or
                params['meeting_id'] is None):
            raise ValueError("Missing the required parameter `meeting_id` when calling `get_meeting`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'meeting_id' in params:
            path_params['meeting_id'] = params['meeting_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/scheduled_meeting/{meeting_id}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Meeting',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def get_meeting_emails(self, user_id, meeting_id, **kwargs):  # noqa: E501
        """Get Meeting Email  # noqa: E501

        This endpoint retrieves the email object for a scheduled meeting.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_emails(user_id, meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int meeting_id: The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. (required)
        :param str type: TEXT, ICS, HTML
        :param str role: moderator, participant
        :param str action: create, edit, delete
        :return: MeetingEmails
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.get_meeting_emails_with_http_info(user_id, meeting_id, **kwargs)  # noqa: E501
        else:
            (data) = self.get_meeting_emails_with_http_info(user_id, meeting_id, **kwargs)  # noqa: E501
            return data

    def get_meeting_emails_with_http_info(self, user_id, meeting_id, **kwargs):  # noqa: E501
        """Get Meeting Email  # noqa: E501

        This endpoint retrieves the email object for a scheduled meeting.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_emails_with_http_info(user_id, meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int meeting_id: The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. (required)
        :param str type: TEXT, ICS, HTML
        :param str role: moderator, participant
        :param str action: create, edit, delete
        :return: MeetingEmails
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'meeting_id', 'type', 'role', 'action']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_meeting_emails" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `get_meeting_emails`")  # noqa: E501
        # verify the required parameter 'meeting_id' is set
        if ('meeting_id' not in params or
                params['meeting_id'] is None):
            raise ValueError("Missing the required parameter `meeting_id` when calling `get_meeting_emails`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'meeting_id' in params:
            path_params['meeting_id'] = params['meeting_id']  # noqa: E501

        query_params = []
        if 'type' in params:
            query_params.append(('type', params['type']))  # noqa: E501
        if 'role' in params:
            query_params.append(('role', params['role']))  # noqa: E501
        if 'action' in params:
            query_params.append(('action', params['action']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/scheduled_meeting/{meeting_id}/emails', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='MeetingEmails',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def get_meeting_endpoint(self, user_id, numeric_meeting_id, endpoint_guid, **kwargs):  # noqa: E501
        """Get Endpoint Information  # noqa: E501

        This endpoint allows you to retrieve information about an endpoint in the meeting.  Can use either of a general or meeting access token.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_endpoint(user_id, numeric_meeting_id, endpoint_guid, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param str endpoint_guid: The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. (required)
        :return: Endpoint
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.get_meeting_endpoint_with_http_info(user_id, numeric_meeting_id, endpoint_guid, **kwargs)  # noqa: E501
        else:
            (data) = self.get_meeting_endpoint_with_http_info(user_id, numeric_meeting_id, endpoint_guid, **kwargs)  # noqa: E501
            return data

    def get_meeting_endpoint_with_http_info(self, user_id, numeric_meeting_id, endpoint_guid, **kwargs):  # noqa: E501
        """Get Endpoint Information  # noqa: E501

        This endpoint allows you to retrieve information about an endpoint in the meeting.  Can use either of a general or meeting access token.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_endpoint_with_http_info(user_id, numeric_meeting_id, endpoint_guid, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param str endpoint_guid: The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. (required)
        :return: Endpoint
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'endpoint_guid']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_meeting_endpoint" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `get_meeting_endpoint`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `get_meeting_endpoint`")  # noqa: E501
        # verify the required parameter 'endpoint_guid' is set
        if ('endpoint_guid' not in params or
                params['endpoint_guid'] is None):
            raise ValueError("Missing the required parameter `endpoint_guid` when calling `get_meeting_endpoint`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501
        if 'endpoint_guid' in params:
            path_params['endpoint_guid'] = params['endpoint_guid']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Endpoint',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def get_meeting_endpoints(self, user_id, numeric_meeting_id, **kwargs):  # noqa: E501
        """List Meeting Endpoints  # noqa: E501

        This endpoint returns an array of all endpoints in the current meeting.  Can use either of a general or meeting access token.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_endpoints(user_id, numeric_meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :return: Endpoints
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.get_meeting_endpoints_with_http_info(user_id, numeric_meeting_id, **kwargs)  # noqa: E501
        else:
            (data) = self.get_meeting_endpoints_with_http_info(user_id, numeric_meeting_id, **kwargs)  # noqa: E501
            return data

    def get_meeting_endpoints_with_http_info(self, user_id, numeric_meeting_id, **kwargs):  # noqa: E501
        """List Meeting Endpoints  # noqa: E501

        This endpoint returns an array of all endpoints in the current meeting.  Can use either of a general or meeting access token.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_endpoints_with_http_info(user_id, numeric_meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :return: Endpoints
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_meeting_endpoints" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `get_meeting_endpoints`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `get_meeting_endpoints`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Endpoints',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def get_meeting_numbers(self, user_id, meeting_id, **kwargs):  # noqa: E501
        """Get Meeting Join Info  # noqa: E501

        This endpoint retrieves the join information for a scheduled meeting.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_numbers(user_id, meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int meeting_id: The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. (required)
        :return: Numbers
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.get_meeting_numbers_with_http_info(user_id, meeting_id, **kwargs)  # noqa: E501
        else:
            (data) = self.get_meeting_numbers_with_http_info(user_id, meeting_id, **kwargs)  # noqa: E501
            return data

    def get_meeting_numbers_with_http_info(self, user_id, meeting_id, **kwargs):  # noqa: E501
        """Get Meeting Join Info  # noqa: E501

        This endpoint retrieves the join information for a scheduled meeting.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_numbers_with_http_info(user_id, meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int meeting_id: The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. (required)
        :return: Numbers
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'meeting_id']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_meeting_numbers" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `get_meeting_numbers`")  # noqa: E501
        # verify the required parameter 'meeting_id' is set
        if ('meeting_id' not in params or
                params['meeting_id'] is None):
            raise ValueError("Missing the required parameter `meeting_id` when calling `get_meeting_numbers`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'meeting_id' in params:
            path_params['meeting_id'] = params['meeting_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/meetings/{meeting_id}/numbers', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Numbers',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def get_meeting_state(self, user_id, numeric_meeting_id, **kwargs):  # noqa: E501
        """Get Meeting State  # noqa: E501

        This endpoint’s purpose is to return whether the meeting is in progress or not.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_state(user_id, numeric_meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :return: MeetingState
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.get_meeting_state_with_http_info(user_id, numeric_meeting_id, **kwargs)  # noqa: E501
        else:
            (data) = self.get_meeting_state_with_http_info(user_id, numeric_meeting_id, **kwargs)  # noqa: E501
            return data

    def get_meeting_state_with_http_info(self, user_id, numeric_meeting_id, **kwargs):  # noqa: E501
        """Get Meeting State  # noqa: E501

        This endpoint’s purpose is to return whether the meeting is in progress or not.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.get_meeting_state_with_http_info(user_id, numeric_meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :return: MeetingState
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_meeting_state" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `get_meeting_state`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `get_meeting_state`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='MeetingState',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def list_meetings(self, user_id, **kwargs):  # noqa: E501
        """List Meetings  # noqa: E501

        This endpoint gets a list of the user's scheduled upcoming meetings.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.list_meetings(user_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param str numeric_meeting_id: Filter the results by the meeting ID that participants will see and use to join the conference.
        :return: list[Meeting]
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.list_meetings_with_http_info(user_id, **kwargs)  # noqa: E501
        else:
            (data) = self.list_meetings_with_http_info(user_id, **kwargs)  # noqa: E501
            return data

    def list_meetings_with_http_info(self, user_id, **kwargs):  # noqa: E501
        """List Meetings  # noqa: E501

        This endpoint gets a list of the user's scheduled upcoming meetings.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.list_meetings_with_http_info(user_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param str numeric_meeting_id: Filter the results by the meeting ID that participants will see and use to join the conference.
        :return: list[Meeting]
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method list_meetings" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `list_meetings`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501

        query_params = []
        if 'numeric_meeting_id' in params:
            query_params.append(('numericMeetingId', params['numeric_meeting_id']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/scheduled_meeting', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='list[Meeting]',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def send_meeting_invite(self, user_id, numeric_meeting_id, payload_invite, **kwargs):  # noqa: E501
        """Send Email Invite  # noqa: E501

        This endpoint generates an email invite to the specified meeting. **Note:** call this API using a meeting access token  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.send_meeting_invite(user_id, numeric_meeting_id, payload_invite, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadInvite payload_invite: (required)
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.send_meeting_invite_with_http_info(user_id, numeric_meeting_id, payload_invite, **kwargs)  # noqa: E501
        else:
            (data) = self.send_meeting_invite_with_http_info(user_id, numeric_meeting_id, payload_invite, **kwargs)  # noqa: E501
            return data

    def send_meeting_invite_with_http_info(self, user_id, numeric_meeting_id, payload_invite, **kwargs):  # noqa: E501
        """Send Email Invite  # noqa: E501

        This endpoint generates an email invite to the specified meeting. **Note:** call this API using a meeting access token  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.send_meeting_invite_with_http_info(user_id, numeric_meeting_id, payload_invite, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadInvite payload_invite: (required)
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'payload_invite']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method send_meeting_invite" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `send_meeting_invite`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `send_meeting_invite`")  # noqa: E501
        # verify the required parameter 'payload_invite' is set
        if ('payload_invite' not in params or
                params['payload_invite'] is None):
            raise ValueError("Missing the required parameter `payload_invite` when calling `send_meeting_invite`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'payload_invite' in params:
            body_params = params['payload_invite']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/invite', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def update_endpoint_layout(self, user_id, numeric_meeting_id, endpoint_guid, **kwargs):  # noqa: E501
        """Update Endpoint Layout  # noqa: E501

        This endpoint allows you to update an individual endpoint’s current layout setting. Requires Meeting access token with moderator privileges  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.update_endpoint_layout(user_id, numeric_meeting_id, endpoint_guid, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param str endpoint_guid: The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. (required)
        :param bool is_leader:
        :param bool push:
        :return: Layout
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.update_endpoint_layout_with_http_info(user_id, numeric_meeting_id, endpoint_guid, **kwargs)  # noqa: E501
        else:
            (data) = self.update_endpoint_layout_with_http_info(user_id, numeric_meeting_id, endpoint_guid, **kwargs)  # noqa: E501
            return data

    def update_endpoint_layout_with_http_info(self, user_id, numeric_meeting_id, endpoint_guid, **kwargs):  # noqa: E501
        """Update Endpoint Layout  # noqa: E501

        This endpoint allows you to update an individual endpoint’s current layout setting. Requires Meeting access token with moderator privileges  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.update_endpoint_layout_with_http_info(user_id, numeric_meeting_id, endpoint_guid, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param str endpoint_guid: The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. (required)
        :param bool is_leader:
        :param bool push:
        :return: Layout
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'endpoint_guid', 'is_leader', 'push']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method update_endpoint_layout" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `update_endpoint_layout`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `update_endpoint_layout`")  # noqa: E501
        # verify the required parameter 'endpoint_guid' is set
        if ('endpoint_guid' not in params or
                params['endpoint_guid'] is None):
            raise ValueError("Missing the required parameter `endpoint_guid` when calling `update_endpoint_layout`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501
        if 'endpoint_guid' in params:
            path_params['endpoint_guid'] = params['endpoint_guid']  # noqa: E501

        query_params = []
        if 'is_leader' in params:
            query_params.append(('isLeader', params['is_leader']))  # noqa: E501
        if 'push' in params:
            query_params.append(('push', params['push']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid}/layout', 'PUT',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Layout',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def update_meeting(self, user_id, meeting_id, meeting, **kwargs):  # noqa: E501
        """Update Meeting  # noqa: E501

        This endpoint changes the settings for a user's meeting. For example, use for rescheduling.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.update_meeting(user_id, meeting_id, meeting, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest.  This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int meeting_id: The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. (required)
        :param Meeting meeting: The user's room details that you wish to update. (required)
        :return: Meeting
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.update_meeting_with_http_info(user_id, meeting_id, meeting, **kwargs)  # noqa: E501
        else:
            (data) = self.update_meeting_with_http_info(user_id, meeting_id, meeting, **kwargs)  # noqa: E501
            return data

    def update_meeting_with_http_info(self, user_id, meeting_id, meeting, **kwargs):  # noqa: E501
        """Update Meeting  # noqa: E501

        This endpoint changes the settings for a user's meeting. For example, use for rescheduling.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.update_meeting_with_http_info(user_id, meeting_id, meeting, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest.  This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int meeting_id: The ID of the meeting you want to view. This is an integer value. You can find this ID by doing a list of meetings and referencing the \"id\" property. (required)
        :param Meeting meeting: The user's room details that you wish to update. (required)
        :return: Meeting
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'meeting_id', 'meeting']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method update_meeting" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `update_meeting`")  # noqa: E501
        # verify the required parameter 'meeting_id' is set
        if ('meeting_id' not in params or
                params['meeting_id'] is None):
            raise ValueError("Missing the required parameter `meeting_id` when calling `update_meeting`")  # noqa: E501
        # verify the required parameter 'meeting' is set
        if ('meeting' not in params or
                params['meeting'] is None):
            raise ValueError("Missing the required parameter `meeting` when calling `update_meeting`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'meeting_id' in params:
            path_params['meeting_id'] = params['meeting_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'meeting' in params:
            body_params = params['meeting']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/scheduled_meeting/{meeting_id}', 'PUT',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Meeting',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def update_meeting_endpoint(self, user_id, numeric_meeting_id, endpoint_guid, **kwargs):  # noqa: E501
        """Update Endpoint Video/Audio State  # noqa: E501

        This endpoint allows you to update an individual endpoint’s ability to send audio or video, and also allows removing an endpoint from the meeting. Requires Meeting access token with moderator privileges  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.update_meeting_endpoint(user_id, numeric_meeting_id, endpoint_guid, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param str endpoint_guid: The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. (required)
        :param bool mute_audio: Toggle the audio source mute.
        :param bool mute_video: Toggle the video source mute.
        :param bool leave_meeting: Remove the user from the meeting.
        :return: Endpoint
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.update_meeting_endpoint_with_http_info(user_id, numeric_meeting_id, endpoint_guid, **kwargs)  # noqa: E501
        else:
            (data) = self.update_meeting_endpoint_with_http_info(user_id, numeric_meeting_id, endpoint_guid, **kwargs)  # noqa: E501
            return data

    def update_meeting_endpoint_with_http_info(self, user_id, numeric_meeting_id, endpoint_guid, **kwargs):  # noqa: E501
        """Update Endpoint Video/Audio State  # noqa: E501

        This endpoint allows you to update an individual endpoint’s ability to send audio or video, and also allows removing an endpoint from the meeting. Requires Meeting access token with moderator privileges  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.update_meeting_endpoint_with_http_info(user_id, numeric_meeting_id, endpoint_guid, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param str endpoint_guid: The GUID of an endpoint.  Usually retrieved from the List Meeting Endpoints endpoint. (required)
        :param bool mute_audio: Toggle the audio source mute.
        :param bool mute_video: Toggle the video source mute.
        :param bool leave_meeting: Remove the user from the meeting.
        :return: Endpoint
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'endpoint_guid', 'mute_audio', 'mute_video', 'leave_meeting']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method update_meeting_endpoint" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `update_meeting_endpoint`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `update_meeting_endpoint`")  # noqa: E501
        # verify the required parameter 'endpoint_guid' is set
        if ('endpoint_guid' not in params or
                params['endpoint_guid'] is None):
            raise ValueError("Missing the required parameter `endpoint_guid` when calling `update_meeting_endpoint`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501
        if 'endpoint_guid' in params:
            path_params['endpoint_guid'] = params['endpoint_guid']  # noqa: E501

        query_params = []
        if 'mute_audio' in params:
            query_params.append(('muteAudio', params['mute_audio']))  # noqa: E501
        if 'mute_video' in params:
            query_params.append(('muteVideo', params['mute_video']))  # noqa: E501
        if 'leave_meeting' in params:
            query_params.append(('leaveMeeting', params['leave_meeting']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints/{endpoint_guid}', 'PUT',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Endpoint',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def update_meeting_endpoints(self, user_id, numeric_meeting_id, **kwargs):  # noqa: E501
        """Update Meeting Endpoints State  # noqa: E501

        This endpoint’s purpose is to be able to modify the endpoints in a meeting. Requires Meeting access token with moderator privileges  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.update_meeting_endpoints(user_id, numeric_meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param bool mute: Allows you to mute/unmute all participants in a meeting. Set mute to true to mute.  Set mute to false to unmute.
        :param str media: Specify the type of media you which to mute/unmute.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.update_meeting_endpoints_with_http_info(user_id, numeric_meeting_id, **kwargs)  # noqa: E501
        else:
            (data) = self.update_meeting_endpoints_with_http_info(user_id, numeric_meeting_id, **kwargs)  # noqa: E501
            return data

    def update_meeting_endpoints_with_http_info(self, user_id, numeric_meeting_id, **kwargs):  # noqa: E501
        """Update Meeting Endpoints State  # noqa: E501

        This endpoint’s purpose is to be able to modify the endpoints in a meeting. Requires Meeting access token with moderator privileges  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.update_meeting_endpoints_with_http_info(user_id, numeric_meeting_id, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param bool mute: Allows you to mute/unmute all participants in a meeting. Set mute to true to mute.  Set mute to false to unmute.
        :param str media: Specify the type of media you which to mute/unmute.
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'mute', 'media']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method update_meeting_endpoints" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `update_meeting_endpoints`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `update_meeting_endpoints`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501

        query_params = []
        if 'mute' in params:
            query_params.append(('mute', params['mute']))  # noqa: E501
        if 'media' in params:
            query_params.append(('media', params['media']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}/endpoints', 'PUT',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def update_meeting_state(self, user_id, numeric_meeting_id, payload_meeting_state, **kwargs):  # noqa: E501
        """Update Meeting State  # noqa: E501

        This endpoint’s purpose is to be able to modify a meeting. Actions include locking the meeting, or terminating the meeting.  This API requires a meeting access token with moderator privileges.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.update_meeting_state(user_id, numeric_meeting_id, payload_meeting_state, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadMeetingState payload_meeting_state: The meeting properties that you wish to update. (required)
        :param int delay: Number of seconds to delay the end meeting operation.
        :return: Meeting
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async'):
            return self.update_meeting_state_with_http_info(user_id, numeric_meeting_id, payload_meeting_state, **kwargs)  # noqa: E501
        else:
            (data) = self.update_meeting_state_with_http_info(user_id, numeric_meeting_id, payload_meeting_state, **kwargs)  # noqa: E501
            return data

    def update_meeting_state_with_http_info(self, user_id, numeric_meeting_id, payload_meeting_state, **kwargs):  # noqa: E501
        """Update Meeting State  # noqa: E501

        This endpoint’s purpose is to be able to modify a meeting. Actions include locking the meeting, or terminating the meeting.  This API requires a meeting access token with moderator privileges.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async=True
        >>> thread = api.update_meeting_state_with_http_info(user_id, numeric_meeting_id, payload_meeting_state, async=True)
        >>> result = thread.get()

        :param async bool
        :param int user_id: The ID of the user of interest. This value is an integer which can be retrieved for the current user via the Get User Account Details endpoint. (required)
        :param int numeric_meeting_id: The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. (required)
        :param PayloadMeetingState payload_meeting_state: The meeting properties that you wish to update. (required)
        :param int delay: Number of seconds to delay the end meeting operation.
        :return: Meeting
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['user_id', 'numeric_meeting_id', 'payload_meeting_state', 'delay']  # noqa: E501
        all_params.append('async')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method update_meeting_state" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'user_id' is set
        if ('user_id' not in params or
                params['user_id'] is None):
            raise ValueError("Missing the required parameter `user_id` when calling `update_meeting_state`")  # noqa: E501
        # verify the required parameter 'numeric_meeting_id' is set
        if ('numeric_meeting_id' not in params or
                params['numeric_meeting_id'] is None):
            raise ValueError("Missing the required parameter `numeric_meeting_id` when calling `update_meeting_state`")  # noqa: E501
        # verify the required parameter 'payload_meeting_state' is set
        if ('payload_meeting_state' not in params or
                params['payload_meeting_state'] is None):
            raise ValueError("Missing the required parameter `payload_meeting_state` when calling `update_meeting_state`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'user_id' in params:
            path_params['user_id'] = params['user_id']  # noqa: E501
        if 'numeric_meeting_id' in params:
            path_params['numeric_meeting_id'] = params['numeric_meeting_id']  # noqa: E501

        query_params = []
        if 'delay' in params:
            query_params.append(('delay', params['delay']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'payload_meeting_state' in params:
            body_params = params['payload_meeting_state']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['access_token']  # noqa: E501

        return self.api_client.call_api(
            '/v1/user/{user_id}/live_meetings/{numeric_meeting_id}', 'PUT',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Meeting',  # noqa: E501
            auth_settings=auth_settings,
            async=params.get('async'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)
