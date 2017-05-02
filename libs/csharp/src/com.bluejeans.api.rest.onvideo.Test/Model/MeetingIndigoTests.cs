/* 
 * BlueJeans onVideo REST API
 *
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
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
    ///  Class for testing MeetingIndigo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MeetingIndigoTests
    {
        // TODO uncomment below to declare an instance variable for MeetingIndigo
        //private MeetingIndigo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MeetingIndigo
            //instance = new MeetingIndigo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MeetingIndigo
        /// </summary>
        [Test]
        public void MeetingIndigoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MeetingIndigo
            //Assert.IsInstanceOfType<MeetingIndigo> (instance, "variable 'instance' is a MeetingIndigo");
        }

        /// <summary>
        /// Test the property 'MeetingId'
        /// </summary>
        [Test]
        public void MeetingIdTest()
        {
            // TODO unit test for the property 'MeetingId'
        }
        /// <summary>
        /// Test the property 'MeetingUUID'
        /// </summary>
        [Test]
        public void MeetingUUIDTest()
        {
            // TODO unit test for the property 'MeetingUUID'
        }
        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Test]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'EncryptionType'
        /// </summary>
        [Test]
        public void EncryptionTypeTest()
        {
            // TODO unit test for the property 'EncryptionType'
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
        /// Test the property 'UserFullName'
        /// </summary>
        [Test]
        public void UserFullNameTest()
        {
            // TODO unit test for the property 'UserFullName'
        }
        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO unit test for the property 'PhoneNumber'
        }
        /// <summary>
        /// Test the property 'UserFeatures'
        /// </summary>
        [Test]
        public void UserFeaturesTest()
        {
            // TODO unit test for the property 'UserFeatures'
        }
        /// <summary>
        /// Test the property 'ScheduledFrom'
        /// </summary>
        [Test]
        public void ScheduledFromTest()
        {
            // TODO unit test for the property 'ScheduledFrom'
        }
        /// <summary>
        /// Test the property 'InviteeCount'
        /// </summary>
        [Test]
        public void InviteeCountTest()
        {
            // TODO unit test for the property 'InviteeCount'
        }
        /// <summary>
        /// Test the property 'Personal'
        /// </summary>
        [Test]
        public void PersonalTest()
        {
            // TODO unit test for the property 'Personal'
        }
        /// <summary>
        /// Test the property 'MuteOnEntry'
        /// </summary>
        [Test]
        public void MuteOnEntryTest()
        {
            // TODO unit test for the property 'MuteOnEntry'
        }
        /// <summary>
        /// Test the property 'AutoRecord'
        /// </summary>
        [Test]
        public void AutoRecordTest()
        {
            // TODO unit test for the property 'AutoRecord'
        }
        /// <summary>
        /// Test the property 'EnterpriseName'
        /// </summary>
        [Test]
        public void EnterpriseNameTest()
        {
            // TODO unit test for the property 'EnterpriseName'
        }
        /// <summary>
        /// Test the property 'ModeratorLess'
        /// </summary>
        [Test]
        public void ModeratorLessTest()
        {
            // TODO unit test for the property 'ModeratorLess'
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
        /// Test the property 'TotalCallSeconds'
        /// </summary>
        [Test]
        public void TotalCallSecondsTest()
        {
            // TODO unit test for the property 'TotalCallSeconds'
        }
        /// <summary>
        /// Test the property 'CreateTime'
        /// </summary>
        [Test]
        public void CreateTimeTest()
        {
            // TODO unit test for the property 'CreateTime'
        }
        /// <summary>
        /// Test the property 'EndpointsCount'
        /// </summary>
        [Test]
        public void EndpointsCountTest()
        {
            // TODO unit test for the property 'EndpointsCount'
        }
        /// <summary>
        /// Test the property 'ConcurrentEndpoints'
        /// </summary>
        [Test]
        public void ConcurrentEndpointsTest()
        {
            // TODO unit test for the property 'ConcurrentEndpoints'
        }
        /// <summary>
        /// Test the property 'LiveVisibleEndpointsCount'
        /// </summary>
        [Test]
        public void LiveVisibleEndpointsCountTest()
        {
            // TODO unit test for the property 'LiveVisibleEndpointsCount'
        }
        /// <summary>
        /// Test the property 'QualarooRating'
        /// </summary>
        [Test]
        public void QualarooRatingTest()
        {
            // TODO unit test for the property 'QualarooRating'
        }
        /// <summary>
        /// Test the property 'QualarooCount'
        /// </summary>
        [Test]
        public void QualarooCountTest()
        {
            // TODO unit test for the property 'QualarooCount'
        }
        /// <summary>
        /// Test the property 'MeetingRecording'
        /// </summary>
        [Test]
        public void MeetingRecordingTest()
        {
            // TODO unit test for the property 'MeetingRecording'
        }
        /// <summary>
        /// Test the property 'VideoShare'
        /// </summary>
        [Test]
        public void VideoShareTest()
        {
            // TODO unit test for the property 'VideoShare'
        }
        /// <summary>
        /// Test the property 'ContentShare'
        /// </summary>
        [Test]
        public void ContentShareTest()
        {
            // TODO unit test for the property 'ContentShare'
        }
        /// <summary>
        /// Test the property 'LiveRecording'
        /// </summary>
        [Test]
        public void LiveRecordingTest()
        {
            // TODO unit test for the property 'LiveRecording'
        }
        /// <summary>
        /// Test the property 'LiveVideoShare'
        /// </summary>
        [Test]
        public void LiveVideoShareTest()
        {
            // TODO unit test for the property 'LiveVideoShare'
        }
        /// <summary>
        /// Test the property 'LiveContentShare'
        /// </summary>
        [Test]
        public void LiveContentShareTest()
        {
            // TODO unit test for the property 'LiveContentShare'
        }
        /// <summary>
        /// Test the property 'LargeMeeting'
        /// </summary>
        [Test]
        public void LargeMeetingTest()
        {
            // TODO unit test for the property 'LargeMeeting'
        }
        /// <summary>
        /// Test the property 'RoiDistance'
        /// </summary>
        [Test]
        public void RoiDistanceTest()
        {
            // TODO unit test for the property 'RoiDistance'
        }
        /// <summary>
        /// Test the property 'Mpls'
        /// </summary>
        [Test]
        public void MplsTest()
        {
            // TODO unit test for the property 'Mpls'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

    }

}
