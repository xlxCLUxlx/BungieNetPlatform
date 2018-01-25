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
    /// MessagesResponsesSaveMessageResult
    /// </summary>
    [DataContract]
    public partial class MessagesResponsesSaveMessageResult :  IEquatable<MessagesResponsesSaveMessageResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResponsesSaveMessageResult" /> class.
        /// </summary>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="MessageId">MessageId.</param>
        public MessagesResponsesSaveMessageResult(long? ConversationId = default(long?), long? MessageId = default(long?))
        {
            this.ConversationId = ConversationId;
            this.MessageId = MessageId;
        }
        
        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public long? ConversationId { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public long? MessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagesResponsesSaveMessageResult {\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
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
            return this.Equals(input as MessagesResponsesSaveMessageResult);
        }

        /// <summary>
        /// Returns true if MessagesResponsesSaveMessageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MessagesResponsesSaveMessageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagesResponsesSaveMessageResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConversationId == input.ConversationId ||
                    (this.ConversationId != null &&
                    this.ConversationId.Equals(input.ConversationId))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
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
                if (this.ConversationId != null)
                    hashCode = hashCode * 59 + this.ConversationId.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
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
