/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * OpenAPI spec version: 2.0.1
 * Contact: support@bungie.com
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
using SwaggerDateConverter = BungieNetPlatform.Client.SwaggerDateConverter;

namespace BungieNetPlatform.BungieNetPlatform.Model
{
    /// <summary>
    /// GroupsV2GroupOptionalConversationEditRequest
    /// </summary>
    [DataContract]
    public partial class GroupsV2GroupOptionalConversationEditRequest :  IEquatable<GroupsV2GroupOptionalConversationEditRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ChatSecurity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChatSecurityEnum
        {
            
            /// <summary>
            /// Enum Group for 0
            /// </summary>
            [EnumMember(Value = "0")]
            Group = 0,
            
            /// <summary>
            /// Enum Admins for 1
            /// </summary>
            [EnumMember(Value = "1")]
            Admins = 1
        }

        /// <summary>
        /// Gets or Sets ChatSecurity
        /// </summary>
        [DataMember(Name="chatSecurity", EmitDefaultValue=false)]
        public ChatSecurityEnum? ChatSecurity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupOptionalConversationEditRequest" /> class.
        /// </summary>
        /// <param name="ChatEnabled">ChatEnabled.</param>
        /// <param name="ChatName">ChatName.</param>
        /// <param name="ChatSecurity">ChatSecurity.</param>
        public GroupsV2GroupOptionalConversationEditRequest(bool? ChatEnabled = default(bool?), string ChatName = default(string), ChatSecurityEnum? ChatSecurity = default(ChatSecurityEnum?))
        {
            this.ChatEnabled = ChatEnabled;
            this.ChatName = ChatName;
            this.ChatSecurity = ChatSecurity;
        }
        
        /// <summary>
        /// Gets or Sets ChatEnabled
        /// </summary>
        [DataMember(Name="chatEnabled", EmitDefaultValue=false)]
        public bool? ChatEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ChatName
        /// </summary>
        [DataMember(Name="chatName", EmitDefaultValue=false)]
        public string ChatName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsV2GroupOptionalConversationEditRequest {\n");
            sb.Append("  ChatEnabled: ").Append(ChatEnabled).Append("\n");
            sb.Append("  ChatName: ").Append(ChatName).Append("\n");
            sb.Append("  ChatSecurity: ").Append(ChatSecurity).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupsV2GroupOptionalConversationEditRequest);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupOptionalConversationEditRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupOptionalConversationEditRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupOptionalConversationEditRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChatEnabled == input.ChatEnabled ||
                    (this.ChatEnabled != null &&
                    this.ChatEnabled.Equals(input.ChatEnabled))
                ) && 
                (
                    this.ChatName == input.ChatName ||
                    (this.ChatName != null &&
                    this.ChatName.Equals(input.ChatName))
                ) && 
                (
                    this.ChatSecurity == input.ChatSecurity ||
                    (this.ChatSecurity != null &&
                    this.ChatSecurity.Equals(input.ChatSecurity))
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
                if (this.ChatEnabled != null)
                    hashCode = hashCode * 59 + this.ChatEnabled.GetHashCode();
                if (this.ChatName != null)
                    hashCode = hashCode * 59 + this.ChatName.GetHashCode();
                if (this.ChatSecurity != null)
                    hashCode = hashCode * 59 + this.ChatSecurity.GetHashCode();
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
