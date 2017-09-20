/* 
 * BlueJeans onVideo REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by an access code.  THe access code can ensure security of participants who can join, and also designate user(s) who need an ability to moderate a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>, and may be assigned a moderator passcode allowing designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About onVideo Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
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
using SwaggerDateConverter = com.bluejeans.api.rest.onvideo.Client.SwaggerDateConverter;

namespace com.bluejeans.api.rest.onvideo.Model
{
    /// <summary>
    /// MeetingIndigo
    /// </summary>
    [DataContract]
    public partial class MeetingIndigo :  IEquatable<MeetingIndigo>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ScheduledFrom
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScheduledFromEnum
        {
            
            /// <summary>
            /// Enum APP for "WEB_APP"
            /// </summary>
            [EnumMember(Value = "WEB_APP")]
            APP
        }

        /// <summary>
        /// Gets or Sets ScheduledFrom
        /// </summary>
        [DataMember(Name="scheduledFrom", EmitDefaultValue=false)]
        public ScheduledFromEnum? ScheduledFrom { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingIndigo" /> class.
        /// </summary>
        /// <param name="MeetingId">This is the same as the numericMeetingId found elsewhere. We should have been more consistent..</param>
        /// <param name="MeetingUUID">The universally unique identifier (UUID) of the meeting. This value is a string which contains 6 alphanumeric segments separated by dashes..</param>
        /// <param name="UserName">UserName.</param>
        /// <param name="Email">Email.</param>
        /// <param name="EncryptionType">EncryptionType.</param>
        /// <param name="Title">Title.</param>
        /// <param name="UserFullName">UserFullName.</param>
        /// <param name="PhoneNumber">PhoneNumber.</param>
        /// <param name="UserFeatures">UserFeatures.</param>
        /// <param name="ScheduledFrom">ScheduledFrom.</param>
        /// <param name="InviteeCount">InviteeCount.</param>
        /// <param name="Personal">Personal.</param>
        /// <param name="MuteOnEntry">MuteOnEntry.</param>
        /// <param name="AutoRecord">AutoRecord.</param>
        /// <param name="EnterpriseName">EnterpriseName.</param>
        /// <param name="ModeratorLess">ModeratorLess.</param>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="EndTime">EndTime.</param>
        /// <param name="TotalCallSeconds">TotalCallSeconds.</param>
        /// <param name="CreateTime">CreateTime.</param>
        /// <param name="EndpointsCount">EndpointsCount.</param>
        /// <param name="ConcurrentEndpoints">ConcurrentEndpoints.</param>
        /// <param name="LiveVisibleEndpointsCount">LiveVisibleEndpointsCount.</param>
        /// <param name="QualarooRating">QualarooRating.</param>
        /// <param name="QualarooCount">QualarooCount.</param>
        /// <param name="MeetingRecording">MeetingRecording.</param>
        /// <param name="VideoShare">VideoShare.</param>
        /// <param name="ContentShare">ContentShare.</param>
        /// <param name="LiveRecording">LiveRecording.</param>
        /// <param name="LiveVideoShare">LiveVideoShare.</param>
        /// <param name="LiveContentShare">LiveContentShare.</param>
        /// <param name="LargeMeeting">LargeMeeting.</param>
        /// <param name="RoiDistance">RoiDistance.</param>
        /// <param name="Mpls">Mpls.</param>
        /// <param name="Id">Same as the meetingUUID property in this object..</param>
        public MeetingIndigo(string MeetingId = default(string), string MeetingUUID = default(string), string UserName = default(string), string Email = default(string), int? EncryptionType = default(int?), string Title = default(string), string UserFullName = default(string), string PhoneNumber = default(string), string UserFeatures = default(string), ScheduledFromEnum? ScheduledFrom = default(ScheduledFromEnum?), int? InviteeCount = default(int?), bool? Personal = default(bool?), bool? MuteOnEntry = default(bool?), bool? AutoRecord = default(bool?), string EnterpriseName = default(string), bool? ModeratorLess = default(bool?), long? StartTime = default(long?), long? EndTime = default(long?), int? TotalCallSeconds = default(int?), long? CreateTime = default(long?), int? EndpointsCount = default(int?), int? ConcurrentEndpoints = default(int?), int? LiveVisibleEndpointsCount = default(int?), int? QualarooRating = default(int?), int? QualarooCount = default(int?), bool? MeetingRecording = default(bool?), bool? VideoShare = default(bool?), bool? ContentShare = default(bool?), bool? LiveRecording = default(bool?), bool? LiveVideoShare = default(bool?), bool? LiveContentShare = default(bool?), bool? LargeMeeting = default(bool?), float? RoiDistance = default(float?), bool? Mpls = default(bool?), string Id = default(string))
        {
            this.MeetingId = MeetingId;
            this.MeetingUUID = MeetingUUID;
            this.UserName = UserName;
            this.Email = Email;
            this.EncryptionType = EncryptionType;
            this.Title = Title;
            this.UserFullName = UserFullName;
            this.PhoneNumber = PhoneNumber;
            this.UserFeatures = UserFeatures;
            this.ScheduledFrom = ScheduledFrom;
            this.InviteeCount = InviteeCount;
            this.Personal = Personal;
            this.MuteOnEntry = MuteOnEntry;
            this.AutoRecord = AutoRecord;
            this.EnterpriseName = EnterpriseName;
            this.ModeratorLess = ModeratorLess;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.TotalCallSeconds = TotalCallSeconds;
            this.CreateTime = CreateTime;
            this.EndpointsCount = EndpointsCount;
            this.ConcurrentEndpoints = ConcurrentEndpoints;
            this.LiveVisibleEndpointsCount = LiveVisibleEndpointsCount;
            this.QualarooRating = QualarooRating;
            this.QualarooCount = QualarooCount;
            this.MeetingRecording = MeetingRecording;
            this.VideoShare = VideoShare;
            this.ContentShare = ContentShare;
            this.LiveRecording = LiveRecording;
            this.LiveVideoShare = LiveVideoShare;
            this.LiveContentShare = LiveContentShare;
            this.LargeMeeting = LargeMeeting;
            this.RoiDistance = RoiDistance;
            this.Mpls = Mpls;
            this.Id = Id;
        }
        
        /// <summary>
        /// This is the same as the numericMeetingId found elsewhere. We should have been more consistent.
        /// </summary>
        /// <value>This is the same as the numericMeetingId found elsewhere. We should have been more consistent.</value>
        [DataMember(Name="meetingId", EmitDefaultValue=false)]
        public string MeetingId { get; set; }

        /// <summary>
        /// The universally unique identifier (UUID) of the meeting. This value is a string which contains 6 alphanumeric segments separated by dashes.
        /// </summary>
        /// <value>The universally unique identifier (UUID) of the meeting. This value is a string which contains 6 alphanumeric segments separated by dashes.</value>
        [DataMember(Name="meetingUUID", EmitDefaultValue=false)]
        public string MeetingUUID { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets EncryptionType
        /// </summary>
        [DataMember(Name="encryptionType", EmitDefaultValue=false)]
        public int? EncryptionType { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets UserFullName
        /// </summary>
        [DataMember(Name="userFullName", EmitDefaultValue=false)]
        public string UserFullName { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets UserFeatures
        /// </summary>
        [DataMember(Name="userFeatures", EmitDefaultValue=false)]
        public string UserFeatures { get; set; }


        /// <summary>
        /// Gets or Sets InviteeCount
        /// </summary>
        [DataMember(Name="inviteeCount", EmitDefaultValue=false)]
        public int? InviteeCount { get; set; }

        /// <summary>
        /// Gets or Sets Personal
        /// </summary>
        [DataMember(Name="personal", EmitDefaultValue=false)]
        public bool? Personal { get; set; }

        /// <summary>
        /// Gets or Sets MuteOnEntry
        /// </summary>
        [DataMember(Name="muteOnEntry", EmitDefaultValue=false)]
        public bool? MuteOnEntry { get; set; }

        /// <summary>
        /// Gets or Sets AutoRecord
        /// </summary>
        [DataMember(Name="autoRecord", EmitDefaultValue=false)]
        public bool? AutoRecord { get; set; }

        /// <summary>
        /// Gets or Sets EnterpriseName
        /// </summary>
        [DataMember(Name="enterpriseName", EmitDefaultValue=false)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// Gets or Sets ModeratorLess
        /// </summary>
        [DataMember(Name="moderatorLess", EmitDefaultValue=false)]
        public bool? ModeratorLess { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Gets or Sets TotalCallSeconds
        /// </summary>
        [DataMember(Name="totalCallSeconds", EmitDefaultValue=false)]
        public int? TotalCallSeconds { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name="createTime", EmitDefaultValue=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndpointsCount
        /// </summary>
        [DataMember(Name="endpointsCount", EmitDefaultValue=false)]
        public int? EndpointsCount { get; set; }

        /// <summary>
        /// Gets or Sets ConcurrentEndpoints
        /// </summary>
        [DataMember(Name="concurrentEndpoints", EmitDefaultValue=false)]
        public int? ConcurrentEndpoints { get; set; }

        /// <summary>
        /// Gets or Sets LiveVisibleEndpointsCount
        /// </summary>
        [DataMember(Name="liveVisibleEndpointsCount", EmitDefaultValue=false)]
        public int? LiveVisibleEndpointsCount { get; set; }

        /// <summary>
        /// Gets or Sets QualarooRating
        /// </summary>
        [DataMember(Name="qualarooRating", EmitDefaultValue=false)]
        public int? QualarooRating { get; set; }

        /// <summary>
        /// Gets or Sets QualarooCount
        /// </summary>
        [DataMember(Name="qualarooCount", EmitDefaultValue=false)]
        public int? QualarooCount { get; set; }

        /// <summary>
        /// Gets or Sets MeetingRecording
        /// </summary>
        [DataMember(Name="meetingRecording", EmitDefaultValue=false)]
        public bool? MeetingRecording { get; set; }

        /// <summary>
        /// Gets or Sets VideoShare
        /// </summary>
        [DataMember(Name="videoShare", EmitDefaultValue=false)]
        public bool? VideoShare { get; set; }

        /// <summary>
        /// Gets or Sets ContentShare
        /// </summary>
        [DataMember(Name="contentShare", EmitDefaultValue=false)]
        public bool? ContentShare { get; set; }

        /// <summary>
        /// Gets or Sets LiveRecording
        /// </summary>
        [DataMember(Name="liveRecording", EmitDefaultValue=false)]
        public bool? LiveRecording { get; set; }

        /// <summary>
        /// Gets or Sets LiveVideoShare
        /// </summary>
        [DataMember(Name="liveVideoShare", EmitDefaultValue=false)]
        public bool? LiveVideoShare { get; set; }

        /// <summary>
        /// Gets or Sets LiveContentShare
        /// </summary>
        [DataMember(Name="liveContentShare", EmitDefaultValue=false)]
        public bool? LiveContentShare { get; set; }

        /// <summary>
        /// Gets or Sets LargeMeeting
        /// </summary>
        [DataMember(Name="largeMeeting", EmitDefaultValue=false)]
        public bool? LargeMeeting { get; set; }

        /// <summary>
        /// Gets or Sets RoiDistance
        /// </summary>
        [DataMember(Name="roiDistance", EmitDefaultValue=false)]
        public float? RoiDistance { get; set; }

        /// <summary>
        /// Gets or Sets Mpls
        /// </summary>
        [DataMember(Name="mpls", EmitDefaultValue=false)]
        public bool? Mpls { get; set; }

        /// <summary>
        /// Same as the meetingUUID property in this object.
        /// </summary>
        /// <value>Same as the meetingUUID property in this object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeetingIndigo {\n");
            sb.Append("  MeetingId: ").Append(MeetingId).Append("\n");
            sb.Append("  MeetingUUID: ").Append(MeetingUUID).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EncryptionType: ").Append(EncryptionType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UserFullName: ").Append(UserFullName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  UserFeatures: ").Append(UserFeatures).Append("\n");
            sb.Append("  ScheduledFrom: ").Append(ScheduledFrom).Append("\n");
            sb.Append("  InviteeCount: ").Append(InviteeCount).Append("\n");
            sb.Append("  Personal: ").Append(Personal).Append("\n");
            sb.Append("  MuteOnEntry: ").Append(MuteOnEntry).Append("\n");
            sb.Append("  AutoRecord: ").Append(AutoRecord).Append("\n");
            sb.Append("  EnterpriseName: ").Append(EnterpriseName).Append("\n");
            sb.Append("  ModeratorLess: ").Append(ModeratorLess).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  TotalCallSeconds: ").Append(TotalCallSeconds).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  EndpointsCount: ").Append(EndpointsCount).Append("\n");
            sb.Append("  ConcurrentEndpoints: ").Append(ConcurrentEndpoints).Append("\n");
            sb.Append("  LiveVisibleEndpointsCount: ").Append(LiveVisibleEndpointsCount).Append("\n");
            sb.Append("  QualarooRating: ").Append(QualarooRating).Append("\n");
            sb.Append("  QualarooCount: ").Append(QualarooCount).Append("\n");
            sb.Append("  MeetingRecording: ").Append(MeetingRecording).Append("\n");
            sb.Append("  VideoShare: ").Append(VideoShare).Append("\n");
            sb.Append("  ContentShare: ").Append(ContentShare).Append("\n");
            sb.Append("  LiveRecording: ").Append(LiveRecording).Append("\n");
            sb.Append("  LiveVideoShare: ").Append(LiveVideoShare).Append("\n");
            sb.Append("  LiveContentShare: ").Append(LiveContentShare).Append("\n");
            sb.Append("  LargeMeeting: ").Append(LargeMeeting).Append("\n");
            sb.Append("  RoiDistance: ").Append(RoiDistance).Append("\n");
            sb.Append("  Mpls: ").Append(Mpls).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MeetingIndigo);
        }

        /// <summary>
        /// Returns true if MeetingIndigo instances are equal
        /// </summary>
        /// <param name="other">Instance of MeetingIndigo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MeetingIndigo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MeetingId == other.MeetingId ||
                    this.MeetingId != null &&
                    this.MeetingId.Equals(other.MeetingId)
                ) && 
                (
                    this.MeetingUUID == other.MeetingUUID ||
                    this.MeetingUUID != null &&
                    this.MeetingUUID.Equals(other.MeetingUUID)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EncryptionType == other.EncryptionType ||
                    this.EncryptionType != null &&
                    this.EncryptionType.Equals(other.EncryptionType)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.UserFullName == other.UserFullName ||
                    this.UserFullName != null &&
                    this.UserFullName.Equals(other.UserFullName)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.UserFeatures == other.UserFeatures ||
                    this.UserFeatures != null &&
                    this.UserFeatures.Equals(other.UserFeatures)
                ) && 
                (
                    this.ScheduledFrom == other.ScheduledFrom ||
                    this.ScheduledFrom != null &&
                    this.ScheduledFrom.Equals(other.ScheduledFrom)
                ) && 
                (
                    this.InviteeCount == other.InviteeCount ||
                    this.InviteeCount != null &&
                    this.InviteeCount.Equals(other.InviteeCount)
                ) && 
                (
                    this.Personal == other.Personal ||
                    this.Personal != null &&
                    this.Personal.Equals(other.Personal)
                ) && 
                (
                    this.MuteOnEntry == other.MuteOnEntry ||
                    this.MuteOnEntry != null &&
                    this.MuteOnEntry.Equals(other.MuteOnEntry)
                ) && 
                (
                    this.AutoRecord == other.AutoRecord ||
                    this.AutoRecord != null &&
                    this.AutoRecord.Equals(other.AutoRecord)
                ) && 
                (
                    this.EnterpriseName == other.EnterpriseName ||
                    this.EnterpriseName != null &&
                    this.EnterpriseName.Equals(other.EnterpriseName)
                ) && 
                (
                    this.ModeratorLess == other.ModeratorLess ||
                    this.ModeratorLess != null &&
                    this.ModeratorLess.Equals(other.ModeratorLess)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) && 
                (
                    this.TotalCallSeconds == other.TotalCallSeconds ||
                    this.TotalCallSeconds != null &&
                    this.TotalCallSeconds.Equals(other.TotalCallSeconds)
                ) && 
                (
                    this.CreateTime == other.CreateTime ||
                    this.CreateTime != null &&
                    this.CreateTime.Equals(other.CreateTime)
                ) && 
                (
                    this.EndpointsCount == other.EndpointsCount ||
                    this.EndpointsCount != null &&
                    this.EndpointsCount.Equals(other.EndpointsCount)
                ) && 
                (
                    this.ConcurrentEndpoints == other.ConcurrentEndpoints ||
                    this.ConcurrentEndpoints != null &&
                    this.ConcurrentEndpoints.Equals(other.ConcurrentEndpoints)
                ) && 
                (
                    this.LiveVisibleEndpointsCount == other.LiveVisibleEndpointsCount ||
                    this.LiveVisibleEndpointsCount != null &&
                    this.LiveVisibleEndpointsCount.Equals(other.LiveVisibleEndpointsCount)
                ) && 
                (
                    this.QualarooRating == other.QualarooRating ||
                    this.QualarooRating != null &&
                    this.QualarooRating.Equals(other.QualarooRating)
                ) && 
                (
                    this.QualarooCount == other.QualarooCount ||
                    this.QualarooCount != null &&
                    this.QualarooCount.Equals(other.QualarooCount)
                ) && 
                (
                    this.MeetingRecording == other.MeetingRecording ||
                    this.MeetingRecording != null &&
                    this.MeetingRecording.Equals(other.MeetingRecording)
                ) && 
                (
                    this.VideoShare == other.VideoShare ||
                    this.VideoShare != null &&
                    this.VideoShare.Equals(other.VideoShare)
                ) && 
                (
                    this.ContentShare == other.ContentShare ||
                    this.ContentShare != null &&
                    this.ContentShare.Equals(other.ContentShare)
                ) && 
                (
                    this.LiveRecording == other.LiveRecording ||
                    this.LiveRecording != null &&
                    this.LiveRecording.Equals(other.LiveRecording)
                ) && 
                (
                    this.LiveVideoShare == other.LiveVideoShare ||
                    this.LiveVideoShare != null &&
                    this.LiveVideoShare.Equals(other.LiveVideoShare)
                ) && 
                (
                    this.LiveContentShare == other.LiveContentShare ||
                    this.LiveContentShare != null &&
                    this.LiveContentShare.Equals(other.LiveContentShare)
                ) && 
                (
                    this.LargeMeeting == other.LargeMeeting ||
                    this.LargeMeeting != null &&
                    this.LargeMeeting.Equals(other.LargeMeeting)
                ) && 
                (
                    this.RoiDistance == other.RoiDistance ||
                    this.RoiDistance != null &&
                    this.RoiDistance.Equals(other.RoiDistance)
                ) && 
                (
                    this.Mpls == other.Mpls ||
                    this.Mpls != null &&
                    this.Mpls.Equals(other.Mpls)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.MeetingId != null)
                    hash = hash * 59 + this.MeetingId.GetHashCode();
                if (this.MeetingUUID != null)
                    hash = hash * 59 + this.MeetingUUID.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EncryptionType != null)
                    hash = hash * 59 + this.EncryptionType.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.UserFullName != null)
                    hash = hash * 59 + this.UserFullName.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.UserFeatures != null)
                    hash = hash * 59 + this.UserFeatures.GetHashCode();
                if (this.ScheduledFrom != null)
                    hash = hash * 59 + this.ScheduledFrom.GetHashCode();
                if (this.InviteeCount != null)
                    hash = hash * 59 + this.InviteeCount.GetHashCode();
                if (this.Personal != null)
                    hash = hash * 59 + this.Personal.GetHashCode();
                if (this.MuteOnEntry != null)
                    hash = hash * 59 + this.MuteOnEntry.GetHashCode();
                if (this.AutoRecord != null)
                    hash = hash * 59 + this.AutoRecord.GetHashCode();
                if (this.EnterpriseName != null)
                    hash = hash * 59 + this.EnterpriseName.GetHashCode();
                if (this.ModeratorLess != null)
                    hash = hash * 59 + this.ModeratorLess.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                if (this.TotalCallSeconds != null)
                    hash = hash * 59 + this.TotalCallSeconds.GetHashCode();
                if (this.CreateTime != null)
                    hash = hash * 59 + this.CreateTime.GetHashCode();
                if (this.EndpointsCount != null)
                    hash = hash * 59 + this.EndpointsCount.GetHashCode();
                if (this.ConcurrentEndpoints != null)
                    hash = hash * 59 + this.ConcurrentEndpoints.GetHashCode();
                if (this.LiveVisibleEndpointsCount != null)
                    hash = hash * 59 + this.LiveVisibleEndpointsCount.GetHashCode();
                if (this.QualarooRating != null)
                    hash = hash * 59 + this.QualarooRating.GetHashCode();
                if (this.QualarooCount != null)
                    hash = hash * 59 + this.QualarooCount.GetHashCode();
                if (this.MeetingRecording != null)
                    hash = hash * 59 + this.MeetingRecording.GetHashCode();
                if (this.VideoShare != null)
                    hash = hash * 59 + this.VideoShare.GetHashCode();
                if (this.ContentShare != null)
                    hash = hash * 59 + this.ContentShare.GetHashCode();
                if (this.LiveRecording != null)
                    hash = hash * 59 + this.LiveRecording.GetHashCode();
                if (this.LiveVideoShare != null)
                    hash = hash * 59 + this.LiveVideoShare.GetHashCode();
                if (this.LiveContentShare != null)
                    hash = hash * 59 + this.LiveContentShare.GetHashCode();
                if (this.LargeMeeting != null)
                    hash = hash * 59 + this.LargeMeeting.GetHashCode();
                if (this.RoiDistance != null)
                    hash = hash * 59 + this.RoiDistance.GetHashCode();
                if (this.Mpls != null)
                    hash = hash * 59 + this.Mpls.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
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
