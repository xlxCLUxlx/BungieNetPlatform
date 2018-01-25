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
    /// IgnoresIgnoreResponse
    /// </summary>
    [DataContract]
    public partial class IgnoresIgnoreResponse :  IEquatable<IgnoresIgnoreResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IgnoresIgnoreResponse" /> class.
        /// </summary>
        /// <param name="IsIgnored">IsIgnored.</param>
        /// <param name="IgnoreFlags">IgnoreFlags.</param>
        public IgnoresIgnoreResponse(bool? IsIgnored = default(bool?), IgnoresIgnoreStatus IgnoreFlags = default(IgnoresIgnoreStatus))
        {
            this.IsIgnored = IsIgnored;
            this.IgnoreFlags = IgnoreFlags;
        }
        
        /// <summary>
        /// Gets or Sets IsIgnored
        /// </summary>
        [DataMember(Name="isIgnored", EmitDefaultValue=false)]
        public bool? IsIgnored { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreFlags
        /// </summary>
        [DataMember(Name="ignoreFlags", EmitDefaultValue=false)]
        public IgnoresIgnoreStatus IgnoreFlags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IgnoresIgnoreResponse {\n");
            sb.Append("  IsIgnored: ").Append(IsIgnored).Append("\n");
            sb.Append("  IgnoreFlags: ").Append(IgnoreFlags).Append("\n");
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
            return this.Equals(input as IgnoresIgnoreResponse);
        }

        /// <summary>
        /// Returns true if IgnoresIgnoreResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IgnoresIgnoreResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IgnoresIgnoreResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsIgnored == input.IsIgnored ||
                    (this.IsIgnored != null &&
                    this.IsIgnored.Equals(input.IsIgnored))
                ) && 
                (
                    this.IgnoreFlags == input.IgnoreFlags ||
                    (this.IgnoreFlags != null &&
                    this.IgnoreFlags.Equals(input.IgnoreFlags))
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
                if (this.IsIgnored != null)
                    hashCode = hashCode * 59 + this.IsIgnored.GetHashCode();
                if (this.IgnoreFlags != null)
                    hashCode = hashCode * 59 + this.IgnoreFlags.GetHashCode();
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
