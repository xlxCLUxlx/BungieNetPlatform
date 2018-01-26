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
    /// Display Categories are different from \&quot;categories\&quot; in that these are specifically for visual grouping and display of categories in Vendor UI. The \&quot;categories\&quot; structure is for validation of the contained items, and can be categorized entirely separately from \&quot;Display Categories\&quot;, there need be and often will be no meaningful relationship between the two.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyDisplayCategoryDefinition :  IEquatable<DestinyDefinitionsDestinyDisplayCategoryDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyDisplayCategoryDefinition" /> class.
        /// </summary>
        /// <param name="Identifier">A string identifier for the display category..</param>
        /// <param name="DisplayProperties">DisplayProperties.</param>
        public DestinyDefinitionsDestinyDisplayCategoryDefinition(string Identifier = default(string), DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition))
        {
            this.Identifier = Identifier;
            this.DisplayProperties = DisplayProperties;
        }
        
        /// <summary>
        /// A string identifier for the display category.
        /// </summary>
        /// <value>A string identifier for the display category.</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets DisplayProperties
        /// </summary>
        [DataMember(Name="displayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyDisplayCategoryDefinition {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyDisplayCategoryDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyDisplayCategoryDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyDisplayCategoryDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyDisplayCategoryDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DisplayProperties != null)
                    hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
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
