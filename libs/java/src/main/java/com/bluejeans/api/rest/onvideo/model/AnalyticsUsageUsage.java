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
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;


/**
 * AnalyticsUsageUsage
 */

public class AnalyticsUsageUsage   {
  @SerializedName("endpointMinutes")
  private Integer endpointMinutes = null;

  @SerializedName("numEndpoints")
  private Integer numEndpoints = null;

  @SerializedName("numMeetings")
  private Integer numMeetings = null;

  @SerializedName("Date")
  private Integer date = null;

  public AnalyticsUsageUsage endpointMinutes(Integer endpointMinutes) {
    this.endpointMinutes = endpointMinutes;
    return this;
  }

   /**
   * Get endpointMinutes
   * @return endpointMinutes
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getEndpointMinutes() {
    return endpointMinutes;
  }

  public void setEndpointMinutes(Integer endpointMinutes) {
    this.endpointMinutes = endpointMinutes;
  }

  public AnalyticsUsageUsage numEndpoints(Integer numEndpoints) {
    this.numEndpoints = numEndpoints;
    return this;
  }

   /**
   * Get numEndpoints
   * @return numEndpoints
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getNumEndpoints() {
    return numEndpoints;
  }

  public void setNumEndpoints(Integer numEndpoints) {
    this.numEndpoints = numEndpoints;
  }

  public AnalyticsUsageUsage numMeetings(Integer numMeetings) {
    this.numMeetings = numMeetings;
    return this;
  }

   /**
   * Get numMeetings
   * @return numMeetings
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getNumMeetings() {
    return numMeetings;
  }

  public void setNumMeetings(Integer numMeetings) {
    this.numMeetings = numMeetings;
  }

  public AnalyticsUsageUsage date(Integer date) {
    this.date = date;
    return this;
  }

   /**
   * Get date
   * @return date
  **/
  @ApiModelProperty(example = "null", value = "")
  public Integer getDate() {
    return date;
  }

  public void setDate(Integer date) {
    this.date = date;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AnalyticsUsageUsage analyticsUsageUsage = (AnalyticsUsageUsage) o;
    return Objects.equals(this.endpointMinutes, analyticsUsageUsage.endpointMinutes) &&
        Objects.equals(this.numEndpoints, analyticsUsageUsage.numEndpoints) &&
        Objects.equals(this.numMeetings, analyticsUsageUsage.numMeetings) &&
        Objects.equals(this.date, analyticsUsageUsage.date);
  }

  @Override
  public int hashCode() {
    return Objects.hash(endpointMinutes, numEndpoints, numMeetings, date);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AnalyticsUsageUsage {\n");
    
    sb.append("    endpointMinutes: ").append(toIndentedString(endpointMinutes)).append("\n");
    sb.append("    numEndpoints: ").append(toIndentedString(numEndpoints)).append("\n");
    sb.append("    numMeetings: ").append(toIndentedString(numMeetings)).append("\n");
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
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

