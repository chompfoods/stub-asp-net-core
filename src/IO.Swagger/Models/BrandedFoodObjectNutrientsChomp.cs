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
    /// 
    /// </summary>
    [DataContract]
    public partial class BrandedFoodObjectNutrientsChomp : IEquatable<BrandedFoodObjectNutrientsChomp>
    { 
        /// <summary>
        /// Nutrient name
        /// </summary>
        /// <value>Nutrient name</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The unit used for measure (e.g. if mesure is 3 tsp, the unit is tsp)
        /// </summary>
        /// <value>The unit used for measure (e.g. if mesure is 3 tsp, the unit is tsp)</value>
        [DataMember(Name="measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// Amount of the nutrient per 100g of food
        /// </summary>
        /// <value>Amount of the nutrient per 100g of food</value>
        [DataMember(Name="per_100g")]
        public decimal? Per100g { get; set; }

        /// <summary>
        /// Nutrient value per serving
        /// </summary>
        /// <value>Nutrient value per serving</value>
        [DataMember(Name="per_serving")]
        public decimal? PerServing { get; set; }

        /// <summary>
        /// Total nutrient value
        /// </summary>
        /// <value>Total nutrient value</value>
        [DataMember(Name="total")]
        public decimal? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectNutrientsChomp {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MeasurementUnit: ").Append(MeasurementUnit).Append("\n");
            sb.Append("  Per100g: ").Append(Per100g).Append("\n");
            sb.Append("  PerServing: ").Append(PerServing).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BrandedFoodObjectNutrientsChomp)obj);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectNutrientsChomp instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandedFoodObjectNutrientsChomp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectNutrientsChomp other)
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
                    MeasurementUnit == other.MeasurementUnit ||
                    MeasurementUnit != null &&
                    MeasurementUnit.Equals(other.MeasurementUnit)
                ) && 
                (
                    Per100g == other.Per100g ||
                    Per100g != null &&
                    Per100g.Equals(other.Per100g)
                ) && 
                (
                    PerServing == other.PerServing ||
                    PerServing != null &&
                    PerServing.Equals(other.PerServing)
                ) && 
                (
                    Total == other.Total ||
                    Total != null &&
                    Total.Equals(other.Total)
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
                    if (MeasurementUnit != null)
                    hashCode = hashCode * 59 + MeasurementUnit.GetHashCode();
                    if (Per100g != null)
                    hashCode = hashCode * 59 + Per100g.GetHashCode();
                    if (PerServing != null)
                    hashCode = hashCode * 59 + PerServing.GetHashCode();
                    if (Total != null)
                    hashCode = hashCode * 59 + Total.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BrandedFoodObjectNutrientsChomp left, BrandedFoodObjectNutrientsChomp right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BrandedFoodObjectNutrientsChomp left, BrandedFoodObjectNutrientsChomp right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
