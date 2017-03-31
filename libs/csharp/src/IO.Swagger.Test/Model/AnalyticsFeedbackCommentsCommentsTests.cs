/* 
 * BlueJeans onVideo REST API
 *
 * _Video That Works Where You Do._  This site provides developers access to API's from BlueJean's onVideo meeting service.  From here you will be able to make actual API calls to manage User Accounts, Meetings, and Recordings.  Also, you can pull analytical data as well retrieve current state information.  With these API's  you should be able to quickly integrate **BlueJeans** video into your applications.     # Authentication All API transactions (excluding Authentication) require an access token per **OAuth standards**.  BlueJeans provides multiple methods for obtaining an access token.  Additionally there are diffferent scopes of token access. ## Grant Types Bluejeans provides 3 different methods for users to Authenticate.  Successful authentication allows BlueJeans to grant an access token to the user. * Authorization Code Grant – Authenticate via a BlueJeans page, and receive an authorization code. Submit authorization with other tokens and receive an access code. (\"three-legged OAuth\") * Password Credentials Grant – Authenticate with a Username and password and receives an access code. (\"two-legged OAuth\"); * Client Credentials Grant – Similar to Password Grant (\"two-legged OAuth\").  ## Access & Permissions BlueJeans defines 3 levels of API access into the system.  When an access token is granted, it carries one of these 3 levels.  The scope of system functionality depends upon the token's access level. * Meeting-level – scope of APIs is limited to individual meetings. * User-level – scope depends on the requested permissions. * App-level – provisioned either by BlueJeans personnel, or the BlueJeans Enterprise Admin, an app, is issued a client key and secret key. These tokens then are used by the BlueJeans Authentication API to receive the token. The token's scope provides access to the entire enterprise and all of its users.  All endpoints in this document that require **Enterprise Admin** access will be marked as such. # Getting Started Before you start using the API's on this site, you must first have a BlueJeans account.  With your BlueJean credentials, use on of the Authentication methods to obtain an access token. - Click on the Authorize button at the top of page - Enter your access token in the field marked \"api_key\" Now the web site will automatically include your access token on all API calls you make. 
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
    ///  Class for testing AnalyticsFeedbackCommentsComments
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AnalyticsFeedbackCommentsCommentsTests
    {
        // TODO uncomment below to declare an instance variable for AnalyticsFeedbackCommentsComments
        //private AnalyticsFeedbackCommentsComments instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of AnalyticsFeedbackCommentsComments
            //instance = new AnalyticsFeedbackCommentsComments();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AnalyticsFeedbackCommentsComments
        /// </summary>
        [Test]
        public void AnalyticsFeedbackCommentsCommentsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AnalyticsFeedbackCommentsComments
            //Assert.IsInstanceOfType<AnalyticsFeedbackCommentsComments> (instance, "variable 'instance' is a AnalyticsFeedbackCommentsComments");
        }

        /// <summary>
        /// Test the property 'QualarooFeedback'
        /// </summary>
        [Test]
        public void QualarooFeedbackTest()
        {
            // TODO unit test for the property 'QualarooFeedback'
        }
        /// <summary>
        /// Test the property 'MeetingUuid'
        /// </summary>
        [Test]
        public void MeetingUuidTest()
        {
            // TODO unit test for the property 'MeetingUuid'
        }
        /// <summary>
        /// Test the property 'Callguid'
        /// </summary>
        [Test]
        public void CallguidTest()
        {
            // TODO unit test for the property 'Callguid'
        }
        /// <summary>
        /// Test the property 'QualarooComments'
        /// </summary>
        [Test]
        public void QualarooCommentsTest()
        {
            // TODO unit test for the property 'QualarooComments'
        }

    }

}
