
# Meeting

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **Integer** | Unique identifier for meeting. |  [optional]
**title** | **String** |  | 
**description** | **String** |  |  [optional]
**start** | **Long** | A [UNIX Timestamp](https://currentmillis.com/) in milliseconds | 
**end** | **Long** | A [UNIX Timestamp](https://currentmillis.com/) in milliseconds | 
**timezone** | **String** |  |  [optional]
**numericMeetingId** | **String** | The meeting ID that participants will see and use to join the conference. When joining via phone, this is the code they enter via DTMF to join. |  [optional]
**attendeePasscode** | **String** |  |  [optional]
**addAttendeePasscode** | **Boolean** | Indicate if you want the attendees to be forced to enter a passcode on entry for extra security. The passcode will be randomly generated at schedule and will be returned in attendeePasscode property of the meeting. |  [optional]
**endPointVersion** | **String** |  | 
**endPointType** | **String** |  | 
**attendees** | [**List&lt;Attendee&gt;**](Attendee.md) |  |  [optional]
**advancedMeetingOptions** | [**MeetingAdvancedMeetingOptions**](MeetingAdvancedMeetingOptions.md) |  |  [optional]



