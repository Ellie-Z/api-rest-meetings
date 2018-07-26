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
import com.bluejeans.api.rest.meetings.model.ContentContentProperties;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * Content
 */

public class Content {
  @SerializedName("id")
  private Integer id = null;

  @SerializedName("contentType")
  private String contentType = null;

  @SerializedName("contentDescription")
  private String contentDescription = null;

  @SerializedName("contentUrl")
  private String contentUrl = null;

  @SerializedName("userId")
  private Integer userId = null;

  @SerializedName("contentLocation")
  private String contentLocation = null;

  @SerializedName("created")
  private Integer created = null;

  @SerializedName("modified")
  private Integer modified = null;

  @SerializedName("contentStatus")
  private String contentStatus = null;

  @SerializedName("contentName")
  private String contentName = null;

  @SerializedName("contentCategory")
  private String contentCategory = null;

  @SerializedName("contentSize")
  private Integer contentSize = null;

  @SerializedName("contentDuration")
  private Integer contentDuration = null;

  @SerializedName("contentProperties")
  private ContentContentProperties contentProperties = null;

  public Content id(Integer id) {
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(value = "")
  public Integer getId() {
    return id;
  }

  public void setId(Integer id) {
    this.id = id;
  }

  public Content contentType(String contentType) {
    this.contentType = contentType;
    return this;
  }

   /**
   * Get contentType
   * @return contentType
  **/
  @ApiModelProperty(value = "")
  public String getContentType() {
    return contentType;
  }

  public void setContentType(String contentType) {
    this.contentType = contentType;
  }

  public Content contentDescription(String contentDescription) {
    this.contentDescription = contentDescription;
    return this;
  }

   /**
   * Get contentDescription
   * @return contentDescription
  **/
  @ApiModelProperty(value = "")
  public String getContentDescription() {
    return contentDescription;
  }

  public void setContentDescription(String contentDescription) {
    this.contentDescription = contentDescription;
  }

  public Content contentUrl(String contentUrl) {
    this.contentUrl = contentUrl;
    return this;
  }

   /**
   * Get contentUrl
   * @return contentUrl
  **/
  @ApiModelProperty(value = "")
  public String getContentUrl() {
    return contentUrl;
  }

  public void setContentUrl(String contentUrl) {
    this.contentUrl = contentUrl;
  }

  public Content userId(Integer userId) {
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

  public Content contentLocation(String contentLocation) {
    this.contentLocation = contentLocation;
    return this;
  }

   /**
   * Get contentLocation
   * @return contentLocation
  **/
  @ApiModelProperty(value = "")
  public String getContentLocation() {
    return contentLocation;
  }

  public void setContentLocation(String contentLocation) {
    this.contentLocation = contentLocation;
  }

  public Content created(Integer created) {
    this.created = created;
    return this;
  }

   /**
   * Get created
   * @return created
  **/
  @ApiModelProperty(value = "")
  public Integer getCreated() {
    return created;
  }

  public void setCreated(Integer created) {
    this.created = created;
  }

  public Content modified(Integer modified) {
    this.modified = modified;
    return this;
  }

   /**
   * Get modified
   * @return modified
  **/
  @ApiModelProperty(value = "")
  public Integer getModified() {
    return modified;
  }

  public void setModified(Integer modified) {
    this.modified = modified;
  }

  public Content contentStatus(String contentStatus) {
    this.contentStatus = contentStatus;
    return this;
  }

   /**
   * Get contentStatus
   * @return contentStatus
  **/
  @ApiModelProperty(value = "")
  public String getContentStatus() {
    return contentStatus;
  }

  public void setContentStatus(String contentStatus) {
    this.contentStatus = contentStatus;
  }

  public Content contentName(String contentName) {
    this.contentName = contentName;
    return this;
  }

   /**
   * Get contentName
   * @return contentName
  **/
  @ApiModelProperty(value = "")
  public String getContentName() {
    return contentName;
  }

  public void setContentName(String contentName) {
    this.contentName = contentName;
  }

  public Content contentCategory(String contentCategory) {
    this.contentCategory = contentCategory;
    return this;
  }

   /**
   * Get contentCategory
   * @return contentCategory
  **/
  @ApiModelProperty(value = "")
  public String getContentCategory() {
    return contentCategory;
  }

  public void setContentCategory(String contentCategory) {
    this.contentCategory = contentCategory;
  }

  public Content contentSize(Integer contentSize) {
    this.contentSize = contentSize;
    return this;
  }

   /**
   * Get contentSize
   * @return contentSize
  **/
  @ApiModelProperty(value = "")
  public Integer getContentSize() {
    return contentSize;
  }

  public void setContentSize(Integer contentSize) {
    this.contentSize = contentSize;
  }

  public Content contentDuration(Integer contentDuration) {
    this.contentDuration = contentDuration;
    return this;
  }

   /**
   * Get contentDuration
   * @return contentDuration
  **/
  @ApiModelProperty(value = "")
  public Integer getContentDuration() {
    return contentDuration;
  }

  public void setContentDuration(Integer contentDuration) {
    this.contentDuration = contentDuration;
  }

  public Content contentProperties(ContentContentProperties contentProperties) {
    this.contentProperties = contentProperties;
    return this;
  }

   /**
   * Get contentProperties
   * @return contentProperties
  **/
  @ApiModelProperty(value = "")
  public ContentContentProperties getContentProperties() {
    return contentProperties;
  }

  public void setContentProperties(ContentContentProperties contentProperties) {
    this.contentProperties = contentProperties;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Content content = (Content) o;
    return Objects.equals(this.id, content.id) &&
        Objects.equals(this.contentType, content.contentType) &&
        Objects.equals(this.contentDescription, content.contentDescription) &&
        Objects.equals(this.contentUrl, content.contentUrl) &&
        Objects.equals(this.userId, content.userId) &&
        Objects.equals(this.contentLocation, content.contentLocation) &&
        Objects.equals(this.created, content.created) &&
        Objects.equals(this.modified, content.modified) &&
        Objects.equals(this.contentStatus, content.contentStatus) &&
        Objects.equals(this.contentName, content.contentName) &&
        Objects.equals(this.contentCategory, content.contentCategory) &&
        Objects.equals(this.contentSize, content.contentSize) &&
        Objects.equals(this.contentDuration, content.contentDuration) &&
        Objects.equals(this.contentProperties, content.contentProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, contentType, contentDescription, contentUrl, userId, contentLocation, created, modified, contentStatus, contentName, contentCategory, contentSize, contentDuration, contentProperties);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Content {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    contentType: ").append(toIndentedString(contentType)).append("\n");
    sb.append("    contentDescription: ").append(toIndentedString(contentDescription)).append("\n");
    sb.append("    contentUrl: ").append(toIndentedString(contentUrl)).append("\n");
    sb.append("    userId: ").append(toIndentedString(userId)).append("\n");
    sb.append("    contentLocation: ").append(toIndentedString(contentLocation)).append("\n");
    sb.append("    created: ").append(toIndentedString(created)).append("\n");
    sb.append("    modified: ").append(toIndentedString(modified)).append("\n");
    sb.append("    contentStatus: ").append(toIndentedString(contentStatus)).append("\n");
    sb.append("    contentName: ").append(toIndentedString(contentName)).append("\n");
    sb.append("    contentCategory: ").append(toIndentedString(contentCategory)).append("\n");
    sb.append("    contentSize: ").append(toIndentedString(contentSize)).append("\n");
    sb.append("    contentDuration: ").append(toIndentedString(contentDuration)).append("\n");
    sb.append("    contentProperties: ").append(toIndentedString(contentProperties)).append("\n");
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

