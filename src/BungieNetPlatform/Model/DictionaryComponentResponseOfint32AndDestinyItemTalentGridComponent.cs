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
    /// DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent
    /// </summary>
    [DataContract]
    public partial class DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent :  IEquatable<DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Privacy">Privacy.</param>
        public DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent(Dictionary<string, DestinyEntitiesItemsDestinyItemTalentGridComponent> Data = default(Dictionary<string, DestinyEntitiesItemsDestinyItemTalentGridComponent>), ComponentsComponentPrivacySetting Privacy = default(ComponentsComponentPrivacySetting))
        {
            this.Data = Data;
            this.Privacy = Privacy;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, DestinyEntitiesItemsDestinyItemTalentGridComponent> Data { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name="privacy", EmitDefaultValue=false)]
        public ComponentsComponentPrivacySetting Privacy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
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
            return this.Equals(input as DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent);
        }

        /// <summary>
        /// Returns true if DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    (this.Privacy != null &&
                    this.Privacy.Equals(input.Privacy))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Privacy != null)
                    hashCode = hashCode * 59 + this.Privacy.GetHashCode();
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
