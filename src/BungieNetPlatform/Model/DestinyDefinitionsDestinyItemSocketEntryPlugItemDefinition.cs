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
    /// The definition of a known, reusable plug that can be applied to a socket.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition :  IEquatable<DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition" /> class.
        /// </summary>
        /// <param name="PlugItemHash">The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted..</param>
        public DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition(uint? PlugItemHash = default(uint?))
        {
            this.PlugItemHash = PlugItemHash;
        }
        
        /// <summary>
        /// The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
        /// </summary>
        /// <value>The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.</value>
        [DataMember(Name="plugItemHash", EmitDefaultValue=false)]
        public uint? PlugItemHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition {\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition input)
        {
            if (input == null)
                return false;

            return 
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
