/**
 * BlueJeans onVideo REST API
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


package com.bluejeans.api.rest.onvideo.model;

import java.util.Objects;
import com.bluejeans.api.rest.onvideo.model.MeetingStateRecordinginfo;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;


/**
 * MeetingState
 */

public class MeetingState   {
  @SerializedName("meetingId")
  private String meetingId = null;

  @SerializedName("meetingGuid")
  private String meetingGuid = null;

  /**
   * Gets or Sets meetingState
   */
  public enum MeetingStateEnum {
    @SerializedName("MeetingStarted")
    MEETINGSTARTED("MeetingStarted");

    private String value;

    MeetingStateEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("meetingState")
  private MeetingStateEnum meetingState = null;

  /**
   * Gets or Sets status
   */
  public enum StatusEnum {
    @SerializedName("active")
    ACTIVE("active");

    private String value;

    StatusEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("status")
  private StatusEnum status = null;

  @SerializedName("isContentSharingActive")
  private Boolean isContentSharingActive = null;

  @SerializedName("bridged")
  private Boolean bridged = null;

  @SerializedName("locked")
  private Boolean locked = null;

  @SerializedName("audioMuteOnEntry")
  private Boolean audioMuteOnEntry = null;

  @SerializedName("videoMuteOnEntry")
  private Boolean videoMuteOnEntry = null;

  @SerializedName("moderatorLess")
  private Boolean moderatorLess = null;

  @SerializedName("title")
  private String title = null;

  @SerializedName("chatEnabled")
  private Boolean chatEnabled = null;

  @SerializedName("pinnedEndpointGuid")
  private String pinnedEndpointGuid = null;

  @SerializedName("audioEndpointCount")
  private Integer audioEndpointCount = null;

  @SerializedName("videoEndpointCount")
  private Integer videoEndpointCount = null;

  @SerializedName("recordingEnabled")
  private Boolean recordingEnabled = null;

  @SerializedName("participantWebJoinURL")
  private String participantWebJoinURL = null;

  @SerializedName("isLargeMeeting")
  private String isLargeMeeting = null;

  @SerializedName("features")
  private List<String> features = new ArrayList<String>();

  @SerializedName("delayedMeetingEndTime")
  private Integer delayedMeetingEndTime = null;

  @SerializedName("smStreams")
  private String smStreams = null;

  @SerializedName("inactiveMeetingStatus")
  private String inactiveMeetingStatus = null;

  @SerializedName("meetingMarkedForDelayedTermination")
  private Boolean meetingMarkedForDelayedTermination = null;

  @SerializedName("recordinginfo")
  private MeetingStateRecordinginfo recordinginfo = null;

  public MeetingState meetingId(String meetingId) {
    this.meetingId = meetingId;
    return this;
  }

   /**
   * Get meetingId
   * @return meetingId
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getMeetingId() {
    return meetingId;
  }

  public void setMeetingId(String meetingId) {
    this.meetingId = meetingId;
  }

  public MeetingState meetingGuid(String meetingGuid) {
    this.meetingGuid = meetingGuid;
    return this;
  }

   /**
   * Get meetingGuid
   * @return meetingGuid
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getMeetingGuid() {
    return meetingGuid;
  }

  public void setMeetingGuid(String meetingGuid) {
    this.meetingGuid = meetingGuid;
  }

  public MeetingState meetingState(MeetingStateEnum meetingState) {
    this.meetingState = meetingState;
    return this;
  }

   /**
   * Get meetingState
   * @return meetingState
  **/
  @ApiModelProperty(example = "null", value = "")
  public MeetingStateEnum getMeetingState() {
    return meetingState;
  }

  public void setMeetingState(MeetingStateEnum meetingState) {
    this.meetingState = meetingState;
  }

  public MeetingState status(StatusEnum status) {
    this.status = status;
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @ApiModelProperty(example = "null", value = "")
  public StatusEnum getStatus() {
    return status;
  }

  public void setStatus(StatusEnum status) {
    this.status = status;
  }

  public MeetingState isContentSharingActive(Boolean isContentSharingActive) {
    this.isContentSharingActive = isContentSharingActive;
    return this;
  }

   /**
   * Get isContentSharingActive
   * @return isContentSharingActive
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getIsContentSharingActive() {
    return isContentSharingActive;
  }

  public void setIsContentSharingActive(Boolean isContentSharingActive) {
    this.isContentSharingActive = isContentSharingActive;
  }

  public MeetingState bridged(Boolean bridged) {
    this.bridged = bridged;
    return this;
  }

   /**
   * Get bridged
   * @return bridged
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getBridged() {
    return bridged;
  }

  public void setBridged(Boolean bridged) {
    this.bridged = bridged;
  }

  public MeetingState locked(Boolean locked) {
    this.locked = locked;
    return this;
  }

   /**
   * Get locked
   * @return locked
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getLocked() {
    return locked;
  }

  public void setLocked(Boolean locked) {
    this.locked = locked;
  }

  public MeetingState audioMuteOnEntry(Boolean audioMuteOnEntry) {
    this.audioMuteOnEntry = audioMuteOnEntry;
    return this;
  }

   /**
   * Get audioMuteOnEntry
   * @return audioMuteOnEntry
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getAudioMuteOnEntry() {
    return audioMuteOnEntry;
  }

  public void setAudioMuteOnEntry(Boolean audioMuteOnEntry) {
    this.audioMuteOnEntry = audioMuteOnEntry;
  }

  public MeetingState videoMuteOnEntry(Boolean videoMuteOnEntry) {
    this.videoMuteOnEntry = videoMuteOnEntry;
    return this;
  }

   /**
   * Get videoMuteOnEntry
   * @return videoMuteOnEntry
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getVideoMuteOnEntry() {
    return videoMuteOnEntry;
  }

  public void setVideoMuteOnEntry(Boolean videoMuteOnEntry) {
    this.videoMuteOnEntry = videoMuteOnEntry;
  }

  public MeetingState moderatorLess(Boolean moderatorLess) {
    this.moderatorLess = moderatorLess;
    return this;
  }

   /**
   * Get moderatorLess
   * @return moderatorLess
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getModeratorLess() {
    return moderatorLess;
  }

  public void setModeratorLess(Boolean moderatorLess) {
    this.moderatorLess = moderatorLess;
  }

  public MeetingState title(String title) {
    this.title = title;
    return this;
  }

   /**
   * Get title
   * @return title
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getTitle() {
    return title;
  }

  public void setTitle(String title) {
    this.title = title;
  }

  public MeetingState chatEnabled(Boolean chatEnabled) {
    this.chatEnabled = chatEnabled;
    return this;
  }

   /**
   * Get chatEnabled
   * @return chatEnabled
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getChatEnabled() {
    return chatEnabled;
  }

  public void setChatEnabled(Boolean chatEnabled) {
    this.chatEnabled = chatEnabled;
  }

  public MeetingState pinnedEndpointGuid(String pinnedEndpointGuid) {
    this.pinnedEndpointGuid = pinnedEndpointGuid;
    return this;
  }

   /**
   * Get pinnedEndpointGuid
   * @return pinnedEndpointGuid
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getPinnedEndpointGuid() {
    return pinnedEndpointGuid;
  }

  public void setPinnedEndpointGuid(String pinnedEndpointGuid) {
    this.pinnedEndpointGuid = pinnedEndpointGuid;
  }

  public MeetingState audioEndpointCount(Integer audioEndpointCount) {
    this.audioEndpointCount = audioEndpointCount;
    return this;
  }

   /**
   * Get audioEndpointCount
   * @return audioEndpointCount
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getAudioEndpointCount() {
    return audioEndpointCount;
  }

  public void setAudioEndpointCount(Integer audioEndpointCount) {
    this.audioEndpointCount = audioEndpointCount;
  }

  public MeetingState videoEndpointCount(Integer videoEndpointCount) {
    this.videoEndpointCount = videoEndpointCount;
    return this;
  }

   /**
   * Get videoEndpointCount
   * @return videoEndpointCount
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getVideoEndpointCount() {
    return videoEndpointCount;
  }

  public void setVideoEndpointCount(Integer videoEndpointCount) {
    this.videoEndpointCount = videoEndpointCount;
  }

  public MeetingState recordingEnabled(Boolean recordingEnabled) {
    this.recordingEnabled = recordingEnabled;
    return this;
  }

   /**
   * Get recordingEnabled
   * @return recordingEnabled
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getRecordingEnabled() {
    return recordingEnabled;
  }

  public void setRecordingEnabled(Boolean recordingEnabled) {
    this.recordingEnabled = recordingEnabled;
  }

  public MeetingState participantWebJoinURL(String participantWebJoinURL) {
    this.participantWebJoinURL = participantWebJoinURL;
    return this;
  }

   /**
   * Get participantWebJoinURL
   * @return participantWebJoinURL
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getParticipantWebJoinURL() {
    return participantWebJoinURL;
  }

  public void setParticipantWebJoinURL(String participantWebJoinURL) {
    this.participantWebJoinURL = participantWebJoinURL;
  }

  public MeetingState isLargeMeeting(String isLargeMeeting) {
    this.isLargeMeeting = isLargeMeeting;
    return this;
  }

   /**
   * Get isLargeMeeting
   * @return isLargeMeeting
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getIsLargeMeeting() {
    return isLargeMeeting;
  }

  public void setIsLargeMeeting(String isLargeMeeting) {
    this.isLargeMeeting = isLargeMeeting;
  }

  public MeetingState features(List<String> features) {
    this.features = features;
    return this;
  }

  public MeetingState addFeaturesItem(String featuresItem) {
    this.features.add(featuresItem);
    return this;
  }

   /**
   * Get features
   * @return features
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<String> getFeatures() {
    return features;
  }

  public void setFeatures(List<String> features) {
    this.features = features;
  }

  public MeetingState delayedMeetingEndTime(Integer delayedMeetingEndTime) {
    this.delayedMeetingEndTime = delayedMeetingEndTime;
    return this;
  }

   /**
   * Get delayedMeetingEndTime
   * @return delayedMeetingEndTime
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getDelayedMeetingEndTime() {
    return delayedMeetingEndTime;
  }

  public void setDelayedMeetingEndTime(Integer delayedMeetingEndTime) {
    this.delayedMeetingEndTime = delayedMeetingEndTime;
  }

  public MeetingState smStreams(String smStreams) {
    this.smStreams = smStreams;
    return this;
  }

   /**
   * Get smStreams
   * @return smStreams
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getSmStreams() {
    return smStreams;
  }

  public void setSmStreams(String smStreams) {
    this.smStreams = smStreams;
  }

  public MeetingState inactiveMeetingStatus(String inactiveMeetingStatus) {
    this.inactiveMeetingStatus = inactiveMeetingStatus;
    return this;
  }

   /**
   * Get inactiveMeetingStatus
   * @return inactiveMeetingStatus
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getInactiveMeetingStatus() {
    return inactiveMeetingStatus;
  }

  public void setInactiveMeetingStatus(String inactiveMeetingStatus) {
    this.inactiveMeetingStatus = inactiveMeetingStatus;
  }

  public MeetingState meetingMarkedForDelayedTermination(Boolean meetingMarkedForDelayedTermination) {
    this.meetingMarkedForDelayedTermination = meetingMarkedForDelayedTermination;
    return this;
  }

   /**
   * Get meetingMarkedForDelayedTermination
   * @return meetingMarkedForDelayedTermination
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getMeetingMarkedForDelayedTermination() {
    return meetingMarkedForDelayedTermination;
  }

  public void setMeetingMarkedForDelayedTermination(Boolean meetingMarkedForDelayedTermination) {
    this.meetingMarkedForDelayedTermination = meetingMarkedForDelayedTermination;
  }

  public MeetingState recordinginfo(MeetingStateRecordinginfo recordinginfo) {
    this.recordinginfo = recordinginfo;
    return this;
  }

   /**
   * Get recordinginfo
   * @return recordinginfo
  **/
  @ApiModelProperty(example = "null", value = "")
  public MeetingStateRecordinginfo getRecordinginfo() {
    return recordinginfo;
  }

  public void setRecordinginfo(MeetingStateRecordinginfo recordinginfo) {
    this.recordinginfo = recordinginfo;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MeetingState meetingState = (MeetingState) o;
    return Objects.equals(this.meetingId, meetingState.meetingId) &&
        Objects.equals(this.meetingGuid, meetingState.meetingGuid) &&
        Objects.equals(this.meetingState, meetingState.meetingState) &&
        Objects.equals(this.status, meetingState.status) &&
        Objects.equals(this.isContentSharingActive, meetingState.isContentSharingActive) &&
        Objects.equals(this.bridged, meetingState.bridged) &&
        Objects.equals(this.locked, meetingState.locked) &&
        Objects.equals(this.audioMuteOnEntry, meetingState.audioMuteOnEntry) &&
        Objects.equals(this.videoMuteOnEntry, meetingState.videoMuteOnEntry) &&
        Objects.equals(this.moderatorLess, meetingState.moderatorLess) &&
        Objects.equals(this.title, meetingState.title) &&
        Objects.equals(this.chatEnabled, meetingState.chatEnabled) &&
        Objects.equals(this.pinnedEndpointGuid, meetingState.pinnedEndpointGuid) &&
        Objects.equals(this.audioEndpointCount, meetingState.audioEndpointCount) &&
        Objects.equals(this.videoEndpointCount, meetingState.videoEndpointCount) &&
        Objects.equals(this.recordingEnabled, meetingState.recordingEnabled) &&
        Objects.equals(this.participantWebJoinURL, meetingState.participantWebJoinURL) &&
        Objects.equals(this.isLargeMeeting, meetingState.isLargeMeeting) &&
        Objects.equals(this.features, meetingState.features) &&
        Objects.equals(this.delayedMeetingEndTime, meetingState.delayedMeetingEndTime) &&
        Objects.equals(this.smStreams, meetingState.smStreams) &&
        Objects.equals(this.inactiveMeetingStatus, meetingState.inactiveMeetingStatus) &&
        Objects.equals(this.meetingMarkedForDelayedTermination, meetingState.meetingMarkedForDelayedTermination) &&
        Objects.equals(this.recordinginfo, meetingState.recordinginfo);
  }

  @Override
  public int hashCode() {
    return Objects.hash(meetingId, meetingGuid, meetingState, status, isContentSharingActive, bridged, locked, audioMuteOnEntry, videoMuteOnEntry, moderatorLess, title, chatEnabled, pinnedEndpointGuid, audioEndpointCount, videoEndpointCount, recordingEnabled, participantWebJoinURL, isLargeMeeting, features, delayedMeetingEndTime, smStreams, inactiveMeetingStatus, meetingMarkedForDelayedTermination, recordinginfo);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MeetingState {\n");
    
    sb.append("    meetingId: ").append(toIndentedString(meetingId)).append("\n");
    sb.append("    meetingGuid: ").append(toIndentedString(meetingGuid)).append("\n");
    sb.append("    meetingState: ").append(toIndentedString(meetingState)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    isContentSharingActive: ").append(toIndentedString(isContentSharingActive)).append("\n");
    sb.append("    bridged: ").append(toIndentedString(bridged)).append("\n");
    sb.append("    locked: ").append(toIndentedString(locked)).append("\n");
    sb.append("    audioMuteOnEntry: ").append(toIndentedString(audioMuteOnEntry)).append("\n");
    sb.append("    videoMuteOnEntry: ").append(toIndentedString(videoMuteOnEntry)).append("\n");
    sb.append("    moderatorLess: ").append(toIndentedString(moderatorLess)).append("\n");
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
    sb.append("    chatEnabled: ").append(toIndentedString(chatEnabled)).append("\n");
    sb.append("    pinnedEndpointGuid: ").append(toIndentedString(pinnedEndpointGuid)).append("\n");
    sb.append("    audioEndpointCount: ").append(toIndentedString(audioEndpointCount)).append("\n");
    sb.append("    videoEndpointCount: ").append(toIndentedString(videoEndpointCount)).append("\n");
    sb.append("    recordingEnabled: ").append(toIndentedString(recordingEnabled)).append("\n");
    sb.append("    participantWebJoinURL: ").append(toIndentedString(participantWebJoinURL)).append("\n");
    sb.append("    isLargeMeeting: ").append(toIndentedString(isLargeMeeting)).append("\n");
    sb.append("    features: ").append(toIndentedString(features)).append("\n");
    sb.append("    delayedMeetingEndTime: ").append(toIndentedString(delayedMeetingEndTime)).append("\n");
    sb.append("    smStreams: ").append(toIndentedString(smStreams)).append("\n");
    sb.append("    inactiveMeetingStatus: ").append(toIndentedString(inactiveMeetingStatus)).append("\n");
    sb.append("    meetingMarkedForDelayedTermination: ").append(toIndentedString(meetingMarkedForDelayedTermination)).append("\n");
    sb.append("    recordinginfo: ").append(toIndentedString(recordinginfo)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}

