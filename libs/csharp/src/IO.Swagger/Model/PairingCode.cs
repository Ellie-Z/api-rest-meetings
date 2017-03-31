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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// PairingCode
    /// </summary>
    [DataContract]
    public partial class PairingCode :  IEquatable<PairingCode>
    {
        /// <summary>
        /// Gets or Sets StatusText
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusTextEnum
        {
            
            /// <summary>
            /// Enum OK for "OK"
            /// </summary>
            [EnumMember(Value = "OK")]
            OK
        }

        /// <summary>
        /// Gets or Sets StatusText
        /// </summary>
        [DataMember(Name="statusText", EmitDefaultValue=false)]
        public StatusTextEnum? StatusText { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PairingCode" /> class.
        /// </summary>
        /// <param name="Callguid">Callguid.</param>
        /// <param name="EndpointGuid">EndpointGuid.</param>
        /// <param name="ForceTURN">ForceTURN.</param>
        /// <param name="_PairingCode">_PairingCode.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StatusText">StatusText.</param>
        /// <param name="Turnservers">Turnservers.</param>
        /// <param name="Uri">Uri.</param>
        /// <param name="SeamEndpointGuid">SeamEndpointGuid.</param>
        /// <param name="ConnectionGuid">ConnectionGuid.</param>
        /// <param name="EndpointName">EndpointName.</param>
        public PairingCode(string Callguid = null, string EndpointGuid = null, bool? ForceTURN = null, string _PairingCode = null, int? Status = null, StatusTextEnum? StatusText = null, List<PairingCodeTurnservers> Turnservers = null, string Uri = null, string SeamEndpointGuid = null, string ConnectionGuid = null, string EndpointName = null)
        {
            this.Callguid = Callguid;
            this.EndpointGuid = EndpointGuid;
            this.ForceTURN = ForceTURN;
            this._PairingCode = _PairingCode;
            this.Status = Status;
            this.StatusText = StatusText;
            this.Turnservers = Turnservers;
            this.Uri = Uri;
            this.SeamEndpointGuid = SeamEndpointGuid;
            this.ConnectionGuid = ConnectionGuid;
            this.EndpointName = EndpointName;
        }
        
        /// <summary>
        /// Gets or Sets Callguid
        /// </summary>
        [DataMember(Name="callguid", EmitDefaultValue=false)]
        public string Callguid { get; set; }
        /// <summary>
        /// Gets or Sets EndpointGuid
        /// </summary>
        [DataMember(Name="endpointGuid", EmitDefaultValue=false)]
        public string EndpointGuid { get; set; }
        /// <summary>
        /// Gets or Sets ForceTURN
        /// </summary>
        [DataMember(Name="forceTURN", EmitDefaultValue=false)]
        public bool? ForceTURN { get; set; }
        /// <summary>
        /// Gets or Sets _PairingCode
        /// </summary>
        [DataMember(Name="pairingCode", EmitDefaultValue=false)]
        public string _PairingCode { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
        /// <summary>
        /// Gets or Sets Turnservers
        /// </summary>
        [DataMember(Name="turnservers", EmitDefaultValue=false)]
        public List<PairingCodeTurnservers> Turnservers { get; set; }
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Gets or Sets SeamEndpointGuid
        /// </summary>
        [DataMember(Name="seamEndpointGuid", EmitDefaultValue=false)]
        public string SeamEndpointGuid { get; set; }
        /// <summary>
        /// Gets or Sets ConnectionGuid
        /// </summary>
        [DataMember(Name="connectionGuid", EmitDefaultValue=false)]
        public string ConnectionGuid { get; set; }
        /// <summary>
        /// Gets or Sets EndpointName
        /// </summary>
        [DataMember(Name="endpointName", EmitDefaultValue=false)]
        public string EndpointName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PairingCode {\n");
            sb.Append("  Callguid: ").Append(Callguid).Append("\n");
            sb.Append("  EndpointGuid: ").Append(EndpointGuid).Append("\n");
            sb.Append("  ForceTURN: ").Append(ForceTURN).Append("\n");
            sb.Append("  _PairingCode: ").Append(_PairingCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusText: ").Append(StatusText).Append("\n");
            sb.Append("  Turnservers: ").Append(Turnservers).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  SeamEndpointGuid: ").Append(SeamEndpointGuid).Append("\n");
            sb.Append("  ConnectionGuid: ").Append(ConnectionGuid).Append("\n");
            sb.Append("  EndpointName: ").Append(EndpointName).Append("\n");
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
            return this.Equals(obj as PairingCode);
        }

        /// <summary>
        /// Returns true if PairingCode instances are equal
        /// </summary>
        /// <param name="other">Instance of PairingCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PairingCode other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Callguid == other.Callguid ||
                    this.Callguid != null &&
                    this.Callguid.Equals(other.Callguid)
                ) && 
                (
                    this.EndpointGuid == other.EndpointGuid ||
                    this.EndpointGuid != null &&
                    this.EndpointGuid.Equals(other.EndpointGuid)
                ) && 
                (
                    this.ForceTURN == other.ForceTURN ||
                    this.ForceTURN != null &&
                    this.ForceTURN.Equals(other.ForceTURN)
                ) && 
                (
                    this._PairingCode == other._PairingCode ||
                    this._PairingCode != null &&
                    this._PairingCode.Equals(other._PairingCode)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusText == other.StatusText ||
                    this.StatusText != null &&
                    this.StatusText.Equals(other.StatusText)
                ) && 
                (
                    this.Turnservers == other.Turnservers ||
                    this.Turnservers != null &&
                    this.Turnservers.SequenceEqual(other.Turnservers)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.SeamEndpointGuid == other.SeamEndpointGuid ||
                    this.SeamEndpointGuid != null &&
                    this.SeamEndpointGuid.Equals(other.SeamEndpointGuid)
                ) && 
                (
                    this.ConnectionGuid == other.ConnectionGuid ||
                    this.ConnectionGuid != null &&
                    this.ConnectionGuid.Equals(other.ConnectionGuid)
                ) && 
                (
                    this.EndpointName == other.EndpointName ||
                    this.EndpointName != null &&
                    this.EndpointName.Equals(other.EndpointName)
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
                if (this.Callguid != null)
                    hash = hash * 59 + this.Callguid.GetHashCode();
                if (this.EndpointGuid != null)
                    hash = hash * 59 + this.EndpointGuid.GetHashCode();
                if (this.ForceTURN != null)
                    hash = hash * 59 + this.ForceTURN.GetHashCode();
                if (this._PairingCode != null)
                    hash = hash * 59 + this._PairingCode.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StatusText != null)
                    hash = hash * 59 + this.StatusText.GetHashCode();
                if (this.Turnservers != null)
                    hash = hash * 59 + this.Turnservers.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                if (this.SeamEndpointGuid != null)
                    hash = hash * 59 + this.SeamEndpointGuid.GetHashCode();
                if (this.ConnectionGuid != null)
                    hash = hash * 59 + this.ConnectionGuid.GetHashCode();
                if (this.EndpointName != null)
                    hash = hash * 59 + this.EndpointName.GetHashCode();
                return hash;
            }
        }
    }

}
