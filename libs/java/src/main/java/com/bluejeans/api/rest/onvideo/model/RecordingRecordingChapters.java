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
import com.bluejeans.api.rest.onvideo.model.RecordingRecordingSessions;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;

/**
 * RecordingRecordingChapters
 */

public class RecordingRecordingChapters {
  @SerializedName("chapterId")
  private String chapterId = null;

  @SerializedName("id")
  private Integer id = null;

  @SerializedName("startTimeOffset")
  private Integer startTimeOffset = null;

  @SerializedName("endTimeOffset")
  private Integer endTimeOffset = null;

  @SerializedName("chapterName")
  private String chapterName = null;

  @SerializedName("totalSize")
  private Integer totalSize = null;

  @SerializedName("compositeContentId")
  private Integer compositeContentId = null;

  @SerializedName("compositeContentStatus")
  private String compositeContentStatus = null;

  @SerializedName("parentRecordingId")
  private Integer parentRecordingId = null;

  @SerializedName("viewCount")
  private Integer viewCount = null;

  @SerializedName("recordingSessions")
  private List<RecordingRecordingSessions> recordingSessions = new ArrayList<RecordingRecordingSessions>();

  public RecordingRecordingChapters chapterId(String chapterId) {
    this.chapterId = chapterId;
    return this;
  }

   /**
   * Get chapterId
   * @return chapterId
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getChapterId() {
    return chapterId;
  }

  public void setChapterId(String chapterId) {
    this.chapterId = chapterId;
  }

  public RecordingRecordingChapters id(Integer id) {
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getId() {
    return id;
  }

  public void setId(Integer id) {
    this.id = id;
  }

  public RecordingRecordingChapters startTimeOffset(Integer startTimeOffset) {
    this.startTimeOffset = startTimeOffset;
    return this;
  }

   /**
   * Get startTimeOffset
   * @return startTimeOffset
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getStartTimeOffset() {
    return startTimeOffset;
  }

  public void setStartTimeOffset(Integer startTimeOffset) {
    this.startTimeOffset = startTimeOffset;
  }

  public RecordingRecordingChapters endTimeOffset(Integer endTimeOffset) {
    this.endTimeOffset = endTimeOffset;
    return this;
  }

   /**
   * Get endTimeOffset
   * @return endTimeOffset
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getEndTimeOffset() {
    return endTimeOffset;
  }

  public void setEndTimeOffset(Integer endTimeOffset) {
    this.endTimeOffset = endTimeOffset;
  }

  public RecordingRecordingChapters chapterName(String chapterName) {
    this.chapterName = chapterName;
    return this;
  }

   /**
   * Get chapterName
   * @return chapterName
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getChapterName() {
    return chapterName;
  }

  public void setChapterName(String chapterName) {
    this.chapterName = chapterName;
  }

  public RecordingRecordingChapters totalSize(Integer totalSize) {
    this.totalSize = totalSize;
    return this;
  }

   /**
   * Get totalSize
   * @return totalSize
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getTotalSize() {
    return totalSize;
  }

  public void setTotalSize(Integer totalSize) {
    this.totalSize = totalSize;
  }

  public RecordingRecordingChapters compositeContentId(Integer compositeContentId) {
    this.compositeContentId = compositeContentId;
    return this;
  }

   /**
   * Get compositeContentId
   * @return compositeContentId
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getCompositeContentId() {
    return compositeContentId;
  }

  public void setCompositeContentId(Integer compositeContentId) {
    this.compositeContentId = compositeContentId;
  }

  public RecordingRecordingChapters compositeContentStatus(String compositeContentStatus) {
    this.compositeContentStatus = compositeContentStatus;
    return this;
  }

   /**
   * Get compositeContentStatus
   * @return compositeContentStatus
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getCompositeContentStatus() {
    return compositeContentStatus;
  }

  public void setCompositeContentStatus(String compositeContentStatus) {
    this.compositeContentStatus = compositeContentStatus;
  }

  public RecordingRecordingChapters parentRecordingId(Integer parentRecordingId) {
    this.parentRecordingId = parentRecordingId;
    return this;
  }

   /**
   * Get parentRecordingId
   * @return parentRecordingId
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getParentRecordingId() {
    return parentRecordingId;
  }

  public void setParentRecordingId(Integer parentRecordingId) {
    this.parentRecordingId = parentRecordingId;
  }

  public RecordingRecordingChapters viewCount(Integer viewCount) {
    this.viewCount = viewCount;
    return this;
  }

   /**
   * Get viewCount
   * @return viewCount
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getViewCount() {
    return viewCount;
  }

  public void setViewCount(Integer viewCount) {
    this.viewCount = viewCount;
  }

  public RecordingRecordingChapters recordingSessions(List<RecordingRecordingSessions> recordingSessions) {
    this.recordingSessions = recordingSessions;
    return this;
  }

  public RecordingRecordingChapters addRecordingSessionsItem(RecordingRecordingSessions recordingSessionsItem) {
    this.recordingSessions.add(recordingSessionsItem);
    return this;
  }

   /**
   * Get recordingSessions
   * @return recordingSessions
  **/
  @ApiModelProperty(example = "null", value = "")
  public List<RecordingRecordingSessions> getRecordingSessions() {
    return recordingSessions;
  }

  public void setRecordingSessions(List<RecordingRecordingSessions> recordingSessions) {
    this.recordingSessions = recordingSessions;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RecordingRecordingChapters recordingRecordingChapters = (RecordingRecordingChapters) o;
    return Objects.equals(this.chapterId, recordingRecordingChapters.chapterId) &&
        Objects.equals(this.id, recordingRecordingChapters.id) &&
        Objects.equals(this.startTimeOffset, recordingRecordingChapters.startTimeOffset) &&
        Objects.equals(this.endTimeOffset, recordingRecordingChapters.endTimeOffset) &&
        Objects.equals(this.chapterName, recordingRecordingChapters.chapterName) &&
        Objects.equals(this.totalSize, recordingRecordingChapters.totalSize) &&
        Objects.equals(this.compositeContentId, recordingRecordingChapters.compositeContentId) &&
        Objects.equals(this.compositeContentStatus, recordingRecordingChapters.compositeContentStatus) &&
        Objects.equals(this.parentRecordingId, recordingRecordingChapters.parentRecordingId) &&
        Objects.equals(this.viewCount, recordingRecordingChapters.viewCount) &&
        Objects.equals(this.recordingSessions, recordingRecordingChapters.recordingSessions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(chapterId, id, startTimeOffset, endTimeOffset, chapterName, totalSize, compositeContentId, compositeContentStatus, parentRecordingId, viewCount, recordingSessions);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RecordingRecordingChapters {\n");
    
    sb.append("    chapterId: ").append(toIndentedString(chapterId)).append("\n");
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    startTimeOffset: ").append(toIndentedString(startTimeOffset)).append("\n");
    sb.append("    endTimeOffset: ").append(toIndentedString(endTimeOffset)).append("\n");
    sb.append("    chapterName: ").append(toIndentedString(chapterName)).append("\n");
    sb.append("    totalSize: ").append(toIndentedString(totalSize)).append("\n");
    sb.append("    compositeContentId: ").append(toIndentedString(compositeContentId)).append("\n");
    sb.append("    compositeContentStatus: ").append(toIndentedString(compositeContentStatus)).append("\n");
    sb.append("    parentRecordingId: ").append(toIndentedString(parentRecordingId)).append("\n");
    sb.append("    viewCount: ").append(toIndentedString(viewCount)).append("\n");
    sb.append("    recordingSessions: ").append(toIndentedString(recordingSessions)).append("\n");
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

