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
    /// MeetingAdvancedMeetingOptions
    /// </summary>
    [DataContract]
    public partial class MeetingAdvancedMeetingOptions :  IEquatable<MeetingAdvancedMeetingOptions>, IValidatableObject
    {
        /// <summary>
        /// Defines EncryptionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EncryptionTypeEnum
        {
            
            /// <summary>
            /// Enum NOENCRYPTION for value: NO_ENCRYPTION
            /// </summary>
            [EnumMember(Value = "NO_ENCRYPTION")]
            NOENCRYPTION = 1,
            
            /// <summary>
            /// Enum ENCRYPTEDONLY for value: ENCRYPTED_ONLY
            /// </summary>
            [EnumMember(Value = "ENCRYPTED_ONLY")]
            ENCRYPTEDONLY = 2,
            
            /// <summary>
            /// Enum ENCRYPTEDORPSTNONLY for value: ENCRYPTED_OR_PSTN_ONLY
            /// </summary>
            [EnumMember(Value = "ENCRYPTED_OR_PSTN_ONLY")]
            ENCRYPTEDORPSTNONLY = 3
        }

        /// <summary>
        /// Gets or Sets EncryptionType
        /// </summary>
        [DataMember(Name="encryptionType", EmitDefaultValue=false)]
        public EncryptionTypeEnum? EncryptionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingAdvancedMeetingOptions" /> class.
        /// </summary>
        /// <param name="videoBestFit">videoBestFit.</param>
        /// <param name="publishMeeting">publishMeeting.</param>
        /// <param name="encryptionType">encryptionType.</param>
        /// <param name="moderatorLess">moderatorLess.</param>
        /// <param name="allowStream">allowStream.</param>
        /// <param name="autoRecord">autoRecord.</param>
        /// <param name="disallowChat">disallowChat.</param>
        /// <param name="muteParticipantsOnEntry">muteParticipantsOnEntry.</param>
        /// <param name="showAllAttendeesInMeetingInvite">showAllAttendeesInMeetingInvite.</param>
        /// <param name="editability">editability.</param>
        public MeetingAdvancedMeetingOptions(bool? videoBestFit = default(bool?), bool? publishMeeting = default(bool?), EncryptionTypeEnum? encryptionType = default(EncryptionTypeEnum?), bool? moderatorLess = default(bool?), bool? allowStream = default(bool?), bool? autoRecord = default(bool?), bool? disallowChat = default(bool?), bool? muteParticipantsOnEntry = default(bool?), bool? showAllAttendeesInMeetingInvite = default(bool?), MeetingAdvancedMeetingOptionsEditability editability = default(MeetingAdvancedMeetingOptionsEditability))
        {
            this.VideoBestFit = videoBestFit;
            this.PublishMeeting = publishMeeting;
            this.EncryptionType = encryptionType;
            this.ModeratorLess = moderatorLess;
            this.AllowStream = allowStream;
            this.AutoRecord = autoRecord;
            this.DisallowChat = disallowChat;
            this.MuteParticipantsOnEntry = muteParticipantsOnEntry;
            this.ShowAllAttendeesInMeetingInvite = showAllAttendeesInMeetingInvite;
            this.Editability = editability;
        }
        
        /// <summary>
        /// Gets or Sets VideoBestFit
        /// </summary>
        [DataMember(Name="videoBestFit", EmitDefaultValue=false)]
        public bool? VideoBestFit { get; set; }

        /// <summary>
        /// Gets or Sets PublishMeeting
        /// </summary>
        [DataMember(Name="publishMeeting", EmitDefaultValue=false)]
        public bool? PublishMeeting { get; set; }


        /// <summary>
        /// Gets or Sets ModeratorLess
        /// </summary>
        [DataMember(Name="moderatorLess", EmitDefaultValue=false)]
        public bool? ModeratorLess { get; set; }

        /// <summary>
        /// Gets or Sets AllowStream
        /// </summary>
        [DataMember(Name="allowStream", EmitDefaultValue=false)]
        public bool? AllowStream { get; set; }

        /// <summary>
        /// Gets or Sets AutoRecord
        /// </summary>
        [DataMember(Name="autoRecord", EmitDefaultValue=false)]
        public bool? AutoRecord { get; set; }

        /// <summary>
        /// Gets or Sets DisallowChat
        /// </summary>
        [DataMember(Name="disallowChat", EmitDefaultValue=false)]
        public bool? DisallowChat { get; set; }

        /// <summary>
        /// Gets or Sets MuteParticipantsOnEntry
        /// </summary>
        [DataMember(Name="muteParticipantsOnEntry", EmitDefaultValue=false)]
        public bool? MuteParticipantsOnEntry { get; set; }

        /// <summary>
        /// Gets or Sets ShowAllAttendeesInMeetingInvite
        /// </summary>
        [DataMember(Name="showAllAttendeesInMeetingInvite", EmitDefaultValue=false)]
        public bool? ShowAllAttendeesInMeetingInvite { get; set; }

        /// <summary>
        /// Gets or Sets Editability
        /// </summary>
        [DataMember(Name="editability", EmitDefaultValue=false)]
        public MeetingAdvancedMeetingOptionsEditability Editability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingAdvancedMeetingOptions {\n");
            sb.Append("  VideoBestFit: ").Append(VideoBestFit).Append("\n");
            sb.Append("  PublishMeeting: ").Append(PublishMeeting).Append("\n");
            sb.Append("  EncryptionType: ").Append(EncryptionType).Append("\n");
            sb.Append("  ModeratorLess: ").Append(ModeratorLess).Append("\n");
            sb.Append("  AllowStream: ").Append(AllowStream).Append("\n");
            sb.Append("  AutoRecord: ").Append(AutoRecord).Append("\n");
            sb.Append("  DisallowChat: ").Append(DisallowChat).Append("\n");
            sb.Append("  MuteParticipantsOnEntry: ").Append(MuteParticipantsOnEntry).Append("\n");
            sb.Append("  ShowAllAttendeesInMeetingInvite: ").Append(ShowAllAttendeesInMeetingInvite).Append("\n");
            sb.Append("  Editability: ").Append(Editability).Append("\n");
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
            return this.Equals(input as MeetingAdvancedMeetingOptions);
        }

        /// <summary>
        /// Returns true if MeetingAdvancedMeetingOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of MeetingAdvancedMeetingOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingAdvancedMeetingOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VideoBestFit == input.VideoBestFit ||
                    (this.VideoBestFit != null &&
                    this.VideoBestFit.Equals(input.VideoBestFit))
                ) && 
                (
                    this.PublishMeeting == input.PublishMeeting ||
                    (this.PublishMeeting != null &&
                    this.PublishMeeting.Equals(input.PublishMeeting))
                ) && 
                (
                    this.EncryptionType == input.EncryptionType ||
                    (this.EncryptionType != null &&
                    this.EncryptionType.Equals(input.EncryptionType))
                ) && 
                (
                    this.ModeratorLess == input.ModeratorLess ||
                    (this.ModeratorLess != null &&
                    this.ModeratorLess.Equals(input.ModeratorLess))
                ) && 
                (
                    this.AllowStream == input.AllowStream ||
                    (this.AllowStream != null &&
                    this.AllowStream.Equals(input.AllowStream))
                ) && 
                (
                    this.AutoRecord == input.AutoRecord ||
                    (this.AutoRecord != null &&
                    this.AutoRecord.Equals(input.AutoRecord))
                ) && 
                (
                    this.DisallowChat == input.DisallowChat ||
                    (this.DisallowChat != null &&
                    this.DisallowChat.Equals(input.DisallowChat))
                ) && 
                (
                    this.MuteParticipantsOnEntry == input.MuteParticipantsOnEntry ||
                    (this.MuteParticipantsOnEntry != null &&
                    this.MuteParticipantsOnEntry.Equals(input.MuteParticipantsOnEntry))
                ) && 
                (
                    this.ShowAllAttendeesInMeetingInvite == input.ShowAllAttendeesInMeetingInvite ||
                    (this.ShowAllAttendeesInMeetingInvite != null &&
                    this.ShowAllAttendeesInMeetingInvite.Equals(input.ShowAllAttendeesInMeetingInvite))
                ) && 
                (
                    this.Editability == input.Editability ||
                    (this.Editability != null &&
                    this.Editability.Equals(input.Editability))
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
                if (this.VideoBestFit != null)
                    hashCode = hashCode * 59 + this.VideoBestFit.GetHashCode();
                if (this.PublishMeeting != null)
                    hashCode = hashCode * 59 + this.PublishMeeting.GetHashCode();
                if (this.EncryptionType != null)
                    hashCode = hashCode * 59 + this.EncryptionType.GetHashCode();
                if (this.ModeratorLess != null)
                    hashCode = hashCode * 59 + this.ModeratorLess.GetHashCode();
                if (this.AllowStream != null)
                    hashCode = hashCode * 59 + this.AllowStream.GetHashCode();
                if (this.AutoRecord != null)
                    hashCode = hashCode * 59 + this.AutoRecord.GetHashCode();
                if (this.DisallowChat != null)
                    hashCode = hashCode * 59 + this.DisallowChat.GetHashCode();
                if (this.MuteParticipantsOnEntry != null)
                    hashCode = hashCode * 59 + this.MuteParticipantsOnEntry.GetHashCode();
                if (this.ShowAllAttendeesInMeetingInvite != null)
                    hashCode = hashCode * 59 + this.ShowAllAttendeesInMeetingInvite.GetHashCode();
                if (this.Editability != null)
                    hashCode = hashCode * 59 + this.Editability.GetHashCode();
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
