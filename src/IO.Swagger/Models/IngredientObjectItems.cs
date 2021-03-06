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
    /// An object containing information for this specific item.
    /// </summary>
    [DataContract]
    public partial class IngredientObjectItems : IEquatable<IngredientObjectItems>
    { 
        /// <summary>
        /// Item name as provided by brand owner or as shown on packaging
        /// </summary>
        /// <value>Item name as provided by brand owner or as shown on packaging</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// An array containing nutrient informatio objects for this food item
        /// </summary>
        /// <value>An array containing nutrient informatio objects for this food item</value>
        [DataMember(Name="nutrients")]
        public List<IngredientObjectNutrients> Nutrients { get; set; }

        /// <summary>
        /// Gets or Sets CalorieConversionFactor
        /// </summary>
        [DataMember(Name="calorie_conversion_factor")]
        public IngredientObjectCalorieConversionFactor CalorieConversionFactor { get; set; }

        /// <summary>
        /// The multiplication factor used to calculate protein from nitrogen
        /// </summary>
        /// <value>The multiplication factor used to calculate protein from nitrogen</value>
        [DataMember(Name="protein_conversion_factor")]
        public decimal? ProteinConversionFactor { get; set; }

        /// <summary>
        /// An array of objects containing the constituent parts of a food (e.g. bone is a component of meat)
        /// </summary>
        /// <value>An array of objects containing the constituent parts of a food (e.g. bone is a component of meat)</value>
        [DataMember(Name="components")]
        public List<IngredientObjectComponents> Components { get; set; }

        /// <summary>
        /// An array of objects containing information on discrete amounts of a food found in this item
        /// </summary>
        /// <value>An array of objects containing information on discrete amounts of a food found in this item</value>
        [DataMember(Name="portions")]
        public List<IngredientObjectPortions> Portions { get; set; }

        /// <summary>
        /// Common name associated with this item. These generally clarify what the item is (e.g. when the brand name is \&quot;BRAND&#x27;s Spicy Enchilada\&quot; the common name may be \&quot;Chicken enchilada\&quot;)
        /// </summary>
        /// <value>Common name associated with this item. These generally clarify what the item is (e.g. when the brand name is \&quot;BRAND&#x27;s Spicy Enchilada\&quot; the common name may be \&quot;Chicken enchilada\&quot;)</value>
        [DataMember(Name="common_name")]
        public string CommonName { get; set; }

        /// <summary>
        /// Comments on any unusual aspects of this item. Examples might include unusual aspects of the food overall
        /// </summary>
        /// <value>Comments on any unusual aspects of this item. Examples might include unusual aspects of the food overall</value>
        [DataMember(Name="footnote")]
        public string Footnote { get; set; }

        /// <summary>
        /// The original search term that found this food item
        /// </summary>
        /// <value>The original search term that found this food item</value>
        [DataMember(Name="search_term")]
        public string SearchTerm { get; set; }

        /// <summary>
        /// A value that represents how similar the name of this food item is to the original search term. The lower the value the closer this item&#x27;s name is to the original search term.
        /// </summary>
        /// <value>A value that represents how similar the name of this food item is to the original search term. The lower the value the closer this item&#x27;s name is to the original search term.</value>
        [DataMember(Name="score")]
        public string Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IngredientObjectItems {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Nutrients: ").Append(Nutrients).Append("\n");
            sb.Append("  CalorieConversionFactor: ").Append(CalorieConversionFactor).Append("\n");
            sb.Append("  ProteinConversionFactor: ").Append(ProteinConversionFactor).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  Portions: ").Append(Portions).Append("\n");
            sb.Append("  CommonName: ").Append(CommonName).Append("\n");
            sb.Append("  Footnote: ").Append(Footnote).Append("\n");
            sb.Append("  SearchTerm: ").Append(SearchTerm).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IngredientObjectItems)obj);
        }

        /// <summary>
        /// Returns true if IngredientObjectItems instances are equal
        /// </summary>
        /// <param name="other">Instance of IngredientObjectItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IngredientObjectItems other)
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
                    Categories == other.Categories ||
                    Categories != null &&
                    Categories.SequenceEqual(other.Categories)
                ) && 
                (
                    Nutrients == other.Nutrients ||
                    Nutrients != null &&
                    Nutrients.SequenceEqual(other.Nutrients)
                ) && 
                (
                    CalorieConversionFactor == other.CalorieConversionFactor ||
                    CalorieConversionFactor != null &&
                    CalorieConversionFactor.Equals(other.CalorieConversionFactor)
                ) && 
                (
                    ProteinConversionFactor == other.ProteinConversionFactor ||
                    ProteinConversionFactor != null &&
                    ProteinConversionFactor.Equals(other.ProteinConversionFactor)
                ) && 
                (
                    Components == other.Components ||
                    Components != null &&
                    Components.SequenceEqual(other.Components)
                ) && 
                (
                    Portions == other.Portions ||
                    Portions != null &&
                    Portions.SequenceEqual(other.Portions)
                ) && 
                (
                    CommonName == other.CommonName ||
                    CommonName != null &&
                    CommonName.Equals(other.CommonName)
                ) && 
                (
                    Footnote == other.Footnote ||
                    Footnote != null &&
                    Footnote.Equals(other.Footnote)
                ) && 
                (
                    SearchTerm == other.SearchTerm ||
                    SearchTerm != null &&
                    SearchTerm.Equals(other.SearchTerm)
                ) && 
                (
                    Score == other.Score ||
                    Score != null &&
                    Score.Equals(other.Score)
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
                    if (Categories != null)
                    hashCode = hashCode * 59 + Categories.GetHashCode();
                    if (Nutrients != null)
                    hashCode = hashCode * 59 + Nutrients.GetHashCode();
                    if (CalorieConversionFactor != null)
                    hashCode = hashCode * 59 + CalorieConversionFactor.GetHashCode();
                    if (ProteinConversionFactor != null)
                    hashCode = hashCode * 59 + ProteinConversionFactor.GetHashCode();
                    if (Components != null)
                    hashCode = hashCode * 59 + Components.GetHashCode();
                    if (Portions != null)
                    hashCode = hashCode * 59 + Portions.GetHashCode();
                    if (CommonName != null)
                    hashCode = hashCode * 59 + CommonName.GetHashCode();
                    if (Footnote != null)
                    hashCode = hashCode * 59 + Footnote.GetHashCode();
                    if (SearchTerm != null)
                    hashCode = hashCode * 59 + SearchTerm.GetHashCode();
                    if (Score != null)
                    hashCode = hashCode * 59 + Score.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IngredientObjectItems left, IngredientObjectItems right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IngredientObjectItems left, IngredientObjectItems right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
