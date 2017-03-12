# api-rest-onvideo

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>com.bluejeans</groupId>
    <artifactId>api-rest-onvideo</artifactId>
    <version>1.0.0</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "com.bluejeans:api-rest-onvideo:1.0.0"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/api-rest-onvideo-1.0.0.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import com.bluejeans.api.rest.onvideo.*;
import com.bluejeans.api.rest.onvideo.auth.*;
import com.bluejeans.api.rest.onvideo.model.*;
import com.bluejeans.api.rest.onvideo.api.AnalyticsApi;

import java.io.File;
import java.util.*;

public class AnalyticsApiExample {

    public static void main(String[] args) {
        ApiClient defaultClient = Configuration.getDefaultApiClient();
        
        // Configure API key authorization: access_token
        ApiKeyAuth access_token = (ApiKeyAuth) defaultClient.getAuthentication("access_token");
        access_token.setApiKey("YOUR API KEY");
        // Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
        //access_token.setApiKeyPrefix("Token");

        AnalyticsApi apiInstance = new AnalyticsApi();
        Integer enterpriseId = 56; // Integer | The ID of the enterprise of interest. This value is an integer which can be retrieved for the current user via the Get Enterprise Profile endpoint.
        String filter = "[{\"type\":\"date\",\"comparison\":\"gt\",\"value\":\"2017-01-16T00:00:00-07:00\",\"field\":\"creation_time\"},{\"type\":\"date\",\"comparison\":\"lt\",\"value\":\"2017-01-23T23:59:59-07:00\",\"field\":\"creation_time\"}]"; // String | URL-encoded JSON string
        try {
            AnalyticsEndpointDistribution result = apiInstance.getEndpointDistribution(enterpriseId, filter);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling AnalyticsApi#getEndpointDistribution");
            e.printStackTrace();
        }
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *https://api.bluejeans.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AnalyticsApi* | [**getEndpointDistribution**](docs/AnalyticsApi.md#getEndpointDistribution) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/endpoints/distribution | Endpoint Distribution
*AnalyticsApi* | [**getFeedbackComments**](docs/AnalyticsApi.md#getFeedbackComments) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/feedback/comments | Survey Feedback Comments
*AnalyticsApi* | [**getFeedbackCount**](docs/AnalyticsApi.md#getFeedbackCount) | **GET** /v1/enterprise/{enterprise_id}/indigo/feedback/count | Survey Feedback Scores
*AnalyticsApi* | [**getMeetingUsage**](docs/AnalyticsApi.md#getMeetingUsage) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/meetings/usage | Meeting Usage Over Time
*AnalyticsApi* | [**getRoiRanges**](docs/AnalyticsApi.md#getRoiRanges) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/roi_ranges | ROI Data
*AnalyticsApi* | [**getTopUsers**](docs/AnalyticsApi.md#getTopUsers) | **GET** /v1/enterprise/{enterprise_id}/indigo/analytics/users/usage | Top Users
*AuthenticationApi* | [**getTokenByClient**](docs/AuthenticationApi.md#getTokenByClient) | **POST** /oauth2/token?Client | Authentication via Client Grant Type
*AuthenticationApi* | [**getTokenByMeeting**](docs/AuthenticationApi.md#getTokenByMeeting) | **POST** /oauth2/token?Meeting | Authentication via Meeting Grant Type
*AuthenticationApi* | [**getTokenByPassword**](docs/AuthenticationApi.md#getTokenByPassword) | **POST** /oauth2/token?Password | Authentication via Password Grant Type
*CommandCenterApi* | [**v1EnterpriseEnterpriseIdIndigoMeetingsGet**](docs/CommandCenterApi.md#v1EnterpriseEnterpriseIdIndigoMeetingsGet) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings | List Past Meetings by Enterprise
*CommandCenterApi* | [**v1EnterpriseEnterpriseIdIndigoMeetingsLiveGet**](docs/CommandCenterApi.md#v1EnterpriseEnterpriseIdIndigoMeetingsLiveGet) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings/live | Live Meetings Summary by Enterprise
*CommandCenterApi* | [**v1EnterpriseEnterpriseIdIndigoMeetingsLiveMeetingGuidEndpointsGet**](docs/CommandCenterApi.md#v1EnterpriseEnterpriseIdIndigoMeetingsLiveMeetingGuidEndpointsGet) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings/live/{meeting_guid}/endpoints/ | List Live Meeting Endpoints by Enterprise
*CommandCenterApi* | [**v1EnterpriseEnterpriseIdIndigoMeetingsMeetingGuidGet**](docs/CommandCenterApi.md#v1EnterpriseEnterpriseIdIndigoMeetingsMeetingGuidGet) | **GET** /v1/enterprise/{enterprise_id}/indigo/meetings/{meeting_guid} | List Meeting Endpoints &amp; Stats by Enterprise
*CommandCenterApi* | [**v1UserUserIdIndigoMeetingsGet**](docs/CommandCenterApi.md#v1UserUserIdIndigoMeetingsGet) | **GET** /v1/user/{user_id}/indigo/meetings | List Past Meetings by User
*CommandCenterApi* | [**v1UserUserIdIndigoMeetingsMeetingGuidGet**](docs/CommandCenterApi.md#v1UserUserIdIndigoMeetingsMeetingGuidGet) | **GET** /v1/user/{user_id}/indigo/meetings/{meeting_guid} | List Meeting Endpoints &amp; Stats by User
*EnterpriseApi* | [**createUser**](docs/EnterpriseApi.md#createUser) | **POST** /v1/enterprise/{enterprise_id}/users | Create Enterprise User
*EnterpriseApi* | [**listUsers**](docs/EnterpriseApi.md#listUsers) | **GET** /v1/enterprise/{enterprise_id}/users | List Enterprise Users
*EnterpriseApi* | [**removeUser**](docs/EnterpriseApi.md#removeUser) | **DELETE** /v1/enterprise/{enterprise_id}/users/{user_id} | Remove Enterprise User
*HistoryApi* | [**getHistoryByEnterprise**](docs/HistoryApi.md#getHistoryByEnterprise) | **GET** /v1/enterprise/{enterprise_id}/meeting_history/{meeting_guid} | Get Meeting History by Enterprise
*HistoryApi* | [**getHistoryByUser**](docs/HistoryApi.md#getHistoryByUser) | **GET** /v1/user/{user_id}/meeting_history/{meeting_guid} | Get Meeting History by User
*HistoryApi* | [**getRecording**](docs/HistoryApi.md#getRecording) | **GET** /v1/user/{user_id}/meeting_history/recordings/{recording_entity_id} | Get Recording
*HistoryApi* | [**listHistoryByEnterprise**](docs/HistoryApi.md#listHistoryByEnterprise) | **GET** /v1/enterprise/{enterprise_id}/meeting_history | List History by Enterprise
*HistoryApi* | [**listHistoryByUser**](docs/HistoryApi.md#listHistoryByUser) | **GET** /v1/user/{user_id}/meeting_history | List History by User
*HistoryApi* | [**listRecordings**](docs/HistoryApi.md#listRecordings) | **GET** /v1/user/{user_id}/meeting_history/recordings | List Meeting Recordings
*MeetingApi* | [**cancelMeeting**](docs/MeetingApi.md#cancelMeeting) | **DELETE** /v1/user/{user_id}/scheduled_meeting/{meeting_id} | Cancel Meeting
*MeetingApi* | [**createMeeting**](docs/MeetingApi.md#createMeeting) | **POST** /v1/user/{user_id}/scheduled_meeting | Create Meeting
*MeetingApi* | [**generatePairingCodeSip**](docs/MeetingApi.md#generatePairingCodeSip) | **POST** /v1/user/{user_id}/live_meetings/{meeting_id}/pairing_code/sip | Generate Pairing Code (SIP)
*MeetingApi* | [**generatePairingCodeWebRtc**](docs/MeetingApi.md#generatePairingCodeWebRtc) | **POST** /v1/user/{user_id}/live_meetings/{meeting_id}/pairing_code/webrtc | Generate Pairing Code (WebRTC)
*MeetingApi* | [**getEndpointLayout**](docs/MeetingApi.md#getEndpointLayout) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints/{endpoint_guid}/layout | Get Endpoint Layout
*MeetingApi* | [**getMeeting**](docs/MeetingApi.md#getMeeting) | **GET** /v1/user/{user_id}/scheduled_meeting/{meeting_id} | Get Meeting
*MeetingApi* | [**getMeetingEmails**](docs/MeetingApi.md#getMeetingEmails) | **GET** /v1/user/{user_id}/scheduled_meeting/{meeting_id}/emails | Get Meeting Email
*MeetingApi* | [**getMeetingEndpoint**](docs/MeetingApi.md#getMeetingEndpoint) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints/{endpoint_guid} | Get Endpoint Information
*MeetingApi* | [**getMeetingEndpoints**](docs/MeetingApi.md#getMeetingEndpoints) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints | List Meeting Endpoints
*MeetingApi* | [**getMeetingNumbers**](docs/MeetingApi.md#getMeetingNumbers) | **GET** /v1/user/{user_id}/meetings/{meeting_id}/numbers | Get Meeting Join Info
*MeetingApi* | [**getMeetingState**](docs/MeetingApi.md#getMeetingState) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id} | Get Meeting State
*MeetingApi* | [**listMeetings**](docs/MeetingApi.md#listMeetings) | **GET** /v1/user/{user_id}/scheduled_meeting | List Meetings
*MeetingApi* | [**sendMeetingInvite**](docs/MeetingApi.md#sendMeetingInvite) | **POST** /v1/user/{user_id}/live_meetings/{meeting_id}/invite | Send Email Invite
*MeetingApi* | [**updateEndpointLayout**](docs/MeetingApi.md#updateEndpointLayout) | **PUT** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints/{endpoint_guid}/layout | Update Endpoint Layout
*MeetingApi* | [**updateMeeting**](docs/MeetingApi.md#updateMeeting) | **PUT** /v1/user/{user_id}/scheduled_meeting/{meeting_id} | Update Meeting
*MeetingApi* | [**updateMeetingEndpoint**](docs/MeetingApi.md#updateMeetingEndpoint) | **PUT** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints/{endpoint_guid} | Update Endpoint Video/Audio State
*MeetingApi* | [**updateMeetingEndpoints**](docs/MeetingApi.md#updateMeetingEndpoints) | **PUT** /v1/user/{user_id}/live_meetings/{meeting_id}/endpoints | Update Meeting Endpoints State
*MeetingApi* | [**updateMeetingState**](docs/MeetingApi.md#updateMeetingState) | **PUT** /v1/user/{user_id}/live_meetings/{meeting_id} | Update Meeting State
*RecordingApi* | [**getMeetingRecordings**](docs/RecordingApi.md#getMeetingRecordings) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id}/recordings | Get All Recordings for a Specified Meeting ID
*RecordingApi* | [**getRecordingContent**](docs/RecordingApi.md#getRecordingContent) | **GET** /v1/user/{user_id}/cms/{content_id}?isDownloadable&#x3D;true | Get Recording Download Link
*RecordingApi* | [**startRecording**](docs/RecordingApi.md#startRecording) | **POST** /v1/user/{user_id}/live_meetings/{meeting_id}/recordings/?action&#x3D;start | Start Recording
*RecordingApi* | [**stopRecording**](docs/RecordingApi.md#stopRecording) | **PUT** /v1/user/{user_id}/live_meetings/{meeting_id}/recordings?action&#x3D;stop | Stop Recording
*RecordingApi* | [**v1UserUserIdLiveMeetingsMeetingIdRecordingsmeetingGuidmeetingGuidGet**](docs/RecordingApi.md#v1UserUserIdLiveMeetingsMeetingIdRecordingsmeetingGuidmeetingGuidGet) | **GET** /v1/user/{user_id}/live_meetings/{meeting_id}/recordings?meetingGuid&#x3D;{meeting_guid} | Get All Recordings for a Specified Meeting GUID
*RecordingApi* | [**v1UserUserIdMeetingHistoryMeetingGuidRecordingsDelete**](docs/RecordingApi.md#v1UserUserIdMeetingHistoryMeetingGuidRecordingsDelete) | **DELETE** /v1/user/{user_id}/meeting_history/{meeting_guid}/recordings | Delete All Recordings for a Specified Meeting GUID
*RecordingApi* | [**v1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete**](docs/RecordingApi.md#v1UserUserIdMeetingHistoryMeetingIdRecordingsRecordingChapterIdDelete) | **DELETE** /v1/user/{user_id}/meeting_history/{meeting_id}/recordings/{recording_chapter_id}/ | Delete a Specified Recording Chapter
*UserApi* | [**getEnterpriseProfile**](docs/UserApi.md#getEnterpriseProfile) | **GET** /v1/user/{user_id}/enterprise_profile | Get Enterprise Profile
*UserApi* | [**getRoom**](docs/UserApi.md#getRoom) | **GET** /v1/user/{user_id}/room | Get User’s Default Meeting Settings
*UserApi* | [**getUser**](docs/UserApi.md#getUser) | **GET** /v1/user/{user_id} | Get User Account Details
*UserApi* | [**updateRoom**](docs/UserApi.md#updateRoom) | **PUT** /v1/user/{user_id}/room | Update User’s Default Meeting Settings
*UserApi* | [**updateUser**](docs/UserApi.md#updateUser) | **PUT** /v1/user/{user_id} | Update User Account Details


## Documentation for Models

 - [AnalyticsEndpointDistribution](docs/AnalyticsEndpointDistribution.md)
 - [AnalyticsEndpointDistributionDistribution](docs/AnalyticsEndpointDistributionDistribution.md)
 - [AnalyticsFeedbackComments](docs/AnalyticsFeedbackComments.md)
 - [AnalyticsFeedbackCommentsComments](docs/AnalyticsFeedbackCommentsComments.md)
 - [AnalyticsFeedbackScores](docs/AnalyticsFeedbackScores.md)
 - [AnalyticsRoiData](docs/AnalyticsRoiData.md)
 - [AnalyticsRoiDataRoiRanges](docs/AnalyticsRoiDataRoiRanges.md)
 - [AnalyticsTopUsers](docs/AnalyticsTopUsers.md)
 - [AnalyticsTopUsersUsage](docs/AnalyticsTopUsersUsage.md)
 - [AnalyticsUsage](docs/AnalyticsUsage.md)
 - [AnalyticsUsageUsage](docs/AnalyticsUsageUsage.md)
 - [Attendee](docs/Attendee.md)
 - [Content](docs/Content.md)
 - [ContentContentProperties](docs/ContentContentProperties.md)
 - [ContentContentPropertiesLevels](docs/ContentContentPropertiesLevels.md)
 - [Endpoint](docs/Endpoint.md)
 - [Endpoints](docs/Endpoints.md)
 - [EndpointsInner](docs/EndpointsInner.md)
 - [EndpointsInnerConnections](docs/EndpointsInnerConnections.md)
 - [Enterprise](docs/Enterprise.md)
 - [EnterpriseUserList](docs/EnterpriseUserList.md)
 - [EnterpriseUserListUsers](docs/EnterpriseUserListUsers.md)
 - [Error](docs/Error.md)
 - [GrantClient](docs/GrantClient.md)
 - [GrantClientScope](docs/GrantClientScope.md)
 - [GrantMeeting](docs/GrantMeeting.md)
 - [GrantMeetingScope](docs/GrantMeetingScope.md)
 - [GrantMeetingScopeMeeting](docs/GrantMeetingScopeMeeting.md)
 - [GrantPassword](docs/GrantPassword.md)
 - [GrantPasswordScope](docs/GrantPasswordScope.md)
 - [GrantRequestClient](docs/GrantRequestClient.md)
 - [GrantRequestMeeting](docs/GrantRequestMeeting.md)
 - [GrantRequestPassword](docs/GrantRequestPassword.md)
 - [Layout](docs/Layout.md)
 - [Meeting](docs/Meeting.md)
 - [MeetingAdvancedMeetingOptions](docs/MeetingAdvancedMeetingOptions.md)
 - [MeetingHistory](docs/MeetingHistory.md)
 - [MeetingHistoryLeaderInfo](docs/MeetingHistoryLeaderInfo.md)
 - [MeetingHistoryParticipantList](docs/MeetingHistoryParticipantList.md)
 - [MeetingState](docs/MeetingState.md)
 - [MeetingStateRecordinginfo](docs/MeetingStateRecordinginfo.md)
 - [Numbers](docs/Numbers.md)
 - [NumbersLabel](docs/NumbersLabel.md)
 - [NumbersNumbers](docs/NumbersNumbers.md)
 - [PairingCode](docs/PairingCode.md)
 - [PairingCodeTurnservers](docs/PairingCodeTurnservers.md)
 - [Partition](docs/Partition.md)
 - [PayloadInvite](docs/PayloadInvite.md)
 - [PayloadMeetingState](docs/PayloadMeetingState.md)
 - [PayloadPairingCodeSIP](docs/PayloadPairingCodeSIP.md)
 - [PayloadPairingCodeWebRTC](docs/PayloadPairingCodeWebRTC.md)
 - [Recording](docs/Recording.md)
 - [RecordingRecordingChapters](docs/RecordingRecordingChapters.md)
 - [RecordingRecordingSessions](docs/RecordingRecordingSessions.md)
 - [RecordingStartedBy](docs/RecordingStartedBy.md)
 - [RecordingSummary](docs/RecordingSummary.md)
 - [Room](docs/Room.md)
 - [User](docs/User.md)
 - [UserId](docs/UserId.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### access_token

- **Type**: API key
- **API key parameter name**: access_token
- **Location**: URL query string


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issue.

## Author

brandon@bluejeans.com

