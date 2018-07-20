/*
 * BlueJeans Meetings REST API
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/010/2018 </alert>Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.4407102018
 * Contact: glenn@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bluejeans.api.rest.meetings.model;

import java.util.Objects;
import com.bluejeans.api.rest.meetings.model.MeetingHistoryLeaderInfo;
import com.bluejeans.api.rest.meetings.model.MeetingHistoryParticipantList;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * MeetingHistory
 */

public class MeetingHistory {
  @SerializedName("meetingGuid")
  private String meetingGuid = null;

  @SerializedName("meetingNumericId")
  private String meetingNumericId = null;

  @SerializedName("title")
  private String title = null;

  @SerializedName("description")
  private String description = null;

  @SerializedName("leaderInfo")
  private MeetingHistoryLeaderInfo leaderInfo = null;

  @SerializedName("userId")
  private Integer userId = null;

  @SerializedName("meetingDuration")
  private Integer meetingDuration = null;

  @SerializedName("maxParticipantCount")
  private Integer maxParticipantCount = null;

  @SerializedName("totalParticipantMinutes")
  private Integer totalParticipantMinutes = null;

  @SerializedName("maxParticipantMinutes")
  private Integer maxParticipantMinutes = null;

  @SerializedName("extraParticipantMinutes")
  private Integer extraParticipantMinutes = null;

  @SerializedName("isdnEndpoints")
  private Integer isdnEndpoints = null;

  @SerializedName("totalDialoutMinutes")
  private Integer totalDialoutMinutes = null;

  @SerializedName("totalTollFreeMinutes")
  private Integer totalTollFreeMinutes = null;

  @SerializedName("callDIDMinutes")
  private Integer callDIDMinutes = null;

  @SerializedName("startTime")
  private Integer startTime = null;

  @SerializedName("endTime")
  private Integer endTime = null;

  /**
   * Gets or Sets meetingStatus
   */
  @JsonAdapter(MeetingStatusEnum.Adapter.class)
  public enum MeetingStatusEnum {
    COMPLETE("Complete");

    private String value;

    MeetingStatusEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static MeetingStatusEnum fromValue(String text) {
      for (MeetingStatusEnum b : MeetingStatusEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<MeetingStatusEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final MeetingStatusEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public MeetingStatusEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return MeetingStatusEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("meetingStatus")
  private MeetingStatusEnum meetingStatus = null;

  @SerializedName("meetingThumbnail")
  private String meetingThumbnail = null;

  @SerializedName("startTimeZone")
  private String startTimeZone = null;

  /**
   * Gets or Sets processingStatus
   */
  @JsonAdapter(ProcessingStatusEnum.Adapter.class)
  public enum ProcessingStatusEnum {
    PROCESSED("PROCESSED");

    private String value;

    ProcessingStatusEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static ProcessingStatusEnum fromValue(String text) {
      for (ProcessingStatusEnum b : ProcessingStatusEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<ProcessingStatusEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final ProcessingStatusEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public ProcessingStatusEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return ProcessingStatusEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("processingStatus")
  private ProcessingStatusEnum processingStatus = null;

  @SerializedName("concurrentCalls")
  private String concurrentCalls = null;

  @SerializedName("uploadStatus")
  private String uploadStatus = null;

  @SerializedName("pstnonly")
  private Boolean pstnonly = null;

  @SerializedName("participantList")
  private List<MeetingHistoryParticipantList> participantList = null;

  public MeetingHistory meetingGuid(String meetingGuid) {
    this.meetingGuid = meetingGuid;
    return this;
  }

   /**
   * Get meetingGuid
   * @return meetingGuid
  **/
  @ApiModelProperty(value = "")
  public String getMeetingGuid() {
    return meetingGuid;
  }

  public void setMeetingGuid(String meetingGuid) {
    this.meetingGuid = meetingGuid;
  }

  public MeetingHistory meetingNumericId(String meetingNumericId) {
    this.meetingNumericId = meetingNumericId;
    return this;
  }

   /**
   * Get meetingNumericId
   * @return meetingNumericId
  **/
  @ApiModelProperty(value = "")
  public String getMeetingNumericId() {
    return meetingNumericId;
  }

  public void setMeetingNumericId(String meetingNumericId) {
    this.meetingNumericId = meetingNumericId;
  }

  public MeetingHistory title(String title) {
    this.title = title;
    return this;
  }

   /**
   * Get title
   * @return title
  **/
  @ApiModelProperty(value = "")
  public String getTitle() {
    return title;
  }

  public void setTitle(String title) {
    this.title = title;
  }

  public MeetingHistory description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @ApiModelProperty(value = "")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public MeetingHistory leaderInfo(MeetingHistoryLeaderInfo leaderInfo) {
    this.leaderInfo = leaderInfo;
    return this;
  }

   /**
   * Get leaderInfo
   * @return leaderInfo
  **/
  @ApiModelProperty(value = "")
  public MeetingHistoryLeaderInfo getLeaderInfo() {
    return leaderInfo;
  }

  public void setLeaderInfo(MeetingHistoryLeaderInfo leaderInfo) {
    this.leaderInfo = leaderInfo;
  }

  public MeetingHistory userId(Integer userId) {
    this.userId = userId;
    return this;
  }

   /**
   * Get userId
   * @return userId
  **/
  @ApiModelProperty(value = "")
  public Integer getUserId() {
    return userId;
  }

  public void setUserId(Integer userId) {
    this.userId = userId;
  }

  public MeetingHistory meetingDuration(Integer meetingDuration) {
    this.meetingDuration = meetingDuration;
    return this;
  }

   /**
   * Get meetingDuration
   * @return meetingDuration
  **/
  @ApiModelProperty(value = "")
  public Integer getMeetingDuration() {
    return meetingDuration;
  }

  public void setMeetingDuration(Integer meetingDuration) {
    this.meetingDuration = meetingDuration;
  }

  public MeetingHistory maxParticipantCount(Integer maxParticipantCount) {
    this.maxParticipantCount = maxParticipantCount;
    return this;
  }

   /**
   * Get maxParticipantCount
   * @return maxParticipantCount
  **/
  @ApiModelProperty(value = "")
  public Integer getMaxParticipantCount() {
    return maxParticipantCount;
  }

  public void setMaxParticipantCount(Integer maxParticipantCount) {
    this.maxParticipantCount = maxParticipantCount;
  }

  public MeetingHistory totalParticipantMinutes(Integer totalParticipantMinutes) {
    this.totalParticipantMinutes = totalParticipantMinutes;
    return this;
  }

   /**
   * Get totalParticipantMinutes
   * @return totalParticipantMinutes
  **/
  @ApiModelProperty(value = "")
  public Integer getTotalParticipantMinutes() {
    return totalParticipantMinutes;
  }

  public void setTotalParticipantMinutes(Integer totalParticipantMinutes) {
    this.totalParticipantMinutes = totalParticipantMinutes;
  }

  public MeetingHistory maxParticipantMinutes(Integer maxParticipantMinutes) {
    this.maxParticipantMinutes = maxParticipantMinutes;
    return this;
  }

   /**
   * Get maxParticipantMinutes
   * @return maxParticipantMinutes
  **/
  @ApiModelProperty(value = "")
  public Integer getMaxParticipantMinutes() {
    return maxParticipantMinutes;
  }

  public void setMaxParticipantMinutes(Integer maxParticipantMinutes) {
    this.maxParticipantMinutes = maxParticipantMinutes;
  }

  public MeetingHistory extraParticipantMinutes(Integer extraParticipantMinutes) {
    this.extraParticipantMinutes = extraParticipantMinutes;
    return this;
  }

   /**
   * Get extraParticipantMinutes
   * @return extraParticipantMinutes
  **/
  @ApiModelProperty(value = "")
  public Integer getExtraParticipantMinutes() {
    return extraParticipantMinutes;
  }

  public void setExtraParticipantMinutes(Integer extraParticipantMinutes) {
    this.extraParticipantMinutes = extraParticipantMinutes;
  }

  public MeetingHistory isdnEndpoints(Integer isdnEndpoints) {
    this.isdnEndpoints = isdnEndpoints;
    return this;
  }

   /**
   * Get isdnEndpoints
   * @return isdnEndpoints
  **/
  @ApiModelProperty(value = "")
  public Integer getIsdnEndpoints() {
    return isdnEndpoints;
  }

  public void setIsdnEndpoints(Integer isdnEndpoints) {
    this.isdnEndpoints = isdnEndpoints;
  }

  public MeetingHistory totalDialoutMinutes(Integer totalDialoutMinutes) {
    this.totalDialoutMinutes = totalDialoutMinutes;
    return this;
  }

   /**
   * Get totalDialoutMinutes
   * @return totalDialoutMinutes
  **/
  @ApiModelProperty(value = "")
  public Integer getTotalDialoutMinutes() {
    return totalDialoutMinutes;
  }

  public void setTotalDialoutMinutes(Integer totalDialoutMinutes) {
    this.totalDialoutMinutes = totalDialoutMinutes;
  }

  public MeetingHistory totalTollFreeMinutes(Integer totalTollFreeMinutes) {
    this.totalTollFreeMinutes = totalTollFreeMinutes;
    return this;
  }

   /**
   * Get totalTollFreeMinutes
   * @return totalTollFreeMinutes
  **/
  @ApiModelProperty(value = "")
  public Integer getTotalTollFreeMinutes() {
    return totalTollFreeMinutes;
  }

  public void setTotalTollFreeMinutes(Integer totalTollFreeMinutes) {
    this.totalTollFreeMinutes = totalTollFreeMinutes;
  }

  public MeetingHistory callDIDMinutes(Integer callDIDMinutes) {
    this.callDIDMinutes = callDIDMinutes;
    return this;
  }

   /**
   * Get callDIDMinutes
   * @return callDIDMinutes
  **/
  @ApiModelProperty(value = "")
  public Integer getCallDIDMinutes() {
    return callDIDMinutes;
  }

  public void setCallDIDMinutes(Integer callDIDMinutes) {
    this.callDIDMinutes = callDIDMinutes;
  }

  public MeetingHistory startTime(Integer startTime) {
    this.startTime = startTime;
    return this;
  }

   /**
   * Get startTime
   * @return startTime
  **/
  @ApiModelProperty(value = "")
  public Integer getStartTime() {
    return startTime;
  }

  public void setStartTime(Integer startTime) {
    this.startTime = startTime;
  }

  public MeetingHistory endTime(Integer endTime) {
    this.endTime = endTime;
    return this;
  }

   /**
   * Get endTime
   * @return endTime
  **/
  @ApiModelProperty(value = "")
  public Integer getEndTime() {
    return endTime;
  }

  public void setEndTime(Integer endTime) {
    this.endTime = endTime;
  }

  public MeetingHistory meetingStatus(MeetingStatusEnum meetingStatus) {
    this.meetingStatus = meetingStatus;
    return this;
  }

   /**
   * Get meetingStatus
   * @return meetingStatus
  **/
  @ApiModelProperty(value = "")
  public MeetingStatusEnum getMeetingStatus() {
    return meetingStatus;
  }

  public void setMeetingStatus(MeetingStatusEnum meetingStatus) {
    this.meetingStatus = meetingStatus;
  }

  public MeetingHistory meetingThumbnail(String meetingThumbnail) {
    this.meetingThumbnail = meetingThumbnail;
    return this;
  }

   /**
   * Get meetingThumbnail
   * @return meetingThumbnail
  **/
  @ApiModelProperty(value = "")
  public String getMeetingThumbnail() {
    return meetingThumbnail;
  }

  public void setMeetingThumbnail(String meetingThumbnail) {
    this.meetingThumbnail = meetingThumbnail;
  }

  public MeetingHistory startTimeZone(String startTimeZone) {
    this.startTimeZone = startTimeZone;
    return this;
  }

   /**
   * Get startTimeZone
   * @return startTimeZone
  **/
  @ApiModelProperty(value = "")
  public String getStartTimeZone() {
    return startTimeZone;
  }

  public void setStartTimeZone(String startTimeZone) {
    this.startTimeZone = startTimeZone;
  }

  public MeetingHistory processingStatus(ProcessingStatusEnum processingStatus) {
    this.processingStatus = processingStatus;
    return this;
  }

   /**
   * Get processingStatus
   * @return processingStatus
  **/
  @ApiModelProperty(value = "")
  public ProcessingStatusEnum getProcessingStatus() {
    return processingStatus;
  }

  public void setProcessingStatus(ProcessingStatusEnum processingStatus) {
    this.processingStatus = processingStatus;
  }

  public MeetingHistory concurrentCalls(String concurrentCalls) {
    this.concurrentCalls = concurrentCalls;
    return this;
  }

   /**
   * Get concurrentCalls
   * @return concurrentCalls
  **/
  @ApiModelProperty(value = "")
  public String getConcurrentCalls() {
    return concurrentCalls;
  }

  public void setConcurrentCalls(String concurrentCalls) {
    this.concurrentCalls = concurrentCalls;
  }

  public MeetingHistory uploadStatus(String uploadStatus) {
    this.uploadStatus = uploadStatus;
    return this;
  }

   /**
   * Get uploadStatus
   * @return uploadStatus
  **/
  @ApiModelProperty(value = "")
  public String getUploadStatus() {
    return uploadStatus;
  }

  public void setUploadStatus(String uploadStatus) {
    this.uploadStatus = uploadStatus;
  }

  public MeetingHistory pstnonly(Boolean pstnonly) {
    this.pstnonly = pstnonly;
    return this;
  }

   /**
   * Get pstnonly
   * @return pstnonly
  **/
  @ApiModelProperty(value = "")
  public Boolean getPstnonly() {
    return pstnonly;
  }

  public void setPstnonly(Boolean pstnonly) {
    this.pstnonly = pstnonly;
  }

  public MeetingHistory participantList(List<MeetingHistoryParticipantList> participantList) {
    this.participantList = participantList;
    return this;
  }

  public MeetingHistory addParticipantListItem(MeetingHistoryParticipantList participantListItem) {
    if (this.participantList == null) {
      this.participantList = new ArrayList<MeetingHistoryParticipantList>();
    }
    this.participantList.add(participantListItem);
    return this;
  }

   /**
   * Get participantList
   * @return participantList
  **/
  @ApiModelProperty(value = "")
  public List<MeetingHistoryParticipantList> getParticipantList() {
    return participantList;
  }

  public void setParticipantList(List<MeetingHistoryParticipantList> participantList) {
    this.participantList = participantList;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MeetingHistory meetingHistory = (MeetingHistory) o;
    return Objects.equals(this.meetingGuid, meetingHistory.meetingGuid) &&
        Objects.equals(this.meetingNumericId, meetingHistory.meetingNumericId) &&
        Objects.equals(this.title, meetingHistory.title) &&
        Objects.equals(this.description, meetingHistory.description) &&
        Objects.equals(this.leaderInfo, meetingHistory.leaderInfo) &&
        Objects.equals(this.userId, meetingHistory.userId) &&
        Objects.equals(this.meetingDuration, meetingHistory.meetingDuration) &&
        Objects.equals(this.maxParticipantCount, meetingHistory.maxParticipantCount) &&
        Objects.equals(this.totalParticipantMinutes, meetingHistory.totalParticipantMinutes) &&
        Objects.equals(this.maxParticipantMinutes, meetingHistory.maxParticipantMinutes) &&
        Objects.equals(this.extraParticipantMinutes, meetingHistory.extraParticipantMinutes) &&
        Objects.equals(this.isdnEndpoints, meetingHistory.isdnEndpoints) &&
        Objects.equals(this.totalDialoutMinutes, meetingHistory.totalDialoutMinutes) &&
        Objects.equals(this.totalTollFreeMinutes, meetingHistory.totalTollFreeMinutes) &&
        Objects.equals(this.callDIDMinutes, meetingHistory.callDIDMinutes) &&
        Objects.equals(this.startTime, meetingHistory.startTime) &&
        Objects.equals(this.endTime, meetingHistory.endTime) &&
        Objects.equals(this.meetingStatus, meetingHistory.meetingStatus) &&
        Objects.equals(this.meetingThumbnail, meetingHistory.meetingThumbnail) &&
        Objects.equals(this.startTimeZone, meetingHistory.startTimeZone) &&
        Objects.equals(this.processingStatus, meetingHistory.processingStatus) &&
        Objects.equals(this.concurrentCalls, meetingHistory.concurrentCalls) &&
        Objects.equals(this.uploadStatus, meetingHistory.uploadStatus) &&
        Objects.equals(this.pstnonly, meetingHistory.pstnonly) &&
        Objects.equals(this.participantList, meetingHistory.participantList);
  }

  @Override
  public int hashCode() {
    return Objects.hash(meetingGuid, meetingNumericId, title, description, leaderInfo, userId, meetingDuration, maxParticipantCount, totalParticipantMinutes, maxParticipantMinutes, extraParticipantMinutes, isdnEndpoints, totalDialoutMinutes, totalTollFreeMinutes, callDIDMinutes, startTime, endTime, meetingStatus, meetingThumbnail, startTimeZone, processingStatus, concurrentCalls, uploadStatus, pstnonly, participantList);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MeetingHistory {\n");
    
    sb.append("    meetingGuid: ").append(toIndentedString(meetingGuid)).append("\n");
    sb.append("    meetingNumericId: ").append(toIndentedString(meetingNumericId)).append("\n");
    sb.append("    title: ").append(toIndentedString(title)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    leaderInfo: ").append(toIndentedString(leaderInfo)).append("\n");
    sb.append("    userId: ").append(toIndentedString(userId)).append("\n");
    sb.append("    meetingDuration: ").append(toIndentedString(meetingDuration)).append("\n");
    sb.append("    maxParticipantCount: ").append(toIndentedString(maxParticipantCount)).append("\n");
    sb.append("    totalParticipantMinutes: ").append(toIndentedString(totalParticipantMinutes)).append("\n");
    sb.append("    maxParticipantMinutes: ").append(toIndentedString(maxParticipantMinutes)).append("\n");
    sb.append("    extraParticipantMinutes: ").append(toIndentedString(extraParticipantMinutes)).append("\n");
    sb.append("    isdnEndpoints: ").append(toIndentedString(isdnEndpoints)).append("\n");
    sb.append("    totalDialoutMinutes: ").append(toIndentedString(totalDialoutMinutes)).append("\n");
    sb.append("    totalTollFreeMinutes: ").append(toIndentedString(totalTollFreeMinutes)).append("\n");
    sb.append("    callDIDMinutes: ").append(toIndentedString(callDIDMinutes)).append("\n");
    sb.append("    startTime: ").append(toIndentedString(startTime)).append("\n");
    sb.append("    endTime: ").append(toIndentedString(endTime)).append("\n");
    sb.append("    meetingStatus: ").append(toIndentedString(meetingStatus)).append("\n");
    sb.append("    meetingThumbnail: ").append(toIndentedString(meetingThumbnail)).append("\n");
    sb.append("    startTimeZone: ").append(toIndentedString(startTimeZone)).append("\n");
    sb.append("    processingStatus: ").append(toIndentedString(processingStatus)).append("\n");
    sb.append("    concurrentCalls: ").append(toIndentedString(concurrentCalls)).append("\n");
    sb.append("    uploadStatus: ").append(toIndentedString(uploadStatus)).append("\n");
    sb.append("    pstnonly: ").append(toIndentedString(pstnonly)).append("\n");
    sb.append("    participantList: ").append(toIndentedString(participantList)).append("\n");
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

