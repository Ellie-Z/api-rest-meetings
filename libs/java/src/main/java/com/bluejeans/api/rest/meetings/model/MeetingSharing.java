/*
 * BlueJeans Meetings REST API
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/23/2018 </alert>Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.4407232018
 * Contact: glenn@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bluejeans.api.rest.meetings.model;

import java.util.Objects;
import java.util.Arrays;
import com.bluejeans.api.rest.meetings.model.MeetingSharingProperties;
import com.bluejeans.api.rest.meetings.model.RecepientOptionsComp;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * MeetingSharing
 */

public class MeetingSharing {
  @SerializedName("id")
  private Integer id = null;

  @SerializedName("meetingGuid")
  private String meetingGuid = null;

  @SerializedName("ownerId")
  private Integer ownerId = null;

  @SerializedName("sharingUrl")
  private String sharingUrl = null;

  @SerializedName("recepientType")
  private RecepientOptionsComp recepientType = null;

  @SerializedName("properties")
  private MeetingSharingProperties properties = null;

  /**
   * This status field indicates the state of the sharing authorization record.
   */
  @JsonAdapter(StatusEnum.Adapter.class)
  public enum StatusEnum {
    ACTIVE("ACTIVE"),
    
    DELETED("DELETED");

    private String value;

    StatusEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static StatusEnum fromValue(String text) {
      for (StatusEnum b : StatusEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<StatusEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final StatusEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public StatusEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return StatusEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("status")
  private StatusEnum status = null;

  @SerializedName("downloadable")
  private Boolean downloadable = null;

  @SerializedName("passcode")
  private String passcode = null;

  @SerializedName("validity")
  private String validity = null;

  @SerializedName("created")
  private Integer created = null;

  @SerializedName("lastmodified")
  private Integer lastmodified = null;

  public MeetingSharing id(Integer id) {
    this.id = id;
    return this;
  }

   /**
   * This field is the Sharing Authorization unique identifier.
   * @return id
  **/
  @ApiModelProperty(value = "This field is the Sharing Authorization unique identifier.")
  public Integer getId() {
    return id;
  }

  public void setId(Integer id) {
    this.id = id;
  }

  public MeetingSharing meetingGuid(String meetingGuid) {
    this.meetingGuid = meetingGuid;
    return this;
  }

   /**
   * The meetingGuid is a globally unique Id for this particular recording. It is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 6 alphanumeric segments separated by dashes.
   * @return meetingGuid
  **/
  @ApiModelProperty(value = "The meetingGuid is a globally unique Id for this particular recording. It is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 6 alphanumeric segments separated by dashes.")
  public String getMeetingGuid() {
    return meetingGuid;
  }

  public void setMeetingGuid(String meetingGuid) {
    this.meetingGuid = meetingGuid;
  }

  public MeetingSharing ownerId(Integer ownerId) {
    this.ownerId = ownerId;
    return this;
  }

   /**
   * The ownerId field is the unique Id number of the BlueJeans account that owns the recording
   * @return ownerId
  **/
  @ApiModelProperty(value = "The ownerId field is the unique Id number of the BlueJeans account that owns the recording")
  public Integer getOwnerId() {
    return ownerId;
  }

  public void setOwnerId(Integer ownerId) {
    this.ownerId = ownerId;
  }

  public MeetingSharing sharingUrl(String sharingUrl) {
    this.sharingUrl = sharingUrl;
    return this;
  }

   /**
   * Get sharingUrl
   * @return sharingUrl
  **/
  @ApiModelProperty(value = "")
  public String getSharingUrl() {
    return sharingUrl;
  }

  public void setSharingUrl(String sharingUrl) {
    this.sharingUrl = sharingUrl;
  }

  public MeetingSharing recepientType(RecepientOptionsComp recepientType) {
    this.recepientType = recepientType;
    return this;
  }

   /**
   * Get recepientType
   * @return recepientType
  **/
  @ApiModelProperty(value = "")
  public RecepientOptionsComp getRecepientType() {
    return recepientType;
  }

  public void setRecepientType(RecepientOptionsComp recepientType) {
    this.recepientType = recepientType;
  }

  public MeetingSharing properties(MeetingSharingProperties properties) {
    this.properties = properties;
    return this;
  }

   /**
   * Get properties
   * @return properties
  **/
  @ApiModelProperty(value = "")
  public MeetingSharingProperties getProperties() {
    return properties;
  }

  public void setProperties(MeetingSharingProperties properties) {
    this.properties = properties;
  }

  public MeetingSharing status(StatusEnum status) {
    this.status = status;
    return this;
  }

   /**
   * This status field indicates the state of the sharing authorization record.
   * @return status
  **/
  @ApiModelProperty(value = "This status field indicates the state of the sharing authorization record.")
  public StatusEnum getStatus() {
    return status;
  }

  public void setStatus(StatusEnum status) {
    this.status = status;
  }

  public MeetingSharing downloadable(Boolean downloadable) {
    this.downloadable = downloadable;
    return this;
  }

   /**
   * The downloadable field indicates whether the recording can be downloaded
   * @return downloadable
  **/
  @ApiModelProperty(value = "The downloadable field indicates whether the recording can be downloaded")
  public Boolean isDownloadable() {
    return downloadable;
  }

  public void setDownloadable(Boolean downloadable) {
    this.downloadable = downloadable;
  }

  public MeetingSharing passcode(String passcode) {
    this.passcode = passcode;
    return this;
  }

   /**
   * TBD
   * @return passcode
  **/
  @ApiModelProperty(value = "TBD")
  public String getPasscode() {
    return passcode;
  }

  public void setPasscode(String passcode) {
    this.passcode = passcode;
  }

  public MeetingSharing validity(String validity) {
    this.validity = validity;
    return this;
  }

   /**
   * TBD
   * @return validity
  **/
  @ApiModelProperty(value = "TBD")
  public String getValidity() {
    return validity;
  }

  public void setValidity(String validity) {
    this.validity = validity;
  }

  public MeetingSharing created(Integer created) {
    this.created = created;
    return this;
  }

   /**
   * Date, since epoch time, that the recording was created (in milliseconds).
   * @return created
  **/
  @ApiModelProperty(value = "Date, since epoch time, that the recording was created (in milliseconds).")
  public Integer getCreated() {
    return created;
  }

  public void setCreated(Integer created) {
    this.created = created;
  }

  public MeetingSharing lastmodified(Integer lastmodified) {
    this.lastmodified = lastmodified;
    return this;
  }

   /**
   * Date, since epoch time, that the recording was last modified (in milliseconds).
   * @return lastmodified
  **/
  @ApiModelProperty(value = "Date, since epoch time, that the recording was last modified (in milliseconds).")
  public Integer getLastmodified() {
    return lastmodified;
  }

  public void setLastmodified(Integer lastmodified) {
    this.lastmodified = lastmodified;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MeetingSharing meetingSharing = (MeetingSharing) o;
    return Objects.equals(this.id, meetingSharing.id) &&
        Objects.equals(this.meetingGuid, meetingSharing.meetingGuid) &&
        Objects.equals(this.ownerId, meetingSharing.ownerId) &&
        Objects.equals(this.sharingUrl, meetingSharing.sharingUrl) &&
        Objects.equals(this.recepientType, meetingSharing.recepientType) &&
        Objects.equals(this.properties, meetingSharing.properties) &&
        Objects.equals(this.status, meetingSharing.status) &&
        Objects.equals(this.downloadable, meetingSharing.downloadable) &&
        Objects.equals(this.passcode, meetingSharing.passcode) &&
        Objects.equals(this.validity, meetingSharing.validity) &&
        Objects.equals(this.created, meetingSharing.created) &&
        Objects.equals(this.lastmodified, meetingSharing.lastmodified);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, meetingGuid, ownerId, sharingUrl, recepientType, properties, status, downloadable, passcode, validity, created, lastmodified);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MeetingSharing {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    meetingGuid: ").append(toIndentedString(meetingGuid)).append("\n");
    sb.append("    ownerId: ").append(toIndentedString(ownerId)).append("\n");
    sb.append("    sharingUrl: ").append(toIndentedString(sharingUrl)).append("\n");
    sb.append("    recepientType: ").append(toIndentedString(recepientType)).append("\n");
    sb.append("    properties: ").append(toIndentedString(properties)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    downloadable: ").append(toIndentedString(downloadable)).append("\n");
    sb.append("    passcode: ").append(toIndentedString(passcode)).append("\n");
    sb.append("    validity: ").append(toIndentedString(validity)).append("\n");
    sb.append("    created: ").append(toIndentedString(created)).append("\n");
    sb.append("    lastmodified: ").append(toIndentedString(lastmodified)).append("\n");
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

