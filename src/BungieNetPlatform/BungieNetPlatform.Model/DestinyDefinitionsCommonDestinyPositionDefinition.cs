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
    /// DestinyDefinitionsCommonDestinyPositionDefinition
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsCommonDestinyPositionDefinition :  IEquatable<DestinyDefinitionsCommonDestinyPositionDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsCommonDestinyPositionDefinition" /> class.
        /// </summary>
        /// <param name="X">X.</param>
        /// <param name="Y">Y.</param>
        /// <param name="Z">Z.</param>
        public DestinyDefinitionsCommonDestinyPositionDefinition(int? X = default(int?), int? Y = default(int?), int? Z = default(int?))
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
        
        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// Gets or Sets Z
        /// </summary>
        [DataMember(Name="z", EmitDefaultValue=false)]
        public int? Z { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsCommonDestinyPositionDefinition {\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsCommonDestinyPositionDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsCommonDestinyPositionDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsCommonDestinyPositionDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsCommonDestinyPositionDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.Z == input.Z ||
                    (this.Z != null &&
                    this.Z.Equals(input.Z))
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
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.Z != null)
                    hashCode = hashCode * 59 + this.Z.GetHashCode();
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
