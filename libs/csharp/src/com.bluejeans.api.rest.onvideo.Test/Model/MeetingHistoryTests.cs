/* 
 * BlueJeans onVideo REST API
 *
 *  ## Video That Works Where You Do. This site provides developers access to APIs from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data and current state information. With these APIs you can quickly integrate **BlueJeans** video administration into your applications.   <hr>  <h2 class=\"info\"> What is a BlueJeans Meeting?</h2> <img src=\"./img/bjnmeeting.png\" style=\"padding-left:20px; width:50%\">  A BlueJeans meeting is a collaboration session of 2 or more participants joining a virtual meeting-room in the cloud.   The first person to join is put into a waiting-room until other participant(s) join.  When the meeting starts, all participants will be connected over video & audio.  <u>Types of Meeting Rooms</u> There are two types of Meeting Rooms available to a registered user.  They are described as: <ul> <li>Scheduled – A room created for a specific date and time.  It is assigned a randomized and unique numeric ID by BlueJeans.</li> <li>Personal – Every user is given a personal meeting room with a customized Meeting Identifier.  People typically use their mobile phone number as their Meeting ID.</li> </ul> <u>Meeting Room Security</u> A meeting room can <i>optionally</i> be protected by an access code.  THe access code can ensure security of participants who can join, and also designate user(s) who need an ability to moderate a meeting. <ul> <li>When set, participants would be required to enter the access code in order to join.</li> <li>, and may be assigned a moderator passcode allowing designated user(s) greater privileges to help organize meetings.</li> </ul> <hr>  <h2 id='gs' class=\"info\" onclick=\"hideit('gs')\"><span id=\"gsicon\" class=\"glyphicon glyphicon-chevron-right\"></span> Getting Started</h2> <div id=\"gsbody\" style=\"display:none\"> Before you start using BlueJeans' APIs, you must first have a BlueJeans account enabled for API Access.  Contact <a href=\"mailto:Support@BlueJeans.com)\">BlueJeans Support</a> for assistance.  <br /><br />Once you have an account, you may start writing application code to authenticate and make API calls.  *Alternatively*, you can use this developer site to test the BlueJeans' APIs and develop a level of familiarity before you write production code.  <br />  ### To Make API Calls from This Site If you want to use this developer site to try various BlueJeans' APIs, here are the steps required to authenticate and enable your Developer Session to place API calls. 1. Choose Method for Authenticating      * Click on the desired Authentication method from below.      * Click on the **Try It Out** button. 1. Make Authentication request      * Follow APIs instructions and input the API parameters.      * Click on the blue **Execute** button.      * If successful, the API returns with JSON data containing a field called **access_token**.  Copy/save this value. 1. Authorize BlueJeans Developer Session.      * Click on the green **Authorize button**.       * The site will show you a pop-up window for authorization.      * Enter your access token in the field named **api_key**      * Click on the **Authorize** button  Your current BlueJeans developer session is now authenticated and ready to place API calls.  The web site will automatically include your access token on any API calls you make. </div> <hr>  <h2 id='oauth' class=\"info\" onclick=\"hideit('oauth')\"><span id=\"oauthicon\" class=\"glyphicon glyphicon-chevron-right\"></span> About onVideo Authentication</h2>  <div id=\"oauthbody\" style=\"display:none\">  All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ### Grant Types Bluejeans provides 4 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to perform API operations. * Password Credentials Grant – Authenticate with a username and password and receive an access token with user level permission. Known as two-legged OAuth. * Meeting Credentials Grant – Authenticate with a meeting ID and meeting passcode and receive an access token with meeting level permission. Known as two-legged OAuth. * Client Credentials Grant –  Authenticate with a client ID and client secret and receive an access token with enterprise level permission. Known as two-legged OAuth. * Authorization Code Grant – Authentication for your developer's application occurs through a redirection to a BlueJeans authentication page. The application receives an authorization code to be submitted, along with other tokens, to receive an access token. Known as three-legged OAuth. For more information please refer to the [OAuth specification](https://oauth.net/). ### Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – Scope of APIs is limited to individual meetings. * User-level – Scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users. All endpoints in this document that require **Enterprise Admin** access will be marked as such. </div> <hr> 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.bluejeans.api.rest.onvideo.Api;
using com.bluejeans.api.rest.onvideo.Model;
using com.bluejeans.api.rest.onvideo.Client;
using System.Reflection;

namespace com.bluejeans.api.rest.onvideo.Test
{
    /// <summary>
    ///  Class for testing MeetingHistory
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MeetingHistoryTests
    {
        // TODO uncomment below to declare an instance variable for MeetingHistory
        //private MeetingHistory instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MeetingHistory
            //instance = new MeetingHistory();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MeetingHistory
        /// </summary>
        [Test]
        public void MeetingHistoryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MeetingHistory
            //Assert.IsInstanceOfType<MeetingHistory> (instance, "variable 'instance' is a MeetingHistory");
        }

        /// <summary>
        /// Test the property 'MeetingGuid'
        /// </summary>
        [Test]
        public void MeetingGuidTest()
        {
            // TODO unit test for the property 'MeetingGuid'
        }
        /// <summary>
        /// Test the property 'MeetingNumericId'
        /// </summary>
        [Test]
        public void MeetingNumericIdTest()
        {
            // TODO unit test for the property 'MeetingNumericId'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'LeaderInfo'
        /// </summary>
        [Test]
        public void LeaderInfoTest()
        {
            // TODO unit test for the property 'LeaderInfo'
        }
        /// <summary>
        /// Test the property 'UserId'
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO unit test for the property 'UserId'
        }
        /// <summary>
        /// Test the property 'MeetingDuration'
        /// </summary>
        [Test]
        public void MeetingDurationTest()
        {
            // TODO unit test for the property 'MeetingDuration'
        }
        /// <summary>
        /// Test the property 'MaxParticipantCount'
        /// </summary>
        [Test]
        public void MaxParticipantCountTest()
        {
            // TODO unit test for the property 'MaxParticipantCount'
        }
        /// <summary>
        /// Test the property 'TotalParticipantMinutes'
        /// </summary>
        [Test]
        public void TotalParticipantMinutesTest()
        {
            // TODO unit test for the property 'TotalParticipantMinutes'
        }
        /// <summary>
        /// Test the property 'MaxParticipantMinutes'
        /// </summary>
        [Test]
        public void MaxParticipantMinutesTest()
        {
            // TODO unit test for the property 'MaxParticipantMinutes'
        }
        /// <summary>
        /// Test the property 'ExtraParticipantMinutes'
        /// </summary>
        [Test]
        public void ExtraParticipantMinutesTest()
        {
            // TODO unit test for the property 'ExtraParticipantMinutes'
        }
        /// <summary>
        /// Test the property 'IsdnEndpoints'
        /// </summary>
        [Test]
        public void IsdnEndpointsTest()
        {
            // TODO unit test for the property 'IsdnEndpoints'
        }
        /// <summary>
        /// Test the property 'TotalDialoutMinutes'
        /// </summary>
        [Test]
        public void TotalDialoutMinutesTest()
        {
            // TODO unit test for the property 'TotalDialoutMinutes'
        }
        /// <summary>
        /// Test the property 'TotalTollFreeMinutes'
        /// </summary>
        [Test]
        public void TotalTollFreeMinutesTest()
        {
            // TODO unit test for the property 'TotalTollFreeMinutes'
        }
        /// <summary>
        /// Test the property 'CallDIDMinutes'
        /// </summary>
        [Test]
        public void CallDIDMinutesTest()
        {
            // TODO unit test for the property 'CallDIDMinutes'
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO unit test for the property 'EndTime'
        }
        /// <summary>
        /// Test the property 'MeetingStatus'
        /// </summary>
        [Test]
        public void MeetingStatusTest()
        {
            // TODO unit test for the property 'MeetingStatus'
        }
        /// <summary>
        /// Test the property 'MeetingThumbnail'
        /// </summary>
        [Test]
        public void MeetingThumbnailTest()
        {
            // TODO unit test for the property 'MeetingThumbnail'
        }
        /// <summary>
        /// Test the property 'StartTimeZone'
        /// </summary>
        [Test]
        public void StartTimeZoneTest()
        {
            // TODO unit test for the property 'StartTimeZone'
        }
        /// <summary>
        /// Test the property 'ProcessingStatus'
        /// </summary>
        [Test]
        public void ProcessingStatusTest()
        {
            // TODO unit test for the property 'ProcessingStatus'
        }
        /// <summary>
        /// Test the property 'ConcurrentCalls'
        /// </summary>
        [Test]
        public void ConcurrentCallsTest()
        {
            // TODO unit test for the property 'ConcurrentCalls'
        }
        /// <summary>
        /// Test the property 'UploadStatus'
        /// </summary>
        [Test]
        public void UploadStatusTest()
        {
            // TODO unit test for the property 'UploadStatus'
        }
        /// <summary>
        /// Test the property 'Pstnonly'
        /// </summary>
        [Test]
        public void PstnonlyTest()
        {
            // TODO unit test for the property 'Pstnonly'
        }
        /// <summary>
        /// Test the property 'ParticipantList'
        /// </summary>
        [Test]
        public void ParticipantListTest()
        {
            // TODO unit test for the property 'ParticipantList'
        }

    }

}
