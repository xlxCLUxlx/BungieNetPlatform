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
    /// Basic identifying data about the bubble. Combine with DestinyDestinationBubbleSettingDefinition - see DestinyDestinationDefinition.bubbleSettings for more information.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyBubbleDefinition :  IEquatable<DestinyDefinitionsDestinyBubbleDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyBubbleDefinition" /> class.
        /// </summary>
        /// <param name="Hash">The identifier for the bubble: only guaranteed to be unique within the Destination..</param>
        public DestinyDefinitionsDestinyBubbleDefinition(uint? Hash = default(uint?))
        {
            this.Hash = Hash;
        }
        
        /// <summary>
        /// The identifier for the bubble: only guaranteed to be unique within the Destination.
        /// </summary>
        /// <value>The identifier for the bubble: only guaranteed to be unique within the Destination.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public uint? Hash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyBubbleDefinition {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyBubbleDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyBubbleDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyBubbleDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyBubbleDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
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
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
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
