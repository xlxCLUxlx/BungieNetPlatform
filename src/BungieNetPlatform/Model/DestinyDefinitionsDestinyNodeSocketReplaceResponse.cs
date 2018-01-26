/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * OpenAPI spec version: 2.1.1
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

namespace BungieNetPlatform.Model
{
    /// <summary>
    /// This is a bit of an odd duck. Apparently, if talent nodes steps have this data, the game will go through on step activation and alter the first Socket it finds on the item that has a type matching the given socket type, inserting the indicated plug item.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyNodeSocketReplaceResponse :  IEquatable<DestinyDefinitionsDestinyNodeSocketReplaceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyNodeSocketReplaceResponse" /> class.
        /// </summary>
        /// <param name="SocketTypeHash">The hash identifier of the socket type to find amidst the item&#39;s sockets (the item to which this talent grid is attached). See DestinyInventoryItemDefinition.sockets.socketEntries to find the socket type of sockets on the item in question..</param>
        /// <param name="PlugItemHash">The hash identifier of the plug item that will be inserted into the socket found..</param>
        public DestinyDefinitionsDestinyNodeSocketReplaceResponse(uint? SocketTypeHash = default(uint?), uint? PlugItemHash = default(uint?))
        {
            this.SocketTypeHash = SocketTypeHash;
            this.PlugItemHash = PlugItemHash;
        }
        
        /// <summary>
        /// The hash identifier of the socket type to find amidst the item&#39;s sockets (the item to which this talent grid is attached). See DestinyInventoryItemDefinition.sockets.socketEntries to find the socket type of sockets on the item in question.
        /// </summary>
        /// <value>The hash identifier of the socket type to find amidst the item&#39;s sockets (the item to which this talent grid is attached). See DestinyInventoryItemDefinition.sockets.socketEntries to find the socket type of sockets on the item in question.</value>
        [DataMember(Name="socketTypeHash", EmitDefaultValue=false)]
        public uint? SocketTypeHash { get; set; }

        /// <summary>
        /// The hash identifier of the plug item that will be inserted into the socket found.
        /// </summary>
        /// <value>The hash identifier of the plug item that will be inserted into the socket found.</value>
        [DataMember(Name="plugItemHash", EmitDefaultValue=false)]
        public uint? PlugItemHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyNodeSocketReplaceResponse {\n");
            sb.Append("  SocketTypeHash: ").Append(SocketTypeHash).Append("\n");
            sb.Append("  PlugItemHash: ").Append(PlugItemHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyNodeSocketReplaceResponse);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyNodeSocketReplaceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyNodeSocketReplaceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyNodeSocketReplaceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SocketTypeHash == input.SocketTypeHash ||
                    (this.SocketTypeHash != null &&
                    this.SocketTypeHash.Equals(input.SocketTypeHash))
                ) && 
                (
                    this.PlugItemHash == input.PlugItemHash ||
                    (this.PlugItemHash != null &&
                    this.PlugItemHash.Equals(input.PlugItemHash))
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
                if (this.SocketTypeHash != null)
                    hashCode = hashCode * 59 + this.SocketTypeHash.GetHashCode();
                if (this.PlugItemHash != null)
                    hashCode = hashCode * 59 + this.PlugItemHash.GetHashCode();
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
