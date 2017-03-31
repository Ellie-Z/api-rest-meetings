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
import com.bluejeans.api.rest.onvideo.model.GrantPasswordScope;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;


/**
 * GrantPassword
 */

public class GrantPassword   {
  @SerializedName("access_token")
  private String accessToken = null;

  @SerializedName("expires_in")
  private Integer expiresIn = null;

  @SerializedName("refresh_token")
  private String refreshToken = null;

  @SerializedName("scope")
  private GrantPasswordScope scope = null;

  public GrantPassword accessToken(String accessToken) {
    this.accessToken = accessToken;
    return this;
  }

   /**
   * The access token acts as a kind of \"valet key\" that the application can include with its requests to the identity provider, which prove that it has permission from the user to access those APIs.
   * @return accessToken
  **/
  @ApiModelProperty(example = "null", value = "The access token acts as a kind of \"valet key\" that the application can include with its requests to the identity provider, which prove that it has permission from the user to access those APIs.")
  public String getAccessToken() {
    return accessToken;
  }

  public void setAccessToken(String accessToken) {
    this.accessToken = accessToken;
  }

  public GrantPassword expiresIn(Integer expiresIn) {
    this.expiresIn = expiresIn;
    return this;
  }

   /**
   * Seconds that access token is valid for from now.
   * @return expiresIn
  **/
  @ApiModelProperty(example = "null", value = "Seconds that access token is valid for from now.")
  public Integer getExpiresIn() {
    return expiresIn;
  }

  public void setExpiresIn(Integer expiresIn) {
    this.expiresIn = expiresIn;
  }

  public GrantPassword refreshToken(String refreshToken) {
    this.refreshToken = refreshToken;
    return this;
  }

   /**
   * Get refreshToken
   * @return refreshToken
  **/
  @ApiModelProperty(example = "null", value = "")
  public String getRefreshToken() {
    return refreshToken;
  }

  public void setRefreshToken(String refreshToken) {
    this.refreshToken = refreshToken;
  }

  public GrantPassword scope(GrantPasswordScope scope) {
    this.scope = scope;
    return this;
  }

   /**
   * Get scope
   * @return scope
  **/
  @ApiModelProperty(example = "null", value = "")
  public GrantPasswordScope getScope() {
    return scope;
  }

  public void setScope(GrantPasswordScope scope) {
    this.scope = scope;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GrantPassword grantPassword = (GrantPassword) o;
    return Objects.equals(this.accessToken, grantPassword.accessToken) &&
        Objects.equals(this.expiresIn, grantPassword.expiresIn) &&
        Objects.equals(this.refreshToken, grantPassword.refreshToken) &&
        Objects.equals(this.scope, grantPassword.scope);
  }

  @Override
  public int hashCode() {
    return Objects.hash(accessToken, expiresIn, refreshToken, scope);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GrantPassword {\n");
    
    sb.append("    accessToken: ").append(toIndentedString(accessToken)).append("\n");
    sb.append("    expiresIn: ").append(toIndentedString(expiresIn)).append("\n");
    sb.append("    refreshToken: ").append(toIndentedString(refreshToken)).append("\n");
    sb.append("    scope: ").append(toIndentedString(scope)).append("\n");
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

