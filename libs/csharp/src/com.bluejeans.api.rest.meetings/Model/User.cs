/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/010/2018 </alert>Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.4407102018
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
    /// 2/5/2018 - - JSON object containing the BlueJeans&#39; user profile fields
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="Username">User&#39;s username.</param>
        /// <param name="FirstName">User&#39;s first name.</param>
        /// <param name="MiddleName">User&#39;s middle name.</param>
        /// <param name="LastName">User&#39;s last name.</param>
        /// <param name="EmailId">User&#39;s email address.</param>
        /// <param name="Company">User&#39;s company name.</param>
        /// <param name="Title">User&#39;s title.</param>
        /// <param name="Phone">User&#39;s phone.</param>
        /// <param name="ProfilePicture">Path to user&#39;s profile picture.</param>
        /// <param name="Timezone">User&#39;s timezone.</param>
        /// <param name="TimeFormat">User&#39;s preference of 12 or 24 hour time display.</param>
        /// <param name="Language">User&#39;s language code, e.g., \&quot;en\&quot;.</param>
        /// <param name="SkypeId">User&#39;s skype account identifier.</param>
        /// <param name="GtalkId">User&#39;s Google Talk account identified.</param>
        /// <param name="DefaultEndpoint">Default type of client user attends meetings.</param>
        /// <param name="PasswordChangeRequired">Force user to change their password on next login.</param>
        /// <param name="MarketoId">User&#39;s Marketo Account identifier.</param>
        /// <param name="OptOutOffers">null.</param>
        /// <param name="OptOutNews">OptOutNews.</param>
        /// <param name="GeoInfo">JSON string containing User&#39;s geographic information including city,state,postal code, country (abbrev, i.e., \&quot;US\&quot;),time zone, country name (i.e.,\&quot;United States\&quot;), ISP, latitude, and longitude.</param>
        /// <param name="HowDidYouHear">null.</param>
        /// <param name="SfdcToken">OAuth token used for Salesforce integration.</param>
        /// <param name="LinkedinProfileUrl">hyperlink to User&#39;s LinkedIn profile.</param>
        /// <param name="LastLogin">Date and time (in milliseconds) of the User&#39;s last login.</param>
        /// <param name="DateJoined">Date and time when BlueJeans account was created.</param>
        /// <param name="Jid">User&#39;s Jabber Account Identifier.</param>
        /// <param name="PrimaryPhone">User&#39;s phone number.</param>
        /// <param name="FailedLoginCount">Count of how many times a user tried to enter their account password.</param>
        /// <param name="IsInitialSetupDone">IsInitialSetupDone.</param>
        /// <param name="ChannelId">ChannelId.</param>
        /// <param name="IsVerified">BlueJeans has validated authenticity of the account owner.</param>
        public User(string Username = default(string), string FirstName = default(string), string MiddleName = default(string), string LastName = default(string), string EmailId = default(string), string Company = default(string), string Title = default(string), string Phone = default(string), string ProfilePicture = default(string), string Timezone = default(string), int? TimeFormat = default(int?), string Language = default(string), string SkypeId = default(string), string GtalkId = default(string), string DefaultEndpoint = default(string), bool? PasswordChangeRequired = default(bool?), string MarketoId = default(string), bool? OptOutOffers = default(bool?), bool? OptOutNews = default(bool?), string GeoInfo = default(string), string HowDidYouHear = default(string), string SfdcToken = default(string), string LinkedinProfileUrl = default(string), int? LastLogin = default(int?), int? DateJoined = default(int?), string Jid = default(string), string PrimaryPhone = default(string), int? FailedLoginCount = default(int?), bool? IsInitialSetupDone = default(bool?), int? ChannelId = default(int?), bool? IsVerified = default(bool?))
        {
            this.Username = Username;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.EmailId = EmailId;
            this.Company = Company;
            this.Title = Title;
            this.Phone = Phone;
            this.ProfilePicture = ProfilePicture;
            this.Timezone = Timezone;
            this.TimeFormat = TimeFormat;
            this.Language = Language;
            this.SkypeId = SkypeId;
            this.GtalkId = GtalkId;
            this.DefaultEndpoint = DefaultEndpoint;
            this.PasswordChangeRequired = PasswordChangeRequired;
            this.MarketoId = MarketoId;
            this.OptOutOffers = OptOutOffers;
            this.OptOutNews = OptOutNews;
            this.GeoInfo = GeoInfo;
            this.HowDidYouHear = HowDidYouHear;
            this.SfdcToken = SfdcToken;
            this.LinkedinProfileUrl = LinkedinProfileUrl;
            this.LastLogin = LastLogin;
            this.DateJoined = DateJoined;
            this.Jid = Jid;
            this.PrimaryPhone = PrimaryPhone;
            this.FailedLoginCount = FailedLoginCount;
            this.IsInitialSetupDone = IsInitialSetupDone;
            this.ChannelId = ChannelId;
            this.IsVerified = IsVerified;
        }
        
        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        /// <value>Unique identifier for the user.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// User&#39;s username
        /// </summary>
        /// <value>User&#39;s username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// User&#39;s first name
        /// </summary>
        /// <value>User&#39;s first name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// User&#39;s middle name
        /// </summary>
        /// <value>User&#39;s middle name</value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// User&#39;s last name
        /// </summary>
        /// <value>User&#39;s last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// User&#39;s email address
        /// </summary>
        /// <value>User&#39;s email address</value>
        [DataMember(Name="emailId", EmitDefaultValue=false)]
        public string EmailId { get; set; }

        /// <summary>
        /// User&#39;s company name
        /// </summary>
        /// <value>User&#39;s company name</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// User&#39;s title
        /// </summary>
        /// <value>User&#39;s title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// User&#39;s phone
        /// </summary>
        /// <value>User&#39;s phone</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Path to user&#39;s profile picture
        /// </summary>
        /// <value>Path to user&#39;s profile picture</value>
        [DataMember(Name="profilePicture", EmitDefaultValue=false)]
        public string ProfilePicture { get; set; }

        /// <summary>
        /// User&#39;s timezone
        /// </summary>
        /// <value>User&#39;s timezone</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// User&#39;s preference of 12 or 24 hour time display
        /// </summary>
        /// <value>User&#39;s preference of 12 or 24 hour time display</value>
        [DataMember(Name="timeFormat", EmitDefaultValue=false)]
        public int? TimeFormat { get; set; }

        /// <summary>
        /// User&#39;s language code, e.g., \&quot;en\&quot;
        /// </summary>
        /// <value>User&#39;s language code, e.g., \&quot;en\&quot;</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// User&#39;s skype account identifier
        /// </summary>
        /// <value>User&#39;s skype account identifier</value>
        [DataMember(Name="skypeId", EmitDefaultValue=false)]
        public string SkypeId { get; set; }

        /// <summary>
        /// User&#39;s Google Talk account identified
        /// </summary>
        /// <value>User&#39;s Google Talk account identified</value>
        [DataMember(Name="gtalkId", EmitDefaultValue=false)]
        public string GtalkId { get; set; }

        /// <summary>
        /// Default type of client user attends meetings
        /// </summary>
        /// <value>Default type of client user attends meetings</value>
        [DataMember(Name="defaultEndpoint", EmitDefaultValue=false)]
        public string DefaultEndpoint { get; set; }

        /// <summary>
        /// Force user to change their password on next login
        /// </summary>
        /// <value>Force user to change their password on next login</value>
        [DataMember(Name="passwordChangeRequired", EmitDefaultValue=false)]
        public bool? PasswordChangeRequired { get; set; }

        /// <summary>
        /// User&#39;s Marketo Account identifier
        /// </summary>
        /// <value>User&#39;s Marketo Account identifier</value>
        [DataMember(Name="marketoId", EmitDefaultValue=false)]
        public string MarketoId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        /// <value>null</value>
        [DataMember(Name="optOutOffers", EmitDefaultValue=false)]
        public bool? OptOutOffers { get; set; }

        /// <summary>
        /// Gets or Sets OptOutNews
        /// </summary>
        [DataMember(Name="optOutNews", EmitDefaultValue=false)]
        public bool? OptOutNews { get; set; }

        /// <summary>
        /// JSON string containing User&#39;s geographic information including city,state,postal code, country (abbrev, i.e., \&quot;US\&quot;),time zone, country name (i.e.,\&quot;United States\&quot;), ISP, latitude, and longitude
        /// </summary>
        /// <value>JSON string containing User&#39;s geographic information including city,state,postal code, country (abbrev, i.e., \&quot;US\&quot;),time zone, country name (i.e.,\&quot;United States\&quot;), ISP, latitude, and longitude</value>
        [DataMember(Name="geoInfo", EmitDefaultValue=false)]
        public string GeoInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        /// <value>null</value>
        [DataMember(Name="howDidYouHear", EmitDefaultValue=false)]
        public string HowDidYouHear { get; set; }

        /// <summary>
        /// OAuth token used for Salesforce integration
        /// </summary>
        /// <value>OAuth token used for Salesforce integration</value>
        [DataMember(Name="sfdcToken", EmitDefaultValue=false)]
        public string SfdcToken { get; set; }

        /// <summary>
        /// hyperlink to User&#39;s LinkedIn profile
        /// </summary>
        /// <value>hyperlink to User&#39;s LinkedIn profile</value>
        [DataMember(Name="linkedinProfileUrl", EmitDefaultValue=false)]
        public string LinkedinProfileUrl { get; set; }

        /// <summary>
        /// Date and time (in milliseconds) of the User&#39;s last login
        /// </summary>
        /// <value>Date and time (in milliseconds) of the User&#39;s last login</value>
        [DataMember(Name="lastLogin", EmitDefaultValue=false)]
        public int? LastLogin { get; set; }

        /// <summary>
        /// Date and time when BlueJeans account was created
        /// </summary>
        /// <value>Date and time when BlueJeans account was created</value>
        [DataMember(Name="dateJoined", EmitDefaultValue=false)]
        public int? DateJoined { get; set; }

        /// <summary>
        /// User&#39;s Jabber Account Identifier
        /// </summary>
        /// <value>User&#39;s Jabber Account Identifier</value>
        [DataMember(Name="jid", EmitDefaultValue=false)]
        public string Jid { get; set; }

        /// <summary>
        /// User&#39;s phone number
        /// </summary>
        /// <value>User&#39;s phone number</value>
        [DataMember(Name="primaryPhone", EmitDefaultValue=false)]
        public string PrimaryPhone { get; set; }

        /// <summary>
        /// Count of how many times a user tried to enter their account password
        /// </summary>
        /// <value>Count of how many times a user tried to enter their account password</value>
        [DataMember(Name="failedLoginCount", EmitDefaultValue=false)]
        public int? FailedLoginCount { get; set; }

        /// <summary>
        /// Gets or Sets IsInitialSetupDone
        /// </summary>
        [DataMember(Name="isInitialSetupDone", EmitDefaultValue=false)]
        public bool? IsInitialSetupDone { get; set; }

        /// <summary>
        /// Gets or Sets ChannelId
        /// </summary>
        [DataMember(Name="channel_id", EmitDefaultValue=false)]
        public int? ChannelId { get; set; }

        /// <summary>
        /// BlueJeans has validated authenticity of the account owner
        /// </summary>
        /// <value>BlueJeans has validated authenticity of the account owner</value>
        [DataMember(Name="isVerified", EmitDefaultValue=false)]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailId: ").Append(EmailId).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  ProfilePicture: ").Append(ProfilePicture).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  TimeFormat: ").Append(TimeFormat).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  SkypeId: ").Append(SkypeId).Append("\n");
            sb.Append("  GtalkId: ").Append(GtalkId).Append("\n");
            sb.Append("  DefaultEndpoint: ").Append(DefaultEndpoint).Append("\n");
            sb.Append("  PasswordChangeRequired: ").Append(PasswordChangeRequired).Append("\n");
            sb.Append("  MarketoId: ").Append(MarketoId).Append("\n");
            sb.Append("  OptOutOffers: ").Append(OptOutOffers).Append("\n");
            sb.Append("  OptOutNews: ").Append(OptOutNews).Append("\n");
            sb.Append("  GeoInfo: ").Append(GeoInfo).Append("\n");
            sb.Append("  HowDidYouHear: ").Append(HowDidYouHear).Append("\n");
            sb.Append("  SfdcToken: ").Append(SfdcToken).Append("\n");
            sb.Append("  LinkedinProfileUrl: ").Append(LinkedinProfileUrl).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  DateJoined: ").Append(DateJoined).Append("\n");
            sb.Append("  Jid: ").Append(Jid).Append("\n");
            sb.Append("  PrimaryPhone: ").Append(PrimaryPhone).Append("\n");
            sb.Append("  FailedLoginCount: ").Append(FailedLoginCount).Append("\n");
            sb.Append("  IsInitialSetupDone: ").Append(IsInitialSetupDone).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.EmailId == other.EmailId ||
                    this.EmailId != null &&
                    this.EmailId.Equals(other.EmailId)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.ProfilePicture == other.ProfilePicture ||
                    this.ProfilePicture != null &&
                    this.ProfilePicture.Equals(other.ProfilePicture)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.TimeFormat == other.TimeFormat ||
                    this.TimeFormat != null &&
                    this.TimeFormat.Equals(other.TimeFormat)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.SkypeId == other.SkypeId ||
                    this.SkypeId != null &&
                    this.SkypeId.Equals(other.SkypeId)
                ) && 
                (
                    this.GtalkId == other.GtalkId ||
                    this.GtalkId != null &&
                    this.GtalkId.Equals(other.GtalkId)
                ) && 
                (
                    this.DefaultEndpoint == other.DefaultEndpoint ||
                    this.DefaultEndpoint != null &&
                    this.DefaultEndpoint.Equals(other.DefaultEndpoint)
                ) && 
                (
                    this.PasswordChangeRequired == other.PasswordChangeRequired ||
                    this.PasswordChangeRequired != null &&
                    this.PasswordChangeRequired.Equals(other.PasswordChangeRequired)
                ) && 
                (
                    this.MarketoId == other.MarketoId ||
                    this.MarketoId != null &&
                    this.MarketoId.Equals(other.MarketoId)
                ) && 
                (
                    this.OptOutOffers == other.OptOutOffers ||
                    this.OptOutOffers != null &&
                    this.OptOutOffers.Equals(other.OptOutOffers)
                ) && 
                (
                    this.OptOutNews == other.OptOutNews ||
                    this.OptOutNews != null &&
                    this.OptOutNews.Equals(other.OptOutNews)
                ) && 
                (
                    this.GeoInfo == other.GeoInfo ||
                    this.GeoInfo != null &&
                    this.GeoInfo.Equals(other.GeoInfo)
                ) && 
                (
                    this.HowDidYouHear == other.HowDidYouHear ||
                    this.HowDidYouHear != null &&
                    this.HowDidYouHear.Equals(other.HowDidYouHear)
                ) && 
                (
                    this.SfdcToken == other.SfdcToken ||
                    this.SfdcToken != null &&
                    this.SfdcToken.Equals(other.SfdcToken)
                ) && 
                (
                    this.LinkedinProfileUrl == other.LinkedinProfileUrl ||
                    this.LinkedinProfileUrl != null &&
                    this.LinkedinProfileUrl.Equals(other.LinkedinProfileUrl)
                ) && 
                (
                    this.LastLogin == other.LastLogin ||
                    this.LastLogin != null &&
                    this.LastLogin.Equals(other.LastLogin)
                ) && 
                (
                    this.DateJoined == other.DateJoined ||
                    this.DateJoined != null &&
                    this.DateJoined.Equals(other.DateJoined)
                ) && 
                (
                    this.Jid == other.Jid ||
                    this.Jid != null &&
                    this.Jid.Equals(other.Jid)
                ) && 
                (
                    this.PrimaryPhone == other.PrimaryPhone ||
                    this.PrimaryPhone != null &&
                    this.PrimaryPhone.Equals(other.PrimaryPhone)
                ) && 
                (
                    this.FailedLoginCount == other.FailedLoginCount ||
                    this.FailedLoginCount != null &&
                    this.FailedLoginCount.Equals(other.FailedLoginCount)
                ) && 
                (
                    this.IsInitialSetupDone == other.IsInitialSetupDone ||
                    this.IsInitialSetupDone != null &&
                    this.IsInitialSetupDone.Equals(other.IsInitialSetupDone)
                ) && 
                (
                    this.ChannelId == other.ChannelId ||
                    this.ChannelId != null &&
                    this.ChannelId.Equals(other.ChannelId)
                ) && 
                (
                    this.IsVerified == other.IsVerified ||
                    this.IsVerified != null &&
                    this.IsVerified.Equals(other.IsVerified)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.EmailId != null)
                    hash = hash * 59 + this.EmailId.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.ProfilePicture != null)
                    hash = hash * 59 + this.ProfilePicture.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.TimeFormat != null)
                    hash = hash * 59 + this.TimeFormat.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.SkypeId != null)
                    hash = hash * 59 + this.SkypeId.GetHashCode();
                if (this.GtalkId != null)
                    hash = hash * 59 + this.GtalkId.GetHashCode();
                if (this.DefaultEndpoint != null)
                    hash = hash * 59 + this.DefaultEndpoint.GetHashCode();
                if (this.PasswordChangeRequired != null)
                    hash = hash * 59 + this.PasswordChangeRequired.GetHashCode();
                if (this.MarketoId != null)
                    hash = hash * 59 + this.MarketoId.GetHashCode();
                if (this.OptOutOffers != null)
                    hash = hash * 59 + this.OptOutOffers.GetHashCode();
                if (this.OptOutNews != null)
                    hash = hash * 59 + this.OptOutNews.GetHashCode();
                if (this.GeoInfo != null)
                    hash = hash * 59 + this.GeoInfo.GetHashCode();
                if (this.HowDidYouHear != null)
                    hash = hash * 59 + this.HowDidYouHear.GetHashCode();
                if (this.SfdcToken != null)
                    hash = hash * 59 + this.SfdcToken.GetHashCode();
                if (this.LinkedinProfileUrl != null)
                    hash = hash * 59 + this.LinkedinProfileUrl.GetHashCode();
                if (this.LastLogin != null)
                    hash = hash * 59 + this.LastLogin.GetHashCode();
                if (this.DateJoined != null)
                    hash = hash * 59 + this.DateJoined.GetHashCode();
                if (this.Jid != null)
                    hash = hash * 59 + this.Jid.GetHashCode();
                if (this.PrimaryPhone != null)
                    hash = hash * 59 + this.PrimaryPhone.GetHashCode();
                if (this.FailedLoginCount != null)
                    hash = hash * 59 + this.FailedLoginCount.GetHashCode();
                if (this.IsInitialSetupDone != null)
                    hash = hash * 59 + this.IsInitialSetupDone.GetHashCode();
                if (this.ChannelId != null)
                    hash = hash * 59 + this.ChannelId.GetHashCode();
                if (this.IsVerified != null)
                    hash = hash * 59 + this.IsVerified.GetHashCode();
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
