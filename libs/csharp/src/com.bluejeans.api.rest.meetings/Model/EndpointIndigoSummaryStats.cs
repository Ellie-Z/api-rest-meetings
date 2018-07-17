/* 
 * BlueJeans Meetings REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's Meetings meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.    <alert>7/010/2018 </alert>Deprecated some Command Center API's.  Exposed API's that Summarize usage.<br/> 7/06/2018 Added API for changing ownership of recordings.<br/> 6/28/2018 Restored Create Enterprise Account, added Enterprise and User Profile Tag API's.<br/> 6/01/2018 Clarified Access Token requirements for meeting endpoint API's.<br/> 5/21/2018 Corrected return model for meeting history call.<br/> <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by a randomized access code.  THe access code ensures security of participants who join.  Also the access code can specify a Moderator role whose user(s) have additional capabilities to administer a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>The scheduler's profile has a user-specified moderator passcode which can be input to allow designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About Meetings Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0.mm44 (7/06/2018)
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
    /// EndpointIndigoSummaryStats
    /// </summary>
    [DataContract]
    public partial class EndpointIndigoSummaryStats :  IEquatable<EndpointIndigoSummaryStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointIndigoSummaryStats" /> class.
        /// </summary>
        /// <param name="AudioRecvCodec">AudioRecvCodec.</param>
        /// <param name="AudioSendCodec">AudioSendCodec.</param>
        /// <param name="ContentRecv">ContentRecv.</param>
        /// <param name="ContentSend">ContentSend.</param>
        /// <param name="TalkDetected">TalkDetected.</param>
        /// <param name="SessionRelay">SessionRelay.</param>
        /// <param name="SessionInRelay">SessionInRelay.</param>
        /// <param name="SessionOutRelay">SessionOutRelay.</param>
        /// <param name="AudioRtpRelay">AudioRtpRelay.</param>
        /// <param name="CallRate">CallRate.</param>
        /// <param name="CumulLossPercentAI">CumulLossPercentAI.</param>
        /// <param name="CumulLossPercentAO">CumulLossPercentAO.</param>
        /// <param name="CumulLossPercentVI">CumulLossPercentVI.</param>
        /// <param name="CumulLossPercentVO">CumulLossPercentVO.</param>
        /// <param name="CumulLossPercentVIC">CumulLossPercentVIC.</param>
        /// <param name="CumulLossPercentVOC">CumulLossPercentVOC.</param>
        /// <param name="CumulLossAI">CumulLossAI.</param>
        /// <param name="CumulLossAO">CumulLossAO.</param>
        /// <param name="CumulLossVI">CumulLossVI.</param>
        /// <param name="CumulLossVO">CumulLossVO.</param>
        /// <param name="CumulLossVIC">CumulLossVIC.</param>
        /// <param name="CumulLossVOC">CumulLossVOC.</param>
        /// <param name="DiscontinuityCount">DiscontinuityCount.</param>
        /// <param name="DroppedPacketsAI">DroppedPacketsAI.</param>
        /// <param name="DroppedPacketsVI">DroppedPacketsVI.</param>
        /// <param name="DroppedPacketsVIC">DroppedPacketsVIC.</param>
        /// <param name="MixUnderRunsAI">MixUnderRunsAI.</param>
        /// <param name="NetworkAvgLossAI">NetworkAvgLossAI.</param>
        /// <param name="NetworkAvgLossAO">NetworkAvgLossAO.</param>
        /// <param name="NetworkAvgLossVI">NetworkAvgLossVI.</param>
        /// <param name="NetworkAvgLossVO">NetworkAvgLossVO.</param>
        /// <param name="NetworkCumulLossAI">NetworkCumulLossAI.</param>
        /// <param name="NetworkCumulLossAO">NetworkCumulLossAO.</param>
        /// <param name="NetworkCumulLossVI">NetworkCumulLossVI.</param>
        /// <param name="NetworkCumulLossVO">NetworkCumulLossVO.</param>
        /// <param name="NetworkLossAI">NetworkLossAI.</param>
        /// <param name="NetworkLossAO">NetworkLossAO.</param>
        /// <param name="NetworkLossVI">NetworkLossVI.</param>
        /// <param name="NetworkLossVO">NetworkLossVO.</param>
        /// <param name="CallQualityMin">CallQualityMin.</param>
        /// <param name="CallQualityMax">CallQualityMax.</param>
        /// <param name="CallQualityAvg">CallQualityAvg.</param>
        /// <param name="FpsMinVI">FpsMinVI.</param>
        /// <param name="FpsMinVO">FpsMinVO.</param>
        /// <param name="FpsMinVIC">FpsMinVIC.</param>
        /// <param name="FpsMinVOC">FpsMinVOC.</param>
        /// <param name="FpsMaxVI">FpsMaxVI.</param>
        /// <param name="FpsMaxVO">FpsMaxVO.</param>
        /// <param name="FpsMaxVIC">FpsMaxVIC.</param>
        /// <param name="FpsMaxVOC">FpsMaxVOC.</param>
        /// <param name="FpsAvgVI">FpsAvgVI.</param>
        /// <param name="FpsAvgVO">FpsAvgVO.</param>
        /// <param name="FpsAvgVIC">FpsAvgVIC.</param>
        /// <param name="FpsAvgVOC">FpsAvgVOC.</param>
        /// <param name="BitrateMinAI">BitrateMinAI.</param>
        /// <param name="BitrateMinAO">BitrateMinAO.</param>
        /// <param name="BitrateMinVI">BitrateMinVI.</param>
        /// <param name="BitrateMinVO">BitrateMinVO.</param>
        /// <param name="BitrateMinVIC">BitrateMinVIC.</param>
        /// <param name="BitrateMinVOC">BitrateMinVOC.</param>
        /// <param name="BitrateMaxAI">BitrateMaxAI.</param>
        /// <param name="BitrateMaxAO">BitrateMaxAO.</param>
        /// <param name="BitrateMaxVI">BitrateMaxVI.</param>
        /// <param name="BitrateMaxVO">BitrateMaxVO.</param>
        /// <param name="BitrateMaxVIC">BitrateMaxVIC.</param>
        /// <param name="BitrateMaxVOC">BitrateMaxVOC.</param>
        /// <param name="BitrateAvgAI">BitrateAvgAI.</param>
        /// <param name="BitrateAvgAO">BitrateAvgAO.</param>
        /// <param name="BitrateAvgVI">BitrateAvgVI.</param>
        /// <param name="BitrateAvgVO">BitrateAvgVO.</param>
        /// <param name="BitrateAvgVIC">BitrateAvgVIC.</param>
        /// <param name="BitrateAvgVOC">BitrateAvgVOC.</param>
        /// <param name="JitterMinAI">JitterMinAI.</param>
        /// <param name="JitterMinAO">JitterMinAO.</param>
        /// <param name="JitterMinVI">JitterMinVI.</param>
        /// <param name="JitterMinVO">JitterMinVO.</param>
        /// <param name="JitterMinVIC">JitterMinVIC.</param>
        /// <param name="JitterMinVOC">JitterMinVOC.</param>
        /// <param name="JitterMaxAI">JitterMaxAI.</param>
        /// <param name="JitterMaxAO">JitterMaxAO.</param>
        /// <param name="JitterMaxVI">JitterMaxVI.</param>
        /// <param name="JitterMaxVO">JitterMaxVO.</param>
        /// <param name="JitterMaxVIC">JitterMaxVIC.</param>
        /// <param name="JitterMaxVOC">JitterMaxVOC.</param>
        /// <param name="JitterAvgAI">JitterAvgAI.</param>
        /// <param name="JitterAvgAO">JitterAvgAO.</param>
        /// <param name="JitterAvgVI">JitterAvgVI.</param>
        /// <param name="JitterAvgVO">JitterAvgVO.</param>
        /// <param name="JitterAvgVIC">JitterAvgVIC.</param>
        /// <param name="JitterAvgVOC">JitterAvgVOC.</param>
        /// <param name="MaxJitterMinAI">MaxJitterMinAI.</param>
        /// <param name="MaxJitterMinVI">MaxJitterMinVI.</param>
        /// <param name="MaxJitterMinVIC">MaxJitterMinVIC.</param>
        /// <param name="MaxJitterMaxAI">MaxJitterMaxAI.</param>
        /// <param name="MaxJitterMaxVI">MaxJitterMaxVI.</param>
        /// <param name="MaxJitterMaxVIC">MaxJitterMaxVIC.</param>
        /// <param name="MaxJitterAvgAI">MaxJitterAvgAI.</param>
        /// <param name="MaxJitterAvgVI">MaxJitterAvgVI.</param>
        /// <param name="MaxJitterAvgVIC">MaxJitterAvgVIC.</param>
        /// <param name="VideoRecvHeightMin">VideoRecvHeightMin.</param>
        /// <param name="VideoRecvHeightMax">VideoRecvHeightMax.</param>
        /// <param name="VideoRecvWidthMin">VideoRecvWidthMin.</param>
        /// <param name="VideoRecvWidthMax">VideoRecvWidthMax.</param>
        /// <param name="VideoSendHeightMin">VideoSendHeightMin.</param>
        /// <param name="VideoSendHeightMax">VideoSendHeightMax.</param>
        /// <param name="VideoSendWidthMin">VideoSendWidthMin.</param>
        /// <param name="VideoSendWidthMax">VideoSendWidthMax.</param>
        /// <param name="ContentRecvHeightMin">ContentRecvHeightMin.</param>
        /// <param name="ContentRecvHeightMax">ContentRecvHeightMax.</param>
        /// <param name="ContentRecvWidthMin">ContentRecvWidthMin.</param>
        /// <param name="ContentRecvWidthMax">ContentRecvWidthMax.</param>
        /// <param name="ContentSendHeightMin">ContentSendHeightMin.</param>
        /// <param name="ContentSendHeightMax">ContentSendHeightMax.</param>
        /// <param name="ContentSendWidthMin">ContentSendWidthMin.</param>
        /// <param name="ContentSendWidthMax">ContentSendWidthMax.</param>
        /// <param name="RoundTripDelayMin">RoundTripDelayMin.</param>
        /// <param name="RoundTripDelayMax">RoundTripDelayMax.</param>
        /// <param name="RoundTripDelayAvg">RoundTripDelayAvg.</param>
        /// <param name="RfactorMin">RfactorMin.</param>
        /// <param name="RfactorMax">RfactorMax.</param>
        /// <param name="RfactorAvg">RfactorAvg.</param>
        /// <param name="ProcessCpuLoadMin">ProcessCpuLoadMin.</param>
        /// <param name="ProcessCpuLoadMax">ProcessCpuLoadMax.</param>
        /// <param name="ProcessCpuLoadAvg">ProcessCpuLoadAvg.</param>
        /// <param name="SystemCpuLoadMin">SystemCpuLoadMin.</param>
        /// <param name="SystemCpuLoadMax">SystemCpuLoadMax.</param>
        /// <param name="SystemCpuLoadAvg">SystemCpuLoadAvg.</param>
        /// <param name="WifiRecvStrengthMin">WifiRecvStrengthMin.</param>
        /// <param name="WifiRecvStrengthMax">WifiRecvStrengthMax.</param>
        /// <param name="WifiRecvStrengthAvg">WifiRecvStrengthAvg.</param>
        /// <param name="KeyFrameRateAvgVI">KeyFrameRateAvgVI.</param>
        /// <param name="KeyFrameRateAvgVO">KeyFrameRateAvgVO.</param>
        /// <param name="KeyFrameRateAvgVIC">KeyFrameRateAvgVIC.</param>
        /// <param name="KeyFrameRateAvgVOC">KeyFrameRateAvgVOC.</param>
        /// <param name="KeyFrameRateMinVI">KeyFrameRateMinVI.</param>
        /// <param name="KeyFrameRateMinVO">KeyFrameRateMinVO.</param>
        /// <param name="KeyFrameRateMinVIC">KeyFrameRateMinVIC.</param>
        /// <param name="KeyFrameRateMinVOC">KeyFrameRateMinVOC.</param>
        /// <param name="KeyFrameRateMaxVI">KeyFrameRateMaxVI.</param>
        /// <param name="KeyFrameRateMaxVO">KeyFrameRateMaxVO.</param>
        /// <param name="KeyFrameRateMaxVIC">KeyFrameRateMaxVIC.</param>
        /// <param name="KeyFrameRateMaxVOC">KeyFrameRateMaxVOC.</param>
        /// <param name="RoundTripDelayAvgVO">RoundTripDelayAvgVO.</param>
        /// <param name="RoundTripDelayAvgVOC">RoundTripDelayAvgVOC.</param>
        /// <param name="RoundTripDelayAvgAO">RoundTripDelayAvgAO.</param>
        public EndpointIndigoSummaryStats(string AudioRecvCodec = default(string), string AudioSendCodec = default(string), bool? ContentRecv = default(bool?), bool? ContentSend = default(bool?), bool? TalkDetected = default(bool?), bool? SessionRelay = default(bool?), bool? SessionInRelay = default(bool?), bool? SessionOutRelay = default(bool?), bool? AudioRtpRelay = default(bool?), int? CallRate = default(int?), decimal? CumulLossPercentAI = default(decimal?), decimal? CumulLossPercentAO = default(decimal?), decimal? CumulLossPercentVI = default(decimal?), decimal? CumulLossPercentVO = default(decimal?), decimal? CumulLossPercentVIC = default(decimal?), decimal? CumulLossPercentVOC = default(decimal?), decimal? CumulLossAI = default(decimal?), decimal? CumulLossAO = default(decimal?), decimal? CumulLossVI = default(decimal?), decimal? CumulLossVO = default(decimal?), decimal? CumulLossVIC = default(decimal?), decimal? CumulLossVOC = default(decimal?), decimal? DiscontinuityCount = default(decimal?), decimal? DroppedPacketsAI = default(decimal?), decimal? DroppedPacketsVI = default(decimal?), decimal? DroppedPacketsVIC = default(decimal?), decimal? MixUnderRunsAI = default(decimal?), decimal? NetworkAvgLossAI = default(decimal?), decimal? NetworkAvgLossAO = default(decimal?), decimal? NetworkAvgLossVI = default(decimal?), decimal? NetworkAvgLossVO = default(decimal?), decimal? NetworkCumulLossAI = default(decimal?), decimal? NetworkCumulLossAO = default(decimal?), decimal? NetworkCumulLossVI = default(decimal?), decimal? NetworkCumulLossVO = default(decimal?), decimal? NetworkLossAI = default(decimal?), decimal? NetworkLossAO = default(decimal?), decimal? NetworkLossVI = default(decimal?), decimal? NetworkLossVO = default(decimal?), decimal? CallQualityMin = default(decimal?), decimal? CallQualityMax = default(decimal?), decimal? CallQualityAvg = default(decimal?), decimal? FpsMinVI = default(decimal?), decimal? FpsMinVO = default(decimal?), decimal? FpsMinVIC = default(decimal?), decimal? FpsMinVOC = default(decimal?), decimal? FpsMaxVI = default(decimal?), decimal? FpsMaxVO = default(decimal?), decimal? FpsMaxVIC = default(decimal?), decimal? FpsMaxVOC = default(decimal?), decimal? FpsAvgVI = default(decimal?), decimal? FpsAvgVO = default(decimal?), decimal? FpsAvgVIC = default(decimal?), decimal? FpsAvgVOC = default(decimal?), decimal? BitrateMinAI = default(decimal?), decimal? BitrateMinAO = default(decimal?), decimal? BitrateMinVI = default(decimal?), decimal? BitrateMinVO = default(decimal?), decimal? BitrateMinVIC = default(decimal?), decimal? BitrateMinVOC = default(decimal?), decimal? BitrateMaxAI = default(decimal?), decimal? BitrateMaxAO = default(decimal?), decimal? BitrateMaxVI = default(decimal?), decimal? BitrateMaxVO = default(decimal?), decimal? BitrateMaxVIC = default(decimal?), decimal? BitrateMaxVOC = default(decimal?), decimal? BitrateAvgAI = default(decimal?), decimal? BitrateAvgAO = default(decimal?), decimal? BitrateAvgVI = default(decimal?), decimal? BitrateAvgVO = default(decimal?), decimal? BitrateAvgVIC = default(decimal?), decimal? BitrateAvgVOC = default(decimal?), decimal? JitterMinAI = default(decimal?), decimal? JitterMinAO = default(decimal?), decimal? JitterMinVI = default(decimal?), decimal? JitterMinVO = default(decimal?), decimal? JitterMinVIC = default(decimal?), decimal? JitterMinVOC = default(decimal?), decimal? JitterMaxAI = default(decimal?), decimal? JitterMaxAO = default(decimal?), decimal? JitterMaxVI = default(decimal?), decimal? JitterMaxVO = default(decimal?), decimal? JitterMaxVIC = default(decimal?), decimal? JitterMaxVOC = default(decimal?), decimal? JitterAvgAI = default(decimal?), decimal? JitterAvgAO = default(decimal?), decimal? JitterAvgVI = default(decimal?), decimal? JitterAvgVO = default(decimal?), decimal? JitterAvgVIC = default(decimal?), decimal? JitterAvgVOC = default(decimal?), decimal? MaxJitterMinAI = default(decimal?), decimal? MaxJitterMinVI = default(decimal?), decimal? MaxJitterMinVIC = default(decimal?), decimal? MaxJitterMaxAI = default(decimal?), decimal? MaxJitterMaxVI = default(decimal?), decimal? MaxJitterMaxVIC = default(decimal?), decimal? MaxJitterAvgAI = default(decimal?), decimal? MaxJitterAvgVI = default(decimal?), decimal? MaxJitterAvgVIC = default(decimal?), decimal? VideoRecvHeightMin = default(decimal?), decimal? VideoRecvHeightMax = default(decimal?), decimal? VideoRecvWidthMin = default(decimal?), decimal? VideoRecvWidthMax = default(decimal?), decimal? VideoSendHeightMin = default(decimal?), decimal? VideoSendHeightMax = default(decimal?), decimal? VideoSendWidthMin = default(decimal?), decimal? VideoSendWidthMax = default(decimal?), decimal? ContentRecvHeightMin = default(decimal?), decimal? ContentRecvHeightMax = default(decimal?), decimal? ContentRecvWidthMin = default(decimal?), decimal? ContentRecvWidthMax = default(decimal?), decimal? ContentSendHeightMin = default(decimal?), decimal? ContentSendHeightMax = default(decimal?), decimal? ContentSendWidthMin = default(decimal?), decimal? ContentSendWidthMax = default(decimal?), decimal? RoundTripDelayMin = default(decimal?), decimal? RoundTripDelayMax = default(decimal?), decimal? RoundTripDelayAvg = default(decimal?), decimal? RfactorMin = default(decimal?), decimal? RfactorMax = default(decimal?), decimal? RfactorAvg = default(decimal?), decimal? ProcessCpuLoadMin = default(decimal?), decimal? ProcessCpuLoadMax = default(decimal?), decimal? ProcessCpuLoadAvg = default(decimal?), decimal? SystemCpuLoadMin = default(decimal?), decimal? SystemCpuLoadMax = default(decimal?), decimal? SystemCpuLoadAvg = default(decimal?), decimal? WifiRecvStrengthMin = default(decimal?), decimal? WifiRecvStrengthMax = default(decimal?), decimal? WifiRecvStrengthAvg = default(decimal?), decimal? KeyFrameRateAvgVI = default(decimal?), decimal? KeyFrameRateAvgVO = default(decimal?), decimal? KeyFrameRateAvgVIC = default(decimal?), decimal? KeyFrameRateAvgVOC = default(decimal?), decimal? KeyFrameRateMinVI = default(decimal?), decimal? KeyFrameRateMinVO = default(decimal?), decimal? KeyFrameRateMinVIC = default(decimal?), decimal? KeyFrameRateMinVOC = default(decimal?), decimal? KeyFrameRateMaxVI = default(decimal?), decimal? KeyFrameRateMaxVO = default(decimal?), decimal? KeyFrameRateMaxVIC = default(decimal?), decimal? KeyFrameRateMaxVOC = default(decimal?), decimal? RoundTripDelayAvgVO = default(decimal?), decimal? RoundTripDelayAvgVOC = default(decimal?), decimal? RoundTripDelayAvgAO = default(decimal?))
        {
            this.AudioRecvCodec = AudioRecvCodec;
            this.AudioSendCodec = AudioSendCodec;
            this.ContentRecv = ContentRecv;
            this.ContentSend = ContentSend;
            this.TalkDetected = TalkDetected;
            this.SessionRelay = SessionRelay;
            this.SessionInRelay = SessionInRelay;
            this.SessionOutRelay = SessionOutRelay;
            this.AudioRtpRelay = AudioRtpRelay;
            this.CallRate = CallRate;
            this.CumulLossPercentAI = CumulLossPercentAI;
            this.CumulLossPercentAO = CumulLossPercentAO;
            this.CumulLossPercentVI = CumulLossPercentVI;
            this.CumulLossPercentVO = CumulLossPercentVO;
            this.CumulLossPercentVIC = CumulLossPercentVIC;
            this.CumulLossPercentVOC = CumulLossPercentVOC;
            this.CumulLossAI = CumulLossAI;
            this.CumulLossAO = CumulLossAO;
            this.CumulLossVI = CumulLossVI;
            this.CumulLossVO = CumulLossVO;
            this.CumulLossVIC = CumulLossVIC;
            this.CumulLossVOC = CumulLossVOC;
            this.DiscontinuityCount = DiscontinuityCount;
            this.DroppedPacketsAI = DroppedPacketsAI;
            this.DroppedPacketsVI = DroppedPacketsVI;
            this.DroppedPacketsVIC = DroppedPacketsVIC;
            this.MixUnderRunsAI = MixUnderRunsAI;
            this.NetworkAvgLossAI = NetworkAvgLossAI;
            this.NetworkAvgLossAO = NetworkAvgLossAO;
            this.NetworkAvgLossVI = NetworkAvgLossVI;
            this.NetworkAvgLossVO = NetworkAvgLossVO;
            this.NetworkCumulLossAI = NetworkCumulLossAI;
            this.NetworkCumulLossAO = NetworkCumulLossAO;
            this.NetworkCumulLossVI = NetworkCumulLossVI;
            this.NetworkCumulLossVO = NetworkCumulLossVO;
            this.NetworkLossAI = NetworkLossAI;
            this.NetworkLossAO = NetworkLossAO;
            this.NetworkLossVI = NetworkLossVI;
            this.NetworkLossVO = NetworkLossVO;
            this.CallQualityMin = CallQualityMin;
            this.CallQualityMax = CallQualityMax;
            this.CallQualityAvg = CallQualityAvg;
            this.FpsMinVI = FpsMinVI;
            this.FpsMinVO = FpsMinVO;
            this.FpsMinVIC = FpsMinVIC;
            this.FpsMinVOC = FpsMinVOC;
            this.FpsMaxVI = FpsMaxVI;
            this.FpsMaxVO = FpsMaxVO;
            this.FpsMaxVIC = FpsMaxVIC;
            this.FpsMaxVOC = FpsMaxVOC;
            this.FpsAvgVI = FpsAvgVI;
            this.FpsAvgVO = FpsAvgVO;
            this.FpsAvgVIC = FpsAvgVIC;
            this.FpsAvgVOC = FpsAvgVOC;
            this.BitrateMinAI = BitrateMinAI;
            this.BitrateMinAO = BitrateMinAO;
            this.BitrateMinVI = BitrateMinVI;
            this.BitrateMinVO = BitrateMinVO;
            this.BitrateMinVIC = BitrateMinVIC;
            this.BitrateMinVOC = BitrateMinVOC;
            this.BitrateMaxAI = BitrateMaxAI;
            this.BitrateMaxAO = BitrateMaxAO;
            this.BitrateMaxVI = BitrateMaxVI;
            this.BitrateMaxVO = BitrateMaxVO;
            this.BitrateMaxVIC = BitrateMaxVIC;
            this.BitrateMaxVOC = BitrateMaxVOC;
            this.BitrateAvgAI = BitrateAvgAI;
            this.BitrateAvgAO = BitrateAvgAO;
            this.BitrateAvgVI = BitrateAvgVI;
            this.BitrateAvgVO = BitrateAvgVO;
            this.BitrateAvgVIC = BitrateAvgVIC;
            this.BitrateAvgVOC = BitrateAvgVOC;
            this.JitterMinAI = JitterMinAI;
            this.JitterMinAO = JitterMinAO;
            this.JitterMinVI = JitterMinVI;
            this.JitterMinVO = JitterMinVO;
            this.JitterMinVIC = JitterMinVIC;
            this.JitterMinVOC = JitterMinVOC;
            this.JitterMaxAI = JitterMaxAI;
            this.JitterMaxAO = JitterMaxAO;
            this.JitterMaxVI = JitterMaxVI;
            this.JitterMaxVO = JitterMaxVO;
            this.JitterMaxVIC = JitterMaxVIC;
            this.JitterMaxVOC = JitterMaxVOC;
            this.JitterAvgAI = JitterAvgAI;
            this.JitterAvgAO = JitterAvgAO;
            this.JitterAvgVI = JitterAvgVI;
            this.JitterAvgVO = JitterAvgVO;
            this.JitterAvgVIC = JitterAvgVIC;
            this.JitterAvgVOC = JitterAvgVOC;
            this.MaxJitterMinAI = MaxJitterMinAI;
            this.MaxJitterMinVI = MaxJitterMinVI;
            this.MaxJitterMinVIC = MaxJitterMinVIC;
            this.MaxJitterMaxAI = MaxJitterMaxAI;
            this.MaxJitterMaxVI = MaxJitterMaxVI;
            this.MaxJitterMaxVIC = MaxJitterMaxVIC;
            this.MaxJitterAvgAI = MaxJitterAvgAI;
            this.MaxJitterAvgVI = MaxJitterAvgVI;
            this.MaxJitterAvgVIC = MaxJitterAvgVIC;
            this.VideoRecvHeightMin = VideoRecvHeightMin;
            this.VideoRecvHeightMax = VideoRecvHeightMax;
            this.VideoRecvWidthMin = VideoRecvWidthMin;
            this.VideoRecvWidthMax = VideoRecvWidthMax;
            this.VideoSendHeightMin = VideoSendHeightMin;
            this.VideoSendHeightMax = VideoSendHeightMax;
            this.VideoSendWidthMin = VideoSendWidthMin;
            this.VideoSendWidthMax = VideoSendWidthMax;
            this.ContentRecvHeightMin = ContentRecvHeightMin;
            this.ContentRecvHeightMax = ContentRecvHeightMax;
            this.ContentRecvWidthMin = ContentRecvWidthMin;
            this.ContentRecvWidthMax = ContentRecvWidthMax;
            this.ContentSendHeightMin = ContentSendHeightMin;
            this.ContentSendHeightMax = ContentSendHeightMax;
            this.ContentSendWidthMin = ContentSendWidthMin;
            this.ContentSendWidthMax = ContentSendWidthMax;
            this.RoundTripDelayMin = RoundTripDelayMin;
            this.RoundTripDelayMax = RoundTripDelayMax;
            this.RoundTripDelayAvg = RoundTripDelayAvg;
            this.RfactorMin = RfactorMin;
            this.RfactorMax = RfactorMax;
            this.RfactorAvg = RfactorAvg;
            this.ProcessCpuLoadMin = ProcessCpuLoadMin;
            this.ProcessCpuLoadMax = ProcessCpuLoadMax;
            this.ProcessCpuLoadAvg = ProcessCpuLoadAvg;
            this.SystemCpuLoadMin = SystemCpuLoadMin;
            this.SystemCpuLoadMax = SystemCpuLoadMax;
            this.SystemCpuLoadAvg = SystemCpuLoadAvg;
            this.WifiRecvStrengthMin = WifiRecvStrengthMin;
            this.WifiRecvStrengthMax = WifiRecvStrengthMax;
            this.WifiRecvStrengthAvg = WifiRecvStrengthAvg;
            this.KeyFrameRateAvgVI = KeyFrameRateAvgVI;
            this.KeyFrameRateAvgVO = KeyFrameRateAvgVO;
            this.KeyFrameRateAvgVIC = KeyFrameRateAvgVIC;
            this.KeyFrameRateAvgVOC = KeyFrameRateAvgVOC;
            this.KeyFrameRateMinVI = KeyFrameRateMinVI;
            this.KeyFrameRateMinVO = KeyFrameRateMinVO;
            this.KeyFrameRateMinVIC = KeyFrameRateMinVIC;
            this.KeyFrameRateMinVOC = KeyFrameRateMinVOC;
            this.KeyFrameRateMaxVI = KeyFrameRateMaxVI;
            this.KeyFrameRateMaxVO = KeyFrameRateMaxVO;
            this.KeyFrameRateMaxVIC = KeyFrameRateMaxVIC;
            this.KeyFrameRateMaxVOC = KeyFrameRateMaxVOC;
            this.RoundTripDelayAvgVO = RoundTripDelayAvgVO;
            this.RoundTripDelayAvgVOC = RoundTripDelayAvgVOC;
            this.RoundTripDelayAvgAO = RoundTripDelayAvgAO;
        }
        
        /// <summary>
        /// Gets or Sets AudioRecvCodec
        /// </summary>
        [DataMember(Name="audioRecvCodec", EmitDefaultValue=false)]
        public string AudioRecvCodec { get; set; }

        /// <summary>
        /// Gets or Sets AudioSendCodec
        /// </summary>
        [DataMember(Name="audioSendCodec", EmitDefaultValue=false)]
        public string AudioSendCodec { get; set; }

        /// <summary>
        /// Gets or Sets ContentRecv
        /// </summary>
        [DataMember(Name="contentRecv", EmitDefaultValue=false)]
        public bool? ContentRecv { get; set; }

        /// <summary>
        /// Gets or Sets ContentSend
        /// </summary>
        [DataMember(Name="contentSend", EmitDefaultValue=false)]
        public bool? ContentSend { get; set; }

        /// <summary>
        /// Gets or Sets TalkDetected
        /// </summary>
        [DataMember(Name="talkDetected", EmitDefaultValue=false)]
        public bool? TalkDetected { get; set; }

        /// <summary>
        /// Gets or Sets SessionRelay
        /// </summary>
        [DataMember(Name="sessionRelay", EmitDefaultValue=false)]
        public bool? SessionRelay { get; set; }

        /// <summary>
        /// Gets or Sets SessionInRelay
        /// </summary>
        [DataMember(Name="sessionInRelay", EmitDefaultValue=false)]
        public bool? SessionInRelay { get; set; }

        /// <summary>
        /// Gets or Sets SessionOutRelay
        /// </summary>
        [DataMember(Name="sessionOutRelay", EmitDefaultValue=false)]
        public bool? SessionOutRelay { get; set; }

        /// <summary>
        /// Gets or Sets AudioRtpRelay
        /// </summary>
        [DataMember(Name="audioRtpRelay", EmitDefaultValue=false)]
        public bool? AudioRtpRelay { get; set; }

        /// <summary>
        /// Gets or Sets CallRate
        /// </summary>
        [DataMember(Name="callRate", EmitDefaultValue=false)]
        public int? CallRate { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossPercentAI
        /// </summary>
        [DataMember(Name="cumulLoss_Percent_AI", EmitDefaultValue=false)]
        public decimal? CumulLossPercentAI { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossPercentAO
        /// </summary>
        [DataMember(Name="cumulLoss_Percent_AO", EmitDefaultValue=false)]
        public decimal? CumulLossPercentAO { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossPercentVI
        /// </summary>
        [DataMember(Name="cumulLoss_Percent_VI", EmitDefaultValue=false)]
        public decimal? CumulLossPercentVI { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossPercentVO
        /// </summary>
        [DataMember(Name="cumulLoss_Percent_VO", EmitDefaultValue=false)]
        public decimal? CumulLossPercentVO { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossPercentVIC
        /// </summary>
        [DataMember(Name="cumulLoss_Percent_VIC", EmitDefaultValue=false)]
        public decimal? CumulLossPercentVIC { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossPercentVOC
        /// </summary>
        [DataMember(Name="cumulLoss_Percent_VOC", EmitDefaultValue=false)]
        public decimal? CumulLossPercentVOC { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossAI
        /// </summary>
        [DataMember(Name="cumulLoss_AI", EmitDefaultValue=false)]
        public decimal? CumulLossAI { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossAO
        /// </summary>
        [DataMember(Name="cumulLoss_AO", EmitDefaultValue=false)]
        public decimal? CumulLossAO { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossVI
        /// </summary>
        [DataMember(Name="cumulLoss_VI", EmitDefaultValue=false)]
        public decimal? CumulLossVI { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossVO
        /// </summary>
        [DataMember(Name="cumulLoss_VO", EmitDefaultValue=false)]
        public decimal? CumulLossVO { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossVIC
        /// </summary>
        [DataMember(Name="cumulLoss_VIC", EmitDefaultValue=false)]
        public decimal? CumulLossVIC { get; set; }

        /// <summary>
        /// Gets or Sets CumulLossVOC
        /// </summary>
        [DataMember(Name="cumulLoss_VOC", EmitDefaultValue=false)]
        public decimal? CumulLossVOC { get; set; }

        /// <summary>
        /// Gets or Sets DiscontinuityCount
        /// </summary>
        [DataMember(Name="discontinuityCount", EmitDefaultValue=false)]
        public decimal? DiscontinuityCount { get; set; }

        /// <summary>
        /// Gets or Sets DroppedPacketsAI
        /// </summary>
        [DataMember(Name="droppedPackets_AI", EmitDefaultValue=false)]
        public decimal? DroppedPacketsAI { get; set; }

        /// <summary>
        /// Gets or Sets DroppedPacketsVI
        /// </summary>
        [DataMember(Name="droppedPackets_VI", EmitDefaultValue=false)]
        public decimal? DroppedPacketsVI { get; set; }

        /// <summary>
        /// Gets or Sets DroppedPacketsVIC
        /// </summary>
        [DataMember(Name="droppedPackets_VIC", EmitDefaultValue=false)]
        public decimal? DroppedPacketsVIC { get; set; }

        /// <summary>
        /// Gets or Sets MixUnderRunsAI
        /// </summary>
        [DataMember(Name="mixUnderRuns_AI", EmitDefaultValue=false)]
        public decimal? MixUnderRunsAI { get; set; }

        /// <summary>
        /// Gets or Sets NetworkAvgLossAI
        /// </summary>
        [DataMember(Name="networkAvgLoss_AI", EmitDefaultValue=false)]
        public decimal? NetworkAvgLossAI { get; set; }

        /// <summary>
        /// Gets or Sets NetworkAvgLossAO
        /// </summary>
        [DataMember(Name="networkAvgLoss_AO", EmitDefaultValue=false)]
        public decimal? NetworkAvgLossAO { get; set; }

        /// <summary>
        /// Gets or Sets NetworkAvgLossVI
        /// </summary>
        [DataMember(Name="networkAvgLoss_VI", EmitDefaultValue=false)]
        public decimal? NetworkAvgLossVI { get; set; }

        /// <summary>
        /// Gets or Sets NetworkAvgLossVO
        /// </summary>
        [DataMember(Name="networkAvgLoss_VO", EmitDefaultValue=false)]
        public decimal? NetworkAvgLossVO { get; set; }

        /// <summary>
        /// Gets or Sets NetworkCumulLossAI
        /// </summary>
        [DataMember(Name="networkCumulLoss_AI", EmitDefaultValue=false)]
        public decimal? NetworkCumulLossAI { get; set; }

        /// <summary>
        /// Gets or Sets NetworkCumulLossAO
        /// </summary>
        [DataMember(Name="networkCumulLoss_AO", EmitDefaultValue=false)]
        public decimal? NetworkCumulLossAO { get; set; }

        /// <summary>
        /// Gets or Sets NetworkCumulLossVI
        /// </summary>
        [DataMember(Name="networkCumulLoss_VI", EmitDefaultValue=false)]
        public decimal? NetworkCumulLossVI { get; set; }

        /// <summary>
        /// Gets or Sets NetworkCumulLossVO
        /// </summary>
        [DataMember(Name="networkCumulLoss_VO", EmitDefaultValue=false)]
        public decimal? NetworkCumulLossVO { get; set; }

        /// <summary>
        /// Gets or Sets NetworkLossAI
        /// </summary>
        [DataMember(Name="networkLoss_AI", EmitDefaultValue=false)]
        public decimal? NetworkLossAI { get; set; }

        /// <summary>
        /// Gets or Sets NetworkLossAO
        /// </summary>
        [DataMember(Name="networkLoss_AO", EmitDefaultValue=false)]
        public decimal? NetworkLossAO { get; set; }

        /// <summary>
        /// Gets or Sets NetworkLossVI
        /// </summary>
        [DataMember(Name="networkLoss_VI", EmitDefaultValue=false)]
        public decimal? NetworkLossVI { get; set; }

        /// <summary>
        /// Gets or Sets NetworkLossVO
        /// </summary>
        [DataMember(Name="networkLoss_VO", EmitDefaultValue=false)]
        public decimal? NetworkLossVO { get; set; }

        /// <summary>
        /// Gets or Sets CallQualityMin
        /// </summary>
        [DataMember(Name="callQuality_Min", EmitDefaultValue=false)]
        public decimal? CallQualityMin { get; set; }

        /// <summary>
        /// Gets or Sets CallQualityMax
        /// </summary>
        [DataMember(Name="callQuality_Max", EmitDefaultValue=false)]
        public decimal? CallQualityMax { get; set; }

        /// <summary>
        /// Gets or Sets CallQualityAvg
        /// </summary>
        [DataMember(Name="callQuality_Avg", EmitDefaultValue=false)]
        public decimal? CallQualityAvg { get; set; }

        /// <summary>
        /// Gets or Sets FpsMinVI
        /// </summary>
        [DataMember(Name="fps_Min_VI", EmitDefaultValue=false)]
        public decimal? FpsMinVI { get; set; }

        /// <summary>
        /// Gets or Sets FpsMinVO
        /// </summary>
        [DataMember(Name="fps_Min_VO", EmitDefaultValue=false)]
        public decimal? FpsMinVO { get; set; }

        /// <summary>
        /// Gets or Sets FpsMinVIC
        /// </summary>
        [DataMember(Name="fps_Min_VIC", EmitDefaultValue=false)]
        public decimal? FpsMinVIC { get; set; }

        /// <summary>
        /// Gets or Sets FpsMinVOC
        /// </summary>
        [DataMember(Name="fps_Min_VOC", EmitDefaultValue=false)]
        public decimal? FpsMinVOC { get; set; }

        /// <summary>
        /// Gets or Sets FpsMaxVI
        /// </summary>
        [DataMember(Name="fps_Max_VI", EmitDefaultValue=false)]
        public decimal? FpsMaxVI { get; set; }

        /// <summary>
        /// Gets or Sets FpsMaxVO
        /// </summary>
        [DataMember(Name="fps_Max_VO", EmitDefaultValue=false)]
        public decimal? FpsMaxVO { get; set; }

        /// <summary>
        /// Gets or Sets FpsMaxVIC
        /// </summary>
        [DataMember(Name="fps_Max_VIC", EmitDefaultValue=false)]
        public decimal? FpsMaxVIC { get; set; }

        /// <summary>
        /// Gets or Sets FpsMaxVOC
        /// </summary>
        [DataMember(Name="fps_Max_VOC", EmitDefaultValue=false)]
        public decimal? FpsMaxVOC { get; set; }

        /// <summary>
        /// Gets or Sets FpsAvgVI
        /// </summary>
        [DataMember(Name="fps_Avg_VI", EmitDefaultValue=false)]
        public decimal? FpsAvgVI { get; set; }

        /// <summary>
        /// Gets or Sets FpsAvgVO
        /// </summary>
        [DataMember(Name="fps_Avg_VO", EmitDefaultValue=false)]
        public decimal? FpsAvgVO { get; set; }

        /// <summary>
        /// Gets or Sets FpsAvgVIC
        /// </summary>
        [DataMember(Name="fps_Avg_VIC", EmitDefaultValue=false)]
        public decimal? FpsAvgVIC { get; set; }

        /// <summary>
        /// Gets or Sets FpsAvgVOC
        /// </summary>
        [DataMember(Name="fps_Avg_VOC", EmitDefaultValue=false)]
        public decimal? FpsAvgVOC { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMinAI
        /// </summary>
        [DataMember(Name="bitrate_Min_AI", EmitDefaultValue=false)]
        public decimal? BitrateMinAI { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMinAO
        /// </summary>
        [DataMember(Name="bitrate_Min_AO", EmitDefaultValue=false)]
        public decimal? BitrateMinAO { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMinVI
        /// </summary>
        [DataMember(Name="bitrate_Min_VI", EmitDefaultValue=false)]
        public decimal? BitrateMinVI { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMinVO
        /// </summary>
        [DataMember(Name="bitrate_Min_VO", EmitDefaultValue=false)]
        public decimal? BitrateMinVO { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMinVIC
        /// </summary>
        [DataMember(Name="bitrate_Min_VIC", EmitDefaultValue=false)]
        public decimal? BitrateMinVIC { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMinVOC
        /// </summary>
        [DataMember(Name="bitrate_Min_VOC", EmitDefaultValue=false)]
        public decimal? BitrateMinVOC { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMaxAI
        /// </summary>
        [DataMember(Name="bitrate_Max_AI", EmitDefaultValue=false)]
        public decimal? BitrateMaxAI { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMaxAO
        /// </summary>
        [DataMember(Name="bitrate_Max_AO", EmitDefaultValue=false)]
        public decimal? BitrateMaxAO { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMaxVI
        /// </summary>
        [DataMember(Name="bitrate_Max_VI", EmitDefaultValue=false)]
        public decimal? BitrateMaxVI { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMaxVO
        /// </summary>
        [DataMember(Name="bitrate_Max_VO", EmitDefaultValue=false)]
        public decimal? BitrateMaxVO { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMaxVIC
        /// </summary>
        [DataMember(Name="bitrate_Max_VIC", EmitDefaultValue=false)]
        public decimal? BitrateMaxVIC { get; set; }

        /// <summary>
        /// Gets or Sets BitrateMaxVOC
        /// </summary>
        [DataMember(Name="bitrate_Max_VOC", EmitDefaultValue=false)]
        public decimal? BitrateMaxVOC { get; set; }

        /// <summary>
        /// Gets or Sets BitrateAvgAI
        /// </summary>
        [DataMember(Name="bitrate_Avg_AI", EmitDefaultValue=false)]
        public decimal? BitrateAvgAI { get; set; }

        /// <summary>
        /// Gets or Sets BitrateAvgAO
        /// </summary>
        [DataMember(Name="bitrate_Avg_AO", EmitDefaultValue=false)]
        public decimal? BitrateAvgAO { get; set; }

        /// <summary>
        /// Gets or Sets BitrateAvgVI
        /// </summary>
        [DataMember(Name="bitrate_Avg_VI", EmitDefaultValue=false)]
        public decimal? BitrateAvgVI { get; set; }

        /// <summary>
        /// Gets or Sets BitrateAvgVO
        /// </summary>
        [DataMember(Name="bitrate_Avg_VO", EmitDefaultValue=false)]
        public decimal? BitrateAvgVO { get; set; }

        /// <summary>
        /// Gets or Sets BitrateAvgVIC
        /// </summary>
        [DataMember(Name="bitrate_Avg_VIC", EmitDefaultValue=false)]
        public decimal? BitrateAvgVIC { get; set; }

        /// <summary>
        /// Gets or Sets BitrateAvgVOC
        /// </summary>
        [DataMember(Name="bitrate_Avg_VOC", EmitDefaultValue=false)]
        public decimal? BitrateAvgVOC { get; set; }

        /// <summary>
        /// Gets or Sets JitterMinAI
        /// </summary>
        [DataMember(Name="jitter_Min_AI", EmitDefaultValue=false)]
        public decimal? JitterMinAI { get; set; }

        /// <summary>
        /// Gets or Sets JitterMinAO
        /// </summary>
        [DataMember(Name="jitter_Min_AO", EmitDefaultValue=false)]
        public decimal? JitterMinAO { get; set; }

        /// <summary>
        /// Gets or Sets JitterMinVI
        /// </summary>
        [DataMember(Name="jitter_Min_VI", EmitDefaultValue=false)]
        public decimal? JitterMinVI { get; set; }

        /// <summary>
        /// Gets or Sets JitterMinVO
        /// </summary>
        [DataMember(Name="jitter_Min_VO", EmitDefaultValue=false)]
        public decimal? JitterMinVO { get; set; }

        /// <summary>
        /// Gets or Sets JitterMinVIC
        /// </summary>
        [DataMember(Name="jitter_Min_VIC", EmitDefaultValue=false)]
        public decimal? JitterMinVIC { get; set; }

        /// <summary>
        /// Gets or Sets JitterMinVOC
        /// </summary>
        [DataMember(Name="jitter_Min_VOC", EmitDefaultValue=false)]
        public decimal? JitterMinVOC { get; set; }

        /// <summary>
        /// Gets or Sets JitterMaxAI
        /// </summary>
        [DataMember(Name="jitter_Max_AI", EmitDefaultValue=false)]
        public decimal? JitterMaxAI { get; set; }

        /// <summary>
        /// Gets or Sets JitterMaxAO
        /// </summary>
        [DataMember(Name="jitter_Max_AO", EmitDefaultValue=false)]
        public decimal? JitterMaxAO { get; set; }

        /// <summary>
        /// Gets or Sets JitterMaxVI
        /// </summary>
        [DataMember(Name="jitter_Max_VI", EmitDefaultValue=false)]
        public decimal? JitterMaxVI { get; set; }

        /// <summary>
        /// Gets or Sets JitterMaxVO
        /// </summary>
        [DataMember(Name="jitter_Max_VO", EmitDefaultValue=false)]
        public decimal? JitterMaxVO { get; set; }

        /// <summary>
        /// Gets or Sets JitterMaxVIC
        /// </summary>
        [DataMember(Name="jitter_Max_VIC", EmitDefaultValue=false)]
        public decimal? JitterMaxVIC { get; set; }

        /// <summary>
        /// Gets or Sets JitterMaxVOC
        /// </summary>
        [DataMember(Name="jitter_Max_VOC", EmitDefaultValue=false)]
        public decimal? JitterMaxVOC { get; set; }

        /// <summary>
        /// Gets or Sets JitterAvgAI
        /// </summary>
        [DataMember(Name="jitter_Avg_AI", EmitDefaultValue=false)]
        public decimal? JitterAvgAI { get; set; }

        /// <summary>
        /// Gets or Sets JitterAvgAO
        /// </summary>
        [DataMember(Name="jitter_Avg_AO", EmitDefaultValue=false)]
        public decimal? JitterAvgAO { get; set; }

        /// <summary>
        /// Gets or Sets JitterAvgVI
        /// </summary>
        [DataMember(Name="jitter_Avg_VI", EmitDefaultValue=false)]
        public decimal? JitterAvgVI { get; set; }

        /// <summary>
        /// Gets or Sets JitterAvgVO
        /// </summary>
        [DataMember(Name="jitter_Avg_VO", EmitDefaultValue=false)]
        public decimal? JitterAvgVO { get; set; }

        /// <summary>
        /// Gets or Sets JitterAvgVIC
        /// </summary>
        [DataMember(Name="jitter_Avg_VIC", EmitDefaultValue=false)]
        public decimal? JitterAvgVIC { get; set; }

        /// <summary>
        /// Gets or Sets JitterAvgVOC
        /// </summary>
        [DataMember(Name="jitter_Avg_VOC", EmitDefaultValue=false)]
        public decimal? JitterAvgVOC { get; set; }

        /// <summary>
        /// Gets or Sets MaxJitterMinAI
        /// </summary>
        [DataMember(Name="maxJitter_Min_AI", EmitDefaultValue=false)]
        public decimal? MaxJitterMinAI { get; set; }

        /// <summary>
        /// Gets or Sets MaxJitterMinVI
        /// </summary>
        [DataMember(Name="maxJitter_Min_VI", EmitDefaultValue=false)]
        public decimal? MaxJitterMinVI { get; set; }

        /// <summary>
        /// Gets or Sets MaxJitterMinVIC
        /// </summary>
        [DataMember(Name="maxJitter_Min_VIC", EmitDefaultValue=false)]
        public decimal? MaxJitterMinVIC { get; set; }

        /// <summary>
        /// Gets or Sets MaxJitterMaxAI
        /// </summary>
        [DataMember(Name="maxJitter_Max_AI", EmitDefaultValue=false)]
        public decimal? MaxJitterMaxAI { get; set; }

        /// <summary>
        /// Gets or Sets MaxJitterMaxVI
        /// </summary>
        [DataMember(Name="maxJitter_Max_VI", EmitDefaultValue=false)]
        public decimal? MaxJitterMaxVI { get; set; }

        /// <summary>
        /// Gets or Sets MaxJitterMaxVIC
        /// </summary>
        [DataMember(Name="maxJitter_Max_VIC", EmitDefaultValue=false)]
        public decimal? MaxJitterMaxVIC { get; set; }

        /// <summary>
        /// Gets or Sets MaxJitterAvgAI
        /// </summary>
        [DataMember(Name="maxJitter_Avg_AI", EmitDefaultValue=false)]
        public decimal? MaxJitterAvgAI { get; set; }

        /// <summary>
        /// Gets or Sets MaxJitterAvgVI
        /// </summary>
        [DataMember(Name="maxJitter_Avg_VI", EmitDefaultValue=false)]
        public decimal? MaxJitterAvgVI { get; set; }

        /// <summary>
        /// Gets or Sets MaxJitterAvgVIC
        /// </summary>
        [DataMember(Name="maxJitter_Avg_VIC", EmitDefaultValue=false)]
        public decimal? MaxJitterAvgVIC { get; set; }

        /// <summary>
        /// Gets or Sets VideoRecvHeightMin
        /// </summary>
        [DataMember(Name="videoRecvHeight_Min", EmitDefaultValue=false)]
        public decimal? VideoRecvHeightMin { get; set; }

        /// <summary>
        /// Gets or Sets VideoRecvHeightMax
        /// </summary>
        [DataMember(Name="videoRecvHeight_Max", EmitDefaultValue=false)]
        public decimal? VideoRecvHeightMax { get; set; }

        /// <summary>
        /// Gets or Sets VideoRecvWidthMin
        /// </summary>
        [DataMember(Name="videoRecvWidth_Min", EmitDefaultValue=false)]
        public decimal? VideoRecvWidthMin { get; set; }

        /// <summary>
        /// Gets or Sets VideoRecvWidthMax
        /// </summary>
        [DataMember(Name="videoRecvWidth_Max", EmitDefaultValue=false)]
        public decimal? VideoRecvWidthMax { get; set; }

        /// <summary>
        /// Gets or Sets VideoSendHeightMin
        /// </summary>
        [DataMember(Name="videoSendHeight_Min", EmitDefaultValue=false)]
        public decimal? VideoSendHeightMin { get; set; }

        /// <summary>
        /// Gets or Sets VideoSendHeightMax
        /// </summary>
        [DataMember(Name="videoSendHeight_Max", EmitDefaultValue=false)]
        public decimal? VideoSendHeightMax { get; set; }

        /// <summary>
        /// Gets or Sets VideoSendWidthMin
        /// </summary>
        [DataMember(Name="videoSendWidth_Min", EmitDefaultValue=false)]
        public decimal? VideoSendWidthMin { get; set; }

        /// <summary>
        /// Gets or Sets VideoSendWidthMax
        /// </summary>
        [DataMember(Name="videoSendWidth_Max", EmitDefaultValue=false)]
        public decimal? VideoSendWidthMax { get; set; }

        /// <summary>
        /// Gets or Sets ContentRecvHeightMin
        /// </summary>
        [DataMember(Name="contentRecvHeight_Min", EmitDefaultValue=false)]
        public decimal? ContentRecvHeightMin { get; set; }

        /// <summary>
        /// Gets or Sets ContentRecvHeightMax
        /// </summary>
        [DataMember(Name="contentRecvHeight_Max", EmitDefaultValue=false)]
        public decimal? ContentRecvHeightMax { get; set; }

        /// <summary>
        /// Gets or Sets ContentRecvWidthMin
        /// </summary>
        [DataMember(Name="contentRecvWidth_Min", EmitDefaultValue=false)]
        public decimal? ContentRecvWidthMin { get; set; }

        /// <summary>
        /// Gets or Sets ContentRecvWidthMax
        /// </summary>
        [DataMember(Name="contentRecvWidth_Max", EmitDefaultValue=false)]
        public decimal? ContentRecvWidthMax { get; set; }

        /// <summary>
        /// Gets or Sets ContentSendHeightMin
        /// </summary>
        [DataMember(Name="contentSendHeight_Min", EmitDefaultValue=false)]
        public decimal? ContentSendHeightMin { get; set; }

        /// <summary>
        /// Gets or Sets ContentSendHeightMax
        /// </summary>
        [DataMember(Name="contentSendHeight_Max", EmitDefaultValue=false)]
        public decimal? ContentSendHeightMax { get; set; }

        /// <summary>
        /// Gets or Sets ContentSendWidthMin
        /// </summary>
        [DataMember(Name="contentSendWidth_Min", EmitDefaultValue=false)]
        public decimal? ContentSendWidthMin { get; set; }

        /// <summary>
        /// Gets or Sets ContentSendWidthMax
        /// </summary>
        [DataMember(Name="contentSendWidth_Max", EmitDefaultValue=false)]
        public decimal? ContentSendWidthMax { get; set; }

        /// <summary>
        /// Gets or Sets RoundTripDelayMin
        /// </summary>
        [DataMember(Name="roundTripDelay_Min", EmitDefaultValue=false)]
        public decimal? RoundTripDelayMin { get; set; }

        /// <summary>
        /// Gets or Sets RoundTripDelayMax
        /// </summary>
        [DataMember(Name="roundTripDelay_Max", EmitDefaultValue=false)]
        public decimal? RoundTripDelayMax { get; set; }

        /// <summary>
        /// Gets or Sets RoundTripDelayAvg
        /// </summary>
        [DataMember(Name="roundTripDelay_Avg", EmitDefaultValue=false)]
        public decimal? RoundTripDelayAvg { get; set; }

        /// <summary>
        /// Gets or Sets RfactorMin
        /// </summary>
        [DataMember(Name="rfactor_Min", EmitDefaultValue=false)]
        public decimal? RfactorMin { get; set; }

        /// <summary>
        /// Gets or Sets RfactorMax
        /// </summary>
        [DataMember(Name="rfactor_Max", EmitDefaultValue=false)]
        public decimal? RfactorMax { get; set; }

        /// <summary>
        /// Gets or Sets RfactorAvg
        /// </summary>
        [DataMember(Name="rfactor_Avg", EmitDefaultValue=false)]
        public decimal? RfactorAvg { get; set; }

        /// <summary>
        /// Gets or Sets ProcessCpuLoadMin
        /// </summary>
        [DataMember(Name="processCpuLoad_Min", EmitDefaultValue=false)]
        public decimal? ProcessCpuLoadMin { get; set; }

        /// <summary>
        /// Gets or Sets ProcessCpuLoadMax
        /// </summary>
        [DataMember(Name="processCpuLoad_Max", EmitDefaultValue=false)]
        public decimal? ProcessCpuLoadMax { get; set; }

        /// <summary>
        /// Gets or Sets ProcessCpuLoadAvg
        /// </summary>
        [DataMember(Name="processCpuLoad_Avg", EmitDefaultValue=false)]
        public decimal? ProcessCpuLoadAvg { get; set; }

        /// <summary>
        /// Gets or Sets SystemCpuLoadMin
        /// </summary>
        [DataMember(Name="systemCpuLoad_Min", EmitDefaultValue=false)]
        public decimal? SystemCpuLoadMin { get; set; }

        /// <summary>
        /// Gets or Sets SystemCpuLoadMax
        /// </summary>
        [DataMember(Name="systemCpuLoad_Max", EmitDefaultValue=false)]
        public decimal? SystemCpuLoadMax { get; set; }

        /// <summary>
        /// Gets or Sets SystemCpuLoadAvg
        /// </summary>
        [DataMember(Name="systemCpuLoad_Avg", EmitDefaultValue=false)]
        public decimal? SystemCpuLoadAvg { get; set; }

        /// <summary>
        /// Gets or Sets WifiRecvStrengthMin
        /// </summary>
        [DataMember(Name="wifiRecvStrength_Min", EmitDefaultValue=false)]
        public decimal? WifiRecvStrengthMin { get; set; }

        /// <summary>
        /// Gets or Sets WifiRecvStrengthMax
        /// </summary>
        [DataMember(Name="wifiRecvStrength_Max", EmitDefaultValue=false)]
        public decimal? WifiRecvStrengthMax { get; set; }

        /// <summary>
        /// Gets or Sets WifiRecvStrengthAvg
        /// </summary>
        [DataMember(Name="wifiRecvStrength_Avg", EmitDefaultValue=false)]
        public decimal? WifiRecvStrengthAvg { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateAvgVI
        /// </summary>
        [DataMember(Name="keyFrameRate_Avg_VI", EmitDefaultValue=false)]
        public decimal? KeyFrameRateAvgVI { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateAvgVO
        /// </summary>
        [DataMember(Name="keyFrameRate_Avg_VO", EmitDefaultValue=false)]
        public decimal? KeyFrameRateAvgVO { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateAvgVIC
        /// </summary>
        [DataMember(Name="keyFrameRate_Avg_VIC", EmitDefaultValue=false)]
        public decimal? KeyFrameRateAvgVIC { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateAvgVOC
        /// </summary>
        [DataMember(Name="keyFrameRate_Avg_VOC", EmitDefaultValue=false)]
        public decimal? KeyFrameRateAvgVOC { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateMinVI
        /// </summary>
        [DataMember(Name="keyFrameRate_Min_VI", EmitDefaultValue=false)]
        public decimal? KeyFrameRateMinVI { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateMinVO
        /// </summary>
        [DataMember(Name="keyFrameRate_Min_VO", EmitDefaultValue=false)]
        public decimal? KeyFrameRateMinVO { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateMinVIC
        /// </summary>
        [DataMember(Name="keyFrameRate_Min_VIC", EmitDefaultValue=false)]
        public decimal? KeyFrameRateMinVIC { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateMinVOC
        /// </summary>
        [DataMember(Name="keyFrameRate_Min_VOC", EmitDefaultValue=false)]
        public decimal? KeyFrameRateMinVOC { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateMaxVI
        /// </summary>
        [DataMember(Name="keyFrameRate_Max_VI", EmitDefaultValue=false)]
        public decimal? KeyFrameRateMaxVI { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateMaxVO
        /// </summary>
        [DataMember(Name="keyFrameRate_Max_VO", EmitDefaultValue=false)]
        public decimal? KeyFrameRateMaxVO { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateMaxVIC
        /// </summary>
        [DataMember(Name="keyFrameRate_Max_VIC", EmitDefaultValue=false)]
        public decimal? KeyFrameRateMaxVIC { get; set; }

        /// <summary>
        /// Gets or Sets KeyFrameRateMaxVOC
        /// </summary>
        [DataMember(Name="keyFrameRate_Max_VOC", EmitDefaultValue=false)]
        public decimal? KeyFrameRateMaxVOC { get; set; }

        /// <summary>
        /// Gets or Sets RoundTripDelayAvgVO
        /// </summary>
        [DataMember(Name="roundTripDelay_Avg_VO", EmitDefaultValue=false)]
        public decimal? RoundTripDelayAvgVO { get; set; }

        /// <summary>
        /// Gets or Sets RoundTripDelayAvgVOC
        /// </summary>
        [DataMember(Name="roundTripDelay_Avg_VOC", EmitDefaultValue=false)]
        public decimal? RoundTripDelayAvgVOC { get; set; }

        /// <summary>
        /// Gets or Sets RoundTripDelayAvgAO
        /// </summary>
        [DataMember(Name="roundTripDelay_Avg_AO", EmitDefaultValue=false)]
        public decimal? RoundTripDelayAvgAO { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointIndigoSummaryStats {\n");
            sb.Append("  AudioRecvCodec: ").Append(AudioRecvCodec).Append("\n");
            sb.Append("  AudioSendCodec: ").Append(AudioSendCodec).Append("\n");
            sb.Append("  ContentRecv: ").Append(ContentRecv).Append("\n");
            sb.Append("  ContentSend: ").Append(ContentSend).Append("\n");
            sb.Append("  TalkDetected: ").Append(TalkDetected).Append("\n");
            sb.Append("  SessionRelay: ").Append(SessionRelay).Append("\n");
            sb.Append("  SessionInRelay: ").Append(SessionInRelay).Append("\n");
            sb.Append("  SessionOutRelay: ").Append(SessionOutRelay).Append("\n");
            sb.Append("  AudioRtpRelay: ").Append(AudioRtpRelay).Append("\n");
            sb.Append("  CallRate: ").Append(CallRate).Append("\n");
            sb.Append("  CumulLossPercentAI: ").Append(CumulLossPercentAI).Append("\n");
            sb.Append("  CumulLossPercentAO: ").Append(CumulLossPercentAO).Append("\n");
            sb.Append("  CumulLossPercentVI: ").Append(CumulLossPercentVI).Append("\n");
            sb.Append("  CumulLossPercentVO: ").Append(CumulLossPercentVO).Append("\n");
            sb.Append("  CumulLossPercentVIC: ").Append(CumulLossPercentVIC).Append("\n");
            sb.Append("  CumulLossPercentVOC: ").Append(CumulLossPercentVOC).Append("\n");
            sb.Append("  CumulLossAI: ").Append(CumulLossAI).Append("\n");
            sb.Append("  CumulLossAO: ").Append(CumulLossAO).Append("\n");
            sb.Append("  CumulLossVI: ").Append(CumulLossVI).Append("\n");
            sb.Append("  CumulLossVO: ").Append(CumulLossVO).Append("\n");
            sb.Append("  CumulLossVIC: ").Append(CumulLossVIC).Append("\n");
            sb.Append("  CumulLossVOC: ").Append(CumulLossVOC).Append("\n");
            sb.Append("  DiscontinuityCount: ").Append(DiscontinuityCount).Append("\n");
            sb.Append("  DroppedPacketsAI: ").Append(DroppedPacketsAI).Append("\n");
            sb.Append("  DroppedPacketsVI: ").Append(DroppedPacketsVI).Append("\n");
            sb.Append("  DroppedPacketsVIC: ").Append(DroppedPacketsVIC).Append("\n");
            sb.Append("  MixUnderRunsAI: ").Append(MixUnderRunsAI).Append("\n");
            sb.Append("  NetworkAvgLossAI: ").Append(NetworkAvgLossAI).Append("\n");
            sb.Append("  NetworkAvgLossAO: ").Append(NetworkAvgLossAO).Append("\n");
            sb.Append("  NetworkAvgLossVI: ").Append(NetworkAvgLossVI).Append("\n");
            sb.Append("  NetworkAvgLossVO: ").Append(NetworkAvgLossVO).Append("\n");
            sb.Append("  NetworkCumulLossAI: ").Append(NetworkCumulLossAI).Append("\n");
            sb.Append("  NetworkCumulLossAO: ").Append(NetworkCumulLossAO).Append("\n");
            sb.Append("  NetworkCumulLossVI: ").Append(NetworkCumulLossVI).Append("\n");
            sb.Append("  NetworkCumulLossVO: ").Append(NetworkCumulLossVO).Append("\n");
            sb.Append("  NetworkLossAI: ").Append(NetworkLossAI).Append("\n");
            sb.Append("  NetworkLossAO: ").Append(NetworkLossAO).Append("\n");
            sb.Append("  NetworkLossVI: ").Append(NetworkLossVI).Append("\n");
            sb.Append("  NetworkLossVO: ").Append(NetworkLossVO).Append("\n");
            sb.Append("  CallQualityMin: ").Append(CallQualityMin).Append("\n");
            sb.Append("  CallQualityMax: ").Append(CallQualityMax).Append("\n");
            sb.Append("  CallQualityAvg: ").Append(CallQualityAvg).Append("\n");
            sb.Append("  FpsMinVI: ").Append(FpsMinVI).Append("\n");
            sb.Append("  FpsMinVO: ").Append(FpsMinVO).Append("\n");
            sb.Append("  FpsMinVIC: ").Append(FpsMinVIC).Append("\n");
            sb.Append("  FpsMinVOC: ").Append(FpsMinVOC).Append("\n");
            sb.Append("  FpsMaxVI: ").Append(FpsMaxVI).Append("\n");
            sb.Append("  FpsMaxVO: ").Append(FpsMaxVO).Append("\n");
            sb.Append("  FpsMaxVIC: ").Append(FpsMaxVIC).Append("\n");
            sb.Append("  FpsMaxVOC: ").Append(FpsMaxVOC).Append("\n");
            sb.Append("  FpsAvgVI: ").Append(FpsAvgVI).Append("\n");
            sb.Append("  FpsAvgVO: ").Append(FpsAvgVO).Append("\n");
            sb.Append("  FpsAvgVIC: ").Append(FpsAvgVIC).Append("\n");
            sb.Append("  FpsAvgVOC: ").Append(FpsAvgVOC).Append("\n");
            sb.Append("  BitrateMinAI: ").Append(BitrateMinAI).Append("\n");
            sb.Append("  BitrateMinAO: ").Append(BitrateMinAO).Append("\n");
            sb.Append("  BitrateMinVI: ").Append(BitrateMinVI).Append("\n");
            sb.Append("  BitrateMinVO: ").Append(BitrateMinVO).Append("\n");
            sb.Append("  BitrateMinVIC: ").Append(BitrateMinVIC).Append("\n");
            sb.Append("  BitrateMinVOC: ").Append(BitrateMinVOC).Append("\n");
            sb.Append("  BitrateMaxAI: ").Append(BitrateMaxAI).Append("\n");
            sb.Append("  BitrateMaxAO: ").Append(BitrateMaxAO).Append("\n");
            sb.Append("  BitrateMaxVI: ").Append(BitrateMaxVI).Append("\n");
            sb.Append("  BitrateMaxVO: ").Append(BitrateMaxVO).Append("\n");
            sb.Append("  BitrateMaxVIC: ").Append(BitrateMaxVIC).Append("\n");
            sb.Append("  BitrateMaxVOC: ").Append(BitrateMaxVOC).Append("\n");
            sb.Append("  BitrateAvgAI: ").Append(BitrateAvgAI).Append("\n");
            sb.Append("  BitrateAvgAO: ").Append(BitrateAvgAO).Append("\n");
            sb.Append("  BitrateAvgVI: ").Append(BitrateAvgVI).Append("\n");
            sb.Append("  BitrateAvgVO: ").Append(BitrateAvgVO).Append("\n");
            sb.Append("  BitrateAvgVIC: ").Append(BitrateAvgVIC).Append("\n");
            sb.Append("  BitrateAvgVOC: ").Append(BitrateAvgVOC).Append("\n");
            sb.Append("  JitterMinAI: ").Append(JitterMinAI).Append("\n");
            sb.Append("  JitterMinAO: ").Append(JitterMinAO).Append("\n");
            sb.Append("  JitterMinVI: ").Append(JitterMinVI).Append("\n");
            sb.Append("  JitterMinVO: ").Append(JitterMinVO).Append("\n");
            sb.Append("  JitterMinVIC: ").Append(JitterMinVIC).Append("\n");
            sb.Append("  JitterMinVOC: ").Append(JitterMinVOC).Append("\n");
            sb.Append("  JitterMaxAI: ").Append(JitterMaxAI).Append("\n");
            sb.Append("  JitterMaxAO: ").Append(JitterMaxAO).Append("\n");
            sb.Append("  JitterMaxVI: ").Append(JitterMaxVI).Append("\n");
            sb.Append("  JitterMaxVO: ").Append(JitterMaxVO).Append("\n");
            sb.Append("  JitterMaxVIC: ").Append(JitterMaxVIC).Append("\n");
            sb.Append("  JitterMaxVOC: ").Append(JitterMaxVOC).Append("\n");
            sb.Append("  JitterAvgAI: ").Append(JitterAvgAI).Append("\n");
            sb.Append("  JitterAvgAO: ").Append(JitterAvgAO).Append("\n");
            sb.Append("  JitterAvgVI: ").Append(JitterAvgVI).Append("\n");
            sb.Append("  JitterAvgVO: ").Append(JitterAvgVO).Append("\n");
            sb.Append("  JitterAvgVIC: ").Append(JitterAvgVIC).Append("\n");
            sb.Append("  JitterAvgVOC: ").Append(JitterAvgVOC).Append("\n");
            sb.Append("  MaxJitterMinAI: ").Append(MaxJitterMinAI).Append("\n");
            sb.Append("  MaxJitterMinVI: ").Append(MaxJitterMinVI).Append("\n");
            sb.Append("  MaxJitterMinVIC: ").Append(MaxJitterMinVIC).Append("\n");
            sb.Append("  MaxJitterMaxAI: ").Append(MaxJitterMaxAI).Append("\n");
            sb.Append("  MaxJitterMaxVI: ").Append(MaxJitterMaxVI).Append("\n");
            sb.Append("  MaxJitterMaxVIC: ").Append(MaxJitterMaxVIC).Append("\n");
            sb.Append("  MaxJitterAvgAI: ").Append(MaxJitterAvgAI).Append("\n");
            sb.Append("  MaxJitterAvgVI: ").Append(MaxJitterAvgVI).Append("\n");
            sb.Append("  MaxJitterAvgVIC: ").Append(MaxJitterAvgVIC).Append("\n");
            sb.Append("  VideoRecvHeightMin: ").Append(VideoRecvHeightMin).Append("\n");
            sb.Append("  VideoRecvHeightMax: ").Append(VideoRecvHeightMax).Append("\n");
            sb.Append("  VideoRecvWidthMin: ").Append(VideoRecvWidthMin).Append("\n");
            sb.Append("  VideoRecvWidthMax: ").Append(VideoRecvWidthMax).Append("\n");
            sb.Append("  VideoSendHeightMin: ").Append(VideoSendHeightMin).Append("\n");
            sb.Append("  VideoSendHeightMax: ").Append(VideoSendHeightMax).Append("\n");
            sb.Append("  VideoSendWidthMin: ").Append(VideoSendWidthMin).Append("\n");
            sb.Append("  VideoSendWidthMax: ").Append(VideoSendWidthMax).Append("\n");
            sb.Append("  ContentRecvHeightMin: ").Append(ContentRecvHeightMin).Append("\n");
            sb.Append("  ContentRecvHeightMax: ").Append(ContentRecvHeightMax).Append("\n");
            sb.Append("  ContentRecvWidthMin: ").Append(ContentRecvWidthMin).Append("\n");
            sb.Append("  ContentRecvWidthMax: ").Append(ContentRecvWidthMax).Append("\n");
            sb.Append("  ContentSendHeightMin: ").Append(ContentSendHeightMin).Append("\n");
            sb.Append("  ContentSendHeightMax: ").Append(ContentSendHeightMax).Append("\n");
            sb.Append("  ContentSendWidthMin: ").Append(ContentSendWidthMin).Append("\n");
            sb.Append("  ContentSendWidthMax: ").Append(ContentSendWidthMax).Append("\n");
            sb.Append("  RoundTripDelayMin: ").Append(RoundTripDelayMin).Append("\n");
            sb.Append("  RoundTripDelayMax: ").Append(RoundTripDelayMax).Append("\n");
            sb.Append("  RoundTripDelayAvg: ").Append(RoundTripDelayAvg).Append("\n");
            sb.Append("  RfactorMin: ").Append(RfactorMin).Append("\n");
            sb.Append("  RfactorMax: ").Append(RfactorMax).Append("\n");
            sb.Append("  RfactorAvg: ").Append(RfactorAvg).Append("\n");
            sb.Append("  ProcessCpuLoadMin: ").Append(ProcessCpuLoadMin).Append("\n");
            sb.Append("  ProcessCpuLoadMax: ").Append(ProcessCpuLoadMax).Append("\n");
            sb.Append("  ProcessCpuLoadAvg: ").Append(ProcessCpuLoadAvg).Append("\n");
            sb.Append("  SystemCpuLoadMin: ").Append(SystemCpuLoadMin).Append("\n");
            sb.Append("  SystemCpuLoadMax: ").Append(SystemCpuLoadMax).Append("\n");
            sb.Append("  SystemCpuLoadAvg: ").Append(SystemCpuLoadAvg).Append("\n");
            sb.Append("  WifiRecvStrengthMin: ").Append(WifiRecvStrengthMin).Append("\n");
            sb.Append("  WifiRecvStrengthMax: ").Append(WifiRecvStrengthMax).Append("\n");
            sb.Append("  WifiRecvStrengthAvg: ").Append(WifiRecvStrengthAvg).Append("\n");
            sb.Append("  KeyFrameRateAvgVI: ").Append(KeyFrameRateAvgVI).Append("\n");
            sb.Append("  KeyFrameRateAvgVO: ").Append(KeyFrameRateAvgVO).Append("\n");
            sb.Append("  KeyFrameRateAvgVIC: ").Append(KeyFrameRateAvgVIC).Append("\n");
            sb.Append("  KeyFrameRateAvgVOC: ").Append(KeyFrameRateAvgVOC).Append("\n");
            sb.Append("  KeyFrameRateMinVI: ").Append(KeyFrameRateMinVI).Append("\n");
            sb.Append("  KeyFrameRateMinVO: ").Append(KeyFrameRateMinVO).Append("\n");
            sb.Append("  KeyFrameRateMinVIC: ").Append(KeyFrameRateMinVIC).Append("\n");
            sb.Append("  KeyFrameRateMinVOC: ").Append(KeyFrameRateMinVOC).Append("\n");
            sb.Append("  KeyFrameRateMaxVI: ").Append(KeyFrameRateMaxVI).Append("\n");
            sb.Append("  KeyFrameRateMaxVO: ").Append(KeyFrameRateMaxVO).Append("\n");
            sb.Append("  KeyFrameRateMaxVIC: ").Append(KeyFrameRateMaxVIC).Append("\n");
            sb.Append("  KeyFrameRateMaxVOC: ").Append(KeyFrameRateMaxVOC).Append("\n");
            sb.Append("  RoundTripDelayAvgVO: ").Append(RoundTripDelayAvgVO).Append("\n");
            sb.Append("  RoundTripDelayAvgVOC: ").Append(RoundTripDelayAvgVOC).Append("\n");
            sb.Append("  RoundTripDelayAvgAO: ").Append(RoundTripDelayAvgAO).Append("\n");
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
            return this.Equals(obj as EndpointIndigoSummaryStats);
        }

        /// <summary>
        /// Returns true if EndpointIndigoSummaryStats instances are equal
        /// </summary>
        /// <param name="other">Instance of EndpointIndigoSummaryStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointIndigoSummaryStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AudioRecvCodec == other.AudioRecvCodec ||
                    this.AudioRecvCodec != null &&
                    this.AudioRecvCodec.Equals(other.AudioRecvCodec)
                ) && 
                (
                    this.AudioSendCodec == other.AudioSendCodec ||
                    this.AudioSendCodec != null &&
                    this.AudioSendCodec.Equals(other.AudioSendCodec)
                ) && 
                (
                    this.ContentRecv == other.ContentRecv ||
                    this.ContentRecv != null &&
                    this.ContentRecv.Equals(other.ContentRecv)
                ) && 
                (
                    this.ContentSend == other.ContentSend ||
                    this.ContentSend != null &&
                    this.ContentSend.Equals(other.ContentSend)
                ) && 
                (
                    this.TalkDetected == other.TalkDetected ||
                    this.TalkDetected != null &&
                    this.TalkDetected.Equals(other.TalkDetected)
                ) && 
                (
                    this.SessionRelay == other.SessionRelay ||
                    this.SessionRelay != null &&
                    this.SessionRelay.Equals(other.SessionRelay)
                ) && 
                (
                    this.SessionInRelay == other.SessionInRelay ||
                    this.SessionInRelay != null &&
                    this.SessionInRelay.Equals(other.SessionInRelay)
                ) && 
                (
                    this.SessionOutRelay == other.SessionOutRelay ||
                    this.SessionOutRelay != null &&
                    this.SessionOutRelay.Equals(other.SessionOutRelay)
                ) && 
                (
                    this.AudioRtpRelay == other.AudioRtpRelay ||
                    this.AudioRtpRelay != null &&
                    this.AudioRtpRelay.Equals(other.AudioRtpRelay)
                ) && 
                (
                    this.CallRate == other.CallRate ||
                    this.CallRate != null &&
                    this.CallRate.Equals(other.CallRate)
                ) && 
                (
                    this.CumulLossPercentAI == other.CumulLossPercentAI ||
                    this.CumulLossPercentAI != null &&
                    this.CumulLossPercentAI.Equals(other.CumulLossPercentAI)
                ) && 
                (
                    this.CumulLossPercentAO == other.CumulLossPercentAO ||
                    this.CumulLossPercentAO != null &&
                    this.CumulLossPercentAO.Equals(other.CumulLossPercentAO)
                ) && 
                (
                    this.CumulLossPercentVI == other.CumulLossPercentVI ||
                    this.CumulLossPercentVI != null &&
                    this.CumulLossPercentVI.Equals(other.CumulLossPercentVI)
                ) && 
                (
                    this.CumulLossPercentVO == other.CumulLossPercentVO ||
                    this.CumulLossPercentVO != null &&
                    this.CumulLossPercentVO.Equals(other.CumulLossPercentVO)
                ) && 
                (
                    this.CumulLossPercentVIC == other.CumulLossPercentVIC ||
                    this.CumulLossPercentVIC != null &&
                    this.CumulLossPercentVIC.Equals(other.CumulLossPercentVIC)
                ) && 
                (
                    this.CumulLossPercentVOC == other.CumulLossPercentVOC ||
                    this.CumulLossPercentVOC != null &&
                    this.CumulLossPercentVOC.Equals(other.CumulLossPercentVOC)
                ) && 
                (
                    this.CumulLossAI == other.CumulLossAI ||
                    this.CumulLossAI != null &&
                    this.CumulLossAI.Equals(other.CumulLossAI)
                ) && 
                (
                    this.CumulLossAO == other.CumulLossAO ||
                    this.CumulLossAO != null &&
                    this.CumulLossAO.Equals(other.CumulLossAO)
                ) && 
                (
                    this.CumulLossVI == other.CumulLossVI ||
                    this.CumulLossVI != null &&
                    this.CumulLossVI.Equals(other.CumulLossVI)
                ) && 
                (
                    this.CumulLossVO == other.CumulLossVO ||
                    this.CumulLossVO != null &&
                    this.CumulLossVO.Equals(other.CumulLossVO)
                ) && 
                (
                    this.CumulLossVIC == other.CumulLossVIC ||
                    this.CumulLossVIC != null &&
                    this.CumulLossVIC.Equals(other.CumulLossVIC)
                ) && 
                (
                    this.CumulLossVOC == other.CumulLossVOC ||
                    this.CumulLossVOC != null &&
                    this.CumulLossVOC.Equals(other.CumulLossVOC)
                ) && 
                (
                    this.DiscontinuityCount == other.DiscontinuityCount ||
                    this.DiscontinuityCount != null &&
                    this.DiscontinuityCount.Equals(other.DiscontinuityCount)
                ) && 
                (
                    this.DroppedPacketsAI == other.DroppedPacketsAI ||
                    this.DroppedPacketsAI != null &&
                    this.DroppedPacketsAI.Equals(other.DroppedPacketsAI)
                ) && 
                (
                    this.DroppedPacketsVI == other.DroppedPacketsVI ||
                    this.DroppedPacketsVI != null &&
                    this.DroppedPacketsVI.Equals(other.DroppedPacketsVI)
                ) && 
                (
                    this.DroppedPacketsVIC == other.DroppedPacketsVIC ||
                    this.DroppedPacketsVIC != null &&
                    this.DroppedPacketsVIC.Equals(other.DroppedPacketsVIC)
                ) && 
                (
                    this.MixUnderRunsAI == other.MixUnderRunsAI ||
                    this.MixUnderRunsAI != null &&
                    this.MixUnderRunsAI.Equals(other.MixUnderRunsAI)
                ) && 
                (
                    this.NetworkAvgLossAI == other.NetworkAvgLossAI ||
                    this.NetworkAvgLossAI != null &&
                    this.NetworkAvgLossAI.Equals(other.NetworkAvgLossAI)
                ) && 
                (
                    this.NetworkAvgLossAO == other.NetworkAvgLossAO ||
                    this.NetworkAvgLossAO != null &&
                    this.NetworkAvgLossAO.Equals(other.NetworkAvgLossAO)
                ) && 
                (
                    this.NetworkAvgLossVI == other.NetworkAvgLossVI ||
                    this.NetworkAvgLossVI != null &&
                    this.NetworkAvgLossVI.Equals(other.NetworkAvgLossVI)
                ) && 
                (
                    this.NetworkAvgLossVO == other.NetworkAvgLossVO ||
                    this.NetworkAvgLossVO != null &&
                    this.NetworkAvgLossVO.Equals(other.NetworkAvgLossVO)
                ) && 
                (
                    this.NetworkCumulLossAI == other.NetworkCumulLossAI ||
                    this.NetworkCumulLossAI != null &&
                    this.NetworkCumulLossAI.Equals(other.NetworkCumulLossAI)
                ) && 
                (
                    this.NetworkCumulLossAO == other.NetworkCumulLossAO ||
                    this.NetworkCumulLossAO != null &&
                    this.NetworkCumulLossAO.Equals(other.NetworkCumulLossAO)
                ) && 
                (
                    this.NetworkCumulLossVI == other.NetworkCumulLossVI ||
                    this.NetworkCumulLossVI != null &&
                    this.NetworkCumulLossVI.Equals(other.NetworkCumulLossVI)
                ) && 
                (
                    this.NetworkCumulLossVO == other.NetworkCumulLossVO ||
                    this.NetworkCumulLossVO != null &&
                    this.NetworkCumulLossVO.Equals(other.NetworkCumulLossVO)
                ) && 
                (
                    this.NetworkLossAI == other.NetworkLossAI ||
                    this.NetworkLossAI != null &&
                    this.NetworkLossAI.Equals(other.NetworkLossAI)
                ) && 
                (
                    this.NetworkLossAO == other.NetworkLossAO ||
                    this.NetworkLossAO != null &&
                    this.NetworkLossAO.Equals(other.NetworkLossAO)
                ) && 
                (
                    this.NetworkLossVI == other.NetworkLossVI ||
                    this.NetworkLossVI != null &&
                    this.NetworkLossVI.Equals(other.NetworkLossVI)
                ) && 
                (
                    this.NetworkLossVO == other.NetworkLossVO ||
                    this.NetworkLossVO != null &&
                    this.NetworkLossVO.Equals(other.NetworkLossVO)
                ) && 
                (
                    this.CallQualityMin == other.CallQualityMin ||
                    this.CallQualityMin != null &&
                    this.CallQualityMin.Equals(other.CallQualityMin)
                ) && 
                (
                    this.CallQualityMax == other.CallQualityMax ||
                    this.CallQualityMax != null &&
                    this.CallQualityMax.Equals(other.CallQualityMax)
                ) && 
                (
                    this.CallQualityAvg == other.CallQualityAvg ||
                    this.CallQualityAvg != null &&
                    this.CallQualityAvg.Equals(other.CallQualityAvg)
                ) && 
                (
                    this.FpsMinVI == other.FpsMinVI ||
                    this.FpsMinVI != null &&
                    this.FpsMinVI.Equals(other.FpsMinVI)
                ) && 
                (
                    this.FpsMinVO == other.FpsMinVO ||
                    this.FpsMinVO != null &&
                    this.FpsMinVO.Equals(other.FpsMinVO)
                ) && 
                (
                    this.FpsMinVIC == other.FpsMinVIC ||
                    this.FpsMinVIC != null &&
                    this.FpsMinVIC.Equals(other.FpsMinVIC)
                ) && 
                (
                    this.FpsMinVOC == other.FpsMinVOC ||
                    this.FpsMinVOC != null &&
                    this.FpsMinVOC.Equals(other.FpsMinVOC)
                ) && 
                (
                    this.FpsMaxVI == other.FpsMaxVI ||
                    this.FpsMaxVI != null &&
                    this.FpsMaxVI.Equals(other.FpsMaxVI)
                ) && 
                (
                    this.FpsMaxVO == other.FpsMaxVO ||
                    this.FpsMaxVO != null &&
                    this.FpsMaxVO.Equals(other.FpsMaxVO)
                ) && 
                (
                    this.FpsMaxVIC == other.FpsMaxVIC ||
                    this.FpsMaxVIC != null &&
                    this.FpsMaxVIC.Equals(other.FpsMaxVIC)
                ) && 
                (
                    this.FpsMaxVOC == other.FpsMaxVOC ||
                    this.FpsMaxVOC != null &&
                    this.FpsMaxVOC.Equals(other.FpsMaxVOC)
                ) && 
                (
                    this.FpsAvgVI == other.FpsAvgVI ||
                    this.FpsAvgVI != null &&
                    this.FpsAvgVI.Equals(other.FpsAvgVI)
                ) && 
                (
                    this.FpsAvgVO == other.FpsAvgVO ||
                    this.FpsAvgVO != null &&
                    this.FpsAvgVO.Equals(other.FpsAvgVO)
                ) && 
                (
                    this.FpsAvgVIC == other.FpsAvgVIC ||
                    this.FpsAvgVIC != null &&
                    this.FpsAvgVIC.Equals(other.FpsAvgVIC)
                ) && 
                (
                    this.FpsAvgVOC == other.FpsAvgVOC ||
                    this.FpsAvgVOC != null &&
                    this.FpsAvgVOC.Equals(other.FpsAvgVOC)
                ) && 
                (
                    this.BitrateMinAI == other.BitrateMinAI ||
                    this.BitrateMinAI != null &&
                    this.BitrateMinAI.Equals(other.BitrateMinAI)
                ) && 
                (
                    this.BitrateMinAO == other.BitrateMinAO ||
                    this.BitrateMinAO != null &&
                    this.BitrateMinAO.Equals(other.BitrateMinAO)
                ) && 
                (
                    this.BitrateMinVI == other.BitrateMinVI ||
                    this.BitrateMinVI != null &&
                    this.BitrateMinVI.Equals(other.BitrateMinVI)
                ) && 
                (
                    this.BitrateMinVO == other.BitrateMinVO ||
                    this.BitrateMinVO != null &&
                    this.BitrateMinVO.Equals(other.BitrateMinVO)
                ) && 
                (
                    this.BitrateMinVIC == other.BitrateMinVIC ||
                    this.BitrateMinVIC != null &&
                    this.BitrateMinVIC.Equals(other.BitrateMinVIC)
                ) && 
                (
                    this.BitrateMinVOC == other.BitrateMinVOC ||
                    this.BitrateMinVOC != null &&
                    this.BitrateMinVOC.Equals(other.BitrateMinVOC)
                ) && 
                (
                    this.BitrateMaxAI == other.BitrateMaxAI ||
                    this.BitrateMaxAI != null &&
                    this.BitrateMaxAI.Equals(other.BitrateMaxAI)
                ) && 
                (
                    this.BitrateMaxAO == other.BitrateMaxAO ||
                    this.BitrateMaxAO != null &&
                    this.BitrateMaxAO.Equals(other.BitrateMaxAO)
                ) && 
                (
                    this.BitrateMaxVI == other.BitrateMaxVI ||
                    this.BitrateMaxVI != null &&
                    this.BitrateMaxVI.Equals(other.BitrateMaxVI)
                ) && 
                (
                    this.BitrateMaxVO == other.BitrateMaxVO ||
                    this.BitrateMaxVO != null &&
                    this.BitrateMaxVO.Equals(other.BitrateMaxVO)
                ) && 
                (
                    this.BitrateMaxVIC == other.BitrateMaxVIC ||
                    this.BitrateMaxVIC != null &&
                    this.BitrateMaxVIC.Equals(other.BitrateMaxVIC)
                ) && 
                (
                    this.BitrateMaxVOC == other.BitrateMaxVOC ||
                    this.BitrateMaxVOC != null &&
                    this.BitrateMaxVOC.Equals(other.BitrateMaxVOC)
                ) && 
                (
                    this.BitrateAvgAI == other.BitrateAvgAI ||
                    this.BitrateAvgAI != null &&
                    this.BitrateAvgAI.Equals(other.BitrateAvgAI)
                ) && 
                (
                    this.BitrateAvgAO == other.BitrateAvgAO ||
                    this.BitrateAvgAO != null &&
                    this.BitrateAvgAO.Equals(other.BitrateAvgAO)
                ) && 
                (
                    this.BitrateAvgVI == other.BitrateAvgVI ||
                    this.BitrateAvgVI != null &&
                    this.BitrateAvgVI.Equals(other.BitrateAvgVI)
                ) && 
                (
                    this.BitrateAvgVO == other.BitrateAvgVO ||
                    this.BitrateAvgVO != null &&
                    this.BitrateAvgVO.Equals(other.BitrateAvgVO)
                ) && 
                (
                    this.BitrateAvgVIC == other.BitrateAvgVIC ||
                    this.BitrateAvgVIC != null &&
                    this.BitrateAvgVIC.Equals(other.BitrateAvgVIC)
                ) && 
                (
                    this.BitrateAvgVOC == other.BitrateAvgVOC ||
                    this.BitrateAvgVOC != null &&
                    this.BitrateAvgVOC.Equals(other.BitrateAvgVOC)
                ) && 
                (
                    this.JitterMinAI == other.JitterMinAI ||
                    this.JitterMinAI != null &&
                    this.JitterMinAI.Equals(other.JitterMinAI)
                ) && 
                (
                    this.JitterMinAO == other.JitterMinAO ||
                    this.JitterMinAO != null &&
                    this.JitterMinAO.Equals(other.JitterMinAO)
                ) && 
                (
                    this.JitterMinVI == other.JitterMinVI ||
                    this.JitterMinVI != null &&
                    this.JitterMinVI.Equals(other.JitterMinVI)
                ) && 
                (
                    this.JitterMinVO == other.JitterMinVO ||
                    this.JitterMinVO != null &&
                    this.JitterMinVO.Equals(other.JitterMinVO)
                ) && 
                (
                    this.JitterMinVIC == other.JitterMinVIC ||
                    this.JitterMinVIC != null &&
                    this.JitterMinVIC.Equals(other.JitterMinVIC)
                ) && 
                (
                    this.JitterMinVOC == other.JitterMinVOC ||
                    this.JitterMinVOC != null &&
                    this.JitterMinVOC.Equals(other.JitterMinVOC)
                ) && 
                (
                    this.JitterMaxAI == other.JitterMaxAI ||
                    this.JitterMaxAI != null &&
                    this.JitterMaxAI.Equals(other.JitterMaxAI)
                ) && 
                (
                    this.JitterMaxAO == other.JitterMaxAO ||
                    this.JitterMaxAO != null &&
                    this.JitterMaxAO.Equals(other.JitterMaxAO)
                ) && 
                (
                    this.JitterMaxVI == other.JitterMaxVI ||
                    this.JitterMaxVI != null &&
                    this.JitterMaxVI.Equals(other.JitterMaxVI)
                ) && 
                (
                    this.JitterMaxVO == other.JitterMaxVO ||
                    this.JitterMaxVO != null &&
                    this.JitterMaxVO.Equals(other.JitterMaxVO)
                ) && 
                (
                    this.JitterMaxVIC == other.JitterMaxVIC ||
                    this.JitterMaxVIC != null &&
                    this.JitterMaxVIC.Equals(other.JitterMaxVIC)
                ) && 
                (
                    this.JitterMaxVOC == other.JitterMaxVOC ||
                    this.JitterMaxVOC != null &&
                    this.JitterMaxVOC.Equals(other.JitterMaxVOC)
                ) && 
                (
                    this.JitterAvgAI == other.JitterAvgAI ||
                    this.JitterAvgAI != null &&
                    this.JitterAvgAI.Equals(other.JitterAvgAI)
                ) && 
                (
                    this.JitterAvgAO == other.JitterAvgAO ||
                    this.JitterAvgAO != null &&
                    this.JitterAvgAO.Equals(other.JitterAvgAO)
                ) && 
                (
                    this.JitterAvgVI == other.JitterAvgVI ||
                    this.JitterAvgVI != null &&
                    this.JitterAvgVI.Equals(other.JitterAvgVI)
                ) && 
                (
                    this.JitterAvgVO == other.JitterAvgVO ||
                    this.JitterAvgVO != null &&
                    this.JitterAvgVO.Equals(other.JitterAvgVO)
                ) && 
                (
                    this.JitterAvgVIC == other.JitterAvgVIC ||
                    this.JitterAvgVIC != null &&
                    this.JitterAvgVIC.Equals(other.JitterAvgVIC)
                ) && 
                (
                    this.JitterAvgVOC == other.JitterAvgVOC ||
                    this.JitterAvgVOC != null &&
                    this.JitterAvgVOC.Equals(other.JitterAvgVOC)
                ) && 
                (
                    this.MaxJitterMinAI == other.MaxJitterMinAI ||
                    this.MaxJitterMinAI != null &&
                    this.MaxJitterMinAI.Equals(other.MaxJitterMinAI)
                ) && 
                (
                    this.MaxJitterMinVI == other.MaxJitterMinVI ||
                    this.MaxJitterMinVI != null &&
                    this.MaxJitterMinVI.Equals(other.MaxJitterMinVI)
                ) && 
                (
                    this.MaxJitterMinVIC == other.MaxJitterMinVIC ||
                    this.MaxJitterMinVIC != null &&
                    this.MaxJitterMinVIC.Equals(other.MaxJitterMinVIC)
                ) && 
                (
                    this.MaxJitterMaxAI == other.MaxJitterMaxAI ||
                    this.MaxJitterMaxAI != null &&
                    this.MaxJitterMaxAI.Equals(other.MaxJitterMaxAI)
                ) && 
                (
                    this.MaxJitterMaxVI == other.MaxJitterMaxVI ||
                    this.MaxJitterMaxVI != null &&
                    this.MaxJitterMaxVI.Equals(other.MaxJitterMaxVI)
                ) && 
                (
                    this.MaxJitterMaxVIC == other.MaxJitterMaxVIC ||
                    this.MaxJitterMaxVIC != null &&
                    this.MaxJitterMaxVIC.Equals(other.MaxJitterMaxVIC)
                ) && 
                (
                    this.MaxJitterAvgAI == other.MaxJitterAvgAI ||
                    this.MaxJitterAvgAI != null &&
                    this.MaxJitterAvgAI.Equals(other.MaxJitterAvgAI)
                ) && 
                (
                    this.MaxJitterAvgVI == other.MaxJitterAvgVI ||
                    this.MaxJitterAvgVI != null &&
                    this.MaxJitterAvgVI.Equals(other.MaxJitterAvgVI)
                ) && 
                (
                    this.MaxJitterAvgVIC == other.MaxJitterAvgVIC ||
                    this.MaxJitterAvgVIC != null &&
                    this.MaxJitterAvgVIC.Equals(other.MaxJitterAvgVIC)
                ) && 
                (
                    this.VideoRecvHeightMin == other.VideoRecvHeightMin ||
                    this.VideoRecvHeightMin != null &&
                    this.VideoRecvHeightMin.Equals(other.VideoRecvHeightMin)
                ) && 
                (
                    this.VideoRecvHeightMax == other.VideoRecvHeightMax ||
                    this.VideoRecvHeightMax != null &&
                    this.VideoRecvHeightMax.Equals(other.VideoRecvHeightMax)
                ) && 
                (
                    this.VideoRecvWidthMin == other.VideoRecvWidthMin ||
                    this.VideoRecvWidthMin != null &&
                    this.VideoRecvWidthMin.Equals(other.VideoRecvWidthMin)
                ) && 
                (
                    this.VideoRecvWidthMax == other.VideoRecvWidthMax ||
                    this.VideoRecvWidthMax != null &&
                    this.VideoRecvWidthMax.Equals(other.VideoRecvWidthMax)
                ) && 
                (
                    this.VideoSendHeightMin == other.VideoSendHeightMin ||
                    this.VideoSendHeightMin != null &&
                    this.VideoSendHeightMin.Equals(other.VideoSendHeightMin)
                ) && 
                (
                    this.VideoSendHeightMax == other.VideoSendHeightMax ||
                    this.VideoSendHeightMax != null &&
                    this.VideoSendHeightMax.Equals(other.VideoSendHeightMax)
                ) && 
                (
                    this.VideoSendWidthMin == other.VideoSendWidthMin ||
                    this.VideoSendWidthMin != null &&
                    this.VideoSendWidthMin.Equals(other.VideoSendWidthMin)
                ) && 
                (
                    this.VideoSendWidthMax == other.VideoSendWidthMax ||
                    this.VideoSendWidthMax != null &&
                    this.VideoSendWidthMax.Equals(other.VideoSendWidthMax)
                ) && 
                (
                    this.ContentRecvHeightMin == other.ContentRecvHeightMin ||
                    this.ContentRecvHeightMin != null &&
                    this.ContentRecvHeightMin.Equals(other.ContentRecvHeightMin)
                ) && 
                (
                    this.ContentRecvHeightMax == other.ContentRecvHeightMax ||
                    this.ContentRecvHeightMax != null &&
                    this.ContentRecvHeightMax.Equals(other.ContentRecvHeightMax)
                ) && 
                (
                    this.ContentRecvWidthMin == other.ContentRecvWidthMin ||
                    this.ContentRecvWidthMin != null &&
                    this.ContentRecvWidthMin.Equals(other.ContentRecvWidthMin)
                ) && 
                (
                    this.ContentRecvWidthMax == other.ContentRecvWidthMax ||
                    this.ContentRecvWidthMax != null &&
                    this.ContentRecvWidthMax.Equals(other.ContentRecvWidthMax)
                ) && 
                (
                    this.ContentSendHeightMin == other.ContentSendHeightMin ||
                    this.ContentSendHeightMin != null &&
                    this.ContentSendHeightMin.Equals(other.ContentSendHeightMin)
                ) && 
                (
                    this.ContentSendHeightMax == other.ContentSendHeightMax ||
                    this.ContentSendHeightMax != null &&
                    this.ContentSendHeightMax.Equals(other.ContentSendHeightMax)
                ) && 
                (
                    this.ContentSendWidthMin == other.ContentSendWidthMin ||
                    this.ContentSendWidthMin != null &&
                    this.ContentSendWidthMin.Equals(other.ContentSendWidthMin)
                ) && 
                (
                    this.ContentSendWidthMax == other.ContentSendWidthMax ||
                    this.ContentSendWidthMax != null &&
                    this.ContentSendWidthMax.Equals(other.ContentSendWidthMax)
                ) && 
                (
                    this.RoundTripDelayMin == other.RoundTripDelayMin ||
                    this.RoundTripDelayMin != null &&
                    this.RoundTripDelayMin.Equals(other.RoundTripDelayMin)
                ) && 
                (
                    this.RoundTripDelayMax == other.RoundTripDelayMax ||
                    this.RoundTripDelayMax != null &&
                    this.RoundTripDelayMax.Equals(other.RoundTripDelayMax)
                ) && 
                (
                    this.RoundTripDelayAvg == other.RoundTripDelayAvg ||
                    this.RoundTripDelayAvg != null &&
                    this.RoundTripDelayAvg.Equals(other.RoundTripDelayAvg)
                ) && 
                (
                    this.RfactorMin == other.RfactorMin ||
                    this.RfactorMin != null &&
                    this.RfactorMin.Equals(other.RfactorMin)
                ) && 
                (
                    this.RfactorMax == other.RfactorMax ||
                    this.RfactorMax != null &&
                    this.RfactorMax.Equals(other.RfactorMax)
                ) && 
                (
                    this.RfactorAvg == other.RfactorAvg ||
                    this.RfactorAvg != null &&
                    this.RfactorAvg.Equals(other.RfactorAvg)
                ) && 
                (
                    this.ProcessCpuLoadMin == other.ProcessCpuLoadMin ||
                    this.ProcessCpuLoadMin != null &&
                    this.ProcessCpuLoadMin.Equals(other.ProcessCpuLoadMin)
                ) && 
                (
                    this.ProcessCpuLoadMax == other.ProcessCpuLoadMax ||
                    this.ProcessCpuLoadMax != null &&
                    this.ProcessCpuLoadMax.Equals(other.ProcessCpuLoadMax)
                ) && 
                (
                    this.ProcessCpuLoadAvg == other.ProcessCpuLoadAvg ||
                    this.ProcessCpuLoadAvg != null &&
                    this.ProcessCpuLoadAvg.Equals(other.ProcessCpuLoadAvg)
                ) && 
                (
                    this.SystemCpuLoadMin == other.SystemCpuLoadMin ||
                    this.SystemCpuLoadMin != null &&
                    this.SystemCpuLoadMin.Equals(other.SystemCpuLoadMin)
                ) && 
                (
                    this.SystemCpuLoadMax == other.SystemCpuLoadMax ||
                    this.SystemCpuLoadMax != null &&
                    this.SystemCpuLoadMax.Equals(other.SystemCpuLoadMax)
                ) && 
                (
                    this.SystemCpuLoadAvg == other.SystemCpuLoadAvg ||
                    this.SystemCpuLoadAvg != null &&
                    this.SystemCpuLoadAvg.Equals(other.SystemCpuLoadAvg)
                ) && 
                (
                    this.WifiRecvStrengthMin == other.WifiRecvStrengthMin ||
                    this.WifiRecvStrengthMin != null &&
                    this.WifiRecvStrengthMin.Equals(other.WifiRecvStrengthMin)
                ) && 
                (
                    this.WifiRecvStrengthMax == other.WifiRecvStrengthMax ||
                    this.WifiRecvStrengthMax != null &&
                    this.WifiRecvStrengthMax.Equals(other.WifiRecvStrengthMax)
                ) && 
                (
                    this.WifiRecvStrengthAvg == other.WifiRecvStrengthAvg ||
                    this.WifiRecvStrengthAvg != null &&
                    this.WifiRecvStrengthAvg.Equals(other.WifiRecvStrengthAvg)
                ) && 
                (
                    this.KeyFrameRateAvgVI == other.KeyFrameRateAvgVI ||
                    this.KeyFrameRateAvgVI != null &&
                    this.KeyFrameRateAvgVI.Equals(other.KeyFrameRateAvgVI)
                ) && 
                (
                    this.KeyFrameRateAvgVO == other.KeyFrameRateAvgVO ||
                    this.KeyFrameRateAvgVO != null &&
                    this.KeyFrameRateAvgVO.Equals(other.KeyFrameRateAvgVO)
                ) && 
                (
                    this.KeyFrameRateAvgVIC == other.KeyFrameRateAvgVIC ||
                    this.KeyFrameRateAvgVIC != null &&
                    this.KeyFrameRateAvgVIC.Equals(other.KeyFrameRateAvgVIC)
                ) && 
                (
                    this.KeyFrameRateAvgVOC == other.KeyFrameRateAvgVOC ||
                    this.KeyFrameRateAvgVOC != null &&
                    this.KeyFrameRateAvgVOC.Equals(other.KeyFrameRateAvgVOC)
                ) && 
                (
                    this.KeyFrameRateMinVI == other.KeyFrameRateMinVI ||
                    this.KeyFrameRateMinVI != null &&
                    this.KeyFrameRateMinVI.Equals(other.KeyFrameRateMinVI)
                ) && 
                (
                    this.KeyFrameRateMinVO == other.KeyFrameRateMinVO ||
                    this.KeyFrameRateMinVO != null &&
                    this.KeyFrameRateMinVO.Equals(other.KeyFrameRateMinVO)
                ) && 
                (
                    this.KeyFrameRateMinVIC == other.KeyFrameRateMinVIC ||
                    this.KeyFrameRateMinVIC != null &&
                    this.KeyFrameRateMinVIC.Equals(other.KeyFrameRateMinVIC)
                ) && 
                (
                    this.KeyFrameRateMinVOC == other.KeyFrameRateMinVOC ||
                    this.KeyFrameRateMinVOC != null &&
                    this.KeyFrameRateMinVOC.Equals(other.KeyFrameRateMinVOC)
                ) && 
                (
                    this.KeyFrameRateMaxVI == other.KeyFrameRateMaxVI ||
                    this.KeyFrameRateMaxVI != null &&
                    this.KeyFrameRateMaxVI.Equals(other.KeyFrameRateMaxVI)
                ) && 
                (
                    this.KeyFrameRateMaxVO == other.KeyFrameRateMaxVO ||
                    this.KeyFrameRateMaxVO != null &&
                    this.KeyFrameRateMaxVO.Equals(other.KeyFrameRateMaxVO)
                ) && 
                (
                    this.KeyFrameRateMaxVIC == other.KeyFrameRateMaxVIC ||
                    this.KeyFrameRateMaxVIC != null &&
                    this.KeyFrameRateMaxVIC.Equals(other.KeyFrameRateMaxVIC)
                ) && 
                (
                    this.KeyFrameRateMaxVOC == other.KeyFrameRateMaxVOC ||
                    this.KeyFrameRateMaxVOC != null &&
                    this.KeyFrameRateMaxVOC.Equals(other.KeyFrameRateMaxVOC)
                ) && 
                (
                    this.RoundTripDelayAvgVO == other.RoundTripDelayAvgVO ||
                    this.RoundTripDelayAvgVO != null &&
                    this.RoundTripDelayAvgVO.Equals(other.RoundTripDelayAvgVO)
                ) && 
                (
                    this.RoundTripDelayAvgVOC == other.RoundTripDelayAvgVOC ||
                    this.RoundTripDelayAvgVOC != null &&
                    this.RoundTripDelayAvgVOC.Equals(other.RoundTripDelayAvgVOC)
                ) && 
                (
                    this.RoundTripDelayAvgAO == other.RoundTripDelayAvgAO ||
                    this.RoundTripDelayAvgAO != null &&
                    this.RoundTripDelayAvgAO.Equals(other.RoundTripDelayAvgAO)
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
                if (this.AudioRecvCodec != null)
                    hash = hash * 59 + this.AudioRecvCodec.GetHashCode();
                if (this.AudioSendCodec != null)
                    hash = hash * 59 + this.AudioSendCodec.GetHashCode();
                if (this.ContentRecv != null)
                    hash = hash * 59 + this.ContentRecv.GetHashCode();
                if (this.ContentSend != null)
                    hash = hash * 59 + this.ContentSend.GetHashCode();
                if (this.TalkDetected != null)
                    hash = hash * 59 + this.TalkDetected.GetHashCode();
                if (this.SessionRelay != null)
                    hash = hash * 59 + this.SessionRelay.GetHashCode();
                if (this.SessionInRelay != null)
                    hash = hash * 59 + this.SessionInRelay.GetHashCode();
                if (this.SessionOutRelay != null)
                    hash = hash * 59 + this.SessionOutRelay.GetHashCode();
                if (this.AudioRtpRelay != null)
                    hash = hash * 59 + this.AudioRtpRelay.GetHashCode();
                if (this.CallRate != null)
                    hash = hash * 59 + this.CallRate.GetHashCode();
                if (this.CumulLossPercentAI != null)
                    hash = hash * 59 + this.CumulLossPercentAI.GetHashCode();
                if (this.CumulLossPercentAO != null)
                    hash = hash * 59 + this.CumulLossPercentAO.GetHashCode();
                if (this.CumulLossPercentVI != null)
                    hash = hash * 59 + this.CumulLossPercentVI.GetHashCode();
                if (this.CumulLossPercentVO != null)
                    hash = hash * 59 + this.CumulLossPercentVO.GetHashCode();
                if (this.CumulLossPercentVIC != null)
                    hash = hash * 59 + this.CumulLossPercentVIC.GetHashCode();
                if (this.CumulLossPercentVOC != null)
                    hash = hash * 59 + this.CumulLossPercentVOC.GetHashCode();
                if (this.CumulLossAI != null)
                    hash = hash * 59 + this.CumulLossAI.GetHashCode();
                if (this.CumulLossAO != null)
                    hash = hash * 59 + this.CumulLossAO.GetHashCode();
                if (this.CumulLossVI != null)
                    hash = hash * 59 + this.CumulLossVI.GetHashCode();
                if (this.CumulLossVO != null)
                    hash = hash * 59 + this.CumulLossVO.GetHashCode();
                if (this.CumulLossVIC != null)
                    hash = hash * 59 + this.CumulLossVIC.GetHashCode();
                if (this.CumulLossVOC != null)
                    hash = hash * 59 + this.CumulLossVOC.GetHashCode();
                if (this.DiscontinuityCount != null)
                    hash = hash * 59 + this.DiscontinuityCount.GetHashCode();
                if (this.DroppedPacketsAI != null)
                    hash = hash * 59 + this.DroppedPacketsAI.GetHashCode();
                if (this.DroppedPacketsVI != null)
                    hash = hash * 59 + this.DroppedPacketsVI.GetHashCode();
                if (this.DroppedPacketsVIC != null)
                    hash = hash * 59 + this.DroppedPacketsVIC.GetHashCode();
                if (this.MixUnderRunsAI != null)
                    hash = hash * 59 + this.MixUnderRunsAI.GetHashCode();
                if (this.NetworkAvgLossAI != null)
                    hash = hash * 59 + this.NetworkAvgLossAI.GetHashCode();
                if (this.NetworkAvgLossAO != null)
                    hash = hash * 59 + this.NetworkAvgLossAO.GetHashCode();
                if (this.NetworkAvgLossVI != null)
                    hash = hash * 59 + this.NetworkAvgLossVI.GetHashCode();
                if (this.NetworkAvgLossVO != null)
                    hash = hash * 59 + this.NetworkAvgLossVO.GetHashCode();
                if (this.NetworkCumulLossAI != null)
                    hash = hash * 59 + this.NetworkCumulLossAI.GetHashCode();
                if (this.NetworkCumulLossAO != null)
                    hash = hash * 59 + this.NetworkCumulLossAO.GetHashCode();
                if (this.NetworkCumulLossVI != null)
                    hash = hash * 59 + this.NetworkCumulLossVI.GetHashCode();
                if (this.NetworkCumulLossVO != null)
                    hash = hash * 59 + this.NetworkCumulLossVO.GetHashCode();
                if (this.NetworkLossAI != null)
                    hash = hash * 59 + this.NetworkLossAI.GetHashCode();
                if (this.NetworkLossAO != null)
                    hash = hash * 59 + this.NetworkLossAO.GetHashCode();
                if (this.NetworkLossVI != null)
                    hash = hash * 59 + this.NetworkLossVI.GetHashCode();
                if (this.NetworkLossVO != null)
                    hash = hash * 59 + this.NetworkLossVO.GetHashCode();
                if (this.CallQualityMin != null)
                    hash = hash * 59 + this.CallQualityMin.GetHashCode();
                if (this.CallQualityMax != null)
                    hash = hash * 59 + this.CallQualityMax.GetHashCode();
                if (this.CallQualityAvg != null)
                    hash = hash * 59 + this.CallQualityAvg.GetHashCode();
                if (this.FpsMinVI != null)
                    hash = hash * 59 + this.FpsMinVI.GetHashCode();
                if (this.FpsMinVO != null)
                    hash = hash * 59 + this.FpsMinVO.GetHashCode();
                if (this.FpsMinVIC != null)
                    hash = hash * 59 + this.FpsMinVIC.GetHashCode();
                if (this.FpsMinVOC != null)
                    hash = hash * 59 + this.FpsMinVOC.GetHashCode();
                if (this.FpsMaxVI != null)
                    hash = hash * 59 + this.FpsMaxVI.GetHashCode();
                if (this.FpsMaxVO != null)
                    hash = hash * 59 + this.FpsMaxVO.GetHashCode();
                if (this.FpsMaxVIC != null)
                    hash = hash * 59 + this.FpsMaxVIC.GetHashCode();
                if (this.FpsMaxVOC != null)
                    hash = hash * 59 + this.FpsMaxVOC.GetHashCode();
                if (this.FpsAvgVI != null)
                    hash = hash * 59 + this.FpsAvgVI.GetHashCode();
                if (this.FpsAvgVO != null)
                    hash = hash * 59 + this.FpsAvgVO.GetHashCode();
                if (this.FpsAvgVIC != null)
                    hash = hash * 59 + this.FpsAvgVIC.GetHashCode();
                if (this.FpsAvgVOC != null)
                    hash = hash * 59 + this.FpsAvgVOC.GetHashCode();
                if (this.BitrateMinAI != null)
                    hash = hash * 59 + this.BitrateMinAI.GetHashCode();
                if (this.BitrateMinAO != null)
                    hash = hash * 59 + this.BitrateMinAO.GetHashCode();
                if (this.BitrateMinVI != null)
                    hash = hash * 59 + this.BitrateMinVI.GetHashCode();
                if (this.BitrateMinVO != null)
                    hash = hash * 59 + this.BitrateMinVO.GetHashCode();
                if (this.BitrateMinVIC != null)
                    hash = hash * 59 + this.BitrateMinVIC.GetHashCode();
                if (this.BitrateMinVOC != null)
                    hash = hash * 59 + this.BitrateMinVOC.GetHashCode();
                if (this.BitrateMaxAI != null)
                    hash = hash * 59 + this.BitrateMaxAI.GetHashCode();
                if (this.BitrateMaxAO != null)
                    hash = hash * 59 + this.BitrateMaxAO.GetHashCode();
                if (this.BitrateMaxVI != null)
                    hash = hash * 59 + this.BitrateMaxVI.GetHashCode();
                if (this.BitrateMaxVO != null)
                    hash = hash * 59 + this.BitrateMaxVO.GetHashCode();
                if (this.BitrateMaxVIC != null)
                    hash = hash * 59 + this.BitrateMaxVIC.GetHashCode();
                if (this.BitrateMaxVOC != null)
                    hash = hash * 59 + this.BitrateMaxVOC.GetHashCode();
                if (this.BitrateAvgAI != null)
                    hash = hash * 59 + this.BitrateAvgAI.GetHashCode();
                if (this.BitrateAvgAO != null)
                    hash = hash * 59 + this.BitrateAvgAO.GetHashCode();
                if (this.BitrateAvgVI != null)
                    hash = hash * 59 + this.BitrateAvgVI.GetHashCode();
                if (this.BitrateAvgVO != null)
                    hash = hash * 59 + this.BitrateAvgVO.GetHashCode();
                if (this.BitrateAvgVIC != null)
                    hash = hash * 59 + this.BitrateAvgVIC.GetHashCode();
                if (this.BitrateAvgVOC != null)
                    hash = hash * 59 + this.BitrateAvgVOC.GetHashCode();
                if (this.JitterMinAI != null)
                    hash = hash * 59 + this.JitterMinAI.GetHashCode();
                if (this.JitterMinAO != null)
                    hash = hash * 59 + this.JitterMinAO.GetHashCode();
                if (this.JitterMinVI != null)
                    hash = hash * 59 + this.JitterMinVI.GetHashCode();
                if (this.JitterMinVO != null)
                    hash = hash * 59 + this.JitterMinVO.GetHashCode();
                if (this.JitterMinVIC != null)
                    hash = hash * 59 + this.JitterMinVIC.GetHashCode();
                if (this.JitterMinVOC != null)
                    hash = hash * 59 + this.JitterMinVOC.GetHashCode();
                if (this.JitterMaxAI != null)
                    hash = hash * 59 + this.JitterMaxAI.GetHashCode();
                if (this.JitterMaxAO != null)
                    hash = hash * 59 + this.JitterMaxAO.GetHashCode();
                if (this.JitterMaxVI != null)
                    hash = hash * 59 + this.JitterMaxVI.GetHashCode();
                if (this.JitterMaxVO != null)
                    hash = hash * 59 + this.JitterMaxVO.GetHashCode();
                if (this.JitterMaxVIC != null)
                    hash = hash * 59 + this.JitterMaxVIC.GetHashCode();
                if (this.JitterMaxVOC != null)
                    hash = hash * 59 + this.JitterMaxVOC.GetHashCode();
                if (this.JitterAvgAI != null)
                    hash = hash * 59 + this.JitterAvgAI.GetHashCode();
                if (this.JitterAvgAO != null)
                    hash = hash * 59 + this.JitterAvgAO.GetHashCode();
                if (this.JitterAvgVI != null)
                    hash = hash * 59 + this.JitterAvgVI.GetHashCode();
                if (this.JitterAvgVO != null)
                    hash = hash * 59 + this.JitterAvgVO.GetHashCode();
                if (this.JitterAvgVIC != null)
                    hash = hash * 59 + this.JitterAvgVIC.GetHashCode();
                if (this.JitterAvgVOC != null)
                    hash = hash * 59 + this.JitterAvgVOC.GetHashCode();
                if (this.MaxJitterMinAI != null)
                    hash = hash * 59 + this.MaxJitterMinAI.GetHashCode();
                if (this.MaxJitterMinVI != null)
                    hash = hash * 59 + this.MaxJitterMinVI.GetHashCode();
                if (this.MaxJitterMinVIC != null)
                    hash = hash * 59 + this.MaxJitterMinVIC.GetHashCode();
                if (this.MaxJitterMaxAI != null)
                    hash = hash * 59 + this.MaxJitterMaxAI.GetHashCode();
                if (this.MaxJitterMaxVI != null)
                    hash = hash * 59 + this.MaxJitterMaxVI.GetHashCode();
                if (this.MaxJitterMaxVIC != null)
                    hash = hash * 59 + this.MaxJitterMaxVIC.GetHashCode();
                if (this.MaxJitterAvgAI != null)
                    hash = hash * 59 + this.MaxJitterAvgAI.GetHashCode();
                if (this.MaxJitterAvgVI != null)
                    hash = hash * 59 + this.MaxJitterAvgVI.GetHashCode();
                if (this.MaxJitterAvgVIC != null)
                    hash = hash * 59 + this.MaxJitterAvgVIC.GetHashCode();
                if (this.VideoRecvHeightMin != null)
                    hash = hash * 59 + this.VideoRecvHeightMin.GetHashCode();
                if (this.VideoRecvHeightMax != null)
                    hash = hash * 59 + this.VideoRecvHeightMax.GetHashCode();
                if (this.VideoRecvWidthMin != null)
                    hash = hash * 59 + this.VideoRecvWidthMin.GetHashCode();
                if (this.VideoRecvWidthMax != null)
                    hash = hash * 59 + this.VideoRecvWidthMax.GetHashCode();
                if (this.VideoSendHeightMin != null)
                    hash = hash * 59 + this.VideoSendHeightMin.GetHashCode();
                if (this.VideoSendHeightMax != null)
                    hash = hash * 59 + this.VideoSendHeightMax.GetHashCode();
                if (this.VideoSendWidthMin != null)
                    hash = hash * 59 + this.VideoSendWidthMin.GetHashCode();
                if (this.VideoSendWidthMax != null)
                    hash = hash * 59 + this.VideoSendWidthMax.GetHashCode();
                if (this.ContentRecvHeightMin != null)
                    hash = hash * 59 + this.ContentRecvHeightMin.GetHashCode();
                if (this.ContentRecvHeightMax != null)
                    hash = hash * 59 + this.ContentRecvHeightMax.GetHashCode();
                if (this.ContentRecvWidthMin != null)
                    hash = hash * 59 + this.ContentRecvWidthMin.GetHashCode();
                if (this.ContentRecvWidthMax != null)
                    hash = hash * 59 + this.ContentRecvWidthMax.GetHashCode();
                if (this.ContentSendHeightMin != null)
                    hash = hash * 59 + this.ContentSendHeightMin.GetHashCode();
                if (this.ContentSendHeightMax != null)
                    hash = hash * 59 + this.ContentSendHeightMax.GetHashCode();
                if (this.ContentSendWidthMin != null)
                    hash = hash * 59 + this.ContentSendWidthMin.GetHashCode();
                if (this.ContentSendWidthMax != null)
                    hash = hash * 59 + this.ContentSendWidthMax.GetHashCode();
                if (this.RoundTripDelayMin != null)
                    hash = hash * 59 + this.RoundTripDelayMin.GetHashCode();
                if (this.RoundTripDelayMax != null)
                    hash = hash * 59 + this.RoundTripDelayMax.GetHashCode();
                if (this.RoundTripDelayAvg != null)
                    hash = hash * 59 + this.RoundTripDelayAvg.GetHashCode();
                if (this.RfactorMin != null)
                    hash = hash * 59 + this.RfactorMin.GetHashCode();
                if (this.RfactorMax != null)
                    hash = hash * 59 + this.RfactorMax.GetHashCode();
                if (this.RfactorAvg != null)
                    hash = hash * 59 + this.RfactorAvg.GetHashCode();
                if (this.ProcessCpuLoadMin != null)
                    hash = hash * 59 + this.ProcessCpuLoadMin.GetHashCode();
                if (this.ProcessCpuLoadMax != null)
                    hash = hash * 59 + this.ProcessCpuLoadMax.GetHashCode();
                if (this.ProcessCpuLoadAvg != null)
                    hash = hash * 59 + this.ProcessCpuLoadAvg.GetHashCode();
                if (this.SystemCpuLoadMin != null)
                    hash = hash * 59 + this.SystemCpuLoadMin.GetHashCode();
                if (this.SystemCpuLoadMax != null)
                    hash = hash * 59 + this.SystemCpuLoadMax.GetHashCode();
                if (this.SystemCpuLoadAvg != null)
                    hash = hash * 59 + this.SystemCpuLoadAvg.GetHashCode();
                if (this.WifiRecvStrengthMin != null)
                    hash = hash * 59 + this.WifiRecvStrengthMin.GetHashCode();
                if (this.WifiRecvStrengthMax != null)
                    hash = hash * 59 + this.WifiRecvStrengthMax.GetHashCode();
                if (this.WifiRecvStrengthAvg != null)
                    hash = hash * 59 + this.WifiRecvStrengthAvg.GetHashCode();
                if (this.KeyFrameRateAvgVI != null)
                    hash = hash * 59 + this.KeyFrameRateAvgVI.GetHashCode();
                if (this.KeyFrameRateAvgVO != null)
                    hash = hash * 59 + this.KeyFrameRateAvgVO.GetHashCode();
                if (this.KeyFrameRateAvgVIC != null)
                    hash = hash * 59 + this.KeyFrameRateAvgVIC.GetHashCode();
                if (this.KeyFrameRateAvgVOC != null)
                    hash = hash * 59 + this.KeyFrameRateAvgVOC.GetHashCode();
                if (this.KeyFrameRateMinVI != null)
                    hash = hash * 59 + this.KeyFrameRateMinVI.GetHashCode();
                if (this.KeyFrameRateMinVO != null)
                    hash = hash * 59 + this.KeyFrameRateMinVO.GetHashCode();
                if (this.KeyFrameRateMinVIC != null)
                    hash = hash * 59 + this.KeyFrameRateMinVIC.GetHashCode();
                if (this.KeyFrameRateMinVOC != null)
                    hash = hash * 59 + this.KeyFrameRateMinVOC.GetHashCode();
                if (this.KeyFrameRateMaxVI != null)
                    hash = hash * 59 + this.KeyFrameRateMaxVI.GetHashCode();
                if (this.KeyFrameRateMaxVO != null)
                    hash = hash * 59 + this.KeyFrameRateMaxVO.GetHashCode();
                if (this.KeyFrameRateMaxVIC != null)
                    hash = hash * 59 + this.KeyFrameRateMaxVIC.GetHashCode();
                if (this.KeyFrameRateMaxVOC != null)
                    hash = hash * 59 + this.KeyFrameRateMaxVOC.GetHashCode();
                if (this.RoundTripDelayAvgVO != null)
                    hash = hash * 59 + this.RoundTripDelayAvgVO.GetHashCode();
                if (this.RoundTripDelayAvgVOC != null)
                    hash = hash * 59 + this.RoundTripDelayAvgVOC.GetHashCode();
                if (this.RoundTripDelayAvgAO != null)
                    hash = hash * 59 + this.RoundTripDelayAvgAO.GetHashCode();
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
