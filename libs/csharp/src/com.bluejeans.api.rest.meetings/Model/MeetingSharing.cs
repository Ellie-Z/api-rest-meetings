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
    /// MeetingSharing
    /// </summary>
    [DataContract]
    public partial class MeetingSharing :  IEquatable<MeetingSharing>, IValidatableObject
    {
        /// <summary>
        /// This status field indicates the state of the sharing authorization record.
        /// </summary>
        /// <value>This status field indicates the state of the sharing authorization record.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,
            
            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 2
        }

        /// <summary>
        /// This status field indicates the state of the sharing authorization record.
        /// </summary>
        /// <value>This status field indicates the state of the sharing authorization record.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingSharing" /> class.
        /// </summary>
        /// <param name="id">This field is the Sharing Authorization unique identifier..</param>
        /// <param name="meetingGuid">The meetingGuid is a globally unique Id for this particular recording. It is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 6 alphanumeric segments separated by dashes..</param>
        /// <param name="ownerId">The ownerId field is the unique Id number of the BlueJeans account that owns the recording.</param>
        /// <param name="sharingUrl">sharingUrl.</param>
        /// <param name="recepientType">recepientType.</param>
        /// <param name="properties">properties.</param>
        /// <param name="status">This status field indicates the state of the sharing authorization record..</param>
        /// <param name="downloadable">The downloadable field indicates whether the recording can be downloaded.</param>
        /// <param name="passcode">TBD.</param>
        /// <param name="validity">TBD.</param>
        /// <param name="created">Date, since epoch time, that the recording was created (in milliseconds)..</param>
        /// <param name="lastmodified">Date, since epoch time, that the recording was last modified (in milliseconds)..</param>
        public MeetingSharing(int? id = default(int?), string meetingGuid = default(string), int? ownerId = default(int?), string sharingUrl = default(string), RecepientOptionsComp recepientType = default(RecepientOptionsComp), MeetingSharingProperties properties = default(MeetingSharingProperties), StatusEnum? status = default(StatusEnum?), bool? downloadable = default(bool?), string passcode = default(string), string validity = default(string), int? created = default(int?), int? lastmodified = default(int?))
        {
            this.Id = id;
            this.MeetingGuid = meetingGuid;
            this.OwnerId = ownerId;
            this.SharingUrl = sharingUrl;
            this.RecepientType = recepientType;
            this.Properties = properties;
            this.Status = status;
            this.Downloadable = downloadable;
            this.Passcode = passcode;
            this.Validity = validity;
            this.Created = created;
            this.Lastmodified = lastmodified;
        }
        
        /// <summary>
        /// This field is the Sharing Authorization unique identifier.
        /// </summary>
        /// <value>This field is the Sharing Authorization unique identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The meetingGuid is a globally unique Id for this particular recording. It is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 6 alphanumeric segments separated by dashes.
        /// </summary>
        /// <value>The meetingGuid is a globally unique Id for this particular recording. It is a string which contains the numeric meeting id, followed by a colon, followed by a 128-bit integer number formatted as 6 alphanumeric segments separated by dashes.</value>
        [DataMember(Name="meetingGuid", EmitDefaultValue=false)]
        public string MeetingGuid { get; set; }

        /// <summary>
        /// The ownerId field is the unique Id number of the BlueJeans account that owns the recording
        /// </summary>
        /// <value>The ownerId field is the unique Id number of the BlueJeans account that owns the recording</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets SharingUrl
        /// </summary>
        [DataMember(Name="sharingUrl", EmitDefaultValue=false)]
        public string SharingUrl { get; set; }

        /// <summary>
        /// Gets or Sets RecepientType
        /// </summary>
        [DataMember(Name="recepientType", EmitDefaultValue=false)]
        public RecepientOptionsComp RecepientType { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public MeetingSharingProperties Properties { get; set; }


        /// <summary>
        /// The downloadable field indicates whether the recording can be downloaded
        /// </summary>
        /// <value>The downloadable field indicates whether the recording can be downloaded</value>
        [DataMember(Name="downloadable", EmitDefaultValue=false)]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="passcode", EmitDefaultValue=false)]
        public string Passcode { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="validity", EmitDefaultValue=false)]
        public string Validity { get; set; }

        /// <summary>
        /// Date, since epoch time, that the recording was created (in milliseconds).
        /// </summary>
        /// <value>Date, since epoch time, that the recording was created (in milliseconds).</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public int? Created { get; set; }

        /// <summary>
        /// Date, since epoch time, that the recording was last modified (in milliseconds).
        /// </summary>
        /// <value>Date, since epoch time, that the recording was last modified (in milliseconds).</value>
        [DataMember(Name="lastmodified", EmitDefaultValue=false)]
        public int? Lastmodified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingSharing {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MeetingGuid: ").Append(MeetingGuid).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  SharingUrl: ").Append(SharingUrl).Append("\n");
            sb.Append("  RecepientType: ").Append(RecepientType).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Downloadable: ").Append(Downloadable).Append("\n");
            sb.Append("  Passcode: ").Append(Passcode).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Lastmodified: ").Append(Lastmodified).Append("\n");
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
            return this.Equals(input as MeetingSharing);
        }

        /// <summary>
        /// Returns true if MeetingSharing instances are equal
        /// </summary>
        /// <param name="input">Instance of MeetingSharing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingSharing input)
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
                    this.MeetingGuid == input.MeetingGuid ||
                    (this.MeetingGuid != null &&
                    this.MeetingGuid.Equals(input.MeetingGuid))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.SharingUrl == input.SharingUrl ||
                    (this.SharingUrl != null &&
                    this.SharingUrl.Equals(input.SharingUrl))
                ) && 
                (
                    this.RecepientType == input.RecepientType ||
                    (this.RecepientType != null &&
                    this.RecepientType.Equals(input.RecepientType))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Downloadable == input.Downloadable ||
                    (this.Downloadable != null &&
                    this.Downloadable.Equals(input.Downloadable))
                ) && 
                (
                    this.Passcode == input.Passcode ||
                    (this.Passcode != null &&
                    this.Passcode.Equals(input.Passcode))
                ) && 
                (
                    this.Validity == input.Validity ||
                    (this.Validity != null &&
                    this.Validity.Equals(input.Validity))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Lastmodified == input.Lastmodified ||
                    (this.Lastmodified != null &&
                    this.Lastmodified.Equals(input.Lastmodified))
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
                if (this.MeetingGuid != null)
                    hashCode = hashCode * 59 + this.MeetingGuid.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.SharingUrl != null)
                    hashCode = hashCode * 59 + this.SharingUrl.GetHashCode();
                if (this.RecepientType != null)
                    hashCode = hashCode * 59 + this.RecepientType.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Downloadable != null)
                    hashCode = hashCode * 59 + this.Downloadable.GetHashCode();
                if (this.Passcode != null)
                    hashCode = hashCode * 59 + this.Passcode.GetHashCode();
                if (this.Validity != null)
                    hashCode = hashCode * 59 + this.Validity.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Lastmodified != null)
                    hashCode = hashCode * 59 + this.Lastmodified.GetHashCode();
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
