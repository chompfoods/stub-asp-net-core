/*
 * Chomp Food Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. Get yours at **[https://chompthis.com/api](https://chompthis.com/api/)**.  ### Getting Started   * **[Subscribe](https://chompthis.com/api/#pricing)** to the API.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ||| | - -- -- -- | - -- -- -- - | | [Knowledge Base](https://desk.zoho.com/portal/chompthis/kb/chomp) | [Pricing](https://chompthis.com/api/) | | [Attribution](https://chompthis.com/api/docs/attribution.php) | [Cost Calculator](https://chompthis.com/api/cost-calculator.php) | | [Terms & License](https://chompthis.com/api/terms.php) | [Database Search](https://chompthis.com/api/lookup.php) | | [Support](https://chompthis.com/api/ticket-new.php) | [Query Builder](https://chompthis.com/api/build.php) | | [Client Center](https://chompthis.com/api/manage.php) | | 
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
    /// An object containing this item&#x27;s ingredients in order of highest value to least
    /// </summary>
    [DataContract]
    public partial class BrandedFoodObjectIngredients : IEquatable<BrandedFoodObjectIngredients>
    { 
        /// <summary>
        /// Ingredients for this item from Chomp&#x27;s internal database
        /// </summary>
        /// <value>Ingredients for this item from Chomp&#x27;s internal database</value>
        [DataMember(Name="chomp")]
        public string Chomp { get; set; }

        /// <summary>
        /// This branded food item&#x27;s ingredients, according to the USDA
        /// </summary>
        /// <value>This branded food item&#x27;s ingredients, according to the USDA</value>
        [DataMember(Name="usda")]
        public string Usda { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectIngredients {\n");
            sb.Append("  Chomp: ").Append(Chomp).Append("\n");
            sb.Append("  Usda: ").Append(Usda).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BrandedFoodObjectIngredients)obj);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectIngredients instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandedFoodObjectIngredients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectIngredients other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Chomp == other.Chomp ||
                    Chomp != null &&
                    Chomp.Equals(other.Chomp)
                ) && 
                (
                    Usda == other.Usda ||
                    Usda != null &&
                    Usda.Equals(other.Usda)
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
                    if (Chomp != null)
                    hashCode = hashCode * 59 + Chomp.GetHashCode();
                    if (Usda != null)
                    hashCode = hashCode * 59 + Usda.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BrandedFoodObjectIngredients left, BrandedFoodObjectIngredients right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BrandedFoodObjectIngredients left, BrandedFoodObjectIngredients right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
