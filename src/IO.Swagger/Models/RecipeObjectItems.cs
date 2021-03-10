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
    public partial class RecipeObjectItems : IEquatable<RecipeObjectItems>
    { 
        /// <summary>
        /// Unique recipe ID
        /// </summary>
        /// <value>Unique recipe ID</value>
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Recipe title
        /// </summary>
        /// <value>Recipe title</value>
        [DataMember(Name="title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta")]
        public RecipeObjectMeta Meta { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// The author of this recipe. You must attribute this author when displaying this recipe.
        /// </summary>
        /// <value>The author of this recipe. You must attribute this author when displaying this recipe.</value>
        [DataMember(Name="author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or Sets Topics
        /// </summary>
        [DataMember(Name="topics")]
        public List<string> Topics { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes")]
        public RecipeObjectAttributes Attributes { get; set; }

        /// <summary>
        /// An array containing this recipe&#x27;s ingredients
        /// </summary>
        /// <value>An array containing this recipe&#x27;s ingredients</value>
        [DataMember(Name="ingredients")]
        public List<RecipeObjectIngredients> Ingredients { get; set; }

        /// <summary>
        /// Gets or Sets BaseIngredients
        /// </summary>
        [DataMember(Name="base_ingredients")]
        public List<string> BaseIngredients { get; set; }

        /// <summary>
        /// Gets or Sets Nutrients
        /// </summary>
        [DataMember(Name="nutrients")]
        public RecipeObjectNutrients Nutrients { get; set; }

        /// <summary>
        /// Gets or Sets DiabeticExchanges
        /// </summary>
        [DataMember(Name="diabetic_exchanges")]
        public List<string> DiabeticExchanges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipeObjectItems {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Ingredients: ").Append(Ingredients).Append("\n");
            sb.Append("  BaseIngredients: ").Append(BaseIngredients).Append("\n");
            sb.Append("  Nutrients: ").Append(Nutrients).Append("\n");
            sb.Append("  DiabeticExchanges: ").Append(DiabeticExchanges).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RecipeObjectItems)obj);
        }

        /// <summary>
        /// Returns true if RecipeObjectItems instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipeObjectItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipeObjectItems other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    Meta == other.Meta ||
                    Meta != null &&
                    Meta.Equals(other.Meta)
                ) && 
                (
                    Categories == other.Categories ||
                    Categories != null &&
                    Categories.SequenceEqual(other.Categories)
                ) && 
                (
                    Author == other.Author ||
                    Author != null &&
                    Author.Equals(other.Author)
                ) && 
                (
                    Keywords == other.Keywords ||
                    Keywords != null &&
                    Keywords.SequenceEqual(other.Keywords)
                ) && 
                (
                    Topics == other.Topics ||
                    Topics != null &&
                    Topics.SequenceEqual(other.Topics)
                ) && 
                (
                    Attributes == other.Attributes ||
                    Attributes != null &&
                    Attributes.Equals(other.Attributes)
                ) && 
                (
                    Ingredients == other.Ingredients ||
                    Ingredients != null &&
                    Ingredients.SequenceEqual(other.Ingredients)
                ) && 
                (
                    BaseIngredients == other.BaseIngredients ||
                    BaseIngredients != null &&
                    BaseIngredients.SequenceEqual(other.BaseIngredients)
                ) && 
                (
                    Nutrients == other.Nutrients ||
                    Nutrients != null &&
                    Nutrients.Equals(other.Nutrients)
                ) && 
                (
                    DiabeticExchanges == other.DiabeticExchanges ||
                    DiabeticExchanges != null &&
                    DiabeticExchanges.SequenceEqual(other.DiabeticExchanges)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (Meta != null)
                    hashCode = hashCode * 59 + Meta.GetHashCode();
                    if (Categories != null)
                    hashCode = hashCode * 59 + Categories.GetHashCode();
                    if (Author != null)
                    hashCode = hashCode * 59 + Author.GetHashCode();
                    if (Keywords != null)
                    hashCode = hashCode * 59 + Keywords.GetHashCode();
                    if (Topics != null)
                    hashCode = hashCode * 59 + Topics.GetHashCode();
                    if (Attributes != null)
                    hashCode = hashCode * 59 + Attributes.GetHashCode();
                    if (Ingredients != null)
                    hashCode = hashCode * 59 + Ingredients.GetHashCode();
                    if (BaseIngredients != null)
                    hashCode = hashCode * 59 + BaseIngredients.GetHashCode();
                    if (Nutrients != null)
                    hashCode = hashCode * 59 + Nutrients.GetHashCode();
                    if (DiabeticExchanges != null)
                    hashCode = hashCode * 59 + DiabeticExchanges.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RecipeObjectItems left, RecipeObjectItems right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RecipeObjectItems left, RecipeObjectItems right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}