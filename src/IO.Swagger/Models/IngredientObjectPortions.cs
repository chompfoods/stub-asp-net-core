/*
 * Chomp Food Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. Get yours at **[https://chompthis.com/api](https://chompthis.com/api/)**.  ### Getting Started   * **[Subscribe](https://chompthis.com/api/#pricing)** to the API.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**   * Error response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/error-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ### Helpful Links   * **Help & Support**     * [Knowledge Base &raquo;](https://desk.zoho.com/portal/chompthis/kb/chomp)     * [Support &raquo;](https://chompthis.com/api/ticket-new.php)     * [Client Center &raquo;](https://chompthis.com/api/manage.php)   * **Pricing**     * [Subscription Options &raquo;](https://chompthis.com/api/)     * [Cost Calculator &raquo;](https://chompthis.com/api/cost-calculator.php)   * **Guidelines**     * [Terms & License &raquo;](https://chompthis.com/api/terms.php)     * [Attribution &raquo;](https://chompthis.com/api/docs/attribution.php) 
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
    /// An object containing information on a specific food portion found in this item
    /// </summary>
    [DataContract]
    public partial class IngredientObjectPortions : IEquatable<IngredientObjectPortions>
    { 
        /// <summary>
        /// The unit used for measure (e.g. if mesure is 3 tsp, the unit is tsp)
        /// </summary>
        /// <value>The unit used for measure (e.g. if mesure is 3 tsp, the unit is tsp)</value>
        [DataMember(Name="measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// Comments that provide more specificity on the measure. For example, for a pizza measure the dissemination text might be 1 slice is 1/8th of a 14 inch pizza.
        /// </summary>
        /// <value>Comments that provide more specificity on the measure. For example, for a pizza measure the dissemination text might be 1 slice is 1/8th of a 14 inch pizza.</value>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Qualifier of the measure (e.g. related to food shape or form) (e.g. melted, crushed, diced)
        /// </summary>
        /// <value>Qualifier of the measure (e.g. related to food shape or form) (e.g. melted, crushed, diced)</value>
        [DataMember(Name="modifier")]
        public string Modifier { get; set; }

        /// <summary>
        /// The weight of the measure in grams
        /// </summary>
        /// <value>The weight of the measure in grams</value>
        [DataMember(Name="gram_weight")]
        public decimal? GramWeight { get; set; }

        /// <summary>
        /// The number of observations on which the measure is based
        /// </summary>
        /// <value>The number of observations on which the measure is based</value>
        [DataMember(Name="data_points")]
        public int? DataPoints { get; set; }

        /// <summary>
        /// Comments on any unusual aspects of the measure. Examples might includes caveats on the usage of a measure, or reasons why a measure gram weight is an unexpected value.
        /// </summary>
        /// <value>Comments on any unusual aspects of the measure. Examples might includes caveats on the usage of a measure, or reasons why a measure gram weight is an unexpected value.</value>
        [DataMember(Name="footnote")]
        public string Footnote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IngredientObjectPortions {\n");
            sb.Append("  MeasurementUnit: ").Append(MeasurementUnit).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  GramWeight: ").Append(GramWeight).Append("\n");
            sb.Append("  DataPoints: ").Append(DataPoints).Append("\n");
            sb.Append("  Footnote: ").Append(Footnote).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IngredientObjectPortions)obj);
        }

        /// <summary>
        /// Returns true if IngredientObjectPortions instances are equal
        /// </summary>
        /// <param name="other">Instance of IngredientObjectPortions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IngredientObjectPortions other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MeasurementUnit == other.MeasurementUnit ||
                    MeasurementUnit != null &&
                    MeasurementUnit.Equals(other.MeasurementUnit)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Modifier == other.Modifier ||
                    Modifier != null &&
                    Modifier.Equals(other.Modifier)
                ) && 
                (
                    GramWeight == other.GramWeight ||
                    GramWeight != null &&
                    GramWeight.Equals(other.GramWeight)
                ) && 
                (
                    DataPoints == other.DataPoints ||
                    DataPoints != null &&
                    DataPoints.Equals(other.DataPoints)
                ) && 
                (
                    Footnote == other.Footnote ||
                    Footnote != null &&
                    Footnote.Equals(other.Footnote)
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
                    if (MeasurementUnit != null)
                    hashCode = hashCode * 59 + MeasurementUnit.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Modifier != null)
                    hashCode = hashCode * 59 + Modifier.GetHashCode();
                    if (GramWeight != null)
                    hashCode = hashCode * 59 + GramWeight.GetHashCode();
                    if (DataPoints != null)
                    hashCode = hashCode * 59 + DataPoints.GetHashCode();
                    if (Footnote != null)
                    hashCode = hashCode * 59 + Footnote.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IngredientObjectPortions left, IngredientObjectPortions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IngredientObjectPortions left, IngredientObjectPortions right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
