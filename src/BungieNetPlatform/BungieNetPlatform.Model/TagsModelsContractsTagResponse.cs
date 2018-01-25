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
    /// TagsModelsContractsTagResponse
    /// </summary>
    [DataContract]
    public partial class TagsModelsContractsTagResponse :  IEquatable<TagsModelsContractsTagResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagsModelsContractsTagResponse" /> class.
        /// </summary>
        /// <param name="TagText">TagText.</param>
        /// <param name="IgnoreStatus">IgnoreStatus.</param>
        public TagsModelsContractsTagResponse(string TagText = default(string), IgnoresIgnoreResponse IgnoreStatus = default(IgnoresIgnoreResponse))
        {
            this.TagText = TagText;
            this.IgnoreStatus = IgnoreStatus;
        }
        
        /// <summary>
        /// Gets or Sets TagText
        /// </summary>
        [DataMember(Name="tagText", EmitDefaultValue=false)]
        public string TagText { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreStatus
        /// </summary>
        [DataMember(Name="ignoreStatus", EmitDefaultValue=false)]
        public IgnoresIgnoreResponse IgnoreStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagsModelsContractsTagResponse {\n");
            sb.Append("  TagText: ").Append(TagText).Append("\n");
            sb.Append("  IgnoreStatus: ").Append(IgnoreStatus).Append("\n");
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
            return this.Equals(input as TagsModelsContractsTagResponse);
        }

        /// <summary>
        /// Returns true if TagsModelsContractsTagResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TagsModelsContractsTagResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagsModelsContractsTagResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TagText == input.TagText ||
                    (this.TagText != null &&
                    this.TagText.Equals(input.TagText))
                ) && 
                (
                    this.IgnoreStatus == input.IgnoreStatus ||
                    (this.IgnoreStatus != null &&
                    this.IgnoreStatus.Equals(input.IgnoreStatus))
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
                if (this.TagText != null)
                    hashCode = hashCode * 59 + this.TagText.GetHashCode();
                if (this.IgnoreStatus != null)
                    hashCode = hashCode * 59 + this.IgnoreStatus.GetHashCode();
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
