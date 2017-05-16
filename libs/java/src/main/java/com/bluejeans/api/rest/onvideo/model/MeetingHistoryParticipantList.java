/*
 * BlueJeans onVideo REST API
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – After creating a developer application, users witll authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access token. Known as three-legged OAuth. ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use one of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bluejeans.api.rest.onvideo.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * MeetingHistoryParticipantList
 */

public class MeetingHistoryParticipantList {
  @SerializedName("endpointName")
  private String endpointName = null;

  @SerializedName("joinTime")
  private Integer joinTime = null;

  @SerializedName("minutes")
  private Integer minutes = null;

  /**
   * Gets or Sets deviceType
   */
  public enum DeviceTypeEnum {
    @SerializedName("Carmel")
    CARMEL("Carmel"),
    
    @SerializedName("WebRTC")
    WEBRTC("WebRTC");

    private String value;

    DeviceTypeEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("deviceType")
  private DeviceTypeEnum deviceType = null;

  @SerializedName("email")
  private String email = null;

  @SerializedName("remoteAddress")
  private String remoteAddress = null;

  @SerializedName("isEncrypted")
  private Boolean isEncrypted = null;

  @SerializedName("disconnectTime")
  private Integer disconnectTime = null;

  @SerializedName("isModerator")
  private Boolean isModerator = null;

  @SerializedName("userId")
  private Integer userId = null;

  @SerializedName("tags")
  private String tags = null;

  @SerializedName("participantGuid")
  private String participantGuid = null;

  public MeetingHistoryParticipantList endpointName(String endpointName) {
    this.endpointName = endpointName;
    return this;
  }

   /**
   * Get endpointName
   * @return endpointName
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getEndpointName() {
    return endpointName;
  }

  public void setEndpointName(String endpointName) {
    this.endpointName = endpointName;
  }

  public MeetingHistoryParticipantList joinTime(Integer joinTime) {
    this.joinTime = joinTime;
    return this;
  }

   /**
   * Get joinTime
   * @return joinTime
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getJoinTime() {
    return joinTime;
  }

  public void setJoinTime(Integer joinTime) {
    this.joinTime = joinTime;
  }

  public MeetingHistoryParticipantList minutes(Integer minutes) {
    this.minutes = minutes;
    return this;
  }

   /**
   * Get minutes
   * @return minutes
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getMinutes() {
    return minutes;
  }

  public void setMinutes(Integer minutes) {
    this.minutes = minutes;
  }

  public MeetingHistoryParticipantList deviceType(DeviceTypeEnum deviceType) {
    this.deviceType = deviceType;
    return this;
  }

   /**
   * Get deviceType
   * @return deviceType
  **/
  @ApiModelProperty(example = "null", value = "")
  public DeviceTypeEnum getDeviceType() {
    return deviceType;
  }

  public void setDeviceType(DeviceTypeEnum deviceType) {
    this.deviceType = deviceType;
  }

  public MeetingHistoryParticipantList email(String email) {
    this.email = email;
    return this;
  }

   /**
   * Get email
   * @return email
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getEmail() {
    return email;
  }

  public void setEmail(String email) {
    this.email = email;
  }

  public MeetingHistoryParticipantList remoteAddress(String remoteAddress) {
    this.remoteAddress = remoteAddress;
    return this;
  }

   /**
   * Get remoteAddress
   * @return remoteAddress
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getRemoteAddress() {
    return remoteAddress;
  }

  public void setRemoteAddress(String remoteAddress) {
    this.remoteAddress = remoteAddress;
  }

  public MeetingHistoryParticipantList isEncrypted(Boolean isEncrypted) {
    this.isEncrypted = isEncrypted;
    return this;
  }

   /**
   * Get isEncrypted
   * @return isEncrypted
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getIsEncrypted() {
    return isEncrypted;
  }

  public void setIsEncrypted(Boolean isEncrypted) {
    this.isEncrypted = isEncrypted;
  }

  public MeetingHistoryParticipantList disconnectTime(Integer disconnectTime) {
    this.disconnectTime = disconnectTime;
    return this;
  }

   /**
   * Get disconnectTime
   * @return disconnectTime
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getDisconnectTime() {
    return disconnectTime;
  }

  public void setDisconnectTime(Integer disconnectTime) {
    this.disconnectTime = disconnectTime;
  }

  public MeetingHistoryParticipantList isModerator(Boolean isModerator) {
    this.isModerator = isModerator;
    return this;
  }

   /**
   * Get isModerator
   * @return isModerator
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getIsModerator() {
    return isModerator;
  }

  public void setIsModerator(Boolean isModerator) {
    this.isModerator = isModerator;
  }

  public MeetingHistoryParticipantList userId(Integer userId) {
    this.userId = userId;
    return this;
  }

   /**
   * Get userId
   * @return userId
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getUserId() {
    return userId;
  }

  public void setUserId(Integer userId) {
    this.userId = userId;
  }

  public MeetingHistoryParticipantList tags(String tags) {
    this.tags = tags;
    return this;
  }

   /**
   * Get tags
   * @return tags
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getTags() {
    return tags;
  }

  public void setTags(String tags) {
    this.tags = tags;
  }

  public MeetingHistoryParticipantList participantGuid(String participantGuid) {
    this.participantGuid = participantGuid;
    return this;
  }

   /**
   * Get participantGuid
   * @return participantGuid
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getParticipantGuid() {
    return participantGuid;
  }

  public void setParticipantGuid(String participantGuid) {
    this.participantGuid = participantGuid;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MeetingHistoryParticipantList meetingHistoryParticipantList = (MeetingHistoryParticipantList) o;
    return Objects.equals(this.endpointName, meetingHistoryParticipantList.endpointName) &&
        Objects.equals(this.joinTime, meetingHistoryParticipantList.joinTime) &&
        Objects.equals(this.minutes, meetingHistoryParticipantList.minutes) &&
        Objects.equals(this.deviceType, meetingHistoryParticipantList.deviceType) &&
        Objects.equals(this.email, meetingHistoryParticipantList.email) &&
        Objects.equals(this.remoteAddress, meetingHistoryParticipantList.remoteAddress) &&
        Objects.equals(this.isEncrypted, meetingHistoryParticipantList.isEncrypted) &&
        Objects.equals(this.disconnectTime, meetingHistoryParticipantList.disconnectTime) &&
        Objects.equals(this.isModerator, meetingHistoryParticipantList.isModerator) &&
        Objects.equals(this.userId, meetingHistoryParticipantList.userId) &&
        Objects.equals(this.tags, meetingHistoryParticipantList.tags) &&
        Objects.equals(this.participantGuid, meetingHistoryParticipantList.participantGuid);
  }

  @Override
  public int hashCode() {
    return Objects.hash(endpointName, joinTime, minutes, deviceType, email, remoteAddress, isEncrypted, disconnectTime, isModerator, userId, tags, participantGuid);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MeetingHistoryParticipantList {\n");
    
    sb.append("    endpointName: ").append(toIndentedString(endpointName)).append("\n");
    sb.append("    joinTime: ").append(toIndentedString(joinTime)).append("\n");
    sb.append("    minutes: ").append(toIndentedString(minutes)).append("\n");
    sb.append("    deviceType: ").append(toIndentedString(deviceType)).append("\n");
    sb.append("    email: ").append(toIndentedString(email)).append("\n");
    sb.append("    remoteAddress: ").append(toIndentedString(remoteAddress)).append("\n");
    sb.append("    isEncrypted: ").append(toIndentedString(isEncrypted)).append("\n");
    sb.append("    disconnectTime: ").append(toIndentedString(disconnectTime)).append("\n");
    sb.append("    isModerator: ").append(toIndentedString(isModerator)).append("\n");
    sb.append("    userId: ").append(toIndentedString(userId)).append("\n");
    sb.append("    tags: ").append(toIndentedString(tags)).append("\n");
    sb.append("    participantGuid: ").append(toIndentedString(participantGuid)).append("\n");
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
