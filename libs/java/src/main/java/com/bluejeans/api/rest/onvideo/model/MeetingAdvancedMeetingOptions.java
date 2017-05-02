/*
 * BlueJeans onVideo REST API
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
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
 * MeetingAdvancedMeetingOptions
 */

public class MeetingAdvancedMeetingOptions {
  @SerializedName("autoRecord")
  private Boolean autoRecord = null;

  @SerializedName("muteParticipantsOnEntry")
  private Boolean muteParticipantsOnEntry = null;

  /**
   * Gets or Sets encryptionType
   */
  public enum EncryptionTypeEnum {
    @SerializedName("NO_ENCRYPTION")
    NO_ENCRYPTION("NO_ENCRYPTION"),
    
    @SerializedName("ENCRYPTED_ONLY")
    ENCRYPTED_ONLY("ENCRYPTED_ONLY"),
    
    @SerializedName("ENCRYPTED_OR_PSTN_ONLY")
    ENCRYPTED_OR_PSTN_ONLY("ENCRYPTED_OR_PSTN_ONLY");

    private String value;

    EncryptionTypeEnum(String value) {
      this.value = value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
  }

  @SerializedName("encryptionType")
  private EncryptionTypeEnum encryptionType = null;

  @SerializedName("moderatorLess")
  private Boolean moderatorLess = null;

  @SerializedName("videoBestFit")
  private Boolean videoBestFit = null;

  @SerializedName("disallowChat")
  private Boolean disallowChat = null;

  @SerializedName("publishMeeting")
  private Boolean publishMeeting = null;

  @SerializedName("showAllAttendeesInMeetingInvite")
  private Boolean showAllAttendeesInMeetingInvite = null;

  public MeetingAdvancedMeetingOptions autoRecord(Boolean autoRecord) {
    this.autoRecord = autoRecord;
    return this;
  }

   /**
   * Get autoRecord
   * @return autoRecord
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getAutoRecord() {
    return autoRecord;
  }

  public void setAutoRecord(Boolean autoRecord) {
    this.autoRecord = autoRecord;
  }

  public MeetingAdvancedMeetingOptions muteParticipantsOnEntry(Boolean muteParticipantsOnEntry) {
    this.muteParticipantsOnEntry = muteParticipantsOnEntry;
    return this;
  }

   /**
   * Get muteParticipantsOnEntry
   * @return muteParticipantsOnEntry
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getMuteParticipantsOnEntry() {
    return muteParticipantsOnEntry;
  }

  public void setMuteParticipantsOnEntry(Boolean muteParticipantsOnEntry) {
    this.muteParticipantsOnEntry = muteParticipantsOnEntry;
  }

  public MeetingAdvancedMeetingOptions encryptionType(EncryptionTypeEnum encryptionType) {
    this.encryptionType = encryptionType;
    return this;
  }

   /**
   * Get encryptionType
   * @return encryptionType
  **/
  @ApiModelProperty(example = "null", value = "")
  public EncryptionTypeEnum getEncryptionType() {
    return encryptionType;
  }

  public void setEncryptionType(EncryptionTypeEnum encryptionType) {
    this.encryptionType = encryptionType;
  }

  public MeetingAdvancedMeetingOptions moderatorLess(Boolean moderatorLess) {
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

  public MeetingAdvancedMeetingOptions videoBestFit(Boolean videoBestFit) {
    this.videoBestFit = videoBestFit;
    return this;
  }

   /**
   * Get videoBestFit
   * @return videoBestFit
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getVideoBestFit() {
    return videoBestFit;
  }

  public void setVideoBestFit(Boolean videoBestFit) {
    this.videoBestFit = videoBestFit;
  }

  public MeetingAdvancedMeetingOptions disallowChat(Boolean disallowChat) {
    this.disallowChat = disallowChat;
    return this;
  }

   /**
   * Get disallowChat
   * @return disallowChat
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getDisallowChat() {
    return disallowChat;
  }

  public void setDisallowChat(Boolean disallowChat) {
    this.disallowChat = disallowChat;
  }

  public MeetingAdvancedMeetingOptions publishMeeting(Boolean publishMeeting) {
    this.publishMeeting = publishMeeting;
    return this;
  }

   /**
   * Get publishMeeting
   * @return publishMeeting
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getPublishMeeting() {
    return publishMeeting;
  }

  public void setPublishMeeting(Boolean publishMeeting) {
    this.publishMeeting = publishMeeting;
  }

  public MeetingAdvancedMeetingOptions showAllAttendeesInMeetingInvite(Boolean showAllAttendeesInMeetingInvite) {
    this.showAllAttendeesInMeetingInvite = showAllAttendeesInMeetingInvite;
    return this;
  }

   /**
   * Get showAllAttendeesInMeetingInvite
   * @return showAllAttendeesInMeetingInvite
  **/
  @ApiModelProperty(example = "null", value = "")
  public Boolean getShowAllAttendeesInMeetingInvite() {
    return showAllAttendeesInMeetingInvite;
  }

  public void setShowAllAttendeesInMeetingInvite(Boolean showAllAttendeesInMeetingInvite) {
    this.showAllAttendeesInMeetingInvite = showAllAttendeesInMeetingInvite;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MeetingAdvancedMeetingOptions meetingAdvancedMeetingOptions = (MeetingAdvancedMeetingOptions) o;
    return Objects.equals(this.autoRecord, meetingAdvancedMeetingOptions.autoRecord) &&
        Objects.equals(this.muteParticipantsOnEntry, meetingAdvancedMeetingOptions.muteParticipantsOnEntry) &&
        Objects.equals(this.encryptionType, meetingAdvancedMeetingOptions.encryptionType) &&
        Objects.equals(this.moderatorLess, meetingAdvancedMeetingOptions.moderatorLess) &&
        Objects.equals(this.videoBestFit, meetingAdvancedMeetingOptions.videoBestFit) &&
        Objects.equals(this.disallowChat, meetingAdvancedMeetingOptions.disallowChat) &&
        Objects.equals(this.publishMeeting, meetingAdvancedMeetingOptions.publishMeeting) &&
        Objects.equals(this.showAllAttendeesInMeetingInvite, meetingAdvancedMeetingOptions.showAllAttendeesInMeetingInvite);
  }

  @Override
  public int hashCode() {
    return Objects.hash(autoRecord, muteParticipantsOnEntry, encryptionType, moderatorLess, videoBestFit, disallowChat, publishMeeting, showAllAttendeesInMeetingInvite);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MeetingAdvancedMeetingOptions {\n");
    
    sb.append("    autoRecord: ").append(toIndentedString(autoRecord)).append("\n");
    sb.append("    muteParticipantsOnEntry: ").append(toIndentedString(muteParticipantsOnEntry)).append("\n");
    sb.append("    encryptionType: ").append(toIndentedString(encryptionType)).append("\n");
    sb.append("    moderatorLess: ").append(toIndentedString(moderatorLess)).append("\n");
    sb.append("    videoBestFit: ").append(toIndentedString(videoBestFit)).append("\n");
    sb.append("    disallowChat: ").append(toIndentedString(disallowChat)).append("\n");
    sb.append("    publishMeeting: ").append(toIndentedString(publishMeeting)).append("\n");
    sb.append("    showAllAttendeesInMeetingInvite: ").append(toIndentedString(showAllAttendeesInMeetingInvite)).append("\n");
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

