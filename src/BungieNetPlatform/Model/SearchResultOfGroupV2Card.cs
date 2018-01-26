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
    /// SearchResultOfGroupV2Card
    /// </summary>
    [DataContract]
    public partial class SearchResultOfGroupV2Card :  IEquatable<SearchResultOfGroupV2Card>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOfGroupV2Card" /> class.
        /// </summary>
        /// <param name="Results">Results.</param>
        /// <param name="TotalResults">TotalResults.</param>
        /// <param name="HasMore">HasMore.</param>
        /// <param name="Query">Query.</param>
        /// <param name="ReplacementContinuationToken">ReplacementContinuationToken.</param>
        /// <param name="UseTotalResults">If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one..</param>
        public SearchResultOfGroupV2Card(List<GroupsV2GroupV2Card> Results = default(List<GroupsV2GroupV2Card>), int? TotalResults = default(int?), bool? HasMore = default(bool?), QueriesPagedQuery Query = default(QueriesPagedQuery), string ReplacementContinuationToken = default(string), bool? UseTotalResults = default(bool?))
        {
            this.Results = Results;
            this.TotalResults = TotalResults;
            this.HasMore = HasMore;
            this.Query = Query;
            this.ReplacementContinuationToken = ReplacementContinuationToken;
            this.UseTotalResults = UseTotalResults;
        }
        
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<GroupsV2GroupV2Card> Results { get; set; }

        /// <summary>
        /// Gets or Sets TotalResults
        /// </summary>
        [DataMember(Name="totalResults", EmitDefaultValue=false)]
        public int? TotalResults { get; set; }

        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name="hasMore", EmitDefaultValue=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public QueriesPagedQuery Query { get; set; }

        /// <summary>
        /// Gets or Sets ReplacementContinuationToken
        /// </summary>
        [DataMember(Name="replacementContinuationToken", EmitDefaultValue=false)]
        public string ReplacementContinuationToken { get; set; }

        /// <summary>
        /// If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.
        /// </summary>
        /// <value>If useTotalResults is true, then totalResults represents an accurate count.  If False, it does not, and may be estimated/only the size of the current page.  Either way, you should probably always only trust hasMore.  This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.</value>
        [DataMember(Name="useTotalResults", EmitDefaultValue=false)]
        public bool? UseTotalResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResultOfGroupV2Card {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  ReplacementContinuationToken: ").Append(ReplacementContinuationToken).Append("\n");
            sb.Append("  UseTotalResults: ").Append(UseTotalResults).Append("\n");
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
            return this.Equals(input as SearchResultOfGroupV2Card);
        }

        /// <summary>
        /// Returns true if SearchResultOfGroupV2Card instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchResultOfGroupV2Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultOfGroupV2Card input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.TotalResults == input.TotalResults ||
                    (this.TotalResults != null &&
                    this.TotalResults.Equals(input.TotalResults))
                ) && 
                (
                    this.HasMore == input.HasMore ||
                    (this.HasMore != null &&
                    this.HasMore.Equals(input.HasMore))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.ReplacementContinuationToken == input.ReplacementContinuationToken ||
                    (this.ReplacementContinuationToken != null &&
                    this.ReplacementContinuationToken.Equals(input.ReplacementContinuationToken))
                ) && 
                (
                    this.UseTotalResults == input.UseTotalResults ||
                    (this.UseTotalResults != null &&
                    this.UseTotalResults.Equals(input.UseTotalResults))
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
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.TotalResults != null)
                    hashCode = hashCode * 59 + this.TotalResults.GetHashCode();
                if (this.HasMore != null)
                    hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.ReplacementContinuationToken != null)
                    hashCode = hashCode * 59 + this.ReplacementContinuationToken.GetHashCode();
                if (this.UseTotalResults != null)
                    hashCode = hashCode * 59 + this.UseTotalResults.GetHashCode();
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
