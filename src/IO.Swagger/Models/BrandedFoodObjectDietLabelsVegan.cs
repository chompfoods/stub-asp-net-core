/*
 * Chomp Food Database API Documentation
 *
 * __Important:__   - An __[API key](https://chompthis.com/api/)__ is required for access to this API.   - Get yours at __[https://chompthis.com/api](https://chompthis.com/api/)__.  - -- --  __Getting Started:__   - __[Subscribe](https://chompthis.com/api/#pricing)__ to the API.   - Scroll down and click the \"__Authorize__\" button.   - Enter your API key into the \"__value__\" input, click the \"__Authorize__\" button, then click the \"__Close__\" button.   - Scroll down to the section titled \"__default__\" and click on the API endpoint you wish to use.   - Click the \"__Try it out__\" button.   - Enter the information the endpoint requires.   - Click the \"__Execute__\" button.  __Example:__    - __[View example](https://raw.githubusercontent.com/chompfoods/examples/master/response-object.json)__ API response object.  - -- --  __How Do I Find My API Key?__   - Your API key was sent to the email address you used to create your subscription.   - You will also find your API key in the __[Client Center](https://chompthis.com/api/manage.php)__.   - _Read __[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)__ for more information._  ||| | - -- -- -- | - -- -- -- - | | [Knowledge Base](https://desk.zoho.com/portal/chompthis/kb/chomp) | [Pricing](https://chompthis.com/api/) | | [Attribution](https://chompthis.com/api/docs/attribution.php) | [Cost Calculator](https://chompthis.com/api/cost-calculator.php) | | [Terms & License](https://chompthis.com/api/terms.php) | [Database Search](https://chompthis.com/api/lookup.php) | | [Support](https://chompthis.com/api/ticket-new.php) | [Query Builder](https://chompthis.com/api/build.php) | | [Client Center](https://chompthis.com/api/manage.php) | | 
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// An object containing information on this item&#x27;s compatibility with the Vegan diets
    /// </summary>
    [DataContract]
    public partial class BrandedFoodObjectDietLabelsVegan : IEquatable<BrandedFoodObjectDietLabelsVegan>
    { 
        /// <summary>
        /// Diet name
        /// </summary>
        /// <value>Diet name</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Boolean describing if this item is compatible with this diet
        /// </summary>
        /// <value>Boolean describing if this item is compatible with this diet</value>
        [DataMember(Name="is_compatible")]
        public bool? IsCompatible { get; set; }

        /// <summary>
        /// Numeric representation of how compatible this item is with this diet. Higher values indicate more compatibility
        /// </summary>
        /// <value>Numeric representation of how compatible this item is with this diet. Higher values indicate more compatibility</value>
        [DataMember(Name="compatibility_level")]
        public int? CompatibilityLevel { get; set; }

        /// <summary>
        /// Boolean that indicates if we are confident in how this item is graded for this diet
        /// </summary>
        /// <value>Boolean that indicates if we are confident in how this item is graded for this diet</value>
        [DataMember(Name="confidence")]
        public int? Confidence { get; set; }

        /// <summary>
        /// Description of our confidence that this item was graded correctly
        /// </summary>
        /// <value>Description of our confidence that this item was graded correctly</value>
        [DataMember(Name="confidence_description")]
        public string ConfidenceDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectDietLabelsVegan {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsCompatible: ").Append(IsCompatible).Append("\n");
            sb.Append("  CompatibilityLevel: ").Append(CompatibilityLevel).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  ConfidenceDescription: ").Append(ConfidenceDescription).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((BrandedFoodObjectDietLabelsVegan)obj);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectDietLabelsVegan instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandedFoodObjectDietLabelsVegan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectDietLabelsVegan other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    IsCompatible == other.IsCompatible ||
                    IsCompatible != null &&
                    IsCompatible.Equals(other.IsCompatible)
                ) && 
                (
                    CompatibilityLevel == other.CompatibilityLevel ||
                    CompatibilityLevel != null &&
                    CompatibilityLevel.Equals(other.CompatibilityLevel)
                ) && 
                (
                    Confidence == other.Confidence ||
                    Confidence != null &&
                    Confidence.Equals(other.Confidence)
                ) && 
                (
                    ConfidenceDescription == other.ConfidenceDescription ||
                    ConfidenceDescription != null &&
                    ConfidenceDescription.Equals(other.ConfidenceDescription)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (IsCompatible != null)
                    hashCode = hashCode * 59 + IsCompatible.GetHashCode();
                    if (CompatibilityLevel != null)
                    hashCode = hashCode * 59 + CompatibilityLevel.GetHashCode();
                    if (Confidence != null)
                    hashCode = hashCode * 59 + Confidence.GetHashCode();
                    if (ConfidenceDescription != null)
                    hashCode = hashCode * 59 + ConfidenceDescription.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BrandedFoodObjectDietLabelsVegan left, BrandedFoodObjectDietLabelsVegan right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BrandedFoodObjectDietLabelsVegan left, BrandedFoodObjectDietLabelsVegan right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
