/* 
 * BlueJeans onVideo REST API
 *
 * _Video That Works Where You Do, from the world's leader in cloud video communication._ # Authentication Each API request that is sent to BlueJeans requires an access token, which is obtained through the BlueJeans Authentication API. There are several methods (grant types) for obtaining an access token, which follow the OAuth2.0 specification. ## Grant Types * Authorization Code Grant – This grant type is used in an authentication flow commonly referred to as \"three-legged OAuth\". The user authenticates via a BlueJeans page, which provides an authorization code. This code, along with a few other elements, can be used to obtain an access code. * Password Credentials Grant – This grant type is used in a two-legged OAuth flow. Username and password are sent to retrieve an access code. * Client Credentials Grant – This grant type is used in a two-legged OAuth flow.  ## Access & Permissions The access level that is associated with each access token is referred to as the scope. There are three basic levels of access that BlueJeans allows, which affect the level of scope.  Three access levels exist within the Blue Jeans service today. * Meeting-level – Authentication takes place using a meeting ID and passcode, and the scope is limited to APIs that relate to the individual meeting. * User-level – Authentication either takes place via three-legged OAuth, or else a direct authorization token request containing a username or password. Access level depends on the requested scope permissions. * App-level – An application is provisioned either by BlueJeans personnel, or within the BlueJeans Enterprise Admin interface. When provisioning an app, a client key and secret are provided, which is then used to obtain an access token, via the BlueJeans Authentication API. The scope that is associated with the token will provide access to an entire enterprise and all of its users.  All endpoints in this document that require Enterprise Admin access will be marked as such. ## Testing In order to make effective use of this page, you will first use one of the authentication methods to obtain an access token. Once the token is given, use the Authenticate button up in the header to store the token. Each BlueJeans API called after that will use the access token provided. 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: brandon@bluejeans.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing RecordingRecordingChapters
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class RecordingRecordingChaptersTests
    {
        // TODO uncomment below to declare an instance variable for RecordingRecordingChapters
        //private RecordingRecordingChapters instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of RecordingRecordingChapters
            //instance = new RecordingRecordingChapters();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecordingRecordingChapters
        /// </summary>
        [Test]
        public void RecordingRecordingChaptersInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" RecordingRecordingChapters
            //Assert.IsInstanceOfType<RecordingRecordingChapters> (instance, "variable 'instance' is a RecordingRecordingChapters");
        }

        /// <summary>
        /// Test the property 'ChapterId'
        /// </summary>
        [Test]
        public void ChapterIdTest()
        {
            // TODO unit test for the property 'ChapterId'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'StartTimeOffset'
        /// </summary>
        [Test]
        public void StartTimeOffsetTest()
        {
            // TODO unit test for the property 'StartTimeOffset'
        }
        /// <summary>
        /// Test the property 'EndTimeOffset'
        /// </summary>
        [Test]
        public void EndTimeOffsetTest()
        {
            // TODO unit test for the property 'EndTimeOffset'
        }
        /// <summary>
        /// Test the property 'ChapterName'
        /// </summary>
        [Test]
        public void ChapterNameTest()
        {
            // TODO unit test for the property 'ChapterName'
        }
        /// <summary>
        /// Test the property 'TotalSize'
        /// </summary>
        [Test]
        public void TotalSizeTest()
        {
            // TODO unit test for the property 'TotalSize'
        }
        /// <summary>
        /// Test the property 'CompositeContentId'
        /// </summary>
        [Test]
        public void CompositeContentIdTest()
        {
            // TODO unit test for the property 'CompositeContentId'
        }
        /// <summary>
        /// Test the property 'CompositeContentStatus'
        /// </summary>
        [Test]
        public void CompositeContentStatusTest()
        {
            // TODO unit test for the property 'CompositeContentStatus'
        }
        /// <summary>
        /// Test the property 'ParentRecordingId'
        /// </summary>
        [Test]
        public void ParentRecordingIdTest()
        {
            // TODO unit test for the property 'ParentRecordingId'
        }
        /// <summary>
        /// Test the property 'ViewCount'
        /// </summary>
        [Test]
        public void ViewCountTest()
        {
            // TODO unit test for the property 'ViewCount'
        }
        /// <summary>
        /// Test the property 'RecordingSessions'
        /// </summary>
        [Test]
        public void RecordingSessionsTest()
        {
            // TODO unit test for the property 'RecordingSessions'
        }

    }

}