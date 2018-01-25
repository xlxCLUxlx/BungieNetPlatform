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
    /// UserUserToUserContext
    /// </summary>
    [DataContract]
    public partial class UserUserToUserContext :  IEquatable<UserUserToUserContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUserToUserContext" /> class.
        /// </summary>
        /// <param name="IsFollowing">IsFollowing.</param>
        /// <param name="IgnoreStatus">IgnoreStatus.</param>
        /// <param name="GlobalIgnoreEndDate">GlobalIgnoreEndDate.</param>
        public UserUserToUserContext(bool? IsFollowing = default(bool?), IgnoresIgnoreResponse IgnoreStatus = default(IgnoresIgnoreResponse), DateTime? GlobalIgnoreEndDate = default(DateTime?))
        {
            this.IsFollowing = IsFollowing;
            this.IgnoreStatus = IgnoreStatus;
            this.GlobalIgnoreEndDate = GlobalIgnoreEndDate;
        }
        
        /// <summary>
        /// Gets or Sets IsFollowing
        /// </summary>
        [DataMember(Name="isFollowing", EmitDefaultValue=false)]
        public bool? IsFollowing { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreStatus
        /// </summary>
        [DataMember(Name="ignoreStatus", EmitDefaultValue=false)]
        public IgnoresIgnoreResponse IgnoreStatus { get; set; }

        /// <summary>
        /// Gets or Sets GlobalIgnoreEndDate
        /// </summary>
        [DataMember(Name="globalIgnoreEndDate", EmitDefaultValue=false)]
        public DateTime? GlobalIgnoreEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUserToUserContext {\n");
            sb.Append("  IsFollowing: ").Append(IsFollowing).Append("\n");
            sb.Append("  IgnoreStatus: ").Append(IgnoreStatus).Append("\n");
            sb.Append("  GlobalIgnoreEndDate: ").Append(GlobalIgnoreEndDate).Append("\n");
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
            return this.Equals(input as UserUserToUserContext);
        }

        /// <summary>
        /// Returns true if UserUserToUserContext instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUserToUserContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUserToUserContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsFollowing == input.IsFollowing ||
                    (this.IsFollowing != null &&
                    this.IsFollowing.Equals(input.IsFollowing))
                ) && 
                (
                    this.IgnoreStatus == input.IgnoreStatus ||
                    (this.IgnoreStatus != null &&
                    this.IgnoreStatus.Equals(input.IgnoreStatus))
                ) && 
                (
                    this.GlobalIgnoreEndDate == input.GlobalIgnoreEndDate ||
                    (this.GlobalIgnoreEndDate != null &&
                    this.GlobalIgnoreEndDate.Equals(input.GlobalIgnoreEndDate))
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
                if (this.IsFollowing != null)
                    hashCode = hashCode * 59 + this.IsFollowing.GetHashCode();
                if (this.IgnoreStatus != null)
                    hashCode = hashCode * 59 + this.IgnoreStatus.GetHashCode();
                if (this.GlobalIgnoreEndDate != null)
                    hashCode = hashCode * 59 + this.GlobalIgnoreEndDate.GetHashCode();
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
