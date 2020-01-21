/*
 * Chomp Food Database API Documentation
 *
 * __Important:__   - An __[API key](https://chompthis.com/api/)__ is required for access to this API.   - Get yours at __[https://chompthis.com/api](https://chompthis.com/api/)__.  - -- --  __Getting Started:__   - __[Subscribe](https://chompthis.com/api/#pricing)__ to the API.   - Scroll down and click the \"__Authorize__\" button.   - Enter your API key into the \"__value__\" input, click the \"__Authorize__\" button, then click the \"__Close__\" button.   - Scroll down to the section titled \"__default__\" and click on the API endpoint you wish to use.   - Click the \"__Try it out__\" button.   - Enter the information the endpoint requires.   - Click the \"__Execute__\" button.  __Example:__    - Branded Food: __[View example](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)__ API response object.   - Ingredient: __[View example](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)__ API response object.  - -- --  __How Do I Find My API Key?__   - Your API key was sent to the email address you used to create your subscription.   - You will also find your API key in the __[Client Center](https://chompthis.com/api/manage.php)__.   - _Read __[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)__ for more information._  ||| | - -- -- -- | - -- -- -- - | | [Knowledge Base](https://desk.zoho.com/portal/chompthis/kb/chomp) | [Pricing](https://chompthis.com/api/) | | [Attribution](https://chompthis.com/api/docs/attribution.php) | [Cost Calculator](https://chompthis.com/api/cost-calculator.php) | | [Terms & License](https://chompthis.com/api/terms.php) | [Database Search](https://chompthis.com/api/lookup.php) | | [Support](https://chompthis.com/api/ticket-new.php) | [Query Builder](https://chompthis.com/api/build.php) | | [Client Center](https://chompthis.com/api/manage.php) | | 
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
    /// An object containing photos of the ingredients on this item&#x27;s packaging
    /// </summary>
    [DataContract]
    public partial class BrandedFoodObjectPackagingPhotosIngredients : IEquatable<BrandedFoodObjectPackagingPhotosIngredients>
    { 
        /// <summary>
        /// Small photo of the ingredients on this item&#x27;s packaging
        /// </summary>
        /// <value>Small photo of the ingredients on this item&#x27;s packaging</value>
        [DataMember(Name="small")]
        public string Small { get; set; }

        /// <summary>
        /// Thumbnail photo of the ingredients on this item&#x27;s packaging
        /// </summary>
        /// <value>Thumbnail photo of the ingredients on this item&#x27;s packaging</value>
        [DataMember(Name="thumb")]
        public string Thumb { get; set; }

        /// <summary>
        /// Full-sized photo of the ingredients on this item&#x27;s packaging
        /// </summary>
        /// <value>Full-sized photo of the ingredients on this item&#x27;s packaging</value>
        [DataMember(Name="display")]
        public string Display { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectPackagingPhotosIngredients {\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
            sb.Append("  Thumb: ").Append(Thumb).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BrandedFoodObjectPackagingPhotosIngredients)obj);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectPackagingPhotosIngredients instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandedFoodObjectPackagingPhotosIngredients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectPackagingPhotosIngredients other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Small == other.Small ||
                    Small != null &&
                    Small.Equals(other.Small)
                ) && 
                (
                    Thumb == other.Thumb ||
                    Thumb != null &&
                    Thumb.Equals(other.Thumb)
                ) && 
                (
                    Display == other.Display ||
                    Display != null &&
                    Display.Equals(other.Display)
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
                    if (Small != null)
                    hashCode = hashCode * 59 + Small.GetHashCode();
                    if (Thumb != null)
                    hashCode = hashCode * 59 + Thumb.GetHashCode();
                    if (Display != null)
                    hashCode = hashCode * 59 + Display.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BrandedFoodObjectPackagingPhotosIngredients left, BrandedFoodObjectPackagingPhotosIngredients right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BrandedFoodObjectPackagingPhotosIngredients left, BrandedFoodObjectPackagingPhotosIngredients right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
