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
    /// An object containing additional information on the countries where this item is found
    /// </summary>
    [DataContract]
    public partial class BrandedFoodObjectCountryDetails : IEquatable<BrandedFoodObjectCountryDetails>
    { 
        /// <summary>
        /// The number of countries where English is the country&#x27;s primary language
        /// </summary>
        /// <value>The number of countries where English is the country&#x27;s primary language</value>
        [DataMember(Name="english_speaking")]
        public int? EnglishSpeaking { get; set; }

        /// <summary>
        /// The number of countries where English is not the country&#x27;s primary language
        /// </summary>
        /// <value>The number of countries where English is not the country&#x27;s primary language</value>
        [DataMember(Name="non_english_speaking")]
        public int? NonEnglishSpeaking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectCountryDetails {\n");
            sb.Append("  EnglishSpeaking: ").Append(EnglishSpeaking).Append("\n");
            sb.Append("  NonEnglishSpeaking: ").Append(NonEnglishSpeaking).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BrandedFoodObjectCountryDetails)obj);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectCountryDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandedFoodObjectCountryDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectCountryDetails other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EnglishSpeaking == other.EnglishSpeaking ||
                    EnglishSpeaking != null &&
                    EnglishSpeaking.Equals(other.EnglishSpeaking)
                ) && 
                (
                    NonEnglishSpeaking == other.NonEnglishSpeaking ||
                    NonEnglishSpeaking != null &&
                    NonEnglishSpeaking.Equals(other.NonEnglishSpeaking)
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
                    if (EnglishSpeaking != null)
                    hashCode = hashCode * 59 + EnglishSpeaking.GetHashCode();
                    if (NonEnglishSpeaking != null)
                    hashCode = hashCode * 59 + NonEnglishSpeaking.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BrandedFoodObjectCountryDetails left, BrandedFoodObjectCountryDetails right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BrandedFoodObjectCountryDetails left, BrandedFoodObjectCountryDetails right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
