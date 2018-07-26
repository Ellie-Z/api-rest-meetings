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
    /// RecordingSession
    /// </summary>
    [DataContract]
    public partial class RecordingSession :  IEquatable<RecordingSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingSession" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contentStatus">contentStatus.</param>
        /// <param name="recordingType">recordingType.</param>
        /// <param name="contentId">contentId.</param>
        /// <param name="thumbnailUrl">thumbnailUrl.</param>
        /// <param name="startTimeOffset">startTimeOffset.</param>
        /// <param name="endTimeOffset">endTimeOffset.</param>
        /// <param name="duration">duration.</param>
        /// <param name="startedBy">startedBy.</param>
        /// <param name="stoppedBy">stoppedBy.</param>
        public RecordingSession(int? id = default(int?), string contentStatus = default(string), string recordingType = default(string), int? contentId = default(int?), string thumbnailUrl = default(string), int? startTimeOffset = default(int?), int? endTimeOffset = default(int?), int? duration = default(int?), RecordingSessionStartedBy startedBy = default(RecordingSessionStartedBy), RecordingSessionStartedBy stoppedBy = default(RecordingSessionStartedBy))
        {
            this.Id = id;
            this.ContentStatus = contentStatus;
            this.RecordingType = recordingType;
            this.ContentId = contentId;
            this.ThumbnailUrl = thumbnailUrl;
            this.StartTimeOffset = startTimeOffset;
            this.EndTimeOffset = endTimeOffset;
            this.Duration = duration;
            this.StartedBy = startedBy;
            this.StoppedBy = stoppedBy;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets ContentStatus
        /// </summary>
        [DataMember(Name="contentStatus", EmitDefaultValue=false)]
        public string ContentStatus { get; set; }

        /// <summary>
        /// Gets or Sets RecordingType
        /// </summary>
        [DataMember(Name="recordingType", EmitDefaultValue=false)]
        public string RecordingType { get; set; }

        /// <summary>
        /// Gets or Sets ContentId
        /// </summary>
        [DataMember(Name="contentId", EmitDefaultValue=false)]
        public int? ContentId { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailUrl
        /// </summary>
        [DataMember(Name="thumbnailUrl", EmitDefaultValue=false)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or Sets StartTimeOffset
        /// </summary>
        [DataMember(Name="startTimeOffset", EmitDefaultValue=false)]
        public int? StartTimeOffset { get; set; }

        /// <summary>
        /// Gets or Sets EndTimeOffset
        /// </summary>
        [DataMember(Name="endTimeOffset", EmitDefaultValue=false)]
        public int? EndTimeOffset { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or Sets StartedBy
        /// </summary>
        [DataMember(Name="startedBy", EmitDefaultValue=false)]
        public RecordingSessionStartedBy StartedBy { get; set; }

        /// <summary>
        /// Gets or Sets StoppedBy
        /// </summary>
        [DataMember(Name="stoppedBy", EmitDefaultValue=false)]
        public RecordingSessionStartedBy StoppedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContentStatus: ").Append(ContentStatus).Append("\n");
            sb.Append("  RecordingType: ").Append(RecordingType).Append("\n");
            sb.Append("  ContentId: ").Append(ContentId).Append("\n");
            sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  StartTimeOffset: ").Append(StartTimeOffset).Append("\n");
            sb.Append("  EndTimeOffset: ").Append(EndTimeOffset).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  StartedBy: ").Append(StartedBy).Append("\n");
            sb.Append("  StoppedBy: ").Append(StoppedBy).Append("\n");
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
            return this.Equals(input as RecordingSession);
        }

        /// <summary>
        /// Returns true if RecordingSession instances are equal
        /// </summary>
        /// <param name="input">Instance of RecordingSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ContentStatus == input.ContentStatus ||
                    (this.ContentStatus != null &&
                    this.ContentStatus.Equals(input.ContentStatus))
                ) && 
                (
                    this.RecordingType == input.RecordingType ||
                    (this.RecordingType != null &&
                    this.RecordingType.Equals(input.RecordingType))
                ) && 
                (
                    this.ContentId == input.ContentId ||
                    (this.ContentId != null &&
                    this.ContentId.Equals(input.ContentId))
                ) && 
                (
                    this.ThumbnailUrl == input.ThumbnailUrl ||
                    (this.ThumbnailUrl != null &&
                    this.ThumbnailUrl.Equals(input.ThumbnailUrl))
                ) && 
                (
                    this.StartTimeOffset == input.StartTimeOffset ||
                    (this.StartTimeOffset != null &&
                    this.StartTimeOffset.Equals(input.StartTimeOffset))
                ) && 
                (
                    this.EndTimeOffset == input.EndTimeOffset ||
                    (this.EndTimeOffset != null &&
                    this.EndTimeOffset.Equals(input.EndTimeOffset))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.StartedBy == input.StartedBy ||
                    (this.StartedBy != null &&
                    this.StartedBy.Equals(input.StartedBy))
                ) && 
                (
                    this.StoppedBy == input.StoppedBy ||
                    (this.StoppedBy != null &&
                    this.StoppedBy.Equals(input.StoppedBy))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ContentStatus != null)
                    hashCode = hashCode * 59 + this.ContentStatus.GetHashCode();
                if (this.RecordingType != null)
                    hashCode = hashCode * 59 + this.RecordingType.GetHashCode();
                if (this.ContentId != null)
                    hashCode = hashCode * 59 + this.ContentId.GetHashCode();
                if (this.ThumbnailUrl != null)
                    hashCode = hashCode * 59 + this.ThumbnailUrl.GetHashCode();
                if (this.StartTimeOffset != null)
                    hashCode = hashCode * 59 + this.StartTimeOffset.GetHashCode();
                if (this.EndTimeOffset != null)
                    hashCode = hashCode * 59 + this.EndTimeOffset.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.StartedBy != null)
                    hashCode = hashCode * 59 + this.StartedBy.GetHashCode();
                if (this.StoppedBy != null)
                    hashCode = hashCode * 59 + this.StoppedBy.GetHashCode();
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
