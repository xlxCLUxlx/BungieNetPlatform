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
    /// QueriesPagedQuery
    /// </summary>
    [DataContract]
    public partial class QueriesPagedQuery :  IEquatable<QueriesPagedQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueriesPagedQuery" /> class.
        /// </summary>
        /// <param name="ItemsPerPage">ItemsPerPage.</param>
        /// <param name="CurrentPage">CurrentPage.</param>
        /// <param name="RequestContinuationToken">RequestContinuationToken.</param>
        public QueriesPagedQuery(int? ItemsPerPage = default(int?), int? CurrentPage = default(int?), string RequestContinuationToken = default(string))
        {
            this.ItemsPerPage = ItemsPerPage;
            this.CurrentPage = CurrentPage;
            this.RequestContinuationToken = RequestContinuationToken;
        }
        
        /// <summary>
        /// Gets or Sets ItemsPerPage
        /// </summary>
        [DataMember(Name="itemsPerPage", EmitDefaultValue=false)]
        public int? ItemsPerPage { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        [DataMember(Name="currentPage", EmitDefaultValue=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Gets or Sets RequestContinuationToken
        /// </summary>
        [DataMember(Name="requestContinuationToken", EmitDefaultValue=false)]
        public string RequestContinuationToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueriesPagedQuery {\n");
            sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  RequestContinuationToken: ").Append(RequestContinuationToken).Append("\n");
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
            return this.Equals(input as QueriesPagedQuery);
        }

        /// <summary>
        /// Returns true if QueriesPagedQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of QueriesPagedQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueriesPagedQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemsPerPage == input.ItemsPerPage ||
                    (this.ItemsPerPage != null &&
                    this.ItemsPerPage.Equals(input.ItemsPerPage))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
                ) && 
                (
                    this.RequestContinuationToken == input.RequestContinuationToken ||
                    (this.RequestContinuationToken != null &&
                    this.RequestContinuationToken.Equals(input.RequestContinuationToken))
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
                if (this.ItemsPerPage != null)
                    hashCode = hashCode * 59 + this.ItemsPerPage.GetHashCode();
                if (this.CurrentPage != null)
                    hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.RequestContinuationToken != null)
                    hashCode = hashCode * 59 + this.RequestContinuationToken.GetHashCode();
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
