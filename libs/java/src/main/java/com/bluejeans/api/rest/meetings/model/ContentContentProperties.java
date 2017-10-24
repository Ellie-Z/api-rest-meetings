/*
 * BlueJeans Meetings REST API
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.bluejeans.api.rest.meetings.model;

import java.util.Objects;
import com.bluejeans.api.rest.meetings.model.ContentContentPropertiesLevels;
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
 * ContentContentProperties
 */

public class ContentContentProperties {
  @SerializedName("duration")
  private Integer duration = null;

  @SerializedName("thumbnail")
  private String thumbnail = null;

  @SerializedName("thumbnailSprite")
  private String thumbnailSprite = null;

  @SerializedName("hdsUrl")
  private String hdsUrl = null;

  @SerializedName("thumbnailCount")
  private Integer thumbnailCount = null;

  @SerializedName("thumbnailWidth")
  private Integer thumbnailWidth = null;

  @SerializedName("thumbnailHeight")
  private Integer thumbnailHeight = null;

  @SerializedName("thumbnailInterval")
  private Integer thumbnailInterval = null;

  @SerializedName("hlsUrl")
  private String hlsUrl = null;

  @SerializedName("levels")
  private List<ContentContentPropertiesLevels> levels = null;

  public ContentContentProperties duration(Integer duration) {
    this.duration = duration;
    return this;
  }

   /**
   * Get duration
   * @return duration
  **/
  @ApiModelProperty(value = "")
  public Integer getDuration() {
    return duration;
  }

  public void setDuration(Integer duration) {
    this.duration = duration;
  }

  public ContentContentProperties thumbnail(String thumbnail) {
    this.thumbnail = thumbnail;
    return this;
  }

   /**
   * Get thumbnail
   * @return thumbnail
  **/
  @ApiModelProperty(value = "")
  public String getThumbnail() {
    return thumbnail;
  }

  public void setThumbnail(String thumbnail) {
    this.thumbnail = thumbnail;
  }

  public ContentContentProperties thumbnailSprite(String thumbnailSprite) {
    this.thumbnailSprite = thumbnailSprite;
    return this;
  }

   /**
   * Get thumbnailSprite
   * @return thumbnailSprite
  **/
  @ApiModelProperty(value = "")
  public String getThumbnailSprite() {
    return thumbnailSprite;
  }

  public void setThumbnailSprite(String thumbnailSprite) {
    this.thumbnailSprite = thumbnailSprite;
  }

  public ContentContentProperties hdsUrl(String hdsUrl) {
    this.hdsUrl = hdsUrl;
    return this;
  }

   /**
   * Get hdsUrl
   * @return hdsUrl
  **/
  @ApiModelProperty(value = "")
  public String getHdsUrl() {
    return hdsUrl;
  }

  public void setHdsUrl(String hdsUrl) {
    this.hdsUrl = hdsUrl;
  }

  public ContentContentProperties thumbnailCount(Integer thumbnailCount) {
    this.thumbnailCount = thumbnailCount;
    return this;
  }

   /**
   * Get thumbnailCount
   * @return thumbnailCount
  **/
  @ApiModelProperty(value = "")
  public Integer getThumbnailCount() {
    return thumbnailCount;
  }

  public void setThumbnailCount(Integer thumbnailCount) {
    this.thumbnailCount = thumbnailCount;
  }

  public ContentContentProperties thumbnailWidth(Integer thumbnailWidth) {
    this.thumbnailWidth = thumbnailWidth;
    return this;
  }

   /**
   * Get thumbnailWidth
   * @return thumbnailWidth
  **/
  @ApiModelProperty(value = "")
  public Integer getThumbnailWidth() {
    return thumbnailWidth;
  }

  public void setThumbnailWidth(Integer thumbnailWidth) {
    this.thumbnailWidth = thumbnailWidth;
  }

  public ContentContentProperties thumbnailHeight(Integer thumbnailHeight) {
    this.thumbnailHeight = thumbnailHeight;
    return this;
  }

   /**
   * Get thumbnailHeight
   * @return thumbnailHeight
  **/
  @ApiModelProperty(value = "")
  public Integer getThumbnailHeight() {
    return thumbnailHeight;
  }

  public void setThumbnailHeight(Integer thumbnailHeight) {
    this.thumbnailHeight = thumbnailHeight;
  }

  public ContentContentProperties thumbnailInterval(Integer thumbnailInterval) {
    this.thumbnailInterval = thumbnailInterval;
    return this;
  }

   /**
   * Get thumbnailInterval
   * @return thumbnailInterval
  **/
  @ApiModelProperty(value = "")
  public Integer getThumbnailInterval() {
    return thumbnailInterval;
  }

  public void setThumbnailInterval(Integer thumbnailInterval) {
    this.thumbnailInterval = thumbnailInterval;
  }

  public ContentContentProperties hlsUrl(String hlsUrl) {
    this.hlsUrl = hlsUrl;
    return this;
  }

   /**
   * Get hlsUrl
   * @return hlsUrl
  **/
  @ApiModelProperty(value = "")
  public String getHlsUrl() {
    return hlsUrl;
  }

  public void setHlsUrl(String hlsUrl) {
    this.hlsUrl = hlsUrl;
  }

  public ContentContentProperties levels(List<ContentContentPropertiesLevels> levels) {
    this.levels = levels;
    return this;
  }

  public ContentContentProperties addLevelsItem(ContentContentPropertiesLevels levelsItem) {
    if (this.levels == null) {
      this.levels = new ArrayList<ContentContentPropertiesLevels>();
    }
    this.levels.add(levelsItem);
    return this;
  }

   /**
   * Get levels
   * @return levels
  **/
  @ApiModelProperty(value = "")
  public List<ContentContentPropertiesLevels> getLevels() {
    return levels;
  }

  public void setLevels(List<ContentContentPropertiesLevels> levels) {
    this.levels = levels;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ContentContentProperties contentContentProperties = (ContentContentProperties) o;
    return Objects.equals(this.duration, contentContentProperties.duration) &&
        Objects.equals(this.thumbnail, contentContentProperties.thumbnail) &&
        Objects.equals(this.thumbnailSprite, contentContentProperties.thumbnailSprite) &&
        Objects.equals(this.hdsUrl, contentContentProperties.hdsUrl) &&
        Objects.equals(this.thumbnailCount, contentContentProperties.thumbnailCount) &&
        Objects.equals(this.thumbnailWidth, contentContentProperties.thumbnailWidth) &&
        Objects.equals(this.thumbnailHeight, contentContentProperties.thumbnailHeight) &&
        Objects.equals(this.thumbnailInterval, contentContentProperties.thumbnailInterval) &&
        Objects.equals(this.hlsUrl, contentContentProperties.hlsUrl) &&
        Objects.equals(this.levels, contentContentProperties.levels);
  }

  @Override
  public int hashCode() {
    return Objects.hash(duration, thumbnail, thumbnailSprite, hdsUrl, thumbnailCount, thumbnailWidth, thumbnailHeight, thumbnailInterval, hlsUrl, levels);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ContentContentProperties {\n");
    
    sb.append("    duration: ").append(toIndentedString(duration)).append("\n");
    sb.append("    thumbnail: ").append(toIndentedString(thumbnail)).append("\n");
    sb.append("    thumbnailSprite: ").append(toIndentedString(thumbnailSprite)).append("\n");
    sb.append("    hdsUrl: ").append(toIndentedString(hdsUrl)).append("\n");
    sb.append("    thumbnailCount: ").append(toIndentedString(thumbnailCount)).append("\n");
    sb.append("    thumbnailWidth: ").append(toIndentedString(thumbnailWidth)).append("\n");
    sb.append("    thumbnailHeight: ").append(toIndentedString(thumbnailHeight)).append("\n");
    sb.append("    thumbnailInterval: ").append(toIndentedString(thumbnailInterval)).append("\n");
    sb.append("    hlsUrl: ").append(toIndentedString(hlsUrl)).append("\n");
    sb.append("    levels: ").append(toIndentedString(levels)).append("\n");
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

