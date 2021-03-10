/*
 * Chomp Food & Recipe Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. * Get a **Food Data API** key at **[https://chompthis.com/api](https://chompthis.com/api/)**. * Get a **Recipe Data API** key at **[https://chompthis.com/api/recipes](https://chompthis.com/api/recipes/)**.  ### Getting Started   * Subscribe to the **[Food Data API](https://chompthis.com/api/#pricing)** or the **[Recipe Data API](https://chompthis.com/api/recipes/#pricing)**.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**   * Recipe response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/example-recipe-response.json)**   * Error response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/error-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ### I'm a Premium subscriber. How do I access the API?   * All Premium subscribers must pass in a unique user ID for each user on their platform that is accessing data from the Chomp API. A user ID can be any string of letters and numbers that you assign to your user. Simply add \"user_id\" as a URL parameter when calling the API. *You must add a \"user_id\" URL parameter to every call you make to ANY endpoint.*     * **Example**        > ```ENDPOINT.php?api_key=API_KEY&code=CODE&user_id=USER_ID```  ### Helpful Links   * **Help & Support**     * [Knowledge Base &raquo;](https://desk.zoho.com/portal/chompthis/kb/chomp)     * [Support &raquo;](https://chompthis.com/api/ticket-new.php)     * [Client Center &raquo;](https://chompthis.com/api/manage.php)   * **Pricing**     * [Food Data API Subscription Options &raquo;](https://chompthis.com/api/)     * [Recipe Data API Subscription Options &raquo;](https://chompthis.com/api/recipes/)     * [Food Data API Cost Calculator &raquo;](https://chompthis.com/api/cost-calculator.php)     * [Recipe Data API Cost Calculator &raquo;](https://chompthis.com/api/recipes/cost-calculator.php)   * **Guidelines**     * [Terms & License &raquo;](https://chompthis.com/api/terms.php)     * [Attribution &raquo;](https://chompthis.com/api/docs/attribution.php) 
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
    /// An object containing nutrient information for this recipe
    /// </summary>
    [DataContract]
    public partial class RecipeObjectNutrients : IEquatable<RecipeObjectNutrients>
    { 
        /// <summary>
        /// An array containing information for calories found in this recipe
        /// </summary>
        /// <value>An array containing information for calories found in this recipe</value>
        [DataMember(Name="calories")]
        public List<RecipeObjectNutrientsCalories> Calories { get; set; }

        /// <summary>
        /// An array containing information for this recipe&#x27;s daily recommended value of certain nutrients
        /// </summary>
        /// <value>An array containing information for this recipe&#x27;s daily recommended value of certain nutrients</value>
        [DataMember(Name="daily_values")]
        public List<RecipeObjectNutrientsCalories> DailyValues { get; set; }

        /// <summary>
        /// An array containing information for fat found in this recipe
        /// </summary>
        /// <value>An array containing information for fat found in this recipe</value>
        [DataMember(Name="fat")]
        public List<RecipeObjectNutrientsCalories> Fat { get; set; }

        /// <summary>
        /// An array containing information for carbs found in this recipe
        /// </summary>
        /// <value>An array containing information for carbs found in this recipe</value>
        [DataMember(Name="carbs")]
        public List<RecipeObjectNutrientsCalories> Carbs { get; set; }

        /// <summary>
        /// An array containing information for vitamins found in this recipe
        /// </summary>
        /// <value>An array containing information for vitamins found in this recipe</value>
        [DataMember(Name="vitamins")]
        public List<RecipeObjectNutrientsCalories> Vitamins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipeObjectNutrients {\n");
            sb.Append("  Calories: ").Append(Calories).Append("\n");
            sb.Append("  DailyValues: ").Append(DailyValues).Append("\n");
            sb.Append("  Fat: ").Append(Fat).Append("\n");
            sb.Append("  Carbs: ").Append(Carbs).Append("\n");
            sb.Append("  Vitamins: ").Append(Vitamins).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RecipeObjectNutrients)obj);
        }

        /// <summary>
        /// Returns true if RecipeObjectNutrients instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipeObjectNutrients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipeObjectNutrients other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Calories == other.Calories ||
                    Calories != null &&
                    Calories.SequenceEqual(other.Calories)
                ) && 
                (
                    DailyValues == other.DailyValues ||
                    DailyValues != null &&
                    DailyValues.SequenceEqual(other.DailyValues)
                ) && 
                (
                    Fat == other.Fat ||
                    Fat != null &&
                    Fat.SequenceEqual(other.Fat)
                ) && 
                (
                    Carbs == other.Carbs ||
                    Carbs != null &&
                    Carbs.SequenceEqual(other.Carbs)
                ) && 
                (
                    Vitamins == other.Vitamins ||
                    Vitamins != null &&
                    Vitamins.SequenceEqual(other.Vitamins)
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
                    if (Calories != null)
                    hashCode = hashCode * 59 + Calories.GetHashCode();
                    if (DailyValues != null)
                    hashCode = hashCode * 59 + DailyValues.GetHashCode();
                    if (Fat != null)
                    hashCode = hashCode * 59 + Fat.GetHashCode();
                    if (Carbs != null)
                    hashCode = hashCode * 59 + Carbs.GetHashCode();
                    if (Vitamins != null)
                    hashCode = hashCode * 59 + Vitamins.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RecipeObjectNutrients left, RecipeObjectNutrients right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RecipeObjectNutrients left, RecipeObjectNutrients right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
