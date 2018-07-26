/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/23/2018 </alert>Corrected errors in API definition file.<br/> 7/10/2018 Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.4407232018
 * Contact: glenn@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = com.bluejeans.api.rest.meetings.Client.SwaggerDateConverter;

namespace com.bluejeans.api.rest.meetings.Model
{
    /// <summary>
    /// MeetingHistoryParticipantList
    /// </summary>
    [DataContract]
    public partial class MeetingHistoryParticipantList :  IEquatable<MeetingHistoryParticipantList>, IValidatableObject
    {
        /// <summary>
        /// Defines DeviceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceTypeEnum
        {
            
            /// <summary>
            /// Enum Carmel for value: Carmel
            /// </summary>
            [EnumMember(Value = "Carmel")]
            Carmel = 1,
            
            /// <summary>
            /// Enum WebRTC for value: WebRTC
            /// </summary>
            [EnumMember(Value = "WebRTC")]
            WebRTC = 2
        }

        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name="deviceType", EmitDefaultValue=false)]
        public DeviceTypeEnum? DeviceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingHistoryParticipantList" /> class.
        /// </summary>
        /// <param name="endpointName">endpointName.</param>
        /// <param name="joinTime">joinTime.</param>
        /// <param name="minutes">minutes.</param>
        /// <param name="deviceType">deviceType.</param>
        /// <param name="email">email.</param>
        /// <param name="remoteAddress">remoteAddress.</param>
        /// <param name="isEncrypted">isEncrypted.</param>
        /// <param name="disconnectTime">disconnectTime.</param>
        /// <param name="isModerator">isModerator.</param>
        /// <param name="userId">userId.</param>
        /// <param name="tags">tags.</param>
        /// <param name="participantGuid">participantGuid.</param>
        public MeetingHistoryParticipantList(string endpointName = default(string), int? joinTime = default(int?), int? minutes = default(int?), DeviceTypeEnum? deviceType = default(DeviceTypeEnum?), string email = default(string), string remoteAddress = default(string), bool? isEncrypted = default(bool?), int? disconnectTime = default(int?), bool? isModerator = default(bool?), int? userId = default(int?), string tags = default(string), string participantGuid = default(string))
        {
            this.EndpointName = endpointName;
            this.JoinTime = joinTime;
            this.Minutes = minutes;
            this.DeviceType = deviceType;
            this.Email = email;
            this.RemoteAddress = remoteAddress;
            this.IsEncrypted = isEncrypted;
            this.DisconnectTime = disconnectTime;
            this.IsModerator = isModerator;
            this.UserId = userId;
            this.Tags = tags;
            this.ParticipantGuid = participantGuid;
        }
        
        /// <summary>
        /// Gets or Sets EndpointName
        /// </summary>
        [DataMember(Name="endpointName", EmitDefaultValue=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// Gets or Sets JoinTime
        /// </summary>
        [DataMember(Name="joinTime", EmitDefaultValue=false)]
        public int? JoinTime { get; set; }

        /// <summary>
        /// Gets or Sets Minutes
        /// </summary>
        [DataMember(Name="minutes", EmitDefaultValue=false)]
        public int? Minutes { get; set; }


        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets RemoteAddress
        /// </summary>
        [DataMember(Name="remoteAddress", EmitDefaultValue=false)]
        public string RemoteAddress { get; set; }

        /// <summary>
        /// Gets or Sets IsEncrypted
        /// </summary>
        [DataMember(Name="isEncrypted", EmitDefaultValue=false)]
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Gets or Sets DisconnectTime
        /// </summary>
        [DataMember(Name="disconnectTime", EmitDefaultValue=false)]
        public int? DisconnectTime { get; set; }

        /// <summary>
        /// Gets or Sets IsModerator
        /// </summary>
        [DataMember(Name="isModerator", EmitDefaultValue=false)]
        public bool? IsModerator { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or Sets ParticipantGuid
        /// </summary>
        [DataMember(Name="participantGuid", EmitDefaultValue=false)]
        public string ParticipantGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingHistoryParticipantList {\n");
            sb.Append("  EndpointName: ").Append(EndpointName).Append("\n");
            sb.Append("  JoinTime: ").Append(JoinTime).Append("\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  RemoteAddress: ").Append(RemoteAddress).Append("\n");
            sb.Append("  IsEncrypted: ").Append(IsEncrypted).Append("\n");
            sb.Append("  DisconnectTime: ").Append(DisconnectTime).Append("\n");
            sb.Append("  IsModerator: ").Append(IsModerator).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ParticipantGuid: ").Append(ParticipantGuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MeetingHistoryParticipantList);
        }

        /// <summary>
        /// Returns true if MeetingHistoryParticipantList instances are equal
        /// </summary>
        /// <param name="input">Instance of MeetingHistoryParticipantList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingHistoryParticipantList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndpointName == input.EndpointName ||
                    (this.EndpointName != null &&
                    this.EndpointName.Equals(input.EndpointName))
                ) && 
                (
                    this.JoinTime == input.JoinTime ||
                    (this.JoinTime != null &&
                    this.JoinTime.Equals(input.JoinTime))
                ) && 
                (
                    this.Minutes == input.Minutes ||
                    (this.Minutes != null &&
                    this.Minutes.Equals(input.Minutes))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.RemoteAddress == input.RemoteAddress ||
                    (this.RemoteAddress != null &&
                    this.RemoteAddress.Equals(input.RemoteAddress))
                ) && 
                (
                    this.IsEncrypted == input.IsEncrypted ||
                    (this.IsEncrypted != null &&
                    this.IsEncrypted.Equals(input.IsEncrypted))
                ) && 
                (
                    this.DisconnectTime == input.DisconnectTime ||
                    (this.DisconnectTime != null &&
                    this.DisconnectTime.Equals(input.DisconnectTime))
                ) && 
                (
                    this.IsModerator == input.IsModerator ||
                    (this.IsModerator != null &&
                    this.IsModerator.Equals(input.IsModerator))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.ParticipantGuid == input.ParticipantGuid ||
                    (this.ParticipantGuid != null &&
                    this.ParticipantGuid.Equals(input.ParticipantGuid))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EndpointName != null)
                    hashCode = hashCode * 59 + this.EndpointName.GetHashCode();
                if (this.JoinTime != null)
                    hashCode = hashCode * 59 + this.JoinTime.GetHashCode();
                if (this.Minutes != null)
                    hashCode = hashCode * 59 + this.Minutes.GetHashCode();
                if (this.DeviceType != null)
                    hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.RemoteAddress != null)
                    hashCode = hashCode * 59 + this.RemoteAddress.GetHashCode();
                if (this.IsEncrypted != null)
                    hashCode = hashCode * 59 + this.IsEncrypted.GetHashCode();
                if (this.DisconnectTime != null)
                    hashCode = hashCode * 59 + this.DisconnectTime.GetHashCode();
                if (this.IsModerator != null)
                    hashCode = hashCode * 59 + this.IsModerator.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ParticipantGuid != null)
                    hashCode = hashCode * 59 + this.ParticipantGuid.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
