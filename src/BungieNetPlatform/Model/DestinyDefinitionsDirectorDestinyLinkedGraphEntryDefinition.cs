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
    /// DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition :  IEquatable<DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition" /> class.
        /// </summary>
        /// <param name="ActivityGraphHash">ActivityGraphHash.</param>
        public DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition(uint? ActivityGraphHash = default(uint?))
        {
            this.ActivityGraphHash = ActivityGraphHash;
        }
        
        /// <summary>
        /// Gets or Sets ActivityGraphHash
        /// </summary>
        [DataMember(Name="activityGraphHash", EmitDefaultValue=false)]
        public uint? ActivityGraphHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition {\n");
            sb.Append("  ActivityGraphHash: ").Append(ActivityGraphHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivityGraphHash == input.ActivityGraphHash ||
                    (this.ActivityGraphHash != null &&
                    this.ActivityGraphHash.Equals(input.ActivityGraphHash))
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
                if (this.ActivityGraphHash != null)
                    hashCode = hashCode * 59 + this.ActivityGraphHash.GetHashCode();
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
