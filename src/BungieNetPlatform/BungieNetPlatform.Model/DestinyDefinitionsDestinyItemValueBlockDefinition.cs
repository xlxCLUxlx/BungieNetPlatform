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
    /// This defines an item&#39;s \&quot;Value\&quot;. Unfortunately, this appears to be used in different ways depending on the way that the item itself is used.  For items being sold at a Vendor, this is the default \&quot;sale price\&quot; of the item. These days, the vendor itself almost always sets the price, but it still possible for the price to fall back to this value. For quests, it is a preview of rewards you can gain by completing the quest. For dummy items, if the itemValue refers to an Emblem, it is the emblem that should be shown as the reward. (jeez louise)  It will likely be used in a number of other ways in the future, it appears to be a bucket where they put arbitrary items and quantities into the item.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyItemValueBlockDefinition :  IEquatable<DestinyDefinitionsDestinyItemValueBlockDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyItemValueBlockDefinition" /> class.
        /// </summary>
        /// <param name="ItemValue">References to the items that make up this item&#39;s \&quot;value\&quot;, and the quantity..</param>
        /// <param name="ValueDescription">If there&#39;s a localized text description of the value provided, this will be said description..</param>
        public DestinyDefinitionsDestinyItemValueBlockDefinition(List<DestinyDestinyItemQuantity> ItemValue = default(List<DestinyDestinyItemQuantity>), string ValueDescription = default(string))
        {
            this.ItemValue = ItemValue;
            this.ValueDescription = ValueDescription;
        }
        
        /// <summary>
        /// References to the items that make up this item&#39;s \&quot;value\&quot;, and the quantity.
        /// </summary>
        /// <value>References to the items that make up this item&#39;s \&quot;value\&quot;, and the quantity.</value>
        [DataMember(Name="itemValue", EmitDefaultValue=false)]
        public List<DestinyDestinyItemQuantity> ItemValue { get; set; }

        /// <summary>
        /// If there&#39;s a localized text description of the value provided, this will be said description.
        /// </summary>
        /// <value>If there&#39;s a localized text description of the value provided, this will be said description.</value>
        [DataMember(Name="valueDescription", EmitDefaultValue=false)]
        public string ValueDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyItemValueBlockDefinition {\n");
            sb.Append("  ItemValue: ").Append(ItemValue).Append("\n");
            sb.Append("  ValueDescription: ").Append(ValueDescription).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyItemValueBlockDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyItemValueBlockDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyItemValueBlockDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyItemValueBlockDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemValue == input.ItemValue ||
                    this.ItemValue != null &&
                    this.ItemValue.SequenceEqual(input.ItemValue)
                ) && 
                (
                    this.ValueDescription == input.ValueDescription ||
                    (this.ValueDescription != null &&
                    this.ValueDescription.Equals(input.ValueDescription))
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
                if (this.ItemValue != null)
                    hashCode = hashCode * 59 + this.ItemValue.GetHashCode();
                if (this.ValueDescription != null)
                    hashCode = hashCode * 59 + this.ValueDescription.GetHashCode();
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
