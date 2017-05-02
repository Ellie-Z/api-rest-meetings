# coding: utf-8

"""
    BlueJeans onVideo REST API

    _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 

    OpenAPI spec version: 1.0.0
    Contact: brandon@bluejeans.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

# import models into sdk package
from .models.analytics_endpoint_distribution import AnalyticsEndpointDistribution
from .models.analytics_endpoint_distribution_distribution import AnalyticsEndpointDistributionDistribution
from .models.analytics_feedback_comments import AnalyticsFeedbackComments
from .models.analytics_feedback_comments_comments import AnalyticsFeedbackCommentsComments
from .models.analytics_feedback_scores import AnalyticsFeedbackScores
from .models.analytics_roi_data import AnalyticsRoiData
from .models.analytics_roi_data_roi_ranges import AnalyticsRoiDataRoiRanges
from .models.analytics_top_users import AnalyticsTopUsers
from .models.analytics_top_users_usage import AnalyticsTopUsersUsage
from .models.analytics_usage import AnalyticsUsage
from .models.analytics_usage_usage import AnalyticsUsageUsage
from .models.attendee import Attendee
from .models.content import Content
from .models.content_content_properties import ContentContentProperties
from .models.content_content_properties_levels import ContentContentPropertiesLevels
from .models.endpoint import Endpoint
from .models.endpoint_indigo import EndpointIndigo
from .models.endpoint_indigo_endpoint_attributes1 import EndpointIndigoEndpointAttributes1
from .models.endpoint_indigo_location import EndpointIndigoLocation
from .models.endpoint_indigo_summary_stats import EndpointIndigoSummaryStats
from .models.endpoint_indigo_traceroute import EndpointIndigoTraceroute
from .models.endpoint_indigo_traceroute_trace_path import EndpointIndigoTracerouteTracePath
from .models.endpoints import Endpoints
from .models.endpoints_inner import EndpointsInner
from .models.endpoints_inner_connections import EndpointsInnerConnections
from .models.enterprise import Enterprise
from .models.enterprise_user_list import EnterpriseUserList
from .models.enterprise_user_list_users import EnterpriseUserListUsers
from .models.error import Error
from .models.grant_client import GrantClient
from .models.grant_client_scope import GrantClientScope
from .models.grant_meeting import GrantMeeting
from .models.grant_meeting_scope import GrantMeetingScope
from .models.grant_meeting_scope_meeting import GrantMeetingScopeMeeting
from .models.grant_password import GrantPassword
from .models.grant_password_scope import GrantPasswordScope
from .models.grant_request_client import GrantRequestClient
from .models.grant_request_meeting import GrantRequestMeeting
from .models.grant_request_password import GrantRequestPassword
from .models.inline_response_200 import InlineResponse200
from .models.layout import Layout
from .models.meeting import Meeting
from .models.meeting_advanced_meeting_options import MeetingAdvancedMeetingOptions
from .models.meeting_extended_indigo import MeetingExtendedIndigo
from .models.meeting_history import MeetingHistory
from .models.meeting_history_leader_info import MeetingHistoryLeaderInfo
from .models.meeting_history_participant_list import MeetingHistoryParticipantList
from .models.meeting_history_sharing import MeetingHistorySharing
from .models.meeting_indigo import MeetingIndigo
from .models.meeting_indigo_list import MeetingIndigoList
from .models.meeting_state import MeetingState
from .models.meeting_state_recordinginfo import MeetingStateRecordinginfo
from .models.numbers import Numbers
from .models.numbers_label import NumbersLabel
from .models.numbers_numbers import NumbersNumbers
from .models.pairing_code import PairingCode
from .models.pairing_code_turnservers import PairingCodeTurnservers
from .models.partition import Partition
from .models.payload_invite import PayloadInvite
from .models.payload_meeting_state import PayloadMeetingState
from .models.payload_pairing_code_sip import PayloadPairingCodeSIP
from .models.payload_pairing_code_web_rtc import PayloadPairingCodeWebRTC
from .models.recording import Recording
from .models.recording_recording_chapters import RecordingRecordingChapters
from .models.recording_recording_sessions import RecordingRecordingSessions
from .models.recording_started_by import RecordingStartedBy
from .models.recording_summary import RecordingSummary
from .models.room import Room
from .models.user import User
from .models.user_id import UserId

# import apis into sdk package
from .apis.analytics_api import AnalyticsApi
from .apis.authentication_api import AuthenticationApi
from .apis.command_center_api import CommandCenterApi
from .apis.enterprise_api import EnterpriseApi
from .apis.history_api import HistoryApi
from .apis.meeting_api import MeetingApi
from .apis.recording_api import RecordingApi
from .apis.user_api import UserApi

# import ApiClient
from .api_client import ApiClient

from .configuration import Configuration

configuration = Configuration()
