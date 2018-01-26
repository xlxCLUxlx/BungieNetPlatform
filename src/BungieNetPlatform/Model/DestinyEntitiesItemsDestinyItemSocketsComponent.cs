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
    /// Instanced items can have sockets, which are slots on the item where plugs can be inserted.  Sockets are a bit complex: be sure to examine the documentation on the DestinyInventoryItemDefinition&#39;s \&quot;socket\&quot; block and elsewhere on these objects for more details.
    /// </summary>
    [DataContract]
    public partial class DestinyEntitiesItemsDestinyItemSocketsComponent :  IEquatable<DestinyEntitiesItemsDestinyItemSocketsComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyEntitiesItemsDestinyItemSocketsComponent" /> class.
        /// </summary>
        /// <param name="Sockets">The list of all sockets on the item, and their status information..</param>
        public DestinyEntitiesItemsDestinyItemSocketsComponent(List<DestinyEntitiesItemsDestinyItemSocketState> Sockets = default(List<DestinyEntitiesItemsDestinyItemSocketState>))
        {
            this.Sockets = Sockets;
        }
        
        /// <summary>
        /// The list of all sockets on the item, and their status information.
        /// </summary>
        /// <value>The list of all sockets on the item, and their status information.</value>
        [DataMember(Name="sockets", EmitDefaultValue=false)]
        public List<DestinyEntitiesItemsDestinyItemSocketState> Sockets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyEntitiesItemsDestinyItemSocketsComponent {\n");
            sb.Append("  Sockets: ").Append(Sockets).Append("\n");
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
            return this.Equals(input as DestinyEntitiesItemsDestinyItemSocketsComponent);
        }

        /// <summary>
        /// Returns true if DestinyEntitiesItemsDestinyItemSocketsComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyEntitiesItemsDestinyItemSocketsComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyEntitiesItemsDestinyItemSocketsComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sockets == input.Sockets ||
                    this.Sockets != null &&
                    this.Sockets.SequenceEqual(input.Sockets)
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
                if (this.Sockets != null)
                    hashCode = hashCode * 59 + this.Sockets.GetHashCode();
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
