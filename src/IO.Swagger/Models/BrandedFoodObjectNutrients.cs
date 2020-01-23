/*
 * Chomp Food Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. Get yours at **[https://chompthis.com/api](https://chompthis.com/api/)**.  ### Getting Started   * **[Subscribe](https://chompthis.com/api/#pricing)** to the API.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ### Helpful Links   * **Help & Support**     * [Knowledge Base &raquo;](https://desk.zoho.com/portal/chompthis/kb/chomp)     * [Support &raquo;](https://chompthis.com/api/ticket-new.php)     * [Client Center &raquo;](https://chompthis.com/api/manage.php)   * **Pricing**     * [Subscription Options &raquo;](https://chompthis.com/api/)     * [Cost Calculator &raquo;](https://chompthis.com/api/cost-calculator.php)   * **Guidelines**     * [Terms & License &raquo;](https://chompthis.com/api/terms.php)     * [Attribution &raquo;](https://chompthis.com/api/docs/attribution.php) 
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
    /// An object containing information for a specific nutrient found in this food item
    /// </summary>
    [DataContract]
    public partial class BrandedFoodObjectNutrients : IEquatable<BrandedFoodObjectNutrients>
    { 
        /// <summary>
        /// Nutrient name
        /// </summary>
        /// <value>Nutrient name</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Amount of the nutrient per 100g of food
        /// </summary>
        /// <value>Amount of the nutrient per 100g of food</value>
        [DataMember(Name="per_100g")]
        public decimal? Per100g { get; set; }

        /// <summary>
        /// The unit used for the measure of this nutrient
        /// </summary>
        /// <value>The unit used for the measure of this nutrient</value>
        [DataMember(Name="measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// Nutrient rank
        /// </summary>
        /// <value>Nutrient rank</value>
        [DataMember(Name="rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// Number of observations on which the value is based
        /// </summary>
        /// <value>Number of observations on which the value is based</value>
        [DataMember(Name="data_points")]
        public int? DataPoints { get; set; }

        /// <summary>
        /// Description of the nutrient source
        /// </summary>
        /// <value>Description of the nutrient source</value>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectNutrients {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Per100g: ").Append(Per100g).Append("\n");
            sb.Append("  MeasurementUnit: ").Append(MeasurementUnit).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  DataPoints: ").Append(DataPoints).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BrandedFoodObjectNutrients)obj);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectNutrients instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandedFoodObjectNutrients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectNutrients other)
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
                    Per100g == other.Per100g ||
                    Per100g != null &&
                    Per100g.Equals(other.Per100g)
                ) && 
                (
                    MeasurementUnit == other.MeasurementUnit ||
                    MeasurementUnit != null &&
                    MeasurementUnit.Equals(other.MeasurementUnit)
                ) && 
                (
                    Rank == other.Rank ||
                    Rank != null &&
                    Rank.Equals(other.Rank)
                ) && 
                (
                    DataPoints == other.DataPoints ||
                    DataPoints != null &&
                    DataPoints.Equals(other.DataPoints)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    if (Per100g != null)
                    hashCode = hashCode * 59 + Per100g.GetHashCode();
                    if (MeasurementUnit != null)
                    hashCode = hashCode * 59 + MeasurementUnit.GetHashCode();
                    if (Rank != null)
                    hashCode = hashCode * 59 + Rank.GetHashCode();
                    if (DataPoints != null)
                    hashCode = hashCode * 59 + DataPoints.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BrandedFoodObjectNutrients left, BrandedFoodObjectNutrients right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BrandedFoodObjectNutrients left, BrandedFoodObjectNutrients right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
