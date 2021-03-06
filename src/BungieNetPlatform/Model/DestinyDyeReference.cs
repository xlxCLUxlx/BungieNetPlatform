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
    /// DestinyDyeReference
    /// </summary>
    [DataContract]
    public partial class DestinyDyeReference :  IEquatable<DestinyDyeReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDyeReference" /> class.
        /// </summary>
        /// <param name="ChannelHash">ChannelHash.</param>
        /// <param name="DyeHash">DyeHash.</param>
        public DestinyDyeReference(uint? ChannelHash = default(uint?), uint? DyeHash = default(uint?))
        {
            this.ChannelHash = ChannelHash;
            this.DyeHash = DyeHash;
        }
        
        /// <summary>
        /// Gets or Sets ChannelHash
        /// </summary>
        [DataMember(Name="channelHash", EmitDefaultValue=false)]
        public uint? ChannelHash { get; set; }

        /// <summary>
        /// Gets or Sets DyeHash
        /// </summary>
        [DataMember(Name="dyeHash", EmitDefaultValue=false)]
        public uint? DyeHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDyeReference {\n");
            sb.Append("  ChannelHash: ").Append(ChannelHash).Append("\n");
            sb.Append("  DyeHash: ").Append(DyeHash).Append("\n");
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
            return this.Equals(input as DestinyDyeReference);
        }

        /// <summary>
        /// Returns true if DestinyDyeReference instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDyeReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDyeReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelHash == input.ChannelHash ||
                    (this.ChannelHash != null &&
                    this.ChannelHash.Equals(input.ChannelHash))
                ) && 
                (
                    this.DyeHash == input.DyeHash ||
                    (this.DyeHash != null &&
                    this.DyeHash.Equals(input.DyeHash))
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
                if (this.ChannelHash != null)
                    hashCode = hashCode * 59 + this.ChannelHash.GetHashCode();
                if (this.DyeHash != null)
                    hashCode = hashCode * 59 + this.DyeHash.GetHashCode();
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
